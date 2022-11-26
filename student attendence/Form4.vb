Imports System.Data.SqlClient
Public Class Form4
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim getuser As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim att As Object
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label3.Text = Format(Now, "dd-MMM-yyyy")
        Me.Label4.Text = Format(Now, "hh:mm tt")
        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            con.Open()
            str = "select Rno from student where id='" + Label1.Text + "'"
            com = New SqlCommand(str, con)

            dr = com.ExecuteReader()
            dr.Read()
            Label2.Text = dr("Rno").ToString
            con.Close()
            Form15.Label4.Text = Label2.Text

        End Using
    End Sub

    Private Sub myDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles myDetailsToolStripMenuItem.Click

        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub viewAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewAttendanceToolStripMenuItem.Click

        Me.Hide()
        Form15.Show()

    End Sub

    Private Sub logoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logoutToolStripMenuItem.Click
        Form15.Label2.Text = ""
        Form15.Label4.Text = ""
        Me.Hide()
        Label2.Text = ""
        Form13.Show()
        Application.Restart()

    






    End Sub
End Class