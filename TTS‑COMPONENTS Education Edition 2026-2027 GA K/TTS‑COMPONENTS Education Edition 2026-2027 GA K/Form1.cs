using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Education_Edition_2026_2027_GA_K
{
    public partial class Form1 : Form
    {
        private Panel holidayPanel;
        private Label titleLabel;
        private ComboBox holidayComboBox;
        private PictureBox holidayPictureBox;
        private Label descriptionLabel;
        private Button nextButton;
        private Button previousButton;
        private Label copyrightLabel; // Add copyright label
        private Label unitLabel;
        private Button goToUnit2Button; // Add this new button

        public Form1()
        {
            InitializeComponent();
            InitializeSSKH1Components();
        }

        private void InitializeSSKH1Components()
        {
            // Title
            titleLabel = new Label
            {
                Text = "SSKH1: National Holidays Learning Center",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                AutoSize = true,
                Location = new Point(20, 20)
            };

            // Holiday Selection
            Label selectLabel = new Label
            {
                Text = "Select a National Holiday:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 60)
            };

            holidayComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 85),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add the holidays from SSKH1
            holidayComboBox.Items.AddRange(new string[]
            {
                "Christmas",
                "Columbus Day", 
                "Independence Day",
                "Juneteenth National Independence Day",
                "Labor Day",
                "Martin Luther King, Jr. Day",
                "Memorial Day",
                "New Year's Day",
                "Presidents Day (Washington, Lincoln, Current President)",
                "Thanksgiving Day",
                "Veterans Day"
            });

            holidayComboBox.SelectedIndexChanged += HolidayComboBox_SelectedIndexChanged;

            // Picture Box for holiday images
            holidayPictureBox = new PictureBox
            {
                Location = new Point(20, 120),
                Size = new Size(200, 150),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.LightGray
            };

            // Description Label
            descriptionLabel = new Label
            {
                Location = new Point(240, 120),
                Size = new Size(400, 150),
                Font = new Font("Arial", 10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightYellow,
                Text = "Select a holiday to learn about the people and events we celebrate!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Navigation Buttons
            previousButton = new Button
            {
                Text = "← Previous Holiday",
                Location = new Point(20, 290),
                Size = new Size(120, 30),
                BackColor = Color.LightBlue
            };
            previousButton.Click += PreviousButton_Click;

            nextButton = new Button
            {
                Text = "Next Holiday →",
                Location = new Point(150, 290),
                Size = new Size(120, 30),
                BackColor = Color.LightGreen
            };
            nextButton.Click += NextButton_Click;

            // Go to Unit 2 Button
            goToUnit2Button = new Button
            {
                Text = "Go to Unit 2: American Symbols →",
                Location = new Point(290, 290),
                Size = new Size(200, 30),
                BackColor = Color.Orange,
                Font = new Font("Arial", 9, FontStyle.Bold)
            };
            goToUnit2Button.Click += GoToUnit2Button_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© TTS Consulting LLC. All rights reserved.",
                Font = new Font("Arial", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(20, 330)
            };

            // Unit label
            unitLabel = new Label
            {
                Text = "Unit 1: Holidays and Celebrations (SSKH1)",
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                AutoSize = true,
                Location = new Point(20, 360)
            };

            // Add all controls to the form
            this.Controls.AddRange(new Control[]
            {
                titleLabel,
                selectLabel,
                holidayComboBox,
                holidayPictureBox,
                descriptionLabel,
                previousButton,
                nextButton,
                goToUnit2Button, // Add the new button
                copyrightLabel,
                unitLabel
            });

            // Set initial selection
            holidayComboBox.SelectedIndex = 0;
        }

        // Add this new event handler method
        private void GoToUnit2Button_Click(object sender, EventArgs e)
        {
            // Create and show Unit 2 form
            Unit_2__SSKH2_ unit2Form = new Unit_2__SSKH2_();
            unit2Form.Show();
            
            // Optional: Hide current form
            // this.Hide();
        }

        private void HolidayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHolidayDisplay();
        }

        private void UpdateHolidayDisplay()
        {
            string selectedHoliday = holidayComboBox.SelectedItem?.ToString();
            
            switch (selectedHoliday)
            {
                case "Christmas":
                    descriptionLabel.Text = "Christmas celebrates the birth of Jesus Christ. People celebrate by giving gifts, decorating trees, and spending time with family.";
                    break;
                    
                case "Columbus Day":
                    descriptionLabel.Text = "Columbus Day honors Christopher Columbus, who sailed from Europe and reached America in 1492. This was when Europeans first learned about the New World.";
                    break;
                    
                case "Independence Day":
                    descriptionLabel.Text = "Independence Day (July 4th) celebrates when America became free from England in 1776. We celebrate with fireworks, parades, and barbecues.";
                    break;
                    
                case "Juneteenth National Independence Day":
                    descriptionLabel.Text = "Juneteenth celebrates when enslaved people in Texas learned they were free on June 19, 1865. It's a day to remember freedom and equality for all people.";
                    break;
                    
                case "Labor Day":
                    descriptionLabel.Text = "Labor Day honors all the workers who help make our country great. We celebrate the people who work hard in jobs like teachers, firefighters, and builders.";
                    break;
                    
                case "Martin Luther King, Jr. Day":
                    descriptionLabel.Text = "This day honors Dr. Martin Luther King, Jr., who worked for equal rights for all people. He had a dream that all people would be treated fairly.";
                    break;
                    
                case "Memorial Day":
                    descriptionLabel.Text = "Memorial Day remembers the brave soldiers who died fighting to keep our country safe. We honor their sacrifice and visit their graves with flowers.";
                    break;
                    
                case "New Year's Day":
                    descriptionLabel.Text = "New Year's Day (January 1st) celebrates the start of a new year. People make resolutions to be better and celebrate with parties and fireworks.";
                    break;
                    
                case "Presidents Day (Washington, Lincoln, Current President)":
                    descriptionLabel.Text = "Presidents Day honors George Washington (first president), Abraham Lincoln, and our current president. They were important leaders of our country.";
                    break;
                    
                case "Thanksgiving Day":
                    descriptionLabel.Text = "Thanksgiving celebrates when the Pilgrims and Native Americans shared a meal together. We give thanks for what we have and eat with family.";
                    break;
                    
                case "Veterans Day":
                    descriptionLabel.Text = "Veterans Day honors all the brave soldiers who served in the military to protect our country. We thank them for keeping us safe and free.";
                    break;
                    
                default:
                    descriptionLabel.Text = "This is an important national holiday that celebrates special people and events in American history.";
                    break;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (holidayComboBox.SelectedIndex > 0)
            {
                holidayComboBox.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (holidayComboBox.SelectedIndex < holidayComboBox.Items.Count - 1)
            {
                holidayComboBox.SelectedIndex++;
            }
        }
    }
}
