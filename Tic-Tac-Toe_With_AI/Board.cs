using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_AI
{
    public class Board
    {
        
        //PROPERTIES

        public Button[,] buttonMatrix { get; set; }
        public List<Button> buttonList { get; set; }

        //Define the named constants for increasing readability.
        public const int ROW_SIZE = 3;


        /// <summary>
        /// In this function we check if the cross has won.
        /// </summary>
        public bool CheckCrossWins()
        {
            for (int index = 0; index < ROW_SIZE; index++)
            {
                // Checks horizontal's won 
                if ((buttonMatrix[index, 0].Text == "X" && buttonMatrix[index, 1].Text == "X" &&
                     buttonMatrix[index, 2].Text == "X")
                    //Checks vertical won
                    || (buttonMatrix[0, index].Text == "X" && buttonMatrix[1, index].Text == "X" &&
                        buttonMatrix[2, index].Text == "X")
                    //Checks diagonals
                    || (buttonMatrix[0, 0].Text == "X" && buttonMatrix[1, 1].Text == "X" &&
                        buttonMatrix[2, 2].Text == "X")
                    || (buttonMatrix[0, 2].Text == "X" && buttonMatrix[1, 1].Text == "X" &&
                        buttonMatrix[2, 0].Text == "X"))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// In this function we check if the ought has won.
        /// </summary>
        public bool CheckOughtWins()
        {
            for (int index = 0; index < ROW_SIZE; index++)
            {
                // Checks horizontal's won 
                if ((buttonMatrix[index, 0].Text == "O" && buttonMatrix[index, 1].Text == "O" &&
                     buttonMatrix[index, 2].Text == "O")
                    //Checks vertical won
                    || (buttonMatrix[0, index].Text == "O" && buttonMatrix[1, index].Text == "O" &&
                        buttonMatrix[2, index].Text == "O")
                    //Checks diagonals
                    || (buttonMatrix[0, 0].Text == "O" && buttonMatrix[1, 1].Text == "O" &&
                        buttonMatrix[2, 2].Text == "O")
                    || (buttonMatrix[0, 2].Text == "O" && buttonMatrix[1, 1].Text == "O" &&
                        buttonMatrix[2, 0].Text == "O"))
                {
                    return true;
                }
            }

            return false;
        }

        //We should check scoreless game.
        //Check all buttons which is enabled.If any enabled button has not 
        //on the list then function return true
        public bool CheckQuits() 
        {
            if (! (buttonList.Any(button => button.Enabled )) ) 
                return true;                                      
            else
                return false;
        }

        
    }
}