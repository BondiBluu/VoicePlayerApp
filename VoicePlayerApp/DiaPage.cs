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
        AllSchools allSchools;    
        //PictureBox diasomniaBox = new PictureBox();
        //TextBox diaTextBox = new TextBox();
            //Button malleusButton = new Button();
            //Button liliaButton = new Button();
            //Button sebekButton = new Button();
            //Button silverButton = new Button();

            public DiaPage(AllSchools allSchools)
            {
                InitializeComponent();
                //DisplayPictureBox();
                //DisplayButtons();
                this.allSchools = allSchools;
            }

            private void DiaPage_Load(object sender, EventArgs e)
            {

            }

        public List<Button> GetButtons()
        {
            List<Button> buttons = new List<Button>();

            Button malleusButton = new Button();
            malleusButton.Location = new Point(75, 317);
            malleusButton.Text = "Malleus";
            malleusButton.Click += malleusButton_Click;
            buttons.Add(malleusButton);

            Button liliaButton = new Button();
            liliaButton.Location = new Point(290, 317);
            liliaButton.Text = "Lilia";
            liliaButton.Click += liliaButton_Click;
            buttons.Add(liliaButton);

            Button silverButton = new Button();
            silverButton.Location = new Point(175, 375);
            silverButton.Text = "Silver";
            silverButton.Click += silverButton_Click;
            buttons.Add(silverButton);

            Button sebekButton = new Button();
            sebekButton.Location = new Point(12, 375);
            sebekButton.Text = "Sebek";
            sebekButton.Click += sebekButton_Click;
            buttons.Add(sebekButton);

            return buttons;
        }

            /*private void DisplayButtons()
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
            }*/

            private void malleusButton_Click(object sender, EventArgs e)
            {
                string malleusInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaTextFiles\MalleusInfo.txt");
                allSchools.textBox.Text = malleusInfo;

                allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaPhotos\Malleus.png");
            }
        
            private void liliaButton_Click(object sender, EventArgs e)
            {
                string liliaInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaTextFiles\LiliaInfo.txt");
                allSchools.textBox.Text = liliaInfo;

                allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaPhotos\Lilia.png");
            }

            private void sebekButton_Click(object sender, EventArgs e)
            {
                string sebekInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaTextFiles\SebekInfo.txt");
                allSchools.textBox.Text = sebekInfo;

                allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaPhotos\Sebek.png");
            }
        
            private void silverButton_Click(object sender, EventArgs e)
            {
                string silverInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaTextFiles\SilverInfo.txt");
                allSchools.textBox.Text = silverInfo;

                allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Diasomnia\DiaPhotos\Silver.png");
            }
        }
    }
