using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class YahtzeeGame : Form
    {

        ScoreCard myScoreCard = new ScoreCard();
        int RollCounter = 0;

        bool diceOneClicked = false, diceTwoClicked = false, diceThreeClicked = false, diceFourClicked = false, diceFiveClicked = false;
       





        int diceOneValue, diceTwoValue, diceThreeValue, diceFourValue, diceFiveValue;

        private void dice4_Click(object sender, EventArgs e)
        {
            if (!diceFourClicked)
            {
                diceFourClicked = true;
                myScoreCard.tempArrayOfDice[3] = Convert.ToInt32(dice4.Text);
                //dice4.Text = "";
                dice4.BackColor = Color.LightBlue;
            }
        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            if (RollCounter < 3)
            {
                rollAllDice();
                RollCounter++;
            }
        }

        private void dice5_Click(object sender, EventArgs e)
        {
            if (!diceFiveClicked)
            {
                diceFiveClicked = true;
                myScoreCard.tempArrayOfDice[4] = Convert.ToInt32(dice5.Text);
                //dice5.Text = "";
                dice5.BackColor = Color.LightBlue;
            }
        }

        private void dice3_Click(object sender, EventArgs e)
        {
            if (!diceThreeClicked)
            {
                diceThreeClicked = true;
                myScoreCard.tempArrayOfDice[2] = Convert.ToInt32(dice3.Text);
                //dice3.Text = "";
                dice3.BackColor = Color.LightBlue;
            }
        }

        private void dice2_Click(object sender, EventArgs e)
        {
            if (!diceTwoClicked)
            {
                diceTwoClicked = true;
                myScoreCard.tempArrayOfDice[1] = Convert.ToInt32(dice2.Text);
                //dice2.Text = "";
                dice2.BackColor = Color.LightBlue;
            }
        }

        private void dice1_Click(object sender, EventArgs e)
        {
            if (!diceOneClicked)
            {
                diceOneClicked = true;
                myScoreCard.tempArrayOfDice[0] = Convert.ToInt32(dice1.Text);
                //dice1.Text = "";
                dice1.BackColor = Color.LightBlue;
            }
        }

        

        public void resetPlayTurn()
        {
            RollCounter = 0;
            for (int i = 0; i < 5; i++)
            {
                myScoreCard.tempArrayOfDice[i] = 0;
            }
            dice1.Text = "";
            dice2.Text = "";
            dice3.Text = "";
            dice4.Text = "";
            dice5.Text = "";
            diceOneClicked = false;
            diceTwoClicked = false;
            diceThreeClicked = false;
            diceFourClicked = false;
            diceFiveClicked = false;
            dice1.BackColor = Color.LightGray;
            dice2.BackColor = Color.LightGray;
            dice3.BackColor = Color.LightGray;
            dice4.BackColor = Color.LightGray;
            dice5.BackColor = Color.LightGray;
        }

        public void scoreButtonClick(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            if (buttonText == "Total:")
            {
                totalField.Text = myScoreCard.totalScore.ToString();
            }
            else if (diceOneClicked && diceTwoClicked && diceThreeClicked && diceFourClicked && diceFiveClicked)
            {
                switch (buttonText)
                {
                    case "Ones":
                        if (myScoreCard.scoreArray[0] == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] == 1)
                                {
                                    myScoreCard.addScore(1, 0);
                                }
                            }
                            onesField.Text = myScoreCard.scoreArray[0].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Twos":
                        if (myScoreCard.scoreArray[1] == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] == 2)
                                {
                                    myScoreCard.addScore(2, 1);
                                }
                            }
                            twosField.Text = myScoreCard.scoreArray[1].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Threes":
                        if (myScoreCard.scoreArray[2] == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] == 3)
                                {
                                    myScoreCard.addScore(3, 2);
                                }
                            }
                            threesField.Text = myScoreCard.scoreArray[2].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Fours":
                        if (myScoreCard.scoreArray[3] == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] == 4)
                                {
                                    myScoreCard.addScore(4, 3);
                                }
                            }
                            foursField.Text = myScoreCard.scoreArray[3].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Fives":
                        if (myScoreCard.scoreArray[4] == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] == 5)
                                {
                                    myScoreCard.addScore(5, 4);
                                }
                            }
                            fivesField.Text = myScoreCard.scoreArray[4].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Sixes":
                        if (myScoreCard.scoreArray[5] == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] == 6)
                                {
                                    myScoreCard.addScore(6, 5);
                                }
                            }
                            sixesField.Text = myScoreCard.scoreArray[5].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Three Of A Kind":
                        if (myScoreCard.scoreArray[6] == 0)
                        {
                            Array.Sort(myScoreCard.tempArrayOfDice);
                            for (int i = 0; i < 3; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] == myScoreCard.tempArrayOfDice[i + 1] &&
                                    myScoreCard.tempArrayOfDice[i + 1] == myScoreCard.tempArrayOfDice[i + 2])
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        myScoreCard.addScore(myScoreCard.tempArrayOfDice[j], 6);
                                    }
                                    threeOfAKindField.Text = myScoreCard.scoreArray[6].ToString();
                                    i = 3;
                                }
                            }
                            resetPlayTurn();
                        }
                        break;
                    case "Four Of A Kind":
                        if (myScoreCard.scoreArray[7] == 0)
                        {
                            Array.Sort(myScoreCard.tempArrayOfDice);
                            for (int i = 0; i < 2; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] == myScoreCard.tempArrayOfDice[i + 1] &&
                                    myScoreCard.tempArrayOfDice[i + 1] == myScoreCard.tempArrayOfDice[i + 2] &&
                                    myScoreCard.tempArrayOfDice[i + 2] == myScoreCard.tempArrayOfDice[i + 3])
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        myScoreCard.addScore(myScoreCard.tempArrayOfDice[j], 7);
                                    }
                                    fourOfAKindField.Text = myScoreCard.scoreArray[7].ToString();
                                    i = 2;
                                }
                            }
                            resetPlayTurn();
                        }
                        break;
                    case "Full House":
                        if (myScoreCard.scoreArray[8] == 0)
                        {
                            Array.Sort(myScoreCard.tempArrayOfDice);
                            if ((myScoreCard.tempArrayOfDice[0] == myScoreCard.tempArrayOfDice[1] &&
                                myScoreCard.tempArrayOfDice[2] == myScoreCard.tempArrayOfDice[3] &&
                                myScoreCard.tempArrayOfDice[3] == myScoreCard.tempArrayOfDice[4]) ||
                                (myScoreCard.tempArrayOfDice[0] == myScoreCard.tempArrayOfDice[1] &&
                                myScoreCard.tempArrayOfDice[1] == myScoreCard.tempArrayOfDice[2] &&
                                myScoreCard.tempArrayOfDice[3] == myScoreCard.tempArrayOfDice[4]))
                            {
                                myScoreCard.addScore(25, 8);
                            }
                            fullHouseField.Text = myScoreCard.scoreArray[8].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Small Straight":
                        if (myScoreCard.scoreArray[9] == 0)
                        {
                            Array.Sort(myScoreCard.tempArrayOfDice);
                            for (int i = 0; i < 5; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] == myScoreCard.tempArrayOfDice[i + 1])
                                {
                                    for (int j = i + 1; j < 4; j++)
                                    {
                                        myScoreCard.tempArrayOfDice[j] = myScoreCard.tempArrayOfDice[j + 1];
                                    }
                                }
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                if (myScoreCard.tempArrayOfDice[i] + 1 == myScoreCard.tempArrayOfDice[i + 1] &&
                                    myScoreCard.tempArrayOfDice[i + 1] + 1 == myScoreCard.tempArrayOfDice[i + 2] &&
                                    myScoreCard.tempArrayOfDice[i + 2] + 1 == myScoreCard.tempArrayOfDice[i + 3])
                                {
                                    myScoreCard.addScore(30, 9);
                                }
                                i = 2;
                            }
                            smallStraightField.Text = myScoreCard.scoreArray[9].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Large Straight":
                        if (myScoreCard.scoreArray[10] == 0)
                        {
                            if (myScoreCard.tempArrayOfDice[0] + 1 == myScoreCard.tempArrayOfDice[1] &&
                                myScoreCard.tempArrayOfDice[1] + 1 == myScoreCard.tempArrayOfDice[2] &&
                                myScoreCard.tempArrayOfDice[2] + 1 == myScoreCard.tempArrayOfDice[3] &&
                                myScoreCard.tempArrayOfDice[3] + 1 == myScoreCard.tempArrayOfDice[4])
                            {
                                myScoreCard.addScore(40, 10);
                            }
                            largeStraightField.Text = myScoreCard.scoreArray[10].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Chance":
                        if (myScoreCard.scoreArray[11] == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                myScoreCard.addScore(myScoreCard.tempArrayOfDice[i], 11);
                            }
                            chanceField.Text = myScoreCard.scoreArray[11].ToString();
                            resetPlayTurn();
                        }
                        break;
                    case "Yahtzee":
                        if (myScoreCard.scoreArray[12] == 0)
                        {
                            if (myScoreCard.tempArrayOfDice[0] == myScoreCard.tempArrayOfDice[1] &&
                                myScoreCard.tempArrayOfDice[1] == myScoreCard.tempArrayOfDice[2] &&
                                myScoreCard.tempArrayOfDice[2] == myScoreCard.tempArrayOfDice[3] &&
                                myScoreCard.tempArrayOfDice[3] == myScoreCard.tempArrayOfDice[4])
                            {
                                myScoreCard.addScore(50, 12);
                            }
                            yahtzeeFIeld.Text = myScoreCard.scoreArray[12].ToString();
                            resetPlayTurn();
                        }
                        break;
                }
            }
        }



        public YahtzeeGame()
        {
            InitializeComponent();
            
            //Code used and changed from Stackoverflow
            onesButton.Click += new EventHandler(scoreButtonClick);
            twosButton.Click += new EventHandler(scoreButtonClick);
            threesButton.Click += new EventHandler(scoreButtonClick);
            foursButton.Click += new EventHandler(scoreButtonClick);
            fivesButton.Click += new EventHandler(scoreButtonClick);
            sixesButton.Click += new EventHandler(scoreButtonClick);
            threeOfAKindButton.Click += new EventHandler(scoreButtonClick);
            fourOfAKindButton.Click += new EventHandler(scoreButtonClick);
            fullHouseButton.Click += new EventHandler(scoreButtonClick);
            smallStraightButton.Click += new EventHandler(scoreButtonClick);
            largeStraightButton.Click += new EventHandler(scoreButtonClick);
            chanceButton.Click += new EventHandler(scoreButtonClick);
            yahtzeeButton.Click += new EventHandler(scoreButtonClick);
            total.Click += new EventHandler(scoreButtonClick);
        }

        public void rollAllDice()
        {
            Random random = new Random();
            if (!diceOneClicked)
            {
                diceOneValue = 1;// random.Next(1, 7);
                dice1.Text = diceOneValue.ToString();
            }

            if (!diceTwoClicked)
            {
                diceTwoValue = 2;// random.Next(1, 7);
                dice2.Text = diceTwoValue.ToString();
            }

            if (!diceThreeClicked)
            {
                diceThreeValue = 3;// random.Next(1, 7);
                dice3.Text = diceThreeValue.ToString();

            }

            if (!diceFourClicked)
            {
                diceFourValue = 3;// random.Next(1, 7);
                dice4.Text = diceFourValue.ToString();
            }

            if (!diceFiveClicked)
            {
                diceFiveValue = 4;//  random.Next(1, 7);
                dice5.Text = diceFiveValue.ToString();
            }




        }


    }

    public class ScoreCard
    {
        public int totalScore = 0;
        public int[] scoreArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] tempArrayOfDice = { 0, 0, 0, 0, 0 };
        public ScoreCard()
        {

        }

        public void addScore(int score, int indexOfScoreArray)
        {
            scoreArray[indexOfScoreArray] += score;
            totalScore += score;
        }

    }

}
