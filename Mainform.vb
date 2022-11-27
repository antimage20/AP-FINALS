Public Class frmMainform
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnHome.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        frmRegistrationForm.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Me.Hide()
        frmLogin.Show()

    End Sub
End Class