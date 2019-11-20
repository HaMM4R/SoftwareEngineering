using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using unirest_net.http;

namespace NewsAPIProviders
{
    /// <summary>
    /// Get ContextualWeb X_RapidAPI_Key go to: https://rapidapi.com/contextualwebsearch/api/web-search
    /// </summary>
    public static class ContextualWeb
    {
        public static async Task<List<Article>> GetNewsSearch(string q, string X_RapidAPI_Key)
        {
            try
            {
                //Perform the web request and get the response
                var response = await Unirest.get(string.Format("https://contextualwebsearch-websearch-v1.p.rapidapi.com/api/Search/NewsSearchAPI?q={0}&pageNumber={1}&pageSize={2}&autoCorrect={3}&safeSearch={4}", q, 1, 20, false, false))
                .header("X-RapidAPI-Host", "contextualwebsearch-websearch-v1.p.rapidapi.com")
                .header("X-RapidAPI-Key", X_RapidAPI_Key)
                .asJsonAsync<string>();

                //Get the ResponseBody as a JSON
                dynamic jsonBody = JsonConvert.DeserializeObject(response.Body);

                //Parse the results

                //Get the numer of items returned
                int totalCount = (int)jsonBody["totalCount"];

                //Get the list of most frequent searches related to the input search query
                List<string> relatedSearch = JsonConvert.DeserializeObject<List<string>>(jsonBody["relatedSearch"].ToString());

                var result = new List<Article>();
                //Go over each resulting item
                foreach (var item in jsonBody["value"])
                {
                    var article = new Article();

                    //Get the web page metadata
                    article.url = item["url"].ToString();
                    article.title = item["title"].ToString();
                    article.description = item["description"].ToString();
                    article.publishedTime = DateTime.Parse(item["datePublished"].ToString());
                    article.publishedTimeTicks = article.publishedTime.Ticks;

                    //Get the web page image (if exists)
                    article.imageUrl = item["image"]["url"].ToString();

                    //Get the web page image thumbail (if exists)
                    article.imageThumbnail = item["image"]["thumbnail"].ToString();

                    article.source = item["provider"]["name"].ToString();
                    result.Add(article);
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}