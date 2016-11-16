using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
namespace DashBoard
{
    public partial class frCNXXView : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=VTIREPORT;Persist Security Info=True;User ID=sa;pwd=123@321;Connect Timeout=30"); //Enter Your sql Server Password eg.pwd=xyz
        ReportDocument _rpd;
        public frCNXXView()
        {
            InitializeComponent();
        }
        public frCNXXView(ReportDocument rpd)
        {
            InitializeComponent();
            _rpd = rpd;
            this.WindowState = FormWindowState.Maximized;
            //Detect when print
            //foreach (Control control in crvCNXX.Controls)
            //{
            //    if (control is System.Windows.Forms.ToolStrip)
            //    {

                    //Default Print Button
                    //ToolStripItem tsItem = ((ToolStrip)control).Items[1];
                    //tsItem.Click += new EventHandler(tsItem_Click);

                    ////Custom Button
                    //ToolStripItem tsNewItem = ((ToolStrip)control).Items.Add("Print");
                    //tsNewItem.ToolTipText = "Custom Print Button";
                    ////tsNewItem.Image = Image.
                    ////tsNewItem.Image = Resources.CustomButton;
                    //tsNewItem.Tag = "99";
                    //((ToolStrip)control).Items.Insert(0, tsNewItem);
                    //tsNewItem.Click += new EventHandler(tsNewItem_Click);
            //    }
            //}
        }

        private void frCNXXView_Load(object sender, EventArgs e)
        {
            crvCNXX.ReportSource = _rpd;
                
        }
        //Detect when print
        public delegate void CustomPrintDelegate();
        public Delegate CustomPrintMethod { get; set; }
        void tsNewItem_Click(object sender, EventArgs e)
        {
            if (CustomPrintMethod != null)
            {
                CustomPrintMethod.DynamicInvoke(null);
            }
        }
        void tsItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            if (CustomPrintMethod != null)
            {
                CustomPrintMethod.DynamicInvoke(null);
            }
        }
    }
}
