namespace DashBoard
{
    partial class frRequest
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(73, 15);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(87, 20);
            this.txtFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(73, 41);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(87, 20);
            this.txtTo.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(276, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 33);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(166, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(95, 20);
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(166, 41);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(95, 20);
            this.dtpTo.TabIndex = 6;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // frRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 94);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrom);
            this.Name = "frRequest";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.frRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}