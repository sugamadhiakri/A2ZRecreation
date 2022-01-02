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
    public partial class RatesUserControl : UserControl
    {
        public RatesUserControl()
        {
            InitializeComponent();
        }

        private void RatesUserControl_Load(object sender, EventArgs e)
        {
            // Check if the Rates.xml file exists
            Rate currentRate;
            FileStream ratesFile;
            XmlSerializer serializer = new XmlSerializer(typeof(Rate));
            // Using the Try/Catch as conditional statement. 
            try
            { // If the rates file exists
                ratesFile = new FileStream("Rates.xml", FileMode.Open, FileAccess.Read);
                currentRate = (Rate)serializer.Deserialize(ratesFile);
                ratesFile.Close();
            } catch (Exception e)
            { // if the rates file doesn't exist
                ratesFile = new FileStream("Rates.xml", FileMode.Create, FileAccess.Write);
                currentRate = Rate.GetDefaultRates();
                serializer.Serialize(ratesFile, currentRate);
                ratesFile.Close();
            }



            // Set the values to the rates field.
            
        }

        
    }
}
