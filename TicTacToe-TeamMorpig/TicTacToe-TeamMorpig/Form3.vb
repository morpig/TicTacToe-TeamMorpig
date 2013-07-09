Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form3
    Dim MysqlConnection = New MySqlConnection

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        If e.KeyCode = Keys.Enter Then
            Label2.Text = "Logging In, Please wait"
            Dim cn As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim dr As MySqlDataReader
            Dim SQLstr As String

            TextBox1.Visible = False
            TextBox2.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            'ProgressBar1.Show()

            Label1.Text = ""

            cn.ConnectionString = "Server = 199.19.119.43; user id = morpig; password = Dito2002; database = tictactoe"
            cmd.Connection = cn
            cn.Open()
            SQLstr = "SELECT * from user WHERE username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "';"
            'MsgBox(SQLstr)
            cmd.CommandText = SQLstr
            dr = cmd.ExecuteReader
            cn.Close()

            If dr.HasRows Then
                cn.Open()
                SQLstr = "UPDATE user SET onlinestatus=1 WHERE username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "';"
                'MsgBox(SQLstr)
                'MsgBox(SQLstr)
                cmd.CommandText = SQLstr
                dr = cmd.ExecuteReader
                SplashScreen1.Show()
                Me.Hide()
                cn.Close()

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
        End If
        If e.KeyCode = Keys.W Then
            MsgBox("CHEAT ACTIVATED!")
            SplashScreen1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim SQLstr As String

        TextBox1.Visible = False
        TextBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        'ProgressBar1.Show()
        Label2.Text = "Logging In, Please wait"
        Label1.Text = ""

        cn.ConnectionString = "Server = 199.19.119.43; user id = morpig; password = Dito2002; database = tictactoe"
        cmd.Connection = cn
        cn.Open()
        SQLstr = "SELECT * from user WHERE username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "';"
        'MsgBox(SQLstr)
        'ProgressBar1.Value = SQLstr
        cmd.CommandText = SQLstr
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            SplashScreen1.Show()
            Me.Hide()

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

    Private Sub Form3_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Hide()
    End Sub

End Class
