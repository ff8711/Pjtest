using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DashBoard.View;
using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace DashBoard
{
    public partial class DashBoard : Form
    {
        
        //SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=iPayment;Persist Security Info=True;User ID=sa;pwd=123@321;Connect Timeout=30"); //Enter Your sql Server Password eg.pwd=xyz
        Connect cn = new Connect();
        DataProvider dp = new DataProvider();
        Process pc = new Process();
        string strConnect = "";
        public DashBoard()
        {
            InitializeComponent();
        }

        private void mnXNTDimension_Click(object sender, EventArgs e)
        {
            frNXT nxt = new frNXT();
            nxt.Show();
        }

        private void mnCNXX_Click(object sender, EventArgs e)
        {
            if (pc.checkUserAllowCNXX(Environment.UserName))
            {
                frCNXX cnxx = new frCNXX();
                cnxx.Show();
            }
            else { MessageBox.Show("User  \"" + Environment.UserName + "\" không có quyền sử dụng chức năng này."); };
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.strConnect = cn.GetConnectString();
            //this.Display();
            this.MenuAdminDisplay();
        }
        private void Display()
        {
            string user,dm;
            user =  Environment.UserName;
            dm = Environment.UserDomainName;
            //MessageBox.Show(dm + "|" + user);
            if ((dm.ToLower() == "vti" || dm.ToLower() == "vti-hcm" ) && ((user == "ndanh") || (user == "pqtbinh") || (user == "anh.nd")))
            {
                mnAdmin.Visible = true;
            }
            else
            {
                mnAdmin.Visible = false;
            }
            if(user == "pen")
                mnAdmin.Visible = true;

        }
        private void MenuAdminDisplay()
        {
            string cmd = "SELECT * FROM [VTIREPORT].[dbo].[Administrator] WHERE [USER] = '" + Environment.UserName + "'";
            if (dp.GetDataByCommandTextAndConnectString(cmd,this.strConnect).Rows.Count > 0)
            {
                mnAdmin.Visible = true;
            }
            else
            {
                mnAdmin.Visible = false;
            }
        }

        private void mnUserSetup_Click(object sender, EventArgs e)
        {
            
            UserWHSetup us = new UserWHSetup();
            us.ShowDialog();
        }

        private void mnAbout_Click(object sender, EventArgs e)
        {

        }

        private void serverConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerConfig sc = new ServerConfig();
            sc.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mnHistory_Click(object sender, EventArgs e)
        {
            //string user, dm;
            //user = Environment.UserName;
            //dm = Environment.UserDomainName;
            ////MessageBox.Show(dm + "|" + user);
            //if ((dm.ToLower() == "vti" || dm.ToLower() == "vti-hcm") && ((user == "ndanh") || (user == "pqtbinh") || (user == "anh.nd")))
            //{
            //    mnHistory.Visible = true;

            //}
            //else
            //{
            //    mnHistory.Visible = false;
            //}
        }

        private void mnCNXXHistory_Click(object sender, EventArgs e)
        {

            if (pc.checkUserAllowCNXX(Environment.UserName))
            {
                CNXXHistory his = new CNXXHistory();
                his.ShowDialog(); ;
            }
            else { MessageBox.Show("User \"" + Environment.UserName + "\" không có quyền sử dụng chức năng này."); };
        }

        private void mnAbout_Click_1(object sender, EventArgs e)
        {
            frAbout about = new frAbout();
            about.ShowDialog();
        }

        private void mnHelpFile_Click(object sender, EventArgs e)
        {

        }

        private void mnStCard_Click(object sender, EventArgs e)
        {
            frStockCard sc = new frStockCard();
            sc.ShowDialog();
        }

        private void mnUserMnPermision_Click(object sender, EventArgs e)
        {

        }

        private void mnPlanReq_Click(object sender, EventArgs e)
        {
            frRequest rq = new frRequest();
            rq.ShowDialog();
        }

        private void mnXNTDimension_Click_1(object sender, EventArgs e)
        {
            frNXTDimension xnt = new frNXTDimension();
            xnt.ShowDialog();
        }

        private void mnInvAllItem_Click(object sender, EventArgs e)
        {
            frInventory inv = new frInventory();
            inv.ShowDialog();
        }
    }
}
