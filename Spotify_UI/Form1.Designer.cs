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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.newsSearch_btn = new System.Windows.Forms.Button();
            this.songSearchType_cmbx = new System.Windows.Forms.ComboBox();
            this.headlineSearch_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.headlines_lst.Size = new System.Drawing.Size(267, 289);
            this.headlines_lst.TabIndex = 1;
            this.headlines_lst.SelectedIndexChanged += new System.EventHandler(this.headlines_lst_SelectedIndexChanged);
            // 
            // songs_lst
            // 
            this.songs_lst.FormattingEnabled = true;
            this.songs_lst.ItemHeight = 15;
            this.songs_lst.Location = new System.Drawing.Point(306, 35);
            this.songs_lst.Name = "songs_lst";
            this.songs_lst.Size = new System.Drawing.Size(244, 289);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-287, -79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // newsSearch_btn
            // 
            this.newsSearch_btn.Location = new System.Drawing.Point(15, 381);
            this.newsSearch_btn.Name = "newsSearch_btn";
            this.newsSearch_btn.Size = new System.Drawing.Size(95, 55);
            this.newsSearch_btn.TabIndex = 6;
            this.newsSearch_btn.Text = "Find Headline";
            this.newsSearch_btn.UseVisualStyleBackColor = true;
            this.newsSearch_btn.Click += new System.EventHandler(this.newsSearch_btn_Click);
            // 
            // songSearchType_cmbx
            // 
            this.songSearchType_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.songSearchType_cmbx.FormattingEnabled = true;
            this.songSearchType_cmbx.Location = new System.Drawing.Point(429, 6);
            this.songSearchType_cmbx.Name = "songSearchType_cmbx";
            this.songSearchType_cmbx.Size = new System.Drawing.Size(121, 23);
            this.songSearchType_cmbx.TabIndex = 7;
            this.songSearchType_cmbx.SelectedIndexChanged += new System.EventHandler(this.songSearchType_cmbx_SelectedIndexChanged);
            // 
            // headlineSearch_txt
            // 
            this.headlineSearch_txt.Location = new System.Drawing.Point(160, 6);
            this.headlineSearch_txt.Name = "headlineSearch_txt";
            this.headlineSearch_txt.Size = new System.Drawing.Size(122, 23);
            this.headlineSearch_txt.TabIndex = 8;
            this.headlineSearch_txt.TextChanged += new System.EventHandler(this.headlineSearch_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1089, -81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1084, -71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search Filter ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Spotify Search Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headlineSearch_txt);
            this.Controls.Add(this.songSearchType_cmbx);
            this.Controls.Add(this.newsSearch_btn);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button newsSearch_btn;
        private System.Windows.Forms.ComboBox songSearchType_cmbx;
        private System.Windows.Forms.TextBox headlineSearch_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

