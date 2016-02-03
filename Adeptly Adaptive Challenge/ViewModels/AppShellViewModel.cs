using Adeptly_Adaptive_Challenge.Models;
using Adeptly_Adaptive_Challenge.ViewModels.Helpers;
using Adeptly_Adaptive_Challenge.Views;
using System.Diagnostics.Contracts;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace Adeptly_Adaptive_Challenge.ViewModels
{
    public class AppShellViewModel : ViewModelBase, IAppShellViewModel
    {
        private Frame _mainContentFrame;
        private string _currentPageTitle;
        private RelayCommand _toggleHamburgerCommand;
        private RelayCommand _paneItemSelectedCommand;
        private MainContentPageType _currentPage;

        private bool _hamburgerShowing;

        private MainContentPageType CurrentPage
        {
            set
            {
                if (SetProperty(ref _currentPage, value))
                {
                    NavigateToPage(_currentPage);
                }
            }
        }

        private void NavigateToPage(MainContentPageType page)
        {
            switch (page)
            {
                case MainContentPageType.Financial:
                    _mainContentFrame?.Navigate(typeof(FinancialNewsPage));
                    CurrentPageTitle = "Financial";
                    break;
                case MainContentPageType.Food:
                    _mainContentFrame.Navigate(typeof(FoodNewsPage));
                    CurrentPageTitle = "Food";
                    break;
            }
        }

        public string CurrentPageTitle
        {
            get { return _currentPageTitle; }
            set { SetProperty(ref _currentPageTitle, value); }
        }

        public ICommand ToggleHamburgerMenu
        {
            get { return _toggleHamburgerCommand; }
        }

        public ICommand PaneItemSelected
        {
            get
            {
                return _paneItemSelectedCommand;
            }
        }

        public bool HamburgerShowing
        {
            get
            {
                return _hamburgerShowing;
            }

            set
            {
                SetProperty(ref _hamburgerShowing, value);
            }
        }

        public void RegisterContentFrame(Frame frame)
        {
            _mainContentFrame = frame;
            CurrentPage = MainContentPageType.Financial;
        }

        public AppShellViewModel()
        {
            _toggleHamburgerCommand = new RelayCommand(ToggleHamburgerMenuCommandExecute);
            _paneItemSelectedCommand = new RelayCommand(PaneItemSelectedCommandExecute);
            _hamburgerShowing = false;
            _currentPage = MainContentPageType.Unset;
            _currentPageTitle = "Loading...";
        }

        private void ToggleHamburgerMenuCommandExecute(object obj)
        {
            HamburgerShowing = !HamburgerShowing;
        }

        private void PaneItemSelectedCommandExecute(object obj)
        {
            Contract.Assert(obj != null, "Cannot execute command with no parameter");
            MainContentPageType selectedType = (MainContentPageType)obj;
            CurrentPage = selectedType;
        }
    }
}
