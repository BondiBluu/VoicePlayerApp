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
    public partial class PomPage : Form
    {
        PictureBox pomfioreBox = new PictureBox();
        TextBox pomTextBox = new TextBox();
        Button vilButton = new Button();
        Button rookButton = new Button();
        Button epelButton = new Button();

        public PomPage()
        {
            InitializeComponent();
            DisplayPictureBox();
            DisplayButtons();
        }

        private void PomPage_Load(object sender, EventArgs e)
        {

        }

        private void DisplayButtons()
        {
            vilButton.Location = new Point(12, 317);
            vilButton.Text = "Vil";

            rookButton.Location = new Point(191, 317);
            rookButton.Text = "Rook";

            epelButton.Location = new Point(370, 317);
            epelButton.Text = "Epel";


            this.Controls.Add(vilButton);
            this.Controls.Add(rookButton);
            this.Controls.Add(epelButton);

            vilButton.Click += vilButton_Click;
            rookButton.Click += rookButton_Click;
            epelButton.Click += epelButton_Click;

        }

        private void DisplayPictureBox()
        {
            pomfioreBox.Location = new Point(12, 12);
            pomfioreBox.Size = new Size(442, 234);
            pomfioreBox.SizeMode = PictureBoxSizeMode.StretchImage;

            pomTextBox.Multiline = true;
            pomTextBox.ReadOnly = true;
            pomTextBox.TextAlign = HorizontalAlignment.Center;
            pomTextBox.Size = new Size(319, 299);
            pomTextBox.Location = new Point(460, 12);
            pomTextBox.Text = "Students of the Pomfiore Dorm, home to the Fairest Queen. A dorm based on the Fairest Queen's spirit of tenacity.";

            this.Controls.Add(pomfioreBox);
            this.Controls.Add(pomTextBox);
        }

        private void vilButton_Click(object sender, EventArgs e)
        {
            string vilInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Pomfiore\PomTextFiles\VilInfo.txt");
            pomTextBox.Text = vilInfo;

            pomfioreBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Pomfiore\PomPhotos\Vil.png");
        }

        private void rookButton_Click(object sender, EventArgs e)
        {
            string rookInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Pomfiore\PomTextFiles\RookInfo.txt");
            pomTextBox.Text = rookInfo;

            pomfioreBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Pomfiore\PomPhotos\Rook.png");
        }

        private void epelButton_Click(object sender, EventArgs e)
        {
            string epelInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Pomfiore\PomTextFiles\EpelInfo.txt");
            pomTextBox.Text = epelInfo;

            pomfioreBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Pomfiore\PomPhotos\Epel.png");
        }
    }
}
