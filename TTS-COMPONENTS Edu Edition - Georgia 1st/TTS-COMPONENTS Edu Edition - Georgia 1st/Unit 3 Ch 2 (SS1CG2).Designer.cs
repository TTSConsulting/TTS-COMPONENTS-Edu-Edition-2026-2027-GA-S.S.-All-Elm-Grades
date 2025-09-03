using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    partial class Unit_3_Ch_2__SS1CG2_
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
            lblTitle = new Label();
            lblStandard = new Label();
            pnlSongButtons = new Panel();
            btnMyCountryTisOfThee = new Button();
            btnAmericaTheBeautiful = new Button();
            pnlContent = new Panel();
            lblSongTitle = new Label();
            lblLyricsSnippet = new Label();
            pnlKeyWords = new Panel();
            lblKeyWords = new Label();
            lblMeanings = new Label();
            lblPatriotismMessage = new Label();
            lblGeorgiaConnection = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            btnBackToUnit3Ch1 = new Button();
            btnSingAlong = new Button();
            btnPatriotismQuiz = new Button();
            btnToUnit4Ch1 = new Button();
            pnlSongButtons.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlKeyWords.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(150, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Unit 3 Chapter 2: Patriotic Songs!";
            // 
            // lblStandard
            // 
            lblStandard.AutoSize = true;
            lblStandard.Font = new Font("Arial", 10F);
            lblStandard.Location = new Point(120, 60);
            lblStandard.Name = "lblStandard";
            lblStandard.Size = new Size(560, 16);
            lblStandard.TabIndex = 1;
            lblStandard.Text = "SS1CG2: Explore Patriotism Through America Songs";
            // 
            // pnlSongButtons
            // 
            pnlSongButtons.BackColor = Color.LightSteelBlue;
            pnlSongButtons.Controls.Add(btnMyCountryTisOfThee);
            pnlSongButtons.Controls.Add(btnAmericaTheBeautiful);
            pnlSongButtons.Location = new Point(50, 100);
            pnlSongButtons.Name = "pnlSongButtons";
            pnlSongButtons.Size = new Size(700, 80);
            pnlSongButtons.TabIndex = 2;
            // 
            // btnMyCountryTisOfThee
            // 
            btnMyCountryTisOfThee.BackColor = Color.LightGray;
            btnMyCountryTisOfThee.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold);
            btnMyCountryTisOfThee.Location = new Point(50, 20);
            btnMyCountryTisOfThee.Name = "btnMyCountryTisOfThee";
            btnMyCountryTisOfThee.Size = new Size(250, 40);
            btnMyCountryTisOfThee.TabIndex = 0;
            btnMyCountryTisOfThee.Text = "🇺🇸 My Country 'Tis of Thee";
            btnMyCountryTisOfThee.UseVisualStyleBackColor = false;
            btnMyCountryTisOfThee.Click += new System.EventHandler(this.btnMyCountryTisOfThee_Click);
            // 
            // btnAmericaTheBeautiful
            // 
            btnAmericaTheBeautiful.BackColor = Color.LightGray;
            btnAmericaTheBeautiful.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold);
            btnAmericaTheBeautiful.Location = new Point(400, 20);
            btnAmericaTheBeautiful.Name = "btnAmericaTheBeautiful";
            btnAmericaTheBeautiful.Size = new Size(250, 40);
            btnAmericaTheBeautiful.TabIndex = 1;
            btnAmericaTheBeautiful.Text = "🏔️ America the Beautiful";
            btnAmericaTheBeautiful.UseVisualStyleBackColor = false;
            btnAmericaTheBeautiful.Click += new System.EventHandler(this.btnAmericaTheBeautiful_Click);
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.AliceBlue;
            pnlContent.Controls.Add(lblSongTitle);
            pnlContent.Controls.Add(lblLyricsSnippet);
            pnlContent.Controls.Add(pnlKeyWords);
            pnlContent.Controls.Add(lblPatriotismMessage);
            pnlContent.Controls.Add(lblGeorgiaConnection);
            pnlContent.Location = new Point(50, 200);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(700, 270);
            pnlContent.TabIndex = 3;
            // 
            // lblSongTitle
            // 
            lblSongTitle.AutoSize = true;
            lblSongTitle.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblSongTitle.ForeColor = Color.DarkRed;
            lblSongTitle.Location = new Point(20, 20);
            lblSongTitle.Name = "lblSongTitle";
            lblSongTitle.Size = new Size(350, 30);
            lblSongTitle.TabIndex = 0;
            lblSongTitle.Text = "Choose a patriotic song above!";
            // 
            // lblLyricsSnippet
            // 
            lblLyricsSnippet.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic);
            lblLyricsSnippet.ForeColor = Color.DarkBlue;
            lblLyricsSnippet.Location = new Point(20, 60);
            lblLyricsSnippet.Name = "lblLyricsSnippet";
            lblLyricsSnippet.Size = new Size(660, 30);
            lblLyricsSnippet.TabIndex = 1;
            // 
            // pnlKeyWords
            // 
            pnlKeyWords.BackColor = Color.LightYellow;
            pnlKeyWords.Controls.Add(lblKeyWords);
            pnlKeyWords.Controls.Add(lblMeanings);
            pnlKeyWords.Location = new Point(20, 100);
            pnlKeyWords.Name = "pnlKeyWords";
            pnlKeyWords.Size = new Size(660, 100);
            pnlKeyWords.TabIndex = 2;
            // 
            // lblKeyWords
            // 
            lblKeyWords.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblKeyWords.ForeColor = Color.DarkGreen;
            lblKeyWords.Location = new Point(10, 10);
            lblKeyWords.Name = "lblKeyWords";
            lblKeyWords.Size = new Size(320, 80);
            lblKeyWords.TabIndex = 0;
            // 
            // lblMeanings
            // 
            lblMeanings.Font = new Font("Comic Sans MS", 10F);
            lblMeanings.ForeColor = Color.DarkBlue;
            lblMeanings.Location = new Point(340, 10);
            lblMeanings.Name = "lblMeanings";
            lblMeanings.Size = new Size(310, 80);
            lblMeanings.TabIndex = 1;
            // 
            // lblPatriotismMessage
            // 
            lblPatriotismMessage.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold);
            lblPatriotismMessage.ForeColor = Color.Purple;
            lblPatriotismMessage.Location = new Point(20, 210);
            lblPatriotismMessage.Name = "lblPatriotismMessage";
            lblPatriotismMessage.Size = new Size(660, 25);
            lblPatriotismMessage.TabIndex = 3;
            // 
            // lblGeorgiaConnection
            // 
            lblGeorgiaConnection.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblGeorgiaConnection.ForeColor = Color.DarkOrange;
            lblGeorgiaConnection.Location = new Point(20, 240);
            lblGeorgiaConnection.Name = "lblGeorgiaConnection";
            lblGeorgiaConnection.Size = new Size(660, 25);
            lblGeorgiaConnection.TabIndex = 4;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGreen;
            btnNext.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnNext.Location = new Point(670, 490);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 40);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next →";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LightCoral;
            btnPrevious.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnPrevious.Location = new Point(50, 490);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(80, 40);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "← Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnBackToUnit3Ch1
            // 
            btnBackToUnit3Ch1.BackColor = Color.LightBlue;
            btnBackToUnit3Ch1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnBackToUnit3Ch1.Location = new Point(200, 490);
            btnBackToUnit3Ch1.Name = "btnBackToUnit3Ch1";
            btnBackToUnit3Ch1.Size = new Size(120, 40);
            btnBackToUnit3Ch1.TabIndex = 6;
            btnBackToUnit3Ch1.Text = "Back to Ch 1";
            btnBackToUnit3Ch1.UseVisualStyleBackColor = false;
            btnBackToUnit3Ch1.Click += new System.EventHandler(this.btnBackToUnit3Ch1_Click);
            // 
            // btnSingAlong
            // 
            btnSingAlong.BackColor = Color.LightPink;
            btnSingAlong.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnSingAlong.Location = new Point(350, 490);
            btnSingAlong.Name = "btnSingAlong";
            btnSingAlong.Size = new Size(120, 40);
            btnSingAlong.TabIndex = 7;
            btnSingAlong.Text = "🎵 Sing Along!";
            btnSingAlong.UseVisualStyleBackColor = false;
            btnSingAlong.Click += new System.EventHandler(this.btnSingAlong_Click);
            // 
            // btnPatriotismQuiz
            // 
            btnPatriotismQuiz.BackColor = Color.Gold;
            btnPatriotismQuiz.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnPatriotismQuiz.Location = new Point(500, 490);
            btnPatriotismQuiz.Name = "btnPatriotismQuiz";
            btnPatriotismQuiz.Size = new Size(120, 40);
            btnPatriotismQuiz.TabIndex = 8;
            btnPatriotismQuiz.Text = "Patriotism Quiz";
            btnPatriotismQuiz.UseVisualStyleBackColor = false;
            btnPatriotismQuiz.Click += new System.EventHandler(this.btnPatriotismQuiz_Click);
            // 
            // btnToUnit4Ch1
            // 
            btnToUnit4Ch1.BackColor = Color.LightGreen;
            btnToUnit4Ch1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnToUnit4Ch1.Location = new Point(640, 490);
            btnToUnit4Ch1.Name = "btnToUnit4Ch1";
            btnToUnit4Ch1.Size = new Size(120, 40);
            btnToUnit4Ch1.TabIndex = 9;
            btnToUnit4Ch1.Text = "Unit 4: Economics!";
            btnToUnit4Ch1.UseVisualStyleBackColor = false;
            btnToUnit4Ch1.Click += new System.EventHandler(this.btnToUnit4Ch1_Click);
            // 
            // Unit_3_Ch_2__SS1CG2_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 550);
            Controls.Add(btnToUnit4Ch1);
            Controls.Add(btnPatriotismQuiz);
            Controls.Add(btnSingAlong);
            Controls.Add(btnBackToUnit3Ch1);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pnlContent);
            Controls.Add(pnlSongButtons);
            Controls.Add(lblStandard);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Unit_3_Ch_2__SS1CG2_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TTS Components - Unit 3 Ch 2: Patriotic Songs";
            pnlSongButtons.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlKeyWords.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStandard;
        private Panel pnlSongButtons;
        private Button btnMyCountryTisOfThee;
        private Button btnAmericaTheBeautiful;
        private Panel pnlContent;
        private Label lblSongTitle;
        private Label lblLyricsSnippet;
        private Panel pnlKeyWords;
        private Label lblKeyWords;
        private Label lblMeanings;
        private Label lblPatriotismMessage;
        private Label lblGeorgiaConnection;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnBackToUnit3Ch1;
        private Button btnSingAlong;
        private Button btnPatriotismQuiz;
        private Button btnToUnit4Ch1;
    }
}