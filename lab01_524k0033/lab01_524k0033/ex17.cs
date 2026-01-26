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
    public partial class ex17 : Form
    {
        public ex17()
        {
            InitializeComponent();
        }

        private void ex17_Load(object sender, EventArgs e)
        {
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel("Ready");
            statusStrip1.Items.Add(statusLabel);
        }
    }
}
