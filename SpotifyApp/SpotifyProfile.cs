using System;
using System.Collections.Generic;
using System.Text;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

namespace SpotifyApp
{
    public class SpotifyProfile
    {
        private SpotifyWebAPI _spotify;
        private PrivateProfile profile;

        public SpotifyProfile(SpotifyWebAPI s)
        {
            _spotify = s;
            DisplayProfileInformation();
            DisplayPlaylists();

            SpotifySearching search = new SpotifySearching(_spotify, profile); 
        }

        public void DisplayProfileInformation()
        {
            profile = _spotify.GetPrivateProfile();
            string name = string.IsNullOrEmpty(profile.DisplayName) ? profile.Id : profile.DisplayName;
            Console.WriteLine($"Hello there, {name}!");
        }

        public void DisplayPlaylists()
        {
            Console.WriteLine("Your playlists:");
            Paging<SimplePlaylist> playlists = _spotify.GetUserPlaylists(profile.Id);
            playlists.Items.ForEach(playlist =>
            {
                Console.WriteLine($"- {playlist.Name}");
            });
        }
    }
}
