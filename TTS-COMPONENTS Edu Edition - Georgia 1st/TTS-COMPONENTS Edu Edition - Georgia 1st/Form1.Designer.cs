using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblStandard = new Label();
            pnlHistoricalFigures = new Panel();
            btnBenjaminFranklin = new Button();
            btnThomasJefferson = new Button();
            btnMeriwetherLewis = new Button();
            btnTheodoreRoosevelt = new Button();
            btnGeorgeWashingtonCarver = new Button();
            btnRubyBridges = new Button();
            pnlContent = new Panel();
            lblFigureName = new Label();
            lblContribution = new Label();
            pnlComparison = new Panel();
            lblComparisonTitle = new Label();
            lblThenNow = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            btnToUnit2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pnlHistoricalFigures.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlComparison.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(229, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(558, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Unit 1 Chapter 1: Famous Americans";
            // 
            // lblStandard
            // 
            lblStandard.AutoSize = true;
            lblStandard.Font = new Font("Arial", 10F);
            lblStandard.Location = new Point(286, 80);
            lblStandard.Name = "lblStandard";
            lblStandard.Size = new Size(345, 19);
            lblStandard.TabIndex = 1;
            lblStandard.Text = "SS1H1: Historical Figures in American History";
            // 
            // pnlHistoricalFigures
            // 
            pnlHistoricalFigures.BackColor = Color.LightBlue;
            pnlHistoricalFigures.Controls.Add(btnBenjaminFranklin);
            pnlHistoricalFigures.Controls.Add(btnThomasJefferson);
            pnlHistoricalFigures.Controls.Add(btnMeriwetherLewis);
            pnlHistoricalFigures.Controls.Add(btnTheodoreRoosevelt);
            pnlHistoricalFigures.Controls.Add(btnGeorgeWashingtonCarver);
            pnlHistoricalFigures.Controls.Add(btnRubyBridges);
            pnlHistoricalFigures.Location = new Point(57, 133);
            pnlHistoricalFigures.Margin = new Padding(3, 4, 3, 4);
            pnlHistoricalFigures.Name = "pnlHistoricalFigures";
            pnlHistoricalFigures.Size = new Size(828, 160);
            pnlHistoricalFigures.TabIndex = 2;
            // 
            // btnBenjaminFranklin
            // 
            btnBenjaminFranklin.BackColor = Color.Yellow;
            btnBenjaminFranklin.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnBenjaminFranklin.Location = new Point(23, 27);
            btnBenjaminFranklin.Margin = new Padding(3, 4, 3, 4);
            btnBenjaminFranklin.Name = "btnBenjaminFranklin";
            btnBenjaminFranklin.Size = new Size(114, 107);
            btnBenjaminFranklin.TabIndex = 0;
            btnBenjaminFranklin.Text = "Benjamin Franklin";
            btnBenjaminFranklin.UseVisualStyleBackColor = false;
            btnBenjaminFranklin.Click += btnBenjaminFranklin_Click;
            // 
            // btnThomasJefferson
            // 
            btnThomasJefferson.BackColor = Color.LightGreen;
            btnThomasJefferson.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnThomasJefferson.Location = new Point(160, 27);
            btnThomasJefferson.Margin = new Padding(3, 4, 3, 4);
            btnThomasJefferson.Name = "btnThomasJefferson";
            btnThomasJefferson.Size = new Size(114, 107);
            btnThomasJefferson.TabIndex = 1;
            btnThomasJefferson.Text = "Thomas Jefferson";
            btnThomasJefferson.UseVisualStyleBackColor = false;
            btnThomasJefferson.Click += btnThomasJefferson_Click;
            // 
            // btnMeriwetherLewis
            // 
            btnMeriwetherLewis.BackColor = Color.Orange;
            btnMeriwetherLewis.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnMeriwetherLewis.Location = new Point(297, 27);
            btnMeriwetherLewis.Margin = new Padding(3, 4, 3, 4);
            btnMeriwetherLewis.Name = "btnMeriwetherLewis";
            btnMeriwetherLewis.Size = new Size(114, 107);
            btnMeriwetherLewis.TabIndex = 2;
            btnMeriwetherLewis.Text = "Meriwether Lewis";
            btnMeriwetherLewis.UseVisualStyleBackColor = false;
            btnMeriwetherLewis.Click += btnMeriwetherLewis_Click;
            // 
            // btnTheodoreRoosevelt
            // 
            btnTheodoreRoosevelt.BackColor = Color.LightCoral;
            btnTheodoreRoosevelt.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnTheodoreRoosevelt.Location = new Point(434, 27);
            btnTheodoreRoosevelt.Margin = new Padding(3, 4, 3, 4);
            btnTheodoreRoosevelt.Name = "btnTheodoreRoosevelt";
            btnTheodoreRoosevelt.Size = new Size(114, 107);
            btnTheodoreRoosevelt.TabIndex = 3;
            btnTheodoreRoosevelt.Text = "Theodore Roosevelt";
            btnTheodoreRoosevelt.UseVisualStyleBackColor = false;
            btnTheodoreRoosevelt.Click += btnTheodoreRoosevelt_Click;
            // 
            // btnGeorgeWashingtonCarver
            // 
            btnGeorgeWashingtonCarver.BackColor = Color.Violet;
            btnGeorgeWashingtonCarver.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnGeorgeWashingtonCarver.Location = new Point(571, 27);
            btnGeorgeWashingtonCarver.Margin = new Padding(3, 4, 3, 4);
            btnGeorgeWashingtonCarver.Name = "btnGeorgeWashingtonCarver";
            btnGeorgeWashingtonCarver.Size = new Size(114, 107);
            btnGeorgeWashingtonCarver.TabIndex = 4;
            btnGeorgeWashingtonCarver.Text = "George Washington Carver";
            btnGeorgeWashingtonCarver.UseVisualStyleBackColor = false;
            btnGeorgeWashingtonCarver.Click += btnGeorgeWashingtonCarver_Click;
            // 
            // btnRubyBridges
            // 
            btnRubyBridges.BackColor = Color.Pink;
            btnRubyBridges.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnRubyBridges.Location = new Point(709, 27);
            btnRubyBridges.Margin = new Padding(3, 4, 3, 4);
            btnRubyBridges.Name = "btnRubyBridges";
            btnRubyBridges.Size = new Size(114, 107);
            btnRubyBridges.TabIndex = 5;
            btnRubyBridges.Text = "Ruby Bridges";
            btnRubyBridges.UseVisualStyleBackColor = false;
            btnRubyBridges.Click += btnRubyBridges_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Controls.Add(lblFigureName);
            pnlContent.Controls.Add(lblContribution);
            pnlContent.Location = new Point(57, 320);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(800, 200);
            pnlContent.TabIndex = 3;
            // 
            // lblFigureName
            // 
            lblFigureName.AutoSize = true;
            lblFigureName.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            lblFigureName.ForeColor = Color.DarkGreen;
            lblFigureName.Location = new Point(23, 27);
            lblFigureName.Name = "lblFigureName";
            lblFigureName.Size = new Size(537, 35);
            lblFigureName.TabIndex = 0;
            lblFigureName.Text = "Click on a person above to learn about them!";
            // 
            // lblContribution
            // 
            lblContribution.Font = new Font("Comic Sans MS", 11F);
            lblContribution.Location = new Point(23, 80);
            lblContribution.Name = "lblContribution";
            lblContribution.Size = new Size(754, 107);
            lblContribution.TabIndex = 1;
            // 
            // pnlComparison
            // 
            pnlComparison.BackColor = Color.LightYellow;
            pnlComparison.Controls.Add(lblComparisonTitle);
            pnlComparison.Controls.Add(lblThenNow);
            pnlComparison.Location = new Point(57, 547);
            pnlComparison.Margin = new Padding(3, 4, 3, 4);
            pnlComparison.Name = "pnlComparison";
            pnlComparison.Size = new Size(800, 160);
            pnlComparison.TabIndex = 4;
            // 
            // lblComparisonTitle
            // 
            lblComparisonTitle.AutoSize = true;
            lblComparisonTitle.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblComparisonTitle.ForeColor = Color.DarkOrange;
            lblComparisonTitle.Location = new Point(286, 13);
            lblComparisonTitle.Name = "lblComparisonTitle";
            lblComparisonTitle.Size = new Size(269, 29);
            lblComparisonTitle.TabIndex = 0;
            lblComparisonTitle.Text = "Then and Now Comparison";
            // 
            // lblThenNow
            // 
            lblThenNow.Font = new Font("Comic Sans MS", 10F);
            lblThenNow.Location = new Point(23, 53);
            lblThenNow.Name = "lblThenNow";
            lblThenNow.Size = new Size(754, 93);
            lblThenNow.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGreen;
            btnNext.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnNext.Location = new Point(766, 733);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(91, 53);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next →";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LightCoral;
            btnPrevious.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnPrevious.Location = new Point(57, 733);
            btnPrevious.Margin = new Padding(3, 4, 3, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(91, 53);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "← Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnToUnit2
            // 
            btnToUnit2.BackColor = Color.LightBlue;
            btnToUnit2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnToUnit2.Location = new Point(350, 733);
            btnToUnit2.Margin = new Padding(3, 4, 3, 4);
            btnToUnit2.Name = "btnToUnit2";
            btnToUnit2.Size = new Size(100, 53);
            btnToUnit2.TabIndex = 7;
            btnToUnit2.Text = "Unit 2: Places";
            btnToUnit2.UseVisualStyleBackColor = false;
            btnToUnit2.Click += btnToUnit2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(539, 7);
            label1.Name = "label1";
            label1.Size = new Size(402, 20);
            label1.TabIndex = 8;
            label1.Text = "If you want to clsoe all the tabs at once, click this 'X' Buttion";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(885, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(56, 10);
            panel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(944, 800);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnToUnit2);
            Controls.Add(pnlComparison);
            Controls.Add(pnlContent);
            Controls.Add(pnlHistoricalFigures);
            Controls.Add(lblStandard);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TTS Components - Georgia 1st Grade Social Studies";
            pnlHistoricalFigures.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlComparison.ResumeLayout(false);
            pnlComparison.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Panel pnlHistoricalFigures;
        private System.Windows.Forms.Button btnBenjaminFranklin;
        private System.Windows.Forms.Button btnThomasJefferson;
        private System.Windows.Forms.Button btnMeriwetherLewis;
        private System.Windows.Forms.Button btnTheodoreRoosevelt;
        private System.Windows.Forms.Button btnGeorgeWashingtonCarver;
        private System.Windows.Forms.Button btnRubyBridges;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblFigureName;
        private System.Windows.Forms.Label lblContribution;
        private System.Windows.Forms.Panel pnlComparison;
        private System.Windows.Forms.Label lblComparisonTitle;
        private System.Windows.Forms.Label lblThenNow;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnToUnit2;
        private Label label1;
        private Panel panel1;
    }
}
