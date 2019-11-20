using System.Collections.Generic;

namespace NewsAPIProviders
{
    public class Results
    {
        public List<Article> contextualWeb { get; set; }
        public List<Article> bing { get; set; }
        public List<Article> newsApi { get; set; }
    }
}