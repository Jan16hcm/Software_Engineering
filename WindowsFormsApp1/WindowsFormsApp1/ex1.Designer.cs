namespace _524K0034_LamGiaVu_Lab1
{
    partial class Form1
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
            this.lblhello = new System.Windows.Forms.Label();
            this.btnclickme = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Location = new System.Drawing.Point(381, 84);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(68, 13);
            this.lblhello.TabIndex = 0;
            this.lblhello.Text = "Hello, World!";
            // 
            // btnclickme
            // 
            this.btnclickme.Location = new System.Drawing.Point(374, 138);
            this.btnclickme.Name = "btnclickme";
            this.btnclickme.Size = new System.Drawing.Size(75, 23);
            this.btnclickme.TabIndex = 1;
            this.btnclickme.Text = "Click me!";
            this.btnclickme.UseVisualStyleBackColor = true;
            this.btnclickme.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(374, 232);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 20);
            this.txtbox1.TabIndex = 2;
            // 
            // ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.btnclickme);
            this.Controls.Add(this.lblhello);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "ex1";
            this.Text = "Hello, World!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.Button btnclickme;
        private System.Windows.Forms.TextBox txtbox1;
    }
}

