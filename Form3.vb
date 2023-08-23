Imports System.Data.SqlClient

Public Class Form3

    Dim con As New SqlConnection("Data Source=CHETANPC1998\SQLEXPRESS;Initial Catalog=adolearnkarlo;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("insert into signUpPage values('" & TextBox1.Text & "', " & TextBox2.Text & " , " & TextBox3.Text & "," & TextBox4.Text & ")", con)
        con.Open()
        MsgBox("Data was inserted ")
        con.Close()

        Form1.Show()
        Hide()
    End Sub

End Class