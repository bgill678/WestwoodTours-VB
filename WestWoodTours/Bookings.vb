Public Class Bookings
    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Dim exWB As Microsoft.Office.Interop.Excel.Workbook
    Dim exWS As Microsoft.Office.Interop.Excel.Worksheet

    Private Sub Bookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exWB = exApp.Workbooks.Open("D:\Documents\College 20-21\Application Design VS PROJ\Excel Files\data.xlsx")
        exWS = exWB.ActiveSheet
    End Sub

    Private Sub TripCODES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TripCODES.SelectedIndexChanged
        If Me.TripCODES.SelectedIndex = 0 Then
            TripPriceNUM.Text = exWS.Range("J14").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B14").Value.ToString
            TripTakenNUM.Text = exWS.Range("F14").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N14").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D14").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E14").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J14").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F69").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 1 Then
            TripPriceNUM.Text = exWS.Range("J15").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B15").Value.ToString
            TripTakenNUM.Text = exWS.Range("F15").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N15").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D15").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E15").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J15").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F70").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 2 Then
            TripPriceNUM.Text = exWS.Range("J16").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B16").Value.ToString
            TripTakenNUM.Text = exWS.Range("F16").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N16").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D16").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E16").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J16").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F71").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 3 Then
            TripPriceNUM.Text = exWS.Range("J17").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B17").Value.ToString
            TripTakenNUM.Text = exWS.Range("F17").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N17").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D17").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E17").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J17").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F72").Value.ToString
        End If
        If Me.TripCODES.SelectedIndex = 4 Then
            TripPriceNUM.Text = exWS.Range("J20").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B20").Value.ToString
            TripTakenNUM.Text = exWS.Range("F20").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N20").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D20").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E20").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J20").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F73").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 5 Then
            TripPriceNUM.Text = exWS.Range("J21").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B21").Value.ToString
            TripTakenNUM.Text = exWS.Range("F21").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N21").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D21").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E21").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J21").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F74").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 6 Then
            TripPriceNUM.Text = exWS.Range("J22").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B22").Value.ToString
            TripTakenNUM.Text = exWS.Range("F22").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N22").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D22").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E22").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J22").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F75").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 7 Then
            TripPriceNUM.Text = exWS.Range("J25").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B25").Value.ToString
            TripTakenNUM.Text = exWS.Range("F25").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N25").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D25").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E25").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J25").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F76").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 8 Then
            TripPriceNUM.Text = exWS.Range("J26").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B26").Value.ToString
            TripTakenNUM.Text = exWS.Range("F26").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N26").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D26").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E26").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J26").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F77").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 9 Then
            TripPriceNUM.Text = exWS.Range("J27").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B27").Value.ToString
            TripTakenNUM.Text = exWS.Range("F27").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N27").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D27").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E27").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J27").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F78").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 10 Then
            TripPriceNUM.Text = exWS.Range("J30").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B30").Value.ToString
            TripTakenNUM.Text = exWS.Range("F30").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N30").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D30").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E30").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J30").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F79").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 11 Then
            TripPriceNUM.Text = exWS.Range("J31").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B31").Value.ToString
            TripTakenNUM.Text = exWS.Range("F31").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N31").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D31").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E31").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J31").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F80").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 12 Then
            TripPriceNUM.Text = exWS.Range("J32").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B32").Value.ToString
            TripTakenNUM.Text = exWS.Range("F32").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N32").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D32").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E32").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J32").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F81").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 13 Then
            TripPriceNUM.Text = exWS.Range("J33").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B33").Value.ToString
            TripTakenNUM.Text = exWS.Range("F33").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N33").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D33").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E33").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J33").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F82").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 14 Then
            TripPriceNUM.Text = exWS.Range("J34").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B34").Value.ToString
            TripTakenNUM.Text = exWS.Range("F34").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N34").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D34").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E34").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J34").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F83").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 15 Then
            TripPriceNUM.Text = exWS.Range("J37").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B37").Value.ToString
            TripTakenNUM.Text = exWS.Range("F37").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N37").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D37").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E37").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J37").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F84").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 16 Then
            TripPriceNUM.Text = exWS.Range("J38").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B38").Value.ToString
            TripTakenNUM.Text = exWS.Range("F38").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N38").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D38").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E38").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J38").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F85").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 17 Then
            TripPriceNUM.Text = exWS.Range("J39").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B39").Value.ToString
            TripTakenNUM.Text = exWS.Range("F39").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N39").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D39").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E39").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J39").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F86").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 18 Then
            TripPriceNUM.Text = exWS.Range("J40").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B40").Value.ToString
            TripTakenNUM.Text = exWS.Range("F40").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N40").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D40").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E40").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J40").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F87").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 19 Then
            TripPriceNUM.Text = exWS.Range("J41").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B41").Value.ToString
            TripTakenNUM.Text = exWS.Range("F41").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N41").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D41").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E41").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J41").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F88").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 20 Then
            TripPriceNUM.Text = exWS.Range("J44").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B44").Value.ToString
            TripTakenNUM.Text = exWS.Range("F44").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N44").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D44").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E44").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J44").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F89").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 21 Then
            TripPriceNUM.Text = exWS.Range("J45").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B45").Value.ToString
            TripTakenNUM.Text = exWS.Range("F45").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N45").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D45").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E45").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J45").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F90").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 22 Then
            TripPriceNUM.Text = exWS.Range("J46").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B46").Value.ToString
            TripTakenNUM.Text = exWS.Range("F46").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N46").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D46").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E46").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J46").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F91").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 23 Then
            TripPriceNUM.Text = exWS.Range("J47").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B47").Value.ToString
            TripTakenNUM.Text = exWS.Range("F47").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N47").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D47").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E47").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J47").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F92").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 24 Then
            TripPriceNUM.Text = exWS.Range("J50").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B50").Value.ToString
            TripTakenNUM.Text = exWS.Range("F50").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N50").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D50").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E50").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J50").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F93").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 25 Then
            TripPriceNUM.Text = exWS.Range("J51").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B51").Value.ToString
            TripTakenNUM.Text = exWS.Range("F51").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N51").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D51").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E51").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J51").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F94").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 26 Then
            TripPriceNUM.Text = exWS.Range("J52").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B52").Value.ToString
            TripTakenNUM.Text = exWS.Range("F52").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N52").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D52").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E52").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J52").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F95").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 27 Then
            TripPriceNUM.Text = exWS.Range("J55").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B55").Value.ToString
            TripTakenNUM.Text = exWS.Range("F55").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N55").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D55").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E55").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J55").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F96").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 28 Then
            TripPriceNUM.Text = exWS.Range("J56").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B56").Value.ToString
            TripTakenNUM.Text = exWS.Range("F56").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N56").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D56").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E56").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J56").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F97").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 29 Then
            TripPriceNUM.Text = exWS.Range("J57").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B57").Value.ToString
            TripTakenNUM.Text = exWS.Range("F57").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N57").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D57").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E57").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J57").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F98").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 30 Then
            TripPriceNUM.Text = exWS.Range("J58").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B58").Value.ToString
            TripTakenNUM.Text = exWS.Range("F58").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N58").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D58").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E58").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J58").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F99").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 31 Then
            TripPriceNUM.Text = exWS.Range("J59").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B59").Value.ToString
            TripTakenNUM.Text = exWS.Range("F59").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N59").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D59").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E59").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J59").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F100").Value.ToString
        End If

        If Me.TripCODES.SelectedIndex = 32 Then
            TripPriceNUM.Text = exWS.Range("J60").Value.ToString
            TripMaximumNUM.Text = exWS.Range("B60").Value.ToString
            TripTakenNUM.Text = exWS.Range("F60").Value.ToString
            TripAvailableNUM.Text = exWS.Range("N60").Value.ToString
            AdultBookingsNUM.Text = exWS.Range("D60").Value.ToString
            ChildBookingsNUM.Text = exWS.Range("E60").Value.ToString
            SalesBookingsNUM.Text = exWS.Range("J60").Value.ToString
            ProfitBookingsNUM.Text = exWS.Range("F101").Value.ToString
        End If
    End Sub

    Private Sub CityNAMES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CityNAMES.SelectedIndexChanged
        If Me.CityNAMES.SelectedIndex = 0 Then
            CityToursNUM.Text = exWS.Range("K3").Value.ToString
            CityAverageNUM.Text = exWS.Range("L3").Value.ToString
        End If

        If Me.CityNAMES.SelectedIndex = 1 Then
            CityToursNUM.Text = exWS.Range("K4").Value.ToString
            CityAverageNUM.Text = exWS.Range("L4").Value.ToString
        End If

        If Me.CityNAMES.SelectedIndex = 2 Then
            CityToursNUM.Text = exWS.Range("K5").Value.ToString
            CityAverageNUM.Text = exWS.Range("L5").Value.ToString
        End If

        If Me.CityNAMES.SelectedIndex = 3 Then
            CityToursNUM.Text = exWS.Range("K6").Value.ToString
            CityAverageNUM.Text = exWS.Range("L6").Value.ToString
        End If

        If Me.CityNAMES.SelectedIndex = 4 Then
            CityToursNUM.Text = exWS.Range("K7").Value.ToString
            CityAverageNUM.Text = exWS.Range("L7").Value.ToString
        End If

        If Me.CityNAMES.SelectedIndex = 5 Then
            CityToursNUM.Text = exWS.Range("K8").Value.ToString
            CityAverageNUM.Text = exWS.Range("L8").Value.ToString
        End If

        If Me.CityNAMES.SelectedIndex = 6 Then
            CityToursNUM.Text = exWS.Range("K9").Value.ToString
            CityAverageNUM.Text = exWS.Range("L9").Value.ToString
        End If

        If Me.CityNAMES.SelectedIndex = 7 Then
            CityToursNUM.Text = exWS.Range("K10").Value.ToString
            CityAverageNUM.Text = exWS.Range("L10").Value.ToString
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
        exApp.Workbooks.Close()
    End Sub
End Class