using System.Diagnostics;
using System.Runtime.InteropServices;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        #region CheckCreatedNew
        static bool CheckCreatedNew()
        {
            var currentProcessName = Process.GetCurrentProcess().ProcessName;//获取当前进程
            //var currentProcessName = AppDomain.CurrentDomain.FriendlyName;
            var mutex = new Mutex(true, nameof(currentProcessName), out bool createdNew);
            if (!createdNew)
            {
                var process = Process.GetProcessesByName(currentProcessName).FirstOrDefault();
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

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd); 
        #endregion
    }
}