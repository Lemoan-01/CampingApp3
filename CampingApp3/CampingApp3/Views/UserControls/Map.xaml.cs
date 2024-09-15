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
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : UserControl
    {
        private int placeID = 0;
        private Windows.SpotDescriptionPop sdp;
        private bool reservationFilterOpen = false;
        private Windows.ReservationFilter reservationFilter;
        private static Map _instance;
        public event EventHandler LoadingCompleted;

        public Map()
        {
            InitializeComponent();
            LoadDataAsync();

            _instance = this;
        }

        public static Map Instance
        {
            get { return _instance; }
        }

        public Grid GetMapGrid()
        {
            return MapGrid;
        }

        public async void LoadDataAsync()
        {
            // Show the loading screen when loading starts
            imgEmptyView.Visibility = Visibility.Visible;
            loadingScreen.Visibility = Visibility.Visible;

            try
            {
                DatabaseConnector.DBFunctions dbFunc = new DatabaseConnector.DBFunctions();

                var buttons = MapGrid.Children.OfType<Button>();
                int bID = 0;

                foreach (var button in buttons)
                {
                    if (int.TryParse(button.Content.ToString(), out bID))
                    {
                        // Asynchronously wait for the result of isBlockedOnID
                        bool isBlocked = await Task.Run(() => dbFunc.isBlockedOnID(bID));

                        if (isBlocked)
                        {
                            // UI updates need to be performed on the UI thread
                            Dispatcher.Invoke(() =>
                            {
                                button.IsHitTestVisible = false;
                                button.Background = Brushes.Red;
                            });
                        }
                    }
                }
            }
            finally
            {
                // Hide the loading screen when loading is complete (even if there's an exception)
                loadingScreen.Visibility = Visibility.Collapsed;
                imgEmptyView.Visibility = Visibility.Collapsed;
            }
        }


        private void spotBtn(object sender, RoutedEventArgs e)
        {
            try
            {
                var senderBtn = sender as Button;
                placeID = Convert.ToInt32(senderBtn.Content.ToString());

                // Get the position of the mouse relative to the current button
                Point relativePosition = Mouse.GetPosition(senderBtn);

                // Convert the relative position to the position relative to the entire window
                Point absolutePosition = senderBtn.PointToScreen(relativePosition);

                if (sdp == null || !sdp.IsVisible)
                {
                    descriptionPop(placeID, absolutePosition); // not window detected so make new
                }
                else
                {
                    sdp.Close();
                    sdp = null; //close old window

                    descriptionPop(placeID, absolutePosition); // after start new
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error during conversion: " + ex.Message);
            }
        }

        private void descriptionPop(int placeID, Point clickPosition)
        {
            sdp = new DescriptionPop(placeID); // Instantiate the popup window

            // Set the left and top position relative to the entire screen
            sdp.Left = clickPosition.X;
            sdp.Top = clickPosition.Y;

            // Adjust the position to align the top-left corner with the spot where you click
            sdp.Left -= sdp.ActualWidth / 2;
            sdp.Top -= sdp.ActualHeight;

            sdp.Show();
        }

        // Map Filter Window
        private void btnInformation_Click(object sender, RoutedEventArgs e)
        {
            // Check if the reservation filter window is already open
            if (!reservationFilterOpen)
            {
                // Create a new instance of the reservation filter window
                reservationFilter = new Windows.ReservationFilter();
                reservationFilter.Closed += ReservationFilter_Closed; // Subscribe to the Closed event
                reservationFilterOpen = true; // Mark the reservation filter window as open
                                              // Set the main window as the owner
                reservationFilter.Owner = Window.GetWindow(this) as Window;
                reservationFilter.Show(); // Use Show instead of ShowDialog
            }
        }

        private void ReservationFilter_Closed(object sender, EventArgs e)
        {
            // When the reservation filter window is closed, enable the button and mark the window as closed
            reservationFilterOpen = false;
            reservationFilter.Closed -= ReservationFilter_Closed; // Unsubscribe from the Closed event
        }
    }
}
