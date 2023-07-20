using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoicePlayerApp
{
    public partial class AllSchools : Form
    {
        public PictureBox pictureBox = new PictureBox();
        public TextBox textBox = new TextBox();
        Button heartsButton = new Button();
        Button savButton = new Button();
        Button octButton = new Button();
        Button scarButton = new Button();
        Button pomButton = new Button();
        Button igniButton = new Button();
        Button diaButton = new Button();


        public AllSchools()
        {
            InitializeComponent();
            DisplayPictureBoxandText();
            DisplayButtons();
        }

        private void AllSchools_Load(object sender, EventArgs e)
        {

        }

        private void DisplayPictureBoxandText()
        {
            pictureBox.Location = new Point(12, 12);
            pictureBox.Size = new Size(442, 234);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            textBox.Multiline = true;
            textBox.ReadOnly = true;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Size = new Size(319, 299);
            textBox.Location = new Point(460, 12);

            this.Controls.Add(pictureBox);
            this.Controls.Add(textBox);
        }

        private void DisplayButtons()
        {
            heartsButton.Location = new Point(12, 415);
            heartsButton.Text = "Heartslabyul";

            savButton.Location = new Point(112, 415);
            savButton.Text = "Savanaclaw";
            
            octButton.Location = new Point(212, 415);
            octButton.Text = "Octavinelle";

            scarButton.Location = new Point(312, 415);
            scarButton.Text = "Scarabia";

            pomButton.Location = new Point(412, 415);
            pomButton.Text = "Pomfiore";

            igniButton.Location = new Point(512, 415);
            igniButton.Text = "Ignihyde";

            diaButton.Location = new Point(612, 415);
            diaButton.Text = "Diasomnia";


            this.Controls.Add(heartsButton);
            this.Controls.Add(savButton);
            this.Controls.Add(octButton);
            this.Controls.Add(scarButton);
            this.Controls.Add(pomButton);
            this.Controls.Add(igniButton);
            this.Controls.Add(diaButton);

            heartsButton.Click += heartsButton_Click;
            savButton.Click += savButton_Click;
            octButton.Click += octButton_Click;
            scarButton.Click += scarButton_Click;
            pomButton.Click += pomButton_Click;
            igniButton.Click += igniButton_Click;
            diaButton.Click += diaButton_Click;
        }

        private void heartsButton_Click(object sender, EventArgs e)
        {
            RemoveExistingButtons();
            textBox.Text = "Students of the Heartslabyul Dorm, home to the Queen of Hearts. A dorm based on the Queen of Hearts' spirit of strictness.";
            pictureBox.Image = null;

            HeartsPage heartsPage = new HeartsPage(this);
            List<Button> heartsButtons = heartsPage.GetButtons();

            foreach (Button b in heartsButtons)
            {
                this.Controls.Add(b);
            }
        }

        private void savButton_Click(object sender, EventArgs e)
        {
            RemoveExistingButtons();
            //resetting when pressing the dorm's button
            textBox.Text = "Students of the Savanaclaw Dorm, home to the King of Beasts. A dorm based on the King of Beasts' spirit of persistence.";
            pictureBox.Image = null;

            // Passing a reference to the AllSchools form to SavPage form when we create an instance of it
            SavPage savPage = new SavPage(this);
            List<Button> savButtons = savPage.GetButtons();

            foreach (Button b in savButtons)
            {
                this.Controls.Add(b);
            }
        }
        
        private void octButton_Click(object sender, EventArgs e)
        {
            RemoveExistingButtons();
            textBox.Text = "Students of the Octavinelle Dorm, home to the Sea Witch. A dorm based on the Sea Witch's spirit of benevolence.";
            pictureBox.Image = null;

            OctPage octPage = new OctPage(this);
            List<Button> octButtons = octPage.GetButtons();

            foreach (Button b in octButtons)
            {
                this.Controls.Add(b);
            }
        }

        private void pomButton_Click(Object sender, EventArgs e)
        {
            RemoveExistingButtons();
            textBox.Text = "Students of the Pomfiore Dorm, home to the Fairest Queen. A dorm based on the Fairest Queen's spirit of tenacity.";
            pictureBox.Image = null;

            PomPage pomPage = new PomPage(this);
            List<Button> pomButtons = pomPage.GetButtons();

            foreach (Button b in pomButtons)
            {
                this.Controls.Add(b);
            }
        }
        private void scarButton_Click(Object sender, EventArgs e)
        {
            RemoveExistingButtons();
            textBox.Text = "Students of the Scarabia Dorm, home to the Sorcerer of the Sands. A dorm based on the Sorcerer of the Sands' spirit of mindfulness.";
            pictureBox.Image = null;

            ScarPage scarPage = new ScarPage(this);
            List<Button> scarButtons = scarPage.GetButtons();

            foreach (Button b in scarButtons)
            {
                this.Controls.Add(b);
            }
        }
        
        private void igniButton_Click(Object sender, EventArgs e)
        {
            RemoveExistingButtons();
            textBox.Text = "Students of the Ignihyde Dorm, home to the King of the Underworld. A dorm based on the King of the Underworld's spirit of diligence";
            pictureBox.Image = null;

            IgniPage igniPage = new IgniPage(this);
            List<Button> igniButtons = igniPage.GetButtons();

            foreach (Button b in igniButtons)
            {
                this.Controls.Add(b);
            }
        }

        private void diaButton_Click(Object sender, EventArgs e)
        {
            RemoveExistingButtons();
            textBox.Text = "Students of the Diasomnia Dorm, home to the Thorn Fairy. A dorm based on the Thorn Fairy's spirit of nobility.";
            pictureBox.Image = null;

            DiaPage diaPage = new DiaPage(this);
            List<Button> diaButtons = diaPage.GetButtons();

            foreach (Button b in diaButtons)
            {
                this.Controls.Add(b);
            }
        }

        private void RemoveExistingButtons()
        {
            // Iterate through the form's controls and remove buttons except for the main dorm buttons
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];
                if (control is Button && control != heartsButton && control != savButton && control != octButton &&
                    control != scarButton && control != pomButton && control != igniButton && control != diaButton)
                {
                    this.Controls.Remove(control);
                }
            }
        }
    }
}
