using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2ZRecreation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(CheckAdminAlreadyExists())
            {
                Application.Run(new LoginForm());
            } else
            {
                Application.Run(new AdminSignupForm());
            }
        }

        static bool CheckAdminAlreadyExists()
        {
            try
            {
                FileStream checkAdmin = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Users.xml", FileMode.Open, FileAccess.Read);
                checkAdmin.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
