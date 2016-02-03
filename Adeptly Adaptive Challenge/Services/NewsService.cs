namespace Adeptly_Adaptive_Challenge.Services
{
    using Adeptly_Adaptive_Challenge.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class NewsService : INewsService
    {
        private List<NewsItem> _items;

        public List<NewsItem> GetNewsStories(NewsStoryCategory category)
        {
            return (from item in _items
                    where item.Category == category
                    select item).ToList();
        }

        public NewsService()
        {
            _items = new List<NewsItem>();

            _items.Add(new NewsItem() { Id = 1, Category = NewsStoryCategory.Financial, Headline = "Lorem Ipsum", SubHeadline = "doro sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/Financial/Financial1.png" });
            _items.Add(new NewsItem() { Id = 2, Category = NewsStoryCategory.Financial, Headline = "Etiam ac felis viverra", SubHeadline = "vulputate nisl ac, aliquet nisi", DateLine = "tortor porttitor, eu fermentum ante congue", Image = "/Assets/Financial/Financial2.png" });
            _items.Add(new NewsItem() { Id = 3, Category = NewsStoryCategory.Financial, Headline = "Integer sed turpis erat", SubHeadline = "Sed quis hendrerit lorem, quis interdum dolor", DateLine = "in viverra metus facilisis sed", Image = "/Assets/Financial/Financial3.png" });
            _items.Add(new NewsItem() { Id = 4, Category = NewsStoryCategory.Financial, Headline = "Proin sem neque", SubHeadline = "aliquet quis ipsum tincidunt", DateLine = "Integer eleifend", Image = "/Assets/Financial/Financial4.png" });
            _items.Add(new NewsItem() { Id = 5, Category = NewsStoryCategory.Financial, Headline = "Mauris bibendum non leo vitae tempor", SubHeadline = "In nisl tortor, eleifend sed ipsum eget", DateLine = "Curabitur dictum augue vitae elementum ultrices", Image = "/Assets/Financial/Financial5.png" });

            _items.Add(new NewsItem() { Id = 6, Category = NewsStoryCategory.Food, Headline = "Lorem ipsum", SubHeadline = "dolor sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/Food/Food1.png" });
            _items.Add(new NewsItem() { Id = 7, Category = NewsStoryCategory.Food, Headline = "Etiam ac felis viverra", SubHeadline = "vulputate nisl ac, aliquet nisi", DateLine = "tortor porttitor, eu fermentum ante congue", Image = "/Assets/Food/Food2.png" });
            _items.Add(new NewsItem() { Id = 8, Category = NewsStoryCategory.Food, Headline = "Integer sed turpis erat", SubHeadline = "Sed quis hendrerit lorem, quis interdum dolor", DateLine = "in viverra metus facilisis sed", Image = "/Assets/Food/Food3.png" });
            _items.Add(new NewsItem() { Id = 9, Category = NewsStoryCategory.Food, Headline = "Proin sem neque", SubHeadline = "aliquet quis ipsum tincidunt", DateLine = "Integer eleifend", Image = "/Assets/Food/Food4.png" });
            _items.Add(new NewsItem() { Id = 10, Category = NewsStoryCategory.Food, Headline = "Mauris bibendum non leo vitae tempor", SubHeadline = "In nisl tortor, eleifend sed ipsum eget", DateLine = "Curabitur dictum augue vitae elementum ultrices", Image = "/Assets/Food/Food5.png" });
        }
    }
}
