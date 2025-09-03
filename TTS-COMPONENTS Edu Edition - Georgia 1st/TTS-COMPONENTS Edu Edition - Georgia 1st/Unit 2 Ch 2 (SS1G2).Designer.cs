using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    partial class Unit_2_Ch_2__SS1G2_
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
            pnlMapLevels = new Panel();
            btnCity = new Button();
            btnCounty = new Button();
            btnState = new Button();
            btnCountry = new Button();
            btnContinent = new Button();
            pnlMapDisplay = new Panel();
            lblLocationName = new Label();
            lblLocationInfo = new Label();
            btnViewOnMap = new Button();
            pnlNavigation = new Panel();
            btnNext = new Button();
            btnPrevious = new Button();
            btnBackToUnit2Ch1 = new Button();
            btnToUnit2Ch3 = new Button();
            pnlMapLevels.SuspendLayout();
            pnlMapDisplay.SuspendLayout();
            pnlNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(206, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(493, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Unit 2 Chapter 2: Where Am I?";
            // 
            // lblStandard
            // 
            lblStandard.AutoSize = true;
            lblStandard.Font = new Font("Arial", 10F);
            lblStandard.Location = new Point(229, 80);
            lblStandard.Name = "lblStandard";
            lblStandard.Size = new Size(389, 19);
            lblStandard.TabIndex = 1;
            lblStandard.Text = "SS1G2: Identify and Locate Your Place in the World";
            // 
            // pnlMapLevels
            // 
            pnlMapLevels.BackColor = Color.LightSkyBlue;
            pnlMapLevels.Controls.Add(btnCity);
            pnlMapLevels.Controls.Add(btnCounty);
            pnlMapLevels.Controls.Add(btnState);
            pnlMapLevels.Controls.Add(btnCountry);
            pnlMapLevels.Controls.Add(btnContinent);
            pnlMapLevels.Location = new Point(57, 133);
            pnlMapLevels.Margin = new Padding(3, 4, 3, 4);
            pnlMapLevels.Name = "pnlMapLevels";
            pnlMapLevels.Size = new Size(800, 133);
            pnlMapLevels.TabIndex = 2;
            // 
            // btnCity
            // 
            btnCity.BackColor = Color.LightGreen;
            btnCity.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnCity.Location = new Point(23, 27);
            btnCity.Margin = new Padding(3, 4, 3, 4);
            btnCity.Name = "btnCity";
            btnCity.Size = new Size(137, 80);
            btnCity.TabIndex = 0;
            btnCity.Text = "My City";
            btnCity.UseVisualStyleBackColor = false;
            btnCity.Click += btnCity_Click;
            // 
            // btnCounty
            // 
            btnCounty.BackColor = Color.Yellow;
            btnCounty.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnCounty.Location = new Point(177, 27);
            btnCounty.Margin = new Padding(3, 4, 3, 4);
            btnCounty.Name = "btnCounty";
            btnCounty.Size = new Size(137, 80);
            btnCounty.TabIndex = 1;
            btnCounty.Text = "My County";
            btnCounty.UseVisualStyleBackColor = false;
            btnCounty.Click += btnCounty_Click;
            // 
            // btnState
            // 
            btnState.BackColor = Color.Orange;
            btnState.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnState.Location = new Point(331, 27);
            btnState.Margin = new Padding(3, 4, 3, 4);
            btnState.Name = "btnState";
            btnState.Size = new Size(137, 80);
            btnState.TabIndex = 2;
            btnState.Text = "My State";
            btnState.UseVisualStyleBackColor = false;
            btnState.Click += btnState_Click;
            // 
            // btnCountry
            // 
            btnCountry.BackColor = Color.LightCoral;
            btnCountry.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnCountry.Location = new Point(486, 27);
            btnCountry.Margin = new Padding(3, 4, 3, 4);
            btnCountry.Name = "btnCountry";
            btnCountry.Size = new Size(137, 80);
            btnCountry.TabIndex = 3;
            btnCountry.Text = "My Country";
            btnCountry.UseVisualStyleBackColor = false;
            btnCountry.Click += btnCountry_Click;
            // 
            // btnContinent
            // 
            btnContinent.BackColor = Color.Violet;
            btnContinent.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnContinent.Location = new Point(640, 27);
            btnContinent.Margin = new Padding(3, 4, 3, 4);
            btnContinent.Name = "btnContinent";
            btnContinent.Size = new Size(137, 80);
            btnContinent.TabIndex = 4;
            btnContinent.Text = "My Continent";
            btnContinent.UseVisualStyleBackColor = false;
            btnContinent.Click += btnContinent_Click;
            // 
            // pnlMapDisplay
            // 
            pnlMapDisplay.BackColor = Color.AliceBlue;
            pnlMapDisplay.Controls.Add(lblLocationName);
            pnlMapDisplay.Controls.Add(lblLocationInfo);
            pnlMapDisplay.Controls.Add(btnViewOnMap);
            pnlMapDisplay.Location = new Point(57, 293);
            pnlMapDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlMapDisplay.Name = "pnlMapDisplay";
            pnlMapDisplay.Size = new Size(800, 333);
            pnlMapDisplay.TabIndex = 3;
            // 
            // lblLocationName
            // 
            lblLocationName.AutoSize = true;
            lblLocationName.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblLocationName.ForeColor = Color.DarkGreen;
            lblLocationName.Location = new Point(23, 27);
            lblLocationName.Name = "lblLocationName";
            lblLocationName.Size = new Size(437, 38);
            lblLocationName.TabIndex = 0;
            lblLocationName.Text = "Click a button above to explore!";
            // 
            // lblLocationInfo
            // 
            lblLocationInfo.Font = new Font("Comic Sans MS", 12F);
            lblLocationInfo.Location = new Point(23, 93);
            lblLocationInfo.Name = "lblLocationInfo";
            lblLocationInfo.Size = new Size(754, 160);
            lblLocationInfo.TabIndex = 1;
            // 
            // btnViewOnMap
            // 
            btnViewOnMap.BackColor = Color.LightBlue;
            btnViewOnMap.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold);
            btnViewOnMap.Location = new Point(299, 276);
            btnViewOnMap.Margin = new Padding(3, 4, 3, 4);
            btnViewOnMap.Name = "btnViewOnMap";
            btnViewOnMap.Size = new Size(197, 53);
            btnViewOnMap.TabIndex = 2;
            btnViewOnMap.Text = "🗺️ View on Map";
            btnViewOnMap.UseVisualStyleBackColor = false;
            btnViewOnMap.Click += btnViewOnMap_Click;
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.Lavender;
            pnlNavigation.Controls.Add(btnNext);
            pnlNavigation.Controls.Add(btnPrevious);
            pnlNavigation.Controls.Add(btnBackToUnit2Ch1);
            pnlNavigation.Controls.Add(btnToUnit2Ch3);
            pnlNavigation.Location = new Point(57, 653);
            pnlNavigation.Margin = new Padding(3, 4, 3, 4);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(800, 93);
            pnlNavigation.TabIndex = 4;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGreen;
            btnNext.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnNext.Location = new Point(686, 20);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(91, 53);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next →";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LightCoral;
            btnPrevious.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnPrevious.Location = new Point(23, 20);
            btnPrevious.Margin = new Padding(3, 4, 3, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(91, 53);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "← Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnBackToUnit2Ch1
            // 
            btnBackToUnit2Ch1.BackColor = Color.LightYellow;
            btnBackToUnit2Ch1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnBackToUnit2Ch1.Location = new Point(343, 20);
            btnBackToUnit2Ch1.Margin = new Padding(3, 4, 3, 4);
            btnBackToUnit2Ch1.Name = "btnBackToUnit2Ch1";
            btnBackToUnit2Ch1.Size = new Size(114, 53);
            btnBackToUnit2Ch1.TabIndex = 2;
            btnBackToUnit2Ch1.Text = "Back to Ch 1";
            btnBackToUnit2Ch1.UseVisualStyleBackColor = false;
            btnBackToUnit2Ch1.Click += btnBackToUnit2Ch1_Click;
            // 
            // btnToUnit2Ch3
            // 
            btnToUnit2Ch3.BackColor = Color.LightCyan;
            btnToUnit2Ch3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnToUnit2Ch3.Location = new Point(470, 20);
            btnToUnit2Ch3.Margin = new Padding(3, 4, 3, 4);
            btnToUnit2Ch3.Name = "btnToUnit2Ch3";
            btnToUnit2Ch3.Size = new Size(114, 53);
            btnToUnit2Ch3.TabIndex = 3;
            btnToUnit2Ch3.Text = "Ch 3: Features";
            btnToUnit2Ch3.UseVisualStyleBackColor = false;
            btnToUnit2Ch3.Click += new System.EventHandler(this.btnToUnit2Ch3_Click);
            // 
            // Unit_2_Ch_2__SS1G2_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(914, 773);
            Controls.Add(pnlNavigation);
            Controls.Add(pnlMapDisplay);
            Controls.Add(pnlMapLevels);
            Controls.Add(lblStandard);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Unit_2_Ch_2__SS1G2_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TTS Components - Unit 2 Ch 2: Geographic Location";
            pnlMapLevels.ResumeLayout(false);
            pnlMapDisplay.ResumeLayout(false);
            pnlMapDisplay.PerformLayout();
            pnlNavigation.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStandard;
        private Panel pnlMapLevels;
        private Button btnCity;
        private Button btnCounty;
        private Button btnState;
        private Button btnCountry;
        private Button btnContinent;
        private Panel pnlMapDisplay;
        private Label lblLocationName;
        private Label lblLocationInfo;
        private Button btnViewOnMap;
        private Panel pnlNavigation;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnBackToUnit2Ch1;
        private Button btnToUnit2Ch3;
    }
}