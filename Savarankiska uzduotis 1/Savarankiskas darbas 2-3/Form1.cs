using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savarankiskas_darbas_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(NumberInputTextBox.Text);
            int power = Convert.ToInt32(PowerInputTextBox.Text);

            double result = Math.Pow(number, power);
            ResultTextBox.Text = result.ToString();
        }
    }
}
