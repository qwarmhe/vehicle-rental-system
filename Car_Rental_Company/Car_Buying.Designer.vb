<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Car_Buying
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.My_Car = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Date_Bought = New System.Windows.Forms.DateTimePicker()
        Me.Car_Price = New System.Windows.Forms.TextBox()
        Me.Car_Id = New System.Windows.Forms.TextBox()
        Me.Car_Name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Customer_Id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Customer_Name = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.My_Car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(59, 447)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Save & Continue"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Date Bought"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(402, 447)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.My_Car)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(408, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(557, 492)
        Me.Panel2.TabIndex = 6
        '
        'My_Car
        '
        Me.My_Car.Location = New System.Drawing.Point(59, 23)
        Me.My_Car.Name = "My_Car"
        Me.My_Car.Size = New System.Drawing.Size(444, 340)
        Me.My_Car.TabIndex = 12
        Me.My_Car.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Show Car"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Date_Bought
        '
        Me.Date_Bought.Location = New System.Drawing.Point(132, 381)
        Me.Date_Bought.Name = "Date_Bought"
        Me.Date_Bought.Size = New System.Drawing.Size(230, 20)
        Me.Date_Bought.TabIndex = 13
        '
        'Car_Price
        '
        Me.Car_Price.Location = New System.Drawing.Point(132, 320)
        Me.Car_Price.Name = "Car_Price"
        Me.Car_Price.Size = New System.Drawing.Size(230, 20)
        Me.Car_Price.TabIndex = 10
        '
        'Car_Id
        '
        Me.Car_Id.Location = New System.Drawing.Point(132, 263)
        Me.Car_Id.Name = "Car_Id"
        Me.Car_Id.Size = New System.Drawing.Size(230, 20)
        Me.Car_Id.TabIndex = 9
        '
        'Car_Name
        '
        Me.Car_Name.Location = New System.Drawing.Point(132, 199)
        Me.Car_Name.Name = "Car_Name"
        Me.Car_Name.Size = New System.Drawing.Size(230, 20)
        Me.Car_Name.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Car Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Car Id"
        '
        'Customer_Id
        '
        Me.Customer_Id.Location = New System.Drawing.Point(132, 142)
        Me.Customer_Id.Name = "Customer_Id"
        Me.Customer_Id.Size = New System.Drawing.Size(230, 20)
        Me.Customer_Id.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer Id"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Date_Bought)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Car_Price)
        Me.Panel1.Controls.Add(Me.Car_Id)
        Me.Panel1.Controls.Add(Me.Car_Name)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Customer_Id)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Customer_Name)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 490)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Car Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name"
        '
        'Customer_Name
        '
        Me.Customer_Name.Location = New System.Drawing.Point(132, 86)
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.Size = New System.Drawing.Size(230, 20)
        Me.Customer_Name.TabIndex = 0
        '
        'Car_Buying
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 490)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Car_Buying"
        Me.Text = "Car_Buying"
        Me.Panel2.ResumeLayout(False)
        CType(Me.My_Car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents My_Car As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Date_Bought As DateTimePicker
    Friend WithEvents Car_Price As TextBox
    Friend WithEvents Car_Id As TextBox
    Friend WithEvents Car_Name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Customer_Id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Customer_Name As TextBox
End Class
