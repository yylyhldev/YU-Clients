namespace Yu.Client.WF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!CheckCreatedNew()) return;
            BindExceptionHanlder();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        #region CheckCreatedNew
        static bool CheckCreatedNew()
        {
            var currentProcessName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;//��ȡ��ǰ����
            //var currentProcessName = AppDomain.CurrentDomain.FriendlyName;
            var mutex = new Mutex(true, nameof(currentProcessName), out bool createdNew);
            if (!createdNew)
            {
                var process = System.Diagnostics.Process.GetProcessesByName(currentProcessName).FirstOrDefault();
                //��ȡ�Ѿ������Ľ��̵���������
                IntPtr mainFormHandle = process.MainWindowHandle;
                if (mainFormHandle != IntPtr.Zero)
                {
                    ShowWindowAsync(mainFormHandle, 1);         //��ʾ�Ѿ������Ľ��̴���
                    SetForegroundWindow(mainFormHandle);   //���Ѿ������Ľ��̴����ƶ���ǰ��
                }
                mutex.WaitOne();
                mutex.ReleaseMutex();
                Environment.Exit(0);
            }
            return createdNew;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [System.Runtime.InteropServices.DllImport("User32")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        #endregion

        private static void BindExceptionHanlder()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ApplicationThreadException);//ui�߳��쳣
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomainUnhandledException);//δ�����쳣
        }
        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"{e.Exception.Message}", $"ϵͳ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private static void CurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"{(e.ExceptionObject as Exception).Message}", $"ϵͳ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}