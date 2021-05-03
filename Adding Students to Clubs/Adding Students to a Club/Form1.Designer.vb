<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstGeneral = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboClubs = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(29, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(701, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'lstGeneral
        '
        Me.lstGeneral.FormattingEnabled = True
        Me.lstGeneral.ItemHeight = 20
        Me.lstGeneral.Items.AddRange(New Object() {"Adams, Ben", "Baker, Sally", "Canseco, Juan", "Davis, Sharon", "Etienne, Jean", "Gonzalez, Jose", "Johnson, Eric", "Koenig, Johann", "Matsunaga, Akiko", "Nakamura, Ken", "Ramirez, Maria"})
        Me.lstGeneral.Location = New System.Drawing.Point(39, 104)
        Me.lstGeneral.Name = "lstGeneral"
        Me.lstGeneral.Size = New System.Drawing.Size(183, 244)
        Me.lstGeneral.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "General Student List"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.cboClubs)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblCount)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lstMembers)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lstGeneral)
        Me.Panel1.Location = New System.Drawing.Point(33, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 378)
        Me.Panel1.TabIndex = 3
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(565, 294)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(115, 54)
        Me.lblCount.TabIndex = 7
        Me.lblCount.Text = "(0 Members)"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(569, 160)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(93, 108)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove selected member"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(242, 160)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 108)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add selected student"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Club Membership List"
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 20
        Me.lstMembers.Location = New System.Drawing.Point(362, 104)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(183, 244)
        Me.lstMembers.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Select the current club:"
        '
        'cboClubs
        '
        Me.cboClubs.FormattingEnabled = True
        Me.cboClubs.Location = New System.Drawing.Point(232, 30)
        Me.cboClubs.Name = "cboClubs"
        Me.cboClubs.Size = New System.Drawing.Size(201, 28)
        Me.cboClubs.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 502)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(781, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 19)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 524)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Adding Students to a Club"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstGeneral As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstMembers As System.Windows.Forms.ListBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents cboClubs As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
