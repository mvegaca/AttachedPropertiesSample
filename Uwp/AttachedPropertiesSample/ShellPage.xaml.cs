using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AttachedPropertiesSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShellPage : Page
    {
        public ShellPage()
        {
            this.InitializeComponent();
            listViewBehavior.Initialize(navigationFrame);
        }

        private void MainPageClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            navigationFrame.Navigate(typeof(MainPage));
        }

        private void SecondaryPageClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            navigationFrame.Navigate(typeof(SecondaryPage));
        }
    }
}
