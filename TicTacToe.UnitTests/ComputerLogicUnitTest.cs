using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_AI;

namespace TicTacToe.UnitTests
{
    [TestClass]
    public class ComputerLogicUnitTest
    {
        //There has many many possibilities so we can not test it every possibilities this test class.
        public const int BUTTON_COUNT = 9;

        //Creating object for test.
        Board board = new Board()
        {
            buttonMatrix = new Button[3, 3],
            buttonList = new List<Button>()
        };
        
        private Board InitializeListTestData(string text)
        {
            foreach (var button in board.buttonList)
            {
                button.Text = text;
            }
            return board;
        }

        [TestMethod]
        public void CreateAvailableButtons_ExistingBoardGiven_ReturnNineButtonList()
        {
            board = InitializeListTestData("?");
            List<Button> availableButtons = ComputerLogic.CreateAvailableButtons(board);
            int expectedValue = board.buttonList.Count;
            int actualValue = availableButtons.Count;
            Assert.AreEqual(expected: expectedValue, actual: actualValue);
        }
        
    }
}
