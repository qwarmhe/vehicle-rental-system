<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_History
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Car_RentalSystemDataSet1 = New Car_Rental_Company.Car_RentalSystemDataSet1()
        Me.TransactionHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Transaction_HistoryTableAdapter = New Car_Rental_Company.Car_RentalSystemDataSet1TableAdapters.Transaction_HistoryTableAdapter()
        Me.CustomernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuypriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_RentalSystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomernameDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.CarnameDataGridViewTextBoxColumn, Me.CaridDataGridViewTextBoxColumn, Me.RentalpriceDataGridViewTextBoxColumn, Me.BuypriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TransactionHistoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(962, 441)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "< Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(513, 462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Car_RentalSystemDataSet1
        '
        Me.Car_RentalSystemDataSet1.DataSetName = "Car_RentalSystemDataSet1"
        Me.Car_RentalSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionHistoryBindingSource
        '
        Me.TransactionHistoryBindingSource.DataMember = "Transaction_History"
        Me.TransactionHistoryBindingSource.DataSource = Me.Car_RentalSystemDataSet1
        '
        'Transaction_HistoryTableAdapter
        '
        Me.Transaction_HistoryTableAdapter.ClearBeforeFill = True
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
        'RentalpriceDataGridViewTextBoxColumn
        '
        Me.RentalpriceDataGridViewTextBoxColumn.DataPropertyName = "rental_price"
        Me.RentalpriceDataGridViewTextBoxColumn.HeaderText = "rental_price"
        Me.RentalpriceDataGridViewTextBoxColumn.Name = "RentalpriceDataGridViewTextBoxColumn"
        '
        'BuypriceDataGridViewTextBoxColumn
        '
        Me.BuypriceDataGridViewTextBoxColumn.DataPropertyName = "buy_price"
        Me.BuypriceDataGridViewTextBoxColumn.HeaderText = "buy_price"
        Me.BuypriceDataGridViewTextBoxColumn.Name = "BuypriceDataGridViewTextBoxColumn"
        '
        'Transaction_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 497)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Transaction_History"
        Me.Text = "Transaction_History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_RentalSystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Car_RentalSystemDataSet1 As Car_RentalSystemDataSet1
    Friend WithEvents TransactionHistoryBindingSource As BindingSource
    Friend WithEvents Transaction_HistoryTableAdapter As Car_RentalSystemDataSet1TableAdapters.Transaction_HistoryTableAdapter
    Friend WithEvents CustomernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuypriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
