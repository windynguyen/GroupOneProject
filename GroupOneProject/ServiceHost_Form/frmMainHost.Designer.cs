namespace ServiceHost_Form
{
    partial class frmMainHost
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
            this.grvEndpoints = new System.Windows.Forms.DataGridView();
            this.colRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colBinding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseLocation = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBinding = new System.Windows.Forms.ComboBox();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtEndpointLocal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboServiceContract = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvEndpoints)).BeginInit();
            this.SuspendLayout();
            // 
            // grvEndpoints
            // 
            this.grvEndpoints.AllowUserToAddRows = false;
            this.grvEndpoints.AllowUserToOrderColumns = true;
            this.grvEndpoints.AllowUserToResizeRows = false;
            this.grvEndpoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grvEndpoints.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.grvEndpoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvEndpoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEndpoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRemove,
            this.colBinding,
            this.colLocation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvEndpoints.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvEndpoints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.grvEndpoints.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.grvEndpoints.Location = new System.Drawing.Point(115, 236);
            this.grvEndpoints.MultiSelect = false;
            this.grvEndpoints.Name = "grvEndpoints";
            this.grvEndpoints.ReadOnly = true;
            this.grvEndpoints.RowHeadersVisible = false;
            this.grvEndpoints.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grvEndpoints.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Gray;
            this.grvEndpoints.RowTemplate.ReadOnly = true;
            this.grvEndpoints.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvEndpoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grvEndpoints.ShowEditingIcon = false;
            this.grvEndpoints.Size = new System.Drawing.Size(250, 141);
            this.grvEndpoints.TabIndex = 14;
            this.grvEndpoints.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEndpoints_CellContentClick);
            // 
            // colRemove
            // 
            this.colRemove.ActiveLinkColor = System.Drawing.Color.LightBlue;
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemove.HeaderText = "Select";
            this.colRemove.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemove.Text = "Delete";
            this.colRemove.UseColumnTextForLinkValue = true;
            this.colRemove.VisitedLinkColor = System.Drawing.Color.LightSeaGreen;
            this.colRemove.Width = 43;
            // 
            // colBinding
            // 
            this.colBinding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBinding.DataPropertyName = "Binding";
            this.colBinding.HeaderText = "Binding";
            this.colBinding.Name = "colBinding";
            this.colBinding.ReadOnly = true;
            this.colBinding.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBinding.Width = 54;
            // 
            // colLocation
            // 
            this.colLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLocation.DataPropertyName = "Address";
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base address :";
            // 
            // txtBaseLocation
            // 
            this.txtBaseLocation.Location = new System.Drawing.Point(112, 61);
            this.txtBaseLocation.Name = "txtBaseLocation";
            this.txtBaseLocation.Size = new System.Drawing.Size(254, 22);
            this.txtBaseLocation.TabIndex = 1;
            this.txtBaseLocation.Text = "http://localhost:2000/MarkManagementService";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(146, 89);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 22);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(252, 89);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 22);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Binding :";
            // 
            // cboBinding
            // 
            this.cboBinding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBinding.FormattingEnabled = true;
            this.cboBinding.Items.AddRange(new object[] {
            "basicHttpBinding",
            "wsHttpBinding",
            "wsDualHttpBinding",
            "netTcpBinding",
            "netNamedPipeBinding"});
            this.cboBinding.Location = new System.Drawing.Point(115, 182);
            this.cboBinding.Name = "cboBinding";
            this.cboBinding.Size = new System.Drawing.Size(125, 21);
            this.cboBinding.TabIndex = 4;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.Location = new System.Drawing.Point(255, 383);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(99, 22);
            this.btnSaveConfig.TabIndex = 3;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "State :";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.DeepPink;
            this.lblMessage.Location = new System.Drawing.Point(115, 120);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(51, 13);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "No Sign!";
            // 
            // txtEndpointLocal
            // 
            this.txtEndpointLocal.Location = new System.Drawing.Point(245, 182);
            this.txtEndpointLocal.Name = "txtEndpointLocal";
            this.txtEndpointLocal.Size = new System.Drawing.Size(121, 22);
            this.txtEndpointLocal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Service Contract :";
            // 
            // cboServiceContract
            // 
            this.cboServiceContract.FormattingEnabled = true;
            this.cboServiceContract.Items.AddRange(new object[] {
            "MarkManagementService"});
            this.cboServiceContract.Location = new System.Drawing.Point(115, 142);
            this.cboServiceContract.Name = "cboServiceContract";
            this.cboServiceContract.Size = new System.Drawing.Size(251, 21);
            this.cboServiceContract.TabIndex = 11;
            this.cboServiceContract.Text = "MarkManagementService";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(255, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 22);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "End Point :";
            // 
            // frmMainHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 432);
            this.Controls.Add(this.grvEndpoints);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboServiceContract);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndpointLocal);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboBinding);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBaseLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMainHost";
            this.Text = "Service Main Control";
            this.Load += new System.EventHandler(this.frmMainHost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvEndpoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseLocation;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBinding;
        //private uscListServiceContract uscListServiceContract2;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtEndpointLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboServiceContract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grvEndpoints;
        private System.Windows.Forms.DataGridViewLinkColumn colRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;

    }
}

