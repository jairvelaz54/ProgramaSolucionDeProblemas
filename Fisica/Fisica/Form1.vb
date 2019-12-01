Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Dim form2 As New Form2
            form2.Show()
            Me.Hide()

        End If
    End Sub
End Class
