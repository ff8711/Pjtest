namespace DashBoard
{
    partial class UserWHSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWHSetup));
            this.dgvUserWHSetup = new System.Windows.Forms.DataGridView();
            this.btnReFresh = new System.Windows.Forms.Button();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.cbWh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbAllWh = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbInvMd = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelUE = new System.Windows.Forms.Button();
            this.btnDelUW = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvUserException = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserWHSetup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserException)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserWHSetup
            // 
            this.dgvUserWHSetup.AllowUserToAddRows = false;
            this.dgvUserWHSetup.AllowUserToDeleteRows = false;
            this.dgvUserWHSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserWHSetup.Location = new System.Drawing.Point(6, 32);
            this.dgvUserWHSetup.Name = "dgvUserWHSetup";
            this.dgvUserWHSetup.ReadOnly = true;
            this.dgvUserWHSetup.Size = new System.Drawing.Size(422, 320);
            this.dgvUserWHSetup.TabIndex = 0;
            // 
            // btnReFresh
            // 
            this.btnReFresh.Image = ((System.Drawing.Image)(resources.GetObject("btnReFresh.Image")));
            this.btnReFresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReFresh.Location = new System.Drawing.Point(449, 10);
            this.btnReFresh.Name = "btnReFresh";
            this.btnReFresh.Size = new System.Drawing.Size(75, 24);
            this.btnReFresh.TabIndex = 1;
            this.btnReFresh.Text = "ReFresh";
            this.btnReFresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReFresh.UseVisualStyleBackColor = true;
            this.btnReFresh.Click += new System.EventHandler(this.btnReFresh_Click);
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(38, 19);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(121, 21);
            this.cbUser.TabIndex = 2;
            this.cbUser.Text = "User";
            // 
            // cbWh
            // 
            this.cbWh.FormattingEnabled = true;
            this.cbWh.Location = new System.Drawing.Point(248, 19);
            this.cbWh.Name = "cbWh";
            this.cbWh.Size = new System.Drawing.Size(121, 21);
            this.cbWh.TabIndex = 3;
            this.cbWh.Text = "Warehouse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "WareHouse";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(397, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Warehouse Setup List";
            // 
            // ckbAllWh
            // 
            this.ckbAllWh.AutoSize = true;
            this.ckbAllWh.Location = new System.Drawing.Point(248, 46);
            this.ckbAllWh.Name = "ckbAllWh";
            this.ckbAllWh.Size = new System.Drawing.Size(100, 17);
            this.ckbAllWh.TabIndex = 8;
            this.ckbAllWh.Text = "All Ware House";
            this.ckbAllWh.UseVisualStyleBackColor = true;
            this.ckbAllWh.CheckedChanged += new System.EventHandler(this.ckbAllWh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbInvMd);
            this.groupBox1.Controls.Add(this.cbUser);
            this.groupBox1.Controls.Add(this.ckbAllWh);
            this.groupBox1.Controls.Add(this.cbWh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 78);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User";
            // 
            // ckbInvMd
            // 
            this.ckbInvMd.AutoSize = true;
            this.ckbInvMd.Location = new System.Drawing.Point(38, 46);
            this.ckbInvMd.Name = "ckbInvMd";
            this.ckbInvMd.Size = new System.Drawing.Size(114, 17);
            this.ckbInvMd.TabIndex = 9;
            this.ckbInvMd.Text = "Invoice Mandatory";
            this.ckbInvMd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelUE);
            this.groupBox2.Controls.Add(this.btnDelUW);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvUserException);
            this.groupBox2.Controls.Add(this.btnReFresh);
            this.groupBox2.Controls.Add(this.dgvUserWHSetup);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 360);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup List";
            // 
            // btnDelUE
            // 
            this.btnDelUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelUE.Image = ((System.Drawing.Image)(resources.GetObject("btnDelUE.Image")));
            this.btnDelUE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelUE.Location = new System.Drawing.Point(695, 59);
            this.btnDelUE.Name = "btnDelUE";
            this.btnDelUE.Size = new System.Drawing.Size(73, 33);
            this.btnDelUE.TabIndex = 11;
            this.btnDelUE.Text = "Delete";
            this.btnDelUE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelUE.UseVisualStyleBackColor = true;
            this.btnDelUE.Click += new System.EventHandler(this.btnDelUE_Click);
            // 
            // btnDelUW
            // 
            this.btnDelUW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelUW.Image = ((System.Drawing.Image)(resources.GetObject("btnDelUW.Image")));
            this.btnDelUW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelUW.Location = new System.Drawing.Point(434, 59);
            this.btnDelUW.Name = "btnDelUW";
            this.btnDelUW.Size = new System.Drawing.Size(75, 32);
            this.btnDelUW.TabIndex = 10;
            this.btnDelUW.Text = "Delete";
            this.btnDelUW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelUW.UseVisualStyleBackColor = true;
            this.btnDelUW.Click += new System.EventHandler(this.btnDelUW_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Exception";
            // 
            // dgvUserException
            // 
            this.dgvUserException.AllowUserToAddRows = false;
            this.dgvUserException.AllowUserToDeleteRows = false;
            this.dgvUserException.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserException.Location = new System.Drawing.Point(545, 34);
            this.dgvUserException.Name = "dgvUserException";
            this.dgvUserException.ReadOnly = true;
            this.dgvUserException.Size = new System.Drawing.Size(144, 320);
            this.dgvUserException.TabIndex = 8;
            // 
            // UserWHSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserWHSetup";
            this.Text = "User Warehouse Setup";
            this.Load += new System.EventHandler(this.UserSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserWHSetup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserException)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserWHSetup;
        private System.Windows.Forms.Button btnReFresh;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.ComboBox cbWh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbAllWh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUserException;
        private System.Windows.Forms.Button btnDelUE;
        private System.Windows.Forms.Button btnDelUW;
        private System.Windows.Forms.CheckBox ckbInvMd;
    }
}