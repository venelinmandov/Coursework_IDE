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
        List<Patient> patients; //Spisyk sys vsichki pacienti
        Doctor doctor; //Doktoryt za koito se zapisva chas
        DateTime date; //Data i chas na zapisvaniq chas

        //Constructor
        public CreateAppointmentForm(DateTime dt, Doctor doc)
        {
            InitializeComponent();
            UpdatePatients();
            doctor = doc;
            date = dt;
            labelTitle.Text += " for " + date.Hour + ":00";
        }


        //Izvlichane na pacientite ot bazata danni i opresnqvane
        //na "comboBoxPatient" s tqh
        void UpdatePatients()
        {
            patients = connectionManager.GetPatients();
            comboBoxPatient.Items.Clear();
            comboBoxPatient.Items.AddRange(patients.ToArray());
        }


        //Otvarqne na forma za registrirane na nov pacient
        //i opresnqvane na "comboBoxPatient" kato se zapazi izbraniq
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int selected = comboBoxPatient.SelectedIndex;
            NewPatientForm newPatientForm = new NewPatientForm();
            newPatientForm.ShowDialog();
            UpdatePatients();
            comboBoxPatient.SelectedIndex = selected;
           
        }

        //Dobavqne na nov zapis v bazata danni za zapisan chas
        //i zatvarqne na formata
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

        //Pokazvane na forma za informaciq na izbraniq pacient
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
