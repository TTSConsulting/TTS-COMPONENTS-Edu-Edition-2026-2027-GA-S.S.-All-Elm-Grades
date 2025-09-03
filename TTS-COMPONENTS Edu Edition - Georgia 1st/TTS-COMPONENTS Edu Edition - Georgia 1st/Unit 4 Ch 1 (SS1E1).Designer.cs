using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_COMPONENTS_Edu_Edition___Georgia_1st
{
    partial class Unit_4_Ch_1__SS1E1_
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
            lblCurrentType = new Label();
            pnlGoodsButtons = new Panel();
            btnFood = new Button();
            btnClothes = new Button();
            btnBooks = new Button();
            btnToys = new Button();
            btnHouses = new Button();
            btnCars = new Button();
            pnlServicesButtons = new Panel();
            btnTeaching = new Button();
            btnHealthcare = new Button();
            btnFireProtection = new Button();
            btnMailDelivery = new Button();
            btnTrashCollection = new Button();
            btnTransportation = new Button();
            pnlContent = new Panel();
            lblItemTitle = new Label();
            lblDescription = new Label();
            lblWhoMakesProvides = new Label();
            lblWhyImportant = new Label();
            lblGeorgiaExample = new Label();
            lblEverydayUse = new Label();
            btnShowGoods = new Button();
            btnShowServices = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnBackToUnit3Ch2 = new Button();
            btnToUnit4Ch2 = new Button();
            btnGoodsServicesGame = new Button();
            btnEconomicsQuiz = new Button();
            pnlGoodsButtons.SuspendLayout();
            pnlServicesButtons.SuspendLayout();
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
            lblTitle.Text = "Unit 4 Chapter 1: Goods and Services!";
            // 
            // lblStandard
            // 
            lblStandard.AutoSize = true;
            lblStandard.Font = new Font("Arial", 10F);
            lblStandard.Location = new Point(150, 60);
            lblStandard.Name = "lblStandard";
            lblStandard.Size = new Size(500, 16);
            lblStandard.TabIndex = 1;
            lblStandard.Text = "SS1E1: Identify goods that people make and services that people provide";
            // 
            // lblCurrentType
            // 
            lblCurrentType.AutoSize = true;
            lblCurrentType.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblCurrentType.ForeColor = Color.DarkBlue;
            lblCurrentType.Location = new Point(280, 90);
            lblCurrentType.Name = "lblCurrentType";
            lblCurrentType.Size = new Size(240, 23);
            lblCurrentType.TabIndex = 2;
            lblCurrentType.Text = "Currently Showing: GOODS";
            // 
            // pnlGoodsButtons
            // 
            pnlGoodsButtons.BackColor = Color.LightSteelBlue;
            pnlGoodsButtons.Controls.Add(btnFood);
            pnlGoodsButtons.Controls.Add(btnClothes);
            pnlGoodsButtons.Controls.Add(btnBooks);
            pnlGoodsButtons.Controls.Add(btnToys);
            pnlGoodsButtons.Controls.Add(btnHouses);
            pnlGoodsButtons.Controls.Add(btnCars);
            pnlGoodsButtons.Location = new Point(30, 120);
            pnlGoodsButtons.Name = "pnlGoodsButtons";
            pnlGoodsButtons.Size = new Size(740, 80);
            pnlGoodsButtons.TabIndex = 3;
            // 
            // btnFood
            // 
            btnFood.BackColor = Color.LightGray;
            btnFood.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnFood.Location = new Point(10, 20);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(110, 40);
            btnFood.TabIndex = 0;
            btnFood.Text = "🍎 Food";
            btnFood.UseVisualStyleBackColor = false;
            btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnClothes
            // 
            btnClothes.BackColor = Color.LightGray;
            btnClothes.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnClothes.Location = new Point(130, 20);
            btnClothes.Name = "btnClothes";
            btnClothes.Size = new Size(110, 40);
            btnClothes.TabIndex = 1;
            btnClothes.Text = "👕 Clothes";
            btnClothes.UseVisualStyleBackColor = false;
            btnClothes.Click += new System.EventHandler(this.btnClothes_Click);
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.LightGray;
            btnBooks.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnBooks.Location = new Point(250, 20);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(110, 40);
            btnBooks.TabIndex = 2;
            btnBooks.Text = "📚 Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnToys
            // 
            btnToys.BackColor = Color.LightGray;
            btnToys.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnToys.Location = new Point(370, 20);
            btnToys.Name = "btnToys";
            btnToys.Size = new Size(110, 40);
            btnToys.TabIndex = 3;
            btnToys.Text = "🧸 Toys";
            btnToys.UseVisualStyleBackColor = false;
            btnToys.Click += new System.EventHandler(this.btnToys_Click);
            // 
            // btnHouses
            // 
            btnHouses.BackColor = Color.LightGray;
            btnHouses.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnHouses.Location = new Point(490, 20);
            btnHouses.Name = "btnHouses";
            btnHouses.Size = new Size(110, 40);
            btnHouses.TabIndex = 4;
            btnHouses.Text = "🏠 Houses";
            btnHouses.UseVisualStyleBackColor = false;
            btnHouses.Click += new System.EventHandler(this.btnHouses_Click);
            // 
            // btnCars
            // 
            btnCars.BackColor = Color.LightGray;
            btnCars.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnCars.Location = new Point(610, 20);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(110, 40);
            btnCars.TabIndex = 5;
            btnCars.Text = "🚗 Cars";
            btnCars.UseVisualStyleBackColor = false;
            btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // pnlServicesButtons
            // 
            pnlServicesButtons.BackColor = Color.LightGreen;
            pnlServicesButtons.Controls.Add(btnTeaching);
            pnlServicesButtons.Controls.Add(btnHealthcare);
            pnlServicesButtons.Controls.Add(btnFireProtection);
            pnlServicesButtons.Controls.Add(btnMailDelivery);
            pnlServicesButtons.Controls.Add(btnTrashCollection);
            pnlServicesButtons.Controls.Add(btnTransportation);
            pnlServicesButtons.Location = new Point(30, 210);
            pnlServicesButtons.Name = "pnlServicesButtons";
            pnlServicesButtons.Size = new Size(740, 80);
            pnlServicesButtons.TabIndex = 4;
            // 
            // btnTeaching
            // 
            btnTeaching.BackColor = Color.LightGray;
            btnTeaching.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnTeaching.Location = new Point(10, 20);
            btnTeaching.Name = "btnTeaching";
            btnTeaching.Size = new Size(110, 40);
            btnTeaching.TabIndex = 0;
            btnTeaching.Text = "🎓 Teaching";
            btnTeaching.UseVisualStyleBackColor = false;
            btnTeaching.Click += new System.EventHandler(this.btnTeaching_Click);
            // 
            // btnHealthcare
            // 
            btnHealthcare.BackColor = Color.LightGray;
            btnHealthcare.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnHealthcare.Location = new Point(130, 20);
            btnHealthcare.Name = "btnHealthcare";
            btnHealthcare.Size = new Size(110, 40);
            btnHealthcare.TabIndex = 1;
            btnHealthcare.Text = "🏥 Healthcare";
            btnHealthcare.UseVisualStyleBackColor = false;
            btnHealthcare.Click += new System.EventHandler(this.btnHealthcare_Click);
            // 
            // btnFireProtection
            // 
            btnFireProtection.BackColor = Color.LightGray;
            btnFireProtection.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnFireProtection.Location = new Point(250, 20);
            btnFireProtection.Name = "btnFireProtection";
            btnFireProtection.Size = new Size(110, 40);
            btnFireProtection.TabIndex = 2;
            btnFireProtection.Text = "🚒 Fire Safety";
            btnFireProtection.UseVisualStyleBackColor = false;
            btnFireProtection.Click += new System.EventHandler(this.btnFireProtection_Click);
            // 
            // btnMailDelivery
            // 
            btnMailDelivery.BackColor = Color.LightGray;
            btnMailDelivery.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnMailDelivery.Location = new Point(370, 20);
            btnMailDelivery.Name = "btnMailDelivery";
            btnMailDelivery.Size = new Size(110, 40);
            btnMailDelivery.TabIndex = 3;
            btnMailDelivery.Text = "📬 Mail";
            btnMailDelivery.UseVisualStyleBackColor = false;
            btnMailDelivery.Click += new System.EventHandler(this.btnMailDelivery_Click);
            // 
            // btnTrashCollection
            // 
            btnTrashCollection.BackColor = Color.LightGray;
            btnTrashCollection.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnTrashCollection.Location = new Point(490, 20);
            btnTrashCollection.Name = "btnTrashCollection";
            btnTrashCollection.Size = new Size(110, 40);
            btnTrashCollection.TabIndex = 4;
            btnTrashCollection.Text = "🗑️ Trash";
            btnTrashCollection.UseVisualStyleBackColor = false;
            btnTrashCollection.Click += new System.EventHandler(this.btnTrashCollection_Click);
            // 
            // btnTransportation
            // 
            btnTransportation.BackColor = Color.LightGray;
            btnTransportation.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnTransportation.Location = new Point(610, 20);
            btnTransportation.Name = "btnTransportation";
            btnTransportation.Size = new Size(110, 40);
            btnTransportation.TabIndex = 5;
            btnTransportation.Text = "🚌 Transport";
            btnTransportation.UseVisualStyleBackColor = false;
            btnTransportation.Click += new System.EventHandler(this.btnTransportation_Click);
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.AliceBlue;
            pnlContent.Controls.Add(lblItemTitle);
            pnlContent.Controls.Add(lblDescription);
            pnlContent.Controls.Add(lblWhoMakesProvides);
            pnlContent.Controls.Add(lblWhyImportant);
            pnlContent.Controls.Add(lblGeorgiaExample);
            pnlContent.Controls.Add(lblEverydayUse);
            pnlContent.Location = new Point(30, 300);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(740, 180);
            pnlContent.TabIndex = 5;
            // 
            // lblItemTitle
            // 
            lblItemTitle.AutoSize = true;
            lblItemTitle.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            lblItemTitle.ForeColor = Color.DarkRed;
            lblItemTitle.Location = new Point(20, 15);
            lblItemTitle.Name = "lblItemTitle";
            lblItemTitle.Size = new Size(300, 26);
            lblItemTitle.TabIndex = 0;
            lblItemTitle.Text = "Choose a good or service above!";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Comic Sans MS", 11F);
            lblDescription.ForeColor = Color.DarkBlue;
            lblDescription.Location = new Point(20, 50);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(700, 25);
            lblDescription.TabIndex = 1;
            // 
            // lblWhoMakesProvides
            // 
            lblWhoMakesProvides.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblWhoMakesProvides.ForeColor = Color.DarkGreen;
            lblWhoMakesProvides.Location = new Point(20, 80);
            lblWhoMakesProvides.Name = "lblWhoMakesProvides";
            lblWhoMakesProvides.Size = new Size(700, 20);
            lblWhoMakesProvides.TabIndex = 2;
            // 
            // lblWhyImportant
            // 
            lblWhyImportant.Font = new Font("Comic Sans MS", 10F);
            lblWhyImportant.ForeColor = Color.Purple;
            lblWhyImportant.Location = new Point(20, 105);
            lblWhyImportant.Name = "lblWhyImportant";
            lblWhyImportant.Size = new Size(700, 20);
            lblWhyImportant.TabIndex = 3;
            // 
            // lblGeorgiaExample
            // 
            lblGeorgiaExample.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblGeorgiaExample.ForeColor = Color.DarkOrange;
            lblGeorgiaExample.Location = new Point(20, 130);
            lblGeorgiaExample.Name = "lblGeorgiaExample";
            lblGeorgiaExample.Size = new Size(700, 20);
            lblGeorgiaExample.TabIndex = 4;
            // 
            // lblEverydayUse
            // 
            lblEverydayUse.Font = new Font("Comic Sans MS", 10F);
            lblEverydayUse.ForeColor = Color.DarkBlue;
            lblEverydayUse.Location = new Point(20, 155);
            lblEverydayUse.Name = "lblEverydayUse";
            lblEverydayUse.Size = new Size(700, 20);
            lblEverydayUse.TabIndex = 5;
            // 
            // btnShowGoods
            // 
            btnShowGoods.BackColor = Color.LightBlue;
            btnShowGoods.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnShowGoods.Location = new Point(100, 500);
            btnShowGoods.Name = "btnShowGoods";
            btnShowGoods.Size = new Size(120, 40);
            btnShowGoods.TabIndex = 6;
            btnShowGoods.Text = "Show GOODS";
            btnShowGoods.UseVisualStyleBackColor = false;
            btnShowGoods.Click += new System.EventHandler(this.btnShowGoods_Click);
            // 
            // btnShowServices
            // 
            btnShowServices.BackColor = Color.LightGreen;
            btnShowServices.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnShowServices.Location = new Point(240, 500);
            btnShowServices.Name = "btnShowServices";
            btnShowServices.Size = new Size(120, 40);
            btnShowServices.TabIndex = 7;
            btnShowServices.Text = "Show SERVICES";
            btnShowServices.UseVisualStyleBackColor = false;
            btnShowServices.Click += new System.EventHandler(this.btnShowServices_Click);
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightGreen;
            btnNext.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnNext.Location = new Point(690, 500);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 40);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next →";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.LightCoral;
            btnPrevious.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnPrevious.Location = new Point(30, 500);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(80, 40);
            btnPrevious.TabIndex = 9;
            btnPrevious.Text = "← Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnBackToUnit3Ch2
            // 
            btnBackToUnit3Ch2.BackColor = Color.LightPink;
            btnBackToUnit3Ch2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnBackToUnit3Ch2.Location = new Point(380, 500);
            btnBackToUnit3Ch2.Name = "btnBackToUnit3Ch2";
            btnBackToUnit3Ch2.Size = new Size(120, 40);
            btnBackToUnit3Ch2.TabIndex = 10;
            btnBackToUnit3Ch2.Text = "Back to Unit 3";
            btnBackToUnit3Ch2.UseVisualStyleBackColor = false;
            btnBackToUnit3Ch2.Click += new System.EventHandler(this.btnBackToUnit3Ch2_Click);
            // 
            // btnToUnit4Ch2
            // 
            btnToUnit4Ch2.BackColor = Color.LightCyan;
            btnToUnit4Ch2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnToUnit4Ch2.Location = new Point(510, 500);
            btnToUnit4Ch2.Name = "btnToUnit4Ch2";
            btnToUnit4Ch2.Size = new Size(120, 40);
            btnToUnit4Ch2.TabIndex = 11;
            btnToUnit4Ch2.Text = "To Unit 4 Ch 2 →";
            btnToUnit4Ch2.UseVisualStyleBackColor = false;
            btnToUnit4Ch2.Click += new System.EventHandler(this.btnToUnit4Ch2_Click);
            // 
            // btnGoodsServicesGame
            // 
            btnGoodsServicesGame.BackColor = Color.Gold;
            btnGoodsServicesGame.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnGoodsServicesGame.Location = new Point(520, 500);
            btnGoodsServicesGame.Name = "btnGoodsServicesGame";
            btnGoodsServicesGame.Size = new Size(80, 40);
            btnGoodsServicesGame.TabIndex = 11;
            btnGoodsServicesGame.Text = "🎮 Game";
            btnGoodsServicesGame.UseVisualStyleBackColor = false;
            btnGoodsServicesGame.Click += new System.EventHandler(this.btnGoodsServicesGame_Click);
            // 
            // btnEconomicsQuiz
            // 
            btnEconomicsQuiz.BackColor = Color.Orange;
            btnEconomicsQuiz.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnEconomicsQuiz.Location = new Point(620, 500);
            btnEconomicsQuiz.Name = "btnEconomicsQuiz";
            btnEconomicsQuiz.Size = new Size(80, 40);
            btnEconomicsQuiz.TabIndex = 12;
            btnEconomicsQuiz.Text = "📝 Quiz";
            btnEconomicsQuiz.UseVisualStyleBackColor = false;
            btnEconomicsQuiz.Click += new System.EventHandler(this.btnEconomicsQuiz_Click);
            // 
            // Unit_4_Ch_1__SS1E1_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 560);
            Controls.Add(btnEconomicsQuiz);
            Controls.Add(btnGoodsServicesGame);
            Controls.Add(btnBackToUnit3Ch2);
            Controls.Add(btnToUnit4Ch2);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnShowServices);
            Controls.Add(btnShowGoods);
            Controls.Add(pnlContent);
            Controls.Add(pnlServicesButtons);
            Controls.Add(pnlGoodsButtons);
            Controls.Add(lblCurrentType);
            Controls.Add(lblStandard);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Unit_4_Ch_1__SS1E1_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TTS Components - Unit 4 Ch 1: Goods and Services";
            pnlGoodsButtons.ResumeLayout(false);
            pnlServicesButtons.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStandard;
        private Label lblCurrentType;
        private Panel pnlGoodsButtons;
        private Button btnFood;
        private Button btnClothes;
        private Button btnBooks;
        private Button btnToys;
        private Button btnHouses;
        private Button btnCars;
        private Panel pnlServicesButtons;
        private Button btnTeaching;
        private Button btnHealthcare;
        private Button btnFireProtection;
        private Button btnMailDelivery;
        private Button btnTrashCollection;
        private Button btnTransportation;
        private Panel pnlContent;
        private Label lblItemTitle;
        private Label lblDescription;
        private Label lblWhoMakesProvides;
        private Label lblWhyImportant;
        private Label lblGeorgiaExample;
        private Label lblEverydayUse;
        private Button btnShowGoods;
        private Button btnShowServices;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnBackToUnit3Ch2;
        private Button btnToUnit4Ch2;
        private Button btnGoodsServicesGame;
        private Button btnEconomicsQuiz;
    }
}