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
    /// Interaction logic for WindowBase.xaml
    /// </summary>
    public partial class WindowBase : Window
    {

        public void btnTerminate_Click()
        {
            try
            {
                Application.Current.Shutdown();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void btnMinimize_Click()
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void btnFullscreen_Click()
        {
            this.WindowState = (this.WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }

/*        public void setStyle()
        {
            // Create a new style for Button
            Style hoverButtonStyle = new Style(typeof(Button));

            // Set the background, foreground, and border thickness properties
            hoverButtonStyle.Setters.Add(new Setter(Button.BackgroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF282C31"))));
            hoverButtonStyle.Setters.Add(new Setter(Button.ForegroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2C9BFF"))));
            hoverButtonStyle.Setters.Add(new Setter(Button.BorderThicknessProperty, new Thickness(0)));

            // Create a control template for the button
            ControlTemplate buttonTemplate = new ControlTemplate(typeof(Button));

            // Create a border element inside the control template
            FrameworkElementFactory borderFactory = new FrameworkElementFactory(typeof(Border));
            borderFactory.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(Button.BackgroundProperty));
            borderFactory.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(Button.BorderBrushProperty));
            borderFactory.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(Button.BorderThicknessProperty));

            // Create a ContentPresenter to present the button's content
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);

            // Add the ContentPresenter as a child of the Border
            borderFactory.AppendChild(contentPresenter);

            // Set the VisualTree of the ControlTemplate to the Border element
            buttonTemplate.VisualTree = borderFactory;

            // Define the trigger for the IsMouseOver property
            Trigger isMouseOverTrigger = new Trigger
            {
                Property = UIElement.IsMouseOverProperty,
                Value = true
            };
            isMouseOverTrigger.Setters.Add(new Setter(Button.BackgroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3A3E44"))));

            // Add the trigger to the ControlTemplate
            buttonTemplate.Triggers.Add(isMouseOverTrigger);

            // Set the template for the button style
            hoverButtonStyle.Setters.Add(new Setter(Button.TemplateProperty, buttonTemplate));

            // Assign the style to a button (or add it to resources)
            Button myButton = new Button
            {
                Content = "Hover Button",
                Style = hoverButtonStyle
            };

            // Alternatively, you can add this style to a resource dictionary, like so:
            // this.Resources["HoverButtonStyle"] = hoverButtonStyle;

        }*/
    }
}
