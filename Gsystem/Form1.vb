Public Class Form1
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim loginForm As New frmAdminLogin()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDriver_Click(sender As Object, e As EventArgs) Handles btnDriver.Click
        Dim loginForm As New frmDriverLogin()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim loginForm As New frmCustomerLogin()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
