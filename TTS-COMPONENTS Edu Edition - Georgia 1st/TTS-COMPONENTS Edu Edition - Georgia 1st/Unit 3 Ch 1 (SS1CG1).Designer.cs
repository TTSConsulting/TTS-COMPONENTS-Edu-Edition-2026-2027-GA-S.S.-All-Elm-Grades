using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    partial class Unit_3_Ch_1__SS1CG1_
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
            pnlCharacterTraits = new Panel();
            btnFairness = new Button();
            btnRespectOthers = new Button();
            btnRespectEnvironment = new Button();
            btnCourage = new Button();
            btnEquality = new Button();
            btnTolerance = new Button();
            btnPerseverance = new Button();
            btnCommitment = new Button();
            pnlContent = new Panel();
            lblTraitName = new Label();
            lblTraitDefinition = new Label();
            lblHistoricalExample = new Label();
            lblEverydayExample = new Label();
            lblActivityPrompt = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            btnBackToUnit2Ch3 = new Button();
            btnCharacterChallenge = new Button();
            btnToUnit3Ch2 = new Button();
            pnlCharacterTraits.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(120, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(560, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Unit 3 Chapter 1: Character Heroes!";
            // 
            // lblStandard
            // 
            lblStandard.AutoSize = true;
            lblStandard.Font = new Font("Arial", 10F);
            lblStandard.Location = new Point(150, 60);
            lblStandard.Name = "lblStandard";
            lblStandard.Size = new Size(500, 16);
            lblStandard.TabIndex = 1;
            lblStandard.Text = "SS1CG1: How Historical Figures Display Positive Character Traits";
            // 
            // pnlCharacterTraits
            // 
            pnlCharacterTraits.BackColor = Color.LightGoldenrodYellow;
            pnlCharacterTraits.Controls.Add(btnFairness);
            pnlCharacterTraits.Controls.Add(btnRespectOthers);
            pnlCharacterTraits.Controls.Add(btnRespectEnvironment);
            pnlCharacterTraits.Controls.Add(btnCourage);
            pnlCharacterTraits.Controls.Add(btnEquality);
            pnlCharacterTraits.Controls.Add(btnTolerance);
            pnlCharacterTraits.Controls.Add(btnPerseverance);
            pnlCharacterTraits.Controls.Add(btnCommitment);
            pnlCharacterTraits.Location = new Point(50, 100);
            pnlCharacterTraits.Name = "pnlCharacterTraits";
            pnlCharacterTraits.Size = new Size(700, 160);
            pnlCharacterTraits.TabIndex = 2;
            // 
            // btnFairness
            // 
            btnFairness.BackColor = Color.LightGray;
            btnFairness.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnFairness.Location = new Point(20, 20);
            btnFairness.Name = "btnFairness";
            btnFairness.Size = new Size(160, 60);
            btnFairness.TabIndex = 0;
            btnFairness.Text = "Fairness";
            btnFairness.UseVisualStyleBackColor = false;
            btnFairness.Click += new System.EventHandler(this.btnFairness_Click);
            // 
            // btnRespectOthers
            // 
            btnRespectOthers.BackColor = Color.LightGray;
            btnRespectOthers.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnRespectOthers.Location = new Point(200, 20);
            btnRespectOthers.Name = "btnRespectOthers";
            btnRespectOthers.Size = new Size(160, 60);
            btnRespectOthers.TabIndex = 1;
            btnRespectOthers.Text = "Respect for Others";
            btnRespectOthers.UseVisualStyleBackColor = false;
            btnRespectOthers.Click += new System.EventHandler(this.btnRespectOthers_Click);
            // 
            // btnRespectEnvironment
            // 
            btnRespectEnvironment.BackColor = Color.LightGray;
            btnRespectEnvironment.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnRespectEnvironment.Location = new Point(380, 20);
            btnRespectEnvironment.Name = "btnRespectEnvironment";
            btnRespectEnvironment.Size = new Size(160, 60);
            btnRespectEnvironment.TabIndex = 2;
            btnRespectEnvironment.Text = "Respect for Environment";
            btnRespectEnvironment.UseVisualStyleBackColor = false;
            btnRespectEnvironment.Click += new System.EventHandler(this.btnRespectEnvironment_Click);
            // 
            // btnCourage
            // 
            btnCourage.BackColor = Color.LightGray;
            btnCourage.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnCourage.Location = new Point(560, 20);
            btnCourage.Name = "btnCourage";
            btnCourage.Size = new Size(120, 60);
            btnCourage.TabIndex = 3;
            btnCourage.Text = "Courage";
            btnCourage.UseVisualStyleBackColor = false;
            btnCourage.Click += new System.EventHandler(this.btnCourage_Click);
            // 
            // btnEquality
            // 
            btnEquality.BackColor = Color.LightGray;
            btnEquality.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnEquality.Location = new Point(20, 90);
            btnEquality.Name = "btnEquality";
            btnEquality.Size = new Size(160, 60);
            btnEquality.TabIndex = 4;
            btnEquality.Text = "Equality";
            btnEquality.UseVisualStyleBackColor = false;
            btnEquality.Click += new System.EventHandler(this.btnEquality_Click);
            // 
            // btnTolerance
            // 
            btnTolerance.BackColor = Color.LightGray;
            btnTolerance.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnTolerance.Location = new Point(200, 90);
            btnTolerance.Name = "btnTolerance";
            btnTolerance.Size = new Size(160, 60);
            btnTolerance.TabIndex = 5;
            btnTolerance.Text = "Tolerance";
            btnTolerance.UseVisualStyleBackColor = false;
            btnTolerance.Click += new System.EventHandler(this.btnTolerance_Click);
            // 
            // btnPerseverance
            // 
            btnPerseverance.BackColor = Color.LightGray;
            btnPerseverance.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnPerseverance.Location = new Point(380, 90);
            btnPerseverance.Name = "btnPerseverance";
            btnPerseverance.Size = new Size(160, 60);
            btnPerseverance.TabIndex = 6;
            btnPerseverance.Text = "Perseverance";
            btnPerseverance.UseVisualStyleBackColor = false;
            btnPerseverance.Click += new System.EventHandler(this.btnPerseverance_Click);
            // 
            // btnCommitment
            // 
            btnCommitment.BackColor = Color.LightGray;
            btnCommitment.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnCommitment.Location = new Point(560, 90);
            btnCommitment.Name = "btnCommitment";
            btnCommitment.Size = new Size(120, 60);
            btnCommitment.TabIndex = 7;
            btnCommitment.Text = "Commitment";
            btnCommitment.UseVisualStyleBackColor = false;
            btnCommitment.Click += new System.EventHandler(this.btnCommitment_Click);
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Lavender;
            pnlContent.Controls.Add(lblTraitName);
            pnlContent.Controls.Add(lblTraitDefinition);
            pnlContent.Controls.Add(lblHistoricalExample);
            pnlContent.Controls.Add(lblEverydayExample);
            pnlContent.Controls.Add(lblActivityPrompt);
            pnlContent.Location = new Point(50, 280);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(700, 220);
            pnlContent.TabIndex = 3;
            // 
            // lblTraitName
            // 
            lblTraitName.AutoSize = true;
            lblTraitName.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblTraitName.ForeColor = Color.DarkRed;
            lblTraitName.Location = new Point(20, 20);
            lblTraitName.Name = "lblTraitName";
            lblTraitName.Size = new Size(450, 30);
            lblTraitName.TabIndex = 0;
            lblTraitName.Text = "Click on a character trait above!";
            // 
            // lblTraitDefinition
            // 
            lblTraitDefinition.Font = new Font("Comic Sans MS", 11F);
            lblTraitDefinition.Location = new Point(20, 60);
            lblTraitDefinition.Name = "lblTraitDefinition";
            lblTraitDefinition.Size = new Size(660, 40);
            lblTraitDefinition.TabIndex = 1;
            // 
            // lblHistoricalExample
            // 
            lblHistoricalExample.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblHistoricalExample.ForeColor = Color.DarkBlue;
            lblHistoricalExample.Location = new Point(20, 110);
            lblHistoricalExample.Name = "lblHistoricalExample";
            lblHistoricalExample.Size = new Size(660, 30);
            lblHistoricalExample.TabIndex = 2;
            // 
            // lblEverydayExample
            // 
            lblEverydayExample.Font = new Font("Comic Sans MS", 10F);
            lblEverydayExample.ForeColor = Color.DarkGreen;
            lblEverydayExample.Location = new Point(20, 150);
            lblEverydayExample.Name = "lblEverydayExample";
            lblEverydayExample.Size = new Size(660, 30);
            lblEverydayExample.TabIndex = 3;
            // 
            // lblActivityPrompt
            // 
            lblActivityPrompt.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblActivityPrompt.ForeColor = Color.Purple;
            lblActivityPrompt.Location = new Point(20, 190);
            lblActivityPrompt.Name = "lblActivityPrompt";
            lblActivityPrompt.Size = new Size(660, 25);
            lblActivityPrompt.TabIndex = 4;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGreen;
            btnNext.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnNext.Location = new Point(670, 520);
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
            btnPrevious.Location = new Point(50, 520);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(80, 40);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "← Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnBackToUnit2Ch3
            // 
            btnBackToUnit2Ch3.BackColor = Color.LightBlue;
            btnBackToUnit2Ch3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnBackToUnit2Ch3.Location = new Point(260, 520);
            btnBackToUnit2Ch3.Name = "btnBackToUnit2Ch3";
            btnBackToUnit2Ch3.Size = new Size(120, 40);
            btnBackToUnit2Ch3.TabIndex = 6;
            btnBackToUnit2Ch3.Text = "Back to Unit 2";
            btnBackToUnit2Ch3.UseVisualStyleBackColor = false;
            btnBackToUnit2Ch3.Click += new System.EventHandler(this.btnBackToUnit2Ch3_Click);
            // 
            // btnCharacterChallenge
            // 
            btnCharacterChallenge.BackColor = Color.Gold;
            btnCharacterChallenge.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnCharacterChallenge.Location = new Point(400, 520);
            btnCharacterChallenge.Name = "btnCharacterChallenge";
            btnCharacterChallenge.Size = new Size(140, 40);
            btnCharacterChallenge.TabIndex = 7;
            btnCharacterChallenge.Text = "Character Challenge!";
            btnCharacterChallenge.UseVisualStyleBackColor = false;
            btnCharacterChallenge.Click += new System.EventHandler(this.btnCharacterChallenge_Click);
            // 
            // btnToUnit3Ch2
            // 
            btnToUnit3Ch2.BackColor = Color.LightGreen;
            btnToUnit3Ch2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnToUnit3Ch2.Location = new Point(560, 520);
            btnToUnit3Ch2.Name = "btnToUnit3Ch2";
            btnToUnit3Ch2.Size = new Size(140, 40);
            btnToUnit3Ch2.TabIndex = 8;
            btnToUnit3Ch2.Text = "Patriotic Songs!";
            btnToUnit3Ch2.UseVisualStyleBackColor = false;
            btnToUnit3Ch2.Click += new System.EventHandler(this.btnToUnit3Ch2_Click);
            // 
            // Unit_3_Ch_1__SS1CG1_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 580);
            Controls.Add(btnToUnit3Ch2);
            Controls.Add(btnCharacterChallenge);
            Controls.Add(btnBackToUnit2Ch3);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pnlContent);
            Controls.Add(pnlCharacterTraits);
            Controls.Add(lblStandard);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Unit_3_Ch_1__SS1CG1_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TTS Components - Unit 3 Ch 1: Character Traits";
            pnlCharacterTraits.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStandard;
        private Panel pnlCharacterTraits;
        private Button btnFairness;
        private Button btnRespectOthers;
        private Button btnRespectEnvironment;
        private Button btnCourage;
        private Button btnEquality;
        private Button btnTolerance;
        private Button btnPerseverance;
        private Button btnCommitment;
        private Panel pnlContent;
        private Label lblTraitName;
        private Label lblTraitDefinition;
        private Label lblHistoricalExample;
        private Label lblEverydayExample;
        private Label lblActivityPrompt;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnBackToUnit2Ch3;
        private Button btnCharacterChallenge;
        private Button btnToUnit3Ch2;
    }
}