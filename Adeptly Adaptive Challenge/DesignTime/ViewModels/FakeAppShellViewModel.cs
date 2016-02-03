namespace Adeptly_Adaptive_Challenge.DesignTime.ViewModels
{
    using Adeptly_Adaptive_Challenge.ViewModels;
    using System;
    using System.Windows.Input;
    using Windows.UI.Xaml.Controls;

    public class FakeAppShellViewModel : IAppShellViewModel
    {
        public string CurrentPageTitle
        {
            get
            {
                return "Fake Page";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool HamburgerShowing
        {
            get
            {
                return true;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public ICommand PaneItemSelected
        {
            get
            {
                return null;
            }
        }

        public ICommand ToggleHamburgerMenu
        {
            get
            {
                return null;
            }
        }

        public void RegisterContentFrame(Frame frame)
        {
        }
    }
}
