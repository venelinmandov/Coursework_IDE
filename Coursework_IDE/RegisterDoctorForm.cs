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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterDoctorForm_Load(object sender, EventArgs e)
        {
            
        }

        private void RegisterDoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
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
    }
}
