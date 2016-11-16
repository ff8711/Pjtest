using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using OfficeOpenXml;
using System.Diagnostics;

namespace DashBoard
{
    public partial class frNXTDimension : Form
    {
        Connect cnn = new Connect();
        DataProvider dp = new DataProvider();
        Process p = new Process();
        string connectString;
        public frNXTDimension()
        {
            InitializeComponent();
        }
        
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtpFrom.Text;
        }
        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtpTo.Text;
        }
        private void frNXTDimension_Load(object sender, EventArgs e)
        {
            this.connectString = cnn.GetConnectString();
            //Load Item
            this.loadItem();
            //Load Warehouse
            this.loadWareHouse();
        }
        public void loadWareHouse()
        {
            string cmd = "SELECT [Warehouse] FROM [VTIREPORT].[dbo].[WH]";
            cbWh.DataSource = p.getListByDataTable(dp.GetDataByCommandTextAndConnectString(cmd, this.connectString));
        }
        public void loadItem()
        {
            string cmd = "SELECT [ItemId] FROM [VTIREPORT].[dbo].[Item]";
            cbItem.DataSource = p.getListByDataTable(dp.GetDataByCommandTextAndConnectString(cmd, this.connectString));
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (txtFromDate.Text.Length >= 10 && txtToDate.Text.Length >= 10 )
            {
                dgvNXT.DataSource = dp.getNhapXuatTonDimension(connectString, "getNXTWithDimension_VTIREPORT", cbWh.Text,
                    cbItem.Text, txtFromDate.Text, txtToDate.Text);
            }
            else
            {
                MessageBox.Show("Chưa nhập từ ngày , đến ngày");
            }
        }
        public void ExportToExcel(string from, string to, string warehouse, string ItemId, string ItemName)
        {
            string starUpPath = cnn.GetLocationString();
            string filePatch = starUpPath + @"NXTDimension-" + Environment.UserName + DateTime.Now.ToString("-ddMMyyyy-hhmmss") + ".xlsx";
            FileInfo newFile = new FileInfo(filePatch);
            if (newFile.Exists)
            {
                newFile.Delete();
                newFile = new FileInfo(starUpPath + @"StockCard-" + Environment.UserName + DateTime.Now.ToString("-ddMMyyyy-hhmmss") + ".xlsx");
            }
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int rowIndex = 5;
                int columIndex;
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("StockCard");
                // Header
                ws.Cells[1, 1].Value = "Nhập Xuất Tồn Theo Dimension";
                using (var range = ws.Cells[1, 1, 1, 10])
                {
                    range.Merge = true;
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    range.Style.Font.Size = 20;
                    range.Style.Font.Bold = true;
                    range.Style.Font.Color.SetColor(Color.Green);
                }
                ws.Cells[2, 1].Value = "ItemId:";
                ws.Cells[2, 1].Style.Font.Bold = true;
                ws.Cells[2, 2].Value = ItemId;
                ws.Cells[2, 3].Value = "Item Name:";
                ws.Cells[2, 3].Style.Font.Bold = true;
                ws.Cells[2, 4].Value = ItemName;
                ws.Cells[3, 1].Value = "Warehouse:";
                ws.Cells[3, 1].Style.Font.Bold = true;
                ws.Cells[3, 2].Value = warehouse;
                ws.Cells[4, 1].Value = "Từ ngày:";
                ws.Cells[4, 1].Style.Font.Bold = true;
                ws.Cells[4, 2].Value = from;
                ws.Cells[4, 3].Value = "Đến ngày:";
                ws.Cells[4, 3].Style.Font.Bold = true;
                ws.Cells[4, 4].Value = to;
                //Value
                //header 
                ws.Cells[5, 1].Value = "ItemId";
                ws.Cells[5, 1].Style.Font.Bold = true;
                ws.Cells[5, 2].Value = "Name";
                ws.Cells[5, 2].Style.Font.Bold = true;
                ws.Cells[5, 3].Value = "Config";
                ws.Cells[5, 3].Style.Font.Bold = true;
                ws.Cells[5, 4].Value = "Size";
                ws.Cells[5, 4].Style.Font.Bold = true;
                ws.Cells[5, 5].Value = "Color";
                ws.Cells[5, 5].Style.Font.Bold = true;
                ws.Cells[5, 6].Value = "Serial";
                ws.Cells[5, 6].Style.Font.Bold = true;
                ws.Cells[5, 7].Value = "TotalName";
                ws.Cells[5, 7].Style.Font.Bold = true;
                ws.Cells[5, 8].Value = "Begin";
                ws.Cells[5, 8].Style.Font.Bold = true;
                ws.Cells[5, 9].Value = "Input";
                ws.Cells[5, 9].Style.Font.Bold = true;
                ws.Cells[5, 10].Value = "OutPut";
                ws.Cells[5, 10].Style.Font.Bold = true;
                ws.Cells[5, 11].Value = "Ending";
                ws.Cells[5, 11].Style.Font.Bold = true;
                

                //Line
                foreach (DataGridViewRow dr in dgvNXT.Rows)
                {
                    rowIndex += 1;
                    columIndex = 0;
                    foreach (DataGridViewColumn dc in dgvNXT.Columns)
                    {
                        columIndex += 1;
                        ws.Cells[rowIndex, columIndex].Value = dr.Cells[dc.Name].Value;
                    }
                }
                package.Save();
                // Openning the created excel file using MS Excel Application
                ProcessStartInfo pi = new ProcessStartInfo(filePatch);
                System.Diagnostics.Process.Start(pi);
                //system.Process.Start(pi);
            }
        }
        public string getItemName(string itemId, string connectString)
        {
            if (itemId.Trim() == "")
                return "";
            string itemName = "";
            DataTable tb;
            string cmd = "select TOP 1 Name from VTIREPORT.dbo.Item where ItemId LIKE '%" + cbItem.Text + "%'";
            tb = dp.GetDataByCommandTextAndConnectString(cmd, this.connectString);
            if (tb.Rows.Count > 0)
                itemName = tb.Rows[0][0].ToString();
            return itemName;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvNXT.RowCount > 0)
            {
                ExportToExcel(txtFromDate.Text, txtToDate.Text, cbWh.Text, cbItem.Text,
                    getItemName(cbItem.Text, connectString));
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel");
            }
        }

    }
}
