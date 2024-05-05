Imports System.Data.SqlClient

Public Class salary
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
                EmpPoslbl.Text = dr(3).ToString()
                EmpNamelbl.Visible = True
                EmpPoslbl.Visible = True


            Next

            con.Close()
        End If


    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles empidtb.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles EmpPoslbl.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles workedtb.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim main = New mainform
        main.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FetchEmployeeData()

    End Sub
    Dim dailypay
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmpPoslbl.Text = "" Then
            MsgBox("select an employee")
        ElseIf workedtb.Text = "" Or Convert.ToInt32(workedtb.Text) > 28 Then
            MsgBox("Enter a valid number of days")
        Else
            If EmpPoslbl.Text = "Manager" Then
                dailypay = 1200
            ElseIf EmpPoslbl.Text = "Accountant" Then
                dailypay = 1200
            ElseIf EmpPoslbl.Text = "Security" Then
                dailypay = 500
            ElseIf EmpPoslbl.Text = "IT" Then
                dailypay = 850
            Else
                dailypay = 500
            End If
            Dim total = dailypay * Convert.ToInt32(workedtb.Text)
            salarytb.Text = "EMPLOYEE ID:    " + empidtb.Text + vbCrLf + "EMPLOYEE NAME:      " + EmpNamelbl.Text + vbCrLf + "EMPLOYEE POSITION:     " + EmpPoslbl.Text + vbCrLf + "DAYS WORKED   " + workedtb.Text + vbCrLf + "DAILY SALARY Rs:     " + Convert.ToString(dailypay) + vbCrLf + "TOTAL AMOUNT Rs:      " + Convert.ToString(total)

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("EMPLOYEE MANAGEMENT SYSTEM", New Font("Century Gothic", 25), Brushes.Black, 180, 40)
        e.Graphics.DrawString("***PAYSLIP***", New Font("Aerial", 20), Brushes.Crimson, 330, 100)
        e.Graphics.DrawString(salarytb.Text, New Font("Century Gothic", 20), Brushes.Black, 150, 190)
        e.Graphics.DrawString("~~~~~~~~~~~~THANKS FOR YOUR SERVICE~~~~~~~~~~~~~~", New Font("Century Gothic", 15), Brushes.Crimson, 150, 500)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class