<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class NyalibeeLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NyalibeeLogin))
        Panel1 = New Panel()
        Label1 = New Label()
        login = New Panel()
        UsernameTextBox = New TextBox()
        PasswordLabel = New Label()
        OK = New Button()
        Cancel = New Button()
        PasswordTextBox = New TextBox()
        UsernameLabel = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        login.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(login)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(206, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(685, 476)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(155, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 37)
        Label1.TabIndex = 8
        Label1.Text = "Nyalibee"
        ' 
        ' login
        ' 
        login.BackColor = Color.LemonChiffon
        login.Controls.Add(UsernameTextBox)
        login.Controls.Add(PasswordLabel)
        login.Controls.Add(OK)
        login.Controls.Add(Cancel)
        login.Controls.Add(PasswordTextBox)
        login.Controls.Add(UsernameLabel)
        login.Location = New Point(11, 153)
        login.Name = "login"
        login.Size = New Size(664, 309)
        login.TabIndex = 7
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Font = New Font("Arial Rounded MT Bold", 12F)
        UsernameTextBox.Location = New Point(215, 94)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 26)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordLabel.Location = New Point(213, 135)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(107, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password:"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' OK
        ' 
        OK.BackColor = Color.Red
        OK.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        OK.ForeColor = Color.White
        OK.Location = New Point(215, 207)
        OK.Name = "OK"
        OK.Size = New Size(94, 37)
        OK.TabIndex = 4
        OK.Text = "Login"
        OK.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = Color.Red
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Font = New Font("Arial Rounded MT Bold", 14F)
        Cancel.ForeColor = Color.White
        Cancel.Location = New Point(339, 207)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 37)
        Cancel.TabIndex = 5
        Cancel.Text = "Sign Up"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Arial Rounded MT Bold", 12F)
        PasswordTextBox.Location = New Point(215, 161)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 26)
        PasswordTextBox.TabIndex = 3
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameLabel.Location = New Point(215, 68)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(114, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "User name:"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(26, 16)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(110, 108)
        Panel2.TabIndex = 6
        ' 
        ' NyalibeeLogin
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        CancelButton = Cancel
        ClientSize = New Size(1097, 598)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "NyalibeeLogin"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        login.ResumeLayout(False)
        login.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents login As Panel
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label1 As Label

End Class
