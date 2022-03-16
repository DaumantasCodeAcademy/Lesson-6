using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_lesson
{
    internal class OutputWriter
    {
        public void WriteName(string name, TextBox outputTextBox)
        {
            outputTextBox.Text = $"Labas, {name}";
        }
    }
}
