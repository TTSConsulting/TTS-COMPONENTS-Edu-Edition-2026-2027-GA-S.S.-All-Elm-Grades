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
    public partial class Unit_2_Ch_1 : Form
    {
        private int currentRegionIndex = 0;
        private readonly GeographicRegion[] regions;

        public Unit_2_Ch_1()
        {
            InitializeComponent();
            
            // Initialize geographic regions data aligned to SS1G1
            regions = new GeographicRegion[]
            {
                new GeographicRegion
                {
                    Name = "American Colonies",
                    GeographicInfluence = "The American Colonies were along the Atlantic Ocean with forests, rivers, and good farmland. People lived in small towns and worked as farmers, craftsmen, or traders. The colonies had to follow rules from England across the ocean.",
                    HistoricalFigures = "Benjamin Franklin lived in Philadelphia where he could print newspapers and meet other smart people. Thomas Jefferson lived in Virginia where he could grow crops and think about freedom from England."
                },
                new GeographicRegion
                {
                    Name = "American Frontier",
                    GeographicInfluence = "The American Frontier was wild, unexplored land with mountains, rivers, and vast plains. There were no roads or maps! Native Americans knew the land well and helped explorers find their way through dangerous places.",
                    HistoricalFigures = "Meriwether Lewis and William Clark explored this frontier with help from Sacagawea, a Native American guide. She knew the rivers, mountains, and safe paths because she grew up on this land."
                },
                new GeographicRegion
                {
                    Name = "National Parks",
                    GeographicInfluence = "National Parks are special places with beautiful mountains, forests, geysers, and wildlife. These places needed protection because people were cutting down trees and hunting too many animals. The land was disappearing!",
                    HistoricalFigures = "Theodore Roosevelt loved the outdoors and saw that America's natural beauty was being destroyed. He created National Parks like Yellowstone to protect bears, buffalo, and beautiful landscapes forever."
                },
                new GeographicRegion
                {
                    Name = "Southern United States",
                    GeographicInfluence = "The Southern U.S. has warm weather perfect for growing cotton, peanuts, and other crops. But there were unfair laws that treated people differently based on skin color. This made life very hard for African Americans.",
                    HistoricalFigures = "George Washington Carver worked in Alabama where peanuts grew well, helping farmers. Ruby Bridges lived in New Orleans where schools were separated by race, but she bravely helped change that."
                }
            };
        }

        private void btnAmericanColonies_Click(object sender, EventArgs e)
        {
            currentRegionIndex = 0;
            DisplayRegionInfo();
        }

        private void btnAmericanFrontier_Click(object sender, EventArgs e)
        {
            currentRegionIndex = 1;
            DisplayRegionInfo();
        }

        private void btnNationalParks_Click(object sender, EventArgs e)
        {
            currentRegionIndex = 2;
            DisplayRegionInfo();
        }

        private void btnSouthernUS_Click(object sender, EventArgs e)
        {
            currentRegionIndex = 3;
            DisplayRegionInfo();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentRegionIndex < regions.Length - 1)
            {
                currentRegionIndex++;
                DisplayRegionInfo();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentRegionIndex > 0)
            {
                currentRegionIndex--;
                DisplayRegionInfo();
            }
        }

        private void btnBackToUnit1_Click(object sender, EventArgs e)
        {
            // Open Unit 1 form and close this one
            Form1 unit1Form = new Form1();
            unit1Form.Show();
            this.Hide();
        }

        private void btnToUnit2Ch2_Click(object sender, EventArgs e)
        {
            // Open Unit 2 Ch 2 form and close this one
            Unit_2_Ch_2__SS1G2_ unit2Ch2Form = new Unit_2_Ch_2__SS1G2_();
            unit2Ch2Form.Show();
        }

        private void DisplayRegionInfo()
        {
            var region = regions[currentRegionIndex];
            lblRegionName.Text = region.Name;
            lblGeographicInfluence.Text = region.GeographicInfluence;
            lblHistoricalFigures.Text = region.HistoricalFigures;
            
            // Update navigation buttons
            btnPrevious.Enabled = currentRegionIndex > 0;
            btnNext.Enabled = currentRegionIndex < regions.Length - 1;
        }
    }

    // Supporting class for geographic region data
    public class GeographicRegion
    {
        public string Name { get; set; } = "";
        public string GeographicInfluence { get; set; } = "";
        public string HistoricalFigures { get; set; } = "";
    }
}
