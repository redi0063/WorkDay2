Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String

        'Read the input from the user'
        fullname = txtFullName.Text

        'Trimmed Full Name'
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        'Display it back to user'
        txtFirstName.Text = fullname

        'Find the index between first space'
        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")

        'Extract the first name'
        Dim firstName As String
        firstName = fullnameTrimmed.Substring(0, idxSpace)

        'Display First name to user'
        txtFirstName.Text = firstName

    End Sub


    Private Sub txtFullName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFullName.TextChanged

    End Sub
End Class
