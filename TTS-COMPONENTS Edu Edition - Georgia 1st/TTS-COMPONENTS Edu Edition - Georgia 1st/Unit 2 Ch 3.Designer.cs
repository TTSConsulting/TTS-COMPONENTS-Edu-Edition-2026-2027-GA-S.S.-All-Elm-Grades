using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    partial class Unit_2_Ch_3
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
            pnlFeatureButtons = new Panel();
            btnContinents = new Button();
            btnOceans = new Button();
            btnMountains = new Button();
            btnDeserts = new Button();
            btnValleys = new Button();
            btnCoasts = new Button();
            pnlContent = new Panel();
            lblFeatureName = new Label();
            lblFeatureType = new Label();
            lblFeatureDescription = new Label();
            lblFeatureExamples = new Label();
            lblGeorgiaConnection = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            btnBackToUnit2Ch2 = new Button();
            btnExploreMap = new Button();
            btnToUnit3Ch1 = new Button();
            pnlFeatureButtons.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(150, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Unit 2 Chapter 3: Earth's Amazing Features";
            // 
            // lblStandard
            // 
            lblStandard.AutoSize = true;
            lblStandard.Font = new Font("Arial", 10F);
            lblStandard.Location = new Point(200, 60);
            lblStandard.Name = "lblStandard";
            lblStandard.Size = new Size(400, 16);
            lblStandard.TabIndex = 1;
            lblStandard.Text = "SS1G3: Locate Major Topographical Features of Earth's Surface";
            // 
            // pnlFeatureButtons
            // 
            pnlFeatureButtons.BackColor = Color.LightSteelBlue;
            pnlFeatureButtons.Controls.Add(btnContinents);
            pnlFeatureButtons.Controls.Add(btnOceans);
            pnlFeatureButtons.Controls.Add(btnMountains);
            pnlFeatureButtons.Controls.Add(btnDeserts);
            pnlFeatureButtons.Controls.Add(btnValleys);
            pnlFeatureButtons.Controls.Add(btnCoasts);
            pnlFeatureButtons.Location = new Point(50, 100);
            pnlFeatureButtons.Name = "pnlFeatureButtons";
            pnlFeatureButtons.Size = new Size(700, 120);
            pnlFeatureButtons.TabIndex = 2;
            // 
            // btnContinents
            // 
            btnContinents.BackColor = Color.LightGreen;
            btnContinents.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnContinents.Location = new Point(20, 20);
            btnContinents.Name = "btnContinents";
            btnContinents.Size = new Size(100, 80);
            btnContinents.TabIndex = 0;
            btnContinents.Text = "Continents";
            btnContinents.UseVisualStyleBackColor = false;
            btnContinents.Click += new System.EventHandler(this.btnContinents_Click);
            // 
            // btnOceans
            // 
            btnOceans.BackColor = Color.LightBlue;
            btnOceans.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnOceans.Location = new Point(140, 20);
            btnOceans.Name = "btnOceans";
            btnOceans.Size = new Size(100, 80);
            btnOceans.TabIndex = 1;
            btnOceans.Text = "Oceans";
            btnOceans.UseVisualStyleBackColor = false;
            btnOceans.Click += new System.EventHandler(this.btnOceans_Click);
            // 
            // btnMountains
            // 
            btnMountains.BackColor = Color.LightGray;
            btnMountains.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnMountains.Location = new Point(260, 20);
            btnMountains.Name = "btnMountains";
            btnMountains.Size = new Size(100, 80);
            btnMountains.TabIndex = 2;
            btnMountains.Text = "Mountains";
            btnMountains.UseVisualStyleBackColor = false;
            btnMountains.Click += new System.EventHandler(this.btnMountains_Click);
            // 
            // btnDeserts
            // 
            btnDeserts.BackColor = Color.Gold;
            btnDeserts.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnDeserts.Location = new Point(380, 20);
            btnDeserts.Name = "btnDeserts";
            btnDeserts.Size = new Size(100, 80);
            btnDeserts.TabIndex = 3;
            btnDeserts.Text = "Deserts";
            btnDeserts.UseVisualStyleBackColor = false;
            btnDeserts.Click += new System.EventHandler(this.btnDeserts_Click);
            // 
            // btnValleys
            // 
            btnValleys.BackColor = Color.LightSalmon;
            btnValleys.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnValleys.Location = new Point(500, 20);
            btnValleys.Name = "btnValleys";
            btnValleys.Size = new Size(100, 80);
            btnValleys.TabIndex = 4;
            btnValleys.Text = "Valleys";
            btnValleys.UseVisualStyleBackColor = false;
            btnValleys.Click += new System.EventHandler(this.btnValleys_Click);
            // 
            // btnCoasts
            // 
            btnCoasts.BackColor = Color.LightCyan;
            btnCoasts.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnCoasts.Location = new Point(610, 20);
            btnCoasts.Name = "btnCoasts";
            btnCoasts.Size = new Size(70, 80);
            btnCoasts.TabIndex = 5;
            btnCoasts.Text = "Coasts";
            btnCoasts.UseVisualStyleBackColor = false;
            btnCoasts.Click += new System.EventHandler(this.btnCoasts_Click);
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Ivory;
            pnlContent.Controls.Add(lblFeatureName);
            pnlContent.Controls.Add(lblFeatureType);
            pnlContent.Controls.Add(lblFeatureDescription);
            pnlContent.Controls.Add(lblFeatureExamples);
            pnlContent.Controls.Add(lblGeorgiaConnection);
            pnlContent.Location = new Point(50, 240);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(700, 250);
            pnlContent.TabIndex = 3;
            // 
            // lblFeatureName
            // 
            lblFeatureName.AutoSize = true;
            lblFeatureName.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblFeatureName.ForeColor = Color.DarkRed;
            lblFeatureName.Location = new Point(20, 20);
            lblFeatureName.Name = "lblFeatureName";
            lblFeatureName.Size = new Size(400, 30);
            lblFeatureName.TabIndex = 0;
            lblFeatureName.Text = "Click on a feature above to learn!";
            // 
            // lblFeatureType
            // 
            lblFeatureType.AutoSize = true;
            lblFeatureType.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblFeatureType.ForeColor = Color.DarkBlue;
            lblFeatureType.Location = new Point(20, 60);
            lblFeatureType.Name = "lblFeatureType";
            lblFeatureType.Size = new Size(0, 23);
            lblFeatureType.TabIndex = 1;
            // 
            // lblFeatureDescription
            // 
            lblFeatureDescription.Font = new Font("Comic Sans MS", 11F);
            lblFeatureDescription.Location = new Point(20, 90);
            lblFeatureDescription.Name = "lblFeatureDescription";
            lblFeatureDescription.Size = new Size(660, 50);
            lblFeatureDescription.TabIndex = 2;
            // 
            // lblFeatureExamples
            // 
            lblFeatureExamples.Font = new Font("Comic Sans MS", 10F);
            lblFeatureExamples.ForeColor = Color.DarkGreen;
            lblFeatureExamples.Location = new Point(20, 150);
            lblFeatureExamples.Name = "lblFeatureExamples";
            lblFeatureExamples.Size = new Size(660, 40);
            lblFeatureExamples.TabIndex = 3;
            // 
            // lblGeorgiaConnection
            // 
            lblGeorgiaConnection.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblGeorgiaConnection.ForeColor = Color.Purple;
            lblGeorgiaConnection.Location = new Point(20, 200);
            lblGeorgiaConnection.Name = "lblGeorgiaConnection";
            lblGeorgiaConnection.Size = new Size(660, 40);
            lblGeorgiaConnection.TabIndex = 4;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGreen;
            btnNext.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnNext.Location = new Point(670, 510);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 40);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next →";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LightCoral;
            btnPrevious.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnPrevious.Location = new Point(50, 510);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(80, 40);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "← Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnBackToUnit2Ch2
            // 
            btnBackToUnit2Ch2.BackColor = Color.LightBlue;
            btnBackToUnit2Ch2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnBackToUnit2Ch2.Location = new Point(280, 510);
            btnBackToUnit2Ch2.Name = "btnBackToUnit2Ch2";
            btnBackToUnit2Ch2.Size = new Size(120, 40);
            btnBackToUnit2Ch2.TabIndex = 6;
            btnBackToUnit2Ch2.Text = "Back to Ch 2";
            btnBackToUnit2Ch2.UseVisualStyleBackColor = false;
            btnBackToUnit2Ch2.Click += new System.EventHandler(this.btnBackToUnit2Ch2_Click);
            // 
            // btnExploreMap
            // 
            btnExploreMap.BackColor = Color.LightYellow;
            btnExploreMap.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnExploreMap.Location = new Point(420, 510);
            btnExploreMap.Name = "btnExploreMap";
            btnExploreMap.Size = new Size(120, 40);
            btnExploreMap.TabIndex = 7;
            btnExploreMap.Text = "Explore Map!";
            btnExploreMap.UseVisualStyleBackColor = false;
            btnExploreMap.Click += new System.EventHandler(this.btnExploreMap_Click);
            // 
            // btnToUnit3Ch1
            // 
            btnToUnit3Ch1.BackColor = Color.LightPink;
            btnToUnit3Ch1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnToUnit3Ch1.Location = new Point(560, 510);
            btnToUnit3Ch1.Name = "btnToUnit3Ch1";
            btnToUnit3Ch1.Size = new Size(120, 40);
            btnToUnit3Ch1.TabIndex = 8;
            btnToUnit3Ch1.Text = "Unit 3: Character";
            btnToUnit3Ch1.UseVisualStyleBackColor = false;
            btnToUnit3Ch1.Click += new System.EventHandler(this.btnToUnit3Ch1_Click);
            // 
            // Unit_2_Ch_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 570);
            Controls.Add(btnExploreMap);
            Controls.Add(btnToUnit3Ch1);
            Controls.Add(btnBackToUnit2Ch2);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pnlContent);
            Controls.Add(pnlFeatureButtons);
            Controls.Add(lblStandard);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Unit_2_Ch_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TTS Components - Unit 2 Ch 3: Earth's Features";
            pnlFeatureButtons.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStandard;
        private Panel pnlFeatureButtons;
        private Button btnContinents;
        private Button btnOceans;
        private Button btnMountains;
        private Button btnDeserts;
        private Button btnValleys;
        private Button btnCoasts;
        private Panel pnlContent;
        private Label lblFeatureName;
        private Label lblFeatureType;
        private Label lblFeatureDescription;
        private Label lblFeatureExamples;
        private Label lblGeorgiaConnection;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnBackToUnit2Ch2;
        private Button btnExploreMap;
        private Button btnToUnit3Ch1;
    }
}