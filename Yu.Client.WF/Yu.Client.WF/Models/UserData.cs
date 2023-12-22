namespace Yu.Client.WF.Models
{
    internal class LoginSign
    {
        public string LoginAccount { get; set; }
        public string LoginPwd { get; set; }
        public bool KeepPwd { get; set; } = true;
        public bool AutoLogin { get; set; } = true;
        public DateTime LoginTime { get; set; } = DateTime.Now;
        public LoginSign() { }
    }
}
