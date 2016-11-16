namespace DashBoard
{
    partial class frNXT
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
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvNXT = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbWH = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(83, 15);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(95, 20);
            this.txtFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(319, 15);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(529, 11);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 27);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvNXT
            // 
            this.dgvNXT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXT.Location = new System.Drawing.Point(12, 135);
            this.dgvNXT.Name = "dgvNXT";
            this.dgvNXT.Size = new System.Drawing.Size(1112, 356);
            this.dgvNXT.TabIndex = 5;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(15, 97);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 32);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "View";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Warehouse";
            // 
            // cbWH
            // 
            this.cbWH.FormattingEnabled = true;
            this.cbWH.Location = new System.Drawing.Point(83, 46);
            this.cbWH.Name = "cbWH";
            this.cbWH.Size = new System.Drawing.Size(87, 21);
            this.cbWH.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(184, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(77, 20);
            this.dtpFrom.TabIndex = 10;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(425, 15);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(84, 20);
            this.dtpTo.TabIndex = 11;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // NXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 503);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cbWH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvNXT);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrom);
            this.Name = "NXT";
            this.Text = "NXT";
            this.Load += new System.EventHandler(this.NXT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvNXT;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbWH;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}