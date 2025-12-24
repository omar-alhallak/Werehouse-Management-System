namespace WinForm_admin_module
{
    partial class Form_LogIN
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
            this.NameApp = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSign_IN = new System.Windows.Forms.Button();
            this.btnMinBox = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameApp
            // 
            this.NameApp.Font = new System.Drawing.Font("Tahoma", 13F);
            this.NameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.NameApp.Location = new System.Drawing.Point(33, 110);
            this.NameApp.Name = "NameApp";
            this.NameApp.Size = new System.Drawing.Size(269, 29);
            this.NameApp.TabIndex = 1;
            this.NameApp.Text = "Warehouse Management System ";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(64, 171);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(238, 18);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TabStop = false;
            this.txtUserName.Text = "UserName";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(26, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(26, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 1);
            this.panel2.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(64, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(238, 18);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnSign_IN
            // 
            this.btnSign_IN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSign_IN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSign_IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign_IN.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign_IN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSign_IN.Location = new System.Drawing.Point(114, 284);
            this.btnSign_IN.Name = "btnSign_IN";
            this.btnSign_IN.Size = new System.Drawing.Size(106, 38);
            this.btnSign_IN.TabIndex = 0;
            this.btnSign_IN.TabStop = false;
            this.btnSign_IN.Text = "Sign IN";
            this.btnSign_IN.UseVisualStyleBackColor = false;
            this.btnSign_IN.Click += new System.EventHandler(this.btnSign_IN_Click);
            // 
            // btnMinBox
            // 
            this.btnMinBox.BackgroundImage = global::WinForm_admin_module.Properties.Resources.تنزيل__5_;
            this.btnMinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinBox.FlatAppearance.BorderSize = 0;
            this.btnMinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinBox.Location = new System.Drawing.Point(37, 0);
            this.btnMinBox.Name = "btnMinBox";
            this.btnMinBox.Size = new System.Drawing.Size(50, 37);
            this.btnMinBox.TabIndex = 11;
            this.btnMinBox.UseVisualStyleBackColor = true;
            this.btnMinBox.Click += new System.EventHandler(this.btnMinBox_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackgroundImage = global::WinForm_admin_module.Properties.Resources.تنزيل;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(308, 204);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(39, 39);
            this.btnShowPassword.TabIndex = 10;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::WinForm_admin_module.Properties.Resources.تنزيل__2_;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pic3
            // 
            this.pic3.Image = global::WinForm_admin_module.Properties.Resources._4686696;
            this.pic3.Location = new System.Drawing.Point(25, 204);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(33, 26);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 7;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::WinForm_admin_module.Properties.Resources._7153150;
            this.pic2.Location = new System.Drawing.Point(25, 163);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(33, 26);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 4;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::WinForm_admin_module.Properties.Resources._11284777;
            this.pic1.Location = new System.Drawing.Point(114, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(106, 85);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // Form_LogIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(359, 334);
            this.Controls.Add(this.btnMinBox);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSign_IN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.NameApp);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_LogIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_LogIN_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label NameApp;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSign_IN;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnMinBox;
    }
}

