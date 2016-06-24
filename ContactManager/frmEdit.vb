Public Class frmEdit

    'Declares variables that will be used  the data for strphone,
    'strFirstName, strLastName, strEmail, strCompanyName and strCompany address will all be strings
    'email will be required to have a @ and a .  strFirstName strLastName, strCompanyAddress will be permitted to have numbers and letters
    'strCompany name will be allowed to have all numbers, letters and special characters due to potential naming conventions of the company
    'values will be obtained from the textbox data entered by the user if
    'a new entry is being created and will be populated by the Database if queried in the search page as well as entered by the user for the search string

    Dim strPhone As String
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