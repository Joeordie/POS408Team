Public Class frmMulti

   

    Public Sub clear()
        lstMultipleResults.Items.Clear()
    End Sub

    Public Sub ResultLoad(strResultLine As String)
        lstMultipleResults.Items.Add(strResultLine)
    End Sub


   
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnMultiBack.Click
        My.Forms.frmSearch.Show()
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        'lstMultipleResults.SelectedIndex()
        'Verify that an item was selected
        If lstMultipleResults.SelectedIndex = -1 Then
            'If ListIndex is -1, nothing selected
            MsgBox("Nothing was selected!")
        Else
            'If ListIndex not -1 inform user what was selected
            MsgBox("You selected " & lstMultipleResults.SelectedIndex.ToString)
        End If

    End Sub

   

End Class