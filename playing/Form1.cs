using System;
using System.Drawing;
using System.Windows.Forms;

namespace playing
{
    public partial class Form1 : Form
    {
        int player = 0;
        int computer = 0;
        int playerChoice = 0;
        int computerChoice = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            playerChoice = 1;
            Play();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playerChoice = 2;
            Play();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playerChoice = 3;
            Play();
        }

        private void Play()
        {
            computerChoice = rnd.Next(1, 4);

            lblPlayer.Text = "Player : " + GetName(playerChoice);
            lblComputer.Text = "Computer : " + GetName(computerChoice);

            if (playerChoice == computerChoice)
            {
                lblResult.Text = "Draw!";
                lblResult.ForeColor = Color.Yellow;
            }
            else if ((playerChoice == 1 && computerChoice == 3) || (playerChoice == 2 && computerChoice == 1) || (playerChoice == 3 && computerChoice == 2))
            {
                player++;
                lblResult.Text = "You Win!";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                computer++;
                lblResult.Text = "You Lose!";
                lblResult.ForeColor = Color.Red;
            }

            lblScore.Text = player + "      " + computer;
        }

        private string GetName(int choice)
        {
            if (choice == 1) return "🎱";
            if (choice == 2) return "📃";
            return "✂";
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            player= 0;
            computer = 0;
            playerChoice = 0;
            computerChoice = 0;

            lblPlayer.Text = "Player";
            lblComputer.Text = "Computer";
            lblResult.Text = "Result";
            lblResult.ForeColor = Color.White;
            lblScore.Text = "0      0";
        }
    }
}