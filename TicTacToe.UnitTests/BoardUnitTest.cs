using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_AI;

namespace TicTacToe.UnitTests
{
    [TestClass]
    public class BoardUnitTest
    {
        //Creating object for test.
        Board board = new Board()
        {
            buttonMatrix = new Button[3, 3],
            buttonList = new List<Button>()
        };

        private Board InitializeMatrixTestData(string text)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board.buttonMatrix[i, j] = new Button() { Text = text };
                }
            }
            return board;
        }
        //Testing when all of button text values is cross. 
        [TestMethod]
        public void CheckCrossWins_ExistingCrossBoardGiven_ReturnsTrue()
        {
            board = InitializeMatrixTestData("X");
            bool actualValue = board.CheckCrossWins();
            Assert.IsTrue(actualValue);
        }

        //Testing when all of button text values is not cross.
        [TestMethod]
        public void CheckCrossWins_NotExistingCrossBoardGiven_ReturnsFalse()
        {
            board = InitializeMatrixTestData("?");
            bool actualValue = board.CheckCrossWins();
            Assert.IsFalse(actualValue);
        }


        //Testing when all of button text values is cross. 
        [TestMethod]
        public void CheckOughtWins_ExistingOughtBoardGiven_ReturnsTrue()
        {
            board = InitializeMatrixTestData("O");
            bool actualValue = board.CheckOughtWins();
            Assert.IsTrue(actualValue);
        }

        //Testing when all of button text values is not cross.
        [TestMethod]
        public void CheckOughtWins_NotExistingOughtBoardGiven_ReturnsFalse()
        {
            board = InitializeMatrixTestData("?");
            bool actualValue = board.CheckCrossWins();
            Assert.IsFalse(actualValue);
        }

        //Testing when all buttons are not enabled.
        [TestMethod]
        public void CheckQuits_ExistingFullBoardGiven_ReturnsTrue()
        {
            bool enabledButtonExist = !(board.buttonList.Any(button => button.Enabled == true));
            bool actualValue = board.CheckQuits();
            Assert.AreEqual(enabledButtonExist, actualValue);
        }





    }
}
