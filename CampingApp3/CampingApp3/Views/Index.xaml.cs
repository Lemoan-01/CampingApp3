using System;
using System.Windows;
using System.Windows.Controls;

namespace CampingApp3.Views
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : Window
    {
		private bool isAdmin = false;
        public static int userID { get; set; } = -1; // default value for guests
		private WindowBase wb;
        public Index()
		{
			InitializeComponent();

			wb = new WindowBase();
			accInfo.Visibility = Visibility.Collapsed;
			btnAdminPage.Visibility = Visibility.Collapsed;
		}

		public Index(int _userID, bool isAdmin)
		{
			InitializeComponent();

			userID = _userID;
			/*			string email = dbFunc.GetEmail(userID);*/
			string email = "temp";
			this.isAdmin = isAdmin;

			if (userID != -1)
			{
				loginBtn.Visibility = Visibility.Collapsed;
				accInfo.Visibility = Visibility.Visible;
				btnAdminPage.Visibility = Visibility.Collapsed;

				lblLoggedIn.Content = "Your email = " + email;
			}
			if (userID != -1 && isAdmin)
			{
				loginBtn.Visibility = Visibility.Collapsed;
				accInfo.Visibility = Visibility.Visible;
				btnAdminPage.Visibility = Visibility.Visible;

				lblLoggedIn.Content = "Your email = " + email;
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;

			if (button.Name == "btnTerminate")
			{
				wb.btnTerminate_Click();
				return;
			}
			if (button.Name == "btnMinimize")
			{
				wb.btnMinimize_Click();
				return;
			}
			if(button.Name == "btnFullscreen")
			{
				wb.btnFullscreen_Click();
				return;
            }
		}

        public void CloseHomepage()
		{
			this.Close();
		}
	}
}
