using CampingApp3.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for DescriptionPop.xaml
    /// </summary>
    public partial class DescriptionPop : WindowBase
    {
        private int placeID;

        public DescriptionPop(int placeID) : base()
        {
            InitializeComponent();

            this.DataContext = new ViewModels.NavigationVM();

            this.placeID = placeID;
            string spotDescription = dbFunc.GetDescription(placeID);

            Label labelSpotID = new Label()
            {
                Content = "Plek: " + placeID,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(2, 5, 0, 0),
                Height = 36,
                Width = 120,
                FontFamily = new FontFamily("Yu Gothic"),
                FontSize = 22,
                Foreground = Brushes.White,
                FontWeight = FontWeights.Bold,
            };
            gridPop.Children.Add(labelSpotID);

            TextBlock DescriptionBlock = new TextBlock()
            {
                Text = spotDescription,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(8, 55, 0, 0),
                TextWrapping = TextWrapping.Wrap,
                VerticalAlignment = VerticalAlignment.Top,
                Height = 92,
                Width = 276,
                FontSize = 15,
                Foreground = Brushes.White,
            };
            gridPop.Children.Add(DescriptionBlock);

            LoadImage();
        }

        private void LoadImage() //voor individuele imgs plek
        {
            byte[] bytingImage = dbFunc.GetImageFromDatabase(placeID);
            BitmapImage bitmapImage = ByteArrayToBitmapImage(bytingImage);

            Image displayImage = new Image()
            {
                Source = bitmapImage,
                HorizontalAlignment = HorizontalAlignment.Left,
                Height = 159,
                Width = 194,
                Margin = new Thickness(190, 55, 0, 0),
                VerticalAlignment = VerticalAlignment.Top,
            };

            gridPop.Children.Add(displayImage);
        }

        public BitmapImage ByteArrayToBitmapImage(byte[] byteArray) //voor individuele imgs plek
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.StreamSource = ms;
                bitmap.EndInit();
                return bitmap;
            }
        }

        public void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { this.DragMove(); }
            if (e.LeftButton == MouseButtonState.Pressed && this.WindowState == WindowState.Maximized)
            {
                // Exit fullscreen mode
                this.WindowState = WindowState.Normal;
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "Cancel")
            {
                this.Close();
            }
            else
            {
                DateTime startDate = ReservationFilter.firstDates;
                DateTime endDate = ReservationFilter.lastDates;

                if (!startDate.Equals(DateTime.MinValue) && !endDate.Equals(DateTime.MinValue)) //als ze allebei niet hun default-waarde zijn
                {
                    MakeReservationPage.MainWindow mk = new MakeReservationPage.MainWindow(placeID, startDate, endDate);
                    mk.Show();
                }
                else
                {
                    MessageBox.Show("Please, set your stay duration in the filter tab first!\n(top-right calendar).");
                }
            }
        }
    }
}
