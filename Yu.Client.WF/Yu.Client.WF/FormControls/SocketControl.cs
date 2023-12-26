namespace Yu.Client.WF
{
    public partial class SocketControl : UserControl
    {
        public SocketControl()
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            Yu.Client.WF.Helpers.ResizeHelper.SetTag(true, this);
        }

        #region 控件大小随窗体大小等比例缩放
        private void SocketControl_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            Yu.Client.WF.Helpers.ResizeHelper.SetControls(false, newx, newy, this);//, specialControlNames: new string[] { nameof(panel1) });
        }
        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度
        #endregion
    }
}
