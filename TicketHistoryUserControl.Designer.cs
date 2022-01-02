
namespace A2ZRecreation
{
    partial class TicketHistoryUserControl
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
            this.TicketHistoryTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TicketHistoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket History";
            // 
            // TicketHistoryTable
            // 
            this.TicketHistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketHistoryTable.Location = new System.Drawing.Point(3, 80);
            this.TicketHistoryTable.Name = "TicketHistoryTable";
            this.TicketHistoryTable.Size = new System.Drawing.Size(589, 322);
            this.TicketHistoryTable.TabIndex = 1;
            // 
            // TicketHistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TicketHistoryTable);
            this.Controls.Add(this.label1);
            this.Name = "TicketHistoryUserControl";
            this.Size = new System.Drawing.Size(595, 450);
            this.Load += new System.EventHandler(this.TicketHistoryUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketHistoryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TicketHistoryTable;
    }
}
