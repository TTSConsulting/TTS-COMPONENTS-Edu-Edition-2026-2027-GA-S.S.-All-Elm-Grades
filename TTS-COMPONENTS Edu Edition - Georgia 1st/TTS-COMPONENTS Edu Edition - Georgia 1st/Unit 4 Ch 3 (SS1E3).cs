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
    public partial class Unit_4_Ch_3__SS1E3_ : Form
    {
        private List<PersonExample> peopleExamples = new List<PersonExample>();
        private int currentPersonIndex = 0;
        private int correctAnswers = 0;
        private int totalQuestions = 0;
        private string currentGameMode = "scenarios"; // scenarios, producer_consumer_quiz, job_match

        public Unit_4_Ch_3__SS1E3_()
        {
            InitializeComponent();
            InitializePeopleExamples();
            
            // Set up initial panel visibility
            pnlScenarios.Visible = true;
            pnlProducerConsumerQuiz.Visible = false;
            pnlJobMatch.Visible = false;
            
            DisplayPerson(currentPersonIndex);
        }

        public class PersonExample
        {
            public string Name { get; set; }
            public string Job { get; set; }
            public string WhatTheyProduce { get; set; }
            public string WhatTheyConsume { get; set; }
            public string GeorgiaConnection { get; set; }
            public string ProducerExample { get; set; }
            public string ConsumerExample { get; set; }
            public string BothExample { get; set; }

            public PersonExample(string name, string job, string whatTheyProduce, string whatTheyConsume, 
                               string georgiaConnection, string producerExample, string consumerExample, string bothExample)
            {
                Name = name;
                Job = job;
                WhatTheyProduce = whatTheyProduce;
                WhatTheyConsume = whatTheyConsume;
                GeorgiaConnection = georgiaConnection;
                ProducerExample = producerExample;
                ConsumerExample = consumerExample;
                BothExample = bothExample;
            }
        }

        private void InitializePeopleExamples()
        {
            peopleExamples = new List<PersonExample>
            {
                new PersonExample(
                    "Mrs. Johnson - Baker",
                    "Baker at Georgia Bread Company",
                    "Makes fresh bread, cookies, and cakes every day",
                    "Buys flour, sugar, and milk to make her baked goods. Also buys clothes and gas for her car",
                    "Many Georgia towns have local bakeries that serve fresh bread to the community",
                    "As a PRODUCER: She bakes 50 loaves of bread each morning",
                    "As a CONSUMER: She buys ingredients and groceries for her family",
                    "She's BOTH! She makes bread (producer) AND buys things she needs (consumer)"
                ),
                new PersonExample(
                    "Mr. Davis - Farmer",
                    "Peach Farmer in Georgia",
                    "Grows and sells Georgia's famous peaches",
                    "Buys farming tools, seeds, and food for his family",
                    "Georgia is famous for its sweet peaches - they're grown all over the state!",
                    "As a PRODUCER: He grows thousands of peaches on his farm",
                    "As a CONSUMER: He shops for groceries and farming equipment",
                    "He's BOTH! He grows peaches (producer) AND buys supplies (consumer)"
                ),
                new PersonExample(
                    "Ms. Garcia - Teacher",
                    "1st Grade Teacher",
                    "Teaches students how to read, write, and learn about Georgia",
                    "Buys school supplies, books, and lunch from the cafeteria",
                    "Georgia teachers help students learn about their state and community",
                    "As a PRODUCER: She provides education services to 20 students",
                    "As a CONSUMER: She buys teaching materials and personal items",
                    "She's BOTH! She teaches lessons (producer) AND buys classroom supplies (consumer)"
                ),
                new PersonExample(
                    "Dr. Martinez - Doctor",
                    "Family Doctor in Atlanta",
                    "Provides medical care and helps people feel better",
                    "Buys medical supplies, medicine, and food for her family",
                    "Georgia doctors take care of families throughout the state",
                    "As a PRODUCER: She provides medical services to keep people healthy",
                    "As a CONSUMER: She purchases medical equipment and personal needs",
                    "She's BOTH! She helps patients (producer) AND buys things she needs (consumer)"
                ),
                new PersonExample(
                    "Mr. Thompson - Mechanic",
                    "Car Mechanic in Savannah",
                    "Fixes cars and trucks so people can drive safely",
                    "Buys car parts, tools, and groceries for his family",
                    "Georgia mechanics keep cars running for families across the state",
                    "As a PRODUCER: He provides car repair services",
                    "As a CONSUMER: He buys auto parts and family necessities",
                    "He's BOTH! He fixes cars (producer) AND buys parts and food (consumer)"
                ),
                new PersonExample(
                    "Ms. Wilson - Store Owner",
                    "Owns Wilson's Corner Store",
                    "Sells snacks, drinks, and school supplies to customers",
                    "Buys products to stock her store and personal items for her home",
                    "Small corner stores serve Georgia neighborhoods with daily needs",
                    "As a PRODUCER: She provides goods and services to her community",
                    "As a CONSUMER: She buys inventory for her store and personal items",
                    "She's BOTH! She sells goods (producer) AND buys products to sell (consumer)"
                )
            };
        }

        private void DisplayPerson(int index)
        {
            if (index >= 0 && index < peopleExamples.Count)
            {
                var person = peopleExamples[index];
                lblPersonName.Text = person.Name;
                lblPersonJob.Text = $"Job: {person.Job}";
                lblWhatTheyProduce.Text = $"What They Produce: {person.WhatTheyProduce}";
                lblWhatTheyConsume.Text = $"What They Consume: {person.WhatTheyConsume}";
                lblGeorgiaConnection.Text = $"Georgia Connection: {person.GeorgiaConnection}";
                
                // Clear explanations initially
                lblProducerExample.Text = "";
                lblConsumerExample.Text = "";
                lblBothExample.Text = "";
                
                // Reset button colors
                btnProducer.BackColor = Color.LightBlue;
                btnConsumer.BackColor = Color.LightGreen;
                btnBoth.BackColor = Color.Gold;
                
                btnPrevious.Enabled = index > 0;
                btnNext.Enabled = index < peopleExamples.Count - 1;
                
                UpdateProgress();
            }
        }

        private void UpdateProgress()
        {
            lblProgress.Text = $"Person {currentPersonIndex + 1} of {peopleExamples.Count}";
            if (totalQuestions > 0)
            {
                lblScore.Text = $"Correct: {correctAnswers}/{totalQuestions}";
            }
            else
            {
                lblScore.Text = "Click your answer below!";
            }
        }

        private void CheckAnswer(string userAnswer)
        {
            var person = peopleExamples[currentPersonIndex];
            totalQuestions++;
            
            // Everyone is BOTH producer and consumer - that's the correct answer
            bool isCorrect = userAnswer == "BOTH";
            if (isCorrect)
            {
                correctAnswers++;
            }
            
            // Show appropriate examples and highlight correct answer
            switch (userAnswer)
            {
                case "PRODUCER":
                    lblProducerExample.Text = person.ProducerExample;
                    lblBothExample.Text = $"But wait! {person.BothExample}";
                    btnProducer.BackColor = isCorrect ? Color.LightGreen : Color.LightCoral;
                    btnBoth.BackColor = Color.LightGreen; // Show correct answer
                    break;
                case "CONSUMER":
                    lblConsumerExample.Text = person.ConsumerExample;
                    lblBothExample.Text = $"But wait! {person.BothExample}";
                    btnConsumer.BackColor = isCorrect ? Color.LightGreen : Color.LightCoral;
                    btnBoth.BackColor = Color.LightGreen; // Show correct answer
                    break;
                case "BOTH":
                    lblProducerExample.Text = person.ProducerExample;
                    lblConsumerExample.Text = person.ConsumerExample;
                    lblBothExample.Text = $"Exactly right! {person.BothExample}";
                    btnBoth.BackColor = Color.LightGreen;
                    break;
            }
            
            UpdateProgress();
            
            string resultMessage = isCorrect ? "Perfect! 🎉" : "Good thinking, but... 🤔";
            string explanation = isCorrect ? 
                "You're absolutely right! People are both producers AND consumers!" :
                "Actually, ALL people are both producers AND consumers. Let's see why...";
            
            MessageBox.Show($"{resultMessage}\n\n{explanation}\n\n{person.BothExample}", 
                          "Producer & Consumer Check!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProducer_Click(object sender, EventArgs e)
        {
            CheckAnswer("PRODUCER");
        }

        private void btnConsumer_Click(object sender, EventArgs e)
        {
            CheckAnswer("CONSUMER");
        }

        private void btnBoth_Click(object sender, EventArgs e)
        {
            CheckAnswer("BOTH");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPersonIndex < peopleExamples.Count - 1)
            {
                currentPersonIndex++;
                DisplayPerson(currentPersonIndex);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPersonIndex > 0)
            {
                currentPersonIndex--;
                DisplayPerson(currentPersonIndex);
            }
        }

        private void btnProducerConsumerGame_Click(object sender, EventArgs e)
        {
            // Switch to producer/consumer identification game
            pnlScenarios.Visible = false;
            pnlProducerConsumerQuiz.Visible = true;
            pnlJobMatch.Visible = false;
            currentGameMode = "producer_consumer_quiz";
            
            SetupProducerConsumerQuiz();
        }

        private void SetupProducerConsumerQuiz()
        {
            string[] activities = {
                "Making cookies|PRODUCER|When you make cookies, you're creating something new!",
                "Eating lunch|CONSUMER|When you eat lunch, you're using up food that someone else made",
                "Drawing a picture|PRODUCER|When you draw, you're creating art!",
                "Reading a book|CONSUMER|When you read, you're using a book that someone else wrote",
                "Helping mom cook dinner|PRODUCER|When you help cook, you're helping make food!",
                "Playing with toys|CONSUMER|When you play with toys, you're using toys that were made",
                "Singing a song for family|PRODUCER|When you sing, you're creating music and entertainment!",
                "Watching TV|CONSUMER|When you watch TV, you're using entertainment that others created"
            };
            
            Random random = new Random();
            string selectedActivity = activities[random.Next(activities.Length)];
            string[] parts = selectedActivity.Split('|');
            
            lblQuizActivity.Text = $"Activity: {parts[0]}";
            lblQuizResult.Text = "";
            lblQuizResult.Visible = false;
            
            // Reset button colors
            btnQuizProducer.BackColor = Color.LightBlue;
            btnQuizConsumer.BackColor = Color.LightGreen;
        }

        private void btnJobMatchGame_Click(object sender, EventArgs e)
        {
            // Switch to job matching game
            pnlScenarios.Visible = false;
            pnlProducerConsumerQuiz.Visible = false;
            pnlJobMatch.Visible = true;
            currentGameMode = "job_match";
            
            SetupJobMatchGame();
        }

        private void SetupJobMatchGame()
        {
            lblJobMatchInstructions.Text = "🎯 JOB MATCHING GAME! 🎯\n\nMatch each Georgia job with what they PRODUCE:\n\n🍑 Peach Farmer → Grows peaches\n👩‍🏫 Teacher → Provides education\n👨‍⚕️ Doctor → Provides medical care\n🚗 Mechanic → Provides car repairs\n🍞 Baker → Makes bread and cakes\n🏪 Store Owner → Provides goods and services\n\nRemember: They're ALL also consumers who buy things they need!";
        }

        private void btnBackToScenarios_Click(object sender, EventArgs e)
        {
            // Return to main scenarios
            pnlScenarios.Visible = true;
            pnlProducerConsumerQuiz.Visible = false;
            pnlJobMatch.Visible = false;
            currentGameMode = "scenarios";
        }

        private void btnQuizProducer_Click(object sender, EventArgs e)
        {
            // Handle producer/consumer quiz answer
            string activity = lblQuizActivity.Text.Replace("Activity: ", "");
            string message = "";
            
            // Simple logic - activities ending in "ing" and creating something are usually producer
            if (activity.Contains("Making") || activity.Contains("Drawing") || activity.Contains("cook") || activity.Contains("Singing"))
            {
                message = "Correct! This person is being a PRODUCER - they're making or creating something!";
                btnQuizProducer.BackColor = Color.LightGreen;
            }
            else
            {
                message = "Not quite! This activity is more about being a CONSUMER - using something others made.";
                btnQuizProducer.BackColor = Color.LightCoral;
                btnQuizConsumer.BackColor = Color.LightGreen;
            }
            
            lblQuizResult.Text = message;
            lblQuizResult.Visible = true;
        }

        private void btnQuizConsumer_Click(object sender, EventArgs e)
        {
            // Handle consumer quiz answer
            string activity = lblQuizActivity.Text.Replace("Activity: ", "");
            string message = "";
            
            // Activities involving using/consuming something
            if (activity.Contains("Eating") || activity.Contains("Reading") || activity.Contains("Playing") || activity.Contains("Watching"))
            {
                message = "Correct! This person is being a CONSUMER - they're using something that was made by others!";
                btnQuizConsumer.BackColor = Color.LightGreen;
            }
            else
            {
                message = "Not quite! This activity is more about being a PRODUCER - making or creating something.";
                btnQuizConsumer.BackColor = Color.LightCoral;
                btnQuizProducer.BackColor = Color.LightGreen;
            }
            
            lblQuizResult.Text = message;
            lblQuizResult.Visible = true;
        }

        private void btnShowScore_Click(object sender, EventArgs e)
        {
            if (totalQuestions == 0)
            {
                MessageBox.Show("Try answering some questions first!", "No Score Yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            double percentage = (double)correctAnswers / totalQuestions * 100;
            string grade = "";
            string message = "";
            
            if (percentage >= 90)
            {
                grade = "A+";
                message = "Outstanding! You're a Producer & Consumer Expert! 🌟";
            }
            else if (percentage >= 80)
            {
                grade = "B+";
                message = "Great job! You understand producers and consumers well! 👍";
            }
            else if (percentage >= 70)
            {
                grade = "C+";
                message = "Good work! Keep practicing! 📚";
            }
            else
            {
                grade = "Keep Learning";
                message = "You're learning! Try more examples! 💪";
            }
            
            string scoreReport = $"📊 PRODUCER & CONSUMER REPORT CARD 📊\n\n";
            scoreReport += $"Questions Answered: {totalQuestions}\n";
            scoreReport += $"Correct Answers: {correctAnswers}\n";
            scoreReport += $"Score: {percentage:F0}%\n";
            scoreReport += $"Grade: {grade}\n\n";
            scoreReport += $"{message}\n\n";
            scoreReport += "🍑 Georgia students are learning about economics!\n\n";
            scoreReport += "Remember: EVERYONE is both a producer AND a consumer!";
            
            MessageBox.Show(scoreReport, "Your Producer & Consumer Score!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Reset the application
            currentPersonIndex = 0;
            correctAnswers = 0;
            totalQuestions = 0;
            
            // Show main scenarios panel
            pnlScenarios.Visible = true;
            pnlProducerConsumerQuiz.Visible = false;
            pnlJobMatch.Visible = false;
            currentGameMode = "scenarios";
            
            DisplayPerson(currentPersonIndex);
            MessageBox.Show("Starting over! Let's learn about producers and consumers from the beginning.", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToUnit4Ch2_Click(object sender, EventArgs e)
        {
            // Navigate back to Unit 4 Ch 2
            Unit_4_Ch_2__SS1E2_ unit4Ch2Form = new Unit_4_Ch_2__SS1E2_();
            unit4Ch2Form.Show();
            this.Hide();
        }

        private void btnToUnit4Ch4_Click(object sender, EventArgs e)
        {
            // Navigate to Unit 4 Ch 4
            Unit_4_Ch_4__SS1E4_ unit4Ch4Form = new Unit_4_Ch_4__SS1E4_();
            unit4Ch4Form.Show();
            this.Hide();
        }

        private void btnToForm1_Click(object sender, EventArgs e)
        {
            // Navigate to main menu (Form1)
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }
}
