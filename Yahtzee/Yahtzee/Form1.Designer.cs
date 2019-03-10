namespace Yahtzee
{
    partial class YahtzeeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YahtzeeGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.Button();
            this.dice5 = new System.Windows.Forms.Button();
            this.dice3 = new System.Windows.Forms.Button();
            this.dice2 = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.Button();
            this.rollDice = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.Button();
            this.totalField = new System.Windows.Forms.Label();
            this.yahtzeeFIeld = new System.Windows.Forms.Label();
            this.chanceField = new System.Windows.Forms.Label();
            this.largeStraightField = new System.Windows.Forms.Label();
            this.smallStraightField = new System.Windows.Forms.Label();
            this.chanceButton = new System.Windows.Forms.Button();
            this.fullHouseField = new System.Windows.Forms.Label();
            this.yahtzeeButton = new System.Windows.Forms.Button();
            this.fourOfAKindField = new System.Windows.Forms.Label();
            this.smallStraightButton = new System.Windows.Forms.Button();
            this.threeOfAKindField = new System.Windows.Forms.Label();
            this.largeStraightButton = new System.Windows.Forms.Button();
            this.sixesField = new System.Windows.Forms.Label();
            this.sixesButton = new System.Windows.Forms.Button();
            this.fivesField = new System.Windows.Forms.Label();
            this.threeOfAKindButton = new System.Windows.Forms.Button();
            this.foursField = new System.Windows.Forms.Label();
            this.fourOfAKindButton = new System.Windows.Forms.Button();
            this.threesField = new System.Windows.Forms.Label();
            this.fullHouseButton = new System.Windows.Forms.Button();
            this.twosField = new System.Windows.Forms.Label();
            this.fivesButton = new System.Windows.Forms.Button();
            this.onesField = new System.Windows.Forms.Label();
            this.foursButton = new System.Windows.Forms.Button();
            this.threesButton = new System.Windows.Forms.Button();
            this.twosButton = new System.Windows.Forms.Button();
            this.onesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.scores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // dice4
            // 
            this.dice4.BackColor = System.Drawing.Color.LightGray;
            this.dice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice4.Location = new System.Drawing.Point(237, 85);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(61, 56);
            this.dice4.TabIndex = 27;
            this.dice4.UseVisualStyleBackColor = false;
            this.dice4.Click += new System.EventHandler(this.dice4_Click);
            // 
            // dice5
            // 
            this.dice5.BackColor = System.Drawing.Color.LightGray;
            this.dice5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice5.Location = new System.Drawing.Point(237, 12);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(61, 56);
            this.dice5.TabIndex = 26;
            this.dice5.UseVisualStyleBackColor = false;
            this.dice5.Click += new System.EventHandler(this.dice5_Click);
            // 
            // dice3
            // 
            this.dice3.BackColor = System.Drawing.Color.LightGray;
            this.dice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice3.Location = new System.Drawing.Point(124, 85);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(61, 56);
            this.dice3.TabIndex = 25;
            this.dice3.UseVisualStyleBackColor = false;
            this.dice3.Click += new System.EventHandler(this.dice3_Click);
            // 
            // dice2
            // 
            this.dice2.BackColor = System.Drawing.Color.LightGray;
            this.dice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice2.Location = new System.Drawing.Point(12, 85);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(61, 56);
            this.dice2.TabIndex = 24;
            this.dice2.UseVisualStyleBackColor = false;
            this.dice2.Click += new System.EventHandler(this.dice2_Click);
            // 
            // dice1
            // 
            this.dice1.BackColor = System.Drawing.Color.LightGray;
            this.dice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice1.Location = new System.Drawing.Point(12, 12);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(61, 56);
            this.dice1.TabIndex = 23;
            this.dice1.UseVisualStyleBackColor = false;
            this.dice1.Click += new System.EventHandler(this.dice1_Click);
            // 
            // rollDice
            // 
            this.rollDice.BackColor = System.Drawing.Color.LightGray;
            this.rollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDice.Location = new System.Drawing.Point(92, 12);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(127, 56);
            this.rollDice.TabIndex = 22;
            this.rollDice.Text = "Roll Dice";
            this.rollDice.UseVisualStyleBackColor = false;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // scores
            // 
            this.scores.Controls.Add(this.total);
            this.scores.Controls.Add(this.totalField);
            this.scores.Controls.Add(this.yahtzeeFIeld);
            this.scores.Controls.Add(this.chanceField);
            this.scores.Controls.Add(this.largeStraightField);
            this.scores.Controls.Add(this.smallStraightField);
            this.scores.Controls.Add(this.chanceButton);
            this.scores.Controls.Add(this.fullHouseField);
            this.scores.Controls.Add(this.yahtzeeButton);
            this.scores.Controls.Add(this.fourOfAKindField);
            this.scores.Controls.Add(this.smallStraightButton);
            this.scores.Controls.Add(this.threeOfAKindField);
            this.scores.Controls.Add(this.largeStraightButton);
            this.scores.Controls.Add(this.sixesField);
            this.scores.Controls.Add(this.sixesButton);
            this.scores.Controls.Add(this.fivesField);
            this.scores.Controls.Add(this.threeOfAKindButton);
            this.scores.Controls.Add(this.foursField);
            this.scores.Controls.Add(this.fourOfAKindButton);
            this.scores.Controls.Add(this.threesField);
            this.scores.Controls.Add(this.fullHouseButton);
            this.scores.Controls.Add(this.twosField);
            this.scores.Controls.Add(this.fivesButton);
            this.scores.Controls.Add(this.onesField);
            this.scores.Controls.Add(this.foursButton);
            this.scores.Controls.Add(this.threesButton);
            this.scores.Controls.Add(this.twosButton);
            this.scores.Controls.Add(this.onesButton);
            this.scores.Location = new System.Drawing.Point(317, 7);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(200, 426);
            this.scores.TabIndex = 21;
            this.scores.TabStop = false;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.LightGray;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(11, 398);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(75, 23);
            this.total.TabIndex = 28;
            this.total.Text = "Total:";
            this.total.UseVisualStyleBackColor = false;
            // 
            // totalField
            // 
            this.totalField.AutoSize = true;
            this.totalField.BackColor = System.Drawing.SystemColors.Control;
            this.totalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalField.Location = new System.Drawing.Point(146, 398);
            this.totalField.Name = "totalField";
            this.totalField.Size = new System.Drawing.Size(0, 20);
            this.totalField.TabIndex = 27;
            // 
            // yahtzeeFIeld
            // 
            this.yahtzeeFIeld.AutoSize = true;
            this.yahtzeeFIeld.BackColor = System.Drawing.SystemColors.Control;
            this.yahtzeeFIeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yahtzeeFIeld.Location = new System.Drawing.Point(147, 372);
            this.yahtzeeFIeld.Name = "yahtzeeFIeld";
            this.yahtzeeFIeld.Size = new System.Drawing.Size(0, 20);
            this.yahtzeeFIeld.TabIndex = 26;
            // 
            // chanceField
            // 
            this.chanceField.AutoSize = true;
            this.chanceField.BackColor = System.Drawing.SystemColors.Control;
            this.chanceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceField.Location = new System.Drawing.Point(146, 346);
            this.chanceField.Name = "chanceField";
            this.chanceField.Size = new System.Drawing.Size(0, 20);
            this.chanceField.TabIndex = 25;
            // 
            // largeStraightField
            // 
            this.largeStraightField.AutoSize = true;
            this.largeStraightField.BackColor = System.Drawing.SystemColors.Control;
            this.largeStraightField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeStraightField.Location = new System.Drawing.Point(146, 314);
            this.largeStraightField.Name = "largeStraightField";
            this.largeStraightField.Size = new System.Drawing.Size(0, 20);
            this.largeStraightField.TabIndex = 24;
            // 
            // smallStraightField
            // 
            this.smallStraightField.AutoSize = true;
            this.smallStraightField.BackColor = System.Drawing.SystemColors.Control;
            this.smallStraightField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallStraightField.Location = new System.Drawing.Point(147, 281);
            this.smallStraightField.Name = "smallStraightField";
            this.smallStraightField.Size = new System.Drawing.Size(0, 20);
            this.smallStraightField.TabIndex = 23;
            // 
            // chanceButton
            // 
            this.chanceButton.BackColor = System.Drawing.Color.LightGray;
            this.chanceButton.Location = new System.Drawing.Point(11, 340);
            this.chanceButton.Name = "chanceButton";
            this.chanceButton.Size = new System.Drawing.Size(75, 23);
            this.chanceButton.TabIndex = 14;
            this.chanceButton.Text = "Chance";
            this.chanceButton.UseVisualStyleBackColor = false;
            // 
            // fullHouseField
            // 
            this.fullHouseField.AutoSize = true;
            this.fullHouseField.BackColor = System.Drawing.SystemColors.Control;
            this.fullHouseField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullHouseField.Location = new System.Drawing.Point(146, 253);
            this.fullHouseField.Name = "fullHouseField";
            this.fullHouseField.Size = new System.Drawing.Size(0, 20);
            this.fullHouseField.TabIndex = 22;
            // 
            // yahtzeeButton
            // 
            this.yahtzeeButton.BackColor = System.Drawing.Color.LightGray;
            this.yahtzeeButton.Location = new System.Drawing.Point(11, 369);
            this.yahtzeeButton.Name = "yahtzeeButton";
            this.yahtzeeButton.Size = new System.Drawing.Size(75, 23);
            this.yahtzeeButton.TabIndex = 13;
            this.yahtzeeButton.Text = "Yahtzee";
            this.yahtzeeButton.UseVisualStyleBackColor = false;
            // 
            // fourOfAKindField
            // 
            this.fourOfAKindField.AutoSize = true;
            this.fourOfAKindField.BackColor = System.Drawing.SystemColors.Control;
            this.fourOfAKindField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourOfAKindField.Location = new System.Drawing.Point(147, 227);
            this.fourOfAKindField.Name = "fourOfAKindField";
            this.fourOfAKindField.Size = new System.Drawing.Size(0, 20);
            this.fourOfAKindField.TabIndex = 21;
            // 
            // smallStraightButton
            // 
            this.smallStraightButton.BackColor = System.Drawing.Color.LightGray;
            this.smallStraightButton.Location = new System.Drawing.Point(11, 282);
            this.smallStraightButton.Name = "smallStraightButton";
            this.smallStraightButton.Size = new System.Drawing.Size(95, 23);
            this.smallStraightButton.TabIndex = 12;
            this.smallStraightButton.Text = "Small Straight";
            this.smallStraightButton.UseVisualStyleBackColor = false;
            // 
            // threeOfAKindField
            // 
            this.threeOfAKindField.AutoSize = true;
            this.threeOfAKindField.BackColor = System.Drawing.SystemColors.Control;
            this.threeOfAKindField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeOfAKindField.Location = new System.Drawing.Point(147, 198);
            this.threeOfAKindField.Name = "threeOfAKindField";
            this.threeOfAKindField.Size = new System.Drawing.Size(0, 20);
            this.threeOfAKindField.TabIndex = 20;
            // 
            // largeStraightButton
            // 
            this.largeStraightButton.BackColor = System.Drawing.Color.LightGray;
            this.largeStraightButton.Location = new System.Drawing.Point(11, 311);
            this.largeStraightButton.Name = "largeStraightButton";
            this.largeStraightButton.Size = new System.Drawing.Size(95, 23);
            this.largeStraightButton.TabIndex = 11;
            this.largeStraightButton.Text = "Large Straight";
            this.largeStraightButton.UseVisualStyleBackColor = false;
            // 
            // sixesField
            // 
            this.sixesField.AutoSize = true;
            this.sixesField.BackColor = System.Drawing.SystemColors.Control;
            this.sixesField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixesField.Location = new System.Drawing.Point(147, 169);
            this.sixesField.Name = "sixesField";
            this.sixesField.Size = new System.Drawing.Size(0, 20);
            this.sixesField.TabIndex = 19;
            // 
            // sixesButton
            // 
            this.sixesButton.BackColor = System.Drawing.Color.LightGray;
            this.sixesButton.Location = new System.Drawing.Point(11, 166);
            this.sixesButton.Name = "sixesButton";
            this.sixesButton.Size = new System.Drawing.Size(75, 23);
            this.sixesButton.TabIndex = 10;
            this.sixesButton.Text = "Sixes";
            this.sixesButton.UseVisualStyleBackColor = false;
            // 
            // fivesField
            // 
            this.fivesField.AutoSize = true;
            this.fivesField.BackColor = System.Drawing.SystemColors.Control;
            this.fivesField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivesField.Location = new System.Drawing.Point(147, 140);
            this.fivesField.Name = "fivesField";
            this.fivesField.Size = new System.Drawing.Size(0, 20);
            this.fivesField.TabIndex = 18;
            // 
            // threeOfAKindButton
            // 
            this.threeOfAKindButton.BackColor = System.Drawing.Color.LightGray;
            this.threeOfAKindButton.Location = new System.Drawing.Point(11, 195);
            this.threeOfAKindButton.Name = "threeOfAKindButton";
            this.threeOfAKindButton.Size = new System.Drawing.Size(95, 23);
            this.threeOfAKindButton.TabIndex = 9;
            this.threeOfAKindButton.Text = "Three Of A Kind";
            this.threeOfAKindButton.UseVisualStyleBackColor = false;
            // 
            // foursField
            // 
            this.foursField.AutoSize = true;
            this.foursField.BackColor = System.Drawing.SystemColors.Control;
            this.foursField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foursField.Location = new System.Drawing.Point(147, 112);
            this.foursField.Name = "foursField";
            this.foursField.Size = new System.Drawing.Size(0, 20);
            this.foursField.TabIndex = 17;
            // 
            // fourOfAKindButton
            // 
            this.fourOfAKindButton.BackColor = System.Drawing.Color.LightGray;
            this.fourOfAKindButton.Location = new System.Drawing.Point(11, 224);
            this.fourOfAKindButton.Name = "fourOfAKindButton";
            this.fourOfAKindButton.Size = new System.Drawing.Size(95, 23);
            this.fourOfAKindButton.TabIndex = 8;
            this.fourOfAKindButton.Text = "Four Of A Kind";
            this.fourOfAKindButton.UseVisualStyleBackColor = false;
            // 
            // threesField
            // 
            this.threesField.AutoSize = true;
            this.threesField.BackColor = System.Drawing.SystemColors.Control;
            this.threesField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threesField.Location = new System.Drawing.Point(146, 86);
            this.threesField.Name = "threesField";
            this.threesField.Size = new System.Drawing.Size(0, 20);
            this.threesField.TabIndex = 16;
            // 
            // fullHouseButton
            // 
            this.fullHouseButton.BackColor = System.Drawing.Color.LightGray;
            this.fullHouseButton.Location = new System.Drawing.Point(11, 253);
            this.fullHouseButton.Name = "fullHouseButton";
            this.fullHouseButton.Size = new System.Drawing.Size(75, 23);
            this.fullHouseButton.TabIndex = 7;
            this.fullHouseButton.Text = "Full House";
            this.fullHouseButton.UseVisualStyleBackColor = false;
            // 
            // twosField
            // 
            this.twosField.AutoSize = true;
            this.twosField.BackColor = System.Drawing.SystemColors.Control;
            this.twosField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twosField.Location = new System.Drawing.Point(147, 54);
            this.twosField.Name = "twosField";
            this.twosField.Size = new System.Drawing.Size(0, 20);
            this.twosField.TabIndex = 15;
            // 
            // fivesButton
            // 
            this.fivesButton.BackColor = System.Drawing.Color.LightGray;
            this.fivesButton.Location = new System.Drawing.Point(11, 137);
            this.fivesButton.Name = "fivesButton";
            this.fivesButton.Size = new System.Drawing.Size(75, 23);
            this.fivesButton.TabIndex = 6;
            this.fivesButton.Text = "Fives";
            this.fivesButton.UseVisualStyleBackColor = false;
            // 
            // onesField
            // 
            this.onesField.AutoSize = true;
            this.onesField.BackColor = System.Drawing.SystemColors.Control;
            this.onesField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onesField.Location = new System.Drawing.Point(147, 25);
            this.onesField.Name = "onesField";
            this.onesField.Size = new System.Drawing.Size(0, 20);
            this.onesField.TabIndex = 14;
            // 
            // foursButton
            // 
            this.foursButton.BackColor = System.Drawing.Color.LightGray;
            this.foursButton.Location = new System.Drawing.Point(11, 106);
            this.foursButton.Name = "foursButton";
            this.foursButton.Size = new System.Drawing.Size(75, 23);
            this.foursButton.TabIndex = 5;
            this.foursButton.Text = "Fours";
            this.foursButton.UseVisualStyleBackColor = false;
            // 
            // threesButton
            // 
            this.threesButton.BackColor = System.Drawing.Color.LightGray;
            this.threesButton.Location = new System.Drawing.Point(11, 80);
            this.threesButton.Name = "threesButton";
            this.threesButton.Size = new System.Drawing.Size(75, 23);
            this.threesButton.TabIndex = 4;
            this.threesButton.Text = "Threes";
            this.threesButton.UseVisualStyleBackColor = false;
            // 
            // twosButton
            // 
            this.twosButton.BackColor = System.Drawing.Color.LightGray;
            this.twosButton.Location = new System.Drawing.Point(11, 51);
            this.twosButton.Name = "twosButton";
            this.twosButton.Size = new System.Drawing.Size(75, 23);
            this.twosButton.TabIndex = 3;
            this.twosButton.Text = "Twos";
            this.twosButton.UseVisualStyleBackColor = false;
            // 
            // onesButton
            // 
            this.onesButton.BackColor = System.Drawing.Color.LightGray;
            this.onesButton.Location = new System.Drawing.Point(11, 22);
            this.onesButton.Name = "onesButton";
            this.onesButton.Size = new System.Drawing.Size(75, 23);
            this.onesButton.TabIndex = 2;
            this.onesButton.Text = "Ones";
            this.onesButton.UseVisualStyleBackColor = false;
            // 
            // YahtzeeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.rollDice);
            this.Controls.Add(this.scores);
            this.Name = "YahtzeeGame";
            this.Text = "Yahtzee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.scores.ResumeLayout(false);
            this.scores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dice4;
        private System.Windows.Forms.Button dice5;
        private System.Windows.Forms.Button dice3;
        private System.Windows.Forms.Button dice2;
        private System.Windows.Forms.Button dice1;
        private System.Windows.Forms.Button rollDice;
        private System.Windows.Forms.GroupBox scores;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.Label totalField;
        private System.Windows.Forms.Label yahtzeeFIeld;
        private System.Windows.Forms.Label chanceField;
        private System.Windows.Forms.Label largeStraightField;
        private System.Windows.Forms.Label smallStraightField;
        private System.Windows.Forms.Button chanceButton;
        private System.Windows.Forms.Label fullHouseField;
        private System.Windows.Forms.Button yahtzeeButton;
        private System.Windows.Forms.Label fourOfAKindField;
        private System.Windows.Forms.Button smallStraightButton;
        private System.Windows.Forms.Label threeOfAKindField;
        private System.Windows.Forms.Button largeStraightButton;
        private System.Windows.Forms.Label sixesField;
        private System.Windows.Forms.Button sixesButton;
        private System.Windows.Forms.Label fivesField;
        private System.Windows.Forms.Button threeOfAKindButton;
        private System.Windows.Forms.Label foursField;
        private System.Windows.Forms.Button fourOfAKindButton;
        private System.Windows.Forms.Label threesField;
        private System.Windows.Forms.Button fullHouseButton;
        private System.Windows.Forms.Label twosField;
        private System.Windows.Forms.Button fivesButton;
        private System.Windows.Forms.Label onesField;
        private System.Windows.Forms.Button foursButton;
        private System.Windows.Forms.Button threesButton;
        private System.Windows.Forms.Button twosButton;
        private System.Windows.Forms.Button onesButton;
    }
}

