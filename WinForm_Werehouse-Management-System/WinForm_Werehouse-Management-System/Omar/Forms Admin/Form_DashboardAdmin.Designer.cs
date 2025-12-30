namespace WinForm_Werehouse_Management_System
{
    partial class Form_DashboardAdmin
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
            this.btnAccountMang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMinBox = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnSysInfo = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccountMang
            // 
            this.btnAccountMang.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAccountMang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAccountMang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountMang.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountMang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAccountMang.Location = new System.Drawing.Point(204, 187);
            this.btnAccountMang.Name = "btnAccountMang";
            this.btnAccountMang.Size = new System.Drawing.Size(253, 55);
            this.btnAccountMang.TabIndex = 3;
            this.btnAccountMang.Text = "Account Management";
            this.btnAccountMang.UseVisualStyleBackColor = false;
            this.btnAccountMang.Click += new System.EventHandler(this.btnAccountMang_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnMinBox);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.labName);
            this.panel1.Location = new System.Drawing.Point(-5, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 57);
            this.panel1.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLogOut.Location = new System.Drawing.Point(559, 8);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(81, 46);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMinBox
            // 
            this.btnMinBox.BackgroundImage = global::WinForm_Werehouse_Management_System.Properties.Resources.file_00000000785071f49870ab9c3cb76de3__1_;
            this.btnMinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinBox.FlatAppearance.BorderSize = 0;
            this.btnMinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinBox.Location = new System.Drawing.Point(39, 3);
            this.btnMinBox.Name = "btnMinBox";
            this.btnMinBox.Size = new System.Drawing.Size(47, 37);
            this.btnMinBox.TabIndex = 2;
            this.btnMinBox.UseVisualStyleBackColor = true;
            this.btnMinBox.Click += new System.EventHandler(this.btnMinBox_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::WinForm_Werehouse_Management_System.Properties.Resources.تنزيل__2_;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labName.Location = new System.Drawing.Point(165, 14);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(0, 33);
            this.labName.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(335, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 189);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(197, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 184);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(463, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 184);
            this.panel5.TabIndex = 0;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnChangePass.Location = new System.Drawing.Point(121, 284);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(195, 116);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "              Product                               AND                          " +
    "     Category              Managment";
            this.btnChangePass.UseVisualStyleBackColor = false;
            // 
            // btnSysInfo
            // 
            this.btnSysInfo.BackColor = System.Drawing.Color.Orange;
            this.btnSysInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSysInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSysInfo.FlatAppearance.BorderSize = 2;
            this.btnSysInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSysInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSysInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSysInfo.Location = new System.Drawing.Point(358, 284);
            this.btnSysInfo.Name = "btnSysInfo";
            this.btnSysInfo.Size = new System.Drawing.Size(197, 116);
            this.btnSysInfo.TabIndex = 5;
            this.btnSysInfo.Text = "Sales Management";
            this.btnSysInfo.UseVisualStyleBackColor = false;
            this.btnSysInfo.Click += new System.EventHandler(this.btnSysInfo_Click);
            // 
            // pic1
            // 
            this.pic1.Image = global::WinForm_Werehouse_Management_System.Properties.Resources.تنزيل__3_;
            this.pic1.Location = new System.Drawing.Point(220, 58);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(215, 123);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 5;
            this.pic1.TabStop = false;
            // 
            // Form_DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(640, 427);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnSysInfo);
            this.Controls.Add(this.btnAccountMang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DashboardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccountMang;
        private System.Windows.Forms.Button btnSysInfo;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnMinBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogOut;
    }
}