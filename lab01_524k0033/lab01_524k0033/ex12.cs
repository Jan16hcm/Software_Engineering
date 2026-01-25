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
    public partial class ex12 : Form
    {
        public ex12()
        {
            InitializeComponent();
        }

        private void ex12_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Column 1", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            ListViewItem item1 = new ListViewItem("Item 1");
            item1.SubItems.Add("Subitem 1");
            ListViewItem item2 = new ListViewItem("Item 2");
            item2.SubItems.Add("Subitem 2");
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
        }
    }
}
