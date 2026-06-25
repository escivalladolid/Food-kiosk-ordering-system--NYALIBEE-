<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class progressbar
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(progressbar))
        ProgressBar1 = New System.Windows.Forms.ProgressBar()
        B1 = New Button()
        Timer1 = New Timer(components)
        Gifbox = New PictureBox()
        CType(Gifbox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(161, 74)
        ProgressBar1.MarqueeAnimationSpeed = 10
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(364, 49)
        ProgressBar1.TabIndex = 0
        ProgressBar1.Value = 100
        ' 
        ' B1
        ' 
        B1.BackColor = Color.LimeGreen
        B1.Cursor = Cursors.No
        B1.FlatStyle = FlatStyle.Popup
        B1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        B1.Location = New Point(251, 154)
        B1.Name = "B1"
        B1.Size = New Size(100, 33)
        B1.TabIndex = 1
        B1.Text = "START"
        B1.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Gifbox
        ' 
        Gifbox.BackgroundImage = CType(resources.GetObject("Gifbox.BackgroundImage"), Image)
        Gifbox.Image = CType(resources.GetObject("Gifbox.Image"), Image)
        Gifbox.Location = New Point(12, 31)
        Gifbox.Name = "Gifbox"
        Gifbox.Size = New Size(143, 125)
        Gifbox.SizeMode = PictureBoxSizeMode.StretchImage
        Gifbox.TabIndex = 2
        Gifbox.TabStop = False
        Gifbox.Visible = False
        ' 
        ' progressbar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(614, 233)
        Controls.Add(Gifbox)
        Controls.Add(B1)
        Controls.Add(ProgressBar1)
        Name = "progressbar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NYALIBEE"
        CType(Gifbox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents B1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Gifbox As PictureBox
End Class
