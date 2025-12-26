namespace WinForm_admin_module
{
    partial class Form_CreateANDEdit
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
            this.btnCreate_Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbltext = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ComBoxRole = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.btnMinBox = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate_Edit
            // 
            this.btnCreate_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnCreate_Edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreate_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate_Edit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCreate_Edit.Location = new System.Drawing.Point(115, 400);
            this.btnCreate_Edit.Name = "btnCreate_Edit";
            this.btnCreate_Edit.Size = new System.Drawing.Size(106, 38);
            this.btnCreate_Edit.TabIndex = 9;
            this.btnCreate_Edit.Text = "Create";
            this.btnCreate_Edit.UseVisualStyleBackColor = false;
            this.btnCreate_Edit.Click += new System.EventHandler(this.btnCreate_Edit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(27, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 1);
            this.panel2.TabIndex = 20;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Enabled = false;
            this.txtConfirm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirm.Location = new System.Drawing.Point(65, 285);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(238, 18);
            this.txtConfirm.TabIndex = 6;
            this.txtConfirm.Text = "Confirm Password";
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            this.txtConfirm.Enter += new System.EventHandler(this.txtConfirm_Enter);
            this.txtConfirm.Leave += new System.EventHandler(this.txtConfirm_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(27, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 1);
            this.panel1.TabIndex = 18;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(65, 171);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(238, 18);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "UserName";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // lbltext
            // 
            this.lbltext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltext.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lbltext.Location = new System.Drawing.Point(69, 109);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(220, 29);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Create Account";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(27, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 1);
            this.panel3.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(65, 251);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(238, 18);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // ComBoxRole
            // 
            this.ComBoxRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ComBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComBoxRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxRole.ForeColor = System.Drawing.Color.Gray;
            this.ComBoxRole.FormattingEnabled = true;
            this.ComBoxRole.Items.AddRange(new object[] {
            "Select Role ",
            "Admin",
            "Inventory",
            "Sales_man"});
            this.ComBoxRole.Location = new System.Drawing.Point(66, 316);
            this.ComBoxRole.Name = "ComBoxRole";
            this.ComBoxRole.Size = new System.Drawing.Size(236, 26);
            this.ComBoxRole.TabIndex = 8;
            this.ComBoxRole.Enter += new System.EventHandler(this.ComBoxRole_Enter);
            this.ComBoxRole.Leave += new System.EventHandler(this.ComBoxRole_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(26, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 1);
            this.panel4.TabIndex = 28;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Gray;
            this.txtFullName.Location = new System.Drawing.Point(66, 210);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(238, 18);
            this.txtFullName.TabIndex = 4;
            this.txtFullName.Text = "Full Name";
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // pic4
            // 
            this.pic4.Image = global::WinForm_admin_module.Properties.Resources._4686696;
            this.pic4.Location = new System.Drawing.Point(26, 243);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(33, 26);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 25;
            this.pic4.TabStop = false;
            // 
            // btnMinBox
            // 
            this.btnMinBox.BackgroundImage = global::WinForm_admin_module.Properties.Resources.تنزيل__5_;
            this.btnMinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinBox.FlatAppearance.BorderSize = 0;
            this.btnMinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinBox.Location = new System.Drawing.Point(38, 0);
            this.btnMinBox.Name = "btnMinBox";
            this.btnMinBox.Size = new System.Drawing.Size(50, 37);
            this.btnMinBox.TabIndex = 2;
            this.btnMinBox.UseVisualStyleBackColor = true;
            this.btnMinBox.Click += new System.EventHandler(this.btnMinBox_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackgroundImage = global::WinForm_admin_module.Properties.Resources.تنزيل;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(309, 243);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(39, 60);
            this.btnShowPassword.TabIndex = 7;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::WinForm_admin_module.Properties.Resources.تنزيل__2_;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pic5
            // 
            this.pic5.Image = global::WinForm_admin_module.Properties.Resources._4686696;
            this.pic5.Location = new System.Drawing.Point(26, 281);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(33, 26);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5.TabIndex = 19;
            this.pic5.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::WinForm_admin_module.Properties.Resources._7153150;
            this.pic2.Location = new System.Drawing.Point(26, 163);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(33, 26);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 17;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::WinForm_admin_module.Properties.Resources._11284777;
            this.pic1.Location = new System.Drawing.Point(115, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(106, 85);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 15;
            this.pic1.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.Image = global::WinForm_admin_module.Properties.Resources.file_000000000b4c720aa4c013b126142c3e;
            this.pic6.Location = new System.Drawing.Point(26, 316);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(33, 34);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic6.TabIndex = 31;
            this.pic6.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::WinForm_admin_module.Properties.Resources._7153150;
            this.pic3.Location = new System.Drawing.Point(26, 204);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(33, 26);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 32;
            this.pic3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(28, 348);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 1);
            this.panel5.TabIndex = 33;
            // 
            // Form_CreateANDEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ComBoxRole);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnMinBox);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate_Edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CreateANDEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_CreateANDEdit_FormClosed);
            this.Load += new System.EventHandler(this.Form_CreateANDEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinBox;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreate_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox ComBoxRole;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Panel panel5;
    }
}