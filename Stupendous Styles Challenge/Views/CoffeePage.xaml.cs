using Stupendous_Styles_Challenge.ViewModels;
using Windows.UI.Xaml.Controls;

namespace Stupendous_Styles_Challenge.Views
{
    public sealed partial class CoffeePage : Page
    {
        public CoffeePageViewModel VM
        {
            get { return (CoffeePageViewModel)this.DataContext; }
        }

        public CoffeePage()
        {
            this.InitializeComponent();
        }
    }
}
