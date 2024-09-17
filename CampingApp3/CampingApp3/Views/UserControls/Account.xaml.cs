﻿using CampingApp3.Models.Services;
using CampingApp3.ViewModels;
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
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : UserControl
    {
        private readonly ReservationService dbReservation;
        private readonly PlaceService dbPlace;
        private int userID = -1;
        private int reservationID = -1;

        public Account()
        {
            InitializeComponent();
            this.DataContext = new AccountVM();

            this.userID = Index.userID;

            if (userID != -1)
            {
                PopulateReservations();
            }
            else
            {
                MessageBox.Show("User ID not found.");
            }
        }

        private void PopulateReservations()
        {
            cmboxReservations.Items.Clear();

            List<int> listReservationsOnUserID = dbReservation.GetReservationsByUserID(userID);
            if (listReservationsOnUserID.Count > 0)
            {
                foreach (int intReservationID in listReservationsOnUserID) //pak er eentsje
                {
                    cmboxReservations.Items.Add(new ComboBoxItem { Content = dbReservation.GetReservationDescription(intReservationID), Tag = intReservationID });
                }
            }
            else
            {
                cmboxReservations.Text = "You have no reservations";
            }
        }

        private void cmboxReservations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedReservationItem = cmboxReservations.SelectedItem as ComboBoxItem;
            if (selectedReservationItem != null)
            {
                var _reservationID = selectedReservationItem.Tag as int?;
                if (_reservationID.HasValue)
                {
                    this.reservationID = _reservationID.Value;
                }
                else
                {
                    // Handle case where Tag is not an int
                    MessageBox.Show("Selected reservation does not have a valid reservation ID.");
                }
            }

            if (selectedReservationItem != null && reservationID != -1) //kan in principe weg 
            {
                int placeID = dbReservation.GetPlaceIDByReservationID(reservationID);
                string spotInformation = dbPlace.GetDescription(placeID);
                SpotInformationTextBlock.Text = spotInformation;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button.Name == "btnDelReservation") //toch wel ff check hé
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to cancel your reservation?", "Delete reservation", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    dbReservation.DeleteReservation(reservationID);
                    PopulateReservations(); // Refresh the reservations list
                }
            }
        }
    }
}
