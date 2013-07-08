Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form3
    Dim MysqlConnection = New MySqlConnection

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            Dim username As String = TextBox1.Text
            Dim pwd As String = TextBox2.Text

            Dim ConStr As String = "Database=tictactoe;" & _
               "Data Source=db4free.net;" & _
               "User Id=morpig;Password=Dito2002"
            Dim connection As New MySqlConnection(ConStr)
            connection.Open()
            connection.Close()

            Label1.Text = "Online, No Problems detected."

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim SQLstr As String

        cn.ConnectionString = "Server = db4free.net; user id = morpig; password = Dito2002; database = tictactoe"
        cmd.Connection = cn
        cn.Open()
        SQLstr = "SELECT * from user WHERE username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "';"
        MsgBox(SQLstr)
        cmd.CommandText = SQLstr
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            Form2.Show()
        Else
            MsgBox("ERROR!")
        End If
    End Sub
    Private Sub testconnection()
        Try

            Dim username As String = TextBox1.Text
            Dim pwd As String = TextBox2.Text

            Dim ConStr As String = "Database=tictactoe;" & _
               "Data Source=db4free.net;" & _
               "User Id=morpig;Password=Dito2002"
            Dim connection As New MySqlConnection(ConStr)
            connection.Open()
            connection.Close()

            Label1.Text = "Online, No Problems detected."

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
End Class