Module QueryModule
    'sets the srtDataBaseFileLocation to the lblFilePath.Text that the user selected on the start page
    Public strDataBaseFileLocation As String = frmStart.lblFilePath.Text

    'strFilePath = strFilePath = frmStart.txtDatabase.text 
    Public Function input(QuerySet As Object) As Integer
        'This Class-less function directs QuerySet objects where they are directed
        Dim intExitCode As Integer = 1
        'Standard success Fail indicator
        If QuerySet.strPurpose = "search" Then
            Dim objSearchBuild As New SearchBuild
            intExitCode = objSearchBuild.Load(QuerySet)
        ElseIf QuerySet.strPurpose = "write" Or QuerySet.strPurpose = "new" Then
            Dim objWriteBuild As New WriteBuild
            intExitCode = objWriteBuild.Load(QuerySet)
        ElseIf QuerySet.strPurpose = "delete" Then
            intExitCode = 1
            Dim intUUID As Integer = QuerySet.UUID
            Dim strSQLStatement As String = ("DELETE FROM Table1 WHERE " & "ID" & "=" & intUUID & ";")
            Dim SQLInterface As New SQLInterface
            SQLInterface.send(strSQLStatement, "delete")
            'call frmEdit.clear()
            frmEdit.intContactUUID = 0
        End If

        Return intExitCode

    End Function

    Public Class SearchBuild
        'Set up searchconnection object see "SQLInterface" Class
        Dim searchConnection As New SQLInterface
        Dim strSQLStatement As String

        Public Function Load(QuerySet As Object) As Integer
            'This function brings the QuerySet into this class for Manipulation
            Dim intExitCode As Integer = 1
            If QuerySet.strFName = "all" Or QuerySet.strFName = "*" Then
                'Search is for all records skip search assembly
                intExitCode = 0
                SQLAll()
            Else
                SQLMagic(QuerySet)
                intExitCode = 0
            End If

            Return intExitCode

        End Function
        Private Sub SQLMagic(QuerySet As Object)
            'These are the variables we have to stearch by
            Dim strSearchField As String = ""
            Dim StrSearchCriterion As String = ""
            'Repeating If for length of Fields, in order of operations'
            'Then set the appropriate Database Field name and pass criteron to SQL Like Statement
            'Trim Statements are to pull off whitespace
            If QuerySet.UUID > 0 Then
                strSearchField = "ID"
                StrSearchCriterion = QuerySet.UUID
            ElseIf Len(QuerySet.strPhone) > 0 Then
                strSearchField = "PhoneNumber"
                StrSearchCriterion = Trim(QuerySet.strPhone)
            ElseIf Len(QuerySet.strEmail) > 0 Then
                strSearchField = "Email"
                StrSearchCriterion = Trim(QuerySet.strEmail)
            ElseIf Len(QuerySet.strLName) > 0 Then
                strSearchField = "LastName"
                StrSearchCriterion = Trim(QuerySet.strLName)
            ElseIf Len(QuerySet.strFName) > 0 Then
                strSearchField = "FirstName"
                StrSearchCriterion = Trim(QuerySet.strFName)
            ElseIf Len(QuerySet.strCompanyName) > 0 Then
                strSearchField = "Company"
                StrSearchCriterion = Trim(QuerySet.strCompanyName)
            Else
                'If nothing is entered its cause Mr. Kandan is trying to break the application
                MessageBox.Show("Try again bub no searchable Fields Entered")
            End If
            If strSearchField = "ID" Then
                'SQL Statement Constructor
                strSQLStatement = ("SELECT * FROM Table1 WHERE " & strSearchField & "=" & StrSearchCriterion & ";")
            Else
                'SQL Statement Constructor
                strSQLStatement = ("SELECT * FROM Table1 WHERE " & strSearchField & " LIKE '" & StrSearchCriterion & "%';")
            End If
            'Send to database connection
            searchConnection.send(strSQLStatement, "read")

        End Sub

        Private Sub SQLAll()
            'PreBuilt SQL Statement for returning all results
            strSQLStatement = "SELECT * FROM Table1"
            searchConnection.send(strSQLStatement, "read") 'send sqlstatement to interface
        End Sub

    End Class

    Public Class WriteBuild

        Public Function Load(QuerySet As Object) As Integer
            'Declare Variables and cast QuerySet attributes into variables!
            Dim writeConnection = New SQLInterface
            Dim strSQLStatement As String
            Dim intExitCode As Integer = 0 'Exit Code to be passed back to start
            Dim intContactUUID = frmEdit.intContactUUID 'HouseKeeping!!!
            Dim strFN As String = QuerySet.strFName
            Dim strLN As String = QuerySet.strLName
            Dim strComp As String = QuerySet.strCompanyName
            Dim strPhone As String = QuerySet.strPhone
            Dim strEmail As String = QuerySet.strEmail
            Dim strCompLit As String = QuerySet.strCompanyAdd
            Dim strCompZip As String
            Dim strCompAdd As String
            'Need to split up Address block into seperate datafields: 
            If Len(strCompLit) > 5 Then 'Prevent Exception by checking length of AddressLiteral
                strCompZip = strCompLit.Substring(Len(strCompLit) - 5) 'set zip code as last 5 chars in address literal
                strCompAdd = strCompLit.Substring(0, (Len(strCompLit) - 5)) 'grab the rest of the literal as the address string
            Else 'If your address string is less than 5 characters the above section wont work, and were going to set the address to "Empty"
                MessageBox.Show("really?")
                strCompZip = "Empty"
                strCompAdd = "Empty"
            End If
            'Decision for flow control "new" records use the INSERT INTO sql statement, which has different argument order than update.... annoying. 
            If QuerySet.strPurpose = "new" Then
                strSQLStatement = ("INSERT INTO Table1 (FirstName,LastName,Company,PhoneNumber,EMail,Address,Zip) VALUES('" & strFN & "','" & strLN & _
                                                 "','" & strComp & "','" & strPhone & "','" & strEmail & "','" & strCompAdd & "','" & strCompZip & "');")
                writeConnection.send(strSQLStatement, "new") 'send sql statement to interface "writeConnection" with "new" flag. 
                intExitCode = 0
            ElseIf QuerySet.strPurpose = "write" Then
                strSQLStatement = ("UPDATE Table1 SET FirstName='" & strFN & "',LastName='" & strLN & "',Company='" & strComp & "',PhoneNumber='" & strPhone & _
                                   "',EMail='" & strEmail & "',Address='" & strCompAdd & "',Zip='" & strCompZip & "' WHERE ID=" & intContactUUID & ";")
                writeConnection.send(strSQLStatement, "write") 'send sql statemetn to interface "writeConnection" with "write" flag. 
                intExitCode = 0
            End If

            Return intExitCode 'send exit code back no longer needed could be removed. 
        End Function

    End Class

    Public Class SQLInterface
        'This is the only way to connect to the database.  Using more cannonic SQL commands because working with Access commands is not really good training for real databases. 
        ' Alot is taken from: http://www.homeandlearn.co.uk/NET/nets12p4.html
        Dim dbConnection As New OleDb.OleDbConnection 'Create Connection Object
        Dim strDBConDetails As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & strDataBaseFileLocation 'Pass connection details to connection object
        Dim objDataSet As New DataSet 'Create DataSet object to contain record info after retrieval
        Dim objDataAdapter As OleDb.OleDbDataAdapter 'Create adapter object to connect dbConnection to DataSet

        Public Sub send(strSQLStatement As String, strPurpose As String)
            'Dial up DB connection
            dbConnection.ConnectionString = strDBConDetails
            'Open Connection
            dbConnection.Open()
            'Close Database so we dont let flies in.

            If strPurpose = "read" Then
                'Create adapter send sQL statement 
                objDataAdapter = New OleDb.OleDbDataAdapter(strSQLStatement, dbConnection)
                dbConnection.Close()
                Try
                    'Load DataSet with results
                    objDataAdapter.Fill(objDataSet, "SearchResultSet")
                    'count rows in result
                    Dim intlastRow = (objDataSet.Tables("SearchResultSet").Rows.Count) - 1
                    'if there is more than one [0] results we use the multi record screen
                    If intlastRow > 1 Then
                        'Set string assmebly variable
                        Dim strResultLine As String = ""
                        'clear last set of results
                        frmMulti.clear()
                        'for loop to write out every record 
                        For r = 0 To intlastRow
                            Dim rownum As Integer = Convert.ToInt16(r)
                            For c = 0 To 3
                                strResultLine = strResultLine & (objDataSet.Tables("SearchResultSet").Rows(r).Item(c) & vbTab)
                            Next
                            'After each record is constructed send to frmMulti
                            frmMulti.ResultLoad(strResultLine)
                            strResultLine = ""
                        Next
                        frmMulti.ResultLoad(strResultLine)
                        'clear resutline
                        strResultLine = ""
                        'hide search form
                        frmSearch.Hide()
                        'show multi result form
                        frmMulti.Show()
                    Else
                        'Else is for single or <0 recordindex
                        'Create new DisplaySet
                        Dim objDisplaySet = New DisplaySet
                        'load record set Loader Sub will not work directly because of the objDataSet.Tables reference
                        'must be cast :(
                        Dim intUUID As Integer = objDataSet.Tables("SearchResultSet").Rows(0).Item(0)
                        frmEdit.intContactUUID = intUUID
                        Dim strFName As String = objDataSet.Tables("SearchResultSet").Rows(0).Item(1)
                        Dim strLName As String = objDataSet.Tables("SearchResultSet").Rows(0).Item(2)
                        Dim strCompanyName As String = objDataSet.Tables("SearchResultSet").Rows(0).Item(3)
                        Dim strPhone As String = objDataSet.Tables("SearchResultSet").Rows(0).Item(4)
                        Dim strEmail As String = objDataSet.Tables("SearchResultset").Rows(0).Item(5)
                        Dim strCompAddress As String = objDataSet.Tables("SearchResultSet").Rows(0).Item(6) & vbNewLine & objDataSet.Tables("SearchResultSet").Rows(0).Item(7)
                        'load object up!!!!
                        objDisplaySet.Loader(intUUID, strFName, strLName, strEmail, strPhone, strCompanyName, strCompAddress)
                        'call display function "Get it Out of Here! -Richard Stallman-
                        frmEdit.Display(objDisplaySet)
                    End If
                Catch ex As Exception
                    MessageBox.Show("No Records Available") 'Not the greatest pop up but it so far has been accurate
                    frmSearch.Show() 'Since you couldnt get it done show the search form again
                End Try
            ElseIf strPurpose = "delete" Then
                'This is different than SQL Query functions above.
                'Create a objCmd object with the SQL statement created in the QueryModule.input() and attach the approprate dbConnection variable crafted in this class
                Dim objCmd As New OleDb.OleDbCommand(strSQLStatement, dbConnection)
                'Send command and EXPECT NO RETURN!!!!
                objCmd.ExecuteNonQuery()
                'Close dbConnection so flies don't get in
                dbConnection.Close()
                'Notify user of success!
                MessageBox.Show("boom!!! you deleted that junk son!")
            ElseIf strPurpose = "write" Or strPurpose = "new" Then 'Virtually the same as above. 
                Dim objCmd As New OleDb.OleDbCommand(strSQLStatement, dbConnection)
                objCmd.ExecuteNonQuery()
                dbConnection.Close()
                MessageBox.Show("you should have written to the database")
            End If
        End Sub

    End Class

End Module
