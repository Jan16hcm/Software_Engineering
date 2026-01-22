namespace _524K0034_LamGiaVu_Lab1
{
    partial class ex4
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
            this.txtboxnum1 = new System.Windows.Forms.TextBox();
            this.txtboxnum2 = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxnum1
            // 
            this.txtboxnum1.Location = new System.Drawing.Point(351, 152);
            this.txtboxnum1.Name = "txtboxnum1";
            this.txtboxnum1.Size = new System.Drawing.Size(100, 20);
            this.txtboxnum1.TabIndex = 0;
            // 
            // txtboxnum2
            // 
            this.txtboxnum2.Location = new System.Drawing.Point(351, 183);
            this.txtboxnum2.Name = "txtboxnum2";
            this.txtboxnum2.Size = new System.Drawing.Size(100, 20);
            this.txtboxnum2.TabIndex = 1;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(282, 152);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(25, 25);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(313, 183);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(25, 25);
            this.btndiv.TabIndex = 3;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(282, 183);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(25, 25);
            this.btnmult.TabIndex = 4;
            this.btnmult.Text = "x";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(313, 152);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(25, 25);
            this.btnminus.TabIndex = 5;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(348, 220);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 6;
            // 
            // ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtboxnum2);
            this.Controls.Add(this.txtboxnum1);
            this.Name = "ex4";
            this.Text = "ex4";
            this.Load += new System.EventHandler(this.ex4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxnum1;
        private System.Windows.Forms.TextBox txtboxnum2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Label lblresult;
    }
}