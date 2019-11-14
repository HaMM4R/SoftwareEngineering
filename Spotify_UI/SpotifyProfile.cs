using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

namespace Spotify_UI
{
    public class SpotifyProfile
    {
        private SpotifyWebAPI _spotify;
        private PrivateProfile profile;

        public SpotifySearching search; 

        public SpotifyProfile(SpotifyWebAPI s)
        {
            _spotify = s;
            DisplayProfileInformation();
            DisplayPlaylists();

            search = new SpotifySearching(_spotify, profile); 
        }

        public void DisplayProfileInformation()
        {
            profile = _spotify.GetPrivateProfile();
            string name = string.IsNullOrEmpty(profile.DisplayName) ? profile.Id : profile.DisplayName;
            Console.WriteLine($"Hello there, {name}!");
        }

        public List<string> DisplayPlaylists()
        {
            List<string> plList = new List<string>(); 
            Paging<SimplePlaylist> playlists = _spotify.GetUserPlaylists(profile.Id);
            playlists.Items.ForEach(playlist =>
            {
                plList.Add($"- {playlist.Name}"); 
            });

            return plList; 
        }
    }
}
