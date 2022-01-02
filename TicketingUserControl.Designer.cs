
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
            this.NoOfPeople = new System.Windows.Forms.NumericUpDown();
            this.TicketTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DurationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenerateTicketButton = new System.Windows.Forms.Button();
            this.DayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPeople)).BeginInit();
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
            // NoOfPeople
            // 
            this.NoOfPeople.Location = new System.Drawing.Point(90, 214);
            this.NoOfPeople.Name = "NoOfPeople";
            this.NoOfPeople.Size = new System.Drawing.Size(120, 20);
            this.NoOfPeople.TabIndex = 1;
            // 
            // TicketTypeComboBox
            // 
            this.TicketTypeComboBox.FormattingEnabled = true;
            this.TicketTypeComboBox.Items.AddRange(new object[] {
            "Adult",
            "Child"});
            this.TicketTypeComboBox.Location = new System.Drawing.Point(243, 214);
            this.TicketTypeComboBox.Name = "TicketTypeComboBox";
            this.TicketTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TicketTypeComboBox.TabIndex = 2;
            this.TicketTypeComboBox.Text = "Select One";
            // 
            // DurationComboBox
            // 
            this.DurationComboBox.FormattingEnabled = true;
            this.DurationComboBox.Items.AddRange(new object[] {
            "1Hr",
            "2Hr",
            "5Hr",
            "1D"});
            this.DurationComboBox.Location = new System.Drawing.Point(400, 213);
            this.DurationComboBox.Name = "DurationComboBox";
            this.DurationComboBox.Size = new System.Drawing.Size(121, 21);
            this.DurationComboBox.TabIndex = 3;
            this.DurationComboBox.Text = "Select One";
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
            this.GenerateTicketButton.Click += new System.EventHandler(this.GenerateTicketButton_Click);
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
            this.Controls.Add(this.DurationComboBox);
            this.Controls.Add(this.TicketTypeComboBox);
            this.Controls.Add(this.NoOfPeople);
            this.Controls.Add(this.label1);
            this.Name = "TicketingUserControl";
            this.Size = new System.Drawing.Size(595, 450);
            this.Load += new System.EventHandler(this.TicketingUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NoOfPeople;
        private System.Windows.Forms.ComboBox TicketTypeComboBox;
        private System.Windows.Forms.ComboBox DurationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateTicketButton;
        private System.Windows.Forms.Label DayLabel;
    }
}
