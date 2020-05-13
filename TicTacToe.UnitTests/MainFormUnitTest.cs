using System;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe_AI;

namespace TicTacToe.UnitTests
{
    /// <summary>
    /// Actually there is more than methods here but these methods are event methods.
    /// </summary>
    [TestClass]
    public class MainFormUnitTest
    {
        MainForm mainForm = new MainForm();

        public const int ROW_SIZE = 3;
        public const int COLUMN_SIZE = 3;
        public const int BUTTON_COUNT = 9;


        //This test method I check in the collections of buttons are filled or not.
        [TestMethod]
        public void LoadButtons_CheckButtonsAreFilled_ReturnsEquivalent()
        {
            mainForm.LoadButtons();
            for (int rowIndex = 0; rowIndex < ROW_SIZE; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < COLUMN_SIZE; columnIndex++)
                {
                    if (mainForm.board.buttonMatrix[rowIndex, columnIndex] == null)
                    {
                        Assert.Fail("buttonMatrix Cannot Load");
                    }
                }
            }

            for (int buttonIndex = 0; buttonIndex < BUTTON_COUNT; buttonIndex++)
            {
                if (mainForm.board.buttonList[buttonIndex] == null)
                {
                    Assert.Fail("buttonList Cannot Load");
                }
            }
            Assert.IsTrue(true);
        }
        

        //In this test method I tested properties are applied.We cant check the button so I check properties of button.Actually we need these.
        [TestMethod]
        public void EditButtons_GivenButtonAndProperties_ReturnsEqual()
        {
            Button expectedTestButton = new Button() { BackColor = Color.White, ForeColor = Color.Black, Text = "test", Enabled = true };
            Button actualTestButton = new Button();
            mainForm.EditButtons(actualTestButton,Color.White, Color.Black, "test",true);
            Assert.AreEqual(expectedTestButton.BackColor,actualTestButton.BackColor);
            Assert.AreEqual(expectedTestButton.ForeColor,actualTestButton.ForeColor);
            Assert.AreEqual(expectedTestButton.Text,actualTestButton.Text);
            Assert.AreEqual(expectedTestButton.Enabled,actualTestButton.Enabled);
        }






    }
}
