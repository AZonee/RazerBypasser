namespace RazerBypasser
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bxDeviceSelect = new System.Windows.Forms.ComboBox();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.pnlDeviceControl = new System.Windows.Forms.Panel();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bxDeviceSelect
            // 
            this.bxDeviceSelect.FormattingEnabled = true;
            this.bxDeviceSelect.Location = new System.Drawing.Point(12, 12);
            this.bxDeviceSelect.Name = "bxDeviceSelect";
            this.bxDeviceSelect.Size = new System.Drawing.Size(238, 21);
            this.bxDeviceSelect.TabIndex = 1;
            this.bxDeviceSelect.Text = "Select Device (Keyboard)";
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Location = new System.Drawing.Point(261, 11);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDevice.TabIndex = 2;
            this.btnSelectDevice.Text = "Select";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // pnlDeviceControl
            // 
            this.pnlDeviceControl.Location = new System.Drawing.Point(12, 39);
            this.pnlDeviceControl.Name = "pnlDeviceControl";
            this.pnlDeviceControl.Size = new System.Drawing.Size(776, 244);
            this.pnlDeviceControl.TabIndex = 3;
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Location = new System.Drawing.Point(343, 12);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(445, 21);
            this.pnlTopRight.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTopRight);
            this.Controls.Add(this.pnlDeviceControl);
            this.Controls.Add(this.btnSelectDevice);
            this.Controls.Add(this.bxDeviceSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Razer Bypasser";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox bxDeviceSelect;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Panel pnlDeviceControl;
    }
}

