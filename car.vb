Public Class car
    Private Sub CarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)

    End Sub

    Private Sub car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AyzanDataSet.price' table. You can move, or remove it, as needed.
        Me.PriceTableAdapter.Fill(Me.AyzanDataSet.price)
        'TODO: This line of code loads data into the 'AyzanDataSet.model' table. You can move, or remove it, as needed.
        Me.ModelTableAdapter.Fill(Me.AyzanDataSet.model)
        'TODO: This line of code loads data into the 'AyzanDataSet.car' table. You can move, or remove it, as needed.
        Me.CarTableAdapter.Fill(Me.AyzanDataSet.car)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CarBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.CarBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.CarBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.CarBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.CarBindingSource.MoveFirst()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.CarBindingSource.MoveLast()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.CarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub
End Class