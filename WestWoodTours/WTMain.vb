Imports System.Threading

Public Class WTMain

    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Dim exWB As Microsoft.Office.Interop.Excel.Workbook
    Dim exWS As Microsoft.Office.Interop.Excel.Worksheet
    Private Sub WTMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exWB = exApp.Workbooks.Open("D:\Documents\College 20-21\Application Design VS PROJ\Excel Files\data.xlsx")
        exWS = exWB.ActiveSheet
        SpacesNUM.Text = exWS.Range("N62").Value.ToString
        ExpenseNUM.Text = exWS.Range("I3").Value.ToString
        BookingsNUM.Text = exWS.Range("A3").Value.ToString
    End Sub


    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
        exApp.Workbooks.Close()

    End Sub

    Private Sub CreateInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateInvoiceToolStripMenuItem.Click
        Dim invoices = New Invoice()
        invoices.Show()
    End Sub

    Private Sub BookingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BookingsToolStripMenuItem1.Click
        Dim bookings = New Bookings()
        bookings.Show()
    End Sub

    Private Sub ExpenseLAB_Click(sender As Object, e As EventArgs) Handles ExpenseLAB.Click

    End Sub

    Private Sub AveragesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RefreshChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshChartToolStripMenuItem.Click

    End Sub
End Class
