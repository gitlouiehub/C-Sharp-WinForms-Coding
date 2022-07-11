using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    /*
     * <author>Luis Munoz<author/>
     * <summary>In the game Rock Paper Scissors, two players simultaneously choose one of three 
            options: rock, paper, or scissors. If both players choose the same option, then the 
            result is a tie. However, if they choose differently, the winner is determined as follows:
            • Rock beats scissors, because a rock can break a pair of scissors.
            • Scissors beats paper, because scissors can cut paper.
            • Paper beats rock, because a piece of paper can cover a rock
            Create a game in which the computer randomly chooses rock, paper, or scissors. Let 
            the user enter a character, r, p, or s, each representing one of the three choices. Then, 
            determine the winner
        <summary/>
     * */
    public partial class RockPaperScissorsForm : Form
    {
        public RockPaperScissorsForm()
        {
            InitializeComponent();
        }

        enum PlayerTwo
        {
            ROCK = 0, PAPER, SCISSORS 
        }
        enum PlayerOne
        {
            ROCK = 'r', PAPER = 'p', SCISSORS = 's'

        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            //initialize variables and random object
            Random random = new Random();
            bool playerOneHasRock = false, playerOneHasPaper = false, playerOneHasScissors = false;
            bool playerTwoHasRock = false, playerTwoHasPaper = false, playerTwoHasScissors = false;
            bool tie = false;

            //determine player one choice
            char playerOne = Convert.ToChar(inputTextBox.Text);
            switch ((PlayerOne)playerOne)
            {
                case PlayerOne.ROCK: playerOneHasRock = true;
                    break;
                case PlayerOne.PAPER: playerOneHasPaper = true;
                    break;
                case PlayerOne.SCISSORS: playerOneHasScissors = true;
                    break;
                default:
                    break;
            }

            //determine player two choice and test to see if there is a tie
            int randomGenerator = random.Next(0, 3);
            switch ((PlayerTwo)randomGenerator)
            {
                case PlayerTwo.ROCK:
                    playerTwoHasRock = true;
                    tie = playerTwoHasRock == playerOneHasRock ? true : false;
                    break;
                case PlayerTwo.PAPER:
                    playerTwoHasPaper = true;
                    tie = playerTwoHasPaper == playerOneHasPaper ? true : false;
                    break;
                case PlayerTwo.SCISSORS:
                    playerTwoHasScissors = true;
                    tie = playerTwoHasScissors == playerOneHasScissors ? true : false;
                    break;
                default:
                    break;
            }

            //LOGIC
            if (!tie)
            {
                if (playerOneHasRock && playerTwoHasScissors || playerOneHasScissors && playerTwoHasPaper || playerOneHasPaper && playerTwoHasRock)
                {
                    outputLabel.Text = $"YOU HAVE {(PlayerOne)playerOne}, PLAYER TWO HAS {(PlayerTwo)randomGenerator}, YOU WIN!";
                }
                else
                {
                    outputLabel.Text = $"YOU HAVE {(PlayerOne)playerOne}, PLAYER TWO HAS {(PlayerTwo)randomGenerator}, YOU LOST...";
                }
            }
            else
            {
                outputLabel.Text = $"YOU HAVE {(PlayerOne)playerOne}, PLAYER TWO HAS {(PlayerTwo)randomGenerator}, IT'S A TIE";
            }

            //reset
            inputTextBox.SelectAll();
            inputTextBox.Focus();
            outputLabel.Visible = true;
        }
    }
}
