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
    public partial class LoginForm : Form
    {
        XmlSerializer  serializer;
        List<User> users;
        public LoginForm()
        {
            InitializeComponent();
            users = new List<User>();
            serializer = new XmlSerializer(typeof(List<User>));
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // get texts
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            // Error on either of them are empty
            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Username or Password field cannot be left empty", "Error - Invalid Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the username exists
            FileStream usersFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Users.xml", FileMode.Open, FileAccess.Read);
            users = (List<User>)serializer.Deserialize(usersFile);
            usersFile.Close();

            foreach(User user in users)
            {
                if(user.Username == username && user.Password == password)
                {
                    Form mainform;
                    if (user.Type == UserType.ADMIN)
                    {
                        mainform = new AdminForm(user);
                    } else
                    {
                        mainform = new StaffForm(user);
                    }

                    this.Hide();
                    mainform.ShowDialog();
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
