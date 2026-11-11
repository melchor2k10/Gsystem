<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminDashboard
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
        pnlEditTrip = New Panel()
        cmbStatus = New ComboBox()
        txtEditDestination = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        label3 = New Label()
        Label2 = New Label()
        btnSaveEdit = New Button()
        txtEditOrigin = New TextBox()
        txtDriverName = New TextBox()
        txtBusNumber = New TextBox()
        cmbTripActions = New ComboBox()
        Label1 = New Label()
        pnlDeleteTrip = New Panel()
        btnDeleteTrip = New Button()
        pnlReschedule = New Panel()
        btnRescheduleTrip = New Button()
        dtpNewTripDate = New DateTimePicker()
        dgvTrips = New DataGridView()
        btnBack = New Button()
        pnlEditTrip.SuspendLayout()
        pnlDeleteTrip.SuspendLayout()
        pnlReschedule.SuspendLayout()
        CType(dgvTrips, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(600, 9)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(63, 25)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Label1"
        ' 
        ' pnlEditTrip
        ' 
        pnlEditTrip.BackColor = Color.Transparent
        pnlEditTrip.Controls.Add(cmbStatus)
        pnlEditTrip.Controls.Add(txtEditDestination)
        pnlEditTrip.Controls.Add(Label5)
        pnlEditTrip.Controls.Add(Label4)
        pnlEditTrip.Controls.Add(label3)
        pnlEditTrip.Controls.Add(Label2)
        pnlEditTrip.Controls.Add(btnSaveEdit)
        pnlEditTrip.Controls.Add(txtEditOrigin)
        pnlEditTrip.Controls.Add(txtDriverName)
        pnlEditTrip.Controls.Add(txtBusNumber)
        pnlEditTrip.Location = New Point(496, 43)
        pnlEditTrip.Name = "pnlEditTrip"
        pnlEditTrip.Size = New Size(862, 133)
        pnlEditTrip.TabIndex = 1
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Scheduled", "In Transit", "Completed"})
        cmbStatus.Location = New Point(7, 88)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(182, 33)
        cmbStatus.TabIndex = 11
        ' 
        ' txtEditDestination
        ' 
        txtEditDestination.Location = New Point(620, 50)
        txtEditDestination.Name = "txtEditDestination"
        txtEditDestination.Size = New Size(189, 31)
        txtEditDestination.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(668, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 25)
        Label5.TabIndex = 9
        Label5.Text = "Destination"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(465, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 25)
        Label4.TabIndex = 8
        Label4.Text = "Origin"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.ForeColor = SystemColors.ButtonHighlight
        label3.Location = New Point(246, 10)
        label3.Name = "label3"
        label3.Size = New Size(111, 25)
        label3.TabIndex = 7
        label3.Text = "Driver Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(49, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 25)
        Label2.TabIndex = 6
        Label2.Text = "Bus no."
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.Location = New Point(273, 87)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(166, 34)
        btnSaveEdit.TabIndex = 5
        btnSaveEdit.Text = "Save Changes"
        btnSaveEdit.UseVisualStyleBackColor = True
        ' 
        ' txtEditOrigin
        ' 
        txtEditOrigin.Location = New Point(412, 50)
        txtEditOrigin.Name = "txtEditOrigin"
        txtEditOrigin.Size = New Size(189, 31)
        txtEditOrigin.TabIndex = 4
        ' 
        ' txtDriverName
        ' 
        txtDriverName.Location = New Point(210, 50)
        txtDriverName.Name = "txtDriverName"
        txtDriverName.Size = New Size(196, 31)
        txtDriverName.TabIndex = 1
        ' 
        ' txtBusNumber
        ' 
        txtBusNumber.Location = New Point(3, 50)
        txtBusNumber.Name = "txtBusNumber"
        txtBusNumber.Size = New Size(201, 31)
        txtBusNumber.TabIndex = 0
        ' 
        ' cmbTripActions
        ' 
        cmbTripActions.FormattingEnabled = True
        cmbTripActions.Location = New Point(12, 81)
        cmbTripActions.Name = "cmbTripActions"
        cmbTripActions.Size = New Size(462, 33)
        cmbTripActions.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(172, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 0
        Label1.Text = "Manage Trip"
        ' 
        ' pnlDeleteTrip
        ' 
        pnlDeleteTrip.BackColor = Color.Transparent
        pnlDeleteTrip.Controls.Add(btnDeleteTrip)
        pnlDeleteTrip.Location = New Point(66, 560)
        pnlDeleteTrip.Name = "pnlDeleteTrip"
        pnlDeleteTrip.Size = New Size(119, 68)
        pnlDeleteTrip.TabIndex = 2
        ' 
        ' btnDeleteTrip
        ' 
        btnDeleteTrip.Location = New Point(3, 14)
        btnDeleteTrip.Name = "btnDeleteTrip"
        btnDeleteTrip.Size = New Size(108, 37)
        btnDeleteTrip.TabIndex = 0
        btnDeleteTrip.Text = "Delete Trip"
        btnDeleteTrip.UseVisualStyleBackColor = True
        ' 
        ' pnlReschedule
        ' 
        pnlReschedule.BackColor = Color.Transparent
        pnlReschedule.Controls.Add(btnRescheduleTrip)
        pnlReschedule.Controls.Add(dtpNewTripDate)
        pnlReschedule.Location = New Point(203, 560)
        pnlReschedule.Name = "pnlReschedule"
        pnlReschedule.Size = New Size(460, 68)
        pnlReschedule.TabIndex = 3
        ' 
        ' btnRescheduleTrip
        ' 
        btnRescheduleTrip.Location = New Point(331, 14)
        btnRescheduleTrip.Name = "btnRescheduleTrip"
        btnRescheduleTrip.Size = New Size(112, 34)
        btnRescheduleTrip.TabIndex = 2
        btnRescheduleTrip.Text = "Reschedule"
        btnRescheduleTrip.UseVisualStyleBackColor = True
        ' 
        ' dtpNewTripDate
        ' 
        dtpNewTripDate.Location = New Point(16, 14)
        dtpNewTripDate.Name = "dtpNewTripDate"
        dtpNewTripDate.Size = New Size(300, 31)
        dtpNewTripDate.TabIndex = 1
        ' 
        ' dgvTrips
        ' 
        dgvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTrips.GridColor = SystemColors.InactiveBorder
        dgvTrips.Location = New Point(66, 204)
        dgvTrips.Name = "dgvTrips"
        dgvTrips.RowHeadersWidth = 62
        dgvTrips.Size = New Size(1283, 340)
        dgvTrips.TabIndex = 5
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(933, 571)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmAdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.truck_logistics_operations_dusk
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1409, 640)
        Controls.Add(btnBack)
        Controls.Add(dgvTrips)
        Controls.Add(Label1)
        Controls.Add(cmbTripActions)
        Controls.Add(pnlReschedule)
        Controls.Add(pnlDeleteTrip)
        Controls.Add(pnlEditTrip)
        Controls.Add(lblWelcome)
        Name = "frmAdminDashboard"
        Text = "AdminDashboard"
        pnlEditTrip.ResumeLayout(False)
        pnlEditTrip.PerformLayout()
        pnlDeleteTrip.ResumeLayout(False)
        pnlReschedule.ResumeLayout(False)
        CType(dgvTrips, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlEditTrip As Panel
    Friend WithEvents cmbTripActions As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlDeleteTrip As Panel
    Friend WithEvents pnlReschedule As Panel
    Friend WithEvents txtEditOrigin As TextBox
    Friend WithEvents txtDriverName As TextBox
    Friend WithEvents txtBusNumber As TextBox
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents btnDeleteTrip As Button
    Friend WithEvents btnRescheduleTrip As Button
    Friend WithEvents dtpNewTripDate As DateTimePicker
    Friend WithEvents dgvTrips As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtEditDestination As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack As Button
End Class
