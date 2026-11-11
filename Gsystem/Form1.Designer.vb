<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAdmin = New Button()
        btnDriver = New Button()
        btnCustomer = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Location = New Point(25, 185)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(112, 34)
        btnAdmin.TabIndex = 0
        btnAdmin.Text = "Admin"
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnDriver
        ' 
        btnDriver.Location = New Point(25, 242)
        btnDriver.Name = "btnDriver"
        btnDriver.Size = New Size(112, 34)
        btnDriver.TabIndex = 1
        btnDriver.Text = "Driver"
        btnDriver.UseVisualStyleBackColor = True
        ' 
        ' btnCustomer
        ' 
        btnCustomer.Location = New Point(25, 292)
        btnCustomer.Name = "btnCustomer"
        btnCustomer.Size = New Size(112, 34)
        btnCustomer.TabIndex = 2
        btnCustomer.Text = "Customer"
        btnCustomer.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(12, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 36)
        Label1.TabIndex = 3
        Label1.Text = "Log In As"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(50, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(712, 36)
        Label2.TabIndex = 4
        Label2.Text = "ROAD: Routing Operations and Automated Dispatch"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(200, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 26)
        Label3.TabIndex = 5
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(25, 346)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = My.Resources.Resources.truck_logistics_operations_dusk
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCustomer)
        Controls.Add(btnDriver)
        Controls.Add(btnAdmin)
        Name = "Form1"
        Text = "LogIn Panel"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnDriver As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button

End Class
