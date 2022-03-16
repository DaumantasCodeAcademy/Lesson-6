using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savarankiskas_darbas_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateDigitsSumButton_Click(object sender, EventArgs e)
        {
            string text = InputTextBox.Text;
            int sum = 0;

            string[] numberTextsArray = text.Split(' ', ',', ';');
            for (int i = 0; i < numberTextsArray.Length; i++)
            {
                sum += Convert.ToInt32(numberTextsArray[i]);
            }

            NumbersCountTextBox.Text = numberTextsArray.Length.ToString();
            SumTextBox.Text = sum.ToString();
        }
    }
}
