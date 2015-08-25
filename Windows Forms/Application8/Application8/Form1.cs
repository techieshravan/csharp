using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Application8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newMdiChild = new Form2
            {
                MdiParent = this
            };
            newMdiChild.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                var file = openFileDialog1.FileName;
                try
                {
                    var text = File.ReadAllText(file);
                    var newMdiChild = new Form2
                    {
                        MdiParent = this,
                        Text = Path.GetFileNameWithoutExtension(file)
                    };
                    newMdiChild.Controls["richTextBox1"].Text = text;
                    newMdiChild.Show();
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
