Imports Microsoft.Data.SqlClient

Public Class frmDriverDashboard
    Private driverUsername As String
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=RoadwiseDB;Integrated Security=True;TrustServerCertificate=True"

    Public Sub New(username As String)
        InitializeComponent()
        driverUsername = username
    End Sub

    Private Sub frmDriverDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & driverUsername
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange(New String() {"Scheduled", "In Progress", "Completed"})
        cmbStatus.SelectedIndex = 0
        LoadMyTrips()
    End Sub

    Private Sub LoadMyTrips()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "
                SELECT TripID, BusNumber, Origin, Destination, TripDate, Status
                FROM Trips
                WHERE DriverName = @DriverName
            "
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@DriverName", driverUsername)
                Dim dt As New DataTable()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
                dgvDriverTrips.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub btnViewBookings_Click(sender As Object, e As EventArgs) Handles btnViewBookings.Click
        If dgvDriverTrips.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a trip.")
            Return
        End If

        Dim tripID As Integer = Convert.ToInt32(dgvDriverTrips.SelectedRows(0).Cells("TripID").Value)

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "
                SELECT CustomerName, DeliveryDate
                FROM Bookings
                WHERE TripID = @TripID
            "
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TripID", tripID)
                Dim dt As New DataTable()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
                dgvTripBookings.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        If dgvDriverTrips.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a trip to update.")
            Return
        End If

        Dim tripID As Integer = Convert.ToInt32(dgvDriverTrips.SelectedRows(0).Cells("TripID").Value)
        Dim newStatus As String = cmbStatus.SelectedItem.ToString()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "
                UPDATE Trips
                SET Status = @Status
                WHERE TripID = @TripID AND DriverName = @DriverName
            "
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Status", newStatus)
                cmd.Parameters.AddWithValue("@TripID", tripID)
                cmd.Parameters.AddWithValue("@DriverName", driverUsername)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Trip status updated successfully!")
        LoadMyTrips()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim login As New Form1()
        login.Show()
        Me.Close()
    End Sub

    Private Sub dgvDriverTrips_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDriverTrips.CellContentClick

    End Sub
End Class
