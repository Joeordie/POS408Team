Public Class frmEdit

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

Public Class DisplaySet
    'Declare Class Attributes
    Public intUUID As Integer
    Public strFName As String
    Public strLName As String
    Public strEmail As String
    Public strPhone As String
    Public strCompanyName As String
    Public strPurpose As String = "display"

    'Routine to load variables
    Public Sub Loader(I As Integer, F As String, L As String, E As String, P As String, CN As String)
        intUUID = I
        strFName = F
        strLName = L
        strEmail = E
        strPhone = P
        strCompanyName = CN
    End Sub
End Class