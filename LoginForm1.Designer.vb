<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OK = New Button()
        Cancel = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Font = New Font("Arial Rounded MT Bold", 12F)
        UsernameLabel.Location = New Point(68, 111)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "User name:"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Font = New Font("Arial Rounded MT Bold", 12F)
        PasswordLabel.Location = New Point(68, 168)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password:"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Font = New Font("Arial Rounded MT Bold", 12F)
        UsernameTextBox.Location = New Point(70, 137)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 26)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Arial Rounded MT Bold", 12F)
        PasswordTextBox.Location = New Point(70, 194)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 26)
        PasswordTextBox.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.BackColor = Color.Red
        OK.Font = New Font("Arial Rounded MT Bold", 12F)
        OK.ForeColor = Color.White
        OK.Location = New Point(70, 242)
        OK.Name = "OK"
        OK.Size = New Size(94, 29)
        OK.TabIndex = 4
        OK.Text = "Log_In"
        OK.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = Color.Red
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Font = New Font("Arial Rounded MT Bold", 12F)
        Cancel.ForeColor = Color.White
        Cancel.Location = New Point(194, 242)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 29)
        Cancel.TabIndex = 5
        Cancel.Text = "Sign Up"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LemonChiffon
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PasswordTextBox)
        Panel1.Controls.Add(Cancel)
        Panel1.Controls.Add(UsernameLabel)
        Panel1.Controls.Add(OK)
        Panel1.Controls.Add(PasswordLabel)
        Panel1.Controls.Add(UsernameTextBox)
        Panel1.Location = New Point(185, 45)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(359, 362)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(139, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 37)
        Label1.TabIndex = 7
        Label1.Text = "Nyalibee."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(20, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 96)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' LoginForm1
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        BackgroundImage = My.Resources.Resources.nyoliboi
        CancelButton = Cancel
        ClientSize = New Size(697, 446)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "WELCOME USER!"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
