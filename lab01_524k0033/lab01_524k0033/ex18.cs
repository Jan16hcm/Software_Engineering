using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01_524k0033
{
    public partial class ex18 : Form
    {
        public ex18()
        {
            InitializeComponent();
        }

        private void ex18_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label() { Text = "Panel 1", Dock = DockStyle.Fill };
            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label() { Text = "Panel 2", Dock = DockStyle.Fill };
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label2);
        }
    }
}
