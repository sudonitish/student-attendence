<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.addTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addTeacherToolStripMenuItem, Me.addStudentToolStripMenuItem, Me.viewTeacherToolStripMenuItem, Me.viewStudentToolStripMenuItem, Me.logoutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(1035, 26)
        Me.menuStrip1.TabIndex = 2
        Me.menuStrip1.Text = "menuStrip1"
        '
        'addTeacherToolStripMenuItem
        '
        Me.addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem"
        Me.addTeacherToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.addTeacherToolStripMenuItem.Text = "Add/Remove/Update Teacher"
        '
        'addStudentToolStripMenuItem
        '
        Me.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem"
        Me.addStudentToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.addStudentToolStripMenuItem.Text = "Add/Remove/Update Student"
        '
        'viewTeacherToolStripMenuItem
        '
        Me.viewTeacherToolStripMenuItem.Name = "viewTeacherToolStripMenuItem"
        Me.viewTeacherToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.viewTeacherToolStripMenuItem.Text = "View Teacher"
        '
        'viewStudentToolStripMenuItem
        '
        Me.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem"
        Me.viewStudentToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.viewStudentToolStripMenuItem.Text = "View Student"
        '
        'logoutToolStripMenuItem
        '
        Me.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem"
        Me.logoutToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.logoutToolStripMenuItem.Text = "Logout"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(792, 88)
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
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(792, 124)
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
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(689, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Time:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(689, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1035, 556)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "HomeAdmin"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents addTeacherToolStripMenuItem As ToolStripMenuItem
    Private WithEvents addStudentToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewTeacherToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewStudentToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
