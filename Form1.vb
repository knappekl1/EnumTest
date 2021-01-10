Public Class Form1
    Const c As Integer = 12
    Private Enum Meals
        Breakfest
        Lunch
        Dinner
        Supper = Dinner
    End Enum

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim A, B As Single
        Const c As Single = 4.6
        Static result As Single
        If Single.TryParse(tbA.Text, A) = False Then
            MessageBox.Show("Enter Valid Number to A")
        ElseIf Single.TryParse(tbB.Text, B) = False Then
            MessageBox.Show("Enter Valid Number to B")
        ElseIf B = 0 Then
            MessageBox.Show("Zero Division: Enter Non Zero Number to B")
        Else
            result += A / B + c
            tbSum.Text = result.ToString("f")
        End If
    End Sub
End Class
