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
            ((System.ComponentModel.ISupportInitialize)(this.grib_All_Subject)).BeginInit();
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
            this.grib_All_Subject.Size = new System.Drawing.Size(475, 166);
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
            this.llbl_Username.Location = new System.Drawing.Point(315, 25);
            this.llbl_Username.Name = "llbl_Username";
            this.llbl_Username.Size = new System.Drawing.Size(55, 13);
            this.llbl_Username.TabIndex = 4;
            this.llbl_Username.TabStop = true;
            this.llbl_Username.Text = "linkLabel1";
            // 
            // llbl_logout
            // 
            this.llbl_logout.AutoSize = true;
            this.llbl_logout.Location = new System.Drawing.Point(388, 25);
            this.llbl_logout.Name = "llbl_logout";
            this.llbl_logout.Size = new System.Drawing.Size(56, 13);
            this.llbl_logout.TabIndex = 7;
            this.llbl_logout.TabStop = true;
            this.llbl_logout.Text = "Đăng xuất";
            this.llbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_logout_LinkClicked);
            // 
            // GV_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 372);
            this.Controls.Add(this.llbl_logout);
            this.Controls.Add(this.llbl_Username);
            this.Controls.Add(this.but_xem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_hocky);
            this.Controls.Add(this.grib_All_Subject);
            this.Name = "GV_Main";
            this.Text = "Giảng viên";
            this.Load += new System.EventHandler(this.GV_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grib_All_Subject)).EndInit();
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
    }
}