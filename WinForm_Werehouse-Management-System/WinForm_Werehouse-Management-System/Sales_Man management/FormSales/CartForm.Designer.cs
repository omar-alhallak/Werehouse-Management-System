namespace WinForm_Werehouse_Management_System
{
    partial class CartForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtsersh = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.btmclear = new System.Windows.Forms.Button();
            this.btmremove = new System.Windows.Forms.Button();
            this.btmAdd = new System.Windows.Forms.Button();
            this.comQuantity = new System.Windows.Forms.NumericUpDown();
            this.btncart1 = new System.Windows.Forms.Button();
            this.btncart2 = new System.Windows.Forms.Button();
            this.btncart4 = new System.Windows.Forms.Button();
            this.btncart3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Price,
            this.Quantity,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(259, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(498, 307);
            this.dataGridView1.TabIndex = 2;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prudect Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(135, 95);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(118, 30);
            this.textBox3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(99, 189);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(154, 30);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(135, 139);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(118, 30);
            this.textBox2.TabIndex = 15;
            // 
            // txtsersh
            // 
            this.txtsersh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtsersh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsersh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsersh.ForeColor = System.Drawing.Color.Gray;
            this.txtsersh.Location = new System.Drawing.Point(15, 250);
            this.txtsersh.Multiline = true;
            this.txtsersh.Name = "txtsersh";
            this.txtsersh.Size = new System.Drawing.Size(117, 19);
            this.txtsersh.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(15, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 1);
            this.panel2.TabIndex = 17;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.close.Location = new System.Drawing.Point(15, 392);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(85, 31);
            this.close.TabIndex = 18;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btmclear
            // 
            this.btmclear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmclear.Location = new System.Drawing.Point(15, 344);
            this.btmclear.Name = "btmclear";
            this.btmclear.Size = new System.Drawing.Size(85, 31);
            this.btmclear.TabIndex = 19;
            this.btmclear.Text = "Cancel Order";
            this.btmclear.UseVisualStyleBackColor = true;
            this.btmclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btmremove
            // 
            this.btmremove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btmremove.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.btmremove.Location = new System.Drawing.Point(135, 344);
            this.btmremove.Name = "btmremove";
            this.btmremove.Size = new System.Drawing.Size(85, 31);
            this.btmremove.TabIndex = 20;
            this.btmremove.Text = "Delete Item";
            this.btmremove.UseVisualStyleBackColor = true;
            this.btmremove.Click += new System.EventHandler(this.button3_Click);
            // 
            // btmAdd
            // 
            this.btmAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAdd.Location = new System.Drawing.Point(135, 298);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(85, 31);
            this.btmAdd.TabIndex = 21;
            this.btmAdd.Text = "Add Item";
            this.btmAdd.UseVisualStyleBackColor = true;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // comQuantity
            // 
            this.comQuantity.Location = new System.Drawing.Point(183, 251);
            this.comQuantity.Name = "comQuantity";
            this.comQuantity.Size = new System.Drawing.Size(48, 20);
            this.comQuantity.TabIndex = 24;
            // 
            // btncart1
            // 
            this.btncart1.Location = new System.Drawing.Point(756, 80);
            this.btncart1.Name = "btncart1";
            this.btncart1.Size = new System.Drawing.Size(20, 20);
            this.btncart1.TabIndex = 25;
            this.btncart1.Text = "1";
            this.btncart1.UseVisualStyleBackColor = true;
            this.btncart1.Click += new System.EventHandler(this.btncart1_Click);
            // 
            // btncart2
            // 
            this.btncart2.Location = new System.Drawing.Point(756, 106);
            this.btncart2.Name = "btncart2";
            this.btncart2.Size = new System.Drawing.Size(20, 20);
            this.btncart2.TabIndex = 26;
            this.btncart2.Text = "2";
            this.btncart2.UseVisualStyleBackColor = true;
            this.btncart2.Click += new System.EventHandler(this.btncart2_Click_1);
            // 
            // btncart4
            // 
            this.btncart4.Location = new System.Drawing.Point(756, 158);
            this.btncart4.Name = "btncart4";
            this.btncart4.Size = new System.Drawing.Size(20, 20);
            this.btncart4.TabIndex = 27;
            this.btncart4.Text = "4";
            this.btncart4.UseVisualStyleBackColor = true;
            this.btncart4.Click += new System.EventHandler(this.btncart4_Click_1);
            // 
            // btncart3
            // 
            this.btncart3.Location = new System.Drawing.Point(756, 132);
            this.btncart3.Name = "btncart3";
            this.btncart3.Size = new System.Drawing.Size(20, 20);
            this.btncart3.TabIndex = 28;
            this.btncart3.Text = "3";
            this.btncart3.UseVisualStyleBackColor = true;
            this.btncart3.Click += new System.EventHandler(this.btncart3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.button1.Location = new System.Drawing.Point(15, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "View Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnorder
            // 
            this.btnorder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.btnorder.Location = new System.Drawing.Point(135, 392);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(85, 31);
            this.btnorder.TabIndex = 30;
            this.btnorder.Text = "Request";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label5.Location = new System.Drawing.Point(268, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Customer Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(390, 403);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 19);
            this.txtName.TabIndex = 32;
            this.txtName.Text = "Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 35;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1, -6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(785, 56);
            this.label6.TabIndex = 34;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(394, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 1);
            this.panel1.TabIndex = 36;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncart3);
            this.Controls.Add(this.btncart4);
            this.Controls.Add(this.btncart2);
            this.Controls.Add(this.btncart1);
            this.Controls.Add(this.comQuantity);
            this.Controls.Add(this.btmAdd);
            this.Controls.Add(this.btmremove);
            this.Controls.Add(this.btmclear);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtsersh);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dash bord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CartForm_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtsersh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button btmclear;
        private System.Windows.Forms.Button btmremove;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.NumericUpDown comQuantity;
        private System.Windows.Forms.Button btncart1;
        private System.Windows.Forms.Button btncart2;
        private System.Windows.Forms.Button btncart4;
        private System.Windows.Forms.Button btncart3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}