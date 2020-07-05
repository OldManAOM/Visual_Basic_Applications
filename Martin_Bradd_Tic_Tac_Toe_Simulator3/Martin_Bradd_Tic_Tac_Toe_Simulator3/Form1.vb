Public Class Form1
    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        'Setting values...
        Dim TicTacArray(2, 2) As Integer
        Dim rand As New Random
        Dim Row1X As Boolean
        Dim Row2X As Boolean
        Dim Row3X As Boolean
        Dim Column1X As Boolean
        Dim Column2X As Boolean
        Dim Column3X As Boolean
        Dim Diag1X As Boolean
        Dim Diag2X As Boolean
        Dim Row1O As Boolean
        Dim Row2O As Boolean
        Dim Row3O As Boolean
        Dim Column1O As Boolean
        Dim Column2O As Boolean
        Dim Column3O As Boolean
        Dim Diag1O As Boolean
        Dim Diag2O As Boolean
        Dim OCanWin As Integer = 0
        Dim XCanWin As Integer = 0
        'Randomly fill array with a value of 0 to 1
        For intRow As Integer = 0 To 2
            For intCol As Integer = 0 To 2
                Dim UnknownNum As Integer = rand.Next(2)
                TicTacArray(intRow, intCol) = UnknownNum
            Next
        Next
        'Making labels represent
        If TicTacArray(0, 0) = 1 Then
            lbl1.Text = "X"
        Else
            lbl1.Text = "O"
        End If
        If TicTacArray(0, 1) = 1 Then
            lbl2.Text = "X"
        Else
            lbl2.Text = "O"
        End If
        If TicTacArray(0, 2) = 1 Then
            lbl3.Text = "X"
        Else
            lbl3.Text = "O"
        End If
        If TicTacArray(1, 0) = 1 Then
            lbl4.Text = "X"
        Else
            lbl4.Text = "O"
        End If
        If TicTacArray(1, 1) = 1 Then
            lbl5.Text = "X"
        Else
            lbl5.Text = "O"
        End If
        If TicTacArray(1, 2) = 1 Then
            lbl6.Text = "X"
        Else
            lbl6.Text = "O"
        End If
        If TicTacArray(2, 0) = 1 Then
            lbl7.Text = "X"
        Else
            lbl7.Text = "O"
        End If
        If TicTacArray(2, 1) = 1 Then
            lbl8.Text = "X"
        Else
            lbl8.Text = "O"
        End If
        If TicTacArray(2, 2) = 1 Then
            lbl9.Text = "X"
        Else
            lbl9.Text = "O"
        End If

        'Determining a winner or tie....
        '   
        'First Rows for X
        If lbl1.Text = "X" And lbl2.Text = "X" And lbl3.Text = "X" Then
            Row1X = True
            XCanWin = 1
        Else Row1X = False
        End If
        If lbl4.Text = "X" And lbl5.Text = "X" And lbl6.Text = "X" Then
            Row2X = True
            XCanWin = 1
        Else Row2X = False
        End If
        If lbl7.Text = "X" And lbl8.Text = "X" And lbl9.Text = "X" Then
            Row3X = True
            XCanWin = 1
        Else Row3X = False
        End If
        'Now Columns for X
        If lbl1.Text = "X" And lbl4.Text = "X" And lbl7.Text = "X" Then
            Column1X = True
            XCanWin = 1
        Else Column1X = False
        End If
        If lbl2.Text = "X" And lbl5.Text = "X" And lbl8.Text = "X" Then
            Column2X = True
            XCanWin = 1
        Else Column2X = False
        End If
        If lbl3.Text = "X" And lbl6.Text = "X" And lbl9.Text = "X" Then
            Column3X = True
            XCanWin = 1
        Else Column3X = False
        End If
        'Now Diag for X
        If lbl1.Text = "X" And lbl5.Text = "X" And lbl9.Text = "X" Then
            Diag1X = True
            XCanWin = 1
        Else Diag1X = False
        End If
        If lbl3.Text = "X" And lbl5.Text = "X" And lbl7.Text = "X" Then
            Diag2X = True
            XCanWin = 1
        Else Diag2X = False
        End If
        'NEW LINE FOR O!!!
        '
        'First Rows for O
        If lbl1.Text = "O" And lbl2.Text = "O" And lbl3.Text = "O" Then
            Row1O = True
            OCanWin = 1
        Else Row1O = False
        End If
        If lbl4.Text = "O" And lbl5.Text = "O" And lbl6.Text = "O" Then
            Row2O = True
            OCanWin = 1
        Else Row2O = False
        End If
        If lbl7.Text = "O" And lbl8.Text = "O" And lbl9.Text = "O" Then
            Row3O = True
            OCanWin = 1
        Else Row3O = False
        End If
        'Now Columns for O
        If lbl1.Text = "O" And lbl4.Text = "O" And lbl7.Text = "O" Then
            Column1O = True
            OCanWin = 1
        Else Column1O = False
        End If
        If lbl2.Text = "O" And lbl5.Text = "O" And lbl8.Text = "O" Then
            Column2O = True
            OCanWin = 1
        Else Column2O = False
        End If
        If lbl3.Text = "O" And lbl6.Text = "O" And lbl9.Text = "O" Then
            Column3O = True
            OCanWin = 1
        Else Column3O = False
        End If
        'Now Diag for O
        If lbl1.Text = "O" And lbl5.Text = "O" And lbl9.Text = "O" Then
            Diag1O = True
            OCanWin = 1
        Else Diag1O = False
        End If
        If lbl3.Text = "O" And lbl5.Text = "O" And lbl7.Text = "O" Then
            Diag2O = True
            OCanWin = 1
        Else Diag2O = False
        End If

        'Now find a tie or win....

        If OCanWin = 1 And XCanWin = 1 Then
            Label10.Text = "It is a tie!"
        ElseIf XCanWin = 1 Then
            Label10.Text = "Player X has won!"
        Else Label10.Text = "Player O has won!"

        End If






    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
