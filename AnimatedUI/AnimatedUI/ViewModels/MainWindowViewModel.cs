using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AnimatedUI.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public MenuStripViewModel MenuStrip { get; } = MenuStripViewModel.Instance;

        public DelegateCommand DragMoveCommand { get; set; }

        public MainWindowViewModel()
        {
            DragMoveCommand = new DelegateCommand(x => Application.Current.MainWindow.DragMove());
        }
    }
}
