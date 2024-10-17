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
            label1.Location = new Point(317, 37);
            label1.Name = "label1";
            label1.Size = new Size(181, 45);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(260, 126);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 44);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(260, 191);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 44);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(137, 135);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(137, 200);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "PassWord";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(280, 310);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 5;
            label4.Text = "Chưa có tài khoản?";
            // 
            // btnDangky
            // 
            btnDangky.Location = new Point(449, 312);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(75, 23);
            btnDangky.TabIndex = 6;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // btnFacelog
            // 
            btnFacelog.Location = new Point(618, 12);
            btnFacelog.Name = "btnFacelog";
            btnFacelog.Size = new Size(170, 23);
            btnFacelog.TabIndex = 7;
            btnFacelog.Text = "Đăng Nhập bằng khuôn mặt";
            btnFacelog.UseVisualStyleBackColor = true;
            btnFacelog.Click += btnFacelog_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangnhap.Location = new Point(340, 254);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(122, 33);
            btnDangnhap.TabIndex = 8;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangnhap);
            Controls.Add(btnFacelog);
            Controls.Add(btnDangky);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
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