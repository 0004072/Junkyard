using System.Drawing;
namespace EmployeeInfo
{
    partial class EmpInfo
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.optGender = new System.Windows.Forms.GroupBox();
            this.optGenFemale = new System.Windows.Forms.RadioButton();
            this.optGenMale = new System.Windows.Forms.RadioButton();
            this.chkDoesSmoke = new System.Windows.Forms.CheckBox();
            this.clrHouseColor = new System.Windows.Forms.ColorDialog();
            this.txtHouseColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHairColor = new System.Windows.Forms.ComboBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.optGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthDate.Location = new System.Drawing.Point(132, 73);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // optGender
            // 
            this.optGender.Controls.Add(this.optGenFemale);
            this.optGender.Controls.Add(this.optGenMale);
            this.optGender.Location = new System.Drawing.Point(132, 109);
            this.optGender.Name = "optGender";
            this.optGender.Size = new System.Drawing.Size(200, 31);
            this.optGender.TabIndex = 5;
            this.optGender.TabStop = false;
            // 
            // optGenFemale
            // 
            this.optGenFemale.AutoSize = true;
            this.optGenFemale.Location = new System.Drawing.Point(78, 9);
            this.optGenFemale.Name = "optGenFemale";
            this.optGenFemale.Size = new System.Drawing.Size(59, 17);
            this.optGenFemale.TabIndex = 1;
            this.optGenFemale.TabStop = true;
            this.optGenFemale.Text = "Female";
            this.optGenFemale.UseVisualStyleBackColor = true;
            // 
            // optGenMale
            // 
            this.optGenMale.AutoSize = true;
            this.optGenMale.Location = new System.Drawing.Point(7, 9);
            this.optGenMale.Name = "optGenMale";
            this.optGenMale.Size = new System.Drawing.Size(48, 17);
            this.optGenMale.TabIndex = 0;
            this.optGenMale.TabStop = true;
            this.optGenMale.Text = "Male";
            this.optGenMale.UseVisualStyleBackColor = true;
            // 
            // chkDoesSmoke
            // 
            this.chkDoesSmoke.AutoSize = true;
            this.chkDoesSmoke.Location = new System.Drawing.Point(132, 160);
            this.chkDoesSmoke.Name = "chkDoesSmoke";
            this.chkDoesSmoke.Size = new System.Drawing.Size(100, 17);
            this.chkDoesSmoke.TabIndex = 6;
            this.chkDoesSmoke.Text = "Do you smoke?";
            this.chkDoesSmoke.UseVisualStyleBackColor = true;
            // 
            // clrHouseColor
            // 
            this.clrHouseColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // txtHouseColor
            // 
            this.txtHouseColor.AcceptsReturn = true;
            this.txtHouseColor.Location = new System.Drawing.Point(132, 192);
            this.txtHouseColor.Name = "txtHouseColor";
            this.txtHouseColor.ReadOnly = true;
            this.txtHouseColor.Size = new System.Drawing.Size(100, 20);
            this.txtHouseColor.TabIndex = 8;
            this.txtHouseColor.Text = "#ffffff";
            this.txtHouseColor.Click += new System.EventHandler(this.txtHouseColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "House Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hair Color";
            // 
            // cmbHairColor
            // 
            this.cmbHairColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHairColor.FormattingEnabled = true;
            this.cmbHairColor.Location = new System.Drawing.Point(132, 226);
            this.cmbHairColor.Name = "cmbHairColor";
            this.cmbHairColor.Size = new System.Drawing.Size(121, 21);
            this.cmbHairColor.TabIndex = 10;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(77, 271);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(98, 23);
            this.btnAddEmp.TabIndex = 11;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(192, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(282, 271);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export List";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // EmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 358);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.cmbHairColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHouseColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkDoesSmoke);
            this.Controls.Add(this.optGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 397);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(456, 397);
            this.Name = "EmpInfo";
            this.Text = "Employee Information";
            this.optGender.ResumeLayout(false);
            this.optGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox optGender;
        private System.Windows.Forms.RadioButton optGenFemale;
        private System.Windows.Forms.RadioButton optGenMale;
        private System.Windows.Forms.CheckBox chkDoesSmoke;
        private System.Windows.Forms.ColorDialog clrHouseColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHouseColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHairColor;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExport;
    }
}