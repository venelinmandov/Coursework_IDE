namespace Coursework_IDE
{
    partial class RegisterDoctorForm
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
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxMName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxEGN = new System.Windows.Forms.TextBox();
            this.textBoxSpec = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelMName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelEGN = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(108, 135);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(141, 20);
            this.textBoxFName.TabIndex = 0;
            // 
            // textBoxMName
            // 
            this.textBoxMName.Location = new System.Drawing.Point(108, 181);
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.Size = new System.Drawing.Size(141, 20);
            this.textBoxMName.TabIndex = 1;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(108, 227);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(141, 20);
            this.textBoxLName.TabIndex = 2;
            // 
            // textBoxEGN
            // 
            this.textBoxEGN.Location = new System.Drawing.Point(341, 135);
            this.textBoxEGN.Name = "textBoxEGN";
            this.textBoxEGN.Size = new System.Drawing.Size(149, 20);
            this.textBoxEGN.TabIndex = 3;
            // 
            // textBoxSpec
            // 
            this.textBoxSpec.Location = new System.Drawing.Point(341, 178);
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.Size = new System.Drawing.Size(149, 20);
            this.textBoxSpec.TabIndex = 4;
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
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(341, 227);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(149, 43);
            this.groupBoxGender.TabIndex = 7;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(27, 135);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(52, 13);
            this.labelFName.TabIndex = 8;
            this.labelFName.Text = "Firstname";
            this.labelFName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.Location = new System.Drawing.Point(27, 181);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(67, 13);
            this.labelMName.TabIndex = 9;
            this.labelMName.Text = "Middle name";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(27, 227);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(53, 13);
            this.labelLName.TabIndex = 10;
            this.labelLName.Text = "Lastname";
            // 
            // labelEGN
            // 
            this.labelEGN.AutoSize = true;
            this.labelEGN.Location = new System.Drawing.Point(278, 135);
            this.labelEGN.Name = "labelEGN";
            this.labelEGN.Size = new System.Drawing.Size(30, 13);
            this.labelEGN.TabIndex = 11;
            this.labelEGN.Text = "EGN";
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Location = new System.Drawing.Point(278, 178);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(52, 13);
            this.labelSpec.TabIndex = 12;
            this.labelSpec.Text = "Speciality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Register new doctor";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(29, 306);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(219, 23);
            this.buttonRegister.TabIndex = 14;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // RegisterDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 357);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelEGN);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.textBoxSpec);
            this.Controls.Add(this.textBoxEGN);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxMName);
            this.Controls.Add(this.textBoxFName);
            this.Name = "RegisterDoctorForm";
            this.Text = "RegisterDoctorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterDoctorForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterDoctorForm_Load);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxMName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxEGN;
        private System.Windows.Forms.TextBox textBoxSpec;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelMName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelEGN;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegister;
    }
}