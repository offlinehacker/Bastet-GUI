using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TROL_MgmtGui2
{
    [System.ComponentModel.DefaultBindingProperty("chair_status")]
    public partial class RemoteView : UserControl
    {
        UInt16 cChairStatus;
        UInt16 cSysStatus;
        int cWeight;

        [Browsable(true)]
        [Bindable(true, BindingDirection.OneWay)]
        public UInt16 chair_status
        {
            get { return cChairStatus; }
            set
            {
                cChairStatus = value;
                ParseChairStatus();
            }
        }

        [Browsable(true)]
        [Bindable(true, BindingDirection.OneWay)]
        public UInt16 sys_status
        {
            get { return cSysStatus; }
            set
            {
                cSysStatus = value;
                //ParseChairStatus();
            }
        }

        public int weight
        {
            get { return cWeight; }
            set
            {
                cWeight = value;
                labelWeight.Text = value.ToString();
            }
        }

        private void ParseChairStatus()
        {
            if ((cChairStatus & (ushort)RemoteViewBits.STATUS_WEIGHT_HI1_BIT) > 0)
                WEIGHT_HI1_button.Enabled = true;
            else
                WEIGHT_HI1_button.Enabled = false;

            if ((cChairStatus & (ushort)RemoteViewBits.STATUS_WEIGHT_HI2_BIT) > 0)
                WEIGHT_HI2_button.Enabled = true;
            else
                WEIGHT_HI2_button.Enabled = false;

            if ((cChairStatus & (ushort)RemoteViewBits.STATUS_WEIGHT_HI3_BIT) > 0)
                WEIGHT_HI3_button.Enabled = true;
            else
                WEIGHT_HI3_button.Enabled = false;

            if ((cChairStatus & (ushort)RemoteViewBits.STATUS_WEIGHT_LO1_BIT) > 0)
                WEIGHT_LO1_button.Enabled = true;
            else
                WEIGHT_LO1_button.Enabled = false;

            if ((cChairStatus & (ushort)RemoteViewBits.STATUS_WEIGHT_LO2_BIT) > 0)
                WEIGHT_LO2_button.Enabled = true;
            else
                WEIGHT_LO2_button.Enabled = false;

            if ((cChairStatus & (ushort)RemoteViewBits.STATUS_WEIGHT_LO3_BIT) > 0)
                WEIGHT_LO3_button.Enabled = true;
            else
                WEIGHT_LO3_button.Enabled = false;

            if ((cChairStatus & (ushort)RemoteViewBits.STATUS_WEIGHT_SET_BIT) > 0)
                WEIGHT_SET_BIT_button.Enabled = true;
            else
                WEIGHT_SET_BIT_button.Enabled = false;

            if ((cChairStatus & (ushort)RemoteViewBits.STATUS_MOTOR_LIM_UP_BIT) > 0)
            {
                MOTOR_DIR_UP_button.Enabled = true;
                MOTOR_DIR_UP_button.Image = global::TROL_MgmtGui2.Properties.Resources.UpArrow_Red;
            }
            else if ((cChairStatus & (ushort)RemoteViewBits.STATUS_MOTOR_DIR_UP_BIT) > 0)
            {
                MOTOR_DIR_UP_button.Enabled = true;
                MOTOR_DIR_UP_button.Image = global::TROL_MgmtGui2.Properties.Resources.UpArrow_0;
            }
            else
                MOTOR_DIR_UP_button.Enabled = false;

            if ((cChairStatus & (ushort)RemoteViewBits.STATUS_MOTOR_LIM_DN_BIT) > 0)
            {
                MOTOR_DIR_DOWN_button.Enabled = true;
                MOTOR_DIR_DOWN_button.Image = global::TROL_MgmtGui2.Properties.Resources.DownArrow_Red;
            }
            else if ((cChairStatus & (ushort)RemoteViewBits.STATUS_MOTOR_DIR_DN_BIT) > 0)
            {
                MOTOR_DIR_DOWN_button.Enabled = true;
                MOTOR_DIR_DOWN_button.Image = global::TROL_MgmtGui2.Properties.Resources.DownArrow_0;
            }
            else
                MOTOR_DIR_DOWN_button.Enabled = false;

            toolStrip1.Refresh();
            toolStrip2.Refresh();
        }

        public RemoteView()
        {
            InitializeComponent();
        }

        private void RemoteView_Load(object sender, EventArgs e)
        {
            //headerBindableStripMenu1.DataBindings.Add(new System.Windows.Forms.Binding("chair_status", remoteViewBinding.DataSource, remoteViewBinding.DataMember));
        }
    }
}
