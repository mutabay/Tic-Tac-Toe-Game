using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_AI
{
    public static class ComputerLogic
    {
        //This function returns list which is full of available buttons.After the gathering available buttons list 
        //We can process the computer logic.
        public static List<Button> CreateAvailableButtons(Board board)
        {
            List<Button> availableButtons = new List<Button>();
            foreach (Button button in board.buttonList)
            {
                if (button.Text == "?")
                {
                    availableButtons.Add(button);
                }
            }
            return availableButtons;
        }

        //This function creates random index between 0 and available buttons count in the list.After select a button according to index.
        private static Button RandomButtonToAdd(List<Button> availableButtons, Button buttonToAdd)
        {
            Random random = new Random();
            int listIndex = random.Next(availableButtons.Count);
            buttonToAdd = availableButtons[listIndex];
            return buttonToAdd;
        }

        //Offensive exploits function for Medium level and this algorithm's target is
        // winning so it is not to successfully for defensive.
        private static Button SelectOffensiveButtonToAdd(Board board,Button buttonToAdd)
        {
            //OFFENSIVE GAME
            #region CheckingOffensiveExploits 

            //Checking horizontal exploits.
            for (int rowIndex = 0; rowIndex < Board.ROW_SIZE; rowIndex++)
            {
                //Checking [2] column index
                if (board.buttonMatrix[rowIndex, 0].Text == "O" && board.buttonMatrix[rowIndex, 1].Text == "O" && board.buttonMatrix[rowIndex, 2].Text == "?")
                {
                    buttonToAdd = board.buttonMatrix[rowIndex, 2];
                }
                //Checking [1] column index
                else if (board.buttonMatrix[rowIndex, 0].Text == "O" && board.buttonMatrix[rowIndex, 1].Text == "?" && board.buttonMatrix[rowIndex, 2].Text == "O")
                {
                    buttonToAdd = board.buttonMatrix[rowIndex, 1];
                }
                //Checking [0] column index
                else if (board.buttonMatrix[rowIndex, 0].Text == "?" && board.buttonMatrix[rowIndex, 1].Text == "O" && board.buttonMatrix[rowIndex, 2].Text == "O")
                {
                    buttonToAdd = board.buttonMatrix[rowIndex, 0];
                }
            }

            //Checking vertical exploits.
            for (int columnIndex = 0; columnIndex < Board.ROW_SIZE; columnIndex++)
            {
                //Checking [2] row index
                if (board.buttonMatrix[0, columnIndex].Text == "O" && board.buttonMatrix[1, columnIndex].Text == "O" && board.buttonMatrix[2, columnIndex].Text == "?")
                {
                    buttonToAdd = board.buttonMatrix[2, columnIndex];
                }
                //Checking [1] row index
                else if (board.buttonMatrix[0, columnIndex].Text == "O" && board.buttonMatrix[1, columnIndex].Text == "?" && board.buttonMatrix[2, columnIndex].Text == "O")
                {
                    buttonToAdd = board.buttonMatrix[1, columnIndex];
                }
                //Checking [0] row index
                else if (board.buttonMatrix[0, columnIndex].Text == "?" && board.buttonMatrix[1, columnIndex].Text == "O" && board.buttonMatrix[2, columnIndex].Text == "O")
                {
                    buttonToAdd = board.buttonMatrix[0, columnIndex];
                }
            }

            //Checking diagonal exploits.

            //Checking [2,2]cell.
            if (board.buttonMatrix[0, 0].Text == "O" && board.buttonMatrix[1, 1].Text == "O" && board.buttonMatrix[2, 2].Text == "?")
            {
                buttonToAdd = board.buttonMatrix[2, 2];
            }
            //Checking [1,1]cell.
            else if (board.buttonMatrix[0, 0].Text == "O" && board.buttonMatrix[1, 1].Text == "?" && board.buttonMatrix[2, 2].Text == "O")

            {
                buttonToAdd = board.buttonMatrix[1, 1];
            }
            //Checking [0,0]cell.
            else if (board.buttonMatrix[0, 0].Text == "?" && board.buttonMatrix[1, 1].Text == "O" && board.buttonMatrix[2, 2].Text == "O")
            {
                buttonToAdd = board.buttonMatrix[0, 0];
            }
            //Checking [0,2]cell.
            else if (board.buttonMatrix[0, 2].Text == "?" && board.buttonMatrix[1, 1].Text == "O" && board.buttonMatrix[2, 0].Text == "O")
            {
                buttonToAdd = board.buttonMatrix[0, 2];
            }
            //Checking [2,0]cell.
            else if (board.buttonMatrix[0, 2].Text == "O" && board.buttonMatrix[1, 1].Text == "O" && board.buttonMatrix[2, 0].Text == "?")
            {
                buttonToAdd = board.buttonMatrix[2, 0];
            }

            #endregion

            return buttonToAdd;
        }

        //Defensive exploits function for Hard level and this algorithm's target is not winning,actually
        // it's first purpose is the player's moves make deactivate.
        private static Button SelectDefensiveButtonToAdd(Board board, Button buttonToAdd)
        {
            //DEFENSIVE GAME
            #region CheckingDeffensiveExploits

            //Checking horizontal exploits.
            for (int rowIndex = 0; rowIndex < Board.ROW_SIZE; rowIndex++)
            {
                //Checking [2] column index
                if (board.buttonMatrix[rowIndex, 0].Text == "X" && board.buttonMatrix[rowIndex, 1].Text == "X" && board.buttonMatrix[rowIndex, 2].Text == "?")
                {
                    buttonToAdd = board.buttonMatrix[rowIndex, 2];
                }
                //Checking [1] column index
                else if (board.buttonMatrix[rowIndex, 0].Text == "X" && board.buttonMatrix[rowIndex, 1].Text == "?" && board.buttonMatrix[rowIndex, 2].Text == "X")
                {
                    buttonToAdd = board.buttonMatrix[rowIndex, 1];
                }
                //Checking [0] column index
                else if (board.buttonMatrix[rowIndex, 0].Text == "?" && board.buttonMatrix[rowIndex, 1].Text == "X" && board.buttonMatrix[rowIndex, 2].Text == "X")
                {
                    buttonToAdd = board.buttonMatrix[rowIndex, 0];
                }
            }

            //Checking vertical exploits.
            for (int columnIndex = 0; columnIndex < Board.ROW_SIZE; columnIndex++)
            {
                //Checking [2] row index
                if (board.buttonMatrix[0, columnIndex].Text == "X" && board.buttonMatrix[1, columnIndex].Text == "X" && board.buttonMatrix[2, columnIndex].Text == "?")
                {
                    buttonToAdd = board.buttonMatrix[2, columnIndex];
                }
                //Checking [1] row index
                else if (board.buttonMatrix[0, columnIndex].Text == "X" && board.buttonMatrix[1, columnIndex].Text == "?" && board.buttonMatrix[2, columnIndex].Text == "X")
                {
                    buttonToAdd = board.buttonMatrix[1, columnIndex];
                }
                //Checking [0] row index
                else if (board.buttonMatrix[0, columnIndex].Text == "?" && board.buttonMatrix[1, columnIndex].Text == "X" && board.buttonMatrix[2, columnIndex].Text == "X")
                {
                    buttonToAdd = board.buttonMatrix[0, columnIndex];
                }
            }

            //Checking diagonal exploits.

            //Checking [2,2]cell.
            if (board.buttonMatrix[0, 0].Text == "X" && board.buttonMatrix[1, 1].Text == "X" && board.buttonMatrix[2, 2].Text == "?")
            {
                buttonToAdd = board.buttonMatrix[2, 2];
            }
            //Checking [1,1]cell.
            else if (board.buttonMatrix[0, 0].Text == "X" && board.buttonMatrix[1, 1].Text == "?" && board.buttonMatrix[2, 2].Text == "X")

            {
                buttonToAdd = board.buttonMatrix[1, 1];
            }
            //Checking [0,0]cell.
            else if (board.buttonMatrix[0, 0].Text == "?" && board.buttonMatrix[1, 1].Text == "X" && board.buttonMatrix[2, 2].Text == "X")
            {
                buttonToAdd = board.buttonMatrix[0, 0];
            }
            //Checking [0,2]cell.
            else if (board.buttonMatrix[0, 2].Text == "?" && board.buttonMatrix[1, 1].Text == "X" && board.buttonMatrix[2, 0].Text == "X")
            {
                buttonToAdd = board.buttonMatrix[0, 2];
            }
            //Checking [2,0]cell.
            else if (board.buttonMatrix[0, 2].Text == "X" && board.buttonMatrix[1, 1].Text == "X" && board.buttonMatrix[2, 0].Text == "?")
            {
                buttonToAdd = board.buttonMatrix[2, 0];
            }

            #endregion

            return buttonToAdd;
        }


        /// <summary>
        /// I made static for easy access
        /// In the content of the function we have a layout compatible for difficulties.
        /// In the first phase we gather easiest obtain button
        /// Secondly in the checking offensive exploits region for Medium level and this algorithm's target is
        /// winning so it is not to successfully for defensive
        /// Thirdly in the checking defensive exploits region for Hard level and this algorithm's target is not winning,actually
        /// it's first purpose is the player's moves make deactivate.
        /// </summary>

        public static Button ComputerPlacement(Board board,GameDifficulty gameDifficulty)
        {
            //Creating button object which will added.
            Button buttonToAdd = new Button();

            List<Button> availableButtons = CreateAvailableButtons(board: board);

            buttonToAdd = RandomButtonToAdd(availableButtons:availableButtons,buttonToAdd:buttonToAdd);

            if (gameDifficulty == GameDifficulty.Easy) //If game is easy mode then computer plays worst possibility.
                return buttonToAdd;
            //The worst possibility,computer choose random location to select.


            //If the center is empty we should set this place.
            if (board.buttonMatrix[1, 1].Text == "?" && board.buttonMatrix[1, 1].Enabled)//The most effective process because who puts it
            {                                                   //in middle,get 2x more probability to continue combo
                buttonToAdd = board.buttonMatrix[1, 1];  //1,1 is the middle of the board.
                return buttonToAdd;
            }

            if (gameDifficulty == GameDifficulty.Medium)
            {
                //OFFENSIVE GAME
                buttonToAdd = SelectOffensiveButtonToAdd(board: board, buttonToAdd: buttonToAdd);
            }
            else if (gameDifficulty == GameDifficulty.Hard)
            {
                //DEFENSIVE GAME
                buttonToAdd = SelectDefensiveButtonToAdd(board: board, buttonToAdd: buttonToAdd);
            }

            return buttonToAdd;

        }
    }
}
