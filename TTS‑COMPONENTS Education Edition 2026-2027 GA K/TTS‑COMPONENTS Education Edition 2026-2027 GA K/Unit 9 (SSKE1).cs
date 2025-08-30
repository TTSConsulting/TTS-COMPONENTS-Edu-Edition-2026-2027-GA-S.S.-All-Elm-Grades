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
    public partial class Unit_9__SSKE1_ : Form
    {
        private Label titleLabel;
        private Label unitLabel;
        private ComboBox jobComboBox;
        private PictureBox jobPictureBox;
        private Label descriptionLabel;
        private Panel workPanel;
        private Label workLabel;
        private Button nextButton;
        private Button previousButton;
        private Label copyrightLabel;
        private Button goToUnit1Button;
        private Button goToUnit2Button;
        private Button goToUnit3Button;
        private Button goToUnit4Button;
        private Button goToUnit5Button;
        private Button goToUnit6Button;
        private Button goToUnit7Button;
        private Button goToUnit8Button;
        private Button goToUnit10Button; // Add Unit 10 button

        public Unit_9__SSKE1_()
        {
            InitializeComponent();
            InitializeSSKE1Components();
        }

        private void InitializeSSKE1Components()
        {
            // Form settings
            this.Text = "Unit 9 - Jobs and Work (SSKE1)";
            this.Size = new Size(800, 680); // Increase height for Unit 10 button
            this.BackColor = Color.LightSeaGreen;
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
                Text = "Unit 9: Jobs and Work - What People Do (SSKE1)",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                Location = new Point(20, 45),
                Size = new Size(750, 25),
                TextAlign = ContentAlignment.TopCenter
            };

            // Job ComboBox
            jobComboBox = new ComboBox
            {
                Font = new Font("Arial", 11),
                Location = new Point(20, 85),
                Size = new Size(300, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Add jobs from the Georgia Standards
            jobComboBox.Items.AddRange(new string[]
            {
                "Police Officer",
                "Fire Fighter",
                "Soldier",
                "Mail Carrier",
                "Farmer",
                "Doctor",
                "Teacher",
                "Nurse",
                "Construction Worker",
                "Chef/Cook",
                "Bus Driver",
                "Veterinarian",
                "All Jobs Are Important"
            });

            jobComboBox.SelectedIndexChanged += JobComboBox_SelectedIndexChanged;

            // Picture Box for job visuals
            jobPictureBox = new PictureBox
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
                Text = "Select a job to learn about the important work people do!",
                TextAlign = ContentAlignment.TopLeft
            };

            // Work Panel
            workPanel = new Panel
            {
                Location = new Point(20, 280),
                Size = new Size(620, 150),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightSalmon
            };

            // Work Label
            workLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(600, 130),
                Font = new Font("Arial", 10),
                BackColor = Color.LightSalmon,
                Text = "Information about jobs and the work people do will be shown here!",
                TextAlign = ContentAlignment.TopLeft
            };

            workPanel.Controls.Add(workLabel);

            // Navigation Buttons
            goToUnit1Button = new Button
            {
                Text = "Unit 1 (SSKH1)",
                Location = new Point(20, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit1Button.Click += (s, e) => { new Form1().Show(); this.Hide(); };

            goToUnit2Button = new Button
            {
                Text = "Unit 2 (SSKH2)",
                Location = new Point(120, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };

            goToUnit3Button = new Button
            {
                Text = "Unit 3 (SSKH3)",
                Location = new Point(220, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };

            goToUnit4Button = new Button
            {
                Text = "Unit 4 (SSKG1)",
                Location = new Point(320, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit4Button.Click += (s, e) => { new Unit_4__SSKG1_().Show(); this.Hide(); };

            goToUnit5Button = new Button
            {
                Text = "Unit 5 (SSKG2)",
                Location = new Point(420, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit5Button.Click += (s, e) => { new Unit_5__SSKG2_cs().Show(); this.Hide(); };

            goToUnit6Button = new Button
            {
                Text = "Unit 6 (SSKG3)",
                Location = new Point(520, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit6Button.Click += (s, e) => { new Unit_6__SSKG3_().Show(); this.Hide(); };

            goToUnit7Button = new Button
            {
                Text = "Unit 7 (SSKCG1)",
                Location = new Point(620, 450),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit7Button.Click += (s, e) => { new Unit_7__SSKCG1_().Show(); this.Hide(); };

            goToUnit8Button = new Button
            {
                Text = "Unit 8 (SSKCG2)",
                Location = new Point(20, 490),
                Size = new Size(90, 30),
                BackColor = Color.LightCoral
            };
            goToUnit8Button.Click += (s, e) => { new Unit_8__SSKCG2_().Show(); this.Hide(); };

            // Add Unit 10 button
            goToUnit10Button = new Button
            {
                Text = "Unit 10 (SSKE2)",
                Location = new Point(120, 490),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            goToUnit10Button.Click += (s, e) => { new Unit_10__SSKE2_().Show();};

            // Previous Button
            previousButton = new Button
            {
                Text = "← Previous Job",
                Location = new Point(480, 530), // Move down to make room
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            previousButton.Click += PreviousButton_Click;

            // Next Button
            nextButton = new Button
            {
                Text = "Next Job →",
                Location = new Point(610, 530), // Move down to make room
                Size = new Size(120, 30),
                BackColor = Color.Orange
            };
            nextButton.Click += NextButton_Click;

            // Copyright Label
            copyrightLabel = new Label
            {
                Text = "© 2026-2027 TTS-COMPONENTS Education Edition - Georgia Standards SSKE1",
                Font = new Font("Arial", 8),
                Location = new Point(20, 600), // Move down to make room
                Size = new Size(750, 20),
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = Color.Gray
            };

            // Add all controls to form
            this.Controls.AddRange(new Control[]
            {
                titleLabel, unitLabel, jobComboBox, jobPictureBox,
                descriptionLabel, workPanel, goToUnit1Button, goToUnit2Button,
                goToUnit3Button, goToUnit4Button, goToUnit5Button, goToUnit6Button,
                goToUnit7Button, goToUnit8Button, goToUnit10Button, previousButton, 
                nextButton, copyrightLabel
            });

            // Set default selection
            jobComboBox.SelectedIndex = 0;
        }

        private void JobComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJobDisplay();
        }

        private void UpdateJobDisplay()
        {
            string selectedJob = jobComboBox.SelectedItem?.ToString();

            switch (selectedJob)
            {
                case "Police Officer":
                    descriptionLabel.Text = "Police officers protect people and keep our communities safe. They help people in trouble and make sure everyone follows the laws.";
                    workLabel.Text = "👮 POLICE OFFICER WORK:\n\n" +
                                   "• Protect people from danger\n" +
                                   "• Help people who are lost or hurt\n" +
                                   "• Make sure traffic laws are followed\n" +
                                   "• Catch people who break the law\n" +
                                   "• Visit schools to teach safety\n\n" +
                                   "Police officers are community heroes! 🚔";
                    break;

                case "Fire Fighter":
                    descriptionLabel.Text = "Fire fighters put out fires and rescue people in emergencies. They are brave heroes who risk their lives to save others and protect property.";
                    workLabel.Text = "🔥 FIRE FIGHTER WORK:\n\n" +
                                   "• Put out fires in buildings and forests\n" +
                                   "• Rescue people from burning buildings\n" +
                                   "• Help people in car accidents\n" +
                                   "• Teach fire safety to children\n" +
                                   "• Take care of fire trucks and equipment\n\n" +
                                   "Fire fighters are brave heroes! 🚒";
                    break;

                case "Soldier":
                    descriptionLabel.Text = "Soldiers serve in the military to protect our country. They are brave men and women who defend America and help keep us free and safe.";
                    workLabel.Text = "🇺🇸 SOLDIER WORK:\n\n" +
                                   "• Protect our country from enemies\n" +
                                   "• Help people in disasters\n" +
                                   "• Train to stay strong and ready\n" +
                                   "• Work as a team with other soldiers\n" +
                                   "• Serve America with honor\n\n" +
                                   "Soldiers defend our freedom! ⭐";
                    break;

                case "Mail Carrier":
                    descriptionLabel.Text = "Mail carriers deliver letters, packages, and important mail to homes and businesses. They make sure everyone gets their mail every day.";
                    workLabel.Text = "📮 MAIL CARRIER WORK:\n\n" +
                                   "• Deliver letters and packages\n" +
                                   "• Walk or drive to every house\n" +
                                   "• Sort mail at the post office\n" +
                                   "• Work in all kinds of weather\n" +
                                   "• Help people get important messages\n\n" +
                                   "Mail carriers connect people! 📬";
                    break;

                case "Farmer":
                    descriptionLabel.Text = "Farmers grow the food we eat every day. They take care of plants and animals to provide fruits, vegetables, meat, and dairy products for everyone.";
                    workLabel.Text = "🚜 FARMER WORK:\n\n" +
                                   "• Grow fruits and vegetables\n" +
                                   "• Take care of farm animals\n" +
                                   "• Plant seeds and harvest crops\n" +
                                   "• Use tractors and farm equipment\n" +
                                   "• Provide food for everyone\n\n" +
                                   "Farmers feed the world! 🌽";
                    break;

                case "Doctor":
                    descriptionLabel.Text = "Doctors help people when they are sick or hurt. They examine patients, give medicine, and work to keep everyone healthy and feeling good.";
                    workLabel.Text = "👩‍⚕️ DOCTOR WORK:\n\n" +
                                   "• Help sick and hurt people\n" +
                                   "• Give checkups to stay healthy\n" +
                                   "• Prescribe medicine\n" +
                                   "• Work in hospitals and clinics\n" +
                                   "• Study for many years to learn\n\n" +
                                   "Doctors help us stay healthy! 🏥";
                    break;

                case "Teacher":
                    descriptionLabel.Text = "Teachers help children learn new things every day. They teach reading, writing, math, and many other subjects to help students grow and succeed.";
                    workLabel.Text = "📚 TEACHER WORK:\n\n" +
                                   "• Teach reading, writing, and math\n" +
                                   "• Help children learn new things\n" +
                                   "• Create fun lessons and activities\n" +
                                   "• Care about every student\n" +
                                   "• Prepare students for the future\n\n" +
                                   "Teachers help us learn and grow! 🍎";
                    break;

                case "Nurse":
                    descriptionLabel.Text = "Nurses take care of people who are sick or hurt. They work with doctors to help patients feel better and get healthy again.";
                    workLabel.Text = "👩‍⚕️ NURSE WORK:\n\n" +
                                   "• Take care of sick people\n" +
                                   "• Give medicine to patients\n" +
                                   "• Help doctors with treatments\n" +
                                   "• Comfort people who don't feel well\n" +
                                   "• Work in hospitals and clinics\n\n" +
                                   "Nurses care for people! 💉";
                    break;

                case "Construction Worker":
                    descriptionLabel.Text = "Construction workers build houses, schools, roads, and bridges. They use tools and machines to create the buildings where we live, work, and learn.";
                    workLabel.Text = "🔨 CONSTRUCTION WORKER WORK:\n\n" +
                                   "• Build houses and buildings\n" +
                                   "• Use hammers, saws, and tools\n" +
                                   "• Make roads and bridges\n" +
                                   "• Work as a team to build things\n" +
                                   "• Create places for people to live\n\n" +
                                   "Construction workers build our world! 🏗️";
                    break;

                case "Chef/Cook":
                    descriptionLabel.Text = "Chefs and cooks prepare delicious food for people to eat. They work in restaurants, schools, and other places to make tasty and healthy meals.";
                    workLabel.Text = "👨‍🍳 CHEF/COOK WORK:\n\n" +
                                   "• Cook delicious meals\n" +
                                   "• Plan menus and recipes\n" +
                                   "• Keep kitchens clean and safe\n" +
                                   "• Work with other kitchen staff\n" +
                                   "• Make people happy with food\n\n" +
                                   "Chefs create delicious meals! 🍳";
                    break;

                case "Bus Driver":
                    descriptionLabel.Text = "Bus drivers safely transport people from place to place. School bus drivers take children to and from school safely every day.";
                    workLabel.Text = "🚌 BUS DRIVER WORK:\n\n" +
                                   "• Drive buses safely\n" +
                                   "• Take children to school\n" +
                                   "• Follow traffic rules carefully\n" +
                                   "• Keep passengers safe\n" +
                                   "• Check buses for safety\n\n" +
                                   "Bus drivers transport us safely! 🚍";
                    break;

                case "Veterinarian":
                    descriptionLabel.Text = "Veterinarians are doctors for animals. They help pets, farm animals, and wild animals when they are sick or hurt.";
                    workLabel.Text = "🐕 VETERINARIAN WORK:\n\n" +
                                   "• Take care of sick animals\n" +
                                   "• Give animals medicine\n" +
                                   "• Help pets stay healthy\n" +
                                   "• Work with all kinds of animals\n" +
                                   "• Love and care for animals\n\n" +
                                   "Veterinarians help our animal friends! 🐾";
                    break;

                case "All Jobs Are Important":
                    descriptionLabel.Text = "Every job is important! All workers help make our community and world a better place. Everyone's work matters and helps other people.";
                    workLabel.Text = "🌟 ALL JOBS ARE IMPORTANT:\n\n" +
                                   "• Every job helps people in some way\n" +
                                   "• Workers make our community better\n" +
                                   "• All work deserves respect\n" +
                                   "• People work to help others\n" +
                                   "• You can choose any job you want!\n\n" +
                                   "What job do YOU want to do someday? 💭";
                    break;

                default:
                    descriptionLabel.Text = "Select a job to learn about the important work people do!";
                    workLabel.Text = "Information about jobs and the work people do will be shown here!";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (jobComboBox.SelectedIndex < jobComboBox.Items.Count - 1)
            {
                jobComboBox.SelectedIndex++;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (jobComboBox.SelectedIndex > 0)
            {
                jobComboBox.SelectedIndex--;
            }
        }
    }
}
