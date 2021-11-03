using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace SynopticProject___Music_Player___William_Fifield
{
    /// <summary>
    ///  MusicPlayer Form Class
    ///  
    ///  Author: William Fifield
    ///  Date: 03/11/2021
    ///  
    ///  This is the main class within the music player. 
    ///  Functions within this class allow the user to interact with the player to load files and play music.
    /// 
    /// </summary>
    public partial class MusicPlayer : Form
    {
        List<MusicDataObject> musicData;// Creating a local string list of MusicDataObjects for our database files

        int interactionTimerCount = 0;// WIP counter for idle state

        String[] files;// A store for the list of files and paths before they are broken into objects
        String[] paths;

        public MusicPlayer()
        {
            InitializeComponent();
            musicData = new List<MusicDataObject>();// Initilizing the local string list
        }

        /// <summary>
        /// The first application load function, showing starter functions and slecting the landing page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            selectionShape.Left = 7;//the location of the menu selector, set as the playback screen
            bunifuPagesSelection.SetPage(playbackPage);
            VolumeSlider.Hide();//hiding the VolumeSlider to reappear when selected

        }

        /// <summary>
        /// The playback screen load is used within multiple instances, so its better to refactor and utilize this function multiple times. 
        /// </summary>
        private void playbackScreenLoad()
        {
            bunifuPagesSelection.SetPage(playbackPage);
            selectionShape.Left = 7;
        }

        /// <summary>
        /// Using the bunifu framework, the pageSelection within the form shows 3 different screens needed
        /// Each of these are listed below with matching menu button clicks to navigate to the page
        /// </summary>
        private void playbackButton_Click(object sender, EventArgs e)
        {
            playbackScreenLoad();
        }


        /// <summary>
        /// Using the navigation to the screen, this menu button also loads up the data from the CSV database. This is pointed in the StreamReader
        /// This also is where the read database items are broken into local files as not not having to constantly connect ot the datastore.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            bunifuPagesSelection.SetPage(searchPage);
            selectionShape.Left = 105;

            using (var reader = new StreamReader("C:\\Users\\light\\source\\repos\\SynopticProject - Music Player - William Fifield\\SynopticProject - Music Player - William Fifield\\Assets\\musicSaved.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<MusicDataObject>();// Putting the csv data into the MusicDataObject
                List<string> tempFiles = new List<string>();
                List<string> tempPaths = new List<string>();

                foreach (MusicDataObject savedFile in records)// Itterating through each of the MusicDataObjects to set local data
                {
                    musicData.Add(savedFile);
                    MusicList.Items.Add(savedFile.FileData);
                    tempFiles.Add(savedFile.FileData);
                    tempPaths.Add(savedFile.PathData);
                }

                files = tempFiles.ToArray();
                paths = tempPaths.ToArray();

            }

        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            bunifuPagesSelection.SetPage(playListPage);
            selectionShape.Left = 203;

            // WIP
            // Work needed to load the playlist music file created by the user, in a similar way the music is saved, in which this will pre-load the saved playlist
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            // WIP
            // Work needed to skip a song when playing within the playlist
        }

        /// <summary>
        /// The volume button will show and hide the volume slider, making it not visible at all times
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volumeButton_Click(object sender, EventArgs e)
        {
            if (VolumeSlider.Visible == true){
                VolumeSlider.Hide();
            }
            else{
                VolumeSlider.Show();
            }
            
        }

        /// <summary>
        /// The reverse of reading the from our already saved file, using the CsvWriter, this import button opens a file dialog and takes teh data given and saves it into the database
        /// Saving it when the files come in saves issues when running this when shutting the application down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importMusicButton_Click(object sender, EventArgs e)
        {

            openFileDialog.Multiselect = true;// Allowing the selection of multiple files at once
            if (openFileDialog.ShowDialog() == DialogResult.OK)// This is a check to confirm that the user has clicked "Open" on the file dialog pop-up
            {
                files = openFileDialog.SafeFileNames;
                paths = openFileDialog.FileNames;

                for (int i = 0; i < files.Length; i++)// Looping through each file selected
                {
                    MusicDataObject newMusic = new MusicDataObject(files[i], paths[i]);
                    musicData.Add(newMusic);
                    MusicList.Items.Add(newMusic.FileData);
                }

            var writer = new StreamWriter("C:\\Users\\light\\source\\repos\\SynopticProject - Music Player - William Fifield\\SynopticProject - Music Player - William Fifield\\Assets\\musicSaved.csv");
            var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

            csvWriter.WriteRecords(musicData);// Writing the contents of every MusicDataObject saved in our musicData list


            }

        }


        /// <summary>
        /// Using our musicData, we can access the saved path within each MusicDataObject in order to play the track. This then takes you to the playback screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = musicData[MusicList.SelectedIndex].PathData;
            playbackScreenLoad();

        }
           
        /// <summary>
        /// The play button is required to play the media controls, and will dissapear if clicked and will show the pause button on the toggle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Hide();
            pauseButton.Show();
            player.Ctlcontrols.play();

        }

        /// <summary>
        /// In reverse to the play button, the pause button shows when music is playing, and will pause and hide itself when it's clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pauseButton_Click(object sender, EventArgs e)
        {
            pauseButton.Hide();
            playButton.Show();
            player.Ctlcontrols.pause();
        }

        /// <summary>
        /// This is checking the players state change, when if the windows media element changes song, it will re-update. This is how the function shows itself as "paused"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (checkIfMediaPlaying())//using below funtion check, as this will throw an error if trying to find media name with no media
            {
                nowPlayingLabel.Text = player.currentMedia.name;
            }
            nowPlayingLabel.Text = player.status;
        }

        //A simple bool check against the windows media element
        private bool checkIfMediaPlaying()
        {
            if (nowPlayingLabel.Text == player.Name)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Using this timer element to count the seconds passed, matching to the timeline slider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime.Text = player.Ctlcontrols.currentPositionString;
            timerSlider.Value = (int)player.Ctlcontrols.currentPosition;
        }

        
        /// <summary>
        /// This second slider controls the volume of the application, and will change it's icon when the volume is muted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VolumeSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            player.settings.volume = VolumeSlider.Value;
            if (VolumeSlider.Value == 0)
            {
                muteButton.Visible = true;
                volumeButton.Visible = false;
            }
            else
            {
                muteButton.Visible = false;
                volumeButton.Visible = true;
            }
        }

        /// <summary>
        /// WIP
        /// A start at the playlist audio track selector, but still required the database connection & Adding elements within app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// WIP
        /// Found on the playback screen, this element still required function to write new objects into the playlist database to be saved by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToPlaylistButton_Click(object sender, EventArgs e)
        {
            //  Development needed to save selected song into a seperate playlist for the user. 
            //  This will use the same method of saving that the program already uses, but will be writing into a seperate csv.
        }

        private void userInteractionPanel_Click(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// WIP
        /// Still being worked on element, using a second timer to count to the idle time of 30 seconds
        /// This element requires countring the seconds, but also resetting if there is user interaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerInteraction_Tick(object sender, EventArgs e)
        {
            interactionTimerCount += 1;

            if (interactionTimerCount == 30)
            {
                userInteractionPanel.Visible = true;
            }
            else
            {
                userInteractionPanel.Visible = false;
                
            }
        }

        /// <summary>
        /// Linking to the timerInteraction, this form click event is to reset the timer of the idle countdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusicPlayer_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("CLICKED");
            interactionTimerCount = 0;
        }
    }
}
