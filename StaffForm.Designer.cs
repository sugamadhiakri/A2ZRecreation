
namespace A2ZRecreation
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.TicketingButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.TicketHistoryButton = new System.Windows.Forms.Button();
            this.ticketHistoryUserControl1 = new A2ZRecreation.TicketHistoryUserControl();
            this.reportUserControl1 = new A2ZRecreation.ReportUserControl();
            this.ticketingUserControl1 = new A2ZRecreation.TicketingUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.TicketHistoryButton);
            this.panel1.Controls.Add(this.ReportButton);
            this.panel1.Controls.Add(this.TicketingButton);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(81, 106);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(35, 13);
            this.username.TabIndex = 1;
            this.username.Text = "label1";
            // 
            // TicketingButton
            // 
            this.TicketingButton.Location = new System.Drawing.Point(48, 192);
            this.TicketingButton.Name = "TicketingButton";
            this.TicketingButton.Size = new System.Drawing.Size(89, 23);
            this.TicketingButton.TabIndex = 2;
            this.TicketingButton.Text = "Ticketing";
            this.TicketingButton.UseVisualStyleBackColor = true;
            this.TicketingButton.Click += new System.EventHandler(this.TicketingButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(48, 256);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(89, 23);
            this.ReportButton.TabIndex = 3;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // TicketHistoryButton
            // 
            this.TicketHistoryButton.Location = new System.Drawing.Point(48, 318);
            this.TicketHistoryButton.Name = "TicketHistoryButton";
            this.TicketHistoryButton.Size = new System.Drawing.Size(89, 23);
            this.TicketHistoryButton.TabIndex = 4;
            this.TicketHistoryButton.Text = "Ticket History";
            this.TicketHistoryButton.UseVisualStyleBackColor = true;
            this.TicketHistoryButton.Click += new System.EventHandler(this.TicketHistoryButton_Click);
            // 
            // ticketHistoryUserControl1
            // 
            this.ticketHistoryUserControl1.Location = new System.Drawing.Point(206, 0);
            this.ticketHistoryUserControl1.Name = "ticketHistoryUserControl1";
            this.ticketHistoryUserControl1.Size = new System.Drawing.Size(595, 450);
            this.ticketHistoryUserControl1.TabIndex = 3;
            // 
            // reportUserControl1
            // 
            this.reportUserControl1.Location = new System.Drawing.Point(206, 0);
            this.reportUserControl1.Name = "reportUserControl1";
            this.reportUserControl1.Size = new System.Drawing.Size(595, 450);
            this.reportUserControl1.TabIndex = 2;
            // 
            // ticketingUserControl1
            // 
            this.ticketingUserControl1.Location = new System.Drawing.Point(206, 0);
            this.ticketingUserControl1.Name = "ticketingUserControl1";
            this.ticketingUserControl1.Size = new System.Drawing.Size(595, 450);
            this.ticketingUserControl1.TabIndex = 1;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticketHistoryUserControl1);
            this.Controls.Add(this.reportUserControl1);
            this.Controls.Add(this.ticketingUserControl1);
            this.Controls.Add(this.panel1);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TicketHistoryButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button TicketingButton;
        private System.Windows.Forms.Label username;
        private TicketingUserControl ticketingUserControl1;
        private ReportUserControl reportUserControl1;
        private TicketHistoryUserControl ticketHistoryUserControl1;
    }
}