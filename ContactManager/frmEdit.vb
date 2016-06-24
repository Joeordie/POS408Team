Public Class frmEdit

    'Declares variables that will be used
    Dim intPhone As Integer
    Dim strFirstName As String
    Dim strLastName As String
    Dim stremail As String
    Dim strCompanyName As String
    Dim strCompanyAddress As String


    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Forms.frmStart.Show()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub
End Class