using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_With_AI
{
    public partial class MainForm : Form
    {
        private TokenType tokenType; //Calling TokenType class
        private List<Button> buttons; //Creating list of buttons
        private Random randomNumber = new Random(); //Import random number generator class

        private int playerWins, computerWins; //Show the score

        public MainForm()
        {
            ResetGame();
            InitializeComponent();
            ResetGame();
        }

        /// <summary>
        /// Computer will randomly choose a button from the list to click.
        /// While list count greater than 0,computer will operate  in the game
        /// </summary>
        /// TODOO!!!!!!!!!!!!!!!!!
        private void AImoves_Tick(object sender, EventArgs e)
        {
            int indexOfButton = randomNumber.Next(buttons.Count);//Generate a random number within the number of available buttons.

            var clickedButton = buttons[indexOfButton]; //Define a variable for increase readability.

            if (buttons.Count > 0 && clickedButton.Enabled)
            {
                clickedButton.Text = "O";   //Change text of clicked button

                clickedButton.BackColor = Color.Tomato; //Changing colors of clicked button

                clickedButton.Enabled = false; //Making disable clicked button for not to click again.
                buttons.Remove(clickedButton); //remove clicked button from the list.

                CheckWins(); //Check if the AI wins the game.
                AImoves.Stop(); //Stop the timer.
                tokenType = TokenType.Empty;
            }
            else
            {
                throw new Exception("Can not clicked because this button is not available");
            }

        }

        /// <summary>
        /// This event works each time when player clicks on the button.
        /// </summary>
        /// TODOO!!!!!!!!!!!!!!!!! USTTEKI FONKSIYON ILE SADELESTIR.
        private void PlayerClick(object sender, EventArgs e)
        {
            
            if (sender == null) return;
            var clickedButton = (Button)sender; //find which button was clicked.
            
            if (buttons.Count > 0 && clickedButton.Enabled && TokenType.Empty == tokenType)
            {
                tokenType = TokenType.Cross; //set player to x.
                clickedButton.Text = "X"; //Change text of clicked button

                clickedButton.BackColor = Color.LightSteelBlue; //Changing colors of clicked button

                clickedButton.Enabled = false; //Making disable clicked button for not to click again.
                buttons.Remove(clickedButton); //Selling from button list so AI can't click again.

                CheckWins();
                AImoves.Start(); //Start AI timer.
            }
            else
            {
                throw new Exception("Can not clicked because this button is not available");
            }
        }

        /// <summary>
        /// This function linked to the Reset function
        /// When clicked restart button,Reset function's process is starts
        /// </summary>
        private void RestartButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        /// <summary>
        /// This function's purpose is loads buttons from the form to the button list. 
        /// </summary>
        private void LoadButtons()
        {
            buttons = new List<Button>()
            {
                Button00, Button01, Button02,
                Button10, Button11, Button12,
                Button20, Button21, Button22
            };
        }

        private void ResetGame()
        {
            //Initialize each of the button
            foreach (var item in this.Controls)
            {
                if (item is Button playButton && playButton.Tag == "play") //Cast item to Button with
                    //is expression and check button tag
                {
                    tokenType = TokenType.Empty;
                    playButton.Enabled = true;
                    playButton.Text = "?";
                    playButton.BackColor = default(Color);
                }

                LoadButtons(); // run the LoadButtons function so all all the buttons are back in the list
            }
        }

        /// <summary>
        /// In this function we check if the player or the AI has won.
        /// </summary>
        private void CheckWins()
        {
            if ( //Check Horizontal Wins
                (Button00.Text == "X" && Button01.Text == "X" && Button02.Text == "X")
                || (Button10.Text == "X" && Button11.Text == "X" && Button12.Text == "X")
                || (Button20.Text == "X" && Button21.Text == "X" && Button22.Text == "X")

                //Check Vertical Wins.
                || (Button00.Text == "X" && Button10.Text == "X" && Button20.Text == "X")
                || (Button01.Text == "X" && Button11.Text == "X" && Button21.Text == "X")
                || (Button02.Text == "X" && Button12.Text == "X" && Button22.Text == "X")

                //Check Diagonal Wins
                || (Button00.Text == "X" && Button11.Text == "X" && Button22.Text == "X")
                || (Button02.Text == "X" && Button11.Text == "X" && Button20.Text == "X")
            )
            {
                AImoves.Stop();
                MessageBox.Show("Player Wins");
                playerWins++;
                Player_Wins_Label.Text = "Player Wins - " + playerWins; //Shows players score on the label
                ResetGame();
            }

            else if ( //Check Horizontal Wins
                (Button00.Text == "O" && Button01.Text == "O" && Button02.Text == "O")
                || (Button10.Text == "O" && Button11.Text == "O" && Button12.Text == "O")
                || (Button20.Text == "O" && Button21.Text == "O" && Button22.Text == "O")

                //Check Vertical Wins.
                || (Button00.Text == "O" && Button10.Text == "O" && Button20.Text == "O")
                || (Button01.Text == "O" && Button11.Text == "O" && Button21.Text == "O")
                || (Button02.Text == "O" && Button12.Text == "O" && Button22.Text == "O")

                //Check Diagonal Wins
                || (Button00.Text == "O" && Button11.Text == "O" && Button22.Text == "O")
                || (Button02.Text == "O" && Button11.Text == "O" && Button20.Text == "O")
            )
            {
                AImoves.Stop();
                MessageBox.Show("Computer Wins");
                computerWins++;
                AI_Wins_Label.Text = "Computer Wins - " + computerWins; //Shows computers(AI)score on the label
                ResetGame();
            }
        }
    }
}