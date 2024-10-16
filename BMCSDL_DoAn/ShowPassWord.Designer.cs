namespace BMCSDL_DoAn
{
    partial class ShowPassWord
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
            listBoxUsers = new ListBox();
            btnLoadData = new Button();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(189, 26);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(408, 304);
            listBoxUsers.TabIndex = 0;
            listBoxUsers.SelectedIndexChanged += btnLoadData_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(346, 365);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(84, 29);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // ShowPassWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadData);
            Controls.Add(listBoxUsers);
            Name = "ShowPassWord";
            Text = "x";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUsers;
        private Button btnLoadData;
    }
}