namespace BMCSDL_DoAn
{
    partial class FaceLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxCamera = new PictureBox();
            btnFaceScan = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.Location = new Point(201, 45);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(445, 326);
            pictureBoxCamera.TabIndex = 0;
            pictureBoxCamera.TabStop = false;
            // 
            // btnFaceScan
            // 
            btnFaceScan.Location = new Point(227, 391);
            btnFaceScan.Name = "btnFaceScan";
            btnFaceScan.Size = new Size(75, 23);
            btnFaceScan.TabIndex = 1;
            btnFaceScan.Text = "Quét";
            btnFaceScan.UseVisualStyleBackColor = true;
            btnFaceScan.Click += btnFaceScan_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(492, 391);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FaceLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnFaceScan);
            Controls.Add(pictureBoxCamera);
            Name = "FaceLogin";
            Text = "FaceLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCamera;
        private Button btnFaceScan;
        private Button btnThoat;
    }
}