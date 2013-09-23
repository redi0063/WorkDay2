Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double

        If (IsNumeric(txtFirstNum.Text)) And (IsNumeric(txtSecondNum.Text)) Then
            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)

            If (num1 < 0 Or num2 < 0) Then
                MessageBox.Show("Error: Please Type a POSITIVE Number")
            End If

            If (num1 > num2) Then
                txtResult.Text = "Larer Number is: " & num1
            ElseIf (num2 > num1) Then
                txtResult.Text = "Larger Number is: " & num2
            Else
                txtResult.Text = "The Two are Equal"
            End If
        Else
            MessageBox.Show("Error: Please Type a Number")
        End If

    End Sub
End Class
