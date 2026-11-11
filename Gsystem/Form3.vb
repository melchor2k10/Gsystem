Imports Microsoft.Data.SqlClient

Public Class frmDriverLogin
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=RoadwiseDB;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter both Username and Password.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT FullName FROM Drivers WHERE Username = @Username AND Password = @Password"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)
                    Dim fullName As Object = cmd.ExecuteScalar()

                    If fullName IsNot Nothing Then
                        ' Login successful, open Driver Dashboard
                        Dim dashboard As New frmDriverDashboard(username)
                        dashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub frmDriverLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
