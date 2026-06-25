<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminonly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adminonly))
        MenuStrip = New MenuStrip()
        FileMenu = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditMenu = New ToolStripMenuItem()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ViewMenu = New ToolStripMenuItem()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel = New ToolStripStatusLabel()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolTip = New ToolTip(components)
        MenuStrip.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.BackColor = Color.Red
        MenuStrip.Items.AddRange(New ToolStripItem() {FileMenu, EditMenu, ViewMenu})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(7, 2, 0, 2)
        MenuStrip.Size = New Size(737, 26)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' FileMenu
        ' 
        FileMenu.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileMenu.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FileMenu.ForeColor = Color.White
        FileMenu.ImageTransparentColor = SystemColors.ActiveBorder
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(76, 22)
        FileMenu.Text = "Logout"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.BackColor = Color.Red
        ExitToolStripMenuItem.ForeColor = Color.White
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
        ExitToolStripMenuItem.Text = "Logout"
        ' 
        ' EditMenu
        ' 
        EditMenu.DropDownItems.AddRange(New ToolStripItem() {SelectAllToolStripMenuItem})
        EditMenu.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EditMenu.ForeColor = Color.White
        EditMenu.Name = "EditMenu"
        EditMenu.Size = New Size(76, 22)
        EditMenu.Text = "Orders"
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.BackColor = Color.Red
        SelectAllToolStripMenuItem.ForeColor = Color.White
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        SelectAllToolStripMenuItem.Size = New Size(190, 22)
        SelectAllToolStripMenuItem.Text = "Orders"
        ' 
        ' ViewMenu
        ' 
        ViewMenu.DropDownItems.AddRange(New ToolStripItem() {StatusBarToolStripMenuItem})
        ViewMenu.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ViewMenu.ForeColor = Color.White
        ViewMenu.Name = "ViewMenu"
        ViewMenu.Size = New Size(130, 22)
        ViewMenu.Text = "Manage Menu"
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.BackColor = Color.Red
        StatusBarToolStripMenuItem.Checked = True
        StatusBarToolStripMenuItem.CheckOnClick = True
        StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        StatusBarToolStripMenuItem.ForeColor = Color.White
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(186, 22)
        StatusBarToolStripMenuItem.Text = "Manage Menu"
        ' 
        ' StatusStrip
        ' 
        StatusStrip.BackColor = Color.Red
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel, ToolStripStatusLabel1})
        StatusStrip.Location = New Point(0, 501)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 16, 0)
        StatusStrip.Size = New Size(737, 22)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel.ForeColor = Color.White
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(71, 17)
        ToolStripStatusLabel.Text = "Nyalibee"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(0, 17)
        ' 
        ' Adminonly
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(737, 523)
        Controls.Add(MenuStrip)
        Controls.Add(StatusStrip)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 3, 4, 3)
        Name = "Adminonly"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Adminonly"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel

End Class
