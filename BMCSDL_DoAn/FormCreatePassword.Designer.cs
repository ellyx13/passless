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
            txtName = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            txtPassword = new TextBox();
            btnSavePassword = new Button();
            label1 = new Label();
            txtURL = new TextBox();
            txtVaultID = new TextBox();
            txtUsername = new TextBox();
            txtNote = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbType = new ComboBox();
            txtAccountNumber = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(210, 122);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 23);
            txtName.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 13.2000008F);
            labelUsername.Location = new Point(116, 76);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(78, 25);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Vault ID:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 13.2000008F);
            labelPassword.Location = new Point(91, 270);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(90, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(210, 270);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSavePassword
            // 
            btnSavePassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSavePassword.Location = new Point(210, 491);
            btnSavePassword.Margin = new Padding(3, 2, 3, 2);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(182, 32);
            btnSavePassword.TabIndex = 6;
            btnSavePassword.Text = "Lưu Mật Khẩu";
            btnSavePassword.UseVisualStyleBackColor = true;
            btnSavePassword.Click += btnTaoMK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 45);
            label1.TabIndex = 7;
            label1.Text = "Tạo mật khẩu";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(210, 330);
            txtURL.Margin = new Padding(3, 2, 3, 2);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(221, 23);
            txtURL.TabIndex = 8;
            // 
            // txtVaultID
            // 
            txtVaultID.Location = new Point(210, 76);
            txtVaultID.Margin = new Padding(3, 2, 3, 2);
            txtVaultID.Name = "txtVaultID";
            txtVaultID.Size = new Size(221, 23);
            txtVaultID.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(210, 215);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 23);
            txtUsername.TabIndex = 10;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(210, 380);
            txtNote.Margin = new Padding(3, 2, 3, 2);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(221, 23);
            txtNote.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.2000008F);
            label2.Location = new Point(134, 328);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 12;
            label2.Text = "URL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.2000008F);
            label3.Location = new Point(86, 210);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 13;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.2000008F);
            label4.Location = new Point(128, 122);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 14;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.2000008F);
            label5.Location = new Point(126, 378);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 15;
            label5.Text = "Note:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.2000008F);
            label6.Location = new Point(128, 164);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 16;
            label6.Text = "Type:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "login", "secure_note", "document", "bank" });
            cbType.Location = new Point(210, 169);
            cbType.Name = "cbType";
            cbType.Size = new Size(221, 23);
            cbType.TabIndex = 17;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(210, 427);
            txtAccountNumber.Margin = new Padding(3, 2, 3, 2);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(221, 23);
            txtAccountNumber.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.2000008F);
            label7.Location = new Point(49, 427);
            label7.Name = "label7";
            label7.Size = new Size(132, 25);
            label7.TabIndex = 19;
            label7.Text = "AccoutNumber";
            // 
            // FormCreatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 563);
            Controls.Add(label7);
            Controls.Add(txtAccountNumber);
            Controls.Add(cbType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNote);
            Controls.Add(txtUsername);
            Controls.Add(txtVaultID);
            Controls.Add(txtURL);
            Controls.Add(label1);
            Controls.Add(btnSavePassword);
            Controls.Add(txtPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(txtName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCreatePassword";
            Text = "FormCreatePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox txtPassword;
        private Button btnSavePassword;
        private Label label1;
        private TextBox txtURL;
        private TextBox txtVaultID;
        private TextBox txtUsername;
        private TextBox txtNote;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbType;
        private TextBox txtAccountNumber;
        private Label label7;
    }
}