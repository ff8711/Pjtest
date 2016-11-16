using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DashBoard
{
    public partial class UserWHSetup : Form
    {
        Connect cnn = new Connect();
        DataProvider dp = new DataProvider();
        Process p = new Process();
        string StringConnect;
        public UserWHSetup()
        {
            InitializeComponent();
        }
        private void UserSetup_Load(object sender, EventArgs e)
        {
            //Load connect string
            //this.StringConnect = cnn.GetConnectString();
            //this.StringConnect = cnn.GetConnectStringWithUsernameAndPassword();
            this.StringConnect = cnn.GetConnectString();
            this.loadUser();
            this.loadWH();
            //this.loadUserWHSetup();
            ckbAllWh.Checked = false;
            ckbInvMd.Checked = true;
        }
        private void loadUser()
        {
            cbUser.DataSource = p.getListByDataTable(dp.GetDataBySPAndConnectString("GetAllUser_VTIREPORT", this.StringConnect));
            cbUser.Text = "User";
            //dgvUserWHSetup.DataSource = dp.GetDataBySPAndConnectString("GetAllWH_VTIREPORT", connect);
        }
        private void loadWH()
        {
            cbWh.DataSource = p.getListByDataTable(dp.GetDataBySPAndConnectString("GetAllWH_VTIREPORT", this.StringConnect));
            cbWh.Text = "WareHouse";
            //dgvUserWHSetup.DataSource = dp.GetDataBySPAndConnectString("GetAllWH_VTIREPORT", connect);
        }
        private void loadUserWHSetup()
        {
            string cmd = "SELECT * FROM [VTIREPORT].[dbo].[UserWH]";
            dgvUserWHSetup.DataSource = dp.GetDataByCommandTextAndConnectString(cmd, this.StringConnect);
            //dgvUserWHSetup.DataSource = dp.GetDataBySPAndConnectString("GetAllUserWHSetup_VTIREPORT", this.StringConnect);
        }
        private void loadUserWHException()
        {
            string cmd = "SELECT [UserName] FROM [VTIREPORT].[dbo].[UserWHException]";
            dgvUserException.DataSource = dp.GetDataByCommandTextAndConnectString(cmd, this.StringConnect);
        }
        private void btnReFresh_Click(object sender, EventArgs e)
        {
            this.loadUserWHSetup();
            this.loadUserWHException();
        }
        private void ckbAllWh_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAllWh.Checked)
            {
                cbWh.Enabled = false;
                ckbInvMd.Enabled = false;
            }
            else
                cbWh.Enabled = true;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbUser.Text.ToLower() == "user" || (cbWh.Text.ToLower() == "warehouse"  && ckbAllWh.Checked == false))
                MessageBox.Show("Chọn lại User và Warehouse, User và Warehouse không hợp lệ !");
            else
            {
                if (ckbAllWh.Checked)
                {              
                    //kiem tra ton tai user trong bang chua
                    string cmd = "SELECT * FROM [VTIREPORT].[dbo].[UserWHException] WHERE [UserName] = '" + cbUser.Text + "'";
                    if (dp.GetDataByCommandTextAndConnectString(cmd,this.StringConnect).Rows.Count > 0)
                    {
                        MessageBox.Show("User đã tồn tại !");
                    }
                    //insert neu chua ton tai
                    else
                    {
                        string insertCmd = "INSERT INTO [VTIREPORT].[dbo].[UserWHException] ([UserName]) VALUES ('" + cbUser.Text + "')";
                        if (dp.InsertByCmdTextAndConnecString(insertCmd, this.StringConnect) > 0)
                        {
                            MessageBox.Show("Insert thành công !");
                            this.loadUserWHException();
                        }
                        else
                            MessageBox.Show("Insert không thành công!");
                    }                    
                }
                else
                {
                    //kiem tra ton tai user,warehouse ton tai
                    string cmd = "SELECT * FROM [VTIREPORT].[dbo].[UserWH] WHERE [User] = '" + cbUser.Text + "' AND [Warehouse] = '" +cbWh.Text + "'";
                    if (dp.GetDataByCommandTextAndConnectString(cmd, this.StringConnect).Rows.Count > 0)
                    {
                        MessageBox.Show("User đã tồn tại !");
                    }
                    //inser neu chua ton tai
                    else
                    {
                        string insertCmd = "INSERT INTO [VTIREPORT].[dbo].[UserWH] ([User],[Warehouse],[InvoiceManda]) VALUES ('" + cbUser.Text + "','" + cbWh.Text + "','" + ckbInvMd.Checked + "')";
                        if (dp.InsertByCmdTextAndConnecString(insertCmd, this.StringConnect) > 0)
                        {
                            MessageBox.Show("Insert thành công !");
                            this.loadUserWHSetup();
                        }
                        else
                            MessageBox.Show("Insert không thành công!"); 
                    }
                }
            }
        }
        private void test(object sender, EventArgs e)
        {
            string s1 = cnn.GetPassword();
            //MessageBox.Show(s1);
            ////string s = "vti@admin@vti";
            ////MessageBox.Show("password:" + s);
            ////string ec = p.Encript(s);
            ////MessageBox.Show(ec);
            //string dc = p.Decrypt(s1);
            //MessageBox.Show(dc);
            //MessageBox.Show(cnn.GetPassword());
        }
        private void btnDelUW_Click(object sender, EventArgs e)
        {
            string user;
            string wh;
            string cmd;
            var cf = MessageBox.Show("Delete ?","Confirmation Delete!",MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                foreach (DataGridViewRow dr in dgvUserWHSetup.SelectedRows)
                {
                    user    =   dr.Cells["User"].Value.ToString();
                    wh      =   dr.Cells["Warehouse"].Value.ToString();
                    
                    cmd = "DELETE VTIREPORT.dbo.UserWH  WHERE [User] = '" + user + "' AND [Warehouse] = '" + wh + "'";
                    //MessageBox.Show(cmd);
                    if (dp.ExecuteByCmdtxt(cmd, this.StringConnect) > 0)
                        MessageBox.Show("Delete User:"+user+ " Warehouse:\n" + wh + " thành công.");
                    else
                        MessageBox.Show("Delete User:"+user+ " Warehouse:\n" + wh + " thất bại.");
                }
                this.loadUserWHSetup();
            }
            
        }
        private void btnDelUE_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((dgvUserException.SelectedCells[0].RowIndex.ToString()));
            //MessageBox.Show(dgvUserException.RowCount.ToString());
            string user;
            string cmd;
            var cf = MessageBox.Show("Delete ?", "Confirmation Delete!", MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                foreach (DataGridViewRow dr in dgvUserException.SelectedRows)
                {
                    user = dr.Cells["UserName"].Value.ToString();
                    cmd = "DELETE VTIREPORT.dbo.UserWHException  WHERE [UserName] = '" + user + "'";
                    //MessageBox.Show(cmd);
                    if (dp.ExecuteByCmdtxt(cmd, this.StringConnect) > 0)
                        MessageBox.Show("Delete User:" + user + " thành công.");
                    else
                        MessageBox.Show("Delete User:" + user + " thất bại.");
                }
                this.loadUserWHException();
            }
        }
    }
}
