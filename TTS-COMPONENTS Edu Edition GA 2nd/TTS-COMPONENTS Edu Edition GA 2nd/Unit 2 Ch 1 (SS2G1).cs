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
    public partial class Unit_2_Ch_1__SS2G1_ : Form
    {
        public Unit_2_Ch_1__SS2G1_()
        {
            InitializeComponent();
        }

        private void GeographicFeature_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is string feature)
            {
                ShowGeographicInfo(feature);
            }
        }

        private void ShowGeographicInfo(string feature)
        {
            string title = "";
            string content = "";

            switch (feature.ToLower())
            {
                case "blueridge":
                    title = "🏔️ Blue Ridge Region";
                    content = "The Blue Ridge region is in the mountains of North Georgia!\n\n" +
                             "What makes it special:\n" +
                             "• Has the highest mountains in Georgia\n" +
                             "• Brasstown Bald is the tallest peak\n" +
                             "• Beautiful blue-colored mountains\n" +
                             "• Cool temperatures and lots of trees\n" +
                             "• Great for hiking and camping\n" +
                             "• Home to many animals like bears and deer";
                    break;

                case "piedmont":
                    title = "⛰️ Piedmont Region";
                    content = "The Piedmont region has rolling hills and is in the middle of Georgia!\n\n" +
                             "What makes it special:\n" +
                             "• Rolling hills that look like gentle waves\n" +
                             "• Atlanta is located here\n" +
                             "• Most people in Georgia live in this region\n" +
                             "• Good soil for farming\n" +
                             "• Many rivers and streams\n" +
                             "• 'Piedmont' means 'foot of the mountain'";
                    break;

                case "coastalplain":
                    title = "🏖️ Coastal Plain Region";
                    content = "The Coastal Plain is the largest region with flat land and beaches!\n\n" +
                             "What makes it special:\n" +
                             "• Flat land that's great for farming\n" +
                             "• Has beautiful beaches along the Atlantic Ocean\n" +
                             "• Okefenokee Swamp is located here\n" +
                             "• Grows lots of peanuts, cotton, and pecans\n" +
                             "• Warm weather year-round\n" +
                             "• Home to many birds and alligators";
                    break;

                case "ridgevalley":
                    title = "🗻 Ridge and Valley Region";
                    content = "The Ridge and Valley region has long ridges and valleys in Northwest Georgia!\n\n" +
                             "What makes it special:\n" +
                             "• Long, narrow ridges and valleys\n" +
                             "• Looks like parallel lines from above\n" +
                             "• Good for farming in the valleys\n" +
                             "• Has limestone caves\n" +
                             "• Rich soil and minerals\n" +
                             "• Cooler temperatures than South Georgia";
                    break;

                case "appalachianplateau":
                    title = "🏔️ Appalachian Plateau Region";
                    content = "The Appalachian Plateau is the smallest region in Northwest Georgia!\n\n" +
                             "What makes it special:\n" +
                             "• Flat-topped mountains\n" +
                             "• Smallest region in Georgia\n" +
                             "• Has coal deposits underground\n" +
                             "• Lookout Mountain is located here\n" +
                             "• Cool temperatures\n" +
                             "• Beautiful views from the plateau tops";
                    break;

                case "savannah":
                    title = "🌊 Savannah River";
                    content = "The Savannah River forms Georgia's eastern border with South Carolina!\n\n" +
                             "Important facts:\n" +
                             "• Forms the border between Georgia and South Carolina\n" +
                             "• Flows into the Atlantic Ocean\n" +
                             "• The city of Savannah is located at its mouth\n" +
                             "• Used for shipping and transportation\n" +
                             "• Provides water for drinking and farming\n" +
                             "• Important for Georgia's history and trade";
                    break;

                case "flint":
                    title = "🌊 Flint River";
                    content = "The Flint River flows through Southwest Georgia!\n\n" +
                             "Important facts:\n" +
                             "• Flows through Southwest Georgia\n" +
                             "• Eventually flows into the Gulf of Mexico\n" +
                             "• Provides water for farming and cities\n" +
                             "• Good for fishing and recreation\n" +
                             "• Helps irrigate peanut and cotton farms\n" +
                             "• Important water source for the region";
                    break;

                case "chattahoochee":
                    title = "🌊 Chattahoochee River";
                    content = "The Chattahoochee River forms Georgia's western border with Alabama!\n\n" +
                             "Important facts:\n" +
                             "• Forms the border between Georgia and Alabama\n" +
                             "• Flows through Atlanta\n" +
                             "• Eventually flows into the Gulf of Mexico\n" +
                             "• Provides water for millions of people\n" +
                             "• Used for recreation like boating and fishing\n" +
                             "• Name means 'painted rock' in Creek language";
                    break;

                default:
                    title = "Geographic Information";
                    content = "Click on a region or river to learn more about Georgia's geography!";
                    break;
            }

            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNextChapter_Click(object sender, EventArgs e)
        {
            Unit_2_Ch_2__SS2G2_ nextChapter = new Unit_2_Ch_2__SS2G2_();
            nextChapter.Show();
            this.Hide();
        }
    }
}
