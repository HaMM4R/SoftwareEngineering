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
    static class Program
    {
        private static string _clientId = "a1e7f499b35149eb9b0300caf0e428bc"; //"";
        private static string _secretId = "0ebd63a52739483c98a2731aeaf00516"; //"";
        private static SpotifyWebAPI _spotify;

        static bool setup = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            test();
        }

        internal static void test()
        {
            SpotifyProfile profile;
            _clientId = string.IsNullOrEmpty(_clientId)
                ? Environment.GetEnvironmentVariable("SPOTIFY_CLIENT_ID")
                : _clientId;

            _secretId = string.IsNullOrEmpty(_secretId)
                ? Environment.GetEnvironmentVariable("SPOTIFY_SECRET_ID")
                : _secretId;


            AuthorizationCodeAuth auth =
                new AuthorizationCodeAuth(_clientId, _secretId, "http://localhost:4002", "http://localhost:4002",
                    Scope.PlaylistReadPrivate | Scope.PlaylistReadCollaborative);
            auth.AuthReceived += AuthOnAuthReceived;
            auth.Start();
            auth.OpenBrowser();

            while (!setup)
            {
                if (setup)
                {
                    profile = new SpotifyProfile(_spotify);
                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1(profile));
                }
            }

            Console.ReadLine();
            auth.Stop(0);
        }

        private static async void AuthOnAuthReceived(object sender, AuthorizationCode payload)
        {
            AuthorizationCodeAuth auth = (AuthorizationCodeAuth)sender;
            auth.Stop();

            Token token = await auth.ExchangeCode(payload.Code);
            SpotifyWebAPI api = new SpotifyWebAPI
            {
                AccessToken = token.AccessToken,
                TokenType = token.TokenType
            };

            _spotify = api;
            setup = true;
        }


        private static async void PrintUsefulData(SpotifyWebAPI api, string test)
        {
            PrivateProfile profile = await api.GetPrivateProfileAsync();
            string name = string.IsNullOrEmpty(profile.DisplayName) ? profile.Id : profile.DisplayName;
            Console.WriteLine($"Hello there, {name}!");
            Console.WriteLine("Your playlists:");
            Paging<SimplePlaylist> playlists = api.GetUserPlaylists(profile.Id);
            playlists.Items.ForEach(playlist =>
            {
                Console.WriteLine($" - {playlist.Tracks.Total} ");
                Console.WriteLine($"- {playlist.Name}");
            });
        }
    }
}
