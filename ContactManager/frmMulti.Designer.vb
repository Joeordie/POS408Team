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
        Me.lstMultipleResults.ItemHeight = 16
        Me.lstMultipleResults.Location = New System.Drawing.Point(36, 54)
        Me.lstMultipleResults.Margin = New System.Windows.Forms.Padding(4)
        Me.lstMultipleResults.Name = "lstMultipleResults"
        Me.lstMultipleResults.Size = New System.Drawing.Size(911, 436)
        Me.lstMultipleResults.TabIndex = 0
        '
        'lblMultiResult
        '
        Me.lblMultiResult.AutoSize = True
        Me.lblMultiResult.Location = New System.Drawing.Point(36, 16)
        Me.lblMultiResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMultiResult.Name = "lblMultiResult"
        Me.lblMultiResult.Size = New System.Drawing.Size(193, 17)
        Me.lblMultiResult.TabIndex = 1
        Me.lblMultiResult.Text = "Please Select Record to View"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(811, 511)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(137, 54)
        Me.btnSelect.TabIndex = 12
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnMultiBack
        '
        Me.btnMultiBack.Location = New System.Drawing.Point(667, 511)
        Me.btnMultiBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMultiBack.Name = "btnMultiBack"
        Me.btnMultiBack.Size = New System.Drawing.Size(137, 54)
        Me.btnMultiBack.TabIndex = 11
        Me.btnMultiBack.Text = "Back"
        Me.btnMultiBack.UseVisualStyleBackColor = True
        '
        'frmMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 586)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnMultiBack)
        Me.Controls.Add(Me.lblMultiResult)
        Me.Controls.Add(Me.lstMultipleResults)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
