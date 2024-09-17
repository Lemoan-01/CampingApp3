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
    /// Interaction logic for ReservationFilter.xaml
    /// </summary>
    public partial class ReservationFilter : WindowBase
    {
        private double _previousWidth;
        private double _previousHeight;
        public static DateTime firstDates { get; set; }
        public static DateTime lastDates { get; set; }
        private int dateSelectionCounter = 0;
        public ReservationFilter() : base()
        {
<<<<<<< Updated upstream
			base.ChildForm = this; InitializeComponent();

=======
			InitializeComponent();
            WindowBase wb = new WindowBase();
>>>>>>> Stashed changes
			Owner = Application.Current.MainWindow; // Set the owner to MainWindow
            UpdatePosition(); // Set initial position
            Application.Current.MainWindow.LocationChanged += MainWindow_LocationChanged; // Subscribe to LocationChanged event
            Application.Current.MainWindow.SizeChanged += MainWindow_SizeChanged; // Subscribe to SizeChanged event
            Application.Current.MainWindow.StateChanged += MainWindow_StateChanged; // Subscribe to StateChanged event
            Application.Current.MainWindow.IsVisibleChanged += MainWindow_IsVisibleChanged; // Subscribe to IsVisibleChanged event
            _previousWidth = Owner.Width;
            _previousHeight = Owner.Height;
            StartDatePicker.DisplayDate = DateTime.Now;
            EndDatePicker.DisplayDate = DateTime.Now;
        }




        private void MainWindow_LocationChanged(object sender, EventArgs e)
        {
            UpdatePosition(); // Update position when MainWindow's location changes
        }

        private void UpdatePosition()
        {
            Left = Owner.Left + Owner.Width + 10; // Adjust the position as needed
            Top = Owner.Top;
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Calculate the difference in width and height of the main window
            double widthDiff = Owner.Width - _previousWidth;
            double heightDiff = Owner.Height - _previousHeight;

            // Adjust the position and size of the filter window
            Left += widthDiff;

            // Update the previous width and height
            _previousWidth = Owner.Width;
            _previousHeight = Owner.Height;
        }

        private void MainWindow_StateChanged(object sender, EventArgs e)
        {
            if (Owner.WindowState == WindowState.Maximized)
            {
                // Bring the filter window to the foreground when the main window is maximized
                this.Topmost = true;  // Bring to front
                this.Topmost = false; // Allow other windows to come to front
            }
        }

        private void MainWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // Check if the main window is now visible
            if ((bool)e.NewValue == true)
            {
                // Bring the filter window to the foreground when the main window becomes visible
                this.Topmost = true;  // Bring to front
                this.Topmost = false; // Allow other windows to come to front
            }
        }

        private void SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker dateP = (DatePicker)sender;
            DateTime date = (DateTime)dateP.SelectedDate;

            if (dateSelectionCounter % 2 == 0)
            {
                firstDates = date;
                dateSelectionCounter++; // maak getal oneven
            }
            else
            {
                lastDates = date;
                TimeSpan diff = date - firstDates; // Gebruik TimeSpan om het verschil te berekenen
                int stayLengthDays = diff.Days;

                if (diff > TimeSpan.Zero)
                {
                    LblStayDuration.Content = "Selected " + stayLengthDays + " days";
                }
                else
                {
                    MessageBox.Show("You can't stay for " + stayLengthDays + " days");
                }
                dateSelectionCounter++; // maak getal weer even
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< Updated upstream
            var reservationWindow = Reservation.Instance;
            reservationWindow.LoadDataAsync();
=======
            Button btn = (Button)sender;
>>>>>>> Stashed changes

            if (btn.Name == "ApplyFilter")
            {
<<<<<<< Updated upstream
                if (dbFunc.IsConnectionAvailable()) // Check if database connection is available
=======
                var reservationWindow = Map.Instance;
                reservationWindow.LoadDataAsync();

                if (reservationWindow != null && StartDatePicker.SelectedDate != null && EndDatePicker.SelectedDate != null)
>>>>>>> Stashed changes
                {
                    Grid mapGrid = reservationWindow.GetMapGrid();
                    int btnCounter = 0;

                    foreach (var child in mapGrid.Children)
                    {
                        if (child is Button button && button.Name != "btnInformation")
                        {
                            bool isAvailable = dbFunc.isAvailable(btnCounter, (DateTime)StartDatePicker.SelectedDate, (DateTime)EndDatePicker.SelectedDate);
                            if (!isAvailable) // Only color the buttons that are not available
                            {
                                button.Background = Brushes.OrangeRed;
                                button.IsHitTestVisible = false;
                            }
                            else
                            {
                                button.Background = Brushes.PaleGreen;
                                button.IsHitTestVisible = true;
                            }
                        }

                        btnCounter++; // Iterate through all buttons
                    }
                }
                else
                {
<<<<<<< Updated upstream
                    MessageBox.Show("No database connection. Please check your connection and try again.");
=======
                    MessageBox.Show("The reservation window is closed, or dates have not been selected.");
>>>>>>> Stashed changes
                }
            }
            if (btn.Name == "btnTerminate")
            {
                this.Close(); // Close the filter window
            }
        }
    }
}
