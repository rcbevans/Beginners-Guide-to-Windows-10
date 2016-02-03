using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace Adeptly_Adaptive_Challenge.ViewModels
{
    public interface IAppShellViewModel
    {
        ICommand ToggleHamburgerMenu { get; }
        ICommand PaneItemSelected { get; }

        bool HamburgerShowing { get; set; }
        string CurrentPageTitle { get; set; }

        void RegisterContentFrame(Frame frame);
    }
}