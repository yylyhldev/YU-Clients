namespace Yu.Client.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : System.Windows.Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            //DataContext = App.Current.LoginVM;
            DataContext = new ViewModels.LoginVM();

            // 使用WindowChrome类设置标题栏背景
            var chrome = new System.Windows.Shell.WindowChrome
            {
                CaptionHeight = 32,
                CornerRadius = new System.Windows.CornerRadius(0),
                GlassFrameThickness = new System.Windows.Thickness(0),
                NonClientFrameEdges = System.Windows.Shell.NonClientFrameEdges.None,
                ResizeBorderThickness = new System.Windows.Thickness(8),
                UseAeroCaptionButtons = false
            };
            //System.Windows.Shell.WindowChrome.SetWindowChrome(this, chrome);
        }

        private void ResetPwd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //<WebBrowser Name="webBrowser" Source="http://www.baidu.com"/>
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.google.com",
                UseShellExecute = true
            });
        }
    }
}