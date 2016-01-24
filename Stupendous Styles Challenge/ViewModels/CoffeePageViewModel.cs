namespace Stupendous_Styles_Challenge.ViewModels
{
    public class CoffeePageViewModel : ViewModelBase
    {
        private RelayCommand _coffeeRoastCommand;
        private RelayCommand _coffeeSweetenerCommand;
        private RelayCommand _coffeeCreamCommand;

        private string _coffeeRoast;
        private string _coffeeSweetener;
        private string _coffeeCream;

        private string _coffeeResultString;

        public RelayCommand CoffeeRoastCommand
        {
            get { return _coffeeRoastCommand; }
            set { SetProperty(ref _coffeeRoastCommand, value); }
        }

        public RelayCommand CoffeeSweetenerCommand
        {
            get { return _coffeeSweetenerCommand; }
            set { SetProperty(ref _coffeeSweetenerCommand, value); }
        }

        public RelayCommand CoffeeCreamCommand
        {
            get { return _coffeeCreamCommand; }
            set { SetProperty(ref _coffeeCreamCommand, value); }
        }

        public string CoffeeRoast
        {
            get
            {
                return _coffeeRoast;
            }

            set
            {
                SetProperty(ref _coffeeRoast, value);
            }
        }

        public string CoffeeSweetener
        {
            get
            {
                return _coffeeSweetener;
            }

            set
            {
                SetProperty(ref _coffeeSweetener, value);
            }
        }

        public string CoffeeCream
        {
            get
            {
                return _coffeeCream;
            }

            set
            {
                SetProperty(ref _coffeeCream, value);
            }
        }

        public string CoffeeResultString
        {
            get
            {
                return _coffeeResultString;
            }

            set
            {
                SetProperty(ref _coffeeResultString, value);
            }
        }

        public CoffeePageViewModel()
        {
            _coffeeRoast = "None";
            _coffeeSweetener = "None";
            _coffeeCream = "None";

            _coffeeResultString = string.Empty;

            _coffeeRoastCommand = new RelayCommand(CoffeeRoastCommandExecute);
            _coffeeSweetenerCommand = new RelayCommand(CoffeeSweetenerCommandExecute);
            _coffeeCreamCommand = new RelayCommand(CoffeeCreamCommandExecute);
        }

        private void CoffeeRoastCommandExecute(object obj)
        {
            string roastType = obj as string;
            CoffeeRoast = roastType;
            UpdateCoffeeResultString();
        }

        private void CoffeeSweetenerCommandExecute(object obj)
        {
            string sweetenerType = obj as string;
            CoffeeSweetener = sweetenerType;
            UpdateCoffeeResultString();
        }

        private void CoffeeCreamCommandExecute(object obj)
        {
            string creamType = obj as string;
            CoffeeCream = creamType;
            UpdateCoffeeResultString();
        }

        private void UpdateCoffeeResultString()
        {
            string resultString = string.Empty;

            if (!_coffeeRoast.Equals("None"))
            {
                resultString = _coffeeRoast;
                if (!_coffeeSweetener.Equals("None"))
                {
                    resultString += $" + {_coffeeSweetener}";
                }

                if (!_coffeeCream.Equals("None"))
                {
                    resultString += $" + {_coffeeCream}";
                }
            }

            CoffeeResultString = resultString;
        }
    }
}
