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
    public partial class HeartsPage : Form
    {

        public HeartsPage()
        {
            InitializeComponent();
            TextBox heartsTextBox = new TextBox();
            heartsTextBox.Text = string.Empty;
        }

        private void HeartsPage_Load(object sender, EventArgs e)
        {

        }

        private void aceButton_Click(object sender, EventArgs e)
        {
            string aceInfo = @"C:\Users\bamid\source\repos\VoicePlayerApp\VoicePlayerApp\Heartslabyul\HeartsTextFiles";
            heartsTextBox.Text = aceInfo;

        }

        private void deuceButton_Click(object sender, EventArgs e)
        {

        }

        private void riddleButton_Click(object sender, EventArgs e)
        {

        }

        private void caterButton_Click(object sender, EventArgs e)
        {

        }

        private void treyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
