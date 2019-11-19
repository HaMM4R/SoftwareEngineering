using System;

namespace NewsAPIProviders
{
    public class Article
    {
        public string url { get; set; }

        public string source { get; set; }

        public DateTime publishedTime { get; set; }

        public string language { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string imageUrl { get; set; }

        public string imageThumbnail { get; set; }

        public long publishedTimeTicks { get; set; }
    }
}