<<<<<<< Updated upstream
﻿using Homepage.ViewModels;
=======
﻿using CampingApp3.Models.Services;
using CampingApp3.ViewModels;
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : UserControl
    {
        // Local Variables
        DatabaseConnector.DBFunctions dbFunc = new DatabaseConnector.DBFunctions();

        public Register()
        {
            InitializeComponent();
        }

        private void clearPlaceholder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBox txtb = (TextBox)sender;

            if (txtb.Text == "Enter your email" || txtb.Text == "Enter your phone number" || txtb.Text == "Enter your address")
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
            else if (txtb.Name == "txtbPhoneNumber")
            {
                placeholder = "Enter your phone number";
            }
            else if (txtb.Name == "txtbAddress")
            {
                placeholder = "Enter your address";
            }

            // Reset to placeholder if text is empty
            if (string.IsNullOrWhiteSpace(txtb.Text))
            {
                txtb.Text = placeholder;
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string email = txtbEmail.Text.Trim();
            string phoneNumber = txtbPhoneNumber.Text;
            string password = pwboxPassword.Password;
            string passwordconfirm = pwboxConfirmPassword.Password;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordconfirm))
            {
                MessageBox.Show("Please fill in all the fields.", "Incomplete Information", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number.", "Invalid Phone Number", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (password == passwordconfirm)
            {
                string query = "INSERT INTO user (email, phoneNumber, password) VALUES (@email, @phoneNumber, SHA2(@password, 256))";
                try
                {
                    dbFunc.InsertData(query,
                         new MySqlConnector.MySqlParameter("@email", email),
                         new MySqlConnector.MySqlParameter("@phoneNumber", phoneNumber),
                         new MySqlConnector.MySqlParameter("@password", password));

                    var navigationVM = App.Current.MainWindow.DataContext as NavigationVM;
                    navigationVM.CurrentView = new LoginVM();

                    MessageBox.Show("Successfully registered!", "Registered", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while registering: " + ex.Message, "Registration Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Password confirmation failed. Please make sure your passwords match.", "Password Mismatch", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }

        private void txtbEmail_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (txtbEmail.Text == "Enter your email")
                txtbEmail.Text = "";
        }

        private void txtbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbEmail.Text))
                txtbEmail.Text = "Enter your email";
        }

        private void txtbPhoneNumber_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (txtbPhoneNumber.Text == "Enter your phone number")
                txtbPhoneNumber.Text = "";
        }

        private void txtbPhoneNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbPhoneNumber.Text))
                txtbPhoneNumber.Text = "Enter your phone number";
        }
    }
}
