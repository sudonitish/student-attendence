Imports System.Data.SqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label3.Text = Format(Now, "dd-MMM-yyyy")
        Me.Label4.Text = Format(Now, "hh:mm tt")
    End Sub

    Private Sub logoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logoutToolStripMenuItem.Click
        Me.Hide()
        Form13.Show()
    End Sub

    Private Sub addTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addTeacherToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub addStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addStudentToolStripMenuItem.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub viewTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewTeacherToolStripMenuItem.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub viewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewStudentToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub viewAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Form9.Show()
    End Sub
End Class