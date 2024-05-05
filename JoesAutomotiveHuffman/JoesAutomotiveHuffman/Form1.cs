using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace JoesAutomotiveHuffman
{
    
    //Nathan Huffman
    // 2/27/2023
    //This is a program that is going to calculate the sum of an Automotive store
    
    
    
    public partial class Form1 : Form
    {
        //geting the const var.
        private const decimal OIL_CHANGE_COST = 26.00m;
        private const decimal RADIATOR_FLUSH_COST = 30.00m;
        private const decimal LUBE_JOB_COST = 18.00m;
        private const decimal TRANSMISSION_FLUSH_COST = 80.00m;
        private const decimal INSPECTION_COST = 15.00m;
        private const decimal REPLACE_MUFFLER_COST = 100.00m;
        private const decimal TIRE_ROTATION_COST = 20.00m;

        private const decimal SALES_TAX = 0.06m;

        private decimal PartsCost;
        private decimal LaborCost;
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clears the GroupBoxes as well as the cost.
            ClearOilandLube();
            ClearFlushes();
            ClearMisc();
            ClearPartsandLabor();
            ClearFees();

            OilLubeGroupBox.Focus();


        }

        private bool IsInputValid (ref decimal PartsCost, ref decimal LaborCost)
        {
            bool isValid = false;
            
            if ((decimal.TryParse(PartsTextBox.Text, out PartsCost) && PartsCost >= 0m) || (PartsTextBox.Text == "")
                || (decimal.TryParse(PartsTextBox.Text.Substring(1, PartsTextBox.Text.Length - 1), out PartsCost)))
            {
                PartsCost = Math.Round(PartsCost, 2, MidpointRounding.AwayFromZero);
                PartsTextBox.Text = PartsCost.ToString("c");

                if ((decimal.TryParse(LaborTextBox.Text, out LaborCost) && LaborCost >= 0m) || (LaborTextBox.Text == "")
                    || (decimal.TryParse(LaborTextBox.Text.Substring(1, LaborTextBox.Text.Length - 1), out LaborCost)))
                {
                    LaborCost = Math.Round(LaborCost, 2, MidpointRounding.AwayFromZero);
                    LaborTextBox.Text = LaborCost.ToString("c");

                    isValid = true;
                }
                else
                {
                    //if not working for labor this shows up
                    MessageBox.Show("Labor cost is not right try again.");
                    LaborTextBox.Clear();
                    LaborTextBox.Focus();
                }
            }
            else
            {
                //if not working for Parts this shows up
                MessageBox.Show("Parts cost is not right try again.");
                PartsTextBox.Clear();
                PartsTextBox.Focus();
            }

            return isValid;
        }

        private decimal OilandLubeCharges()
        {
            //getting the cost for the oild and lube
            decimal oilAndLubeCharges = 0m;

            if (OilCheckBox.Checked)
            {
                oilAndLubeCharges += OIL_CHANGE_COST;
            }
            if (LubeCheckBox.Checked)
            {
                oilAndLubeCharges += LUBE_JOB_COST;
            }

            return oilAndLubeCharges;
        }

        private decimal FlushCharges()
        {
            ////getting the cost for the Flush
            decimal flushCharges = 0m;

            if (RadiatorCheckBox.Checked)
            {
                flushCharges += RADIATOR_FLUSH_COST;
            }
            if (TransmissionCheckBox.Checked)
            {
                flushCharges += TRANSMISSION_FLUSH_COST;
            }

            return flushCharges;
        }

        private decimal MiscCharges()
        {
            //getting the cost for the Misc
            decimal miscCharges = 0m;

            if (InspectionCheckBox.Checked)
            {
                miscCharges += INSPECTION_COST;
            }
            if (MufflerCheckBox.Checked)
            {
                miscCharges += REPLACE_MUFFLER_COST;
            }
            if (TireCheckBox.Checked)
            {
                miscCharges += TIRE_ROTATION_COST;
            }

            return miscCharges;
        }

        private decimal PartsandLaborCharges()
        {
            //getting the cost for the Parts and Labor
            decimal otherCharges = PartsCost + LaborCost;

            return otherCharges;
        }

        private decimal TaxCharges()
        {
            //geting the Tax charges 
            decimal taxCharges = PartsCost * SALES_TAX;

            taxCharges = Math.Round(taxCharges, 2, MidpointRounding.AwayFromZero);

            return taxCharges;
        }

        private decimal TotalCharges()
        {
            //totals the charges up
            decimal totalCharges = OilandLubeCharges() + FlushCharges() + MiscCharges() + PartsandLaborCharges() + TaxCharges();

            return totalCharges;
        }

        private void ClearOilandLube()
        {
            //clears Oil and Lube
            OilCheckBox.Checked = false;
            LubeCheckBox.Checked = false;
        }

        private void ClearFlushes()
        {
            //clears Flushes
            RadiatorCheckBox.Checked = false;
            TransmissionCheckBox.Checked = false;
        }

        private void ClearMisc()
        {
            //clears Misc
            InspectionCheckBox.Checked = false;
            MufflerCheckBox.Checked = false;
            TireCheckBox.Checked = false;
        }

        private void ClearPartsandLabor()
        {
            //clears parts and labor
            PartsTextBox.Clear();
            LaborTextBox.Clear();
        }

        private void ClearFees()
        {
            //clears the fees 
            ServiceandLaborLabel.Text = "";
            PartsLabel.Text = "";
            TaxLabel.Text = "";
            TotalFeesLabel.Text = "";
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //adds all of the Private Voids and calculates the cost for the customer
            if (IsInputValid(ref PartsCost, ref LaborCost))
            {
                decimal ServiceCost = OilandLubeCharges() + FlushCharges() + MiscCharges();
                decimal ServiceAndLaborCost = ServiceCost + LaborCost;

                ServiceandLaborLabel.Text = ServiceAndLaborCost.ToString("c");

                PartsLabel.Text = PartsCost.ToString("c");

                TaxLabel.Text = TaxCharges().ToString("c");

                TotalFeesLabel.Text = TotalCharges().ToString("c");

                ClearButton.Focus();
            }
        }
    }
}
