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
using Translate;


namespace WindowsFormsApp10
{
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();
        }

        private async void ButtonSend_Click(object sender, EventArgs e)
        {
            TranslationService translation = new TranslationService();

            if (ComboBoxFrom.SelectedIndex == 0 && ComboBoxTo.SelectedIndex == 1)
            {
                var result = await translation.TrasnlateAsync("en", "ru", InputTextBox.Text);
                TextBoxResult.Text = result.responseData.translatedText;
            }

            else if (ComboBoxFrom.SelectedIndex == 0 && ComboBoxTo.SelectedIndex == 2)
            {
                var result = await translation.TrasnlateAsync("en", "geo", InputTextBox.Text);
                TextBoxResult.Text = result.responseData.translatedText;
            }

            else if (ComboBoxFrom.SelectedIndex == 1 && ComboBoxTo.SelectedIndex == 0)
            {
                var result = await translation.TrasnlateAsync("ru", "en", InputTextBox.Text);
                TextBoxResult.Text = result.responseData.translatedText;
            }

            else if (ComboBoxFrom.SelectedIndex == 1 && ComboBoxTo.SelectedIndex == 2)
            {
                var result = await translation.TrasnlateAsync("ru", "geo", InputTextBox.Text);
                TextBoxResult.Text = result.responseData.translatedText;
            }

            else if (ComboBoxFrom.SelectedIndex == 2 && ComboBoxTo.SelectedIndex == 0)
            {
                var result = await translation.TrasnlateAsync("geo", "en", InputTextBox.Text);
                TextBoxResult.Text = result.responseData.translatedText;
            }

            else if (ComboBoxFrom.SelectedIndex == 2 && ComboBoxTo.SelectedIndex == 1)
            {
                var result = await translation.TrasnlateAsync("geo", "ru", InputTextBox.Text);
                TextBoxResult.Text = result.responseData.translatedText;
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
            InputTextBox.Cursor
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
