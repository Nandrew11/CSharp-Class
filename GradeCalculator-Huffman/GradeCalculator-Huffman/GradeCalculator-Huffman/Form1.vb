'Nathan Huffman 
'9/25/2022
'we are going to grade some papers for a class
Option Strict On

Public Class Form1
    'class level Variables 
    Dim TestonePointPossible As Integer = 72
    Dim TestTwoPointPossible As Integer = 90
    Dim TestThreePointPossible As Integer = 57
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'closes the program
        Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clears the text in all of the labels and textboxs
        TestGradeLabel1.Text = ""
        TestGradeLabel2.Text = ""
        TestGradeLabel3.Text = ""
        TestScore1Textbox.Clear()
        TestScore2Textbox.Clear()
        TestScore3Textbox.Clear()
        ClassGradeLabel.Text = ""
        TestScore1Textbox.Focus()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'accumulated class grade
        Dim TotalClassPercent As Decimal
        'Making some Varibles
        Dim TestOnePoints As Integer
        Dim TestTwoPoints As Integer
        Dim TestThreePoints As Integer
        'now some Calculated Values 
        Dim TestGrade1 As Decimal
        Dim TestGrade2 As Decimal
        Dim TestGrade3 As Decimal
        Dim TotalClassPossible As Integer
        Dim TotalClassGrade As Decimal
        Dim TotalTestPoints As Integer
        'time for the Convertions 
        TestOnePoints = Integer.Parse(TestScore1Textbox.Text)
        TestTwoPoints = Integer.Parse(TestScore2Textbox.Text)
        TestThreePoints = Integer.Parse(TestScore3Textbox.Text)
        'Calculations time
        TotalClassPossible = TestonePointPossible + TestTwoPointPossible + TestThreePointPossible
        TestGrade1 = CDec(TestOnePoints / TestonePointPossible)
        TestGrade2 = CDec(TestTwoPoints / TestTwoPointPossible)
        TestGrade3 = CDec(TestThreePoints / TestThreePointPossible)
        TotalTestPoints = TestOnePoints + TestTwoPoints + TestThreePoints
        TotalClassGrade = CDec(TotalTestPoints / TotalClassPossible)


        'display the values
        TestGradeLabel1.Text = TestGrade1.ToString("p2") & "%"
        TestGradeLabel2.Text = TestGrade2.ToString("p2") & "%"
        TestGradeLabel3.Text = TestGrade3.ToString("p2") & "%"
        ClassGradeLabel.Text = ("Your grade for the class is ") & TotalClassGrade.ToString("p2")
    End Sub
End Class
