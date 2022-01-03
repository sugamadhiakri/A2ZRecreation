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
    public partial class AdminSignupForm : Form
    {
        XmlSerializer serializer;
        List<User> users;
        public AdminSignupForm()
        {
            InitializeComponent();
            users = new List<User>();
            serializer = new XmlSerializer(typeof(List<User>));
        }

        private void ContinueAsAdminButton_Click(object sender, EventArgs e)
        {
            string adminUsername = usernameTextBox.Text.Trim();
            string adminPassword = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            // check if the username or password is empty
            if(adminUsername.Length == 0 || adminPassword.Length == 0)
            {
                MessageBox.Show("Username or Password field cannot be left empty", "Error - Invalid Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the passwords match
            if (!adminPassword.Equals(confirmPassword))
            {
                MessageBox.Show("Your Passwords doesn't match, please have the same password", "Error - Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Store admin details in a file

            FileStream usersFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Users.xml", FileMode.Create, FileAccess.Write);
            User admin = new User();
            admin.Username = adminUsername;
            admin.Password = adminPassword;
            admin.Type = UserType.ADMIN;
            users.Add(admin);
            serializer.Serialize(usersFile, users);
            usersFile.Close();

            // open login form
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
