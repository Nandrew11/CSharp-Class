//Making a coin caluclater for a purchase
//Nathan Huffman
//1/30/2023

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeMakerHuffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
         //closes the program
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clears all the labels and text boxes
            OwedTextbox.Clear();
            PaidTextbox.Clear();
            TotalChangeLabel.Text="";
            DollarsLabel.Text = "";
            QuartersLabel.Text = "";
            DimesLabel.Text = "";
            NickelsLabel.Text = "";
            PenniesLabel.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //getting varibles 
            double Owed = 0.0, Paid = 0.0, TotalChange = 0.0;
            int Dollars = 0, Quarters = 0, Dimes = 0, Nickels = 0, Pennies = 0;
            //Converting
            Owed = Convert.ToDouble(OwedTextbox.Text);
            Paid = Convert.ToDouble(PaidTextbox.Text);
           //setting up Try and catch 
            try
            {
                //Doing the calculations in a while loop to get the change back 
                TotalChange = Paid - Owed;
                TotalChangeLabel.Text = TotalChange.ToString("C");

                while (TotalChange - (1.00) >=0 )
                {
                    TotalChange = TotalChange - 1.00;
                    Dollars += 1;
                }
                while (TotalChange - (0.25) >= 0)
                {
                    TotalChange = TotalChange - 0.25;
                    Quarters += 1;
                }
                while (TotalChange - (0.10) >= 0)
                {
                    TotalChange = TotalChange - 0.10;
                    Dimes += 1;
                }
                while (TotalChange - (0.05) >= 0)
                {
                    TotalChange = TotalChange - 0.05;
                    Nickels += 1;
                }
                while (TotalChange - (0.01) >= 0)
                {
                    TotalChange = TotalChange - 0.01;
                    Pennies += 1;
                }
                //Displaying the calculations
                DollarsLabel.Text = Dollars.ToString();
                QuartersLabel.Text = Quarters.ToString();
                DimesLabel.Text = Dimes.ToString();
                NickelsLabel.Text = Nickels.ToString();
                PenniesLabel.Text = Pennies.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
