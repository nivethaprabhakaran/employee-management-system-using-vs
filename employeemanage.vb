Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class employeemanage
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

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
        query = "insert into EmployeeTable values('" & EmpIdtb.Text & "','" & Empnametb.Text & "','" & empaddresstb.Text & "','" & empposcb.SelectedItem.ToString() & "', '" & empphntb.Text & "','" & empqualicb.SelectedItem.ToString() & "','" & empgendercb.SelectedItem.ToString() & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()



        MsgBox("Employee Added")
        con.Close()
        Populate()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub employeegrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeegrid.CellContentClick
        Populate()

    End Sub

    Private Sub empphntb_TextChanged(sender As Object, e As EventArgs) Handles empphntb.TextChanged

    End Sub

    Private ReadOnly frmMain As Object
    Dim key = 0
    Private Sub Clear()
        Empnametb.Clear()
        empposcb.Text = ""
        empgendercb.Text = ""
        empaddresstb.Text = ""
        key = 0
        empqualicb.Text = ""
        empphntb.Text = ""




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select the employee to delete ")
        Else
            Try
                con.Open()
                Dim query As String
                query = "Delete from EmployeeTable where Empid=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("EMPLOYEE DELETED SUCCESSFULLY")
                con.Close()
                Populate()
                Clear()



            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If


    End Sub

    Private Sub employeegrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles employeegrid.CellMouseClick
        Dim row As DataGridViewRow = employeegrid.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())

        Empnametb.Text = row.Cells(1).Value.ToString()
        empaddresstb.Text = row.Cells(2).Value.ToString()
        empposcb.Text = row.Cells(3).Value.ToString()
        empphntb.Text = row.Cells(4).Value.ToString()
        empqualicb.Text = row.Cells(5).Value.ToString()
        empgendercb.Text = row.Cells(6).Value.ToString()




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Empnametb.Text = "" Or empphntb.Text = "" Or empaddresstb.Text = "" Then
            MsgBox("MISSING INFORMATION")
        Else
            con.Open()
            Dim query As String
            query = "Update EmployeeTable set EmpName='" & Empnametb.Text & "',EmpAdd='" & empaddresstb.Text & "',EmpPos='" & empposcb.SelectedItem.ToString() & "',EmpPhone='" & empphntb.Text & "',EmpEdu='" & empqualicb.SelectedItem.ToString() & "',EmpGend='" & empgendercb.SelectedItem.ToString() & "' where Empid=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("EMPLOYEE UPDATED")
            con.Close()
            Populate()


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim main = New mainform
        main.Show()



    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Application.Exit()

    End Sub
End Class
