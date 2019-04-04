<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.add_client = New System.Windows.Forms.Button()
        Me.add_car = New System.Windows.Forms.Button()
        Me.make_rental = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'add_client
        '
        Me.add_client.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_client.Location = New System.Drawing.Point(12, 25)
        Me.add_client.Name = "add_client"
        Me.add_client.Size = New System.Drawing.Size(206, 152)
        Me.add_client.TabIndex = 0
        Me.add_client.Text = "ADD CLIENT"
        Me.add_client.UseVisualStyleBackColor = True
        '
        'add_car
        '
        Me.add_car.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_car.Location = New System.Drawing.Point(582, 25)
        Me.add_car.Name = "add_car"
        Me.add_car.Size = New System.Drawing.Size(206, 152)
        Me.add_car.TabIndex = 1
        Me.add_car.Text = "ADD CAR"
        Me.add_car.UseVisualStyleBackColor = True
        '
        'make_rental
        '
        Me.make_rental.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.make_rental.ForeColor = System.Drawing.SystemColors.WindowText
        Me.make_rental.Location = New System.Drawing.Point(245, 233)
        Me.make_rental.Name = "make_rental"
        Me.make_rental.Size = New System.Drawing.Size(321, 152)
        Me.make_rental.TabIndex = 2
        Me.make_rental.Text = "MAKE A RENTAL"
        Me.make_rental.UseVisualStyleBackColor = True
        '
        'welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.make_rental)
        Me.Controls.Add(Me.add_car)
        Me.Controls.Add(Me.add_client)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AYZAN"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents add_client As Button
    Friend WithEvents add_car As Button
    Friend WithEvents make_rental As Button
End Class
