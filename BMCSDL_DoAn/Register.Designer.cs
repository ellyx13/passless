﻿namespace BMCSDL_DoAn
{
    partial class Register
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
            btnDangKy = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label5 = new Label();
            txtFullname = new TextBox();
            SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(353, 269);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(93, 42);
            btnDangKy.TabIndex = 13;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(164, 228);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 11;
            label3.Text = "PassWord";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(164, 103);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 10;
            label2.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(287, 219);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 44);
            txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(287, 94);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 44);
            txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(353, 28);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 7;
            label1.Text = "Đăng ký";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(164, 165);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 15;
            label5.Text = "UserName";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(287, 156);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(264, 44);
            txtFullname.TabIndex = 14;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 427);
            Controls.Add(label5);
            Controls.Add(txtFullname);
            Controls.Add(btnDangKy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangKy;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label1;
        private Label label5;
        private TextBox txtFullname;
    }
}