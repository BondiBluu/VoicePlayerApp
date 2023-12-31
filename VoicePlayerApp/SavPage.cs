﻿using System;
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
        public PictureBox savanaclawBox = new PictureBox();
        public TextBox savTextBox = new TextBox();
        private AllSchools allSchools;

        //Passing a reference to the AllSchools form to the SavPage form iot
        //access its controls (the TextBox and pictureBox) and update
        //their properties accordingly in the Button_Click
        public SavPage(AllSchools allSchools)
        {
            InitializeComponent();
            // Storing the reference to the AllSchools form
            this.allSchools = allSchools;
            //DisplayPictureBox();
            //DisplayButtons();
        }

        public SavPage()
        {
            InitializeComponent();
            // Storing the reference to the AllSchools form
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
       /* public void DisplayButtons()
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
        }*/

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
