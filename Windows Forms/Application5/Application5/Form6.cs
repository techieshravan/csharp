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
    public partial class Form6 : Form
    {
        List<string> _items = new List<string>();

        public Form6()
        {
            InitializeComponent();

            _items.Add("One");
            _items.Add("Two");
            _items.Add("Three");

            listBox1.DataSource = _items;
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _items.Add("New item " + DateTime.Now.Second);
            listBox1.DataSource = null;
            listBox1.DataSource = _items;
            
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            try
            {
                _items.RemoveAt(selectedIndex);
            }
            catch (Exception)
            {       
                throw;
            }
            listBox1.DataSource = null;
            listBox1.DataSource = _items;

            if (listBox1.Items.Count == 0)
            {
                button2.Enabled = false;
            }
        }
    }
}
