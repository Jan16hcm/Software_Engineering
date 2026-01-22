using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _524K0034_LamGiaVu_Lab1
{
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void ex4_Load(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtboxnum1.Text);
            double num2 = Convert.ToDouble(txtboxnum2.Text);
            lblresult.Text = (num1 + num2).ToString();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtboxnum1.Text);
            double num2 = Convert.ToDouble(txtboxnum2.Text);
            lblresult.Text = (num1 - num2).ToString();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtboxnum1.Text);
            double num2 = Convert.ToDouble(txtboxnum2.Text);
            lblresult.Text = (num1 * num2).ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtboxnum1.Text);
            double num2 = Convert.ToDouble(txtboxnum2.Text);
            if (num2 == 0)
            {
                if (MessageBox.Show("Division by 0, Do you want to break universe?", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    Application.Exit();
                }
            }
            lblresult.Text = (num1 / num2).ToString();
            
        }
    }
}
