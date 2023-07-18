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
    public partial class SavPage : Form
    {
        PictureBox savanaclawBox = new PictureBox();
        TextBox savTextBox = new TextBox();
        Button leonaButton = new Button();
        Button ruggieButton = new Button();
        Button jackButton = new Button();


        public SavPage()
        {
            InitializeComponent();
            DisplayPictureBox();
            DisplayButtons();
        }

        private void SavPage_Load(object sender, EventArgs e)
        {
            
        }

        private void DisplayButtons()
        {
            leonaButton.Location = new Point(12, 317);
            leonaButton.Text = "Leona";

            ruggieButton.Location = new Point(191, 317);
            ruggieButton.Text = "Ruggie";

            jackButton.Location = new Point(370, 317);
            jackButton.Text = "Jack";


            //adding the buttons to SavPage.cs
            this.Controls.Add(leonaButton);
            this.Controls.Add(ruggieButton);
            this.Controls.Add(jackButton);

            //needed for the OnClick to work
            leonaButton.Click += leonaButton_Click;
            ruggieButton.Click += ruggieButton_Click;
            jackButton.Click += jackButton_Click;

        }

        private void DisplayPictureBox()
        {
            savanaclawBox.Location = new Point(12, 12);
            savanaclawBox.Size = new Size(442, 234);
            savanaclawBox.SizeMode = PictureBoxSizeMode.StretchImage;

            savTextBox.Multiline = true;
            savTextBox.ReadOnly = true;
            savTextBox.TextAlign = HorizontalAlignment.Center;
            savTextBox.Size = new Size(319, 299);
            savTextBox.Location = new Point(460, 12);
            savTextBox.Text = "Students of the Savanaclaw Dorm, home to the King of Beasts. A dorm based on the King of Beasts' spirit of persistence.";

            this.Controls.Add(savanaclawBox);
            this.Controls.Add(savTextBox);
        }

        private void leonaButton_Click(object sender, EventArgs e)
        {
            string leonaInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavTextFiles\LeonaInfo.txt");
            savTextBox.Text = leonaInfo;

            savanaclawBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavPhotos\Leona.png");
        }

        private void ruggieButton_Click(object sender, EventArgs e)
        {
            string ruggieInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavTextFiles\RuggieInfo.txt");
            savTextBox.Text = ruggieInfo;

            savanaclawBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavPhotos\Ruggie.png");
        }

        private void jackButton_Click(object sender, EventArgs e)
        {
            string jackInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavTextFiles\JackInfo.txt");
            savTextBox.Text = jackInfo;

            savanaclawBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavPhotos\Jack.png");
        }
    }
}
