using Adeptly_Adaptive_Challenge.Models;
using Adeptly_Adaptive_Challenge.ViewModels;
using Windows.UI.Xaml.Controls;

namespace Adeptly_Adaptive_Challenge.Views
{
    public sealed partial class AppShell : Page
    {
        public AppShellViewModel VM => this.DataContext as AppShellViewModel;

        public AppShell()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            VM?.RegisterContentFrame(AppContentFrame);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            ListBoxItem lbi = lb.SelectedItem as ListBoxItem;

            switch (lbi.Tag as string)
            {
                case "Financial":
                    VM.PaneItemSelected?.Execute(MainContentPageType.Financial);
                    break;
                case "Food":
                    VM.PaneItemSelected?.Execute(MainContentPageType.Food);
                    break;
            }
        }
    }
}
