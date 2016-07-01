<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDataBase = New System.Windows.Forms.Button()
        Me.ofdDatabase = New System.Windows.Forms.OpenFileDialog()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(91, 60)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(218, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(91, 60)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDataBase
        '
        Me.btnDataBase.Location = New System.Drawing.Point(12, 78)
        Me.btnDataBase.Name = "btnDataBase"
        Me.btnDataBase.Size = New System.Drawing.Size(91, 60)
        Me.btnDataBase.TabIndex = 2
        Me.btnDataBase.Text = "DataBase File Select"
        Me.btnDataBase.UseVisualStyleBackColor = True
        '
        'ofdDatabase
        '
        Me.ofdDatabase.FileName = "OpenFileDialog1"
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Location = New System.Drawing.Point(12, 152)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(48, 13)
        Me.lblFilePath.TabIndex = 4
        Me.lblFilePath.Text = "File Path"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(218, 78)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 60)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 184)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.btnDataBase)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "frmStart"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDataBase As System.Windows.Forms.Button
    Friend WithEvents ofdDatabase As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
