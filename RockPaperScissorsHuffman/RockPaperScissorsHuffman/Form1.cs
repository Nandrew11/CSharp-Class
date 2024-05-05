using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsHuffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result(PictureBox PlayersChoice)
        {
            //CPU's choice 
            Random RandomChoice = new Random();
            int CPU = RandomChoice.Next(1, 4);
            // 1=Rock, 2=Paper, 3=Scissors


            switch (CPU)
            {
                //Puts the CPU answers into the picture that it chose 
                case 1:
                    CPUBox.Image = Properties.Resources.istockphoto_170215830_612x612;
                    break;
                case 2:
                    CPUBox.Image = Properties.Resources.Continuous_form_paper__14p875_x_11_;
                    break;
                case 3:
                    CPUBox.Image = Properties.Resources.scissors_4730862;
                    break;
            }

            // Tells the outcome
            if (PlayersChoice == RockBox && CPU == 3 ||
                PlayersChoice == PaperBox && CPU == 1 ||
                PlayersChoice == ScissorsBox && CPU == 2)
            {
                WinnerLabel.Text = "Player wins!";
            }
            else if (PlayersChoice == RockBox && CPU == 2 ||
                     PlayersChoice == PaperBox && CPU == 3 ||
                     PlayersChoice == ScissorsBox && CPU == 1)
            {
                WinnerLabel.Text = "CPU wins better luck next time!";
            }
            else
            {
                WinnerLabel.Text = "Its a Tie!";
            }

        }

        private void RockBox_Click(object sender, EventArgs e)
        {
            Result(RockBox);
        }

        private void PaperBox_Click(object sender, EventArgs e)
        {
            Result(PaperBox);
        }

        private void ScissorsBox_Click(object sender, EventArgs e)
        {
            Result(ScissorsBox);
        }
    }
}
