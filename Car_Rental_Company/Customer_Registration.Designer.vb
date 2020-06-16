<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Registration
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
        Me.Area_Residence = New System.Windows.Forms.TextBox()
        Me.Contact = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Customer_Name = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Customer_Picture = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Customer_Id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.Customer_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save & Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Area_Residence
        '
        Me.Area_Residence.Location = New System.Drawing.Point(143, 327)
        Me.Area_Residence.Name = "Area_Residence"
        Me.Area_Residence.Size = New System.Drawing.Size(348, 20)
        Me.Area_Residence.TabIndex = 10
        '
        'Contact
        '
        Me.Contact.Location = New System.Drawing.Point(143, 264)
        Me.Contact.Name = "Contact"
        Me.Contact.Size = New System.Drawing.Size(348, 20)
        Me.Contact.TabIndex = 9
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(143, 202)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(348, 20)
        Me.Email.TabIndex = 8
        '
        'Customer_Name
        '
        Me.Customer_Name.Location = New System.Drawing.Point(143, 136)
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.Size = New System.Drawing.Size(348, 20)
        Me.Customer_Name.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(126, 314)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Upload Image"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Customer_Picture
        '
        Me.Customer_Picture.Location = New System.Drawing.Point(12, 50)
        Me.Customer_Picture.Name = "Customer_Picture"
        Me.Customer_Picture.Size = New System.Drawing.Size(340, 247)
        Me.Customer_Picture.TabIndex = 15
        Me.Customer_Picture.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Customer_Picture)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(603, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(361, 484)
        Me.Panel2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Area of Residence"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Contact"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'Customer_Id
        '
        Me.Customer_Id.Location = New System.Drawing.Point(143, 76)
        Me.Customer_Id.Name = "Customer_Id"
        Me.Customer_Id.Size = New System.Drawing.Size(348, 20)
        Me.Customer_Id.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Gender)
        Me.Panel1.Controls.Add(Me.Area_Residence)
        Me.Panel1.Controls.Add(Me.Contact)
        Me.Panel1.Controls.Add(Me.Email)
        Me.Panel1.Controls.Add(Me.Customer_Name)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Customer_Id)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 484)
        Me.Panel1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Gender"
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Location = New System.Drawing.Point(143, 383)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(348, 21)
        Me.Gender.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(267, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "< Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Customer_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 500)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Customer_Registration"
        Me.Text = "Customer_Registration"
        CType(Me.Customer_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Area_Residence As TextBox
    Friend WithEvents Contact As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Customer_Name As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Customer_Picture As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Customer_Id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Button4 As Button
End Class
