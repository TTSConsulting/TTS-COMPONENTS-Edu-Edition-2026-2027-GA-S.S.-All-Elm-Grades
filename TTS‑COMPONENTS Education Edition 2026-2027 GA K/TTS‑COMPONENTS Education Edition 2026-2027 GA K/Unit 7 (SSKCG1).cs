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
    public partial class Unit_7__SSKCG1_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox citizenshipTopicComboBox;
        private PictureBox citizenshipPictureBox;
        private Label descriptionLabel;
        private Panel rulesPanel;
        private Label rulesLabel;
        private Button nextButton;
        private Button previousButton;
        private Label copyrightLabel;
        private Button goToUnit1Button;
        private Button goToUnit2Button;
        private Button goToUnit3Button;
        private Button goToUnit4Button;
        private Button goToUnit5Button;
        private Button goToUnit6Button;
        private Button goToUnit8Button; // Add this new button variable

        public Unit_7__SSKCG1_()
        {
            InitializeComponent();
            InitializeSSKCG1Components();
        }

        private void InitializeSSKCG1Components()
        {
            // Form settings
            this.Text = "Unit 7 - Good Citizenship (SSKCG1)";
            this.Size = new Size(800, 650);
            this.BackColor = Color.LightBlue;
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
                Text = "Unit 7: Good Citizenship - Rules and Why We Follow Them (SSKCG1)",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                Location = new Point(20, 45),
                Size = new Size(750, 25),
                TextAlign = ContentAlignment.TopCenter
            };

            // Citizenship Topic ComboBox
            citizenshipTopicComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 85),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add citizenship topics
            citizenshipTopicComboBox.Items.AddRange(new string[]
            {
                "What are Rules?",
                "How Rules are Made",
                "Why We Have Rules",
                "Following Rules at Home",
                "Following Rules at School",
                "Following Rules in Community",
                "Good Citizens Follow Rules",
                "What Happens When We Don't Follow Rules"
            });

            citizenshipTopicComboBox.SelectedIndexChanged += CitizenshipTopicComboBox_SelectedIndexChanged;

            // Picture Box for citizenship visuals
            citizenshipPictureBox = new PictureBox
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
                Text = "Select a topic to learn about being a good citizen and following rules!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Rules Panel
            rulesPanel = new Panel
            {
                Location = new Point(20, 280),
                Size = new Size(620, 150),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGreen
            };

            // Rules Label
            rulesLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(600, 130),
                Font = new Font("Arial", 10),
                BackColor = Color.LightGreen,
                Text = "Examples of rules and good citizenship will be shown here when you select a topic!",
                TextAlign = ContentAlignment.TopLeft
            };

            rulesPanel.Controls.Add(rulesLabel);

            // Navigation Buttons
            goToUnit1Button = new Button
            {
                Text = "Unit 1 (SSKH1)",
                Location = new Point(20, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit1Button.Click += (s, e) => { new Form1().Show(); this.Hide(); };

            goToUnit2Button = new Button
            {
                Text = "Unit 2 (SSKH2)",
                Location = new Point(130, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };

            goToUnit3Button = new Button
            {
                Text = "Unit 3 (SSKH3)",
                Location = new Point(240, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };

            goToUnit4Button = new Button
            {
                Text = "Unit 4 (SSKG1)",
                Location = new Point(350, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit4Button.Click += (s, e) => { new Unit_4__SSKG1_().Show(); this.Hide(); };

            goToUnit5Button = new Button
            {
                Text = "Unit 5 (SSKG2)",
                Location = new Point(460, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit5Button.Click += (s, e) => { new Unit_5__SSKG2_cs().Show(); this.Hide(); };

            goToUnit6Button = new Button
            {
                Text = "Unit 6 (SSKG3)",
                Location = new Point(570, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit6Button.Click += (s, e) => { new Unit_6__SSKG3_().Show(); this.Hide(); };

            // Add Unit 8 button
            goToUnit8Button = new Button
            {
                Text = "Unit 8 (SSKCG2)",
                Location = new Point(20, 490),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit8Button.Click += (s, e) => { new Unit_8__SSKCG2_().Show();};

            // Previous Button
            previousButton = new Button
            {
                Text = "← Previous Topic",
                Location = new Point(480, 500),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            previousButton.Click += PreviousButton_Click;

            // Next Button
            nextButton = new Button
            {
                Text = "Next Topic →",
                Location = new Point(610, 500),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            nextButton.Click += NextButton_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© 2026-2027 TTS-COMPONENTS Education Edition - Georgia Standards SSKCG1",
                Font = new Font("Arial", 8),
                Location = new Point(20, 570),
                Size = new Size(750, 20),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.Gray
            };

            // Add all controls to form
            this.Controls.AddRange(new Control[]
            {
                titleLabel, unitLabel, citizenshipTopicComboBox, citizenshipPictureBox,
                descriptionLabel, rulesPanel, goToUnit1Button, goToUnit2Button,
                goToUnit3Button, goToUnit4Button, goToUnit5Button, goToUnit6Button,
                goToUnit8Button, previousButton, nextButton, copyrightLabel
            });

            // Set default selection
            citizenshipTopicComboBox.SelectedIndex = 0;
        }

        private void CitizenshipTopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCitizenshipDisplay();
        }

        private void UpdateCitizenshipDisplay()
        {
            string selectedTopic = citizenshipTopicComboBox.SelectedItem?.ToString();

            switch (selectedTopic)
            {
                case "What are Rules?":
                    descriptionLabel.Text = "Rules are instructions that tell us what we should do and what we should not do. Rules help everyone stay safe and get along with each other.";
                    rulesLabel.Text = "📏 WHAT ARE RULES?\n\n" +
                                    "• Rules tell us what to do and not do\n" +
                                    "• Rules help keep everyone safe\n" +
                                    "• Rules help us be fair to each other\n" +
                                    "• Rules help us work together\n" +
                                    "• Every place has rules (home, school, community)\n\n" +
                                    "Rules make our world a better place! 🌟";
                    break;

                case "How Rules are Made":
                    descriptionLabel.Text = "Rules are made by people in charge who want to help everyone stay safe and happy. Parents make rules at home, teachers make rules at school.";
                    rulesLabel.Text = "👥 HOW RULES ARE MADE:\n\n" +
                                    "• Parents make family rules at home\n" +
                                    "• Teachers and principals make school rules\n" +
                                    "• Government leaders make community rules\n" +
                                    "• Rules are made to help everyone\n" +
                                    "• Good people think carefully about rules\n\n" +
                                    "Rules come from people who care about us! ❤️";
                    break;

                case "Why We Have Rules":
                    descriptionLabel.Text = "We have rules to keep everyone safe, to be fair, and to help people work together peacefully. Rules protect us and help us live happily together.";
                    rulesLabel.Text = "🛡️ WHY WE HAVE RULES:\n\n" +
                                    "• To keep everyone SAFE\n" +
                                    "• To be FAIR to all people\n" +
                                    "• To help us work TOGETHER\n" +
                                    "• To protect people's feelings\n" +
                                    "• To make sure everyone is treated well\n\n" +
                                    "Rules help create a peaceful world! 🕊️";
                    break;

                case "Following Rules at Home":
                    descriptionLabel.Text = "At home, we follow family rules like cleaning up our toys, being kind to family members, and doing what our parents ask us to do.";
                    rulesLabel.Text = "🏠 HOME RULES EXAMPLES:\n\n" +
                                    "• Clean up your toys when finished\n" +
                                    "• Be kind and respectful to family\n" +
                                    "• Listen to Mom and Dad\n" +
                                    "• Share with your brothers and sisters\n" +
                                    "• Use your inside voice in the house\n\n" +
                                    "Good children follow family rules! 👨‍👩‍👧‍👦";
                    break;

                case "Following Rules at School":
                    descriptionLabel.Text = "At school, we follow rules like raising our hand to speak, walking in the hallway, listening to our teacher, and being kind to classmates.";
                    rulesLabel.Text = "🏫 SCHOOL RULES EXAMPLES:\n\n" +
                                    "• Raise your hand before speaking\n" +
                                    "• Walk (don't run) in the hallways\n" +
                                    "• Listen when the teacher is talking\n" +
                                    "• Keep your hands to yourself\n" +
                                    "• Be kind to all classmates\n\n" +
                                    "Good students follow school rules! 📚";
                    break;

                case "Following Rules in Community":
                    descriptionLabel.Text = "In our community, we follow rules like stopping at red lights, not littering, using crosswalks, and being respectful in public places.";
                    rulesLabel.Text = "🏘️ COMMUNITY RULES EXAMPLES:\n\n" +
                                    "• Stop at red lights and stop signs\n" +
                                    "• Don't throw trash on the ground\n" +
                                    "• Use crosswalks to cross streets\n" +
                                    "• Be quiet in libraries\n" +
                                    "• Wait your turn in line\n\n" +
                                    "Good citizens follow community rules! 🚦";
                    break;

                case "Good Citizens Follow Rules":
                    descriptionLabel.Text = "Good citizens are people who follow rules and help make their community a better place. They show respect, kindness, and responsibility.";
                    rulesLabel.Text = "⭐ GOOD CITIZENS:\n\n" +
                                    "• Follow rules even when no one is watching\n" +
                                    "• Help others follow rules too\n" +
                                    "• Show respect for authority\n" +
                                    "• Think about how their actions affect others\n" +
                                    "• Try to make their community better\n\n" +
                                    "YOU can be a good citizen! 🇺🇸";
                    break;

                case "What Happens When We Don't Follow Rules":
                    descriptionLabel.Text = "When people don't follow rules, it can cause problems like someone getting hurt, feelings getting hurt, or things becoming unfair and chaotic.";
                    rulesLabel.Text = "⚠️ WHEN RULES AREN'T FOLLOWED:\n\n" +
                                    "• People might get hurt or feel sad\n" +
                                    "• Things become unfair\n" +
                                    "• There might be consequences\n" +
                                    "• Trust is broken\n" +
                                    "• Everyone's day becomes harder\n\n" +
                                    "That's why following rules is so important! ✅";
                    break;

                default:
                    descriptionLabel.Text = "Select a topic to learn about being a good citizen and following rules!";
                    rulesLabel.Text = "Examples of rules and good citizenship will be shown here when you select a topic!";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (citizenshipTopicComboBox.SelectedIndex < citizenshipTopicComboBox.Items.Count - 1)
            {
                citizenshipTopicComboBox.SelectedIndex++;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (citizenshipTopicComboBox.SelectedIndex > 0)
            {
                citizenshipTopicComboBox.SelectedIndex--;
            }
        }
    }
}
