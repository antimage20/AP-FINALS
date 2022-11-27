Imports System.Data.DataTable
Public Class frmPatientsrecords

    Private Sub frmPatientsrecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim table As New DataTable("table")

        table.Columns.Add("First Name", Type.GetType("System.Int32"))
        table.Columns.Add("Middle Name", Type.GetType("System.Int32"))
        table.Columns.Add("Last Name", Type.GetType("System.Int32"))
        table.Columns.Add("Occupation", Type.GetType("System.Int32"))
        table.Columns.Add("Date of birth", Type.GetType("System.Int32"))
        table.Columns.Add("Address", Type.GetType("System.Int32"))
        table.Columns.Add("Mobile phone", Type.GetType("System.Int32"))
        table.Columns.Add("Email", Type.GetType("System.Int32"))

        DataGridView1.DataSource = table
        DataGridView1.AllowUserToAddRows = False

    End Sub

End Class