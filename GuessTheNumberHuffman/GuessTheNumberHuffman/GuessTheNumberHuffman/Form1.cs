using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumberHuffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Makes a random number from 1-100
            Random rnumber = new Random();
            RandomNumber = rnumber.Next(1, 101);
        }
        //variables here
        int RandomNumber;
        int Guesscount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //display the correct number
            MessageBox.Show("The Number is: " + RandomNumber);
        }

        private void TryButton_Click(object sender, EventArgs e)
        {
            //adding to the count 
            if (int.TryParse(GuessTextbox.Text, out int userguess) && (userguess >= 0 && userguess <= 100))
            {
                Guesscount++;

                if (userguess == RandomNumber)
                {
                    MessageBox.Show("Thats Right!!");

                    // makes a new random number for the player
                    Random randomnumber = new Random();
                    RandomNumber = randomnumber.Next(1, 101);


                    // Reset guess count and clears the text box 
                    Guesscount = 0;
                    GuessTextbox.Clear();
                    GuessTextbox.Focus();
                }
                else if (userguess > RandomNumber)
                {
                    MessageBox.Show("Too high try again. :( ");
                    GuessTextbox.Clear();
                    GuessTextbox.Focus();
                }
                else
                {
                    MessageBox.Show("Too low try again. :( ");
                    GuessTextbox.Clear();
                    GuessTextbox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter an number between 1-100.");
                GuessTextbox.Clear();
                GuessTextbox.Focus();
            }

            NumberOfGuessesLabel.Text = Guesscount.ToString();
        }

        private void NewNumberButton_Click(object sender, EventArgs e)
        {
            //gives new number
            Random randomnumber = new Random();
            RandomNumber = randomnumber.Next(1, 101);
            //reset the amount of guesses
            Guesscount = 0;
            GuessTextbox.Clear();
            //clear the number of guesses label
            NumberOfGuessesLabel.Text = "";
        }
    }
}
