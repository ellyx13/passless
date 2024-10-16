namespace BMCSDL_DoAn
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
            btnDangKy.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangKy.Location = new Point(403, 359);
            btnDangKy.Margin = new Padding(3, 4, 3, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(134, 56);
            btnDangKy.TabIndex = 13;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(187, 304);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 11;
            label3.Text = "PassWord";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(187, 137);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 10;
            label2.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(328, 292);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 57);
            txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(328, 125);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(301, 57);
            txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(403, 37);
            label1.Name = "label1";
            label1.Size = new Size(172, 54);
            label1.TabIndex = 7;
            label1.Text = "Đăng ký";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(187, 220);
            label5.Name = "label5";
            label5.Size = new Size(115, 30);
            label5.TabIndex = 15;
            label5.Text = "UserName";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(328, 208);
            txtFullname.Margin = new Padding(3, 4, 3, 4);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(301, 57);
            txtFullname.TabIndex = 14;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 569);
            Controls.Add(label5);
            Controls.Add(txtFullname);
            Controls.Add(btnDangKy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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