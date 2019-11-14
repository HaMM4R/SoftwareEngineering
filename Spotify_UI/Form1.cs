using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Spotify_UI
{
    public partial class Form1 : Form
    {
        private SpotifyProfile _spotify; 
        public Form1(SpotifyProfile s)
        {
            _spotify = s; 
            InitializeComponent();
        }

        private void searchSongs_btn_Click(object sender, EventArgs e)
        {
            foreach(string s in _spotify.search.SearchPlaylists("Brexit"))
            {
                songs_lst.Items.Add(s);
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
