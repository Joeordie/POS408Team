Public Class frmStart

    'Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If lblFilePath.Text = "File Path" Then
            MessageBox.Show("Please Select a Database file path before proceeding")
        Else
            frmEdit.intContactUUID = 0
            My.Forms.frmEdit.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If lblFilePath.Text = "File Path" Then
            MessageBox.Show("Please Select a Database file path before proceeding")
        Else

            My.Forms.frmSearch.Show()
            Me.Hide()
            frmEdit.intContactUUID = 0

        End If

    End Sub

    Public Sub btnDataBase_Click(sender As Object, e As EventArgs) Handles btnDataBase.Click

        'Allows user to select the file path for their database
        If ofdDatabase.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            'lblfilepath.text is changed to the file path of the selected database
            lblFilePath.Text = ofdDatabase.FileName
        End If

    End Sub

    
End Class
