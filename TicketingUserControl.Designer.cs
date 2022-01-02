
namespace A2ZRecreation
{
    partial class TicketingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NoOfPeopleNumeric = new System.Windows.Forms.NumericUpDown();
            this.TicketType = new System.Windows.Forms.ComboBox();
            this.Duration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenerateTicketButton = new System.Windows.Forms.Button();
            this.DayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPeopleNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticketing";
            // 
            // NoOfPeopleNumeric
            // 
            this.NoOfPeopleNumeric.Location = new System.Drawing.Point(90, 214);
            this.NoOfPeopleNumeric.Name = "NoOfPeopleNumeric";
            this.NoOfPeopleNumeric.Size = new System.Drawing.Size(120, 20);
            this.NoOfPeopleNumeric.TabIndex = 1;
            // 
            // TicketType
            // 
            this.TicketType.FormattingEnabled = true;
            this.TicketType.Location = new System.Drawing.Point(243, 214);
            this.TicketType.Name = "TicketType";
            this.TicketType.Size = new System.Drawing.Size(121, 21);
            this.TicketType.TabIndex = 2;
            // 
            // Duration
            // 
            this.Duration.FormattingEnabled = true;
            this.Duration.Location = new System.Drawing.Point(400, 213);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(121, 21);
            this.Duration.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. Of People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ticket Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duration";
            // 
            // GenerateTicketButton
            // 
            this.GenerateTicketButton.Location = new System.Drawing.Point(264, 327);
            this.GenerateTicketButton.Name = "GenerateTicketButton";
            this.GenerateTicketButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateTicketButton.TabIndex = 7;
            this.GenerateTicketButton.Text = "Generate Ticket";
            this.GenerateTicketButton.UseVisualStyleBackColor = true;
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(90, 103);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(32, 13);
            this.DayLabel.TabIndex = 8;
            this.DayLabel.Text = "Day: ";
            // 
            // TicketingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.GenerateTicketButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.TicketType);
            this.Controls.Add(this.NoOfPeopleNumeric);
            this.Controls.Add(this.label1);
            this.Name = "TicketingUserControl";
            this.Size = new System.Drawing.Size(595, 450);
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPeopleNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NoOfPeopleNumeric;
        private System.Windows.Forms.ComboBox TicketType;
        private System.Windows.Forms.ComboBox Duration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateTicketButton;
        private System.Windows.Forms.Label DayLabel;
    }
}
