Public Class MainForm

    Public Ready As Integer = 1
    Public IsSomeoneComing As Integer = 1

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Ready = 2
        GuestInformationForm.ShowDialog()

    End Sub

    Private Sub GuestListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestListToolStripMenuItem.Click
        If Ready < 2 Then
            MessageBox.Show("No one is on the guest list yet... You could be the first one to say Coming!")
            GuestInformationForm.ShowDialog()
        End If
        ConfirmedGuestForm.ShowDialog()

    End Sub

    Public Sub ComingOrNot()
        IsSomeoneComing = 2
    End Sub
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        If IsSomeoneComing = 2 Then
            MessageBox.Show(“Goodbye, see you at party.”)
        Else
            MessageBox.Show(“Goodbye, sorry we will miss you.”)
        End If
        Application.Exit()

    End Sub
End Class
