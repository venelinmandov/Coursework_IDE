using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_IDE
{
    public partial class DoctorForm : Form
    {
        Doctor doctor;
        ConnectionManager connMgr = new ConnectionManager();
        
        Form1 mainForm;
        public DoctorForm(Form1 mf, String egn)
        {
            InitializeComponent();
            mainForm = mf;
            mf.Hide();
            doctor = connMgr.GetDoctor(egn); 
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
    }
}
