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
    public partial class EditAppointmentForm : Form
    {
        List<Patient> patients;
        List<Medicine> meds;
        List<Medicine> prescription;
        ConnectionManager connectionManager = new ConnectionManager();
        Appointment appointment;

        public EditAppointmentForm(Appointment app)
        {
            InitializeComponent();
            appointment = app;
            UpdatePatients();
            UpdateMedication();
            UpdateMedsList();
            labelTitle.Text += " for " + appointment.date.Hour + ":00";

            for(int i = 0; i< patients.Count; i++)
            {
                if (patients[i].id == appointment.patientId)
                    comboBoxPatient.SelectedIndex = i;
            }

            if(appointment.diagnosis != null)
                textBoxDiagnosis.Text = appointment.diagnosis;
            
        }



        void UpdatePatients()
        {
            patients = connectionManager.GetPatients();
            comboBoxPatient.Items.Clear();
            comboBoxPatient.Items.AddRange(patients.ToArray());
            
        }

        void UpdateMedication()
        {
            meds = connectionManager.GetMedication();
            comboBoxMedication.Items.Clear();
            comboBoxMedication.Items.AddRange(meds.ToArray());

        }
        void UpdateMedsList()
        {
            prescription = connectionManager.GetMedicationByAppointment(appointment.id);
            listPrescription.Items.Clear();
            listPrescription.Items.AddRange(prescription.ToArray());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddPatient_Click(object sender, EventArgs e)
        {
            NewPatientForm newPatientForm = new NewPatientForm();
            newPatientForm.ShowDialog();
            UpdatePatients();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            connectionManager.ChangeAppointment(appointment);
            this.Dispose();
        }

        private void textBoxDiagnosis_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text == "")
                textBoxDiagnosis.Text = "Optional";
            if (textBoxDiagnosis.Text != "Optional")
                appointment.diagnosis = textBoxDiagnosis.Text;
            else
                appointment.diagnosis = null;
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointment.patientId = patients[comboBoxPatient.SelectedIndex].id;
        }

        private void ButtonAddMedication_Click(object sender, EventArgs e)
        {
            connectionManager.AddMedicine(appointment, meds[comboBoxMedication.SelectedIndex]);
            UpdateMedsList();
        }

        private void buttonRemoveMedication_Click(object sender, EventArgs e)
        {
            if (listPrescription.Items.Count != 0)
            {
                connectionManager.RemoveMedicine(appointment, prescription[listPrescription.SelectedIndex]);
                UpdateMedsList();
            }
            
        }
    }
}
