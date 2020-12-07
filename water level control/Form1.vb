Public Class Form1
    Private Sub use_Click(sender As Object, e As EventArgs) Handles use.Click
        use_timer.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub use_timer_Tick(sender As Object, e As EventArgs) Handles use_timer.Tick
        stop_timer.Stop()
        If ttank.Location.Y = 160 Then
            bot1.BackColor = Color.White
            bot2.BackColor = Color.White
            use_timer.Stop()
        ElseIf ttank.Location.Y >= 93 Then
            ttank.Location = New Point(ttank.Location.X, ttank.Location.Y - 2)
            ttank.Height = ttank.Height + 2
            ctrl.Text = "On"
            ctrl.BackColor = Color.Green
            top2.BackColor = Color.Blue
            top3.BackColor = Color.Blue

        Else
            ttank.Location = New Point(ttank.Location.X, ttank.Location.Y + 1)
            ttank.Height = ttank.Height - 1

            bot1.BackColor = Color.Blue
            bot2.BackColor = Color.Blue
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        use_timer.Stop()
        stop_timer.Start()
    End Sub

    Private Sub stop_timer_Tick(sender As Object, e As EventArgs) Handles stop_timer.Tick

        If ctrl.Text = "Off" Then
            bot1.BackColor = Color.White
            bot2.BackColor = Color.White
            top2.BackColor = Color.White
            top3.BackColor = Color.White
        End If
        If ctrl.Text = "On" Then
            ttank.Location = New Point(ttank.Location.X, ttank.Location.Y - 1)
            ttank.Height = ttank.Height + 1
            bot1.BackColor = Color.White
            bot2.BackColor = Color.White
            If ttank.Location.Y < 26 Then
                ctrl.Text = "Off"
                ctrl.BackColor = Color.Red
                ttank.Location = New Point(ttank.Location.X, 26)

                top2.BackColor = Color.White
                top3.BackColor = Color.White
                stop_timer.Stop()
            End If
        End If
    End Sub

    Private Sub ctrl_Click(sender As Object, e As EventArgs) Handles ctrl.Click

    End Sub

    Private Sub btank_TextChanged(sender As Object, e As EventArgs) Handles btank.TextChanged

    End Sub
End Class