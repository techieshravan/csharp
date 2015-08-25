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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            richTextBox1.Font = new Font("Consolas", 18f, FontStyle.Bold);
            richTextBox1.BackColor = Color.AliceBlue;
            string[] words = { "You", "Are", "So", "Nice", "Person" };
            Color[] colors =
            {
                Color.Aqua,
                Color.CadetBlue,
                Color.Cornsilk,
                Color.Gold,
                Color.HotPink,
                Color.Lavender,
                Color.Moccasin
            };

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                Color color = colors[i];
                {
                    richTextBox1.SelectionBackColor = color;
                    richTextBox1.AppendText(word);
                    richTextBox1.SelectionBackColor = Color.AliceBlue;
                    richTextBox1.AppendText(" ");
                }
            }
        }
    }
}
