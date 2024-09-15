using System.Windows;
using System;

namespace CampingApp3.Views
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : WindowBase
    {
        public static int userID { get; set; } = -1; // default value for guests
        private bool isAdmin = false;

        public Index()
        {
            InitializeComponent();
            accInfo.Visibility = Visibility.Collapsed;
            btnAdminPage.Visibility = Visibility.Collapsed;
        }

        public Index(int _userID, bool isAdmin) : base() // Explicitly call base constructor
        {
            InitializeComponent();
            userID = _userID;
            string email = dbFunc.GetEmail(userID);
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
    }
}
