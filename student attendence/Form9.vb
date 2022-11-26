Imports System.Data.SqlClient
Public Class Form9
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim cmd1 As SqlCommand
    Dim cmd2 As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim str1 As String
    Dim str2 As String
    Dim getuser As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim att As Object
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            str = "select * from attendance where tid='" + Form10.Label5.Text + "'"
            com = New SqlCommand(Str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, att)
        End Using
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Dim ld, la
        Dim per
      

        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            Try
                con.Open()
                If ComboBox1.Text = "01" Then
                    str = "select date,RN01 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN01') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN01') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN01='P'"
                End If
                If ComboBox1.Text = "02" Then
                    str = "select date,RN02 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN02') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN02') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN02='P'"
                End If
                If ComboBox1.Text = "03" Then
                    str = "select date,RN03 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN03') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN03') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN03='P'"
                End If
                If ComboBox1.Text = "04" Then
                    str = "select date,RN04 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN04') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN04') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN04='P'"
                End If
                If ComboBox1.Text = "05" Then
                    str = "select date,RN05 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN05') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN05') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN05='P'"
                End If
                If ComboBox1.Text = "06" Then
                    str = "select date,RN06 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN06') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN06') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN06='P'"
                End If
                If ComboBox1.Text = "07" Then
                    str = "select date,RN07 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN07') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN07') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN07='P'"
                End If
                If ComboBox1.Text = "08" Then
                    str = "select date,RN08 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN08') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN08') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN08='P'"
                End If
                If ComboBox1.Text = "09" Then
                    str = "select date,RN09 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN09') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN09') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN09='P'"
                End If
                If ComboBox1.Text = "10" Then
                    str = "select date,RN10 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN10') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN10') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN10='P'"
                End If
                If ComboBox1.Text = "11" Then
                    str = "select date,RN11 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN11') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN11') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN11='P'"
                End If
                If ComboBox1.Text = "12" Then
                    str = "select date,RN12 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN12') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN12') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN12='P'"
                End If
                If ComboBox1.Text = "13" Then
                    str = "select date,RN13 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN13') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN13') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN13='P'"
                End If
                If ComboBox1.Text = "14" Then
                    str = "select date,RN14 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN14') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN14') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN14='P'"
                End If
                If ComboBox1.Text = "15" Then
                    str = "select date,RN15 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN15') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN15') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN15='P'"
                End If
                If ComboBox1.Text = "16" Then
                    str = "select date,RN16 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN16') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN16') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN16='P'"
                End If
                If ComboBox1.Text = "17" Then
                    str = "select date,RN17 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN17') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN17') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN17='P'"

                End If
                If ComboBox1.Text = "18" Then
                    str = "select date,RN18 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN18') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN18') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN18='P'"
                End If
                If ComboBox1.Text = "19" Then
                    str = "select date,RN19 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN19') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN19') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN19='P'"
                End If
                If ComboBox1.Text = "20" Then
                    str = "select date,RN20 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN20') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN20') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN20='P'"
                End If
                If ComboBox1.Text = "21" Then
                    str = "select date,RN21 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN21') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN21') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN21='P'"
                End If
                If ComboBox1.Text = "22" Then
                    str = "select date,RN22 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN22') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN22') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN22='P'"
                End If
                If ComboBox1.Text = "23" Then
                    str = "select date,RN23 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN23') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN23') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN23='P'"
                End If
                If ComboBox1.Text = "24" Then
                    str = "select date,RN24 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN24') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN24') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN24='P'"
                End If
                If ComboBox1.Text = "25" Then
                    str = "select date,RN25 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN25') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN25') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN25='P'"
                End If
                If ComboBox1.Text = "26" Then
                    str = "select date,RN26 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN26') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN26') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN26='P'"
                End If
                If ComboBox1.Text = "27" Then
                    str = "select date,RN27 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN27') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN27') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN27='P'"
                End If
                If ComboBox1.Text = "28" Then
                    str = "select date,RN28 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN28') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN28') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN28='P'"
                End If
                If ComboBox1.Text = "29" Then
                    str = "select date,RN29 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN29') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN29') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN29='P'"
                End If
                If ComboBox1.Text = "30" Then
                    str = "select date,RN30 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN30') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN30') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN30='P'"
                End If
                If ComboBox1.Text = "31" Then
                    str = "select date,RN31 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN31') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN31') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN31='P'"
                End If
                If ComboBox1.Text = "32" Then
                    str = "select date,RN32 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN32') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN32') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN32='P'"
                End If
                If ComboBox1.Text = "33" Then
                    str = "select date,RN33 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN33') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN33') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN33='P'"
                End If
                If ComboBox1.Text = "34" Then
                    str = "select date,RN34 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN34') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN34') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN34='P'"
                End If
                If ComboBox1.Text = "35" Then
                    str = "select date,RN35 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN35') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN35') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN35='P'"
                End If
                If ComboBox1.Text = "36" Then
                    str = "select date,36 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN36') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN36') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN36='P'"
                End If
                If ComboBox1.Text = "37" Then
                    str = "select date,RN37 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN37') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN37') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN37='P'"
                End If
                If ComboBox1.Text = "38" Then
                    str = "select date,RN38 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN38') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN38') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN38='P'"
                End If
                If ComboBox1.Text = "39" Then
                    str = "select date,RN39 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN39') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN39') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN39='P'"
                End If
                If ComboBox1.Text = "40" Then
                    str = "select date,RN40 as '" + ComboBox1.Text + "' from attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str1 = "SELECT COUNT('RN40') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "'"
                    str2 = "SELECT COUNT('RN40') FROM attendance where class='" + ComboBox2.Text + "' AND tid='" + Form10.Label5.Text + "' AND RN40='P'"
                End If

                com = New SqlCommand(str, con)


                cmd1 = New SqlCommand(str1, con)
                cmd2 = New SqlCommand(str2, con)
                ld = cmd1.ExecuteNonQuery
                la = cmd2.ExecuteNonQuery
                Label8.Text = cmd1.ExecuteScalar().ToString()
                Label9.Text = cmd2.ExecuteScalar().ToString()
                la = Label9.Text
                ld = Label8.Text

                per = (la / ld) * 100
                Label10.Text = per & "%"
                If per < 75 Then
                    Label11.ForeColor = Color.Red
                    Label11.Text = "Stucked off"
                Else
                    Label11.ForeColor = Color.Green
                    Label11.Text = "Attending"

                End If

                con.Close()


                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                dataGridView1.DataSource = New BindingSource(dt, att)

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try



        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            str = "select * from attendance"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, att)
        End Using
        If Form3.Label1.Text = "Teacher" Then
            Me.Hide()
            Form3.Show()
        Else
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
            str = "select * from attendance where tid='" + Form10.Label5.Text + "'"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, att)
        End Using
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class