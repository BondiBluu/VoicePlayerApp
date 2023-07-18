namespace VoicePlayerApp
{
    partial class HeartsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.heartslabyulBox = new System.Windows.Forms.PictureBox();
            this.aceButton = new System.Windows.Forms.Button();
            this.treyButton = new System.Windows.Forms.Button();
            this.caterButton = new System.Windows.Forms.Button();
            this.riddleButton = new System.Windows.Forms.Button();
            this.deuceButton = new System.Windows.Forms.Button();
            this.heartsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.heartslabyulBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heartslabyulBox
            // 
            this.heartslabyulBox.Location = new System.Drawing.Point(12, 12);
            this.heartslabyulBox.Name = "heartslabyulBox";
            this.heartslabyulBox.Size = new System.Drawing.Size(442, 234);
            this.heartslabyulBox.TabIndex = 0;
            this.heartslabyulBox.TabStop = false;
            // 
            // aceButton
            // 
            this.aceButton.Location = new System.Drawing.Point(86, 317);
            this.aceButton.Name = "aceButton";
            this.aceButton.Size = new System.Drawing.Size(75, 23);
            this.aceButton.TabIndex = 1;
            this.aceButton.Text = "Ace";
            this.aceButton.UseVisualStyleBackColor = true;
            this.aceButton.Click += new System.EventHandler(this.aceButton_Click);
            // 
            // treyButton
            // 
            this.treyButton.Location = new System.Drawing.Point(343, 389);
            this.treyButton.Name = "treyButton";
            this.treyButton.Size = new System.Drawing.Size(75, 23);
            this.treyButton.TabIndex = 2;
            this.treyButton.Text = "Trey";
            this.treyButton.UseVisualStyleBackColor = true;
            this.treyButton.Click += new System.EventHandler(this.treyButton_Click);
            // 
            // caterButton
            // 
            this.caterButton.Location = new System.Drawing.Point(164, 389);
            this.caterButton.Name = "caterButton";
            this.caterButton.Size = new System.Drawing.Size(75, 23);
            this.caterButton.TabIndex = 3;
            this.caterButton.Text = "Cater";
            this.caterButton.UseVisualStyleBackColor = true;
            this.caterButton.Click += new System.EventHandler(this.caterButton_Click);
            // 
            // riddleButton
            // 
            this.riddleButton.Location = new System.Drawing.Point(426, 317);
            this.riddleButton.Name = "riddleButton";
            this.riddleButton.Size = new System.Drawing.Size(75, 23);
            this.riddleButton.TabIndex = 4;
            this.riddleButton.Text = "Riddle";
            this.riddleButton.UseVisualStyleBackColor = true;
            this.riddleButton.Click += new System.EventHandler(this.riddleButton_Click);
            // 
            // deuceButton
            // 
            this.deuceButton.Location = new System.Drawing.Point(247, 317);
            this.deuceButton.Name = "deuceButton";
            this.deuceButton.Size = new System.Drawing.Size(75, 23);
            this.deuceButton.TabIndex = 5;
            this.deuceButton.Text = "Deuce";
            this.deuceButton.UseVisualStyleBackColor = true;
            this.deuceButton.Click += new System.EventHandler(this.deuceButton_Click);
            // 
            // heartsTextBox
            // 
            this.heartsTextBox.Location = new System.Drawing.Point(460, 12);
            this.heartsTextBox.Multiline = true;
            this.heartsTextBox.Name = "heartsTextBox";
            this.heartsTextBox.ReadOnly = true;
            this.heartsTextBox.Size = new System.Drawing.Size(319, 299);
            this.heartsTextBox.TabIndex = 7;
            this.heartsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeartsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.heartsTextBox);
            this.Controls.Add(this.deuceButton);
            this.Controls.Add(this.riddleButton);
            this.Controls.Add(this.caterButton);
            this.Controls.Add(this.treyButton);
            this.Controls.Add(this.aceButton);
            this.Controls.Add(this.heartslabyulBox);
            this.Name = "HeartsPage";
            this.Text = "HeartsPage";
            this.Load += new System.EventHandler(this.HeartsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heartslabyulBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox heartslabyulBox;
        private System.Windows.Forms.Button aceButton;
        private System.Windows.Forms.Button treyButton;
        private System.Windows.Forms.Button caterButton;
        private System.Windows.Forms.Button riddleButton;
        private System.Windows.Forms.Button deuceButton;
        private System.Windows.Forms.TextBox heartsTextBox;
    }
}