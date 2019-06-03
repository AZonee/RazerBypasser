namespace RazerBypasser
{
    partial class ucDControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDControl));
            this.lblTemp = new System.Windows.Forms.Label();
            this.bxSelectKey = new System.Windows.Forms.ComboBox();
            this.btnSelectKey = new System.Windows.Forms.Button();
            this.bxSelectInput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(368, 205);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(405, 39);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = resources.GetString("lblTemp.Text");
            // 
            // bxSelectKey
            // 
            this.bxSelectKey.FormattingEnabled = true;
            this.bxSelectKey.Location = new System.Drawing.Point(0, 0);
            this.bxSelectKey.Name = "bxSelectKey";
            this.bxSelectKey.Size = new System.Drawing.Size(238, 21);
            this.bxSelectKey.TabIndex = 1;
            this.bxSelectKey.Text = "Change which key?";
            // 
            // btnSelectKey
            // 
            this.btnSelectKey.Location = new System.Drawing.Point(490, -1);
            this.btnSelectKey.Name = "btnSelectKey";
            this.btnSelectKey.Size = new System.Drawing.Size(75, 23);
            this.btnSelectKey.TabIndex = 2;
            this.btnSelectKey.Text = "Select";
            this.btnSelectKey.UseVisualStyleBackColor = true;
            this.btnSelectKey.Click += new System.EventHandler(this.btnSelectKey_Click);
            // 
            // bxSelectInput
            // 
            this.bxSelectInput.FormattingEnabled = true;
            this.bxSelectInput.Location = new System.Drawing.Point(246, 0);
            this.bxSelectInput.Name = "bxSelectInput";
            this.bxSelectInput.Size = new System.Drawing.Size(238, 21);
            this.bxSelectInput.TabIndex = 3;
            this.bxSelectInput.Text = "Change to what?";
            // 
            // ucDControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bxSelectInput);
            this.Controls.Add(this.btnSelectKey);
            this.Controls.Add(this.bxSelectKey);
            this.Controls.Add(this.lblTemp);
            this.Name = "ucDControl";
            this.Size = new System.Drawing.Size(776, 244);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.ComboBox bxSelectKey;
        private System.Windows.Forms.Button btnSelectKey;
        private System.Windows.Forms.ComboBox bxSelectInput;
    }
}
