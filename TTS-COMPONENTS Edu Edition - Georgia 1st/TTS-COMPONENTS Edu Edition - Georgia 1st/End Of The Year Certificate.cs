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

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    public partial class End_Of_The_Year_Certificate : Form
    {
        private PrintDocument? printDocument;
        
        public End_Of_The_Year_Certificate()
        {
            InitializeComponent();
            InitializeCertificate();
        }
        
        private void InitializeCertificate()
        {
            // Initialize print document
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            
            // Set current date
            lblDate.Text = $"Date: {DateTime.Now.ToString("MMMM dd, yyyy")}";
            
            // Set default student name placeholder
            txtStudentName.Text = "Enter Student Name";
            txtStudentName.ForeColor = Color.Gray;
            
            // Add focus events for student name textbox
            txtStudentName.GotFocus += TxtStudentName_GotFocus;
            txtStudentName.LostFocus += TxtStudentName_LostFocus;
            
            // Set default teacher name placeholder
            txtTeacherName.Text = "Enter Teacher Name";
            txtTeacherName.ForeColor = Color.Gray;
            
            // Add focus events for teacher name textbox
            txtTeacherName.GotFocus += TxtTeacherName_GotFocus;
            txtTeacherName.LostFocus += TxtTeacherName_LostFocus;
            
            // Set default principal name placeholder
            txtPrincipalName.Text = "Enter Principal Name";
            txtPrincipalName.ForeColor = Color.Gray;
            
            // Add focus events for principal name textbox
            txtPrincipalName.GotFocus += TxtPrincipalName_GotFocus;
            txtPrincipalName.LostFocus += TxtPrincipalName_LostFocus;
            
            // Add border effect
            this.Paint += Form_Paint;
        }
        
        private void TxtStudentName_GotFocus(object? sender, EventArgs e)
        {
            if (txtStudentName.Text == "Enter Student Name")
            {
                txtStudentName.Text = "";
                txtStudentName.ForeColor = Color.DarkBlue;
            }
        }
        
        private void TxtStudentName_LostFocus(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                txtStudentName.Text = "Enter Student Name";
                txtStudentName.ForeColor = Color.Gray;
            }
        }
        
        private void TxtTeacherName_GotFocus(object? sender, EventArgs e)
        {
            if (txtTeacherName.Text == "Enter Teacher Name")
            {
                txtTeacherName.Text = "";
                txtTeacherName.ForeColor = Color.DarkBlue;
            }
        }
        
        private void TxtTeacherName_LostFocus(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherName.Text))
            {
                txtTeacherName.Text = "Enter Teacher Name";
                txtTeacherName.ForeColor = Color.Gray;
            }
        }
        
        private void TxtPrincipalName_GotFocus(object? sender, EventArgs e)
        {
            if (txtPrincipalName.Text == "Enter Principal Name")
            {
                txtPrincipalName.Text = "";
                txtPrincipalName.ForeColor = Color.DarkBlue;
            }
        }
        
        private void TxtPrincipalName_LostFocus(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrincipalName.Text))
            {
                txtPrincipalName.Text = "Enter Principal Name";
                txtPrincipalName.ForeColor = Color.Gray;
            }
        }
        
        private void Form_Paint(object? sender, PaintEventArgs e)
        {
            // Draw decorative border around the certificate
            using (Pen borderPen = new Pen(Color.DarkBlue, 3))
            {
                Rectangle borderRect = new Rectangle(10, 10, this.ClientSize.Width - 20, this.ClientSize.Height - 80);
                e.Graphics.DrawRectangle(borderPen, borderRect);
                
                // Inner decorative border
                using (Pen innerPen = new Pen(Color.Gold, 2))
                {
                    Rectangle innerRect = new Rectangle(15, 15, this.ClientSize.Width - 30, this.ClientSize.Height - 90);
                    e.Graphics.DrawRectangle(innerPen, innerRect);
                }
            }
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateAllNames() && printDocument != null)
                {
                    // Show print preview first
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.WindowState = FormWindowState.Maximized;
                    printPreviewDialog.Text = "Certificate Print Preview";
                    
                    if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                    {
                        // After preview, show print dialog
                        PrintDialog printDialog = new PrintDialog();
                        printDialog.Document = printDocument;
                        
                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            printDocument.Print();
                            MessageBox.Show("Certificate printed successfully!", "Print Complete", 
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing certificate: {ex.Message}", "Print Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateAllNames())
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    saveDialog.Title = "Save Certificate";
                    saveDialog.FileName = $"{txtStudentName.Text}_Certificate.png";
                    
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        SaveCertificateAsImage(saveDialog.FileName);
                        MessageBox.Show($"Certificate saved as {saveDialog.FileName}", "Save Complete", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving certificate: {ex.Message}", "Save Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCustomize_Click(object sender, EventArgs e)
        {
            // Show customization options
            CustomizationDialog customDialog = new CustomizationDialog();
            if (customDialog.ShowDialog() == DialogResult.OK)
            {
                // Apply customizations
                ApplyCustomizations(customDialog);
            }
        }
        
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Navigate back to main menu
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
        
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateAllNames() && printDocument != null)
                {
                    // Show print preview
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.WindowState = FormWindowState.Maximized;
                    printPreviewDialog.Text = "Certificate Print Preview";
                    printPreviewDialog.UseAntiAlias = true;
                    
                    printPreviewDialog.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing preview: {ex.Message}", "Preview Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool ValidateStudentName()
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) || txtStudentName.Text == "Enter Student Name")
            {
                MessageBox.Show("Please enter the student's name before printing or saving the certificate.", 
                              "Student Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentName.Focus();
                return false;
            }
            return true;
        }
        
        private bool ValidateAllNames()
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) || txtStudentName.Text == "Enter Student Name")
            {
                MessageBox.Show("Please enter the student's name before printing or saving the certificate.", 
                              "Student Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentName.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtTeacherName.Text) || txtTeacherName.Text == "Enter Teacher Name")
            {
                MessageBox.Show("Please enter the teacher's name before printing or saving the certificate.", 
                              "Teacher Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeacherName.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtPrincipalName.Text) || txtPrincipalName.Text == "Enter Principal Name")
            {
                MessageBox.Show("Please enter the principal's name before printing or saving the certificate.", 
                              "Principal Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrincipalName.Focus();
                return false;
            }
            
            return true;
        }
        
        private void SaveCertificateAsImage(string fileName)
        {
            // Create a bitmap of the certificate area
            Rectangle certificateArea = new Rectangle(10, 10, this.ClientSize.Width - 20, this.ClientSize.Height - 80);
            Bitmap bitmap = new Bitmap(certificateArea.Width, certificateArea.Height);
            
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Fill background
                g.FillRectangle(new SolidBrush(this.BackColor), 0, 0, bitmap.Width, bitmap.Height);
                
                // Draw all certificate elements
                DrawCertificateContent(g, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            }
            
            // Save in the appropriate format
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
            string extension = Path.GetExtension(fileName).ToLower();
            
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    format = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
                case ".bmp":
                    format = System.Drawing.Imaging.ImageFormat.Bmp;
                    break;
                default:
                    format = System.Drawing.Imaging.ImageFormat.Png;
                    break;
            }
            
            bitmap.Save(fileName, format);
            bitmap.Dispose();
        }
        
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (e.Graphics == null) return;
            
            // Scale the certificate to fit the page
            float scale = Math.Min(
                (float)e.MarginBounds.Width / (this.ClientSize.Width - 20),
                (float)e.MarginBounds.Height / (this.ClientSize.Height - 80)
            );
            
            e.Graphics.ScaleTransform(scale, scale);
            
            // Draw certificate content
            Rectangle printArea = new Rectangle(0, 0, this.ClientSize.Width - 20, this.ClientSize.Height - 80);
            DrawCertificateContent(e.Graphics, printArea);
        }
        
        private void DrawCertificateContent(Graphics g, Rectangle bounds)
        {
            // Fill background
            g.FillRectangle(new SolidBrush(Color.Ivory), bounds);
            
            // Draw borders
            using (Pen borderPen = new Pen(Color.DarkBlue, 3))
            {
                g.DrawRectangle(borderPen, bounds);
                
                using (Pen innerPen = new Pen(Color.Gold, 2))
                {
                    Rectangle innerRect = new Rectangle(bounds.X + 5, bounds.Y + 5, 
                                                       bounds.Width - 10, bounds.Height - 10);
                    g.DrawRectangle(innerPen, innerRect);
                }
            }
            
            int yPos = bounds.Y + 30;
            int centerX = bounds.X + bounds.Width / 2;
            
            // Draw main title
            using (Font titleFont = new Font("Times New Roman", 24, FontStyle.Bold))
            {
                string title = "Certificate of Achievement";
                SizeF titleSize = g.MeasureString(title, titleFont);
                PointF titlePoint = new PointF(centerX - titleSize.Width / 2, yPos);
                g.DrawString(title, titleFont, new SolidBrush(Color.DarkBlue), titlePoint);
                yPos += (int)titleSize.Height + 10;
            }
            
            // Draw subtitle
            using (Font subtitleFont = new Font("Times New Roman", 14, FontStyle.Italic))
            {
                string subtitle = "Georgia First Grade Social Studies";
                SizeF subtitleSize = g.MeasureString(subtitle, subtitleFont);
                PointF subtitlePoint = new PointF(centerX - subtitleSize.Width / 2, yPos);
                g.DrawString(subtitle, subtitleFont, new SolidBrush(Color.DarkGoldenrod), subtitlePoint);
                yPos += (int)subtitleSize.Height + 20;
            }
            
            // Draw "Presented to"
            using (Font presentedFont = new Font("Times New Roman", 12, FontStyle.Regular))
            {
                string presented = "This certificate is proudly presented to:";
                SizeF presentedSize = g.MeasureString(presented, presentedFont);
                PointF presentedPoint = new PointF(centerX - presentedSize.Width / 2, yPos);
                g.DrawString(presented, presentedFont, new SolidBrush(Color.DarkBlue), presentedPoint);
                yPos += (int)presentedSize.Height + 10;
            }
            
            // Draw student name with underline
            using (Font nameFont = new Font("Times New Roman", 18, FontStyle.Bold))
            {
                string studentName = txtStudentName.Text;
                if (studentName == "Enter Student Name") studentName = "_________________";
                
                SizeF nameSize = g.MeasureString(studentName, nameFont);
                PointF namePoint = new PointF(centerX - nameSize.Width / 2, yPos);
                g.DrawString(studentName, nameFont, new SolidBrush(Color.DarkBlue), namePoint);
                
                // Draw underline
                using (Pen underlinePen = new Pen(Color.DarkBlue, 2))
                {
                    g.DrawLine(underlinePen, 
                              namePoint.X, namePoint.Y + nameSize.Height,
                              namePoint.X + nameSize.Width, namePoint.Y + nameSize.Height);
                }
                yPos += (int)nameSize.Height + 30;
            }
            
            // Draw completion text
            using (Font completionFont = new Font("Times New Roman", 12, FontStyle.Regular))
            {
                string completion = "For outstanding completion of Georgia First Grade Social Studies";
                SizeF completionSize = g.MeasureString(completion, completionFont);
                PointF completionPoint = new PointF(centerX - completionSize.Width / 2, yPos);
                g.DrawString(completion, completionFont, new SolidBrush(Color.DarkBlue), completionPoint);
                yPos += (int)completionSize.Height + 20;
            }
            
            // Draw achievements section
            using (Font achievementHeaderFont = new Font("Comic Sans MS", 14, FontStyle.Bold))
            {
                string achievementHeader = "🌟 Achievements Unlocked 🌟";
                SizeF headerSize = g.MeasureString(achievementHeader, achievementHeaderFont);
                PointF headerPoint = new PointF(centerX - headerSize.Width / 2, yPos);
                g.DrawString(achievementHeader, achievementHeaderFont, new SolidBrush(Color.DarkGreen), headerPoint);
                yPos += (int)headerSize.Height + 15;
            }
            
            // Draw individual achievements
            using (Font achievementFont = new Font("Comic Sans MS", 10, FontStyle.Regular))
            {
                string[] achievements = {
                    "✅ Unit 1 (SS1H1): Historical Thinking Understanding - Single Chapter Mastery",
                    "✅ Unit 2 (SS1G1-SS1G3): Community Helper Understanding - Multi-Chapter Expert", 
                    "✅ Unit 3 (SS1CG1-SS1CG2): Multi-Chapter Champion Rules and Laws Understanding - Multi-Chapter Champion",
                    "✅ Unit 4 (SS1E1-SS1E4): Economics Understanding - Four Chapter Explorer"
                };
                
                int leftX = bounds.X + 50;
                foreach (string achievement in achievements)
                {
                    g.DrawString(achievement, achievementFont, new SolidBrush(Color.DarkGreen), leftX, yPos);
                    yPos += 25;
                }
                yPos += 20;
            }
            
            // Draw skills section
            using (Font skillHeaderFont = new Font("Comic Sans MS", 12, FontStyle.Bold))
            {
                string skillHeader = "💡 Skills Learned:";
                SizeF skillHeaderSize = g.MeasureString(skillHeader, skillHeaderFont);
                PointF skillHeaderPoint = new PointF(centerX - skillHeaderSize.Width / 2, yPos);
                g.DrawString(skillHeader, skillHeaderFont, new SolidBrush(Color.Navy), skillHeaderPoint);
                yPos += (int)skillHeaderSize.Height + 10;
            }
            
            using (Font skillFont = new Font("Comic Sans MS", 9, FontStyle.Regular))
            {
                string[] skills = {
                    "• Exploring Georgia's history and culture",
                    "• Learning about community helpers and their jobs",
                    "• Understanding rules and why they are important",
                    "• Making smart choices about money and spending",
                    "• Working together and solving problems"
                };
                
                int leftX = bounds.X + 60;
                foreach (string skill in skills)
                {
                    g.DrawString(skill, skillFont, new SolidBrush(Color.Navy), leftX, yPos);
                    yPos += 20;
                }
                yPos += 30;
            }
            
            // Draw date and signatures section
            int bottomY = bounds.Bottom - 120;
            
            // Date
            using (Font dateFont = new Font("Times New Roman", 10, FontStyle.Regular))
            {
                string dateText = $"Date: {DateTime.Now.ToString("MMMM dd, yyyy")}";
                g.DrawString(dateText, dateFont, new SolidBrush(Color.Black), bounds.X + 50, bottomY);
            }
            
            // School year
            using (Font yearFont = new Font("Times New Roman", 10, FontStyle.Regular))
            {
                string yearText = "School Year: 2024-2025";
                SizeF yearSize = g.MeasureString(yearText, yearFont);
                g.DrawString(yearText, yearFont, new SolidBrush(Color.Black), 
                           bounds.Right - yearSize.Width - 50, bottomY);
            }
            
            // Signature lines and names
            int sigY = bottomY + 40;
            using (Pen sigPen = new Pen(Color.Black, 1))
            {
                // Teacher signature area
                using (Font sigFont = new Font("Times New Roman", 12, FontStyle.Regular))
                {
                    string teacherName = txtTeacherName.Text;
                    if (teacherName == "Enter Teacher Name") teacherName = "___________________";
                    
                    // Draw teacher name
                    g.DrawString(teacherName, sigFont, new SolidBrush(Color.Black), bounds.X + 80, sigY - 15);
                    
                    // Draw line under teacher name
                    g.DrawLine(sigPen, bounds.X + 80, sigY, bounds.X + 300, sigY);
                    g.DrawString("Teacher", sigFont, new SolidBrush(Color.Black), bounds.X + 80, sigY + 5);
                }
                
                // Principal signature area 
                using (Font sigFont = new Font("Times New Roman", 12, FontStyle.Regular))
                {
                    string principalName = txtPrincipalName.Text;
                    if (principalName == "Enter Principal Name") principalName = "___________________";
                    
                    // Measure text for right alignment
                    SizeF principalNameSize = g.MeasureString(principalName, sigFont);
                    SizeF principalLabelSize = g.MeasureString("Principal", sigFont);
                    
                    // Draw principal name (right aligned)
                    g.DrawString(principalName, sigFont, new SolidBrush(Color.Black), 
                               bounds.Right - 80 - principalNameSize.Width, sigY - 15);
                    
                    // Draw line under principal name
                    g.DrawLine(sigPen, bounds.Right - 300, sigY, bounds.Right - 80, sigY);
                    g.DrawString("Principal", sigFont, new SolidBrush(Color.Black), 
                               bounds.Right - 80 - principalLabelSize.Width, sigY + 5);
                }
            }
            
            // Draw decorative stars
            using (Font starFont = new Font("Comic Sans MS", 16, FontStyle.Bold))
            {
                using (SolidBrush starBrush = new SolidBrush(Color.Gold))
                {
                    g.DrawString("⭐", starFont, starBrush, bounds.X + 20, bounds.Y + 40);
                    g.DrawString("⭐", starFont, starBrush, bounds.Right - 40, bounds.Y + 40);
                    g.DrawString("⭐", starFont, starBrush, bounds.X + 20, bounds.Bottom - 100);
                    g.DrawString("⭐", starFont, starBrush, bounds.Right - 40, bounds.Bottom - 100);
                }
            }
            
            // Draw Georgia logo placeholder
            using (Font logoFont = new Font("Comic Sans MS", 12, FontStyle.Bold))
            {
                string georgiaText = "🍑 GEORGIA 🍑";
                SizeF georgiaSize = g.MeasureString(georgiaText, logoFont);
                g.DrawString(georgiaText, logoFont, new SolidBrush(Color.DarkRed), 
                           centerX - georgiaSize.Width / 2, bounds.Bottom - 60);
            }
        }
        
        private void ApplyCustomizations(CustomizationDialog customDialog)
        {
            // Apply color and style customizations
            // This would be implemented based on the customization dialog options
        }
    }
    
    // Simple customization dialog class
    public partial class CustomizationDialog : Form
    {
        public CustomizationDialog()
        {
            InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            this.Size = new Size(400, 300);
            this.Text = "Customize Certificate";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            Label lblInfo = new Label();
            lblInfo.Text = "Certificate customization options will be available here.";
            lblInfo.Location = new Point(20, 20);
            lblInfo.Size = new Size(350, 60);
            lblInfo.Font = new Font("Comic Sans MS", 10);
            this.Controls.Add(lblInfo);
            
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new Point(150, 220);
            btnOK.Size = new Size(80, 30);
            btnOK.DialogResult = DialogResult.OK;
            this.Controls.Add(btnOK);
            
            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(240, 220);
            btnCancel.Size = new Size(80, 30);
            btnCancel.DialogResult = DialogResult.Cancel;
            this.Controls.Add(btnCancel);
        }
    }
}
