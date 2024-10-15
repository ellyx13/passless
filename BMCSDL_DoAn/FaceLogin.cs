using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
namespace BMCSDL_DoAn
{
    public partial class FaceLogin : Form
    {
        public FaceLogin()
        {
            InitializeComponent();
        }
        private VideoCapture _capture;  // Biến để điều khiển camera
        private bool _isCameraRunning = false;
        private void FormFaceLogin_Load(object sender, EventArgs e)
        {
            // Khi form được mở, bật camera
            StartCamera();
        }
        private void StartCamera()
        {
            if (_capture == null)
            {
                try
                {
                    _capture = new VideoCapture(); // Mở camera mặc định (camera 0)
                    _capture.ImageGrabbed += ProcessFrame;  // Đăng ký sự kiện xử lý hình ảnh
                    _capture.Start(); // Bắt đầu ghi hình
                    _isCameraRunning = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể khởi động camera. Vui lòng kiểm tra kết nối camera.\n" + ex.Message);
                }
            }
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture == null)
            {
                try
                {
                    _capture = new VideoCapture(0); // Mở camera mặc định (camera 0)
                    if (!_capture.IsOpened)
                    {
                        MessageBox.Show("Không thể mở camera, kiểm tra lại kết nối.");
                        return;
                    }
                    _capture.ImageGrabbed += ProcessFrame;  // Đăng ký sự kiện xử lý hình ảnh
                    _capture.Start(); // Bắt đầu ghi hình
                    _isCameraRunning = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi khởi động camera: " + ex.Message);
                }
            }
        }
        private void btnFaceScan_Click(object sender, EventArgs e)
        {
            if (_isCameraRunning && _capture != null)
            {
                // Chụp ảnh từ camera và lưu lại
                Mat frame = new Mat();
                _capture.Retrieve(frame);
                string filePath = $"FaceCapture_{DateTime.Now.Ticks}.jpg";
                frame.Save(filePath);

                MessageBox.Show("Ảnh đã được chụp và lưu: " + filePath);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form FaceLogin và trở về form đăng nhập
            this.Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Giải phóng camera khi đóng form
            if (_capture != null)
            {
                _capture.Dispose();
            }
            base.OnFormClosed(e);
        }
    }
}
