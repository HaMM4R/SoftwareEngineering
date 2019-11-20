using Microsoft.Azure.CognitiveServices.Search.NewsSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAPIProviders
{
    public static class Bing
    {
        public static async Task<List<Article>> GetNewsSearch(string q, string subscriptionKey)
        {
            var client = new NewsSearchClient(new ApiKeyServiceClientCredentials(subscriptionKey));

            var result = new List<Article>();

            try
            {
                var newsResults = await client.News.SearchAsync(query: q, market: "en-us", count: 20);

                foreach (var item in newsResults.Value)
                {
                    var article = new Article();

                    article.title = item.Name;

                    article.description = item.Description;

                    article.url = item.Url;

                    if (item.Image != null && item.Image.Thumbnail != null)
                    {
                        article.imageUrl = item.Image.Thumbnail.ContentUrl;
                        article.imageThumbnail = item.Image.Thumbnail.ContentUrl;
                    }

                    article.publishedTime = Convert.ToDateTime(item.DatePublished);
                    article.publishedTimeTicks = article.publishedTime.Ticks;

                    article.source = item.Provider.Count > 0 ? item.Provider.First().Name : string.Empty; ;
                    result.Add(article);
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered exception. " + ex.Message);
                return null;
            }
        }
    }
}