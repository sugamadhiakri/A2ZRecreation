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
        FileStream ratesFile;
        XmlSerializer serializer;
        public RatesUserControl()
        {
            InitializeComponent();

            // Set proper max values to the number fields.
            oneHrRate.Maximum = int.MaxValue;
            twoHrRate.Maximum = int.MaxValue;
            fiveHrRate.Maximum = int.MaxValue;
            oneDayRate.Maximum = int.MaxValue;

            // setup serializer
            serializer = new XmlSerializer(typeof(Rate));

        }

        private void RatesUserControl_Load(object sender, EventArgs e)
        {
            // Check if the Rates.xml file exists
            Rate currentRate;
            // Using the Try/Catch as conditional statement. 
            try
            { // If the rates file exists
                currentRate = Rate.GetCurrentRates();
            }
            catch (Exception err)
            { // if the rates file doesn't exist
                ratesFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Rates.xml", FileMode.Create, FileAccess.Write);
                currentRate = Rate.GetDefaultRates();
                serializer.Serialize(ratesFile, currentRate);
                ratesFile.Close();
            }


            // Set the values to the rates field.
            oneHrRate.Value = (int) currentRate.OneHr;
            twoHrRate.Value = currentRate.TwoHr;
            fiveHrRate.Value = currentRate.FiveHr;
            oneDayRate.Value = currentRate.OneDay;
            childDiscount.Value = currentRate.ChildDiscount;
            fiveDiscount.Value = currentRate.FiveDiscount;
            tenDiscount.Value = currentRate.TenDiscount;
            weekendCharge.Value = currentRate.WeekendCharge;

        }

        private void RatesSaveButton_Click(object sender, EventArgs e)
        {

            // Extract all the new rates
            Rate newRate = new Rate();
            newRate.OneHr = (int)oneHrRate.Value;
            newRate.TwoHr = (int)twoHrRate.Value;
            newRate.FiveHr = (int)fiveHrRate.Value;
            newRate.OneDay = (int)oneDayRate.Value;
            newRate.ChildDiscount = (int)childDiscount.Value;
            newRate.FiveDiscount = (int)fiveDiscount.Value;
            newRate.TenDiscount = (int)tenDiscount.Value;
            newRate.WeekendCharge = (int)weekendCharge.Value;

            // Serialize the new rates into the file.
            ratesFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Rates.xml", FileMode.Create, FileAccess.Write);
            ratesFile.SetLength(0);
            serializer.Serialize(ratesFile, newRate);
            ratesFile.Close();
        }
    }
}
