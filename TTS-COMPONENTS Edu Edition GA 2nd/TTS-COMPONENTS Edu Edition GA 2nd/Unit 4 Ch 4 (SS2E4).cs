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
    public partial class Unit_4_Ch_4__SS2E4_ : Form
    {
        private int currentScenarioIndex = 0;
        private List<SavingSpendingScenario> scenarios = new List<SavingSpendingScenario>();
        private bool showingSavingExample = true;

        public Unit_4_Ch_4__SS2E4_()
        {
            InitializeComponent();
            InitializeScenarios();
            DisplayScenario(0);
        }

        private void InitializeScenarios()
        {
            scenarios = new List<SavingSpendingScenario>
            {
                new SavingSpendingScenario
                {
                    Title = "🎮 Video Game vs Saving for Bike",
                    Description = "Maya has $50. She wants a new video game ($50) now, but also wants a bike ($200) later.",
                    SpendingChoice = "Maya buys the video game immediately with her $50.",
                    SavingChoice = "Maya saves her $50 and continues saving to buy the bike later.",
                    SpendingCosts = "• No money left for bike\n• Must wait longer to save for bike\n• Instant gratification but limited future options",
                    SpendingBenefits = "• Gets to play the game right away\n• Immediate fun and entertainment\n• No waiting required",
                    SavingCosts = "• Must wait to have fun\n• Temptation to spend on other things\n• Requires patience and self-control",
                    SavingBenefits = "• Gets closer to bigger goal (bike)\n• Learns patience and planning\n• Will have transportation later\n• Builds good saving habits",
                    LearningPoint = "Spending gives immediate pleasure, but saving helps you reach bigger goals!"
                },

                new SavingSpendingScenario
                {
                    Title = "🍭 Candy Every Day vs Toy Savings",
                    Description = "Alex gets $2 allowance weekly. He can buy candy daily ($10/week) or save for a $40 toy.",
                    SpendingChoice = "Alex spends $10 each week on candy and snacks.",
                    SavingChoice = "Alex saves $2 each week to buy the $40 toy in 20 weeks.",
                    SpendingCosts = "• Spending $40/month on temporary treats\n• Never builds up money for bigger purchases\n• Less healthy food choices",
                    SpendingBenefits = "• Daily treats and immediate satisfaction\n• Variety of different candies to try\n• No waiting or planning needed",
                    SavingCosts = "• No daily treats or candy\n• Must wait 20 weeks for the toy\n• Requires saying 'no' to tempting purchases",
                    SavingBenefits = "• Gets a lasting toy that provides long-term fun\n• Learns to plan and wait for goals\n• Develops self-discipline\n• Has something valuable to show for money",
                    LearningPoint = "Small daily spending adds up! Saving small amounts regularly can buy bigger, better things."
                },

                new SavingSpendingScenario
                {
                    Title = "🎨 Art Supplies: Cheap vs Quality",
                    Description = "Emma needs art supplies. She can buy cheap supplies ($15) that break easily, or save for quality supplies ($45).",
                    SpendingChoice = "Emma buys the cheap art supplies for $15 immediately.",
                    SavingChoice = "Emma saves for 3 months to buy the $45 quality art supplies.",
                    SpendingCosts = "• Supplies break quickly and need replacing\n• Poor quality affects artwork results\n• Ends up spending more money over time ($15 x 3 = $45)",
                    SpendingBenefits = "• Can start art projects immediately\n• Lower upfront cost\n• Gets to use supplies right away",
                    SavingCosts = "• Must wait 3 months to start art projects\n• Higher upfront cost ($45 at once)\n• Temptation to buy cheaper alternatives while waiting",
                    SavingBenefits = "• Supplies last much longer\n• Better quality artwork results\n• Saves money in the long run\n• More satisfaction with purchases",
                    LearningPoint = "Sometimes spending more money upfront saves money over time by buying quality items!"
                },

                new SavingSpendingScenario
                {
                    Title = "🎂 Birthday Money: Spend vs Save",
                    Description = "Jake receives $100 for his birthday. He can spend it all on fun activities or save most of it.",
                    SpendingChoice = "Jake spends all $100 on movies, arcade games, and treats in one weekend.",
                    SavingChoice = "Jake spends $20 on a small celebration and saves $80 for future goals.",
                    SpendingCosts = "• Money is gone after one weekend\n• Nothing to show for it afterward\n• No money for future wants or emergencies",
                    SpendingBenefits = "• Amazing fun weekend with friends\n• Lots of entertainment and treats\n• Creates fun memories\n• No planning or waiting required",
                    SavingCosts = "• Less immediate fun and entertainment\n• Must resist spending temptations\n• Friends might not understand saving choice",
                    SavingBenefits = "• Has money for future opportunities\n• Can help with emergencies or unexpected costs\n• Money grows if put in savings account\n• Provides security and options",
                    LearningPoint = "Balancing some immediate fun with saving gives you both present enjoyment and future security!"
                },

                new SavingSpendingScenario
                {
                    Title = "📱 Phone Case: Now vs Later",
                    Description = "Sofia's phone screen cracked. She can buy a cheap case now ($10) or save for a protective case ($30).",
                    SpendingChoice = "Sofia buys the $10 basic case immediately to protect her phone.",
                    SavingChoice = "Sofia saves for 2 weeks to buy the $30 heavy-duty protective case.",
                    SpendingCosts = "• Basic protection only\n• Phone still at risk of more damage\n• May need to replace case sooner",
                    SpendingBenefits = "• Immediate protection for cracked phone\n• Lower cost right now\n• Quick solution to current problem",
                    SavingCosts = "• Phone remains vulnerable for 2 weeks\n• Risk of more damage while waiting\n• Higher upfront cost when purchased",
                    SavingBenefits = "• Much better protection for phone\n• Prevents costly future phone repairs\n• Case lasts longer\n• Better investment in phone safety",
                    LearningPoint = "Sometimes spending a little more money can prevent much bigger costs later!"
                },

                new SavingSpendingScenario
                {
                    Title = "🍕 Lunch Money: Daily vs Weekly",
                    Description = "Carlos gets $25 weekly for lunch. He can buy lunch daily ($5/day) or bring lunch and save the money.",
                    SpendingChoice = "Carlos buys school lunch every day for $25 per week.",
                    SavingChoice = "Carlos brings lunch from home and saves the $25 weekly ($100/month).",
                    SpendingCosts = "• Spends $100 per month on lunch\n• No money left for other wants\n• Limited lunch choices at school",
                    SpendingBenefits = "• Convenient - no lunch preparation\n• Gets to eat with friends who buy lunch\n• Variety in daily meal choices\n• No planning required",
                    SavingCosts = "• Must prepare lunch daily\n• Takes time and planning\n• Might miss social aspect of buying lunch",
                    SavingBenefits = "• Saves $400 per school year\n• Can buy bigger items or experiences\n• Often healthier homemade food\n• Develops planning and preparation skills",
                    LearningPoint = "Small daily expenses add up to big amounts! Saving on regular expenses creates money for special purchases."
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
                
                // Show saving example by default
                ShowSavingExample();
            }
        }

        private void ShowSavingExample()
        {
            showingSavingExample = true;
            var scenario = scenarios[currentScenarioIndex];
            this.ChoiceTitleLabel.Text = "💰 SAVING CHOICE";
            this.ChoiceDescriptionLabel.Text = scenario.SavingChoice;
            this.CostsLabel.Text = "💸 COSTS OF SAVING:\n" + scenario.SavingCosts;
            this.BenefitsLabel.Text = "✅ BENEFITS OF SAVING:\n" + scenario.SavingBenefits;
            this.SavingButton.BackColor = Color.Green;
            this.SpendingButton.BackColor = Color.LightGray;
        }

        private void ShowSpendingExample()
        {
            showingSavingExample = false;
            var scenario = scenarios[currentScenarioIndex];
            this.ChoiceTitleLabel.Text = "🛍️ SPENDING CHOICE";
            this.ChoiceDescriptionLabel.Text = scenario.SpendingChoice;
            this.CostsLabel.Text = "💸 COSTS OF SPENDING:\n" + scenario.SpendingCosts;
            this.BenefitsLabel.Text = "✅ BENEFITS OF SPENDING:\n" + scenario.SpendingBenefits;
            this.SpendingButton.BackColor = Color.Orange;
            this.SavingButton.BackColor = Color.LightGray;
        }

        private void SavingButton_Click(object sender, EventArgs e)
        {
            ShowSavingExample();
        }

        private void SpendingButton_Click(object sender, EventArgs e)
        {
            ShowSpendingExample();
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            var scenario = scenarios[currentScenarioIndex];
            MessageBox.Show($"COMPARISON: Saving vs Spending\n\n" +
                          $"SAVING CHOICE:\n{scenario.SavingChoice}\n\n" +
                          $"SPENDING CHOICE:\n{scenario.SpendingChoice}\n\n" +
                          $"💡 LESSON: {scenario.LearningPoint}",
                          "Saving vs Spending Comparison",
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
                // Show completion message and offer certificate
                var result = MessageBox.Show("🎉 CONGRATULATIONS! 🎉\n\n" +
                    "You completed Unit 4 Chapter 4 - Saving and Spending Choices!\n\n" +
                    "You learned about:\n" +
                    "💰 SAVING BENEFITS:\n" +
                    "• Helps you reach bigger goals\n" +
                    "• Provides security for emergencies\n" +
                    "• Teaches patience and planning\n" +
                    "• Often saves money in the long run\n\n" +
                    "🛍️ SPENDING BENEFITS:\n" +
                    "• Gives immediate satisfaction\n" +
                    "• Meets current needs and wants\n" +
                    "• Can be convenient and social\n\n" +
                    "Remember: The best choice depends on your goals, needs, and situation!\n\n" +
                    "Would you like to get your Unit 4 Completion Certificate?",
                    "Unit 4 Chapter 4 Complete!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    End_Of_The_Year_Certificate certificateForm = new End_Of_The_Year_Certificate();
                    certificateForm.Show();
                }   
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

        private void SavingConceptButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            switch (clickedButton.Name)
            {
                case "btnWhatIsSaving":
                    this.ConceptExplanationLabel.Text = "💰 WHAT IS SAVING?\n\n" +
                        "Saving means keeping money instead of spending it right away.\n\n" +
                        "Ways to Save:\n" +
                        "• Piggy bank at home\n" +
                        "• Savings account at bank\n" +
                        "• Not buying things you want immediately\n" +
                        "• Setting aside part of allowance or gift money\n\n" +
                        "Saving helps you buy bigger, more expensive things later!\n" +
                        "It also gives you money for emergencies or unexpected opportunities.";
                    break;

                case "btnWhySave":
                    this.ConceptExplanationLabel.Text = "🎯 WHY SHOULD WE SAVE?\n\n" +
                        "Saving money has many important benefits!\n\n" +
                        "Reasons to Save:\n" +
                        "• Buy expensive items you really want\n" +
                        "• Have money for emergencies\n" +
                        "• Learn patience and self-control\n" +
                        "• Make your money grow in savings accounts\n" +
                        "• Have choices when opportunities come up\n" +
                        "• Feel secure and confident about money\n\n" +
                        "People who save money have more options and less stress!";
                    break;

                case "btnSpendingChoices":
                    this.ConceptExplanationLabel.Text = "🛍️ MAKING SPENDING CHOICES\n\n" +
                        "Every time you spend money, you're making a choice!\n\n" +
                        "Good Spending Questions:\n" +
                        "• Do I really need this or just want it?\n" +
                        "• Will this make me happy for a long time?\n" +
                        "• Am I spending more than I have?\n" +
                        "• Could I save this money for something better?\n" +
                        "• Will I regret this purchase later?\n\n" +
                        "Smart spenders think before they buy and choose carefully!";
                    break;

                case "btnOpportunityCost":
                    this.ConceptExplanationLabel.Text = "⚖️ OPPORTUNITY COST\n\n" +
                        "Opportunity cost is what you give up when you make a choice.\n\n" +
                        "Examples:\n" +
                        "• Buy candy now = give up saving for toy later\n" +
                        "• Save for bike = give up immediate fun purchases\n" +
                        "• Buy expensive shoes = give up money for other clothes\n\n" +
                        "Every choice has an opportunity cost!\n" +
                        "Smart people think about what they're giving up\n" +
                        "and make sure their choice is worth it.";
                    break;
            }
        }

        private void Unit4Ch3Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unit_4_Ch_3__SS2E3_ unit4Ch3 = new Unit_4_Ch_3__SS2E3_();
            unit4Ch3.Show();
        }
    }

    public class SavingSpendingScenario
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string SpendingChoice { get; set; } = "";
        public string SavingChoice { get; set; } = "";
        public string SpendingCosts { get; set; } = "";
        public string SpendingBenefits { get; set; } = "";
        public string SavingCosts { get; set; } = "";
        public string SavingBenefits { get; set; } = "";
        public string LearningPoint { get; set; } = "";
    }
}
