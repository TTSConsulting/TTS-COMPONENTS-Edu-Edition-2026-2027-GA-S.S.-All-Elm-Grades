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
    public partial class Unit_1_Ch_2__SS2H2_ : Form
    {
        public Unit_1_Ch_2__SS2H2_()
        {
            InitializeComponent();
        }

        private void CategoryButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is string category)
            {
                ShowCulturalComparison(category);
            }
        }

        private void btnNextUnit_Click(object? sender, EventArgs e)
        {
            // Open Unit 2 Chapter 1 form
            Unit_2_Ch_1__SS2G1_ unit2Form = new Unit_2_Ch_1__SS2G1_();
            unit2Form.Show();
        }

        private void ShowCulturalComparison(string category)
        {
            string title = "";
            string content = "";

            switch (category.ToLower())
            {
                case "tools":
                    title = "Tools - Creek and Cherokee vs Today";
                    content = "Creek & Cherokee Tools:\n" +
                             "• Made tools from stone, wood, and bone\n" +
                             "• Used bows and arrows for hunting\n" +
                             "• Created pottery for cooking and storage\n" +
                             "• Made baskets from plants\n\n" +
                             "Tools Today:\n" +
                             "• We use metal tools and machines\n" +
                             "• We have electric appliances\n" +
                             "• We buy tools from stores\n" +
                             "• We use plastic and metal containers";
                    break;

                case "clothing":
                    title = "Clothing - Creek and Cherokee vs Today";
                    content = "Creek & Cherokee Clothing:\n" +
                             "• Made clothes from animal skins\n" +
                             "• Decorated with beads and feathers\n" +
                             "• Wore moccasins on their feet\n" +
                             "• Used natural materials like plant fibers\n\n" +
                             "Clothing Today:\n" +
                             "• We wear clothes made in factories\n" +
                             "• We use cotton, polyester, and other materials\n" +
                             "• We buy clothes from stores\n" +
                             "• We have shoes made of rubber and leather";
                    break;

                case "homes":
                    title = "Homes - Creek and Cherokee vs Today";
                    content = "Creek & Cherokee Homes:\n" +
                             "• Built homes from wood, clay, and grass\n" +
                             "• Creek lived in houses with thatched roofs\n" +
                             "• Cherokee lived in log cabins and wigwams\n" +
                             "• Used fire for heat and cooking\n\n" +
                             "Homes Today:\n" +
                             "• We live in houses made of brick, wood, and concrete\n" +
                             "• We have electricity and indoor plumbing\n" +
                             "• We use air conditioning and heating systems\n" +
                             "• We have modern appliances and furniture";
                    break;

                case "living":
                    title = "Making a Living - Creek and Cherokee vs Today";
                    content = "Creek & Cherokee Ways:\n" +
                             "• Grew crops like corn, beans, and squash\n" +
                             "• Hunted deer, turkey, and other animals\n" +
                             "• Fished in rivers and streams\n" +
                             "• Gathered nuts, berries, and plants\n\n" +
                             "Making a Living Today:\n" +
                             "• We work in offices, schools, and stores\n" +
                             "• We buy food from grocery stores\n" +
                             "• We use money to pay for things we need\n" +
                             "• We have many different types of jobs";
                    break;

                case "accomplishments":
                    title = "Accomplishments - Creek and Cherokee";
                    content = "Creek Accomplishments:\n" +
                             "• Created a strong confederacy of tribes\n" +
                             "• Developed successful farming techniques\n" +
                             "• Built lasting relationships with other tribes\n" +
                             "• Preserved their culture and traditions\n\n" +
                             "Cherokee Accomplishments:\n" +
                             "• Sequoyah created the Cherokee alphabet\n" +
                             "• Developed their own constitution and government\n" +
                             "• Built schools and had their own newspaper\n" +
                             "• Maintained their language and customs";
                    break;

                default:
                    title = "Cultural Information";
                    content = "Click on a category to learn more!";
                    break;
            }

            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
