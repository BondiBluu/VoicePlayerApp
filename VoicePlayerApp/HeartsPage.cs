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
        AllSchools allSchools;
        //start
        public HeartsPage(AllSchools allSchools)
        {
            InitializeComponent();
            //TextBox heartsTextBox = new TextBox();
            //PictureBox heartslabyulBox = new PictureBox();
            this.allSchools = allSchools;
        }

        //update
        private void HeartsPage_Load(object sender, EventArgs e)
        {
            heartsTextBox.Text = "Students of the Heartslabyul Dorm, home to the Queen of Hearts. A dorm based on the Queen of Hearts' spirit of strictness.";
        }

        public List<Button> GetButtons()
        {
            List<Button> buttons = new List<Button>();

            Button aceButton = new Button();
            aceButton.Location = new Point(86, 317);
            aceButton.Text = "Ace";
            aceButton.Click += aceButton_Click;
            buttons.Add(aceButton);

            Button deuceButton = new Button();
            deuceButton.Location = new Point(247, 317);
            deuceButton.Text = "Deuce";
            deuceButton.Click += deuceButton_Click;
            buttons.Add(deuceButton);

            Button riddleButton = new Button();
            riddleButton.Location = new Point(426, 317);
            riddleButton.Text = "Riddle";
            riddleButton.Click += riddleButton_Click;
            buttons.Add(riddleButton);

            Button treyButton = new Button();
            treyButton.Location = new Point(164, 389);
            treyButton.Text = "Trey";
            treyButton.Click += treyButton_Click;
            buttons.Add(treyButton);
            
            Button caterButton = new Button();
            caterButton.Location = new Point(343, 389);
            caterButton.Text = "Cater";
            caterButton.Click += caterButton_Click;
            buttons.Add(caterButton);

            return buttons;
        }
        private void aceButton_Click(object sender, EventArgs e)
        {
            //creating a string variable that grabs he data from a text file
            string aceInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\AceInfo.txt");
            allSchools.textBox.Text = aceInfo;

            //stretching the image to fit the picture box 
            heartslabyulBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //displaying the needed image onto the PictureBox in HeartsPage.cs
            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Ace.png");
        }

        private void deuceButton_Click(object sender, EventArgs e)
        {
            string deuceInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\DeuceInfo.txt");
            allSchools.textBox.Text = deuceInfo;

            heartslabyulBox.SizeMode= PictureBoxSizeMode.StretchImage;
            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Deuce.png");

        }

        private void riddleButton_Click(object sender, EventArgs e)
        {
            string riddleInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\RiddleInfo.txt");
            allSchools.textBox.Text = riddleInfo;

            heartslabyulBox.SizeMode = PictureBoxSizeMode.StretchImage;
            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Riddle.png");
        }

        private void caterButton_Click(object sender, EventArgs e)
        {
            string caterInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\CaterInfo.txt");
            allSchools.textBox.Text = caterInfo;

            heartslabyulBox.SizeMode = PictureBoxSizeMode.StretchImage;
            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Cater.png");
        }

        private void treyButton_Click(object sender, EventArgs e)
        {
            string treyInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles\TreyInfo.txt");
            allSchools.textBox.Text = treyInfo;

            heartslabyulBox.SizeMode = PictureBoxSizeMode.StretchImage;
            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsPhotos\Trey.png");
        }
    }
}
