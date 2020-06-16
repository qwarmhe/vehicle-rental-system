<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Car_Update
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Maintenance_Date = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.In_Date = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Colour = New System.Windows.Forms.TextBox()
        Me.Rental_Price = New System.Windows.Forms.TextBox()
        Me.Car_Name = New System.Windows.Forms.TextBox()
        Me.Buying_Price = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Car_Picture = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.Car_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save & Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Maintenance_Date
        '
        Me.Maintenance_Date.Location = New System.Drawing.Point(134, 317)
        Me.Maintenance_Date.Name = "Maintenance_Date"
        Me.Maintenance_Date.Size = New System.Drawing.Size(348, 20)
        Me.Maintenance_Date.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Rental Price"
        '
        'In_Date
        '
        Me.In_Date.Location = New System.Drawing.Point(134, 255)
        Me.In_Date.Name = "In_Date"
        Me.In_Date.Size = New System.Drawing.Size(348, 20)
        Me.In_Date.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Buying Price"
        '
        'Colour
        '
        Me.Colour.Location = New System.Drawing.Point(134, 186)
        Me.Colour.Name = "Colour"
        Me.Colour.Size = New System.Drawing.Size(348, 20)
        Me.Colour.TabIndex = 8
        '
        'Rental_Price
        '
        Me.Rental_Price.Location = New System.Drawing.Point(134, 432)
        Me.Rental_Price.Name = "Rental_Price"
        Me.Rental_Price.Size = New System.Drawing.Size(348, 20)
        Me.Rental_Price.TabIndex = 12
        '
        'Car_Name
        '
        Me.Car_Name.Location = New System.Drawing.Point(134, 119)
        Me.Car_Name.Name = "Car_Name"
        Me.Car_Name.Size = New System.Drawing.Size(348, 20)
        Me.Car_Name.TabIndex = 7
        '
        'Buying_Price
        '
        Me.Buying_Price.Location = New System.Drawing.Point(134, 374)
        Me.Buying_Price.Name = "Buying_Price"
        Me.Buying_Price.Size = New System.Drawing.Size(348, 20)
        Me.Buying_Price.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(126, 314)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Upload Car Image"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Car_Picture
        '
        Me.Car_Picture.Location = New System.Drawing.Point(12, 50)
        Me.Car_Picture.Name = "Car_Picture"
        Me.Car_Picture.Size = New System.Drawing.Size(340, 247)
        Me.Car_Picture.TabIndex = 15
        Me.Car_Picture.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Car_Picture)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(598, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(361, 484)
        Me.Panel2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(213, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Maintance Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "In-Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Colour"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(134, 50)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(348, 20)
        Me.ID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Maintenance_Date)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.In_Date)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Colour)
        Me.Panel1.Controls.Add(Me.Rental_Price)
        Me.Panel1.Controls.Add(Me.Car_Name)
        Me.Panel1.Controls.Add(Me.Buying_Price)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 484)
        Me.Panel1.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(15, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "< Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Car_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 491)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Car_Update"
        Me.Text = "Car_Update"
        CType(Me.Car_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Maintenance_Date As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents In_Date As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Colour As TextBox
    Friend WithEvents Rental_Price As TextBox
    Friend WithEvents Car_Name As TextBox
    Friend WithEvents Buying_Price As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Car_Picture As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
End Class
