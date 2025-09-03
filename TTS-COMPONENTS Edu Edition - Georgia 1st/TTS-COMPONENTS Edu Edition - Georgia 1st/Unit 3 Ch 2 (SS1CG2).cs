using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    public partial class Unit_3_Ch_2__SS1CG2_ : Form
    {
        private List<PatrioticSong> patrioticSongs = new List<PatrioticSong>();
        private int currentSongIndex = 0;

        public Unit_3_Ch_2__SS1CG2_()
        {
            InitializeComponent();
            InitializePatrioticSongs();
            DisplaySongInfo(currentSongIndex);
        }

        public class PatrioticSong
        {
            public string Title { get; set; }
            public string[] KeyWords { get; set; }
            public string[] Meanings { get; set; }
            public string PatriotismMessage { get; set; }
            public string LyricsSnippet { get; set; }
            public string GeorgiaConnection { get; set; }

            public PatrioticSong(string title, string[] keyWords, string[] meanings, string patriotismMessage, string lyricsSnippet, string georgiaConnection)
            {
                Title = title;
                KeyWords = keyWords;
                Meanings = meanings;
                PatriotismMessage = patriotismMessage;
                LyricsSnippet = lyricsSnippet;
                GeorgiaConnection = georgiaConnection;
            }
        }

        private void InitializePatrioticSongs()
        {
            patrioticSongs = new List<PatrioticSong>
            {
                new PatrioticSong(
                    "America (My Country 'Tis of Thee)",
                    new string[] { "Country", "Liberty", "Freedom", "Sweet Land" },
                    new string[] { 
                        "Country: Our homeland, the United States",
                        "Liberty: Being free to make choices", 
                        "Freedom: Not being controlled by others",
                        "Sweet Land: A beautiful, wonderful place to live"
                    },
                    "This song shows we love our country and are grateful for our freedom!",
                    "This song talks about our sweet land of liberty and freedom",
                    "Georgia is part of this 'sweet land of liberty' - we are free in Georgia!"
                ),
                new PatrioticSong(
                    "America the Beautiful",
                    new string[] { "Beautiful", "Brotherhood", "Pride", "Grace" },
                    new string[] { 
                        "Beautiful: Our country has amazing mountains, fields, and cities",
                        "Brotherhood: We are all Americans working together like family", 
                        "Pride: We feel good about being Americans",
                        "Grace: God's blessing and kindness on our country"
                    },
                    "This song celebrates how beautiful our country is and how we should work together!",
                    "This song praises America's beauty and calls for brotherhood",
                    "Georgia's beautiful mountains and peach farms are part of 'America the Beautiful'!"
                )
            };
        }

        private void DisplaySongInfo(int index)
        {
            if (index >= 0 && index < patrioticSongs.Count)
            {
                var song = patrioticSongs[index];
                lblSongTitle.Text = song.Title;
                lblLyricsSnippet.Text = $"\"{song.LyricsSnippet}\"";
                lblPatriotismMessage.Text = song.PatriotismMessage;
                lblGeorgiaConnection.Text = song.GeorgiaConnection;
                
                // Display key words and meanings
                DisplayKeyWordsAndMeanings(song);
                
                btnPrevious.Enabled = index > 0;
                btnNext.Enabled = index < patrioticSongs.Count - 1;
                
                HighlightCurrentSongButton(index);
            }
        }

        private void DisplayKeyWordsAndMeanings(PatrioticSong song)
        {
            string keyWordsText = "Key Patriotic Words:\n";
            for (int i = 0; i < song.KeyWords.Length; i++)
            {
                keyWordsText += $"• {song.KeyWords[i]}\n";
            }
            lblKeyWords.Text = keyWordsText;

            string meaningsText = "What They Mean:\n";
            for (int i = 0; i < song.Meanings.Length; i++)
            {
                meaningsText += $"• {song.Meanings[i]}\n";
            }
            lblMeanings.Text = meaningsText;
        }

        private void HighlightCurrentSongButton(int index)
        {
            ResetButtonColors();
            switch (index)
            {
                case 0: btnMyCountryTisOfThee.BackColor = Color.Red; break;
                case 1: btnAmericaTheBeautiful.BackColor = Color.Blue; break;
            }
        }

        private void ResetButtonColors()
        {
            btnMyCountryTisOfThee.BackColor = Color.LightGray;
            btnAmericaTheBeautiful.BackColor = Color.LightGray;
        }

        private void btnMyCountryTisOfThee_Click(object sender, EventArgs e)
        {
            currentSongIndex = 0;
            DisplaySongInfo(currentSongIndex);
        }

        private void btnAmericaTheBeautiful_Click(object sender, EventArgs e)
        {
            currentSongIndex = 1;
            DisplaySongInfo(currentSongIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentSongIndex < patrioticSongs.Count - 1)
            {
                currentSongIndex++;
                DisplaySongInfo(currentSongIndex);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentSongIndex > 0)
            {
                currentSongIndex--;
                DisplaySongInfo(currentSongIndex);
            }
        }

        private void btnBackToUnit3Ch1_Click(object sender, EventArgs e)
        {
            Unit_3_Ch_1__SS1CG1_ unit3Ch1Form = new Unit_3_Ch_1__SS1CG1_();
            unit3Ch1Form.Show();
        }

        private void btnToUnit4Ch1_Click(object sender, EventArgs e)
        {
            Unit_4_Ch_1__SS1E1_ unit4Ch1Form = new Unit_4_Ch_1__SS1E1_();
            unit4Ch1Form.Show();
        }

        private void btnSingAlong_Click(object sender, EventArgs e)
        {
            var song = patrioticSongs[currentSongIndex];
            MessageBox.Show($"🎵 Let's sing together! 🎵\n\n{song.LyricsSnippet}\n\nSinging patriotic songs helps us show love for our country!", 
                          "Sing-Along Time!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPatriotismQuiz_Click(object sender, EventArgs e)
        {
            var song = patrioticSongs[currentSongIndex];
            string quiz = $"Patriotism Quiz!\n\nListen to '{song.Title}' and answer:\n\n";
            quiz += "1. What does this song teach us about loving our country?\n";
            quiz += "2. Which words make you feel proud to be American?\n";
            quiz += "3. How can you show patriotism at school?\n\n";
            quiz += "Talk about your answers with your teacher and classmates!";
            
            MessageBox.Show(quiz, "Patriotism Quiz", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
