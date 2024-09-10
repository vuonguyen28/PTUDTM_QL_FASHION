﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class TextBox_Number:TextBox
    {
        public TextBox_Number()
        {
            this.KeyPress += TextBox_Number_KeyPress;
        }

        private void TextBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            { 
                e.Handled = true;
            }
        }
    }
}
