using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BMCSDL_DoAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnDangnhap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập email và mật khẩu!");
                return;
            }
            var loginData = new
            {
                email = email,
                password = password,
            };
            string jsonData = JsonConvert.SerializeObject(loginData);
            //Call API
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://passless-api.kiet.site/"); // URL của API đăng nhập

                // Tạo yêu cầu POST
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Gọi API và đợi kết quả
                HttpResponseMessage response = await client.PostAsync("v1/users/login", content);

                if (response.IsSuccessStatusCode)
                {
                    // Xử lý khi đăng nhập thành công
                    string result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Đăng nhập thành công!");
                    // Tiến hành chuyển tiếp hoặc xử lý khác
                }
                else
                {
                    // Xử lý khi đăng nhập thất bại
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Đăng nhập thất bại: {errorMessage}");
                }
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {

            Register formDangKy = new Register();
            this.Hide();
            formDangKy.Show();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công");
            this.Hide();
            TrangChu tCHu = new TrangChu();
            tCHu.Show();
        }

        private void btnFacelog_Click(object sender, EventArgs e)
        {
            FaceLogin FaceLog = new FaceLogin();
            this.Hide();
            FaceLog.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}