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
        RegisterDoctorForm regForm; //Registracionna forma za lekar
        DoctorForm drForm; //Forma s grafika na lekarq
        public Form1()
        {
            InitializeComponent();
            
        }

        //Otvarqne na registacionna forma
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            regForm = new RegisterDoctorForm(this);
            regForm.ShowDialog();
        }

        //Otvarqne na forma s grafika na lekarq
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //Ako syshtestvuva lekyr s takova EGN se otvarq formata
            //imache izvejda MessageBox e greshka
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
