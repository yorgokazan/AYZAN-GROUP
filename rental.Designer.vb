<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rental
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
        Dim Rental_numLabel As System.Windows.Forms.Label
        Dim Chassis_idLabel As System.Windows.Forms.Label
        Dim Client_idLabel As System.Windows.Forms.Label
        Dim Rental_dateLabel As System.Windows.Forms.Label
        Dim Rental_time_per_dayLabel As System.Windows.Forms.Label
        Dim Current_kmLabel As System.Windows.Forms.Label
        Dim R_totalLabel As System.Windows.Forms.Label
        Me.AyzanDataSet = New AYZAN.ayzanDataSet()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New AYZAN.ayzanDataSetTableAdapters.clientTableAdapter()
        Me.TableAdapterManager = New AYZAN.ayzanDataSetTableAdapters.TableAdapterManager()
        Me.ClientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarTableAdapter = New AYZAN.ayzanDataSetTableAdapters.carTableAdapter()
        Me.CarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceTableAdapter = New AYZAN.ayzanDataSetTableAdapters.priceTableAdapter()
        Me.PriceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalTableAdapter = New AYZAN.ayzanDataSetTableAdapters.rentalTableAdapter()
        Me.Rental_numTextBox = New System.Windows.Forms.TextBox()
        Me.Chassis_idTextBox = New System.Windows.Forms.TextBox()
        Me.Client_idTextBox = New System.Windows.Forms.TextBox()
        Me.Rental_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Rental_time_per_dayTextBox = New System.Windows.Forms.TextBox()
        Me.Current_kmTextBox = New System.Windows.Forms.TextBox()
        Me.R_totalTextBox = New System.Windows.Forms.TextBox()
        Me.RentalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Rental_numLabel = New System.Windows.Forms.Label()
        Chassis_idLabel = New System.Windows.Forms.Label()
        Client_idLabel = New System.Windows.Forms.Label()
        Rental_dateLabel = New System.Windows.Forms.Label()
        Rental_time_per_dayLabel = New System.Windows.Forms.Label()
        Current_kmLabel = New System.Windows.Forms.Label()
        R_totalLabel = New System.Windows.Forms.Label()
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.carTableAdapter = Me.CarTableAdapter
        Me.TableAdapterManager.clientTableAdapter = Me.ClientTableAdapter
        Me.TableAdapterManager.modelTableAdapter = Nothing
        Me.TableAdapterManager.priceTableAdapter = Me.PriceTableAdapter
        Me.TableAdapterManager.rentalTableAdapter = Me.RentalTableAdapter
        Me.TableAdapterManager.UpdateOrder = AYZAN.ayzanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientDataGridView
        '
        Me.ClientDataGridView.AllowUserToAddRows = False
        Me.ClientDataGridView.AllowUserToDeleteRows = False
        Me.ClientDataGridView.AutoGenerateColumns = False
        Me.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ClientDataGridView.DataSource = Me.ClientBindingSource
        Me.ClientDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.ClientDataGridView.Name = "ClientDataGridView"
        Me.ClientDataGridView.ReadOnly = True
        Me.ClientDataGridView.RowTemplate.Height = 24
        Me.ClientDataGridView.Size = New System.Drawing.Size(331, 140)
        Me.ClientDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "client_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "client_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "client_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "client_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
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
        'CarDataGridView
        '
        Me.CarDataGridView.AllowUserToAddRows = False
        Me.CarDataGridView.AllowUserToDeleteRows = False
        Me.CarDataGridView.AutoGenerateColumns = False
        Me.CarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7})
        Me.CarDataGridView.DataSource = Me.CarBindingSource
        Me.CarDataGridView.Location = New System.Drawing.Point(367, 12)
        Me.CarDataGridView.Name = "CarDataGridView"
        Me.CarDataGridView.ReadOnly = True
        Me.CarDataGridView.RowTemplate.Height = 24
        Me.CarDataGridView.Size = New System.Drawing.Size(397, 140)
        Me.CarDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "chassis_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "chassis_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "car_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "car_name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "p_id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "p_id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
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
        'PriceDataGridView
        '
        Me.PriceDataGridView.AllowUserToAddRows = False
        Me.PriceDataGridView.AllowUserToDeleteRows = False
        Me.PriceDataGridView.AutoGenerateColumns = False
        Me.PriceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PriceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PriceDataGridView.DataSource = Me.PriceBindingSource
        Me.PriceDataGridView.Location = New System.Drawing.Point(794, 12)
        Me.PriceDataGridView.Name = "PriceDataGridView"
        Me.PriceDataGridView.ReadOnly = True
        Me.PriceDataGridView.RowTemplate.Height = 24
        Me.PriceDataGridView.Size = New System.Drawing.Size(535, 140)
        Me.PriceDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "p_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "p_id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "per_day"
        Me.DataGridViewTextBoxColumn6.HeaderText = "per_day"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "per_month"
        Me.DataGridViewTextBoxColumn8.HeaderText = "per_month"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "per_year"
        Me.DataGridViewTextBoxColumn9.HeaderText = "per_year"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(264, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(367, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "<<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(689, 158)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(794, 158)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1254, 158)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = ">>"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'RentalBindingSource
        '
        Me.RentalBindingSource.DataMember = "rental"
        Me.RentalBindingSource.DataSource = Me.AyzanDataSet
        '
        'RentalTableAdapter
        '
        Me.RentalTableAdapter.ClearBeforeFill = True
        '
        'Rental_numLabel
        '
        Rental_numLabel.AutoSize = True
        Rental_numLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rental_numLabel.Location = New System.Drawing.Point(26, 203)
        Rental_numLabel.Name = "Rental_numLabel"
        Rental_numLabel.Size = New System.Drawing.Size(107, 23)
        Rental_numLabel.TabIndex = 9
        Rental_numLabel.Text = "rental num:"
        '
        'Rental_numTextBox
        '
        Me.Rental_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "rental_num", True))
        Me.Rental_numTextBox.Location = New System.Drawing.Point(12, 243)
        Me.Rental_numTextBox.Name = "Rental_numTextBox"
        Me.Rental_numTextBox.Size = New System.Drawing.Size(133, 22)
        Me.Rental_numTextBox.TabIndex = 10
        '
        'Chassis_idLabel
        '
        Chassis_idLabel.AutoSize = True
        Chassis_idLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chassis_idLabel.Location = New System.Drawing.Point(179, 203)
        Chassis_idLabel.Name = "Chassis_idLabel"
        Chassis_idLabel.Size = New System.Drawing.Size(95, 23)
        Chassis_idLabel.TabIndex = 11
        Chassis_idLabel.Text = "chassis id:"
        '
        'Chassis_idTextBox
        '
        Me.Chassis_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "chassis_id", True))
        Me.Chassis_idTextBox.Location = New System.Drawing.Point(151, 243)
        Me.Chassis_idTextBox.Name = "Chassis_idTextBox"
        Me.Chassis_idTextBox.Size = New System.Drawing.Size(155, 22)
        Me.Chassis_idTextBox.TabIndex = 12
        '
        'Client_idLabel
        '
        Client_idLabel.AutoSize = True
        Client_idLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_idLabel.Location = New System.Drawing.Point(343, 203)
        Client_idLabel.Name = "Client_idLabel"
        Client_idLabel.Size = New System.Drawing.Size(83, 23)
        Client_idLabel.TabIndex = 13
        Client_idLabel.Text = "client id:"
        '
        'Client_idTextBox
        '
        Me.Client_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "client_id", True))
        Me.Client_idTextBox.Location = New System.Drawing.Point(312, 243)
        Me.Client_idTextBox.Name = "Client_idTextBox"
        Me.Client_idTextBox.Size = New System.Drawing.Size(159, 22)
        Me.Client_idTextBox.TabIndex = 14
        '
        'Rental_dateLabel
        '
        Rental_dateLabel.AutoSize = True
        Rental_dateLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rental_dateLabel.Location = New System.Drawing.Point(543, 203)
        Rental_dateLabel.Name = "Rental_dateLabel"
        Rental_dateLabel.Size = New System.Drawing.Size(109, 23)
        Rental_dateLabel.TabIndex = 15
        Rental_dateLabel.Text = "rental date:"
        '
        'Rental_dateDateTimePicker
        '
        Me.Rental_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RentalBindingSource, "rental_date", True))
        Me.Rental_dateDateTimePicker.Location = New System.Drawing.Point(481, 243)
        Me.Rental_dateDateTimePicker.Name = "Rental_dateDateTimePicker"
        Me.Rental_dateDateTimePicker.Size = New System.Drawing.Size(253, 22)
        Me.Rental_dateDateTimePicker.TabIndex = 16
        '
        'Rental_time_per_dayLabel
        '
        Rental_time_per_dayLabel.AutoSize = True
        Rental_time_per_dayLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rental_time_per_dayLabel.Location = New System.Drawing.Point(767, 203)
        Rental_time_per_dayLabel.Name = "Rental_time_per_dayLabel"
        Rental_time_per_dayLabel.Size = New System.Drawing.Size(177, 23)
        Rental_time_per_dayLabel.TabIndex = 17
        Rental_time_per_dayLabel.Text = "rental time per day:"
        '
        'Rental_time_per_dayTextBox
        '
        Me.Rental_time_per_dayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "rental_time_per_day", True))
        Me.Rental_time_per_dayTextBox.Location = New System.Drawing.Point(740, 245)
        Me.Rental_time_per_dayTextBox.Name = "Rental_time_per_dayTextBox"
        Me.Rental_time_per_dayTextBox.Size = New System.Drawing.Size(230, 22)
        Me.Rental_time_per_dayTextBox.TabIndex = 18
        '
        'Current_kmLabel
        '
        Current_kmLabel.AutoSize = True
        Current_kmLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Current_kmLabel.Location = New System.Drawing.Point(1002, 203)
        Current_kmLabel.Name = "Current_kmLabel"
        Current_kmLabel.Size = New System.Drawing.Size(110, 23)
        Current_kmLabel.TabIndex = 19
        Current_kmLabel.Text = "current km:"
        '
        'Current_kmTextBox
        '
        Me.Current_kmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "current_km", True))
        Me.Current_kmTextBox.Location = New System.Drawing.Point(976, 245)
        Me.Current_kmTextBox.Name = "Current_kmTextBox"
        Me.Current_kmTextBox.Size = New System.Drawing.Size(193, 22)
        Me.Current_kmTextBox.TabIndex = 20
        '
        'R_totalLabel
        '
        R_totalLabel.AutoSize = True
        R_totalLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        R_totalLabel.Location = New System.Drawing.Point(1220, 203)
        R_totalLabel.Name = "R_totalLabel"
        R_totalLabel.Size = New System.Drawing.Size(69, 23)
        R_totalLabel.TabIndex = 21
        R_totalLabel.Text = "r total:"
        '
        'R_totalTextBox
        '
        Me.R_totalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "r_total", True))
        Me.R_totalTextBox.Location = New System.Drawing.Point(1175, 245)
        Me.R_totalTextBox.Name = "R_totalTextBox"
        Me.R_totalTextBox.Size = New System.Drawing.Size(154, 22)
        Me.R_totalTextBox.TabIndex = 22
        '
        'RentalDataGridView
        '
        Me.RentalDataGridView.AllowUserToAddRows = False
        Me.RentalDataGridView.AllowUserToDeleteRows = False
        Me.RentalDataGridView.AutoGenerateColumns = False
        Me.RentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.RentalDataGridView.DataSource = Me.RentalBindingSource
        Me.RentalDataGridView.Location = New System.Drawing.Point(136, 375)
        Me.RentalDataGridView.Name = "RentalDataGridView"
        Me.RentalDataGridView.ReadOnly = True
        Me.RentalDataGridView.RowTemplate.Height = 24
        Me.RentalDataGridView.Size = New System.Drawing.Size(1085, 103)
        Me.RentalDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "rental_num"
        Me.DataGridViewTextBoxColumn10.HeaderText = "rental_num"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "chassis_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "chassis_id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "client_id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "client_id"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "rental_date"
        Me.DataGridViewTextBoxColumn13.HeaderText = "rental_date"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "rental_time_per_day"
        Me.DataGridViewTextBoxColumn14.HeaderText = "rental_time_per_day"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "current_km"
        Me.DataGridViewTextBoxColumn15.HeaderText = "current_km"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "r_total"
        Me.DataGridViewTextBoxColumn16.HeaderText = "r_total"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(136, 300)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "ADD"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(347, 300)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 25
        Me.Button8.Text = "DELETE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(558, 300)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 26
        Me.Button9.Text = "<<"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(751, 300)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 27
        Me.Button10.Text = ">>"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(939, 300)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 28
        Me.Button11.Text = "FIRST"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(1146, 300)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 29
        Me.Button12.Text = "LAST"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(605, 518)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(185, 58)
        Me.Button13.TabIndex = 30
        Me.Button13.Text = "SAVE"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(1224, 542)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(105, 57)
        Me.Button14.TabIndex = 31
        Me.Button14.Text = "QUIT"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'rental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1341, 622)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.RentalDataGridView)
        Me.Controls.Add(Rental_numLabel)
        Me.Controls.Add(Me.Rental_numTextBox)
        Me.Controls.Add(Chassis_idLabel)
        Me.Controls.Add(Me.Chassis_idTextBox)
        Me.Controls.Add(Client_idLabel)
        Me.Controls.Add(Me.Client_idTextBox)
        Me.Controls.Add(Rental_dateLabel)
        Me.Controls.Add(Me.Rental_dateDateTimePicker)
        Me.Controls.Add(Rental_time_per_dayLabel)
        Me.Controls.Add(Me.Rental_time_per_dayTextBox)
        Me.Controls.Add(Current_kmLabel)
        Me.Controls.Add(Me.Current_kmTextBox)
        Me.Controls.Add(R_totalLabel)
        Me.Controls.Add(Me.R_totalTextBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PriceDataGridView)
        Me.Controls.Add(Me.CarDataGridView)
        Me.Controls.Add(Me.ClientDataGridView)
        Me.Name = "rental"
        Me.Text = "rental"
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AyzanDataSet As ayzanDataSet
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents ClientTableAdapter As ayzanDataSetTableAdapters.clientTableAdapter
    Friend WithEvents TableAdapterManager As ayzanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientDataGridView As DataGridView
    Friend WithEvents CarTableAdapter As ayzanDataSetTableAdapters.carTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CarBindingSource As BindingSource
    Friend WithEvents PriceTableAdapter As ayzanDataSetTableAdapters.priceTableAdapter
    Friend WithEvents CarDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents PriceBindingSource As BindingSource
    Friend WithEvents RentalTableAdapter As ayzanDataSetTableAdapters.rentalTableAdapter
    Friend WithEvents PriceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RentalBindingSource As BindingSource
    Friend WithEvents Rental_numTextBox As TextBox
    Friend WithEvents Chassis_idTextBox As TextBox
    Friend WithEvents Client_idTextBox As TextBox
    Friend WithEvents Rental_dateDateTimePicker As DateTimePicker
    Friend WithEvents Rental_time_per_dayTextBox As TextBox
    Friend WithEvents Current_kmTextBox As TextBox
    Friend WithEvents R_totalTextBox As TextBox
    Friend WithEvents RentalDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
End Class
