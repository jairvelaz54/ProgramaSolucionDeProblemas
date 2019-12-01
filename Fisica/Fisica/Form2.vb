Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form1 As New Form1
        form1.Close()
        Panel1.Visible = False
        Panel3.Visible = False


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Panel1.Visible = True

        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim distancia As Double
            Dim tiempo As Double
            Dim velocidad As Double
            distancia = CDbl(TextBox1.Text)
            tiempo = CDbl(TextBox2.Text)

            velocidad = distancia / tiempo
            Dim d, t, v
            d = CStr(distancia)
            t = CStr(tiempo)
            v = CStr(velocidad)
            RichTextBox1.Text = "Formula" + "(v=d/t)" + vbLf + "v=?" + vbLf + "t=" + t + vbLf + "d=" + d + vbLf + "v=" + v + "m/s"
        Catch ex As Exception
            MsgBox("No ingrese letras")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End Try



    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Try
            If RadioButton5.Checked = True Then
                Dim con, conver As Double
                Dim conv As String
                con = CDbl(TextBox3.Text)
                conver = con * 1000
                conv = CStr(conver)
                Label5.Text = conv
            Else
                Label5.Text = ""
            End If
        Catch ex As Exception
            MsgBox("No ingrese letras")
            RadioButton5.Checked = False

        End Try

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Dim con, conver As Double
            Dim conv As String
            con = CDbl(TextBox3.Text)
            conver = con * 60
            conv = CStr(conver)
            Label5.Text = conv
        Else
            Label5.Text = ""
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            Dim con, conver As Double
            Dim conv As String
            con = CDbl(TextBox3.Text)
            conver = con / 3.6
            conv = CStr(conver)
            Label5.Text = conv
        Else
            Label5.Text = ""
        End If
    End Sub
    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Dim con, conver As Double
            Dim conv As String
            con = CDbl(TextBox3.Text)
            conver = con / 60
            conv = CStr(conver)
            Label5.Text = conv
        Else
            Label5.Text = ""
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Panel3.Visible = True

        Else
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim velocidad, tiempo, distancia As Double
            Dim v, t, d As String
            velocidad = CDbl(TextBox4.Text)
            tiempo = CDbl(TextBox5.Text)
            distancia = velocidad * tiempo
            v = CStr(velocidad)
            t = CStr(tiempo)
            d = CStr(distancia)
            RichTextBox2.Text = "Formula" + vbLf + "d=vt" + vbLf + "d=?" + vbLf + "t=" + t + vbLf + "v=" + v + "km/h" + vbLf + "d=" + v + "*" + t + vbLf + "Resultado" + vbLf + "d=" + d + "KM"
        Catch ex As Exception
            MsgBox("No ingrese letras")
            TextBox4.Text = ""
            TextBox5.Text = ""
        End Try
    End Sub




End Class