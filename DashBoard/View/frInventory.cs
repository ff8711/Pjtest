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

namespace DashBoard.View
{
    public partial class frInventory : Form
    {
        Connect cnn = new Connect();
        DataProvider dp = new DataProvider();
        Process p = new Process();
        string connectString;
        public frInventory()
        {
            InitializeComponent();
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbInventory.Text);
            if (txtDate.Text.Length >= 10 && cbWh.Text != "" && cbInventory.Text != @"Chọn")
            {
                switch (cbInventory.Text)
                {
                    case "Khung":
                        dgvInvOnHand.DataSource = dp.getInventory(connectString, "getInventoryFrame_VTIREPORT", cbWh.Text,
                    txtDate.Text);
                        break;
                    case "Tấm":
                        dgvInvOnHand.DataSource = dp.getInventory(connectString, "getInventoryBoard_VTIREPORT", cbWh.Text,
                    txtDate.Text);
                        break;
                    case "Tole":
                        dgvInvOnHand.DataSource = dp.getInventory(connectString, "getInventoryTole_VTIREPORT", cbWh.Text,
                    txtDate.Text);
                        break;
                    case "Phụ kiện":
                        dgvInvOnHand.DataSource = dp.getInventory(connectString, "getInventoryAsessories_VTIREPORT", cbWh.Text,
                    txtDate.Text);
                        break;
                    case "Khung-Tấm-Phụ kiện":
                        dgvInvOnHand.DataSource = dp.getInventory(connectString, "getInventoryFrameBoardAccessories_VTIREPORT", cbWh.Text,
                    txtDate.Text);
                        break;
                    case "Khung - Tấm - Phụ kiện - Tole":
                        dgvInvOnHand.DataSource = dp.getInventory(connectString, "getInventoryFrameBoardAccessoriesTole_VTIREPORT", cbWh.Text,
                    txtDate.Text);
                        break;
                    case "Nguyên vật liệu - Thiết bị":
                        dgvInvOnHand.DataSource = dp.getInventory(connectString, "getInventoryMaterialDevices_VTIREPORT", cbWh.Text,
                    txtDate.Text);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập ngày lấy tồn kho hoặc mã kho ,hoặc chưa chọn lấy dữ liệu nào ");
            }
        }
        public void loadWareHouse()
        {
            string cmd = "SELECT [Warehouse] FROM [VTIREPORT].[dbo].[WH] where [Warehouse] like '%HP%' or [Warehouse] like '%CH%'  or [Warehouse] like '%TC%' ";
            cbWh.DataSource = p.getListByDataTable(dp.GetDataByCommandTextAndConnectString(cmd, this.connectString));
        }
        public void ExportToExcel(string date, string warehouse)
        {
            string starUpPath = cnn.GetLocationString();
            string filePatch = starUpPath + @"Inventory-" + Environment.UserName + DateTime.Now.ToString("-ddMMyyyy-hhmmss") + ".xlsx";
            FileInfo newFile = new FileInfo(filePatch);
            if (newFile.Exists)
            {
                newFile.Delete();
                newFile = new FileInfo(starUpPath + @"Inventory-" + Environment.UserName + DateTime.Now.ToString("-ddMMyyyy-hhmmss") + ".xlsx");
            }
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int rowIndex = 5;
                int columIndex;
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("Intenvory");
                // Header
                ws.Cells[1, 1].Value = "Tồn Kho Theo Ngày và Kho";
                using (var range = ws.Cells[1, 1, 1, 10])
                {
                    range.Merge = true;
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    range.Style.Font.Size = 20;
                    range.Style.Font.Bold = true;
                    range.Style.Font.Color.SetColor(Color.Green);
                }
                //ws.Cells[2, 1].Value = "ItemId:";
                //ws.Cells[2, 1].Style.Font.Bold = true;
                //ws.Cells[2, 2].Value = ItemId;
                //ws.Cells[2, 3].Value = "Item Name:";
                //ws.Cells[2, 3].Style.Font.Bold = true;
                //ws.Cells[2, 4].Value = ItemName;
                ws.Cells[3, 1].Value = "Warehouse:";
                ws.Cells[3, 1].Style.Font.Bold = true;
                ws.Cells[3, 2].Value = warehouse;

                ws.Cells[4, 1].Value = "Tồn kho ngày:";
                ws.Cells[4, 1].Style.Font.Bold = true;
                ws.Cells[4, 2].Value = date;
                //ws.Cells[4, 3].Value = "Đến ngày:";
                //ws.Cells[4, 3].Style.Font.Bold = true;
                //ws.Cells[4, 4].Value = to;
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
                ws.Cells[5, 8].Value = "Ending";
                ws.Cells[5, 8].Style.Font.Bold = true;


                //Line
                foreach (DataGridViewRow dr in dgvInvOnHand.Rows)
                {
                    rowIndex += 1;
                    columIndex = 0;
                    foreach (DataGridViewColumn dc in dgvInvOnHand.Columns)
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
        /*
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
        */
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvInvOnHand.RowCount > 0)
            {
                ExportToExcel(txtDate.Text,cbWh.Text);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel");
            }
        }
        private void frInventoryAll_Load(object sender, EventArgs e)
        {
            this.connectString = cnn.GetConnectString();
            //Load Warehouse
            this.loadWareHouse();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dtpDate.Text;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


    }
}
