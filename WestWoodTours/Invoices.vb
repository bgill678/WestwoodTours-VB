Imports System.Net.Mail
Imports System.Text.RegularExpressions
Public Class Invoice
    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    Dim exWB As Microsoft.Office.Interop.Excel.Workbook
    Dim exWS As Microsoft.Office.Interop.Excel.Worksheet
    Dim staffID As String
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
        exApp.Workbooks.Close()
    End Sub

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exWB = exApp.Workbooks.Open("D:\Documents\College 20-21\Application Design VS PROJ\Excel Files\data.xlsx")
        exWS = exWB.ActiveSheet
        Dim staffID As String = CInt(Int((855855 * Rnd()) + 1))
        Dim regex As Regex = New Regex("\w+")
        Me.Text = "Westwood Tours Mainframe - Staff ID: " + staffID
    End Sub

    Dim invoiceNUM As Integer = 1
    Private Sub InvoiceSendBTN_Click(sender As Object, e As EventArgs) Handles InvoiceSendBTN.Click
        Try
            'CHECKBOXES
            Dim price As String = True
            Dim max As String = True
            Dim places As String = True
            If PriceCBX.Checked Then
                If ToursLIST.SelectedItems.Count <= 0 Then
                    MsgBox("Please select a trip if you're using this option (Choose trip again when updating options)")
                ElseIf ToursLIST.SelectedItems.Count > 0 Then
                    If Me.ToursLIST.SelectedIndex = 0 Then
                        price = exWS.Range("B69").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 1 Then
                        price = exWS.Range("B70").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 2 Then
                        price = exWS.Range("B71").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 3 Then
                        price = exWS.Range("B72").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 4 Then
                        price = exWS.Range("B73").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 5 Then
                        price = exWS.Range("B74").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 6 Then
                        price = exWS.Range("B75").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 7 Then
                        price = exWS.Range("B76").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 8 Then
                        price = exWS.Range("B77").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 9 Then
                        price = exWS.Range("B78").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 10 Then
                        price = exWS.Range("B79").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 11 Then
                        price = exWS.Range("B80").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 12 Then
                        price = exWS.Range("B81").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 13 Then
                        price = exWS.Range("B82").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 14 Then
                        price = exWS.Range("B83").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 15 Then
                        price = exWS.Range("B84").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 16 Then
                        price = exWS.Range("B85").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 17 Then
                        price = exWS.Range("B86").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 18 Then
                        price = exWS.Range("B87").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 19 Then
                        price = exWS.Range("B88").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 20 Then
                        price = exWS.Range("B89").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 21 Then
                        price = exWS.Range("B90").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 22 Then
                        price = exWS.Range("B91").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 23 Then
                        price = exWS.Range("B92").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 24 Then
                        price = exWS.Range("B93").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 25 Then
                        price = exWS.Range("B94").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 26 Then
                        price = exWS.Range("B95").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 27 Then
                        price = exWS.Range("B96").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 28 Then
                        price = exWS.Range("B97").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 29 Then
                        price = exWS.Range("B98").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 30 Then
                        price = exWS.Range("B99").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 31 Then
                        price = exWS.Range("B100").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 32 Then
                        price = exWS.Range("B101").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 33 Then
                        price = exWS.Range("B102").Value.ToString
                    End If
                End If
            End If

            If PlacesCBX.Checked Then
                If ToursLIST.SelectedItems.Count <= 0 Then
                    MsgBox("Please select a trip if you're using this option (Choose trip again when updating options)")
                ElseIf ToursLIST.SelectedItems.Count > 0 Then

                    If Me.ToursLIST.SelectedIndex = 0 Then
                        places = exWS.Range("D69").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 1 Then
                        places = exWS.Range("D70").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 2 Then
                        places = exWS.Range("D71").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 3 Then
                        places = exWS.Range("D72").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 4 Then
                        places = exWS.Range("D73").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 5 Then
                        places = exWS.Range("D74").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 6 Then
                        places = exWS.Range("D75").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 7 Then
                        places = exWS.Range("D76").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 8 Then
                        places = exWS.Range("D77").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 9 Then
                        places = exWS.Range("D78").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 10 Then
                        places = exWS.Range("D79").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 11 Then
                        places = exWS.Range("D80").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 12 Then
                        places = exWS.Range("D81").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 13 Then
                        places = exWS.Range("D82").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 14 Then
                        places = exWS.Range("D83").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 15 Then
                        places = exWS.Range("D84").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 16 Then
                        places = exWS.Range("D85").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 17 Then
                        places = exWS.Range("D86").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 18 Then
                        places = exWS.Range("D87").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 19 Then
                        places = exWS.Range("D88").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 20 Then
                        places = exWS.Range("D89").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 21 Then
                        places = exWS.Range("D90").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 22 Then
                        places = exWS.Range("D91").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 23 Then
                        places = exWS.Range("D92").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 24 Then
                        places = exWS.Range("D93").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 25 Then
                        places = exWS.Range("D94").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 26 Then
                        places = exWS.Range("D95").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 27 Then
                        places = exWS.Range("D96").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 28 Then
                        places = exWS.Range("D97").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 29 Then
                        places = exWS.Range("D98").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 30 Then
                        places = exWS.Range("D99").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 31 Then
                        places = exWS.Range("D100").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 32 Then
                        places = exWS.Range("D101").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 33 Then
                        places = exWS.Range("D102").Value.ToString
                    End If
                End If
            End If

            If MaxCBX.Checked Then
                If ToursLIST.SelectedItems.Count <= 0 Then
                    MsgBox("Please select a trip if you're using this option (Choose trip again when updating options)")
                ElseIf ToursLIST.SelectedItems.Count > 0 Then

                    If Me.ToursLIST.SelectedIndex = 0 Then
                        max = exWS.Range("D69").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 1 Then
                        max = exWS.Range("D70").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 2 Then
                        max = exWS.Range("D71").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 3 Then
                        max = exWS.Range("D72").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 4 Then
                        max = exWS.Range("D73").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 5 Then
                        max = exWS.Range("D74").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 6 Then
                        max = exWS.Range("D75").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 7 Then
                        max = exWS.Range("D76").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 8 Then
                        max = exWS.Range("D77").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 9 Then
                        max = exWS.Range("D78").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 10 Then
                        max = exWS.Range("D79").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 11 Then
                        max = exWS.Range("D80").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 12 Then
                        max = exWS.Range("D81").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 13 Then
                        max = exWS.Range("D82").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 14 Then
                        max = exWS.Range("D83").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 15 Then
                        max = exWS.Range("D84").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 16 Then
                        max = exWS.Range("D85").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 17 Then
                        max = exWS.Range("D86").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 18 Then
                        max = exWS.Range("D87").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 19 Then
                        max = exWS.Range("D88").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 20 Then
                        max = exWS.Range("D89").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 21 Then
                        max = exWS.Range("D90").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 22 Then
                        max = exWS.Range("D91").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 23 Then
                        max = exWS.Range("D92").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 24 Then
                        max = exWS.Range("D93").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 25 Then
                        max = exWS.Range("D94").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 26 Then
                        max = exWS.Range("D95").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 27 Then
                        max = exWS.Range("D96").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 28 Then
                        max = exWS.Range("D97").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 29 Then
                        max = exWS.Range("D98").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 30 Then
                        max = exWS.Range("D99").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 31 Then
                        max = exWS.Range("D100").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 32 Then
                        max = exWS.Range("D101").Value.ToString
                    End If

                    If Me.ToursLIST.SelectedIndex = 33 Then
                        max = exWS.Range("D102").Value.ToString
                    End If
                End If
            End If

            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("joelcollierj14020@gmail.com", "JC1402011")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage
            e_mail.From = New MailAddress("heymangaming@hotmail.com")
            If String.IsNullOrEmpty(AddressBOX.Text) Then
                e_mail.To.Add(EmailBOX.SelectedItem.ToString)
            Else
                    e_mail.To.Add(AddressBOX.Text)
            End If
            e_mail.Subject = ("Invoice #" + invoiceNUM.ToString + "- " + "Customer: " + CustomerNameBOX.Text.ToString)
            invoiceNUM = invoiceNUM + 1
            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment("D:\Documents\College 20-21\Application Design VS PROJ\Westwood Tours Logo\WestwoodTours.png")
            e_mail.Attachments.Add(attachment)
            Dim emailBody As String = ""
            emailBody = "WESTWOOD TOURS" + vbLf
            If PriceCBX.Checked Then emailBody += "Price of trip " + "£" + price + vbLf
            If PlacesCBX.Checked Then emailBody += "Places available on the coach: " + places + vbLf
            If MaxCBX.Checked Then emailBody += "Max available spaces: " + max + vbLf + vbLf
            emailBody += "Staff Name: " + StaffNameBOX.Text + vbLf
            emailBody += "Please do not reply to this email as this was sent via an automatic application created by Bailey Gill for Westwood Tours." + vbLf + "© 2020 WESTWOOD TOURS"
            e_mail.Body = emailBody
            If MaxCBX.Checked Or PriceCBX.Checked Or PlacesCBX.Checked Then
                If EmailBOX.SelectedItems.Count >= 0 Or Not String.IsNullOrEmpty(AddressBOX.Text) Then
                    Smtp_Server.Send(e_mail)
                    MsgBox("Your invoice has been sent")
                Else
                    MsgBox("Please select an email on the left or use the box")
                End If
            Else
                MsgBox("You need to tick a box at the bottom to give the customer information.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class