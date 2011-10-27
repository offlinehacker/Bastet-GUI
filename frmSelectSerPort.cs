using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TROL_MgmtGui2
{
    partial class frmSelectSerPort : Form
    {
        /// <summary>
        /// Gets currently selected port name.
        /// </summary>
        public String SelectedPortName
        {
            get
            {
                return (String)comboSerPort.SelectedItem;
            }
        }

        /// <summary>
        /// Gets currently selected protocol.
        /// </summary>
        public String SelectedProtocol
        {
            get
            {
                return (String)comboProtocol.SelectedItem;
            }
        }

        public frmSelectSerPort()
        {
            InitializeComponent();

            // add all available serial ports to the combobox
            foreach (String port in SerialBase.GetAvailablePorts())
                comboSerPort.Items.Add(port);
        }

        /// <summary>
        /// Refresh list of available serial ports.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboSerPort.Items.Clear();

            foreach (String port in SerialBase.GetAvailablePorts())
                comboSerPort.Items.Add(port);
        }
    }
}