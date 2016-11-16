namespace DashBoard
{
    partial class frCNXXView
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
            this.crvCNXX = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCNXX
            // 
            this.crvCNXX.ActiveViewIndex = -1;
            this.crvCNXX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCNXX.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCNXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCNXX.Location = new System.Drawing.Point(0, 0);
            this.crvCNXX.Name = "crvCNXX";
            this.crvCNXX.Size = new System.Drawing.Size(284, 261);
            this.crvCNXX.TabIndex = 0;
            // 
            // frCNXXView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.crvCNXX);
            this.Name = "frCNXXView";
            this.Text = "Chứng nhận XX";
            this.Load += new System.EventHandler(this.frCNXXView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCNXX;
    }
}