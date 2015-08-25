using System.Windows.Forms;

namespace Application2
{
    internal class Form1 : Form
    {
        private TextBox TextBox1;
        private Label Label1;
        private Button Button1;
        
        public Form1()
        {
            Text = "My Form 1";

            TextBox1 = new TextBox
            {
                Top = 25,
                Left = 25,
                Width = 200
            };
            Controls.Add(TextBox1);

            Label1 = new Label
            {
                Text = "I am a Label",
                Top = 75,
                Left = 25,
                Width = 200
            };
            Controls.Add(Label1);

            Button1 = new Button
            {
                Text = "Click Me!",
                Top = 125,
                Left = 25,
                Width = 200
            };
            Button1.Click += Button1_Click;
            Controls.Add(Button1);
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }
    }
}