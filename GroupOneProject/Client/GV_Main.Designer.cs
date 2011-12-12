namespace Client
{
    partial class GV_Main
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
            this.grib_All_Subject = new System.Windows.Forms.DataGridView();
            this.Xem = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cbo_hocky = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_xem = new System.Windows.Forms.Button();
            this.llbl_Username = new System.Windows.Forms.LinkLabel();
            this.llbl_logout = new System.Windows.Forms.LinkLabel();
            this.gbb_pass = new System.Windows.Forms.GroupBox();
            this.but_ok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_passnew = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_passold = new System.Windows.Forms.TextBox();
            this.lbl_changpass = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.but_phanhoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grib_All_Subject)).BeginInit();
            this.gbb_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // grib_All_Subject
            // 
            this.grib_All_Subject.AllowUserToAddRows = false;
            this.grib_All_Subject.AllowUserToDeleteRows = false;
            this.grib_All_Subject.AllowUserToOrderColumns = true;
            this.grib_All_Subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grib_All_Subject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xem});
            this.grib_All_Subject.Location = new System.Drawing.Point(12, 116);
            this.grib_All_Subject.MultiSelect = false;
            this.grib_All_Subject.Name = "grib_All_Subject";
            this.grib_All_Subject.ReadOnly = true;
            this.grib_All_Subject.RowHeadersVisible = false;
            this.grib_All_Subject.Size = new System.Drawing.Size(551, 166);
            this.grib_All_Subject.TabIndex = 0;
            this.grib_All_Subject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grib_All_Subject_CellContentClick);
            // 
            // Xem
            // 
            this.Xem.HeaderText = "Xem";
            this.Xem.Name = "Xem";
            this.Xem.ReadOnly = true;
            this.Xem.Text = "Xem";
            this.Xem.UseColumnTextForLinkValue = true;
            this.Xem.Width = 50;
            // 
            // cbo_hocky
            // 
            this.cbo_hocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_hocky.FormattingEnabled = true;
            this.cbo_hocky.Location = new System.Drawing.Point(59, 86);
            this.cbo_hocky.Name = "cbo_hocky";
            this.cbo_hocky.Size = new System.Drawing.Size(121, 21);
            this.cbo_hocky.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Học kỳ";
            // 
            // but_xem
            // 
            this.but_xem.Location = new System.Drawing.Point(186, 84);
            this.but_xem.Name = "but_xem";
            this.but_xem.Size = new System.Drawing.Size(75, 23);
            this.but_xem.TabIndex = 3;
            this.but_xem.Text = "Xem";
            this.but_xem.UseVisualStyleBackColor = true;
            this.but_xem.Click += new System.EventHandler(this.but_xem_Click);
            // 
            // llbl_Username
            // 
            this.llbl_Username.AutoSize = true;
            this.llbl_Username.Location = new System.Drawing.Point(5, 9);
            this.llbl_Username.Name = "llbl_Username";
            this.llbl_Username.Size = new System.Drawing.Size(55, 13);
            this.llbl_Username.TabIndex = 4;
            this.llbl_Username.TabStop = true;
            this.llbl_Username.Text = "linkLabel1";
            // 
            // llbl_logout
            // 
            this.llbl_logout.AutoSize = true;
            this.llbl_logout.Location = new System.Drawing.Point(76, 9);
            this.llbl_logout.Name = "llbl_logout";
            this.llbl_logout.Size = new System.Drawing.Size(56, 13);
            this.llbl_logout.TabIndex = 7;
            this.llbl_logout.TabStop = true;
            this.llbl_logout.Text = "Đăng xuất";
            this.llbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_logout_LinkClicked);
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
            this.gbb_pass.Location = new System.Drawing.Point(282, 9);
            this.gbb_pass.Name = "gbb_pass";
            this.gbb_pass.Size = new System.Drawing.Size(281, 92);
            this.gbb_pass.TabIndex = 26;
            this.gbb_pass.TabStop = false;
            this.gbb_pass.Text = "Mật khẩu";
            this.gbb_pass.Visible = false;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(183, 42);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(77, 43);
            this.but_ok.TabIndex = 24;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "MH cũ:";
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Location = new System.Drawing.Point(77, 67);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.Size = new System.Drawing.Size(100, 20);
            this.txt_confirmPass.TabIndex = 23;
            this.txt_confirmPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "MH mới:";
            // 
            // txt_passnew
            // 
            this.txt_passnew.Location = new System.Drawing.Point(77, 43);
            this.txt_passnew.Name = "txt_passnew";
            this.txt_passnew.Size = new System.Drawing.Size(100, 20);
            this.txt_passnew.TabIndex = 22;
            this.txt_passnew.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Xác nhận:";
            // 
            // txt_passold
            // 
            this.txt_passold.Location = new System.Drawing.Point(77, 20);
            this.txt_passold.Name = "txt_passold";
            this.txt_passold.Size = new System.Drawing.Size(100, 20);
            this.txt_passold.TabIndex = 21;
            this.txt_passold.UseSystemPasswordChar = true;
            // 
            // lbl_changpass
            // 
            this.lbl_changpass.AutoSize = true;
            this.lbl_changpass.Location = new System.Drawing.Point(140, 9);
            this.lbl_changpass.Name = "lbl_changpass";
            this.lbl_changpass.Size = new System.Drawing.Size(70, 13);
            this.lbl_changpass.TabIndex = 25;
            this.lbl_changpass.TabStop = true;
            this.lbl_changpass.Text = "Đổi mật khẩu";
            this.lbl_changpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_changpass_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Thông tin lớp môn học";
            // 
            // but_phanhoi
            // 
            this.but_phanhoi.Location = new System.Drawing.Point(469, 319);
            this.but_phanhoi.Name = "but_phanhoi";
            this.but_phanhoi.Size = new System.Drawing.Size(94, 41);
            this.but_phanhoi.TabIndex = 28;
            this.but_phanhoi.Text = "Phản hồi";
            this.but_phanhoi.UseVisualStyleBackColor = true;
            this.but_phanhoi.Click += new System.EventHandler(this.but_phanhoi_Click);
            // 
            // GV_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 372);
            this.Controls.Add(this.but_phanhoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_xem);
            this.Controls.Add(this.gbb_pass);
            this.Controls.Add(this.lbl_changpass);
            this.Controls.Add(this.llbl_logout);
            this.Controls.Add(this.llbl_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_hocky);
            this.Controls.Add(this.grib_All_Subject);
            this.Name = "GV_Main";
            this.Text = "Giảng viên";
            this.Load += new System.EventHandler(this.GV_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grib_All_Subject)).EndInit();
            this.gbb_pass.ResumeLayout(false);
            this.gbb_pass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_hocky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_xem;
        private System.Windows.Forms.LinkLabel llbl_Username;
        private System.Windows.Forms.DataGridViewLinkColumn Xem;
        private System.Windows.Forms.DataGridView grib_All_Subject;
        private System.Windows.Forms.LinkLabel llbl_logout;
        private System.Windows.Forms.GroupBox gbb_pass;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_confirmPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_passnew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_passold;
        private System.Windows.Forms.LinkLabel lbl_changpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_phanhoi;
    }
}