namespace RazerBypasser
{
    partial class ucProfileSelect
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
            this.bxProfileSelect = new System.Windows.Forms.ComboBox();
            this.btnProfileSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bxProfileSelect
            // 
            this.bxProfileSelect.FormattingEnabled = true;
            this.bxProfileSelect.Location = new System.Drawing.Point(0, 0);
            this.bxProfileSelect.Name = "bxProfileSelect";
            this.bxProfileSelect.Size = new System.Drawing.Size(179, 21);
            this.bxProfileSelect.TabIndex = 0;
            this.bxProfileSelect.Text = "Select Profile";
            // 
            // btnProfileSelect
            // 
            this.btnProfileSelect.Location = new System.Drawing.Point(185, -1);
            this.btnProfileSelect.Name = "btnProfileSelect";
            this.btnProfileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnProfileSelect.TabIndex = 1;
            this.btnProfileSelect.Text = "Select";
            this.btnProfileSelect.UseVisualStyleBackColor = true;
            this.btnProfileSelect.Click += new System.EventHandler(this.btnProfileSelect_Click);
            // 
            // ucProfileSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProfileSelect);
            this.Controls.Add(this.bxProfileSelect);
            this.Name = "ucProfileSelect";
            this.Size = new System.Drawing.Size(445, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox bxProfileSelect;
        private System.Windows.Forms.Button btnProfileSelect;
    }
}
