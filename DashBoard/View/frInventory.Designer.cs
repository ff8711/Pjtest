namespace DashBoard.View
{
    partial class frInventory
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
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvInvOnHand = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbInventory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvOnHand)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(180, 14);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(52, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Serial";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(10, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Size";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(118, 14);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Config";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(65, 13);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(50, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Color";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(163, 97);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(121, 23);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(31, 97);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(106, 23);
            this.btnPreview.TabIndex = 19;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbWh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 77);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // cbWh
            // 
            this.cbWh.FormattingEnabled = true;
            this.cbWh.Location = new System.Drawing.Point(100, 39);
            this.cbWh.Name = "cbWh";
            this.cbWh.Size = new System.Drawing.Size(87, 21);
            this.cbWh.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(32, 45);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Warehouse";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(52, 13);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(158, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(106, 20);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(-199, -81);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(58, 129);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "View";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // dgvInvOnHand
            // 
            this.dgvInvOnHand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvOnHand.Location = new System.Drawing.Point(12, 126);
            this.dgvInvOnHand.Name = "dgvInvOnHand";
            this.dgvInvOnHand.Size = new System.Drawing.Size(1002, 345);
            this.dgvInvOnHand.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Location = new System.Drawing.Point(328, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 36);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // cbInventory
            // 
            this.cbInventory.FormattingEnabled = true;
            this.cbInventory.Items.AddRange(new object[] {
            "Khung",
            "Tấm",
            "Tole",
            "Phụ kiện",
            "Khung-Tấm-Phụ kiện",
            "Khung - Tấm - Phụ kiện - Tole",
            "Nguyên vật liệu - Thiết bị"});
            this.cbInventory.Location = new System.Drawing.Point(393, 25);
            this.cbInventory.Name = "cbInventory";
            this.cbInventory.Size = new System.Drawing.Size(201, 21);
            this.cbInventory.TabIndex = 24;
            this.cbInventory.Text = "Chọn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Chọn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 43);
            this.button1.TabIndex = 26;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbInventory);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvInvOnHand);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Name = "frInventory";
            this.Text = "TỒN KHO TẠI THỜI ĐIỂM";
            this.Load += new System.EventHandler(this.frInventoryAll_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvOnHand)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbWh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvInvOnHand;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}