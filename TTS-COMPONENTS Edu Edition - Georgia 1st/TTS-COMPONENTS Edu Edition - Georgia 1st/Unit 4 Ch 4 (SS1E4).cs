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
    public partial class Unit_4_Ch_4__SS1E4_ : Form
    {
        // Data structures for income and spending scenarios
        public class JobScenario
        {
            public string Name { get; set; }
            public string Job { get; set; }
            public int WeeklyIncome { get; set; }
            public string WorkDescription { get; set; }
            public string GeorgiaConnection { get; set; }
            public List<SpendingChoice> SpendingChoices { get; set; }
            public SpendingChoice SavingChoice { get; set; }
        }

        public class SpendingChoice
        {
            public string ItemName { get; set; }
            public int Cost { get; set; }
            public string Category { get; set; } // "need", "want", "saving"
            public string Description { get; set; }
            public bool IsCorrectChoice { get; set; }
        }

        public class BudgetActivity
        {
            public string ActivityName { get; set; }
            public string Description { get; set; }
            public int Budget { get; set; }
            public List<SpendingChoice> Options { get; set; }
            public int CorrectAnswer { get; set; }
        }

        // Current state tracking
        private List<JobScenario> jobScenarios;
        private List<BudgetActivity> budgetActivities;
        private int currentScenarioIndex = 0;
        private int currentBudgetIndex = 0;
        private int score = 0;
        private string currentGameMode = "scenarios"; // scenarios, budget_game, savings_game

        public Unit_4_Ch_4__SS1E4_()
        {
            InitializeComponent();
            InitializeJobScenarios();
            InitializeBudgetActivities();
            DisplayScenario(0);
        }

        private void InitializeJobScenarios()
        {
            jobScenarios = new List<JobScenario>
            {
                new JobScenario
                {
                    Name = "Emma the Teacher",
                    Job = "Elementary School Teacher in Atlanta",
                    WeeklyIncome = 600,
                    WorkDescription = "Emma teaches 1st grade students. She works 5 days a week helping children learn to read, write, and do math.",
                    GeorgiaConnection = "Georgia has over 120,000 teachers working in schools across the state!",
                    SpendingChoices = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Groceries", Cost = 100, Category = "need", Description = "Food for the week", IsCorrectChoice = true },
                        new SpendingChoice { ItemName = "Video Game", Cost = 60, Category = "want", Description = "New game for fun", IsCorrectChoice = false },
                        new SpendingChoice { ItemName = "Gas for Car", Cost = 40, Category = "need", Description = "To drive to work", IsCorrectChoice = true }
                    },
                    SavingChoice = new SpendingChoice { ItemName = "Savings Account", Cost = 200, Category = "saving", Description = "Money for the future", IsCorrectChoice = true }
                },

                new JobScenario
                {
                    Name = "Carlos the Firefighter",
                    Job = "Firefighter in Savannah",
                    WeeklyIncome = 700,
                    WorkDescription = "Carlos helps keep people safe by fighting fires and helping in emergencies. He works at the fire station.",
                    GeorgiaConnection = "Savannah has brave firefighters who protect our historic city and its people!",
                    SpendingChoices = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Rent", Cost = 300, Category = "need", Description = "Place to live", IsCorrectChoice = true },
                        new SpendingChoice { ItemName = "Expensive Shoes", Cost = 150, Category = "want", Description = "Designer sneakers", IsCorrectChoice = false },
                        new SpendingChoice { ItemName = "Work Uniform", Cost = 80, Category = "need", Description = "Clothes for work", IsCorrectChoice = true }
                    },
                    SavingChoice = new SpendingChoice { ItemName = "Emergency Fund", Cost = 170, Category = "saving", Description = "Money for unexpected things", IsCorrectChoice = true }
                },

                new JobScenario
                {
                    Name = "Maria the Store Manager",
                    Job = "Manager at a Grocery Store in Augusta",
                    WeeklyIncome = 550,
                    WorkDescription = "Maria manages a grocery store. She makes sure the store has food, helps customers, and leads her team.",
                    GeorgiaConnection = "Augusta has many grocery stores that help families get the food they need!",
                    SpendingChoices = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Phone Bill", Cost = 50, Category = "need", Description = "To stay connected", IsCorrectChoice = true },
                        new SpendingChoice { ItemName = "Fancy Purse", Cost = 200, Category = "want", Description = "Expensive handbag", IsCorrectChoice = false },
                        new SpendingChoice { ItemName = "Medicine", Cost = 30, Category = "need", Description = "To stay healthy", IsCorrectChoice = true }
                    },
                    SavingChoice = new SpendingChoice { ItemName = "College Fund", Cost = 150, Category = "saving", Description = "Money for education", IsCorrectChoice = true }
                },

                new JobScenario
                {
                    Name = "David the Farmer",
                    Job = "Peach Farmer in Macon",
                    WeeklyIncome = 500,
                    WorkDescription = "David grows peaches on his farm. He plants, waters, and harvests peaches that people buy at stores.",
                    GeorgiaConnection = "Georgia is famous for growing the sweetest peaches in the country!",
                    SpendingChoices = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Farm Tools", Cost = 120, Category = "need", Description = "Tools to grow peaches", IsCorrectChoice = true },
                        new SpendingChoice { ItemName = "Expensive Watch", Cost = 300, Category = "want", Description = "Luxury timepiece", IsCorrectChoice = false },
                        new SpendingChoice { ItemName = "Seeds", Cost = 50, Category = "need", Description = "To plant new trees", IsCorrectChoice = true }
                    },
                    SavingChoice = new SpendingChoice { ItemName = "Equipment Fund", Cost = 150, Category = "saving", Description = "Money for new farm equipment", IsCorrectChoice = true }
                },

                new JobScenario
                {
                    Name = "Lisa the Nurse",
                    Job = "Nurse at Columbus Hospital",
                    WeeklyIncome = 650,
                    WorkDescription = "Lisa takes care of patients at the hospital. She helps doctors and makes sure people feel better.",
                    GeorgiaConnection = "Columbus has excellent hospitals with caring nurses who help our community stay healthy!",
                    SpendingChoices = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Work Shoes", Cost = 90, Category = "need", Description = "Comfortable shoes for long work days", IsCorrectChoice = true },
                        new SpendingChoice { ItemName = "Concert Tickets", Cost = 120, Category = "want", Description = "Entertainment for weekend", IsCorrectChoice = false },
                        new SpendingChoice { ItemName = "Car Insurance", Cost = 100, Category = "need", Description = "Required to drive", IsCorrectChoice = true }
                    },
                    SavingChoice = new SpendingChoice { ItemName = "Vacation Fund", Cost = 180, Category = "saving", Description = "Money for family vacation", IsCorrectChoice = true }
                },

                new JobScenario
                {
                    Name = "James the Construction Worker",
                    Job = "Construction Worker in Athens",
                    WeeklyIncome = 580,
                    WorkDescription = "James builds houses and buildings. He uses tools and works with his team to construct places where people live and work.",
                    GeorgiaConnection = "Athens is growing fast, and construction workers like James help build homes for families!",
                    SpendingChoices = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Work Boots", Cost = 80, Category = "need", Description = "Safe shoes for construction", IsCorrectChoice = true },
                        new SpendingChoice { ItemName = "Gaming Console", Cost = 400, Category = "want", Description = "Entertainment system", IsCorrectChoice = false },
                        new SpendingChoice { ItemName = "Lunch Money", Cost = 60, Category = "need", Description = "Food during work week", IsCorrectChoice = true }
                    },
                    SavingChoice = new SpendingChoice { ItemName = "Tool Fund", Cost = 160, Category = "saving", Description = "Money for better work tools", IsCorrectChoice = true }
                }
            };
        }

        private void InitializeBudgetActivities()
        {
            budgetActivities = new List<BudgetActivity>
            {
                new BudgetActivity
                {
                    ActivityName = "Birthday Party Planning",
                    Description = "You have $50 to spend on a birthday party. What should you buy?",
                    Budget = 50,
                    Options = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Cake ($20) + Decorations ($15) + Games ($10)", Cost = 45, Category = "balanced", Description = "A fun party with money left over" },
                        new SpendingChoice { ItemName = "Expensive Cake ($60)", Cost = 60, Category = "overspend", Description = "Too expensive - goes over budget!" },
                        new SpendingChoice { ItemName = "Just Decorations ($15)", Cost = 15, Category = "underspend", Description = "Not enough for a good party" }
                    },
                    CorrectAnswer = 0
                },

                new BudgetActivity
                {
                    ActivityName = "School Supply Shopping",
                    Description = "You need school supplies and have $30. What's the best choice?",
                    Budget = 30,
                    Options = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Fancy Backpack ($35)", Cost = 35, Category = "overspend", Description = "Too expensive for your budget!" },
                        new SpendingChoice { ItemName = "Pencils ($5) + Notebooks ($10) + Folder ($8)", Cost = 23, Category = "balanced", Description = "All the supplies you need" },
                        new SpendingChoice { ItemName = "Just one pencil ($1)", Cost = 1, Category = "underspend", Description = "Not enough supplies for school" }
                    },
                    CorrectAnswer = 1
                },

                new BudgetActivity
                {
                    ActivityName = "Toy Store Visit",
                    Description = "You saved $25 from your allowance. What should you buy?",
                    Budget = 25,
                    Options = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Small toy ($10) + Save the rest ($15)", Cost = 10, Category = "balanced", Description = "Buy something and save too!" },
                        new SpendingChoice { ItemName = "Expensive toy ($40)", Cost = 40, Category = "overspend", Description = "Costs more than you have!" },
                        new SpendingChoice { ItemName = "Candy ($3) + Stickers ($2)", Cost = 5, Category = "underspend", Description = "Small purchases, lots left over" }
                    },
                    CorrectAnswer = 0
                },

                new BudgetActivity
                {
                    ActivityName = "Family Grocery Helper",
                    Description = "Mom gives you $20 to buy snacks for the family. Choose wisely!",
                    Budget = 20,
                    Options = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Fruits ($8) + Crackers ($6) + Juice ($5)", Cost = 19, Category = "balanced", Description = "Healthy snacks for everyone" },
                        new SpendingChoice { ItemName = "One expensive chocolate box ($25)", Cost = 25, Category = "overspend", Description = "Too much money for one item!" },
                        new SpendingChoice { ItemName = "One apple ($2)", Cost = 2, Category = "underspend", Description = "Not enough food for the family" }
                    },
                    CorrectAnswer = 0
                },

                new BudgetActivity
                {
                    ActivityName = "Pet Care Budget",
                    Description = "You have $15 to take care of your pet this week. What do you buy?",
                    Budget = 15,
                    Options = new List<SpendingChoice>
                    {
                        new SpendingChoice { ItemName = "Pet food ($10) + Treats ($4)", Cost = 14, Category = "balanced", Description = "Everything your pet needs" },
                        new SpendingChoice { ItemName = "Expensive pet toy ($20)", Cost = 20, Category = "overspend", Description = "More than your budget allows" },
                        new SpendingChoice { ItemName = "Just treats ($4)", Cost = 4, Category = "underspend", Description = "Pet needs food too!" }
                    },
                    CorrectAnswer = 0
                }
            };
        }

        private void DisplayScenario(int index)
        {
            if (index < 0 || index >= jobScenarios.Count) return;

            var scenario = jobScenarios[index];
            currentScenarioIndex = index;

            lblPersonName.Text = scenario.Name;
            lblPersonJob.Text = $"Job: {scenario.Job}";
            lblWeeklyIncome.Text = $"Weekly Income: ${scenario.WeeklyIncome}";
            lblWorkDescription.Text = $"What they do: {scenario.WorkDescription}";
            lblGeorgiaConnection.Text = $"Georgia Connection: {scenario.GeorgiaConnection}";

            // Show spending choices
            UpdateSpendingChoicesDisplay();
            
            // Update progress
            lblProgress.Text = $"Person {index + 1}/6";
            lblScore.Text = $"Score: {score}/6";

            // Reset UI state
            ResetChoiceButtons();
            HideResultLabels();
        }

        private void UpdateSpendingChoicesDisplay()
        {
            var scenario = jobScenarios[currentScenarioIndex];
            
            lblSpendingChoice1.Text = $"💰 {scenario.SpendingChoices[0].ItemName} (${scenario.SpendingChoices[0].Cost})";
            lblSpendingChoice2.Text = $"💰 {scenario.SpendingChoices[1].ItemName} (${scenario.SpendingChoices[1].Cost})";
            lblSpendingChoice3.Text = $"💰 {scenario.SpendingChoices[2].ItemName} (${scenario.SpendingChoices[2].Cost})";
            lblSavingChoice.Text = $"🏦 {scenario.SavingChoice.ItemName} (${scenario.SavingChoice.Cost})";

            lblSpendingDesc1.Text = scenario.SpendingChoices[0].Description;
            lblSpendingDesc2.Text = scenario.SpendingChoices[1].Description;
            lblSpendingDesc3.Text = scenario.SpendingChoices[2].Description;
            lblSavingDesc.Text = scenario.SavingChoice.Description;
        }

        private void ResetChoiceButtons()
        {
            btnChoice1.BackColor = Color.LightBlue;
            btnChoice2.BackColor = Color.LightGreen;
            btnChoice3.BackColor = Color.LightCoral;
            btnSavingChoice.BackColor = Color.Gold;
            
            btnChoice1.Enabled = true;
            btnChoice2.Enabled = true;
            btnChoice3.Enabled = true;
            btnSavingChoice.Enabled = true;
        }

        private void HideResultLabels()
        {
            lblChoiceResult.Text = "";
            lblChoiceResult.Visible = false;
            lblIncomeLesson.Text = "";
            lblIncomeLesson.Visible = false;
            btnNext.Visible = false;
        }

        private void EvaluateChoice(int choiceIndex, bool isSaving = false)
        {
            var scenario = jobScenarios[currentScenarioIndex];
            SpendingChoice selectedChoice;
            bool isCorrect;

            if (isSaving)
            {
                selectedChoice = scenario.SavingChoice;
                isCorrect = true; // Saving is always a good choice
            }
            else
            {
                selectedChoice = scenario.SpendingChoices[choiceIndex];
                isCorrect = selectedChoice.IsCorrectChoice;
            }

            if (isCorrect)
            {
                score++;
                lblChoiceResult.Text = $"✅ Great choice! {selectedChoice.ItemName} is a {selectedChoice.Category}.";
                lblChoiceResult.ForeColor = Color.Green;
                
                if (isSaving)
                {
                    lblIncomeLesson.Text = "💡 Saving money is very important! It helps you buy things you need later.";
                }
                else if (selectedChoice.Category == "need")
                {
                    lblIncomeLesson.Text = "💡 Needs are things we must have to live safely and healthily.";
                }
                else
                {
                    lblIncomeLesson.Text = "💡 This is a smart spending choice for someone with this income.";
                }
            }
            else
            {
                lblChoiceResult.Text = $"❌ Think again! {selectedChoice.ItemName} might not be the best choice.";
                lblChoiceResult.ForeColor = Color.Red;
                
                if (selectedChoice.Category == "want")
                {
                    lblIncomeLesson.Text = "💡 Wants are nice to have, but we should buy needs first!";
                }
                else
                {
                    lblIncomeLesson.Text = "💡 With this income, there might be better choices to make.";
                }
            }

            lblChoiceResult.Visible = true;
            lblIncomeLesson.Visible = true;
            btnNext.Visible = true;

            // Disable all buttons after choice
            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnSavingChoice.Enabled = false;

            // Update score display
            lblScore.Text = $"Score: {score}/6";
        }

        // Button click handlers for scenarios
        private void btnChoice1_Click(object sender, EventArgs e)
        {
            EvaluateChoice(0);
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            EvaluateChoice(1);
        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            EvaluateChoice(2);
        }

        private void btnSavingChoice_Click(object sender, EventArgs e)
        {
            EvaluateChoice(0, true);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentScenarioIndex < jobScenarios.Count - 1)
            {
                currentScenarioIndex++;
                DisplayScenario(currentScenarioIndex);
            }
            else
            {
                // All scenarios completed, navigate to Unit 4 Ch 3 or show completion
                MessageBox.Show($"🎉 Congratulations! You completed all scenarios!\n\nFinal Score: {score}/6\n\nYou learned about how people earn income by working and make choices about saving and spending!", 
                    "Unit 4 Chapter 4 Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentScenarioIndex > 0)
            {
                currentScenarioIndex--;
                DisplayScenario(currentScenarioIndex);
            }
        }

        // Game mode switching
        private void HideAllPanels()
        {
            pnlScenarios.Visible = false;
            pnlBudgetGame.Visible = false;
            pnlSavingsGame.Visible = false;
        }

        private void btnBudgetGame_Click(object sender, EventArgs e)
        {
            currentGameMode = "budget_game";
            HideAllPanels();
            pnlBudgetGame.Visible = true;
            DisplayBudgetActivity(0);
        }

        private void btnSavingsGame_Click(object sender, EventArgs e)
        {
            currentGameMode = "savings_game";
            HideAllPanels();
            pnlSavingsGame.Visible = true;
            SetupSavingsGame();
        }

        private void btnBackToScenarios_Click(object sender, EventArgs e)
        {
            currentGameMode = "scenarios";
            HideAllPanels();
            pnlScenarios.Visible = true;
        }

        // Budget game functionality
        private void DisplayBudgetActivity(int index)
        {
            if (index < 0 || index >= budgetActivities.Count) return;

            var activity = budgetActivities[index];
            currentBudgetIndex = index;

            lblBudgetTitle.Text = activity.ActivityName;
            lblBudgetDescription.Text = $"{activity.Description}\nBudget: ${activity.Budget}";

            btnBudgetOption1.Text = activity.Options[0].ItemName;
            btnBudgetOption2.Text = activity.Options[1].ItemName;
            btnBudgetOption3.Text = activity.Options[2].ItemName;

            lblBudgetResult.Visible = false;
            btnNextBudget.Visible = false;

            // Reset button colors
            btnBudgetOption1.BackColor = Color.LightSalmon;
            btnBudgetOption2.BackColor = Color.LightBlue;
            btnBudgetOption3.BackColor = Color.LightGreen;

            btnBudgetOption1.Enabled = true;
            btnBudgetOption2.Enabled = true;
            btnBudgetOption3.Enabled = true;
        }

        private void btnBudgetOption1_Click(object sender, EventArgs e)
        {
            EvaluateBudgetChoice(0);
        }

        private void btnBudgetOption2_Click(object sender, EventArgs e)
        {
            EvaluateBudgetChoice(1);
        }

        private void btnBudgetOption3_Click(object sender, EventArgs e)
        {
            EvaluateBudgetChoice(2);
        }

        private void EvaluateBudgetChoice(int optionIndex)
        {
            var activity = budgetActivities[currentBudgetIndex];
            var selectedOption = activity.Options[optionIndex];
            bool isCorrect = optionIndex == activity.CorrectAnswer;

            if (isCorrect)
            {
                lblBudgetResult.Text = $"✅ Perfect! {selectedOption.Description}";
                lblBudgetResult.ForeColor = Color.Green;
            }
            else
            {
                lblBudgetResult.Text = $"❌ Not quite! {selectedOption.Description}";
                lblBudgetResult.ForeColor = Color.Red;
            }

            lblBudgetResult.Visible = true;
            btnNextBudget.Visible = true;

            btnBudgetOption1.Enabled = false;
            btnBudgetOption2.Enabled = false;
            btnBudgetOption3.Enabled = false;
        }

        private void btnNextBudget_Click(object sender, EventArgs e)
        {
            if (currentBudgetIndex < budgetActivities.Count - 1)
            {
                currentBudgetIndex++;
                DisplayBudgetActivity(currentBudgetIndex);
            }
            else
            {
                MessageBox.Show("🎉 Great job learning about budgets!\n\nRemember: A budget helps you plan how to spend your money wisely!", 
                    "Budget Game Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentBudgetIndex = 0;
                DisplayBudgetActivity(0);
            }
        }

        // Savings game functionality
        private void SetupSavingsGame()
        {
            lblSavingsTitle.Text = "Savings Challenge!";
            lblSavingsInstructions.Text = "🏦 Learn about saving money!\n\n" +
                "💡 Saving means keeping money for later instead of spending it all now.\n\n" +
                "✨ Why save money?\n" +
                "• To buy bigger things later\n" +
                "• For emergencies\n" +
                "• To reach your goals\n\n" +
                "🌟 Remember: Even saving a little bit helps!\n\n" +
                "In Georgia, kids often save money in piggy banks or special accounts at banks!";
        }

        // Navigation and utility functions
        private void btnRestart_Click(object sender, EventArgs e)
        {
            score = 0;
            currentScenarioIndex = 0;
            currentBudgetIndex = 0;
            DisplayScenario(0);
            HideAllPanels();
            pnlScenarios.Visible = true;
        }

        private void btnShowScore_Click(object sender, EventArgs e)
        {
            string message = $"📊 Your Current Progress:\n\n" +
                           $"Scenarios Score: {score}/6\n\n" +
                           $"💰 You're learning about:\n" +
                           $"• How people earn money by working\n" +
                           $"• Making smart spending choices\n" +
                           $"• The importance of saving money\n\n" +
                           $"Keep up the great work! 🌟";

            MessageBox.Show(message, "Your Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToUnit4Ch3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unit_4_Ch_3__SS1E3_ unit4Ch3 = new Unit_4_Ch_3__SS1E3_();
            unit4Ch3.Show();
        }

        private void btnToForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnToCertificate_Click(object sender, EventArgs e)
        {
            this.Hide();
            End_Of_The_Year_Certificate certificate = new End_Of_The_Year_Certificate();
            certificate.Show();
        }
    }
}
