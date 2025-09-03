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
    public partial class Unit_2_Ch_3 : Form
    {
        private List<TopographicalFeature> topographicalFeatures = new List<TopographicalFeature>();
        private int currentFeatureIndex = 0;

        public Unit_2_Ch_3()
        {
            InitializeComponent();
            InitializeTopographicalFeatures();
            DisplayFeatureInfo(currentFeatureIndex);
        }

        public class TopographicalFeature
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public string Examples { get; set; }
            public string GeorgiaExample { get; set; }

            public TopographicalFeature(string name, string type, string description, string examples, string georgiaExample)
            {
                Name = name;
                Type = type;
                Description = description;
                Examples = examples;
                GeorgiaExample = georgiaExample;
            }
        }

        private void InitializeTopographicalFeatures()
        {
            topographicalFeatures = new List<TopographicalFeature>
            {
                new TopographicalFeature(
                    "Continents",
                    "Large Land Areas",
                    "The biggest pieces of land on Earth! There are 7 continents where people live.",
                    "North America, South America, Africa, Europe, Asia, Antarctica, Australia",
                    "We live in North America! Georgia is part of this big continent."
                ),
                new TopographicalFeature(
                    "Oceans",
                    "Large Water Areas",
                    "Huge bodies of water that cover most of our planet! Fish and whales live here.",
                    "Atlantic, Pacific, Indian, Arctic, Southern",
                    "Georgia is near the Atlantic Ocean! We can drive to the beach there."
                ),
                new TopographicalFeature(
                    "Mountains",
                    "High Land",
                    "Very tall land that reaches up to the sky! They can have snow on top.",
                    "Rocky Mountains, Appalachian Mountains, Himalayas",
                    "North Georgia has the Appalachian Mountains! People like to hike there."
                ),
                new TopographicalFeature(
                    "Deserts",
                    "Dry Land",
                    "Places with very little water and rain. Cactus plants grow in deserts!",
                    "Sahara Desert, Mojave Desert, Gobi Desert",
                    "Georgia doesn't have deserts, but we can visit them in other states!"
                ),
                new TopographicalFeature(
                    "Valleys",
                    "Low Land",
                    "Low areas between hills or mountains. Rivers often flow through valleys.",
                    "Central Valley, Death Valley, Great Rift Valley",
                    "Georgia has many valleys between our mountains and hills!"
                ),
                new TopographicalFeature(
                    "Coasts",
                    "Where Land Meets Water",
                    "The edge where the land meets the ocean. Beaches are part of the coast!",
                    "East Coast, West Coast, Gulf Coast",
                    "Georgia has a beautiful coast with beaches like Tybee Island!"
                )
            };
        }

        private void DisplayFeatureInfo(int index)
        {
            if (index >= 0 && index < topographicalFeatures.Count)
            {
                var feature = topographicalFeatures[index];
                lblFeatureName.Text = feature.Name;
                lblFeatureType.Text = $"Type: {feature.Type}";
                lblFeatureDescription.Text = feature.Description;
                lblFeatureExamples.Text = $"Examples: {feature.Examples}";
                lblGeorgiaConnection.Text = $"Georgia Connection: {feature.GeorgiaExample}";
                
                btnPrevious.Enabled = index > 0;
                btnNext.Enabled = index < topographicalFeatures.Count - 1;
            }
        }

        private void btnContinents_Click(object sender, EventArgs e)
        {
            currentFeatureIndex = 0;
            DisplayFeatureInfo(currentFeatureIndex);
        }

        private void btnOceans_Click(object sender, EventArgs e)
        {
            currentFeatureIndex = 1;
            DisplayFeatureInfo(currentFeatureIndex);
        }

        private void btnMountains_Click(object sender, EventArgs e)
        {
            currentFeatureIndex = 2;
            DisplayFeatureInfo(currentFeatureIndex);
        }

        private void btnDeserts_Click(object sender, EventArgs e)
        {
            currentFeatureIndex = 3;
            DisplayFeatureInfo(currentFeatureIndex);
        }

        private void btnValleys_Click(object sender, EventArgs e)
        {
            currentFeatureIndex = 4;
            DisplayFeatureInfo(currentFeatureIndex);
        }

        private void btnCoasts_Click(object sender, EventArgs e)
        {
            currentFeatureIndex = 5;
            DisplayFeatureInfo(currentFeatureIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentFeatureIndex < topographicalFeatures.Count - 1)
            {
                currentFeatureIndex++;
                DisplayFeatureInfo(currentFeatureIndex);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentFeatureIndex > 0)
            {
                currentFeatureIndex--;
                DisplayFeatureInfo(currentFeatureIndex);
            }
        }

        private void btnBackToUnit2Ch2_Click(object sender, EventArgs e)
        {
            Unit_2_Ch_2__SS1G2_ unit2Ch2Form = new Unit_2_Ch_2__SS1G2_();
            unit2Ch2Form.Show();
        }

        private void btnExploreMap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Let's explore the world map together! Point to the continents and oceans you learned about!", 
                          "Explore the World", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToUnit3Ch1_Click(object sender, EventArgs e)
        {
            Unit_3_Ch_1__SS1CG1_ unit3Ch1Form = new Unit_3_Ch_1__SS1CG1_();
            unit3Ch1Form.Show();
        }
    }
}
