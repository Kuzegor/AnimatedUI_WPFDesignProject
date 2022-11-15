using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace AnimatedUI.ViewModels
{
    internal class MainMenuViewModel : ViewModelBase
    {
        public DelegateCommand ShutdownCommand { get; set; }
        public DelegateCommand MinimizeCommand { get; set; }
        public DelegateCommand MaximizeCommand { get; set; }

        public MainMenuViewModel()
        {
            ShutdownCommand = new DelegateCommand(x => Application.Current.Shutdown());
            MaximizeCommand = new DelegateCommand(x =>
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                {
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                    Application.Current.MainWindow.BorderThickness = new Thickness(0);
                }
                else
                {
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                    Application.Current.MainWindow.BorderThickness = new Thickness(0);
                }
            });
            MinimizeCommand = new DelegateCommand(x => Application.Current.MainWindow.WindowState = WindowState.Minimized);
        }
    }
}
