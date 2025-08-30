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
    public partial class Unit_6__SSKG3_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox addressComponentComboBox;
        private PictureBox addressPictureBox;
        private Label descriptionLabel;
        private Panel examplePanel;
        private Label exampleLabel;
        private TextBox studentAddressTextBox;
        private Label practiceLabel;
        private Button nextButton;
        private Button previousButton;
        private Label copyrightLabel;
        private Button goToUnit1Button;
        private Button goToUnit2Button;
        private Button goToUnit3Button;
        private Button goToUnit4Button;
        private Button goToUnit5Button;
        private Button goToUnit7Button; // Add this new button variable

        public Unit_6__SSKG3_()
        {
            InitializeComponent();
            InitializeSSKG3Components();
        }

        private void InitializeSSKG3Components()
        {
            // Form settings
            this.Text = "Unit 6 - My Address (SSKG3)";
            this.Size = new Size(800, 650);
            this.BackColor = Color.LightGreen;
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
                Text = "Unit 6: My Address - Where I Live (SSKG3)",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                Location = new Point(20, 45),
                Size = new Size(750, 25),
                TextAlign = ContentAlignment.TopCenter
            };

            // Address Component ComboBox
            addressComponentComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 85),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add address components
            addressComponentComboBox.Items.AddRange(new string[]
            {
                "Street Address",
                "City",
                "State", 
                "Country",
                "Complete Address",
                "Address Practice"
            });

            addressComponentComboBox.SelectedIndexChanged += AddressComponentComboBox_SelectedIndexChanged;

            // Picture Box for address visuals
            addressPictureBox = new PictureBox
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
                Text = "Select an address component to learn about where you live!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Example Panel
            examplePanel = new Panel
            {
                Location = new Point(20, 280),
                Size = new Size(620, 120),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightBlue
            };

            // Example Label
            exampleLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(600, 100),
                Font = new Font("Arial", 10),
                BackColor = Color.LightBlue,
                Text = "Address examples and practice will appear here!",
                TextAlign = ContentAlignment.TopLeft
            };

            examplePanel.Controls.Add(exampleLabel);

            // Practice Label
            practiceLabel = new Label
            {
                Text = "Practice writing your address:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(20, 420),
                Size = new Size(300, 25),
                ForeColor = Color.DarkBlue
            };

            // Student Address TextBox
            studentAddressTextBox = new TextBox
            {
                Location = new Point(20, 450),
                Size = new Size(620, 25),
                Font = new Font("Arial", 11),
                BackColor = Color.LightCyan,
                Text = "Type your address here..."
            };

            // Navigation Buttons
            goToUnit1Button = new Button
            {
                Text = "Unit 1 (SSKH1)",
                Location = new Point(20, 500),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit1Button.Click += (s, e) => { new Form1().Show(); this.Hide(); };

            goToUnit2Button = new Button
            {
                Text = "Unit 2 (SSKH2)",
                Location = new Point(130, 500),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };

            goToUnit3Button = new Button
            {
                Text = "Unit 3 (SSKH3)",
                Location = new Point(240, 500),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };

            goToUnit4Button = new Button
            {
                Text = "Unit 4 (SSKG1)",
                Location = new Point(350, 500),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit4Button.Click += (s, e) => { new Unit_4__SSKG1_().Show(); this.Hide(); };

            goToUnit5Button = new Button
            {
                Text = "Unit 5 (SSKG2)",
                Location = new Point(460, 500),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit5Button.Click += (s, e) => { new Unit_5__SSKG2_cs().Show(); this.Hide(); };

            // Add Unit 7 button
            goToUnit7Button = new Button
            {
                Text = "Unit 7 (SSKCG1)",
                Location = new Point(20, 540),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit7Button.Click += (s, e) => { new Unit_7__SSKCG1_().Show();};

            // Previous Button
            previousButton = new Button
            {
                Text = "← Previous",
                Location = new Point(680, 500),
                Size = new Size(80, 30),
                BackColor = Color.Orange
            };
            previousButton.Click += PreviousButton_Click;

            // Next Button
            nextButton = new Button
            {
                Text = "Next →",
                Location = new Point(770, 500),
                Size = new Size(80, 30),
                BackColor = Color.Orange
            };
            nextButton.Click += NextButton_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© 2026-2027 TTS-COMPONENTS Education Edition - Georgia Standards SSKG3",
                Font = new Font("Arial", 8),
                Location = new Point(20, 580), // Move down to make room for Unit 7 button
                Size = new Size(750, 20),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.Gray
            };

            // Add all controls to form
            this.Controls.AddRange(new Control[]
            {
                titleLabel, unitLabel, addressComponentComboBox, addressPictureBox,
                descriptionLabel, examplePanel, practiceLabel, studentAddressTextBox,
                goToUnit1Button, goToUnit2Button, goToUnit3Button, goToUnit4Button,
                goToUnit5Button, goToUnit7Button, previousButton, nextButton, copyrightLabel
            });

            // Set default selection
            addressComponentComboBox.SelectedIndex = 0;
        }

        private void AddressComponentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddressDisplay();
        }

        private void UpdateAddressDisplay()
        {
            string selectedComponent = addressComponentComboBox.SelectedItem?.ToString();

            switch (selectedComponent)
            {
                case "Street Address":
                    descriptionLabel.Text = "A street address tells us the exact location of your home. It includes the house number and street name where you live.";
                    exampleLabel.Text = "🏠 STREET ADDRESS EXAMPLES:\n\n" +
                                      "• 123 Main Street\n" +
                                      "• 456 Oak Avenue\n" +
                                      "• 789 Maple Drive\n" +
                                      "• 321 Pine Road\n\n" +
                                      "The NUMBER tells which house, the NAME tells which street!";
                    break;

                case "City":
                    descriptionLabel.Text = "A city is the town or place where you live. Cities have neighborhoods, schools, stores, and many families living together.";
                    exampleLabel.Text = "🏙️ CITY EXAMPLES:\n\n" +
                                      "• Atlanta (Georgia's capital city)\n" +
                                      "• Savannah (historic coastal city)\n" +
                                      "• Columbus (large Georgia city)\n" +
                                      "• Augusta (home of Masters golf)\n" +
                                      "• Macon (central Georgia city)\n\n" +
                                      "Your city is where you go to school and play!";
                    break;

                case "State":
                    descriptionLabel.Text = "A state is a large area with many cities inside it. We live in the state of Georgia, which is in the southeastern United States.";
                    exampleLabel.Text = "🍑 STATE OF GEORGIA:\n\n" +
                                      "• Georgia is our state\n" +
                                      "• Georgia has 159 counties\n" +
                                      "• Atlanta is Georgia's capital\n" +
                                      "• Georgia is known for peaches\n" +
                                      "• We are the 'Peach State'\n\n" +
                                      "Georgia is home to millions of people!";
                    break;

                case "Country":
                    descriptionLabel.Text = "A country is a very large area with many states inside it. We live in the United States of America, the best country in the world!";
                    exampleLabel.Text = "🇺🇸 UNITED STATES OF AMERICA:\n\n" +
                                      "• USA is our country\n" +
                                      "• 50 states make up America\n" +
                                      "• Washington D.C. is our capital\n" +
                                      "• We are Americans!\n" +
                                      "• Land of the free, home of the brave\n\n" +
                                      "We are proud to be Americans! 🦅";
                    break;

                case "Complete Address":
                    descriptionLabel.Text = "A complete address has ALL the parts: street address, city, state, and country. This tells exactly where you live in the whole world!";
                    exampleLabel.Text = "📮 COMPLETE ADDRESS EXAMPLE:\n\n" +
                                      "123 Main Street\n" +
                                      "Atlanta, Georgia 30309\n" +
                                      "United States of America\n\n" +
                                      "ORDER: Street → City → State → Country\n\n" +
                                      "This address could find you anywhere in the world!";
                    break;

                case "Address Practice":
                    descriptionLabel.Text = "Practice writing your own address! Ask your family to help you learn your street address, city, state, and country.";
                    exampleLabel.Text = "✏️ PRACTICE YOUR ADDRESS:\n\n" +
                                      "1. What is your street address?\n" +
                                      "2. What city do you live in?\n" +
                                      "3. What state do you live in? (Georgia!)\n" +
                                      "4. What country do you live in? (USA!)\n\n" +
                                      "Use the text box below to practice writing your address!";
                    break;

                default:
                    descriptionLabel.Text = "Select an address component to learn about where you live!";
                    exampleLabel.Text = "Address examples and practice will appear here!";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (addressComponentComboBox.SelectedIndex < addressComponentComboBox.Items.Count - 1)
            {
                addressComponentComboBox.SelectedIndex++;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (addressComponentComboBox.SelectedIndex > 0)
            {
                addressComponentComboBox.SelectedIndex--;
            }
        }
    }
}
