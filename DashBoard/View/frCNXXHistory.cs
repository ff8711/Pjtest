using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DashBoard
{
    public partial class CNXXHistory : Form
    {
        Connect cn = new Connect();
        Process pc = new Process();
        DataProvider dp = new DataProvider();
        string connectStr;
        public CNXXHistory()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (((txtFrom.Text.Length == 0) && (txtTo.Text.Length > 0)) || (txtFrom.Text.Length > 0 && txtTo.Text.Length == 0))
            {MessageBox.Show("Nhập đầy đủ khoảng thời gian  hoặc để trống !");}
            else
            {
                if(dp.CheckUserException(connectStr,Environment.UserName))
                {

                    dgvHis.DataSource = dp.getCNXXHistory("getCNXXHistory_VTIREPORT", this.connectStr
                        ,txtUser.Text, txtSalesId.Text,txtPackId.Text, txtNumber.Text, txtFrom.Text, txtTo.Text);      
                }
                else
                {
                    string WhFilter =  pc.WareHouseStringFilter(dp.getWHUserPermission(Environment.UserName,this.connectStr));
                    //MessageBox.Show(WhFilter);
                    dgvHis.DataSource = dp.getCNXXHistoryByWareHouse("getCNXXHistoryByWarehouse_VTIREPORT", this.connectStr
                        ,txtUser.Text, txtSalesId.Text,txtPackId.Text, txtNumber.Text, txtFrom.Text, txtTo.Text,WhFilter);
                }
            }
        }
        private void CNXXHistory_Load(object sender, EventArgs e)
        {
            this.connectStr = cn.GetConnectString();
        }
        public Boolean validDate(string s)
        {
            //^(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])[.](19|20)[0-9]{2}$
            string strpattern = @"^([1-9]|[12][0-9]|3[01])[/]([1-9]|1[012])[/](19|20)[1-9]{2}$";
            Regex rg = new Regex(strpattern);
            return rg.Match(s).Success;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            txtTo.Text = dtpTo.Text;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            txtFrom.Text = dtpFrom.Text;
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            int id;
            string cmd;
            string SP, CT, DVTC, DC,NgayXX;
            DataTable tb;
            if (dgvHis.SelectedRows.Count == 1)
            {
                foreach(DataGridViewRow  dr in dgvHis.SelectedRows)
                {
                    id = int.Parse(dr.Cells["Id"].Value.ToString());
                    SP = dr.Cells["SP"].Value.ToString();
                    CT = dr.Cells["CT"].Value.ToString();
                    DVTC = dr.Cells["DVTC"].Value.ToString();
                    DC = dr.Cells["DC"].Value.ToString();
                    NgayXX = Convert.ToDateTime(dr.Cells["NgayXX"].Value.ToString()).ToString("dd/MM/yyyy");
                    cmd = "SELECT	[SalesID],[PackingId] PackingSlipId,[Warehouse],[ItemId],[ItemName] Name " +
                          ",[OrderQty],[Qty],[UOM] Unit,[EditQty],[Batch], CONVERT(nvarchar(10),[Date],103) Date,[InvoiceAccount],[CustName] Cust " +
                                    "FROM [VTIREPORT].[dbo].[NumberLines]	WHERE NumId = '" + id.ToString() + "'";
                    tb = dp.GetDataByCommandTextAndConnectString(cmd, connectStr);
                    frCNXX cnxx = new frCNXX(tb, SP, CT, DVTC, DC, NgayXX);
                    cnxx.ShowDialog();
                }
            }
            else{MessageBox.Show("Chọn một dòng để in lại.");}
          
        }

    }
}
