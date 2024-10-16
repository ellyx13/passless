<<<<<<< HEAD
﻿using Newtonsoft.Json;
using System;
=======
﻿using System;
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
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

<<<<<<< HEAD
=======
        private void FormCreatePassword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
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

<<<<<<< HEAD
=======
            // Thực hiện hành động lưu mật khẩu (lưu vào file hoặc cơ sở dữ liệu)
            // Ví dụ đơn giản: hiện thông báo đã lưu thành công
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            MessageBox.Show("Mật khẩu đã được lưu thành công!");

            // Sau khi lưu thành công, có thể xóa trắng các ô nhập liệu
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
<<<<<<< HEAD
        private void btnTaoMK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Tạo đối tượng chứa thông tin
            var userInfo = new
            {
                Username = username,
                Name = name,
                Password = password
            };

            // Chuyển đổi đối tượng thành JSON
            string json = JsonConvert.SerializeObject(userInfo, Formatting.Indented);
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Lùi lại 2 thư mục từ thư mục hiện tại
            string parentDirectory = Path.GetFullPath(Path.Combine(currentDirectory, @"..\..\.."));
            
            // Lưu JSON vào file
            string filePath = Path.Combine(parentDirectory, "userData.json");
            File.WriteAllText(filePath, json);

            MessageBox.Show("Thông tin đã được lưu vào file: " + filePath);
=======

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
        }
    }
}
