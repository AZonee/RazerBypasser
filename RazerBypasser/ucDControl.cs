using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace RazerBypasser
{
    public partial class ucDControl : UserControl
    {
        private Device device;

        public ucDControl(Device d)
        {
            device = d;
            InitializeComponent();
            Console.WriteLine("INITALIZED DEVICE:\n" +
                "DEVICE NAME: " + device.Name + "\n" + 
                "DEVICE PATH: " + device.Path + "\n" + 
                "PROFILE NAME: " + device.Profile.Name + "\n" + 
                "PROFILE ID: " + device.Profile.ID);

            bxSelectKey.Items.AddRange(new string[] { "Macro key 1", "Macro key 2", "Macro key 3", "Macro key 4", "Macro key 5" });
            bxSelectInput.Items.AddRange(new string[] { "F13", "F14", "F15", "F16", "F17", "F18", "F19", "F20", "F21", "F22", "F23", "F24" });
        }

        private void btnSelectKey_Click(object sender, EventArgs e)
        {
            if (bxSelectInput.SelectedItem == null || bxSelectKey.SelectedItem == null)
            {
                MessageBox.Show("Select some stuff first my guy.", "we've got selections for a reason smh");
                return;
            }
            string DKMNUMBER = bxSelectKey.SelectedItem.ToString().Split(' ').Last();

            XDocument xdc = XDocument.Load(device.Path + @"\Features\" + device.Profile.ID + @"\762555eb-82f2-4fa6-9741-e009d579f188.xml");
            Console.WriteLine(device.Path + @"\Features\" + device.Profile.ID + @"\762555eb-82f2-4fa6-9741-e009d579f188.xml");
            var allmaps = xdc.Elements().First().Elements().First().Elements();
            var DKM = allmaps.Where(x=> x.Elements("DKMInput").Count() != 0 && x.Elements("IsHyperShift").Count() == 0 && x.Element("DKMInput").Value.StartsWith("DKM_M_0" + DKMNUMBER));
            // DKM is now the element that we wish to edit.
            // Now to edit it...

        }
    }
}
