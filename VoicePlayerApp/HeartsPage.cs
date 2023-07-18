using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoicePlayerApp
{
    public partial class HeartsPage : Form
    {
        //start
        public HeartsPage()
        {
            InitializeComponent();
            TextBox heartsTextBox = new TextBox();
            PictureBox heartslabyulBox = new PictureBox();
            
        }

        //update
        private void HeartsPage_Load(object sender, EventArgs e)
        {
            heartsTextBox.Text = "Students of the Heartslabyul Dorm, home to the Queen of Hearts. A dorm based on the Queen of Hearts' spirit of strictness.";
        }

        private void aceButton_Click(object sender, EventArgs e)
        {
            //creating a string variable that grabs he data from a text file
            string aceInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\AceInfo.txt");
            heartsTextBox.Text = aceInfo;

            //stretching the image to fit the picture box 
            heartslabyulBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //displaying the needed image onto the PictureBox in HeartsPage.cs
            heartslabyulBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Ace.png");
        }

        private void deuceButton_Click(object sender, EventArgs e)
        {
            string deuceInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\DeuceInfo.txt");
            heartsTextBox.Text = deuceInfo;

            heartslabyulBox.SizeMode= PictureBoxSizeMode.StretchImage;
            heartslabyulBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Deuce.png");

        }

        private void riddleButton_Click(object sender, EventArgs e)
        {
            string riddleInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\RiddleInfo.txt");
            heartsTextBox.Text = riddleInfo;

            heartslabyulBox.SizeMode = PictureBoxSizeMode.StretchImage;
            heartslabyulBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Riddle.png");
        }

        private void caterButton_Click(object sender, EventArgs e)
        {
            string caterInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\CaterInfo.txt");
            heartsTextBox.Text = caterInfo;

            heartslabyulBox.SizeMode = PictureBoxSizeMode.StretchImage;
            heartslabyulBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Cater.png");
        }

        private void treyButton_Click(object sender, EventArgs e)
        {
            string treyInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\TreyInfo.txt");
            heartsTextBox.Text = treyInfo;

            heartslabyulBox.SizeMode = PictureBoxSizeMode.StretchImage;
            heartslabyulBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Trey.png");
        }
    }
}
