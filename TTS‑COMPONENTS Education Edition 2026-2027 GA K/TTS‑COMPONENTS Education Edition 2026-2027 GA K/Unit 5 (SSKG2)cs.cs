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
    public partial class Unit_5__SSKG2_cs : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox topicComboBox;
        private PictureBox mapGlobePictureBox;
        private Label descriptionLabel;
        private Panel featuresPanel;
        private Label featuresLabel;
        private Button nextButton;
        private Button previousButton;
        private Label copyrightLabel;
        private Button goToUnit1Button;
        private Button goToUnit2Button;
        private Button goToUnit3Button;
        private Button goToUnit4Button;
        private Button goToUnit6Button; // Add this new button variable

        public Unit_5__SSKG2_cs()
        {
            InitializeComponent();
            InitializeSSKG2Components();
        }

        private void InitializeSSKG2Components()
        {
            // Form settings
            this.Text = "Unit 5 - Maps and Globes (SSKG2)";
            this.Size = new Size(800, 600);
            this.BackColor = Color.LightBlue;
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
                Text = "Unit 5: Maps and Globes - Understanding Our World (SSKG2)",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.Green,
                Location = new Point(20, 45),
                Size = new Size(750, 25),
                TextAlign = ContentAlignment.TopCenter
            };

            // Topic ComboBox
            topicComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 85),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add map and globe topics
            topicComboBox.Items.AddRange(new string[]
            {
                "What is a Map?",
                "What is a Globe?", 
                "Land Features",
                "Water Features",
                "View from Above",
                "Smaller Size Features",
                "Reading Simple Maps",
                "Comparing Maps and Globes"
            });

            topicComboBox.SelectedIndexChanged += TopicComboBox_SelectedIndexChanged;

            // Picture Box for maps and globes
            mapGlobePictureBox = new PictureBox
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
                Text = "Select a topic to learn about maps, globes, and how they help us understand our world!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Features Panel
            featuresPanel = new Panel
            {
                Location = new Point(20, 280),
                Size = new Size(620, 150),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGreen
            };

            // Features Label
            featuresLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(600, 130),
                Font = new Font("Arial", 10),
                BackColor = Color.LightGreen,
                Text = "Geographic features and map reading skills will be shown here when you select a topic!",
                TextAlign = ContentAlignment.TopLeft
            };

            featuresPanel.Controls.Add(featuresLabel);

            // Navigation Buttons
            goToUnit1Button = new Button
            {
                Text = "Unit 1 (SSKH1)",
                Location = new Point(20, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit1Button.Click += (s, e) => { new Form1().Show(); this.Hide(); };

            goToUnit2Button = new Button
            {
                Text = "Unit 2 (SSKH2)",
                Location = new Point(130, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };

            goToUnit3Button = new Button
            {
                Text = "Unit 3 (SSKH3)",
                Location = new Point(240, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };

            goToUnit4Button = new Button
            {
                Text = "Unit 4 (SSKG1)",
                Location = new Point(350, 450),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit4Button.Click += (s, e) => { new Unit_4__SSKG1_().Show(); this.Hide(); };

            // Add Unit 6 button
            goToUnit6Button = new Button
            {
                Text = "Unit 6 (SSKG3)",
                Location = new Point(20, 490),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit6Button.Click += (s, e) => { new Unit_6__SSKG3_().Show();};

            // Previous Button
            previousButton = new Button
            {
                Text = "← Previous Topic",
                Location = new Point(580, 450),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            previousButton.Click += PreviousButton_Click;

            // Next Button
            nextButton = new Button
            {
                Text = "Next Topic →",
                Location = new Point(710, 450),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            nextButton.Click += NextButton_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© 2026-2027 TTS-COMPONENTS Education Edition - Georgia Standards SSKG2",
                Font = new Font("Arial", 8),
                Location = new Point(20, 530), // Move down to make room for Unit 6 button
                Size = new Size(750, 20),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.Gray
            };

            // Add all controls to form
            this.Controls.AddRange(new Control[]
            {
                titleLabel, unitLabel, topicComboBox, mapGlobePictureBox,
                descriptionLabel, featuresPanel, goToUnit1Button, goToUnit2Button,
                goToUnit3Button, goToUnit4Button, goToUnit6Button, previousButton, nextButton, copyrightLabel
            });

            // Set default selection
            topicComboBox.SelectedIndex = 0;
        }

        private void TopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTopicDisplay();
        }

        private void UpdateTopicDisplay()
        {
            string selectedTopic = topicComboBox.SelectedItem?.ToString();

            switch (selectedTopic)
            {
                case "What is a Map?":
                    descriptionLabel.Text = "A map is a drawing of a place! Maps show us where things are located. They help us find our way and understand different places in our world.";
                    featuresLabel.Text = "🗺️ Maps are flat drawings\n📍 They show locations of places\n🏠 Can show your neighborhood, city, or country\n📏 Maps use symbols and colors to represent real things\n🧭 Help us navigate and find directions";
                    break;

                case "What is a Globe?":
                    descriptionLabel.Text = "A globe is a model of Earth! It is round like our planet and shows all the continents and oceans. Globes help us see the whole world at once.";
                    featuresLabel.Text = "🌍 Globes are round like Earth\n🌎 Show the whole planet\n🌊 Display all continents and oceans\n🔄 Can be rotated to see different parts\n📐 Show Earth's true shape and size relationships";
                    break;

                case "Land Features":
                    descriptionLabel.Text = "Land features are different types of ground we can see on maps and globes. These include mountains, hills, forests, and flat areas called plains.";
                    featuresLabel.Text = "🏔️ Mountains - Very tall land (shown in brown)\n🏞️ Hills - Medium height land (shown in green/brown)\n🌲 Forests - Areas with many trees (shown in dark green)\n🌾 Plains - Flat areas for farming (shown in light green)\n🏜️ Deserts - Dry, sandy areas (shown in tan/yellow)";
                    break;

                case "Water Features":
                    descriptionLabel.Text = "Water features are bodies of water we can see on maps and globes. These include oceans, lakes, rivers, and streams that provide water for people and animals.";
                    featuresLabel.Text = "🌊 Oceans - Very large bodies of water (shown in dark blue)\n🏞️ Lakes - Smaller bodies of water surrounded by land (shown in blue)\n🏞️ Rivers - Long, flowing water that connects places (shown as blue lines)\n🏞️ Streams - Small flowing water (shown as thin blue lines)\n💧 All water features are shown in blue on maps";
                    break;

                case "View from Above":
                    descriptionLabel.Text = "Maps and globes show us what places look like from above, as if we were flying in an airplane looking down at the ground below.";
                    featuresLabel.Text = "✈️ Imagine looking down from an airplane\n🏠 Houses look like small squares from above\n🛣️ Roads look like lines connecting places\n🌳 Trees look like small green circles\n👁️ This 'bird's eye view' helps us see how places connect";
                    break;

                case "Smaller Size Features":
                    descriptionLabel.Text = "Maps and globes show big places in a smaller size so we can see them all at once. A whole country can fit on a piece of paper!";
                    featuresLabel.Text = "📏 Real places are made smaller to fit on maps\n🏫 A big school becomes a small symbol\n🌍 The whole Earth fits on a globe you can hold\n🔍 We use a 'scale' to know real sizes\n📐 This helps us study places that are far away";
                    break;

                case "Reading Simple Maps":
                    descriptionLabel.Text = "Learning to read maps helps us find places and understand where things are located. Maps use symbols, colors, and labels to show information.";
                    featuresLabel.Text = "🔤 Look for labels that name places\n🎨 Colors show different features (blue=water, green=land)\n📍 Symbols represent real things (star=capital city)\n🧭 Compass rose shows directions (North, South, East, West)\n🗝️ Map key explains what symbols mean";
                    break;

                case "Comparing Maps and Globes":
                    descriptionLabel.Text = "Maps and globes both show us places, but they are different! Maps are flat and globes are round. Both help us learn about our world in special ways.";
                    featuresLabel.Text = "🗺️ MAPS: Flat, easy to carry, show small areas well\n🌍 GLOBES: Round like Earth, show whole world, accurate shapes\n📱 Both show same places in different ways\n📚 Maps good for detailed areas, globes good for whole Earth\n🤝 Use both together to understand geography better";
                    break;

                default:
                    descriptionLabel.Text = "Select a topic to learn about maps, globes, and how they help us understand our world!";
                    featuresLabel.Text = "Geographic features and map reading skills will be shown here when you select a topic!";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (topicComboBox.SelectedIndex < topicComboBox.Items.Count - 1)
            {
                topicComboBox.SelectedIndex++;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (topicComboBox.SelectedIndex > 0)
            {
                topicComboBox.SelectedIndex--;
            }
        }
    }
}
