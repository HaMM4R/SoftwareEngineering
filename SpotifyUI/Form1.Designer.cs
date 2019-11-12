namespace SpotifyUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchSpotify_btn = new System.Windows.Forms.Button();
            this.headlines_list = new System.Windows.Forms.ListBox();
            this.songs_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // searchSpotify_btn
            // 
            this.searchSpotify_btn.Location = new System.Drawing.Point(12, 388);
            this.searchSpotify_btn.Name = "searchSpotify_btn";
            this.searchSpotify_btn.Size = new System.Drawing.Size(113, 50);
            this.searchSpotify_btn.TabIndex = 0;
            this.searchSpotify_btn.Text = "Suggest Songs";
            this.searchSpotify_btn.UseVisualStyleBackColor = true;
            this.searchSpotify_btn.Click += new System.EventHandler(this.searchSpotify_btn_Click);
            // 
            // headlines_list
            // 
            this.headlines_list.FormattingEnabled = true;
            this.headlines_list.Location = new System.Drawing.Point(12, 12);
            this.headlines_list.Name = "headlines_list";
            this.headlines_list.Size = new System.Drawing.Size(185, 186);
            this.headlines_list.TabIndex = 1;
            this.headlines_list.SelectedIndexChanged += new System.EventHandler(this.headlines_list_SelectedIndexChanged);
            // 
            // songs_list
            // 
            this.songs_list.FormattingEnabled = true;
            this.songs_list.Location = new System.Drawing.Point(234, 12);
            this.songs_list.Name = "songs_list";
            this.songs_list.Size = new System.Drawing.Size(173, 186);
            this.songs_list.TabIndex = 2;
            this.songs_list.SelectedIndexChanged += new System.EventHandler(this.songs_list_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.songs_list);
            this.Controls.Add(this.headlines_list);
            this.Controls.Add(this.searchSpotify_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchSpotify_btn;
        private System.Windows.Forms.ListBox headlines_list;
        private System.Windows.Forms.ListBox songs_list;
    }
}

