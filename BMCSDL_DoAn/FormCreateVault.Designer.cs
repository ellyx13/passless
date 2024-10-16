namespace BMCSDL_DoAn
{
    partial class FormCreateVault
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
            labelTitle = new Label();
            label1 = new Label();
            txtVaultName = new TextBox();
            btnCreateVault = new Button();
            pictureBoxIcon = new PictureBox();
            btnSelectImage = new Button();
<<<<<<< HEAD
            btnBack = new Button();
=======
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
<<<<<<< HEAD
            labelTitle.Location = new Point(170, 23);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(247, 45);
=======
            labelTitle.Location = new Point(140, 55);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(303, 54);
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Tạo kho lưu trữ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 163);
<<<<<<< HEAD
            label1.Location = new Point(104, 186);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
=======
            label1.Location = new Point(64, 249);
            label1.Name = "label1";
            label1.Size = new Size(54, 31);
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            label1.TabIndex = 1;
            label1.Text = "Tên:";
            // 
            // txtVaultName
            // 
<<<<<<< HEAD
            txtVaultName.Location = new Point(170, 191);
            txtVaultName.Margin = new Padding(3, 2, 3, 2);
            txtVaultName.Name = "txtVaultName";
            txtVaultName.Size = new Size(247, 23);
=======
            txtVaultName.Location = new Point(159, 253);
            txtVaultName.Name = "txtVaultName";
            txtVaultName.Size = new Size(217, 27);
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            txtVaultName.TabIndex = 2;
            // 
            // btnCreateVault
            // 
            btnCreateVault.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 163);
<<<<<<< HEAD
            btnCreateVault.Location = new Point(229, 257);
            btnCreateVault.Margin = new Padding(3, 2, 3, 2);
            btnCreateVault.Name = "btnCreateVault";
            btnCreateVault.Size = new Size(114, 32);
            btnCreateVault.TabIndex = 3;
            btnCreateVault.Text = "Create";
            btnCreateVault.UseVisualStyleBackColor = true;
            btnCreateVault.Click += btnCreate_Click;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(229, 89);
            pictureBoxIcon.Margin = new Padding(3, 2, 3, 2);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(114, 46);
=======
            btnCreateVault.Location = new Point(221, 346);
            btnCreateVault.Name = "btnCreateVault";
            btnCreateVault.Size = new Size(111, 42);
            btnCreateVault.TabIndex = 3;
            btnCreateVault.Text = "Create";
            btnCreateVault.UseVisualStyleBackColor = true;
            btnCreateVault.Click += btnCreateVault_Click;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(221, 138);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(125, 62);
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 4;
            pictureBoxIcon.TabStop = false;
            // 
            // btnSelectImage
            // 
<<<<<<< HEAD
            btnSelectImage.Location = new Point(244, 153);
            btnSelectImage.Margin = new Padding(3, 2, 3, 2);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(82, 22);
=======
            btnSelectImage.Location = new Point(238, 206);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(94, 29);
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            btnSelectImage.TabIndex = 5;
            btnSelectImage.Text = "Chọn Ảnh";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
<<<<<<< HEAD
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(12, 11);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(49, 32);
            btnBack.TabIndex = 6;
            btnBack.Text = "<-";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormCreateVault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 338);
            Controls.Add(btnBack);
=======
            // FormCreateVault
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            Controls.Add(btnSelectImage);
            Controls.Add(pictureBoxIcon);
            Controls.Add(btnCreateVault);
            Controls.Add(txtVaultName);
            Controls.Add(label1);
            Controls.Add(labelTitle);
<<<<<<< HEAD
            Margin = new Padding(3, 2, 3, 2);
=======
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
            Name = "FormCreateVault";
            Text = "FormCreateVault";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private TextBox txtVaultName;
        private Button btnCreateVault;
        private PictureBox pictureBoxIcon;
        private Button btnSelectImage;
<<<<<<< HEAD
        private Button btnBack;
=======
>>>>>>> bc242820f9cb2ea6c3111ec1d60235386c111c08
    }
}