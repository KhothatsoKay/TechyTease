using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public class NewsApiResponse
    {
        public List<NewsArticle> Articles { get; set; }
    }
    public class NewsSource
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }


    public class NewsArticle
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string Image { get; set; } // Updated property name
        public DateTime PublishedAt { get; set; }
        public NewsSource Source { get; set; }

    }
}
