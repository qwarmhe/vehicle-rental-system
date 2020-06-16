<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Car_Transactions
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Car_RentalSystemDataSet2 = New Car_Rental_Company.Car_RentalSystemDataSet2()
        Me.CarHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_HistoryTableAdapter = New Car_Rental_Company.Car_RentalSystemDataSet2TableAdapters.Car_HistoryTableAdapter()
        Me.CustomernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyingpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateboughtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateissuedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_RentalSystemDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 491)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(85, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(85, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Back / Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomernameDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.CarnameDataGridViewTextBoxColumn, Me.CaridDataGridViewTextBoxColumn, Me.BuyingpriceDataGridViewTextBoxColumn, Me.DateboughtDataGridViewTextBoxColumn, Me.DateissuedDataGridViewTextBoxColumn, Me.RentalpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CarHistoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(336, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(634, 491)
        Me.DataGridView1.TabIndex = 1
        '
        'Car_RentalSystemDataSet2
        '
        Me.Car_RentalSystemDataSet2.DataSetName = "Car_RentalSystemDataSet2"
        Me.Car_RentalSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarHistoryBindingSource
        '
        Me.CarHistoryBindingSource.DataMember = "Car_History"
        Me.CarHistoryBindingSource.DataSource = Me.Car_RentalSystemDataSet2
        '
        'Car_HistoryTableAdapter
        '
        Me.Car_HistoryTableAdapter.ClearBeforeFill = True
        '
        'CustomernameDataGridViewTextBoxColumn
        '
        Me.CustomernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name"
        Me.CustomernameDataGridViewTextBoxColumn.HeaderText = "customer_name"
        Me.CustomernameDataGridViewTextBoxColumn.Name = "CustomernameDataGridViewTextBoxColumn"
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'CarnameDataGridViewTextBoxColumn
        '
        Me.CarnameDataGridViewTextBoxColumn.DataPropertyName = "car_name"
        Me.CarnameDataGridViewTextBoxColumn.HeaderText = "car_name"
        Me.CarnameDataGridViewTextBoxColumn.Name = "CarnameDataGridViewTextBoxColumn"
        '
        'CaridDataGridViewTextBoxColumn
        '
        Me.CaridDataGridViewTextBoxColumn.DataPropertyName = "car_id"
        Me.CaridDataGridViewTextBoxColumn.HeaderText = "car_id"
        Me.CaridDataGridViewTextBoxColumn.Name = "CaridDataGridViewTextBoxColumn"
        '
        'BuyingpriceDataGridViewTextBoxColumn
        '
        Me.BuyingpriceDataGridViewTextBoxColumn.DataPropertyName = "buying_price"
        Me.BuyingpriceDataGridViewTextBoxColumn.HeaderText = "buying_price"
        Me.BuyingpriceDataGridViewTextBoxColumn.Name = "BuyingpriceDataGridViewTextBoxColumn"
        '
        'DateboughtDataGridViewTextBoxColumn
        '
        Me.DateboughtDataGridViewTextBoxColumn.DataPropertyName = "date_bought"
        Me.DateboughtDataGridViewTextBoxColumn.HeaderText = "date_bought"
        Me.DateboughtDataGridViewTextBoxColumn.Name = "DateboughtDataGridViewTextBoxColumn"
        '
        'DateissuedDataGridViewTextBoxColumn
        '
        Me.DateissuedDataGridViewTextBoxColumn.DataPropertyName = "date_issued"
        Me.DateissuedDataGridViewTextBoxColumn.HeaderText = "date_issued"
        Me.DateissuedDataGridViewTextBoxColumn.Name = "DateissuedDataGridViewTextBoxColumn"
        '
        'RentalpriceDataGridViewTextBoxColumn
        '
        Me.RentalpriceDataGridViewTextBoxColumn.DataPropertyName = "rental_price"
        Me.RentalpriceDataGridViewTextBoxColumn.HeaderText = "rental_price"
        Me.RentalpriceDataGridViewTextBoxColumn.Name = "RentalpriceDataGridViewTextBoxColumn"
        '
        'Car_Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 489)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Car_Transactions"
        Me.Text = "Car_Transactions"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_RentalSystemDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Car_RentalSystemDataSet2 As Car_RentalSystemDataSet2
    Friend WithEvents CarHistoryBindingSource As BindingSource
    Friend WithEvents Car_HistoryTableAdapter As Car_RentalSystemDataSet2TableAdapters.Car_HistoryTableAdapter
    Friend WithEvents CustomernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyingpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateboughtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateissuedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
