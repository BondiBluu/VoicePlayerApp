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
    public partial class OctPage : Form
    {
        AllSchools allSchools;
        PictureBox octavinelleBox = new PictureBox();
        TextBox octTextBox = new TextBox();

        public OctPage(AllSchools allSchools)
        {
            InitializeComponent();
            //DisplayButtons();
            //DisplayPictureBox();
            this.allSchools = allSchools;
        }

        private void OctPage_Load(object sender, EventArgs e)
        {

        }

        public List<Button> GetButtons()
        {
            List<Button> buttons = new List<Button>();


            Button azulButton = new Button();
            azulButton.Location = new Point(12, 317);
            azulButton.Text = "Azul";
            azulButton.Click += azulButton_Click;
            //adding the button after modification
            buttons.Add(azulButton);

            Button jadeButton = new Button();
            jadeButton.Location = new Point(191, 317);
            jadeButton.Text = "Jade";
            jadeButton.Click += jadeButton_Click;
            buttons.Add(jadeButton);

            Button floydButton = new Button();
            floydButton.Location = new Point(370, 317);
            floydButton.Text = "Floyd";
            floydButton.Click += floydButton_Click;
            buttons.Add(floydButton);


            return buttons;
        }
        /*private void DisplayButtons()
        {
            azulButton.Location = new Point(12, 317);
            azulButton.Text = "Azul";

            jadeButton.Location = new Point(191, 317);
            jadeButton.Text = "Jade";

            floydButton.Location = new Point(370, 317);
            floydButton.Text = "Floyd";


            this.Controls.Add(azulButton);
            this.Controls.Add(jadeButton);
            this.Controls.Add(floydButton);

            azulButton.Click += azulButton_Click;
            jadeButton.Click += jadeButton_Click;
            floydButton.Click += floydButton_Click;

        }*/

        private void DisplayPictureBox()
        {
            octavinelleBox.Location = new Point(12, 12);
            octavinelleBox.Size = new Size(442, 234);
            octavinelleBox.SizeMode = PictureBoxSizeMode.StretchImage;

            octTextBox.Multiline = true;
            octTextBox.ReadOnly = true;
            octTextBox.TextAlign = HorizontalAlignment.Center;
            octTextBox.Size = new Size(319, 299);
            octTextBox.Location = new Point(460, 12);
            octTextBox.Text = "Students of the Octavinelle Dorm, home to the Sea Witch. A dorm based on the Sea Witch's spirit of benevolence.";

            this.Controls.Add(octavinelleBox);
            this.Controls.Add(octTextBox);
        }

        private void azulButton_Click(object sender, EventArgs e)
        {
            string azulInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Octavinelle\OctTextFiles\AzulInfo.txt");
            allSchools.textBox.Text = azulInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Octavinelle\OctPhotos\Azul.png");
        }

        private void jadeButton_Click(object sender, EventArgs e)
        {
            string jadeInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Octavinelle\OctTextFiles\JadeInfo.txt");
            allSchools.textBox.Text = jadeInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Octavinelle\OctPhotos\Jade.png");
        }

        private void floydButton_Click(object sender, EventArgs e)
        {
            string floydInfo = File.ReadAllText(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Octavinelle\OctTextFiles\FloydInfo.txt");
            allSchools.textBox.Text = floydInfo;

            allSchools.pictureBox.Image = Image.FromFile(@"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Octavinelle\OctPhotos\Floyd.png");
        }
    }
}
