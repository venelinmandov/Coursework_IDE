namespace Coursework_IDE
{
    partial class NewPatientForm
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelEGN = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelMName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxEGN = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxMName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(47, 298);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(219, 23);
            this.buttonRegister.TabIndex = 27;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "New patient";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(279, 178);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(45, 13);
            this.labelBirthday.TabIndex = 25;
            this.labelBirthday.Text = "Birthday";
            // 
            // labelEGN
            // 
            this.labelEGN.AutoSize = true;
            this.labelEGN.Location = new System.Drawing.Point(279, 135);
            this.labelEGN.Name = "labelEGN";
            this.labelEGN.Size = new System.Drawing.Size(30, 13);
            this.labelEGN.TabIndex = 24;
            this.labelEGN.Text = "EGN";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(28, 227);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(53, 13);
            this.labelLName.TabIndex = 23;
            this.labelLName.Text = "Lastname";
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.Location = new System.Drawing.Point(28, 181);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(67, 13);
            this.labelMName.TabIndex = 22;
            this.labelMName.Text = "Middle name";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(28, 135);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(52, 13);
            this.labelFName.TabIndex = 21;
            this.labelFName.Text = "Firstname";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(342, 227);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(149, 43);
            this.groupBoxGender.TabIndex = 20;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(71, 20);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 6;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 5;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxEGN
            // 
            this.textBoxEGN.Location = new System.Drawing.Point(342, 135);
            this.textBoxEGN.Name = "textBoxEGN";
            this.textBoxEGN.Size = new System.Drawing.Size(200, 20);
            this.textBoxEGN.TabIndex = 18;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(109, 227);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(141, 20);
            this.textBoxLName.TabIndex = 17;
            // 
            // textBoxMName
            // 
            this.textBoxMName.Location = new System.Drawing.Point(109, 181);
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.Size = new System.Drawing.Size(141, 20);
            this.textBoxMName.TabIndex = 16;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(109, 135);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(141, 20);
            this.textBoxFName.TabIndex = 15;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(342, 178);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 28;
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 357);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelEGN);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.textBoxEGN);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxMName);
            this.Controls.Add(this.textBoxFName);
            this.Name = "NewPatientForm";
            this.Text = "NewPatientForm";
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelEGN;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelMName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textBoxEGN;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxMName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}