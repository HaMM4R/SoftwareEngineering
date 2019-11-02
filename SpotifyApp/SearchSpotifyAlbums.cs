using System;
using System.Collections.Generic;
using System.Text;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

namespace SpotifyApp
{
    public class SearchSpotifyAlbums
    {
        SpotifyWebAPI _spotify;
        public SearchSpotifyAlbums(SpotifyWebAPI s)
        {
            _spotify = s;
            DisplayProfileInformation(); 
        }

        void DisplayProfileInformation()
        {
            PrivateProfile profile = _spotify.GetPrivateProfile();
            string name = string.IsNullOrEmpty(profile.DisplayName) ? profile.Id : profile.DisplayName;
            Console.WriteLine($"Hello there, {name}!");
        }

        void DisplayPlaylists()
        {

        }
    }
}
