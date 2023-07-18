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
    public partial class Form2 : Form
    {
        public Form2()
        {
            /*PictureBox heartsPictureBox;
            PictureBox savPictureBox;
            PictureBox scaraPictureBox;
            PictureBox octPictureBox;
            PictureBox diaPictureBox;
            PictureBox igniPictureBox;
            PictureBox pomPictureBox;*/

            InitializeComponent();
            DisplayImages();
        }

        private void DisplayImages()
        {
            /*int boxHeight = 200;
            int boxWidth = 200;
            int spacing = 10;
            int x = spacing;
            int y = spacing;

            heartsPictureBox = new PictureBox();
            heartsPictureBox.Location = new Point(x, y);
            heartsPictureBox.Size = new Size(boxWidth, boxHeight);
            heartsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            heartsPictureBox.Image = Image.FromFile("C:\\Users\\bamid\\source\\repos\\VoicePlayerApp\\VoicePlayerApp\\DormImages\\Hearts.png");
            Controls.Add(heartsPictureBox);*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void heartsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void heartsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HeartsPage heartsPage = new HeartsPage();
            heartsPage.Show();
        }

        private void savLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SavPage savPage = new SavPage();
            savPage.Show();
        }

        private void octLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OctPage octPage = new OctPage();
            octPage.Show();
        }

        private void scaraLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScarPage scarPage = new ScarPage();
            scarPage.Show();
        }



        private void igLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IgniPage igniPage = new IgniPage();
            igniPage.Show();
        }

        private void diaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DiaPage diaPage = new DiaPage();
            diaPage.Show();
        }

        private void pomLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PomPage pomPage = new PomPage();
            pomPage.Show();
        }
    }
}
