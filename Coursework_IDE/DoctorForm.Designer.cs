namespace Coursework_IDE
{
    partial class DoctorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelWellcome = new System.Windows.Forms.Label();
            this.ScheduleTable = new System.Windows.Forms.DataGridView();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWellcome
            // 
            this.labelWellcome.AutoSize = true;
            this.labelWellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelWellcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(252)))));
            this.labelWellcome.Location = new System.Drawing.Point(13, 59);
            this.labelWellcome.Name = "labelWellcome";
            this.labelWellcome.Size = new System.Drawing.Size(249, 39);
            this.labelWellcome.TabIndex = 0;
            this.labelWellcome.Text = "Wellcome Dr. ";
            // 
            // ScheduleTable
            // 
            this.ScheduleTable.AllowUserToAddRows = false;
            this.ScheduleTable.AllowUserToDeleteRows = false;
            this.ScheduleTable.AllowUserToResizeColumns = false;
            this.ScheduleTable.AllowUserToResizeRows = false;
            this.ScheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hour,
            this.Lastname,
            this.EGN});
            this.ScheduleTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ScheduleTable.Location = new System.Drawing.Point(49, 71);
            this.ScheduleTable.MultiSelect = false;
            this.ScheduleTable.Name = "ScheduleTable";
            this.ScheduleTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ScheduleTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ScheduleTable.Size = new System.Drawing.Size(344, 324);
            this.ScheduleTable.TabIndex = 1;
            this.ScheduleTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Hour
            // 
            this.Hour.HeaderText = "Hour";
            this.Hour.Name = "Hour";
            this.Hour.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // EGN
            // 
            this.EGN.HeaderText = "EGN";
            this.EGN.Name = "EGN";
            this.EGN.ReadOnly = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(83, 410);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(268, 20);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ScheduleTable);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(37, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 485);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Schedule";
            // 
            // buttonExport
            // 
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.Location = new System.Drawing.Point(16, 448);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(141, 23);
            this.buttonExport.TabIndex = 22;
            this.buttonExport.Text = "Export to Excell";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWellcome);
            this.Name = "DoctorForm";
            this.Text = "Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWellcome;
        private System.Windows.Forms.DataGridView ScheduleTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGN;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExport;
    }
}