// Nathan Huffman 
//2/6/2023
//  to get a distance from user and to convert the distance into a differnt form of distance 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceConverterHuffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
           // Closes the program
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clears the labels as well as the listbox 
            ConvertedDistanceLabel.Text = "";
            DistanceTextbox.Text = "";
            FromlistBox.ClearSelected();
            ToListbox.ClearSelected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adds forms of mesuerment into both of the listboxes
            FromlistBox.Items.Add("Inches");
            FromlistBox.Items.Add("Feet");
            FromlistBox.Items.Add("Yards");
            ToListbox.Items.Add("Inches");
            ToListbox.Items.Add("Feet");
            ToListbox.Items.Add("Yards");
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //geting the varibles 
            double Distance;
            double ConvertedDistance;
            ConvertedDistance= double.Parse(DistanceTextbox.Text);
            //adding the Try/ Catch 
            try
            {
                if ((double.TryParse(DistanceTextbox.Text, out Distance)))
                {
                    //making sure that the list boxes are selected.
                    if (FromlistBox.SelectedIndex != -1)
                    {
                        if (ToListbox.SelectedIndex != -1)
                        {
                            // Calulating the measurements 
                            if (FromlistBox.SelectedIndex == 0 && ToListbox.SelectedIndex == 0)
                            {
                                ConvertedDistance = Distance;
                            }
                            if (FromlistBox.SelectedIndex == 0 && ToListbox.SelectedIndex == 1)
                            {
                                ConvertedDistance = Distance / 12;
                            }
                            if (FromlistBox.SelectedIndex == 0 && ToListbox.SelectedIndex == 2)
                            {
                                ConvertedDistance = Distance / 36;
                            }
                            if (FromlistBox.SelectedIndex == 1 && ToListbox.SelectedIndex == 0)
                            {
                                ConvertedDistance = Distance * 12;
                            }
                            if (FromlistBox.SelectedIndex == 1 && ToListbox.SelectedIndex == 1)
                            {
                                ConvertedDistance = Distance;
                            }
                            if (FromlistBox.SelectedIndex == 1 && ToListbox.SelectedIndex == 2)
                            {
                                ConvertedDistance = Distance / 3;
                            }
                            if (FromlistBox.SelectedIndex == 2 && ToListbox.SelectedIndex == 0)
                            {
                                ConvertedDistance = Distance * 36;
                            }
                            if (FromlistBox.SelectedIndex == 2 && ToListbox.SelectedIndex == 1)
                            {
                                ConvertedDistance = Distance * 3;
                            }
                            if (FromlistBox.SelectedIndex == 2 && ToListbox.SelectedIndex == 2)
                            {
                                ConvertedDistance = Distance;
                            }
                            // making that only two decemal are used 
                            ConvertedDistanceLabel.Text = ConvertedDistance.ToString("0.00");

                        }
                        else
                        {
                            MessageBox.Show("You must select a mesurement.", "Missing Data");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must select a mesurement.", "Missing Data");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number in the distance converter.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            
        
        

        }
    }
}
