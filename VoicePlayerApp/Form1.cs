﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formTwoCharactersLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form2 characterPage = new Form2();
            //characterPage.Show();

            AllSchools allSchools = new AllSchools();
            allSchools.Show();
            //this.Hide();
        }
    }
}
