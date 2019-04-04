<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Me.components = New System.ComponentModel.Container()
        Dim Client_idLabel As System.Windows.Forms.Label
        Dim Client_nameLabel As System.Windows.Forms.Label
        Dim Client_addressLabel As System.Windows.Forms.Label
        Dim Client_telLabel As System.Windows.Forms.Label
        Dim Client_emailLabel As System.Windows.Forms.Label
        Me.AyzanDataSet = New AYZAN.ayzanDataSet()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New AYZAN.ayzanDataSetTableAdapters.clientTableAdapter()
        Me.TableAdapterManager = New AYZAN.ayzanDataSetTableAdapters.TableAdapterManager()
        Me.Client_idTextBox = New System.Windows.Forms.TextBox()
        Me.Client_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Client_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Client_telTextBox = New System.Windows.Forms.TextBox()
        Me.Client_emailTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ClientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Client_idLabel = New System.Windows.Forms.Label()
        Client_nameLabel = New System.Windows.Forms.Label()
        Client_addressLabel = New System.Windows.Forms.Label()
        Client_telLabel = New System.Windows.Forms.Label()
        Client_emailLabel = New System.Windows.Forms.Label()
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AyzanDataSet
        '
        Me.AyzanDataSet.DataSetName = "ayzanDataSet"
        Me.AyzanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.AyzanDataSet
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.carTableAdapter = Nothing
        Me.TableAdapterManager.clientTableAdapter = Me.ClientTableAdapter
        Me.TableAdapterManager.modelTableAdapter = Nothing
        Me.TableAdapterManager.priceTableAdapter = Nothing
        Me.TableAdapterManager.rentalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AYZAN.ayzanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Client_idLabel
        '
        Client_idLabel.AutoSize = True
        Client_idLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_idLabel.Location = New System.Drawing.Point(29, 32)
        Client_idLabel.Name = "Client_idLabel"
        Client_idLabel.Size = New System.Drawing.Size(103, 26)
        Client_idLabel.TabIndex = 1
        Client_idLabel.Text = "client id:"
        '
        'Client_idTextBox
        '
        Me.Client_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_id", True))
        Me.Client_idTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client_idTextBox.Location = New System.Drawing.Point(203, 25)
        Me.Client_idTextBox.Name = "Client_idTextBox"
        Me.Client_idTextBox.Size = New System.Drawing.Size(341, 27)
        Me.Client_idTextBox.TabIndex = 2
        '
        'Client_nameLabel
        '
        Client_nameLabel.AutoSize = True
        Client_nameLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_nameLabel.Location = New System.Drawing.Point(29, 67)
        Client_nameLabel.Name = "Client_nameLabel"
        Client_nameLabel.Size = New System.Drawing.Size(138, 26)
        Client_nameLabel.TabIndex = 3
        Client_nameLabel.Text = "client name:"
        '
        'Client_nameTextBox
        '
        Me.Client_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_name", True))
        Me.Client_nameTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client_nameTextBox.Location = New System.Drawing.Point(203, 61)
        Me.Client_nameTextBox.Name = "Client_nameTextBox"
        Me.Client_nameTextBox.Size = New System.Drawing.Size(341, 27)
        Me.Client_nameTextBox.TabIndex = 4
        '
        'Client_addressLabel
        '
        Client_addressLabel.AutoSize = True
        Client_addressLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_addressLabel.Location = New System.Drawing.Point(29, 102)
        Client_addressLabel.Name = "Client_addressLabel"
        Client_addressLabel.Size = New System.Drawing.Size(161, 26)
        Client_addressLabel.TabIndex = 5
        Client_addressLabel.Text = "client address:"
        '
        'Client_addressTextBox
        '
        Me.Client_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_address", True))
        Me.Client_addressTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client_addressTextBox.Location = New System.Drawing.Point(203, 97)
        Me.Client_addressTextBox.Name = "Client_addressTextBox"
        Me.Client_addressTextBox.Size = New System.Drawing.Size(341, 27)
        Me.Client_addressTextBox.TabIndex = 6
        '
        'Client_telLabel
        '
        Client_telLabel.AutoSize = True
        Client_telLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_telLabel.Location = New System.Drawing.Point(29, 139)
        Client_telLabel.Name = "Client_telLabel"
        Client_telLabel.Size = New System.Drawing.Size(109, 26)
        Client_telLabel.TabIndex = 7
        Client_telLabel.Text = "client tel:"
        '
        'Client_telTextBox
        '
        Me.Client_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_tel", True))
        Me.Client_telTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client_telTextBox.Location = New System.Drawing.Point(203, 133)
        Me.Client_telTextBox.Name = "Client_telTextBox"
        Me.Client_telTextBox.Size = New System.Drawing.Size(341, 27)
        Me.Client_telTextBox.TabIndex = 8
        '
        'Client_emailLabel
        '
        Client_emailLabel.AutoSize = True
        Client_emailLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_emailLabel.Location = New System.Drawing.Point(29, 174)
        Client_emailLabel.Name = "Client_emailLabel"
        Client_emailLabel.Size = New System.Drawing.Size(139, 26)
        Client_emailLabel.TabIndex = 9
        Client_emailLabel.Text = "client email:"
        '
        'Client_emailTextBox
        '
        Me.Client_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_email", True))
        Me.Client_emailTextBox.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client_emailTextBox.Location = New System.Drawing.Point(203, 169)
        Me.Client_emailTextBox.Name = "Client_emailTextBox"
        Me.Client_emailTextBox.Size = New System.Drawing.Size(341, 27)
        Me.Client_emailTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(578, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 57)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(744, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 57)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(578, 87)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 57)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "<<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(744, 87)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 57)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(578, 151)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 57)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "FIRST"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(744, 151)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 57)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "LAST"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ClientDataGridView
        '
        Me.ClientDataGridView.AutoGenerateColumns = False
        Me.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ClientDataGridView.DataSource = Me.ClientBindingSource
        Me.ClientDataGridView.Location = New System.Drawing.Point(61, 214)
        Me.ClientDataGridView.Name = "ClientDataGridView"
        Me.ClientDataGridView.RowTemplate.Height = 24
        Me.ClientDataGridView.Size = New System.Drawing.Size(539, 220)
        Me.ClientDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "client_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "client_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "client_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "client_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "client_address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "client_address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "client_tel"
        Me.DataGridViewTextBoxColumn4.HeaderText = "client_tel"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "client_email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "client_email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(690, 268)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(139, 57)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "SAVE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(690, 345)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(139, 57)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "CLOSE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(901, 533)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ClientDataGridView)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Client_idLabel)
        Me.Controls.Add(Me.Client_idTextBox)
        Me.Controls.Add(Client_nameLabel)
        Me.Controls.Add(Me.Client_nameTextBox)
        Me.Controls.Add(Client_addressLabel)
        Me.Controls.Add(Me.Client_addressTextBox)
        Me.Controls.Add(Client_telLabel)
        Me.Controls.Add(Me.Client_telTextBox)
        Me.Controls.Add(Client_emailLabel)
        Me.Controls.Add(Me.Client_emailTextBox)
        Me.Name = "client"
        Me.Text = "CLIENT"
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AyzanDataSet As ayzanDataSet
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents ClientTableAdapter As ayzanDataSetTableAdapters.clientTableAdapter
    Friend WithEvents TableAdapterManager As ayzanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Client_idTextBox As TextBox
    Friend WithEvents Client_nameTextBox As TextBox
    Friend WithEvents Client_addressTextBox As TextBox
    Friend WithEvents Client_telTextBox As TextBox
    Friend WithEvents Client_emailTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ClientDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
