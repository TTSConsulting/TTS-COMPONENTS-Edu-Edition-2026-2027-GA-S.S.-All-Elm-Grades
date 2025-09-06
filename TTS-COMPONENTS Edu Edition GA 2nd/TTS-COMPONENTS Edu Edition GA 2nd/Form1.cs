namespace TTS_COMPONENTS_Edu_Edition_GA_2nd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FigureButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is string tagValue && int.TryParse(tagValue, out int figureIndex))
            {
                ShowHistoricalFigureInfo(figureIndex);
            }
        }

        private void btnNextChapter_Click(object? sender, EventArgs e)
        {
            // Open Unit 1 Chapter 2 form
            Unit_1_Ch_2__SS2H2_ chapter2Form = new Unit_1_Ch_2__SS2H2_();
            chapter2Form.Show();
        }

        private void ShowHistoricalFigureInfo(int index)
        {
            string[] figureNames = {
                "James Oglethorpe",
                "Tomochichi",
                "Mary Musgrove",
                "Sequoyah",
                "Jackie Robinson",
                "Martin Luther King Jr.",
                "Juliette Gordon Low",
                "Jimmy Carter"
            };

            string[] figureInfo = {
                "James Oglethorpe founded the colony of Georgia in 1733. He wanted to help poor people from England start new lives in America. He was a kind leader who made friends with the Native Americans.",
                
                "Tomochichi was a Creek Indian chief who became friends with James Oglethorpe. He helped the English settlers learn how to live in Georgia. He was very wise and helped keep peace between his people and the colonists.",
                
                "Mary Musgrove was half Creek Indian and half English. She could speak both languages, so she helped Oglethorpe and Tomochichi talk to each other. She was also a successful trader.",
                
                "Sequoyah was a Cherokee Indian who created an alphabet for his people. Before Sequoyah, the Cherokee language was only spoken. Now they could read and write in their own language!",
                
                "Jackie Robinson was the first African American to play Major League Baseball. He was born in Georgia and showed great sportsmanship. He helped break down barriers and fight for civil rights.",
                
                "Martin Luther King Jr. was born in Atlanta, Georgia. He was a great leader who fought for civil rights using peaceful protests. He had a dream that all people would be treated equally.",
                
                "Juliette Gordon Low founded the Girl Scouts of America in Savannah, Georgia in 1912. She wanted girls to learn new skills, help others, and become strong leaders.",
                
                "Jimmy Carter was the 39th President of the United States. He was born in Plains, Georgia. As president and after, he worked hard to help people around the world and promote human rights."
            };

            MessageBox.Show(figureInfo[index], figureNames[index], MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
