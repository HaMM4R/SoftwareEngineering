using NewsAPIProviders;
using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    /// <summary>
    /// Get News artciles from the three major providers:
    /// ContextualWeb
    /// Bing
    /// NewsAPI.org
    /// For ContextualWeb X_RapidAPI_Key go to: https://rapidapi.com/contextualwebsearch/api/web-search
    /// </summary>
    internal class Program
    {
        public static string NewsAPI_APIKey = "ddce5783271a4c67b9d0e82e3355610b";

        public static void Main(string[] args)
        {
            //Your search query:
            string q = "Taylor Swift";

            //Call the 3 APIs
            Task<Results> task = GetApiComparison(q);
            Task.WaitAny(task);

            var newsApiNewsArticles = task.Result.newsApi;

            foreach(var test in newsApiNewsArticles)
            {
                Debug.WriteLine(test.title);
            }

            Console.WriteLine("done.");
        }

        public static async Task<Results> GetApiComparison(string q)
        {
            var taskNewsAPI = NewsAPIorg.GetNewsSearch(q, NewsAPI_APIKey);

            //Wait for the responses
            await Task.WhenAll(taskNewsAPI);

            Results result = new Results
            {
                newsApi = taskNewsAPI.Result
            };

            return result;
        }
    }
}