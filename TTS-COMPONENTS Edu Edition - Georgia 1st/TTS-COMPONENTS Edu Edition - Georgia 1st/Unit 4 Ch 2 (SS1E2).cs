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
    public partial class Unit_4_Ch_2__SS1E2_ : Form
    {
        private List<ScarcityScenario> scenarios = new List<ScarcityScenario>();
        private int currentScenarioIndex = 0;
        private int correctAnswers = 0;
        private int totalQuestions = 0;

        public Unit_4_Ch_2__SS1E2_()
        {
            InitializeComponent();
            InitializeScenarios();
            
            // Set up initial panel visibility
            pnlScenario.Visible = true;
            pnlQuiz.Visible = false;
            pnlNeedsWants.Visible = false;
            
            DisplayScenario(currentScenarioIndex);
        }

        public class ScarcityScenario
        {
            public string Title { get; set; }
            public string Situation { get; set; }
            public string WhatYouWant { get; set; }
            public string WhatYouHave { get; set; }
            public bool IsScarcity { get; set; }
            public string Explanation { get; set; }
            public string GeorgiaExample { get; set; }
            public string LessonLearned { get; set; }

            public ScarcityScenario(string title, string situation, string whatYouWant, string whatYouHave, bool isScarcity, string explanation, string georgiaExample, string lessonLearned)
            {
                Title = title;
                Situation = situation;
                WhatYouWant = whatYouWant;
                WhatYouHave = whatYouHave;
                IsScarcity = isScarcity;
                Explanation = explanation;
                GeorgiaExample = georgiaExample;
                LessonLearned = lessonLearned;
            }
        }

        private void InitializeScenarios()
        {
            scenarios = new List<ScarcityScenario>
            {
                new ScarcityScenario(
                    "Ice Cream Truck",
                    "The ice cream truck comes to your neighborhood! You hear the music playing.",
                    "You want 3 different ice creams: a popsicle, ice cream sandwich, and snow cone",
                    "You only have $2 in your piggy bank",
                    true,
                    "This is SCARCITY! You want more things than your money can buy.",
                    "In Georgia, kids face this choice when the ice cream truck visits their neighborhood",
                    "We have to choose what's most important when we can't have everything!"
                ),
                new ScarcityScenario(
                    "Toy Store Visit",
                    "Your family goes to the toy store before your birthday.",
                    "You want 1 small toy car that costs $5",
                    "Your parents give you $10 to spend",
                    false,
                    "This is NOT scarcity! You have enough money for what you want, plus some left over.",
                    "Georgia toy stores have toys for every budget",
                    "When we have enough resources for our wants, there's no scarcity!"
                ),
                new ScarcityScenario(
                    "School Lunch Line",
                    "It's pizza day at school! Everyone loves pizza day.",
                    "You want 2 slices of pizza and chocolate milk",
                    "The cafeteria only has 1 slice left when you get there",
                    true,
                    "This is SCARCITY! There isn't enough pizza for everyone who wants it.",
                    "Georgia school cafeterias sometimes run out of popular foods",
                    "Sometimes there isn't enough of what everyone wants!"
                ),
                new ScarcityScenario(
                    "Crayon Box",
                    "Art time at school! Time to color your Georgia peach picture.",
                    "You want to use the red crayon",
                    "There are 5 red crayons in the classroom crayon box",
                    false,
                    "This is NOT scarcity! There are plenty of red crayons for everyone.",
                    "Georgia classrooms usually have enough art supplies for all students",
                    "When there's enough for everyone, we don't have scarcity!"
                ),
                new ScarcityScenario(
                    "Playground Swings",
                    "Recess time! Everyone wants to play on the swings.",
                    "20 kids want to swing",
                    "The playground only has 4 swings",
                    true,
                    "This is SCARCITY! More kids want to swing than there are swings available.",
                    "Georgia playgrounds often have this problem during recess",
                    "We have to take turns when there isn't enough for everyone!"
                ),
                new ScarcityScenario(
                    "Story Time Books",
                    "The teacher is reading a story about Georgia animals.",
                    "6 kids want to see the pictures up close",
                    "There are 6 chairs in the front row",
                    false,
                    "This is NOT scarcity! There are exactly enough front seats for everyone who wants one.",
                    "Georgia classrooms try to have enough space for all students",
                    "Perfect match! When wants equal what we have, there's no scarcity!"
                )
            };
        }

        private void DisplayScenario(int index)
        {
            if (index >= 0 && index < scenarios.Count)
            {
                var scenario = scenarios[index];
                lblScenarioTitle.Text = scenario.Title;
                lblSituation.Text = scenario.Situation;
                lblWhatYouWant.Text = $"What You Want: {scenario.WhatYouWant}";
                lblWhatYouHave.Text = $"What You Have: {scenario.WhatYouHave}";
                lblExplanation.Text = "";
                lblGeorgiaExample.Text = "";
                lblLessonLearned.Text = "";
                
                // Reset button colors
                btnIsScarcity.BackColor = Color.LightGray;
                btnNotScarcity.BackColor = Color.LightGray;
                
                btnPrevious.Enabled = index > 0;
                btnNext.Enabled = index < scenarios.Count - 1;
                
                UpdateProgress();
            }
        }

        private void UpdateProgress()
        {
            lblProgress.Text = $"Scenario {currentScenarioIndex + 1} of {scenarios.Count}";
            if (totalQuestions > 0)
            {
                lblScore.Text = $"Correct: {correctAnswers}/{totalQuestions}";
            }
            else
            {
                lblScore.Text = "Click your answer below!";
            }
        }

        private void CheckAnswer(bool userAnswer)
        {
            var scenario = scenarios[currentScenarioIndex];
            totalQuestions++;
            
            bool isCorrect = userAnswer == scenario.IsScarcity;
            if (isCorrect)
            {
                correctAnswers++;
                btnIsScarcity.BackColor = scenario.IsScarcity ? Color.LightGreen : Color.LightGray;
                btnNotScarcity.BackColor = !scenario.IsScarcity ? Color.LightGreen : Color.LightGray;
            }
            else
            {
                btnIsScarcity.BackColor = scenario.IsScarcity ? Color.LightGreen : Color.LightCoral;
                btnNotScarcity.BackColor = !scenario.IsScarcity ? Color.LightGreen : Color.LightCoral;
            }
            
            // Show explanation
            lblExplanation.Text = scenario.Explanation;
            lblGeorgiaExample.Text = $"Georgia Connection: {scenario.GeorgiaExample}";
            lblLessonLearned.Text = $"Lesson: {scenario.LessonLearned}";
            
            UpdateProgress();
            
            string resultMessage = isCorrect ? "Correct! 🎉" : "Not quite! 🤔";
            MessageBox.Show($"{resultMessage}\n\n{scenario.Explanation}", "Scarcity Check!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIsScarcity_Click(object sender, EventArgs e)
        {
            CheckAnswer(true);
        }

        private void btnNotScarcity_Click(object sender, EventArgs e)
        {
            CheckAnswer(false);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentScenarioIndex < scenarios.Count - 1)
            {
                currentScenarioIndex++;
                DisplayScenario(currentScenarioIndex);
            }
            else
            {
                // All scenarios completed, navigate to Unit 4 Ch 3
                this.Hide();
                Unit_4_Ch_3__SS1E3_ unit4Ch3 = new Unit_4_Ch_3__SS1E3_();
                unit4Ch3.Show();
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

        private void btnScarcityGame_Click(object sender, EventArgs e)
        {
            string gameInstructions = "🎮 SCARCITY DETECTIVE GAME! 🎮\n\n";
            gameInstructions += "Look around your classroom and find:\n\n";
            gameInstructions += "✅ 3 things where there's ENOUGH for everyone:\n";
            gameInstructions += "   (Like: pencils, paper, chairs)\n\n";
            gameInstructions += "❌ 3 things where there might be SCARCITY:\n";
            gameInstructions += "   (Like: the teacher's special markers, computer time)\n\n";
            gameInstructions += "🔍 SCARCITY CLUES:\n";
            gameInstructions += "• More people want it than there are available\n";
            gameInstructions += "• People have to wait or take turns\n";
            gameInstructions += "• It costs more money than you have\n\n";
            gameInstructions += "Discuss your findings with your class!";
            
            MessageBox.Show(gameInstructions, "Scarcity Detective Game!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChoicesQuiz_Click(object sender, EventArgs e)
        {
            string quiz = "🤔 SCARCITY CHOICES QUIZ! 🤔\n\n";
            quiz += "Imagine you have $3 and you're at the school store:\n\n";
            quiz += "🍎 Apple: $1\n";
            quiz += "📝 Pencil: $1\n";
            quiz += "📚 Sticker pack: $2\n";
            quiz += "🧸 Small toy: $3\n\n";
            quiz += "QUESTIONS:\n";
            quiz += "1. Can you buy everything? (No - that's scarcity!)\n";
            quiz += "2. What would you choose and why?\n";
            quiz += "3. What would you have to give up?\n\n";
            quiz += "💡 This is what grown-ups call 'opportunity cost' - \n";
            quiz += "what you give up when you make a choice!\n\n";
            quiz += "Talk about your choices with your teacher!";
            
            MessageBox.Show(quiz, "Scarcity Choices Quiz", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnNeedsWants_Click(object sender, EventArgs e)
        {
            string needsWants = "💭 NEEDS vs WANTS 💭\n\n";
            needsWants += "Understanding scarcity starts with knowing the difference:\n\n";
            needsWants += "🏠 NEEDS (Things you must have to live):\n";
            needsWants += "• Food to eat\n";
            needsWants += "• Water to drink\n";
            needsWants += "• Clothes to wear\n";
            needsWants += "• Home to live in\n";
            needsWants += "• Medical care when sick\n\n";
            needsWants += "🎮 WANTS (Things that would be nice to have):\n";
            needsWants += "• Toys and games\n";
            needsWants += "• Ice cream and candy\n";
            needsWants += "• Latest shoes or clothes\n";
            needsWants += "• Video games\n";
            needsWants += "• Extra stuff for fun\n\n";
            needsWants += "💡 Scarcity means we can't have unlimited wants,\n";
            needsWants += "so we have to choose wisely!\n\n";
            needsWants += "🏖️ Georgia families make these choices every day!";
            
            MessageBox.Show(needsWants, "Needs vs Wants", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBackToUnit4Ch1_Click(object sender, EventArgs e)
        {
            Unit_4_Ch_1__SS1E1_ unit4Ch1Form = new Unit_4_Ch_1__SS1E1_();
            unit4Ch1Form.Show();
        }

        private void btnShowScore_Click(object sender, EventArgs e)
        {
            if (totalQuestions == 0)
            {
                MessageBox.Show("Try answering some scenarios first!", "No Score Yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            double percentage = (double)correctAnswers / totalQuestions * 100;
            string grade = "";
            string message = "";
            
            if (percentage >= 90)
            {
                grade = "A+";
                message = "Outstanding! You're a Scarcity Expert! 🌟";
            }
            else if (percentage >= 80)
            {
                grade = "B+";
                message = "Great job! You understand scarcity well! 👍";
            }
            else if (percentage >= 70)
            {
                grade = "C+";
                message = "Good work! Keep practicing! 📚";
            }
            else
            {
                grade = "Keep Learning";
                message = "You're learning! Try more scenarios! 💪";
            }
            
            string scoreReport = $"📊 SCARCITY REPORT CARD 📊\n\n";
            scoreReport += $"Questions Answered: {totalQuestions}\n";
            scoreReport += $"Correct Answers: {correctAnswers}\n";
            scoreReport += $"Score: {percentage:F0}%\n";
            scoreReport += $"Grade: {grade}\n\n";
            scoreReport += $"{message}\n\n";
            scoreReport += "🍑 Georgia students are learning about economics!";
            
            MessageBox.Show(scoreReport, "Your Scarcity Score!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuizMode_Click(object sender, EventArgs e)
        {
            // Hide all panels first
            pnlScenario.Visible = false;
            pnlQuiz.Visible = true;
            pnlNeedsWants.Visible = false;
            
            // Start quiz mode logic here
            MessageBox.Show("Quiz Mode coming soon! For now, use the main scenarios to learn about scarcity.", "Quiz Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNeedsWantsGame_Click(object sender, EventArgs e)
        {
            // Hide other panels and show needs/wants panel
            pnlScenario.Visible = false;
            pnlQuiz.Visible = false;
            pnlNeedsWants.Visible = true;
            
            // Set up the needs vs wants game
            SetupNeedsWantsGame();
        }

        private void SetupNeedsWantsGame()
        {
            string[] needsWantsItems = {
                "Food to eat|NEED|We need food to survive and grow!",
                "Video game console|WANT|This is fun but not necessary for survival",
                "Clean water to drink|NEED|Water is essential for our body to work",
                "Expensive sneakers|WANT|We need shoes, but expensive ones are a want",
                "Warm clothes|NEED|We need clothes to stay warm and comfortable",
                "Ice cream|WANT|Ice cream is tasty but not necessary for health",
                "A place to live|NEED|Everyone needs shelter to be safe",
                "Latest toy|WANT|Toys are fun but not essential for living"
            };
            
            // This would be expanded to cycle through items
            lblNeedsWantsItem.Text = "Food to eat - something your body needs every day to grow and be healthy";
        }

        private void btnNeed_Click(object sender, EventArgs e)
        {
            // Handle need button click
            MessageBox.Show("Good thinking! Food is definitely a NEED - we must have it to survive!", "Correct!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWant_Click(object sender, EventArgs e)
        {
            // Handle want button click  
            MessageBox.Show("Think again! Food is something we NEED to survive, not just want.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Reset the application
            currentScenarioIndex = 0;
            correctAnswers = 0;
            totalQuestions = 0;
            
            // Show main scenario panel
            pnlScenario.Visible = true;
            pnlQuiz.Visible = false;
            pnlNeedsWants.Visible = false;
            
            DisplayScenario(currentScenarioIndex);
            MessageBox.Show("Starting over! Let's learn about scarcity from the beginning.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToUnit4Ch1_Click(object sender, EventArgs e)
        {
            // Navigate back to Unit 4 Ch 1
            Unit_4_Ch_1__SS1E1_ unit4Ch1Form = new Unit_4_Ch_1__SS1E1_();
            unit4Ch1Form.Show();
            this.Hide();
        }

        private void btnToForm1_Click(object sender, EventArgs e)
        {
            // Navigate to main menu (Form1)
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
        
        private void btnToUnit4Ch3_Click(object sender, EventArgs e)
        {
            // Navigate to Unit 4 Ch 3 (SS1E3)
            this.Hide();
            Unit_4_Ch_3__SS1E3_ unit4Ch3 = new Unit_4_Ch_3__SS1E3_();
            unit4Ch3.Show();
        }
    }
}
