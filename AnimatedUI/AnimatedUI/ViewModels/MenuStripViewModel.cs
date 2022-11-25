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
        private StatisticViewModel StatisticViewModel { get; set; }
        private InfoViewModel InfoViewModel { get; set; }
        private MailViewModel MailViewModel { get; set; }
        private OffersViewModel OffersViewModel { get; set; }


        public MenuStripViewModel()
        {
            HomeViewModel = new HomeViewModel();
            AccountViewModel = new AccountViewModel();
            SettingsViewModel = new SettingsViewModel();
            StatisticViewModel = new StatisticViewModel();
            InfoViewModel = new InfoViewModel();
            MailViewModel = new MailViewModel();
            OffersViewModel = new OffersViewModel();
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
            ShowOffersViewCommand = new DelegateCommand(x =>
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    Thread.Sleep(700);
                    Instance.CurrentViewModel = OffersViewModel;
                }));
                thread.Start();
            });
            ShowStatisticViewCommand = new DelegateCommand(x =>
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    Thread.Sleep(700);
                    Instance.CurrentViewModel = StatisticViewModel;
                }));
                thread.Start();
            });
            ShowMailViewCommand = new DelegateCommand(x =>
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    Thread.Sleep(700);
                    Instance.CurrentViewModel = MailViewModel;
                }));
                thread.Start();
            });
            ShowInfoViewCommand = new DelegateCommand(x =>
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    Thread.Sleep(700);
                    Instance.CurrentViewModel = InfoViewModel;
                }));
                thread.Start();
            });
        }

        public DelegateCommand ShowHomeViewCommand { get; set; }
        public DelegateCommand ShowAccountViewCommand { get; set; }
        public DelegateCommand ShowSettingsViewCommand { get; set; }
        public DelegateCommand ShowStatisticViewCommand { get; set; }
        public DelegateCommand ShowInfoViewCommand { get; set; }
        public DelegateCommand ShowMailViewCommand { get; set; }
        public DelegateCommand ShowOffersViewCommand { get; set; }

    }
}
