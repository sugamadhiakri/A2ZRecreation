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

        private void employeeUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
