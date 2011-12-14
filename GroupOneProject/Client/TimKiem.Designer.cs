namespace Client
{
    partial class TimKiem
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
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_TimKiem = new System.Windows.Forms.Button();
            this.grid_listMonhoc = new System.Windows.Forms.DataGridView();
            this.Xem = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_ketqua = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listMonhoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ketqua)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(65, 46);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(175, 22);
            this.txt_keyword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa";
            // 
            // but_TimKiem
            // 
            this.but_TimKiem.Location = new System.Drawing.Point(246, 20);
            this.but_TimKiem.Name = "but_TimKiem";
            this.but_TimKiem.Size = new System.Drawing.Size(75, 47);
            this.but_TimKiem.TabIndex = 2;
            this.but_TimKiem.Text = "Tìm";
            this.but_TimKiem.UseVisualStyleBackColor = true;
            this.but_TimKiem.Click += new System.EventHandler(this.but_TimKiem_Click);
            // 
            // grid_listMonhoc
            // 
            this.grid_listMonhoc.AllowUserToAddRows = false;
            this.grid_listMonhoc.AllowUserToDeleteRows = false;
            this.grid_listMonhoc.AllowUserToOrderColumns = true;
            this.grid_listMonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_listMonhoc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grid_listMonhoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_listMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_listMonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xem});
            this.grid_listMonhoc.Location = new System.Drawing.Point(12, 96);
            this.grid_listMonhoc.MultiSelect = false;
            this.grid_listMonhoc.Name = "grid_listMonhoc";
            this.grid_listMonhoc.ReadOnly = true;
            this.grid_listMonhoc.RowHeadersVisible = false;
            this.grid_listMonhoc.Size = new System.Drawing.Size(612, 134);
            this.grid_listMonhoc.TabIndex = 3;
            this.grid_listMonhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_listMonhoc_CellContentClick);
            // 
            // Xem
            // 
            this.Xem.HeaderText = "Xem điểm";
            this.Xem.Name = "Xem";
            this.Xem.ReadOnly = true;
            this.Xem.Text = "Xem điểm";
            this.Xem.UseColumnTextForLinkValue = true;
            this.Xem.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MaMH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_keyword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.but_TimKiem);
            this.groupBox1.Location = new System.Drawing.Point(234, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txt_MaMH
            // 
            this.txt_MaMH.Location = new System.Drawing.Point(65, 20);
            this.txt_MaMH.Name = "txt_MaMH";
            this.txt_MaMH.Size = new System.Drawing.Size(175, 22);
            this.txt_MaMH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã MH";
            // 
            // grid_ketqua
            // 
            this.grid_ketqua.AllowUserToAddRows = false;
            this.grid_ketqua.AllowUserToDeleteRows = false;
            this.grid_ketqua.AllowUserToOrderColumns = true;
            this.grid_ketqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_ketqua.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_ketqua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ketqua.Location = new System.Drawing.Point(12, 237);
            this.grid_ketqua.MultiSelect = false;
            this.grid_ketqua.Name = "grid_ketqua";
            this.grid_ketqua.ReadOnly = true;
            this.grid_ketqua.RowHeadersVisible = false;
            this.grid_ketqua.Size = new System.Drawing.Size(612, 81);
            this.grid_ketqua.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(6, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 32);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tìm kiếm";
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 327);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grid_ketqua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_listMonhoc);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(593, 365);
            this.Name = "TimKiem";
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_listMonhoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ketqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_TimKiem;
        private System.Windows.Forms.DataGridView grid_listMonhoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_ketqua;
        private System.Windows.Forms.TextBox txt_MaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewLinkColumn Xem;
        private System.Windows.Forms.Label label12;
    }
}