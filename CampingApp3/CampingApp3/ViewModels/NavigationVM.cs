using CampingApp3.Views.UserControls;
using CampingApp3.ViewModels;
using System.Windows.Input;

namespace Homepage.ViewModels
{
    public class NavigationVM : ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand ReservationCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand AccountCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand AdminCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Map(object obj) => CurrentView = new MapVM();
        private void Login(object obj) => CurrentView = new LoginVM();
        private void Account(object obj) => CurrentView = new AccountVM();
        private void Register(object obj) => CurrentView = new RegisterVM();
        private void Admin(object obj) => CurrentView = new AdminVM();

        public NavigationVM()
        {
            // Add the RelayCommands when adding a new Page
            HomeCommand = new RelayCommand(Home);
            ReservationCommand = new RelayCommand(Map);
            LoginCommand = new RelayCommand(Login);
            AccountCommand = new RelayCommand(Account);
            RegisterCommand = new RelayCommand(Register);
            AdminCommand = new RelayCommand(Admin);

            // This sets the Homepage as default on startup
            CurrentView = new HomeVM();
        }
    }
}
