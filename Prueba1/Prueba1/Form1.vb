Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Try
            num1 = txtbox1.Text
            MsgBox(num1, MsgBoxStyle.Information, "Lectura de Numero entero"
                                             )
        Catch ex As Exception
            MsgBox("NO ES UN NUMERO ENTERO", MsgBoxStyle.Critical, "Alerta")
            MsgBox(ex.ToString)
        End Try










    End Sub
End Class
