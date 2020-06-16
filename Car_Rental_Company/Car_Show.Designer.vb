<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Car_Show
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
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Buy_Price = New System.Windows.Forms.TextBox()
        Me.Rent_Price = New System.Windows.Forms.TextBox()
        Me.Date_In = New System.Windows.Forms.TextBox()
        Me.Car_Id = New System.Windows.Forms.TextBox()
        Me.Car_Name = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Car_Picture = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Car_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Buy_Price)
        Me.Panel1.Controls.Add(Me.Rent_Price)
        Me.Panel1.Controls.Add(Me.Date_In)
        Me.Panel1.Controls.Add(Me.Car_Id)
        Me.Panel1.Controls.Add(Me.Car_Name)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 482)
        Me.Panel1.TabIndex = 0
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(109, 412)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(142, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Exit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(109, 329)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Back / Previous"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Buy_Price
        '
        Me.Buy_Price.Location = New System.Drawing.Point(51, 265)
        Me.Buy_Price.Name = "Buy_Price"
        Me.Buy_Price.Size = New System.Drawing.Size(277, 20)
        Me.Buy_Price.TabIndex = 4
        Me.Buy_Price.Text = "Buy Price"
        '
        'Rent_Price
        '
        Me.Rent_Price.Location = New System.Drawing.Point(51, 208)
        Me.Rent_Price.Name = "Rent_Price"
        Me.Rent_Price.Size = New System.Drawing.Size(277, 20)
        Me.Rent_Price.TabIndex = 3
        Me.Rent_Price.Text = "Rent Price"
        '
        'Date_In
        '
        Me.Date_In.Location = New System.Drawing.Point(51, 157)
        Me.Date_In.Name = "Date_In"
        Me.Date_In.Size = New System.Drawing.Size(277, 20)
        Me.Date_In.TabIndex = 2
        Me.Date_In.Text = "Date In"
        '
        'Car_Id
        '
        Me.Car_Id.Location = New System.Drawing.Point(51, 106)
        Me.Car_Id.Name = "Car_Id"
        Me.Car_Id.Size = New System.Drawing.Size(277, 20)
        Me.Car_Id.TabIndex = 1
        Me.Car_Id.Text = "Car Id"
        '
        'Car_Name
        '
        Me.Car_Name.Location = New System.Drawing.Point(51, 55)
        Me.Car_Name.Name = "Car_Name"
        Me.Car_Name.Size = New System.Drawing.Size(277, 20)
        Me.Car_Name.TabIndex = 0
        Me.Car_Name.Text = "Car Name"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Car_Picture)
        Me.Panel2.Location = New System.Drawing.Point(387, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 482)
        Me.Panel2.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(423, 439)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Rent"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 448)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Buy"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(208, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Preview"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Car_Picture
        '
        Me.Car_Picture.Location = New System.Drawing.Point(3, 3)
        Me.Car_Picture.Name = "Car_Picture"
        Me.Car_Picture.Size = New System.Drawing.Size(562, 359)
        Me.Car_Picture.TabIndex = 0
        Me.Car_Picture.TabStop = False
        '
        'Car_Show
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 485)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Car_Show"
        Me.Text = "Car_Show"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Car_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Buy_Price As TextBox
    Friend WithEvents Rent_Price As TextBox
    Friend WithEvents Date_In As TextBox
    Friend WithEvents Car_Id As TextBox
    Friend WithEvents Car_Name As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Car_Picture As PictureBox
End Class
