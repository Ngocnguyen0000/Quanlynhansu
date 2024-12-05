namespace Quanlynhansu
{
    partial class fLogin
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
            panel1 = new Panel();
            buttonExit = new Button();
            buttonLogin = new Button();
            panel3 = new Panel();
            textPass = new TextBox();
            passWord = new Label();
            panel2 = new Panel();
            textUsername = new TextBox();
            userName = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 193);
            panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(248, 150);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(154, 150);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Đăng nhập";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textPass);
            panel3.Controls.Add(passWord);
            panel3.Location = new Point(3, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(457, 60);
            panel3.TabIndex = 2;
            // 
            // textPass
            // 
            textPass.Location = new Point(151, 17);
            textPass.Name = "textPass";
            textPass.Size = new Size(284, 23);
            textPass.TabIndex = 2;
            textPass.UseSystemPasswordChar = true;
            // 
            // passWord
            // 
            passWord.AutoSize = true;
            passWord.FlatStyle = FlatStyle.System;
            passWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passWord.Location = new Point(18, 19);
            passWord.Name = "passWord";
            passWord.Size = new Size(86, 21);
            passWord.TabIndex = 0;
            passWord.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(textUsername);
            panel2.Controls.Add(userName);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 60);
            panel2.TabIndex = 0;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(151, 17);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(284, 23);
            textUsername.TabIndex = 1;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.FlatStyle = FlatStyle.System;
            userName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName.Location = new Point(18, 19);
            userName.Name = "userName";
            userName.Size = new Size(127, 21);
            userName.TabIndex = 0;
            userName.Text = "Tên đăng nhập:";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 217);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox textPass;
        private Label passWord;
        private Panel panel2;
        private TextBox textUsername;
        private Label userName;
        private Button buttonExit;
        private Button buttonLogin;
    }
}
