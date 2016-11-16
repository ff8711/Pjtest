namespace DashBoard
{
    partial class frStockCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.dgvStockCard = new System.Windows.Forms.DataGridView();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockCard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(88, 16);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(108, 20);
            this.txtItemId.TabIndex = 1;
            // 
            // dgvStockCard
            // 
            this.dgvStockCard.AllowUserToAddRows = false;
            this.dgvStockCard.AllowUserToDeleteRows = false;
            this.dgvStockCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStockCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockCard.Location = new System.Drawing.Point(15, 159);
            this.dgvStockCard.Name = "dgvStockCard";
            this.dgvStockCard.ReadOnly = true;
            this.dgvStockCard.Size = new System.Drawing.Size(797, 315);
            this.dgvStockCard.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(88, 64);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(108, 20);
            this.txtTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(88, 40);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(108, 20);
            this.txtFrom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Từ ngày:";
            // 
            // txtWh
            // 
            this.txtWh.Location = new System.Drawing.Point(48, 26);
            this.txtWh.Name = "txtWh";
            this.txtWh.Size = new System.Drawing.Size(108, 20);
            this.txtWh.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kho:";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(202, 64);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(86, 20);
            this.dtpTo.TabIndex = 9;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(202, 40);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(86, 20);
            this.dtpFrom.TabIndex = 10;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(26, 117);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 28);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Preview";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(136, 117);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 28);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSerial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtConfig);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(327, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimension";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(210, 52);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(108, 20);
            this.txtColor.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Color:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(48, 52);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(108, 20);
            this.txtSize.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Size:";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(363, 52);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(108, 20);
            this.txtSerial.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Serial:";
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(210, 26);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(108, 20);
            this.txtConfig.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Config:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtItemId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Controls.Add(this.txtFrom);
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 94);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item-Date";
            // 
            // frStockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvStockCard);
            this.Name = "frStockCard";
            this.Text = "Thẻ Kho";
            this.Load += new System.EventHandler(this.frStockCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockCard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.DataGridView dgvStockCard;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}