using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_AI
{
    public partial class StartForm : Form
    {
        public static GameDifficulty difficulty = GameDifficulty.Medium;
        public StartForm()
        {
            InitializeComponent();
        }

        private void Easy_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Easy_RadioButton.Checked)
            {
                difficulty = GameDifficulty.Easy;
            }
        }

        private void Medium_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Medium_RadioButton.Checked)
            {
                difficulty = GameDifficulty.Medium;
            }
        }

        private void Hard_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Hard_RadioButton.Checked)
            {
                difficulty = GameDifficulty.Hard;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm TicTacToe = new MainForm();
            TicTacToe.Show();
            
        }

        
    }
}
