<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signupform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signupform))
        Panel1 = New Panel()
        Panel3 = New Panel()
        TextBox4 = New TextBox()
        CheckBox3 = New CheckBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        CheckBox1 = New CheckBox()
        Label6 = New Label()
        CheckBox2 = New CheckBox()
        Label2 = New Label()
        PasswordTextBox = New TextBox()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(26, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1147, 583)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LemonChiffon
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(CheckBox3)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(CheckBox1)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(CheckBox2)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(PasswordTextBox)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBox1)
        Panel3.Location = New Point(166, 135)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(805, 405)
        Panel3.TabIndex = 24
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(335, 201)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(220, 23)
        TextBox4.TabIndex = 21
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox3.Location = New Point(305, 339)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(170, 21)
        CheckBox3.TabIndex = 23
        CheckBox3.Text = "Terms and Agreement"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F)
        Label3.Location = New Point(230, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 18)
        Label3.TabIndex = 11
        Label3.Text = "First Name:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(335, 245)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(220, 23)
        TextBox3.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F)
        Label4.Location = New Point(230, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 18)
        Label4.TabIndex = 12
        Label4.Text = "Last Name:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Arial Rounded MT Bold", 12F)
        CheckBox1.Location = New Point(264, 153)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(64, 22)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Male"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 12F)
        Label6.Location = New Point(231, 245)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 18)
        Label6.TabIndex = 20
        Label6.Text = "Email:"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox2.Location = New Point(411, 153)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(85, 22)
        CheckBox2.TabIndex = 14
        CheckBox2.Text = "Female"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F)
        Label2.Location = New Point(230, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 18)
        Label2.TabIndex = 19
        Label2.Text = "Phone #:"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Arial Rounded MT Bold", 12F)
        PasswordTextBox.Location = New Point(335, 291)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 26)
        PasswordTextBox.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(335, 104)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(220, 23)
        TextBox2.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F)
        Label5.Location = New Point(230, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 18)
        Label5.TabIndex = 16
        Label5.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(335, 51)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(220, 23)
        TextBox1.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(144, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 37)
        Label1.TabIndex = 9
        Label1.Text = "Nyalibee"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(19, 13)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(110, 108)
        Panel2.TabIndex = 7
        ' 
        ' signupform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(1197, 634)
        Controls.Add(Panel1)
        Name = "signupform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Panel3 As Panel

End Class
