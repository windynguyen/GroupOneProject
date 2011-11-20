namespace Client
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).BeginInit();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_KetQua.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.grid_KetQua.Size = new System.Drawing.Size(654, 197);
            this.grid_KetQua.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 483);
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
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).EndInit();
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
    }
}