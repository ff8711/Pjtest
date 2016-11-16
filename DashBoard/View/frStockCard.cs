using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using System.Diagnostics;

namespace DashBoard
{
    public partial class frStockCard : Form
    {
        Connect cn = new Connect();
        Process pc = new Process();
        DataProvider dp = new DataProvider();
        string connectStr;
        public frStockCard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            txtFrom.Text = dtpFrom.Text;
            
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            txtTo.Text = dtpTo.Text;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtItemId.Text != "" && txtWh.Text != "" && txtFrom.Text != "" && txtTo.Text != "")
            {
            dgvStockCard.DataSource = dp.getStockCard(this.connectStr, "StockCard_VtiReport", txtItemId.Text, txtWh.Text, txtFrom.Text,txtTo.Text
                            , txtConfig.Text, txtSize.Text, txtColor.Text, txtSerial.Text);
            }
            else { MessageBox.Show("Nhập mã sản phẩm , kho,  ngày tháng"); }
        }

        private void frStockCard_Load(object sender, EventArgs e)
        {
            this.connectStr = cn.GetConnectString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
            if (dgvStockCard.RowCount > 0)
            {
                //MessageBox.Show(this.connectStr);
                DataTable tb,bg;
                string ItemName = "";
                string BeginQty = "0";
                string cmd = "select TOP 1 Name from VTIREPORT.dbo.Item where ItemId LIKE '%" + txtItemId.Text + "%'"  ;
                tb = dp.GetDataByCommandTextAndConnectString(cmd,this.connectStr);
                //MessageBox.Show(tb.Rows.Count.ToString());
                if (tb.Rows.Count > 0)
                    ItemName = tb.Rows[0][0].ToString();
                bg = dp.getBeginQty(this.connectStr, "BeginQty_VTIReport", txtItemId.Text, txtWh.Text, txtFrom.Text
                                                    , txtTo.Text, txtConfig.Text, txtSize.Text, txtColor.Text, txtSerial.Text);
                if(bg.Rows.Count > 0)
                 BeginQty = bg.Rows[0][0].ToString();
                ExportToExcel(txtItemId.Text,ItemName,BeginQty,txtWh.Text,txtConfig.Text,txtSize.Text,txtColor.Text,txtSerial.Text,txtFrom.Text,txtTo.Text);
            }
            else { MessageBox.Show("Không có dữ liệu để xuất Excel"); }
        }
        public void ExportToExcel(string ItemId,string ItemName,string beginQty,string warehouse,
                                    string config,string size,string color,string serial,string from,string to)
        {
            //string starUpPath = "D:/OutPut/";
            string starUpPath = cn.GetLocationString();
            //MessageBox.Show(starUpPath);
            string filePatch = starUpPath + @"StockCard-" + Environment.UserName + DateTime.Now.ToString("-ddMMyyyy-hhmmss") + ".xlsx"; 
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
                ws.Cells[1, 1].Value = "Thẻ Kho";
                using (var range = ws.Cells[1, 1, 1, 16])
                {
                    range.Merge = true;
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    range.Style.Font.Size = 20;
                    range.Style.Font.Bold = true;
                    range.Style.Font.Color.SetColor(Color.Green);
                }
                //ws.Column(7).AutoFit();
                ws.Column(7).Style.Numberformat.Format = "dd/MM/yyyy";
                ws.Column(14).Style.Numberformat.Format = "_(* #,##0_);_(* (#,##0);_(@_)";
                ws.Column(15).Style.Numberformat.Format = "_(* #,##0_);_(* (#,##0);_(@_)";
                ws.Column(16).Style.Numberformat.Format = "_(* #,##0_);_(* (#,##0);_(@_)";
                //ws.Column(1).BestFit = true;  
                ws.Cells[2, 1].Value = "Item Id:";
                ws.Cells[2, 1].Style.Font.Bold = true;
                ws.Cells[2, 2].Value = ItemId;
                ws.Cells[2, 3].Value = "Product Name:";
                ws.Cells[2, 3].Style.Font.Bold = true;
                ws.Cells[2, 4].Value = ItemName;
                using (var range = ws.Cells[2, 4, 2, 10])
                {
                    range.Merge = true;
                }
                ws.Cells[3, 1].Value = "Warehouse:";
                ws.Cells[3, 1].Style.Font.Bold = true;
                ws.Cells[3, 2].Value = warehouse;
                ws.Cells[3, 3].Value = "Config:";
                ws.Cells[3, 3].Style.Font.Bold = true;
                ws.Cells[3, 4].Value = config;
                ws.Cells[3, 5].Value = "Size:";
                ws.Cells[3, 5].Style.Font.Bold = true;
                ws.Cells[3, 6].Value = size;
                ws.Cells[3, 7].Value = "Color:";
                ws.Cells[3, 7].Style.Font.Bold = true;
                ws.Cells[3, 8].Value = color;
                ws.Cells[3, 9].Value = "Serial:";
                ws.Cells[3, 9].Style.Font.Bold = true;
                ws.Cells[3, 10].Value = serial;

                ws.Cells[4, 1].Value = "Từ ngày:";
                ws.Cells[4, 1].Style.Font.Bold = true;
                ws.Cells[4, 2].Value = from;
                ws.Cells[4, 3].Value = "Đến ngày:";
                ws.Cells[4, 3].Style.Font.Bold = true;
                ws.Cells[4, 4].Value = to;

                ws.Cells[4, 14].Value = "Tồn đầu:";
                ws.Cells[4, 14].Style.Font.Bold = true;
                ws.Cells[4, 15].Value = double.Parse(beginQty);
                ws.Cells[4, 14].Style.Font.Color.SetColor(Color.Blue);
                ws.Cells[4, 14].Style.Numberformat.Format = "_(* #,##0_);_(* (#,##0);_(@_)";
                using (var range = ws.Cells[4, 15, 4, 16])
                {
                    range.Merge = true;
                }
                ws.Cells[5, 1].Value = "ItemId";
                ws.Cells[5, 2].Value = "Warehouse";
                ws.Cells[5, 3].Value = "Config";
                ws.Cells[5, 4].Value = "Size";
                ws.Cells[5, 5].Value = "Color";
                ws.Cells[5, 6].Value = "Serial";
                ws.Cells[5, 7].Value = "Date";
                ws.Cells[5, 8].Value = "CustomerID";
                ws.Cells[5, 9].Value = "VendorId";
                ws.Cells[5, 10].Value = "Cust/Vend Name";
                ws.Cells[5, 11].Value = "Number";
                ws.Cells[5, 12].Value = "Voucher";
                ws.Cells[5, 13].Value = "Type";
                ws.Cells[5, 14].Value = "Nhập";
                ws.Cells[5, 15].Value = "Xuất";
                ws.Cells[5, 16].Value = "Tồn";
                //Format Header
                using (var range = ws.Cells[5, 1, 5, 16])
                {
                    //setup Bold
                    range.Style.Font.Bold = true;
                    //Style solid
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    //Backgound color
                    range.Style.Fill.BackgroundColor.SetColor(Color.DarkRed);
                    //Font color
                    range.Style.Font.Color.SetColor(Color.White);
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                }
                foreach (DataGridViewRow dr in dgvStockCard.Rows)
                {
                    rowIndex += 1;
                    columIndex = 0;
                    foreach (DataGridViewColumn dc in dgvStockCard.Columns)
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
    }
}
