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
    public partial class IgniPage : Form
    {
        AllSchools allSchools;
        //PictureBox ignihydeBox = new PictureBox();
        //TextBox igniTextBox = new TextBox();
        Button idiaButton = new Button();
        Button orthoButton = new Button();

        public IgniPage(AllSchools allSchools)
        {
            InitializeComponent();
            //DisplayPictureBox();
            //DisplayButtons();
            this.allSchools = allSchools;
        }

        private void IgniPage_Load(object sender, EventArgs e)
        {

        }

        public List<Button> GetButtons()
        {
            List<Button> buttons = new List<Button>();

            Button idiaButton = new Button();
            idiaButton.Location = new Point(75, 317);
            idiaButton.Text = "Idia";
            idiaButton.Click += idiaButton_Click;
            buttons.Add(idiaButton);


            Button orthoButton = new Button();
            orthoButton.Location = new Point(290, 317);
            orthoButton.Text = "Ortho";
            orthoButton.Click += orthoButton_Click;
            buttons.Add(orthoButton);

            return buttons;
        }

        /*private void DisplayButtons()
        {
            idiaButton.Location = new Point(75, 317);
            idiaButton.Text = "Idia";

            orthoButton.Location = new Point(290, 317);
            orthoButton.Text = "Ortho";

            this.Controls.Add(idiaButton);
            this.Controls.Add(orthoButton);

            idiaButton.Click += idiaButton_Click;
            orthoButton.Click += orthoButton_Click;

        }

        private void DisplayPictureBox()
        {
            ignihydeBox.Location = new Point(12, 12);
            ignihydeBox.Size = new Size(442, 234);
            ignihydeBox.SizeMode = PictureBoxSizeMode.StretchImage;

            igniTextBox.Multiline = true;
            igniTextBox.ReadOnly = true;
            igniTextBox.TextAlign = HorizontalAlignment.Center;
            igniTextBox.Size = new Size(319, 299);
            igniTextBox.Location = new Point(460, 12);
            igniTextBox.Text = "Students of the Ignihyde Dorm, home to the King of the Underworld. A dorm based on the King of the Underworld's spirit of diligence";

            this.Controls.Add(ignihydeBox);
            this.Controls.Add(igniTextBox);
        }*/

        private void idiaButton_Click(object sender, EventArgs e)
        {
            string idiaInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Ignihyde\IgniTextFiles\IdiaInfo.txt");
            allSchools.textBox.Text = idiaInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Ignihyde\IgniPhotos\Idia.png");
        }

        private void orthoButton_Click(object sender, EventArgs e)
        {
            string orthoInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Ignihyde\IgniTextFiles\OrthoInfo.txt");
            allSchools.textBox.Text = orthoInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Ignihyde\IgniPhotos\Ortho.png");
        }
    }
}
