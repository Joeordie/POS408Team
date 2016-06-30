Public Class frmEdit

    Dim strEditMode As String = "new"

    Public intContactUUID As Integer


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Forms.frmStart.Show()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim queryset As New QuerySet
        queryset.Loader(txtFirstName.Text, txtLastName.Text, TxtEmail.Text, txtPhone.Text, txtCompanyName.Text, txtCompanyAddr.Text)
        queryset.strPurpose = strEditMode
        Dim intExitCode As Integer = QueryModule.input(queryset)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Convert.ToInt16(tbxUUID.Text)
        If intContactUUID > 0 Then
            Dim queryset As New QuerySet
            queryset.UUID = intContactUUID
            queryset.strPurpose = "delete"
            Me.Hide()
            frmSearch.Show()
            QueryModule.input(queryset)
        ElseIf intContactUUID <= 0 Then
            MessageBox.Show("there is no record selected")
        End If

    End Sub

    Private Sub querytransport()
        'lets load this sucker up with the QuerySeyClass! 
        'Construction Phase
        Dim queryset As New QuerySet
        'Load Phase!
        queryset.Loader(txtFirstName.Text, txtLastName.Text, TxtEmail.Text, txtPhone.Text, txtCompanyName.Text, txtCompanyAddr.Text)
        queryset.UUID = intContactUUID
        'Transport Phase!
        Dim intSuccess As Integer

        intSuccess = QueryModule.input(queryset)
        If intSuccess = 0 Then
            'Do nothing it worked!
        Else
            MessageBox.Show("Ut-oh you have recieved an error code: " & intSuccess)
        End If
    End Sub

    Public Function Display(DisplaySet As Object)
        Dim intExitCode As Integer = 1
        If DisplaySet.intUUID > 0 Then
            tbxUUID.Text = DisplaySet.intUUID
            strEditMode = "write"
            txtFirstName.Text = DisplaySet.strFName
            txtLastName.Text = DisplaySet.strLName
            TxtEmail.Text = DisplaySet.strEmail
            txtPhone.Text = DisplaySet.strPhone
            txtCompanyName.Text = DisplaySet.strCompanyName
            txtCompanyAddr.Text = DisplaySet.strCompanyAddress
            'Might not be needed now
            intContactUUID = DisplaySet.intUUID
            intExitCode = 0
            Me.Show()
        End If

        Return intExitCode
    End Function



End Class


Public Class DisplaySet
    'Declare Class Attributes
    Public intUUID As Integer
    Public strFName As String
    Public strLName As String
    Public strEmail As String
    Public strPhone As String
    Public strCompanyName As String
    Public strCompanyAddress As String
    Public strPurpose As String = "display"

    'Routine to load variables
    Public Sub Loader(I As Integer, F As String, L As String, E As String, P As String, CN As String, CA As String)
        intUUID = I
        strFName = F
        strLName = L
        strEmail = E
        strPhone = P
        strCompanyName = CN
        strCompanyAddress = CA
    End Sub



End Class