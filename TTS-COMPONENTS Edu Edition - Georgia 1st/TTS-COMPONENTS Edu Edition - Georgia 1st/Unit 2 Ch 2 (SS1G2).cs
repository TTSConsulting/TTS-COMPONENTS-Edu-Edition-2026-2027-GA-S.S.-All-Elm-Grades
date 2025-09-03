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
    public partial class Unit_2_Ch_2__SS1G2_ : Form
    {
        private int currentLocationIndex = 0;
        private readonly LocationLevel[] locations;

        public Unit_2_Ch_2__SS1G2_()
        {
            InitializeComponent();
            
            // Initialize location data aligned to SS1G2
            locations = new LocationLevel[]
            {
                new LocationLevel
                {
                    Name = "My City",
                    LocationName = "Atlanta",
                    Description = "A city is where you live! Atlanta is Georgia's capital city. It has neighborhoods, schools, parks, and stores. Cities have streets with addresses so people can find places. Your house or apartment is in a city!"
                },
                new LocationLevel
                {
                    Name = "My County",
                    LocationName = "Fulton County",
                    Description = "A county is bigger than a city! Fulton County has many cities inside it, including Atlanta. Counties help organize government services like schools and parks. Think of a county like a big container that holds several cities!"
                },
                new LocationLevel
                {
                    Name = "My State",
                    LocationName = "Georgia",
                    Description = "Georgia is our state! It's much bigger than counties and cities. Georgia has 159 counties and many cities. Our state has mountains in the north, beaches in the south, and the famous city of Atlanta. Georgia grows peaches and peanuts!"
                },
                new LocationLevel
                {
                    Name = "My Country",
                    LocationName = "United States of America",
                    Description = "The United States is our country! It has 50 states, and Georgia is one of them. Our country goes from the Atlantic Ocean to the Pacific Ocean. We have one President for the whole country, and we celebrate the 4th of July!"
                },
                new LocationLevel
                {
                    Name = "My Continent",
                    LocationName = "North America",
                    Description = "North America is our continent! It's a huge piece of land with three main countries: United States, Canada, and Mexico. Continents are separated by oceans. There are 7 continents on Earth, and we live on North America!"
                }
            };
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            currentLocationIndex = 0;
            DisplayLocationInfo();
        }

        private void btnCounty_Click(object sender, EventArgs e)
        {
            currentLocationIndex = 1;
            DisplayLocationInfo();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            currentLocationIndex = 2;
            DisplayLocationInfo();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            currentLocationIndex = 3;
            DisplayLocationInfo();
        }

        private void btnContinent_Click(object sender, EventArgs e)
        {
            currentLocationIndex = 4;
            DisplayLocationInfo();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentLocationIndex < locations.Length - 1)
            {
                currentLocationIndex++;
                DisplayLocationInfo();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentLocationIndex > 0)
            {
                currentLocationIndex--;
                DisplayLocationInfo();
            }
        }

        private void btnBackToUnit2Ch1_Click(object sender, EventArgs e)
        {
            // Open Unit 2 Ch 1 form and close this one
            Unit_2_Ch_1 unit2Ch1Form = new Unit_2_Ch_1();
            unit2Ch1Form.Show();
            this.Hide();
        }

        private void btnViewOnMap_Click(object sender, EventArgs e)
        {
            var location = locations[currentLocationIndex];
            string mapMessage = $"🗺️ On a map, you would look for {location.LocationName}!\n\n";
            
            switch (currentLocationIndex)
            {
                case 0: // City
                    mapMessage += "🏠 Find your street and neighborhood on a city map!";
                    break;
                case 1: // County
                    mapMessage += "🏛️ Look for county lines on a regional map!";
                    break;
                case 2: // State
                    mapMessage += "🍑 Find Georgia's peach shape on a US map!";
                    break;
                case 3: // Country
                    mapMessage += "🦅 Look for the United States between two oceans!";
                    break;
                case 4: // Continent
                    mapMessage += "🌎 Find North America on a world map or globe!";
                    break;
            }
            
            MessageBox.Show(mapMessage, "View on Map", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayLocationInfo()
        {
            var location = locations[currentLocationIndex];
            lblLocationName.Text = location.LocationName;
            lblLocationInfo.Text = location.Description;
            
            // Update navigation buttons
            btnPrevious.Enabled = currentLocationIndex > 0;
            btnNext.Enabled = currentLocationIndex < locations.Length - 1;
            
            // Highlight the current level button
            ResetButtonColors();
            switch (currentLocationIndex)
            {
                case 0: btnCity.BackColor = Color.LightGreen; break;
                case 1: btnCounty.BackColor = Color.Yellow; break;
                case 2: btnState.BackColor = Color.Orange; break;
                case 3: btnCountry.BackColor = Color.LightCoral; break;
                case 4: btnContinent.BackColor = Color.Violet; break;
            }
        }

        private void ResetButtonColors()
        {
            btnCity.BackColor = Color.LightGray;
            btnCounty.BackColor = Color.LightGray;
            btnState.BackColor = Color.LightGray;
            btnCountry.BackColor = Color.LightGray;
            btnContinent.BackColor = Color.LightGray;
        }

        private void btnToUnit2Ch3_Click(object sender, EventArgs e)
        {
            Unit_2_Ch_3 unit2Ch3Form = new Unit_2_Ch_3();
            unit2Ch3Form.Show();
        }
    }

    // Supporting class for location level data
    public class LocationLevel
    {
        public string Name { get; set; } = "";
        public string LocationName { get; set; } = "";
        public string Description { get; set; } = "";
    }
}
