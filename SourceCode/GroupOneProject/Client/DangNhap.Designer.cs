﻿namespace Client
{
    partial class DangNhap
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
            this.but_Login = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdo_sinhvien = new System.Windows.Forms.RadioButton();
            this.rdo_phuhuynh = new System.Windows.Forms.RadioButton();
            this.rdo_giangvien = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // but_Login
            // 
            this.but_Login.Location = new System.Drawing.Point(163, 174);
            this.but_Login.Name = "but_Login";
            this.but_Login.Size = new System.Drawing.Size(75, 34);
            this.but_Login.TabIndex = 0;
            this.but_Login.Text = "Login";
            this.but_Login.UseVisualStyleBackColor = true;
            this.but_Login.Click += new System.EventHandler(this.but_Login_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(110, 32);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(128, 20);
            this.txt_username.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(110, 66);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(128, 20);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // rdo_sinhvien
            // 
            this.rdo_sinhvien.AutoSize = true;
            this.rdo_sinhvien.Checked = true;
            this.rdo_sinhvien.Location = new System.Drawing.Point(110, 96);
            this.rdo_sinhvien.Name = "rdo_sinhvien";
            this.rdo_sinhvien.Size = new System.Drawing.Size(69, 17);
            this.rdo_sinhvien.TabIndex = 5;
            this.rdo_sinhvien.TabStop = true;
            this.rdo_sinhvien.Text = "Sinh viên";
            this.rdo_sinhvien.UseVisualStyleBackColor = true;
            // 
            // rdo_phuhuynh
            // 
            this.rdo_phuhuynh.AutoSize = true;
            this.rdo_phuhuynh.Location = new System.Drawing.Point(110, 119);
            this.rdo_phuhuynh.Name = "rdo_phuhuynh";
            this.rdo_phuhuynh.Size = new System.Drawing.Size(76, 17);
            this.rdo_phuhuynh.TabIndex = 6;
            this.rdo_phuhuynh.Text = "Phụ huynh";
            this.rdo_phuhuynh.UseVisualStyleBackColor = true;
            // 
            // rdo_giangvien
            // 
            this.rdo_giangvien.AutoSize = true;
            this.rdo_giangvien.Location = new System.Drawing.Point(110, 142);
            this.rdo_giangvien.Name = "rdo_giangvien";
            this.rdo_giangvien.Size = new System.Drawing.Size(76, 17);
            this.rdo_giangvien.TabIndex = 7;
            this.rdo_giangvien.Text = "Giảng viên";
            this.rdo_giangvien.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 220);
            this.Controls.Add(this.rdo_giangvien);
            this.Controls.Add(this.rdo_phuhuynh);
            this.Controls.Add(this.rdo_sinhvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.but_Login);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Login;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdo_sinhvien;
        private System.Windows.Forms.RadioButton rdo_phuhuynh;
        private System.Windows.Forms.RadioButton rdo_giangvien;
    }
}