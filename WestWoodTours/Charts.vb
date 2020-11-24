
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

    Private Sub Charts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim staffID As String = CInt(Int((855855 * Rnd()) + 1))
        Dim MsgBoxText As String = "please make sure that you click the View Charts button while the visible charts are under maintenance!"
        MessageBox.Show("Hello {0} {1}".Format(staffID, MsgBoxText))
    End Sub

    Private Sub viewChartsBTN_Click(sender As Object, e As EventArgs) Handles viewChartsBTN.Click
        Dim command As String = "start excel D:\data.xlsx"
        Shell("cmd.exe /k" + command)
        Application.Exit()
    End Sub
End Class