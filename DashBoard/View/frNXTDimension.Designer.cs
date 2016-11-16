namespace DashBoard
{
    partial class frNXTDimension
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
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWh = new System.Windows.Forms.ComboBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNXT = new System.Windows.Forms.DataGridView();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(81, 13);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(100, 20);
            this.txtFromDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(81, 39);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(100, 20);
            this.txtToDate.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(310, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Warehouse";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(187, 13);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(106, 20);
            this.dtpFrom.TabIndex = 6;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(187, 39);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(106, 20);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(314, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Size";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(366, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(50, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Color";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(482, 41);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Config";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(544, 41);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(52, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Serial";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(422, 41);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(54, 17);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "Batch";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbWh);
            this.groupBox1.Controls.Add(this.cbItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 68);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // cbWh
            // 
            this.cbWh.FormattingEnabled = true;
            this.cbWh.Location = new System.Drawing.Point(378, 12);
            this.cbWh.Name = "cbWh";
            this.cbWh.Size = new System.Drawing.Size(121, 21);
            this.cbWh.TabIndex = 16;
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(557, 12);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(146, 21);
            this.cbItem.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item";
            // 
            // dgvNXT
            // 
            this.dgvNXT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXT.Location = new System.Drawing.Point(12, 114);
            this.dgvNXT.Name = "dgvNXT";
            this.dgvNXT.Size = new System.Drawing.Size(932, 396);
            this.dgvNXT.TabIndex = 14;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(29, 86);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(106, 23);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(151, 86);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(121, 23);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frNXTDimension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 522);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dgvNXT);
            this.Controls.Add(this.groupBox1);
            this.Name = "frNXTDimension";
            this.Text = "NHẬP XUẤT TỒN DIMENSION";
            this.Load += new System.EventHandler(this.frNXTDimension_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNXT;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.ComboBox cbWh;
    }
}