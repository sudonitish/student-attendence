Imports System.Data.SqlClient
Public Class Form6
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

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()

        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            str = "select * from student"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, att)
        End Using


    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        If radioButton1.Checked Then
            gen = "Male"
        ElseIf radioButton2.Checked Then
            gen = "Female"
        End If

        If textBox1.Text = "" Or textBox2.Text = "" Or textBox3.Text = "" Or textBox4.Text = "" Or textBox6.Text = "" Or ComboBox1.Text = "--Select--" Or ComboBox2.Text = "--Select--" Or textBox9.Text = "" Then

            MessageBox.Show("Please fill all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                str = "insert into student(Id,name,gen,contact,email,addr,dob,class,Rno,pass) values('" + textBox1.Text + "','" + textBox2.Text + "','" + gen + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + DateTimePicker1.Value.ToShortDateString + "','" + ComboBox1.Text + "','" + ComboBox2.Text + "','" + textBox9.Text + "')"
                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                MsgBox("Student Details Inserted Successfully..")
                Using con
                    str = "select * from student"
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
                DateTimePicker1.Value = Format(Now, "dd-MMM-yyyy")
                textBox6.Text = ""
                ComboBox1.Text = "--Select--"
                ComboBox2.Text = "--Select--"
                textBox9.Text = ""
                radioButton1.Checked = True
                con.Close()
            Catch

                MessageBox.Show("Id already exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        Try
            str = "Select name,gen,contact,email,addr,dob,class,Rno,pass from student where id='" + textBox1.Text + "'"
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
                textBox6.Text = dr.GetValue(4).ToString()
                DateTimePicker1.Value = dr.GetValue(5).ToString()
                ComboBox1.Text = dr.GetValue(6).ToString()
                ComboBox2.Text = dr.GetValue(7).ToString()
                textBox9.Text = dr.GetValue(8).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
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
        str = "update student set name='" + textBox2.Text + "',gen='" + gen + "',contact='" + textBox3.Text + "',email='" + textBox4.Text + "',addr='" + textBox6.Text + "',dob='" + DateTimePicker1.Value.ToShortDateString + "',class='" + ComboBox1.Text + "',Rno='" + ComboBox2.Text + "',pass='" + textBox9.Text + "' where id='" + textBox1.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Student Data Updated Successfully..")
        Using con
            str = "select * from student"
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
        DateTimePicker1.Value = Format(Now, "dd-MMM-yyyy")
        textBox6.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
        textBox9.Text = ""
        con.Close()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Try
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            con.Open()
            str = "Delete from student where id='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Delete Student Data Successfully..")
            Using con
                str = "select * from student"
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
            DateTimePicker1.Value = Format(Now, "dd-MMM-yyyy")
            textBox6.Text = ""
             ComboBox1.Text = "--Select--"
            ComboBox2.Text = "--Select--"
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
        DateTimePicker1.Value = Format(Now, "dd-MMM-yyyy")
        textBox6.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
        textBox9.Text = ""
        radioButton1.Checked = True
    End Sub
End Class