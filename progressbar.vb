Public Class progressbar


    Private Sub progressbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Timer1.Interval = 300
        Timer1.Enabled = False
        Gifbox.Visible = False
    End Sub

        Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click

        Gifbox.Visible = True
            Timer1.Start()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(10)
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()
            Gifbox.Visible = False
            MsgBox("Complete")
            Form2.Show()
            Me.Hide()

        End If

    End Sub


End Class
