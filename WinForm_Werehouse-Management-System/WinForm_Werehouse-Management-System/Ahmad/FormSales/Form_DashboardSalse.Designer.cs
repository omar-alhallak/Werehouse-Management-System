namespace WinForm_Werehouse_Management_System
{
    partial class Form_DashboardSalse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(54, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(298, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 303);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-3, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 63);
            this.panel3.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(512, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Log out";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ahmad Abo Shear";
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackgroundImage = global::WinForm_Werehouse_Management_System.Properties.Resources.invose;
            this.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInvoice.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.btnInvoice.Location = new System.Drawing.Point(326, 266);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(201, 115);
            this.btnInvoice.TabIndex = 14;
            this.btnInvoice.Text = "View Invoices";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImage = global::WinForm_Werehouse_Management_System.Properties.Resources.date_Order;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrder.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.btnOrder.Location = new System.Drawing.Point(75, 266);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(201, 115);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "View Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSales.BackgroundImage = global::WinForm_Werehouse_Management_System.Properties.Resources.cart;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSales.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.Black;
            this.btnSales.Location = new System.Drawing.Point(326, 102);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(201, 115);
            this.btnSales.TabIndex = 12;
            this.btnSales.Text = "Cart";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::WinForm_Werehouse_Management_System.Properties.Resources.order;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.btnReturn.Location = new System.Drawing.Point(75, 102);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(201, 115);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return The Order";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form_DashboardSalse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DashboardSalse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button2;
    }
}