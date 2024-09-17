using CampingApp3.ViewModels;
using CampingApp3.Views;
using System.Windows.Input;

namespace Homepage.ViewModels
{
    class RegisterVM : ViewModelBase
    {
        public ICommand NavigateToLoginCommand { get; }

        public RegisterVM()
        {
            NavigateToLoginCommand = new RelayCommand(NavigateToLogin);
        }

        private void NavigateToLogin(object obj)
        {
            var navigationVM = App.Current.MainWindow.DataContext as NavigationVM;
            navigationVM.CurrentView = new LoginVM();
        }
    }
}
