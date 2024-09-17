<<<<<<< Updated upstream
﻿using System;
=======
﻿using CampingApp3.Models.Services;
using System;
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
>>>>>>> Stashed changes

namespace CampingApp3.Views
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : WindowBase
    {
		private bool isAdmin = false;
<<<<<<< Updated upstream
		public Index() : base()
		{
			base.ChildForm = this; InitializeComponent();

=======
        public static int userID { get; set; } = -1; // default value for guests
		private WindowBase wb;
		private readonly UserService dbUser;
        public Index()
		{
			InitializeComponent();
			wb = new WindowBase();
>>>>>>> Stashed changes
			accInfo.Visibility = Visibility.Collapsed;
			btnAdminPage.Visibility = Visibility.Collapsed;
		}

		public Index(int _userID, bool isAdmin) : base() // Explicitly call base constructor
		{
			base.ChildForm = this; InitializeComponent();

			userID = _userID;
<<<<<<< Updated upstream
			string email = dbFunc.GetEmail(userID);
=======
			string email = dbUser.GetEmail(userID);
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
		public static int userID { get; set; } = -1; // default value for guests
	}
=======
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

        public void pnlSelectionBar_MouseDown(Object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { this.DragMove(); }
            if (e.LeftButton == MouseButtonState.Pressed && this.WindowState == WindowState.Maximized)
            {
                // Exit fullscreen mode
                this.WindowState = WindowState.Normal;
            }
        }

        public void pnlTopBar_MouseDown(Object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { this.DragMove(); }
            if (e.LeftButton == MouseButtonState.Pressed && this.WindowState == WindowState.Maximized)
            {
                // Exit fullscreen mode
                this.WindowState = WindowState.Normal;
            }
        }
    }
>>>>>>> Stashed changes
}
