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
    public partial class DiaPage : Form
    {
            PictureBox diasomniaBox = new PictureBox();
            TextBox diaTextBox = new TextBox();
            Button malleusButton = new Button();
            Button liliaButton = new Button();
            Button sebekButton = new Button();
            Button silverButton = new Button();

            public DiaPage()
            {
                InitializeComponent();
                DisplayPictureBox();
                DisplayButtons();
            }

            private void DiaPage_Load(object sender, EventArgs e)
            {

            }

            private void DisplayButtons()
            {
                malleusButton.Location = new Point(75, 317);
                malleusButton.Text = "Malleus";

                liliaButton.Location = new Point(290, 317);
                liliaButton.Text = "Lilia";

                silverButton.Location = new Point(175, 389);
                silverButton.Text = "Silver";

                sebekButton.Location = new Point(12, 389);
                sebekButton.Text = "Sebek";


                this.Controls.Add(malleusButton);
                this.Controls.Add(liliaButton);
                this.Controls.Add(silverButton);
                this.Controls.Add(sebekButton);

                malleusButton.Click += malleusButton_Click;
                liliaButton.Click += liliaButton_Click;
                sebekButton.Click += sebekButton_Click;
                silverButton.Click += silverButton_Click;

            }

            private void DisplayPictureBox()
            {
                diasomniaBox.Location = new Point(12, 12);
                diasomniaBox.Size = new Size(442, 234);
                diasomniaBox.SizeMode = PictureBoxSizeMode.StretchImage;

                diaTextBox.Multiline = true;
                diaTextBox.ReadOnly = true;
                diaTextBox.TextAlign = HorizontalAlignment.Center;
                diaTextBox.Size = new Size(319, 299);
                diaTextBox.Location = new Point(460, 12);
                diaTextBox.Text = "Students of the Diasomnia Dorm, home to the Thorn Fairy. A dorm based on the Thorn Fairy's spirit of nobility.";

                this.Controls.Add(diasomniaBox);
                this.Controls.Add(diaTextBox);
            }

            private void malleusButton_Click(object sender, EventArgs e)
            {
                string malleusInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaTextFiles\MalleusInfo.txt");
                diaTextBox.Text = malleusInfo;

                diasomniaBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaPhotos\Malleus.png");
            }
        
            private void liliaButton_Click(object sender, EventArgs e)
            {
                string liliaInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaTextFiles\LiliaInfo.txt");
                diaTextBox.Text = liliaInfo;

                diasomniaBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaPhotos\Lilia.png");
            }

            private void sebekButton_Click(object sender, EventArgs e)
            {
                string sebekInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaTextFiles\SebekInfo.txt");
                diaTextBox.Text = sebekInfo;

                diasomniaBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaPhotos\Sebek.png");
            }
        
            private void silverButton_Click(object sender, EventArgs e)
            {
                string silverInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaTextFiles\SilverInfo.txt");
                diaTextBox.Text = silverInfo;

                diasomniaBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaPhotos\Silver.png");
            }
        }
    }
