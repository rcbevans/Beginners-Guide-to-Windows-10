using Hamburger_Heaven.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HamburgerHeavenFrame : Page
    {
        public HamburgerHeavenFrame()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            MenuItemListBox.SelectedItem = Home;
        }

        private void MenuItemListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (sender as ListBox).SelectedItem as ListBoxItem;

            switch (selectedItem.Name)
            {
                case nameof(Food):
                    NavigateFood();
                    break;
                case nameof(Home):
                default:
                    NavigateHome();
                    break;
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            ContentSplitView.IsPaneOpen = !ContentSplitView.IsPaneOpen;
        }

        private void NavigateHome()
        {
            SplitviewContentFrame.Navigate(typeof(Financial));
            updateShell();
        }

        private void NavigateFood()
        {
            SplitviewContentFrame.Navigate(typeof(Food));
            updateShell();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (SplitviewContentFrame.CanGoBack)
                SplitviewContentFrame.GoBack();
            updateShell();
        }

        private void updateShell()
        {
            var currentContentType = SplitviewContentFrame.Content.GetType();
            
            switch (currentContentType.Name)
            {
                case nameof(Food):
                    CurrentPageTitle.Text = "Food";
                    BackButton.Visibility = Visibility.Visible;
                    if (MenuItemListBox.SelectedIndex != 1)
                        MenuItemListBox.SelectedIndex = 1;

                    break;
                case nameof(Financial):
                default:
                    if (MenuItemListBox.SelectedIndex != 0)
                        MenuItemListBox.SelectedIndex = 0;
                    CurrentPageTitle.Text = "Financial";
                    BackButton.Visibility = Visibility.Collapsed;
                    break;

            }
        }
    }
}
