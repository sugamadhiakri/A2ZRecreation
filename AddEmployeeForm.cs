using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace A2ZRecreation
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            // get data from textbox
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            // display error on empty fields
            if(username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Username or Password field cannot be left empty", "Error - Invalid Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Extract all the available users
            FileStream usersFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Users.xml", FileMode.Open, FileAccess.ReadWrite);
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            List<User> users = (List<User>)serializer.Deserialize(usersFile);
            
            // check if the username already exists
            foreach(User usr in users)
            {
                if(usr.Username.Equals(username))
                {
                    MessageBox.Show("Operation Failed", "Error - Username must be unique. " + username + " already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            User user = new User();
            user.Username = username;
            user.Password = password;
            user.Type = UserType.STAFF;
            users.Add(user);
            usersFile.SetLength(0);
            serializer.Serialize(usersFile, users);
            usersFile.Close();
            this.Close();
        }
    }
}
