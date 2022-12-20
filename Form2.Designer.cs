using System.Windows.Forms;

namespace Musicplayer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pan_navbar = new System.Windows.Forms.Panel();
            this.nav_btn_search = new System.Windows.Forms.Button();
            this.pan_nav_his = new System.Windows.Forms.Button();
            this.pan_nav_btt_playlist = new System.Windows.Forms.Button();
            this.pan_nav_btt_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.Label();
            this.a_pan_playlist = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.a_type = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.a_pan_visual_banner = new System.Windows.Forms.PictureBox();
            this.lab_songname = new System.Windows.Forms.Label();
            this.lab_artist = new System.Windows.Forms.Label();
            this.c_pan_detail = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.c_flowpan_cmt = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.c_pan_lyric = new System.Windows.Forms.Panel();
            this.c_lyrics = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c_download = new System.Windows.Forms.PictureBox();
            this.c_play = new System.Windows.Forms.PictureBox();
            this.c_like = new System.Windows.Forms.PictureBox();
            this.c_add = new System.Windows.Forms.PictureBox();
            this.c_link = new System.Windows.Forms.Label();
            this.c_artist = new System.Windows.Forms.Label();
            this.c_songname = new System.Windows.Forms.Label();
            this.c_picb_cover = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_his = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.picb_songcover = new System.Windows.Forms.PictureBox();
            this.pan_home = new System.Windows.Forms.Panel();
            this.b_pan_myplaylist = new System.Windows.Forms.PictureBox();
            this.b_pan_liked = new System.Windows.Forms.PictureBox();
            this.b_home_vpop = new System.Windows.Forms.PictureBox();
            this.b_home_viral = new System.Windows.Forms.PictureBox();
            this.b_pan_welcome = new System.Windows.Forms.Label();
            this.pan_navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.a_pan_playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_pan_visual_banner)).BeginInit();
            this.c_pan_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.c_pan_lyric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_picb_cover)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_songcover)).BeginInit();
            this.pan_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_pan_myplaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_pan_liked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_home_vpop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_home_viral)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_navbar
            // 
            this.pan_navbar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pan_navbar.Controls.Add(this.nav_btn_search);
            this.pan_navbar.Controls.Add(this.pan_nav_his);
            this.pan_navbar.Controls.Add(this.pan_nav_btt_playlist);
            this.pan_navbar.Controls.Add(this.pan_nav_btt_home);
            this.pan_navbar.Controls.Add(this.pictureBox1);
            this.pan_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_navbar.Location = new System.Drawing.Point(0, 0);
            this.pan_navbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_navbar.Name = "pan_navbar";
            this.pan_navbar.Size = new System.Drawing.Size(340, 767);
            this.pan_navbar.TabIndex = 0;
            this.pan_navbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_navbar_Paint);
            // 
            // nav_btn_search
            // 
            this.nav_btn_search.BackColor = System.Drawing.Color.Black;
            this.nav_btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_btn_search.FlatAppearance.BorderSize = 0;
            this.nav_btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_btn_search.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.nav_btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nav_btn_search.Location = new System.Drawing.Point(0, 509);
            this.nav_btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nav_btn_search.Name = "nav_btn_search";
            this.nav_btn_search.Size = new System.Drawing.Size(340, 58);
            this.nav_btn_search.TabIndex = 2;
            this.nav_btn_search.Text = "🔍   Search";
            this.nav_btn_search.UseVisualStyleBackColor = false;
            this.nav_btn_search.Click += new System.EventHandler(this.nav_btn_search_Click);
            // 
            // pan_nav_his
            // 
            this.pan_nav_his.BackColor = System.Drawing.Color.Black;
            this.pan_nav_his.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_nav_his.FlatAppearance.BorderSize = 0;
            this.pan_nav_his.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pan_nav_his.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_nav_his.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pan_nav_his.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pan_nav_his.Location = new System.Drawing.Point(0, 425);
            this.pan_nav_his.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_nav_his.Name = "pan_nav_his";
            this.pan_nav_his.Size = new System.Drawing.Size(340, 58);
            this.pan_nav_his.TabIndex = 2;
            this.pan_nav_his.Text = "🕔   History";
            this.pan_nav_his.UseVisualStyleBackColor = false;
            this.pan_nav_his.Click += new System.EventHandler(this.pan_nav_his_Click);
            // 
            // pan_nav_btt_playlist
            // 
            this.pan_nav_btt_playlist.BackColor = System.Drawing.Color.Black;
            this.pan_nav_btt_playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_nav_btt_playlist.FlatAppearance.BorderSize = 0;
            this.pan_nav_btt_playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pan_nav_btt_playlist.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_nav_btt_playlist.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pan_nav_btt_playlist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pan_nav_btt_playlist.Location = new System.Drawing.Point(0, 341);
            this.pan_nav_btt_playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_nav_btt_playlist.Name = "pan_nav_btt_playlist";
            this.pan_nav_btt_playlist.Size = new System.Drawing.Size(340, 58);
            this.pan_nav_btt_playlist.TabIndex = 1;
            this.pan_nav_btt_playlist.Text = "〣    Playlist";
            this.pan_nav_btt_playlist.UseVisualStyleBackColor = false;
            this.pan_nav_btt_playlist.Click += new System.EventHandler(this.b_pan_myplaylist_Click);
            // 
            // pan_nav_btt_home
            // 
            this.pan_nav_btt_home.BackColor = System.Drawing.Color.Black;
            this.pan_nav_btt_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_nav_btt_home.FlatAppearance.BorderSize = 0;
            this.pan_nav_btt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pan_nav_btt_home.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_nav_btt_home.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pan_nav_btt_home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pan_nav_btt_home.Location = new System.Drawing.Point(0, 256);
            this.pan_nav_btt_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_nav_btt_home.Name = "pan_nav_btt_home";
            this.pan_nav_btt_home.Size = new System.Drawing.Size(340, 58);
            this.pan_nav_btt_home.TabIndex = 0;
            this.pan_nav_btt_home.Text = "⌂    Home";
            this.pan_nav_btt_home.UseVisualStyleBackColor = false;
            this.pan_nav_btt_home.Click += new System.EventHandler(this.pan_nav_btt_home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Font = new System.Drawing.Font("Corbel", 24.1791F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(1172, -3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(47, 55);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "x";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close_btn.Click += new System.EventHandler(this.label1_Click);
            // 
            // a_pan_playlist
            // 
            this.a_pan_playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.a_pan_playlist.Controls.Add(this.pictureBox3);
            this.a_pan_playlist.Controls.Add(this.comboBox1);
            this.a_pan_playlist.Controls.Add(this.a_type);
            this.a_pan_playlist.Controls.Add(this.label5);
            this.a_pan_playlist.Controls.Add(this.label4);
            this.a_pan_playlist.Controls.Add(this.label1);
            this.a_pan_playlist.Controls.Add(this.flowLayoutPanel1);
            this.a_pan_playlist.Controls.Add(this.a_pan_visual_banner);
            this.a_pan_playlist.Location = new System.Drawing.Point(340, 0);
            this.a_pan_playlist.Name = "a_pan_playlist";
            this.a_pan_playlist.Size = new System.Drawing.Size(872, 710);
            this.a_pan_playlist.TabIndex = 5;
            this.a_pan_playlist.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Orange;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(323, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.98507F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Visible = false;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // a_type
            // 
            this.a_type.AutoSize = true;
            this.a_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.a_type.Location = new System.Drawing.Point(27, 267);
            this.a_type.Name = "a_type";
            this.a_type.Size = new System.Drawing.Size(44, 16);
            this.a_type.TabIndex = 3;
            this.a_type.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(712, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(397, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Composer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 297);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(809, 387);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // a_pan_visual_banner
            // 
            this.a_pan_visual_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a_pan_visual_banner.Image = global::Musicplayer.Properties.Resources.banner1;
            this.a_pan_visual_banner.Location = new System.Drawing.Point(0, -3);
            this.a_pan_visual_banner.Name = "a_pan_visual_banner";
            this.a_pan_visual_banner.Size = new System.Drawing.Size(872, 239);
            this.a_pan_visual_banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.a_pan_visual_banner.TabIndex = 0;
            this.a_pan_visual_banner.TabStop = false;
            // 
            // lab_songname
            // 
            this.lab_songname.AutoSize = true;
            this.lab_songname.Font = new System.Drawing.Font("Microsoft Tai Le", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_songname.ForeColor = System.Drawing.Color.White;
            this.lab_songname.Location = new System.Drawing.Point(409, 718);
            this.lab_songname.Name = "lab_songname";
            this.lab_songname.Size = new System.Drawing.Size(93, 18);
            this.lab_songname.TabIndex = 9;
            this.lab_songname.Text = "Choose song";
            this.lab_songname.TextChanged += new System.EventHandler(this.lab_songname_TextChanged);
            // 
            // lab_artist
            // 
            this.lab_artist.AutoSize = true;
            this.lab_artist.Font = new System.Drawing.Font("Microsoft Tai Le", 5.910448F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_artist.ForeColor = System.Drawing.Color.White;
            this.lab_artist.Location = new System.Drawing.Point(409, 740);
            this.lab_artist.Name = "lab_artist";
            this.lab_artist.Size = new System.Drawing.Size(36, 16);
            this.lab_artist.TabIndex = 9;
            this.lab_artist.Text = "None";
            // 
            // c_pan_detail
            // 
            this.c_pan_detail.Controls.Add(this.textBox1);
            this.c_pan_detail.Controls.Add(this.pictureBox2);
            this.c_pan_detail.Controls.Add(this.c_flowpan_cmt);
            this.c_pan_detail.Controls.Add(this.label3);
            this.c_pan_detail.Controls.Add(this.c_pan_lyric);
            this.c_pan_detail.Controls.Add(this.c_download);
            this.c_pan_detail.Controls.Add(this.c_play);
            this.c_pan_detail.Controls.Add(this.c_like);
            this.c_pan_detail.Controls.Add(this.c_add);
            this.c_pan_detail.Controls.Add(this.c_link);
            this.c_pan_detail.Controls.Add(this.c_artist);
            this.c_pan_detail.Controls.Add(this.c_songname);
            this.c_pan_detail.Controls.Add(this.c_picb_cover);
            this.c_pan_detail.Location = new System.Drawing.Point(340, 0);
            this.c_pan_detail.Name = "c_pan_detail";
            this.c_pan_detail.Size = new System.Drawing.Size(872, 710);
            this.c_pan_detail.TabIndex = 11;
            this.c_pan_detail.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(562, 645);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 29);
            this.textBox1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(818, 638);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // c_flowpan_cmt
            // 
            this.c_flowpan_cmt.AutoScroll = true;
            this.c_flowpan_cmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_flowpan_cmt.Location = new System.Drawing.Point(555, 286);
            this.c_flowpan_cmt.Name = "c_flowpan_cmt";
            this.c_flowpan_cmt.Size = new System.Drawing.Size(305, 346);
            this.c_flowpan_cmt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "<";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // c_pan_lyric
            // 
            this.c_pan_lyric.AutoScroll = true;
            this.c_pan_lyric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c_pan_lyric.Controls.Add(this.c_lyrics);
            this.c_pan_lyric.Controls.Add(this.label2);
            this.c_pan_lyric.Location = new System.Drawing.Point(30, 286);
            this.c_pan_lyric.Name = "c_pan_lyric";
            this.c_pan_lyric.Size = new System.Drawing.Size(505, 388);
            this.c_pan_lyric.TabIndex = 3;
            // 
            // c_lyrics
            // 
            this.c_lyrics.AutoSize = true;
            this.c_lyrics.Font = new System.Drawing.Font("Bahnschrift Light", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_lyrics.ForeColor = System.Drawing.Color.White;
            this.c_lyrics.Location = new System.Drawing.Point(13, 55);
            this.c_lyrics.Name = "c_lyrics";
            this.c_lyrics.Size = new System.Drawing.Size(75, 23);
            this.c_lyrics.TabIndex = 0;
            this.c_lyrics.Text = "AaBbCc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lyrics";
            // 
            // c_download
            // 
            this.c_download.Image = ((System.Drawing.Image)(resources.GetObject("c_download.Image")));
            this.c_download.Location = new System.Drawing.Point(257, 202);
            this.c_download.Name = "c_download";
            this.c_download.Size = new System.Drawing.Size(37, 34);
            this.c_download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c_download.TabIndex = 2;
            this.c_download.TabStop = false;
            this.c_download.Click += new System.EventHandler(this.c_download_Click);
            // 
            // c_play
            // 
            this.c_play.Image = ((System.Drawing.Image)(resources.GetObject("c_play.Image")));
            this.c_play.Location = new System.Drawing.Point(763, 192);
            this.c_play.Name = "c_play";
            this.c_play.Size = new System.Drawing.Size(46, 44);
            this.c_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c_play.TabIndex = 2;
            this.c_play.TabStop = false;
            this.c_play.Click += new System.EventHandler(this.c_play_Click);
            // 
            // c_like
            // 
            this.c_like.Image = ((System.Drawing.Image)(resources.GetObject("c_like.Image")));
            this.c_like.Location = new System.Drawing.Point(697, 192);
            this.c_like.Name = "c_like";
            this.c_like.Size = new System.Drawing.Size(46, 44);
            this.c_like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c_like.TabIndex = 2;
            this.c_like.TabStop = false;
            this.c_like.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // c_add
            // 
            this.c_add.Image = ((System.Drawing.Image)(resources.GetObject("c_add.Image")));
            this.c_add.Location = new System.Drawing.Point(634, 192);
            this.c_add.Name = "c_add";
            this.c_add.Size = new System.Drawing.Size(46, 44);
            this.c_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c_add.TabIndex = 2;
            this.c_add.TabStop = false;
            this.c_add.Click += new System.EventHandler(this.c_add_Click);
            // 
            // c_link
            // 
            this.c_link.AutoSize = true;
            this.c_link.Font = new System.Drawing.Font("Bahnschrift Light", 5.970149F);
            this.c_link.ForeColor = System.Drawing.Color.White;
            this.c_link.Location = new System.Drawing.Point(257, 72);
            this.c_link.Name = "c_link";
            this.c_link.Size = new System.Drawing.Size(37, 14);
            this.c_link.TabIndex = 1;
            this.c_link.Text = "Artist";
            // 
            // c_artist
            // 
            this.c_artist.AutoSize = true;
            this.c_artist.Font = new System.Drawing.Font("Bahnschrift Light", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_artist.ForeColor = System.Drawing.Color.White;
            this.c_artist.Location = new System.Drawing.Point(250, 155);
            this.c_artist.Name = "c_artist";
            this.c_artist.Size = new System.Drawing.Size(83, 33);
            this.c_artist.TabIndex = 1;
            this.c_artist.Text = "Artist";
            // 
            // c_songname
            // 
            this.c_songname.AutoSize = true;
            this.c_songname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8806F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_songname.ForeColor = System.Drawing.Color.White;
            this.c_songname.Location = new System.Drawing.Point(250, 95);
            this.c_songname.Name = "c_songname";
            this.c_songname.Size = new System.Drawing.Size(421, 44);
            this.c_songname.TabIndex = 1;
            this.c_songname.Text = "Buoc qua mua co don";
            // 
            // c_picb_cover
            // 
            this.c_picb_cover.Image = global::Musicplayer.Properties.Resources.img1;
            this.c_picb_cover.Location = new System.Drawing.Point(28, 61);
            this.c_picb_cover.Name = "c_picb_cover";
            this.c_picb_cover.Size = new System.Drawing.Size(183, 175);
            this.c_picb_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c_picb_cover.TabIndex = 0;
            this.c_picb_cover.TabStop = false;
            this.c_picb_cover.Click += new System.EventHandler(this.c_picb_cover_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lab_his);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(231, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 420);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // lab_his
            // 
            this.lab_his.AutoSize = true;
            this.lab_his.Font = new System.Drawing.Font("Microsoft Tai Le", 13.20895F);
            this.lab_his.ForeColor = System.Drawing.Color.DarkGray;
            this.lab_his.Location = new System.Drawing.Point(50, 94);
            this.lab_his.Name = "lab_his";
            this.lab_his.Size = new System.Drawing.Size(75, 31);
            this.lab_his.TabIndex = 7;
            this.lab_his.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Recently played";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Corbel", 24.1791F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(684, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 55);
            this.label6.TabIndex = 5;
            this.label6.Text = "x";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(537, 716);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(675, 47);
            this.player.TabIndex = 7;
            // 
            // picb_songcover
            // 
            this.picb_songcover.Image = ((System.Drawing.Image)(resources.GetObject("picb_songcover.Image")));
            this.picb_songcover.Location = new System.Drawing.Point(346, 713);
            this.picb_songcover.Name = "picb_songcover";
            this.picb_songcover.Size = new System.Drawing.Size(56, 50);
            this.picb_songcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_songcover.TabIndex = 8;
            this.picb_songcover.TabStop = false;
            // 
            // pan_home
            // 
            this.pan_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_home.BackgroundImage")));
            this.pan_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pan_home.Controls.Add(this.b_pan_myplaylist);
            this.pan_home.Controls.Add(this.b_pan_liked);
            this.pan_home.Controls.Add(this.b_home_vpop);
            this.pan_home.Controls.Add(this.b_home_viral);
            this.pan_home.Controls.Add(this.b_pan_welcome);
            this.pan_home.Location = new System.Drawing.Point(340, 0);
            this.pan_home.Name = "pan_home";
            this.pan_home.Size = new System.Drawing.Size(872, 710);
            this.pan_home.TabIndex = 10;
            // 
            // b_pan_myplaylist
            // 
            this.b_pan_myplaylist.Image = ((System.Drawing.Image)(resources.GetObject("b_pan_myplaylist.Image")));
            this.b_pan_myplaylist.Location = new System.Drawing.Point(667, 350);
            this.b_pan_myplaylist.Margin = new System.Windows.Forms.Padding(20);
            this.b_pan_myplaylist.Name = "b_pan_myplaylist";
            this.b_pan_myplaylist.Size = new System.Drawing.Size(170, 300);
            this.b_pan_myplaylist.TabIndex = 2;
            this.b_pan_myplaylist.TabStop = false;
            this.b_pan_myplaylist.Click += new System.EventHandler(this.b_pan_myplaylist_Click);
            // 
            // b_pan_liked
            // 
            this.b_pan_liked.Image = ((System.Drawing.Image)(resources.GetObject("b_pan_liked.Image")));
            this.b_pan_liked.Location = new System.Drawing.Point(452, 350);
            this.b_pan_liked.Margin = new System.Windows.Forms.Padding(20);
            this.b_pan_liked.Name = "b_pan_liked";
            this.b_pan_liked.Size = new System.Drawing.Size(170, 300);
            this.b_pan_liked.TabIndex = 2;
            this.b_pan_liked.TabStop = false;
            this.b_pan_liked.Click += new System.EventHandler(this.b_pan_liked_Click);
            // 
            // b_home_vpop
            // 
            this.b_home_vpop.Image = ((System.Drawing.Image)(resources.GetObject("b_home_vpop.Image")));
            this.b_home_vpop.Location = new System.Drawing.Point(240, 350);
            this.b_home_vpop.Margin = new System.Windows.Forms.Padding(20);
            this.b_home_vpop.Name = "b_home_vpop";
            this.b_home_vpop.Size = new System.Drawing.Size(170, 300);
            this.b_home_vpop.TabIndex = 2;
            this.b_home_vpop.TabStop = false;
            this.b_home_vpop.Click += new System.EventHandler(this.b_home_vpop_Click);
            // 
            // b_home_viral
            // 
            this.b_home_viral.Image = ((System.Drawing.Image)(resources.GetObject("b_home_viral.Image")));
            this.b_home_viral.Location = new System.Drawing.Point(30, 350);
            this.b_home_viral.Margin = new System.Windows.Forms.Padding(20);
            this.b_home_viral.Name = "b_home_viral";
            this.b_home_viral.Size = new System.Drawing.Size(170, 300);
            this.b_home_viral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b_home_viral.TabIndex = 2;
            this.b_home_viral.TabStop = false;
            this.b_home_viral.Click += new System.EventHandler(this.b_home_viral_Click);
            // 
            // b_pan_welcome
            // 
            this.b_pan_welcome.AutoSize = true;
            this.b_pan_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.b_pan_welcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pan_welcome.ForeColor = System.Drawing.Color.White;
            this.b_pan_welcome.Location = new System.Drawing.Point(275, 280);
            this.b_pan_welcome.Name = "b_pan_welcome";
            this.b_pan_welcome.Size = new System.Drawing.Size(387, 34);
            this.b_pan_welcome.TabIndex = 1;
            this.b_pan_welcome.Text = "Play any song on demand";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1212, 767);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.lab_artist);
            this.Controls.Add(this.lab_songname);
            this.Controls.Add(this.picb_songcover);
            this.Controls.Add(this.player);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_navbar);
            this.Controls.Add(this.c_pan_detail);
            this.Controls.Add(this.a_pan_playlist);
            this.Controls.Add(this.pan_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pan_navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.a_pan_playlist.ResumeLayout(false);
            this.a_pan_playlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_pan_visual_banner)).EndInit();
            this.c_pan_detail.ResumeLayout(false);
            this.c_pan_detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.c_pan_lyric.ResumeLayout(false);
            this.c_pan_lyric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_picb_cover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_songcover)).EndInit();
            this.pan_home.ResumeLayout(false);
            this.pan_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_pan_myplaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_pan_liked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_home_vpop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_home_viral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pan_navbar;
        private Button pan_nav_btt_home;
        private Button pan_nav_btt_playlist;
        private Button pan_nav_his;
        private PictureBox pictureBox1;
        private Label close_btn;
        private Panel a_pan_playlist;
        private PictureBox a_pan_visual_banner;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private PictureBox picb_songcover;
        private Label lab_songname;
        private Label lab_artist;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pan_home;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label b_pan_welcome;
        private PictureBox b_pan_myplaylist;
        private PictureBox b_pan_liked;
        private PictureBox b_home_vpop;
        private PictureBox b_home_viral;
        private Panel c_pan_detail;
        private PictureBox c_add;
        private Label c_artist;
        private Label c_songname;
        private PictureBox c_picb_cover;
        private PictureBox c_download;
        private PictureBox c_play;
        private PictureBox c_like;
        private Panel c_pan_lyric;
        private Label c_lyrics;
        private Label label2;
        private Label label3;
        private Label c_link;
        private FlowLayoutPanel c_flowpan_cmt;
        private PictureBox pictureBox2;
        private Label a_type;
        private TextBox textBox1;
        private Panel panel1;
        private Label lab_his;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
        private Button nav_btn_search;
    }
}