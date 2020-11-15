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
        Doctor doctor;
        ConnectionManager connMgr = new ConnectionManager();
        
        Form1 mainForm;
        public DoctorForm(Form1 mf, Doctor d)
        {
            InitializeComponent();
            mainForm = mf;
            mf.Hide();
            doctor = d;
            labelWellcome.Text += doctor.lastName;
            UpdateSchedule();


        }

        private void UpdateSchedule()
        {
            ScheduleTable.Rows.Clear();
            List<Appointment> appointments = connMgr.GetAppointments(dateTimePicker.Value, doctor.id);
            Object[] row = new Object[0];

            for (int i = 0; i < 10; i++)
            {
                if(appointments.Count != 0)
                {
                    for (int j = 0; j < appointments.Count; j++)
                    {
                        
                        if (appointments[j].date.Hour == i + 8)
                            {
                                Patient patient = connMgr.GetPatient(appointments[j].patientId);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Appointment> appointments = connMgr.GetAppointments(dateTimePicker.Value, doctor.id);

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
            DateTime dateTime = dateTimePicker.Value;
            
            dateTime = dateTime.AddHours(ScheduleTable.CurrentCell.RowIndex + 8);
            CreateAppointmentForm createAppointmentForm = new CreateAppointmentForm(dateTime, doctor);
            createAppointmentForm.ShowDialog();
            UpdateSchedule();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void DoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet worksheet = (Excel.Worksheet) excelApp.ActiveSheet;
            
            worksheet.Cells[2, "B"] = "Schedule of " + doctor.firstName + " " + doctor.lastName;
            worksheet.Cells[4, "C"] = "Time";
            worksheet.Cells[4, "D"] = "Lastname";
            worksheet.Cells[4, "E"] = "EGN";
            int i;
            for (i = 0; i < ScheduleTable.Rows.Count; i++)
            {
                worksheet.Cells[i+5, "C"] = ScheduleTable.Rows[i].Cells[0].Value;
                worksheet.Cells[i+5, "D"] = ScheduleTable.Rows[i].Cells[1].Value;
                worksheet.Cells[i+5, "E"] = ScheduleTable.Rows[i].Cells[2].Value;
            }
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
