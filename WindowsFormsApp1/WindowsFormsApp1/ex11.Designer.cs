namespace _524K0034_LamGiaVu_Lab1
{
    partial class ex11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(283, 157);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Location = new System.Drawing.Point(524, 384);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(131, 13);
            this.lblcopyright.TabIndex = 1;
            this.lblcopyright.Text = "Developed by Lâm Gia Vũ\r\n";
            // 
            // ex11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcopyright);
            this.Controls.Add(this.treeView1);
            this.Name = "ex11";
            this.Text = "ex11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblcopyright;
    }
}