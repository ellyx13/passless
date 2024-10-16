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
    public partial class ShowPassWord : Form
    {
        public ShowPassWord()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadDataFromJson();
        }
        private void LoadDataFromJson()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Lùi lại 2 thư mục từ thư mục hiện tại
            string parentDirectory = Path.GetFullPath(Path.Combine(currentDirectory, @"..\..\.."));
            string filePath = Path.Combine(parentDirectory, "userData.json");

            // Kiểm tra xem file JSON có tồn tại không
            if (File.Exists(filePath))
            {
                try
                {
                    // Đọc nội dung file JSON
                    string jsonData = File.ReadAllText(filePath);

                    // Deserialize dữ liệu từ JSON thành danh sách đối tượng
                    List<UserInfo> users = JsonConvert.DeserializeObject<List<UserInfo>>(jsonData);

                    // Xóa nội dung cũ trong ListBox
                    listBoxUsers.Items.Clear();

                    // Duyệt qua danh sách người dùng và thêm thông tin vào ListBox
                    foreach (var user in users)
                    {
                        string userInfo = $"Name: {user.Name}, Username: {user.Username}, Password: {user.Password}";
                        listBoxUsers.Items.Add(userInfo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi đọc file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File userData.json không tồn tại.");
            }

        }
        public class UserInfo
        {
            public string Username { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
        }
    }
}
