<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        MenuStrip = New MenuStrip()
        FileMenu = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        EditMenu = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        ViewMenu = New ToolStripMenuItem()
        ToolBarToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip = New StatusStrip()
        ToolTip = New ToolTip(components)
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripStatusLabel = New ToolStripStatusLabel()
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
        MenuStrip.Size = New Size(1036, 36)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' FileMenu
        ' 
        FileMenu.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem})
        FileMenu.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FileMenu.ForeColor = Color.White
        FileMenu.ImageTransparentColor = SystemColors.ActiveBorder
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(103, 32)
        FileMenu.Text = "Logout"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.BackColor = Color.Red
        NewToolStripMenuItem.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NewToolStripMenuItem.ForeColor = Color.White
        NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), Image)
        NewToolStripMenuItem.ImageTransparentColor = Color.Black
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(194, 22)
        NewToolStripMenuItem.Text = "Logout"
        ' 
        ' EditMenu
        ' 
        EditMenu.DropDownItems.AddRange(New ToolStripItem() {PasteToolStripMenuItem, ToolStripSeparator7})
        EditMenu.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EditMenu.ForeColor = Color.White
        EditMenu.Name = "EditMenu"
        EditMenu.Size = New Size(107, 32)
        EditMenu.Text = "Orders"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(186, 6)
        ' 
        ' ViewMenu
        ' 
        ViewMenu.DropDownItems.AddRange(New ToolStripItem() {ToolBarToolStripMenuItem})
        ViewMenu.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ViewMenu.ForeColor = Color.White
        ViewMenu.Name = "ViewMenu"
        ViewMenu.Size = New Size(183, 32)
        ViewMenu.Text = "Manage Menu"
        ' 
        ' ToolBarToolStripMenuItem
        ' 
        ToolBarToolStripMenuItem.BackColor = Color.Red
        ToolBarToolStripMenuItem.Checked = True
        ToolBarToolStripMenuItem.CheckOnClick = True
        ToolBarToolStripMenuItem.CheckState = CheckState.Checked
        ToolBarToolStripMenuItem.ForeColor = Color.White
        ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        ToolBarToolStripMenuItem.Size = New Size(243, 32)
        ToolBarToolStripMenuItem.Text = "Manage Menu"
        ' 
        ' StatusStrip
        ' 
        StatusStrip.BackColor = Color.Red
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel})
        StatusStrip.Location = New Point(0, 565)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 16, 0)
        StatusStrip.Size = New Size(1036, 27)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.BackColor = Color.Red
        PasteToolStripMenuItem.ForeColor = Color.White
        PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), Image)
        PasteToolStripMenuItem.ImageTransparentColor = Color.Black
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(189, 22)
        PasteToolStripMenuItem.Text = "Orders"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.BackColor = Color.Red
        ToolStripStatusLabel.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel.ForeColor = Color.White
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(95, 22)
        ToolStripStatusLabel.Text = "Nyalibee."
        ' 
        ' MDIParent1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1036, 592)
        Controls.Add(MenuStrip)
        Controls.Add(StatusStrip)
        DoubleBuffered = True
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 3, 4, 3)
        Name = "MDIParent1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MDIParent1"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel

End Class
