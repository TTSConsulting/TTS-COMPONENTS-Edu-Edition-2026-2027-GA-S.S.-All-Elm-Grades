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
    public partial class Unit_3_Ch_3__SS2CG3_ : Form
    {
        private string currentTrait = "";
        private string currentFigure = "";

        public Unit_3_Ch_3__SS2CG3_()
        {
            InitializeComponent();
        }

        // Historical Figure Button Events
        private void PocahontasButton_Click(object sender, EventArgs e)
        {
            currentFigure = "Pocahontas";
            DisplayFigureInfo("Pocahontas", "Native American who showed compassion and helped create peace between her people and English settlers. She demonstrated honesty and trustworthiness in her relationships.");
            EnableTraitButtons();
        }

        private void SequoyahButton_Click(object sender, EventArgs e)
        {
            currentFigure = "Sequoyah";
            DisplayFigureInfo("Sequoyah", "Cherokee leader who showed patience and dependability while creating the Cherokee written language. His work took many years of dedicated effort.");
            EnableTraitButtons();
        }

        private void JackieRobinsonButton_Click(object sender, EventArgs e)
        {
            currentFigure = "Jackie Robinson";
            DisplayFigureInfo("Jackie Robinson", "Baseball player who broke the color barrier with honor and good sportsmanship. He faced challenges with patience and civility.");
            EnableTraitButtons();
        }

        private void MartinLutherKingButton_Click(object sender, EventArgs e)
        {
            currentFigure = "Martin Luther King Jr.";
            DisplayFigureInfo("Martin Luther King Jr.", "Civil rights leader who demonstrated compassion and civility in his fight for equality. He showed patience and honor in peaceful protests.");
            EnableTraitButtons();
        }

        // Citizenship Trait Button Events
        private void HonestyButton_Click(object sender, EventArgs e)
        {
            currentTrait = "Honesty";
            ShowTraitExample(currentFigure, "Honesty", GetHonestyExample(currentFigure));
        }

        private void DependabilityButton_Click(object sender, EventArgs e)
        {
            currentTrait = "Dependability";
            ShowTraitExample(currentFigure, "Dependability", GetDependabilityExample(currentFigure));
        }

        private void TrustworthinessButton_Click(object sender, EventArgs e)
        {
            currentTrait = "Trustworthiness";
            ShowTraitExample(currentFigure, "Trustworthiness", GetTrustworthinessExample(currentFigure));
        }

        private void HonorButton_Click(object sender, EventArgs e)
        {
            currentTrait = "Honor";
            ShowTraitExample(currentFigure, "Honor", GetHonorExample(currentFigure));
        }

        private void CivilityButton_Click(object sender, EventArgs e)
        {
            currentTrait = "Civility";
            ShowTraitExample(currentFigure, "Civility", GetCivilityExample(currentFigure));
        }

        private void SportsmanshipButton_Click(object sender, EventArgs e)
        {
            currentTrait = "Good Sportsmanship";
            ShowTraitExample(currentFigure, "Good Sportsmanship", GetSportsmanshipExample(currentFigure));
        }

        private void PatienceButton_Click(object sender, EventArgs e)
        {
            currentTrait = "Patience";
            ShowTraitExample(currentFigure, "Patience", GetPatienceExample(currentFigure));
        }

        private void CompassionButton_Click(object sender, EventArgs e)
        {
            currentTrait = "Compassion";
            ShowTraitExample(currentFigure, "Compassion", GetCompassionExample(currentFigure));
        }

        // Helper Methods
        private void DisplayFigureInfo(string figureName, string description)
        {
            this.FigureInfoLabel.Text = $"{figureName}: {description}";
            this.InstructionLabel.Text = $"Now click on a citizenship trait to see how {figureName} demonstrated it!";
        }

        private void EnableTraitButtons()
        {
            this.HonestyButton.Enabled = true;
            this.DependabilityButton.Enabled = true;
            this.TrustworthinessButton.Enabled = true;
            this.HonorButton.Enabled = true;
            this.CivilityButton.Enabled = true;
            this.SportsmanshipButton.Enabled = true;
            this.PatienceButton.Enabled = true;
            this.CompassionButton.Enabled = true;
        }

        private void ShowTraitExample(string figure, string trait, string example)
        {
            this.TraitExampleLabel.Text = $"{trait} Example: {example}";
            this.TraitExampleLabel.Visible = true;
        }

        // Trait Examples for Each Historical Figure
        private string GetHonestyExample(string figure)
        {
            return figure switch
            {
                "Pocahontas" => "Pocahontas was honest about her feelings and beliefs, even when it was difficult.",
                "Sequoyah" => "Sequoyah was honest about the challenges of creating a written language for his people.",
                "Jackie Robinson" => "Jackie Robinson was honest about the discrimination he faced and spoke truthfully about equality.",
                "Martin Luther King Jr." => "Dr. King was honest about injustice and spoke the truth about civil rights.",
                _ => "This person showed honesty in their actions and words."
            };
        }

        private string GetDependabilityExample(string figure)
        {
            return figure switch
            {
                "Pocahontas" => "People could depend on Pocahontas to help create understanding between different groups.",
                "Sequoyah" => "Sequoyah could be depended upon to work hard on his writing system for many years.",
                "Jackie Robinson" => "His team could depend on Jackie Robinson to play his best and represent baseball well.",
                "Martin Luther King Jr." => "People could depend on Dr. King to lead peaceful protests and fight for what was right.",
                _ => "This person could be counted on to do what they said they would do."
            };
        }

        private string GetTrustworthinessExample(string figure)
        {
            return figure switch
            {
                "Pocahontas" => "Both her people and the English settlers learned they could trust Pocahontas.",
                "Sequoyah" => "His people trusted Sequoyah to create something that would help preserve their culture.",
                "Jackie Robinson" => "Baseball fans learned to trust that Jackie Robinson would play fairly and with skill.",
                "Martin Luther King Jr." => "People trusted Dr. King to lead them in the right direction for civil rights.",
                _ => "This person earned the trust of others through their actions."
            };
        }

        private string GetHonorExample(string figure)
        {
            return figure switch
            {
                "Pocahontas" => "Pocahontas brought honor to her people through her brave actions for peace.",
                "Sequoyah" => "Sequoyah brought honor to the Cherokee people by preserving their language in writing.",
                "Jackie Robinson" => "Jackie Robinson brought honor to baseball and his race by playing with dignity.",
                "Martin Luther King Jr." => "Dr. King brought honor to the civil rights movement through peaceful methods.",
                _ => "This person acted in ways that brought respect and honor."
            };
        }

        private string GetCivilityExample(string figure)
        {
            return figure switch
            {
                "Pocahontas" => "Pocahontas was polite and respectful to both her people and the English settlers.",
                "Sequoyah" => "Sequoyah was respectful when teaching others about his new writing system.",
                "Jackie Robinson" => "Jackie Robinson remained polite and respectful even when others were not kind to him.",
                "Martin Luther King Jr." => "Dr. King was always polite and respectful, even to those who disagreed with him.",
                _ => "This person treated others with politeness and respect."
            };
        }

        private string GetSportsmanshipExample(string figure)
        {
            return figure switch
            {
                "Pocahontas" => "Pocahontas showed fairness by trying to help both sides understand each other.",
                "Sequoyah" => "Sequoyah was fair in sharing his writing system with all Cherokee people.",
                "Jackie Robinson" => "Jackie Robinson showed perfect sportsmanship by playing fairly and accepting both wins and losses gracefully.",
                "Martin Luther King Jr." => "Dr. King showed good sportsmanship by fighting fairly for civil rights without violence.",
                _ => "This person played fairly and treated others well in competition."
            };
        }

        private string GetPatienceExample(string figure)
        {
            return figure switch
            {
                "Pocahontas" => "Pocahontas was patient when helping different groups learn to understand each other.",
                "Sequoyah" => "Sequoyah showed great patience working for 12 years to create the Cherokee writing system.",
                "Jackie Robinson" => "Jackie Robinson was patient when facing unfair treatment and worked to change minds slowly.",
                "Martin Luther King Jr." => "Dr. King was patient in working for civil rights, knowing that change takes time.",
                _ => "This person waited calmly and worked steadily toward their goals."
            };
        }

        private string GetCompassionExample(string figure)
        {
            return figure switch
            {
                "Pocahontas" => "Pocahontas showed compassion by caring about both her people and the English settlers.",
                "Sequoyah" => "Sequoyah showed compassion by wanting to help his people preserve their stories and culture.",
                "Jackie Robinson" => "Jackie Robinson showed compassion by understanding that his success would help other African Americans.",
                "Martin Luther King Jr." => "Dr. King showed compassion by caring about all people and wanting equality for everyone.",
                _ => "This person cared deeply about others and wanted to help them."
            };
        }

        // Navigation
        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void NextChapterButton_Click(object sender, EventArgs e)
        {
            // This completes Unit 3 - could navigate to Unit 4 or back to main menu
            MessageBox.Show("Congratulations! You have completed Unit 3: Government and Citizenship!\n\nYou learned about:\n• Government, rules, and laws (SS2CG1)\n• Elected officials and their workplaces (SS2CG2)\n• Citizenship traits of historical figures (SS2CG3)", 
                           "Unit 3 Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void Unit4Ch1Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unit_4_Ch_1__SS2E1_ unit4Ch1 = new Unit_4_Ch_1__SS2E1_();
            unit4Ch1.Show();
        }
    }
}
