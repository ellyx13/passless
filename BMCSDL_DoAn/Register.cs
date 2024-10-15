using Newtonsoft.Json;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string fullname = txtFullname.Text;
            string password = txtPassword.Text;

            // Kiểm tra xem người dùng có nhập đủ thông tin không
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Tạo đối tượng chứa thông tin đăng ký
            var registerData = new
            {
                email = email,
                fullname = fullname,
                password = password
            };
            string jsonData = JsonConvert.SerializeObject(registerData);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://passless-api.kiet.site/");

                // Định nghĩa nội dung của yêu cầu POST với định dạng JSON
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Thực hiện gọi API đăng ký
                HttpResponseMessage response = await client.PostAsync("v1/users/register", content);

                // Xử lý phản hồi từ server
                if (response.IsSuccessStatusCode)
                {
                    // Đăng ký thành công, xử lý phản hồi nếu cần
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();

                    // Có thể xử lý thêm nếu cần, ví dụ: chuyển đến màn hình đăng nhập
                }
                else
                {
                    // Đăng ký thất bại, hiển thị thông báo lỗi
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Đăng ký thất bại: {errorMessage}");
                }
            }
        }
    }
}
