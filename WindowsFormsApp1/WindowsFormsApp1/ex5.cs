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
    public partial class ex5 : Form
    {
        public ex5()
        {
            InitializeComponent();
            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");
            comboBox1.Items.Add("Option A");
            comboBox1.Items.Add("Option B");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            string selectedOption = comboBox1.SelectedItem.ToString();
            MessageBox.Show($"ListBox: {selectedItem}, ComboBox: {selectedOption}");
        }
    }
}
