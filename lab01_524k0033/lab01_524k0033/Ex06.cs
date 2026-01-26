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
    public partial class Ex06 : Form
    {
        public Ex06()
        {
            InitializeComponent();
        }

        private void Ex06_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Age";
            string[] row1 = new string[] { "1", "Ky-Trung Pham", "25" };
            string[] row2 = new string[] { "2", "Thai Ky Trung", "30" };
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
        }


    }
}

