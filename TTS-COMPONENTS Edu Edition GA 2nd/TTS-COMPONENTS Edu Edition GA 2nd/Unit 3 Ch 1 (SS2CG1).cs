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
    public partial class Unit_3_Ch_1__SS2CG1_ : Form
    {
        public Unit_3_Ch_1__SS2CG1_()
        {
            InitializeComponent();
        }

        private void GovernmentButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;
            
            switch (clickedButton.Name)
            {
                case "btnWhatIsGovernment":
                    governmentInfoLabel.Text = "🏛️ WHAT IS GOVERNMENT?\n\n" +
                        "Government is a group of people who make rules and laws to help everyone live together safely and happily!\n\n" +
                        "• Government makes rules for everyone to follow\n" +
                        "• Government helps keep us safe\n" +
                        "• Government makes sure everyone is treated fairly\n" +
                        "• We have government in our town, state, and country\n\n" +
                        "Just like your family has rules at home, our community has rules too!";
                    break;

                case "btnRulesAtHome":
                    governmentInfoLabel.Text = "🏠 RULES AT HOME\n\n" +
                        "Every family has rules to help everyone get along and stay safe!\n\n" +
                        "Examples of home rules:\n" +
                        "• Be kind to your family members\n" +
                        "• Clean up your toys when you're done\n" +
                        "• Ask permission before going outside\n" +
                        "• Do your homework before playing\n" +
                        "• Be respectful to parents and siblings\n\n" +
                        "These rules help families live together peacefully!";
                    break;

                case "btnRulesAtSchool":
                    governmentInfoLabel.Text = "🏫 RULES AT SCHOOL\n\n" +
                        "Schools have rules to help everyone learn and feel safe!\n\n" +
                        "Examples of school rules:\n" +
                        "• Raise your hand before speaking\n" +
                        "• Walk quietly in the hallways\n" +
                        "• Be kind to all classmates\n" +
                        "• Listen when the teacher is talking\n" +
                        "• Keep your hands to yourself\n" +
                        "• Take turns and share\n\n" +
                        "These rules help create a good learning environment for everyone!";
                    break;

                case "btnLawsInCommunity":
                    governmentInfoLabel.Text = "🌆 LAWS IN OUR COMMUNITY\n\n" +
                        "Laws are special rules that everyone in our community must follow!\n\n" +
                        "Examples of community laws:\n" +
                        "• Stop at red lights and stop signs\n" +
                        "• Don't take things that don't belong to you\n" +
                        "• Be respectful in public places\n" +
                        "• Throw trash in garbage cans\n" +
                        "• Follow speed limits when driving\n\n" +
                        "Laws help keep our whole community safe and clean!";
                    break;

                case "btnWhyNeedRules":
                    governmentInfoLabel.Text = "❓ WHY WE NEED RULES\n\n" +
                        "Rules and laws are very important because they:\n\n" +
                        "🛡️ Keep us SAFE\n" +
                        "• Rules protect us from getting hurt\n" +
                        "• They help prevent accidents\n\n" +
                        "⚖️ Make things FAIR\n" +
                        "• Everyone gets a turn\n" +
                        "• No one gets left out\n\n" +
                        "🤝 Help us get along\n" +
                        "• Rules help us be kind to each other\n" +
                        "• They help solve problems peacefully\n\n" +
                        "Without rules, things would be chaotic and unsafe!";
                    break;

                case "btnLeaders":
                    governmentInfoLabel.Text = "👩‍💼 OUR LEADERS\n\n" +
                        "Leaders are people who help make and enforce rules and laws!\n\n" +
                        "Types of leaders:\n" +
                        "🏠 Family Leaders: Parents and guardians\n" +
                        "🏫 School Leaders: Principal, teachers\n" +
                        "🏛️ Community Leaders: Mayor, governor\n" +
                        "🇺🇸 Country Leaders: President\n\n" +
                        "Good leaders:\n" +
                        "• Listen to people's needs\n" +
                        "• Make fair decisions\n" +
                        "• Help solve problems\n" +
                        "• Keep everyone safe\n\n" +
                        "Leaders work hard to make good rules for everyone!";
                    break;

                case "btnClassroomRules":
                    governmentInfoLabel.Text = "📚 CLASSROOM RULES\n\n" +
                        "Let's think about the rules in our classroom!\n\n" +
                        "Common classroom rules:\n" +
                        "• Respect your teacher and classmates\n" +
                        "• Raise your hand to speak\n" +
                        "• Use inside voices\n" +
                        "• Keep your desk and area clean\n" +
                        "• Follow directions the first time\n" +
                        "• Help others when they need it\n\n" +
                        "These rules help create a place where everyone can learn and have fun!\n\n" +
                        "What are some rules in YOUR classroom?";
                    break;

                case "btnSafetyLaws":
                    governmentInfoLabel.Text = "🚦 SAFETY LAWS\n\n" +
                        "Safety laws protect everyone in our community!\n\n" +
                        "Important safety laws:\n" +
                        "🚗 Traffic Laws:\n" +
                        "• Stop at red lights\n" +
                        "• Look both ways before crossing\n" +
                        "• Wear seatbelts in cars\n\n" +
                        "🚴 Bike Safety Laws:\n" +
                        "• Wear a helmet when riding\n" +
                        "• Ride on the right side\n\n" +
                        "🏥 Health Laws:\n" +
                        "• Wash hands to stay healthy\n" +
                        "• Cover your mouth when coughing\n\n" +
                        "These laws help prevent accidents and keep everyone healthy!";
                    break;

                case "btnFairness":
                    governmentInfoLabel.Text = "⚖️ BEING FAIR TO EVERYONE\n\n" +
                        "Fairness means treating everyone with respect and kindness!\n\n" +
                        "How to be fair:\n" +
                        "🤝 Taking Turns:\n" +
                        "• Everyone gets a chance to play\n" +
                        "• Share toys and games\n\n" +
                        "👂 Listening:\n" +
                        "• Listen to what others have to say\n" +
                        "• Let everyone share their ideas\n\n" +
                        "🎯 Equal Treatment:\n" +
                        "• Follow the same rules for everyone\n" +
                        "• Be kind to all people\n\n" +
                        "💭 Making Good Choices:\n" +
                        "• Think about how others feel\n" +
                        "• Help solve problems peacefully\n\n" +
                        "When we're fair, everyone feels happy and included!";
                    break;
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            // Navigate back to main menu
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void btnNextUnit_Click(object sender, EventArgs e)
        {
            // Navigate to Unit 3 Chapter 2 (SS2CG2 - Elected Officials)
            this.Hide();
            Unit_3_Ch_2__SS2CG2_ unit3Ch2Form = new Unit_3_Ch_2__SS2CG2_();
            unit3Ch2Form.Show();
        }

        private void btnToUnit3Ch2_Click(object sender, EventArgs e)
        {
            // Navigate to Unit 3 Chapter 2 (SS2CG2 - Elected Officials)
            this.Hide();
            Unit_3_Ch_2__SS2CG2_ unit3Ch2Form = new Unit_3_Ch_2__SS2CG2_();
            unit3Ch2Form.Show();
        }
    }
}
