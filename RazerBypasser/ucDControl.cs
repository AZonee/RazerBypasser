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
    public partial class ucDControl : UserControl
    {
        public ucDControl(Device device)
        {
            InitializeComponent();
            lblTest.Text = "DEVICE NAME: " + device.Name + "\n" + 
                "DEVICE PATH: " + device.Path + "\n" + 
                "PROFILE NAME: " + device.Profile.Name + "\n" + 
                "PROFILE ID: " + device.Profile.ID;
        }
    }
}
