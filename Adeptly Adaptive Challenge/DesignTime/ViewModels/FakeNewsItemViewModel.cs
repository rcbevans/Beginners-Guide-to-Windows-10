namespace Adeptly_Adaptive_Challenge.DesignTime.ViewModels
{
    using Adeptly_Adaptive_Challenge.UserControls.ViewModels;
    using System;

    public class FakeNewsItemViewModel : INewsItemViewModel
    {
        public string DateLine
        {
            get
            {
                return "Curabitur dictum augue vitae elementum ultrices";
            }

            set
            {
            }
        }

        public string Headline
        {
            get
            {
                return "Lorem ipsum";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Image
        {
            get
            {
                return "/Assets/Financial/Financial1.png";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string SubHeadline
        {
            get
            {
                return "dolor sit amet";
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
