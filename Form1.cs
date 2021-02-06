using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void flexBeat_Click(object sender, EventArgs e)
        {

        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {

        }

        //global variables of string type array for saving path and the track of songs.
        string[] paths, files;

        private void btn1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //saving files
                paths = ofd.FileNames; //saving tracks
                
                //displaying music choices in listBox
                 for(int i=0; i<files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //displays in listbox 
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);     //for closing the app
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            windowsMedia.URL = paths[listBoxSongs.SelectedIndex];
        }
    }
}
