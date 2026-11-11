<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminLogin
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
        lblMessage = New Label()
        CheckBox1 = New CheckBox()
        btnLogin = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        btnCancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(368, 354)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 25)
        lblMessage.TabIndex = 13
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(632, 189)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(22, 21)
        CheckBox1.TabIndex = 12
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(431, 245)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 11
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(324, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 10
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(320, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 25)
        Label1.TabIndex = 9
        Label1.Text = "Username:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(431, 185)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(223, 31)
        txtPassword.TabIndex = 8
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(431, 113)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(223, 31)
        txtUsername.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._123
        PictureBox1.Location = New Point(90, 94)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(183, 204)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(72, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(213, 32)
        Label3.TabIndex = 15
        Label3.Text = "Log In as Admin"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(549, 245)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmAdminLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancel)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(lblMessage)
        Controls.Add(CheckBox1)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "frmAdminLogin"
        Text = "Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
End Class
