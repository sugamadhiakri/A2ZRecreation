using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace A2ZRecreation
{
    public partial class EmployeeUserControl : UserControl
    {
        
        XmlSerializer serializer;
        public EmployeeUserControl()
        {
            InitializeComponent();
            serializer = new XmlSerializer(typeof(List<User>));
            employeeDataGridView.ReadOnly = true;
        }

        private void EmployeeUserControl_Load(object sender, EventArgs e)
        {
            UpdateTable();

               
        }

        private void UpdateTable()
        {
            // Read all the users that are staff
            FileStream usersFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Users.xml", FileMode.Open, FileAccess.Read);
            List<User> allUsers = (List<User>)serializer.Deserialize(usersFile);
            usersFile.Close();
            // add only staff users
            List<User> staffUsers = new List<User>();
            foreach (User user in allUsers)
            {
                if (user.Type == UserType.STAFF)
                {
                    staffUsers.Add(user);
                }
            }

            employeeDataGridView.DataSource = staffUsers;
            employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            UpdateTable();
        }
    }
}
