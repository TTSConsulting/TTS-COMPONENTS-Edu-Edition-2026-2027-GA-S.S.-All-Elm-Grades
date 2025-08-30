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
    public partial class Unit_10__SSKE2_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox incomeTopicComboBox;
        private PictureBox incomePictureBox;
        private Label descriptionLabel;
        private Panel incomePanel;
        private Label incomeLabel;
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

        public Unit_10__SSKE2_()
        {
            InitializeComponent();
            InitializeSSKE2Components();
        }

        private void InitializeSSKE2Components()
        {
            // Form settings
            this.Text = "Unit 10 - Earning Income by Working (SSKE2)";
            this.Size = new Size(800, 700);
            this.BackColor = Color.LightGoldenrodYellow;
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
                Text = "Unit 10: Earning Income by Working - How People Make Money (SSKE2)",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkGoldenrod,
                Location = new Point(20, 45),
                Size = new Size(750, 25),
                TextAlign = ContentAlignment.TopCenter
            };

            // Income Topic ComboBox
            incomeTopicComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 85),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add income topics
            incomeTopicComboBox.Items.AddRange(new string[]
            {
                "What is Income?",
                "How Do People Earn Money?",
                "Different Jobs, Different Pay",
                "Working Hard Earns Money",
                "Money for Buying Things",
                "Saving Money from Work",
                "Parents Work to Earn Money",
                "Why People Need to Work"
            });

            incomeTopicComboBox.SelectedIndexChanged += IncomeTopicComboBox_SelectedIndexChanged;

            // Picture Box for income visuals
            incomePictureBox = new PictureBox
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
                Text = "Select a topic to learn about how people earn income by working!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Income Panel
            incomePanel = new Panel
            {
                Location = new Point(20, 280),
                Size = new Size(620, 150),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGreen
            };

            // Income Label
            incomeLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(600, 130),
                Font = new Font("Arial", 10),
                BackColor = Color.LightGreen,
                Text = "Information about earning income will be shown here when you select a topic!",
                TextAlign = ContentAlignment.TopLeft
            };

            incomePanel.Controls.Add(incomeLabel);

            // Navigation Buttons - First Row
            goToUnit1Button = new Button
            {
                Text = "Unit 1 (SSKH1)",
                Location = new Point(20, 450),
                Size = new Size(85, 30),
                BackColor = Color.LightCoral
            };
            goToUnit1Button.Click += (s, e) => { new Form1().Show(); this.Hide(); };

            goToUnit2Button = new Button
            {
                Text = "Unit 2 (SSKH2)",
                Location = new Point(115, 450),
                Size = new Size(85, 30),
                BackColor = Color.LightCoral
            };

            goToUnit3Button = new Button
            {
                Text = "Unit 3 (SSKH3)",
                Location = new Point(210, 450),
                Size = new Size(85, 30),
                BackColor = Color.LightCoral
            };

            goToUnit4Button = new Button
            {
                Text = "Unit 4 (SSKG1)",
                Location = new Point(305, 450),
                Size = new Size(85, 30),
                BackColor = Color.LightCoral
            };
            goToUnit4Button.Click += (s, e) => { new Unit_4__SSKG1_().Show(); this.Hide(); };

            goToUnit5Button = new Button
            {
                Text = "Unit 5 (SSKG2)",
                Location = new Point(400, 450),
                Size = new Size(85, 30),
                BackColor = Color.LightCoral
            };
            goToUnit5Button.Click += (s, e) => { new Unit_5__SSKG2_cs().Show(); this.Hide(); };

            goToUnit6Button = new Button
            {
                Text = "Unit 6 (SSKG3)",
                Location = new Point(495, 450),
                Size = new Size(85, 30),
                BackColor = Color.LightCoral
            };
            goToUnit6Button.Click += (s, e) => { new Unit_6__SSKG3_().Show(); this.Hide(); };

            goToUnit7Button = new Button
            {
                Text = "Unit 7 (SSKCG1)",
                Location = new Point(590, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit7Button.Click += (s, e) => { new Unit_7__SSKCG1_().Show(); this.Hide(); };

            // Navigation Buttons - Second Row
            goToUnit8Button = new Button
            {
                Text = "Unit 8 (SSKCG2)",
                Location = new Point(20, 490),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit8Button.Click += (s, e) => { new Unit_8__SSKCG2_().Show(); this.Hide(); };

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
                Text = "← Previous Topic",
                Location = new Point(480, 530),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            previousButton.Click += PreviousButton_Click;

            // Next Button
            nextButton = new Button
            {
                Text = "Next Topic →",
                Location = new Point(610, 530),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            nextButton.Click += NextButton_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© 2026-2027 TTS-COMPONENTS Education Edition - Georgia Standards SSKE2",
                Font = new Font("Arial", 8),
                Location = new Point(20, 600),
                Size = new Size(750, 20),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.Gray
            };

            // Add all controls to form
            this.Controls.AddRange(new Control[]
            {
                titleLabel, unitLabel, incomeTopicComboBox, incomePictureBox,
                descriptionLabel, incomePanel, goToUnit1Button, goToUnit2Button,
                goToUnit3Button, goToUnit4Button, goToUnit5Button, goToUnit6Button,
                goToUnit7Button, goToUnit8Button, goToUnit9Button, previousButton, 
                nextButton, copyrightLabel
            });

            // Set default selection
            incomeTopicComboBox.SelectedIndex = 0;
        }

        private void IncomeTopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIncomeDisplay();
        }

        private void UpdateIncomeDisplay()
        {
            string selectedTopic = incomeTopicComboBox.SelectedItem?.ToString();

            switch (selectedTopic)
            {
                case "What is Income?":
                    descriptionLabel.Text = "Income is money that people earn when they work. When someone does a job, they get paid money for their work. This money is called income.";
                    incomeLabel.Text = "💰 WHAT IS INCOME?\n\n" +
                                     "• Income is money you earn from working\n" +
                                     "• People get paid for doing their jobs\n" +
                                     "• Income helps people buy things they need\n" +
                                     "• Different jobs earn different amounts\n" +
                                     "• Income lets people take care of their families\n\n" +
                                     "Income is the money you earn for working! 💵";
                    break;

                case "How Do People Earn Money?":
                    descriptionLabel.Text = "People earn money by doing jobs and working hard. They use their skills and time to help others, and in return, they receive money for their work.";
                    incomeLabel.Text = "👷‍♂️ HOW PEOPLE EARN MONEY:\n\n" +
                                     "• Teachers earn money by teaching students\n" +
                                     "• Doctors earn money by helping sick people\n" +
                                     "• Farmers earn money by growing food\n" +
                                     "• Store workers earn money by helping customers\n" +
                                     "• Police officers earn money by keeping us safe\n\n" +
                                     "People work hard to earn their money! 💪";
                    break;

                case "Different Jobs, Different Pay":
                    descriptionLabel.Text = "Different jobs earn different amounts of money. Some jobs require more training or education, and those jobs usually pay more money.";
                    incomeLabel.Text = "📊 DIFFERENT JOBS, DIFFERENT PAY:\n\n" +
                                     "• Some jobs pay more money than others\n" +
                                     "• Jobs that need special training pay more\n" +
                                     "• Doctors study for many years and earn more\n" +
                                     "• All honest work is valuable and important\n" +
                                     "• Every job helps our community\n\n" +
                                     "All jobs are important, no matter the pay! ⭐";
                    break;

                case "Working Hard Earns Money":
                    descriptionLabel.Text = "When people work hard and do their best, they earn money. The harder and better someone works, the more successful they can become.";
                    incomeLabel.Text = "💪 WORKING HARD EARNS MONEY:\n\n" +
                                     "• Hard work is rewarded with income\n" +
                                     "• People who do their best earn money\n" +
                                     "• Being responsible at work is important\n" +
                                     "• Good workers often earn more over time\n" +
                                     "• Hard work makes people feel proud\n\n" +
                                     "Hard work pays off! 🏆";
                    break;

                case "Money for Buying Things":
                    descriptionLabel.Text = "People use the money they earn from working to buy things they need and want, like food, clothes, toys, and a place to live.";
                    incomeLabel.Text = "🛒 MONEY FOR BUYING THINGS:\n\n" +
                                     "• Income lets people buy food to eat\n" +
                                     "• People buy clothes to wear\n" +
                                     "• Families buy or rent homes to live in\n" +
                                     "• Money can buy toys and fun things\n" +
                                     "• Income helps pay for important things\n\n" +
                                     "Work gives us money to buy what we need! 🏠";
                    break;

                case "Saving Money from Work":
                    descriptionLabel.Text = "Smart people save some of the money they earn from working. Saving money helps them buy bigger things later or have money for emergencies.";
                    incomeLabel.Text = "🏦 SAVING MONEY FROM WORK:\n\n" +
                                     "• People save some of their income\n" +
                                     "• Saving helps buy bigger things later\n" +
                                     "• Saved money helps in emergencies\n" +
                                     "• Piggy banks help children save\n" +
                                     "• Saving money is a smart habit\n\n" +
                                     "Saving money is very smart! 🐷";
                    break;

                case "Parents Work to Earn Money":
                    descriptionLabel.Text = "Your parents work every day to earn money for your family. They use this money to buy food, pay for your home, and take care of you.";
                    incomeLabel.Text = "👨‍👩‍👧‍👦 PARENTS WORK FOR FAMILIES:\n\n" +
                                     "• Moms and dads work to earn money\n" +
                                     "• They buy food for the family\n" +
                                     "• They pay for the house and utilities\n" +
                                     "• They buy clothes and school supplies\n" +
                                     "• Parents work hard to take care of you\n\n" +
                                     "Thank your parents for working hard! ❤️";
                    break;

                case "Why People Need to Work":
                    descriptionLabel.Text = "People need to work to earn money so they can take care of themselves and their families. Work also helps people feel good about helping others.";
                    incomeLabel.Text = "🌟 WHY PEOPLE NEED TO WORK:\n\n" +
                                     "• Work provides money for basic needs\n" +
                                     "• People feel good when they help others\n" +
                                     "• Work gives people a sense of purpose\n" +
                                     "• Working helps build communities\n" +
                                     "• Everyone contributes by working\n\n" +
                                     "Work makes our world a better place! 🌍";
                    break;

                default:
                    descriptionLabel.Text = "Select a topic to learn about how people earn income by working!";
                    incomeLabel.Text = "Information about earning income will be shown here when you select a topic!";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (incomeTopicComboBox.SelectedIndex < incomeTopicComboBox.Items.Count - 1)
            {
                incomeTopicComboBox.SelectedIndex++;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (incomeTopicComboBox.SelectedIndex > 0)
            {
                incomeTopicComboBox.SelectedIndex--;
            }
        }
    }
}
