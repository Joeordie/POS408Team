Module QueryModule

    Public strDataBaseFileLocation As String = "C:\Users\carro\Downloads\Contacts.accdb"

    Public Function input(QuerySet As Object) As Integer
        'This Class-less function directs QuerySet objects where they are directed
        Dim intExitCode As Integer = 1
        'Standard success Fail indicator
        If QuerySet.strPurpose = "search" Then
            Dim objSearchBuild As New SearchBuild
            intExitCode = objSearchBuild.Load(QuerySet)
        ElseIf QuerySet.strPurpose = "write" Then
            'Do something with WriterBuild Class
            intExitCode = 1
            MessageBox.Show("writing has not been implemented yet")
        ElseIf QuerySet.strPurpose = "display" Then
            intExitCode = 1
            MessageBox.Show("display has not been implemented yet")
        ElseIf QuerySet.strPurpose = "multi" Then
            intExitCode = 1
            MessageBox.Show("multi display has not been implemented yet")
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
            Dim strSearchField As String
            Dim StrSearchCriterion As String
            If Len(QuerySet.strPhone) > 0 Then
                strSearchField = "PhoneNumber"
                StrSearchCriterion = Trim(QuerySet.strPhone)
            ElseIf Len(QuerySet.strLName) > 0 Then
                strSearchField = "LastName"
                StrSearchCriterion = QuerySet.strLName
            ElseIf Len(QuerySet.strFName) > 0 Then
                strSearchField = "FirstName"
                StrSearchCriterion = QuerySet.strFName
            ElseIf Len(QuerySet.strCompanyName) > 0 Then
                strSearchField = "Company"
                StrSearchCriterion = QuerySet.strCompanyName
            Else
                MessageBox.Show("Try again bub no searchable Fields Entered")
            End If

            strSQLStatement = ("SELECT * FROM Table1 WHERE " & strSearchField & " LIKE '" & StrSearchCriterion & "%';")
            searchConnection.send(strSQLStatement)

        End Sub

        Private Sub SQLAll()
            'PreBuilt SQL Statement
            strSQLStatement = "SELECT * FROM Table1"
            searchConnection.send(strSQLStatement)
            MessageBox.Show(strSQLStatement)
        End Sub

    End Class

    Public Class WriteBuild
        Public Function Load(QuerySet As Object) As Integer
            Dim intExitCode As Integer = 0
            MessageBox.Show("you are writing")
            Return intExitCode
        End Function
    End Class

    Public Class MultiResultSet

    End Class

    Public Class SQLInterface
        ' Alot is taken from: http://www.homeandlearn.co.uk/NET/nets12p4.html
        Dim dbConnection As New OleDb.OleDbConnection
        Dim strDBConDetails As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & strDataBaseFileLocation
        Dim objDataSet As New DataSet
        Dim objDataAdapter As OleDb.OleDbDataAdapter

        Public Sub send(strSQLStatement As String)
            'Dial up DB connection
            dbConnection.ConnectionString = strDBConDetails
            'Open Connection
            dbConnection.Open()
            'Create adapter send sQL statement 
            objDataAdapter = New OleDb.OleDbDataAdapter(strSQLStatement, dbConnection)
            'Close Database so we dont let flies in.
            dbConnection.Close()

            Try
                'Load DataSet with results
                objDataAdapter.Fill(objDataSet, "SearchResultSet")
                'count rows in result
                Dim intlastRow = (objDataSet.Tables("SearchResultSet").Rows.Count) - 1
                'if there is more than one [0] results we use the multi record screen
                If intlastRow > 1 Then
                    'Set string assmebly var
                    Dim strResultLine As String = ""
                    'clear last set of results
                    frmMulti.clear()
                    'for loop to write out every record 
                    For r = 0 To intlastRow
                        Dim rownum As Integer = Convert.ToInt16(r)
                        For c = 1 To 3
                            strResultLine = strResultLine & (objDataSet.Tables("SearchResultSet").Rows(r).Item(c) & vbTab)
                        Next
                        frmMulti.ResultLoad(strResultLine)
                        strResultLine = ""
                    Next
                    frmMulti.ResultLoad(strResultLine)
                    strResultLine = ""
                    frmSearch.Hide()
                    frmMulti.Show()
                Else
                    'Display Set
                End If
            Catch ex As Exception
                MessageBox.Show("No Records Available")
                frmSearch.Show()
            End Try
           

            
        End Sub

    End Class



End Module
