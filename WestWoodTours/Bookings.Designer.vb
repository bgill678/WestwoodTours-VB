<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bookings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bookings))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TripCODES = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookingTripPRICE = New System.Windows.Forms.Label()
        Me.BookingTripMAXIUMUM = New System.Windows.Forms.Label()
        Me.BookingTripTAKEN = New System.Windows.Forms.Label()
        Me.BookingTripAVAILABLE = New System.Windows.Forms.Label()
        Me.TripPriceNUM = New System.Windows.Forms.Label()
        Me.TripMaximumNUM = New System.Windows.Forms.Label()
        Me.TripTakenNUM = New System.Windows.Forms.Label()
        Me.TripAvailableNUM = New System.Windows.Forms.Label()
        Me.AdultBookingsNUM = New System.Windows.Forms.Label()
        Me.BookingTripADULT = New System.Windows.Forms.Label()
        Me.ChildBookingsNUM = New System.Windows.Forms.Label()
        Me.BookingTripCHILD = New System.Windows.Forms.Label()
        Me.SalesBookingsNUM = New System.Windows.Forms.Label()
        Me.BookingTripSALES = New System.Windows.Forms.Label()
        Me.CashSymbol1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CashSymbol2 = New System.Windows.Forms.Label()
        Me.ProfitBookingsNUM = New System.Windows.Forms.Label()
        Me.BookingTripPROFIT = New System.Windows.Forms.Label()
        Me.CityNAMES = New System.Windows.Forms.ListBox()
        Me.CityToursNUM = New System.Windows.Forms.Label()
        Me.ToursNumberLAB = New System.Windows.Forms.Label()
        Me.CityAverageNUM = New System.Windows.Forms.Label()
        Me.AverageNumberLAB = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'TripCODES
        '
        Me.TripCODES.FormattingEnabled = True
        Me.TripCODES.Items.AddRange(New Object() {"BMOU2", "BGIA5", "BFOL5", "BCIT4", "DWHI4", "DLEE4", "DCAS2", "ELLOM3", "ECIT2", "EBRI4", "HYOR3", "HHUM2", "HCIT1", "HBUR2", "HBEV2", "LYOR2", "LWAR2", "LMAN1", "LCIT3", "LCHA5", "LWIN3", "LROY3", "LMUS2", "LCIT8", "NHAD2", "NCIT1", "NALA4", "SWIN4", "SWEY2", "SISLE5", "SHIG3", "SDID2", "SCOT7"})
        Me.TripCODES.Location = New System.Drawing.Point(12, 117)
        Me.TripCODES.Name = "TripCODES"
        Me.TripCODES.Size = New System.Drawing.Size(225, 186)
        Me.TripCODES.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Trip Codes"
        '
        'BookingTripPRICE
        '
        Me.BookingTripPRICE.AutoSize = True
        Me.BookingTripPRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingTripPRICE.Location = New System.Drawing.Point(18, 322)
        Me.BookingTripPRICE.Name = "BookingTripPRICE"
        Me.BookingTripPRICE.Size = New System.Drawing.Size(77, 13)
        Me.BookingTripPRICE.TabIndex = 5
        Me.BookingTripPRICE.Text = "Price of Trip"
        '
        'BookingTripMAXIUMUM
        '
        Me.BookingTripMAXIUMUM.AutoSize = True
        Me.BookingTripMAXIUMUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingTripMAXIUMUM.Location = New System.Drawing.Point(158, 322)
        Me.BookingTripMAXIUMUM.Name = "BookingTripMAXIUMUM"
        Me.BookingTripMAXIUMUM.Size = New System.Drawing.Size(100, 13)
        Me.BookingTripMAXIUMUM.TabIndex = 6
        Me.BookingTripMAXIUMUM.Text = "Maximum Places"
        '
        'BookingTripTAKEN
        '
        Me.BookingTripTAKEN.AutoSize = True
        Me.BookingTripTAKEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingTripTAKEN.Location = New System.Drawing.Point(15, 443)
        Me.BookingTripTAKEN.Name = "BookingTripTAKEN"
        Me.BookingTripTAKEN.Size = New System.Drawing.Size(85, 13)
        Me.BookingTripTAKEN.TabIndex = 7
        Me.BookingTripTAKEN.Text = "Places Taken"
        '
        'BookingTripAVAILABLE
        '
        Me.BookingTripAVAILABLE.AutoSize = True
        Me.BookingTripAVAILABLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingTripAVAILABLE.Location = New System.Drawing.Point(159, 443)
        Me.BookingTripAVAILABLE.Name = "BookingTripAVAILABLE"
        Me.BookingTripAVAILABLE.Size = New System.Drawing.Size(101, 13)
        Me.BookingTripAVAILABLE.TabIndex = 8
        Me.BookingTripAVAILABLE.Text = "Places Available"
        '
        'TripPriceNUM
        '
        Me.TripPriceNUM.AutoSize = True
        Me.TripPriceNUM.BackColor = System.Drawing.Color.Transparent
        Me.TripPriceNUM.Location = New System.Drawing.Point(24, 348)
        Me.TripPriceNUM.Name = "TripPriceNUM"
        Me.TripPriceNUM.Size = New System.Drawing.Size(0, 13)
        Me.TripPriceNUM.TabIndex = 9
        '
        'TripMaximumNUM
        '
        Me.TripMaximumNUM.AutoSize = True
        Me.TripMaximumNUM.BackColor = System.Drawing.Color.Transparent
        Me.TripMaximumNUM.Location = New System.Drawing.Point(158, 348)
        Me.TripMaximumNUM.Name = "TripMaximumNUM"
        Me.TripMaximumNUM.Size = New System.Drawing.Size(0, 13)
        Me.TripMaximumNUM.TabIndex = 10
        '
        'TripTakenNUM
        '
        Me.TripTakenNUM.AutoSize = True
        Me.TripTakenNUM.Location = New System.Drawing.Point(15, 469)
        Me.TripTakenNUM.Name = "TripTakenNUM"
        Me.TripTakenNUM.Size = New System.Drawing.Size(0, 13)
        Me.TripTakenNUM.TabIndex = 11
        '
        'TripAvailableNUM
        '
        Me.TripAvailableNUM.AutoSize = True
        Me.TripAvailableNUM.Location = New System.Drawing.Point(159, 469)
        Me.TripAvailableNUM.Name = "TripAvailableNUM"
        Me.TripAvailableNUM.Size = New System.Drawing.Size(0, 13)
        Me.TripAvailableNUM.TabIndex = 12
        '
        'AdultBookingsNUM
        '
        Me.AdultBookingsNUM.AutoSize = True
        Me.AdultBookingsNUM.Location = New System.Drawing.Point(18, 400)
        Me.AdultBookingsNUM.Name = "AdultBookingsNUM"
        Me.AdultBookingsNUM.Size = New System.Drawing.Size(0, 13)
        Me.AdultBookingsNUM.TabIndex = 14
        '
        'BookingTripADULT
        '
        Me.BookingTripADULT.AutoSize = True
        Me.BookingTripADULT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingTripADULT.Location = New System.Drawing.Point(15, 382)
        Me.BookingTripADULT.Name = "BookingTripADULT"
        Me.BookingTripADULT.Size = New System.Drawing.Size(92, 13)
        Me.BookingTripADULT.TabIndex = 13
        Me.BookingTripADULT.Text = "Adult Bookings"
        '
        'ChildBookingsNUM
        '
        Me.ChildBookingsNUM.AutoSize = True
        Me.ChildBookingsNUM.Location = New System.Drawing.Point(159, 400)
        Me.ChildBookingsNUM.Name = "ChildBookingsNUM"
        Me.ChildBookingsNUM.Size = New System.Drawing.Size(0, 13)
        Me.ChildBookingsNUM.TabIndex = 16
        '
        'BookingTripCHILD
        '
        Me.BookingTripCHILD.AutoSize = True
        Me.BookingTripCHILD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingTripCHILD.Location = New System.Drawing.Point(159, 382)
        Me.BookingTripCHILD.Name = "BookingTripCHILD"
        Me.BookingTripCHILD.Size = New System.Drawing.Size(91, 13)
        Me.BookingTripCHILD.TabIndex = 15
        Me.BookingTripCHILD.Text = "Child Bookings"
        '
        'SalesBookingsNUM
        '
        Me.SalesBookingsNUM.AutoSize = True
        Me.SalesBookingsNUM.Location = New System.Drawing.Point(19, 527)
        Me.SalesBookingsNUM.Name = "SalesBookingsNUM"
        Me.SalesBookingsNUM.Size = New System.Drawing.Size(0, 13)
        Me.SalesBookingsNUM.TabIndex = 18
        '
        'BookingTripSALES
        '
        Me.BookingTripSALES.AutoSize = True
        Me.BookingTripSALES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingTripSALES.Location = New System.Drawing.Point(15, 501)
        Me.BookingTripSALES.Name = "BookingTripSALES"
        Me.BookingTripSALES.Size = New System.Drawing.Size(71, 13)
        Me.BookingTripSALES.TabIndex = 17
        Me.BookingTripSALES.Text = "Total Sales"
        '
        'CashSymbol1
        '
        Me.CashSymbol1.AutoSize = True
        Me.CashSymbol1.Location = New System.Drawing.Point(6, 527)
        Me.CashSymbol1.Name = "CashSymbol1"
        Me.CashSymbol1.Size = New System.Drawing.Size(13, 13)
        Me.CashSymbol1.TabIndex = 19
        Me.CashSymbol1.Text = "£"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(5, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "£"
        '
        'CashSymbol2
        '
        Me.CashSymbol2.AutoSize = True
        Me.CashSymbol2.Location = New System.Drawing.Point(155, 527)
        Me.CashSymbol2.Name = "CashSymbol2"
        Me.CashSymbol2.Size = New System.Drawing.Size(13, 13)
        Me.CashSymbol2.TabIndex = 23
        Me.CashSymbol2.Text = "£"
        '
        'ProfitBookingsNUM
        '
        Me.ProfitBookingsNUM.AutoSize = True
        Me.ProfitBookingsNUM.Location = New System.Drawing.Point(168, 527)
        Me.ProfitBookingsNUM.Name = "ProfitBookingsNUM"
        Me.ProfitBookingsNUM.Size = New System.Drawing.Size(0, 13)
        Me.ProfitBookingsNUM.TabIndex = 22
        '
        'BookingTripPROFIT
        '
        Me.BookingTripPROFIT.AutoSize = True
        Me.BookingTripPROFIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingTripPROFIT.Location = New System.Drawing.Point(159, 501)
        Me.BookingTripPROFIT.Name = "BookingTripPROFIT"
        Me.BookingTripPROFIT.Size = New System.Drawing.Size(70, 13)
        Me.BookingTripPROFIT.TabIndex = 21
        Me.BookingTripPROFIT.Text = "Total Profit"
        '
        'CityNAMES
        '
        Me.CityNAMES.FormattingEnabled = True
        Me.CityNAMES.Items.AddRange(New Object() {"Belfast", "Dover", "Edinburgh", "Hull", "Liverpool", "London", "Newcastle", "Southampton"})
        Me.CityNAMES.Location = New System.Drawing.Point(674, 117)
        Me.CityNAMES.Name = "CityNAMES"
        Me.CityNAMES.Size = New System.Drawing.Size(186, 147)
        Me.CityNAMES.TabIndex = 24
        '
        'CityToursNUM
        '
        Me.CityToursNUM.AutoSize = True
        Me.CityToursNUM.Location = New System.Drawing.Point(671, 346)
        Me.CityToursNUM.Name = "CityToursNUM"
        Me.CityToursNUM.Size = New System.Drawing.Size(0, 13)
        Me.CityToursNUM.TabIndex = 26
        '
        'ToursNumberLAB
        '
        Me.ToursNumberLAB.AutoSize = True
        Me.ToursNumberLAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToursNumberLAB.Location = New System.Drawing.Point(671, 322)
        Me.ToursNumberLAB.Name = "ToursNumberLAB"
        Me.ToursNumberLAB.Size = New System.Drawing.Size(141, 13)
        Me.ToursNumberLAB.TabIndex = 25
        Me.ToursNumberLAB.Text = "Number of tours offered"
        '
        'CityAverageNUM
        '
        Me.CityAverageNUM.AutoSize = True
        Me.CityAverageNUM.Location = New System.Drawing.Point(671, 418)
        Me.CityAverageNUM.Name = "CityAverageNUM"
        Me.CityAverageNUM.Size = New System.Drawing.Size(0, 13)
        Me.CityAverageNUM.TabIndex = 28
        '
        'AverageNumberLAB
        '
        Me.AverageNumberLAB.AutoSize = True
        Me.AverageNumberLAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageNumberLAB.Location = New System.Drawing.Point(671, 394)
        Me.AverageNumberLAB.Name = "AverageNumberLAB"
        Me.AverageNumberLAB.Size = New System.Drawing.Size(169, 13)
        Me.AverageNumberLAB.TabIndex = 27
        Me.AverageNumberLAB.Text = "Average number of bookings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(722, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 33)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Cities"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(247, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 39)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Please select a trip from the selection box on the left. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will then show th" &
    "e information of said trip below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<---"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(316, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 33)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Help!?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(247, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(307, 39)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "On the right you will see a selection of Cities from the database. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please selec" &
    "t one to view information about that specific City. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--->"
        '
        'Bookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 559)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CityAverageNUM)
        Me.Controls.Add(Me.AverageNumberLAB)
        Me.Controls.Add(Me.CityToursNUM)
        Me.Controls.Add(Me.ToursNumberLAB)
        Me.Controls.Add(Me.CityNAMES)
        Me.Controls.Add(Me.CashSymbol2)
        Me.Controls.Add(Me.ProfitBookingsNUM)
        Me.Controls.Add(Me.BookingTripPROFIT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CashSymbol1)
        Me.Controls.Add(Me.SalesBookingsNUM)
        Me.Controls.Add(Me.BookingTripSALES)
        Me.Controls.Add(Me.ChildBookingsNUM)
        Me.Controls.Add(Me.BookingTripCHILD)
        Me.Controls.Add(Me.AdultBookingsNUM)
        Me.Controls.Add(Me.BookingTripADULT)
        Me.Controls.Add(Me.TripAvailableNUM)
        Me.Controls.Add(Me.TripTakenNUM)
        Me.Controls.Add(Me.TripMaximumNUM)
        Me.Controls.Add(Me.TripPriceNUM)
        Me.Controls.Add(Me.BookingTripAVAILABLE)
        Me.Controls.Add(Me.BookingTripTAKEN)
        Me.Controls.Add(Me.BookingTripMAXIUMUM)
        Me.Controls.Add(Me.BookingTripPRICE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TripCODES)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bookings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "WT Bookings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TripCODES As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BookingTripPRICE As Label
    Friend WithEvents BookingTripMAXIUMUM As Label
    Friend WithEvents BookingTripTAKEN As Label
    Friend WithEvents BookingTripAVAILABLE As Label
    Friend WithEvents TripPriceNUM As Label
    Friend WithEvents TripMaximumNUM As Label
    Friend WithEvents TripTakenNUM As Label
    Friend WithEvents TripAvailableNUM As Label
    Friend WithEvents AdultBookingsNUM As Label
    Friend WithEvents BookingTripADULT As Label
    Friend WithEvents ChildBookingsNUM As Label
    Friend WithEvents BookingTripCHILD As Label
    Friend WithEvents SalesBookingsNUM As Label
    Friend WithEvents BookingTripSALES As Label
    Friend WithEvents CashSymbol1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CashSymbol2 As Label
    Friend WithEvents ProfitBookingsNUM As Label
    Friend WithEvents BookingTripPROFIT As Label
    Friend WithEvents CityNAMES As ListBox
    Friend WithEvents CityToursNUM As Label
    Friend WithEvents ToursNumberLAB As Label
    Friend WithEvents CityAverageNUM As Label
    Friend WithEvents AverageNumberLAB As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
