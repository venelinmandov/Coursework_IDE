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
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAddPatient = new System.Windows.Forms.Button();
            this.labelMedication = new System.Windows.Forms.Label();
            this.ButtonAddMedication = new System.Windows.Forms.Button();
            this.comboBoxMedication = new System.Windows.Forms.ComboBox();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listPrescription = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRemoveMedication = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(252)))));
            this.labelTitle.Location = new System.Drawing.Point(22, 55);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(297, 39);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Edit Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Patient";
            // 
            // ButtonAddPatient
            // 
            this.ButtonAddPatient.Location = new System.Drawing.Point(493, 215);
            this.ButtonAddPatient.Name = "ButtonAddPatient";
            this.ButtonAddPatient.Size = new System.Drawing.Size(64, 23);
            this.ButtonAddPatient.TabIndex = 29;
            this.ButtonAddPatient.Text = "Add";
            this.ButtonAddPatient.UseVisualStyleBackColor = true;
            this.ButtonAddPatient.Click += new System.EventHandler(this.ButtonAddPatient_Click);
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
            this.ButtonAddMedication.Click += new System.EventHandler(this.ButtonAddMedication_Click);
            // 
            // comboBoxMedication
            // 
            this.comboBoxMedication.FormattingEnabled = true;
            this.comboBoxMedication.Location = new System.Drawing.Point(212, 147);
            this.comboBoxMedication.Name = "comboBoxMedication";
            this.comboBoxMedication.Size = new System.Drawing.Size(240, 21);
            this.comboBoxMedication.TabIndex = 33;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(212, 217);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(240, 21);
            this.comboBoxPatient.TabIndex = 34;
            this.comboBoxPatient.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatient_SelectedIndexChanged);
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
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.Location = new System.Drawing.Point(212, 283);
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(240, 20);
            this.textBoxDiagnosis.TabIndex = 36;
            this.textBoxDiagnosis.Text = "Optional";
            this.textBoxDiagnosis.TextChanged += new System.EventHandler(this.textBoxDiagnosis_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(29, 348);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "Done";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(139, 348);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(158, 23);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Remove appointment";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listPrescription
            // 
            this.listPrescription.FormattingEnabled = true;
            this.listPrescription.Location = new System.Drawing.Point(678, 104);
            this.listPrescription.Name = "listPrescription";
            this.listPrescription.Size = new System.Drawing.Size(185, 238);
            this.listPrescription.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Prescription:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonRemoveMedication
            // 
            this.buttonRemoveMedication.Location = new System.Drawing.Point(678, 348);
            this.buttonRemoveMedication.Name = "buttonRemoveMedication";
            this.buttonRemoveMedication.Size = new System.Drawing.Size(185, 23);
            this.buttonRemoveMedication.TabIndex = 41;
            this.buttonRemoveMedication.Text = "Remove selected";
            this.buttonRemoveMedication.UseVisualStyleBackColor = true;
            this.buttonRemoveMedication.Click += new System.EventHandler(this.buttonRemoveMedication_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(563, 215);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(61, 23);
            this.buttonInfo.TabIndex = 42;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // EditAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 383);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonRemoveMedication);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listPrescription);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDiagnosis);
            this.Controls.Add(this.DiagnosisLabel);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.comboBoxMedication);
            this.Controls.Add(this.ButtonAddMedication);
            this.Controls.Add(this.labelMedication);
            this.Controls.Add(this.ButtonAddPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditAppointmentForm";
            this.Text = "Edit Appointment";
            this.Load += new System.EventHandler(this.EditAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAddPatient;
        private System.Windows.Forms.Label labelMedication;
        private System.Windows.Forms.Button ButtonAddMedication;
        private System.Windows.Forms.ComboBox comboBoxMedication;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listPrescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRemoveMedication;
        private System.Windows.Forms.Button buttonInfo;
    }
}