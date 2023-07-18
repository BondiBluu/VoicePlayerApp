namespace VoicePlayerApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.formTwoCharactersLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twisted Wonderland";
            // 
            // formTwoCharactersLabel
            // 
            this.formTwoCharactersLabel.AutoSize = true;
            this.formTwoCharactersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formTwoCharactersLabel.Location = new System.Drawing.Point(12, 223);
            this.formTwoCharactersLabel.Name = "formTwoCharactersLabel";
            this.formTwoCharactersLabel.Size = new System.Drawing.Size(80, 13);
            this.formTwoCharactersLabel.TabIndex = 1;
            this.formTwoCharactersLabel.TabStop = true;
            this.formTwoCharactersLabel.Text = "See Characters";
            this.formTwoCharactersLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.formTwoCharactersLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formTwoCharactersLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel formTwoCharactersLabel;
    }
}

