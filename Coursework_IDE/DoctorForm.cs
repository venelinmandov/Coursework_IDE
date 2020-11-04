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
    public partial class DoctorForm : Form
    {
        Doctor doctor;
        ConnectionManager connMgr = new ConnectionManager();
        Form1 mainForm;
        public DoctorForm(Form1 mf, String egn)
        {
            InitializeComponent();
            mainForm = mf;
            mf.Hide();
            doctor = connMgr.GetDoctor(egn); 
            labelWellcome.Text += doctor.lastName;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
