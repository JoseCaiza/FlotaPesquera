Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ObjetoBarco As New FlotaPesquera.Negocio.Barco
        MessageBox.Show(ObjetoBarco.ConsultarTripulates(38))


    End Sub
End Class
