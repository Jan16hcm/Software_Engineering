using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _524K0034_LamGiaVu_Lab1
{
    public partial class ex11 : Form
    {
        public ex11()
        {
            InitializeComponent();
            TreeNode rootNode = new TreeNode("Root");
            TreeNode childNode1 = new TreeNode("Child 1");
            TreeNode childNode2 = new TreeNode("Child 2");
            rootNode.Nodes.Add(childNode1);
            rootNode.Nodes.Add(childNode2);
            treeView1.Nodes.Add(rootNode);
        }
    }
}
