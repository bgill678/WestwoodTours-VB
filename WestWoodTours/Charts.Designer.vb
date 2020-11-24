<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Charts
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Charts))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Toggle1 = New WestWoodTours.Toggle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.AdultBookingsLAB = New System.Windows.Forms.Label()
        Me.ChildBookingsLAB = New System.Windows.Forms.Label()
        Me.AverageBookingsLAB = New System.Windows.Forms.Label()
        Me.bookingsPerTripLAB = New System.Windows.Forms.Label()
        Me.profitPerCityLAB = New System.Windows.Forms.Label()
        Me.viewChartsBTN = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1207, 24)
        Me.MenuStrip1.TabIndex = 5
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
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'Toggle1
        '
        Me.Toggle1.Checked = False
        Me.Toggle1.Location = New System.Drawing.Point(553, 463)
        Me.Toggle1.Name = "Toggle1"
        Me.Toggle1.Size = New System.Drawing.Size(100, 28)
        Me.Toggle1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(551, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Dark Mode!"
        '
        'Chart1
        '
        ChartArea1.Name = "Adult Bookings"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 68)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "Adult Bookings"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(218, 200)
        Me.Chart1.TabIndex = 21
        Me.Chart1.Text = "Adult Bookings"
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(491, 68)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(218, 200)
        Me.Chart2.TabIndex = 22
        Me.Chart2.Text = "Chart2"
        '
        'Chart3
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend3)
        Me.Chart3.Location = New System.Drawing.Point(977, 68)
        Me.Chart3.Name = "Chart3"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart3.Series.Add(Series3)
        Me.Chart3.Size = New System.Drawing.Size(218, 200)
        Me.Chart3.TabIndex = 23
        Me.Chart3.Text = "Chart3"
        '
        'Chart4
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend4)
        Me.Chart4.Location = New System.Drawing.Point(12, 317)
        Me.Chart4.Name = "Chart4"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart4.Series.Add(Series4)
        Me.Chart4.Size = New System.Drawing.Size(218, 200)
        Me.Chart4.TabIndex = 25
        Me.Chart4.Text = "Chart4"
        '
        'Chart5
        '
        ChartArea5.Name = "ChartArea1"
        Me.Chart5.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart5.Legends.Add(Legend5)
        Me.Chart5.Location = New System.Drawing.Point(977, 317)
        Me.Chart5.Name = "Chart5"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.Chart5.Series.Add(Series5)
        Me.Chart5.Size = New System.Drawing.Size(218, 200)
        Me.Chart5.TabIndex = 26
        Me.Chart5.Text = "Chart5"
        '
        'AdultBookingsLAB
        '
        Me.AdultBookingsLAB.AutoSize = True
        Me.AdultBookingsLAB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdultBookingsLAB.Location = New System.Drawing.Point(58, 39)
        Me.AdultBookingsLAB.Name = "AdultBookingsLAB"
        Me.AdultBookingsLAB.Size = New System.Drawing.Size(91, 13)
        Me.AdultBookingsLAB.TabIndex = 28
        Me.AdultBookingsLAB.Text = "Adult Bookings"
        '
        'ChildBookingsLAB
        '
        Me.ChildBookingsLAB.AutoSize = True
        Me.ChildBookingsLAB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChildBookingsLAB.Location = New System.Drawing.Point(550, 39)
        Me.ChildBookingsLAB.Name = "ChildBookingsLAB"
        Me.ChildBookingsLAB.Size = New System.Drawing.Size(88, 13)
        Me.ChildBookingsLAB.TabIndex = 29
        Me.ChildBookingsLAB.Text = "Child Bookings"
        '
        'AverageBookingsLAB
        '
        Me.AverageBookingsLAB.AutoSize = True
        Me.AverageBookingsLAB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageBookingsLAB.Location = New System.Drawing.Point(1031, 39)
        Me.AverageBookingsLAB.Name = "AverageBookingsLAB"
        Me.AverageBookingsLAB.Size = New System.Drawing.Size(109, 13)
        Me.AverageBookingsLAB.TabIndex = 30
        Me.AverageBookingsLAB.Text = "Average Bookings"
        '
        'bookingsPerTripLAB
        '
        Me.bookingsPerTripLAB.AutoSize = True
        Me.bookingsPerTripLAB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookingsPerTripLAB.Location = New System.Drawing.Point(58, 291)
        Me.bookingsPerTripLAB.Name = "bookingsPerTripLAB"
        Me.bookingsPerTripLAB.Size = New System.Drawing.Size(103, 13)
        Me.bookingsPerTripLAB.TabIndex = 31
        Me.bookingsPerTripLAB.Text = "Bookings per trip"
        '
        'profitPerCityLAB
        '
        Me.profitPerCityLAB.AutoSize = True
        Me.profitPerCityLAB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profitPerCityLAB.Location = New System.Drawing.Point(1034, 291)
        Me.profitPerCityLAB.Name = "profitPerCityLAB"
        Me.profitPerCityLAB.Size = New System.Drawing.Size(85, 13)
        Me.profitPerCityLAB.TabIndex = 32
        Me.profitPerCityLAB.Text = "Profit per City"
        '
        'viewChartsBTN
        '
        Me.viewChartsBTN.Location = New System.Drawing.Point(491, 364)
        Me.viewChartsBTN.Name = "viewChartsBTN"
        Me.viewChartsBTN.Size = New System.Drawing.Size(218, 33)
        Me.viewChartsBTN.TabIndex = 33
        Me.viewChartsBTN.Text = "View Charts!"
        Me.viewChartsBTN.UseVisualStyleBackColor = True
        '
        'Charts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 595)
        Me.Controls.Add(Me.viewChartsBTN)
        Me.Controls.Add(Me.profitPerCityLAB)
        Me.Controls.Add(Me.bookingsPerTripLAB)
        Me.Controls.Add(Me.AverageBookingsLAB)
        Me.Controls.Add(Me.ChildBookingsLAB)
        Me.Controls.Add(Me.AdultBookingsLAB)
        Me.Controls.Add(Me.Chart5)
        Me.Controls.Add(Me.Chart4)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Toggle1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Charts"
        Me.Text = "WT Charts"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Toggle1 As Toggle
    Friend WithEvents Label6 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As DataVisualization.Charting.Chart
    Friend WithEvents Chart5 As DataVisualization.Charting.Chart
    Friend WithEvents AdultBookingsLAB As Label
    Friend WithEvents ChildBookingsLAB As Label
    Friend WithEvents AverageBookingsLAB As Label
    Friend WithEvents bookingsPerTripLAB As Label
    Friend WithEvents profitPerCityLAB As Label
    Friend WithEvents viewChartsBTN As Button
End Class
