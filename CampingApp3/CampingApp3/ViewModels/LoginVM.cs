﻿using CampingApp3.Views.UserControls;
using CampingApp3.ViewModels;
using System.Windows.Input;

namespace CampingApp3.ViewModels
{
    class LoginVM : ViewModelBase
    {
        public ICommand NavigateToRegisterCommand { get; }

        public LoginVM()
        {
            NavigateToRegisterCommand = new RelayCommand(NavigateToRegister);
        }

        private void NavigateToRegister(object obj)
        {
            var navigationVM = App.Current.MainWindow.DataContext as NavigationVM;
            navigationVM.CurrentView = new RegisterVM();
        }
    }
}
