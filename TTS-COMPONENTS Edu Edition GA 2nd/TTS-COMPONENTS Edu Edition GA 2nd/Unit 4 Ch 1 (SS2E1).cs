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
    public partial class Unit_4_Ch_1__SS2E1_ : Form
    {
        private int currentScenarioIndex = 0;
        private List<ChoiceScenario> scenarios = new List<ChoiceScenario>();

        public Unit_4_Ch_1__SS2E1_()
        {
            InitializeComponent();
            InitializeScenarios();
            DisplayScenario(0);
        }

        private void InitializeScenarios()
        {
            scenarios = new List<ChoiceScenario>
            {
                new ChoiceScenario
                {
                    Title = "🍎 Snack Time Choice",
                    Description = "You have $2 to spend on a snack. You can only choose ONE:",
                    Choice1 = "🍪 Cookies ($2)",
                    Choice2 = "🍎 Apple ($2)", 
                    Choice3 = "🥨 Pretzel ($2)",
                    ScarcityExplanation = "💰 SCARCITY: You only have $2, so you can't buy everything you want!",
                    OpportunityCost1 = "If you choose cookies, you give up the apple and pretzel.",
                    OpportunityCost2 = "If you choose apple, you give up the cookies and pretzel.",
                    OpportunityCost3 = "If you choose pretzel, you give up the cookies and apple.",
                    Lesson = "When we don't have enough money for everything, we must choose what we want most!"
                },

                new ChoiceScenario
                {
                    Title = "🎮 Toy Store Choice",
                    Description = "You saved $10 for a toy. You can only buy ONE:",
                    Choice1 = "🎮 Video Game ($10)",
                    Choice2 = "🧸 Teddy Bear ($10)",
                    Choice3 = "🚗 Toy Car ($10)",
                    ScarcityExplanation = "💰 SCARCITY: You only saved $10, so you must choose just one toy!",
                    OpportunityCost1 = "If you buy the video game, you give up the teddy bear and toy car.",
                    OpportunityCost2 = "If you buy the teddy bear, you give up the video game and toy car.", 
                    OpportunityCost3 = "If you buy the toy car, you give up the video game and teddy bear.",
                    Lesson = "Our money is limited, so we must choose the toy we want most!"
                },

                new ChoiceScenario
                {
                    Title = "⏰ After School Choice",
                    Description = "You have 1 hour after school. You can only do ONE activity:",
                    Choice1 = "⚽ Play Soccer (1 hour)",
                    Choice2 = "📚 Read a Book (1 hour)",
                    Choice3 = "🎨 Draw Pictures (1 hour)",
                    ScarcityExplanation = "⏰ SCARCITY: You only have 1 hour, so you can't do all activities!",
                    OpportunityCost1 = "If you play soccer, you give up reading and drawing.",
                    OpportunityCost2 = "If you read, you give up playing soccer and drawing.",
                    OpportunityCost3 = "If you draw, you give up playing soccer and reading.",
                    Lesson = "Time is scarce! We must choose how to use our time wisely!"
                },

                new ChoiceScenario
                {
                    Title = "🍰 Birthday Party Choice",
                    Description = "At the party, you can have ONE piece of cake:",
                    Choice1 = "🍰 Chocolate Cake",
                    Choice2 = "🎂 Vanilla Cake", 
                    Choice3 = "🧁 Strawberry Cupcake",
                    ScarcityExplanation = "🍰 SCARCITY: There's only enough cake for one piece per person!",
                    OpportunityCost1 = "If you choose chocolate, you give up vanilla and strawberry.",
                    OpportunityCost2 = "If you choose vanilla, you give up chocolate and strawberry.",
                    OpportunityCost3 = "If you choose strawberry, you give up chocolate and vanilla.",
                    Lesson = "Even at parties, resources are limited and we must make choices!"
                },

                new ChoiceScenario
                {
                    Title = "📚 Library Book Choice",
                    Description = "You can check out 2 books from the library. Choose wisely:",
                    Choice1 = "📖 Adventure Story",
                    Choice2 = "🦕 Dinosaur Book",
                    Choice3 = "🌟 Space Book",
                    ScarcityExplanation = "📚 SCARCITY: Library rules limit you to only 2 books at a time!",
                    OpportunityCost1 = "If you choose adventure + dinosaur, you give up the space book.",
                    OpportunityCost2 = "If you choose adventure + space, you give up the dinosaur book.",
                    OpportunityCost3 = "If you choose dinosaur + space, you give up the adventure book.",
                    Lesson = "Libraries have rules that create scarcity - we can't take all the books home!"
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
                this.Choice1Button.Text = scenario.Choice1;
                this.Choice2Button.Text = scenario.Choice2;
                this.Choice3Button.Text = scenario.Choice3;
                this.ScarcityLabel.Text = scenario.ScarcityExplanation;
                this.OpportunityCostLabel.Text = "Click a choice to see the opportunity cost!";
                this.LessonLabel.Text = scenario.Lesson;
                this.ProgressLabel.Text = $"Scenario {index + 1} of {scenarios.Count}";
            }
        }

        private void Choice1Button_Click(object sender, EventArgs e)
        {
            var scenario = scenarios[currentScenarioIndex];
            this.OpportunityCostLabel.Text = $"🔄 OPPORTUNITY COST: {scenario.OpportunityCost1}";
            this.OpportunityCostLabel.ForeColor = Color.Red;
        }

        private void Choice2Button_Click(object sender, EventArgs e)
        {
            var scenario = scenarios[currentScenarioIndex];
            this.OpportunityCostLabel.Text = $"🔄 OPPORTUNITY COST: {scenario.OpportunityCost2}";
            this.OpportunityCostLabel.ForeColor = Color.Red;
        }

        private void Choice3Button_Click(object sender, EventArgs e)
        {
            var scenario = scenarios[currentScenarioIndex];
            this.OpportunityCostLabel.Text = $"🔄 OPPORTUNITY COST: {scenario.OpportunityCost3}";
            this.OpportunityCostLabel.ForeColor = Color.Red;
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
                    "You completed Unit 4 Chapter 1 - Economics Basics!\n\n" +
                    "You learned about:\n" +
                    "💰 SCARCITY: Not having enough resources for everything we want\n" +
                    "🤔 CHOICES: Deciding what to do with limited resources\n" +
                    "🔄 OPPORTUNITY COST: What we give up when we make a choice\n\n" +
                    "Remember: Every choice has an opportunity cost!\n" +
                    "We must think carefully about what we want most when resources are scarce.",
                    "Unit 4 Chapter 1 Complete!",
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

        private void Unit4Ch2Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unit_4_Ch_2__SS2E2_ unit4Ch2 = new Unit_4_Ch_2__SS2E2_();
            unit4Ch2.Show();
        }

        private void ConceptButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            switch (clickedButton.Name)
            {
                case "btnScarcity":
                    this.ConceptExplanationLabel.Text = "💰 SCARCITY\n\n" +
                        "Scarcity means we don't have enough of something for everyone who wants it.\n\n" +
                        "Examples of Scarcity:\n" +
                        "• Only having $5 but wanting a $10 toy\n" +
                        "• Having 1 hour but wanting to do 3 activities\n" +
                        "• Only 1 slice of pizza left but 2 hungry people\n" +
                        "• Only 20 playground swings but 30 kids want to swing\n\n" +
                        "Because of scarcity, we must make choices about what we want most!";
                    break;

                case "btnChoices":
                    this.ConceptExplanationLabel.Text = "🤔 MAKING CHOICES\n\n" +
                        "When we don't have enough for everything, we must choose what we want most.\n\n" +
                        "How to Make Good Choices:\n" +
                        "• Think about what you need vs. what you want\n" +
                        "• Consider what makes you happiest\n" +
                        "• Ask yourself: 'What do I want most?'\n" +
                        "• Remember you can't have everything\n\n" +
                        "Good choices help us use our limited resources wisely!";
                    break;

                case "btnOpportunityCost":
                    this.ConceptExplanationLabel.Text = "🔄 OPPORTUNITY COST\n\n" +
                        "Opportunity cost is what you give up when you make a choice.\n\n" +
                        "Examples:\n" +
                        "• If you buy a toy car, the opportunity cost is the toy plane you didn't buy\n" +
                        "• If you play outside, the opportunity cost is reading inside\n" +
                        "• If you eat an apple, the opportunity cost is the banana you didn't eat\n\n" +
                        "Every choice has an opportunity cost - something you give up!";
                    break;

                case "btnResources":
                    this.ConceptExplanationLabel.Text = "📦 RESOURCES\n\n" +
                        "Resources are things we need and want that can be scarce.\n\n" +
                        "Types of Resources:\n" +
                        "💰 Money: We use it to buy things we need\n" +
                        "⏰ Time: We only have 24 hours in a day\n" +
                        "🍎 Goods: Things like food, toys, and clothes\n" +
                        "🏫 Services: Help from others like teachers and doctors\n\n" +
                        "All resources are limited, so we must use them carefully!";
                    break;
            }
        }
    }

    public class ChoiceScenario
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Choice1 { get; set; } = "";
        public string Choice2 { get; set; } = "";
        public string Choice3 { get; set; } = "";
        public string ScarcityExplanation { get; set; } = "";
        public string OpportunityCost1 { get; set; } = "";
        public string OpportunityCost2 { get; set; } = "";
        public string OpportunityCost3 { get; set; } = "";
        public string Lesson { get; set; } = "";
    }
}
