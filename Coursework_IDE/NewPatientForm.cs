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
    public partial class NewPatientForm : Form
    {

        ConnectionManager connectionManager = new ConnectionManager();
        public NewPatientForm()
        {
         
            InitializeComponent();
        }

        //Validaciq na vyvedenite danni
        void ValidateData()
        {
            String error = "";
            if (textBoxFName.Text == "")
            {
                error += "Please enter firstname! \n";
            }
            if (textBoxMName.Text == "")
            {
                error += "Please enter middle name! \n";
            }
            if (textBoxLName.Text == "")
            {
                error += "Please enter lastname! \n";
            }
            if (textBoxEGN.Text.Length < 10)
            {
                if (textBoxEGN.Text == "")
                    error += "Please enter EGN! \n";
                else
                    error += "Invalid EGN! \n";
            }
            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                error += "Please choose a gender! \n";
            }

            if (error != "")
                throw new Exception(error);
        }
      

        //Ako dannite sa validirani uspeshno se suzdava nov zapis v bazata danni za lekar.
        //V protiven sluchai izvejda validacionni greshki s MessageBox.
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateData();
                Patient patient = new Patient();
                patient.firstName = textBoxFName.Text;
                patient.middleName = textBoxMName.Text;
                patient.lastName = textBoxLName.Text;
                patient.egn = textBoxEGN.Text;
                patient.birthday = dateTimePicker.Value;
                patient.sex = (radioButtonMale.Checked ? radioButtonMale : radioButtonFemale).Text;
                connectionManager.RegisterPatient(patient);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
