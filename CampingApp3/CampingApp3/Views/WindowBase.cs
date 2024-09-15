using System.Windows;
using System.Windows.Input;

namespace CampingApp3.Views
{
    public class WindowBase : Window
    {
        public WindowBase()
        {
            // Any base initialization can go here
        }

        protected void btnTerminate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Application.Current.Shutdown();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        protected void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        protected void pnlSelectionBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { this.DragMove(); }
            if (e.LeftButton == MouseButtonState.Pressed && this.WindowState == WindowState.Maximized)
            {
                // Exit fullscreen mode
                this.WindowState = WindowState.Normal;
            }
        }

        protected void pnlTopBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { this.DragMove(); }
            if (e.LeftButton == MouseButtonState.Pressed && this.WindowState == WindowState.Maximized)
            {
                // Exit fullscreen mode
                this.WindowState = WindowState.Normal;
            }
        }

        protected void btnFullscreen_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = (this.WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }
    }
}
