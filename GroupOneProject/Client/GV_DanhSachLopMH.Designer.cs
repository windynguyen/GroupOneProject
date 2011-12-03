namespace Client
{
    partial class GV_DanhSachLopMH
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
            this.grid_danhsachlop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_maMH = new System.Windows.Forms.Label();
            this.lbl_tenMH = new System.Windows.Forms.Label();
            this.lbl_hocky = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_avg = new System.Windows.Forms.TextBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.txt_8_10 = new System.Windows.Forms.TextBox();
            this.txt_siso = new System.Windows.Forms.TextBox();
            this.txt_5_8 = new System.Windows.Forms.TextBox();
            this.txt_duoi5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_danhsachlop)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_danhsachlop
            // 
            this.grid_danhsachlop.AllowUserToAddRows = false;
            this.grid_danhsachlop.AllowUserToDeleteRows = false;
            this.grid_danhsachlop.AllowUserToOrderColumns = true;
            this.grid_danhsachlop.AllowUserToResizeRows = false;
            this.grid_danhsachlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_danhsachlop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.grid_danhsachlop.Location = new System.Drawing.Point(12, 127);
            this.grid_danhsachlop.MultiSelect = false;
            this.grid_danhsachlop.Name = "grid_danhsachlop";
            this.grid_danhsachlop.ReadOnly = true;
            this.grid_danhsachlop.RowHeadersVisible = false;
            this.grid_danhsachlop.Size = new System.Drawing.Size(618, 183);
            this.grid_danhsachlop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sinh viên lớp môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Học kỳ:";
            // 
            // lbl_maMH
            // 
            this.lbl_maMH.AutoSize = true;
            this.lbl_maMH.Location = new System.Drawing.Point(108, 67);
            this.lbl_maMH.Name = "lbl_maMH";
            this.lbl_maMH.Size = new System.Drawing.Size(35, 13);
            this.lbl_maMH.TabIndex = 5;
            this.lbl_maMH.Text = "label5";
            // 
            // lbl_tenMH
            // 
            this.lbl_tenMH.AutoSize = true;
            this.lbl_tenMH.Location = new System.Drawing.Point(108, 89);
            this.lbl_tenMH.Name = "lbl_tenMH";
            this.lbl_tenMH.Size = new System.Drawing.Size(35, 13);
            this.lbl_tenMH.TabIndex = 6;
            this.lbl_tenMH.Text = "label6";
            // 
            // lbl_hocky
            // 
            this.lbl_hocky.AutoSize = true;
            this.lbl_hocky.Location = new System.Drawing.Point(244, 67);
            this.lbl_hocky.Name = "lbl_hocky";
            this.lbl_hocky.Size = new System.Drawing.Size(35, 13);
            this.lbl_hocky.TabIndex = 7;
            this.lbl_hocky.Text = "label7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_avg);
            this.groupBox1.Controls.Add(this.txt_min);
            this.groupBox1.Controls.Add(this.txt_max);
            this.groupBox1.Controls.Add(this.txt_8_10);
            this.groupBox1.Controls.Add(this.txt_siso);
            this.groupBox1.Controls.Add(this.txt_5_8);
            this.groupBox1.Controls.Add(this.txt_duoi5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // txt_avg
            // 
            this.txt_avg.Enabled = false;
            this.txt_avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_avg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_avg.Location = new System.Drawing.Point(278, 114);
            this.txt_avg.Name = "txt_avg";
            this.txt_avg.Size = new System.Drawing.Size(53, 20);
            this.txt_avg.TabIndex = 13;
            // 
            // txt_min
            // 
            this.txt_min.Enabled = false;
            this.txt_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_min.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_min.Location = new System.Drawing.Point(278, 85);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(53, 20);
            this.txt_min.TabIndex = 12;
            // 
            // txt_max
            // 
            this.txt_max.Enabled = false;
            this.txt_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_max.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_max.Location = new System.Drawing.Point(278, 56);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(53, 20);
            this.txt_max.TabIndex = 11;
            // 
            // txt_8_10
            // 
            this.txt_8_10.Enabled = false;
            this.txt_8_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_8_10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_8_10.Location = new System.Drawing.Point(69, 114);
            this.txt_8_10.Name = "txt_8_10";
            this.txt_8_10.Size = new System.Drawing.Size(53, 20);
            this.txt_8_10.TabIndex = 10;
            // 
            // txt_siso
            // 
            this.txt_siso.Enabled = false;
            this.txt_siso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_siso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_siso.Location = new System.Drawing.Point(69, 25);
            this.txt_siso.Name = "txt_siso";
            this.txt_siso.Size = new System.Drawing.Size(53, 20);
            this.txt_siso.TabIndex = 9;
            // 
            // txt_5_8
            // 
            this.txt_5_8.Enabled = false;
            this.txt_5_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_5_8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_5_8.Location = new System.Drawing.Point(69, 85);
            this.txt_5_8.Name = "txt_5_8";
            this.txt_5_8.Size = new System.Drawing.Size(53, 20);
            this.txt_5_8.TabIndex = 8;
            // 
            // txt_duoi5
            // 
            this.txt_duoi5.Enabled = false;
            this.txt_duoi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duoi5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_duoi5.Location = new System.Drawing.Point(69, 56);
            this.txt_duoi5.Name = "txt_duoi5";
            this.txt_duoi5.Size = new System.Drawing.Size(53, 20);
            this.txt_duoi5.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Điểm trung bình:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Điểm nhỏ nhất:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Điểm lớn nhất:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "[8,10]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "[5,8)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "<5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sỉ số";
            // 
            // GV_DanhSachLopMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_hocky);
            this.Controls.Add(this.lbl_tenMH);
            this.Controls.Add(this.lbl_maMH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_danhsachlop);
            this.Name = "GV_DanhSachLopMH";
            this.Text = "Danh sách lớp";
            this.Load += new System.EventHandler(this.GV_DanhSachLopMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_danhsachlop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_danhsachlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_maMH;
        private System.Windows.Forms.Label lbl_tenMH;
        private System.Windows.Forms.Label lbl_hocky;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_avg;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.TextBox txt_8_10;
        private System.Windows.Forms.TextBox txt_siso;
        private System.Windows.Forms.TextBox txt_5_8;
        private System.Windows.Forms.TextBox txt_duoi5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}