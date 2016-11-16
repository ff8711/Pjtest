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
    public partial class ServerConfig : Form
    {
        DataProvider dp = new DataProvider();
        public ServerConfig()
        {
            InitializeComponent();
        }

        private void ServerConfig_Load(object sender, EventArgs e)
        {
            txtDatabse.ReadOnly = true;
            txtServer.ReadOnly = true;
            ckbEdit.Checked = false;
        }

        private void ckbEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEdit.Checked)
            {
                txtDatabse.ReadOnly = false;
                txtServer.ReadOnly = false;
            }
            else
            {
                txtDatabse.ReadOnly = true;
                txtServer.ReadOnly = true;
            }

        }

        private void btnGetInf_Click(object sender, EventArgs e)
        {
            string[] s = dp.getServerInfo();
            txtServer.Text = s[0];
            txtDatabse.Text = s[1];

            txtDatabse.ReadOnly = true;
            txtServer.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dp.updateServerInfo(txtServer.Text, txtDatabse.Text);
            txtDatabse.ReadOnly = true;
            txtServer.ReadOnly = true;
            MessageBox.Show("Update thành công !");
        }
    }
}
