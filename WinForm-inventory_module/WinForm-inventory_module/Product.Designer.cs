namespace WinForm_inventory_module
{
    partial class Product
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
            this.ddd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddd
            // 
            this.ddd.Location = new System.Drawing.Point(674, 40);
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(75, 23);
            this.ddd.TabIndex = 0;
            this.ddd.Text = "button1";
            this.ddd.UseVisualStyleBackColor = true;
            this.ddd.Click += new System.EventHandler(this.ddd_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddd);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Name = "Product";
            this.Text = "إدارة المنتجات";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ddd;
    }
}