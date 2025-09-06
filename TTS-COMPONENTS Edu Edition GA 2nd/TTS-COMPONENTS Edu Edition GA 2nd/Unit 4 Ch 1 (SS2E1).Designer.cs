namespace TTS_COMPONENTS_Edu_Edition_GA_2nd
{
    partial class Unit_4_Ch_1__SS2E1_
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
            TitleLabel = new Label();
            StandardLabel = new Label();
            InstructionLabel = new Label();
            ConceptsGroupBox = new GroupBox();
            btnScarcity = new Button();
            btnChoices = new Button();
            btnOpportunityCost = new Button();
            btnResources = new Button();
            ConceptExplanationLabel = new Label();
            ScenariosGroupBox = new GroupBox();
            ScenarioTitleLabel = new Label();
            ScenarioDescriptionLabel = new Label();
            Choice1Button = new Button();
            Choice2Button = new Button();
            Choice3Button = new Button();
            ScarcityLabel = new Label();
            OpportunityCostLabel = new Label();
            LessonLabel = new Label();
            NavigationGroupBox = new GroupBox();
            PreviousButton = new Button();
            NextButton = new Button();
            ProgressLabel = new Label();
            BackToMenuButton = new Button();
            Unit4Ch2Button = new Button();
            ConceptsGroupBox.SuspendLayout();
            ScenariosGroupBox.SuspendLayout();
            NavigationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.DarkBlue;
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(549, 37);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Unit 4 Chapter 1: Economics - Scarcity & Choices";
            // 
            // StandardLabel
            // 
            StandardLabel.AutoSize = true;
            StandardLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            StandardLabel.ForeColor = Color.DarkGreen;
            StandardLabel.Location = new Point(12, 46);
            StandardLabel.Name = "StandardLabel";
            StandardLabel.Size = new Size(661, 21);
            StandardLabel.TabIndex = 1;
            StandardLabel.Text = "SS2E1: Explain that because of scarcity, people must make choices that result in opportunity costs.";
            // 
            // InstructionLabel
            // 
            InstructionLabel.AutoSize = true;
            InstructionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InstructionLabel.Location = new Point(12, 80);
            InstructionLabel.Name = "InstructionLabel";
            InstructionLabel.Size = new Size(584, 21);
            InstructionLabel.TabIndex = 2;
            InstructionLabel.Text = "Learn about economics! First explore concepts, then practice making choices with scenarios.";
            // 
            // ConceptsGroupBox
            // 
            ConceptsGroupBox.Controls.Add(btnScarcity);
            ConceptsGroupBox.Controls.Add(btnChoices);
            ConceptsGroupBox.Controls.Add(btnOpportunityCost);
            ConceptsGroupBox.Controls.Add(btnResources);
            ConceptsGroupBox.Controls.Add(ConceptExplanationLabel);
            ConceptsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConceptsGroupBox.Location = new Point(12, 110);
            ConceptsGroupBox.Name = "ConceptsGroupBox";
            ConceptsGroupBox.Size = new Size(950, 250);
            ConceptsGroupBox.TabIndex = 3;
            ConceptsGroupBox.TabStop = false;
            ConceptsGroupBox.Text = "💡 Economics Concepts";
            // 
            // btnScarcity
            // 
            btnScarcity.BackColor = Color.Orange;
            btnScarcity.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnScarcity.ForeColor = Color.White;
            btnScarcity.Location = new Point(20, 30);
            btnScarcity.Name = "btnScarcity";
            btnScarcity.Size = new Size(120, 50);
            btnScarcity.TabIndex = 0;
            btnScarcity.Text = "💰 Scarcity";
            btnScarcity.UseVisualStyleBackColor = false;
            btnScarcity.Click += ConceptButton_Click;
            // 
            // btnChoices
            // 
            btnChoices.BackColor = Color.Green;
            btnChoices.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnChoices.ForeColor = Color.White;
            btnChoices.Location = new Point(150, 30);
            btnChoices.Name = "btnChoices";
            btnChoices.Size = new Size(120, 50);
            btnChoices.TabIndex = 1;
            btnChoices.Text = "🤔 Choices";
            btnChoices.UseVisualStyleBackColor = false;
            btnChoices.Click += ConceptButton_Click;
            // 
            // btnOpportunityCost
            // 
            btnOpportunityCost.BackColor = Color.Red;
            btnOpportunityCost.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpportunityCost.ForeColor = Color.White;
            btnOpportunityCost.Location = new Point(280, 30);
            btnOpportunityCost.Name = "btnOpportunityCost";
            btnOpportunityCost.Size = new Size(140, 50);
            btnOpportunityCost.TabIndex = 2;
            btnOpportunityCost.Text = "🔄 Opportunity Cost";
            btnOpportunityCost.UseVisualStyleBackColor = false;
            btnOpportunityCost.Click += ConceptButton_Click;
            // 
            // btnResources
            // 
            btnResources.BackColor = Color.Purple;
            btnResources.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnResources.ForeColor = Color.White;
            btnResources.Location = new Point(430, 30);
            btnResources.Name = "btnResources";
            btnResources.Size = new Size(120, 50);
            btnResources.TabIndex = 3;
            btnResources.Text = "📦 Resources";
            btnResources.UseVisualStyleBackColor = false;
            btnResources.Click += ConceptButton_Click;
            // 
            // ConceptExplanationLabel
            // 
            ConceptExplanationLabel.BorderStyle = BorderStyle.FixedSingle;
            ConceptExplanationLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ConceptExplanationLabel.Location = new Point(20, 90);
            ConceptExplanationLabel.Name = "ConceptExplanationLabel";
            ConceptExplanationLabel.Size = new Size(910, 150);
            ConceptExplanationLabel.TabIndex = 4;
            ConceptExplanationLabel.Text = "Click on a concept above to learn about it!";
            ConceptExplanationLabel.TextAlign = ContentAlignment.TopLeft;
            // 
            // ScenariosGroupBox
            // 
            ScenariosGroupBox.Controls.Add(ScenarioTitleLabel);
            ScenariosGroupBox.Controls.Add(ScenarioDescriptionLabel);
            ScenariosGroupBox.Controls.Add(Choice1Button);
            ScenariosGroupBox.Controls.Add(Choice2Button);
            ScenariosGroupBox.Controls.Add(Choice3Button);
            ScenariosGroupBox.Controls.Add(ScarcityLabel);
            ScenariosGroupBox.Controls.Add(OpportunityCostLabel);
            ScenariosGroupBox.Controls.Add(LessonLabel);
            ScenariosGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ScenariosGroupBox.Location = new Point(12, 370);
            ScenariosGroupBox.Name = "ScenariosGroupBox";
            ScenariosGroupBox.Size = new Size(950, 280);
            ScenariosGroupBox.TabIndex = 4;
            ScenariosGroupBox.TabStop = false;
            ScenariosGroupBox.Text = "🎯 Choice Scenarios";
            // 
            // ScenarioTitleLabel
            // 
            ScenarioTitleLabel.AutoSize = true;
            ScenarioTitleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ScenarioTitleLabel.ForeColor = Color.DarkBlue;
            ScenarioTitleLabel.Location = new Point(20, 30);
            ScenarioTitleLabel.Name = "ScenarioTitleLabel";
            ScenarioTitleLabel.Size = new Size(131, 25);
            ScenarioTitleLabel.TabIndex = 0;
            ScenarioTitleLabel.Text = "Scenario Title";
            // 
            // ScenarioDescriptionLabel
            // 
            ScenarioDescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ScenarioDescriptionLabel.Location = new Point(20, 60);
            ScenarioDescriptionLabel.Name = "ScenarioDescriptionLabel";
            ScenarioDescriptionLabel.Size = new Size(910, 40);
            ScenarioDescriptionLabel.TabIndex = 1;
            ScenarioDescriptionLabel.Text = "Scenario description will appear here.";
            // 
            // Choice1Button
            // 
            Choice1Button.BackColor = Color.LightBlue;
            Choice1Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Choice1Button.Location = new Point(20, 110);
            Choice1Button.Name = "Choice1Button";
            Choice1Button.Size = new Size(200, 50);
            Choice1Button.TabIndex = 2;
            Choice1Button.Text = "Choice 1";
            Choice1Button.UseVisualStyleBackColor = false;
            Choice1Button.Click += Choice1Button_Click;
            // 
            // Choice2Button
            // 
            Choice2Button.BackColor = Color.LightGreen;
            Choice2Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Choice2Button.Location = new Point(240, 110);
            Choice2Button.Name = "Choice2Button";
            Choice2Button.Size = new Size(200, 50);
            Choice2Button.TabIndex = 3;
            Choice2Button.Text = "Choice 2";
            Choice2Button.UseVisualStyleBackColor = false;
            Choice2Button.Click += Choice2Button_Click;
            // 
            // Choice3Button
            // 
            Choice3Button.BackColor = Color.LightCoral;
            Choice3Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Choice3Button.Location = new Point(460, 110);
            Choice3Button.Name = "Choice3Button";
            Choice3Button.Size = new Size(200, 50);
            Choice3Button.TabIndex = 4;
            Choice3Button.Text = "Choice 3";
            Choice3Button.UseVisualStyleBackColor = false;
            Choice3Button.Click += Choice3Button_Click;
            // 
            // ScarcityLabel
            // 
            ScarcityLabel.BorderStyle = BorderStyle.FixedSingle;
            ScarcityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ScarcityLabel.ForeColor = Color.DarkOrange;
            ScarcityLabel.Location = new Point(20, 170);
            ScarcityLabel.Name = "ScarcityLabel";
            ScarcityLabel.Size = new Size(430, 40);
            ScarcityLabel.TabIndex = 5;
            ScarcityLabel.Text = "Scarcity explanation will appear here.";
            ScarcityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OpportunityCostLabel
            // 
            OpportunityCostLabel.BorderStyle = BorderStyle.FixedSingle;
            OpportunityCostLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OpportunityCostLabel.ForeColor = Color.Red;
            OpportunityCostLabel.Location = new Point(460, 170);
            OpportunityCostLabel.Name = "OpportunityCostLabel";
            OpportunityCostLabel.Size = new Size(470, 40);
            OpportunityCostLabel.TabIndex = 6;
            OpportunityCostLabel.Text = "Click a choice to see the opportunity cost!";
            OpportunityCostLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LessonLabel
            // 
            LessonLabel.BorderStyle = BorderStyle.FixedSingle;
            LessonLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            LessonLabel.ForeColor = Color.DarkGreen;
            LessonLabel.Location = new Point(20, 210);
            LessonLabel.Name = "LessonLabel";
            LessonLabel.Size = new Size(910, 50);
            LessonLabel.TabIndex = 7;
            LessonLabel.Text = "Lesson will appear here.";
            LessonLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NavigationGroupBox
            // 
            NavigationGroupBox.Controls.Add(PreviousButton);
            NavigationGroupBox.Controls.Add(NextButton);
            NavigationGroupBox.Controls.Add(ProgressLabel);
            NavigationGroupBox.Controls.Add(BackToMenuButton);
            NavigationGroupBox.Controls.Add(Unit4Ch2Button);
            NavigationGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            NavigationGroupBox.Location = new Point(12, 660);
            NavigationGroupBox.Name = "NavigationGroupBox";
            NavigationGroupBox.Size = new Size(950, 80);
            NavigationGroupBox.TabIndex = 5;
            NavigationGroupBox.TabStop = false;
            NavigationGroupBox.Text = "🧭 Navigation";
            // 
            // PreviousButton
            // 
            PreviousButton.BackColor = Color.Gray;
            PreviousButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            PreviousButton.ForeColor = Color.White;
            PreviousButton.Location = new Point(20, 25);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(120, 40);
            PreviousButton.TabIndex = 0;
            PreviousButton.Text = "⬅️ Previous";
            PreviousButton.UseVisualStyleBackColor = false;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.DarkBlue;
            NextButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            NextButton.ForeColor = Color.White;
            NextButton.Location = new Point(160, 25);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(120, 40);
            NextButton.TabIndex = 1;
            NextButton.Text = "Next ➡️";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProgressLabel.Location = new Point(300, 35);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(107, 21);
            ProgressLabel.TabIndex = 2;
            ProgressLabel.Text = "Scenario 1 of 5";
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.DarkRed;
            BackToMenuButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMenuButton.ForeColor = Color.White;
            BackToMenuButton.Location = new Point(800, 25);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(130, 40);
            BackToMenuButton.TabIndex = 3;
            BackToMenuButton.Text = "🏠 Main Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // Unit4Ch2Button
            // 
            Unit4Ch2Button.BackColor = Color.Green;
            Unit4Ch2Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Unit4Ch2Button.ForeColor = Color.White;
            Unit4Ch2Button.Location = new Point(660, 25);
            Unit4Ch2Button.Name = "Unit4Ch2Button";
            Unit4Ch2Button.Size = new Size(130, 40);
            Unit4Ch2Button.TabIndex = 4;
            Unit4Ch2Button.Text = "Unit 4 Ch 2 ➡️";
            Unit4Ch2Button.UseVisualStyleBackColor = false;
            Unit4Ch2Button.Click += Unit4Ch2Button_Click;
            // 
            // Unit_4_Ch_1__SS2E1_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(980, 760);
            Controls.Add(NavigationGroupBox);
            Controls.Add(ScenariosGroupBox);
            Controls.Add(ConceptsGroupBox);
            Controls.Add(InstructionLabel);
            Controls.Add(StandardLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Unit_4_Ch_1__SS2E1_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unit 4 Chapter 1: Economics - Scarcity and Choices (SS2E1)";
            ConceptsGroupBox.ResumeLayout(false);
            ScenariosGroupBox.ResumeLayout(false);
            ScenariosGroupBox.PerformLayout();
            NavigationGroupBox.ResumeLayout(false);
            NavigationGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label StandardLabel;
        private Label InstructionLabel;
        private GroupBox ConceptsGroupBox;
        private Button btnScarcity;
        private Button btnChoices;
        private Button btnOpportunityCost;
        private Button btnResources;
        private Label ConceptExplanationLabel;
        private GroupBox ScenariosGroupBox;
        private Label ScenarioTitleLabel;
        private Label ScenarioDescriptionLabel;
        private Button Choice1Button;
        private Button Choice2Button;
        private Button Choice3Button;
        private Label ScarcityLabel;
        private Label OpportunityCostLabel;
        private Label LessonLabel;
        private GroupBox NavigationGroupBox;
        private Button PreviousButton;
        private Button NextButton;
        private Label ProgressLabel;
        private Button BackToMenuButton;
        private Button Unit4Ch2Button;
    }
}