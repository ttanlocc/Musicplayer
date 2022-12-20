namespace Musicplayer
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.pan_navbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pan_nav_btt_playlist = new System.Windows.Forms.Button();
            this.pan_nav_btt_home = new System.Windows.Forms.Button();
            this.pan_navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Corbel", 24.1791F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1821, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pan_navbar
            // 
            this.pan_navbar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pan_navbar.Controls.Add(this.pictureBox1);
            this.pan_navbar.Controls.Add(this.button2);
            this.pan_navbar.Controls.Add(this.button1);
            this.pan_navbar.Controls.Add(this.pan_nav_btt_playlist);
            this.pan_navbar.Controls.Add(this.pan_nav_btt_home);
            this.pan_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_navbar.Location = new System.Drawing.Point(0, 0);
            this.pan_navbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_navbar.Name = "pan_navbar";
            this.pan_navbar.Size = new System.Drawing.Size(340, 976);
            this.pan_navbar.TabIndex = 5;
            this.pan_navbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_navbar_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(-2, 510);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "      🔎   Search";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(-2, 425);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "      🎶   Genres";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pan_nav_btt_playlist
            // 
            this.pan_nav_btt_playlist.BackColor = System.Drawing.Color.Black;
            this.pan_nav_btt_playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_nav_btt_playlist.FlatAppearance.BorderSize = 0;
            this.pan_nav_btt_playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pan_nav_btt_playlist.Font = new System.Drawing.Font("Segoe UI", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_nav_btt_playlist.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pan_nav_btt_playlist.Location = new System.Drawing.Point(-2, 341);
            this.pan_nav_btt_playlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_nav_btt_playlist.Name = "pan_nav_btt_playlist";
            this.pan_nav_btt_playlist.Size = new System.Drawing.Size(340, 58);
            this.pan_nav_btt_playlist.TabIndex = 1;
            this.pan_nav_btt_playlist.Text = "      〣    Playlist";
            this.pan_nav_btt_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pan_nav_btt_playlist.UseVisualStyleBackColor = false;
            // 
            // pan_nav_btt_home
            // 
            this.pan_nav_btt_home.BackColor = System.Drawing.Color.Black;
            this.pan_nav_btt_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_nav_btt_home.FlatAppearance.BorderSize = 0;
            this.pan_nav_btt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pan_nav_btt_home.Font = new System.Drawing.Font("Segoe UI", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_nav_btt_home.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pan_nav_btt_home.Location = new System.Drawing.Point(-2, 256);
            this.pan_nav_btt_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_nav_btt_home.Name = "pan_nav_btt_home";
            this.pan_nav_btt_home.Size = new System.Drawing.Size(340, 58);
            this.pan_nav_btt_home.TabIndex = 0;
            this.pan_nav_btt_home.Text = "       ⌂    Home";
            this.pan_nav_btt_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pan_nav_btt_home.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1880, 976);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan_navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pan_navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_navbar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pan_nav_btt_playlist;
        private System.Windows.Forms.Button pan_nav_btt_home;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}