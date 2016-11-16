namespace DashBoard
{
    partial class frCNXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCNXX));
            this.label3 = new System.Windows.Forms.Label();
            this.txtPackId = new System.Windows.Forms.TextBox();
            this.dgvPacking = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCTrinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalesID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayXX = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgayXX = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnHis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phiếu Xuất";
            // 
            // txtPackId
            // 
            this.txtPackId.Location = new System.Drawing.Point(246, 21);
            this.txtPackId.Name = "txtPackId";
            this.txtPackId.Size = new System.Drawing.Size(100, 20);
            this.txtPackId.TabIndex = 4;
            // 
            // dgvPacking
            // 
            this.dgvPacking.AllowUserToAddRows = false;
            this.dgvPacking.AllowUserToOrderColumns = true;
            this.dgvPacking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacking.Location = new System.Drawing.Point(12, 204);
            this.dgvPacking.Name = "dgvPacking";
            this.dgvPacking.Size = new System.Drawing.Size(1023, 292);
            this.dgvPacking.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(387, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(76, 35);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(28, 165);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 31);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "In-Preview";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Công trình";
            // 
            // txtCTrinh
            // 
            this.txtCTrinh.Location = new System.Drawing.Point(72, 41);
            this.txtCTrinh.Name = "txtCTrinh";
            this.txtCTrinh.Size = new System.Drawing.Size(228, 20);
            this.txtCTrinh.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(371, 41);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(646, 42);
            this.txtDiaChi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đơn Vị TC";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(72, 67);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(228, 20);
            this.txtDonVi.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sale Order";
            // 
            // txtSalesID
            // 
            this.txtSalesID.Location = new System.Drawing.Point(71, 21);
            this.txtSalesID.Name = "txtSalesID";
            this.txtSalesID.Size = new System.Drawing.Size(100, 20);
            this.txtSalesID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số phiếu";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(72, 18);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(179, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "( bắt buộc)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPackId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSalesID);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 52);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lấy dữ liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgayXX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNgayXX);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCTrinh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNumber);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDonVi);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 95);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bổ xung";
            // 
            // dtpNgayXX
            // 
            this.dtpNgayXX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXX.Location = new System.Drawing.Point(469, 18);
            this.dtpNgayXX.Name = "dtpNgayXX";
            this.dtpNgayXX.Size = new System.Drawing.Size(81, 20);
            this.dtpNgayXX.TabIndex = 22;
            this.dtpNgayXX.ValueChanged += new System.EventHandler(this.dtpNgayXX_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(280, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ngày cấp CNXX";
            // 
            // txtNgayXX
            // 
            this.txtNgayXX.Location = new System.Drawing.Point(371, 19);
            this.txtNgayXX.Name = "txtNgayXX";
            this.txtNgayXX.Size = new System.Drawing.Size(92, 20);
            this.txtNgayXX.TabIndex = 21;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(156, 165);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 30);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnHis
            // 
            this.btnHis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHis.ForeColor = System.Drawing.Color.Blue;
            this.btnHis.Location = new System.Drawing.Point(908, 168);
            this.btnHis.Name = "btnHis";
            this.btnHis.Size = new System.Drawing.Size(121, 30);
            this.btnHis.TabIndex = 23;
            this.btnHis.Text = "Lịch Sử In CNXX";
            this.btnHis.UseVisualStyleBackColor = true;
            this.btnHis.Click += new System.EventHandler(this.btnHis_Click);
            // 
            // frCNXX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 508);
            this.Controls.Add(this.btnHis);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvPacking);
            this.Name = "frCNXX";
            this.Text = "Chứng Nhận Xuất Xưởng";
            this.Load += new System.EventHandler(this.frCNXX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPackId;
        private System.Windows.Forms.DataGridView dgvPacking;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCTrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalesID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnHis;
        private System.Windows.Forms.DateTimePicker dtpNgayXX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNgayXX;
    }
}