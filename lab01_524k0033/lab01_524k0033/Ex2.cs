using System;
using System.Windows.Forms;

namespace lab01_524k0033
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Width = button1.Width + 15;
            button1.Text = "Button Clicked!";
        }
    }
}
