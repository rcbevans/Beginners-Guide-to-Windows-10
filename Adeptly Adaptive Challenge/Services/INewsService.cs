using Adeptly_Adaptive_Challenge.Models;
namespace Adeptly_Adaptive_Challenge.Services
{
    using System.Collections.Generic;

    public interface INewsService
    {
        List<NewsItem> GetNewsStories(NewsStoryCategory category);
    }
}
