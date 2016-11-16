namespace DashBoard
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStCard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPlanReq = new System.Windows.Forms.ToolStripMenuItem();
            this.mnXNTDimension = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInvAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCNXX = new System.Windows.Forms.ToolStripMenuItem();
            this.salesConfirmationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesPackingSlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCNXXHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUserSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.serverConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUserMnPermision = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHelpFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.mnHistory,
            this.mnAdmin,
            this.mnHelp,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnStCard,
            this.mnPlanReq,
            this.mnXNTDimension,
            this.mnInvAllItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // mnStCard
            // 
            this.mnStCard.Name = "mnStCard";
            this.mnStCard.Size = new System.Drawing.Size(222, 22);
            this.mnStCard.Text = "Thẻ Kho - StockCard";
            this.mnStCard.Click += new System.EventHandler(this.mnStCard_Click);
            // 
            // mnPlanReq
            // 
            this.mnPlanReq.Name = "mnPlanReq";
            this.mnPlanReq.Size = new System.Drawing.Size(222, 22);
            this.mnPlanReq.Text = "Planning-Request";
            this.mnPlanReq.Click += new System.EventHandler(this.mnPlanReq_Click);
            // 
            // mnXNTDimension
            // 
            this.mnXNTDimension.Name = "mnXNTDimension";
            this.mnXNTDimension.Size = new System.Drawing.Size(222, 22);
            this.mnXNTDimension.Text = "Xuất Nhập Tồn - Dimension";
            this.mnXNTDimension.Click += new System.EventHandler(this.mnXNTDimension_Click_1);
            // 
            // mnInvAllItem
            // 
            this.mnInvAllItem.Name = "mnInvAllItem";
            this.mnInvAllItem.Size = new System.Drawing.Size(222, 22);
            this.mnInvAllItem.Text = "Tồn kho";
            this.mnInvAllItem.Click += new System.EventHandler(this.mnInvAllItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCNXX,
            this.salesConfirmationToolStripMenuItem,
            this.salesPackingSlipToolStripMenuItem,
            this.salesInvoiceToolStripMenuItem});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.saleToolStripMenuItem.Text = "Sales";
            // 
            // mnCNXX
            // 
            this.mnCNXX.Name = "mnCNXX";
            this.mnCNXX.Size = new System.Drawing.Size(201, 22);
            this.mnCNXX.Text = "Chứng nhận xuất xưởng";
            this.mnCNXX.Click += new System.EventHandler(this.mnCNXX_Click);
            // 
            // salesConfirmationToolStripMenuItem
            // 
            this.salesConfirmationToolStripMenuItem.Name = "salesConfirmationToolStripMenuItem";
            this.salesConfirmationToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.salesConfirmationToolStripMenuItem.Text = "Confirmation";
            // 
            // salesPackingSlipToolStripMenuItem
            // 
            this.salesPackingSlipToolStripMenuItem.Name = "salesPackingSlipToolStripMenuItem";
            this.salesPackingSlipToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.salesPackingSlipToolStripMenuItem.Text = "Packing Slip";
            // 
            // salesInvoiceToolStripMenuItem
            // 
            this.salesInvoiceToolStripMenuItem.Name = "salesInvoiceToolStripMenuItem";
            this.salesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.salesInvoiceToolStripMenuItem.Text = "Invoice";
            // 
            // mnHistory
            // 
            this.mnHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCNXXHistory});
            this.mnHistory.Name = "mnHistory";
            this.mnHistory.Size = new System.Drawing.Size(57, 20);
            this.mnHistory.Text = "History";
            this.mnHistory.Click += new System.EventHandler(this.mnHistory_Click);
            // 
            // mnCNXXHistory
            // 
            this.mnCNXXHistory.Name = "mnCNXXHistory";
            this.mnCNXXHistory.Size = new System.Drawing.Size(201, 22);
            this.mnCNXXHistory.Text = "Chứng nhận xuất xưởng";
            this.mnCNXXHistory.Click += new System.EventHandler(this.mnCNXXHistory_Click);
            // 
            // mnAdmin
            // 
            this.mnAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUserSetup,
            this.serverConfigToolStripMenuItem,
            this.mnUserMnPermision});
            this.mnAdmin.Name = "mnAdmin";
            this.mnAdmin.Size = new System.Drawing.Size(92, 20);
            this.mnAdmin.Text = "Administrator";
            this.mnAdmin.Visible = false;
            // 
            // mnUserSetup
            // 
            this.mnUserSetup.Name = "mnUserSetup";
            this.mnUserSetup.Size = new System.Drawing.Size(194, 22);
            this.mnUserSetup.Text = "User Warehouse Setup";
            this.mnUserSetup.Click += new System.EventHandler(this.mnUserSetup_Click);
            // 
            // serverConfigToolStripMenuItem
            // 
            this.serverConfigToolStripMenuItem.Name = "serverConfigToolStripMenuItem";
            this.serverConfigToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.serverConfigToolStripMenuItem.Text = "Server Config";
            this.serverConfigToolStripMenuItem.Click += new System.EventHandler(this.serverConfigToolStripMenuItem_Click);
            // 
            // mnUserMnPermision
            // 
            this.mnUserMnPermision.Name = "mnUserMnPermision";
            this.mnUserMnPermision.Size = new System.Drawing.Size(194, 22);
            this.mnUserMnPermision.Text = "User-Menu Permission";
            this.mnUserMnPermision.Click += new System.EventHandler(this.mnUserMnPermision_Click);
            // 
            // mnHelp
            // 
            this.mnHelp.Checked = true;
            this.mnHelp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHelpFile,
            this.mnAbout});
            this.mnHelp.Name = "mnHelp";
            this.mnHelp.Size = new System.Drawing.Size(44, 20);
            this.mnHelp.Text = "Help";
            this.mnHelp.Click += new System.EventHandler(this.mnAbout_Click);
            // 
            // mnHelpFile
            // 
            this.mnHelpFile.Name = "mnHelpFile";
            this.mnHelpFile.Size = new System.Drawing.Size(120, 22);
            this.mnHelpFile.Text = "Help File";
            this.mnHelpFile.Click += new System.EventHandler(this.mnHelpFile_Click);
            // 
            // mnAbout
            // 
            this.mnAbout.Name = "mnAbout";
            this.mnAbout.Size = new System.Drawing.Size(120, 22);
            this.mnAbout.Text = "About";
            this.mnAbout.Click += new System.EventHandler(this.mnAbout_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.Text = "VTI REPORT";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnStCard;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnCNXX;
        private System.Windows.Forms.ToolStripMenuItem mnAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnUserSetup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem salesConfirmationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesPackingSlipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnHelp;
        private System.Windows.Forms.ToolStripMenuItem serverConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnHistory;
        private System.Windows.Forms.ToolStripMenuItem mnCNXXHistory;
        private System.Windows.Forms.ToolStripMenuItem mnHelpFile;
        private System.Windows.Forms.ToolStripMenuItem mnAbout;
        private System.Windows.Forms.ToolStripMenuItem mnUserMnPermision;
        private System.Windows.Forms.ToolStripMenuItem mnPlanReq;
        private System.Windows.Forms.ToolStripMenuItem mnXNTDimension;
        private System.Windows.Forms.ToolStripMenuItem mnInvAllItem;
    }
}

