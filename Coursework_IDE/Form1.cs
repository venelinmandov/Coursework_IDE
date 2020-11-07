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
        Appointment[] appointments;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            regForm = new RegisterDoctorForm(this);
            regForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            drForm = new DoctorForm(this,textBoxEGN.Text);
            drForm.Show();
        }
    }
}
