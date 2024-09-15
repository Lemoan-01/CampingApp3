using CampingApp3.Views;
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
using System.Windows.Shapes;

namespace CampingApp3.Views
{
    /// <summary>
    /// Interaction logic for MakeReservationPage.xaml
    /// </summary>
    public partial class MakeReservationPage : WindowBase
    {
        private DateTime dateStart;
        private DateTime dateEnd;
        private int placeID;
        public static int userID { get; set; } = -1;

        public MakeReservationPage(int placeID, DateTime firstDates, DateTime lastDates)
        {

            InitializeComponent();
            this.placeID = placeID;
            this.dateStart = firstDates;
            this.dateEnd = lastDates;

            for (int i = 1; i <= 12; i++) //12 mensen max per plek i guess
            {
                aantPersonen.Items.Add(i);
            }

            Label labelPlace = new Label() //label plekvermelder
            {
                Content = "Place: " + placeID,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(115, 89, 0, 0),
                VerticalAlignment = VerticalAlignment.Top,
                Foreground = Brushes.White,
                Height = 52,
                Width = 320,
                FontSize = 30,
                FontFamily = new FontFamily("Yu Gothic UI Semibold")
            };

            Label labelDates = new Label() //label datums
            {
                Content = "You'll stay from: " + firstDates.ToString("dd-MM-yyyy") + "\nto " + lastDates.ToString("dd-MM-yyyy"),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(12, 176, 0, 0),
                VerticalAlignment = VerticalAlignment.Top,
                Foreground = Brushes.White,
                Height = 100,
                Width = 400,
                FontSize = 22,
                FontFamily = new FontFamily("Yu Gothic UI Semibold")
            };
            MainWindowGrid.Children.Add(labelDates);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "Cancel")
            {
                this.Close();
            }
            else if (button.Name == "Pay")
            {
                if (userID != -1)
                {
                    if (aantPersonen.SelectedItem != null)
                    {

                        System.Diagnostics.Process.Start("https://www.paypal.com/us/home");

                        DatabaseConnector.DBFunctions dbFunc = new DatabaseConnector.DBFunctions();

                        int aantalPersonen = (int)aantPersonen.SelectedItem;

                        dbFunc.InsertReservation(placeID, dateStart, dateEnd, aantalPersonen, userID);
                    }
                }
                else
                {
                    CloseWindowWithMessageBox();
                }
            }
        }

        private void CloseWindowWithMessageBox()
        {
            // Show the message box with an OK button
            MessageBoxResult result = MessageBox.Show("You are not logged in", "Confirmation", MessageBoxButton.OK);

            // Check if the OK button was clicked
            if (result == MessageBoxResult.OK)
            {
                // Close the window
                this.Close();
            }
        }
    }
}
