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
    }
}
