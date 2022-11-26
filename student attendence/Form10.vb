Imports System.Data.SqlClient

Public Class Form10
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
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Label1.Text = Format(Now, "dd-MMM-yyyy")

        ComboBox2.Text = "P"
        ComboBox3.Text = "P"
        ComboBox4.Text = "P"
        ComboBox5.Text = "P"
        ComboBox6.Text = "P"
        ComboBox7.Text = "P"
        ComboBox8.Text = "P"
        ComboBox9.Text = "P"
        ComboBox10.Text = "P"
        ComboBox11.Text = "P"
        ComboBox12.Text = "P"
        ComboBox13.Text = "P"
        ComboBox14.Text = "P"
        ComboBox15.Text = "P"
        ComboBox16.Text = "P"
        ComboBox17.Text = "P"
        ComboBox18.Text = "P"
        ComboBox19.Text = "P"
        ComboBox20.Text = "P"
        ComboBox21.Text = "P"
        ComboBox22.Text = "P"
        ComboBox23.Text = "P"
        ComboBox24.Text = "P"
        ComboBox25.Text = "P"
        ComboBox26.Text = "P"
        ComboBox27.Text = "P"
        ComboBox28.Text = "P"
        ComboBox29.Text = "P"
        ComboBox30.Text = "P"
        ComboBox31.Text = "P"
        ComboBox32.Text = "P"
        ComboBox33.Text = "P"
        ComboBox34.Text = "P"
        ComboBox35.Text = "P"
        ComboBox36.Text = "P"
        ComboBox37.Text = "P"
        ComboBox38.Text = "P"
        ComboBox39.Text = "P"
        ComboBox40.Text = "P"
        ComboBox41.Text = "P"
        comboBox1.Text = "--Select--"
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If comboBox1.Text = "--Select--" Then
            MsgBox("Select class!")
            Me.Refresh()


        Else

            If ComboBox41.Text = "P" Then
            Form12.Label1.Text = "P"
        ElseIf ComboBox41.Text = "A" Then
            Form12.Label1.Text = "A"
        ElseIf ComboBox41.Text = "L" Then
            Form12.Label1.Text = "L"
        End If
        If ComboBox2.Text = "P" Then
            Form12.Label2.Text = "P"
        ElseIf ComboBox2.Text = "A" Then
            Form12.Label2.Text = "A"
        ElseIf ComboBox2.Text = "L" Then
            Form12.Label2.Text = "L"
        End If
        If ComboBox3.Text = "P" Then
            Form12.Label3.Text = "P"
        ElseIf ComboBox3.Text = "A" Then
            Form12.Label3.Text = "A"
        ElseIf ComboBox3.Text = "L" Then
            Form12.Label3.Text = "L"
        End If
        If ComboBox4.Text = "P" Then
            Form12.Label4.Text = "P"
        ElseIf ComboBox4.Text = "A" Then
            Form12.Label4.Text = "A"
        ElseIf ComboBox4.Text = "L" Then
            Form12.Label4.Text = "L"
        End If
        If ComboBox5.Text = "P" Then
            Form12.Label5.Text = "P"
        ElseIf ComboBox5.Text = "A" Then
            Form12.Label5.Text = "A"
        ElseIf ComboBox5.Text = "L" Then
            Form12.Label5.Text = "L"
        End If
        If ComboBox6.Text = "P" Then
            Form12.Label6.Text = "P"
        ElseIf ComboBox6.Text = "A" Then
            Form12.Label6.Text = "A"
        ElseIf ComboBox6.Text = "L" Then
            Form12.Label6.Text = "L"
        End If
        If ComboBox7.Text = "P" Then
            Form12.Label7.Text = "P"
        ElseIf ComboBox7.Text = "A" Then
            Form12.Label7.Text = "A"
        ElseIf ComboBox7.Text = "L" Then
            Form12.Label7.Text = "L"
        End If
        If ComboBox8.Text = "P" Then
            Form12.Label8.Text = "P"
        ElseIf ComboBox8.Text = "A" Then
            Form12.Label8.Text = "A"
        ElseIf ComboBox8.Text = "L" Then
            Form12.Label8.Text = "L"
        End If
        If ComboBox9.Text = "P" Then
            Form12.Label9.Text = "P"
        ElseIf ComboBox9.Text = "A" Then
            Form12.Label9.Text = "A"
        ElseIf ComboBox9.Text = "L" Then
            Form12.Label9.Text = "L"
        End If
        If ComboBox10.Text = "P" Then
            Form12.Label10.Text = "P"
        ElseIf ComboBox10.Text = "A" Then
            Form12.Label10.Text = "A"
        ElseIf ComboBox10.Text = "L" Then
            Form12.Label10.Text = "L"
        End If
        If ComboBox11.Text = "P" Then
            Form12.Label11.Text = "P"
        ElseIf ComboBox11.Text = "A" Then
            Form12.Label11.Text = "A"
        ElseIf ComboBox11.Text = "L" Then
            Form12.Label11.Text = "L"
        End If
        If ComboBox12.Text = "P" Then
            Form12.Label12.Text = "P"
        ElseIf ComboBox12.Text = "A" Then
            Form12.Label12.Text = "A"
        ElseIf ComboBox12.Text = "L" Then
            Form12.Label12.Text = "L"
        End If
        If ComboBox13.Text = "P" Then
            Form12.Label13.Text = "P"
        ElseIf ComboBox13.Text = "A" Then
            Form12.Label13.Text = "A"
        ElseIf ComboBox13.Text = "L" Then
            Form12.Label13.Text = "L"
        End If
        If ComboBox14.Text = "P" Then
            Form12.Label14.Text = "P"
        ElseIf ComboBox14.Text = "A" Then
            Form12.Label14.Text = "A"
        ElseIf ComboBox14.Text = "L" Then
            Form12.Label14.Text = "L"
        End If
        If ComboBox15.Text = "P" Then
            Form12.Label15.Text = "P"
        ElseIf ComboBox15.Text = "A" Then
            Form12.Label15.Text = "A"
        ElseIf ComboBox15.Text = "L" Then
            Form12.Label15.Text = "L"
        End If
        If ComboBox16.Text = "P" Then
            Form12.Label16.Text = "P"
        ElseIf ComboBox16.Text = "A" Then
            Form12.Label16.Text = "A"
        ElseIf ComboBox16.Text = "L" Then
            Form12.Label16.Text = "L"
        End If
        If ComboBox17.Text = "P" Then
            Form12.Label17.Text = "P"
        ElseIf ComboBox17.Text = "A" Then
            Form12.Label17.Text = "A"
        ElseIf ComboBox17.Text = "L" Then
            Form12.Label17.Text = "L"
        End If
        If ComboBox18.Text = "P" Then
            Form12.Label18.Text = "P"
        ElseIf ComboBox18.Text = "A" Then
            Form12.Label18.Text = "A"
        ElseIf ComboBox18.Text = "L" Then
            Form12.Label18.Text = "L"
        End If
        If ComboBox19.Text = "P" Then
            Form12.Label19.Text = "P"
        ElseIf ComboBox19.Text = "A" Then
            Form12.Label19.Text = "A"
        ElseIf ComboBox19.Text = "L" Then
            Form12.Label19.Text = "L"
        End If
        If ComboBox20.Text = "P" Then
            Form12.Label20.Text = "P"
        ElseIf ComboBox20.Text = "A" Then
            Form12.Label20.Text = "A"
        ElseIf ComboBox20.Text = "L" Then
            Form12.Label20.Text = "L"
        End If
        If ComboBox21.Text = "P" Then
            Form12.Label21.Text = "P"
        ElseIf ComboBox21.Text = "A" Then
            Form12.Label21.Text = "A"
        ElseIf ComboBox21.Text = "L" Then
            Form12.Label21.Text = "L"
        End If
        If ComboBox22.Text = "P" Then
            Form12.Label22.Text = "P"
        ElseIf ComboBox22.Text = "A" Then
            Form12.Label22.Text = "A"
        ElseIf ComboBox22.Text = "L" Then
            Form12.Label22.Text = "L"
        End If
        If ComboBox23.Text = "P" Then
            Form12.Label23.Text = "P"
        ElseIf ComboBox23.Text = "A" Then
            Form12.Label23.Text = "A"
        ElseIf ComboBox23.Text = "L" Then
            Form12.Label23.Text = "L"
        End If
        If ComboBox24.Text = "P" Then
            Form12.Label24.Text = "P"
        ElseIf ComboBox24.Text = "A" Then
            Form12.Label24.Text = "A"
        ElseIf ComboBox24.Text = "L" Then
            Form12.Label24.Text = "L"
        End If
        If ComboBox25.Text = "P" Then
            Form12.Label25.Text = "P"
        ElseIf ComboBox25.Text = "A" Then
            Form12.Label25.Text = "A"
        ElseIf ComboBox25.Text = "L" Then
            Form12.Label25.Text = "L"
        End If
        If ComboBox26.Text = "P" Then
            Form12.Label26.Text = "P"
        ElseIf ComboBox26.Text = "A" Then
            Form12.Label26.Text = "A"
        ElseIf ComboBox26.Text = "L" Then
            Form12.Label26.Text = "L"
        End If
        If ComboBox27.Text = "P" Then
            Form12.Label27.Text = "P"
        ElseIf ComboBox27.Text = "A" Then
            Form12.Label27.Text = "A"
        ElseIf ComboBox27.Text = "L" Then
            Form12.Label27.Text = "L"
        End If
        If ComboBox28.Text = "P" Then
            Form12.Label28.Text = "P"
        ElseIf ComboBox28.Text = "A" Then
            Form12.Label28.Text = "A"
        ElseIf ComboBox28.Text = "L" Then
            Form12.Label28.Text = "L"
        End If
        If ComboBox29.Text = "P" Then
            Form12.Label29.Text = "P"
        ElseIf ComboBox29.Text = "A" Then
            Form12.Label29.Text = "A"
        ElseIf ComboBox29.Text = "L" Then
            Form12.Label29.Text = "L"
        End If
        If ComboBox30.Text = "P" Then
            Form12.Label30.Text = "P"
        ElseIf ComboBox30.Text = "A" Then
            Form12.Label30.Text = "A"
        ElseIf ComboBox30.Text = "L" Then
            Form12.Label30.Text = "L"
        End If
        If ComboBox31.Text = "P" Then
            Form12.Label31.Text = "P"
        ElseIf ComboBox31.Text = "A" Then
            Form12.Label31.Text = "A"
        ElseIf ComboBox31.Text = "L" Then
            Form12.Label31.Text = "L"
        End If
        If ComboBox32.Text = "P" Then
            Form12.Label32.Text = "P"
        ElseIf ComboBox32.Text = "A" Then
            Form12.Label32.Text = "A"
        ElseIf ComboBox32.Text = "L" Then
            Form12.Label32.Text = "L"
        End If
        If ComboBox33.Text = "P" Then
            Form12.Label33.Text = "P"
        ElseIf ComboBox33.Text = "A" Then
            Form12.Label33.Text = "A"
        ElseIf ComboBox33.Text = "L" Then
            Form12.Label33.Text = "L"
        End If
        If ComboBox34.Text = "P" Then
            Form12.Label34.Text = "P"
        ElseIf ComboBox34.Text = "A" Then
            Form12.Label34.Text = "A"
        ElseIf ComboBox34.Text = "L" Then
            Form12.Label34.Text = "L"
        End If
        If ComboBox35.Text = "P" Then
            Form12.Label35.Text = "P"
        ElseIf ComboBox35.Text = "A" Then
            Form12.Label35.Text = "A"
        ElseIf ComboBox35.Text = "L" Then
            Form12.Label35.Text = "L"
        End If
        If ComboBox36.Text = "P" Then
            Form12.Label36.Text = "P"
        ElseIf ComboBox36.Text = "A" Then
            Form12.Label36.Text = "A"
        ElseIf ComboBox36.Text = "L" Then
            Form12.Label36.Text = "L"
        End If
        If ComboBox37.Text = "P" Then
            Form12.Label37.Text = "P"
        ElseIf ComboBox37.Text = "A" Then
            Form12.Label37.Text = "A"
        ElseIf ComboBox37.Text = "L" Then
            Form12.Label37.Text = "L"
        End If
        If ComboBox38.Text = "P" Then
            Form12.Label38.Text = "P"
        ElseIf ComboBox38.Text = "A" Then
            Form12.Label38.Text = "A"
        ElseIf ComboBox38.Text = "L" Then
            Form12.Label38.Text = "L"
        End If
        If ComboBox39.Text = "P" Then
            Form12.Label39.Text = "P"
        ElseIf ComboBox39.Text = "A" Then
            Form12.Label39.Text = "A"
        ElseIf ComboBox39.Text = "L" Then
            Form12.Label39.Text = "L"
        End If
        If ComboBox40.Text = "P" Then
            Form12.Label40.Text = "P"
        ElseIf ComboBox40.Text = "A" Then
            Form12.Label40.Text = "A"
        ElseIf ComboBox40.Text = "L" Then
            Form12.Label40.Text = "L"
        End If



            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\attend.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        str = "Insert into attendance values('" + Label5.Text + "','" + comboBox1.Text + "','" + Format(Now, "dd-MMM-yyyy") + "','" + Form12.Label2.Text + "','" + Form12.Label3.Text + "','" + Form12.Label4.Text + "','" + Form12.Label5.Text + "','" + Form12.Label6.Text + "','" + Form12.Label7.Text + "','" + Form12.Label8.Text + "','" + Form12.Label9.Text + "','" + Form12.Label10.Text + "','" + Form12.Label11.Text + "','" + Form12.Label12.Text + "','" + Form12.Label13.Text + "','" + Form12.Label14.Text + "','" + Form12.Label15.Text + "','" + Form12.Label16.Text + "','" + Form12.Label17.Text + "','" + Form12.Label18.Text + "','" + Form12.Label19.Text + "','" + Form12.Label20.Text + "','" + Form12.Label21.Text + "','" + Form12.Label22.Text + "','" + Form12.Label23.Text + "','" + Form12.Label24.Text + "','" + Form12.Label25.Text + "','" + Form12.Label26.Text + "','" + Form12.Label27.Text + "','" + Form12.Label28.Text + "','" + Form12.Label29.Text + "','" + Form12.Label30.Text + "','" + Form12.Label31.Text + "','" + Form12.Label32.Text + "','" + Form12.Label33.Text + "','" + Form12.Label34.Text + "','" + Form12.Label35.Text + "','" + Form12.Label36.Text + "','" + Form12.Label37.Text + "','" + Form12.Label38.Text + "','" + Form12.Label39.Text + "','" + Form12.Label40.Text + "','" + Form12.Label1.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Student Attendance Inserted Successfully..")

        End If





        Me.Label1.Text = Format(Now, "dd-MMM-yyyy")

        ComboBox2.Text = "P"
        ComboBox3.Text = "P"
        ComboBox4.Text = "P"
        ComboBox5.Text = "P"
        ComboBox6.Text = "P"
        ComboBox7.Text = "P"
        ComboBox8.Text = "P"
        ComboBox9.Text = "P"
        ComboBox10.Text = "P"
        ComboBox11.Text = "P"
        ComboBox12.Text = "P"
        ComboBox13.Text = "P"
        ComboBox14.Text = "P"
        ComboBox15.Text = "P"
        ComboBox16.Text = "P"
        ComboBox17.Text = "P"
        ComboBox18.Text = "P"
        ComboBox19.Text = "P"
        ComboBox20.Text = "P"
        ComboBox21.Text = "P"
        ComboBox22.Text = "P"
        ComboBox23.Text = "P"
        ComboBox24.Text = "P"
        ComboBox25.Text = "P"
        ComboBox26.Text = "P"
        ComboBox27.Text = "P"
        ComboBox28.Text = "P"
        ComboBox29.Text = "P"
        ComboBox30.Text = "P"
        ComboBox31.Text = "P"
        ComboBox32.Text = "P"
        ComboBox33.Text = "P"
        ComboBox34.Text = "P"
        ComboBox35.Text = "P"
        ComboBox36.Text = "P"
        ComboBox37.Text = "P"
        ComboBox38.Text = "P"
        ComboBox39.Text = "P"
        ComboBox40.Text = "P"
        ComboBox41.Text = "P"
        comboBox1.Text = "--Select--"
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        comboBox1.Text = "--Select--"


        ComboBox2.Text = "P"
        ComboBox3.Text = "P"
        ComboBox4.Text = "P"
        ComboBox5.Text = "P"
        ComboBox6.Text = "P"
        ComboBox7.Text = "P"
        ComboBox8.Text = "P"
        ComboBox9.Text = "P"
        ComboBox10.Text = "P"
        ComboBox11.Text = "P"
        ComboBox12.Text = "P"
        ComboBox13.Text = "P"
        ComboBox14.Text = "P"
        ComboBox15.Text = "P"
        ComboBox16.Text = "P"
        ComboBox17.Text = "P"
        ComboBox18.Text = "P"
        ComboBox19.Text = "P"
        ComboBox20.Text = "P"
        ComboBox21.Text = "P"
        ComboBox22.Text = "P"
        ComboBox23.Text = "P"
        ComboBox24.Text = "P"
        ComboBox25.Text = "P"
        ComboBox26.Text = "P"
        ComboBox27.Text = "P"
        ComboBox28.Text = "P"
        ComboBox29.Text = "P"
        ComboBox30.Text = "P"
        ComboBox31.Text = "P"
        ComboBox32.Text = "P"
        ComboBox33.Text = "P"
        ComboBox34.Text = "P"
        ComboBox35.Text = "P"
        ComboBox36.Text = "P"
        ComboBox37.Text = "P"
        ComboBox38.Text = "P"
        ComboBox39.Text = "P"
        ComboBox40.Text = "P"
        ComboBox41.Text = "P"

        Me.Hide()
        Form3.Show()
    End Sub
End Class
