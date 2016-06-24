


Public Class frmSearch
    'Declares variables that will be used  the data for strphone,
    'strFirstName, strLastName, strEmail, strCompanyName and strCompany address will all be strings
    'email will be required to have a @ and a .  strFirstName strLastName, strCompanyAddress will be permitted to have numbers and letters
    'strCompany name will be allowed to have all numbers, letters and special characters due to potential naming conventions of the company
    'values will be obtained from the textbox data entered by the user if
    'a new entry is being created and will be populated by the Database if queried in the search page as well as entered by the user for the search string

    Dim intPhone As Integer
    Dim strFirstName As String
    Dim strLastName As String
    Dim stremail As String
    Dim strCompanyName As String
    Dim strCompanyAddress As String


    'Clicking back button closes frmSearch and opens frmStart
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Forms.frmStart.Show()
        Me.Close()
    End Sub
    'Validates input so that only numbers or a "." can be entered in the text box and also allows the user to use the backspace key to correct their input if they make a mistake
    'All other keystrokes will be ignored.
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
            'following code instructs the application to not accept the keystroke because it does not match the required input range.
            e.Handled = False
        End If
    End Sub

    
End Class