Imports System.IO

Public Class Form1
    Private strClubNames() As String = {"Honors", "Golden Arrow", "Computer"}

    ' keep track of the size of each club
    Private intEnrollSizes(strClubNames.Count) As Integer

    ' holds names of enrolled members of all clubs
    Private strEnrollments(0, 0) As String


    Function CheckForInsertErrors() As Boolean

        lblStatus.Text = String.Empty

        If lstGeneral.SelectedIndex = -1 Then
            lblStatus.Text = "Please select a name from the general student list"
            Return False
        End If
        If cboClubs.SelectedIndex = -1 Then
            lblStatus.Text = "Please select a club name from the list"
            Return False
        End If
        Return True
    End Function

    ' Copy a student name from the general student list to the list for the
    ' currently selected club.
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Not CheckForInsertErrors() Then Return

        Dim clubIndex As Integer = cboClubs.SelectedIndex

        Dim name As String = lstGeneral.SelectedItem.ToString()
        If Not lstMembers.Items.Contains(name) Then
            lstMembers.Items.Add(lstGeneral.SelectedItem)
            intEnrollSizes(clubIndex) += 1
            lblCount.Text = lstMembers.Items.Count.ToString() & " members"
        End If

        '  save the names back into the master array
        For i = 0 To lstMembers.Items.Count - 1
            strEnrollments(clubIndex, i) = lstMembers.Items(i).ToString()
        Next

    End Sub

    Private Function CreatingFile() As ClubData
        Dim clubNew As ClubData = New ClubData

        With clubNew
            .strClubsName = CType(intEnrollSizes(1), String)
            .strClubNums =
            .strHonorClubNames =
            .strHonorNameNum =
            .strGoldClubNames =
            .strGoldNameNum =
            .strCompClubNames =
            .strCompNameNum =
        End With
        Return clubNew
    End Function

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim clubOne As ClubData = CreatingFile()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        lblStatus.Text = String.Empty
        If lstMembers.SelectedIndex = -1 Then
            lblStatus.Text = "Please select a name from the membership list"
            Return
        End If

        Dim index As Integer = lstMembers.SelectedIndex
        If index <> -1 Then
            lstMembers.Items.RemoveAt(index)
        End If

        Dim clubIndex As Integer = cboClubs.SelectedIndex

        '  save the names back into the master array
        For i = 0 To lstMembers.Items.Count - 1
            strEnrollments(clubIndex, i) = lstMembers.Items(i).ToString()
        Next
        intEnrollSizes(clubIndex) = lstMembers.Items.Count

        lblCount.Text = lstMembers.Items.Count.ToString() & " members"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' insert club names in the combo box
        For Each club As String In strClubNames
            cboClubs.Items.Add(club)
        Next
        ReDim strEnrollments(strClubNames.Count, lstGeneral.Items.Count)
    End Sub




    Private Sub createFile()
        Dim clubFile As StreamWriter



        Try
            clubFile = File.CreateText(strFileName)



        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboClubs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClubs.SelectedIndexChanged

        ' Fill the members list box with the names of people
        ' who belong to the currently selected club.
        lstMembers.Items.Clear()
        Dim index As Integer = cboClubs.SelectedIndex

        ' copy member names from the enrollments master array into
        ' the list box.
        For i As Integer = 0 To intEnrollSizes(index) - 1
            lstMembers.Items.Add(strEnrollments(index, i))
        Next
    End Sub
End Class
