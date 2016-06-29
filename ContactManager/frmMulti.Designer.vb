<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMulti
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
        Me.lstMultipleResults = New System.Windows.Forms.ListBox()
        Me.lblMultiResult = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnMultiBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMultipleResults
        '
        Me.lstMultipleResults.FormattingEnabled = True
        Me.lstMultipleResults.Location = New System.Drawing.Point(27, 44)
        Me.lstMultipleResults.Name = "lstMultipleResults"
        Me.lstMultipleResults.Size = New System.Drawing.Size(684, 355)
        Me.lstMultipleResults.TabIndex = 0
        '
        'lblMultiResult
        '
        Me.lblMultiResult.AutoSize = True
        Me.lblMultiResult.Location = New System.Drawing.Point(27, 13)
        Me.lblMultiResult.Name = "lblMultiResult"
        Me.lblMultiResult.Size = New System.Drawing.Size(148, 13)
        Me.lblMultiResult.TabIndex = 1
        Me.lblMultiResult.Text = "Please Select Record to View"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(608, 415)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(103, 44)
        Me.btnSelect.TabIndex = 12
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnMultiBack
        '
        Me.btnMultiBack.Location = New System.Drawing.Point(500, 415)
        Me.btnMultiBack.Name = "btnMultiBack"
        Me.btnMultiBack.Size = New System.Drawing.Size(103, 44)
        Me.btnMultiBack.TabIndex = 11
        Me.btnMultiBack.Text = "Back"
        Me.btnMultiBack.UseVisualStyleBackColor = True
        '
        'frmMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 476)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnMultiBack)
        Me.Controls.Add(Me.lblMultiResult)
        Me.Controls.Add(Me.lstMultipleResults)
        Me.Name = "frmMulti"
        Me.Text = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstMultipleResults As System.Windows.Forms.ListBox
    Friend WithEvents lblMultiResult As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnMultiBack As System.Windows.Forms.Button
End Class
