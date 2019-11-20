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
        private News news = new News(); 
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

            List<string> results = await news.SearchNews("Brexit");

            foreach(string s in results)
            {
                headlines_lst.Items.Add(s);
            }
        }
        
    

        private void headlines_lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void songs_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
