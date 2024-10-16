namespace BMCSDL_DoAn
{
    partial class TrangChu
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
            btnCreateVault = new Button();
            btnPassManage = new Button();
            btnLogout = new Button();
            btnPassWordCreate = new Button();
            SuspendLayout();
            // 
            // btnCreateVault
            // 
            btnCreateVault.Location = new Point(662, 81);
            btnCreateVault.Name = "btnCreateVault";
            btnCreateVault.Size = new Size(126, 31);
            btnCreateVault.TabIndex = 0;
            btnCreateVault.Text = "Tạo Vault";
            btnCreateVault.UseVisualStyleBackColor = true;
            btnCreateVault.Click += btnCreateVault_Click;
            // 
            // btnPassManage
            // 
            btnPassManage.Location = new Point(662, 199);
            btnPassManage.Name = "btnPassManage";
            btnPassManage.Size = new Size(126, 31);
            btnPassManage.TabIndex = 2;
            btnPassManage.Text = "Quản lý mật khẩu";
            btnPassManage.UseVisualStyleBackColor = true;
            btnPassManage.Click += btnPassManage_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(662, 257);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 31);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnPassWordCreate
            // 
            btnPassWordCreate.Location = new Point(662, 142);
            btnPassWordCreate.Name = "btnPassWordCreate";
            btnPassWordCreate.Size = new Size(126, 31);
            btnPassWordCreate.TabIndex = 4;
            btnPassWordCreate.Text = "Thêm Mật Khẩu";
            btnPassWordCreate.UseVisualStyleBackColor = true;
            btnPassWordCreate.Click += btnPassWordCreate_Click;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPassWordCreate);
            Controls.Add(btnLogout);
            Controls.Add(btnPassManage);
            Controls.Add(btnCreateVault);
            Name = "TrangChu";
            Text = "TrangChu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateVault;
        private Button btnPassManage;
        private Button btnLogout;
        private Button btnPassWordCreate;
    }
}