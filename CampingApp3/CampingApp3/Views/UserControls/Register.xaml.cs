using CampingApp3.Models.Services;
using Homepage.ViewModels;
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
        private readonly UserService dbUser;

        public Register()
        {
            InitializeComponent();
            this.DataContext = new RegisterVM();
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
            string phoneNumberStr = txtbPhoneNumber.Text; // Get phone number as string
            string password = pwboxPassword.Password;
            string passwordconfirm = pwboxConfirmPassword.Password;

            // Validate that all fields are filled
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumberStr) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordconfirm))
            {
                MessageBox.Show("Please fill in all the fields.", "Incomplete Information", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Validate phone number format
            if (!IsValidPhoneNumber(phoneNumberStr))
            {
                MessageBox.Show("Please enter a valid phone number.", "Invalid Phone Number", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Convert phone number to integer
            if (!int.TryParse(phoneNumberStr, out int phoneNumber))
            {
                MessageBox.Show("Phone number conversion failed. Please enter a valid phone number.", "Conversion Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Check password confirmation
            if (password == passwordconfirm)
            {
                if (dbUser.Register(email, phoneNumber, password))
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
