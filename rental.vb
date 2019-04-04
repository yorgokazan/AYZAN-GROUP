Public Class rental
    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)

    End Sub

    Private Sub rental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AyzanDataSet.rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.AyzanDataSet.rental)
        'TODO: This line of code loads data into the 'AyzanDataSet.price' table. You can move, or remove it, as needed.
        Me.PriceTableAdapter.Fill(Me.AyzanDataSet.price)
        'TODO: This line of code loads data into the 'AyzanDataSet.car' table. You can move, or remove it, as needed.
        Me.CarTableAdapter.Fill(Me.AyzanDataSet.car)
        'TODO: This line of code loads data into the 'AyzanDataSet.client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.AyzanDataSet.client)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ClientBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.CarBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.PriceBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ClientBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.CarBindingSource.MoveNext()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.PriceBindingSource.MoveNext()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.RentalBindingSource.AddNew()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Validate()
        Me.RentalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.RentalBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.RentalBindingSource.MovePrevious()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.RentalBindingSource.MoveNext()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.RentalBindingSource.MoveFirst()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.RentalBindingSource.MoveLast()

    End Sub
End Class