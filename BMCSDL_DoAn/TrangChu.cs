using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMCSDL_DoAn
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnCreateVault_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCreateVault vault = new FormCreateVault();
            vault.ShowDialog();
        }

        private void btnPassWordCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCreatePassword pass = new FormCreatePassword();
            pass.ShowDialog();
        }

        private void btnPassManage_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowPassWord pass = new ShowPassWord();
            pass.ShowDialog();
        }
    }
}
