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
    public partial class Form1 : Form
    {
        RegisterDoctorForm regForm;
        DoctorForm drForm;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            regForm = new RegisterDoctorForm(this);
            regForm.ShowDialog();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
            ConnectionManager connectionManager = new ConnectionManager();
            try
            {
                Doctor doctor;
                doctor = connectionManager.GetDoctor(textBoxEGN.Text);
                drForm = new DoctorForm(this, doctor);
                drForm.Show();

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There is no doctor with that EGN!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
