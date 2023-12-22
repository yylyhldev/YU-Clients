namespace Yu.Client.WF
{
    partial class Login
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
            label1 = new Label();
            TxtSign = new TextBox();
            label2 = new Label();
            TxtPwd = new TextBox();
            BtnLogin = new Button();
            CkbSavePwd = new CheckBox();
            CkbAutoLogin = new CheckBox();
            LinkFogetPwd = new LinkLabel();
            LoginTip = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 65);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "账号：";
            // 
            // TxtSign
            // 
            TxtSign.Location = new Point(99, 62);
            TxtSign.Name = "TxtSign";
            TxtSign.PlaceholderText = "请输入账号";
            TxtSign.Size = new Size(189, 23);
            TxtSign.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 118);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 0;
            label2.Text = "密码：";
            // 
            // TxtPwd
            // 
            TxtPwd.Location = new Point(99, 115);
            TxtPwd.Name = "TxtPwd";
            TxtPwd.PlaceholderText = "请输入密码";
            TxtPwd.Size = new Size(189, 23);
            TxtPwd.TabIndex = 1;
            TxtPwd.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(99, 176);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(88, 43);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "登 录";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // CkbSavePwd
            // 
            CkbSavePwd.AutoSize = true;
            CkbSavePwd.Location = new Point(99, 149);
            CkbSavePwd.Name = "CkbSavePwd";
            CkbSavePwd.Size = new Size(75, 21);
            CkbSavePwd.TabIndex = 3;
            CkbSavePwd.Text = "记住密码";
            CkbSavePwd.UseVisualStyleBackColor = true;
            // 
            // CkbAutoLogin
            // 
            CkbAutoLogin.AutoSize = true;
            CkbAutoLogin.Location = new Point(190, 149);
            CkbAutoLogin.Name = "CkbAutoLogin";
            CkbAutoLogin.Size = new Size(75, 21);
            CkbAutoLogin.TabIndex = 3;
            CkbAutoLogin.Text = "自动登录";
            CkbAutoLogin.UseVisualStyleBackColor = true;
            // 
            // LinkFogetPwd
            // 
            LinkFogetPwd.AutoSize = true;
            LinkFogetPwd.Location = new Point(211, 189);
            LinkFogetPwd.Name = "LinkFogetPwd";
            LinkFogetPwd.Size = new Size(56, 17);
            LinkFogetPwd.TabIndex = 4;
            LinkFogetPwd.TabStop = true;
            LinkFogetPwd.Text = "忘记密码";
            LinkFogetPwd.LinkClicked += LinkFogetPwd_LinkClicked;
            // 
            // LoginTip
            // 
            LoginTip.AutoSize = true;
            LoginTip.Location = new Point(99, 222);
            LoginTip.Name = "LoginTip";
            LoginTip.Size = new Size(17, 17);
            LoginTip.TabIndex = 5;
            LoginTip.Text = "...";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 240);
            Controls.Add(LoginTip);
            Controls.Add(LinkFogetPwd);
            Controls.Add(CkbAutoLogin);
            Controls.Add(CkbSavePwd);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPwd);
            Controls.Add(label2);
            Controls.Add(TxtSign);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Login";
            Text = "登录";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtSign;
        private Label label2;
        private TextBox TxtPwd;
        private Button BtnLogin;
        private CheckBox CkbSavePwd;
        private CheckBox CkbAutoLogin;
        private LinkLabel LinkFogetPwd;
        private Label LoginTip;
    }
}