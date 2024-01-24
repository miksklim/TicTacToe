using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationTicTacToe
{
    public partial class Form1 : Form
    {

        public enum Player
        {
            //x will be human, o will be CPU
            x, o
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWins = 0;
        int cpuWins = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CPUChooseOption(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.o;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Red;
                buttons.RemoveAt(index); //removes the button selected from the list so next choices cannot be the same
                CheckGame();
                TimerCPU.Stop();
            }
        }

        private void PlayerChooseOption(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.x;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Blue;
            buttons.Remove(button);
            CheckGame();
            TimerCPU.Start();
        }

        private void CheckGame()
        {

            // vertical straights, horizontal straights, left-to-right diagonal, right-to-left diagal
            if (button1.Text == "x" && button6.Text == "x" && button9.Text == "x"
                || button2.Text == "x" && button5.Text == "x" && button8.Text == "x"
                || button3.Text == "x" && button4.Text == "x" && button7.Text == "x"
                || button1.Text == "x" && button2.Text == "x" && button3.Text == "x"
                || button4.Text == "x" && button5.Text == "x" && button6.Text == "x"
                || button7.Text == "x" && button8.Text == "x" && button9.Text == "x"
                || button1.Text == "x" && button5.Text == "x" && button7.Text == "x"
                || button3.Text == "x" && button5.Text == "x" && button9.Text == "x")
            {
                //player won, end game
                TimerCPU.Stop();
                MessageBox.Show("Human has won", "Congrats");
                playerWins++;
                playerlabel.Text = "Player Wins: " + playerWins;
                CheckScore();
                RestartGame();
            }
            else if (button1.Text == "o" && button6.Text == "o" && button9.Text == "o"
                || button2.Text == "o" && button5.Text == "o" && button8.Text == "o"
                || button3.Text == "o" && button4.Text == "o" && button7.Text == "x"
                || button1.Text == "o" && button2.Text == "o" && button3.Text == "o"
                || button4.Text == "o" && button5.Text == "o" && button6.Text == "o"
                || button7.Text == "o" && button8.Text == "o" && button9.Text == "o"
                || button1.Text == "o" && button5.Text == "o" && button7.Text == "o"
                || button3.Text == "o" && button5.Text == "o" && button9.Text == "o")
            {
                //CPU won, end game
                TimerCPU.Stop();
                MessageBox.Show("Computer has won", "Oh no");
                cpuWins++;
                cpulabel.Text = "CPU Wins: " + cpuWins;
                CheckScore();
                RestartGame();
            }

            //if its a tie
            else if (button1.Text != "?" && button2.Text != "?" && button3.Text != "?" && button4.Text != "?" && button5.Text != "?"
                && button6.Text != "?" && button7.Text != "?" && button8.Text != "?" && button9.Text != "?")
            {
                TimerCPU.Stop();
                MessageBox.Show("It's a tie", "Nice");
                RestartGame();
            }

        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;

            }
            CheckScore();
        }

        private void CheckScore()
        {
            if (playerWins == 5)
            {
                //TimerCPU.Stop();
                MessageBox.Show("The human won the entire game", "Congrats");
                ResetScore();
            }
            else if (cpuWins == 5)
            {
                //TimerCPU.Stop();
                MessageBox.Show("The computer won the entire game", "uh oh");
                ResetScore();
            }
        }

        private void ResetScore()
        {
            playerWins = 0;
            cpuWins = 0;
            playerlabel.Text = "Player Wins: " + playerWins;
            cpulabel.Text = "CPU Wins: " + cpuWins;
        }
    }
}
