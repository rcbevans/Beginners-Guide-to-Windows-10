using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Stupendous_Styles_Challenge.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(DonutPage), null);
        }

        private void DonutButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(DonutPage), null);
        }

        private void CoffeeButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(CoffeePage), null);
        }

        private void ScheduleButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(SchedulePage), null);
        }

        private void CompleteButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(CompletePage), null);
        }
    }
}
