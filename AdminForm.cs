using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2ZRecreation
{
    public partial class AdminForm : Form
    {
        User loggedInUser;
        public AdminForm(User user)
        {
            this.loggedInUser = user;
            InitializeComponent();
            loggedInUsername.Text = loggedInUser.Username;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ratesUserControl1.Hide();
            reportUserControl1.Hide();
            
            employeeUserControl1.Show();
            employeeUserControl1.BringToFront();

        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            ratesUserControl1.Hide();
            reportUserControl1.Hide();

            employeeUserControl1.Show();
            employeeUserControl1.BringToFront();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ratesUserControl1.Hide();
            employeeUserControl1.Hide();

            reportUserControl1.Show();
            reportUserControl1.BringToFront();
        }

        private void ratesButton_Click(object sender, EventArgs e)
        {
            employeeUserControl1.Hide();
            reportUserControl1.Hide();

            ratesUserControl1.Show();
            ratesUserControl1.BringToFront();
        }
    }
}
