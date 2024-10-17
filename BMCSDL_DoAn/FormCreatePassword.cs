using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Http;

namespace BMCSDL_DoAn
{
    public partial class FormCreatePassword : Form
    {
        public FormCreatePassword()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();
        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra dữ liệu có hợp lệ không
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            MessageBox.Show("Mật khẩu đã được lưu thành công!");

            // Sau khi lưu thành công, có thể xóa trắng các ô nhập liệu
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private async void btnTaoMK_Click(object sender, EventArgs e)
        {
            var apiurl = "https://passless-api.kiet.site/v1/vault-items?page=1&limit=20&sort_by=created_at&order_by=desc";
            var data_vault_item = new
            {
                vault_id = txtVaultID.Text,
                name = txtName.Text,
                type = cbType.Text,
                username = txtUsername.Text,
                password = txtPassword.Text,
                url = txtURL.Text,
                notes = txtNote.Text,
                account_number = txtAccountNumber.Text,
            };
            var json_data_vaul_item = JsonConvert.SerializeObject(data_vault_item);
            var content = new StringContent("application/json");
            try
            {
                var response = await client.GetAsync(apiurl);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody=await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseBody);
                    MessageBox.Show("Tạo mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Tạo mật khẩu thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
