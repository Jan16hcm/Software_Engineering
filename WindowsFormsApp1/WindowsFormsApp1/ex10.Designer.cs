namespace _524K0034_LamGiaVu_Lab1
{
    partial class ex10
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
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.pbr1 = new System.Windows.Forms.ProgressBar();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(253, 191);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 0;
            // 
            // pbr1
            // 
            this.pbr1.Location = new System.Drawing.Point(253, 217);
            this.pbr1.Name = "pbr1";
            this.pbr1.Size = new System.Drawing.Size(122, 23);
            this.pbr1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(378, 217);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Start";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ex10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pbr1);
            this.Controls.Add(this.dtp1);
            this.Name = "ex10";
            this.Text = "ex10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ProgressBar pbr1;
        private System.Windows.Forms.Button btn1;
    }
}