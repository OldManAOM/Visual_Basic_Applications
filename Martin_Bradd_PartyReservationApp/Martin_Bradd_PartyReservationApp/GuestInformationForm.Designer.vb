<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestInformationForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtNumberOfGuests = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboBoxFoodP = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(179, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(179, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of Guests:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(179, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(407, 94)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(256, 26)
        Me.txtFirstName.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(407, 154)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(256, 26)
        Me.txtLastName.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(407, 214)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(256, 26)
        Me.txtEmail.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(407, 279)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(256, 26)
        Me.txtPhone.TabIndex = 9
        '
        'txtNumberOfGuests
        '
        Me.txtNumberOfGuests.Location = New System.Drawing.Point(407, 337)
        Me.txtNumberOfGuests.Name = "txtNumberOfGuests"
        Me.txtNumberOfGuests.Size = New System.Drawing.Size(256, 26)
        Me.txtNumberOfGuests.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(789, 99)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(164, 248)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1021, 99)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 248)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1259, 38)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ResetToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ResetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(81, 34)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 27)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Food Preference:"
        '
        'comboBoxFoodP
        '
        Me.comboBoxFoodP.FormattingEnabled = True
        Me.comboBoxFoodP.Items.AddRange(New Object() {"Pizza", "Taco", "Chicken", "Beef", "Steak", "Popcorn"})
        Me.comboBoxFoodP.Location = New System.Drawing.Point(407, 391)
        Me.comboBoxFoodP.Name = "comboBoxFoodP"
        Me.comboBoxFoodP.Size = New System.Drawing.Size(256, 28)
        Me.comboBoxFoodP.TabIndex = 15
        '
        'GuestInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 457)
        Me.Controls.Add(Me.comboBoxFoodP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNumberOfGuests)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GuestInformationForm"
        Me.Text = "Guest Information Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtNumberOfGuests As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents comboBoxFoodP As ComboBox
End Class
