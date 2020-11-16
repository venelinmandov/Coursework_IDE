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
    public partial class RegisterDoctorForm : Form
    {
        Form1 mainForm;
        ConnectionManager connManager = new ConnectionManager();
        DoctorForm DoctorForm;
        public RegisterDoctorForm(Form1 mf)
        {
            InitializeComponent();
            mainForm = mf;
            mf.Hide();
        }

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
            if (textBoxSpec.Text == "")
            {
                error += "Please enter speciallity! \n";
            }
            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                error += "Please choose a gender! \n";
            }

            if (error != "")
                throw new Exception(error);

        }

        private void RegisterDoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            try
            {
                ValidateData();
                Doctor doctor = new Doctor();
                doctor.firstName = textBoxFName.Text;
                doctor.middleName = textBoxMName.Text;
                doctor.lastName = textBoxLName.Text;
                doctor.egn = textBoxEGN.Text;
                doctor.spec = textBoxSpec.Text;
                doctor.sex = (radioButtonMale.Checked ? radioButtonMale : radioButtonFemale).Text;
                connManager.RegisterDoctor(doctor);
                mainForm.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            



        }
    }
}
