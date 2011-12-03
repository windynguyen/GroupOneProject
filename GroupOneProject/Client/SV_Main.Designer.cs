namespace Client
{
    partial class SV_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_listHK = new System.Windows.Forms.ComboBox();
            this.but_show = new System.Windows.Forms.Button();
            this.llbl_mssv = new System.Windows.Forms.LinkLabel();
            this.llbl_logout = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TCDK = new System.Windows.Forms.Label();
            this.lbl_TCDAT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_TBHK = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.but_ThongKe = new System.Windows.Forms.Button();
            this.grid_KetQua = new System.Windows.Forms.DataGridView();
            this.lbl_changpass = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_passold = new System.Windows.Forms.TextBox();
            this.txt_passnew = new System.Windows.Forms.TextBox();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.gbb_pass = new System.Windows.Forms.GroupBox();
            this.but_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).BeginInit();
            this.gbb_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem kết quả học tập";
            // 
            // cbo_listHK
            // 
            this.cbo_listHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_listHK.FormattingEnabled = true;
            this.cbo_listHK.Location = new System.Drawing.Point(54, 118);
            this.cbo_listHK.Name = "cbo_listHK";
            this.cbo_listHK.Size = new System.Drawing.Size(121, 21);
            this.cbo_listHK.TabIndex = 2;
            // 
            // but_show
            // 
            this.but_show.Location = new System.Drawing.Point(181, 118);
            this.but_show.Name = "but_show";
            this.but_show.Size = new System.Drawing.Size(77, 23);
            this.but_show.TabIndex = 3;
            this.but_show.Text = "Xem";
            this.but_show.UseVisualStyleBackColor = true;
            this.but_show.Click += new System.EventHandler(this.but_show_Click);
            // 
            // llbl_mssv
            // 
            this.llbl_mssv.AutoSize = true;
            this.llbl_mssv.Location = new System.Drawing.Point(474, 22);
            this.llbl_mssv.Name = "llbl_mssv";
            this.llbl_mssv.Size = new System.Drawing.Size(42, 13);
            this.llbl_mssv.TabIndex = 5;
            this.llbl_mssv.TabStop = true;
            this.llbl_mssv.Text = "[MSSV]";
            this.llbl_mssv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_mssv_LinkClicked);
            // 
            // llbl_logout
            // 
            this.llbl_logout.AutoSize = true;
            this.llbl_logout.Location = new System.Drawing.Point(540, 22);
            this.llbl_logout.Name = "llbl_logout";
            this.llbl_logout.Size = new System.Drawing.Size(60, 13);
            this.llbl_logout.TabIndex = 6;
            this.llbl_logout.TabStop = true;
            this.llbl_logout.Text = "Đăng xuất";
            this.llbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_logout_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MSSV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Học kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số TC đăng ký:";
            // 
            // lbl_TCDK
            // 
            this.lbl_TCDK.AutoSize = true;
            this.lbl_TCDK.Location = new System.Drawing.Point(101, 399);
            this.lbl_TCDK.Name = "lbl_TCDK";
            this.lbl_TCDK.Size = new System.Drawing.Size(51, 13);
            this.lbl_TCDK.TabIndex = 10;
            this.lbl_TCDK.Text = "lbl_TCDK";
            // 
            // lbl_TCDAT
            // 
            this.lbl_TCDAT.AutoSize = true;
            this.lbl_TCDAT.Location = new System.Drawing.Point(101, 423);
            this.lbl_TCDAT.Name = "lbl_TCDAT";
            this.lbl_TCDAT.Size = new System.Drawing.Size(57, 13);
            this.lbl_TCDAT.TabIndex = 12;
            this.lbl_TCDAT.Text = "lbl_TCDAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số TC đạt:";
            // 
            // lbl_TBHK
            // 
            this.lbl_TBHK.AutoSize = true;
            this.lbl_TBHK.Location = new System.Drawing.Point(101, 445);
            this.lbl_TBHK.Name = "lbl_TBHK";
            this.lbl_TBHK.Size = new System.Drawing.Size(51, 13);
            this.lbl_TBHK.TabIndex = 14;
            this.lbl_TBHK.Text = "lbl_TBHK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Trung bình HK:";
            // 
            // but_ThongKe
            // 
            this.but_ThongKe.Location = new System.Drawing.Point(211, 399);
            this.but_ThongKe.Name = "but_ThongKe";
            this.but_ThongKe.Size = new System.Drawing.Size(93, 23);
            this.but_ThongKe.TabIndex = 15;
            this.but_ThongKe.Text = "Thống kê";
            this.but_ThongKe.UseVisualStyleBackColor = true;
            this.but_ThongKe.Click += new System.EventHandler(this.but_ThongKe_Click);
            // 
            // grid_KetQua
            // 
            this.grid_KetQua.AllowUserToAddRows = false;
            this.grid_KetQua.AllowUserToDeleteRows = false;
            this.grid_KetQua.AllowUserToOrderColumns = true;
            this.grid_KetQua.AllowUserToResizeRows = false;
            this.grid_KetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_KetQua.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.grid_KetQua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_KetQua.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid_KetQua.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.grid_KetQua.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.grid_KetQua.Location = new System.Drawing.Point(15, 164);
            this.grid_KetQua.MultiSelect = false;
            this.grid_KetQua.Name = "grid_KetQua";
            this.grid_KetQua.ReadOnly = true;
            this.grid_KetQua.RowHeadersVisible = false;
            this.grid_KetQua.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grid_KetQua.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Gray;
            this.grid_KetQua.RowTemplate.ReadOnly = true;
            this.grid_KetQua.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_KetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid_KetQua.ShowEditingIcon = false;
            this.grid_KetQua.Size = new System.Drawing.Size(680, 197);
            this.grid_KetQua.TabIndex = 16;
            // 
            // lbl_changpass
            // 
            this.lbl_changpass.AutoSize = true;
            this.lbl_changpass.Location = new System.Drawing.Point(475, 45);
            this.lbl_changpass.Name = "lbl_changpass";
            this.lbl_changpass.Size = new System.Drawing.Size(76, 13);
            this.lbl_changpass.TabIndex = 17;
            this.lbl_changpass.TabStop = true;
            this.lbl_changpass.Text = "Đổi mật khẩu";
            this.lbl_changpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_changpass_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "MH cũ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "MH mới:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Xác nhận:";
            // 
            // txt_passold
            // 
            this.txt_passold.Location = new System.Drawing.Point(80, 20);
            this.txt_passold.Name = "txt_passold";
            this.txt_passold.Size = new System.Drawing.Size(100, 22);
            this.txt_passold.TabIndex = 21;
            this.txt_passold.UseSystemPasswordChar = true;
            // 
            // txt_passnew
            // 
            this.txt_passnew.Location = new System.Drawing.Point(80, 43);
            this.txt_passnew.Name = "txt_passnew";
            this.txt_passnew.Size = new System.Drawing.Size(100, 22);
            this.txt_passnew.TabIndex = 22;
            this.txt_passnew.UseSystemPasswordChar = true;
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Location = new System.Drawing.Point(80, 67);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.Size = new System.Drawing.Size(100, 22);
            this.txt_confirmPass.TabIndex = 23;
            this.txt_confirmPass.UseSystemPasswordChar = true;
            // 
            // gbb_pass
            // 
            this.gbb_pass.Controls.Add(this.but_ok);
            this.gbb_pass.Controls.Add(this.label5);
            this.gbb_pass.Controls.Add(this.txt_confirmPass);
            this.gbb_pass.Controls.Add(this.label7);
            this.gbb_pass.Controls.Add(this.txt_passnew);
            this.gbb_pass.Controls.Add(this.label9);
            this.gbb_pass.Controls.Add(this.txt_passold);
            this.gbb_pass.Location = new System.Drawing.Point(426, 66);
            this.gbb_pass.Name = "gbb_pass";
            this.gbb_pass.Size = new System.Drawing.Size(269, 92);
            this.gbb_pass.TabIndex = 24;
            this.gbb_pass.TabStop = false;
            this.gbb_pass.Text = "Mật khẩu";
            this.gbb_pass.Visible = false;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(186, 42);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(77, 43);
            this.but_ok.TabIndex = 24;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // SV_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 483);
            this.Controls.Add(this.gbb_pass);
            this.Controls.Add(this.lbl_changpass);
            this.Controls.Add(this.grid_KetQua);
            this.Controls.Add(this.but_ThongKe);
            this.Controls.Add(this.lbl_TBHK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_TCDAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_TCDK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llbl_logout);
            this.Controls.Add(this.llbl_mssv);
            this.Controls.Add(this.but_show);
            this.Controls.Add(this.cbo_listHK);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SV_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).EndInit();
            this.gbb_pass.ResumeLayout(false);
            this.gbb_pass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_listHK;
        private System.Windows.Forms.Button but_show;
        private System.Windows.Forms.LinkLabel llbl_mssv;
        private System.Windows.Forms.LinkLabel llbl_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TCDK;
        private System.Windows.Forms.Label lbl_TCDAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_TBHK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_ThongKe;
        private System.Windows.Forms.DataGridView grid_KetQua;
        private System.Windows.Forms.LinkLabel lbl_changpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_passold;
        private System.Windows.Forms.TextBox txt_passnew;
        private System.Windows.Forms.TextBox txt_confirmPass;
        private System.Windows.Forms.GroupBox gbb_pass;
        private System.Windows.Forms.Button but_ok;
    }
}