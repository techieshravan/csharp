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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var items = checkedListBox1.Items;
            items.Add("F#");
            items.Add("Angular", true);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = checkedListBox1.SelectedIndex;
            if (selected != -1)
            {
                this.Text = checkedListBox1.Items[selected].ToString();
            }
        }
    }
}
