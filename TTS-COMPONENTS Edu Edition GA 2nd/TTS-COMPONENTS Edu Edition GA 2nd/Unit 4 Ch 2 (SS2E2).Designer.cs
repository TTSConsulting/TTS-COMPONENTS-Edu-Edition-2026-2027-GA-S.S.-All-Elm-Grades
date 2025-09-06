namespace TTS_COMPONENTS_Edu_Edition_GA_2nd
{
    partial class Unit_4_Ch_2__SS2E2_
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
            AllocationMethodsGroupBox = new GroupBox();
            btnPrice = new Button();
            btnMajorityRule = new Button();
            btnContest = new Button();
            btnForce = new Button();
            btnSharing = new Button();
            btnLottery = new Button();
            btnAuthority = new Button();
            btnFirstCome = new Button();
            btnPersonalCharacteristics = new Button();
            MethodExplanationLabel = new Label();
            ScenariosGroupBox = new GroupBox();
            ScenarioTitleLabel = new Label();
            ScenarioDescriptionLabel = new Label();
            Method1Button = new Button();
            Method2Button = new Button();
            Method3Button = new Button();
            AllocationExplanationLabel = new Label();
            ProsConsLabel = new Label();
            LearningPointLabel = new Label();
            NavigationGroupBox = new GroupBox();
            PreviousButton = new Button();
            NextButton = new Button();
            ProgressLabel = new Label();
            BackToMenuButton = new Button();
            Unit4Ch3Button = new Button();
            AllocationMethodsGroupBox.SuspendLayout();
            ScenariosGroupBox.SuspendLayout();
            NavigationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.DarkBlue;
            TitleLabel.Location = new Point(14, 12);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(850, 46);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Unit 4 Chapter 2: How Goods & Services are Allocated";
            // 
            // StandardLabel
            // 
            StandardLabel.AutoSize = true;
            StandardLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            StandardLabel.ForeColor = Color.DarkGreen;
            StandardLabel.Location = new Point(14, 61);
            StandardLabel.Name = "StandardLabel";
            StandardLabel.Size = new Size(1431, 28);
            StandardLabel.TabIndex = 1;
            StandardLabel.Text = "SS2E2: Identify ways goods and services are allocated (price, majority rule, contests, force, sharing, lottery, authority, first-come-first-served, personal characteristics).";
            // 
            // InstructionLabel
            // 
            InstructionLabel.AutoSize = true;
            InstructionLabel.Font = new Font("Segoe UI", 12F);
            InstructionLabel.Location = new Point(14, 107);
            InstructionLabel.Name = "InstructionLabel";
            InstructionLabel.Size = new Size(916, 28);
            InstructionLabel.TabIndex = 2;
            InstructionLabel.Text = "Learn about different ways to allocate resources! First explore methods, then practice with real scenarios.";
            // 
            // AllocationMethodsGroupBox
            // 
            AllocationMethodsGroupBox.Controls.Add(btnPrice);
            AllocationMethodsGroupBox.Controls.Add(btnMajorityRule);
            AllocationMethodsGroupBox.Controls.Add(btnContest);
            AllocationMethodsGroupBox.Controls.Add(btnForce);
            AllocationMethodsGroupBox.Controls.Add(btnSharing);
            AllocationMethodsGroupBox.Controls.Add(btnLottery);
            AllocationMethodsGroupBox.Controls.Add(btnAuthority);
            AllocationMethodsGroupBox.Controls.Add(btnFirstCome);
            AllocationMethodsGroupBox.Controls.Add(btnPersonalCharacteristics);
            AllocationMethodsGroupBox.Controls.Add(MethodExplanationLabel);
            AllocationMethodsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AllocationMethodsGroupBox.Location = new Point(14, 147);
            AllocationMethodsGroupBox.Margin = new Padding(3, 4, 3, 4);
            AllocationMethodsGroupBox.Name = "AllocationMethodsGroupBox";
            AllocationMethodsGroupBox.Padding = new Padding(3, 4, 3, 4);
            AllocationMethodsGroupBox.Size = new Size(1141, 373);
            AllocationMethodsGroupBox.TabIndex = 3;
            AllocationMethodsGroupBox.TabStop = false;
            AllocationMethodsGroupBox.Text = "📋 Allocation Methods";
            // 
            // btnPrice
            // 
            btnPrice.BackColor = Color.LimeGreen;
            btnPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrice.ForeColor = Color.White;
            btnPrice.Location = new Point(23, 40);
            btnPrice.Margin = new Padding(3, 4, 3, 4);
            btnPrice.Name = "btnPrice";
            btnPrice.Size = new Size(114, 67);
            btnPrice.TabIndex = 0;
            btnPrice.Text = "💰 Price";
            btnPrice.UseVisualStyleBackColor = false;
            btnPrice.Click += AllocationMethodButton_Click;
            // 
            // btnMajorityRule
            // 
            btnMajorityRule.BackColor = Color.DodgerBlue;
            btnMajorityRule.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMajorityRule.ForeColor = Color.White;
            btnMajorityRule.Location = new Point(149, 40);
            btnMajorityRule.Margin = new Padding(3, 4, 3, 4);
            btnMajorityRule.Name = "btnMajorityRule";
            btnMajorityRule.Size = new Size(114, 67);
            btnMajorityRule.TabIndex = 1;
            btnMajorityRule.Text = "🗳️ Majority Rule";
            btnMajorityRule.UseVisualStyleBackColor = false;
            btnMajorityRule.Click += AllocationMethodButton_Click;
            // 
            // btnContest
            // 
            btnContest.BackColor = Color.Orange;
            btnContest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnContest.ForeColor = Color.White;
            btnContest.Location = new Point(274, 40);
            btnContest.Margin = new Padding(3, 4, 3, 4);
            btnContest.Name = "btnContest";
            btnContest.Size = new Size(114, 67);
            btnContest.TabIndex = 2;
            btnContest.Text = "🏆 Contest";
            btnContest.UseVisualStyleBackColor = false;
            btnContest.Click += AllocationMethodButton_Click;
            // 
            // btnForce
            // 
            btnForce.BackColor = Color.DarkRed;
            btnForce.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnForce.ForeColor = Color.White;
            btnForce.Location = new Point(400, 40);
            btnForce.Margin = new Padding(3, 4, 3, 4);
            btnForce.Name = "btnForce";
            btnForce.Size = new Size(114, 67);
            btnForce.TabIndex = 3;
            btnForce.Text = "💪 Force";
            btnForce.UseVisualStyleBackColor = false;
            btnForce.Click += AllocationMethodButton_Click;
            // 
            // btnSharing
            // 
            btnSharing.BackColor = Color.MediumSeaGreen;
            btnSharing.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSharing.ForeColor = Color.White;
            btnSharing.Location = new Point(526, 40);
            btnSharing.Margin = new Padding(3, 4, 3, 4);
            btnSharing.Name = "btnSharing";
            btnSharing.Size = new Size(114, 67);
            btnSharing.TabIndex = 4;
            btnSharing.Text = "\U0001f91d Sharing";
            btnSharing.UseVisualStyleBackColor = false;
            btnSharing.Click += AllocationMethodButton_Click;
            // 
            // btnLottery
            // 
            btnLottery.BackColor = Color.Purple;
            btnLottery.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLottery.ForeColor = Color.White;
            btnLottery.Location = new Point(651, 40);
            btnLottery.Margin = new Padding(3, 4, 3, 4);
            btnLottery.Name = "btnLottery";
            btnLottery.Size = new Size(114, 67);
            btnLottery.TabIndex = 5;
            btnLottery.Text = "🎲 Lottery";
            btnLottery.UseVisualStyleBackColor = false;
            btnLottery.Click += AllocationMethodButton_Click;
            // 
            // btnAuthority
            // 
            btnAuthority.BackColor = Color.SaddleBrown;
            btnAuthority.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAuthority.ForeColor = Color.White;
            btnAuthority.Location = new Point(777, 40);
            btnAuthority.Margin = new Padding(3, 4, 3, 4);
            btnAuthority.Name = "btnAuthority";
            btnAuthority.Size = new Size(114, 67);
            btnAuthority.TabIndex = 6;
            btnAuthority.Text = "👨‍🏫 Authority";
            btnAuthority.UseVisualStyleBackColor = false;
            btnAuthority.Click += AllocationMethodButton_Click;
            // 
            // btnFirstCome
            // 
            btnFirstCome.BackColor = Color.Teal;
            btnFirstCome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFirstCome.ForeColor = Color.White;
            btnFirstCome.Location = new Point(903, 40);
            btnFirstCome.Margin = new Padding(3, 4, 3, 4);
            btnFirstCome.Name = "btnFirstCome";
            btnFirstCome.Size = new Size(114, 67);
            btnFirstCome.TabIndex = 7;
            btnFirstCome.Text = "⏰ First-Come";
            btnFirstCome.UseVisualStyleBackColor = false;
            btnFirstCome.Click += AllocationMethodButton_Click;
            // 
            // btnPersonalCharacteristics
            // 
            btnPersonalCharacteristics.BackColor = Color.Indigo;
            btnPersonalCharacteristics.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPersonalCharacteristics.ForeColor = Color.White;
            btnPersonalCharacteristics.Location = new Point(1029, 40);
            btnPersonalCharacteristics.Margin = new Padding(3, 4, 3, 4);
            btnPersonalCharacteristics.Name = "btnPersonalCharacteristics";
            btnPersonalCharacteristics.Size = new Size(103, 67);
            btnPersonalCharacteristics.TabIndex = 8;
            btnPersonalCharacteristics.Text = "👥 Personal Traits";
            btnPersonalCharacteristics.UseVisualStyleBackColor = false;
            btnPersonalCharacteristics.Click += AllocationMethodButton_Click;
            // 
            // MethodExplanationLabel
            // 
            MethodExplanationLabel.BorderStyle = BorderStyle.FixedSingle;
            MethodExplanationLabel.Font = new Font("Segoe UI", 11F);
            MethodExplanationLabel.Location = new Point(23, 120);
            MethodExplanationLabel.Name = "MethodExplanationLabel";
            MethodExplanationLabel.Size = new Size(1085, 239);
            MethodExplanationLabel.TabIndex = 9;
            MethodExplanationLabel.Text = "Click on an allocation method above to learn about it!";
            // 
            // ScenariosGroupBox
            // 
            ScenariosGroupBox.Controls.Add(ScenarioTitleLabel);
            ScenariosGroupBox.Controls.Add(ScenarioDescriptionLabel);
            ScenariosGroupBox.Controls.Add(Method1Button);
            ScenariosGroupBox.Controls.Add(Method2Button);
            ScenariosGroupBox.Controls.Add(Method3Button);
            ScenariosGroupBox.Controls.Add(AllocationExplanationLabel);
            ScenariosGroupBox.Controls.Add(ProsConsLabel);
            ScenariosGroupBox.Controls.Add(LearningPointLabel);
            ScenariosGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ScenariosGroupBox.Location = new Point(14, 533);
            ScenariosGroupBox.Margin = new Padding(3, 4, 3, 4);
            ScenariosGroupBox.Name = "ScenariosGroupBox";
            ScenariosGroupBox.Padding = new Padding(3, 4, 3, 4);
            ScenariosGroupBox.Size = new Size(1120, 373);
            ScenariosGroupBox.TabIndex = 4;
            ScenariosGroupBox.TabStop = false;
            ScenariosGroupBox.Text = "🎯 Practice Scenarios";
            // 
            // ScenarioTitleLabel
            // 
            ScenarioTitleLabel.AutoSize = true;
            ScenarioTitleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ScenarioTitleLabel.ForeColor = Color.DarkBlue;
            ScenarioTitleLabel.Location = new Point(23, 40);
            ScenarioTitleLabel.Name = "ScenarioTitleLabel";
            ScenarioTitleLabel.Size = new Size(169, 32);
            ScenarioTitleLabel.TabIndex = 0;
            ScenarioTitleLabel.Text = "Scenario Title";
            // 
            // ScenarioDescriptionLabel
            // 
            ScenarioDescriptionLabel.Font = new Font("Segoe UI", 12F);
            ScenarioDescriptionLabel.Location = new Point(23, 80);
            ScenarioDescriptionLabel.Name = "ScenarioDescriptionLabel";
            ScenarioDescriptionLabel.Size = new Size(1086, 40);
            ScenarioDescriptionLabel.TabIndex = 1;
            ScenarioDescriptionLabel.Text = "Scenario description will appear here.";
            // 
            // Method1Button
            // 
            Method1Button.BackColor = Color.LightBlue;
            Method1Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Method1Button.Location = new Point(23, 133);
            Method1Button.Margin = new Padding(3, 4, 3, 4);
            Method1Button.Name = "Method1Button";
            Method1Button.Size = new Size(171, 53);
            Method1Button.TabIndex = 2;
            Method1Button.Text = "Method 1";
            Method1Button.UseVisualStyleBackColor = false;
            Method1Button.Click += Method1Button_Click;
            // 
            // Method2Button
            // 
            Method2Button.BackColor = Color.LightGreen;
            Method2Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Method2Button.Location = new Point(206, 133);
            Method2Button.Margin = new Padding(3, 4, 3, 4);
            Method2Button.Name = "Method2Button";
            Method2Button.Size = new Size(171, 53);
            Method2Button.TabIndex = 3;
            Method2Button.Text = "Method 2";
            Method2Button.UseVisualStyleBackColor = false;
            Method2Button.Click += Method2Button_Click;
            // 
            // Method3Button
            // 
            Method3Button.BackColor = Color.LightCoral;
            Method3Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Method3Button.Location = new Point(389, 133);
            Method3Button.Margin = new Padding(3, 4, 3, 4);
            Method3Button.Name = "Method3Button";
            Method3Button.Size = new Size(171, 53);
            Method3Button.TabIndex = 4;
            Method3Button.Text = "Method 3";
            Method3Button.UseVisualStyleBackColor = false;
            Method3Button.Click += Method3Button_Click;
            // 
            // AllocationExplanationLabel
            // 
            AllocationExplanationLabel.BorderStyle = BorderStyle.FixedSingle;
            AllocationExplanationLabel.Font = new Font("Segoe UI", 11F);
            AllocationExplanationLabel.ForeColor = Color.DarkBlue;
            AllocationExplanationLabel.Location = new Point(23, 200);
            AllocationExplanationLabel.Name = "AllocationExplanationLabel";
            AllocationExplanationLabel.Size = new Size(537, 39);
            AllocationExplanationLabel.TabIndex = 5;
            AllocationExplanationLabel.Text = "Click on a method to see how it works!";
            AllocationExplanationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProsConsLabel
            // 
            ProsConsLabel.BorderStyle = BorderStyle.FixedSingle;
            ProsConsLabel.Font = new Font("Segoe UI", 10F);
            ProsConsLabel.Location = new Point(571, 133);
            ProsConsLabel.Name = "ProsConsLabel";
            ProsConsLabel.Size = new Size(537, 106);
            ProsConsLabel.TabIndex = 6;
            ProsConsLabel.Text = "Pros and cons will appear here.";
            // 
            // LearningPointLabel
            // 
            LearningPointLabel.BorderStyle = BorderStyle.FixedSingle;
            LearningPointLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            LearningPointLabel.ForeColor = Color.DarkGreen;
            LearningPointLabel.Location = new Point(23, 253);
            LearningPointLabel.Name = "LearningPointLabel";
            LearningPointLabel.Size = new Size(1085, 106);
            LearningPointLabel.TabIndex = 7;
            LearningPointLabel.Text = "Learning point will appear here.";
            // 
            // NavigationGroupBox
            // 
            NavigationGroupBox.Controls.Add(PreviousButton);
            NavigationGroupBox.Controls.Add(NextButton);
            NavigationGroupBox.Controls.Add(ProgressLabel);
            NavigationGroupBox.Controls.Add(BackToMenuButton);
            NavigationGroupBox.Controls.Add(Unit4Ch3Button);
            NavigationGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            NavigationGroupBox.Location = new Point(14, 920);
            NavigationGroupBox.Margin = new Padding(3, 4, 3, 4);
            NavigationGroupBox.Name = "NavigationGroupBox";
            NavigationGroupBox.Padding = new Padding(3, 4, 3, 4);
            NavigationGroupBox.Size = new Size(1120, 93);
            NavigationGroupBox.TabIndex = 5;
            NavigationGroupBox.TabStop = false;
            NavigationGroupBox.Text = "\U0001f9ed Navigation";
            // 
            // PreviousButton
            // 
            PreviousButton.BackColor = Color.Gray;
            PreviousButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            PreviousButton.ForeColor = Color.White;
            PreviousButton.Location = new Point(23, 27);
            PreviousButton.Margin = new Padding(3, 4, 3, 4);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(114, 47);
            PreviousButton.TabIndex = 0;
            PreviousButton.Text = "⬅️ Previous";
            PreviousButton.UseVisualStyleBackColor = false;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.DarkBlue;
            NextButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            NextButton.ForeColor = Color.White;
            NextButton.Location = new Point(149, 27);
            NextButton.Margin = new Padding(3, 4, 3, 4);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(114, 47);
            NextButton.TabIndex = 1;
            NextButton.Text = "Next ➡️";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Font = new Font("Segoe UI", 12F);
            ProgressLabel.Location = new Point(286, 40);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(142, 28);
            ProgressLabel.TabIndex = 2;
            ProgressLabel.Text = "Scenario 1 of 8";
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.DarkRed;
            BackToMenuButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BackToMenuButton.ForeColor = Color.White;
            BackToMenuButton.Location = new Point(983, 27);
            BackToMenuButton.Margin = new Padding(3, 4, 3, 4);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(126, 47);
            BackToMenuButton.TabIndex = 3;
            BackToMenuButton.Text = "🏠 Main Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // Unit4Ch3Button
            // 
            Unit4Ch3Button.BackColor = Color.Green;
            Unit4Ch3Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Unit4Ch3Button.ForeColor = Color.White;
            Unit4Ch3Button.Location = new Point(846, 27);
            Unit4Ch3Button.Margin = new Padding(3, 4, 3, 4);
            Unit4Ch3Button.Name = "Unit4Ch3Button";
            Unit4Ch3Button.Size = new Size(126, 47);
            Unit4Ch3Button.TabIndex = 4;
            Unit4Ch3Button.Text = "Unit 4 Ch 3 ➡️";
            Unit4Ch3Button.UseVisualStyleBackColor = false;
            Unit4Ch3Button.Click += Unit4Ch3Button_Click;
            // 
            // Unit_4_Ch_2__SS2E2_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1443, 1040);
            Controls.Add(NavigationGroupBox);
            Controls.Add(ScenariosGroupBox);
            Controls.Add(AllocationMethodsGroupBox);
            Controls.Add(InstructionLabel);
            Controls.Add(StandardLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Unit_4_Ch_2__SS2E2_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unit 4 Chapter 2: Resource Allocation Methods (SS2E2)";
            AllocationMethodsGroupBox.ResumeLayout(false);
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
        private GroupBox AllocationMethodsGroupBox;
        private Button btnPrice;
        private Button btnMajorityRule;
        private Button btnContest;
        private Button btnForce;
        private Button btnSharing;
        private Button btnLottery;
        private Button btnAuthority;
        private Button btnFirstCome;
        private Button btnPersonalCharacteristics;
        private Label MethodExplanationLabel;
        private GroupBox ScenariosGroupBox;
        private Label ScenarioTitleLabel;
        private Label ScenarioDescriptionLabel;
        private Button Method1Button;
        private Button Method2Button;
        private Button Method3Button;
        private Label AllocationExplanationLabel;
        private Label ProsConsLabel;
        private Label LearningPointLabel;
        private GroupBox NavigationGroupBox;
        private Button PreviousButton;
        private Button NextButton;
        private Label ProgressLabel;
        private Button BackToMenuButton;
        private Button Unit4Ch3Button;
    }
}