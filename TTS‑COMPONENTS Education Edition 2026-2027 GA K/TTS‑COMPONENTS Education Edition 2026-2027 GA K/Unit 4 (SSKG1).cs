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
    public partial class Unit_4__SSKG1_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox cultureComboBox;
        private PictureBox culturePictureBox;
        private Label descriptionLabel;
        private Button nextButton;
        private Button previousButton;
        private Label copyrightLabel;
        private Panel customsPanel;
        private Label customsLabel;
        private Button goToUnit1Button;
        private Button goToUnit2Button;
        private Button goToUnit3Button;
        private Button goToUnit5Button; // Add this new button variable

        public Unit_4__SSKG1_()
        {
            InitializeComponent();
            InitializeSSKG1Components();
        }

        private void InitializeSSKG1Components()
        {
            // Title
            titleLabel = new Label
            {
                Text = "SSKG1: American Cultural Diversity Learning Center",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                AutoSize = true,
                Location = new Point(20, 20)
            };

            // Unit Label
            unitLabel = new Label
            {
                Text = "Unit 4: Cultural Diversity (SSKG1)",
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                AutoSize = true,
                Location = new Point(20, 50)
            };

            // Culture Selection
            Label selectLabel = new Label
            {
                Text = "Select a Cultural Family/Community:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 80)
            };

            cultureComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 105),
                Size = new Size(350, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add diverse cultural families and communities
            cultureComboBox.Items.AddRange(new string[]
            {
                "African American Families",
                "Hispanic/Latino Families", 
                "Asian American Families",
                "Native American Families",
                "European American Families",
                "Middle Eastern Families",
                "Jewish Families",
                "Italian American Families",
                "Irish American Families",
                "Military Families",
                "Immigrant Families",
                "Rural Community Families",
                "Urban Community Families"
            });

            cultureComboBox.SelectedIndexChanged += CultureComboBox_SelectedIndexChanged;

            // Picture Box for cultural images
            culturePictureBox = new PictureBox
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
                BackColor = Color.LightPink,
                Text = "Select a cultural family or community to learn about their customs and celebrations!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Customs Panel
            customsPanel = new Panel
            {
                Location = new Point(20, 270),
                Size = new Size(620, 50),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightYellow
            };

            customsLabel = new Label
            {
                Text = "Special customs and celebrations will appear here!",
                Font = new Font("Arial", 9),
                ForeColor = Color.DarkRed,
                AutoSize = false,
                Size = new Size(610, 40),
                Location = new Point(5, 5),
                TextAlign = ContentAlignment.MiddleLeft
            };

            customsPanel.Controls.Add(customsLabel);

            // Navigation Buttons
            previousButton = new Button
            {
                Text = "← Previous Culture",
                Location = new Point(20, 330),
                Size = new Size(120, 30),
                BackColor = Color.LightBlue
            };
            previousButton.Click += PreviousButton_Click;

            nextButton = new Button
            {
                Text = "Next Culture →",
                Location = new Point(150, 330),
                Size = new Size(120, 30),
                BackColor = Color.LightGreen
            };
            nextButton.Click += NextButton_Click;

            // Unit Navigation Buttons
            goToUnit1Button = new Button
            {
                Text = "Unit 1: Holidays",
                Location = new Point(290, 330),
                Size = new Size(100, 30),
                BackColor = Color.Orange
            };
            goToUnit1Button.Click += GoToUnit1Button_Click;

            goToUnit2Button = new Button
            {
                Text = "Unit 2: Symbols",
                Location = new Point(400, 330),
                Size = new Size(100, 30),
                BackColor = Color.Orange
            };
            goToUnit2Button.Click += GoToUnit2Button_Click;

            goToUnit3Button = new Button
            {
                Text = "Unit 3: Time",
                Location = new Point(510, 330),
                Size = new Size(100, 30),
                BackColor = Color.Orange
            };
            goToUnit3Button.Click += GoToUnit3Button_Click;

            // Add Unit 5 button
            goToUnit5Button = new Button
            {
                Text = "Unit 5: Maps",
                Location = new Point(620, 330),
                Size = new Size(100, 30),
                BackColor = Color.Orange
            };
            goToUnit5Button.Click += GoToUnit5Button_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© 2025 TTS Consulting - All Rights Reserved",
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
                cultureComboBox,
                culturePictureBox,
                descriptionLabel,
                customsPanel,
                previousButton,
                nextButton,
                goToUnit1Button,
                goToUnit2Button,
                goToUnit3Button,
                goToUnit5Button, // Add this to the controls array
                copyrightLabel
            });

            // Set initial selection
            cultureComboBox.SelectedIndex = 0;
        }

        private void CultureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCultureDisplay();
        }

        private void UpdateCultureDisplay()
        {
            string selectedCulture = cultureComboBox.SelectedItem?.ToString();

            switch (selectedCulture)
            {
                case "African American Families":
                    descriptionLabel.Text = "African American families have rich traditions that include storytelling, music, and strong community bonds. They celebrate their heritage and contributions to America.";
                    customsLabel.Text = "Customs: Kwanzaa celebration, soul food traditions, gospel music, family reunions, and honoring ancestors and civil rights leaders.";
                    break;

                case "Hispanic/Latino Families":
                    descriptionLabel.Text = "Hispanic and Latino families value close family relationships, respect for elders, and celebrating their cultural heritage from countries like Mexico, Puerto Rico, and others.\n🌟 (NOT RELATED TO STANDARDS) Dev Note: Main developer (Coolis1362) is Hispanic! 🇲🇽";
                    customsLabel.Text = "Customs: Día de los Muertos, quinceañera celebrations, piñatas, traditional foods like tamales, and speaking Spanish. ¡Viva la cultura hispana!";
                    break;

                case "Asian American Families":
                    descriptionLabel.Text = "Asian American families from countries like China, Japan, Korea, and India bring traditions of respect, education, and family honor to America.";
                    customsLabel.Text = "Customs: Chinese New Year, respect for elders, traditional foods like rice and noodles, martial arts, and honoring education.";
                    break;

                case "Native American Families":
                    descriptionLabel.Text = "Native American families are the first people of America. They have deep connections to the land and traditions passed down for thousands of years.";
                    customsLabel.Text = "Customs: Powwows, storytelling, respect for nature, traditional crafts, and honoring the Earth and animals.";
                    break;

                case "European American Families":
                    descriptionLabel.Text = "European American families came from countries like Germany, England, and France. They brought traditions of hard work and community building.";
                    customsLabel.Text = "Customs: Christmas traditions, Thanksgiving, family recipes, and celebrating heritage from different European countries.";
                    break;

                case "Middle Eastern Families":
                    descriptionLabel.Text = "Middle Eastern families come from countries like Lebanon, Syria, and Iran. They value hospitality, family respect, and sharing meals together.";
                    customsLabel.Text = "Customs: Sharing large family meals, respecting elders, traditional music and dance, and celebrating cultural holidays.";
                    break;

                case "Jewish Families":
                    descriptionLabel.Text = "Jewish families celebrate their faith and traditions that are thousands of years old. They value education, family, and helping others.";
                    customsLabel.Text = "Customs: Hanukkah, Passover, Shabbat dinners, bar/bat mitzvahs, and reading from the Torah.";
                    break;

                case "Italian American Families":
                    descriptionLabel.Text = "Italian American families brought traditions of cooking, family gatherings, and celebrating life together. They value family bonds and good food.";
                    customsLabel.Text = "Customs: Making pasta and pizza, large family dinners, celebrating feast days, and passing down recipes through generations.";
                    break;

                case "Irish American Families":
                    descriptionLabel.Text = "Irish American families brought traditions of storytelling, music, and celebrating their heritage. They value community and helping neighbors.";
                    customsLabel.Text = "Customs: St. Patrick's Day celebrations, Irish music and dancing, storytelling, and community gatherings.";
                    break;

                case "Military Families":
                    descriptionLabel.Text = "Military families serve our country and move frequently. They have strong values of service, honor, and supporting each other.";
                    customsLabel.Text = "Customs: Flag ceremonies, honoring veterans, moving to new bases, and supporting service members and their families.";
                    break;

                case "Immigrant Families":
                    descriptionLabel.Text = "Immigrant families come to America from many countries seeking better lives. They bring their cultures while learning American traditions.";
                    customsLabel.Text = "Customs: Learning English, celebrating both old and new country traditions, and sharing their cultural foods and customs.";
                    break;

                case "Rural Community Families":
                    descriptionLabel.Text = "Rural families live in the countryside and small towns. They value hard work, helping neighbors, and being close to nature.";
                    customsLabel.Text = "Customs: County fairs, farming traditions, community barn raisings, harvest celebrations, and knowing all your neighbors.";
                    break;

                case "Urban Community Families":
                    descriptionLabel.Text = "Urban families live in big cities with lots of people nearby. They value diversity, cultural events, and city community activities.";
                    customsLabel.Text = "Customs: City festivals, using public transportation, apartment living, visiting museums and parks, and diverse neighborhoods.";
                    break;

                default:
                    descriptionLabel.Text = "Every family and community in America has special customs and celebrations that make our country diverse and interesting.";
                    customsLabel.Text = "All families contribute unique traditions that make America a wonderful place with many different cultures.";
                    break;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (cultureComboBox.SelectedIndex > 0)
            {
                cultureComboBox.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (cultureComboBox.SelectedIndex < cultureComboBox.Items.Count - 1)
            {
                cultureComboBox.SelectedIndex++;
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

        private void GoToUnit3Button_Click(object sender, EventArgs e)
        {
            Unit_3__SSKH3_ unit3Form = new Unit_3__SSKH3_();
            unit3Form.Show();
        }

        // Add this new method
        private void GoToUnit5Button_Click(object sender, EventArgs e)
        {
            Unit_5__SSKG2_cs unit5Form = new Unit_5__SSKG2_cs();
            unit5Form.Show();
        }
    }
}
