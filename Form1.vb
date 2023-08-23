Imports System.Data.SqlClient
Imports System.Data
Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection(" Data Source=CHETANPC1998\SQLEXPRESS;Initial Catalog=adolearnkarlo;Integrated Security=True ")
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        da = New SqlDataAdapter
        dt = New DataTable
        cmd = New SqlCommand("Select * from signUppage where name ='" & TextUser.Text & "' and password ='" & TextPassword.Text & "'", con)
        con.Open()
        da.SelectCommand = cmd
        da.Fill(dt)


        If dt.Rows.Count <= 0 Then

            MsgBox("Wrong USERNAME AND PASSWORD")
            TextUser.Clear()
            TextPassword.Clear()
            TextUser.Focus()

        Else
            MsgBox("LOGIN SUCCESSFUL...")
            Form2.Show()
        End If
        con.Close()
    End Sub

    Private Sub ButtonSignup_Click(sender As Object, e As EventArgs) Handles ButtonSignup.Click
        Form3.Show()
        Hide()

    End Sub
End Class
