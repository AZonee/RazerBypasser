using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RazerBypasser
{
    public partial class ucProfileSelect : UserControl
    {

        private Device device;

        public ucProfileSelect(Device d)
        {
            InitializeComponent();
            device = d;
            foreach (Profile profile in device.Profiles)
            {
                bxProfileSelect.Items.Add(profile.Name);
            }
        }

        private void btnProfileSelect_Click(object sender, EventArgs e)
        {
            if (bxProfileSelect.SelectedItem == null) return;
            device.Profile = device.Profiles.Where(x => x.Name == (string)bxProfileSelect.SelectedItem).First();
            ucDControl c = new ucDControl(device)
            {
                Top = 0,
                Left = 0
            };
            Parent.Parent.Controls.Find("pnlDeviceControl", false).First().Controls.Clear();
            Parent.Parent.Controls.Find("pnlDeviceControl", false).First().Controls.Add(c);
        }
    }
}
