using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoicePlayerApp
{
    public class Savanaclaw : Form
    {
        public PictureBox savanaclawBox = new PictureBox();
        public TextBox savTextBox = new TextBox();
        private AllSchools allSchools;

        public Savanaclaw()
        {
            //InitializeComponent();
            // Storing the reference to the AllSchools form
            //this.allSchools = allSchools;
            //DisplayPictureBox();
            //DisplayButtons();
        }

        private void SavPage_Load(object sender, EventArgs e)
        {

        }

        //making buttons to function with AllSchools.cs
        public List<Button> GetButtons()
        {
            List<Button> buttons = new List<Button>();


            Button leonaButton = new Button();
            leonaButton.Location = new Point(12, 317);
            leonaButton.Text = "Leona";
            leonaButton.Click += leonaButton_Click;
            //adding the button after modification
            buttons.Add(leonaButton);


            Button ruggieButton = new Button();
            ruggieButton.Location = new Point(191, 317);
            ruggieButton.Text = "Ruggie";
            ruggieButton.Click += ruggieButton_Click;
            buttons.Add(ruggieButton);

            Button jackButton = new Button();
            jackButton.Location = new Point(370, 317);
            jackButton.Text = "Jack";
            jackButton.Click += jackButton_Click;
            buttons.Add(jackButton);


            return buttons;
        }
        
        public void leonaButton_Click(object sender, EventArgs e)
        {
            string leonaInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavTextFiles\LeonaInfo.txt");
            allSchools.textBox.Text = leonaInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavPhotos\Leona.png");
        }

        public void ruggieButton_Click(object sender, EventArgs e)
        {
            string ruggieInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavTextFiles\RuggieInfo.txt");
            allSchools.textBox.Text = ruggieInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavPhotos\Ruggie.png");
        }

        public void jackButton_Click(object sender, EventArgs e)
        {
            string jackInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavTextFiles\JackInfo.txt");
            allSchools.textBox.Text = jackInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Savanaclaw\SavPhotos\Jack.png");
        }
    }
}

