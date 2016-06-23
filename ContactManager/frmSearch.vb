


Public Class frmSearch
    Private Sub tbxFirstName_Click(sender As Object, e As EventArgs) Handles tbxFirstName.Click

    End Sub

    Private Sub tbxLastName_Click(sender As Object, e As EventArgs) Handles tbxLastName.Click

    End Sub

    Private Sub grpPersonal_Enter(sender As Object, e As EventArgs) Handles grpPersonal.Enter

    End Sub

    Private Sub grpCompany_Enter(sender As Object, e As EventArgs) Handles grpCompany.Enter

    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
        If e.KeyChar Like "[abcdefghijklmnopqrstuvwxyz]" _
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
        If e.KeyChar Like "[abcdefghijklmnopqrstuvwxyz]" _
            Or e.KeyChar = Chr(&H8) Then
            'following code instructs the application to not accept the keystroke because it does not match the required input range
            e.Handled = False
        End If
    End Sub

    
End Class