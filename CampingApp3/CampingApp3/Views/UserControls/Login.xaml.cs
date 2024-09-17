using CampingApp3.Models.Services;
using Homepage.ViewModels;
using MySqlConnector;
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

namespace CampingApp3.Views.UserControls
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private readonly UserService dbUser;

        public Login()
        {
            InitializeComponent();
            this.DataContext = new LoginVM();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtbEmail.Text;
            string password = pwboxPassword.Password;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the fields.", "Incomplete Information", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else //all fields filled
            {
                int userId = dbUser.LoginVerification(email, password); //login

                if (userId != -1)// Login successful
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    restartHomepage(userId, dbUser.IsAdmin(userId));
                    MakeReservationPage.userID = userId;
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private static void restartHomepage(int _userID, bool _IsAdmin)
        {
            Index mw = new Index(_userID, _IsAdmin);
            mw.Show();

            //CLOSE v EN REOPEN ^
            var mainWindow = Application.Current.MainWindow as Index;

            // Ensure mainWindow is not null and call the closeHomePage method
            if (mainWindow != null)
            {
                mainWindow.CloseHomepage();
            }
        }

        private void txtbEmail_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (txtbEmail.Text == "Enter your email")
                txtbEmail.Text = "";
        }

        private void clearPlaceholder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBox txtb = (TextBox)sender;

            if (txtb.Text == "Enter your email")
                txtb.Text = "";
        }

        private void resetPlaceholder_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtb = (TextBox)sender;

            // Define placeholders for each TextBox
            string placeholder = "";
            if (txtb.Name == "txtbEmail")
            {
                placeholder = "Enter your email";
            }

            // Reset to placeholder if text is empty
            if (string.IsNullOrWhiteSpace(txtb.Text))
            {
                txtb.Text = placeholder;
            }
        }

        private void txtbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtbEmail.Text == "")
                txtbEmail.Text = "Enter your email";
        }
    }
}