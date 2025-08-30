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
    public partial class Unit_12__SSKE4_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox choiceTopicComboBox;
        private PictureBox choicePictureBox;
        private Label descriptionLabel;
        private Panel choicePanel;
        private Label choiceLabel;
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
        private Button goToUnit8Button;
        private Button goToUnit9Button;
        private Button goToUnit10Button;
        private Button goToUnit11Button;
        private Button completionButton; // Special completion button for final unit

        public Unit_12__SSKE4_()
        {
            InitializeComponent();
            InitializeSSKE4Components();
        }

        private void InitializeSSKE4Components()
        {
            // Form settings
            this.Text = "Unit 12 - Making Choices (SSKE4) - FINAL UNIT!";
            this.Size = new Size(800, 750); // Extra height for completion
            this.BackColor = Color.LightPink;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Title Label
            titleLabel = new Label
            {
                Text = "TTS-COMPONENTS Education Edition 2026-2027 GA K - FINAL UNIT! 🎉",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(20, 10),
                Size = new Size(750, 30),
                TextAlign = ContentAlignment.TopCenter
            };

            // Unit Label
            unitLabel = new Label
            {
                Text = "Unit 12: Making Choices - We Can't Have Everything We Want (SSKE4)",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkMagenta,
                Location = new Point(20, 45),
                Size = new Size(750, 25),
                TextAlign = ContentAlignment.TopCenter
            };

            // Choice Topic ComboBox
            choiceTopicComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 85),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add choice topics based on SSKE4 standards
            choiceTopicComboBox.Items.AddRange(new string[]
            {
                "What Are Choices?",
                "Why Can't We Have Everything?",
                "Limited Money, Unlimited Wants",
                "Choosing Between Toys",
                "Choosing What to Eat",
                "Family Budget Choices",
                "Time Choices - Can't Do Everything",
                "Making Good Choices",
                "What Happens When We Choose",
                "Practice Making Choices"
            });

            choiceTopicComboBox.SelectedIndexChanged += ChoiceTopicComboBox_SelectedIndexChanged;

            // Picture Box for choice visuals
            choicePictureBox = new PictureBox
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
                Text = "Select a topic to learn about making choices because we can't have everything!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Choice Panel
            choicePanel = new Panel
            {
                Location = new Point(20, 280),
                Size = new Size(620, 150),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightCyan
            };

            // Choice Label
            choiceLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(600, 130),
                Font = new Font("Arial", 10),
                BackColor = Color.LightCyan,
                Text = "Information about making choices will be shown here when you select a topic!",
                TextAlign = ContentAlignment.TopLeft
            };

            choicePanel.Controls.Add(choiceLabel);

            // Navigation Buttons - First Row
            goToUnit1Button = new Button
            {
                Text = "Unit 1 (SSKH1)",
                Location = new Point(20, 450),
                Size = new Size(70, 30),
                BackColor = Color.LightCoral
            };
            goToUnit1Button.Click += (s, e) => { new Form1().Show(); this.Hide(); };

            goToUnit2Button = new Button
            {
                Text = "Unit 2 (SSKH2)",
                Location = new Point(100, 450),
                Size = new Size(70, 30),
                BackColor = Color.LightCoral
            };

            goToUnit3Button = new Button
            {
                Text = "Unit 3 (SSKH3)",
                Location = new Point(180, 450),
                Size = new Size(70, 30),
                BackColor = Color.LightCoral
            };

            goToUnit4Button = new Button
            {
                Text = "Unit 4 (SSKG1)",
                Location = new Point(260, 450),
                Size = new Size(70, 30),
                BackColor = Color.LightCoral
            };
            goToUnit4Button.Click += (s, e) => { new Unit_4__SSKG1_().Show(); this.Hide(); };

            goToUnit5Button = new Button
            {
                Text = "Unit 5 (SSKG2)",
                Location = new Point(340, 450),
                Size = new Size(70, 30),
                BackColor = Color.LightCoral
            };
            goToUnit5Button.Click += (s, e) => { new Unit_5__SSKG2_cs().Show(); this.Hide(); };

            goToUnit6Button = new Button
            {
                Text = "Unit 6 (SSKG3)",
                Location = new Point(420, 450),
                Size = new Size(70, 30),
                BackColor = Color.LightCoral
            };
            goToUnit6Button.Click += (s, e) => { new Unit_6__SSKG3_().Show(); this.Hide(); };

            goToUnit7Button = new Button
            {
                Text = "Unit 7 (SSKCG1)",
                Location = new Point(500, 450),
                Size = new Size(80, 30),
                BackColor = Color.LightCoral
            };
            goToUnit7Button.Click += (s, e) => { new Unit_7__SSKCG1_().Show(); this.Hide(); };

            goToUnit8Button = new Button
            {
                Text = "Unit 8 (SSKCG2)",
                Location = new Point(590, 450),
                Size = new Size(80, 30),
                BackColor = Color.LightCoral
            };
            goToUnit8Button.Click += (s, e) => { new Unit_8__SSKCG2_().Show(); this.Hide(); };

            // Navigation Buttons - Second Row
            goToUnit9Button = new Button
            {
                Text = "Unit 9 (SSKE1)",
                Location = new Point(20, 490),
                Size = new Size(80, 30),
                BackColor = Color.LightCoral
            };
            goToUnit9Button.Click += (s, e) => { new Unit_9__SSKE1_().Show(); this.Hide(); };

            goToUnit10Button = new Button
            {
                Text = "Unit 10 (SSKE2)",
                Location = new Point(110, 490),
                Size = new Size(85, 30),
                BackColor = Color.LightCoral
            };
            goToUnit10Button.Click += (s, e) => { new Unit_10__SSKE2_().Show(); this.Hide(); };

            goToUnit11Button = new Button
            {
                Text = "Unit 11 (SSKE3)",
                Location = new Point(205, 490),
                Size = new Size(85, 30),
                BackColor = Color.LightCoral
            };
            goToUnit11Button.Click += (s, e) => { new Unit_11__SSKE3_().Show(); this.Hide(); };

            // Special Completion Button
            completionButton = new Button
            {
                Text = "🎉 CONGRATULATIONS! YOU COMPLETED ALL UNITS! 🎉",
                Location = new Point(300, 490),
                Size = new Size(350, 30),
                BackColor = Color.Gold,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.DarkRed
            };
            completionButton.Click += CompletionButton_Click;

            // Previous Button
            previousButton = new Button
            {
                Text = "← Previous Topic",
                Location = new Point(480, 540),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            previousButton.Click += PreviousButton_Click;

            // Next Button
            nextButton = new Button
            {
                Text = "Next Topic →",
                Location = new Point(610, 540),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            nextButton.Click += NextButton_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© 2026-2027 TTS-COMPONENTS Education Edition - Georgia Standards SSKE4 - FINAL UNIT COMPLETED! 🎓",
                Font = new Font("Arial", 8, FontStyle.Bold),
                Location = new Point(20, 650),
                Size = new Size(750, 20),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.DarkGreen
            };

            // Add all controls to form
            this.Controls.AddRange(new Control[]
            {
                titleLabel, unitLabel, choiceTopicComboBox, choicePictureBox,
                descriptionLabel, choicePanel, goToUnit1Button, goToUnit2Button,
                goToUnit3Button, goToUnit4Button, goToUnit5Button, goToUnit6Button,
                goToUnit7Button, goToUnit8Button, goToUnit9Button, goToUnit10Button,
                goToUnit11Button, completionButton, previousButton, nextButton, copyrightLabel
            });

            // Set default selection
            choiceTopicComboBox.SelectedIndex = 0;
        }

        private void ChoiceTopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChoiceDisplay();
        }

        private void UpdateChoiceDisplay()
        {
            string selectedTopic = choiceTopicComboBox.SelectedItem?.ToString();

            switch (selectedTopic)
            {
                case "What Are Choices?":
                    descriptionLabel.Text = "Choices are decisions we make when we pick one thing instead of another. Every day we make many choices about what to do, what to eat, and what to play with.";
                    choiceLabel.Text = "🤔 WHAT ARE CHOICES?\n\n" +
                                     "• Choices are decisions we make every day\n" +
                                     "• When we pick one thing, we can't pick another\n" +
                                     "• We choose what to wear, eat, and play\n" +
                                     "• Choices help us decide what's most important\n" +
                                     "• Everyone makes choices all the time\n\n" +
                                     "Choices are part of life! 🌟";
                    break;

                case "Why Can't We Have Everything?":
                    descriptionLabel.Text = "We can't have everything we want because there isn't enough money, time, or resources for everyone to have everything. This is why we must choose.";
                    choiceLabel.Text = "🚫 WHY CAN'T WE HAVE EVERYTHING?\n\n" +
                                     "• There isn't enough money to buy everything\n" +
                                     "• There isn't enough time to do everything\n" +
                                     "• Stores don't have unlimited toys and food\n" +
                                     "• Families have to budget their money\n" +
                                     "• We must choose what's most important\n\n" +
                                     "That's why choices are important! 💡";
                    break;

                case "Limited Money, Unlimited Wants":
                    descriptionLabel.Text = "People have limited money but unlimited wants. We always want more toys, clothes, and fun things than we can afford, so we must choose carefully.";
                    choiceLabel.Text = "💰 LIMITED MONEY, UNLIMITED WANTS:\n\n" +
                                     "• Families have a certain amount of money\n" +
                                     "• We want more things than money can buy\n" +
                                     "• We must choose the most important things\n" +
                                     "• Smart families make good spending choices\n" +
                                     "• Saving money helps us buy special things\n\n" +
                                     "Choose wisely with your money! 🧠";
                    break;

                case "Choosing Between Toys":
                    descriptionLabel.Text = "When you want two toys but can only get one, you must choose. Think about which toy you want more and which one will make you happiest.";
                    choiceLabel.Text = "🧸 CHOOSING BETWEEN TOYS:\n\n" +
                                     "• You see two toys you really want\n" +
                                     "• You only have money for one toy\n" +
                                     "• Think about which one you want more\n" +
                                     "• Consider which will make you happier\n" +
                                     "• Make your choice and be happy with it\n\n" +
                                     "Choose the toy that makes you happiest! 😊";
                    break;

                case "Choosing What to Eat":
                    descriptionLabel.Text = "At restaurants or at home, we must choose what to eat. We can't eat everything on the menu, so we pick what we want most or what's healthiest.";
                    choiceLabel.Text = "🍎 CHOOSING WHAT TO EAT:\n\n" +
                                     "• Look at all the food options\n" +
                                     "• Think about what you're hungry for\n" +
                                     "• Consider healthy vs. unhealthy choices\n" +
                                     "• You can only eat so much food\n" +
                                     "• Choose foods that taste good and are good for you\n\n" +
                                     "Make healthy food choices! 🥗";
                    break;

                case "Family Budget Choices":
                    descriptionLabel.Text = "Families must choose how to spend their money. They might choose between a family vacation or new furniture, because they can't afford both.";
                    choiceLabel.Text = "🏠 FAMILY BUDGET CHOICES:\n\n" +
                                     "• Families have limited money each month\n" +
                                     "• They must choose between different things\n" +
                                     "• Vacation or new car? New clothes or toys?\n" +
                                     "• Parents make choices for the whole family\n" +
                                     "• Some choices are needs, some are wants\n\n" +
                                     "Families work together to make good choices! 👨‍👩‍👧‍👦";
                    break;

                case "Time Choices - Can't Do Everything":
                    descriptionLabel.Text = "We also can't do everything we want because there isn't enough time. We must choose between playing different games or doing different activities.";
                    choiceLabel.Text = "⏰ TIME CHOICES:\n\n" +
                                     "• There are only 24 hours in a day\n" +
                                     "• We can't do every fun activity we want\n" +
                                     "• Choose between playground or video games\n" +
                                     "• Choose between TV time or reading time\n" +
                                     "• Make time for important things first\n\n" +
                                     "Use your time wisely! ⏱️";
                    break;

                case "Making Good Choices":
                    descriptionLabel.Text = "Good choices are decisions that help us and make us happy in the long run. Think carefully and choose what's best for you and your family.";
                    choiceLabel.Text = "✅ MAKING GOOD CHOICES:\n\n" +
                                     "• Think before you choose\n" +
                                     "• Consider what's best for you\n" +
                                     "• Ask parents for help with big choices\n" +
                                     "• Choose things that make you truly happy\n" +
                                     "• Learn from choices that don't work out\n\n" +
                                     "Good choices lead to happiness! 😄";
                    break;

                case "What Happens When We Choose":
                    descriptionLabel.Text = "When we choose one thing, we give up something else. This is called an 'opportunity cost' - what we miss out on when we make a choice.";
                    choiceLabel.Text = "⚖️ WHAT HAPPENS WHEN WE CHOOSE:\n\n" +
                                     "• When you choose one thing, you give up another\n" +
                                     "• If you choose ice cream, you give up cake\n" +
                                     "• If you choose to play, you give up TV time\n" +
                                     "• This is called 'opportunity cost'\n" +
                                     "• Every choice has consequences\n\n" +
                                     "Every choice means giving something up! 🔄";
                    break;

                case "Practice Making Choices":
                    descriptionLabel.Text = "Let's practice making choices! Think about real situations where you had to choose between two things you wanted. How did you decide?";
                    choiceLabel.Text = "🎯 PRACTICE MAKING CHOICES:\n\n" +
                                     "PRACTICE SCENARIOS:\n" +
                                     "• Ice cream or cookies for dessert?\n" +
                                     "• Play outside or watch TV?\n" +
                                     "• Red shirt or blue shirt?\n" +
                                     "• Save money or buy a small toy?\n" +
                                     "• Help mom or play with friends?\n\n" +
                                     "Practice makes better choices! 🏆";
                    break;

                default:
                    descriptionLabel.Text = "Select a topic to learn about making choices because we can't have everything!";
                    choiceLabel.Text = "Information about making choices will be shown here when you select a topic!";
                    break;
            }
        }

        private void CompletionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "🎉🎓 CONGRATULATIONS! 🎓🎉\n\n" +
                "You have successfully completed ALL 12 UNITS of the\n" +
                "TTS-COMPONENTS Education Edition 2026-2027 GA K!\n\n" +
                "You learned about:\n" +
                "📚 History (Units 1-3)\n" +
                "🌍 Geography (Units 4-6)\n" +
                "🇺🇸 Civics (Units 7-8)\n" +
                "💰 Economics (Units 9-12)\n\n" +
                "You're now ready for 1st Grade Social Studies!\n\n" +
                "AMAZING JOB! 🌟⭐🎯",
                "🎉 CURRICULUM COMPLETED! 🎉",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (choiceTopicComboBox.SelectedIndex < choiceTopicComboBox.Items.Count - 1)
            {
                choiceTopicComboBox.SelectedIndex++;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (choiceTopicComboBox.SelectedIndex > 0)
            {
                choiceTopicComboBox.SelectedIndex--;
            }
        }
    }
}
