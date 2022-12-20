using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musicplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set the URL property to the file path obtained from the text box. 
            player.URL = textBox1.Text;

            // Play the media file. 
            player.Ctlcontrols.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the URL property to the file path obtained from the text box. 
            player.URL = "D:\\Download\\1 Waiting For You.mp3";

            // Play the media file. 
            player.Ctlcontrols.play();
        }
    }
}
