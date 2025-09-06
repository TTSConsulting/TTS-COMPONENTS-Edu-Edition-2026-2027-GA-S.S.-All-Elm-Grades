namespace TTS_COMPONENTS_Edu_Edition_GA_2nd
{
    partial class Unit_2_Ch_1__SS2G1_
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            titleLabel = new Label();
            instructionLabel = new Label();
            regionsLabel = new Label();
            riversLabel = new Label();
            btnBlueRidge = new Button();
            btnPiedmont = new Button();
            btnCoastalPlain = new Button();
            btnRidgeValley = new Button();
            btnAppalachianPlateau = new Button();
            btnSavannahRiver = new Button();
            btnFlintRiver = new Button();
            btnChattahoocheeRiver = new Button();
            mapInfoLabel = new Label();
            btnNextChapter = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(57, 40);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(796, 46);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "🗺️ Georgia Geographic Features (SS2G1)";
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Arial", 14F);
            instructionLabel.ForeColor = Color.DarkGreen;
            instructionLabel.Location = new Point(57, 107);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(795, 27);
            instructionLabel.TabIndex = 1;
            instructionLabel.Text = "Explore Georgia's five regions and three major rivers! Click to learn more.";
            // 
            // regionsLabel
            // 
            regionsLabel.AutoSize = true;
            regionsLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            regionsLabel.ForeColor = Color.DarkRed;
            regionsLabel.Location = new Point(57, 160);
            regionsLabel.Name = "regionsLabel";
            regionsLabel.Size = new Size(401, 35);
            regionsLabel.TabIndex = 2;
            regionsLabel.Text = "🏔️ Georgia's Five Regions:";
            // 
            // riversLabel
            // 
            riversLabel.AutoSize = true;
            riversLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            riversLabel.ForeColor = Color.DarkBlue;
            riversLabel.Location = new Point(57, 400);
            riversLabel.Name = "riversLabel";
            riversLabel.Size = new Size(487, 35);
            riversLabel.TabIndex = 3;
            riversLabel.Text = "🌊 Georgia's Three Major Rivers:";
            // 
            // btnBlueRidge
            // 
            btnBlueRidge.BackColor = Color.SteelBlue;
            btnBlueRidge.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnBlueRidge.ForeColor = Color.White;
            btnBlueRidge.Location = new Point(57, 213);
            btnBlueRidge.Margin = new Padding(3, 4, 3, 4);
            btnBlueRidge.Name = "btnBlueRidge";
            btnBlueRidge.Size = new Size(171, 80);
            btnBlueRidge.TabIndex = 4;
            btnBlueRidge.Tag = "blueridge";
            btnBlueRidge.Text = "🏔️ Blue Ridge\r\nMountains";
            btnBlueRidge.UseVisualStyleBackColor = false;
            btnBlueRidge.Click += GeographicFeature_Click;
            // 
            // btnPiedmont
            // 
            btnPiedmont.BackColor = Color.ForestGreen;
            btnPiedmont.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnPiedmont.ForeColor = Color.White;
            btnPiedmont.Location = new Point(251, 213);
            btnPiedmont.Margin = new Padding(3, 4, 3, 4);
            btnPiedmont.Name = "btnPiedmont";
            btnPiedmont.Size = new Size(171, 80);
            btnPiedmont.TabIndex = 5;
            btnPiedmont.Tag = "piedmont";
            btnPiedmont.Text = "🌲 Piedmont\r\nRolling Hills";
            btnPiedmont.UseVisualStyleBackColor = false;
            btnPiedmont.Click += GeographicFeature_Click;
            // 
            // btnCoastalPlain
            // 
            btnCoastalPlain.BackColor = Color.Gold;
            btnCoastalPlain.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCoastalPlain.ForeColor = Color.DarkBlue;
            btnCoastalPlain.Location = new Point(446, 213);
            btnCoastalPlain.Margin = new Padding(3, 4, 3, 4);
            btnCoastalPlain.Name = "btnCoastalPlain";
            btnCoastalPlain.Size = new Size(171, 80);
            btnCoastalPlain.TabIndex = 6;
            btnCoastalPlain.Tag = "coastalplain";
            btnCoastalPlain.Text = "🏖️ Coastal Plain\r\nFlat Land";
            btnCoastalPlain.UseVisualStyleBackColor = false;
            btnCoastalPlain.Click += GeographicFeature_Click;
            // 
            // btnRidgeValley
            // 
            btnRidgeValley.BackColor = Color.DarkOliveGreen;
            btnRidgeValley.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnRidgeValley.ForeColor = Color.White;
            btnRidgeValley.Location = new Point(640, 213);
            btnRidgeValley.Margin = new Padding(3, 4, 3, 4);
            btnRidgeValley.Name = "btnRidgeValley";
            btnRidgeValley.Size = new Size(171, 80);
            btnRidgeValley.TabIndex = 7;
            btnRidgeValley.Tag = "ridgevalley";
            btnRidgeValley.Text = "⛰️ Ridge & Valley\r\nLong Ridges";
            btnRidgeValley.UseVisualStyleBackColor = false;
            btnRidgeValley.Click += GeographicFeature_Click;
            // 
            // btnAppalachianPlateau
            // 
            btnAppalachianPlateau.BackColor = Color.DarkSlateGray;
            btnAppalachianPlateau.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnAppalachianPlateau.ForeColor = Color.White;
            btnAppalachianPlateau.Location = new Point(834, 213);
            btnAppalachianPlateau.Margin = new Padding(3, 4, 3, 4);
            btnAppalachianPlateau.Name = "btnAppalachianPlateau";
            btnAppalachianPlateau.Size = new Size(171, 80);
            btnAppalachianPlateau.TabIndex = 8;
            btnAppalachianPlateau.Tag = "plateau";
            btnAppalachianPlateau.Text = "🗻 Appalachian\r\nPlateau";
            btnAppalachianPlateau.UseVisualStyleBackColor = false;
            btnAppalachianPlateau.Click += GeographicFeature_Click;
            // 
            // btnSavannahRiver
            // 
            btnSavannahRiver.BackColor = Color.DodgerBlue;
            btnSavannahRiver.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSavannahRiver.ForeColor = Color.White;
            btnSavannahRiver.Location = new Point(57, 453);
            btnSavannahRiver.Margin = new Padding(3, 4, 3, 4);
            btnSavannahRiver.Name = "btnSavannahRiver";
            btnSavannahRiver.Size = new Size(206, 80);
            btnSavannahRiver.TabIndex = 9;
            btnSavannahRiver.Tag = "savannah";
            btnSavannahRiver.Text = "🌊 Savannah River\r\n(Georgia-SC border)";
            btnSavannahRiver.UseVisualStyleBackColor = false;
            btnSavannahRiver.Click += GeographicFeature_Click;
            // 
            // btnFlintRiver
            // 
            btnFlintRiver.BackColor = Color.RoyalBlue;
            btnFlintRiver.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnFlintRiver.ForeColor = Color.White;
            btnFlintRiver.Location = new Point(286, 453);
            btnFlintRiver.Margin = new Padding(3, 4, 3, 4);
            btnFlintRiver.Name = "btnFlintRiver";
            btnFlintRiver.Size = new Size(206, 80);
            btnFlintRiver.TabIndex = 10;
            btnFlintRiver.Tag = "flint";
            btnFlintRiver.Text = "🌊 Flint River\r\n(Southwest Georgia)";
            btnFlintRiver.UseVisualStyleBackColor = false;
            btnFlintRiver.Click += GeographicFeature_Click;
            // 
            // btnChattahoocheeRiver
            // 
            btnChattahoocheeRiver.BackColor = Color.MediumBlue;
            btnChattahoocheeRiver.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnChattahoocheeRiver.ForeColor = Color.White;
            btnChattahoocheeRiver.Location = new Point(514, 453);
            btnChattahoocheeRiver.Margin = new Padding(3, 4, 3, 4);
            btnChattahoocheeRiver.Name = "btnChattahoocheeRiver";
            btnChattahoocheeRiver.Size = new Size(221, 80);
            btnChattahoocheeRiver.TabIndex = 11;
            btnChattahoocheeRiver.Tag = "chattahoochee";
            btnChattahoocheeRiver.Text = "🌊 Chattahoochee River\r\n(Georgia-AL border)";
            btnChattahoocheeRiver.UseVisualStyleBackColor = false;
            btnChattahoocheeRiver.Click += GeographicFeature_Click;
            // 
            // mapInfoLabel
            // 
            mapInfoLabel.AutoSize = true;
            mapInfoLabel.Font = new Font("Arial", 12F, FontStyle.Italic);
            mapInfoLabel.ForeColor = Color.DarkOrange;
            mapInfoLabel.Location = new Point(57, 560);
            mapInfoLabel.Name = "mapInfoLabel";
            mapInfoLabel.Size = new Size(709, 24);
            mapInfoLabel.TabIndex = 12;
            mapInfoLabel.Text = "🗺️ These features help define Georgia's surface and shape our beautiful state!";
            // 
            // btnNextChapter
            // 
            btnNextChapter.BackColor = Color.MediumSeaGreen;
            btnNextChapter.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnNextChapter.ForeColor = Color.White;
            btnNextChapter.Location = new Point(800, 560);
            btnNextChapter.Margin = new Padding(3, 4, 3, 4);
            btnNextChapter.Name = "btnNextChapter";
            btnNextChapter.Size = new Size(286, 67);
            btnNextChapter.TabIndex = 13;
            btnNextChapter.Text = "🔗 Unit 2 Chapter 2 →\r\nPeople & Places!";
            btnNextChapter.UseVisualStyleBackColor = false;
            btnNextChapter.Click += btnNextChapter_Click;
            // 
            // Unit_2_Ch_1__SS2G1_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1143, 667);
            Controls.Add(btnNextChapter);
            Controls.Add(mapInfoLabel);
            Controls.Add(btnChattahoocheeRiver);
            Controls.Add(btnFlintRiver);
            Controls.Add(btnSavannahRiver);
            Controls.Add(btnAppalachianPlateau);
            Controls.Add(btnRidgeValley);
            Controls.Add(btnCoastalPlain);
            Controls.Add(btnPiedmont);
            Controls.Add(btnBlueRidge);
            Controls.Add(riversLabel);
            Controls.Add(regionsLabel);
            Controls.Add(instructionLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Unit_2_Ch_1__SS2G1_";
            Text = "Unit 2 Chapter 1 - Georgia Geographic Features (SS2G1)";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label regionsLabel;
        private System.Windows.Forms.Label riversLabel;
        private System.Windows.Forms.Button btnBlueRidge;
        private System.Windows.Forms.Button btnPiedmont;
        private System.Windows.Forms.Button btnCoastalPlain;
        private System.Windows.Forms.Button btnRidgeValley;
        private System.Windows.Forms.Button btnAppalachianPlateau;
        private System.Windows.Forms.Button btnSavannahRiver;
        private System.Windows.Forms.Button btnFlintRiver;
        private System.Windows.Forms.Button btnChattahoocheeRiver;
        private System.Windows.Forms.Label mapInfoLabel;
        private System.Windows.Forms.Button btnNextChapter;
    }
}