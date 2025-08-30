using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Education_Edition_2026_2027_GA_K
{
    public partial class Unit_8__SSKCG2_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox characterTraitComboBox;
        private PictureBox characterPictureBox;
        private Label descriptionLabel;
        private Panel examplesPanel;
        private Label examplesLabel;
        private Button nextButton;
        private Button previousButton;
        private Label copyrightLabel;
        private Button goToUnit1Button;
        private Button goToUnit2Button;
        private Button goToUnit3Button;
        private Button goToUnit4Button;
        private Button goToUnit5Button;
        private Button goToUnit6Button;
        private Button goToUnit7Button;
        private Button goToUnit9Button; // Add Unit 9 button

        public Unit_8__SSKCG2_()
        {
            InitializeComponent();
            InitializeSSKCG2Components();
        }

        private void InitializeSSKCG2Components()
        {
            // Form settings
            this.Text = "Unit 8 - Positive Character Traits (SSKCG2)";
            this.Size = new Size(800, 700); // Increased height for more buttons
            this.BackColor = Color.LightPink;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Title Label
            titleLabel = new Label
            {
                Text = "TTS-COMPONENTS Education Edition 2026-2027 GA K",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(20, 10),
                Size = new Size(750, 30),
                TextAlign = ContentAlignment.TopCenter
            };

            // Unit Label
            unitLabel = new Label
            {
                Text = "Unit 8: Positive Character Traits - Being a Good Person (SSKCG2)",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkMagenta,
                Location = new Point(20, 45),
                Size = new Size(750, 25),
                TextAlign = ContentAlignment.TopCenter
            };

            // Character Trait ComboBox
            characterTraitComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 85),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add character traits
            characterTraitComboBox.Items.AddRange(new string[]
            {
                "Honesty",
                "Patriotism",
                "Courtesy",
                "Respect",
                "Pride",
                "Self-Control",
                "All Character Traits Together"
            });

            characterTraitComboBox.SelectedIndexChanged += CharacterTraitComboBox_SelectedIndexChanged;

            // Picture Box for character visuals
            characterPictureBox = new PictureBox
            {
                Location = new Point(20, 120),
                Size = new Size(200, 150),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.White
            };

            // Description Label
            descriptionLabel = new Label
            {
                Location = new Point(240, 120),
                Size = new Size(400, 120),
                Font = new Font("Arial", 10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightYellow,
                Text = "Select a character trait to learn about being a good person!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Examples Panel
            examplesPanel = new Panel
            {
                Location = new Point(20, 280),
                Size = new Size(620, 150),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightCyan
            };

            // Examples Label
            examplesLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(600, 130),
                Font = new Font("Arial", 10),
                BackColor = Color.LightCyan,
                Text = "Examples of positive character traits will be shown here when you select a trait!",
                TextAlign = ContentAlignment.TopLeft
            };

            examplesPanel.Controls.Add(examplesLabel);

            // Navigation Buttons - First Row
            goToUnit1Button = new Button
            {
                Text = "Unit 1 (SSKH1)",
                Location = new Point(20, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit1Button.Click += (s, e) => { new Form1().Show(); this.Hide(); };

            goToUnit2Button = new Button
            {
                Text = "Unit 2 (SSKH2)",
                Location = new Point(120, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };

            goToUnit3Button = new Button
            {
                Text = "Unit 3 (SSKH3)",
                Location = new Point(220, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };

            goToUnit4Button = new Button
            {
                Text = "Unit 4 (SSKG1)",
                Location = new Point(320, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit4Button.Click += (s, e) => { new Unit_4__SSKG1_().Show(); this.Hide(); };

            goToUnit5Button = new Button
            {
                Text = "Unit 5 (SSKG2)",
                Location = new Point(420, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit5Button.Click += (s, e) => { new Unit_5__SSKG2_cs().Show(); this.Hide(); };

            goToUnit6Button = new Button
            {
                Text = "Unit 6 (SSKG3)",
                Location = new Point(520, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit6Button.Click += (s, e) => { new Unit_6__SSKG3_().Show(); this.Hide(); };

            // Navigation Buttons - Second Row
            goToUnit7Button = new Button
            {
                Text = "Unit 7 (SSKCG1)",
                Location = new Point(20, 490),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit7Button.Click += (s, e) => { new Unit_7__SSKCG1_().Show(); this.Hide(); };

            goToUnit9Button = new Button
            {
                Text = "Unit 9 (SSKE1)",
                Location = new Point(130, 490),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit9Button.Click += (s, e) => { new Unit_9__SSKE1_().Show(); this.Hide(); };

            // Previous Button
            previousButton = new Button
            {
                Text = "← Previous Trait",
                Location = new Point(480, 530),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            previousButton.Click += PreviousButton_Click;

            // Next Button
            nextButton = new Button
            {
                Text = "Next Trait →",
                Location = new Point(610, 530),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            nextButton.Click += NextButton_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© 2026-2027 TTS-COMPONENTS Education Edition - Georgia Standards SSKCG2",
                Font = new Font("Arial", 8),
                Location = new Point(20, 600),
                Size = new Size(750, 20),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.Gray
            };

            // Add all controls to form
            this.Controls.AddRange(new Control[]
            {
                titleLabel, unitLabel, characterTraitComboBox, characterPictureBox,
                descriptionLabel, examplesPanel, goToUnit1Button, goToUnit2Button,
                goToUnit3Button, goToUnit4Button, goToUnit5Button, goToUnit6Button,
                goToUnit7Button, goToUnit9Button, previousButton, nextButton, copyrightLabel
            });

            // Set default selection
            characterTraitComboBox.SelectedIndex = 0;
        }

        private void CharacterTraitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCharacterDisplay();
        }

        private void UpdateCharacterDisplay()
        {
            string selectedTrait = characterTraitComboBox.SelectedItem?.ToString();

            switch (selectedTrait)
            {
                case "Honesty":
                    descriptionLabel.Text = "Honesty means telling the truth and being truthful in everything you do. Honest people don't lie, cheat, or try to trick others.";
                    examplesLabel.Text = "💎 HONESTY EXAMPLES:\n\n" +
                                       "• Telling the truth when you break something\n" +
                                       "• Admitting when you make a mistake\n" +
                                       "• Not taking things that don't belong to you\n" +
                                       "• Being truthful about your homework\n" +
                                       "• Telling your parents what really happened\n\n" +
                                       "Honest people are trusted by everyone! ✨";
                    break;

                case "Patriotism":
                    descriptionLabel.Text = "Patriotism means loving your country and being proud to be an American. Patriots respect the flag, say the Pledge of Allegiance, and care about America.";
                    examplesLabel.Text = "🇺🇸 PATRIOTISM EXAMPLES:\n\n" +
                                       "• Standing for the Pledge of Allegiance\n" +
                                       "• Respecting the American flag\n" +
                                       "• Learning about American heroes\n" +
                                       "• Celebrating the 4th of July\n" +
                                       "• Being proud to be an American\n\n" +
                                       "Patriots love their country! 🦅";
                    break;

                case "Courtesy":
                    descriptionLabel.Text = "Courtesy means being polite and kind to others. Courteous people use good manners, say 'please' and 'thank you,' and treat everyone nicely.";
                    examplesLabel.Text = "😊 COURTESY EXAMPLES:\n\n" +
                                       "• Saying 'Please' and 'Thank you'\n" +
                                       "• Holding the door for others\n" +
                                       "• Using kind words when you speak\n" +
                                       "• Waiting your turn in line\n" +
                                       "• Helping someone who dropped something\n\n" +
                                       "Courteous people make everyone feel good! 🌟";
                    break;

                case "Respect":
                    descriptionLabel.Text = "Respect means treating others the way you want to be treated. Respectful people listen to others, follow rules, and care about people's feelings.";
                    examplesLabel.Text = "🤝 RESPECT EXAMPLES:\n\n" +
                                       "• Listening when someone is talking\n" +
                                       "• Following your teacher's instructions\n" +
                                       "• Being kind to people who are different\n" +
                                       "• Taking care of other people's things\n" +
                                       "• Using good manners with everyone\n\n" +
                                       "Respectful people get respect back! ❤️";
                    break;

                case "Pride":
                    descriptionLabel.Text = "Pride means feeling good about doing your best work and being the best person you can be. Pride helps you feel confident and accomplished.";
                    examplesLabel.Text = "⭐ PRIDE EXAMPLES:\n\n" +
                                       "• Doing your best work in school\n" +
                                       "• Taking care of your belongings\n" +
                                       "• Being proud of your family\n" +
                                       "• Feeling good when you help others\n" +
                                       "• Standing up straight and smiling\n\n" +
                                       "Pride helps you feel great about yourself! 🌈";
                    break;

                case "Self-Control":
                    descriptionLabel.Text = "Self-control means controlling your actions and emotions. People with self-control think before they act and make good choices even when it's hard.";
                    examplesLabel.Text = "🧘 SELF-CONTROL EXAMPLES:\n\n" +
                                       "• Raising your hand instead of shouting out\n" +
                                       "• Walking instead of running in the hallway\n" +
                                       "• Using words instead of hitting when angry\n" +
                                       "• Waiting patiently for your turn\n" +
                                       "• Thinking before you speak\n\n" +
                                       "Self-control helps you make good choices! 🎯";
                    break;

                case "All Character Traits Together":
                    descriptionLabel.Text = "When you combine all these character traits, you become an amazing person! Good citizens show honesty, patriotism, courtesy, respect, pride, and self-control.";
                    examplesLabel.Text = "🌟 ALL TRAITS TOGETHER:\n\n" +
                                       "HONESTY + PATRIOTISM + COURTESY + RESPECT + PRIDE + SELF-CONTROL\n\n" +
                                       "= AN AMAZING PERSON! 🏆\n\n" +
                                       "When you practice all these traits every day,\n" +
                                       "you become someone everyone admires and respects.\n\n" +
                                       "YOU can be a person of great character! ✨";
                    break;

                default:
                    descriptionLabel.Text = "Select a character trait to learn about being a good person!";
                    examplesLabel.Text = "Examples of positive character traits will be shown here when you select a trait!";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (characterTraitComboBox.SelectedIndex < characterTraitComboBox.Items.Count - 1)
            {
                characterTraitComboBox.SelectedIndex++;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (characterTraitComboBox.SelectedIndex > 0)
            {
                characterTraitComboBox.SelectedIndex--;
            }
        }
    }
}
