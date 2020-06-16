<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_History
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturneddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarTrackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_RentalSystemDataSet = New Car_Rental_Company.Car_RentalSystemDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Car_TrackTableAdapter = New Car_Rental_Company.Car_RentalSystemDataSetTableAdapters.Car_TrackTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarTrackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_RentalSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomeridDataGridViewTextBoxColumn, Me.CustomernameDataGridViewTextBoxColumn, Me.CaridDataGridViewTextBoxColumn, Me.CarnameDataGridViewTextBoxColumn, Me.IssueddateDataGridViewTextBoxColumn, Me.DuedateDataGridViewTextBoxColumn, Me.ReturneddateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CarTrackBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-2, -1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(950, 456)
        Me.DataGridView1.TabIndex = 0
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'CustomernameDataGridViewTextBoxColumn
        '
        Me.CustomernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name"
        Me.CustomernameDataGridViewTextBoxColumn.HeaderText = "customer_name"
        Me.CustomernameDataGridViewTextBoxColumn.Name = "CustomernameDataGridViewTextBoxColumn"
        '
        'CaridDataGridViewTextBoxColumn
        '
        Me.CaridDataGridViewTextBoxColumn.DataPropertyName = "car_id"
        Me.CaridDataGridViewTextBoxColumn.HeaderText = "car_id"
        Me.CaridDataGridViewTextBoxColumn.Name = "CaridDataGridViewTextBoxColumn"
        '
        'CarnameDataGridViewTextBoxColumn
        '
        Me.CarnameDataGridViewTextBoxColumn.DataPropertyName = "car_name"
        Me.CarnameDataGridViewTextBoxColumn.HeaderText = "car_name"
        Me.CarnameDataGridViewTextBoxColumn.Name = "CarnameDataGridViewTextBoxColumn"
        '
        'IssueddateDataGridViewTextBoxColumn
        '
        Me.IssueddateDataGridViewTextBoxColumn.DataPropertyName = "issued_date"
        Me.IssueddateDataGridViewTextBoxColumn.HeaderText = "issued_date"
        Me.IssueddateDataGridViewTextBoxColumn.Name = "IssueddateDataGridViewTextBoxColumn"
        '
        'DuedateDataGridViewTextBoxColumn
        '
        Me.DuedateDataGridViewTextBoxColumn.DataPropertyName = "due_date"
        Me.DuedateDataGridViewTextBoxColumn.HeaderText = "due_date"
        Me.DuedateDataGridViewTextBoxColumn.Name = "DuedateDataGridViewTextBoxColumn"
        '
        'ReturneddateDataGridViewTextBoxColumn
        '
        Me.ReturneddateDataGridViewTextBoxColumn.DataPropertyName = "returned_date"
        Me.ReturneddateDataGridViewTextBoxColumn.HeaderText = "returned_date"
        Me.ReturneddateDataGridViewTextBoxColumn.Name = "ReturneddateDataGridViewTextBoxColumn"
        '
        'CarTrackBindingSource
        '
        Me.CarTrackBindingSource.DataMember = "Car_Track"
        Me.CarTrackBindingSource.DataSource = Me.Car_RentalSystemDataSet
        '
        'Car_RentalSystemDataSet
        '
        Me.Car_RentalSystemDataSet.DataSetName = "Car_RentalSystemDataSet"
        Me.Car_RentalSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(772, 463)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 472)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Car_TrackTableAdapter
        '
        Me.Car_TrackTableAdapter.ClearBeforeFill = True
        '
        'Customer_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 498)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Customer_History"
        Me.Text = "Customer_History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarTrackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_RentalSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Car_RentalSystemDataSet As Car_RentalSystemDataSet
    Friend WithEvents CarTrackBindingSource As BindingSource
    Friend WithEvents Car_TrackTableAdapter As Car_RentalSystemDataSetTableAdapters.Car_TrackTableAdapter
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DuedateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturneddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
