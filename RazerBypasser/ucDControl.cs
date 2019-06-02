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
            lblTest.Text = device.Name + "; " + device.Path;
        }

        private void ucDControl_Load(object sender, EventArgs e)
        {

        }
    }
}
