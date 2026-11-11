<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriverDashboard
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
        lblWelcome = New Label()
        dgvDriverTrips = New DataGridView()
        dgvTripBookings = New DataGridView()
        btnViewBookings = New Button()
        cmbStatus = New ComboBox()
        btnUpdateStatus = New Button()
        btnBack = New Button()
        CType(dgvDriverTrips, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTripBookings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(321, 9)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 25)
        lblWelcome.TabIndex = 0
        ' 
        ' dgvDriverTrips
        ' 
        dgvDriverTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDriverTrips.Location = New Point(85, 106)
        dgvDriverTrips.Name = "dgvDriverTrips"
        dgvDriverTrips.RowHeadersWidth = 62
        dgvDriverTrips.Size = New Size(985, 123)
        dgvDriverTrips.TabIndex = 1
        ' 
        ' dgvTripBookings
        ' 
        dgvTripBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTripBookings.Location = New Point(85, 284)
        dgvTripBookings.Name = "dgvTripBookings"
        dgvTripBookings.RowHeadersWidth = 62
        dgvTripBookings.Size = New Size(985, 142)
        dgvTripBookings.TabIndex = 2
        ' 
        ' btnViewBookings
        ' 
        btnViewBookings.Location = New Point(85, 235)
        btnViewBookings.Name = "btnViewBookings"
        btnViewBookings.Size = New Size(181, 34)
        btnViewBookings.TabIndex = 3
        btnViewBookings.Text = "View Bookings"
        btnViewBookings.UseVisualStyleBackColor = True
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Scheduled", "In Progress", "Completed"})
        cmbStatus.Location = New Point(84, 28)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(182, 33)
        cmbStatus.TabIndex = 4
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.Location = New Point(905, 52)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(165, 34)
        btnUpdateStatus.TabIndex = 5
        btnUpdateStatus.Text = "Update Status"
        btnUpdateStatus.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(500, 432)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmDriverDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LemonChiffon
        BackgroundImage = My.Resources.Resources.truck_logistics_operations_dusk
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1142, 492)
        Controls.Add(btnBack)
        Controls.Add(btnUpdateStatus)
        Controls.Add(cmbStatus)
        Controls.Add(btnViewBookings)
        Controls.Add(dgvTripBookings)
        Controls.Add(dgvDriverTrips)
        Controls.Add(lblWelcome)
        Name = "frmDriverDashboard"
        Text = "Driverdashboard"
        CType(dgvDriverTrips, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTripBookings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents dgvDriverTrips As DataGridView
    Friend WithEvents dgvTripBookings As DataGridView
    Friend WithEvents btnViewBookings As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents btnBack As Button
End Class
