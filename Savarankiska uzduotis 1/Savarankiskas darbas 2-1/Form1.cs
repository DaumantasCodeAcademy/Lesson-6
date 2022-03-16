using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savarankiskas_darbas_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextInputTextBox_TextChanged(object sender, EventArgs e)
        {
            int numberOfSpaces = 0;
            string currentText = TextInputTextBox.Text;

            for (int i = 0; i < TextInputTextBox.Text.Length; i++)
            {
                if (currentText[i] == ' ')
                {
                    numberOfSpaces++;
                }
            }
            SpaceCountTextBox.Text = numberOfSpaces.ToString();
            //SpaceCountTextBox.Text = $"{numberOfSpaces}";
        }
    }
}
