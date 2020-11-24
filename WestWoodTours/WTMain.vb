Imports System.Threading
Module Darkmode
    Private m_FormBackgroundColor As Color
    Public Property FormBackgroundColor As Color
        Get
            Return m_FormBackgroundColor
        End Get
        Set(value As Color)
            m_FormBackgroundColor = value
            For Each Frm As Form In Application.OpenForms
                Frm.BackColor = m_FormBackgroundColor
            Next
        End Set
    End Property
End Module
Public Class WTMain

    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Dim exWB As Microsoft.Office.Interop.Excel.Workbook
    Dim exWS As Microsoft.Office.Interop.Excel.Worksheet
    Private Sub WTMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exWB = exApp.Workbooks.Open("D:\data.xlsx")
        exWS = exWB.ActiveSheet
        SpacesNUM.Text = exWS.Range("N62").Value.ToString
        ExpenseNUM.Text = exWS.Range("I3").Value.ToString
        BookingsNUM.Text = exWS.Range("A3").Value.ToString
        Me.BackColor = FormBackgroundColor
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

    Private Sub RefreshChartToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Toggle1_Load(sender As Object, e As EventArgs) Handles Toggle1.Load

    End Sub

    Private Sub ChartsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChartsToolStripMenuItem1.Click
        Dim charts = New Charts()
        charts.Show()
    End Sub
End Class
