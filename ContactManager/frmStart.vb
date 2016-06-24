Public Class frmStart

    'Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        My.Forms.frmEdit.Show()
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        My.Forms.frmSearch.Show()
        Me.Close()
    End Sub

    
End Class
