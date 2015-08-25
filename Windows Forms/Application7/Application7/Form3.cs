using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Application7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            bool hasDigit = text.Any(char.IsDigit);

            if (!hasDigit)
            {
                errorProvider1.SetError(textBox1, "Needs to contain a digit");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
