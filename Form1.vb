Public Class welcome
    Private Sub add_client_Click(sender As Object, e As EventArgs) Handles add_client.Click
        client.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub add_car_Click(sender As Object, e As EventArgs) Handles add_car.Click
        car.Show()

    End Sub

    Private Sub make_rental_Click(sender As Object, e As EventArgs) Handles make_rental.Click
        rental.Show()

    End Sub
End Class
