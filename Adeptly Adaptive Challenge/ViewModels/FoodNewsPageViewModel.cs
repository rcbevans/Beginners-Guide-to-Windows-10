namespace Adeptly_Adaptive_Challenge.ViewModels
{
    using Adeptly_Adaptive_Challenge.Models;
    using Adeptly_Adaptive_Challenge.Services;
    using Adeptly_Adaptive_Challenge.UserControls.ViewModels;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    class FoodNewsPageViewModel : ViewModelBase
    {
        private INewsService _newsService;
        private ObservableCollection<INewsItemViewModel> _foodItems;

        public ObservableCollection<INewsItemViewModel> NewsStories
        {
            get { return _foodItems; }
            set { SetProperty(ref _foodItems, value); }
        }

        public FoodNewsPageViewModel()
        {
            _newsService = new NewsService();
            List<NewsItem> items = _newsService.GetNewsStories(NewsStoryCategory.Food);

            ObservableCollection<INewsItemViewModel> itemVMs = new ObservableCollection<INewsItemViewModel>();

            (from item in items
             select new NewsItemViewModel(item)).ToList().ForEach(itemVMs.Add);

            NewsStories = itemVMs;
        }
    }
}
