using DbSqlite;
using Yu.Client.WF.Models;

namespace Yu.Client.WF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private async void Login_Load(object sender, EventArgs e)
        {
            LoginTip.Text = string.Empty;
            if (!FreeSqlHelper.FSql.DbFirst.ExistsTable(nameof(LoginSign)))
            {
                FreeSqlHelper.FSql.Insert(new LoginSign { LoginAccount = "yuyongli", LoginPwd = "a123", KeepPwd = true, AutoLogin = false }).ExecuteAffrows();
            }
            var sign = await FreeSqlHelper.FSql.Select<LoginSign>().OrderByDescending(d => d.LoginTime).FirstAsync();
            if (!string.IsNullOrWhiteSpace(sign?.LoginAccount))
            {
                TxtSign.Text = sign.LoginAccount;
                TxtPwd.Text = sign.LoginPwd;
                CkbSavePwd.Checked = sign.KeepPwd;
                CkbAutoLogin.Checked = sign.AutoLogin;
                if (sign.AutoLogin)
                {
                    BtnLogin_Click(sender, e);
                }
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private static readonly SemaphoreSlim BtnLock = new(1, 1);
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            BtnLock.Wait();
            if (!BtnLogin.Enabled) return;
            BtnLogin.Enabled = false;
            LoginTip.Text = "登录中......";

            if (!await FreeSqlHelper.FSql.Select<LoginSign>().AnyAsync(d => d.LoginAccount == TxtSign.Text && d.LoginPwd == TxtPwd.Text))
            {
                ResetLogin();
                MessageBox.Show("账号密码不正确");
                return;
            }
            LoginTip.Text = "登录成功，正在跳转......";
            await FreeSqlHelper.FSql.Update<LoginSign>()
                .Set(d => d.KeepPwd, CkbSavePwd.Checked)
                .Set(d => d.AutoLogin, CkbAutoLogin.Checked)
                .Set(d => d.LoginTime, DateTime.Now)
                .Where(d => d.LoginAccount == TxtSign.Text)
                .ExecuteAffrowsAsync();
            await Task.Delay(1000);
            ResetLogin();

            this.Hide();
            new TabForm().Show();

            //Invoke(new MethodInvoker(delegate () { new TabForm().Show(); }));
            //this.Hide();
        }
        private void ResetLogin()
        {
            Invoke(new MethodInvoker(delegate ()
            {
                LoginTip.Text = string.Empty;
                BtnLogin.Enabled = true;
                BtnLock.Release();
            }));
        }

        private void LinkFogetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.baidu.com",
                UseShellExecute = true
            });
        }
    }
}
