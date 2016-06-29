<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.grpPersonal = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.grpCompany = New System.Windows.Forms.GroupBox()
        Me.txtCompanyAddr = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompanyAddr = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tbxUUID = New System.Windows.Forms.TextBox()
        Me.grpPersonal.SuspendLayout()
        Me.grpCompany.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPersonal
        '
        Me.grpPersonal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpPersonal.Controls.Add(Me.txtPhone)
        Me.grpPersonal.Controls.Add(Me.lblPhone)
        Me.grpPersonal.Controls.Add(Me.TxtEmail)
        Me.grpPersonal.Controls.Add(Me.txtLastName)
        Me.grpPersonal.Controls.Add(Me.txtFirstName)
        Me.grpPersonal.Controls.Add(Me.lblEmail)
        Me.grpPersonal.Controls.Add(Me.lblFirstName)
        Me.grpPersonal.Controls.Add(Me.lblLastName)
        Me.grpPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonal.Location = New System.Drawing.Point(12, 9)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Size = New System.Drawing.Size(720, 141)
        Me.grpPersonal.TabIndex = 3
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal Information"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(427, 89)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(246, 22)
        Me.txtPhone.TabIndex = 6
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
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(79, 88)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(246, 22)
        Me.TxtEmail.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(427, 25)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(246, 22)
        Me.txtLastName.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(79, 25)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(246, 22)
        Me.txtFirstName.TabIndex = 3
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
        'grpCompany
        '
        Me.grpCompany.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpCompany.Controls.Add(Me.txtCompanyAddr)
        Me.grpCompany.Controls.Add(Me.txtCompanyName)
        Me.grpCompany.Controls.Add(Me.lblCompanyAddr)
        Me.grpCompany.Controls.Add(Me.lblCompanyName)
        Me.grpCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCompany.Location = New System.Drawing.Point(12, 169)
        Me.grpCompany.Name = "grpCompany"
        Me.grpCompany.Size = New System.Drawing.Size(502, 296)
        Me.grpCompany.TabIndex = 4
        Me.grpCompany.TabStop = False
        Me.grpCompany.Text = "Company Information"
        '
        'txtCompanyAddr
        '
        Me.txtCompanyAddr.Location = New System.Drawing.Point(12, 138)
        Me.txtCompanyAddr.Multiline = True
        Me.txtCompanyAddr.Name = "txtCompanyAddr"
        Me.txtCompanyAddr.Size = New System.Drawing.Size(409, 148)
        Me.txtCompanyAddr.TabIndex = 8
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(12, 66)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(313, 22)
        Me.txtCompanyName.TabIndex = 7
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
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(639, 371)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(103, 44)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove User"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(530, 371)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(103, 44)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit User"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(591, 421)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 44)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'tbxUUID
        '
        Me.tbxUUID.Location = New System.Drawing.Point(569, 237)
        Me.tbxUUID.Name = "tbxUUID"
        Me.tbxUUID.Size = New System.Drawing.Size(100, 20)
        Me.tbxUUID.TabIndex = 13
        Me.tbxUUID.Visible = False
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 476)
        Me.Controls.Add(Me.tbxUUID)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.grpCompany)
        Me.Controls.Add(Me.grpPersonal)
        Me.Name = "frmEdit"
        Me.Text = "Form1"
        Me.grpPersonal.ResumeLayout(False)
        Me.grpPersonal.PerformLayout()
        Me.grpCompany.ResumeLayout(False)
        Me.grpCompany.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents grpCompany As System.Windows.Forms.GroupBox
    Friend WithEvents txtCompanyAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents lblCompanyAddr As System.Windows.Forms.Label
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents tbxUUID As System.Windows.Forms.TextBox
End Class
