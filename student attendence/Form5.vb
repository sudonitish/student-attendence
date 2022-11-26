Imports System.Data.SqlClient
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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

    Private Sub AddTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()

        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            str = "select * from teacher"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, att)
        End Using
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        If radioButton1.Checked Then
            gen = "Male"
        ElseIf radioButton2.Checked Then
            gen = "Female"
        End If
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()

        Try

            If textBox1.Text = "" Or textBox2.Text = "" Or textBox3.Text = "" Or textBox4.Text = "" Or textBox5.Text = "" Or textBox6.Text = "" Or textBox7.Text = "" Or textBox8.Text = "" Or textBox9.Text = "" Then

                MessageBox.Show("Please fill all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                str = "insert into teacher(Id,name,gen,contact,email,addr,subject,age,pass,salary) values('" + textBox1.Text + "','" + textBox2.Text + "','" + gen + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')"
                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                MsgBox("Teacher Details Inserted Successfully..")

                Using con
                    str = "select * from teacher"
                    com = New SqlCommand(str, con)
                    da = New SqlDataAdapter(com)
                    dt = New DataTable()
                    dv = New DataView()
                    da.Fill(dt)
                    DataGridView1.DataSource = New BindingSource(dt, att)
                End Using

                textBox1.Text = ""
                textBox2.Text = ""
                textBox3.Text = ""
                textBox4.Text = ""
                textBox5.Text = ""
                textBox6.Text = ""
                textBox7.Text = ""
                textBox8.Text = ""
                textBox9.Text = ""
                radioButton1.Checked = True
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("User already exists!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        Try
            str = "Select name,gen,contact,email,addr,subject,age,pass,salary from teacher where id='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                textBox2.Text = dr.GetValue(0).ToString()
                Select Case dr(1).ToString
                    Case "Male"
                        radioButton1.Checked = True
                    Case "Female"
                        radioButton2.Checked = True
                End Select
                textBox3.Text = dr.GetValue(2).ToString()
                textBox4.Text = dr.GetValue(3).ToString()
                textBox5.Text = dr.GetValue(4).ToString()
                textBox6.Text = dr.GetValue(5).ToString()
                textBox7.Text = dr.GetValue(6).ToString()
                textBox8.Text = dr.GetValue(7).ToString()
                textBox9.Text = dr.GetValue(8).ToString()
            End If
        Catch
            MsgBox("ID already available!!")
        End Try
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        If radioButton1.Checked Then
            gen = "Male"
        ElseIf radioButton2.Checked Then
            gen = "Female"
        End If
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        str = "update teacher set name='" + textBox2.Text + "',gen='" + gen + "',contact='" + textBox3.Text + "',email='" + textBox4.Text + "',addr='" + textBox5.Text + "',subject='" + textBox6.Text + "',age='" + textBox7.Text + "',pass='" + textBox8.Text + "',salary='" + textBox9.Text + "' where id='" + textBox1.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Teacher Data Updated Successfully..")
        Using con
            str = "select * from teacher"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, att)
        End Using
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        textBox7.Text = ""
        textBox8.Text = ""
        textBox9.Text = ""
        con.Close()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Try
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            con.Open()
            str = "Delete from teacher where id='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Delete Teacher Data Successfully..")
            Using con
                str = "select * from teacher"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                DataGridView1.DataSource = New BindingSource(dt, att)
            End Using

            textBox2.Text = ""
            textBox3.Text = ""
            textBox4.Text = ""
            textBox5.Text = ""
            textBox6.Text = ""
            textBox7.Text = ""
            textBox8.Text = ""
            textBox9.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        textBox7.Text = ""
        textBox8.Text = ""
        textBox9.Text = ""
        radioButton1.Checked = True

    End Sub
End Class