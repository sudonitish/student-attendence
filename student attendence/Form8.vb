Imports System.Data.SqlClient
Public Class Form8
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
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            Str = "select * from student"
            com = New SqlCommand(Str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, att)
        End Using
    End Sub


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            Str = "select * from student where id='" + textBox1.Text + "'"
            com = New SqlCommand(Str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, att)
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            str = "select * from student"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, att)
        End Using
        textBox1.Text = ""
        If Form3.Label1.Text = "Teacher" Then
            Me.Hide()
            Form3.Show()
        Else
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class