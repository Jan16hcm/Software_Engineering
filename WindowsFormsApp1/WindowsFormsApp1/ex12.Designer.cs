namespace _524K0034_LamGiaVu_Lab1
{
    partial class ex12
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
            this.lblcopyright = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Location = new System.Drawing.Point(519, 396);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(131, 13);
            this.lblcopyright.TabIndex = 2;
            this.lblcopyright.Text = "Developed by Lâm Gia Vũ\r\n";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(260, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(197, 168);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ex12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblcopyright);
            this.Name = "ex12";
            this.Text = "ex12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcopyright;
        private System.Windows.Forms.ListView listView1;
    }
}