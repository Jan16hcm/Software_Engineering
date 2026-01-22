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
    public partial class ex10 : Form
    {
        public ex10()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pbr1.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 100; // 100 ms
            timer.Tick += (s, args) =>
            {
                if (pbr1.Value < 100)
                {
                    pbr1.Value += 10;
                }
                else
                {
                    timer.Stop();
                    MessageBox.Show("Progress complete!");
                }
            };
            timer.Start();
        }
    }
}