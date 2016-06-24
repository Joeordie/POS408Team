<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiResult
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
        Me.lbxMultiResult = New System.Windows.Forms.ListBox()
        Me.lblMultiResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbxMultiResult
        '
        Me.lbxMultiResult.FormattingEnabled = True
        Me.lbxMultiResult.Location = New System.Drawing.Point(7, 46)
        Me.lbxMultiResult.Name = "lbxMultiResult"
        Me.lbxMultiResult.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbxMultiResult.Size = New System.Drawing.Size(624, 602)
        Me.lbxMultiResult.TabIndex = 0
        '
        'lblMultiResult
        '
        Me.lblMultiResult.AutoSize = True
        Me.lblMultiResult.Location = New System.Drawing.Point(12, 9)
        Me.lblMultiResult.Name = "lblMultiResult"
        Me.lblMultiResult.Size = New System.Drawing.Size(204, 13)
        Me.lblMultiResult.TabIndex = 1
        Me.lblMultiResult.Text = "Your Query has Returned Multiple Results"
        '
        'frmMultiResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 651)
        Me.Controls.Add(Me.lblMultiResult)
        Me.Controls.Add(Me.lbxMultiResult)
        Me.Name = "frmMultiResult"
        Me.Text = "frmMultiResult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbxMultiResult As System.Windows.Forms.ListBox
    Friend WithEvents lblMultiResult As System.Windows.Forms.Label
End Class
