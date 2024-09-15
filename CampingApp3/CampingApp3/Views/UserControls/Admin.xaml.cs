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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : UserControl
    {
        private int _placeID;
        private int _newPrice;
        DBFunctions dbFunctions = new DBFunctions();

        public Admin()
        {
            InitializeComponent();
            SetPlaceholderText();
        }

        private void SetPlaceholderText()
        {
            txtbPID.Text = "Enter PID";
            txtbPrice.Text = "Enter Price";
            txtBlock.Text = "Enter Place ID";
        }

        public void Empty_UserID()
        {
            if (string.IsNullOrWhiteSpace(txtbPID.Text))
            {
                MessageBox.Show("Please enter a placeID before updating");
            }
        }

        private void clearPlaceholder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBox txtb = (TextBox)sender;

            if (txtb.Text == "Enter PID" || txtb.Text == "Enter Price" || txtb.Text == "Enter Place ID")
                txtb.Text = "";
        }

        private void resetPlaceholder_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtb = (TextBox)sender;

            // Reset to placeholder if text is empty
            if (string.IsNullOrWhiteSpace(txtb.Text))
            {
                if (txtb.Name == "txtbPID")
                {
                    txtb.Text = "Enter PID";
                }
                else if (txtb.Name == "txtbPrice")
                {
                    txtb.Text = "Enter Price";
                }
                else if (txtb.Name == "txtBlock")
                {
                    txtb.Text = "Enter Place ID";
                }
            }
        }

        private void btnUpdate_Price_Click(object sender, RoutedEventArgs e)
        {
            Empty_UserID();

            if (string.IsNullOrWhiteSpace(txtbPrice.Text) || txtbPrice.Text == "Enter Price")
            {
                MessageBox.Show("Please enter a price before updating.");
                return;
            }

            if (!int.TryParse(txtbPrice.Text, out int newPrice))
            {
                MessageBox.Show("Please enter a valid integer for the price.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtbPrice.Text))
            {
                _placeID = int.Parse(txtbPID.Text); // Changed to txtbPID.Text
                _newPrice = newPrice;
                dbFunctions.UpdatePrice(_newPrice, _placeID);
                MessageBox.Show("The price has been successfully updated.");
            }
        }

        private void btnBlock_Place(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBlock.Text) || txtBlock.Text == "Enter Place ID")
            {
                MessageBox.Show("Please enter a place to block");
                return;
            }

            if (!int.TryParse(txtBlock.Text, out int placeID))
            {
                MessageBox.Show("Please enter a valid integer for the placeID.");
                return;
            }

            if (StartDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please select a starting date from where you'd like to block the place");
                return;
            }

            if (EndDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please select an end date from where you'd like to end the blockage of the place");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtBlock.Text))
            {
                dbFunctions.InsertReservation(placeID, StartDatePicker.SelectedDate, EndDatePicker.SelectedDate, 1, -1, true);
                MessageBox.Show("The place has been successfully blocked");
            }
        }
    }
}
