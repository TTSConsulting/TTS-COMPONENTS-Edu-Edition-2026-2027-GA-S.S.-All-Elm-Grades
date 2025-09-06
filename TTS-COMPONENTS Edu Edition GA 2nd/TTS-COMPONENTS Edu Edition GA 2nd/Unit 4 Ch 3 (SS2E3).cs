using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition_GA_2nd
{
    public partial class Unit_4_Ch_3__SS2E3_ : Form
    {
        private int currentScenarioIndex = 0;
        private List<TradeScenario> scenarios = new List<TradeScenario>();
        private bool showingBarterExample = true;

        public Unit_4_Ch_3__SS2E3_()
        {
            InitializeComponent();
            InitializeScenarios();
            DisplayScenario(0);
        }

        private void InitializeScenarios()
        {
            scenarios = new List<TradeScenario>
            {
                new TradeScenario
                {
                    Title = "🍎 Trading for Lunch",
                    Description = "Emma has an apple but wants a sandwich. How can she get what she wants?",
                    BarterExample = "Emma trades her apple directly to Jake for his sandwich. But what if Jake doesn't want an apple?",
                    MoneyExample = "Emma sells her apple for $2, then uses the $2 to buy a sandwich from the cafeteria.",
                    BarterProblems = "• Jake might not want Emma's apple\n• Hard to find someone who wants what you have AND has what you want\n• What if the apple and sandwich have different values?",
                    MoneyAdvantages = "• Emma can sell to anyone who wants an apple\n• She can use money to buy from anyone\n• Money shows exact value ($2 = $2)",
                    LearningPoint = "Money makes trading easier because everyone accepts it and it shows clear value!"
                },

                new TradeScenario
                {
                    Title = "🧸 Toy Store Trade",
                    Description = "Alex wants a new toy car that costs $10. He has old toys he doesn't play with anymore.",
                    BarterExample = "Alex tries to trade his old robot toy directly for the new car, but the store owner says no.",
                    MoneyExample = "Alex sells his old toys for $12, then uses $10 to buy the new car and keeps $2.",
                    BarterProblems = "• Store might not want Alex's old toys\n• Hard to know if old robot equals new car in value\n• Store has many customers with different wants",
                    MoneyAdvantages = "• Store accepts money from everyone\n• Clear price: $10 for the car\n• Alex can sell toys to someone who wants them",
                    LearningPoint = "Stores use money because they can't trade toys with everyone who wants different things!"
                },

                new TradeScenario
                {
                    Title = "📚 Book Exchange",
                    Description = "Sarah has 3 books she's read and wants 1 new book from the bookstore.",
                    BarterExample = "Sarah offers to trade her 3 books for 1 new book, but the bookstore says her books are old.",
                    MoneyExample = "Sarah sells her 3 books for $6 total, then buys a new book for $8 (needs $2 more from allowance).",
                    BarterProblems = "• Used books worth less than new books\n• Bookstore already has those books\n• Hard to agree on how many old books = 1 new book",
                    MoneyAdvantages = "• Money shows exact value: old books = $6, new book = $8\n• Sarah knows she needs $2 more\n• Bookstore can use $6 for anything",
                    LearningPoint = "Money helps us understand the exact value of different things!"
                },

                new TradeScenario
                {
                    Title = "🎮 Video Game Trade",
                    Description = "Mike wants to buy a video game that costs $30. He has several items he could trade.",
                    BarterExample = "Mike tries to trade his bike, skateboard, and baseball cards directly for the game.",
                    MoneyExample = "Mike sells his bike for $20, skateboard for $8, and cards for $5, then buys the game for $30.",
                    BarterProblems = "• Game store doesn't need a bike or skateboard\n• Too many items to carry and trade at once\n• Store owner can't use Mike's stuff in the business",
                    MoneyAdvantages = "• Money is easy to carry ($33 fits in wallet)\n• Store accepts money for any purchase\n• Mike has $3 left over for snacks",
                    LearningPoint = "Money is much easier to carry and use than trading many different objects!"
                },

                new TradeScenario
                {
                    Title = "🍕 Pizza Party Planning",
                    Description = "The class wants to order pizza. Each student has different things to contribute.",
                    BarterExample = "Students try to trade toys, snacks, and supplies directly to the pizza place for pizza.",
                    MoneyExample = "Each student contributes $3, and the teacher uses the $60 to order pizza for the class.",
                    BarterProblems = "• Pizza place doesn't want toys and snacks\n• Hard to know if everyone's contribution is fair\n• Too confusing with 20 different items",
                    MoneyAdvantages = "• Everyone contributes the same amount: $3\n• Pizza place accepts money easily\n• Simple: $60 buys exactly 4 large pizzas",
                    LearningPoint = "Money makes group purchases fair and simple for everyone!"
                },

                new TradeScenario
                {
                    Title = "🚲 Bike Repair Service",
                    Description = "Lucy's bike has a flat tire. The bike shop charges $15 to fix it.",
                    BarterExample = "Lucy offers to clean the bike shop for 2 hours instead of paying money.",
                    MoneyExample = "Lucy pays $15 and gets her bike fixed immediately.",
                    BarterProblems = "• Shop owner might not need cleaning help\n• Takes extra time to arrange work schedule\n• Hard to know if 2 hours work = $15",
                    MoneyAdvantages = "• Quick and easy transaction\n• Shop owner can use $15 for anything needed\n• Lucy gets bike back right away",
                    LearningPoint = "Money saves time and makes business transactions quick and fair!"
                },

                new TradeScenario
                {
                    Title = "🎨 Art Supplies Shopping",
                    Description = "Kevin needs colored pencils, paper, and glue for his art project.",
                    BarterExample = "Kevin tries to trade his old art projects to get new supplies from different stores.",
                    MoneyExample = "Kevin uses his $20 allowance to buy all supplies from the art store.",
                    BarterProblems = "• Each store might want different things\n• Kevin's old art might not be worth enough\n• Takes all day visiting different stores",
                    MoneyAdvantages = "• One trip to one store\n• All stores accept money\n• Kevin knows exactly what he can afford with $20",
                    LearningPoint = "Money lets you shop at any store and buy everything you need in one trip!"
                },

                new TradeScenario
                {
                    Title = "🏪 Corner Store Snacks",
                    Description = "Maria wants to buy a drink and chips after school. The total cost is $3.50.",
                    BarterExample = "Maria offers to trade her homework help for snacks, but the store owner needs money to pay bills.",
                    MoneyExample = "Maria pays $3.50 and gets her snacks immediately.",
                    BarterProblems = "• Store owner needs money to pay rent and electricity\n• Homework help doesn't pay the store's bills\n• Other customers waiting in line",
                    MoneyAdvantages = "• Store can use money to pay all business expenses\n• Fast transaction keeps line moving\n• Maria gets exactly what she wants",
                    LearningPoint = "Businesses need money to operate and serve all their customers fairly!"
                }
            };
        }

        private void DisplayScenario(int index)
        {
            if (index >= 0 && index < scenarios.Count)
            {
                var scenario = scenarios[index];
                this.ScenarioTitleLabel.Text = scenario.Title;
                this.ScenarioDescriptionLabel.Text = scenario.Description;
                this.ProgressLabel.Text = $"Scenario {index + 1} of {scenarios.Count}";
                
                // Show barter example by default
                ShowBarterExample();
            }
        }

        private void ShowBarterExample()
        {
            showingBarterExample = true;
            var scenario = scenarios[currentScenarioIndex];
            this.ExampleTitleLabel.Text = "🔄 BARTER SYSTEM (Trading Objects)";
            this.ExampleDescriptionLabel.Text = scenario.BarterExample;
            this.ProblemsAdvantagesLabel.Text = "❌ PROBLEMS WITH BARTER:\n" + scenario.BarterProblems;
            this.ProblemsAdvantagesLabel.ForeColor = Color.DarkRed;
            this.BarterButton.BackColor = Color.Orange;
            this.MoneyButton.BackColor = Color.LightGray;
        }

        private void ShowMoneyExample()
        {
            showingBarterExample = false;
            var scenario = scenarios[currentScenarioIndex];
            this.ExampleTitleLabel.Text = "💰 MONEY SYSTEM (Using Currency)";
            this.ExampleDescriptionLabel.Text = scenario.MoneyExample;
            this.ProblemsAdvantagesLabel.Text = "✅ ADVANTAGES OF MONEY:\n" + scenario.MoneyAdvantages;
            this.ProblemsAdvantagesLabel.ForeColor = Color.DarkGreen;
            this.MoneyButton.BackColor = Color.Green;
            this.BarterButton.BackColor = Color.LightGray;
        }

        private void BarterButton_Click(object sender, EventArgs e)
        {
            ShowBarterExample();
        }

        private void MoneyButton_Click(object sender, EventArgs e)
        {
            ShowMoneyExample();
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            var scenario = scenarios[currentScenarioIndex];
            MessageBox.Show($"COMPARISON: Barter vs Money\n\n" +
                          $"BARTER PROBLEMS:\n{scenario.BarterProblems}\n\n" +
                          $"MONEY ADVANTAGES:\n{scenario.MoneyAdvantages}\n\n" +
                          $"💡 LESSON: {scenario.LearningPoint}",
                          "Barter vs Money Comparison",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentScenarioIndex < scenarios.Count - 1)
            {
                currentScenarioIndex++;
                DisplayScenario(currentScenarioIndex);
            }
            else
            {
                // Show completion message
                MessageBox.Show("🎉 CONGRATULATIONS! 🎉\n\n" +
                    "You completed Unit 4 Chapter 3 - Money and Trade!\n\n" +
                    "You learned that:\n" +
                    "💰 MONEY makes trade easier than barter because:\n" +
                    "• Everyone accepts money as payment\n" +
                    "• Money shows exact value of goods and services\n" +
                    "• Money is easy to carry and use\n" +
                    "• Businesses need money to operate\n" +
                    "• Money saves time in transactions\n\n" +
                    "🔄 BARTER (trading objects) has problems:\n" +
                    "• Hard to find someone who wants what you have\n" +
                    "• Difficult to determine fair trade values\n" +
                    "• Takes more time and effort\n\n" +
                    "Remember: Money is a tool that makes buying and selling much easier for everyone!",
                    "Unit 4 Chapter 3 Complete!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentScenarioIndex > 0)
            {
                currentScenarioIndex--;
                DisplayScenario(currentScenarioIndex);
            }
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void MoneyConceptButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            switch (clickedButton.Name)
            {
                case "btnWhatIsMoney":
                    this.ConceptExplanationLabel.Text = "💰 WHAT IS MONEY?\n\n" +
                        "Money is something that everyone agrees has value and can be used to buy things.\n\n" +
                        "Types of Money:\n" +
                        "• Coins: pennies, nickels, dimes, quarters\n" +
                        "• Bills: $1, $5, $10, $20, etc.\n" +
                        "• Digital: money on cards and phones\n\n" +
                        "Money represents value so we don't have to trade objects directly.\n" +
                        "Everyone trusts that money can be used to buy goods and services!";
                    break;

                case "btnWhyUseMoney":
                    this.ConceptExplanationLabel.Text = "🤔 WHY DO WE USE MONEY?\n\n" +
                        "Money solves the problems of barter (trading objects directly).\n\n" +
                        "Money Benefits:\n" +
                        "• Everyone accepts it as payment\n" +
                        "• Easy to carry in your pocket or wallet\n" +
                        "• Shows exact value ($5 is always $5)\n" +
                        "• Can be saved for later purchases\n" +
                        "• Makes buying and selling fast and fair\n\n" +
                        "Without money, you'd have to find someone who wants exactly what you have!";
                    break;

                case "btnBarterProblems":
                    this.ConceptExplanationLabel.Text = "🔄 PROBLEMS WITH BARTER\n\n" +
                        "Barter means trading one thing directly for another thing.\n\n" +
                        "Why Barter is Hard:\n" +
                        "• 'Double Coincidence of Wants' - you need someone who wants your item AND has what you want\n" +
                        "• Hard to decide fair trades (is 1 toy = 3 books?)\n" +
                        "• Some things can't be divided (can't trade half a cow!)\n" +
                        "• Takes a long time to find trading partners\n" +
                        "• Difficult to save value for the future\n\n" +
                        "This is why people invented money to make trade easier!";
                    break;

                case "btnMoneyHistory":
                    this.ConceptExplanationLabel.Text = "📜 HISTORY OF MONEY\n\n" +
                        "People have used many different things as money throughout history!\n\n" +
                        "Historical Money:\n" +
                        "• Shells and beads (very old times)\n" +
                        "• Salt (so valuable we say 'worth your salt')\n" +
                        "• Gold and silver coins\n" +
                        "• Paper money (easier to carry than gold)\n" +
                        "• Credit cards and digital money (today)\n\n" +
                        "The best money is something everyone agrees is valuable,\n" +
                        "easy to carry, and doesn't spoil or break easily!";
                    break;
            }
        }

        private void Unit4Ch2Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unit_4_Ch_2__SS2E2_ unit4Ch2 = new Unit_4_Ch_2__SS2E2_();
            unit4Ch2.Show();
        }

        private void Unit4Ch4Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unit_4_Ch_4__SS2E4_ unit4Ch4 = new Unit_4_Ch_4__SS2E4_();
            unit4Ch4.Show();
        }
    }

    public class TradeScenario
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string BarterExample { get; set; } = "";
        public string MoneyExample { get; set; } = "";
        public string BarterProblems { get; set; } = "";
        public string MoneyAdvantages { get; set; } = "";
        public string LearningPoint { get; set; } = "";
    }
}
