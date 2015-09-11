Public Class Form1

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(" los " & Txtnum.Text & " Primeros numeros de la serie son: " & fib(), "fibonacci", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Function fib() As String
        Dim i, ant, act, sig As Integer
        Dim f As String = ""
        ant = 0
        sig = 1
        For i = 1 To txtnum.Text
            act = ant
            f = f & " " & ant
            ant = sig + ant
            sig = act

        Next
        Return (f)
    End Function
End Class
