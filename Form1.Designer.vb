<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Un = New TextBox()
        Ln = New TextBox()
        pun = New TextBox()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Passtxt = New TextBox()
        Cancel = New Button()
        UsernameLabel = New Label()
        OK = New Button()
        PasswordLabel = New Label()
        Fname = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LemonChiffon
        Panel1.Controls.Add(Un)
        Panel1.Controls.Add(Ln)
        Panel1.Controls.Add(pun)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Passtxt)
        Panel1.Controls.Add(Cancel)
        Panel1.Controls.Add(UsernameLabel)
        Panel1.Controls.Add(OK)
        Panel1.Controls.Add(PasswordLabel)
        Panel1.Controls.Add(Fname)
        Panel1.Location = New Point(136, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(573, 435)
        Panel1.TabIndex = 7
        ' 
        ' Un
        ' 
        Un.Font = New Font("Arial Rounded MT Bold", 12F)
        Un.Location = New Point(70, 264)
        Un.Name = "Un"
        Un.Size = New Size(220, 26)
        Un.TabIndex = 21
        ' 
        ' Ln
        ' 
        Ln.Font = New Font("Arial Rounded MT Bold", 12F)
        Ln.Location = New Point(70, 332)
        Ln.Name = "Ln"
        Ln.Size = New Size(220, 26)
        Ln.TabIndex = 20
        ' 
        ' pun
        ' 
        pun.Font = New Font("Arial Rounded MT Bold", 12F)
        pun.Location = New Point(314, 280)
        pun.Name = "pun"
        pun.Size = New Size(220, 26)
        pun.TabIndex = 19
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"FEMALE", "MALE"})
        ComboBox1.Location = New Point(316, 180)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial Rounded MT Bold", 12F)
        Label6.Location = New Point(316, 140)
        Label6.Name = "Label6"
        Label6.Size = New Size(220, 23)
        Label6.TabIndex = 17
        Label6.Text = "GENDER:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial Rounded MT Bold", 12F)
        Label5.Location = New Point(70, 306)
        Label5.Name = "Label5"
        Label5.Size = New Size(220, 23)
        Label5.TabIndex = 14
        Label5.Text = "Last Name:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial Rounded MT Bold", 12F)
        Label4.Location = New Point(316, 254)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 23)
        Label4.TabIndex = 12
        Label4.Text = "Phone#"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial Rounded MT Bold", 12F)
        Label3.Location = New Point(70, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(220, 23)
        Label3.TabIndex = 10
        Label3.Text = "First Name:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
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
        ' Passtxt
        ' 
        Passtxt.Font = New Font("Arial Rounded MT Bold", 12F)
        Passtxt.Location = New Point(70, 196)
        Passtxt.Name = "Passtxt"
        Passtxt.PasswordChar = "*"c
        Passtxt.Size = New Size(220, 26)
        Passtxt.TabIndex = 3
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = Color.Red
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Font = New Font("Arial Rounded MT Bold", 12F)
        Cancel.ForeColor = Color.White
        Cancel.Location = New Point(389, 379)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 29)
        Cancel.TabIndex = 5
        Cancel.Text = "CANCEL"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Font = New Font("Arial Rounded MT Bold", 12F)
        UsernameLabel.Location = New Point(68, 102)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "User Name:"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' OK
        ' 
        OK.BackColor = Color.Red
        OK.Font = New Font("Arial Rounded MT Bold", 12F)
        OK.ForeColor = Color.White
        OK.Location = New Point(194, 379)
        OK.Name = "OK"
        OK.Size = New Size(94, 29)
        OK.TabIndex = 4
        OK.Text = "SAVE"
        OK.UseVisualStyleBackColor = False
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
        ' Fname
        ' 
        Fname.Font = New Font("Arial Rounded MT Bold", 12F)
        Fname.Location = New Point(68, 128)
        Fname.Name = "Fname"
        Fname.Size = New Size(220, 26)
        Fname.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(832, 515)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIGN -UP if u Dont have an Account"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Passtxt As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents OK As Button
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Fname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Un As TextBox
    Friend WithEvents Ln As TextBox
    Friend WithEvents pun As TextBox
End Class
