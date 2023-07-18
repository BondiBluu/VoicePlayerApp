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
    public partial class SavPage : Form
    {
        PictureBox octBox = new PictureBox();

        public SavPage()
        {
            InitializeComponent();
            octBox.Location = new Point();
        }

        private void SavPage_Load(object sender, EventArgs e)
        {

        }
    }
}
