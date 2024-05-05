
Imports System.Data.SqlClient

Public Class Employee
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles empphntb.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()

    End Sub
    Private Sub Populate()
        con.Open()
        Dim sql = "select * from EmployeeTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        employeegrid.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim query As String
        query = "insert into EmployeeTable values('" & empidtb.Text & "','" & Empnametb.Text & "','" & empaddresstb.Text & "','" & empposcb.SelectedItem.ToString() & "','" & empdob.Value & "', '" & empphntb.Text & "','" & empqualicb.SelectedItem.ToString() & "','" & empgendercb.SelectedItem.ToString() & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()



        MsgBox("Employee Added")
        con.Close()
        Populate()


    End Sub

    Private Sub empaddresstb_TextChanged(sender As Object, e As EventArgs) Handles empaddresstb.TextChanged

    End Sub
End Class