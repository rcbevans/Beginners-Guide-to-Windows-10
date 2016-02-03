namespace Adeptly_Adaptive_Challenge.UserControls.ViewModels
{
    using Adeptly_Adaptive_Challenge.Models;
    using Adeptly_Adaptive_Challenge.ViewModels;

    public class NewsItemViewModel : ViewModelBase, INewsItemViewModel
    {
        private NewsItem _originalItem;
        private string _headline;
        private string _subHeading;
        private string _dateLine;
        private string _imagePath;

        public string Headline { get { return _headline; } set { SetProperty(ref _headline, value); } }
        public string SubHeadline { get { return _subHeading; } set { SetProperty(ref _subHeading, value); } }
        public string DateLine { get { return _dateLine; } set { SetProperty(ref _dateLine, value); } }
        public string Image { get { return _imagePath; } set { SetProperty(ref _imagePath, value); } }

        public NewsItemViewModel(NewsItem ni)
        {
            _originalItem = ni;
            Headline = ni.Headline;
            SubHeadline = ni.SubHeadline;
            DateLine = ni.DateLine;
            Image = ni.Image;
        }
    }
}
