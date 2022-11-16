using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AnimatedUI.ViewModels
{
    internal class MenuStripViewModel : ViewModelBase
    {
        public static MenuStripViewModel Instance { get; } = new MenuStripViewModel();

        private object _currentViewModel;

        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        private HomeViewModel HomeViewModel { get; set; }
        private AccountViewModel AccountViewModel { get; set; }
        private SettingsViewModel SettingsViewModel { get; set; }

        public MenuStripViewModel()
        {
            HomeViewModel = new HomeViewModel();
            AccountViewModel = new AccountViewModel();
            SettingsViewModel = new SettingsViewModel();
            CurrentViewModel = HomeViewModel;

            ShowHomeViewCommand = new DelegateCommand(x => 
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    Thread.Sleep(700);
                    Instance.CurrentViewModel = HomeViewModel;
                }));
                thread.Start();
            });
            ShowAccountViewCommand = new DelegateCommand(x =>
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    Thread.Sleep(700);
                    Instance.CurrentViewModel = AccountViewModel;
                }));
                thread.Start();
            });
            ShowSettingsViewCommand = new DelegateCommand(x =>
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    Thread.Sleep(700);
                    Instance.CurrentViewModel = SettingsViewModel;
                }));
                thread.Start();
            });
        }

        public DelegateCommand ShowHomeViewCommand { get; set; }
        public DelegateCommand ShowAccountViewCommand { get; set; }
        public DelegateCommand ShowSettingsViewCommand { get; set; }
    }
}
