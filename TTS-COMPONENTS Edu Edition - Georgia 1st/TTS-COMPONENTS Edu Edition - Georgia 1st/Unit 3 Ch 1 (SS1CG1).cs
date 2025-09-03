using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    public partial class Unit_3_Ch_1__SS1CG1_ : Form
    {
        private List<CharacterTrait> characterTraits = new List<CharacterTrait>();
        private int currentTraitIndex = 0;

        public Unit_3_Ch_1__SS1CG1_()
        {
            InitializeComponent();
            InitializeCharacterTraits();
            DisplayTraitInfo(currentTraitIndex);
        }

        public class CharacterTrait
        {
            public string Name { get; set; }
            public string Definition { get; set; }
            public string HistoricalExample { get; set; }
            public string EverydayExample { get; set; }
            public string ActivityPrompt { get; set; }

            public CharacterTrait(string name, string definition, string historicalExample, string everydayExample, string activityPrompt)
            {
                Name = name;
                Definition = definition;
                HistoricalExample = historicalExample;
                EverydayExample = everydayExample;
                ActivityPrompt = activityPrompt;
            }
        }

        private void InitializeCharacterTraits()
        {
            characterTraits = new List<CharacterTrait>
            {
                new CharacterTrait(
                    "Fairness",
                    "Being fair means treating everyone the same way and being honest.",
                    "Benjamin Franklin was fair when he helped write rules that treated all people equally.",
                    "Taking turns at the playground and sharing toys with friends.",
                    "How can you be fair to your classmates today?"
                ),
                new CharacterTrait(
                    "Respect for Others",
                    "Respect means being kind and polite to everyone, even if they are different from you.",
                    "Ruby Bridges showed respect by being kind even when others were not kind to her.",
                    "Saying 'please' and 'thank you' and listening when others talk.",
                    "Who is someone you respect and why?"
                ),
                new CharacterTrait(
                    "Respect for Environment",
                    "Taking care of our Earth, plants, animals, and keeping places clean.",
                    "Theodore Roosevelt protected national parks so animals and trees would be safe.",
                    "Putting trash in garbage cans and not picking flowers in the park.",
                    "What can you do to help take care of our Earth?"
                ),
                new CharacterTrait(
                    "Courage",
                    "Being brave and doing the right thing even when it's scary or hard.",
                    "Lewis and Clark were courageous when they explored new, unknown places.",
                    "Standing up for a friend who is being teased or trying something new.",
                    "Tell about a time when you were brave!"
                ),
                new CharacterTrait(
                    "Equality",
                    "Believing that all people should be treated the same, no matter what they look like.",
                    "Ruby Bridges helped show that all children should go to school together.",
                    "Including everyone in games and not leaving anyone out.",
                    "How can you help everyone feel included?"
                ),
                new CharacterTrait(
                    "Tolerance",
                    "Being patient and kind to people who are different from you.",
                    "George Washington Carver was tolerant and kept working even when people were mean to him.",
                    "Being nice to new students and learning about different cultures.",
                    "How can you be more understanding of others?"
                ),
                new CharacterTrait(
                    "Perseverance",
                    "Never giving up, even when something is hard or takes a long time.",
                    "Thomas Jefferson kept working on the Declaration of Independence until it was perfect.",
                    "Practicing reading every day or learning to ride a bike even after falling.",
                    "What is something hard you kept trying until you got it?"
                ),
                new CharacterTrait(
                    "Commitment",
                    "Keeping your promises and finishing what you start.",
                    "George Washington was committed to helping America become free and independent.",
                    "Feeding your pet every day or finishing your homework before playing.",
                    "What promise can you make to be a better person?"
                )
            };
        }

        private void DisplayTraitInfo(int index)
        {
            if (index >= 0 && index < characterTraits.Count)
            {
                var trait = characterTraits[index];
                lblTraitName.Text = trait.Name;
                lblTraitDefinition.Text = trait.Definition;
                lblHistoricalExample.Text = $"Historical Hero: {trait.HistoricalExample}";
                lblEverydayExample.Text = $"In Your Life: {trait.EverydayExample}";
                lblActivityPrompt.Text = trait.ActivityPrompt;
                
                btnPrevious.Enabled = index > 0;
                btnNext.Enabled = index < characterTraits.Count - 1;
                
                HighlightCurrentTraitButton(index);
            }
        }

        private void HighlightCurrentTraitButton(int index)
        {
            ResetButtonColors();
            switch (index)
            {
                case 0: btnFairness.BackColor = Color.Gold; break;
                case 1: btnRespectOthers.BackColor = Color.LightBlue; break;
                case 2: btnRespectEnvironment.BackColor = Color.LightGreen; break;
                case 3: btnCourage.BackColor = Color.Orange; break;
                case 4: btnEquality.BackColor = Color.Pink; break;
                case 5: btnTolerance.BackColor = Color.LightCyan; break;
                case 6: btnPerseverance.BackColor = Color.LightSalmon; break;
                case 7: btnCommitment.BackColor = Color.Plum; break;
            }
        }

        private void ResetButtonColors()
        {
            btnFairness.BackColor = Color.LightGray;
            btnRespectOthers.BackColor = Color.LightGray;
            btnRespectEnvironment.BackColor = Color.LightGray;
            btnCourage.BackColor = Color.LightGray;
            btnEquality.BackColor = Color.LightGray;
            btnTolerance.BackColor = Color.LightGray;
            btnPerseverance.BackColor = Color.LightGray;
            btnCommitment.BackColor = Color.LightGray;
        }

        private void btnFairness_Click(object sender, EventArgs e)
        {
            currentTraitIndex = 0;
            DisplayTraitInfo(currentTraitIndex);
        }

        private void btnRespectOthers_Click(object sender, EventArgs e)
        {
            currentTraitIndex = 1;
            DisplayTraitInfo(currentTraitIndex);
        }

        private void btnRespectEnvironment_Click(object sender, EventArgs e)
        {
            currentTraitIndex = 2;
            DisplayTraitInfo(currentTraitIndex);
        }

        private void btnCourage_Click(object sender, EventArgs e)
        {
            currentTraitIndex = 3;
            DisplayTraitInfo(currentTraitIndex);
        }

        private void btnEquality_Click(object sender, EventArgs e)
        {
            currentTraitIndex = 4;
            DisplayTraitInfo(currentTraitIndex);
        }

        private void btnTolerance_Click(object sender, EventArgs e)
        {
            currentTraitIndex = 5;
            DisplayTraitInfo(currentTraitIndex);
        }

        private void btnPerseverance_Click(object sender, EventArgs e)
        {
            currentTraitIndex = 6;
            DisplayTraitInfo(currentTraitIndex);
        }

        private void btnCommitment_Click(object sender, EventArgs e)
        {
            currentTraitIndex = 7;
            DisplayTraitInfo(currentTraitIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentTraitIndex < characterTraits.Count - 1)
            {
                currentTraitIndex++;
                DisplayTraitInfo(currentTraitIndex);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentTraitIndex > 0)
            {
                currentTraitIndex--;
                DisplayTraitInfo(currentTraitIndex);
            }
        }

        private void btnBackToUnit2Ch3_Click(object sender, EventArgs e)
        {
            Unit_2_Ch_3 unit2Ch3Form = new Unit_2_Ch_3();
            unit2Ch3Form.Show();
        }

        private void btnCharacterChallenge_Click(object sender, EventArgs e)
        {
            var trait = characterTraits[currentTraitIndex];
            MessageBox.Show($"Character Challenge!\n\n{trait.ActivityPrompt}\n\nThink about your answer and share it with someone!", 
                          "Be a Character Hero!", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnToUnit3Ch2_Click(object sender, EventArgs e)
        {
            Unit_3_Ch_2__SS1CG2_ unit3Ch2Form = new Unit_3_Ch_2__SS1CG2_();
            unit3Ch2Form.Show();
        }
    }
}
