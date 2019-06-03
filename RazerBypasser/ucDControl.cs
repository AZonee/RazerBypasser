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


            // WARNING: Trash code below. I'm really bad at XML parsing so this is the abomination you get.
            XDocument xdc = XDocument.Load(device.Path + @"\Features\" + device.Profile.ID + @"\762555eb-82f2-4fa6-9741-e009d579f188.xml");
            var allmaps = xdc.Elements().First().Elements().First().Elements();
            var DKM = allmaps.Where(x=> x.Elements("DKMInput").Count() != 0 && x.Elements("IsHyperShift").Count() == 0 && x.Element("DKMInput").Value.StartsWith("DKM_M_0" + DKMNUMBER)).First();

            // The variable DKM is now the element that we wish to edit.
            // Tags needed - IsDefault, MappingGroup, InputType, DKMInput, Keygroup(KeyAssignment(Scancode, Virtual Key))
            // e.g.
            // <Mapping>
            //   <IsDefault>false</IsDefault>
            //   <MappingGroup>Keyboard</MappingGroup>
            //   <InputType>DKMInput</InputType>
            //   <DKMInput>DKM_M_01</DKMInput>
            //   <KeyGroup>
            //     <KeyAssignment>
            //       <Scancode>109</Scancode>
            //       <VirtualKey>133</VirtualKey>
            //     </KeyAssignment>
            //   </KeyGroup>
            // </Mapping>
            //
            //
            // DEFAULT DKM:
            // <Mapping>
            //   <MappingGroup>Disable</MappingGroup>
            //   <InputType>DKMInput</InputType>
            //   <DKMInput>DKM_M_05</DKMInput>
            // </Mapping>

            // Creates the Element
            DKM.Add(new XElement("IsDefault", "false"));
            DKM.Element("MappingGroup").Value = "Keyboard";
            XElement KG = new XElement("KeyGroup",
                new XElement("KeyAssignment",
                new XElement[] {
                    new XElement("Scancode", Key.GetKey(bxSelectInput.SelectedItem.ToString()).Scancode),
                    new XElement("VirtualKey", Key.GetKey(bxSelectInput.SelectedItem.ToString()).VirtualKey)}));
            DKM.Add(KG);
            // Stages and saves the full document.
            DialogResult dr = MessageBox.Show("Changing " + bxSelectKey.SelectedItem.ToString() + " to " + bxSelectInput.SelectedItem.ToString() + ".\nIs this correct?", "Make Change", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                DKM.Document.Save(device.Path + @"\Features\" + device.Profile.ID + @"\762555eb-82f2-4fa6-9741-e009d579f188.xml");
            }
            else if (dr == DialogResult.Cancel)
            {
                return;
            }
        }
    }
}
