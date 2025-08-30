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
    public partial class Unit_3__SSKH3_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox timeConceptComboBox;
        private PictureBox timeConceptPictureBox;
        private Label descriptionLabel;
        private Button nextButton;
        private Button previousButton;
        private Label copyrightLabel;
        private Button goToUnit1Button;
        private Button goToUnit2Button;
        private Button goToUnit4Button; // Add this new button
        private Panel examplePanel;
        private Label exampleLabel;

        public Unit_3__SSKH3_()
        {
            InitializeComponent();
            InitializeSSKH3Components();
        }

        private void InitializeSSKH3Components()
        {
            // Title
            titleLabel = new Label
            {
                Text = "SSKH3: Chronology and Time Learning Center",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                AutoSize = true,
                Location = new Point(20, 20)
            };

            // Unit Label
            unitLabel = new Label
            {
                Text = "Unit 3: Time and Chronology (SSKH3)",
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                AutoSize = true,
                Location = new Point(20, 50)
            };

            // Time Concept Selection
            Label selectLabel = new Label
            {
                Text = "Select a Time Concept:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 80)
            };

            timeConceptComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 105),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add the time concepts from SSKH3
            timeConceptComboBox.Items.AddRange(new string[]
            {
                "Now, Long Ago",
                "Before, After",
                "Today, Tomorrow, Yesterday",
                "First, Last, Next",
                "Day, Week, Month, Year",
                "Past, Present, Future"
            });

            timeConceptComboBox.SelectedIndexChanged += TimeConceptComboBox_SelectedIndexChanged;

            // Picture Box for time concept illustrations
            timeConceptPictureBox = new PictureBox
            {
                Location = new Point(20, 140),
                Size = new Size(200, 120),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.LightGray
            };

            // Description Label
            descriptionLabel = new Label
            {
                Location = new Point(240, 140),
                Size = new Size(400, 120),
                Font = new Font("Arial", 10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightCyan,
                Text = "Select a time concept to learn about chronology and time!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Example Panel
            examplePanel = new Panel
            {
                Location = new Point(20, 270),
                Size = new Size(620, 50),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightYellow
            };

            exampleLabel = new Label
            {
                Text = "Examples will appear here when you select a time concept!",
                Font = new Font("Arial", 9),
                ForeColor = Color.DarkGreen,
                AutoSize = false,
                Size = new Size(610, 40),
                Location = new Point(5, 5),
                TextAlign = ContentAlignment.MiddleLeft
            };

            examplePanel.Controls.Add(exampleLabel);

            // Navigation Buttons
            previousButton = new Button
            {
                Text = "← Previous Concept",
                Location = new Point(20, 330),
                Size = new Size(120, 30),
                BackColor = Color.LightBlue
            };
            previousButton.Click += PreviousButton_Click;

            nextButton = new Button
            {
                Text = "Next Concept →",
                Location = new Point(150, 330),
                Size = new Size(120, 30),
                BackColor = Color.LightGreen
            };
            nextButton.Click += NextButton_Click;

            // Unit Navigation Buttons
            goToUnit1Button = new Button
            {
                Text = "← Unit 1: Holidays",
                Location = new Point(290, 330),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            goToUnit1Button.Click += GoToUnit1Button_Click;

            goToUnit2Button = new Button
            {
                Text = "← Unit 2: Symbols",
                Location = new Point(420, 330),
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            goToUnit2Button.Click += GoToUnit2Button_Click;

            // Go to Unit 4 Button
            goToUnit4Button = new Button
            {
                Text = "Unit 4: Culture →",
                Location = new Point(550, 330),
                Size = new Size(120, 30),
                BackColor = Color.Purple,
                ForeColor = Color.White,
                Font = new Font("Arial", 9, FontStyle.Bold)
            };
            goToUnit4Button.Click += GoToUnit4Button_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© 2025 Tadeo and Tony's Software (TTS Consulting) - Educational Edition",
                Font = new Font("Arial", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(20, 370)
            };

            // Add all controls to the form
            this.Controls.AddRange(new Control[]
            {
                titleLabel,
                unitLabel,
                selectLabel,
                timeConceptComboBox,
                timeConceptPictureBox,
                descriptionLabel,
                examplePanel,
                previousButton,
                nextButton,
                goToUnit1Button,
                goToUnit2Button,
                goToUnit4Button, // Add the new button
                copyrightLabel
            });

            // Set initial selection
            timeConceptComboBox.SelectedIndex = 0;
        }

        private void TimeConceptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTimeConceptDisplay();
        }

        private void UpdateTimeConceptDisplay()
        {
            string selectedConcept = timeConceptComboBox.SelectedItem?.ToString();

            switch (selectedConcept)
            {
                case "Now, Long Ago":
                    descriptionLabel.Text = "NOW means right at this moment. LONG AGO means something that happened many years before you were born, like when your grandparents were children.";
                    exampleLabel.Text = "Examples: NOW - We are learning in school today. LONG AGO - Native Americans lived here before there were cars or computers.";
                    break;

                case "Before, After":
                    descriptionLabel.Text = "BEFORE means something happens first, then something else comes next. AFTER means something happens following another event.";
                    exampleLabel.Text = "Examples: BEFORE lunch we wash our hands. AFTER lunch we play outside. BEFORE bedtime we brush our teeth.";
                    break;

                case "Today, Tomorrow, Yesterday":
                    descriptionLabel.Text = "TODAY is right now, this day. YESTERDAY was the day that came before today. TOMORROW is the day that will come after today.";
                    exampleLabel.Text = "Examples: TODAY we are at school. YESTERDAY was Sunday. TOMORROW we will have art class.";
                    break;

                case "First, Last, Next":
                    descriptionLabel.Text = "FIRST means the very beginning, what happens at the start. LAST means the very end. NEXT means what comes right after something.";
                    exampleLabel.Text = "Examples: FIRST we line up. NEXT we walk to lunch. LAST we clean up our table.";
                    break;

                case "Day, Week, Month, Year":
                    descriptionLabel.Text = "A DAY is from morning to night. A WEEK is 7 days. A MONTH is about 4 weeks. A YEAR is 12 months and includes your birthday!";
                    exampleLabel.Text = "Examples: We go to school each DAY. We have weekends every WEEK. We celebrate holidays each MONTH. We grow bigger every YEAR.";
                    break;

                case "Past, Present, Future":
                    descriptionLabel.Text = "PAST is everything that already happened before now. PRESENT is what is happening right now. FUTURE is what will happen later.";
                    exampleLabel.Text = "Examples: PAST - When you were a baby. PRESENT - Learning about time right now. FUTURE - When you become a grown-up.";
                    break;

                default:
                    descriptionLabel.Text = "This time concept helps us understand when things happen and put events in order.";
                    exampleLabel.Text = "Select a time concept to see examples!";
                    break;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (timeConceptComboBox.SelectedIndex > 0)
            {
                timeConceptComboBox.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (timeConceptComboBox.SelectedIndex < timeConceptComboBox.Items.Count - 1)
            {
                timeConceptComboBox.SelectedIndex++;
            }
        }

        private void GoToUnit1Button_Click(object sender, EventArgs e)
        {
            Form1 unit1Form = new Form1();
            unit1Form.Show();
        }

        private void GoToUnit2Button_Click(object sender, EventArgs e)
        {
            Unit_2__SSKH2_ unit2Form = new Unit_2__SSKH2_();
            unit2Form.Show();
        }

        // Add this new event handler method
        private void GoToUnit4Button_Click(object sender, EventArgs e)
        {
            // Create and show Unit 4 form
            Unit_4__SSKG1_ unit4Form = new Unit_4__SSKG1_();
            unit4Form.Show();
            
            // Optional: Hide current form
            // this.Hide();
        }
    }
}
