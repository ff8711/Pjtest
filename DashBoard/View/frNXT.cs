using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using OfficeOpenXml.DataValidation;
using OfficeOpenXml.ConditionalFormatting;
using OfficeOpenXml.Drawing;

namespace DashBoard
{
    public partial class frNXT : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=VTIREPORT;Persist Security Info=True;User ID=sa;pwd=123@321;Connect Timeout=30"); //Enter Your sql Server Password eg.pwd=xyz
        public frNXT()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
        private void load(string from,string to)
        {
            SqlCommand cmd = new SqlCommand("nxt", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@from", SqlDbType.Date).Value = from;
            cmd.Parameters.Add("@to", SqlDbType.Date).Value = to;
            Con.Open();

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adap.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                dgvNXT.DataSource = tb;
                dgvNXT.AutoGenerateColumns = false;
                dgvNXT.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);             
            }
            Con.Close();
        }
        private void ExportToExcel()
        {
            if(dgvNXT.RowCount > 0)
            {

            }
            else
            {
                MessageBox.Show("Empty Data, Process End !");                   
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("nxtDimensionNotTI",Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@from",SqlDbType.Date).Value = txtFrom.Text;
            cmd.Parameters.Add("@to", SqlDbType.Date).Value=txtTo.Text;
            cmd.Parameters.Add("@wh", SqlDbType.NVarChar,10).Value = cbWH.Text;
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();

                adap.Fill(tb);
                dgvNXT.DataSource = tb;
                Con.Close();
                this.CreateExcel(tb);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }           
            
        }

        private void NXT_Load(object sender, EventArgs e)
        {
            string[] wh = new string[] { "HP10", "HP11", "HP20", "HP21", "HP30" };
            cbWH.DataSource = wh;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbWH.Text);
        }
        private void CreateExcel(DataTable tb)
        {
            int rowIndex = 5;
            int columIndex = 0;
            string starUpPath = Application.StartupPath + "/OutPut/";
            FileInfo newFile = new FileInfo(starUpPath + @"NXT-Dimension-"+DateTime.Now.ToString("ddMMyyyyhhmmss")+".xlsx");
            if (newFile.Exists)
            {
                newFile.Delete();
                newFile = new FileInfo(starUpPath + @"NXT-Dimension-" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ".xlsx");
            }
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("NXT");
                //Add Header
                ws.Cells[5, 1].Value = "Sản phẩm";
                ws.Cells[5, 2].Value = "Mã gộp";
                ws.Cells[5, 3].Value =  "Tên";
                ws.Cells[5, 4].Value =  "Config";
                ws.Cells[5, 5].Value =  "Size";
                ws.Cells[5, 6].Value = "Color";
                ws.Cells[5, 7].Value = "Serial";
                ws.Cells[5, 8].Value = "Tồn Đầu";
                ws.Cells[5, 9].Value = "Nhập";
                ws.Cells[5, 10].Value = "Xuất";
                ws.Cells[5, 11].Value = "Tồn cuối";
                //Format Header
                using (var range = ws.Cells[5,1,5,12])
                {
                    //setup Bold
                    range.Style.Font.Bold = true;
                    //Style solid
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    //Backgound color
                    range.Style.Fill.BackgroundColor.SetColor(Color.DarkRed);
                    //Font color
                    range.Style.Font.Color.SetColor(Color.White);
                }
                foreach(DataRow dr in tb.Rows)
                {
                    rowIndex += 1;
                    columIndex =0;
                    foreach (DataColumn dc in tb.Columns)
                    {
                        columIndex += 1;
                        ws.Cells[rowIndex,columIndex].Value = dr[dc.ColumnName].ToString();
                        
                    }
                }
               

                package.Save();
                MessageBox.Show("Done!");
            }
            

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            txtFrom.Text = dtpFrom.Text;
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            txtTo.Text = dtpTo.Text;
        }
    }
}
