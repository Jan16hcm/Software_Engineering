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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void Ex5_Load(object sender, EventArgs e)
        {

      
                string[] items = { "Item 1", "Item 2" };
                string[] options = { "Option A", "Option B" };
                listBox1.Items.AddRange(items);
                comboBox1.Items.AddRange(options);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();

        }
    }
}
