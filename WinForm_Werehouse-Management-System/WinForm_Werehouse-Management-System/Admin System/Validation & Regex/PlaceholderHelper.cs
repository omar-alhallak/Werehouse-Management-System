using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Werehouse_Management_System
{
    public static class PlaceholderHelper
    {
        public static void PlaceholderFromTextBox(TextBox textBox, string placeholder)
        {
            textBox.Tag = placeholder;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.White;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        public static void PlaceholderFromComboBox(ComboBox combo, string placeholder)
        {
            if(!combo.Items.Contains(placeholder))
              combo.Items.Insert(0, placeholder);

            if (combo.SelectedIndex == -1 || combo.SelectedItem == null) 
            {
                combo.SelectedIndex = 0;
                combo.ForeColor = Color.Gray;
            }

            combo.SelectedIndexChanged += (s, e) =>
            {
                combo.ForeColor = combo.SelectedIndex == 0 ? Color.Gray : Color.White;
            };

            combo.Enter += (s, e) =>
            {
                if (combo.SelectedIndex == 0)
                {
                    combo.DroppedDown = true;
                }
            };
        }
    }
}