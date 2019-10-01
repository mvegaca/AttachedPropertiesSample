using System.Windows;
using MahApps.Metro.Controls;

namespace AttachedPropertiesSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            listViewBehavior.Initialize(navigationFrame);
        }

        private void MainPageClick(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new MainPage());
        }

        private void SecondaryPageClick(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new SecondaryPage());
        }
    }
}
