


Public Class frmSearch
    

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Forms.frmStart.Show()
        Me.Close()
    End Sub
    'Validates input so that only numbers or a "." can be entered in the text box and also allows the user to use the backspace key to correct their input if they make a mistake
    'All other keystrokes will be ignored
    'Mead, G. (2009). How to Restrict TextBox Input. Retrieved from http://vbcity.com/blogs/xtab/archive/2009/06/08/restrictiong-textbox-input.aspx
    Private Sub tbxPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxPhone.KeyPress
        e.Handled = True
        If e.KeyChar Like "[.1234567890]" _
            Or e.KeyChar = Chr(&H8) Then
            'following code instructs the application to not accept the keystroke because it does not match the required input range
            e.Handled = False
        End If
    End Sub
    'Validates input so that only numbers or a "." can be entered in the text box and also allows the user to use the backspace key to correct their input if they make a mistake
    'All other keystrokes will be ignored
    'Mead, G. (2009). How to Restrict TextBox Input. Retrieved from http://vbcity.com/blogs/xtab/archive/2009/06/08/restrictiong-textbox-input.aspx
    Private Sub tbxFirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxFirstName.KeyPress
        e.Handled = True
        If e.KeyChar Like "[abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ]" _
            Or e.KeyChar = Chr(&H8) Then
            'following code instructs the application to not accept the keystroke because it does not match the required input range
            e.Handled = False
        End If
    End Sub
    'Validates input so that only numbers or a "." can be entered in the text box and also allows the user to use the backspace key to correct their input if they make a mistake
    'All other keystrokes will be ignored
    'Mead, G. (2009). How to Restrict TextBox Input. Retrieved from http://vbcity.com/blogs/xtab/archive/2009/06/08/restrictiong-textbox-input.aspx
    Private Sub tbxLastName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxLastName.KeyPress
        e.Handled = True
        If e.KeyChar Like "[abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ]" _
            Or e.KeyChar = Chr(&H8) Then
            'following code instructs the application to not accept the keystroke because it does not match the required input range.
            e.Handled = False
        End If
    End Sub

    Private Sub frmSearch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmStart.Show()
    End Sub

    
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub querytransport()
        'lets load this sucker up with the QuerySeyClass! 
        'Construction Phase
        Dim queryset As New QuerySet
        'Load Phase!
        queryset.Loader(tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, _
            tbxPhone.Text, tbxCompanyName.Text)
        'Transport Phase!
        Dim intSuccess As Integer

        intSuccess = QueryModule.input(queryset)
        If intSuccess = 0 Then
            'Do nothing it worked!
            Me.Hide()
        Else
            MessageBox.Show("Ut-oh you have recieved an error code: " & intSuccess)
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        querytransport()
    End Sub
End Class


Public Class QuerySet
    'Declare Class Attributes
    Public UUID As Integer
    Public strFName As String
    Public strLName As String
    Public strEmail As String
    Public strPhone As String
    Public strCompanyName As String
    Public strPurpose As String = "search"

    'Routine to load variables
    Public Sub Loader(F As String, L As String, E As String, P As String, CN As String)
        strFName = F
        strLName = L
        strEmail = E
        strPhone = P
        strCompanyName = CN
    End Sub

    'Private Sub frmSearch_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.formClosing
    '    frmStart.Show()
    'End Sub
End Class
