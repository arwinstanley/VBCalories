' Name:Alex Winstanley
'Date: 3/4/15
' Purpose: To create a program that takes the number of fats carbohydrates
'and proteins and tell you the total amount of calories

Public Class frmCalories


    'Exits the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Clears the textboxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCalories.Clear()
        txtCarbohydrates.Clear()
        txtFat.Clear()
        txtProtein.Clear()
        txtFat.Focus()
    End Sub

    'Calculates the amount of calories
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Local Variables
        Dim fat, protein, carbohydrates, calories As Integer

        'Get Data from the program
        fat = Val(txtFat.Text)
        protein = Val(txtProtein.Text)
        carbohydrates = Val(txtCarbohydrates.Text)

        'Compute the data
        calories = (fat * 9) + (protein * 4) + (carbohydrates * 4)

        'Shows the calories
        txtCalories.Text = calories.ToString("n0")

    End Sub


    'Makes sure the text boxes are clear
    Private Sub frmCalories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear_Click(sender, e)
    End Sub
End Class
