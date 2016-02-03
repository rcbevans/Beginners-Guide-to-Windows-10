namespace Adeptly_Adaptive_Challenge.Models
{
    public class NewsItem 
    {
        private int _id;
        private NewsStoryCategory _category;
        private string _headline;
        private string _subHeading;
        private string _dateLine;
        private string _imagePath;

        public int Id { get { return _id; } set { _id = value; } }
        public NewsStoryCategory Category { get { return _category; } set { _category = value; } }
        public string Headline { get { return _headline; } set { _headline = value; } }
        public string SubHeadline { get { return _subHeading; } set { _subHeading = value; } }
        public string DateLine { get { return _dateLine; } set { _dateLine = value; } }
        public string Image { get { return _imagePath; } set { _imagePath = value; } }
    }
}
