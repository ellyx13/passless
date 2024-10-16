namespace BMCSDL_DoAn
{
    partial class FormCreatePassword
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
            labelName = new Label();
            txtName = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSavePassword = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelName.Location = new Point(49, 121);
            labelName.Name = "labelName";
            labelName.Size = new Size(155, 31);
            labelName.TabIndex = 0;
            labelName.Text = "Tên Tài khoản:";
            labelName.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(229, 126);
            txtName.Name = "txtName";
            txtName.Size = new Size(263, 27);
            txtName.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 13.2000008F);
            labelUsername.Location = new Point(82, 214);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(122, 31);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 13.2000008F);
            labelPassword.Location = new Point(87, 298);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(115, 31);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(229, 219);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 27);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(229, 299);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnSavePassword
            // 
            btnSavePassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSavePassword.Location = new Point(274, 368);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(208, 43);
            btnSavePassword.TabIndex = 6;
            btnSavePassword.Text = "Lưu Mật Khẩu";
            btnSavePassword.UseVisualStyleBackColor = true;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(264, 47);
            label1.Name = "label1";
            label1.Size = new Size(270, 54);
            label1.TabIndex = 7;
            label1.Text = "Tạo mật khẩu";
            // 
            // FormCreatePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSavePassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Name = "FormCreatePassword";
            Text = "FormCreatePassword";
            Load += FormCreatePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox txtName;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSavePassword;
        private Label label1;
    }
}