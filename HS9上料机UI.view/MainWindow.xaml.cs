using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro;
using HS9上料机UI.viewmodel;
using BingLibrary.hjb.Metro;

namespace HS9上料机UI.view
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SetBinding(ShowYieldAdminControlWindowProperty, "ShowYieldAdminControlWindow");
            if (System.Environment.CurrentDirectory != @"C:\Debug")
            {
                //System.Windows.MessageBox.Show("软件安装目录必须为C:\\Debug");
                //System.Windows.Application.Current.Shutdown();
            }
            else
            {
                
                System.Diagnostics.Process[] myProcesses = System.Diagnostics.Process.GetProcessesByName("HS9上料机UI");//获取指定的进程名   
                if (myProcesses.Length > 1) //如果可以获取到知道的进程名则说明已经启动
                {
                    System.Windows.MessageBox.Show("不允许重复打开软件");
                    System.Windows.Application.Current.Shutdown();
                }
            }

        }

        private async void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isCameraPageVisible = false;
            e.Cancel = true;
            GlobalVar.metro.ChangeAccent("Red");
            if (CameraPageGrid.Visibility == Visibility.Visible)
            {
                CameraPageGrid.Visibility = Visibility.Collapsed;
                isCameraPageVisible = true;
            }
            var r = await GlobalVar.metro.ShowConfirm("警告", "确定关闭吗？");
            if (r)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else
            {
                GlobalVar.metro.ChangeAccent("Blue");
                if (isCameraPageVisible)
                {
                    CameraPageGrid.Visibility = Visibility.Visible;
                }
                
            }
        }
        public static YieldAdminControlWindow YieldAdminControlWindow = null;

        public static readonly DependencyProperty ShowYieldAdminControlWindowProperty =
            DependencyProperty.Register("ShowYieldAdminControlWindow", typeof(bool), typeof(MainWindow), new PropertyMetadata(
                new PropertyChangedCallback((d, e) =>
                {
                    if (YieldAdminControlWindow != null)
                    {
                        if (YieldAdminControlWindow.HasShow)
                            return;
                    }
                    var mMainWindow = d as MainWindow;
                    YieldAdminControlWindow = new YieldAdminControlWindow();// { Owner = this }.Show();
                    YieldAdminControlWindow.Owner = Application.Current.MainWindow;
                    YieldAdminControlWindow.DataContext = mMainWindow.DataContext;
                    YieldAdminControlWindow.SetBinding(YieldAdminControlWindow.QuitYieldAdminControlProperty, "QuitYieldAdminControl");
                    YieldAdminControlWindow.HasShow = true;
                    YieldAdminControlWindow.Show();
                })));
        public bool ShowYieldAdminControlWindow
        {
            get { return (bool)GetValue(ShowYieldAdminControlWindowProperty); }
            set { SetValue(ShowYieldAdminControlWindowProperty, value); }
        }
    }
}
