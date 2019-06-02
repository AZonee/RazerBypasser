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
        public ucProfileSelect(Device device)
        {
            InitializeComponent();
            foreach (Profile profile in device.Profiles)
            {
                bxProfileSelect.Items.Add(profile.Name);
            }
        }

        private void btnProfileSelect_Click(object sender, EventArgs e)
        {
            if (bxProfileSelect.SelectedItem == null) return;
            ucProfileSelect c = new ucProfileSelect(Devices.Where(x => x.Name == (string)bxDeviceSelect.SelectedItem).First())
            {
                Top = 0,
                Left = 0
            };
            frmMain..Controls.Clear();
            pnlDeviceControl.Controls.Add(c);
        }
    }
}
