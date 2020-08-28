using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Mutex m = new Mutex(true, "單實例", out bool isNewInstance);
            if (!isNewInstance)
            {
                MessageBox.Show("這是單實例程序，程序已啟動。");
                Shutdown();
            }
        }
    }

}
