namespace Client
{
    partial class StudentInfo
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
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.btnGetSV = new System.Windows.Forms.Button();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Mã số SV",
            "Tất cả"});
            this.cbbType.Location = new System.Drawing.Point(12, 71);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(121, 21);
            this.cbbType.TabIndex = 0;
            // 
            // btnGetSV
            // 
            this.btnGetSV.Location = new System.Drawing.Point(141, 69);
            this.btnGetSV.Name = "btnGetSV";
            this.btnGetSV.Size = new System.Drawing.Size(75, 23);
            this.btnGetSV.TabIndex = 1;
            this.btnGetSV.Text = "Xong";
            this.btnGetSV.UseVisualStyleBackColor = true;
            this.btnGetSV.Click += new System.EventHandler(this.btnGetSV_Click);
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(12, 109);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.Size = new System.Drawing.Size(555, 254);
            this.dtGrid.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(21, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(376, 36);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Thông tin Sinh viên";
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 375);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.btnGetSV);
            this.Controls.Add(this.cbbType);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button btnGetSV;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.Label lbTitle;
    }
}