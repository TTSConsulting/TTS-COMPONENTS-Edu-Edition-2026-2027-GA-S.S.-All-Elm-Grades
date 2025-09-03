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
    public partial class Unit_4_Ch_1__SS1E1_ : Form
    {
        private List<Good> goods = new List<Good>();
        private List<Service> services = new List<Service>();
        private int currentGoodIndex = 0;
        private int currentServiceIndex = 0;
        private bool showingGoods = true;

        public Unit_4_Ch_1__SS1E1_()
        {
            InitializeComponent();
            InitializeGoodsAndServices();
            DisplayGood(currentGoodIndex);
        }

        public class Good
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string WhoMakes { get; set; }
            public string WhyImportant { get; set; }
            public string GeorgiaExample { get; set; }
            public string EverydayUse { get; set; }

            public Good(string name, string description, string whoMakes, string whyImportant, string georgiaExample, string everydayUse)
            {
                Name = name;
                Description = description;
                WhoMakes = whoMakes;
                WhyImportant = whyImportant;
                GeorgiaExample = georgiaExample;
                EverydayUse = everydayUse;
            }
        }

        public class Service
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string WhoProvides { get; set; }
            public string WhyImportant { get; set; }
            public string GeorgiaExample { get; set; }
            public string HowItHelps { get; set; }

            public Service(string name, string description, string whoProvides, string whyImportant, string georgiaExample, string howItHelps)
            {
                Name = name;
                Description = description;
                WhoProvides = whoProvides;
                WhyImportant = whyImportant;
                GeorgiaExample = georgiaExample;
                HowItHelps = howItHelps;
            }
        }

        private void InitializeGoodsAndServices()
        {
            // Initialize Goods
            goods = new List<Good>
            {
                new Good(
                    "Food",
                    "Things we eat to stay healthy and strong",
                    "Farmers, bakers, cooks, and factory workers",
                    "We need food to grow and have energy to play and learn",
                    "Georgia grows delicious peaches, peanuts, and pecans!",
                    "We eat breakfast, lunch, and dinner every day"
                ),
                new Good(
                    "Clothes",
                    "Things we wear to stay warm and look nice",
                    "Tailors, designers, and factory workers",
                    "Clothes keep us warm, dry, and comfortable",
                    "Georgia makes cotton that becomes soft t-shirts and jeans",
                    "We wear clothes to school, play, and special events"
                ),
                new Good(
                    "Books",
                    "Things we read to learn new information and stories",
                    "Authors, illustrators, and printing companies",
                    "Books help us learn about the world and have fun reading",
                    "Many books are printed in Georgia publishing companies",
                    "We read books at school, at home, and at the library"
                ),
                new Good(
                    "Toys",
                    "Things we play with to have fun and learn",
                    "Toy designers, engineers, and factory workers",
                    "Toys help us learn, be creative, and have fun with friends",
                    "Some toys are made in Georgia factories",
                    "We play with toys at home, school, and with friends"
                ),
                new Good(
                    "Houses",
                    "Places where we live with our families",
                    "Builders, carpenters, and construction workers",
                    "Houses keep us safe, warm, and dry",
                    "Georgia has beautiful houses made from local wood and materials",
                    "Our houses are where we sleep, eat, and spend time with family"
                ),
                new Good(
                    "Cars",
                    "Vehicles that help us travel from place to place",
                    "Engineers, factory workers, and mechanics",
                    "Cars help us get to school, work, and visit family",
                    "Some cars are made in Georgia car factories",
                    "Cars take us to the grocery store, school, and fun places"
                )
            };

            // Initialize Services
            services = new List<Service>
            {
                new Service(
                    "Teaching",
                    "Helping students learn new things every day",
                    "Teachers, principals, and school staff",
                    "Teachers help us learn to read, write, and solve problems",
                    "Georgia has wonderful teachers in schools across the state",
                    "Teachers help us become smart and ready for the future"
                ),
                new Service(
                    "Healthcare",
                    "Helping people stay healthy and feel better when sick",
                    "Doctors, nurses, and hospital workers",
                    "Healthcare workers help us stay healthy and get better when we're sick",
                    "Georgia has many hospitals and clinics to help people",
                    "Doctors check our health and give us medicine when we need it"
                ),
                new Service(
                    "Fire Protection",
                    "Keeping people safe from fires and other emergencies",
                    "Firefighters and emergency workers",
                    "Firefighters save lives and protect our homes and schools",
                    "Georgia firefighters protect cities and forests across the state",
                    "Firefighters come quickly when there's an emergency"
                ),
                new Service(
                    "Mail Delivery",
                    "Bringing letters and packages to our homes",
                    "Mail carriers and postal workers",
                    "Mail service helps us stay connected with family and friends",
                    "Georgia postal workers deliver mail to every home and business",
                    "Mail carriers bring us birthday cards, packages, and important letters"
                ),
                new Service(
                    "Trash Collection",
                    "Taking away our garbage to keep our community clean",
                    "Sanitation workers and truck drivers",
                    "Trash collection keeps our neighborhoods clean and healthy",
                    "Georgia waste management companies help keep our cities clean",
                    "Trash collectors come to our houses to take away our garbage"
                ),
                new Service(
                    "Transportation",
                    "Helping people get from one place to another safely",
                    "Bus drivers, train operators, and pilots",
                    "Transportation helps us travel to school, work, and visit places",
                    "Georgia has buses, trains, and planes to help people travel",
                    "School buses take us to school safely every day"
                )
            };
        }

        private void DisplayGood(int index)
        {
            if (index >= 0 && index < goods.Count)
            {
                showingGoods = true;
                var good = goods[index];
                lblItemTitle.Text = $"GOOD: {good.Name}";
                lblDescription.Text = good.Description;
                lblWhoMakesProvides.Text = $"Who Makes It: {good.WhoMakes}";
                lblWhyImportant.Text = $"Why Important: {good.WhyImportant}";
                lblGeorgiaExample.Text = $"Georgia Connection: {good.GeorgiaExample}";
                lblEverydayUse.Text = $"How We Use It: {good.EverydayUse}";
                
                btnPrevious.Enabled = index > 0;
                btnNext.Enabled = index < goods.Count - 1;
                
                HighlightCurrentGoodButton(index);
                UpdateTypeLabel("GOODS");
            }
        }

        private void DisplayService(int index)
        {
            if (index >= 0 && index < services.Count)
            {
                showingGoods = false;
                var service = services[index];
                lblItemTitle.Text = $"SERVICE: {service.Name}";
                lblDescription.Text = service.Description;
                lblWhoMakesProvides.Text = $"Who Provides It: {service.WhoProvides}";
                lblWhyImportant.Text = $"Why Important: {service.WhyImportant}";
                lblGeorgiaExample.Text = $"Georgia Connection: {service.GeorgiaExample}";
                lblEverydayUse.Text = $"How It Helps: {service.HowItHelps}";
                
                btnPrevious.Enabled = index > 0;
                btnNext.Enabled = index < services.Count - 1;
                
                HighlightCurrentServiceButton(index);
                UpdateTypeLabel("SERVICES");
            }
        }

        private void HighlightCurrentGoodButton(int index)
        {
            ResetGoodButtonColors();
            switch (index)
            {
                case 0: btnFood.BackColor = Color.Orange; break;
                case 1: btnClothes.BackColor = Color.Purple; break;
                case 2: btnBooks.BackColor = Color.Green; break;
                case 3: btnToys.BackColor = Color.Red; break;
                case 4: btnHouses.BackColor = Color.Brown; break;
                case 5: btnCars.BackColor = Color.Blue; break;
            }
        }

        private void HighlightCurrentServiceButton(int index)
        {
            ResetServiceButtonColors();
            switch (index)
            {
                case 0: btnTeaching.BackColor = Color.Gold; break;
                case 1: btnHealthcare.BackColor = Color.LightBlue; break;
                case 2: btnFireProtection.BackColor = Color.Red; break;
                case 3: btnMailDelivery.BackColor = Color.LightGreen; break;
                case 4: btnTrashCollection.BackColor = Color.Gray; break;
                case 5: btnTransportation.BackColor = Color.Yellow; break;
            }
        }

        private void ResetGoodButtonColors()
        {
            btnFood.BackColor = Color.LightGray;
            btnClothes.BackColor = Color.LightGray;
            btnBooks.BackColor = Color.LightGray;
            btnToys.BackColor = Color.LightGray;
            btnHouses.BackColor = Color.LightGray;
            btnCars.BackColor = Color.LightGray;
        }

        private void ResetServiceButtonColors()
        {
            btnTeaching.BackColor = Color.LightGray;
            btnHealthcare.BackColor = Color.LightGray;
            btnFireProtection.BackColor = Color.LightGray;
            btnMailDelivery.BackColor = Color.LightGray;
            btnTrashCollection.BackColor = Color.LightGray;
            btnTransportation.BackColor = Color.LightGray;
        }

        private void UpdateTypeLabel(string type)
        {
            lblCurrentType.Text = $"Currently Showing: {type}";
            lblCurrentType.ForeColor = type == "GOODS" ? Color.DarkBlue : Color.DarkGreen;
        }

        // Good Button Click Events
        private void btnFood_Click(object sender, EventArgs e)
        {
            currentGoodIndex = 0;
            DisplayGood(currentGoodIndex);
        }

        private void btnClothes_Click(object sender, EventArgs e)
        {
            currentGoodIndex = 1;
            DisplayGood(currentGoodIndex);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            currentGoodIndex = 2;
            DisplayGood(currentGoodIndex);
        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            currentGoodIndex = 3;
            DisplayGood(currentGoodIndex);
        }

        private void btnHouses_Click(object sender, EventArgs e)
        {
            currentGoodIndex = 4;
            DisplayGood(currentGoodIndex);
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            currentGoodIndex = 5;
            DisplayGood(currentGoodIndex);
        }

        // Service Button Click Events
        private void btnTeaching_Click(object sender, EventArgs e)
        {
            currentServiceIndex = 0;
            DisplayService(currentServiceIndex);
        }

        private void btnHealthcare_Click(object sender, EventArgs e)
        {
            currentServiceIndex = 1;
            DisplayService(currentServiceIndex);
        }

        private void btnFireProtection_Click(object sender, EventArgs e)
        {
            currentServiceIndex = 2;
            DisplayService(currentServiceIndex);
        }

        private void btnMailDelivery_Click(object sender, EventArgs e)
        {
            currentServiceIndex = 3;
            DisplayService(currentServiceIndex);
        }

        private void btnTrashCollection_Click(object sender, EventArgs e)
        {
            currentServiceIndex = 4;
            DisplayService(currentServiceIndex);
        }

        private void btnTransportation_Click(object sender, EventArgs e)
        {
            currentServiceIndex = 5;
            DisplayService(currentServiceIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (showingGoods)
            {
                if (currentGoodIndex < goods.Count - 1)
                {
                    currentGoodIndex++;
                    DisplayGood(currentGoodIndex);
                }
            }
            else
            {
                if (currentServiceIndex < services.Count - 1)
                {
                    currentServiceIndex++;
                    DisplayService(currentServiceIndex);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (showingGoods)
            {
                if (currentGoodIndex > 0)
                {
                    currentGoodIndex--;
                    DisplayGood(currentGoodIndex);
                }
            }
            else
            {
                if (currentServiceIndex > 0)
                {
                    currentServiceIndex--;
                    DisplayService(currentServiceIndex);
                }
            }
        }

        private void btnShowGoods_Click(object sender, EventArgs e)
        {
            DisplayGood(currentGoodIndex);
        }

        private void btnShowServices_Click(object sender, EventArgs e)
        {
            DisplayService(currentServiceIndex);
        }

        private void btnBackToUnit3Ch2_Click(object sender, EventArgs e)
        {
            Unit_3_Ch_2__SS1CG2_ unit3Ch2Form = new Unit_3_Ch_2__SS1CG2_();
            unit3Ch2Form.Show();
        }

        private void btnToUnit4Ch2_Click(object sender, EventArgs e)
        {
            Unit_4_Ch_2__SS1E2_ unit4Ch2Form = new Unit_4_Ch_2__SS1E2_();
            unit4Ch2Form.Show();
            this.Hide();
        }

        private void btnGoodsServicesGame_Click(object sender, EventArgs e)
        {
            string gameInstructions = "🎮 GOODS vs SERVICES GAME! 🎮\n\n";
            gameInstructions += "GOODS are things you can TOUCH:\n";
            gameInstructions += "• Food, clothes, toys, books\n\n";
            gameInstructions += "SERVICES are things people DO for you:\n";
            gameInstructions += "• Teaching, healthcare, delivery\n\n";
            gameInstructions += "Look around your classroom!\n";
            gameInstructions += "• Can you find 3 GOODS?\n";
            gameInstructions += "• Can you think of 3 SERVICES your school provides?\n\n";
            gameInstructions += "Talk about your answers with your teacher!";
            
            MessageBox.Show(gameInstructions, "Goods vs Services Game!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEconomicsQuiz_Click(object sender, EventArgs e)
        {
            string quiz = "📚 ECONOMICS QUIZ! 📚\n\n";
            quiz += "1. Is a pizza a GOOD or SERVICE?\n";
            quiz += "   (Answer: GOOD - you can touch it!)\n\n";
            quiz += "2. Is a haircut a GOOD or SERVICE?\n";
            quiz += "   (Answer: SERVICE - someone does it for you!)\n\n";
            quiz += "3. Name one thing Georgia makes:\n";
            quiz += "   (Answer: Peaches, peanuts, cars, etc.)\n\n";
            quiz += "4. Name one service your community provides:\n";
            quiz += "   (Answer: Fire protection, mail, teaching, etc.)\n\n";
            quiz += "Great job learning about goods and services!";
            
            MessageBox.Show(quiz, "Economics Quiz", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
