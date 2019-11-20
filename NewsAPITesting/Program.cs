using System;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;

namespace NewsAPITesting
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }

        private static async void test()
        {
            Console.WriteLine("Test");
            var newsApiClient = new NewsApiClient("ddce5783271a4c67b9d0e82e3355610b");

            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = "Test",
                SortBy = SortBys.Popularity,
                Language = Languages.EN,
                From = new DateTime(2019, 1, 25)
            });

            Console.WriteLine(articlesResponse.TotalResults);

            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                Console.WriteLine(articlesResponse.TotalResults);

                // here's the first 20
                foreach (var article in articlesResponse.Articles)
                {
                    // title
                    Console.WriteLine(article.Title);
                    // author
                    Console.WriteLine(article.Author);
                    // description
                    Console.WriteLine(article.Description);
                    // url
                    Console.WriteLine(article.Url);
                    // image
                    Console.WriteLine(article.UrlToImage);
                    // published at
                    Console.WriteLine(article.PublishedAt);
                }
            }

            Console.ReadLine();
        }
    }
}
