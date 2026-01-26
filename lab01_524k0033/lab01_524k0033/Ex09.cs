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
    public partial class Ex09 : Form
    {
        public Ex09()
        {
            InitializeComponent();
        }

        private void Ex09_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Age";
            string[] row1 = new string[] { "1", "Ky-Trung Pham", "25" };
            string[] row2 = new string[] { "2", "Thai Ky Trung", "30" };
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Options";
            comboBoxColumn.Items.AddRange("Option 1", "Option 2", "Option 3");
            dataGridView1.Columns.Add(comboBoxColumn);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { textBoxID.Text, textBoxName.Text, textBoxAge.Text };
            dataGridView1.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}
