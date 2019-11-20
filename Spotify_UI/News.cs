using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;

namespace Spotify_UI
{
    internal class News
    {
        public static string NewsAPI_APIKey = "ddce5783271a4c67b9d0e82e3355610b";

        public async Task<List<string>> SearchNews(string search)
        {
            List<string> results = new List<string>();
            var newsApiClient = new NewsApiClient(NewsAPI_APIKey);

            var articlesResponse = await newsApiClient.GetEverythingAsync(new EverythingRequest
            {
                Q = "Brexit",
                SortBy = SortBys.Popularity,
                Language = Languages.EN,
                From = DateTime.Now.AddDays(-2)
            });

            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                Console.WriteLine(articlesResponse.TotalResults);

                // here's the first 20
                foreach (var article in articlesResponse.Articles)
                {
                    results.Add(article.Title);
                }
            }

            return results; 
        }
    }
}
