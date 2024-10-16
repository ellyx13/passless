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
    public partial class FormCreateVault : Form
    {
        public FormCreateVault()
        {
            InitializeComponent();
        }

        private void btnCreateVault_Click(object sender, EventArgs e)
        {
            // Lấy tên kho lưu trữ từ TextBox
            string vaultName = txtVaultName.Text;

            // Kiểm tra dữ liệu có hợp lệ không
            if (string.IsNullOrWhiteSpace(vaultName))
            {
                MessageBox.Show("Vui lòng nhập tên kho lưu trữ!");
                return;
            }

            // Thực hiện hành động tạo kho lưu trữ (lưu vào cơ sở dữ liệu hoặc file)
            // Ví dụ đơn giản: hiện thông báo đã tạo kho lưu trữ thành công
            MessageBox.Show($"Kho lưu trữ '{vaultName}' đã được tạo thành công!");

            // Xóa trắng ô nhập liệu sau khi tạo thành công
            txtVaultName.Clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // Mở thư mục gốc
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp"; // Chỉ hiển thị file ảnh
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn ảnh
                    string filePath = openFileDialog.FileName;

                    // Hiển thị ảnh lên PictureBox
                    pictureBoxIcon.Image = new Bitmap(filePath);
                }
            }
        }
    }
}
