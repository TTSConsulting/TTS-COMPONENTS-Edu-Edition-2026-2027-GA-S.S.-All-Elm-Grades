using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    partial class Unit_2_Ch_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblStandard = new Label();
            pnlGeographicRegions = new Panel();
            btnAmericanColonies = new Button();
            btnAmericanFrontier = new Button();
            btnNationalParks = new Button();
            btnSouthernUS = new Button();
            pnlContent = new Panel();
            lblRegionName = new Label();
            lblGeographicInfluence = new Label();
            pnlFigures = new Panel();
            lblFiguresTitle = new Label();
            lblHistoricalFigures = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            btnBackToUnit1 = new Button();
            btnToUnit2Ch2 = new Button();
            pnlGeographicRegions.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlFigures.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkGreen;
            lblTitle.Location = new Point(200, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Unit 2 Chapter 1: Places Shape People";
            // 
            // lblStandard
            // 
            lblStandard.AutoSize = true;
            lblStandard.Font = new Font("Arial", 10F);
            lblStandard.Location = new Point(250, 60);
            lblStandard.Name = "lblStandard";
            lblStandard.Size = new Size(400, 16);
            lblStandard.TabIndex = 1;
            lblStandard.Text = "SS1G1: How Time and Place Influenced Historical Figures";
            // 
            // pnlGeographicRegions
            // 
            pnlGeographicRegions.BackColor = Color.LightGreen;
            pnlGeographicRegions.Controls.Add(btnAmericanColonies);
            pnlGeographicRegions.Controls.Add(btnAmericanFrontier);
            pnlGeographicRegions.Controls.Add(btnNationalParks);
            pnlGeographicRegions.Controls.Add(btnSouthernUS);
            pnlGeographicRegions.Location = new Point(50, 100);
            pnlGeographicRegions.Name = "pnlGeographicRegions";
            pnlGeographicRegions.Size = new Size(700, 100);
            pnlGeographicRegions.TabIndex = 2;
            // 
            // btnAmericanColonies
            // 
            btnAmericanColonies.BackColor = Color.Gold;
            btnAmericanColonies.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnAmericanColonies.Location = new Point(20, 20);
            btnAmericanColonies.Name = "btnAmericanColonies";
            btnAmericanColonies.Size = new Size(150, 60);
            btnAmericanColonies.TabIndex = 0;
            btnAmericanColonies.Text = "American Colonies";
            btnAmericanColonies.UseVisualStyleBackColor = false;
            btnAmericanColonies.Click += new System.EventHandler(this.btnAmericanColonies_Click);
            // 
            // btnAmericanFrontier
            // 
            btnAmericanFrontier.BackColor = Color.SandyBrown;
            btnAmericanFrontier.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnAmericanFrontier.Location = new Point(190, 20);
            btnAmericanFrontier.Name = "btnAmericanFrontier";
            btnAmericanFrontier.Size = new Size(150, 60);
            btnAmericanFrontier.TabIndex = 1;
            btnAmericanFrontier.Text = "American Frontier";
            btnAmericanFrontier.UseVisualStyleBackColor = false;
            btnAmericanFrontier.Click += new System.EventHandler(this.btnAmericanFrontier_Click);
            // 
            // btnNationalParks
            // 
            btnNationalParks.BackColor = Color.LimeGreen;
            btnNationalParks.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnNationalParks.Location = new Point(360, 20);
            btnNationalParks.Name = "btnNationalParks";
            btnNationalParks.Size = new Size(150, 60);
            btnNationalParks.TabIndex = 2;
            btnNationalParks.Text = "National Parks";
            btnNationalParks.UseVisualStyleBackColor = false;
            btnNationalParks.Click += new System.EventHandler(this.btnNationalParks_Click);
            // 
            // btnSouthernUS
            // 
            btnSouthernUS.BackColor = Color.LightCoral;
            btnSouthernUS.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnSouthernUS.Location = new Point(530, 20);
            btnSouthernUS.Name = "btnSouthernUS";
            btnSouthernUS.Size = new Size(150, 60);
            btnSouthernUS.TabIndex = 3;
            btnSouthernUS.Text = "Southern U.S.";
            btnSouthernUS.UseVisualStyleBackColor = false;
            btnSouthernUS.Click += new System.EventHandler(this.btnSouthernUS_Click);
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Azure;
            pnlContent.Controls.Add(lblRegionName);
            pnlContent.Controls.Add(lblGeographicInfluence);
            pnlContent.Location = new Point(50, 220);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(700, 180);
            pnlContent.TabIndex = 3;
            // 
            // lblRegionName
            // 
            lblRegionName.AutoSize = true;
            lblRegionName.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            lblRegionName.ForeColor = Color.DarkBlue;
            lblRegionName.Location = new Point(20, 20);
            lblRegionName.Name = "lblRegionName";
            lblRegionName.Size = new Size(450, 27);
            lblRegionName.TabIndex = 0;
            lblRegionName.Text = "Click on a place above to see how it shaped people!";
            // 
            // lblGeographicInfluence
            // 
            lblGeographicInfluence.Font = new Font("Comic Sans MS", 11F);
            lblGeographicInfluence.Location = new Point(20, 60);
            lblGeographicInfluence.Name = "lblGeographicInfluence";
            lblGeographicInfluence.Size = new Size(660, 110);
            lblGeographicInfluence.TabIndex = 1;
            lblGeographicInfluence.Text = "";
            // 
            // pnlFigures
            // 
            pnlFigures.BackColor = Color.Lavender;
            pnlFigures.Controls.Add(lblFiguresTitle);
            pnlFigures.Controls.Add(lblHistoricalFigures);
            pnlFigures.Location = new Point(50, 420);
            pnlFigures.Name = "pnlFigures";
            pnlFigures.Size = new Size(700, 120);
            pnlFigures.TabIndex = 4;
            // 
            // lblFiguresTitle
            // 
            lblFiguresTitle.AutoSize = true;
            lblFiguresTitle.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblFiguresTitle.ForeColor = Color.Purple;
            lblFiguresTitle.Location = new Point(250, 10);
            lblFiguresTitle.Name = "lblFiguresTitle";
            lblFiguresTitle.Size = new Size(200, 23);
            lblFiguresTitle.TabIndex = 0;
            lblFiguresTitle.Text = "Famous People from Here";
            // 
            // lblHistoricalFigures
            // 
            lblHistoricalFigures.Font = new Font("Comic Sans MS", 10F);
            lblHistoricalFigures.Location = new Point(20, 40);
            lblHistoricalFigures.Name = "lblHistoricalFigures";
            lblHistoricalFigures.Size = new Size(660, 70);
            lblHistoricalFigures.TabIndex = 1;
            lblHistoricalFigures.Text = "";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGreen;
            btnNext.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnNext.Location = new Point(670, 560);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 40);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next →";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LightCoral;
            btnPrevious.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnPrevious.Location = new Point(50, 560);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(80, 40);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "← Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnBackToUnit1
            // 
            btnBackToUnit1.BackColor = Color.LightBlue;
            btnBackToUnit1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnBackToUnit1.Location = new Point(350, 560);
            btnBackToUnit1.Name = "btnBackToUnit1";
            btnBackToUnit1.Size = new Size(100, 40);
            btnBackToUnit1.TabIndex = 7;
            btnBackToUnit1.Text = "Back to Unit 1";
            btnBackToUnit1.UseVisualStyleBackColor = false;
            btnBackToUnit1.Click += new System.EventHandler(this.btnBackToUnit1_Click);
            // 
            // btnToUnit2Ch2
            // 
            btnToUnit2Ch2.BackColor = Color.LightCyan;
            btnToUnit2Ch2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnToUnit2Ch2.Location = new Point(470, 560);
            btnToUnit2Ch2.Name = "btnToUnit2Ch2";
            btnToUnit2Ch2.Size = new Size(100, 40);
            btnToUnit2Ch2.TabIndex = 8;
            btnToUnit2Ch2.Text = "Ch 2: Maps";
            btnToUnit2Ch2.UseVisualStyleBackColor = false;
            btnToUnit2Ch2.Click += new System.EventHandler(this.btnToUnit2Ch2_Click);
            // 
            // Unit_2_Ch_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 620);
            Controls.Add(btnBackToUnit1);
            Controls.Add(btnToUnit2Ch2);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pnlFigures);
            Controls.Add(pnlContent);
            Controls.Add(pnlGeographicRegions);
            Controls.Add(lblStandard);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Unit_2_Ch_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TTS Components - Unit 2: Geographic Understandings";
            pnlGeographicRegions.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlFigures.ResumeLayout(false);
            pnlFigures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStandard;
        private Panel pnlGeographicRegions;
        private Button btnAmericanColonies;
        private Button btnAmericanFrontier;
        private Button btnNationalParks;
        private Button btnSouthernUS;
        private Panel pnlContent;
        private Label lblRegionName;
        private Label lblGeographicInfluence;
        private Panel pnlFigures;
        private Label lblFiguresTitle;
        private Label lblHistoricalFigures;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnBackToUnit1;
        private Button btnToUnit2Ch2;
    }
}