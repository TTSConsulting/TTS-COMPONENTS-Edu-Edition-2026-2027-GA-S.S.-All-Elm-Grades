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
    public partial class Unit_2__SSKH2_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox symbolComboBox;
        private PictureBox symbolPictureBox;
        private Label descriptionLabel;
        private Button nextButton;
        private Button previousButton;
        private Label copyrightLabel;
        private Button goToUnit3Button; // Add this new button

        public Unit_2__SSKH2_()
        {
            InitializeComponent();
            InitializeSSKH2Components();
        }

        private void InitializeSSKH2Components()
        {
            // Title
            titleLabel = new Label
            {
                Text = "SSKH2: American Symbols Learning Center",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                AutoSize = true,
                Location = new Point(20, 20)
            };

            // Unit Label
            unitLabel = new Label
            {
                Text = "Unit 2: American Symbols (SSKH2)",
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                AutoSize = true,
                Location = new Point(20, 50)
            };

            // Symbol Selection
            Label selectLabel = new Label
            {
                Text = "Select an American Symbol:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 80)
            };

            symbolComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 105),
                Size = new Size(350, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add the symbols from SSKH2
            symbolComboBox.Items.AddRange(new string[]
            {
                "The National Flag (United States Flag)",
                "The State Flag (Georgia Flag)",
                "Pledge of Allegiance",
                "Star Spangled Banner (National Anthem)",
                "The Bald Eagle",
                "The Statue of Liberty",
                "Lincoln Memorial (Abraham Lincoln and Presidents Day)",
                "Washington Monument (George Washington and Presidents Day)",
                "White House (Presidents Day and Current President)"
            });

            symbolComboBox.SelectedIndexChanged += SymbolComboBox_SelectedIndexChanged;

            // Picture Box for symbol images
            symbolPictureBox = new PictureBox
            {
                Location = new Point(20, 140),
                Size = new Size(200, 150),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.LightGray
            };

            // Description Label
            descriptionLabel = new Label
            {
                Location = new Point(240, 140),
                Size = new Size(400, 150),
                Font = new Font("Arial", 10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightBlue,
                Text = "Select an American symbol to learn about what it represents!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Navigation Buttons
            previousButton = new Button
            {
                Text = "← Previous Symbol",
                Location = new Point(20, 310),
                Size = new Size(120, 30),
                BackColor = Color.LightBlue
            };
            previousButton.Click += PreviousButton_Click;

            nextButton = new Button
            {
                Text = "Next Symbol →",
                Location = new Point(150, 310),
                Size = new Size(120, 30),
                BackColor = Color.LightGreen
            };
            nextButton.Click += NextButton_Click;

            // Go to Unit 3 Button
            goToUnit3Button = new Button
            {
                Text = "Go to Unit 3: Time & Chronology →",
                Location = new Point(290, 310),
                Size = new Size(200, 30),
                BackColor = Color.Orange,
                Font = new Font("Arial", 9, FontStyle.Bold)
            };
            goToUnit3Button.Click += GoToUnit3Button_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© TTS Consulting - All Rights Reserved",
                Font = new Font("Arial", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(20, 350)
            };

            // Add all controls to the form
            this.Controls.AddRange(new Control[]
            {
                titleLabel,
                unitLabel,
                selectLabel,
                symbolComboBox,
                symbolPictureBox,
                descriptionLabel,
                previousButton,
                nextButton,
                goToUnit3Button, // Add the new button
                copyrightLabel
            });

            // Set initial selection
            symbolComboBox.SelectedIndex = 0;
        }

        private void SymbolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSymbolDisplay();
        }

        private void UpdateSymbolDisplay()
        {
            string selectedSymbol = symbolComboBox.SelectedItem?.ToString();

            switch (selectedSymbol)
            {
                case "The National Flag (United States Flag)":
                    descriptionLabel.Text = "The American flag has 50 stars for the 50 states and 13 stripes for the first 13 colonies. The red, white, and blue colors represent courage, purity, and justice.";
                    break;

                case "The State Flag (Georgia Flag)":
                    descriptionLabel.Text = "The Georgia state flag has the state seal and 13 stars representing Georgia as one of the original 13 colonies. It shows our state's history and pride.";
                    break;

                case "Pledge of Allegiance":
                    descriptionLabel.Text = "The Pledge of Allegiance is a promise we make to our country. We put our hand over our heart and promise to be loyal to America and what it stands for.";
                    break;

                case "Star Spangled Banner (National Anthem)":
                    descriptionLabel.Text = "The Star Spangled Banner is our national song. We sing it to show respect for our country, especially at sporting events and special ceremonies.";
                    break;

                case "The Bald Eagle":
                    descriptionLabel.Text = "The bald eagle is America's national bird. It represents strength, freedom, and courage. You can see the eagle on money, government seals, and important documents.";
                    break;

                case "The Statue of Liberty":
                    descriptionLabel.Text = "The Statue of Liberty stands in New York Harbor and welcomes people to America. She holds a torch for freedom and represents liberty and opportunity for all.";
                    break;

                case "Lincoln Memorial (Abraham Lincoln and Presidents Day)":
                    descriptionLabel.Text = "The Lincoln Memorial honors President Abraham Lincoln, who helped keep our country together and freed enslaved people. We remember him on Presidents Day.";
                    break;

                case "Washington Monument (George Washington and Presidents Day)":
                    descriptionLabel.Text = "The Washington Monument honors George Washington, our first president. The tall white tower in Washington D.C. reminds us of his leadership on Presidents Day.";
                    break;

                case "White House (Presidents Day and Current President)":
                    descriptionLabel.Text = "The White House is where the President lives and works. It represents the leadership of our country and is especially important on Presidents Day.";
                    break;

                default:
                    descriptionLabel.Text = "This is an important American symbol that represents our country's values and history.";
                    break;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (symbolComboBox.SelectedIndex > 0)
            {
                symbolComboBox.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (symbolComboBox.SelectedIndex < symbolComboBox.Items.Count - 1)
            {
                symbolComboBox.SelectedIndex++;
            }
        }

        // Add this new event handler method
        private void GoToUnit3Button_Click(object sender, EventArgs e)
        {
            // Create and show Unit 3 form
            Unit_3__SSKH3_ unit3Form = new Unit_3__SSKH3_();
            unit3Form.Show();
            
            // Optional: Hide current form
            // this.Hide();
        }
    }
}
