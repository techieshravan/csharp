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
    public partial class Form4 : Form
    {
        int _selectedIndex;
        string _text;

        public Form4()
        {
            InitializeComponent();
            comboBox1.Items.Add("FORTRAN");
            comboBox1.Items.Add("Ada");
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIndex = comboBox1.SelectedIndex;
            Display();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            _text = comboBox1.Text;
            Display();
        }

        void Display()
        {
            this.Text = string.Format("Text: {0}   SelectedIndex: {1}", _text, _selectedIndex);
        }
    }
}
