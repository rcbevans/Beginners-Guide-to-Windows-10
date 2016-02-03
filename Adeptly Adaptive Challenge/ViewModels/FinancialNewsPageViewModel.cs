namespace Adeptly_Adaptive_Challenge.ViewModels
{
    using Adeptly_Adaptive_Challenge.Models;
    using Services;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using UserControls.ViewModels;

    class FinancialNewsPageViewModel : ViewModelBase
    {
        private INewsService _newsService;
        private ObservableCollection<INewsItemViewModel> _financialItems;

        public ObservableCollection<INewsItemViewModel> NewsStories
        {
            get { return _financialItems; }
            set { SetProperty(ref _financialItems, value); }
        }

        public FinancialNewsPageViewModel()
        {
            _newsService = new NewsService();
            List<NewsItem> items = _newsService.GetNewsStories(NewsStoryCategory.Financial);

            ObservableCollection<INewsItemViewModel> itemVMs = new ObservableCollection<INewsItemViewModel>();

            (from item in items
             select new NewsItemViewModel(item)).ToList().ForEach(itemVMs.Add);

            NewsStories = itemVMs;
        }
    }
}
