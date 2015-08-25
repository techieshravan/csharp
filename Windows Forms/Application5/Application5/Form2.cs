using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Application5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            CheckState state = checkBox1.CheckState;
            
            switch (state)
            {
                case CheckState.Checked:
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        MessageBox.Show(state.ToString());
                        break;
                    }
            }
            
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
            MessageBox.Show(checkBox1.CheckState.ToString());
        }
    }
}
