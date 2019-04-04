Public Class client
    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)

    End Sub

    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AyzanDataSet.client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.AyzanDataSet.client)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ClientBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ClientBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ClientBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ClientBindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.ClientBindingSource.MoveFirst()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.ClientBindingSource.MoveLast()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AyzanDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub
End Class