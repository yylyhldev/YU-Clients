using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Yu.Client.WPF
{
    #region View和ViewModel的关联方式
    //方式一：在View中设置DataContext为ViewModel对象
    //xmlns:local="clr-namespace:namespace.ViewModel"
    //<Window.Resources/DataContext><local:ViewPageVM x:Key="vmodel"/></Window.Resources/DataContext>

    //方式二：在ViewPage.xaml.cs构造函数中实例化ViewModel赋值DataContext
    //public ViewPage(){ InitializeComponent(); DataContext = new ViewModel.ViewPageVM(); }

    //方式三：依赖注入，注册ViewModel服务，在ViewPage.xaml.cs构造函数中实例化ViewModel赋值DataContext
    //new ServiceCollection().AddSingleton<ViewModel.ViewPageVM>();
    //public ViewPage(){ InitializeComponent(); DataContext = App.Current.IpcVM; } 
    //或public ViewPage(ViewPageVM viewModel){ InitializeComponent(); BindingContext = viewModel; }
    #endregion
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        private readonly IServiceProvider serviceProvider;
        public App()
        {
            if (!CheckCreatedNew()) return;
            //MessageBox.Show(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            //_ = new System.Threading.Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out bool FirstOpen);
            //if (!FirstOpen)
            //{
            //    Environment.Exit(0);
            //    //Application.Current.Shutdown();
            //    return;
            //}
            //SqliteDbPwd.Set("123");
            var services = new ServiceCollection();//创建容器
            //services.AddSingleton(Yu.Wpf.SqliteHelper.Instance.SqliteConnection());
            serviceProvider = services.BuildServiceProvider();//创建服务定位器
        }

        private static readonly bool isLogin = false;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (!isLogin)
            {
                new LoginWindow().Show();
            }
            else
            {
                new Views.MainWindow().Show();
            }
            //(new Window { Content = new Views.ChatGptPage() }).Show();
        }

        #region CheckCreatedNew
        static bool CheckCreatedNew()
        {
            //var currentProcessName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;//获取当前进程
            var currentProcessName = AppDomain.CurrentDomain.FriendlyName;
            var mutex = new Mutex(true, nameof(currentProcessName), out bool createdNew);
            if (!createdNew)
            {
                var process = System.Diagnostics.Process.GetProcessesByName(currentProcessName).FirstOrDefault();
                //获取已经开启的进程的主窗体句柄
                IntPtr mainFormHandle = process.MainWindowHandle;
                if (mainFormHandle != IntPtr.Zero)
                {
                    ShowWindowAsync(mainFormHandle, 1);         //显示已经开启的进程窗口
                    SetForegroundWindow(mainFormHandle);   //将已经开启的进程窗口移动到前端
                }
                mutex.WaitOne();
                mutex.ReleaseMutex();
                Environment.Exit(0);
            }
            return createdNew;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        #endregion
    }

}
