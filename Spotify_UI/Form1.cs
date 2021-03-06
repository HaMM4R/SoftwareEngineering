﻿using System;
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
        private Keywords keywords = new Keywords(); 

        public Form1(SpotifyProfile s)
        {
            _spotify = s;
            InitializeComponent();
            ComboBoxes_Load();
        }

        private void ComboBoxes_Load()
        {
            songSearchType_cmbx.Items.Add("Songs");
            songSearchType_cmbx.Items.Add("Albums");
            songSearchType_cmbx.Items.Add("Artists");
            songSearchType_cmbx.Items.Add("Playlists");
            songSearchType_cmbx.SelectedItem = ("Songs");
        }

        List<string> results;
        private async void newsSearch_btn_Click(object sender, EventArgs e)
        {
            string searchfilter = headlineSearch_txt.Text;

            headlines_lst.Items.Clear();

            results = await news.SearchNews(searchfilter);

            foreach (string s in results)
            {
                headlines_lst.Items.Add(s);
            }
        }
        private void searchSongs_btn_Click(object sender, EventArgs e)
        {
            songs_lst.Items.Clear();

            string selectedHeadline = headlines_lst.GetItemText(headlines_lst.SelectedItem);
            selectedHeadline = keywords.FindKeywords(selectedHeadline); 

            if (headlines_lst.Items.Count != 0)
            {
                if ((string)songSearchType_cmbx.SelectedItem == "Songs")
                {
                    foreach (var s in _spotify.search.SearchTracks(selectedHeadline.Substring(0, 12)))
                    {
                        songs_lst.Items.Add(s);
                    }
                }
                else if ((string)songSearchType_cmbx.SelectedItem == "Albums")
                {
                    foreach (var s in _spotify.search.SearchAlbums(selectedHeadline.Substring(0, 12)))
                    {
                        songs_lst.Items.Add(s);
                    }
                }
                else if ((string)songSearchType_cmbx.SelectedItem == "Artists")
                {
                    foreach (var s in _spotify.search.SearchArtists(selectedHeadline.Substring(0, 12)))
                    {
                        songs_lst.Items.Add(s);
                    }
                }
                else
                {
                    foreach (var s in _spotify.search.SearchPlaylists(selectedHeadline.Substring(0, 12)))
                    {
                        songs_lst.Items.Add(s);
                    }
                }
            }
            
        }
        
        private void headlines_lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void songs_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void songSearchType_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newsCategory_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void headlineSearch_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
