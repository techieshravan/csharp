using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Application4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            maskedTextBox1.MaskInputRejected += MaskedTextBox1_MaskInputRejected;
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show(string.Format("Error: {0}; position: {1}", e.RejectionHint, e.Position));
        }
    }
}
