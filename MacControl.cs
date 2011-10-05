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
    class MacControl : FlexFieldControl
    {
        public MacControl()
        {
            // the format of this control is 'FF:FF:FF:FF'

            // set FieldCount first
            //
            FieldCount = 4;

            // the value format is hexadecimal
            //
            SetValueFormat(ValueFormat.Hexadecimal);

            // every field is 2 digits max
            SetMaxLength(2);

            // every separator is ':'...
            SetSeparatorText(":");

            SetSeparatorText(0, String.Empty);
            SetSeparatorText(FieldCount, String.Empty);

            // use leading zeros for every field
            //
            SetLeadingZeros(true);

            // use uppercase only
            //
            SetCasing(System.Windows.Forms.CharacterCasing.Upper);

            // this should be the last thing
            //
            Size = MinimumSize;

            /*KeyEventArgs e = new KeyEventArgs(Keys.OemSemicolon);
            AddCedeFocusKey(e);*/

            this.Validated += new EventHandler(OnValidated);
        }

        private void OnValidated(object sender, EventArgs test2)
        {

        }

        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int IntValue
        {
            get { return (int)System.Convert.ToUInt32(Text.Replace(":",""),16); }
            set 
            {
                SetValue(0,(int)((value & 0xFF000000) >> 24));
                SetValue(1,(int)((value & 0x00FF0000) >> 16));
                SetValue(2,(int)((value & 0x0000FF00) >> 8));
                SetValue(3,(int)((value & 0x000000FF) >> 0));
            }
        }
    }
}
