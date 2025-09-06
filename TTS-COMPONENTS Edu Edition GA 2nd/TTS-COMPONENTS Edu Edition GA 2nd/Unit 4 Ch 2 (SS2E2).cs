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
    public partial class Unit_4_Ch_2__SS2E2_ : Form
    {
        private int currentScenarioIndex = 0;
        private List<AllocationScenario> scenarios = new List<AllocationScenario>();
        private Random random = new Random();

        public Unit_4_Ch_2__SS2E2_()
        {
            InitializeComponent();
            InitializeScenarios();
            DisplayScenario(0);
        }

        private void InitializeScenarios()
        {
            scenarios = new List<AllocationScenario>
            {
                new AllocationScenario
                {
                    Title = "🍕 Pizza Party Allocation",
                    Description = "The class has 20 students but only 12 slices of pizza. How should we decide who gets pizza?",
                    Method1 = "💰 Price",
                    Method2 = "🗳️ Majority Rule", 
                    Method3 = "⚡ First-Come-First-Served",
                    Method1Explanation = "Each slice costs $2. Students with money can buy pizza.",
                    Method2Explanation = "The class votes on who should get pizza first.",
                    Method3Explanation = "The first 12 students in line get pizza.",
                    Method1Pros = "Fair for those who can pay; funds can buy more pizza",
                    Method2Pros = "Democratic; everyone has a say in the decision",
                    Method3Pros = "Simple and clear; rewards being on time",
                    Method1Cons = "Unfair to students without money",
                    Method2Cons = "May create popularity contests; time-consuming",
                    Method3Cons = "Unfair to students who arrive later",
                    LearningPoint = "Different allocation methods have different advantages and fairness levels!"
                },

                new AllocationScenario
                {
                    Title = "🎁 Classroom Supplies Distribution",
                    Description = "The teacher has 15 special erasers to give to 25 students. How should they be distributed?",
                    Method1 = "🎲 Lottery",
                    Method2 = "👨‍🏫 Authority", 
                    Method3 = "🤝 Sharing",
                    Method1Explanation = "Put all names in a hat and randomly draw 15 winners.",
                    Method2Explanation = "The teacher decides based on good behavior and grades.",
                    Method3Explanation = "Students work in groups and share the erasers together.",
                    Method1Pros = "Everyone has equal chance; completely fair random selection",
                    Method2Pros = "Rewards good behavior; teacher knows students best",
                    Method3Pros = "Everyone gets to use supplies; builds cooperation",
                    Method1Cons = "Good students might not get rewarded",
                    Method2Cons = "May seem unfair; teacher bias possible",
                    Method3Cons = "Some students may not cooperate well",
                    LearningPoint = "Authority figures often make allocation decisions, but random and sharing methods can also be fair!"
                },

                new AllocationScenario
                {
                    Title = "🏆 Field Day Contest Prizes",
                    Description = "There are 10 trophy prizes for the field day games with 30 students competing. How are prizes allocated?",
                    Method1 = "🏃‍♂️ Contest",
                    Method2 = "👥 Personal Characteristics", 
                    Method3 = "💪 Force",
                    Method1Explanation = "The fastest runners in each race win the trophies.",
                    Method2Explanation = "Prizes go to students who show the best sportsmanship.",
                    Method3Explanation = "Stronger students take prizes from others (This is NOT fair!).",
                    Method1Pros = "Rewards skill and effort; encourages practice",
                    Method2Pros = "Rewards good character; builds positive behavior",
                    Method3Pros = "None - this method is unfair and wrong!",
                    Method1Cons = "Only athletic students win; others feel left out",
                    Method2Cons = "Subjective judgment; hard to measure fairly",
                    Method3Cons = "Completely unfair; creates conflict and hurt feelings",
                    LearningPoint = "Contests reward ability, personal characteristics reward behavior, but force is never a fair way to allocate resources!"
                },

                new AllocationScenario
                {
                    Title = "📚 Library Book Checkout",
                    Description = "The library has 5 copies of a popular new book, but 20 students want to read it. How should books be allocated?",
                    Method1 = "⏰ First-Come-First-Served",
                    Method2 = "🎯 Authority", 
                    Method3 = "🗳️ Majority Rule",
                    Method1Explanation = "First 5 students to request the book get to check it out.",
                    Method2Explanation = "Librarian decides based on reading levels and needs.",
                    Method3Explanation = "Students vote on who should get the books first.",
                    Method1Pros = "Simple system; rewards promptness",
                    Method2Pros = "Matches books to appropriate readers; educational focus",
                    Method3Pros = "Democratic process; students have input",
                    Method1Cons = "May not consider reading ability or need",
                    Method2Cons = "Students may disagree with librarian's choices",
                    Method3Cons = "Popular students may always win votes",
                    LearningPoint = "Libraries often use first-come-first-served, but authority figures can make decisions based on educational needs!"
                },

                new AllocationScenario
                {
                    Title = "🎪 School Carnival Tickets",
                    Description = "The school carnival has limited rides. Only 100 students can ride the Ferris wheel today. How do we decide?",
                    Method1 = "💳 Price",
                    Method2 = "🎲 Lottery", 
                    Method3 = "🤝 Sharing",
                    Method1Explanation = "Students buy tickets for $5 each to ride the Ferris wheel.",
                    Method2Explanation = "All interested students enter a drawing for the 100 spots.",
                    Method3Explanation = "Students take turns throughout the day in small groups.",
                    Method1Pros = "Generates money for school; those who really want it will pay",
                    Method2Pros = "Fair chance for everyone; no advantage for wealth",
                    Method3Pros = "Everyone gets a turn; builds patience and fairness",
                    Method1Cons = "Excludes students without money",
                    Method2Cons = "Some eager students may not get selected",
                    Method3Cons = "Takes longer; some may have to wait until end of day",
                    LearningPoint = "Different allocation methods work better in different situations - consider fairness, efficiency, and goals!"
                },

                new AllocationScenario
                {
                    Title = "🍎 School Lunch Distribution",
                    Description = "The cafeteria made 80 servings of the special meal, but 100 students want it. How is it allocated?",
                    Method1 = "⏰ First-Come-First-Served",
                    Method2 = "👨‍🍳 Authority", 
                    Method3 = "💰 Price",
                    Method1Explanation = "Students line up and first 80 in line get the special meal.",
                    Method2Explanation = "Cafeteria staff decides based on dietary needs and grade level.",
                    Method3Explanation = "Special meal costs extra; regular meal is standard price.",
                    Method1Pros = "Simple and clear; encourages punctuality",
                    Method2Pros = "Considers individual needs; professional judgment",
                    Method3Pros = "Allows choice; generates extra funds for better meals",
                    Method1Cons = "Late students miss out; doesn't consider special needs",
                    Method2Cons = "Students may feel staff choices are unfair",
                    Method3Cons = "Creates inequality based on family income",
                    LearningPoint = "Food allocation often involves multiple methods - first-come-first-served, authority decisions, and pricing!"
                },

                new AllocationScenario
                {
                    Title = "🎨 Art Supplies for Project",
                    Description = "The art teacher has premium colored pencils for 15 students, but 25 students are in class. How to allocate?",
                    Method1 = "🏆 Contest",
                    Method2 = "🤝 Sharing", 
                    Method3 = "👩‍🎨 Personal Characteristics",
                    Method1Explanation = "Students compete in an art skill challenge to earn the premium supplies.",
                    Method2Explanation = "Students work in pairs and share the premium pencils.",
                    Method3Explanation = "Students who show the most artistic passion and effort get them.",
                    Method1Pros = "Rewards artistic skill; motivates improvement",
                    Method2Pros = "Everyone gets access; builds cooperation",
                    Method3Pros = "Rewards dedication and positive attitude",
                    Method1Cons = "Beginners may feel discouraged",
                    Method2Cons = "Some students may not share fairly",
                    Method3Cons = "Subjective judgment; may seem unfair to some",
                    LearningPoint = "Art and creative activities can use contests, sharing, or recognize personal qualities like passion and effort!"
                },

                new AllocationScenario
                {
                    Title = "🎮 Computer Lab Time",
                    Description = "The computer lab has 20 computers but 30 students need to complete their assignment. How to allocate time?",
                    Method1 = "📅 Authority",
                    Method2 = "⏰ First-Come-First-Served", 
                    Method3 = "🗳️ Majority Rule",
                    Method1Explanation = "Teacher assigns computer time based on project deadlines and needs.",
                    Method2Explanation = "Students sign up for time slots as they arrive each day.",
                    Method3Explanation = "Class votes on the schedule and priority system.",
                    Method1Pros = "Teacher knows all student needs; can prioritize urgent work",
                    Method2Pros = "Simple system; treats everyone equally",
                    Method3Pros = "Students feel involved in decision-making",
                    Method1Cons = "Students may disagree with teacher priorities",
                    Method2Cons = "Doesn't consider different project deadlines",
                    Method3Cons = "Voting takes time; popular students may get advantages",
                    LearningPoint = "Scheduling shared resources often requires authority figures to consider everyone's needs fairly!"
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
                this.Method1Button.Text = scenario.Method1;
                this.Method2Button.Text = scenario.Method2;
                this.Method3Button.Text = scenario.Method3;
                this.AllocationExplanationLabel.Text = "Click on an allocation method to learn more!";
                this.ProsConsLabel.Text = "";
                this.LearningPointLabel.Text = scenario.LearningPoint;
                this.ProgressLabel.Text = $"Scenario {index + 1} of {scenarios.Count}";
            }
        }

        private void Method1Button_Click(object sender, EventArgs e)
        {
            var scenario = scenarios[currentScenarioIndex];
            this.AllocationExplanationLabel.Text = $"{scenario.Method1}: {scenario.Method1Explanation}";
            this.ProsConsLabel.Text = $"✅ PROS: {scenario.Method1Pros}\n\n❌ CONS: {scenario.Method1Cons}";
            this.ProsConsLabel.ForeColor = Color.DarkBlue;
        }

        private void Method2Button_Click(object sender, EventArgs e)
        {
            var scenario = scenarios[currentScenarioIndex];
            this.AllocationExplanationLabel.Text = $"{scenario.Method2}: {scenario.Method2Explanation}";
            this.ProsConsLabel.Text = $"✅ PROS: {scenario.Method2Pros}\n\n❌ CONS: {scenario.Method2Cons}";
            this.ProsConsLabel.ForeColor = Color.DarkGreen;
        }

        private void Method3Button_Click(object sender, EventArgs e)
        {
            var scenario = scenarios[currentScenarioIndex];
            this.AllocationExplanationLabel.Text = $"{scenario.Method3}: {scenario.Method3Explanation}";
            this.ProsConsLabel.Text = $"✅ PROS: {scenario.Method3Pros}\n\n❌ CONS: {scenario.Method3Cons}";
            this.ProsConsLabel.ForeColor = Color.DarkRed;
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
                    "You completed Unit 4 Chapter 2 - How Goods and Services are Allocated!\n\n" +
                    "You learned about these allocation methods:\n" +
                    "💰 PRICE: Pay money to get goods/services\n" +
                    "🗳️ MAJORITY RULE: Group votes to decide\n" +
                    "🏆 CONTESTS: Compete to win resources\n" +
                    "💪 FORCE: Taking by strength (unfair!)\n" +
                    "🤝 SHARING: Working together to use resources\n" +
                    "🎲 LOTTERY: Random chance selection\n" +
                    "👨‍🏫 AUTHORITY: Leaders make decisions\n" +
                    "⏰ FIRST-COME-FIRST-SERVED: Line up and wait your turn\n" +
                    "👥 PERSONAL CHARACTERISTICS: Based on behavior or traits\n\n" +
                    "Remember: Different allocation methods work better in different situations!\n" +
                    "Always consider what is most fair for everyone involved.",
                    "Unit 4 Chapter 2 Complete!",
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

        private void AllocationMethodButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            switch (clickedButton.Name)
            {
                case "btnPrice":
                    this.MethodExplanationLabel.Text = "💰 PRICE ALLOCATION\n\n" +
                        "When we use price to allocate goods and services, people pay money to get what they want.\n\n" +
                        "Examples:\n" +
                        "• Buying toys at a store\n" +
                        "• Paying for movie tickets\n" +
                        "• Purchasing school lunch\n" +
                        "• Buying clothes\n\n" +
                        "✅ GOOD: People who want something most will pay for it\n" +
                        "❌ BAD: People without money can't get things they need\n\n" +
                        "Price helps decide who gets limited resources!";
                    break;

                case "btnMajorityRule":
                    this.MethodExplanationLabel.Text = "🗳️ MAJORITY RULE ALLOCATION\n\n" +
                        "When we use majority rule, the group votes and the choice with the most votes wins.\n\n" +
                        "Examples:\n" +
                        "• Class voting on which movie to watch\n" +
                        "• Students choosing the field trip destination\n" +
                        "• Deciding class rules together\n" +
                        "• Picking the class pet\n\n" +
                        "✅ GOOD: Everyone gets a voice; democratic and fair\n" +
                        "❌ BAD: The minority doesn't get what they want\n\n" +
                        "Majority rule lets groups make decisions together!";
                    break;

                case "btnContest":
                    this.MethodExplanationLabel.Text = "🏆 CONTEST ALLOCATION\n\n" +
                        "When we use contests, people compete and the best performer gets the resource.\n\n" +
                        "Examples:\n" +
                        "• Sports competitions for trophies\n" +
                        "• Academic contests for prizes\n" +
                        "• Art competitions for ribbons\n" +
                        "• Spelling bees for awards\n\n" +
                        "✅ GOOD: Rewards skill, effort, and practice\n" +
                        "❌ BAD: Only the most skilled people win\n\n" +
                        "Contests encourage people to try their best!";
                    break;

                case "btnForce":
                    this.MethodExplanationLabel.Text = "💪 FORCE ALLOCATION (UNFAIR!)\n\n" +
                        "When people use force, they take things from others using strength or threats.\n\n" +
                        "Examples of WRONG behavior:\n" +
                        "• Bullying someone to take their lunch\n" +
                        "• Pushing others out of line\n" +
                        "• Taking toys from smaller children\n" +
                        "• Grabbing things without permission\n\n" +
                        "✅ GOOD: Nothing! This method is always wrong!\n" +
                        "❌ BAD: Hurts others; creates fear; completely unfair\n\n" +
                        "Force is NEVER a fair way to get resources!\n" +
                        "We should always treat others with respect and kindness.";
                    break;

                case "btnSharing":
                    this.MethodExplanationLabel.Text = "🤝 SHARING ALLOCATION\n\n" +
                        "When we share, everyone gets to use the resource by taking turns or using it together.\n\n" +
                        "Examples:\n" +
                        "• Taking turns on the playground swings\n" +
                        "• Sharing art supplies during projects\n" +
                        "• Using library books in reading groups\n" +
                        "• Splitting snacks with friends\n\n" +
                        "✅ GOOD: Everyone gets something; builds cooperation\n" +
                        "❌ BAD: Everyone gets less; some people don't share fairly\n\n" +
                        "Sharing helps everyone and builds friendships!";
                    break;

                case "btnLottery":
                    this.MethodExplanationLabel.Text = "🎲 LOTTERY ALLOCATION\n\n" +
                        "When we use a lottery, names are picked randomly so everyone has an equal chance.\n\n" +
                        "Examples:\n" +
                        "• Drawing names from a hat for prizes\n" +
                        "• Random selection for special activities\n" +
                        "• Spinning a wheel to choose winners\n" +
                        "• Rolling dice to decide order\n\n" +
                        "✅ GOOD: Completely fair; everyone has equal chance\n" +
                        "❌ BAD: Good behavior isn't rewarded; pure luck\n\n" +
                        "Lotteries make sure no one has an unfair advantage!";
                    break;

                case "btnAuthority":
                    this.MethodExplanationLabel.Text = "👨‍🏫 AUTHORITY ALLOCATION\n\n" +
                        "When authority figures decide, people in charge make choices about who gets resources.\n\n" +
                        "Examples:\n" +
                        "• Teachers assigning classroom jobs\n" +
                        "• Parents deciding bedtime and treats\n" +
                        "• Coaches choosing team positions\n" +
                        "• Principals making school rules\n\n" +
                        "✅ GOOD: Experienced people make wise decisions\n" +
                        "❌ BAD: Others might disagree; can seem unfair\n\n" +
                        "Authority figures often know what's best for everyone!";
                    break;

                case "btnFirstCome":
                    this.MethodExplanationLabel.Text = "⏰ FIRST-COME-FIRST-SERVED ALLOCATION\n\n" +
                        "When we use first-come-first-served, the first people in line get the resources.\n\n" +
                        "Examples:\n" +
                        "• Lining up for lunch in the cafeteria\n" +
                        "• Getting tickets for school events\n" +
                        "• Checking out library books\n" +
                        "• Signing up for activities\n\n" +
                        "✅ GOOD: Simple and fair; rewards being on time\n" +
                        "❌ BAD: Late arrivals miss out; doesn't consider need\n\n" +
                        "First-come-first-served encourages promptness!";
                    break;

                case "btnPersonalCharacteristics":
                    this.MethodExplanationLabel.Text = "👥 PERSONAL CHARACTERISTICS ALLOCATION\n\n" +
                        "When we use personal characteristics, resources go to people based on their behavior, skills, or traits.\n\n" +
                        "Examples:\n" +
                        "• Giving leadership roles to responsible students\n" +
                        "• Rewarding good behavior with privileges\n" +
                        "• Choosing helpers based on kindness\n" +
                        "• Selecting team captains for sportsmanship\n\n" +
                        "✅ GOOD: Rewards positive behavior and good character\n" +
                        "❌ BAD: Subjective judgment; may seem unfair to some\n\n" +
                        "Personal characteristics help recognize good behavior!";
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

    public class AllocationScenario
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Method1 { get; set; } = "";
        public string Method2 { get; set; } = "";
        public string Method3 { get; set; } = "";
        public string Method1Explanation { get; set; } = "";
        public string Method2Explanation { get; set; } = "";
        public string Method3Explanation { get; set; } = "";
        public string Method1Pros { get; set; } = "";
        public string Method2Pros { get; set; } = "";
        public string Method3Pros { get; set; } = "";
        public string Method1Cons { get; set; } = "";
        public string Method2Cons { get; set; } = "";
        public string Method3Cons { get; set; } = "";
        public string LearningPoint { get; set; } = "";
    }
}
