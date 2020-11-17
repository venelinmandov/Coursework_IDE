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
        List<Patient> patients; //Vsichki pacienti
        List<Medicine> meds; //Vsichki lekarstva
        List<Medicine> prescription; //Predpisanite lekarstva
        ConnectionManager connectionManager = new ConnectionManager();
        Appointment appointment;//Chasyt za rediktirane

        //Constructor
        public EditAppointmentForm(Appointment app)
        {
            InitializeComponent();
            appointment = app;
            UpdatePatients();
            UpdateMedication();
            UpdateMedsList();
            labelTitle.Text += " for " + appointment.date.Hour + ":00"; //Zaglaven label

            for(int i = 0; i< patients.Count; i++)
            {
                if (patients[i].id == appointment.patientId)
                    comboBoxPatient.SelectedIndex = i;
            }

            if(appointment.diagnosis != null)
                textBoxDiagnosis.Text = appointment.diagnosis;
            
        }


        //Izvlichane na pacientite ot bazata danni i оpresnqvane na "comboBoxPatient".
        void UpdatePatients()
        {
            patients = connectionManager.GetPatients();
            comboBoxPatient.Items.Clear();
            comboBoxPatient.Items.AddRange(patients.ToArray());
            
        }

        //Izvlichane na lekarstvata ot bazata danni i оpresnqvane na "comboBoxMedication".
        void UpdateMedication()
        {
            meds = connectionManager.GetMedication();
            comboBoxMedication.Items.Clear();
            comboBoxMedication.Items.AddRange(meds.ToArray());


        }
        //Izvlichane na predpisanite lekarstva ot bazata danni i оpresnqvane na "listPrescription".
        void UpdateMedsList()
        {
            prescription = connectionManager.GetMedicationByAppointment(appointment.id);
            listPrescription.Items.Clear();
            listPrescription.Items.AddRange(prescription.ToArray());
            if (listPrescription.Items.Count > 0)
                listPrescription.SelectedIndex = 0;
        }


        //Pokazvane na formata za registraciq na pacient
        private void ButtonAddPatient_Click(object sender, EventArgs e)
        {
            NewPatientForm newPatientForm = new NewPatientForm();
            newPatientForm.ShowDialog();
            UpdatePatients();
        }

        //Izprashtane na SQL zaqvka za reaktirane na chasa i zatvarqne na formata
        private void buttonSave_Click(object sender, EventArgs e)
        {
            connectionManager.ChangeAppointment(appointment);
            this.Dispose();
        }

        //Ako "textBoxDiagnosis" nqma tekst, teksta stava "Optional", i sled 
        //tova ako stojnostta mu e takava na stojnostta na diagnozata se prisvoqva null.
        private void textBoxDiagnosis_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text == "")
                textBoxDiagnosis.Text = "Optional";
            if (textBoxDiagnosis.Text != "Optional")
                appointment.diagnosis = textBoxDiagnosis.Text;
            else
                appointment.diagnosis = null;
        }

        //Promqna na stojnostta na id-to na pacienta v appointment-a v zavisimos ot
        //izbraniq pacient ot "comboBoxPatient".
        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointment.patientId = patients[comboBoxPatient.SelectedIndex].id;
        }

        //Dobavqne na nov zapis v bazata danni za predpisano lekarstvo
        private void ButtonAddMedication_Click(object sender, EventArgs e)
        {
            connectionManager.AddMedicine(appointment, meds[comboBoxMedication.SelectedIndex]);
            UpdateMedsList();
        }

        //Premahvane na zapis v bazata danni za predpisno lekarstvo
        private void buttonRemoveMedication_Click(object sender, EventArgs e)
        {
            if (listPrescription.Items.Count != 0)
            {
                connectionManager.RemoveMedicine(appointment, prescription[listPrescription.SelectedIndex]);
                UpdateMedsList();
            }
            
        }

        //Premahvane na zapisa na tekushtiq zapisan chas v bazata danni i zatvarqna na formata
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            connectionManager.RemoveAppointment(appointment);
            this.Dispose();
        }

        //Otvarqne na informacionna forma za pacienta
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            PatientInfoForm patientInfoForm = new PatientInfoForm(patients[comboBoxPatient.SelectedIndex]);
            patientInfoForm.ShowDialog();
        }
    }
}
