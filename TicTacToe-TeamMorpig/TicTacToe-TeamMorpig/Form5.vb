Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form5
    Dim MysqlConnection = New MySqlConnection

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'server1
        Control.CheckForIllegalCrossThreadCalls = False
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label1.Hide()
        ProgressBar1.Hide()
        Button2.Show()
        'BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Button2.Hide()
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i = 0 To 100
            Dim cn As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim dr As MySqlDataReader
            Dim SQLstr As String
            cn.ConnectionString = "Server = 199.19.119.43; user id = morpig; password = Dito2002; database = tictactoe"
            cmd.Connection = cn
            cn.Open()
            SQLstr = "SELECT * from server1 WHERE online=1;"
            cmd.CommandText = SQLstr
            dr = cmd.ExecuteReader
            cn.Close()

            If dr.HasRows Then
                Label2.Show()
                Label3.Show()
                Label4.Text = "Max Players: 5"
                Label4.Show()
            Else
                Label1.Text = "Server 1 is off, still fetching other data."

                Application.DoEvents()
                System.Threading.Thread.Sleep(2500)

            End If

        Next



        
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Label1.Text = ("COMPLETED")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Show()
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class