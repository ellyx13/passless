using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BMCSDL_DoAn
{
    public partial class FormCreatePassword : Form
    {
        public FormCreatePassword()
        {
            InitializeComponent();
        }

        private void FormCreatePassword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

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

            // Thực hiện hành động lưu mật khẩu (lưu vào file hoặc cơ sở dữ liệu)
            // Ví dụ đơn giản: hiện thông báo đã lưu thành công
            MessageBox.Show("Mật khẩu đã được lưu thành công!");

            // Sau khi lưu thành công, có thể xóa trắng các ô nhập liệu
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
