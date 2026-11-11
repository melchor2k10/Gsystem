Imports Microsoft.Data.SqlClient

Public Class frmCustomerDashboard

    Private customerName As String
    Private connectionString As String =
        "Data Source=.\SQLEXPRESS;Initial Catalog=RoadwiseDB;Integrated Security=True;TrustServerCertificate=True"

    Public Sub New(username As String)
        InitializeComponent()
        customerName = username
        lblWelcome.Text = "Welcome, " & customerName & "!"
    End Sub

    ' ========================
    ' BOOK TRIP
    ' ========================
    Private Sub btnBookTrip_Click(sender As Object, e As EventArgs) Handles btnBookTrip.Click
        Dim origin As String = txtOriginForBooking.Text.Trim()
        Dim destination As String = txtDestinationForBooking.Text.Trim()

        If origin = "" OrElse destination = "" Then
            MessageBox.Show("Please enter both Origin and Destination.")
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' CREATE TRIP (PENDING)
                Dim insertTripQuery As String =
                    "INSERT INTO Trips (BusNumber, DriverName, Origin, Destination, TripDate, Status) " &
                    "OUTPUT INSERTED.TripID " &
                    "VALUES ('Pending','Pending',@Origin,@Destination,GETDATE(),'Scheduled')"

                Dim tripID As Integer

                Using cmd As New SqlCommand(insertTripQuery, conn)
                    cmd.Parameters.AddWithValue("@Origin", origin)
                    cmd.Parameters.AddWithValue("@Destination", destination)
                    tripID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' CREATE BOOKING
                Dim insertBookingQuery As String =
                    "INSERT INTO Bookings (CustomerName, TripID, DeliveryDate) " &
                    "VALUES (@CustomerName,@TripID,@DeliveryDate)"

                Using cmd As New SqlCommand(insertBookingQuery, conn)
                    cmd.Parameters.AddWithValue("@CustomerName", customerName)
                    cmd.Parameters.AddWithValue("@TripID", tripID)
                    cmd.Parameters.AddWithValue("@DeliveryDate", dtpDeliveryDate.Value.Date)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Booking created successfully!")
            LoadMyDeliveries()

        Catch ex As Exception
            MessageBox.Show("Error creating booking: " & ex.Message)
        End Try
    End Sub

    ' ========================
    ' LOAD DELIVERY STATUS ✅
    ' ========================
    Private Sub LoadMyDeliveries()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String =
                    "SELECT b.BookingID, t.Origin, t.Destination, " &
                    "t.TripDate, b.DeliveryDate, t.Status " &
                    "FROM Bookings b " &
                    "JOIN Trips t ON b.TripID = t.TripID " &
                    "WHERE b.CustomerName = @CustomerName " &
                    "ORDER BY t.TripDate DESC"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerName", customerName)

                    Dim dt As New DataTable()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)

                    dgvMyBookings.DataSource = dt
                    dgvMyBookings.ReadOnly = True
                    dgvMyBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading delivery status: " & ex.Message)
        End Try
    End Sub

    ' ========================
    ' CANCEL BOOKING
    ' ========================
    Private Sub btnCancelBooking_Click(sender As Object, e As EventArgs) Handles btnCancelBooking.Click
        If dgvMyBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to cancel.")
            Exit Sub
        End If

        Dim bookingID As Integer =
            Convert.ToInt32(dgvMyBookings.SelectedRows(0).Cells("BookingID").Value)

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String =
                    "DELETE FROM Bookings WHERE BookingID = @BookingID AND CustomerName = @CustomerName"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BookingID", bookingID)
                    cmd.Parameters.AddWithValue("@CustomerName", customerName)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Booking canceled successfully!")
            LoadMyDeliveries()

        Catch ex As Exception
            MessageBox.Show("Error canceling booking: " & ex.Message)
        End Try
    End Sub

    ' ========================
    ' FORM LOAD
    ' ========================
    Private Sub frmCustomerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMyDeliveries()
    End Sub

    Private Sub btnSearchTrips_Click(sender As Object, e As EventArgs) Handles btnSearchTrips.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String =
                "SELECT TripID, Origin, Destination, TripDate, Status " &
                "FROM Trips " &
                "WHERE Origin LIKE '%' + @Origin + '%' " &
                "AND Destination LIKE '%' + @Destination + '%' " &
                "ORDER BY TripDate DESC"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Origin", txtOrigin.Text.Trim())
                    cmd.Parameters.AddWithValue("@Destination", txtDestination.Text.Trim())

                    Dim dt As New DataTable()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)

                    dgvSearchResults.DataSource = dt
                    dgvSearchResults.ReadOnly = True
                    dgvSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching trips: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim login As New Form1()
        login.Show()
        Me.Close()
    End Sub
End Class
