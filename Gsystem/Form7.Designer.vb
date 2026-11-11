<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDashboard
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
        pnlBookTrip = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        txtDestinationForBooking = New MaskedTextBox()
        txtOriginForBooking = New MaskedTextBox()
        Label1 = New Label()
        dtpDeliveryDate = New DateTimePicker()
        btnBookTrip = New Button()
        pnlViewBookings = New Panel()
        btnCancelBooking = New Button()
        dgvMyBookings = New DataGridView()
        pnlSearchTrips = New Panel()
        dgvSearchResults = New DataGridView()
        btnSearchTrips = New Button()
        dtpSearchDate = New DateTimePicker()
        txtDestination = New TextBox()
        txtOrigin = New TextBox()
        btnBack = New Button()
        pnlBookTrip.SuspendLayout()
        pnlViewBookings.SuspendLayout()
        CType(dgvMyBookings, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchTrips.SuspendLayout()
        CType(dgvSearchResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(293, 9)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 25)
        lblWelcome.TabIndex = 0
        ' 
        ' pnlBookTrip
        ' 
        pnlBookTrip.BackColor = Color.Transparent
        pnlBookTrip.Controls.Add(Label3)
        pnlBookTrip.Controls.Add(Label2)
        pnlBookTrip.Controls.Add(txtDestinationForBooking)
        pnlBookTrip.Controls.Add(txtOriginForBooking)
        pnlBookTrip.Controls.Add(Label1)
        pnlBookTrip.Controls.Add(dtpDeliveryDate)
        pnlBookTrip.Controls.Add(btnBookTrip)
        pnlBookTrip.Location = New Point(30, 43)
        pnlBookTrip.Name = "pnlBookTrip"
        pnlBookTrip.Size = New Size(739, 208)
        pnlBookTrip.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 25)
        Label3.TabIndex = 7
        Label3.Text = "Destination:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 25)
        Label2.TabIndex = 6
        Label2.Text = "Place of origin:"
        ' 
        ' txtDestinationForBooking
        ' 
        txtDestinationForBooking.Location = New Point(155, 112)
        txtDestinationForBooking.Name = "txtDestinationForBooking"
        txtDestinationForBooking.Size = New Size(150, 31)
        txtDestinationForBooking.TabIndex = 5
        ' 
        ' txtOriginForBooking
        ' 
        txtOriginForBooking.Location = New Point(155, 62)
        txtOriginForBooking.Name = "txtOriginForBooking"
        txtOriginForBooking.Size = New Size(150, 31)
        txtOriginForBooking.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(455, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 25)
        Label1.TabIndex = 3
        Label1.Text = "Delivery Date"
        ' 
        ' dtpDeliveryDate
        ' 
        dtpDeliveryDate.Location = New Point(357, 97)
        dtpDeliveryDate.Name = "dtpDeliveryDate"
        dtpDeliveryDate.Size = New Size(300, 31)
        dtpDeliveryDate.TabIndex = 2
        ' 
        ' btnBookTrip
        ' 
        btnBookTrip.Location = New Point(444, 148)
        btnBookTrip.Name = "btnBookTrip"
        btnBookTrip.Size = New Size(112, 34)
        btnBookTrip.TabIndex = 1
        btnBookTrip.Text = "Book Trip"
        btnBookTrip.UseVisualStyleBackColor = True
        ' 
        ' pnlViewBookings
        ' 
        pnlViewBookings.BackColor = Color.Transparent
        pnlViewBookings.Controls.Add(btnCancelBooking)
        pnlViewBookings.Controls.Add(dgvMyBookings)
        pnlViewBookings.Location = New Point(30, 297)
        pnlViewBookings.Name = "pnlViewBookings"
        pnlViewBookings.Size = New Size(719, 277)
        pnlViewBookings.TabIndex = 3
        ' 
        ' btnCancelBooking
        ' 
        btnCancelBooking.Location = New Point(217, 208)
        btnCancelBooking.Name = "btnCancelBooking"
        btnCancelBooking.Size = New Size(197, 34)
        btnCancelBooking.TabIndex = 1
        btnCancelBooking.Text = "Cancel Booking"
        btnCancelBooking.UseVisualStyleBackColor = True
        ' 
        ' dgvMyBookings
        ' 
        dgvMyBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMyBookings.Location = New Point(3, 23)
        dgvMyBookings.Name = "dgvMyBookings"
        dgvMyBookings.RowHeadersWidth = 62
        dgvMyBookings.Size = New Size(706, 164)
        dgvMyBookings.TabIndex = 0
        ' 
        ' pnlSearchTrips
        ' 
        pnlSearchTrips.BackColor = Color.Transparent
        pnlSearchTrips.Controls.Add(dgvSearchResults)
        pnlSearchTrips.Controls.Add(btnSearchTrips)
        pnlSearchTrips.Controls.Add(dtpSearchDate)
        pnlSearchTrips.Controls.Add(txtDestination)
        pnlSearchTrips.Controls.Add(txtOrigin)
        pnlSearchTrips.Location = New Point(775, 43)
        pnlSearchTrips.Name = "pnlSearchTrips"
        pnlSearchTrips.Size = New Size(679, 352)
        pnlSearchTrips.TabIndex = 4
        ' 
        ' dgvSearchResults
        ' 
        dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSearchResults.Location = New Point(0, 148)
        dgvSearchResults.Name = "dgvSearchResults"
        dgvSearchResults.RowHeadersWidth = 62
        dgvSearchResults.Size = New Size(673, 200)
        dgvSearchResults.TabIndex = 4
        ' 
        ' btnSearchTrips
        ' 
        btnSearchTrips.Location = New Point(289, 88)
        btnSearchTrips.Name = "btnSearchTrips"
        btnSearchTrips.Size = New Size(112, 45)
        btnSearchTrips.TabIndex = 3
        btnSearchTrips.Text = "Search Trip"
        btnSearchTrips.UseVisualStyleBackColor = True
        ' 
        ' dtpSearchDate
        ' 
        dtpSearchDate.Location = New Point(353, 26)
        dtpSearchDate.Name = "dtpSearchDate"
        dtpSearchDate.Size = New Size(300, 31)
        dtpSearchDate.TabIndex = 2
        ' 
        ' txtDestination
        ' 
        txtDestination.Location = New Point(197, 26)
        txtDestination.Name = "txtDestination"
        txtDestination.Size = New Size(150, 31)
        txtDestination.TabIndex = 1
        ' 
        ' txtOrigin
        ' 
        txtOrigin.Location = New Point(24, 26)
        txtOrigin.Name = "txtOrigin"
        txtOrigin.Size = New Size(150, 31)
        txtOrigin.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(1048, 489)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 5
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmCustomerDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1466, 594)
        Controls.Add(btnBack)
        Controls.Add(pnlSearchTrips)
        Controls.Add(pnlViewBookings)
        Controls.Add(pnlBookTrip)
        Controls.Add(lblWelcome)
        Name = "frmCustomerDashboard"
        Text = "CustomerDashboard"
        pnlBookTrip.ResumeLayout(False)
        pnlBookTrip.PerformLayout()
        pnlViewBookings.ResumeLayout(False)
        CType(dgvMyBookings, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchTrips.ResumeLayout(False)
        pnlSearchTrips.PerformLayout()
        CType(dgvSearchResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlBookTrip As Panel
    Friend WithEvents pnlViewBookings As Panel
    Friend WithEvents pnlSearchTrips As Panel
    Friend WithEvents btnBookTrip As Button
    Friend WithEvents btnCancelBooking As Button
    Friend WithEvents dgvMyBookings As DataGridView
    Friend WithEvents btnSearchTrips As Button
    Friend WithEvents dtpSearchDate As DateTimePicker
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents txtOrigin As TextBox
    Friend WithEvents dgvSearchResults As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDeliveryDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDestinationForBooking As MaskedTextBox
    Friend WithEvents txtOriginForBooking As MaskedTextBox
    Friend WithEvents btnBack As Button
End Class
