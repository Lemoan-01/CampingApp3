using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Startup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CampingApp3.Views.Index mw;

        public MainWindow()
        {
            InitializeComponent();

            mw = new CampingApp3.Views.Index();
            mw.Show();
            this.Hide(); // Hides the main window upon startup
        }
    }
}