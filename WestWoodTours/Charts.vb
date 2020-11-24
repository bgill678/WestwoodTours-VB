
Public Class Charts
    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Dim exWB As Microsoft.Office.Interop.Excel.Workbook
    Dim exWS As Microsoft.Office.Interop.Excel.Worksheet
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
        exApp.Workbooks.Close()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click

    End Sub
End Class