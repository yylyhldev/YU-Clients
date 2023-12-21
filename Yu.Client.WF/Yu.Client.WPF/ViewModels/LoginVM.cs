using System.Windows.Input;
using System.Windows;
using Yu.Client.WPF.Helpers;
using Yu.Client.WPF.Models;
using DbSqlite;

namespace Yu.Client.WPF.ViewModels
{
    public class LoginVM : ViewModelBase
    {
        public LoginVM()
        {
            if (!FreeSqlHelper.FSql.DbFirst.ExistsTable(nameof(LoginSign)))
            {
                FreeSqlHelper.FSql.Insert(new LoginSign { LoginAccount = "yuyongli", LoginPwd = "a123", KeepPwd = true, AutoLogin = false }).ExecuteAffrows();
            }
            var lastLogin = FreeSqlHelper.FSql.Select<LoginSign>().OrderByDescending(d => d.LoginTime).First();
            if (lastLogin != null)
            {
                LoginAccount = lastLogin.LoginAccount;
                LoginPwd = lastLogin.LoginPwd;
                KeepPwd = lastLogin.KeepPwd;
                AutoLogin = lastLogin.AutoLogin;
                if (AutoLogin)
                {
                    Application.Current.Dispatcher.Invoke(async () =>
                    {
                        await Task.Delay(1000);
                        Login(default);
                    });
                }
            }
        }

        #region Command
        public ICommand ResetPwdCommand { get { return new RelayCommand(ResetPwd); } }
        private void ResetPwd(object obj)
        {
            MessageBox.Show("开发中。。。");
        }

        /// <summary>
        /// 按钮命令  CommandParameter="{Binding RelativeSource={RelativeSource Mode=Self},Path=Content}"
        /// </summary>
        public ICommand LoginCommand { get { return new RelayCommand(Login); } }
        private async void Login(object arg)
        {
            LoginIsEnabled = false;
            LoginTip = "登录中......";
            if (!await FreeSqlHelper.FSql.Select<LoginSign>().AnyAsync(d => d.LoginAccount == LoginAccount))
            {
                LoginIsEnabled = true;
                LoginTip = string.Empty;
                Application.Current.Dispatcher.Invoke(() => MessageBox.Show("账号密码不正确"));
                return;
            }
            LoginTip = "登录成功，正在跳转......";
            await FreeSqlHelper.FSql.Update<LoginSign>()
                .Set(d => d.KeepPwd, KeepPwd)
                .Set(d => d.AutoLogin, AutoLogin)
                .Set(d => d.LoginTime, DateTime.Now)
                .Where(d => d.LoginAccount == LoginAccount)
                .ExecuteAffrowsAsync();
            await Application.Current.Dispatcher.Invoke(async () =>
            {
                await Task.Delay(500);
                var window = Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive);
                new Views.MainWindow().Show();
                window?.Close();
            });
        }

        #endregion

        #region Model
        private bool _loginIsEnabled = true;
        public bool LoginIsEnabled
        {
            get => _loginIsEnabled;
            set
            {
                _loginIsEnabled = value;
                OnPropertyChanged(nameof(LoginIsEnabled));
            }
        }
        public string _loginTip = string.Empty;
        public string LoginTip
        {
            get { return _loginTip; }
            set
            {
                _loginTip = value;
                OnPropertyChanged(nameof(LoginTip));
            }
        }
        public string LoginAccount { get; set; }
        public string LoginPwd { get; set; }
        public bool KeepPwd { get; set; } = true;
        public bool AutoLogin { get; set; } = true;

        #endregion
    }
}
