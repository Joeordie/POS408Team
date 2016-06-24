<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.grpPersonal = New System.Windows.Forms.GroupBox()
        Me.tbxPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.tbxLastName = New System.Windows.Forms.TextBox()
        Me.tbxFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.grpCompany = New System.Windows.Forms.GroupBox()
        Me.tbxCompanyAddr = New System.Windows.Forms.TextBox()
        Me.tbxCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompanyAddr = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grpPersonal.SuspendLayout()
        Me.grpCompany.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(6, 28)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(67, 15)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(354, 28)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(67, 15)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name"
        '
        'grpPersonal
        '
        Me.grpPersonal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpPersonal.Controls.Add(Me.tbxPhone)
        Me.grpPersonal.Controls.Add(Me.lblPhone)
        Me.grpPersonal.Controls.Add(Me.tbxEmail)
        Me.grpPersonal.Controls.Add(Me.tbxLastName)
        Me.grpPersonal.Controls.Add(Me.tbxFirstName)
        Me.grpPersonal.Controls.Add(Me.lblEmail)
        Me.grpPersonal.Controls.Add(Me.lblFirstName)
        Me.grpPersonal.Controls.Add(Me.lblLastName)
        Me.grpPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonal.Location = New System.Drawing.Point(12, 9)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Size = New System.Drawing.Size(720, 141)
        Me.grpPersonal.TabIndex = 2
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal Information"
        '
        'tbxPhone
        '
        Me.tbxPhone.Location = New System.Drawing.Point(427, 89)
        Me.tbxPhone.MaxLength = 18
        Me.tbxPhone.Name = "tbxPhone"
        Me.tbxPhone.Size = New System.Drawing.Size(246, 22)
        Me.tbxPhone.TabIndex = 6
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(354, 91)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(43, 15)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Phone"
        '
        'tbxEmail
        '
        Me.tbxEmail.Location = New System.Drawing.Point(79, 88)
        Me.tbxEmail.MaxLength = 25
        Me.tbxEmail.Name = "tbxEmail"
        Me.tbxEmail.Size = New System.Drawing.Size(246, 22)
        Me.tbxEmail.TabIndex = 5
        '
        'tbxLastName
        '
        Me.tbxLastName.Location = New System.Drawing.Point(427, 25)
        Me.tbxLastName.MaxLength = 25
        Me.tbxLastName.Name = "tbxLastName"
        Me.tbxLastName.Size = New System.Drawing.Size(246, 22)
        Me.tbxLastName.TabIndex = 4
        '
        'tbxFirstName
        '
        Me.tbxFirstName.Location = New System.Drawing.Point(79, 25)
        Me.tbxFirstName.MaxLength = 25
        Me.tbxFirstName.Name = "tbxFirstName"
        Me.tbxFirstName.Size = New System.Drawing.Size(246, 22)
        Me.tbxFirstName.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(6, 88)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email"
        '
        'grpCompany
        '
        Me.grpCompany.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpCompany.Controls.Add(Me.tbxCompanyAddr)
        Me.grpCompany.Controls.Add(Me.tbxCompanyName)
        Me.grpCompany.Controls.Add(Me.lblCompanyAddr)
        Me.grpCompany.Controls.Add(Me.lblCompanyName)
        Me.grpCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCompany.Location = New System.Drawing.Point(12, 169)
        Me.grpCompany.Name = "grpCompany"
        Me.grpCompany.Size = New System.Drawing.Size(502, 296)
        Me.grpCompany.TabIndex = 3
        Me.grpCompany.TabStop = False
        Me.grpCompany.Text = "Company Information"
        '
        'tbxCompanyAddr
        '
        Me.tbxCompanyAddr.Location = New System.Drawing.Point(12, 138)
        Me.tbxCompanyAddr.MaxLength = 75
        Me.tbxCompanyAddr.Multiline = True
        Me.tbxCompanyAddr.Name = "tbxCompanyAddr"
        Me.tbxCompanyAddr.Size = New System.Drawing.Size(409, 148)
        Me.tbxCompanyAddr.TabIndex = 8
        '
        'tbxCompanyName
        '
        Me.tbxCompanyName.Location = New System.Drawing.Point(12, 66)
        Me.tbxCompanyName.MaxLength = 25
        Me.tbxCompanyName.Name = "tbxCompanyName"
        Me.tbxCompanyName.Size = New System.Drawing.Size(313, 22)
        Me.tbxCompanyName.TabIndex = 7
        '
        'lblCompanyAddr
        '
        Me.lblCompanyAddr.AutoSize = True
        Me.lblCompanyAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyAddr.Location = New System.Drawing.Point(9, 105)
        Me.lblCompanyAddr.Name = "lblCompanyAddr"
        Me.lblCompanyAddr.Size = New System.Drawing.Size(106, 15)
        Me.lblCompanyAddr.TabIndex = 1
        Me.lblCompanyAddr.Text = "Company Address"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(9, 36)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(96, 15)
        Me.lblCompanyName.TabIndex = 0
        Me.lblCompanyName.Text = "Company Name"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(520, 420)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 44)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(629, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 44)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 476)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpCompany)
        Me.Controls.Add(Me.grpPersonal)
        Me.Name = "frmSearch"
        Me.Text = "Record View"
        Me.grpPersonal.ResumeLayout(False)
        Me.grpPersonal.PerformLayout()
        Me.grpCompany.ResumeLayout(False)
        Me.grpCompany.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents grpPersonal As GroupBox
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents tbxLastName As TextBox
    Friend WithEvents tbxFirstName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents grpCompany As GroupBox
    Friend WithEvents tbxPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents tbxCompanyAddr As TextBox
    Friend WithEvents tbxCompanyName As TextBox
    Friend WithEvents lblCompanyAddr As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Button2 As Button
End Class
