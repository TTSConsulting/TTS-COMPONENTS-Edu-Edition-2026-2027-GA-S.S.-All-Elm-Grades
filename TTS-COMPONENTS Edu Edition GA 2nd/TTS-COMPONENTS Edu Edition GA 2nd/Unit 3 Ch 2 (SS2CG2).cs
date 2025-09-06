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
    public partial class Unit_3_Ch_2__SS2CG2_ : Form
    {
        public Unit_3_Ch_2__SS2CG2_()
        {
            InitializeComponent();
        }

        private void LeaderButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            switch (clickedButton.Name)
            {
                case "btnPresident":
                    leaderInfoLabel.Text = "🏛️ THE PRESIDENT\n\n" +
                        "The President is the leader of our entire country!\n\n" +
                        "👤 WHAT THE PRESIDENT DOES:\n" +
                        "• Makes important decisions for America\n" +
                        "• Signs laws that Congress makes\n" +
                        "• Keeps our country safe\n" +
                        "• Meets with leaders from other countries\n" +
                        "• Lives and works in the White House\n\n" +
                        "🇺🇸 FUN FACTS:\n" +
                        "• Elected every 4 years\n" +
                        "• Must be at least 35 years old\n" +
                        "• Leader of the Executive Branch\n\n" +
                        "📍 WORKS AT: White House in Washington, D.C.";
                    break;

                case "btnWhiteHouse":
                    leaderInfoLabel.Text = "🏛️ THE WHITE HOUSE\n\n" +
                        "The White House is where the President lives and works!\n\n" +
                        "🏠 ABOUT THE WHITE HOUSE:\n" +
                        "• The President's home and office\n" +
                        "• Located in Washington, D.C.\n" +
                        "• Has 132 rooms!\n" +
                        "• Built over 200 years ago\n" +
                        "• Famous for its white color\n\n" +
                        "🎯 IMPORTANT WORK DONE HERE:\n" +
                        "• Making decisions for our country\n" +
                        "• Meeting with other world leaders\n" +
                        "• Signing important laws\n\n" +
                        "📍 ADDRESS: 1600 Pennsylvania Avenue\nWashington, D.C.";
                    break;

                case "btnGovernor":
                    leaderInfoLabel.Text = "🍑 THE GOVERNOR\n\n" +
                        "The Governor is the leader of our state of Georgia!\n\n" +
                        "👤 WHAT THE GOVERNOR DOES:\n" +
                        "• Makes decisions for everyone in Georgia\n" +
                        "• Signs state laws\n" +
                        "• Helps keep Georgia safe\n" +
                        "• Works with other states\n" +
                        "• Lives and works in Atlanta\n\n" +
                        "🍑 ABOUT GEORGIA'S GOVERNOR:\n" +
                        "• Elected every 4 years by Georgia voters\n" +
                        "• Leader of Georgia's Executive Branch\n" +
                        "• Works to make Georgia a great place to live\n\n" +
                        "📍 WORKS AT: State Capitol Building in Atlanta, GA";
                    break;

                case "btnStateCapitol":
                    leaderInfoLabel.Text = "🏛️ GEORGIA STATE CAPITOL\n\n" +
                        "The State Capitol is where Georgia's Governor works!\n\n" +
                        "🏠 ABOUT THE STATE CAPITOL:\n" +
                        "• Governor's office and workplace\n" +
                        "• Located in Atlanta, Georgia\n" +
                        "• Beautiful gold dome on top\n" +
                        "• Where state laws are made\n" +
                        "• Georgia's government center\n\n" +
                        "🎯 IMPORTANT WORK DONE HERE:\n" +
                        "• Making decisions for all Georgians\n" +
                        "• Creating state laws\n" +
                        "• Managing Georgia's government\n\n" +
                        "📍 ADDRESS: 206 Washington Street SW\nAtlanta, Georgia";
                    break;

                case "btnMayor":
                    leaderInfoLabel.Text = "🏙️ THE MAYOR\n\n" +
                        "The Mayor is the leader of your city or town!\n\n" +
                        "👤 WHAT THE MAYOR DOES:\n" +
                        "• Makes decisions for your local community\n" +
                        "• Helps keep your city clean and safe\n" +
                        "• Manages city services like parks and libraries\n" +
                        "• Works with the city council\n" +
                        "• Lives in your community\n\n" +
                        "🏙️ ABOUT YOUR MAYOR:\n" +
                        "• Elected by people in your city\n" +
                        "• Knows local problems and needs\n" +
                        "• Closest government leader to you\n\n" +
                        "📍 WORKS AT: City Hall in your city";
                    break;

                case "btnCityHall":
                    leaderInfoLabel.Text = "🏛️ CITY HALL\n\n" +
                        "City Hall is where your Mayor works!\n\n" +
                        "🏠 ABOUT CITY HALL:\n" +
                        "• Mayor's office and workplace\n" +
                        "• Located in your city\n" +
                        "• Where local government meets\n" +
                        "• Place for city services\n" +
                        "• Center of local government\n\n" +
                        "🎯 IMPORTANT WORK DONE HERE:\n" +
                        "• Making decisions for your community\n" +
                        "• Planning local events\n" +
                        "• Managing city services\n" +
                        "• Helping local residents\n\n" +
                        "📍 LOCATION: Your local city's downtown area";
                    break;

                case "btnWashingtonDC":
                    leaderInfoLabel.Text = "🏛️ WASHINGTON, D.C.\n\n" +
                        "Washington, D.C. is our nation's capital!\n\n" +
                        "🇺🇸 ABOUT WASHINGTON, D.C.:\n" +
                        "• Capital city of the United States\n" +
                        "• Where the President works\n" +
                        "• Home to the White House\n" +
                        "• Where Congress meets\n" +
                        "• Center of our national government\n\n" +
                        "🏛️ IMPORTANT BUILDINGS:\n" +
                        "• White House (President's home)\n" +
                        "• Capitol Building (Congress)\n" +
                        "• Supreme Court\n" +
                        "• Many monuments and museums\n\n" +
                        "📍 SPECIAL FACT: D.C. stands for District of Columbia!";
                    break;

                case "btnAtlantaGA":
                    leaderInfoLabel.Text = "🍑 ATLANTA, GEORGIA\n\n" +
                        "Atlanta is Georgia's capital city!\n\n" +
                        "🍑 ABOUT ATLANTA:\n" +
                        "• Capital city of Georgia\n" +
                        "• Where the Governor works\n" +
                        "• Home to the State Capitol\n" +
                        "• Georgia's largest city\n" +
                        "• Center of Georgia's government\n\n" +
                        "🏛️ IMPORTANT PLACES:\n" +
                        "• State Capitol Building (Governor)\n" +
                        "• Georgia State University\n" +
                        "• Many parks and museums\n" +
                        "• Atlanta Zoo and Aquarium\n\n" +
                        "📍 FUN FACT: Atlanta is known as the 'City in a Forest'!";
                    break;

                case "btnLocalCity":
                    leaderInfoLabel.Text = "🏙️ YOUR LOCAL CITY\n\n" +
                        "Your city is where you live and where your Mayor works!\n\n" +
                        "🏙️ ABOUT YOUR CITY:\n" +
                        "• Your home community\n" +
                        "• Where your Mayor works\n" +
                        "• Has its own City Hall\n" +
                        "• Part of Georgia state\n" +
                        "• Your local government\n\n" +
                        "🏛️ LOCAL PLACES:\n" +
                        "• City Hall (Mayor's office)\n" +
                        "• Local parks and libraries\n" +
                        "• Your school\n" +
                        "• Community centers\n\n" +
                        "📍 SPECIAL: This is YOUR community where you can make a difference!";
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
            // Navigate to Unit 3 Chapter 3 (SS2CG3 - Citizenship Traits)
            this.Hide();
            Unit_3_Ch_3__SS2CG3_ unit3Ch3Form = new Unit_3_Ch_3__SS2CG3_();
            unit3Ch3Form.Show();
        }

        private void btnToUnit3Ch3_Click(object sender, EventArgs e)
        {
            // Navigate to Unit 3 Chapter 3 (SS2CG3 - Citizenship Traits)
            this.Hide();
            Unit_3_Ch_3__SS2CG3_ unit3Ch3Form = new Unit_3_Ch_3__SS2CG3_();
            unit3Ch3Form.Show();
        }
    }
}
