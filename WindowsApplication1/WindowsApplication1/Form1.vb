Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        Dim resultado As Integer
        Try

            a = txtbox1.Text
            b = txtbox2.Text
            c = txtbox3.Text

            resultado = a * (b + c)
            MsgBox(resultado, MsgBoxStyle.Information, "LABORATORIO 3")
        Catch ex As Exception
            MsgBox("No es un numero", MsgBoxStyle.Critical)

        End Try



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub
End Class
