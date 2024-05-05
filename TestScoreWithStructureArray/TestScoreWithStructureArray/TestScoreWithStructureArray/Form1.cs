using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TestScoreWithStructureArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct StudentScores
        {
            //declare the data types for each "column" in structure
            public string StudentName;
            public int MidtermScore;
            public int FinalScore;
        }

        //declare a 10 row array
        StudentScores[] TestGrades = new StudentScores[10];
        int arrayIndex = 0;        

        private void Form1_Load(object sender, EventArgs e)
        {
            //read Grades.txt file and place in array

            for (int x = 0; x < 10; x++)
            {
                TestGrades[x].StudentName = "";
                TestGrades[x].MidtermScore = 0;
                TestGrades[x].FinalScore = 0;

            }
            StreamReader studentReader = File.OpenText("Grades.txt");
            string[] splitLine = new string[3];
            string oneStudent = "";
            while (!studentReader.EndOfStream)
            {
                
                oneStudent = studentReader.ReadLine();
                splitLine = oneStudent.Split('*');

                TestGrades[arrayIndex].StudentName = splitLine[0];
                StudentNameCombobox.Items.Add(splitLine[0]);
                TestGrades[arrayIndex].MidtermScore = int.Parse(splitLine[1]);
                TestGrades[arrayIndex].FinalScore = int.Parse(splitLine[2]);
                arrayIndex++;
            }
            studentReader.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter GradeWriter = File.CreateText("Grades.txt");
                for (int x = 0; x < 10; x++)
                {
                    //only write to file if product exists
                    if (TestGrades[x].StudentName != "")
                    {
                        GradeWriter.Write(TestGrades[x].StudentName + "*");
                        GradeWriter.Write(TestGrades[x].MidtermScore + "*");
                        GradeWriter.WriteLine(TestGrades[x].FinalScore);
                    }
                }
                //close
                GradeWriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayTotalsBtn_Click(object sender, EventArgs e)
        {

            decimal FinalsAveragePoints, MidtermsAveragePoints, AllTestsAveragePoints;
            decimal FinalsAveragePercent, MidtermsAveragePercent, AllTestsAveragePercent;
            int MidtermTotalPoints, FinalsTotalPoints, AllTestsTotalPoints;
            int SelectedStudentMidtermScore, SelectedStudentFinalScore;
            decimal SelectedStudentMidtermPercent, SelectedStudentFinalPercent;


            //determine which radio button is checked and display the relevant data
            if (AllAverageRadBtn.Checked)
            {
                AllTestsTotalPoints = 0;
                for (int row = 0; row < 10; row++)
                {                  
                   
                     AllTestsTotalPoints += TestGrades[row].MidtermScore + TestGrades[row].FinalScore;                  
                    
                }

                AllTestsAveragePoints = AllTestsTotalPoints / 20m;
                AllTestsAveragePercent = AllTestsAveragePoints / 100;

                MessageBox.Show("Average points for all tests is: " + AllTestsAveragePoints.ToString() + "\n" + "Average percent grade for all tests is: " + AllTestsAveragePercent.ToString("P"));
            }

            if (MidtermAvgRadBtn.Checked)
            {
                MidtermTotalPoints = 0;
                for (int row = 0; row < 10; row++)
                {
                    MidtermTotalPoints += TestGrades[row].MidtermScore;
                }

                MidtermsAveragePoints = MidtermTotalPoints / 10m;
                MidtermsAveragePercent = MidtermsAveragePoints / 100;

                MessageBox.Show("Average points for Midterms is: " + MidtermsAveragePoints.ToString() + "\n" + "Average percent grade for Midterms is: " + MidtermsAveragePercent.ToString("P"));
            }
            if (FinalsAvgRadBtn.Checked)
            {
                FinalsTotalPoints = 0;
                for (int row = 0; row < 10; row++)
                {
                    FinalsTotalPoints += TestGrades[row].FinalScore;
                }

                FinalsAveragePoints = FinalsTotalPoints / 10m;
                FinalsAveragePercent = FinalsAveragePoints / 100;

                MessageBox.Show("Average points for Finals is: " + FinalsAveragePoints.ToString() + "\n" + "Average percent grade for Finals is: " + FinalsAveragePercent.ToString("P"));
            }

            if (MidtermLookupRadBtn.Checked)
            {
                if (StudentNameCombobox.SelectedIndex != -1)
                {
                    int row = StudentNameCombobox.SelectedIndex;

                    SelectedStudentMidtermScore = TestGrades[row].MidtermScore;
                    SelectedStudentMidtermPercent = SelectedStudentMidtermScore / 100m;

                    MessageBox.Show("Selected students Midterm score is: " + SelectedStudentMidtermScore.ToString() + "\n" + "Selected students percent grade for Midterms is:" + SelectedStudentMidtermPercent.ToString("P"));
                }
                else
                {
                    MessageBox.Show("Please select a student name.");
                }
            }

            if (FinalLookupRadBtn.Checked)
            {
                if (StudentNameCombobox.SelectedIndex != -1)
                {
                    int row = StudentNameCombobox.SelectedIndex;

                    SelectedStudentFinalScore = TestGrades[row].FinalScore;
                    SelectedStudentFinalPercent = SelectedStudentFinalScore / 100m;

                    MessageBox.Show("Selected students Final score is: " + SelectedStudentFinalScore.ToString() + "\n" + "Selected students percent grade for Finals is:" + SelectedStudentFinalPercent.ToString("P"));
                }
                else
                {
                    MessageBox.Show("Please select a student name.");
                }
            }
        }

        private void DisplaySelectedStudentBtn_Click(object sender, EventArgs e)
        {

            //verify that student name has been selected, then display grade in corresponding label
            if (StudentNameCombobox.SelectedIndex != -1)
            {
                //display selected students grades
                int MidtermGrade, FinalGrade;
                int row = StudentNameCombobox.SelectedIndex;

                MidtermGrade = TestGrades[row].MidtermScore;
                FinalGrade = TestGrades[row].FinalScore;

                MidtermDisplayDataLabel.Text = MidtermGrade.ToString();
                FinalDisplayDataLabel.Text = FinalGrade.ToString();

            }
            else
            {
                MessageBox.Show("Please select a student ID number.");
            }
        }

        private bool ValidateMidterm(bool ValidSelection)
        {
            //make sure that the data is valid
            bool MValid = true;
            int EnteredMidScore = 0;

            MValid = int.TryParse(UpdateMidtermTextbox.Text, out EnteredMidScore);

            if (StudentNameCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student ID number.");
                return false;
            }
            if (MValid == false || EnteredMidScore < 0 || EnteredMidScore > 100)
            {
                MessageBox.Show("Midterm score must be an integer between 0 and 100.");
                UpdateMidtermTextbox.Focus();
                return false;
            }
            return true;
        }
        private void UpdateMidtermBtn_Click(object sender, EventArgs e)
        {
            //validate data and place into designated midterm index
            int UpdatedMidtermScore;
            bool MValid, AllIsGood;
            MValid = int.TryParse(UpdateMidtermTextbox.Text, out UpdatedMidtermScore);
            AllIsGood = ValidateMidterm(MValid);
            if (AllIsGood)
            {
                int row = StudentNameCombobox.SelectedIndex;
                TestGrades[row].MidtermScore = UpdatedMidtermScore;
                UpdateMidtermTextbox.Clear();
            }
        }
        private bool ValidateFinal(bool ValidSelection)
        {
            //make sure that the data is valid
            bool FValid;
            int EnteredFinalScore = 0;

            FValid = int.TryParse(UpdateFinalTextbox.Text, out EnteredFinalScore);

            if (StudentNameCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student ID number.");
                return false;
            }

            if (FValid == false || EnteredFinalScore < 0 || EnteredFinalScore > 100)
            {
                MessageBox.Show("Final score must be an integer between 0 and 100.");
                UpdateFinalTextbox.Focus();
                return false;
            }
            return true;
        }
        private void UpdateFinalBtn_Click(object sender, EventArgs e)
        {
            //validate data and place into designated final index
            int UpdatedFinalScore;
            bool FValid, AllIsGood;
            FValid = int.TryParse(UpdateFinalTextbox.Text, out UpdatedFinalScore);
            AllIsGood = ValidateFinal(FValid);
            if (AllIsGood)
            {
                int row = StudentNameCombobox.SelectedIndex;
                TestGrades[row].FinalScore = UpdatedFinalScore;
                UpdateFinalTextbox.Clear();
            }
        }

        private void AllAverageRadBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
