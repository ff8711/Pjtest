namespace DashBoard
{
    partial class CNXXHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CNXXHistory));
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalesId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPackId = new System.Windows.Forms.TextBox();
            this.txtPackingID = new System.Windows.Forms.Label();
            this.dgvHis = new System.Windows.Forms.DataGridView();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnRePrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(577, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(66, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(89, 12);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 3;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(361, 12);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(240, 64);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 7;
            this.txtUser.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User :";
            this.label3.Visible = false;
            // 
            // txtSalesId
            // 
            this.txtSalesId.Location = new System.Drawing.Point(89, 38);
            this.txtSalesId.Name = "txtSalesId";
            this.txtSalesId.Size = new System.Drawing.Size(100, 20);
            this.txtSalesId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sales Order:";
            // 
            // txtPackId
            // 
            this.txtPackId.Location = new System.Drawing.Point(89, 64);
            this.txtPackId.Name = "txtPackId";
            this.txtPackId.Size = new System.Drawing.Size(100, 20);
            this.txtPackId.TabIndex = 11;
            // 
            // txtPackingID
            // 
            this.txtPackingID.AutoSize = true;
            this.txtPackingID.Location = new System.Drawing.Point(18, 67);
            this.txtPackingID.Name = "txtPackingID";
            this.txtPackingID.Size = new System.Drawing.Size(61, 13);
            this.txtPackingID.TabIndex = 10;
            this.txtPackingID.Text = "Packing Id:";
            // 
            // dgvHis
            // 
            this.dgvHis.AllowUserToAddRows = false;
            this.dgvHis.AllowUserToDeleteRows = false;
            this.dgvHis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHis.Location = new System.Drawing.Point(12, 116);
            this.dgvHis.Name = "dgvHis";
            this.dgvHis.ReadOnly = true;
            this.dgvHis.Size = new System.Drawing.Size(899, 386);
            this.dgvHis.TabIndex = 12;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(240, 38);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số :";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(198, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(91, 20);
            this.dtpFrom.TabIndex = 15;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(467, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(91, 20);
            this.dtpTo.TabIndex = 16;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // btnRePrint
            // 
            this.btnRePrint.Image = ((System.Drawing.Image)(resources.GetObject("btnRePrint.Image")));
            this.btnRePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRePrint.Location = new System.Drawing.Point(795, 67);
            this.btnRePrint.Name = "btnRePrint";
            this.btnRePrint.Size = new System.Drawing.Size(99, 43);
            this.btnRePrint.TabIndex = 17;
            this.btnRePrint.Text = "In Lại";
            this.btnRePrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRePrint.UseVisualStyleBackColor = true;
            this.btnRePrint.Click += new System.EventHandler(this.btnRePrint_Click);
            // 
            // CNXXHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 514);
            this.Controls.Add(this.btnRePrint);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvHis);
            this.Controls.Add(this.txtPackId);
            this.Controls.Add(this.txtPackingID);
            this.Controls.Add(this.txtSalesId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Name = "CNXXHistory";
            this.Text = "CNXXHistory";
            this.Load += new System.EventHandler(this.CNXXHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPackId;
        private System.Windows.Forms.Label txtPackingID;
        private System.Windows.Forms.DataGridView dgvHis;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnRePrint;
    }
}