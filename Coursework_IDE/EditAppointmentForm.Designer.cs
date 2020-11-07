namespace Coursework_IDE
{
    partial class EditAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAddPatient = new System.Windows.Forms.Button();
            this.labelMedication = new System.Windows.Forms.Label();
            this.ButtonAddMedication = new System.Windows.Forms.Button();
            this.MedicationComboBox = new System.Windows.Forms.ComboBox();
            this.PatientcomboBox = new System.Windows.Forms.ComboBox();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.DiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "Edit Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Patients";
            // 
            // ButtonAddPatient
            // 
            this.ButtonAddPatient.Location = new System.Drawing.Point(493, 215);
            this.ButtonAddPatient.Name = "ButtonAddPatient";
            this.ButtonAddPatient.Size = new System.Drawing.Size(131, 23);
            this.ButtonAddPatient.TabIndex = 29;
            this.ButtonAddPatient.Text = "Add";
            this.ButtonAddPatient.UseVisualStyleBackColor = true;
            // 
            // labelMedication
            // 
            this.labelMedication.AutoSize = true;
            this.labelMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedication.Location = new System.Drawing.Point(23, 145);
            this.labelMedication.Name = "labelMedication";
            this.labelMedication.Size = new System.Drawing.Size(145, 31);
            this.labelMedication.TabIndex = 30;
            this.labelMedication.Text = "Medication";
            // 
            // ButtonAddMedication
            // 
            this.ButtonAddMedication.Location = new System.Drawing.Point(493, 145);
            this.ButtonAddMedication.Name = "ButtonAddMedication";
            this.ButtonAddMedication.Size = new System.Drawing.Size(131, 23);
            this.ButtonAddMedication.TabIndex = 32;
            this.ButtonAddMedication.Text = "Add";
            this.ButtonAddMedication.UseVisualStyleBackColor = true;
            // 
            // MedicationComboBox
            // 
            this.MedicationComboBox.FormattingEnabled = true;
            this.MedicationComboBox.Location = new System.Drawing.Point(212, 147);
            this.MedicationComboBox.Name = "MedicationComboBox";
            this.MedicationComboBox.Size = new System.Drawing.Size(240, 21);
            this.MedicationComboBox.TabIndex = 33;
            // 
            // PatientcomboBox
            // 
            this.PatientcomboBox.FormattingEnabled = true;
            this.PatientcomboBox.Location = new System.Drawing.Point(212, 217);
            this.PatientcomboBox.Name = "PatientcomboBox";
            this.PatientcomboBox.Size = new System.Drawing.Size(240, 21);
            this.PatientcomboBox.TabIndex = 34;
            // 
            // DiagnosisLabel
            // 
            this.DiagnosisLabel.AutoSize = true;
            this.DiagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisLabel.Location = new System.Drawing.Point(23, 273);
            this.DiagnosisLabel.Name = "DiagnosisLabel";
            this.DiagnosisLabel.Size = new System.Drawing.Size(134, 31);
            this.DiagnosisLabel.TabIndex = 35;
            this.DiagnosisLabel.Text = "Diagnosis";
            // 
            // DiagnosisTextBox
            // 
            this.DiagnosisTextBox.Location = new System.Drawing.Point(212, 283);
            this.DiagnosisTextBox.Name = "DiagnosisTextBox";
            this.DiagnosisTextBox.Size = new System.Drawing.Size(240, 20);
            this.DiagnosisTextBox.TabIndex = 36;
            this.DiagnosisTextBox.Text = "Optional";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(29, 348);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(139, 348);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(158, 23);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Remove appointment";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // EditAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.DiagnosisTextBox);
            this.Controls.Add(this.DiagnosisLabel);
            this.Controls.Add(this.PatientcomboBox);
            this.Controls.Add(this.MedicationComboBox);
            this.Controls.Add(this.ButtonAddMedication);
            this.Controls.Add(this.labelMedication);
            this.Controls.Add(this.ButtonAddPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditAppointmentForm";
            this.Text = "EditAppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAddPatient;
        private System.Windows.Forms.Label labelMedication;
        private System.Windows.Forms.Button ButtonAddMedication;
        private System.Windows.Forms.ComboBox MedicationComboBox;
        private System.Windows.Forms.ComboBox PatientcomboBox;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.TextBox DiagnosisTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}