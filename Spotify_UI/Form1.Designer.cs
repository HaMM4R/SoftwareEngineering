namespace Spotify_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchSongs_btn = new System.Windows.Forms.Button();
            this.headlines_lst = new System.Windows.Forms.ListBox();
            this.songs_lst = new System.Windows.Forms.ListBox();
            this.playSong_btn = new System.Windows.Forms.Button();
            this.playlistToggle_chkbx = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.newsCategory_cmbx = new System.Windows.Forms.ComboBox();
            this.newsSearch_btn = new System.Windows.Forms.Button();
            this.songSearchType_cmbx = new System.Windows.Forms.ComboBox();
            // 
            // searchSongs_btn
            // 
            this.searchSongs_btn.Location = new System.Drawing.Point(150, 381);
            this.searchSongs_btn.Name = "searchSongs_btn";
            this.searchSongs_btn.Size = new System.Drawing.Size(95, 55);
            this.searchSongs_btn.TabIndex = 0;
            this.searchSongs_btn.Text = "Suggest Songs";
            this.searchSongs_btn.UseVisualStyleBackColor = true;
            this.searchSongs_btn.Click += new System.EventHandler(this.searchSongs_btn_Click);
            // 
            // headlines_lst
            // 
            this.headlines_lst.FormattingEnabled = true;
            this.headlines_lst.ItemHeight = 15;
            this.headlines_lst.Location = new System.Drawing.Point(15, 35);
            this.headlines_lst.Name = "headlines_lst";
            this.headlines_lst.Size = new System.Drawing.Size(229, 259);
            this.headlines_lst.TabIndex = 1;
            this.headlines_lst.SelectedIndexChanged += new System.EventHandler(this.headlines_lst_SelectedIndexChanged);
            // 
            // songs_lst
            // 
            this.songs_lst.FormattingEnabled = true;
            this.songs_lst.ItemHeight = 15;
            this.songs_lst.Location = new System.Drawing.Point(311, 35);
            this.songs_lst.Name = "songs_lst";
            this.songs_lst.Size = new System.Drawing.Size(239, 259);
            this.songs_lst.TabIndex = 2;
            this.songs_lst.SelectedIndexChanged += new System.EventHandler(this.songs_lst_SelectedIndexChanged);
            // 
            // playSong_btn
            // 
            this.playSong_btn.Location = new System.Drawing.Point(415, 381);
            this.playSong_btn.Name = "playSong_btn";
            this.playSong_btn.Size = new System.Drawing.Size(135, 54);
            this.playSong_btn.TabIndex = 0;
            this.playSong_btn.Text = "Play";
            this.playSong_btn.UseVisualStyleBackColor = true;
            this.playSong_btn.Click += new System.EventHandler(this.searchSongs_btn_Click);
            // 
            // playlistToggle_chkbx
            // 
            this.playlistToggle_chkbx.AutoSize = true;
            this.playlistToggle_chkbx.Location = new System.Drawing.Point(429, 300);
            this.playlistToggle_chkbx.Name = "playlistToggle_chkbx";
            this.playlistToggle_chkbx.Size = new System.Drawing.Size(127, 19);
            this.playlistToggle_chkbx.TabIndex = 3;
            this.playlistToggle_chkbx.Text = "Search for PlayLists";
            this.playlistToggle_chkbx.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-287, -79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // newsCategory_cmbx
            // 
            this.newsCategory_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newsCategory_cmbx.FormattingEnabled = true;
            this.newsCategory_cmbx.Location = new System.Drawing.Point(123, 6);
            this.newsCategory_cmbx.Name = "newsCategory_cmbx";
            this.newsCategory_cmbx.Size = new System.Drawing.Size(121, 23);
            this.newsCategory_cmbx.TabIndex = 5;
            // 
            // newsSearch_btn
            // 
            this.newsSearch_btn.Location = new System.Drawing.Point(15, 381);
            this.newsSearch_btn.Name = "newsSearch_btn";
            this.newsSearch_btn.Size = new System.Drawing.Size(95, 55);
            this.newsSearch_btn.TabIndex = 6;
            this.newsSearch_btn.Text = "Find Headline";
            this.newsSearch_btn.UseVisualStyleBackColor = true;
            // 
            // songSearchType_cmbx
            // 
            this.songSearchType_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.songSearchType_cmbx.FormattingEnabled = true;
            this.songSearchType_cmbx.Location = new System.Drawing.Point(429, 6);
            this.songSearchType_cmbx.Name = "songSearchType_cmbx";
            this.songSearchType_cmbx.Size = new System.Drawing.Size(121, 23);
            this.songSearchType_cmbx.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.songSearchType_cmbx);
            this.Controls.Add(this.newsSearch_btn);
            this.Controls.Add(this.newsCategory_cmbx);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.playlistToggle_chkbx);
            this.Controls.Add(this.songs_lst);
            this.Controls.Add(this.headlines_lst);
            this.Controls.Add(this.searchSongs_btn);
            this.Controls.Add(this.playSong_btn);
            this.Name = "Form1";
            this.Text = "Form1";

        }

        #endregion

        private System.Windows.Forms.Button searchSongs_btn;
        private System.Windows.Forms.ListBox headlines_lst;
        private System.Windows.Forms.ListBox songs_lst;
        private System.Windows.Forms.Button playSong_btn;
        private System.Windows.Forms.CheckBox playlistToggle_chkbx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox newsCategory_cmbx;
        private System.Windows.Forms.Button newsSearch_btn;
        private System.Windows.Forms.ComboBox songSearchType_cmbx;
    }
}

