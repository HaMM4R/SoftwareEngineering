using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using NewsAPIProviders;
using System.Diagnostics;

namespace Spotify_UI
{
    internal class News
    {
        public static string NewsAPI_APIKey = "ddce5783271a4c67b9d0e82e3355610b";

        public News()
        {
            
        }

        public List<string> NewsSearch()
        {
            List<string> s = new List<string>(); 
            string q = "Queen";

            //Call the 3 APIs
            Task<Results> task = GetApiComparison(q);
            Task.WaitAny(task);

            var newsApiNewsArticles = task.Result.newsApi;

            foreach (var test in newsApiNewsArticles)
            {
                Debug.WriteLine(test.title);
                s.Add(test.title);
            }
            return s; 
            
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
