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
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.lblModeSelect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 67)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(91, 60)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New Record / Edit Record"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(137, 67)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(91, 60)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search Record"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'lblModeSelect
        '
        Me.lblModeSelect.AutoSize = True
        Me.lblModeSelect.Location = New System.Drawing.Point(9, 29)
        Me.lblModeSelect.Name = "lblModeSelect"
        Me.lblModeSelect.Size = New System.Drawing.Size(227, 13)
        Me.lblModeSelect.TabIndex = 2
        Me.lblModeSelect.Text = "Please Select New Record or Search Records"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 149)
        Me.Controls.Add(Me.lblModeSelect)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "frmStart"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents lblModeSelect As System.Windows.Forms.Label
End Class
