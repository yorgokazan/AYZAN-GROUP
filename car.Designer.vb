<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class car
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Chassis_idLabel As System.Windows.Forms.Label
        Dim Car_nameLabel As System.Windows.Forms.Label
        Dim Model_idLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim P_idLabel As System.Windows.Forms.Label
        Me.AyzanDataSet = New AYZAN.ayzanDataSet()
        Me.CarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarTableAdapter = New AYZAN.ayzanDataSetTableAdapters.carTableAdapter()
        Me.TableAdapterManager = New AYZAN.ayzanDataSetTableAdapters.TableAdapterManager()
        Me.ModelTableAdapter = New AYZAN.ayzanDataSetTableAdapters.modelTableAdapter()
        Me.PriceTableAdapter = New AYZAN.ayzanDataSetTableAdapters.priceTableAdapter()
        Me.Chassis_idTextBox = New System.Windows.Forms.TextBox()
        Me.Car_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Model_idTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.P_idTextBox = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button10 = New System.Windows.Forms.Button()
        Chassis_idLabel = New System.Windows.Forms.Label()
        Car_nameLabel = New System.Windows.Forms.Label()
        Model_idLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        P_idLabel = New System.Windows.Forms.Label()
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chassis_idLabel
        '
        Chassis_idLabel.AutoSize = True
        Chassis_idLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chassis_idLabel.Location = New System.Drawing.Point(16, 29)
        Chassis_idLabel.Name = "Chassis_idLabel"
        Chassis_idLabel.Size = New System.Drawing.Size(116, 26)
        Chassis_idLabel.TabIndex = 1
        Chassis_idLabel.Text = "chassis id:"
        '
        'Car_nameLabel
        '
        Car_nameLabel.AutoSize = True
        Car_nameLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_nameLabel.Location = New System.Drawing.Point(16, 57)
        Car_nameLabel.Name = "Car_nameLabel"
        Car_nameLabel.Size = New System.Drawing.Size(115, 26)
        Car_nameLabel.TabIndex = 3
        Car_nameLabel.Text = "car name:"
        '
        'Model_idLabel
        '
        Model_idLabel.AutoSize = True
        Model_idLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Model_idLabel.Location = New System.Drawing.Point(16, 85)
        Model_idLabel.Name = "Model_idLabel"
        Model_idLabel.Size = New System.Drawing.Size(108, 26)
        Model_idLabel.TabIndex = 5
        Model_idLabel.Text = "model id:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColorLabel.Location = New System.Drawing.Point(16, 113)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(73, 26)
        ColorLabel.TabIndex = 7
        ColorLabel.Text = "color:"
        '
        'P_idLabel
        '
        P_idLabel.AutoSize = True
        P_idLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        P_idLabel.Location = New System.Drawing.Point(16, 141)
        P_idLabel.Name = "P_idLabel"
        P_idLabel.Size = New System.Drawing.Size(59, 26)
        P_idLabel.TabIndex = 9
        P_idLabel.Text = "p id:"
        '
        'AyzanDataSet
        '
        Me.AyzanDataSet.DataSetName = "ayzanDataSet"
        Me.AyzanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarBindingSource
        '
        Me.CarBindingSource.DataMember = "car"
        Me.CarBindingSource.DataSource = Me.AyzanDataSet
        '
        'CarTableAdapter
        '
        Me.CarTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.carTableAdapter = Me.CarTableAdapter
        Me.TableAdapterManager.clientTableAdapter = Nothing
        Me.TableAdapterManager.modelTableAdapter = Me.ModelTableAdapter
        Me.TableAdapterManager.priceTableAdapter = Me.PriceTableAdapter
        Me.TableAdapterManager.rentalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AYZAN.ayzanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ModelTableAdapter
        '
        Me.ModelTableAdapter.ClearBeforeFill = True
        '
        'PriceTableAdapter
        '
        Me.PriceTableAdapter.ClearBeforeFill = True
        '
        'Chassis_idTextBox
        '
        Me.Chassis_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "chassis_id", True))
        Me.Chassis_idTextBox.Location = New System.Drawing.Point(162, 33)
        Me.Chassis_idTextBox.Name = "Chassis_idTextBox"
        Me.Chassis_idTextBox.Size = New System.Drawing.Size(321, 22)
        Me.Chassis_idTextBox.TabIndex = 2
        '
        'Car_nameTextBox
        '
        Me.Car_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "car_name", True))
        Me.Car_nameTextBox.Location = New System.Drawing.Point(162, 61)
        Me.Car_nameTextBox.Name = "Car_nameTextBox"
        Me.Car_nameTextBox.Size = New System.Drawing.Size(321, 22)
        Me.Car_nameTextBox.TabIndex = 4
        '
        'Model_idTextBox
        '
        Me.Model_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "model_id", True))
        Me.Model_idTextBox.Location = New System.Drawing.Point(162, 89)
        Me.Model_idTextBox.Name = "Model_idTextBox"
        Me.Model_idTextBox.Size = New System.Drawing.Size(321, 22)
        Me.Model_idTextBox.TabIndex = 6
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(162, 117)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(321, 22)
        Me.ColorTextBox.TabIndex = 8
        '
        'P_idTextBox
        '
        Me.P_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "p_id", True))
        Me.P_idTextBox.Location = New System.Drawing.Point(162, 145)
        Me.P_idTextBox.Name = "P_idTextBox"
        Me.P_idTextBox.Size = New System.Drawing.Size(321, 22)
        Me.P_idTextBox.TabIndex = 10
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(687, 358)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(139, 57)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "CLOSE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(687, 281)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(139, 57)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "SAVE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(741, 164)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 57)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "LAST"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(575, 164)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 57)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "FIRST"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(741, 100)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 57)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(575, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 57)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "<<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(741, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 57)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(575, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 57)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ModelBindingSource
        '
        Me.ModelBindingSource.DataMember = "model"
        Me.ModelBindingSource.DataSource = Me.AyzanDataSet
        '
        'ModelDataGridView
        '
        Me.ModelDataGridView.AllowUserToAddRows = False
        Me.ModelDataGridView.AllowUserToDeleteRows = False
        Me.ModelDataGridView.AutoGenerateColumns = False
        Me.ModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ModelDataGridView.DataSource = Me.ModelBindingSource
        Me.ModelDataGridView.Location = New System.Drawing.Point(12, 192)
        Me.ModelDataGridView.Name = "ModelDataGridView"
        Me.ModelDataGridView.ReadOnly = True
        Me.ModelDataGridView.RowTemplate.Height = 24
        Me.ModelDataGridView.Size = New System.Drawing.Size(542, 106)
        Me.ModelDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "model_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "model_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "model_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "model_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "model_classification"
        Me.DataGridViewTextBoxColumn3.HeaderText = "model_classification"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(162, 304)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(156, 23)
        Me.Button9.TabIndex = 27
        Me.Button9.Text = "ADD MODEL"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'PriceBindingSource
        '
        Me.PriceBindingSource.DataMember = "price"
        Me.PriceBindingSource.DataSource = Me.AyzanDataSet
        '
        'PriceDataGridView
        '
        Me.PriceDataGridView.AllowUserToAddRows = False
        Me.PriceDataGridView.AllowUserToDeleteRows = False
        Me.PriceDataGridView.AutoGenerateColumns = False
        Me.PriceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PriceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PriceDataGridView.DataSource = Me.PriceBindingSource
        Me.PriceDataGridView.Location = New System.Drawing.Point(12, 366)
        Me.PriceDataGridView.Name = "PriceDataGridView"
        Me.PriceDataGridView.ReadOnly = True
        Me.PriceDataGridView.RowTemplate.Height = 24
        Me.PriceDataGridView.Size = New System.Drawing.Size(542, 114)
        Me.PriceDataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "p_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "p_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "per_day"
        Me.DataGridViewTextBoxColumn5.HeaderText = "per_day"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "per_month"
        Me.DataGridViewTextBoxColumn6.HeaderText = "per_month"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "per_year"
        Me.DataGridViewTextBoxColumn7.HeaderText = "per_year"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(162, 486)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(156, 23)
        Me.Button10.TabIndex = 28
        Me.Button10.Text = "ADD PRICES"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(915, 620)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.PriceDataGridView)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.ModelDataGridView)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Chassis_idLabel)
        Me.Controls.Add(Me.Chassis_idTextBox)
        Me.Controls.Add(Car_nameLabel)
        Me.Controls.Add(Me.Car_nameTextBox)
        Me.Controls.Add(Model_idLabel)
        Me.Controls.Add(Me.Model_idTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(P_idLabel)
        Me.Controls.Add(Me.P_idTextBox)
        Me.Name = "car"
        Me.Text = "car"
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AyzanDataSet As ayzanDataSet
    Friend WithEvents CarBindingSource As BindingSource
    Friend WithEvents CarTableAdapter As ayzanDataSetTableAdapters.carTableAdapter
    Friend WithEvents TableAdapterManager As ayzanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Chassis_idTextBox As TextBox
    Friend WithEvents Car_nameTextBox As TextBox
    Friend WithEvents Model_idTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents P_idTextBox As TextBox
    Friend WithEvents ModelTableAdapter As ayzanDataSetTableAdapters.modelTableAdapter
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ModelBindingSource As BindingSource
    Friend WithEvents ModelDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PriceTableAdapter As ayzanDataSetTableAdapters.priceTableAdapter
    Friend WithEvents Button9 As Button
    Friend WithEvents PriceBindingSource As BindingSource
    Friend WithEvents PriceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Button10 As Button
End Class
