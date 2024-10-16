namespace BMCSDL_DoAn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDangky = new Button();
            btnFacelog = new Button();
            btnDangnhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
<<<<<<< HEAD
            label1.Location = new Point(317, 37);
            label1.Name = "label1";
            label1.Size = new Size(181, 45);
=======
            label1.Location = new Point(362, 49);
            label1.Name = "label1";
            label1.Size = new Size(222, 54);
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(297, 168);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(301, 57);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(297, 255);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 57);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
<<<<<<< HEAD
=======
            txtPassword.TextChanged += txtPassword_TextChanged;
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(157, 180);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(157, 267);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 4;
            label3.Text = "PassWord";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(320, 413);
            label4.Name = "label4";
            label4.Size = new Size(196, 30);
            label4.TabIndex = 5;
            label4.Text = "Chưa có tài khoản?";
            // 
            // btnDangky
            // 
            btnDangky.Location = new Point(513, 416);
            btnDangky.Margin = new Padding(3, 4, 3, 4);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(86, 31);
            btnDangky.TabIndex = 6;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // btnFacelog
            // 
            btnFacelog.Location = new Point(706, 16);
            btnFacelog.Margin = new Padding(3, 4, 3, 4);
            btnFacelog.Name = "btnFacelog";
            btnFacelog.Size = new Size(194, 31);
            btnFacelog.TabIndex = 7;
            btnFacelog.Text = "Đăng Nhập bằng khuôn mặt";
            btnFacelog.UseVisualStyleBackColor = true;
            btnFacelog.Click += btnFacelog_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
<<<<<<< HEAD
            btnDangnhap.Location = new Point(340, 254);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(122, 33);
=======
            btnDangnhap.Location = new Point(389, 339);
            btnDangnhap.Margin = new Padding(3, 4, 3, 4);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(140, 44);
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            btnDangnhap.TabIndex = 8;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnDangnhap);
            Controls.Add(btnFacelog);
            Controls.Add(btnDangky);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDangky;
        private Button btnFacelog;
        private Button btnDangnhap;
    }
}