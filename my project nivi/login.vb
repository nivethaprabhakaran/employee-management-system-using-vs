Public Class login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Uid.Clear()
        Pwd.Clear()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userid As String

        Dim password As String

        userid = Uid.Text
        password = Pwd.Text
        If Uid.Text = "" Or Pwd.Text = "" Then
            MsgBox("Enter admin name and password")


        ElseIf (userid.Equals("nivi") And password.Equals("nivi")) Then
            Dim main = New mainform
            main.Show()
            Me.Hide()

        Else
            MsgBox("Wrong Admin name and Password")

        End If






    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class