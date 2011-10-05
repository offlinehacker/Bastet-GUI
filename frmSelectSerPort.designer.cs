namespace TROL_MgmtGui2
{
    partial class frmSelectSerPort
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
            this.lblSelectPort = new System.Windows.Forms.Label();
            this.comboSerPort = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectPort
            // 
            this.lblSelectPort.AutoSize = true;
            this.lblSelectPort.Location = new System.Drawing.Point(12, 15);
            this.lblSelectPort.Name = "lblSelectPort";
            this.lblSelectPort.Size = new System.Drawing.Size(88, 13);
            this.lblSelectPort.TabIndex = 0;
            this.lblSelectPort.Text = "Select serial port:";
            // 
            // comboSerPort
            // 
            this.comboSerPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSerPort.FormattingEnabled = true;
            this.comboSerPort.Location = new System.Drawing.Point(106, 12);
            this.comboSerPort.Name = "comboSerPort";
            this.comboSerPort.Size = new System.Drawing.Size(121, 21);
            this.comboSerPort.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelect.Location = new System.Drawing.Point(314, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(233, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmSelectSerPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 45);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.comboSerPort);
            this.Controls.Add(this.lblSelectPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectSerPort";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select serial port";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectPort;
        private System.Windows.Forms.ComboBox comboSerPort;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRefresh;
    }
}