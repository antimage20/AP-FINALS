Imports System.Data.SqlClient

Public Class frmRegistrationForm

    Dim con As SqlConnection = (12)
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()
        frmMainform.Show()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPrefix.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtLastname.Text = ""
        txtOccupation.Text = ""
        txtDateofbirth.Text = ""
        txtAddress.Text = ""
        txtMobilephone.Text = ""
        txtEmail.Text = ""

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        frmPatientsrecords.Show()
        frmPatientsrecords.DataGridView1.Rows.Add(txtPrefix.Text, txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, txtOccupation.Text, txtDateofbirth.Text, txtAddress.Text, txtMobilephone.Text, txtEmail.Text)
        Me.Hide()

    End Sub
End Class