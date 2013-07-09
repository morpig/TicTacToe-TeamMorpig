Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form3
    Dim MysqlConnection = New MySqlConnection

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Checking update and establish connection with Database. Please Wait")
        Try
            MsgBox("Checking update and establish connection with Database. Please Wait")
            Dim username As String = TextBox1.Text
            Dim pwd As String = TextBox2.Text

            Dim ConStr As String = "Server = 199.19.118.174; user id = morpig; password = Dito2002; database = tictactoe"
            Dim connection As New MySqlConnection(ConStr)
            connection.Open()
            connection.Close()
            MsgBox("Checking update and establish connection with Database. Please Wait")
            Label1.Text = "Online, No Problems detected."
            MsgBox(ConStr)

        Catch ex As Exception
            Label1.Text = "Offline, please try again later."

        End Try


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim SQLstr As String

        TextBox1.Visible = False
        TextBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Label2.Text = "Logging In, Please wait"

        cn.ConnectionString = "Server = 199.19.118.174; user id = morpig; password = Dito2002; database = tictactoe"
        cmd.Connection = cn
        cn.Open()
        SQLstr = "SELECT * from user WHERE username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "';"
        'MsgBox(SQLstr)
        cmd.CommandText = SQLstr
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            SplashScreen1.Show()
            Me.hide

        Else

            Label2.Text = "Login Failed, please try again."
            Application.DoEvents()
            System.Threading.Thread.Sleep(2500)
            TextBox1.Visible = True
            TextBox2.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Label2.Text = ""
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

    Private Sub Form3_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MsgBox("Checking update and establish connection with Database. Please Wait")
            'Dim username As String = TextBox1.Text
            'Dim pwd As String = TextBox2.Text

            'Dim ConStr As String = "Server = 199.19.118.174; user id = morpig; password = Dito2002; database = tictactoe"
            Me.Show()
            'Dim connection As New MySqlConnection(ConStr)
            'connection.Open()
            'connection.Close()
            'Me.Show()
            Label1.Text = "Online, No Problems detected."
            'MsgBox(ConStr)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub
End Class