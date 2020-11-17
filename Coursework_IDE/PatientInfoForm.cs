using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace Coursework_IDE
{
    public partial class PatientInfoForm : Form
    {
        Patient patient; //Tekushtiq pacient

        //Konstruktor
        public PatientInfoForm(Patient p)
        {
            InitializeComponent();
            patient = p;
            labelFM.Text = patient.firstName;
            labelMN.Text = patient.middleName;
            labelLN.Text = patient.lastName;
            labelEGN.Text = patient.egn;
            labelGender.Text = patient.sex;
            labelBirthday.Text = patient.birthday.Date.ToString("dd/MM/yyyy");

        }

        //Eksportirane v Word
        private void buttonExport_Click(object sender, EventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();
            var wordApp = new Word.Application();
            wordApp.Visible = true;
            wordApp.Documents.Add();
            Word.Document doc = wordApp.ActiveDocument;
            object missing = System.Reflection.Missing.Value;
            List<Appointment> appointments = connectionManager.GetAppointementsInLast30Days(patient);

            Word.Paragraph par = doc.Content.Paragraphs.Add(ref missing);
            //Zaglaven red na otcheta i formatiraneto mu
            par.Range.Text = "Information for patient No " + patient.id;
            par.Range.Font.Size = 26;
            par.Range.Font.Name = "Bahnschrift";
            par.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            par.Range.InsertParagraphAfter();

            //Redove s informaciq za pacienta i formatiraneto im
            string[,] data = new string[,]
                {
                    {"Firstname",labelFM.Text },
                    {"Middlename",labelMN.Text },
                    {"Last Name", labelLN.Text },
                    {"EGN",labelEGN.Text },
                    {"Gender",labelGender.Text },
                    {"Birthday",labelBirthday.Text }
                };


            
            for (int i = 0; i < data.GetLength(0); i++)
            {
                
                par.Range.Font.Size = 14;
                par.Range.Text = data[i, 0] + ": " + data[i, 1];       
                par.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                par.Range.InsertParagraphAfter();

            }

            //Zaglaven red za informaciata za diagnozi prez poslednite 30 dena i formatiraneto mu
            par.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            par.Range.Font.Size = 20;
            par.Range.Text = "Diagnoses in last 30 days:";
            par.Range.InsertParagraphAfter();
            par.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            par.Range.Font.Size = 12;

            //informaciata za diagnozi prez poslednite 30 dena i formatirane
            if (appointments.Count == 0)
                par.Range.Text = "Patient was not diagnosed in the last 30 days.";
            else
            {
                for (int i = 0; i < appointments.Count; i++)
                {
                    par.Range.Text = "On " + appointments[i].date.ToString("dd/MM/yyyy") + " patient was diagnosed with " + appointments[i].diagnosis + ".";
                    par.Range.InsertParagraphAfter();
                }
            }

            //Dobavqne na footer s data
            foreach (Word.Section section in doc.Sections)
            {
                Word.Range footer = section.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footer.Text = DateTime.Now.ToString();

            }
        }
    }
}
