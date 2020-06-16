<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Return_Page
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Customer_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Customer_ID = New System.Windows.Forms.TextBox()
        Me.Car_Name = New System.Windows.Forms.TextBox()
        Me.Car_ID = New System.Windows.Forms.TextBox()
        Me.Issued_Date = New System.Windows.Forms.DateTimePicker()
        Me.Due_Date = New System.Windows.Forms.DateTimePicker()
        Me.Returned_Date = New System.Windows.Forms.DateTimePicker()
        Me.Previous = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Returned_Date)
        Me.Panel1.Controls.Add(Me.Due_Date)
        Me.Panel1.Controls.Add(Me.Issued_Date)
        Me.Panel1.Controls.Add(Me.Car_ID)
        Me.Panel1.Controls.Add(Me.Car_Name)
        Me.Panel1.Controls.Add(Me.Customer_ID)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Customer_Name)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 482)
        Me.Panel1.TabIndex = 0
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(691, 207)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(205, 23)
        Me.Back.TabIndex = 1
        Me.Back.Text = "Back / Previous"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name"
        '
        'Customer_Name
        '
        Me.Customer_Name.Location = New System.Drawing.Point(114, 64)
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.Size = New System.Drawing.Size(247, 20)
        Me.Customer_Name.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Car_Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Car ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Issued Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Due Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 429)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Returned Date"
        '
        'Customer_ID
        '
        Me.Customer_ID.Location = New System.Drawing.Point(114, 129)
        Me.Customer_ID.Name = "Customer_ID"
        Me.Customer_ID.Size = New System.Drawing.Size(247, 20)
        Me.Customer_ID.TabIndex = 9
        '
        'Car_Name
        '
        Me.Car_Name.Location = New System.Drawing.Point(114, 190)
        Me.Car_Name.Name = "Car_Name"
        Me.Car_Name.Size = New System.Drawing.Size(247, 20)
        Me.Car_Name.TabIndex = 10
        '
        'Car_ID
        '
        Me.Car_ID.Location = New System.Drawing.Point(114, 251)
        Me.Car_ID.Name = "Car_ID"
        Me.Car_ID.Size = New System.Drawing.Size(247, 20)
        Me.Car_ID.TabIndex = 11
        '
        'Issued_Date
        '
        Me.Issued_Date.Location = New System.Drawing.Point(114, 312)
        Me.Issued_Date.Name = "Issued_Date"
        Me.Issued_Date.Size = New System.Drawing.Size(247, 20)
        Me.Issued_Date.TabIndex = 12
        '
        'Due_Date
        '
        Me.Due_Date.Location = New System.Drawing.Point(114, 366)
        Me.Due_Date.Name = "Due_Date"
        Me.Due_Date.Size = New System.Drawing.Size(247, 20)
        Me.Due_Date.TabIndex = 13
        '
        'Returned_Date
        '
        Me.Returned_Date.Location = New System.Drawing.Point(114, 422)
        Me.Returned_Date.Name = "Returned_Date"
        Me.Returned_Date.Size = New System.Drawing.Size(247, 20)
        Me.Returned_Date.TabIndex = 14
        '
        'Previous
        '
        Me.Previous.Location = New System.Drawing.Point(691, 285)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(211, 23)
        Me.Previous.TabIndex = 2
        Me.Previous.Text = "Exit"
        Me.Previous.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(691, 136)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(205, 23)
        Me.Save.TabIndex = 3
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Return_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 488)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Previous)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Return_Page"
        Me.Text = "Return_Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Car_ID As TextBox
    Friend WithEvents Car_Name As TextBox
    Friend WithEvents Customer_ID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Customer_Name As TextBox
    Friend WithEvents Back As Button
    Friend WithEvents Returned_Date As DateTimePicker
    Friend WithEvents Due_Date As DateTimePicker
    Friend WithEvents Issued_Date As DateTimePicker
    Friend WithEvents Previous As Button
    Friend WithEvents Save As Button
End Class
