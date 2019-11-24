using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify_UI
{
    public class Keywords
    {
        private string[] removeWords = new string[56] 
        { 
            "is", "the", "from", "to", "who", "in", "says", 
            "he", "she", "him", "her", "that", "this", "those",
            "be", "of", "and", "a", "have", "it", "for", "not",
            "on", "with", "by", "say", "or", "will", "my", "their",
            "there", "would", "what", "so", "about", "get", "just",
            "know", "take", "into", "year", "people", "good", "some",
            "see", "other", "over", "think", "how", "work", "first", "want",
            "new", "day", "most", "us"
        };

        public string FindKeywords(string headline)
        {
            var builder = new StringBuilder();
            string cutHeadline = "";
            int counter = 0;

            headline = headline.ToLower();
            foreach (string s in removeWords)
            {
                cutHeadline = headline.Replace(s, ""); 
            }

            foreach(char c in cutHeadline)
            {
                if (counter == 3)
                    break;

                if (c == ' ')
                    counter++;

                builder.Append(c); 
            }


            cutHeadline = builder.ToString(); 
            return cutHeadline; 
        }
    }
}
