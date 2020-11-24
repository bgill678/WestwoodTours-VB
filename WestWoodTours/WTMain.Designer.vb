<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WTMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WTMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChartsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpacesLAB = New System.Windows.Forms.Label()
        Me.SpacesNUM = New System.Windows.Forms.Label()
        Me.BookingsLAB = New System.Windows.Forms.Label()
        Me.BookingsNUM = New System.Windows.Forms.Label()
        Me.ExpenseNUM = New System.Windows.Forms.Label()
        Me.ExpenseLAB = New System.Windows.Forms.Label()
        Me.Refresh = New System.Windows.Forms.Timer(Me.components)
        Me.Toggle1 = New WestWoodTours.Toggle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.InvoicesToolStripMenuItem, Me.BookingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'InvoicesToolStripMenuItem
        '
        Me.InvoicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateInvoiceToolStripMenuItem})
        Me.InvoicesToolStripMenuItem.Name = "InvoicesToolStripMenuItem"
        Me.InvoicesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.InvoicesToolStripMenuItem.Text = "Invoices"
        '
        'CreateInvoiceToolStripMenuItem
        '
        Me.CreateInvoiceToolStripMenuItem.Name = "CreateInvoiceToolStripMenuItem"
        Me.CreateInvoiceToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CreateInvoiceToolStripMenuItem.Text = "Create Invoice"
        '
        'BookingsToolStripMenuItem
        '
        Me.BookingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookingsToolStripMenuItem1, Me.ChartsToolStripMenuItem1})
        Me.BookingsToolStripMenuItem.Name = "BookingsToolStripMenuItem"
        Me.BookingsToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.BookingsToolStripMenuItem.Text = "Information"
        '
        'BookingsToolStripMenuItem1
        '
        Me.BookingsToolStripMenuItem1.Name = "BookingsToolStripMenuItem1"
        Me.BookingsToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.BookingsToolStripMenuItem1.Text = "Bookings"
        '
        'ChartsToolStripMenuItem1
        '
        Me.ChartsToolStripMenuItem1.Name = "ChartsToolStripMenuItem1"
        Me.ChartsToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ChartsToolStripMenuItem1.Text = "Charts"
        '
        'SpacesLAB
        '
        Me.SpacesLAB.AutoSize = True
        Me.SpacesLAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpacesLAB.Location = New System.Drawing.Point(97, 67)
        Me.SpacesLAB.Name = "SpacesLAB"
        Me.SpacesLAB.Size = New System.Drawing.Size(105, 13)
        Me.SpacesLAB.TabIndex = 2
        Me.SpacesLAB.Text = "Spaces Available"
        '
        'SpacesNUM
        '
        Me.SpacesNUM.AutoSize = True
        Me.SpacesNUM.Location = New System.Drawing.Point(97, 89)
        Me.SpacesNUM.Name = "SpacesNUM"
        Me.SpacesNUM.Size = New System.Drawing.Size(0, 13)
        Me.SpacesNUM.TabIndex = 3
        '
        'BookingsLAB
        '
        Me.BookingsLAB.AutoSize = True
        Me.BookingsLAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingsLAB.Location = New System.Drawing.Point(375, 67)
        Me.BookingsLAB.Name = "BookingsLAB"
        Me.BookingsLAB.Size = New System.Drawing.Size(120, 13)
        Me.BookingsLAB.TabIndex = 4
        Me.BookingsLAB.Text = "Number of bookings"
        '
        'BookingsNUM
        '
        Me.BookingsNUM.AutoSize = True
        Me.BookingsNUM.Location = New System.Drawing.Point(375, 89)
        Me.BookingsNUM.Name = "BookingsNUM"
        Me.BookingsNUM.Size = New System.Drawing.Size(0, 13)
        Me.BookingsNUM.TabIndex = 5
        '
        'ExpenseNUM
        '
        Me.ExpenseNUM.AutoSize = True
        Me.ExpenseNUM.Location = New System.Drawing.Point(252, 89)
        Me.ExpenseNUM.Name = "ExpenseNUM"
        Me.ExpenseNUM.Size = New System.Drawing.Size(0, 13)
        Me.ExpenseNUM.TabIndex = 7
        '
        'ExpenseLAB
        '
        Me.ExpenseLAB.AutoSize = True
        Me.ExpenseLAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpenseLAB.Location = New System.Drawing.Point(243, 67)
        Me.ExpenseLAB.Name = "ExpenseLAB"
        Me.ExpenseLAB.Size = New System.Drawing.Size(88, 13)
        Me.ExpenseLAB.TabIndex = 6
        Me.ExpenseLAB.Text = "Total Expense"
        '
        'Refresh
        '
        Me.Refresh.Interval = 3000
        '
        'Toggle1
        '
        Me.Toggle1.Checked = False
        Me.Toggle1.Location = New System.Drawing.Point(525, 196)
        Me.Toggle1.Name = "Toggle1"
        Me.Toggle1.Size = New System.Drawing.Size(63, 26)
        Me.Toggle1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(498, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Dark Mode!"
        '
        'WTMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 232)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Toggle1)
        Me.Controls.Add(Me.ExpenseNUM)
        Me.Controls.Add(Me.ExpenseLAB)
        Me.Controls.Add(Me.BookingsNUM)
        Me.Controls.Add(Me.BookingsLAB)
        Me.Controls.Add(Me.SpacesNUM)
        Me.Controls.Add(Me.SpacesLAB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WTMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Westwood Tours Mainframe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateInvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpacesLAB As Label
    Friend WithEvents SpacesNUM As Label
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChartsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BookingsLAB As Label
    Friend WithEvents BookingsNUM As Label
    Friend WithEvents ExpenseNUM As Label
    Friend WithEvents ExpenseLAB As Label
    Friend WithEvents Refresh As Timer
    Friend WithEvents Toggle1 As Toggle
    Friend WithEvents Label6 As Label
End Class
