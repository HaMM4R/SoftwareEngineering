using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsAPIProviders
{
    public class NewsAPIorg
    {
        public static async Task<List<Article>> GetNewsSearch(string q, string apiKey)
        {
            // init with your API key
            var newsApiClient = new NewsApiClient(apiKey);
            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = q,
                SortBy = SortBys.PublishedAt,
                Language = Languages.EN,
                From = DateTime.Now.AddDays(-2)
            });

            var result = new List<Article>();

            if (articlesResponse.Status == Statuses.Ok)
            {
                foreach (var item in articlesResponse.Articles)
                {
                    var article = new Article();

                    article.title = item.Title;

                    article.description = item.Description;

                    article.url = item.Url;

                    article.imageUrl = item.UrlToImage;

                    article.imageThumbnail = item.UrlToImage;

                    article.publishedTime = (DateTime)item.PublishedAt;

                    article.publishedTimeTicks = article.publishedTime.Ticks;

                    article.source = item.Source != null ? item.Source.Name : string.Empty;

                    result.Add(article);
                }
            }
            return result;
        }
    }
}