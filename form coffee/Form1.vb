Public Class Form1
    Dim price As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        price = 0
        If RadioButton1.Checked Then
            price = 1.0
            If RadioButton2.Checked Then
                price = 1.5
            ElseIf price = 2.0 Then
            End If
        End If
        If CheckBox1.Checked = True Then
            price = price + 0.5
        End If
        Form2.Show()
        Form2.Label4 = price
    End Sub
End Class
