Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            MainForm.Show()
            Me.Hide()
        End If

    End Sub


End Class