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
    public partial class Unit_11__SSKE3_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox moneyTopicComboBox;
        private PictureBox moneyPictureBox;
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
        private Button goToUnit8Button;
        private Button goToUnit9Button;
        private Button goToUnit10Button;
        private Button goToUnit12Button; // Add Unit 12 button

        public Unit_11__SSKE3_()
        {
            InitializeComponent();
            InitializeSSKE3Components();
        }

        private void InitializeSSKE3Components()
        {
            // Form settings
            this.Text = "Unit 11 - Money and Purchasing (SSKE3)";
            this.Size = new Size(800, 740); // Increased height for Unit 12 button
            this.BackColor = Color.LightSteelBlue;
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
                Text = "Unit 11: Money and Purchasing - How We Buy Goods and Services (SSKE3)",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkSlateBlue,
                Location = new Point(20, 45),
                Size = new Size(750, 25),
                TextAlign = ContentAlignment.TopCenter
            };

            // Money Topic ComboBox
            moneyTopicComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 85),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add money topics based on SSKE3 standards
            moneyTopicComboBox.Items.AddRange(new string[]
            {
                "What is Money?",
                "Goods vs Services",
                "U.S. Coins (Pennies, Nickels, Dimes, Quarters)",
                "U.S. Dollar Bills (Paper Money)",
                "How We Use Money to Buy Things",
                "Buying Goods with Money",
                "Buying Services with Money",
                "Counting Money",
                "Making Change",
                "Why We Need Money"
            });

            moneyTopicComboBox.SelectedIndexChanged += MoneyTopicComboBox_SelectedIndexChanged;

            // Picture Box for money visuals
            moneyPictureBox = new PictureBox
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
                Text = "Select a topic to learn about money and how we buy goods and services!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Examples Panel
            examplesPanel = new Panel
            {
                Location = new Point(20, 280),
                Size = new Size(620, 150),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGreen
            };

            // Examples Label
            examplesLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(600, 130),
                Font = new Font("Arial", 10),
                BackColor = Color.LightGreen,
                Text = "Examples about money and purchasing will be shown here when you select a topic!",
                TextAlign = ContentAlignment.TopLeft
            };

            examplesPanel.Controls.Add(examplesLabel);

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

            goToUnit12Button = new Button
            {
                Text = "Unit 12 (SSKE4)",
                Location = new Point(205, 490),
                Size = new Size(85, 30),
                BackColor = Color.Gold, // Special color for final unit
                Font = new Font("Arial", 9, FontStyle.Bold),
                ForeColor = Color.DarkRed
            };
            goToUnit12Button.Click += (s, e) => { new Unit_12__SSKE4_().Show(); this.Hide(); };

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
                Text = "© 2026-2027 TTS-COMPONENTS Education Edition - Georgia Standards SSKE3",
                Font = new Font("Arial", 8),
                Location = new Point(20, 640),
                Size = new Size(750, 20),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.Gray
            };

            // Add all controls to form
            this.Controls.AddRange(new Control[]
            {
                titleLabel, unitLabel, moneyTopicComboBox, moneyPictureBox,
                descriptionLabel, examplesPanel, goToUnit1Button, goToUnit2Button,
                goToUnit3Button, goToUnit4Button, goToUnit5Button, goToUnit6Button,
                goToUnit7Button, goToUnit8Button, goToUnit9Button, goToUnit10Button,
                goToUnit12Button, previousButton, nextButton, copyrightLabel
            });

            // Set default selection
            moneyTopicComboBox.SelectedIndex = 0;
        }

        private void MoneyTopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMoneyDisplay();
        }

        private void UpdateMoneyDisplay()
        {
            string selectedTopic = moneyTopicComboBox.SelectedItem?.ToString();

            switch (selectedTopic)
            {
                case "What is Money?":
                    descriptionLabel.Text = "Money is what we use to buy things we need and want. Money has value and people accept it in exchange for goods and services.";
                    examplesLabel.Text = "💰 WHAT IS MONEY?\n\n" +
                                       "• Money is used to buy things\n" +
                                       "• People accept money for goods and services\n" +
                                       "• Money makes trading easier\n" +
                                       "• Different countries have different money\n" +
                                       "• Money has value that everyone agrees on\n\n" +
                                       "Money helps us get what we need! 💵";
                    break;

                case "Goods vs Services":
                    descriptionLabel.Text = "GOODS are things you can touch and keep (like toys, food, clothes). SERVICES are things people do for you (like haircuts, teaching, fixing things).";
                    examplesLabel.Text = "📦 GOODS vs 🤝 SERVICES:\n\n" +
                                       "GOODS (Things you can touch):\n" +
                                       "• Food, toys, clothes, books, cars\n" +
                                       "• You can hold them and take them home\n\n" +
                                       "SERVICES (Things people do):\n" +
                                       "• Haircuts, teaching, doctor visits\n" +
                                       "• Fixing cars, cleaning, cooking\n\n" +
                                       "Both goods and services cost money! 💡";
                    break;

                case "U.S. Coins (Pennies, Nickels, Dimes, Quarters)":
                    descriptionLabel.Text = "U.S. coins are round pieces of metal money. We have pennies (1¢), nickels (5¢), dimes (10¢), and quarters (25¢).";
                    examplesLabel.Text = "🪙 U.S. COINS:\n\n" +
                                       "• PENNY = 1 cent (1¢) - copper colored\n" +
                                       "• NICKEL = 5 cents (5¢) - bigger, silver\n" +
                                       "• DIME = 10 cents (10¢) - smallest, silver\n" +
                                       "• QUARTER = 25 cents (25¢) - biggest, silver\n\n" +
                                       "Different coins have different values!\n" +
                                       "4 quarters = 1 dollar! 💰";
                    break;

                case "U.S. Dollar Bills (Paper Money)":
                    descriptionLabel.Text = "U.S. dollar bills are paper money. We have $1, $5, $10, $20 bills and more. Paper money is worth more than coins.";
                    examplesLabel.Text = "💵 U.S. DOLLAR BILLS (Paper Money):\n\n" +
                                       "• $1 bill = 1 dollar (George Washington)\n" +
                                       "• $5 bill = 5 dollars (Abraham Lincoln)\n" +
                                       "• $10 bill = 10 dollars (Alexander Hamilton)\n" +
                                       "• $20 bill = 20 dollars (Andrew Jackson)\n\n" +
                                       "Paper money is our main currency!\n" +
                                       "Bills are worth more than coins! 💴";
                    break;

                case "How We Use Money to Buy Things":
                    descriptionLabel.Text = "We give money to stores and people to get things we want. The store gives us goods or services, and we give them money in return.";
                    examplesLabel.Text = "🛒 HOW WE USE MONEY:\n\n" +
                                       "• Go to a store with money\n" +
                                       "• Pick what you want to buy\n" +
                                       "• Give money to the cashier\n" +
                                       "• Take your purchase home\n" +
                                       "• Get change if you paid too much\n\n" +
                                       "Money makes buying things easy! ✨";
                    break;

                case "Buying Goods with Money":
                    descriptionLabel.Text = "We use money to buy goods (things we can touch and keep). Food, toys, clothes, and books are all goods we buy with money.";
                    examplesLabel.Text = "📦 BUYING GOODS WITH MONEY:\n\n" +
                                       "Examples of GOODS we buy:\n" +
                                       "• Food from the grocery store\n" +
                                       "• Toys from the toy store\n" +
                                       "• Clothes from clothing stores\n" +
                                       "• Books from bookstores\n" +
                                       "• School supplies\n\n" +
                                       "Goods are things you can take home! 🏠";
                    break;

                case "Buying Services with Money":
                    descriptionLabel.Text = "We use money to buy services (things people do for us). Haircuts, doctor visits, and car repairs are all services we pay for.";
                    examplesLabel.Text = "🤝 BUYING SERVICES WITH MONEY:\n\n" +
                                       "Examples of SERVICES we buy:\n" +
                                       "• Haircuts at the salon\n" +
                                       "• Doctor and dentist visits\n" +
                                       "• Car repairs at the garage\n" +
                                       "• Restaurant meals (cooking service)\n" +
                                       "• House cleaning\n\n" +
                                       "Services are things people do for you! 👨‍🔧";
                    break;

                case "Counting Money":
                    descriptionLabel.Text = "We need to count money to know how much we have and if we have enough to buy something. Start with the biggest coins and bills first.";
                    examplesLabel.Text = "🔢 COUNTING MONEY:\n\n" +
                                       "• Start with dollar bills first\n" +
                                       "• Then count quarters (25¢ each)\n" +
                                       "• Then count dimes (10¢ each)\n" +
                                       "• Then count nickels (5¢ each)\n" +
                                       "• Finally count pennies (1¢ each)\n\n" +
                                       "Practice counting money every day! 📚";
                    break;

                case "Making Change":
                    descriptionLabel.Text = "When you pay more money than something costs, the store gives you change (money back). If something costs 75¢ and you pay $1, you get 25¢ change.";
                    examplesLabel.Text = "💱 MAKING CHANGE:\n\n" +
                                       "• If you pay more than the price\n" +
                                       "• The store gives you money back\n" +
                                       "• This extra money is called 'change'\n" +
                                       "• Example: Item costs 60¢, you pay 75¢\n" +
                                       "• You get 15¢ change back\n\n" +
                                       "Always check your change! ✅";
                    break;

                case "Why We Need Money":
                    descriptionLabel.Text = "We need money because it makes trading fair and easy. Instead of trading things directly, we use money that everyone accepts and trusts.";
                    examplesLabel.Text = "🌟 WHY WE NEED MONEY:\n\n" +
                                       "• Money makes trading easier\n" +
                                       "• Everyone accepts money as payment\n" +
                                       "• Money has agreed-upon value\n" +
                                       "• We can save money for later\n" +
                                       "• Money helps the economy work\n\n" +
                                       "Money makes our world work better! 🌍";
                    break;

                default:
                    descriptionLabel.Text = "Select a topic to learn about money and how we buy goods and services!";
                    examplesLabel.Text = "Examples about money and purchasing will be shown here when you select a topic!";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (moneyTopicComboBox.SelectedIndex < moneyTopicComboBox.Items.Count - 1)
            {
                moneyTopicComboBox.SelectedIndex++;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (moneyTopicComboBox.SelectedIndex > 0)
            {
                moneyTopicComboBox.SelectedIndex--;
            }
        }
    }
}
