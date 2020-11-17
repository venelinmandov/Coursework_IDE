using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Coursework_IDE
{
    public partial class DoctorForm : Form
    {
        Doctor doctor; //Tekyshtiq lekar
        ConnectionManager connectionManager = new ConnectionManager();
        
        Form1 mainForm;  //Pazi refenciq kym obekta na purvata forma

        //Constructor
        public DoctorForm(Form1 mf, Doctor d)
        {
            InitializeComponent();
            mainForm = mf;
            mf.Hide();
            doctor = d;
            labelWellcome.Text += doctor.lastName; //Zaglaven label
            dateTimePicker.Value = DateTime.Now.Date; //Zadavane na tekushtata data na "dateTimePicker"
            UpdateSchedule();
        }

        //Izvlichane na chasovete za zadadenata data ot bazata danni i opresnqvane na "ScheduleTable"
        private void UpdateSchedule()
        {
            ScheduleTable.Rows.Clear();
            List<Appointment> appointments = connectionManager.GetAppointments(dateTimePicker.Value, doctor.id);
            Object[] row = new Object[0];

            //Obhojdane na redovete na tablicata (za chasove ot 8:00 do 17:00)
            for (int i = 0; i < 10; i++)
            {
                if(appointments.Count != 0)
                {
                    //Obhojdane na spisyka s chasove i pri suvpadenie na syotvetniq red se zapisva
                    //informaciq za zapisaniq chas i tozi chas se maha ot spisyka, ako nqma syvpadenie 
                    //se izpisva FREE v poslednite dve kletki
                    for (int j = 0; j < appointments.Count; j++)
                    {
                        
                        if (appointments[j].date.Hour == i + 8)
                            {
                                Patient patient = connectionManager.GetPatient(appointments[j].patientId);
                                row = new Object[] { (i + 8).ToString() + ":00", patient.lastName, patient.egn };
                                appointments.RemoveAt(j);
                                break;
                            }
                            row = new Object[] { (i + 8).ToString() + ":00", "FREE", "FREE" };
                    }
                }
                else
                    row = new Object[] { (i + 8).ToString() + ":00", "FREE", "FREE" };
                ScheduleTable.Rows.Add(row);
            }
        }

        //Otvarqne na forma za syzdavane/redktirane na chas
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Appointment> appointments = connectionManager.GetAppointments(dateTimePicker.Value, doctor.id);

            //Tursene na zapis v "appointments" za izpraniq red. Ako nameri otvarq forma za redktirane.
            for (int i = 0; i < appointments.Count; i++)
            {
                if (appointments[i].date.Hour == ScheduleTable.CurrentCell.RowIndex + 8)
                {
                    EditAppointmentForm editAppointmentForm = new EditAppointmentForm(appointments[i]);
                    editAppointmentForm.ShowDialog();
                    UpdateSchedule();
                    return;
                }
            }
            //Ako nqma nameren otvarq forma za syzdavane na "appointment".
            DateTime dateTime = dateTimePicker.Value;
            dateTime = dateTime.AddHours(ScheduleTable.CurrentCell.RowIndex + 8);
            CreateAppointmentForm createAppointmentForm = new CreateAppointmentForm(dateTime, doctor);
            createAppointmentForm.ShowDialog();

            //Opresnqvane na grafika
            UpdateSchedule();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Opresnqvane na grafika
            UpdateSchedule();
        }

        private void DoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Pokazvane na pyrvata forma
            mainForm.Show();
        }

        //Eksportirane na grafika v Excel
        private void buttonExport_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet worksheet = (Excel.Worksheet) excelApp.ActiveSheet;
            
            //Zaglavie na otcheta
            worksheet.Cells[2, "B"] = "Schedule of Dr. " + doctor.firstName + " " + doctor.lastName;
            //Zaglaven red na tablicata
            worksheet.Cells[4, "C"] = "Time";
            worksheet.Cells[4, "D"] = "Lastname";
            worksheet.Cells[4, "E"] = "EGN";
            int i;
            //Popylvane na redovete
            for (i = 0; i < ScheduleTable.Rows.Count; i++)
            {
                worksheet.Cells[i+5, "C"] = ScheduleTable.Rows[i].Cells[0].Value;
                worksheet.Cells[i+5, "D"] = ScheduleTable.Rows[i].Cells[1].Value;
                worksheet.Cells[i+5, "E"] = ScheduleTable.Rows[i].Cells[2].Value;
            }
            //Dobavqne na border na zaglavniq red i na samata tablica
            worksheet.Range["C4", "E4"].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            worksheet.Range["C4", "E4"].Borders.Weight = Excel.XlBorderWeight.xlMedium;
            worksheet.Range["C4", "E4"].Font.Bold = true;
            worksheet.Range["C5", "E" + (i+4)].Borders.Weight = Excel.XlLineStyle.xlContinuous;
            worksheet.Range["C5", "E" + (i+4)].Borders.Weight = Excel.XlBorderWeight.xlThin;
            worksheet.Cells[i+6, "B"] = "Date: " + dateTimePicker.Value.ToString("dd/MM/yyyy");
            worksheet.Columns[3].AutoFit();
            worksheet.Columns[4].AutoFit();
            worksheet.Columns[5].AutoFit();
        }

    }
}
