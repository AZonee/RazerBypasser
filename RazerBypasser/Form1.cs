using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RazerBypasser
{
    public partial class Form1 : Form
    {
        public string DevicesDirectory = "ERROR";

        public Form1()
        {
            InitializeComponent();

            // Makes sure that the dependant programs exist.
            if (!Directory.Exists(@"C:\ProgramData\Razer\Razer Central\Accounts"))
            {
                MessageBox.Show(
                  "Please have Razer Central installed and an account logged in.",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation
                );
                Environment.Exit(1);
            }

            // Checks for a logged in user, takes the first. Unsure how to handle multiple accounts atm, so we're going with a default here.
            // TODO: Fix that ^ (Support multiple active accounts.)
            try
            {
                DevicesDirectory = Directory.GetDirectories(@"C:\ProgramData\Razer\Razer Central\Accounts").Where(x => x.Contains("RZR_")).ToList().First();
            }
            catch (Exception e)
            {
                LogTxt.AppendText("Error, account directory not found: " + e.Message + "\n(Do you have Razer Central installed and logged into?)");
                return;
            }

            // Goes one directory deeper -
            // I'm not sure if this is consistant. TBD.
            DevicesDirectory = Directory.GetDirectories(DevicesDirectory).Where(x=> !x.EndsWith("Razer Central") || !x.EndsWith("Shared")).ToList().First() + @"\Devices";

            LogTxt.AppendText("Device Directory: " + DevicesDirectory);

        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            LogTxt.AppendText("\nFeature not yet implemented.");
        }
    }
}
