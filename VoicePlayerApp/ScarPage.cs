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
    public partial class ScarPage : Form
    {
        AllSchools allSchools;
        //PictureBox scarabiaBox = new PictureBox();
        //TextBox scarTextBox = new TextBox();
        //Button kalimButton = new Button();
        //Button jamilButton = new Button();

        public ScarPage(AllSchools allSchools)
        {
            InitializeComponent();
            //DisplayPictureBox();
            //DisplayButtons();
            this.allSchools = allSchools;
        }

        private void ScarPage_Load(object sender, EventArgs e)
        {

        }

        public List<Button> GetButtons()
        {
            List<Button> buttons = new List<Button>();

            Button kalimButton = new Button();
            kalimButton.Location = new Point(75, 317);
            kalimButton.Text = "Kalim";
            kalimButton.Click += kalimButton_Click;
            buttons.Add(kalimButton);


            Button jamilButton = new Button();
            jamilButton.Location = new Point(290, 317);
            jamilButton.Text = "Jamil";
            jamilButton.Click += jamilButton_Click;
            buttons.Add(jamilButton);

            return buttons;
        }

        /*private void DisplayButtons()
        {
            kalimButton.Location = new Point(75, 317);
            kalimButton.Text = "Kalim";

            jamilButton.Location = new Point(290, 317);
            jamilButton.Text = "Jamil";

            this.Controls.Add(kalimButton);
            this.Controls.Add(jamilButton);

            kalimButton.Click += kalimButton_Click;
            jamilButton.Click += jamilButton_Click;

        }

        private void DisplayPictureBox()
        {
            scarabiaBox.Location = new Point(12, 12);
            scarabiaBox.Size = new Size(442, 234);
            scarabiaBox.SizeMode = PictureBoxSizeMode.StretchImage;

            scarTextBox.Multiline = true;
            scarTextBox.ReadOnly = true;
            scarTextBox.TextAlign = HorizontalAlignment.Center;
            scarTextBox.Size = new Size(319, 299);
            scarTextBox.Location = new Point(460, 12);
            scarTextBox.Text = "Students of the Scarabia Dorm, home to the Sorcerer of the Sands. A dorm based on the Sorcerer of the Sands' spirit of mindfulness.";

            this.Controls.Add(scarabiaBox);
            this.Controls.Add(scarTextBox);
        }*/

        private void kalimButton_Click(object sender, EventArgs e)
        {
            string kalimInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Scarabia\ScarTextFiles\KalimInfo.txt");
            allSchools.textBox.Text = kalimInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Scarabia\ScarPhotos\Kalim.png");
        }

        private void jamilButton_Click(object sender, EventArgs e)
        {
            string jamilInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Scarabia\ScarTextFiles\JamilInfo.txt");
            allSchools.textBox.Text = jamilInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Scarabia\ScarPhotos\Jamil.png");
        }
    }
}
