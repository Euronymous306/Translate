using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp10
{
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (ComboBoxFrom.SelectedIndex == 2 && InputTextBox.Text == "გამარჯობა")
            {
                TextBoxResult.Text = "Hello";
            }
            else
            TextBoxResult.Text = InputTextBox.Text;
        }

        private void Translate_Load(object sender, EventArgs e)
        {
            ComboBoxFrom.SelectedIndex = 0;
            ComboBoxTo.SelectedIndex = 0;
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ButtonSend.PerformClick();
            }
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            InputTextBox.DeselectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTextBox.Undo();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            TextBoxResult.Clear();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTextBox.SelectAll();
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTextBox.DeselectAll();
        }
    }
}
