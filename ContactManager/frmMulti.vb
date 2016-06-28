Public Class frmMulti

    Private Sub frmMulti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub clear()
        lstMultipleResults.Items.Clear()
    End Sub

    Public Sub ResultLoad(strResultLine As String)
        lstMultipleResults.Items.Add(strResultLine)
    End Sub


End Class