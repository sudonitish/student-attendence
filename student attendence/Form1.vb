Imports System.Data.SqlClient
Public Class Form1




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label3.Text = Format(Now, "dd-MMM-yyyy")
        Me.Label4.Text = Format(Now, "hh:mm tt")
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form13.Show()
        Me.Hide()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        Form14.Show()

    End Sub
End Class
