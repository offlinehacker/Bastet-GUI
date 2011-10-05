using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlexFieldControlLib;

namespace TROL_MgmtGui2
{
    [System.ComponentModel.DefaultBindingProperty("IntValue")]
    class HexControl : FlexFieldControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                //this.DataBindings.
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public HexControl()
        {
            // the format of this control is 'FF:FF:FF:FF:FF:FF'

            // set FieldCount first
            //
            FieldCount = 1;

            // the value format is hexadecimal
            //
            SetValueFormat(ValueFormat.Hexadecimal);

            SetSeparatorText(0, "0x");
            SetSeparatorText(FieldCount, String.Empty);

            SetMaxLength(8);

            // use leading zeros for every field
            //
            SetLeadingZeros(false);

            // use uppercase only
            //
            SetCasing(System.Windows.Forms.CharacterCasing.Upper);

            // this should be the last thing
            //
            Size = MinimumSize;

            this.Validated+= new EventHandler(OnValidated);
        }

        private void OnValidated( object sender, EventArgs test2)
        {
            NotifyPropertyChanged("IntValue");
        }

        [Bindable(true,BindingDirection.TwoWay)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int IntValue
        {
            get { return GetValue(0); }
            set { SetValue(0, value); }
        }
    }
}
