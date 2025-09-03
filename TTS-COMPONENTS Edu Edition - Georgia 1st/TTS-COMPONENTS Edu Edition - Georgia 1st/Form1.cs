using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    public partial class Form1 : Form
    {
        private int currentFigureIndex = 0;
        private readonly HistoricalFigure[] figures;

        public Form1()
        {
            InitializeComponent();
            
            // Initialize historical figures data aligned to SS1H1
            figures = new HistoricalFigure[]
            {
                new HistoricalFigure
                {
                    Name = "Benjamin Franklin",
                    Contribution = "Benjamin Franklin was an inventor, author, and statesman. He invented many things like bifocals (glasses to see far and near) and helped create electricity experiments with kites and lightning!",
                    ThenNowComparison = "THEN: Ben Franklin used candles for light and wrote with quill pens. NOW: We use electric lights and computers to write!"
                },
                new HistoricalFigure
                {
                    Name = "Thomas Jefferson",
                    Contribution = "Thomas Jefferson helped write the Declaration of Independence, which said America wanted to be free from England. He was also the 3rd President of the United States!",
                    ThenNowComparison = "THEN: Jefferson rode horses to travel and wrote letters by hand. NOW: We drive cars and send emails instantly!"
                },
                new HistoricalFigure
                {
                    Name = "Meriwether Lewis & William Clark",
                    Contribution = "Lewis and Clark were brave explorers who traveled across America with Sacagawea (a Native American guide) to map new lands and discover what was out west!",
                    ThenNowComparison = "THEN: They walked and used canoes to explore, following rivers and stars. NOW: We use GPS and cars to travel anywhere!"
                },
                new HistoricalFigure
                {
                    Name = "Theodore Roosevelt",
                    Contribution = "Theodore Roosevelt was President who loved nature! He created many National Parks to protect animals and beautiful lands so everyone could enjoy them forever.",
                    ThenNowComparison = "THEN: People didn't protect nature much and animals were disappearing. NOW: We have National Parks where animals are safe!"
                },
                new HistoricalFigure
                {
                    Name = "George Washington Carver",
                    Contribution = "George Washington Carver was a scientist who discovered over 300 ways to use peanuts! He helped farmers grow better crops and invented peanut butter!",
                    ThenNowComparison = "THEN: Farmers didn't know how to make soil healthy for plants. NOW: We use George's discoveries to grow food better!"
                },
                new HistoricalFigure
                {
                    Name = "Ruby Bridges",
                    Contribution = "Ruby Bridges was a brave 6-year-old girl who was the first African American child to go to an all-white school. She helped make schools fair for everyone!",
                    ThenNowComparison = "THEN: Schools were separated by skin color, which wasn't fair. NOW: All children can go to school together no matter what they look like!"
                }
            };
        }

        // Ensure this method signature matches the EventHandler delegate
        private void btnBenjaminFranklin_Click(object sender, EventArgs e)
        {
            currentFigureIndex = 0;
            DisplayFigureInfo();
        }

        private void btnThomasJefferson_Click(object sender, EventArgs e)
        {
            currentFigureIndex = 1;
            DisplayFigureInfo();
        }

        private void btnMeriwetherLewis_Click(object sender, EventArgs e)
        {
            currentFigureIndex = 2;
            DisplayFigureInfo();
        }

        private void btnTheodoreRoosevelt_Click(object sender, EventArgs e)
        {
            currentFigureIndex = 3;
            DisplayFigureInfo();
        }

        private void btnGeorgeWashingtonCarver_Click(object sender, EventArgs e)
        {
            currentFigureIndex = 4;
            DisplayFigureInfo();
        }

        private void btnRubyBridges_Click(object sender, EventArgs e)
        {
            currentFigureIndex = 5;
            DisplayFigureInfo();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentFigureIndex < figures.Length - 1)
            {
                currentFigureIndex++;
                DisplayFigureInfo();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentFigureIndex > 0)
            {
                currentFigureIndex--;
                DisplayFigureInfo();
            }
        }

        private void btnToUnit2_Click(object sender, EventArgs e)
        {
            // Open Unit 2 form and hide this one
            Unit_2_Ch_1 unit2Form = new Unit_2_Ch_1();
            unit2Form.Show();
        }

        private void DisplayFigureInfo()
        {
            var figure = figures[currentFigureIndex];
            lblFigureName.Text = figure.Name;
            lblContribution.Text = figure.Contribution;
            lblThenNow.Text = figure.ThenNowComparison;
            
            // Update navigation buttons
            btnPrevious.Enabled = currentFigureIndex > 0;
            btnNext.Enabled = currentFigureIndex < figures.Length - 1;
        }
    }

    // Supporting class for historical figure data
    public class HistoricalFigure
    {
        public string Name { get; set; } = "";
        public string Contribution { get; set; } = "";
        public string ThenNowComparison { get; set; } = "";
    }
}
