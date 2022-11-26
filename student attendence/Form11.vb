Imports System.Data.SqlClient
Public Class Form11
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
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        Try
            str = "Select name,gen,contact,email,addr,dob,class,Rno,pass from student where id='" + Form4.Label1.Text + "'"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                label13.Text = dr.GetValue(0).ToString()
                label14.Text = dr.GetValue(2).ToString()
                label15.Text = dr.GetValue(3).ToString()
                label16.Text = dr.GetValue(4).ToString()
                label17.Text = dr.GetValue(5).ToString()
                label18.Text = dr.GetValue(6).ToString()
                label19.Text = dr.GetValue(7).ToString()
                label20.Text = dr.GetValue(8).ToString()
                label21.Text = dr.GetValue(1).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub


End Class