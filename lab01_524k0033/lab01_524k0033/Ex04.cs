using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01_524k0033
{
    public partial class Ex04 : Form
    {
        double input1;
        double input2;
        
        public Ex04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = Convert.ToString(input1+input2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultLabel.Text = Convert.ToString(input1 / input2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultLabel.Text = Convert.ToString(input1 - input2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultLabel.Text = Convert.ToString(input1 * input2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.input1= Convert.ToDouble(textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.input2 = Convert.ToDouble(textBox2.Text);

        }
    }
}
