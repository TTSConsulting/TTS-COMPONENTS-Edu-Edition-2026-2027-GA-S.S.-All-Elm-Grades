using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition_GA_2nd
{
    public partial class End_Of_The_Year_Certificate : Form
    {
        private int animationStep = 0;
        private System.Windows.Forms.Timer? animationTimer;

        public End_Of_The_Year_Certificate()
        {
            InitializeComponent();
            LoadCertificateData();
            InitializeAnimations();
        }

        private void LoadCertificateData()
        {
            // Set current date
            this.DateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            // Set school year
            this.SchoolYearLabel.Text = "2024-2025 School Year";

            // Set student name (can be customized)
            this.StudentNameLabel.Text = "Outstanding Student";
        }

        private void InitializeAnimations()
        {
            // Create a timer for certificate animations
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 500; // 500ms intervals
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object? sender, EventArgs e)
        {
            // Animate the congratulations text
            animationStep++;

            if (animationStep % 2 == 0)
            {
                this.CongratsLabel.ForeColor = Color.Gold;
                this.CelebrationLabel.Text = "🎉🎊🏆 AMAZING ACHIEVEMENT! 🏆🎊🎉";
            }
            else
            {
                this.CongratsLabel.ForeColor = Color.Purple;
                this.CelebrationLabel.Text = "⭐🌟✨ EXCELLENT WORK! ✨🌟⭐";
            }

            // Stop after 20 steps (10 seconds)
            if (animationStep >= 20)
            {
                animationTimer?.Stop();
                this.CongratsLabel.ForeColor = Color.DarkBlue;
                this.CelebrationLabel.Text = "🎉 CONGRATULATIONS ON AN OUTSTANDING YEAR! 🎉";
            }
        }

        private void StartCelebrationButton_Click(object sender, EventArgs e)
        {
            animationStep = 0;
            animationTimer?.Start();

            MessageBox.Show("🎉 LET'S CELEBRATE! 🎉\n\n" +
                "You have successfully completed ALL of 2nd Grade Social Studies!\n\n" +
                "🏛️ CIVICS (Unit 2 & 3):\n" +
                "• Learned about government and rules\n" +
                "• Studied important historical figures\n" +
                "• Explored character traits and citizenship\n\n" +
                "💰 ECONOMICS (Unit 4):\n" +
                "• Understood scarcity and choices\n" +
                "• Explored different economic systems\n" +
                "• Learned about money and saving\n\n" +
                "This is a tremendous accomplishment!\n" +
                "You should be very proud of all your hard work!",
                "🏆 CELEBRATION TIME! 🏆",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void PrintCertificateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a PrintDialog
                PrintDialog printDialog = new PrintDialog();
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                
                printDocument.PrintPage += (s, args) =>
                {
                    if (args.Graphics == null) return;
                    
                    // Get the form's image
                    Bitmap bitmap = new Bitmap(this.Width, this.Height);
                    this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
                    
                    // Calculate scaling to fit on page
                    float scaleX = (float)args.PageBounds.Width / bitmap.Width;
                    float scaleY = (float)args.PageBounds.Height / bitmap.Height;
                    float scale = Math.Min(scaleX, scaleY);
                    
                    int newWidth = (int)(bitmap.Width * scale);
                    int newHeight = (int)(bitmap.Height * scale);
                    
                    // Center the image on the page
                    int x = (args.PageBounds.Width - newWidth) / 2;
                    int y = (args.PageBounds.Height - newHeight) / 2;
                    
                    args.Graphics.DrawImage(bitmap, x, y, newWidth, newHeight);
                    bitmap.Dispose();
                };
                
                printDialog.Document = printDocument;
                
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                    MessageBox.Show("🖨️ Certificate sent to printer successfully!\n\n" +
                        "Your End-of-Year Certificate is printing.\n" +
                        "Congratulations on this amazing achievement!",
                        "Print Success!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Print Error\n\nSorry, there was an error printing the certificate:\n{ex.Message}\n\n" +
                    "You can try taking a screenshot instead (Windows Key + Shift + S)",
                    "Print Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveCertificateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveDialog.Title = "Save End-of-Year Certificate";
                saveDialog.FileName = $"End_of_Year_Certificate_{DateTime.Now:yyyy_MM_dd}";
                
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a bitmap of the form
                    Bitmap bitmap = new Bitmap(this.Width, this.Height);
                    this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
                    
                    // Determine format based on file extension
                    string extension = Path.GetExtension(saveDialog.FileName).ToLower();
                    System.Drawing.Imaging.ImageFormat format = extension switch
                    {
                        ".jpg" or ".jpeg" => System.Drawing.Imaging.ImageFormat.Jpeg,
                        ".bmp" => System.Drawing.Imaging.ImageFormat.Bmp,
                        _ => System.Drawing.Imaging.ImageFormat.Png
                    };
                    
                    bitmap.Save(saveDialog.FileName, format);
                    bitmap.Dispose();
                    
                    MessageBox.Show($"💾 Certificate Saved Successfully!\n\n" +
                        $"Your End-of-Year Certificate has been saved to:\n{saveDialog.FileName}\n\n" +
                        "You can now:\n" +
                        "• Share it with family and friends\n" +
                        "• Print it for framing\n" +
                        "• Add it to your achievement portfolio\n" +
                        "• Email it to teachers and relatives\n\n" +
                        "Congratulations on this amazing accomplishment!",
                        "Certificate Saved!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Save Error\n\nSorry, there was an error saving the certificate:\n{ex.Message}\n\n" +
                    "Please try again or choose a different location.",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ViewStandardsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("📚 GEORGIA STANDARDS MASTERED THIS YEAR\n\n" +
                "🏛️ CIVICS STANDARDS:\n" +
                "• SS2CG1: Define the concept of government and the need for rules and laws\n" +
                "• SS2CG2: Identify the role of the citizen in American democracy\n" +
                "• SS2CG3: Give examples of how historical figures demonstrate positive character traits\n\n" +
                "💰 ECONOMICS STANDARDS:\n" +
                "• SS2E1: Explain that because of scarcity, people must make choices with opportunity costs\n" +
                "• SS2E2: Identify ways that people organize economic systems to deal with scarcity\n" +
                "• SS2E3: Explain that people usually use money to obtain goods and services vs barter\n" +
                "• SS2E4: Describe the costs and benefits of personal saving and spending choices\n\n" +
                "🌍 ADDITIONAL LEARNING:\n" +
                "• Character traits of historical figures\n" +
                "• Government structure and citizenship\n" +
                "• Economic decision-making\n" +
                "• Problem-solving and critical thinking\n\n" +
                "TOTAL: 7 Major Standards + Countless Learning Objectives!\n" +
                "This represents a comprehensive 2nd grade social studies education!",
                "🎓 All Standards Mastered!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void EditStudentNameButton_Click(object sender, EventArgs e)
        {
            string currentName = this.StudentNameLabel.Text;

            using (Form inputForm = new Form())
            {
                inputForm.Text = "🎓 Personalize Your Certificate";
                inputForm.Size = new Size(450, 180);
                inputForm.StartPosition = FormStartPosition.CenterParent;
                inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                inputForm.MaximizeBox = false;
                inputForm.MinimizeBox = false;
                inputForm.BackColor = Color.LightBlue;

                Label promptLabel = new Label()
                {
                    Text = "Enter the student's name for this special End-of-Year Certificate:",
                    Location = new Point(20, 20),
                    Size = new Size(400, 25),
                    Font = new Font("Georgia", 10F, FontStyle.Bold),
                    ForeColor = Color.DarkBlue
                };

                TextBox inputTextBox = new TextBox()
                {
                    Text = currentName,
                    Location = new Point(20, 55),
                    Size = new Size(300, 30),
                    Font = new Font("Georgia", 12F),
                    SelectionStart = 0,
                    SelectionLength = currentName.Length
                };

                Button okButton = new Button()
                {
                    Text = "✅ Update Certificate",
                    Location = new Point(330, 52),
                    Size = new Size(90, 35),
                    DialogResult = DialogResult.OK,
                    BackColor = Color.LightGreen,
                    Font = new Font("Georgia", 9F, FontStyle.Bold)
                };

                Button cancelButton = new Button()
                {
                    Text = "❌ Cancel",
                    Location = new Point(330, 95),
                    Size = new Size(90, 30),
                    DialogResult = DialogResult.Cancel,
                    BackColor = Color.LightCoral,
                    Font = new Font("Georgia", 9F)
                };

                Label tipLabel = new Label()
                {
                    Text = "💡 Tip: This will update the certificate with the new name instantly!",
                    Location = new Point(20, 95),
                    Size = new Size(300, 40),
                    Font = new Font("Georgia", 8F, FontStyle.Italic),
                    ForeColor = Color.DarkGreen
                };

                inputForm.Controls.AddRange(new Control[] { promptLabel, inputTextBox, okButton, cancelButton, tipLabel });
                inputForm.AcceptButton = okButton;
                inputForm.CancelButton = cancelButton;

                // Focus and select the text
                inputTextBox.Focus();
                inputTextBox.SelectAll();

                if (inputForm.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(inputTextBox.Text))
                {
                    this.StudentNameLabel.Text = inputTextBox.Text.Trim();
                    
                    MessageBox.Show($"🎉 Certificate Updated Successfully!\n\n" +
                        $"The certificate is now personalized for:\n{inputTextBox.Text.Trim()}\n\n" +
                        "The name change has been applied to your End-of-Year Certificate!",
                        "Certificate Personalized!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            // Stop any running animations
            animationTimer?.Stop();
            
            // Close this form and return to main menu
            this.Close();
            
            // Find the main form if it exists, otherwise create a new one
            Form1? mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (mainForm == null)
            {
                mainForm = new Form1();
            }
            
            if (!mainForm.Visible)
            {
                mainForm.Show();
            }
            else
            {
                mainForm.BringToFront();
            }
        }

        private void PrepareForNextYearButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("🎓 READY FOR 3RD GRADE! 🎓\n\n" +
                "Congratulations on completing 2nd Grade Social Studies!\n\n" +
                "🌟 WHAT YOU'VE ACCOMPLISHED:\n" +
                "• Mastered all Georgia 2nd Grade SS Standards\n" +
                "• Learned about government, citizenship, and character\n" +
                "• Understood economics, money, and decision-making\n" +
                "• Developed critical thinking and problem-solving skills\n\n" +
                "🚀 GET READY FOR 3RD GRADE:\n" +
                "• Geography and map skills\n" +
                "• American history and historical figures\n" +
                "• Government and civic responsibility\n" +
                "• Economics and entrepreneurship\n\n" +
                "Georgia Standards You Will Learn next!: Third Grade\n" +
                "United States History\n" +
                "Year 1: American Indian Cultures through Colonization\n" +
                "You have built an excellent foundation for future learning!\n" +
                "Keep up the outstanding work!\n\n" +
                "Have a wonderful summer and see you in 3rd grade! 📚✨",
                "🌟 Ready for the Next Adventure! 🌟",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Show welcome message when form loads
            this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();
        }

        private void DateCompletedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
