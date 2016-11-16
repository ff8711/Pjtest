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
    public partial class frRequest : Form
    {
        public frRequest()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtFrom.Text = dtpFrom.Text;

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            txtTo.Text = dtpTo.Text;
        }

        private void frRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
