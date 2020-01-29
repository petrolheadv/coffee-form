Public Class Form2
    Public Shared Property Cost As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.RadioButton1.Checked Then
            Label2.Text = "Small Coffe"
            If Form1.RadioButton2.Checked Then
                Label2.Text = "Meduim Coffee"
            Else
                Label2.Text = "Large Coffee"
            End If
        End If
        Label4 = Form1.price
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class