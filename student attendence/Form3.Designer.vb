<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.menuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.takeAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.menuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip2
        '
        Me.menuStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.takeAttendanceToolStripMenuItem, Me.viewStudentToolStripMenuItem, Me.viewAttendanceToolStripMenuItem, Me.logoutToolStripMenuItem})
        Me.menuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip2.Name = "menuStrip2"
        Me.menuStrip2.Size = New System.Drawing.Size(800, 26)
        Me.menuStrip2.TabIndex = 4
        Me.menuStrip2.Text = "menuStrip2"
        '
        'takeAttendanceToolStripMenuItem
        '
        Me.takeAttendanceToolStripMenuItem.Name = "takeAttendanceToolStripMenuItem"
        Me.takeAttendanceToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.takeAttendanceToolStripMenuItem.Text = "Take Attendance"
        '
        'viewStudentToolStripMenuItem
        '
        Me.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem"
        Me.viewStudentToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.viewStudentToolStripMenuItem.Text = "View Student"
        '
        'viewAttendanceToolStripMenuItem
        '
        Me.viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem"
        Me.viewAttendanceToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.viewAttendanceToolStripMenuItem.Text = "View Attendance"
        '
        'logoutToolStripMenuItem
        '
        Me.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem"
        Me.logoutToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.logoutToolStripMenuItem.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(655, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(624, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "d"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(624, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "t"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(521, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(521, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Date:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "HomeTeacher"
        Me.menuStrip2.ResumeLayout(False)
        Me.menuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip2 As MenuStrip
    Private WithEvents takeAttendanceToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewStudentToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewAttendanceToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
