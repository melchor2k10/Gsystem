Imports Microsoft.Data.SqlClient

Public Class frmAdminDashboard

    Private adminName As String
    Private connectionString As String =
        "Data Source=.\SQLEXPRESS;Initial Catalog=RoadwiseDB;Integrated Security=True;TrustServerCertificate=True"

    ' =========================
    ' CONSTRUCTORS
    ' =========================
    Public Sub New(username As String)
        InitializeComponent()
        adminName = username
        lblWelcome.Text = "Welcome, " & adminName & "!"
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    ' =========================
    ' FORM LOAD
    ' =========================
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbTripActions.Items.Clear()
        cmbTripActions.Items.Add("-- Select Action --")
        cmbTripActions.Items.Add("Edit Trip")
        cmbTripActions.Items.Add("Delete Trip")
        cmbTripActions.Items.Add("Reschedule")
        cmbTripActions.SelectedIndex = 0

        LoadTrips() ' ✅ THIS IS CORRECT
    End Sub

    ' =========================
    ' LOAD TRIPS INTO dgvTrips
    ' =========================
    Private Sub LoadTrips()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String =
                    "SELECT TripID, BusNumber, DriverName, Origin, Destination, TripDate, Status " &
                    "FROM dbo.Trips ORDER BY TripDate"

                Using cmd As New SqlCommand(query, conn)
                    Dim dt As New DataTable()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)

                    dgvTrips.DataSource = dt
                    dgvTrips.ReadOnly = True
                    dgvTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading trips: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' ✅ REQUIRED FUNCTION ✅
    ' =========================
    Private Function GetSelectedTripID() As Integer
        If dgvTrips.SelectedRows.Count = 0 Then
            Throw New Exception("Please select a trip first.")
        End If

        Return Convert.ToInt32(dgvTrips.SelectedRows(0).Cells("TripID").Value)
    End Function

    ' =========================
    ' AUTO-FILL EDIT FIELDS
    ' =========================
    Private Sub dgvTrips_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTrips.SelectionChanged
        If dgvTrips.SelectedRows.Count = 0 Then Exit Sub

        txtBusNumber.Text = dgvTrips.SelectedRows(0).Cells("BusNumber").Value.ToString()
        txtDriverName.Text = dgvTrips.SelectedRows(0).Cells("DriverName").Value.ToString()
        txtEditOrigin.Text = dgvTrips.SelectedRows(0).Cells("Origin").Value.ToString()
        txtEditDestination.Text = dgvTrips.SelectedRows(0).Cells("Destination").Value.ToString()
        cmbStatus.Text = dgvTrips.SelectedRows(0).Cells("Status").Value.ToString()
    End Sub

    ' =========================
    ' EDIT TRIP
    ' =========================
    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        Try
            Dim tripID As Integer = GetSelectedTripID()

            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String =
                    "UPDATE dbo.Trips SET " &
                    "BusNumber = @BusNumber, " &
                    "DriverName = @DriverName, " &
                    "Origin = @Origin, " &
                    "Destination = @Destination, " &
                    "Status = @Status " &
                    "WHERE TripID = @TripID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BusNumber", txtBusNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@DriverName", txtDriverName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Origin", txtEditOrigin.Text.Trim())
                    cmd.Parameters.AddWithValue("@Destination", txtEditDestination.Text.Trim())
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@TripID", tripID)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Trip updated successfully.")
            LoadTrips()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteTrip_Click(sender As Object, e As EventArgs) Handles btnDeleteTrip.Click
        Try
            Dim tripID As Integer = GetSelectedTripID()

            Dim confirm As DialogResult = MessageBox.Show(
                "Are you sure you want to delete this trip?" & vbCrLf &
                "This will also delete related bookings.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If confirm = DialogResult.No Then Exit Sub

            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String =
                    "DELETE FROM dbo.Trips WHERE TripID = @TripID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TripID", tripID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Trip deleted successfully.")
            LoadTrips()

        Catch ex As Exception
            MessageBox.Show("Error deleting trip: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRescheduleTrip_Click(sender As Object, e As EventArgs) Handles btnRescheduleTrip.Click
        Try
            Dim tripID As Integer = GetSelectedTripID()

            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String =
                    "UPDATE dbo.Trips " &
                    "SET TripDate = @TripDate " &
                    "WHERE TripID = @TripID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TripDate", dtpNewTripDate.Value)
                    cmd.Parameters.AddWithValue("@TripID", tripID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Trip rescheduled successfully.")
            LoadTrips()

        Catch ex As Exception
            MessageBox.Show("Error rescheduling trip: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbTripActions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTripActions.SelectedIndexChanged
        pnlEditTrip.Visible = False
        pnlDeleteTrip.Visible = False
        pnlReschedule.Visible = False

        Select Case cmbTripActions.Text
            Case "Edit Trip"
                pnlEditTrip.Visible = True
            Case "Delete Trip"
                pnlDeleteTrip.Visible = True
            Case "Reschedule"
                pnlReschedule.Visible = True
        End Select
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim login As New Form1()
        login.Show()
        Me.Close()
    End Sub
End Class
