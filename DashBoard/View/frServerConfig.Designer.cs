namespace DashBoard
{
    partial class ServerConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetInf = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ckbEdit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(112, 24);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 1;
            // 
            // txtDatabse
            // 
            this.txtDatabse.Location = new System.Drawing.Point(112, 53);
            this.txtDatabse.Name = "txtDatabse";
            this.txtDatabse.Size = new System.Drawing.Size(100, 20);
            this.txtDatabse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // btnGetInf
            // 
            this.btnGetInf.Image = ((System.Drawing.Image)(resources.GetObject("btnGetInf.Image")));
            this.btnGetInf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetInf.Location = new System.Drawing.Point(218, 13);
            this.btnGetInf.Name = "btnGetInf";
            this.btnGetInf.Size = new System.Drawing.Size(84, 40);
            this.btnGetInf.TabIndex = 4;
            this.btnGetInf.Text = "Get Server Setup";
            this.btnGetInf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetInf.UseVisualStyleBackColor = true;
            this.btnGetInf.Click += new System.EventHandler(this.btnGetInf_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(137, 83);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ckbEdit
            // 
            this.ckbEdit.AutoSize = true;
            this.ckbEdit.Location = new System.Drawing.Point(72, 87);
            this.ckbEdit.Name = "ckbEdit";
            this.ckbEdit.Size = new System.Drawing.Size(44, 17);
            this.ckbEdit.TabIndex = 6;
            this.ckbEdit.Text = "Edit";
            this.ckbEdit.UseVisualStyleBackColor = true;
            this.ckbEdit.CheckedChanged += new System.EventHandler(this.ckbEdit_CheckedChanged);
            // 
            // ServerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 174);
            this.Controls.Add(this.ckbEdit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetInf);
            this.Controls.Add(this.txtDatabse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Name = "ServerConfig";
            this.Text = "ServerConfig";
            this.Load += new System.EventHandler(this.ServerConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDatabse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetInf;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox ckbEdit;
    }
}