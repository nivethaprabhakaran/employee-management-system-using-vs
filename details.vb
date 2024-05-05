Imports System.Data.SqlClient

Public Class details
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub FetchEmployeeData()
        If EmpIdtb.Text = "" Then
            MsgBox("Enter the employee id")
        Else
            con.Open()
            Dim query = "select * from EmployeeTable where Empid=" & EmpIdtb.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                EmpNamelbl.Text = dr(1).ToString()
                EmpAddlbl.Text = dr(2).ToString()
                EmpPoslbl.Text = dr(3).ToString()

                EmpPhnlbl.Text = dr(4).ToString()
                EmpQualilbl.Text = dr(5).ToString()
                EmpGenderlbl.Text = dr(6).ToString()
                EmpNamelbl.Visible = True
                EmpAddlbl.Visible = True
                EmpPoslbl.Visible = True

                EmpPhnlbl.Visible = True
                EmpQualilbl.Visible = True
                EmpGenderlbl.Visible = True


            Next

            con.Close()
        End If


    End Sub
    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FetchEmployeeData()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim main = New mainform
        main.Show()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
