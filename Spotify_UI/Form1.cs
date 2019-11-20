using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsAPIProviders;
using System.Diagnostics;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;

namespace Spotify_UI
{
    public partial class Form1 : Form
    {
        private SpotifyProfile _spotify;
        News n = new News(); 
        public Form1(SpotifyProfile s)
        {
            _spotify = s;
            InitializeComponent();
        }

        private async void searchSongs_btn_Click(object sender, EventArgs e)
        {
            foreach (var s in _spotify.search.SearchAlbums("Queen"))
            {
                songs_lst.Items.Add(s);
            }

            var newsApiClient = new NewsApiClient("ddce5783271a4c67b9d0e82e3355610b");

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
                    songs_lst.Items.Add(article.Title);
                }
            }

            Console.ReadLine();
        }
        
    

        private void headlines_lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void songs_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
