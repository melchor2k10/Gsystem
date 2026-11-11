Imports Microsoft.data.SqlClient
Public Class frmAdminLogin

    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=RoadwiseDB;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Size = New Size(800, 600)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            lblMessage.Text = "Please enter username and password!"
            lblMessage.ForeColor = Color.Red
            Exit Sub
        End If

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT Password FROM Users WHERE Username=@user AND Role='Admin'"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    If password = result.ToString() Then
                        Dim dashboard As New frmAdminDashboard(username)
                        dashboard.Show()
                        Me.Hide()
                    Else
                        lblMessage.Text = "Incorrect password!"
                        lblMessage.ForeColor = Color.Red
                    End If
                Else
                    lblMessage.Text = "Admin username not found!"
                    lblMessage.ForeColor = Color.Red
                End If
            End Using
        End Using
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
