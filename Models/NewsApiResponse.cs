using System.Collections.Generic;

namespace Blog.Models
{
    public class NewsApiResponse
    {
        public List<NewsArticle> Articles { get; set; }
    }

    public class NewsArticle
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string PublishedAt { get; set; }
    }
}
