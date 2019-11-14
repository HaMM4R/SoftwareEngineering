using System;
using System.Collections.Generic;
using System.Text;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

namespace Spotify_UI
{
    class SpotifySearching
    {
        private SpotifyWebAPI _spotify;
        private PrivateProfile _profile; 
        public SpotifySearching(SpotifyWebAPI spotify, PrivateProfile profile)
        {
            _spotify = spotify; 
            _profile = profile;
            SearchAlbums("Queen");
            SearchArtists("Nirvana");
            //SearchPlaylists("Queen");
            SearchTracks("Cherubrock");
        }

        void SearchAlbums(string s)
        {
            SearchItem search = _spotify.SearchItemsEscaped(s, SearchType.Album);
            Paging<SimpleAlbum> albums = search.Albums;
            albums.Items.ForEach(item => Console.WriteLine(item.Name));
        }

        void SearchArtists(string s)
        {
            SearchItem search = _spotify.SearchItemsEscaped(s, SearchType.Artist);
            Paging<FullArtist> artist = search.Artists;
            artist.Items.ForEach(item => Console.WriteLine(item.Name));
        }

        /*void SearchPlaylists(string s)
        {
            SearchItem search = _spotify.SearchItemsEscaped(s, SearchType.Playlist);
            Paging<SimplePlaylist> playlist = search.Playlists;
            playlist.Items.ForEach(item => Console.WriteLine(item.Name));
        }*/

        void SearchTracks(string s)
        {
            SearchItem search = _spotify.SearchItemsEscaped(s, SearchType.Track);
            Paging<FullTrack> track = search.Tracks;
            track.Items.ForEach(item => Console.WriteLine(item.Name));
        }
    }
}
