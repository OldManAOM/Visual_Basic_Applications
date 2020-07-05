<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmedGuestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBoxConfirmGuest = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxConfirmGuest
        '
        Me.ListBoxConfirmGuest.FormattingEnabled = True
        Me.ListBoxConfirmGuest.ItemHeight = 20
        Me.ListBoxConfirmGuest.Location = New System.Drawing.Point(12, 3)
        Me.ListBoxConfirmGuest.Name = "ListBoxConfirmGuest"
        Me.ListBoxConfirmGuest.Size = New System.Drawing.Size(1192, 424)
        Me.ListBoxConfirmGuest.TabIndex = 0
        '
        'ConfirmedGuestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 440)
        Me.Controls.Add(Me.ListBoxConfirmGuest)
        Me.Name = "ConfirmedGuestForm"
        Me.Text = "Confirmed Guest Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxConfirmGuest As ListBox
End Class
