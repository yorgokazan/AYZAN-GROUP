<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modelandprice
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
        Dim Model_idLabel As System.Windows.Forms.Label
        Dim Model_nameLabel As System.Windows.Forms.Label
        Dim Model_classificationLabel As System.Windows.Forms.Label
        Dim P_idLabel As System.Windows.Forms.Label
        Dim Per_dayLabel As System.Windows.Forms.Label
        Dim Per_monthLabel As System.Windows.Forms.Label
        Dim Per_yearLabel As System.Windows.Forms.Label
        Me.AyzanDataSet = New AYZAN.ayzanDataSet()
        Me.ModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelTableAdapter = New AYZAN.ayzanDataSetTableAdapters.modelTableAdapter()
        Me.TableAdapterManager = New AYZAN.ayzanDataSetTableAdapters.TableAdapterManager()
        Me.Model_idTextBox = New System.Windows.Forms.TextBox()
        Me.Model_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Model_classificationTextBox = New System.Windows.Forms.TextBox()
        Me.PriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceTableAdapter = New AYZAN.ayzanDataSetTableAdapters.priceTableAdapter()
        Me.P_idTextBox = New System.Windows.Forms.TextBox()
        Me.Per_dayTextBox = New System.Windows.Forms.TextBox()
        Me.Per_monthTextBox = New System.Windows.Forms.TextBox()
        Me.Per_yearTextBox = New System.Windows.Forms.TextBox()
        Me.ModelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Model_idLabel = New System.Windows.Forms.Label()
        Model_nameLabel = New System.Windows.Forms.Label()
        Model_classificationLabel = New System.Windows.Forms.Label()
        P_idLabel = New System.Windows.Forms.Label()
        Per_dayLabel = New System.Windows.Forms.Label()
        Per_monthLabel = New System.Windows.Forms.Label()
        Per_yearLabel = New System.Windows.Forms.Label()
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AyzanDataSet
        '
        Me.AyzanDataSet.DataSetName = "ayzanDataSet"
        Me.AyzanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModelBindingSource
        '
        Me.ModelBindingSource.DataMember = "model"
        Me.ModelBindingSource.DataSource = Me.AyzanDataSet
        '
        'ModelTableAdapter
        '
        Me.ModelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.carTableAdapter = Nothing
        Me.TableAdapterManager.clientTableAdapter = Nothing
        Me.TableAdapterManager.modelTableAdapter = Me.ModelTableAdapter
        Me.TableAdapterManager.priceTableAdapter = Me.PriceTableAdapter
        Me.TableAdapterManager.rentalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AYZAN.ayzanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Model_idLabel
        '
        Model_idLabel.AutoSize = True
        Model_idLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Model_idLabel.Location = New System.Drawing.Point(12, 21)
        Model_idLabel.Name = "Model_idLabel"
        Model_idLabel.Size = New System.Drawing.Size(108, 26)
        Model_idLabel.TabIndex = 1
        Model_idLabel.Text = "model id:"
        '
        'Model_idTextBox
        '
        Me.Model_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModelBindingSource, "model_id", True))
        Me.Model_idTextBox.Location = New System.Drawing.Point(238, 25)
        Me.Model_idTextBox.Name = "Model_idTextBox"
        Me.Model_idTextBox.Size = New System.Drawing.Size(174, 22)
        Me.Model_idTextBox.TabIndex = 2
        '
        'Model_nameLabel
        '
        Model_nameLabel.AutoSize = True
        Model_nameLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Model_nameLabel.Location = New System.Drawing.Point(12, 74)
        Model_nameLabel.Name = "Model_nameLabel"
        Model_nameLabel.Size = New System.Drawing.Size(143, 26)
        Model_nameLabel.TabIndex = 3
        Model_nameLabel.Text = "model name:"
        '
        'Model_nameTextBox
        '
        Me.Model_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModelBindingSource, "model_name", True))
        Me.Model_nameTextBox.Location = New System.Drawing.Point(238, 78)
        Me.Model_nameTextBox.Name = "Model_nameTextBox"
        Me.Model_nameTextBox.Size = New System.Drawing.Size(174, 22)
        Me.Model_nameTextBox.TabIndex = 4
        '
        'Model_classificationLabel
        '
        Model_classificationLabel.AutoSize = True
        Model_classificationLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Model_classificationLabel.Location = New System.Drawing.Point(12, 126)
        Model_classificationLabel.Name = "Model_classificationLabel"
        Model_classificationLabel.Size = New System.Drawing.Size(220, 26)
        Model_classificationLabel.TabIndex = 5
        Model_classificationLabel.Text = "model classification:"
        '
        'Model_classificationTextBox
        '
        Me.Model_classificationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModelBindingSource, "model_classification", True))
        Me.Model_classificationTextBox.Location = New System.Drawing.Point(238, 130)
        Me.Model_classificationTextBox.Name = "Model_classificationTextBox"
        Me.Model_classificationTextBox.Size = New System.Drawing.Size(174, 22)
        Me.Model_classificationTextBox.TabIndex = 6
        '
        'PriceBindingSource
        '
        Me.PriceBindingSource.DataMember = "price"
        Me.PriceBindingSource.DataSource = Me.AyzanDataSet
        '
        'PriceTableAdapter
        '
        Me.PriceTableAdapter.ClearBeforeFill = True
        '
        'P_idLabel
        '
        P_idLabel.AutoSize = True
        P_idLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        P_idLabel.Location = New System.Drawing.Point(12, 306)
        P_idLabel.Name = "P_idLabel"
        P_idLabel.Size = New System.Drawing.Size(59, 26)
        P_idLabel.TabIndex = 7
        P_idLabel.Text = "p id:"
        '
        'P_idTextBox
        '
        Me.P_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PriceBindingSource, "p_id", True))
        Me.P_idTextBox.Location = New System.Drawing.Point(145, 306)
        Me.P_idTextBox.Name = "P_idTextBox"
        Me.P_idTextBox.Size = New System.Drawing.Size(267, 22)
        Me.P_idTextBox.TabIndex = 8
        '
        'Per_dayLabel
        '
        Per_dayLabel.AutoSize = True
        Per_dayLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Per_dayLabel.Location = New System.Drawing.Point(12, 346)
        Per_dayLabel.Name = "Per_dayLabel"
        Per_dayLabel.Size = New System.Drawing.Size(98, 26)
        Per_dayLabel.TabIndex = 9
        Per_dayLabel.Text = "per day:"
        '
        'Per_dayTextBox
        '
        Me.Per_dayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PriceBindingSource, "per_day", True))
        Me.Per_dayTextBox.Location = New System.Drawing.Point(145, 346)
        Me.Per_dayTextBox.Name = "Per_dayTextBox"
        Me.Per_dayTextBox.Size = New System.Drawing.Size(267, 22)
        Me.Per_dayTextBox.TabIndex = 10
        '
        'Per_monthLabel
        '
        Per_monthLabel.AutoSize = True
        Per_monthLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Per_monthLabel.Location = New System.Drawing.Point(12, 393)
        Per_monthLabel.Name = "Per_monthLabel"
        Per_monthLabel.Size = New System.Drawing.Size(126, 26)
        Per_monthLabel.TabIndex = 11
        Per_monthLabel.Text = "per month:"
        '
        'Per_monthTextBox
        '
        Me.Per_monthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PriceBindingSource, "per_month", True))
        Me.Per_monthTextBox.Location = New System.Drawing.Point(145, 393)
        Me.Per_monthTextBox.Name = "Per_monthTextBox"
        Me.Per_monthTextBox.Size = New System.Drawing.Size(267, 22)
        Me.Per_monthTextBox.TabIndex = 12
        '
        'Per_yearLabel
        '
        Per_yearLabel.AutoSize = True
        Per_yearLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Per_yearLabel.Location = New System.Drawing.Point(12, 443)
        Per_yearLabel.Name = "Per_yearLabel"
        Per_yearLabel.Size = New System.Drawing.Size(107, 26)
        Per_yearLabel.TabIndex = 13
        Per_yearLabel.Text = "per year:"
        '
        'Per_yearTextBox
        '
        Me.Per_yearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PriceBindingSource, "per_year", True))
        Me.Per_yearTextBox.Location = New System.Drawing.Point(145, 443)
        Me.Per_yearTextBox.Name = "Per_yearTextBox"
        Me.Per_yearTextBox.Size = New System.Drawing.Size(267, 22)
        Me.Per_yearTextBox.TabIndex = 14
        '
        'ModelDataGridView
        '
        Me.ModelDataGridView.AllowUserToAddRows = False
        Me.ModelDataGridView.AllowUserToDeleteRows = False
        Me.ModelDataGridView.AutoGenerateColumns = False
        Me.ModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ModelDataGridView.DataSource = Me.ModelBindingSource
        Me.ModelDataGridView.Location = New System.Drawing.Point(442, 21)
        Me.ModelDataGridView.Name = "ModelDataGridView"
        Me.ModelDataGridView.ReadOnly = True
        Me.ModelDataGridView.RowTemplate.Height = 24
        Me.ModelDataGridView.Size = New System.Drawing.Size(487, 133)
        Me.ModelDataGridView.TabIndex = 14
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
        'PriceDataGridView
        '
        Me.PriceDataGridView.AllowUserToAddRows = False
        Me.PriceDataGridView.AllowUserToDeleteRows = False
        Me.PriceDataGridView.AutoGenerateColumns = False
        Me.PriceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PriceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PriceDataGridView.DataSource = Me.PriceBindingSource
        Me.PriceDataGridView.Location = New System.Drawing.Point(442, 306)
        Me.PriceDataGridView.Name = "PriceDataGridView"
        Me.PriceDataGridView.ReadOnly = True
        Me.PriceDataGridView.RowTemplate.Height = 24
        Me.PriceDataGridView.Size = New System.Drawing.Size(487, 165)
        Me.PriceDataGridView.TabIndex = 15
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 55)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "QUIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(442, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 55)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(625, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 55)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(804, 170)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 55)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(442, 490)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 55)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "ADD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(625, 490)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(125, 55)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "DELETE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(804, 490)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(125, 55)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "SAVE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'modelandprice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(941, 594)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PriceDataGridView)
        Me.Controls.Add(Me.ModelDataGridView)
        Me.Controls.Add(P_idLabel)
        Me.Controls.Add(Me.P_idTextBox)
        Me.Controls.Add(Per_dayLabel)
        Me.Controls.Add(Me.Per_dayTextBox)
        Me.Controls.Add(Per_monthLabel)
        Me.Controls.Add(Me.Per_monthTextBox)
        Me.Controls.Add(Per_yearLabel)
        Me.Controls.Add(Me.Per_yearTextBox)
        Me.Controls.Add(Model_idLabel)
        Me.Controls.Add(Me.Model_idTextBox)
        Me.Controls.Add(Model_nameLabel)
        Me.Controls.Add(Me.Model_nameTextBox)
        Me.Controls.Add(Model_classificationLabel)
        Me.Controls.Add(Me.Model_classificationTextBox)
        Me.Name = "modelandprice"
        Me.Text = "modelandprice"
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AyzanDataSet As ayzanDataSet
    Friend WithEvents ModelBindingSource As BindingSource
    Friend WithEvents ModelTableAdapter As ayzanDataSetTableAdapters.modelTableAdapter
    Friend WithEvents TableAdapterManager As ayzanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Model_idTextBox As TextBox
    Friend WithEvents Model_nameTextBox As TextBox
    Friend WithEvents Model_classificationTextBox As TextBox
    Friend WithEvents PriceTableAdapter As ayzanDataSetTableAdapters.priceTableAdapter
    Friend WithEvents PriceBindingSource As BindingSource
    Friend WithEvents P_idTextBox As TextBox
    Friend WithEvents Per_dayTextBox As TextBox
    Friend WithEvents Per_monthTextBox As TextBox
    Friend WithEvents Per_yearTextBox As TextBox
    Friend WithEvents ModelDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
