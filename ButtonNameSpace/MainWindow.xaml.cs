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

namespace ButtonNameSpace
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = GetRandomBrushColor();
            MessageBox.Show($"Button {button.Content} clicked. Color: {button.Background}", "Button Clicked", MessageBoxButton.OK);
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = (Button)sender;
            buttonStackPanel1.Children.Remove(button);
            buttonStackPanel2.Children.Remove(button);
            this.Title = $"Button {button.Content} deleted";
        }
        private SolidColorBrush GetRandomBrushColor()
        {
            Random random = new Random();
            byte red = Convert.ToByte(random.Next(0, 255));
            byte green = Convert.ToByte(random.Next(0, 255));
            byte blue = Convert.ToByte(random.Next(0, 255));
            return new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
    }
}
