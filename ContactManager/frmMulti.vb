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
            Dim strSelectedUUID = Trim(lstMultipleResults.SelectedItem.ToString.Substring(0, 2))
            Dim intSelectedUUID = Convert.ToInt16(strSelectedUUID)
            Dim queryset As New QuerySet
            queryset.UUID = intSelectedUUID
            queryset.strPurpose = "search"
            QueryModule.input(queryset)
            Me.Hide()
        End If

    End Sub
    'I had a problem: when closing this form with the "X" the form would close but left the program running with no visible forms
    Private Sub frmMulti_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If form is closed using the "X", it will return to search form  

        My.Forms.frmSearch.Show()

    End Sub
End Class