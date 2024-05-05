//Nathan Huffman
//4/29/2023
//this is desycering the numbers for the get food number 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneTranslatorHuffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //closes program
            Close();
        }

        private void ClearScreenButton_Click(object sender, EventArgs e)
        {
            //Clear the textbox as well as the label
            PhoneNumberTextbox.Clear();
            ConvertedNumberLabel.Text = "";
        }

        private void ConvertPhoneNumberButton_Click(object sender, EventArgs e)
        {
            //get and validate the numbers entered by user
            string phonenumber = null;
            string SemiConvertedNumber = null;
            string ConvertedNumber = null;

            if (IsValidFormat(ConvertedNumber))
            {
                SemiConvertedNumber = UndoPhoneNumber(phonenumber);

                ConvertedNumber = CharConversion(SemiConvertedNumber);

                ConvertedNumber = ConvertedNumber.Insert(3, "-");
                ConvertedNumber = ConvertedNumber.Insert(7, "-");

                ConvertedNumberLabel.Text = ConvertedNumber;

            }
            else
            {
                MessageBox.Show("Enter number in this way:" + "\n" + "XXX-XXX-XXXX");
            }
        }

        private bool IsValidFormat(string ValidNumber)
        {
            //make sure the user number is in good format
            const int VALID_LENGTH = 12;
            ValidNumber = PhoneNumberTextbox.Text;
            bool isNumValid;
            // leading and trailing spaces already removed:
            if (ValidNumber.Length == VALID_LENGTH && ValidNumber[3] == '-' && ValidNumber[7] == '-')
            {
                isNumValid = true;
            }
            else
            {
                isNumValid = false;
            }

            return isNumValid;
        }


        

        private string CharConversion(string newNumber)
        {
            //check which characters are letters and convert to corresponding number
            int x = 0;
            string UnformattedNumber = UndoPhoneNumber(newNumber);
            newNumber = null;

            char unconvertednumberchar;
            for (x = 0; x < 10; x++)
            {
                if (char.IsDigit(UnformattedNumber[x]))
                {
                    newNumber += UnformattedNumber[x];
                }

                if (char.IsLetter(UnformattedNumber[x]))
                {
                    unconvertednumberchar = UnformattedNumber[x];

                    if (unconvertednumberchar == 'a' || unconvertednumberchar == 'A' || unconvertednumberchar == 'b' || unconvertednumberchar == 'B' || unconvertednumberchar == 'c' || unconvertednumberchar == 'C')
                    {
                        newNumber += 2.ToString();
                    }
                    else if (unconvertednumberchar == 'd' || unconvertednumberchar == 'D' || unconvertednumberchar == 'e' || unconvertednumberchar == 'E' || unconvertednumberchar == 'f' || unconvertednumberchar == 'F')
                    {
                        newNumber += 3.ToString();
                    }
                    else if (unconvertednumberchar == 'g' || unconvertednumberchar == 'G' || unconvertednumberchar == 'h' || unconvertednumberchar == 'H' || unconvertednumberchar == 'i' || unconvertednumberchar == 'I')
                    {
                        newNumber += 4.ToString();
                    }
                    else if (unconvertednumberchar == 'j' || unconvertednumberchar == 'J' || unconvertednumberchar == 'k' || unconvertednumberchar == 'K' || unconvertednumberchar == 'l' || unconvertednumberchar == 'L')
                    {
                        newNumber += 5.ToString();
                    }
                    else if (unconvertednumberchar == 'm' || unconvertednumberchar == 'M' || unconvertednumberchar == 'n' || unconvertednumberchar == 'N' || unconvertednumberchar == 'o' || unconvertednumberchar == 'O')
                    {
                        newNumber += 6.ToString();
                    }
                    else if (unconvertednumberchar == 'p' || unconvertednumberchar == 'P' || unconvertednumberchar == 'q' || unconvertednumberchar == 'Q' || unconvertednumberchar == 'r' || unconvertednumberchar == 'R' || unconvertednumberchar == 's' || unconvertednumberchar == 'S')
                    {
                        newNumber += 7.ToString();
                    }
                    else if (unconvertednumberchar == 't' || unconvertednumberchar == 'T' || unconvertednumberchar == 'u' || unconvertednumberchar == 'U' || unconvertednumberchar == 'v' || unconvertednumberchar == 'V')
                    {
                        newNumber += 8.ToString();
                    }
                    else if (unconvertednumberchar == 'w' || unconvertednumberchar == 'W' || unconvertednumberchar == 'x' || unconvertednumberchar == 'X' || unconvertednumberchar == 'y' || unconvertednumberchar == 'Y' || unconvertednumberchar == 'z' || unconvertednumberchar == 'Z')
                    {
                        newNumber += 9.ToString();
                    }
                }

            }

            return newNumber;

        }

        private string UndoPhoneNumber(string UnconvertedNumber)
        {
            //unformat number so the hyphens are gone temporarily
            UnconvertedNumber = PhoneNumberTextbox.Text;

            UnconvertedNumber = UnconvertedNumber.Remove(3, 1);
            UnconvertedNumber = UnconvertedNumber.Remove(6, 1);

            return UnconvertedNumber;
        }
    }
}
