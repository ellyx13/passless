﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace BMCSDL_DoAn
{
    public partial class FormCreateVault : Form
    {
        public FormCreateVault()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();
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
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            string vaultName = txtVaultName.Text.Trim();

            if (string.IsNullOrEmpty(vaultName))
            {
                MessageBox.Show("Vui lòng nhập tên Vault.");
                return;
            }

            var result = await CreateVaultAsync(vaultName);
            if (result)
            {
                MessageBox.Show("Vault đã được tạo thành công.");
            }
            else
            {
                MessageBox.Show("Tên Vault không hợp lệ hoặc đã tồn tại.");
            }
        }
        private async Task<bool> CreateVaultAsync(string vaultName)
        {
            var url = "https://passless-api.kiet.site/v1/vaults"; // Thay đổi với URL API của bạn
            var requestBody = new { name = vaultName }; // Tạo đối tượng JSON

            string json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                // Gọi API để tạo Vault
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode(); // Ném ngoại lệ nếu mã trạng thái không thành công

                // Đọc phản hồi JSON
                var responseContent = await response.Content.ReadAsStringAsync();
                dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);

                // Giả sử API trả về thông tin về Vault mới tạo
                return jsonResponse.name == vaultName; // Kiểm tra tên Vault
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu tChu = new TrangChu();
            tChu.Show();
        }
    }
}
