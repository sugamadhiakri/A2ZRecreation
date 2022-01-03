
namespace A2ZRecreation
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratesButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.loggedInUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeUserControl1 = new A2ZRecreation.EmployeeUserControl();
            this.ratesUserControl1 = new A2ZRecreation.RatesUserControl();
            this.reportUserControl1 = new A2ZRecreation.ReportUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.ratesButton);
            this.panel1.Controls.Add(this.reportButton);
            this.panel1.Controls.Add(this.employeeButton);
            this.panel1.Controls.Add(this.loggedInUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 450);
            this.panel1.TabIndex = 0;
            // 
            // ratesButton
            // 
            this.ratesButton.Location = new System.Drawing.Point(64, 275);
            this.ratesButton.Name = "ratesButton";
            this.ratesButton.Size = new System.Drawing.Size(75, 23);
            this.ratesButton.TabIndex = 4;
            this.ratesButton.Text = "Rates";
            this.ratesButton.UseVisualStyleBackColor = true;
            this.ratesButton.Click += new System.EventHandler(this.RatesButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(64, 212);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Location = new System.Drawing.Point(64, 156);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(75, 23);
            this.employeeButton.TabIndex = 2;
            this.employeeButton.Text = "Employee";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // loggedInUsername
            // 
            this.loggedInUsername.AutoSize = true;
            this.loggedInUsername.Location = new System.Drawing.Point(81, 97);
            this.loggedInUsername.Name = "loggedInUsername";
            this.loggedInUsername.Size = new System.Drawing.Size(35, 13);
            this.loggedInUsername.TabIndex = 1;
            this.loggedInUsername.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // employeeUserControl1
            // 
            this.employeeUserControl1.Location = new System.Drawing.Point(205, 0);
            this.employeeUserControl1.Name = "employeeUserControl1";
            this.employeeUserControl1.Size = new System.Drawing.Size(595, 450);
            this.employeeUserControl1.TabIndex = 1;
            // 
            // ratesUserControl1
            // 
            this.ratesUserControl1.Location = new System.Drawing.Point(205, 0);
            this.ratesUserControl1.Name = "ratesUserControl1";
            this.ratesUserControl1.Size = new System.Drawing.Size(595, 450);
            this.ratesUserControl1.TabIndex = 2;
            // 
            // reportUserControl1
            // 
            this.reportUserControl1.Location = new System.Drawing.Point(205, 0);
            this.reportUserControl1.Name = "reportUserControl1";
            this.reportUserControl1.Size = new System.Drawing.Size(595, 450);
            this.reportUserControl1.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportUserControl1);
            this.Controls.Add(this.ratesUserControl1);
            this.Controls.Add(this.employeeUserControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loggedInUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ratesButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button employeeButton;
        private EmployeeUserControl employeeUserControl1;
        private RatesUserControl ratesUserControl1;
        private ReportUserControl reportUserControl1;
    }
}