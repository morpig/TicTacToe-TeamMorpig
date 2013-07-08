Public Class Form1
    Private isX As Boolean = False
    Private MChar As String = "O"
    Private Player As String
    Private NoOfWin1 As Integer = 0
    Private NoOfWin2 As Integer = 0
    Private Draw As Integer = 0
    Private Histroy As Boolean = False
    Private Sub WriteText()
        If isX = True Then
            MChar = "X"
            isX = False
            CheckTrun()
            Button11.Enabled = False
        Else
            MChar = "O"
            isX = True
            CheckTrun()
            Button11.Enabled = False
        End If
    End Sub
    Private Sub Buttonclick(ByVal Btn As Button)
        WriteText()
        Btn.Text = MChar
        Btn.Enabled = False
        CheckWin()
        CheckDraw()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Buttonclick(Button3)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Buttonclick(Button6)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Buttonclick(Button9)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Buttonclick(Button8)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Buttonclick(Button7)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Buttonclick(Button4)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Buttonclick(Button5)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Buttonclick(Button2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Buttonclick(Button1)
    End Sub
    Private Sub CheckWin()
        ThreeRowChecker(Button1, Button2, Button3)
        ThreeRowChecker(Button4, Button5, Button6)
        ThreeRowChecker(Button7, Button8, Button9)
        ThreeRowChecker(Button1, Button5, Button9)
        ThreeRowChecker(Button1, Button4, Button7)
        ThreeRowChecker(Button2, Button5, Button8)
        ThreeRowChecker(Button3, Button6, Button9)
        ThreeRowChecker(Button1, Button4, Button7)
        ThreeRowChecker(Button3, Button5, Button7)
    End Sub
    Private Sub ThreeRowChecker(ByVal b1 As Button, ByVal b2 As Button, ByVal b3 As Button)
        If b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
            MessageBox.Show("Player 1 Won This Game", "Congratz")
            NoOfWin1 += 1
            Restart()
            UptadeHistroy()
            Button11.Enabled = True
            isX = False
        ElseIf b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
            MessageBox.Show("Player 2 Won This Game", "Congratz")
            NoOfWin2 += 1
            Restart()
            UptadeHistroy()
            isX = False
            Button11.Enabled = True
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Restart()
        Button11.Enabled = True
    End Sub
    Private Sub Restart()
        Button1.Text = Nothing
        Button2.Text = Nothing
        Button3.Text = Nothing
        Button4.Text = Nothing
        Button5.Text = Nothing
        Button6.Text = Nothing
        Button7.Text = Nothing
        Button8.Text = Nothing
        Button9.Text = Nothing
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckTrun()
        Me.Width = 319
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub
    Private Sub CheckTrun()
        If MChar = "X" Then
            Player = "Player 1"
        Else
            Player = "Player 2"
        End If
        Label1.Text = "This Turn Belong To " & Player
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        isX = True
        Button11.Enabled = False
    End Sub

    Private Sub HistroyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistroyToolStripMenuItem.Click
        If Me.Width = 319 Then
            Me.Width = 614
            HistroyToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        Else
            Me.Width = 319
            HistroyToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        NoOfWin1 = 0
        NoOfWin2 = 0
        Draw = 0
        Label2.Text = "No Of Player 1 Won = " & NoOfWin1
        Label3.Text = "No Of Player 2 Won = " & NoOfWin2
        Label4.Text = "No Of Draw = " & Draw
    End Sub
    Private Sub UptadeHistroy()
        Label2.Text = "No Of Player 1 Won = " & NoOfWin1
        Label3.Text = "No Of Player 2 Won = " & NoOfWin2
        Label4.Text = "No Of Draw = " & Draw
    End Sub
    Private Sub CheckDraw()
        If Button1.Text <> Nothing And Button2.Text <> Nothing And Button3.Text <> Nothing And Button4.Text <> Nothing And Button5.Text <> Nothing And Button6.Text <> Nothing And Button7.Text <> Nothing And Button8.Text <> Nothing And Button9.Text <> Nothing Then
            Draw += 1
            UptadeHistroy()
            MessageBox.Show("This Game Ended As Draw", "Draw")
            Restart()
            Button11.Enabled = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Do You Want To Quit", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
