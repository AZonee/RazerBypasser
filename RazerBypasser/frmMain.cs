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
using System.Xml.Linq;


// NOTE TO ANYONE READING THIS CODE -
// I'm a kid, I haven't ever been taught how to code, or taken an online course, or anything
// I'm just kinda figuring out as I go along
// So the practices used are _probably_ pretty bad.
//
// sorry lmao


namespace RazerBypasser
{
    public partial class frmMain : Form
    {
        public string DevicesDirectory = "ERROR";
        public List<Device> Devices = new List<Device>();

        public frmMain()
        {
            InitializeComponent();
            Devices.Add(new Device { Name = "TEST OBJECT", Path = "FAKE PATH" });
            bxDeviceSelect.Items.Add("TEST OBJECT");


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

                MessageBox.Show(
                    "Error, account directory not found: " + e.Message + "\n(Do you have Razer Central installed and logged into?)",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
                Environment.Exit(1);
                return; // why is this return here even lmao 
            }

            // Goes one directory deeper -
            // I'm not sure if this is consistant. TBD.
            DevicesDirectory = Directory.GetDirectories(DevicesDirectory).Where(x=> !x.EndsWith("Razer Central") || !x.EndsWith("Shared")).ToList().First() + @"\Devices";

            // Gets names of available devices and adds them to a list
            foreach (string DevDir in Directory.GetDirectories(DevicesDirectory))
            {
                var xml = XDocument.Load(DevDir + @"\DeviceInfo.xml");

                Device device = new Device
                {
                    Name = xml.Descendants("Name").First().Value,
                    Path = DevDir
                };

                // Find and add profiles
                foreach (string xmlDoc in Directory.GetFiles(DevDir + @"\Profiles"))
                {
                    Profile profile = new Profile();
                    profile.ID = xmlDoc.Split('\\').Last().Replace(".xml","");
                    profile.Name = XDocument.Load(xmlDoc).Descendants("Name").First().Value;
                    Console.WriteLine("PROFILE ID = " + profile.ID + "; PROFILE NAME = " + profile.Name);
                    device.Profiles.Add(profile);
                }

                if (!(device.Name == "Chroma Connect"))
                {
                    Devices.Add(device);
                    bxDeviceSelect.Items.Add(device.Name);
                }
            }
        }

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            if (bxDeviceSelect.SelectedItem == null) return;
            ucProfileSelect c = new ucProfileSelect(Devices.Where(x=> x.Name == (string)bxDeviceSelect.SelectedItem).First())
            {
                Top  = 0,
                Left = 0
            };
            pnlTopRight.Controls.Clear();
            pnlTopRight.Controls.Add(c);
        }
    }
}