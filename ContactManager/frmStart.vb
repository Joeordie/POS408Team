Public Class frmStart

    'Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.frmEdit.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.frmSearch.Show()
        Me.Close()
    End Sub
End Class
