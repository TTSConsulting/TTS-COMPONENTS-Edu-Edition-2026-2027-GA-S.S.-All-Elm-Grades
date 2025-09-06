namespace TTS_COMPONENTS_Edu_Edition_GA_2nd
{
    partial class Unit_3_Ch_2__SS2CG2_
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
            titleLabel = new Label();
            subtitleLabel = new Label();
            nationalLabel = new Label();
            btnPresident = new Button();
            btnWhiteHouse = new Button();
            stateLabel = new Label();
            btnGovernor = new Button();
            btnStateCapitol = new Button();
            localLabel = new Label();
            btnMayor = new Button();
            btnCityHall = new Button();
            leaderInfoLabel = new Label();
            workplacesLabel = new Label();
            btnWashingtonDC = new Button();
            btnAtlantaGA = new Button();
            btnLocalCity = new Button();
            btnBackToMain = new Button();
            btnNextUnit = new Button();
            instructionLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(250, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(300, 45);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Our Elected Leaders";
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            subtitleLabel.ForeColor = Color.DarkGreen;
            subtitleLabel.Location = new Point(280, 70);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(240, 25);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "SS2CG2 - Executive Branch";
            // 
            // nationalLabel
            // 
            nationalLabel.AutoSize = true;
            nationalLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            nationalLabel.ForeColor = Color.DarkRed;
            nationalLabel.Location = new Point(50, 120);
            nationalLabel.Name = "nationalLabel";
            nationalLabel.Size = new Size(180, 30);
            nationalLabel.TabIndex = 2;
            nationalLabel.Text = "🇺🇸 NATIONAL LEVEL";
            // 
            // btnPresident
            // 
            btnPresident.BackColor = Color.LightBlue;
            btnPresident.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnPresident.Location = new Point(50, 160);
            btnPresident.Name = "btnPresident";
            btnPresident.Size = new Size(200, 80);
            btnPresident.TabIndex = 3;
            btnPresident.Text = "🏛️ PRESIDENT\nLeader of our Nation";
            btnPresident.UseVisualStyleBackColor = false;
            btnPresident.Click += new EventHandler(LeaderButton_Click);
            // 
            // btnWhiteHouse
            // 
            btnWhiteHouse.BackColor = Color.LightCyan;
            btnWhiteHouse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnWhiteHouse.Location = new Point(270, 160);
            btnWhiteHouse.Name = "btnWhiteHouse";
            btnWhiteHouse.Size = new Size(180, 80);
            btnWhiteHouse.TabIndex = 4;
            btnWhiteHouse.Text = "🏛️ WHITE HOUSE\nWashington, D.C.\nWhere President Works";
            btnWhiteHouse.UseVisualStyleBackColor = false;
            btnWhiteHouse.Click += new EventHandler(LeaderButton_Click);
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            stateLabel.ForeColor = Color.DarkRed;
            stateLabel.Location = new Point(50, 260);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(160, 30);
            stateLabel.TabIndex = 5;
            stateLabel.Text = "🍑 STATE LEVEL";
            // 
            // btnGovernor
            // 
            btnGovernor.BackColor = Color.LightGreen;
            btnGovernor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnGovernor.Location = new Point(50, 300);
            btnGovernor.Name = "btnGovernor";
            btnGovernor.Size = new Size(200, 80);
            btnGovernor.TabIndex = 6;
            btnGovernor.Text = "🍑 GOVERNOR\nLeader of Georgia";
            btnGovernor.UseVisualStyleBackColor = false;
            btnGovernor.Click += new EventHandler(LeaderButton_Click);
            // 
            // btnStateCapitol
            // 
            btnStateCapitol.BackColor = Color.LightYellow;
            btnStateCapitol.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStateCapitol.Location = new Point(270, 300);
            btnStateCapitol.Name = "btnStateCapitol";
            btnStateCapitol.Size = new Size(180, 80);
            btnStateCapitol.TabIndex = 7;
            btnStateCapitol.Text = "🏛️ STATE CAPITOL\nAtlanta, Georgia\nWhere Governor Works";
            btnStateCapitol.UseVisualStyleBackColor = false;
            btnStateCapitol.Click += new EventHandler(LeaderButton_Click);
            // 
            // localLabel
            // 
            localLabel.AutoSize = true;
            localLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            localLabel.ForeColor = Color.DarkRed;
            localLabel.Location = new Point(50, 400);
            localLabel.Name = "localLabel";
            localLabel.Size = new Size(150, 30);
            localLabel.TabIndex = 8;
            localLabel.Text = "🏙️ LOCAL LEVEL";
            // 
            // btnMayor
            // 
            btnMayor.BackColor = Color.LightCoral;
            btnMayor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMayor.Location = new Point(50, 440);
            btnMayor.Name = "btnMayor";
            btnMayor.Size = new Size(200, 80);
            btnMayor.TabIndex = 9;
            btnMayor.Text = "🏙️ MAYOR\nLeader of our City";
            btnMayor.UseVisualStyleBackColor = false;
            btnMayor.Click += new EventHandler(LeaderButton_Click);
            // 
            // btnCityHall
            // 
            btnCityHall.BackColor = Color.LightSalmon;
            btnCityHall.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCityHall.Location = new Point(270, 440);
            btnCityHall.Name = "btnCityHall";
            btnCityHall.Size = new Size(180, 80);
            btnCityHall.TabIndex = 10;
            btnCityHall.Text = "🏛️ CITY HALL\nYour City\nWhere Mayor Works";
            btnCityHall.UseVisualStyleBackColor = false;
            btnCityHall.Click += new EventHandler(LeaderButton_Click);
            // 
            // leaderInfoLabel
            // 
            leaderInfoLabel.BackColor = Color.White;
            leaderInfoLabel.BorderStyle = BorderStyle.FixedSingle;
            leaderInfoLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            leaderInfoLabel.Location = new Point(480, 160);
            leaderInfoLabel.Name = "leaderInfoLabel";
            leaderInfoLabel.Size = new Size(280, 200);
            leaderInfoLabel.TabIndex = 11;
            leaderInfoLabel.Text = "Click on the leaders and buildings to learn about our elected officials!\r\n\r\n👆 Click any button to start exploring!";
            // 
            // workplacesLabel
            // 
            workplacesLabel.AutoSize = true;
            workplacesLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            workplacesLabel.ForeColor = Color.DarkBlue;
            workplacesLabel.Location = new Point(480, 380);
            workplacesLabel.Name = "workplacesLabel";
            workplacesLabel.Size = new Size(200, 30);
            workplacesLabel.TabIndex = 12;
            workplacesLabel.Text = "🏛️ Where They Work";
            // 
            // btnWashingtonDC
            // 
            btnWashingtonDC.BackColor = Color.PaleGoldenrod;
            btnWashingtonDC.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnWashingtonDC.Location = new Point(480, 420);
            btnWashingtonDC.Name = "btnWashingtonDC";
            btnWashingtonDC.Size = new Size(120, 60);
            btnWashingtonDC.TabIndex = 13;
            btnWashingtonDC.Text = "🏛️ Washington\nD.C.";
            btnWashingtonDC.UseVisualStyleBackColor = false;
            btnWashingtonDC.Click += new EventHandler(LeaderButton_Click);
            // 
            // btnAtlantaGA
            // 
            btnAtlantaGA.BackColor = Color.PeachPuff;
            btnAtlantaGA.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtlantaGA.Location = new Point(620, 420);
            btnAtlantaGA.Name = "btnAtlantaGA";
            btnAtlantaGA.Size = new Size(120, 60);
            btnAtlantaGA.TabIndex = 14;
            btnAtlantaGA.Text = "🍑 Atlanta\nGeorgia";
            btnAtlantaGA.UseVisualStyleBackColor = false;
            btnAtlantaGA.Click += new EventHandler(LeaderButton_Click);
            // 
            // btnLocalCity
            // 
            btnLocalCity.BackColor = Color.LightSteelBlue;
            btnLocalCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLocalCity.Location = new Point(480, 490);
            btnLocalCity.Name = "btnLocalCity";
            btnLocalCity.Size = new Size(120, 60);
            btnLocalCity.TabIndex = 15;
            btnLocalCity.Text = "🏙️ Your Local\nCity";
            btnLocalCity.UseVisualStyleBackColor = false;
            btnLocalCity.Click += new EventHandler(LeaderButton_Click);
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackColor = Color.LightGray;
            btnBackToMain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackToMain.Location = new Point(50, 570);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(120, 40);
            btnBackToMain.TabIndex = 16;
            btnBackToMain.Text = "← Main Menu";
            btnBackToMain.UseVisualStyleBackColor = false;
            btnBackToMain.Click += new EventHandler(btnBackToMain_Click);
            // 
            // btnNextUnit
            // 
            btnNextUnit.BackColor = Color.LightSeaGreen;
            btnNextUnit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextUnit.Location = new Point(640, 570);
            btnNextUnit.Name = "btnNextUnit";
            btnNextUnit.Size = new Size(120, 40);
            btnNextUnit.TabIndex = 17;
            btnNextUnit.Text = "Complete! ✅";
            btnNextUnit.UseVisualStyleBackColor = false;
            btnNextUnit.Click += new EventHandler(btnNextUnit_Click);
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            instructionLabel.ForeColor = Color.DarkGray;
            instructionLabel.Location = new Point(50, 100);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(400, 21);
            instructionLabel.TabIndex = 18;
            instructionLabel.Text = "Learn about the President, Governor, and Mayor!";
            // 
            // Unit_3_Ch_2__SS2CG2_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 630);
            Controls.Add(instructionLabel);
            Controls.Add(btnNextUnit);
            Controls.Add(btnBackToMain);
            Controls.Add(btnLocalCity);
            Controls.Add(btnAtlantaGA);
            Controls.Add(btnWashingtonDC);
            Controls.Add(workplacesLabel);
            Controls.Add(leaderInfoLabel);
            Controls.Add(btnCityHall);
            Controls.Add(btnMayor);
            Controls.Add(localLabel);
            Controls.Add(btnStateCapitol);
            Controls.Add(btnGovernor);
            Controls.Add(stateLabel);
            Controls.Add(btnWhiteHouse);
            Controls.Add(btnPresident);
            Controls.Add(nationalLabel);
            Controls.Add(subtitleLabel);
            Controls.Add(titleLabel);
            Name = "Unit_3_Ch_2__SS2CG2_";
            Text = "Unit 3 Ch 2 - Elected Officials & Executive Branch (SS2CG2)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label subtitleLabel;
        private Label nationalLabel;
        private Button btnPresident;
        private Button btnWhiteHouse;
        private Label stateLabel;
        private Button btnGovernor;
        private Button btnStateCapitol;
        private Label localLabel;
        private Button btnMayor;
        private Button btnCityHall;
        private Label leaderInfoLabel;
        private Label workplacesLabel;
        private Button btnWashingtonDC;
        private Button btnAtlantaGA;
        private Button btnLocalCity;
        private Button btnBackToMain;
        private Button btnNextUnit;
        private Label instructionLabel;
    }
}