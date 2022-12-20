namespace Musicplayer
{
    partial class uc_songlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_songlist));
            this.songname = new System.Windows.Forms.Label();
            this.artist = new System.Windows.Forms.Label();
            this.compose = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.coverpic = new System.Windows.Forms.PictureBox();
            this.lyric = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.Label();
            this.like = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coverpic)).BeginInit();
            this.SuspendLayout();
            // 
            // songname
            // 
            this.songname.AutoSize = true;
            this.songname.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songname.ForeColor = System.Drawing.Color.White;
            this.songname.Location = new System.Drawing.Point(104, 11);
            this.songname.Name = "songname";
            this.songname.Size = new System.Drawing.Size(117, 25);
            this.songname.TabIndex = 0;
            this.songname.Text = "Song name";
            // 
            // artist
            // 
            this.artist.AutoSize = true;
            this.artist.Font = new System.Drawing.Font("Bahnschrift Light", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artist.ForeColor = System.Drawing.Color.White;
            this.artist.Location = new System.Drawing.Point(105, 47);
            this.artist.Name = "artist";
            this.artist.Size = new System.Drawing.Size(46, 18);
            this.artist.TabIndex = 0;
            this.artist.Text = "Artist";
            // 
            // compose
            // 
            this.compose.AutoSize = true;
            this.compose.Font = new System.Drawing.Font("Bahnschrift", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compose.ForeColor = System.Drawing.Color.White;
            this.compose.Location = new System.Drawing.Point(370, 29);
            this.compose.Name = "compose";
            this.compose.Size = new System.Drawing.Size(88, 21);
            this.compose.TabIndex = 0;
            this.compose.Text = "Composer";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Bahnschrift", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(689, 29);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(41, 21);
            this.time.TabIndex = 0;
            this.time.Text = "0:00";
            // 
            // coverpic
            // 
            this.coverpic.Image = ((System.Drawing.Image)(resources.GetObject("coverpic.Image")));
            this.coverpic.Location = new System.Drawing.Point(29, 10);
            this.coverpic.Name = "coverpic";
            this.coverpic.Size = new System.Drawing.Size(60, 60);
            this.coverpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverpic.TabIndex = 1;
            this.coverpic.TabStop = false;
            // 
            // lyric
            // 
            this.lyric.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.223881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lyric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lyric.Location = new System.Drawing.Point(529, 10);
            this.lyric.Name = "lyric";
            this.lyric.Size = new System.Drawing.Size(30, 55);
            this.lyric.TabIndex = 2;
            this.lyric.Text = "label1";
            // 
            // link
            // 
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.223881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.link.Location = new System.Drawing.Point(580, 10);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(30, 26);
            this.link.TabIndex = 2;
            this.link.Text = "label1";
            // 
            // like
            // 
            this.like.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.223881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.like.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.like.Location = new System.Drawing.Point(580, 39);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(30, 26);
            this.like.TabIndex = 2;
            this.like.Text = "0";
            // 
            // uc_songlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.like);
            this.Controls.Add(this.link);
            this.Controls.Add(this.lyric);
            this.Controls.Add(this.coverpic);
            this.Controls.Add(this.time);
            this.Controls.Add(this.compose);
            this.Controls.Add(this.artist);
            this.Controls.Add(this.songname);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_songlist";
            this.Size = new System.Drawing.Size(786, 80);
            this.Click += new System.EventHandler(this.uc_songlist_Click);
            ((System.ComponentModel.ISupportInitialize)(this.coverpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label songname;
        public System.Windows.Forms.Label artist;
        public System.Windows.Forms.PictureBox coverpic;
        public System.Windows.Forms.Label compose;
        public System.Windows.Forms.Label time;
        public System.Windows.Forms.Label lyric;
        public System.Windows.Forms.Label link;
        public System.Windows.Forms.Label like;
    }
}
