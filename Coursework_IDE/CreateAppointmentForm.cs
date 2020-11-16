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
    public partial class CreateAppointmentForm : Form
    {
        ConnectionManager connectionManager = new ConnectionManager();
        List<Patient> patients;
        Doctor doctor;
        DateTime date;
        public CreateAppointmentForm(DateTime dt, Doctor doc)
        {
            InitializeComponent();
            UpdatePatients();
            doctor = doc;
            date = dt;
            labelTitle.Text += " for " + date.Hour + ":00";
        }

        void UpdatePatients()
        {
            patients = connectionManager.GetPatients();
            comboBoxPatient.Items.Clear();
            comboBoxPatient.Items.AddRange(patients.ToArray());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewPatientForm newPatientForm = new NewPatientForm();
            newPatientForm.ShowDialog();
            UpdatePatients();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxPatient.Text != "")
            {
                Appointment appointment = new Appointment();
                appointment.patientId = patients[comboBoxPatient.SelectedIndex].id;
                appointment.doctorId = doctor.id;
                appointment.date = date;

                connectionManager.NewApointment(appointment);
                this.Dispose();
            }
            
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxPatient.Text != "")
            {
                PatientInfoForm patientInfoForm = new PatientInfoForm(patients[comboBoxPatient.SelectedIndex]);
                patientInfoForm.ShowDialog();
            }
           
        }
    }
}
