using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
namespace DashBoard
{
    public partial class frCNXX : Form
    {
        Connect cn = new Connect();
        Process pc = new Process();
        DataProvider dp = new DataProvider();
        //SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=VTIREPORT;Persist Security Info=True;User ID=sa;pwd=123@321;Connect Timeout=30"); //Enter Your sql Server Password eg.pwd=xyz
        string strConnect = "";
        public frCNXX()
        {
            InitializeComponent();
        }
        public frCNXX(DataTable tb,string sp,string ct,string dvtc,string dc,string NgayXX)
        {
            InitializeComponent();
            txtNumber.Text = sp;
            txtCTrinh.Text = ct;
            txtDonVi.Text = dvtc;
            txtDiaChi.Text = dc;
            txtNgayXX.Text = NgayXX;
            dgvPacking.DataSource = tb;
            this.ReadOnlyColumns();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtSalesID.Text != "" || txtPackId.Text != "")
            {
                strConnect = cn.GetConnectString();
                string WhFilter;
                //Get All WareHouse if user Full Permission In Warehouse
                if (dp.CheckUserException(this.strConnect, Environment.UserName))
                    WhFilter = pc.WareHouseStringFilter(dp.getListAllWareHouse(this.strConnect));
                else
                    WhFilter = pc.WareHouseStringFilter(dp.getWHUserPermission(Environment.UserName,this.strConnect));
                //MessageBox.Show(WhFilter);
                //MessageBox.Show(WhFilter.Length.ToString());
                if (txtSalesID.Text != "" && txtPackId.Text != "")
                {
                    //get packing by both packid and salesid
                    dgvPacking.DataSource = this.dp.getPackByPackIdANDSO("getPackByPackIdANDSO_VTIREPORT", strConnect, txtSalesID.Text, txtPackId.Text,WhFilter);
                    this.ReadOnlyColumns();
                }
                else
                {
                    if (txtSalesID.Text != "" && txtPackId.Text == "")
                    {
                        //get packing by only sales order
                        //txtDiaChi.Text = WhFilter;
                        dgvPacking.DataSource = this.dp.getPackBySalesId("getPackBySO_VTIREPORT", this.strConnect, txtSalesID.Text, WhFilter);
                        this.ReadOnlyColumns();
                    }
                    else
                    {
                        if (txtSalesID.Text == ""  && txtPackId.Text != "" )
                        {
                            //dgvPacking.DataSource = this.dp.getPackByPackID("getPackByPackId_VTIREPORT", strConnect, txtPackId.Text,WhFilter);
                            dgvPacking.DataSource = this.dp.getPackByPackID("getPackByPackId_VTIREPORT", strConnect, txtPackId.Text, WhFilter);
                            //get packing by only packing id 
                        }
                        else
                        {
                            MessageBox.Show("Không xác định được cách lấy dữ liệu !");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập Sales Order hoặc Packing Id");
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string strConnect = cn.GetConnectString();
            int stt = 0;
            
            //if (dgvPacking.Rows.Count > 0 && dgvPacking.Rows.Count <= 12 && txtNumber.Text != "") // && txtNgayXX.Text != "" ) // Kiểm tra điều kiện in
            if (dgvPacking.Rows.Count > 0 && dgvPacking.Rows.Count <= 12 && txtNumber.Text != "" && txtNgayXX.Text != "" ) // Kiểm tra điều kiện in
            {
                if (pc.checkSplit(dgvPacking))
                {
                    string wh = this.getWarehouse();
                    if (pc.checkUser(Environment.UserName, wh)) //Check user have permission on warehouse
                    {
                        if (dp.isUserWHInvoiceMandatoryValid(Environment.UserName, wh, this.getSalesOrder(), strConnect))
                        {
                            //MessageBox.Show(dgvPacking.Rows[0].Cells["Date"].Value.ToString());
                            //string cmd;
                            DataSet ds = new DataSet();
                            DataTable tb = new DataTable();
                            int id;
                            string SalesId;
                            string cust = dgvPacking.Rows[0].Cells["CUST"].Value.ToString();
                            //int num = 0;
                            string PackingId = pc.getPackingByList(pc.getPackingByDatagridview(dgvPacking));
                            //MessageBox.Show(PackingId);
                            tb.Columns.Add("STT");      //Số thứ tự
                            tb.Columns.Add("ITEM");     //Mã Item
                            tb.Columns.Add("NAME");     //Tên Item
                            tb.Columns.Add("QTY");      //Số lượng
                            tb.Columns.Add("UOM");      //Don vi
                            tb.Columns.Add("BATCH");    //Số lô
                            //tb.Columns.Add("DATE");   //Ngày giao
                            foreach (DataGridViewRow dr in dgvPacking.Rows)
                            {
                                string batchStr = "";
                                string Qty = dr.Cells["QTY"].Value.ToString();
                                stt += 1;
                                string[] qty = pc.processQty(dr.Cells["EDITQTY"].Value.ToString());
                                string[] batch = pc.processBatch(dr.Cells["BATCH"].Value.ToString());
                                //Neu tach so luong
                                //if (dr.Cells["BATCH"].Value.ToString() != "" &&  batch.Length ==  qty.Length)
                                if (dr.Cells["EDITQTY"].Value.ToString() != "" && batch.Length == qty.Length)
                                {
                                    for (int i = 0; i < qty.Length; i++)
                                    {
                                        if (batchStr.Length != 0)
                                            batchStr += ",Số lượng:" + qty[i] + "-" + "Số lô:" + batch[i];
                                        else
                                            batchStr += "Số lượng:" + qty[i] + "-" + "Số lô:" + batch[i];
                                    }
                                }
                                if (dr.Cells["EDITQTY"].Value.ToString() == "" && batch.Length == qty.Length)
                                {
                                    batchStr = dr.Cells["BATCH"].Value.ToString();
                                }

                                //tb.Rows.Add(stt, dr.Cells["ITEMID"].Value, dr.Cells["NAME"].Value, Qty, dr.Cells["UNIT"].Value, batchStr, dr.Cells["DATE"].Value);
                                tb.Rows.Add(stt, dr.Cells["ITEMID"].Value, dr.Cells["NAME"].Value, Qty, dr.Cells["UNIT"].Value, batchStr);// Bỏ ngày giao
                            }
                            ds.Tables.Add(tb);
                            id = dp.getId(strConnect) + 1;
                            SalesId = dgvPacking.Rows[0].Cells["SALESID"].Value.ToString();
                            //INSERT HEADER
                            dp.InsertNumberByStore("InsertNumber_VTIREPORT", id, strConnect, SalesId, PackingId,wh,txtNumber.Text, txtCTrinh.Text, txtDonVi.Text, txtDiaChi.Text,txtNgayXX.Text);
                            //INSERT LINE 
                            foreach (DataGridViewRow  dr in dgvPacking.Rows)
                            {
                                dp.InsertNumberLinesByStore("InsertNumberLines_VTIREPORT", strConnect, id, SalesId, dr.Cells["PACKINGSLIPID"].Value.ToString(), dr.Cells["WAREHOUSE"].Value.ToString()
                                    , dr.Cells["ItemId"].Value.ToString(), dr.Cells["Name"].Value.ToString(), dr.Cells["ORDERQTY"].Value.ToString()
                                    , Double.Parse(dr.Cells["QTY"].Value.ToString()), dr.Cells["UNIT"].Value.ToString(), dr.Cells["EDITQTY"].Value.ToString(), dr.Cells["BATCH"].Value.ToString()
                                    , dr.Cells["DATE"].Value.ToString(), "", dr.Cells["INVOICEACCOUNT"].Value.ToString(), dr.Cells["CUST"].Value.ToString());
                                    
                            }
                            cryCNXX cnxx = new cryCNXX();

                            //USER PATTERN
                            CrystalDecisions.CrystalReports.Engine.ReportDocument crys = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                            string path = Application.StartupPath + "\\Report\\cryCNXX.rpt";
                            ////MessageBox.Show(path);
                            crys.Load(path);
                            //cryCNXX cnn2 = 
                            crys.SetDataSource(ds);
                            crys.SetParameterValue("SoPhieu", txtNumber.Text);
                            crys.SetParameterValue("Cust", cust);
                            crys.SetParameterValue("CTrinh", txtCTrinh.Text);
                            crys.SetParameterValue("DiaChi", txtDiaChi.Text);
                            crys.SetParameterValue("DVThiCong", txtDonVi.Text);
                            //crys.SetParameterValue("Date", DateTime.Now.ToString("dd/MM/yyyy"));
                            crys.SetParameterValue("Date", txtNgayXX.Text);   //Ngày xuất xưởng
                            
                            //crys.SetParameterValue("Num", num.ToString() + "/" + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yy") + "-HT");
                            // crys.SetParameterValue("PackingId", txtPackId.Text);
                            //crys.SetParameterValue("PackingId", PackingId);
                            //
                            frCNXXView view = new frCNXXView(crys);

                            view.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("User " + Environment.UserName + " không có quyền in Sales Order chưa Invoiced." + this.getSalesOrder());
                        }
                    }
                    else
                    {
                        MessageBox.Show("User " + Environment.UserName + " không có quyền in Chứng Nhận Xuất Xưởng trên kho. " + wh);
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại tổng số lượng trên cột EditQty");
                }
            }         
            else
            {
                MessageBox.Show("Kiểm tra lại dữ liệu, số dòng phải < 12 ,nhập số phiếu  và ngày cấp CNXX !");
            }

        }
        private void ReadOnlyColumns()
        {
            dgvPacking.Columns["SALESID"].ReadOnly = true;
            dgvPacking.Columns["PACKINGSLIPID"].ReadOnly = true;
            dgvPacking.Columns["ITEMID"].ReadOnly = true;
            dgvPacking.Columns["ORDERQTY"].ReadOnly = true;
            dgvPacking.Columns["DATE"].ReadOnly = true;
            //dgvPacking.Columns["NAME"].ReadOnly = true;
            dgvPacking.Columns["QTY"].ReadOnly = true;
            dgvPacking.Columns["InvoiceAccount"].ReadOnly = true;
            dgvPacking.Columns["Warehouse"].ReadOnly = true;
        }
        private void frCNXX_Load(object sender, EventArgs e)
        {
            //txtPackId.Text = "XB031165";
        }
        public string getWarehouse()
        {
            return dgvPacking.Rows[0].Cells["WAREHOUSE"].Value.ToString();
        }
        public string getSalesOrder()
        {
            return dgvPacking.Rows[0].Cells["SALESID"].Value.ToString();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnHis_Click(object sender, EventArgs e)
        {
            CNXXHistory his = new CNXXHistory();
            his.ShowDialog();
        }

        private void dtpNgayXX_ValueChanged(object sender, EventArgs e)
        {
            txtNgayXX.Text = dtpNgayXX.Text;
            //DateTime dt;
            //dt = Convert.ToDateTime(dtpNgayXX.Text);
            //txtNgayXX.Text = dt.ToString("dd/MM/yyy"); 
        }
    }
}
