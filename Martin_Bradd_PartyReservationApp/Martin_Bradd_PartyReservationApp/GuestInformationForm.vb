Imports System.Data.OleDb
Public Class GuestInformationForm

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub GuestInformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtFirstName.Text = Nothing
        txtLastName.Text = Nothing
        txtEmail.Text = Nothing
        txtPhone.Text = Nothing
        txtNumberOfGuests.Text = Nothing

    End Sub
    Private Phone As Integer
    Private Guests As Integer
    Private Function ValidateInputFields() As Boolean
        'Finding Errors
        If txtLastName.Text = Nothing Then
            MessageBox.Show("All fields must be filled out!")
            Return False
        End If
        If txtEmail.Text = Nothing Then
            MessageBox.Show("All fields must be filled out!")
            Return False
        End If
        If txtPhone.Text = Nothing Then
            MessageBox.Show("All fields must be filled out!")
            Return False
        End If
        If txtFirstName.Text = Nothing Then
            MessageBox.Show("All fields must be filled out!")
            Return False
        End If
        If txtNumberOfGuests.Text = Nothing Then
            MessageBox.Show("All fields must be filled out!")
            Return False
        End If
        If comboBoxFoodP.Text = Nothing Then
            MessageBox.Show("All fields must be filled out!")
            Return False
        End If
        If Not Integer.TryParse(txtPhone.Text, Phone) Then
            txtPhone.Text = "Must be numeric only!"
            Return False
        End If
        If Not Integer.TryParse(txtNumberOfGuests.Text, Guests) Then
            txtNumberOfGuests.Text = "Must be numeric only!"
            Return False
        End If
        Return True
    End Function




    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MainForm.ComingOrNot()
        If ValidateInputFields() Then
            Try
                Dim gCount As Integer
                Dim One As Integer = 1

                provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                dataFile = "B:\Documents\VisualBasicPartyDatabase.accdb"
                connString = provider & dataFile
                myConnection.ConnectionString = connString
                myConnection.Open()
                Dim str As String
                str = "Insert into DataChart([First Name],[Last Name],[Email Address],[Phone Number],[Number of Guests],[Food Preference]) Values (?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                cmd.Parameters.Add(New OleDbParameter("First Name", CType(txtFirstName.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Last Name", CType(txtLastName.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Email Address", CType(txtEmail.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Phone Number", CType(txtPhone.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Number of Guests", CType(txtNumberOfGuests.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Food Preference", CType(comboBoxFoodP.Text, String)))

                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                Clear()

                MessageBox.Show("Data saved to Access database!")

                gCount = Guests + One

                ConfirmedGuestForm.ListBoxConfirmGuest.Items.Add(txtFirstName.Text & " " & txtLastName.Text & "," & " " & "Party of " & gCount)
                ConfirmedGuestForm.ListBoxConfirmGuest.Items.Add("\n")

                ConfirmedGuestForm.ListBoxConfirmGuest.Items.Add("First Name: " & txtFirstName.Text)
                ConfirmedGuestForm.ListBoxConfirmGuest.Items.Add("Last Name: " & txtLastName.Text)
                ConfirmedGuestForm.ListBoxConfirmGuest.Items.Add("Email: " & txtEmail.Text)
                ConfirmedGuestForm.ListBoxConfirmGuest.Items.Add("Phone Number: " & txtPhone.Text)
                ConfirmedGuestForm.ListBoxConfirmGuest.Items.Add("Number of Guests: " & txtNumberOfGuests.Text)
                ConfirmedGuestForm.ListBoxConfirmGuest.Items.Add("Food Preference: " & comboBoxFoodP.Text)
                ConfirmedGuestForm.ListBoxConfirmGuest.Items.Add("--------------------------------------------")

                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Failed to save user information to Access database.")
            End Try


        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("I will miss you and hope to see you soon!")
        Me.Close()

    End Sub

    Sub Clear()
        txtFirstName.Text = Nothing
        txtLastName.Text = Nothing
        txtEmail.Text = Nothing
        txtPhone.Text = Nothing
        txtNumberOfGuests.Text = Nothing
        comboBoxFoodP.Text = Nothing
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Clear()
    End Sub
End Class