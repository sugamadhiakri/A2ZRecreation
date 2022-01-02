
namespace A2ZRecreation
{
    partial class EmployeeUserControl
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
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteSelectedEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(42, 391);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(92, 23);
            this.AddEmployeeButton.TabIndex = 0;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(42, 38);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(515, 317);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // deleteSelectedEmployeeButton
            // 
            this.deleteSelectedEmployeeButton.Location = new System.Drawing.Point(422, 391);
            this.deleteSelectedEmployeeButton.Name = "deleteSelectedEmployeeButton";
            this.deleteSelectedEmployeeButton.Size = new System.Drawing.Size(135, 23);
            this.deleteSelectedEmployeeButton.TabIndex = 2;
            this.deleteSelectedEmployeeButton.Text = "Delete Selected Staff";
            this.deleteSelectedEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteSelectedEmployeeButton.Click += new System.EventHandler(this.deleteSelectedEmployeeButton_Click);
            // 
            // EmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteSelectedEmployeeButton);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.AddEmployeeButton);
            this.Name = "EmployeeUserControl";
            this.Size = new System.Drawing.Size(595, 450);
            this.Load += new System.EventHandler(this.EmployeeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button deleteSelectedEmployeeButton;
    }
}
