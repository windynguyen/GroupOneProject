namespace Client
{
    partial class frmMain_Client
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
            this.btn_Author_BasHttp = new System.Windows.Forms.Button();
            this.lbl_showauthor = new System.Windows.Forms.Label();
            this.grid_basHttp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLLocaBasHttp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Author_NetTcp = new System.Windows.Forms.Button();
            this.txtLLocaNetTcp = new System.Windows.Forms.TextBox();
            this.grid_netTcp = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLLocaWsHttp = new System.Windows.Forms.TextBox();
            this.btn_Author_WsHttp = new System.Windows.Forms.Button();
            this.grid_WsHttp = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Author_WsDualHttp = new System.Windows.Forms.Button();
            this.txtLLocaWsDualHttp = new System.Windows.Forms.TextBox();
            this.grid_WsDualHttp = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Author_NetNPipe = new System.Windows.Forms.Button();
            this.grid_netNPipe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_basHttp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_netTcp)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_WsHttp)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_WsDualHttp)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_netNPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Author_BasHttp
            // 
            this.btn_Author_BasHttp.Location = new System.Drawing.Point(162, 20);
            this.btn_Author_BasHttp.Name = "btn_Author_BasHttp";
            this.btn_Author_BasHttp.Size = new System.Drawing.Size(75, 23);
            this.btn_Author_BasHttp.TabIndex = 0;
            this.btn_Author_BasHttp.Text = "GetAuthors";
            this.btn_Author_BasHttp.UseVisualStyleBackColor = true;
            this.btn_Author_BasHttp.Click += new System.EventHandler(this.btn_Author_BasHttp_Click);
            // 
            // lbl_showauthor
            // 
            this.lbl_showauthor.AutoSize = true;
            this.lbl_showauthor.Location = new System.Drawing.Point(12, 98);
            this.lbl_showauthor.Name = "lbl_showauthor";
            this.lbl_showauthor.Size = new System.Drawing.Size(0, 13);
            this.lbl_showauthor.TabIndex = 1;
            // 
            // grid_basHttp
            // 
            this.grid_basHttp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_basHttp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_basHttp.Location = new System.Drawing.Point(3, 52);
            this.grid_basHttp.Name = "grid_basHttp";
            this.grid_basHttp.Size = new System.Drawing.Size(281, 137);
            this.grid_basHttp.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Author_BasHttp);
            this.groupBox1.Controls.Add(this.txtLLocaBasHttp);
            this.groupBox1.Controls.Add(this.grid_basHttp);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BasicHttpBinding";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location";
            // 
            // txtLLocaBasHttp
            // 
            this.txtLLocaBasHttp.Location = new System.Drawing.Point(56, 21);
            this.txtLLocaBasHttp.Name = "txtLLocaBasHttp";
            this.txtLLocaBasHttp.Size = new System.Drawing.Size(100, 22);
            this.txtLLocaBasHttp.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Author_NetTcp);
            this.groupBox2.Controls.Add(this.txtLLocaNetTcp);
            this.groupBox2.Controls.Add(this.grid_netTcp);
            this.groupBox2.Location = new System.Drawing.Point(15, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 194);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NetTcpBinding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Location";
            // 
            // btn_Author_NetTcp
            // 
            this.btn_Author_NetTcp.Location = new System.Drawing.Point(162, 17);
            this.btn_Author_NetTcp.Name = "btn_Author_NetTcp";
            this.btn_Author_NetTcp.Size = new System.Drawing.Size(75, 23);
            this.btn_Author_NetTcp.TabIndex = 3;
            this.btn_Author_NetTcp.Text = "GetAuthors";
            this.btn_Author_NetTcp.UseVisualStyleBackColor = true;
            this.btn_Author_NetTcp.Click += new System.EventHandler(this.btn_Author_NetTcp_Click);
            // 
            // txtLLocaNetTcp
            // 
            this.txtLLocaNetTcp.Location = new System.Drawing.Point(56, 17);
            this.txtLLocaNetTcp.Name = "txtLLocaNetTcp";
            this.txtLLocaNetTcp.Size = new System.Drawing.Size(100, 22);
            this.txtLLocaNetTcp.TabIndex = 6;
            // 
            // grid_netTcp
            // 
            this.grid_netTcp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_netTcp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_netTcp.Location = new System.Drawing.Point(1, 48);
            this.grid_netTcp.Name = "grid_netTcp";
            this.grid_netTcp.Size = new System.Drawing.Size(283, 137);
            this.grid_netTcp.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtLLocaWsHttp);
            this.groupBox3.Controls.Add(this.btn_Author_WsHttp);
            this.groupBox3.Controls.Add(this.grid_WsHttp);
            this.groupBox3.Location = new System.Drawing.Point(311, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 200);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WsHttpBinding";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location";
            // 
            // txtLLocaWsHttp
            // 
            this.txtLLocaWsHttp.Location = new System.Drawing.Point(59, 22);
            this.txtLLocaWsHttp.Name = "txtLLocaWsHttp";
            this.txtLLocaWsHttp.Size = new System.Drawing.Size(100, 22);
            this.txtLLocaWsHttp.TabIndex = 3;
            // 
            // btn_Author_WsHttp
            // 
            this.btn_Author_WsHttp.Location = new System.Drawing.Point(165, 21);
            this.btn_Author_WsHttp.Name = "btn_Author_WsHttp";
            this.btn_Author_WsHttp.Size = new System.Drawing.Size(75, 23);
            this.btn_Author_WsHttp.TabIndex = 0;
            this.btn_Author_WsHttp.Text = "GetAuthors";
            this.btn_Author_WsHttp.UseVisualStyleBackColor = true;
            this.btn_Author_WsHttp.Click += new System.EventHandler(this.btn_Author_WsHttp_Click);
            // 
            // grid_WsHttp
            // 
            this.grid_WsHttp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_WsHttp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_WsHttp.Location = new System.Drawing.Point(3, 52);
            this.grid_WsHttp.Name = "grid_WsHttp";
            this.grid_WsHttp.Size = new System.Drawing.Size(281, 137);
            this.grid_WsHttp.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btn_Author_WsDualHttp);
            this.groupBox4.Controls.Add(this.txtLLocaWsDualHttp);
            this.groupBox4.Controls.Add(this.grid_WsDualHttp);
            this.groupBox4.Location = new System.Drawing.Point(607, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 200);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "WsDualHttpBinding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Location";
            // 
            // btn_Author_WsDualHttp
            // 
            this.btn_Author_WsDualHttp.Location = new System.Drawing.Point(164, 19);
            this.btn_Author_WsDualHttp.Name = "btn_Author_WsDualHttp";
            this.btn_Author_WsDualHttp.Size = new System.Drawing.Size(75, 23);
            this.btn_Author_WsDualHttp.TabIndex = 0;
            this.btn_Author_WsDualHttp.Text = "GetAuthors";
            this.btn_Author_WsDualHttp.UseVisualStyleBackColor = true;
            this.btn_Author_WsDualHttp.Click += new System.EventHandler(this.btn_Author_WsDualHttp_Click);
            // 
            // txtLLocaWsDualHttp
            // 
            this.txtLLocaWsDualHttp.Location = new System.Drawing.Point(57, 19);
            this.txtLLocaWsDualHttp.Name = "txtLLocaWsDualHttp";
            this.txtLLocaWsDualHttp.Size = new System.Drawing.Size(100, 22);
            this.txtLLocaWsDualHttp.TabIndex = 5;
            // 
            // grid_WsDualHttp
            // 
            this.grid_WsDualHttp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_WsDualHttp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_WsDualHttp.Location = new System.Drawing.Point(3, 52);
            this.grid_WsDualHttp.Name = "grid_WsDualHttp";
            this.grid_WsDualHttp.Size = new System.Drawing.Size(281, 137);
            this.grid_WsDualHttp.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Author_NetNPipe);
            this.groupBox5.Controls.Add(this.grid_netNPipe);
            this.groupBox5.Location = new System.Drawing.Point(314, 230);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 194);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "NetNamedPipeBinding";
            // 
            // btn_Author_NetNPipe
            // 
            this.btn_Author_NetNPipe.Location = new System.Drawing.Point(1, 17);
            this.btn_Author_NetNPipe.Name = "btn_Author_NetNPipe";
            this.btn_Author_NetNPipe.Size = new System.Drawing.Size(75, 23);
            this.btn_Author_NetNPipe.TabIndex = 3;
            this.btn_Author_NetNPipe.Text = "GetAuthors";
            this.btn_Author_NetNPipe.UseVisualStyleBackColor = true;
            this.btn_Author_NetNPipe.Click += new System.EventHandler(this.btn_Author_netNamePipe_Click);
            // 
            // grid_netNPipe
            // 
            this.grid_netNPipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_netNPipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_netNPipe.Location = new System.Drawing.Point(1, 47);
            this.grid_netNPipe.Name = "grid_netNPipe";
            this.grid_netNPipe.Size = new System.Drawing.Size(283, 137);
            this.grid_netNPipe.TabIndex = 4;
            // 
            // frmMain_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 437);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_showauthor);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain_Client";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.grid_basHttp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_netTcp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_WsHttp)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_WsDualHttp)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_netNPipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Author_BasHttp;
        private System.Windows.Forms.Label lbl_showauthor;
        private System.Windows.Forms.DataGridView grid_basHttp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Author_NetTcp;
        private System.Windows.Forms.DataGridView grid_netTcp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Author_WsHttp;
        private System.Windows.Forms.DataGridView grid_WsHttp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Author_WsDualHttp;
        private System.Windows.Forms.DataGridView grid_WsDualHttp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Author_NetNPipe;
        private System.Windows.Forms.DataGridView grid_netNPipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLLocaWsHttp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLLocaWsDualHttp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLLocaNetTcp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLLocaBasHttp;

    }
}

