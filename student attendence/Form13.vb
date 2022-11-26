Imports System.Data.SqlClient
Public Class Form13
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



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedIndex = "0" Then
            If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then


                ComboBox1.Text = "--Select--"
                TextBox1.Text = ""
                TextBox2.Text = ""
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("login fail")
            End If
        End If

        If ComboBox1.SelectedIndex = "1" Then
            Form3.Label1.Text = "Teacher"
            Form10.Label5.Text = TextBox1.Text
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            con.Open()
            Try
                getuser = "select id from teacher where id='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                com = New SqlCommand(getuser, con)
                dr = com.ExecuteReader()
                If (dr.Read()) Then


                    ComboBox1.Text = "--Select Type--"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    Form3.Show()
                    Me.Hide()
                Else
                    MsgBox("something Wrong")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedIndex = "2" Then
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            con.Open()
            Try
                getuser = "select id from student where id='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
                com = New SqlCommand(getuser, con)
                dr = com.ExecuteReader()
                Form4.Label1.Text = TextBox1.Text
                Form15.Label1.Text = TextBox1.Text
                Form11.Label12.Text = TextBox1.Text
                If (dr.Read()) Then


                    ComboBox1.Text = "--Select Type--"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    Form4.Show()
                    Me.Hide()
                Else
                    MsgBox("something Wrong")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = "--Select--"
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = "--Select--"

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class