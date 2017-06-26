namespace TemperatureMonitor
{
    partial class frmTempMon
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
            this.btnRainy = new System.Windows.Forms.Button();
            this.btnSunny = new System.Windows.Forms.Button();
            this.btnAdHoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRainy
            // 
            this.btnRainy.Location = new System.Drawing.Point(24, 17);
            this.btnRainy.Name = "btnRainy";
            this.btnRainy.Size = new System.Drawing.Size(75, 23);
            this.btnRainy.TabIndex = 0;
            this.btnRainy.Text = "Rainy";
            this.btnRainy.UseVisualStyleBackColor = true;
            // 
            // btnSunny
            // 
            this.btnSunny.Location = new System.Drawing.Point(24, 56);
            this.btnSunny.Name = "btnSunny";
            this.btnSunny.Size = new System.Drawing.Size(75, 23);
            this.btnSunny.TabIndex = 1;
            this.btnSunny.Text = "Sunny";
            this.btnSunny.UseVisualStyleBackColor = true;
            // 
            // btnAdHoc
            // 
            this.btnAdHoc.Location = new System.Drawing.Point(24, 94);
            this.btnAdHoc.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnAdHoc.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnAdHoc.Name = "btnAdHoc";
            this.btnAdHoc.Size = new System.Drawing.Size(75, 23);
            this.btnAdHoc.TabIndex = 2;
            this.btnAdHoc.Text = "Ad-Hoc";
            this.btnAdHoc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Temperature :";
            // 
            // lblCurrentTemp
            // 
            this.lblCurrentTemp.AutoSize = true;
            this.lblCurrentTemp.Location = new System.Drawing.Point(107, 67);
            this.lblCurrentTemp.Name = "lblCurrentTemp";
            this.lblCurrentTemp.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentTemp.TabIndex = 4;
            // 
            // frmTempMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 131);
            this.Controls.Add(this.lblCurrentTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdHoc);
            this.Controls.Add(this.btnSunny);
            this.Controls.Add(this.btnRainy);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(245, 170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(245, 170);
            this.Name = "frmTempMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRainy;
        private System.Windows.Forms.Button btnSunny;
        private System.Windows.Forms.Button btnAdHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentTemp;
    }
}

