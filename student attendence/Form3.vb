Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration


Public Class Form3
    Private Sub takeAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles takeAttendanceToolStripMenuItem.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub viewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewStudentToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()




    End Sub

    Private Sub viewAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewAttendanceToolStripMenuItem.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub logoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logoutToolStripMenuItem.Click
        Me.Hide()
        Form13.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label3.Text = Format(Now, "dd-MMM-yyyy")
        Me.Label4.Text = Format(Now, "hh:mm tt")
    End Sub


End Class




























