namespace Client
{
    partial class PhanHoi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_viet = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_huy = new System.Windows.Forms.Button();
            this.but_gui = new System.Windows.Forms.Button();
            this.txt_NoiDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TieuDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_nhan = new System.Windows.Forms.TabPage();
            this.grid_reply = new System.Windows.Forms.DataGridView();
            this.Xem = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.lbl_content = new System.Windows.Forms.Label();
            this.lbl_reply = new System.Windows.Forms.Label();
            this.grb_mess = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.txt_reply = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_viet.SuspendLayout();
            this.tab_nhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reply)).BeginInit();
            this.grb_mess.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_viet);
            this.tabControl1.Controls.Add(this.tab_nhan);
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 378);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tab_viet
            // 
            this.tab_viet.Controls.Add(this.label4);
            this.tab_viet.Controls.Add(this.label3);
            this.tab_viet.Controls.Add(this.but_huy);
            this.tab_viet.Controls.Add(this.but_gui);
            this.tab_viet.Controls.Add(this.txt_NoiDung);
            this.tab_viet.Controls.Add(this.label2);
            this.tab_viet.Controls.Add(this.txt_TieuDe);
            this.tab_viet.Controls.Add(this.label1);
            this.tab_viet.Location = new System.Drawing.Point(4, 22);
            this.tab_viet.Name = "tab_viet";
            this.tab_viet.Padding = new System.Windows.Forms.Padding(3);
            this.tab_viet.Size = new System.Drawing.Size(531, 352);
            this.tab_viet.TabIndex = 0;
            this.tab_viet.Text = "Gửi";
            this.tab_viet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(51, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(47, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "*";
            // 
            // but_huy
            // 
            this.but_huy.Location = new System.Drawing.Point(329, 233);
            this.but_huy.Name = "but_huy";
            this.but_huy.Size = new System.Drawing.Size(75, 32);
            this.but_huy.TabIndex = 5;
            this.but_huy.Text = "Hủy";
            this.but_huy.UseVisualStyleBackColor = true;
            this.but_huy.Click += new System.EventHandler(this.but_huy_Click);
            // 
            // but_gui
            // 
            this.but_gui.Location = new System.Drawing.Point(248, 233);
            this.but_gui.Name = "but_gui";
            this.but_gui.Size = new System.Drawing.Size(75, 32);
            this.but_gui.TabIndex = 4;
            this.but_gui.Text = "Gửi";
            this.but_gui.UseVisualStyleBackColor = true;
            this.but_gui.Click += new System.EventHandler(this.but_gui_Click);
            // 
            // txt_NoiDung
            // 
            this.txt_NoiDung.Location = new System.Drawing.Point(67, 58);
            this.txt_NoiDung.Multiline = true;
            this.txt_NoiDung.Name = "txt_NoiDung";
            this.txt_NoiDung.Size = new System.Drawing.Size(392, 146);
            this.txt_NoiDung.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung";
            // 
            // txt_TieuDe
            // 
            this.txt_TieuDe.Location = new System.Drawing.Point(66, 22);
            this.txt_TieuDe.Name = "txt_TieuDe";
            this.txt_TieuDe.Size = new System.Drawing.Size(100, 20);
            this.txt_TieuDe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề";
            // 
            // tab_nhan
            // 
            this.tab_nhan.Controls.Add(this.grb_mess);
            this.tab_nhan.Controls.Add(this.grid_reply);
            this.tab_nhan.Location = new System.Drawing.Point(4, 22);
            this.tab_nhan.Name = "tab_nhan";
            this.tab_nhan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_nhan.Size = new System.Drawing.Size(531, 352);
            this.tab_nhan.TabIndex = 1;
            this.tab_nhan.Text = "Nhận";
            this.tab_nhan.UseVisualStyleBackColor = true;
            // 
            // grid_reply
            // 
            this.grid_reply.AllowUserToAddRows = false;
            this.grid_reply.AllowUserToDeleteRows = false;
            this.grid_reply.AllowUserToOrderColumns = true;
            this.grid_reply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_reply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xem});
            this.grid_reply.Location = new System.Drawing.Point(0, 6);
            this.grid_reply.MultiSelect = false;
            this.grid_reply.Name = "grid_reply";
            this.grid_reply.ReadOnly = true;
            this.grid_reply.RowHeadersVisible = false;
            this.grid_reply.Size = new System.Drawing.Size(525, 145);
            this.grid_reply.TabIndex = 1;
            this.grid_reply.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_reply_CellContentClick);
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
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Location = new System.Drawing.Point(212, -7);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(40, 13);
            this.lbl_sub.TabIndex = 0;
            this.lbl_sub.Text = "lbl_sub";
            this.lbl_sub.Visible = false;
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.Location = new System.Drawing.Point(212, 16);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(59, 13);
            this.lbl_content.TabIndex = 1;
            this.lbl_content.Text = "lbl_content";
            this.lbl_content.Visible = false;
            // 
            // lbl_reply
            // 
            this.lbl_reply.AutoSize = true;
            this.lbl_reply.Location = new System.Drawing.Point(212, 39);
            this.lbl_reply.Name = "lbl_reply";
            this.lbl_reply.Size = new System.Drawing.Size(35, 13);
            this.lbl_reply.TabIndex = 2;
            this.lbl_reply.Text = "label5";
            this.lbl_reply.Visible = false;
            // 
            // grb_mess
            // 
            this.grb_mess.Controls.Add(this.txt_reply);
            this.grb_mess.Controls.Add(this.txt_content);
            this.grb_mess.Controls.Add(this.txt_sub);
            this.grb_mess.Controls.Add(this.label7);
            this.grb_mess.Controls.Add(this.label6);
            this.grb_mess.Controls.Add(this.label5);
            this.grb_mess.Controls.Add(this.lbl_reply);
            this.grb_mess.Controls.Add(this.lbl_content);
            this.grb_mess.Controls.Add(this.lbl_sub);
            this.grb_mess.Location = new System.Drawing.Point(6, 157);
            this.grb_mess.Name = "grb_mess";
            this.grb_mess.Size = new System.Drawing.Size(519, 191);
            this.grb_mess.TabIndex = 2;
            this.grb_mess.TabStop = false;
            this.grb_mess.Text = "Content";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Trả lời:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nội dung:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tiêu đề:";
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(54, 27);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.ReadOnly = true;
            this.txt_sub.Size = new System.Drawing.Size(100, 20);
            this.txt_sub.TabIndex = 6;
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(54, 55);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.ReadOnly = true;
            this.txt_content.Size = new System.Drawing.Size(367, 54);
            this.txt_content.TabIndex = 7;
            // 
            // txt_reply
            // 
            this.txt_reply.Location = new System.Drawing.Point(54, 123);
            this.txt_reply.Multiline = true;
            this.txt_reply.Name = "txt_reply";
            this.txt_reply.ReadOnly = true;
            this.txt_reply.Size = new System.Drawing.Size(367, 62);
            this.txt_reply.TabIndex = 8;
            // 
            // PhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 394);
            this.Controls.Add(this.tabControl1);
            this.Name = "PhanHoi";
            this.Text = "Phản hồi";
            this.tabControl1.ResumeLayout(false);
            this.tab_viet.ResumeLayout(false);
            this.tab_viet.PerformLayout();
            this.tab_nhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_reply)).EndInit();
            this.grb_mess.ResumeLayout(false);
            this.grb_mess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_viet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_huy;
        private System.Windows.Forms.Button but_gui;
        private System.Windows.Forms.TextBox txt_NoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_nhan;
        private System.Windows.Forms.DataGridView grid_reply;
        private System.Windows.Forms.DataGridViewLinkColumn Xem;
        private System.Windows.Forms.GroupBox grb_mess;
        private System.Windows.Forms.Label lbl_reply;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.TextBox txt_reply;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}