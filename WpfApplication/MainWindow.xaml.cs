using System.Windows;
using System.Windows.Media;

namespace WpfApplication
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

        private void ToRed_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Red);
        }

        private void ToBlue_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Blue);
        }
    }
}
