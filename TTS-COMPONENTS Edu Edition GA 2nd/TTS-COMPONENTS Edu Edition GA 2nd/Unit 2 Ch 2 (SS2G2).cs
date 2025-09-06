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
    public partial class Unit_2_Ch_2__SS2G2_ : Form
    {
        public Unit_2_Ch_2__SS2G2_()
        {
            InitializeComponent();
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            string tag = button?.Tag?.ToString() ?? "";

            switch (tag)
            {
                case "oglethorpe":
                    ShowLocationInfo("James Oglethorpe & Savannah", 
                        "🏛️ James Oglethorpe founded Savannah in 1733 in the Coastal Plain region!\n\n" +
                        "📍 LOCATION: Coastal Plain - flat land near the Atlantic Ocean\n" +
                        "🌊 GEOGRAPHY: Near the Savannah River and ocean port\n" +
                        "🏘️ WHY HERE: Good for ships, trading, and farming\n\n" +
                        "🤝 PEOPLE CONNECTION: Oglethorpe worked with Tomochichi (Creek leader)\n" +
                        "📜 HISTORICAL FACT: This was Georgia's first permanent English settlement!\n\n" +
                        "🌟 TODAY: Savannah is still a major port city in the Coastal Plain!");
                    break;

                case "tomochichi":
                    ShowLocationInfo("Tomochichi & Creek Territory", 
                        "🌾 Tomochichi was a Creek leader who lived in central Georgia!\n\n" +
                        "📍 LOCATION: Creek territory - mostly in the Piedmont region\n" +
                        "🏞️ GEOGRAPHY: Rolling hills, many rivers, good farming land\n" +
                        "🌱 WHY HERE: Rich soil for crops, rivers for water and travel\n\n" +
                        "🤝 PEOPLE CONNECTION: Helped James Oglethorpe establish Savannah\n" +
                        "🏕️ CULTURAL FACT: Creek people were skilled farmers and traders!\n\n" +
                        "🌟 TODAY: Many Georgia cities are built where Creek villages once were!");
                    break;

                case "musgrove":
                    ShowLocationInfo("Mary Musgrove & Trading Posts", 
                        "🤝 Mary Musgrove helped Creek and English people trade together!\n\n" +
                        "📍 LOCATION: Trading posts along Georgia's rivers\n" +
                        "🏞️ GEOGRAPHY: Rivers like Savannah, Oconee, and Ocmulgee\n" +
                        "🚤 WHY HERE: Rivers were highways for travel and trade\n\n" +
                        "👥 PEOPLE CONNECTION: Half Creek, half English - perfect translator!\n" +
                        "💼 CULTURAL FACT: Trading brought different cultures together!\n\n" +
                        "🌟 TODAY: Georgia's rivers are still important for transportation!");
                    break;

                case "sequoyah":
                    ShowLocationInfo("Sequoyah & Cherokee Territory", 
                        "📝 Sequoyah created the Cherokee alphabet in the mountains!\n\n" +
                        "📍 LOCATION: Cherokee territory - Blue Ridge Mountains and Ridge/Valley\n" +
                        "🏔️ GEOGRAPHY: High mountains, deep valleys, thick forests\n" +
                        "🌲 WHY HERE: Mountains provided protection and natural resources\n\n" +
                        "👥 PEOPLE CONNECTION: Made it possible for Cherokee to read and write!\n" +
                        "📚 CULTURAL FACT: Only Native American to create a writing system!\n\n" +
                        "🌟 TODAY: North Georgia mountains still show Cherokee influence!");
                    break;

                case "creek":
                    ShowLocationInfo("Creek People & Their Geography", 
                        "🌾 The Creek people adapted perfectly to their environment!\n\n" +
                        "📍 LOCATION: Piedmont and parts of Coastal Plain\n" +
                        "🏞️ GEOGRAPHY: Rolling hills, river valleys, fertile farmland\n" +
                        "🌱 HOW THEY USED IT:\n" +
                        "  • Farmed corn, beans, and squash in rich soil\n" +
                        "  • Used rivers for travel and fishing\n" +
                        "  • Built villages near water sources\n" +
                        "  • Traded along river routes\n\n" +
                        "🏘️ SETTLEMENT PATTERN: Villages along major rivers\n" +
                        "🌟 LEGACY: Many Georgia towns are where Creek villages were!");
                    break;

                case "cherokee":
                    ShowLocationInfo("Cherokee People & Their Geography", 
                        "🏔️ The Cherokee people mastered mountain living!\n\n" +
                        "📍 LOCATION: Blue Ridge Mountains and Ridge and Valley regions\n" +
                        "🏔️ GEOGRAPHY: High mountains, deep valleys, rushing streams\n" +
                        "🌲 HOW THEY USED IT:\n" +
                        "  • Hunted deer and other animals in forests\n" +
                        "  • Grew crops in mountain valleys\n" +
                        "  • Used mountain streams for water\n" +
                        "  • Built homes from mountain materials\n\n" +
                        "🏘️ SETTLEMENT PATTERN: Villages in protected mountain valleys\n" +
                        "🌟 LEGACY: North Georgia mountains still show Cherokee heritage!");
                    break;

                case "atlanta":
                    ShowLocationInfo("Modern Atlanta & Historical Connections", 
                        "🏙️ Atlanta connects our past and present!\n\n" +
                        "📍 LOCATION: Piedmont region - same area as Cherokee and Creek territory\n" +
                        "🏞️ GEOGRAPHY: Rolling hills, many streams, mild climate\n" +
                        "🔗 HISTORICAL CONNECTIONS:\n" +
                        "  • Built where Cherokee trails crossed\n" +
                        "  • Near old Creek trading routes\n" +
                        "  • Same geography that attracted Native Americans\n\n" +
                        "🚂 WHY IT GREW: Railroad crossroads, just like old Indian trails\n" +
                        "🌟 TODAY: Georgia's capital city in the same region that Native Americans chose!");
                    break;

                case "savannah":
                    ShowLocationInfo("Modern Savannah & Historical Connections", 
                        "🏛️ Savannah shows how geography shapes history!\n\n" +
                        "📍 LOCATION: Coastal Plain - same place Oglethorpe chose in 1733\n" +
                        "🌊 GEOGRAPHY: Flat land, near ocean, on Savannah River\n" +
                        "🔗 HISTORICAL CONNECTIONS:\n" +
                        "  • Same location Oglethorpe chose for colony\n" +
                        "  • Where Tomochichi met the English\n" +
                        "  • Still uses the river for transportation\n\n" +
                        "🚢 WHY IT WORKS: Ocean port, river access, flat land for building\n" +
                        "🌟 TODAY: Still Georgia's main port city - same reasons as 1733!");
                    break;
            }
        }

        private void ShowLocationInfo(string title, string info)
        {
            MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            // Navigate back to main menu
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void btnNextUnit_Click(object sender, EventArgs e)
        {
            // Navigate to Unit 3 Chapter 1 (SS2CG1 - Government)
            this.Hide();
            Unit_3_Ch_1__SS2CG1_ unit3Form = new Unit_3_Ch_1__SS2CG1_();
            unit3Form.Show();
        }
    }
}
