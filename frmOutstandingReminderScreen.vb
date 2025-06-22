
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net.Mail.SmtpException
Imports System.Net
Imports System.IO
Imports System.Collections.Specialized
Imports System.Text

Imports System.Windows.Forms
Imports System.Windows

Imports Microsoft.Office.Interop

Imports System.Net.Mail.MailMessage


Public Class frmOutstandingReminderScreen
    Dim blnLoading As Boolean = True
    Dim dtBill As DataTable
    Dim dtTable As DataTable
    Dim i As Integer
    Dim WithEvents dtQty As DataTable
    Dim blnNewRow As Boolean
    Dim WhatsMsg As Boolean = False
    Dim MailMsg As Boolean = False




    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Common.ClearControls(grpMain)
        dtgBill.DataSource = Nothing
        grpMain.Enabled = False
        dtgBill.ReadOnly = True
        cmbLedger.Properties.DataSource = Nothing
        cmbLedger.SetEditValue("")
        '-------------------

        '--------------------------
        Me.Close()

    End Sub

    Private Sub frmSaleBillUpdation1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmOutstandingReminderScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' grpMain.Enabled = False
        Query = "Select Distinct LED_KEY, LED_NAME " _
                     & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                     & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                     & " And AccLGrp.AccLgrp_Type in(3,4)  " _
                     & " Order By Led_Name"
        Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")


        ' dtgBill.ReadOnly = True

        dtgBill.ContextMenu = mnuSelection

        Call btnShow_Click(btnShow, Nothing)

        If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftWareForGcube)) = 1 Then
            mnuCustomer.Visible = False
            mnuVendors.Visible = False
        End If

        cmbLedger.Focus()
    End Sub

    Private Sub DisplayHeader(ByVal dtTable As DataTable)
        Dim tblStyle As New DataGridTableStyle

        With tblStyle
            .MappingName = dtTable.TableName
            .HeaderFont = New System.Drawing.Font("Verdana", 8, FontStyle.Bold, GraphicsUnit.Point)
            .RowHeaderWidth = 12
            .ReadOnly = False
            .ForeColor = Color.DarkBlue
            .SelectionBackColor = Color.Lavender
            .SelectionForeColor = Color.DarkBlue
            .GridLineColor = Color.SteelBlue
            .HeaderForeColor = Color.Maroon
        End With


        Dim colMark As New DataGridBoolColumn
        With colMark
            .MappingName = dtTable.Columns(0).ColumnName
            .HeaderText = "Select"
            .Width = 45
            .TrueValue = "1"
            .FalseValue = "0"
            .AllowNull = False
        End With

        Dim colPartyKey As New DataGridTextBoxColumn
        With colPartyKey
            .MappingName = dtTable.Columns(1).ColumnName
            .HeaderText = "Party_Key"
            .Width = 0
            .ReadOnly = True
        End With

        Dim colParty As New DataGridTextBoxColumn
        With colParty
            .MappingName = dtTable.Columns(2).ColumnName
            .HeaderText = "Party"
            .Alignment = HorizontalAlignment.Left
            .Width = 200
            .ReadOnly = True
        End With

        Dim colCity As New DataGridTextBoxColumn
        With colCity
            .MappingName = dtTable.Columns(3).ColumnName
            .HeaderText = "Station"
            .Alignment = HorizontalAlignment.Left
            .Width = 100
            .ReadOnly = True
        End With

        Dim colMobileNo As New DataGridTextBoxColumn
        With colMobileNo
            .MappingName = dtTable.Columns(4).ColumnName
            .HeaderText = "Mobile No"
            .Alignment = HorizontalAlignment.Left
            .Width = 80
            .ReadOnly = True
        End With

        Dim colWhatsAppNo As New DataGridTextBoxColumn
        With colWhatsAppNo
            .MappingName = dtTable.Columns(5).ColumnName
            .HeaderText = "WhatsApp No."
            .Alignment = HorizontalAlignment.Left
            .Width = 100
            .ReadOnly = True
        End With

        Dim colEmail As New DataGridTextBoxColumn
        With colEmail
            .MappingName = dtTable.Columns(6).ColumnName
            .HeaderText = "Email Id"
            .Alignment = HorizontalAlignment.Left
            .Width = 180
            .ReadOnly = True
        End With

        Dim colBrokerKey As New DataGridTextBoxColumn
        With colBrokerKey
            .MappingName = dtTable.Columns(7).ColumnName
            .HeaderText = "Broker_Key"
            .Width = 0
            .ReadOnly = True
        End With

        Dim colBalAmt As New DataGridTextBoxColumn
        With colBalAmt
            .MappingName = dtTable.Columns(8).ColumnName
            .HeaderText = "Bal Amt."
            .Alignment = HorizontalAlignment.Right
            .Width = 100
            .ReadOnly = True
        End With

        Dim colBrokerName As New DataGridTextBoxColumn
        With colBrokerName
            .MappingName = dtTable.Columns(9).ColumnName
            .HeaderText = "Broker Name"
            .Alignment = HorizontalAlignment.Left
            .Width = 120
            .ReadOnly = True
        End With

       

        Dim colFlag As New DataGridTextBoxColumn
        With colFlag
            .MappingName = dtTable.Columns(10).ColumnName
            .HeaderText = ""
            .Width = 0
            .ReadOnly = True
        End With





        tblStyle.GridColumnStyles.Clear()
        tblStyle.GridColumnStyles.AddRange(New DataGridColumnStyle() {colMark, colPartyKey, colParty, colCity, colMobileNo, colWhatsAppNo, colEmail, colBrokerKey, colBalAmt, colBrokerName, colFlag})
        colMark = Nothing : colPartyKey = Nothing : colParty = Nothing : colCity = Nothing : colMobileNo = Nothing : colWhatsAppNo = Nothing : colEmail = Nothing
        colBrokerKey = Nothing : colBrokerName = Nothing : colFlag = Nothing

        dtgBill.TableStyles.Clear()
        dtgBill.TableStyles.Add(tblStyle)

    End Sub


 


    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        Dim Filter As String = ""
        Dim ledtype As String = ""


        blnNewRow = True


        LedType = GetSelectedAttributes(cmbLedger, "Party_key")
        If LedType.Trim.Length > 0 Then
            Filter &= " And " & LedType


        End If



        ' If cmbLedgerType.SelectedIndex = 1 Then

        'LedType = " Where AccLGrp.AccLGrp_Type in ('3','4') Or Party.Led_Cat='L' "
        ' End If

        Query = "Select '0' as selparty, Party_key, PartyName, City, MobileNo,WhatsAppNo,email, Broker_Key  , Abs(Sum(Amt)) Amt,BrokerName, case when Sum(Amt) < 0 then 'Cr' else 'Dr' end Flag " _
            & " From ( " _
            & " Select A.CoBr_Id, A.Fcyr_Id, A.Led_Key Party_key, Party.Led_Name PartyName,Station.Stn_Name City, Party.Mobile1 MobileNo, Party.WhatsAppMobileNo WhatsAppNo, " _
            & " Party.OEmail Email, Party.Broker_Key,case when AmtFlag = 'D' then Sum(Amount) else -Sum(Amount) end Amt, Broker.Led_Name BrokerName  " _
            & " from View_LedgerOnScreen as A " _
            & " Left Join Ledger Party	on A.Led_Key = Party.Led_Key " _
            & " Left Join Ledger Broker	on Party.Broker_Key = Broker.Led_Key " _
            & " Left Join Station on Party.OStn_Key = Station.Stn_Key " _
            & " Group By A.CoBr_Id, A.Fcyr_Id, A.Led_Key, Party.Led_Name, Station.Stn_Name, Party.Mobile1,AmtFlag,Party.WhatsAppMobileNo,Party.OEmail,Party.Broker_Key, Broker.Led_Name    " _
            & " ) B " _
            & " WHERE COBR_ID = '" & SelBranchId & "' " & Filter & " AND PARTYNAME <> '' AND amt <>0  " _
            & " Group By Party_key, PartyName, City, MobileNo,WhatsAppNo,Email ,Broker_Key, BrokerName " _
            & " ORDER BY PARTYNAME, CITY"
        ''Remove the year filter to fetch the previous year opening balance viv 18/02/2019
        ''  ---& " WHERE COBR_ID = '" & SelBranchId & "' and Fcyr_Id='" & SelYearId & "'" & Filter & " AND PARTYNAME <> ''" _



        dtQty = Common.GetDataTable(Query)
        dtQty.DefaultView.AllowDelete = False
        dtQty.DefaultView.AllowNew = False

        dtgBill.DataSource = dtQty
        Call DisplayHeader(dtQty)

        dtgBill.CurrentRowIndex = 0
        If dtQty.Rows.Count > 0 Then
            dtgBill.Select(dtgBill.CurrentCell.RowNumber)
        Else

        End If


        If dtgBill.CurrentRowIndex = -1 Then
            btnCancel.Focus()
        Else
            dtgBill.Focus()
        End If
        blnNewRow = False

    End Sub









    Private Sub mnuSelectAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSelectAll.Click
        Dim i As Integer
        Dim dblTotChgSale As Double = 0

        dtBill = CType(dtgBill.DataSource, DataTable)
        For i = 0 To dtBill.Rows.Count - 1
            dtBill.Rows(i)(0) = "1"


        Next i

        'lblDeleteSale.Text = Format$(dblTotChgSale, "0.00")
        'lblBalSale.Text = Format$(Val(lblTotalSale.Text) - dblTotChgSale, "0.00")


    End Sub

    Private Sub mnuUnSelectAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuUnSelectAll.Click
        Dim i As Integer
        dtBill = CType(dtgBill.DataSource, DataTable)
        For i = 0 To dtBill.Rows.Count - 1
            dtBill.Rows(i)(0) = "0"
        Next i



    End Sub

    Private Sub mnuInvertSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInvertSelect.Click
        Dim i As Integer
        Dim dblTotChgSale As Double = 0

        dtBill = CType(dtgBill.DataSource, DataTable)
        For i = 0 To dtBill.Rows.Count - 1
            dtBill.Rows(i)(0) = IIf(dtBill.Rows(i)(0) = "0", "1", "0")
            If dtBill.Rows(i)(0) = "1" Then
                'dblTotChgSale += dtBill.Rows(i)(6)


            End If
        Next i

        'lblDeleteSale.Text = Format$(dblTotChgSale, "0.00")
        'lblBalSale.Text = Format$(Val(lblTotalSale.Text) - dblTotChgSale, "0.00")

    End Sub

    'Private Sub dtQty_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles dtQty.ColumnChanged
    '    Dim i As Integer
    '    'Dim dblTotChgSale As Double = 0

    '    dtBill = CType(dtgBill.DataSource, DataTable)
    '    For i = 0 To dtBill.Rows.Count - 1
    '        If dtBill.Rows(i)(0) & "" = "1" Then



    '        End If
    '    Next i


    'End Sub

    Private Sub btnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub mnuCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomer.Click
        Dim i As Integer
        Dim Trans As SqlTransaction = Nothing
        'Dim dblTotChgSale As Double = 0
        Try

          
            If dtgBill.CurrentRowIndex = -1 Then
                MsgBox("Bill details have not been provided !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                Exit Sub
            End If



            dtBill = CType(dtgBill.DataSource, DataTable)
            If MsgBox("Do You Want to Send Outstanding Bills Via Email ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then
                Exit Sub
            End If

            For i = 0 To dtBill.Rows.Count - 1
                If dtBill.Rows(i)(0) & "" = "1" And dtBill.Rows(i)(8) <> 0 Then

                    If dtBill.Rows(i)(6) & "" <> "" Then
                        '    MsgBox("Email Id Not Specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                        '    Exit Sub
                        'Else
                        ''''''''''''''''''''''''''''''''
                        Me.Cursor = Cursors.WaitCursor

                        Trans = CreateSQLTransaction()
                        Dim SenderAcc As String = GetSettingAsPerId(ApplnSettingsIdx.GenEmailUser)
                        Dim SenderPwd As String = GetSettingAsPerId(ApplnSettingsIdx.GenEmailPassword)
                        'Dim SenderName As String = GetSettingAsPerId(ApplnSettingsIdx.GenEmailSenderName)

                        'EmailSender(SenderAcc, SenderPwd, SenderName, txtRecipient.Text, txtMessage.Text, txtSubject.Text)
                        ''Satyam 16072022



                        MailAttachments = ""
                        ReportParameters.rptCaption = Me.Text
                        ReportParameters.rptFile = ReportPath & "\Accounts\LedgerOsBill.rpt"
                        ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "' And  {vw_LedgerAccount.Led_Key} In ['" & dtBill.Rows(i)(1) & "']"


                        Dim Formulas As Hashtable = Nothing

                        Formulas = New Hashtable
                        Dim CrystalFormulas As Hashtable
                        Formulas.Add("DispDtlRef#N", 0)
                        Formulas.Add("BillType#N", 0)
                        Formulas.Add("MultiLedger#N", 0)
                        Formulas.Add("stDate#S", Format$(AccFromDt, "dd/MM/yyyy")) ' AccFromDt
                        Formulas.Add("ToDate#S", Format$(Now.Date, "dd/MM/yyyy"))
                        'Dim subrpt() As SubReportDetails
                        Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

                        If Not IO.File.Exists(ReportParameters.rptFile) Then
                            MsgBox("Report file does not exists !", MsgBoxStyle.Exclamation)
                            Exit Sub
                        End If
                        objReport.Load(ReportParameters.rptFile)

                        If objReport.RecordSelectionFormula <> "" Then
                            objReport.RecordSelectionFormula = objReport.RecordSelectionFormula
                        Else

                            objReport.RecordSelectionFormula = ReportParameters.rptFilter
                        End If


                        Dim obj As Object
                        Dim FormulaKey As String = ""

                        If Not IsNothing(Formulas) Then
                            For Each obj In Formulas
                                If FormulaIsNumeric(obj.Key, FormulaKey) Then
                                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = obj.Value
                                Else
                                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = "'" & obj.Value & "'"
                                End If
                            Next obj
                        End If



                        Formulas = Nothing
                        CrystalFormulas = Nothing



                        objReport.SetDatabaseLogon(SQLUserId, Password, ServerName, Database)

                        If SQLUserId.Trim.Length = 0 Then
                            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, True)
                        Else
                            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, SQLUserId, Password)
                        End If
                        ''''''''''''''''''''''


                        Try
                            Me.Cursor = Cursors.WaitCursor

                            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            Dim rptFile As String = Application.StartupPath & "\OutstandingBill-" & dtBill.Rows(i)(8) & ".pdf"

                            If IO.File.Exists(rptFile) Then
                                IO.File.Delete(rptFile)
                            End If

                            Dim CrExportOptions As CrystalDecisions.Shared.ExportOptions = objReport.ExportOptions
                            Dim CrDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions()
                            Dim CrFormatTypeOptions As New CrystalDecisions.Shared.PdfRtfWordFormatOptions()
                            CrDiskFileDestinationOptions.DiskFileName = rptFile

                            With CrExportOptions
                                .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                                .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                                .DestinationOptions = CrDiskFileDestinationOptions
                                .FormatOptions = CrFormatTypeOptions
                            End With
                            objReport.Export()

                            MailAttachments = rptFile
                            ReportParameters.rptCaption = Me.Text

                            'ReportParameters.rptFilter = " {vw_LedgerAccount.Led_Key} In ['02121']"
                        Catch
                        End Try
                        '-----------------------------------------------------------------------------
                        Dim MailAttachments1 As String
                        MailAttachments1 = ""
                        ReportParameters.rptCaption = Me.Text
                        ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccount.rpt"
                        ReportParameters.rptFilter = "{VIEW_BYRACCOUNT.CoBr_Id} = '" & SelBranchId & "' And {VIEW_BYRACCOUNT.Party_key} In ['" & dtBill.Rows(i)(1) & "']"



                        Formulas = New Hashtable

                        Formulas.Add("stDate#S", Format$(AccFromDt, "dd/MM/yyyy")) ' AccFromDt

                        Formulas.Add("ToDate#S", Format$(Now.Date, "dd/MM/yyyy"))
                        'Dim subrpt() As SubReportDetails


                        If Not IO.File.Exists(ReportParameters.rptFile) Then
                            MsgBox("Report file does not exists !", MsgBoxStyle.Exclamation)
                            Exit Sub
                        End If
                        objReport.Load(ReportParameters.rptFile)

                        If objReport.RecordSelectionFormula <> "" Then
                            objReport.RecordSelectionFormula = objReport.RecordSelectionFormula
                        Else

                            objReport.RecordSelectionFormula = ReportParameters.rptFilter
                        End If

                        'Dim obj As Object
                        FormulaKey = ""

                        If Not IsNothing(Formulas) Then
                            For Each obj In Formulas
                                If FormulaIsNumeric(obj.Key, FormulaKey) Then
                                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = obj.Value
                                Else
                                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = "'" & obj.Value & "'"
                                End If
                            Next obj
                        End If



                        Formulas = Nothing
                        CrystalFormulas = Nothing

                        objReport.SetDatabaseLogon(SQLUserId, Password, ServerName, Database)

                        If SQLUserId.Trim.Length = 0 Then
                            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, True)
                        Else
                            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, SQLUserId, Password)
                        End If
                        ''''''''''''''''''''''


                        Try
                            Me.Cursor = Cursors.WaitCursor

                            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            Dim rptFile As String = Application.StartupPath & "\OutstandingLedger-" & dtBill.Rows(i)(8) & ".pdf"

                            If IO.File.Exists(rptFile) Then
                                IO.File.Delete(rptFile)
                            End If

                            Dim CrExportOptions As CrystalDecisions.Shared.ExportOptions = objReport.ExportOptions
                            Dim CrDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions()
                            Dim CrFormatTypeOptions As New CrystalDecisions.Shared.PdfRtfWordFormatOptions()
                            CrDiskFileDestinationOptions.DiskFileName = rptFile

                            With CrExportOptions
                                .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                                .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                                .DestinationOptions = CrDiskFileDestinationOptions
                                .FormatOptions = CrFormatTypeOptions
                            End With
                            objReport.Export()

                            MailAttachments1 = rptFile
                            ReportParameters.rptCaption = Me.Text


                            'ReportParameters.rptFilter = " {vw_LedgerAccount.Led_Key} In ['02121']"
                        Catch
                        End Try


                        Dim note As String = "Dear - " & dtBill.Rows(i)(2) & "" & vbCrLf _
                            & vbCrLf _
                           & "This is a gentle reminder to clear your payment dues with Khatunaresh Enterprises Pvt. Ltd. (Bodysize)." & vbCrLf _
                           & "Your total outstanding with Khatunaresh Enterprises Pvt. Ltd. until now is Rs  " & dtBill.Rows(i)(8) & "." & vbCrLf _
                           & "We request you to clear your dues as soon as possible to avoid deduction of 5% cash discount. (Cash Discount is not applicable on payments made after 45 days)." & vbCrLf _
                           & "Any pending or new order will not be dispatched till the due payment  is not cleared." & vbCrLf _
                            & vbCrLf _
                           & "Details of your Outstanding and Ledger has been shared below -" & vbCrLf _
                           & vbCrLf _
                           & "Regards," & vbCrLf _
                           & "Bodysize" & vbCrLf

                        SendMail1(SenderAcc, SenderPwd, dtBill.Rows(i)(6), "", "", "Outstanding Amount ", note, Label1, MailAttachments, MailAttachments1)


                        ''''''''''''''''''''''''''''''
                    End If
                Else

                End If
            Next i

           

            If MailMsg = True Then
                MsgBox("Mail Send Successfully !!", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Someting Went Wrong !", MsgBoxStyle.Exclamation)

            End If





        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub SendMail1(ByVal Mail_Id As String, ByVal Mail_Pass As String, ByVal recepient As String, ByVal bcc As String, ByVal cc As String, ByVal subject As String, ByVal body As String, ByVal errormsg As Label, ByVal attachment As String,ByVal attachment1 As string)
        Try

            Dim mailResponse As String = ""
            ' Instantiate a new instance of MailMessage
            ' errormsg.Text = ""
            Dim mMailMessage As New MailMessage()

            Dim Smtp_Server As New SmtpClient
            ' Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = True
            Smtp_Server.Credentials = New Net.NetworkCredential(Mail_Id, Mail_Pass)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            mMailMessage = New MailMessage()
            mMailMessage.From = New MailAddress(Mail_Id)

            'Dim attach As Mail.Attachment = New Mail.Attachment("D:\ram\SO_Bal.txt")
            'e_mail.Attachments.Add(attach)

            'For l_index As Integer = 0 To lstAttachments.Items.Count - 1
            'attachment = Mail
            mMailMessage.Attachments.Add(New System.Net.Mail.Attachment(attachment.Trim))
            mMailMessage.Attachments.Add(New System.Net.Mail.Attachment(attachment1.Trim))

            ' e_mail.To.Add("mistryshaileshj@gmail.com")
            'Split string based on spaces
            Dim mailaddress As String() = recepient.Split(New Char() {","c})
            'Use For Each loop over words and display them
            Dim word As String
            For Each word In mailaddress
                mMailMessage.To.Add(New MailAddress(word.Trim))
            Next

            If Not bcc Is Nothing And bcc <> String.Empty Then
                ' Set the Bcc address of the mail message
                mMailMessage.Bcc.Add(New MailAddress(bcc))
            End If

            'e_mail.To.Add("sales@vrssoftwares.com")
            If Not cc Is Nothing And cc <> String.Empty Then
                'Set the CC address of the mail message
                mMailMessage.CC.Add(New MailAddress(cc))
            End If

            mMailMessage.Subject = subject
            mMailMessage.Body = body
            Smtp_Server.Send(mMailMessage)


        
            'If body <> "" Then ''Satyam 16072022
            '    mailResponse = "SUCCESS || Mail send Successfully."
            '    MsgBox("Mail Send Successfully..!", MsgBoxStyle.Exclamation)
            'Else
            '    errormsg.Text = "No Data Available To send"
            '    MsgBox("Something Went Wrong..", MsgBoxStyle.Exclamation)
            'End If

            mMailMessage.Dispose()


        Catch ex As Exception
            Common.LogAndDisplayException(ex)
            MailMsg = False

        Finally
            Me.Cursor = Cursors.Default
            MailMsg = True
        End Try
    End Sub ''End
    Private Sub mnuWholesaleCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWholesaleCustomer.Click
        Dim i As Integer
        'Dim dblTotChgSale As Double = 0
        Try
            If dtgBill.CurrentRowIndex = -1 Then
                MsgBox("Bill details have not been provided !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                Exit Sub
            End If
            If MsgBox("Do You Want to Send Outstanding Bills Via WhatsApp ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then
                Exit Sub
            End If

            dtBill = CType(dtgBill.DataSource, DataTable)
            For i = 0 To dtBill.Rows.Count - 1
                If dtBill.Rows(i)(0) & "" = "1" And dtBill.Rows(i)(5) & "" <> "" And dtBill.Rows(i)(8) <> 0 Then
                    'If MsgBox("Do You Want to Send Outstanding Bills Via WhatsApp ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then
                    '    Exit Sub
                    'End If

                    '    MsgBox("WhatsApp No. Not Specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                    '    Exit Sub
                    'Else
                    ''''''''''''''''''''''''''''''''
                    '   ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccount.rpt"
                    ' ReportParameters.rptFilter = "{VIEW_BYRACCOUNT.CoBr_Id} = '" & SelBranchId & "' And  {VIEW_BYRACCOUNT.Party_key} In ['" & dtBill.Rows(i)(1) & "']"


                    MailAttachments = ""
                    ReportParameters.rptCaption = Me.Text
                    ReportParameters.rptFile = ReportPath & "\Accounts\LedgerOsBill.rpt"
                    ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "'  And  {vw_LedgerAccount.Led_Key} In ['" & dtBill.Rows(i)(1) & "']"


                    Dim Formulas As Hashtable = Nothing

                    Formulas = New Hashtable
                    Dim CrystalFormulas As Hashtable
                    Formulas.Add("DispDtlRef#N", 0)
                    Formulas.Add("BillType#N", 0)
                    Formulas.Add("MultiLedger#N", 0)
                    Formulas.Add("stDate#S", Format$(AccFromDt, "dd/MM/yyyy")) ' AccFromDt
                    Formulas.Add("ToDate#S", Format$(Now.Date, "dd/MM/yyyy"))
                    'Dim subrpt() As SubReportDetails
                    Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

                    If Not IO.File.Exists(ReportParameters.rptFile) Then
                        MsgBox("Report file does not exists !", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                    objReport.Load(ReportParameters.rptFile)

                    If objReport.RecordSelectionFormula <> "" Then
                        objReport.RecordSelectionFormula = objReport.RecordSelectionFormula
                    Else

                        objReport.RecordSelectionFormula = ReportParameters.rptFilter
                    End If


                    Dim obj As Object
                    Dim FormulaKey As String = ""

                    If Not IsNothing(Formulas) Then
                        For Each obj In Formulas
                            If FormulaIsNumeric(obj.Key, FormulaKey) Then
                                objReport.DataDefinition.FormulaFields(FormulaKey).Text = obj.Value
                            Else
                                objReport.DataDefinition.FormulaFields(FormulaKey).Text = "'" & obj.Value & "'"
                            End If
                        Next obj
                    End If



                    Formulas = Nothing
                    CrystalFormulas = Nothing


                    objReport.SetDatabaseLogon(SQLUserId, Password, ServerName, Database)

                    If SQLUserId.Trim.Length = 0 Then
                        objReport.DataSourceConnections(0).SetConnection(ServerName, Database, True)
                    Else
                        objReport.DataSourceConnections(0).SetConnection(ServerName, Database, SQLUserId, Password)
                    End If
                    ''''''''''''''''''''''

                    Try
                        Me.Cursor = Cursors.WaitCursor
                        Dim rptFile As String = ""
                        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftWareForGcube)) = 1 Then
                            rptFile = Application.StartupPath & "\GCUBE NX -" & dtBill.Rows(i)(8) & ".pdf"
                        Else
                            rptFile = Application.StartupPath & "\OutstandingBill-" & dtBill.Rows(i)(8) & ".pdf"
                        End If


                        If IO.File.Exists(rptFile) Then
                            ' IO.File.Delete(rptFile)
                        End If

                        Dim CrExportOptions As CrystalDecisions.Shared.ExportOptions = objReport.ExportOptions
                        Dim CrDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions()
                        Dim CrFormatTypeOptions As New CrystalDecisions.Shared.PdfRtfWordFormatOptions()
                        CrDiskFileDestinationOptions.DiskFileName = rptFile

                        With CrExportOptions
                            .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                            .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                            .DestinationOptions = CrDiskFileDestinationOptions
                            .FormatOptions = CrFormatTypeOptions
                        End With
                        objReport.Export()

                        MailAttachments = rptFile
                        ReportParameters.rptCaption = Me.Text


                        'ReportParameters.rptFilter = " {vw_LedgerAccount.Led_Key} In ['02121']"
                    Catch
                    End Try

                    '------------------------------------------------------------------------------------------------------

                    If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftWareForGcube)) <> 1 Then
                        Dim MailAttachments1 As String
                        MailAttachments1 = ""
                        ReportParameters.rptCaption = Me.Text
                        ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccount.rpt"
                        ReportParameters.rptFilter = "{VIEW_BYRACCOUNT.CoBr_Id} = '" & SelBranchId & "' And {VIEW_BYRACCOUNT.Party_key} In ['" & dtBill.Rows(i)(1) & "']"




                        Formulas = New Hashtable

                        Formulas.Add("stDate#S", Format$(AccFromDt, "dd/MM/yyyy"))
                        Formulas.Add("ToDate#S", Format$(Now.Date, "dd/MM/yyyy"))
                        'Dim subrpt() As SubReportDetails


                        If Not IO.File.Exists(ReportParameters.rptFile) Then
                            MsgBox("Report file does not exists !", MsgBoxStyle.Exclamation)
                            Exit Sub
                        End If
                        objReport.Load(ReportParameters.rptFile)

                        If objReport.RecordSelectionFormula <> "" Then
                            objReport.RecordSelectionFormula = objReport.RecordSelectionFormula
                        Else

                            objReport.RecordSelectionFormula = ReportParameters.rptFilter
                        End If


                        FormulaKey = ""

                        If Not IsNothing(Formulas) Then
                            For Each obj In Formulas
                                If FormulaIsNumeric(obj.Key, FormulaKey) Then
                                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = obj.Value
                                Else
                                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = "'" & obj.Value & "'"
                                End If
                            Next obj
                        End If



                        Formulas = Nothing
                        CrystalFormulas = Nothing

                        objReport.SetDatabaseLogon(SQLUserId, Password, ServerName, Database)

                        If SQLUserId.Trim.Length = 0 Then
                            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, True)
                        Else
                            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, SQLUserId, Password)
                        End If
                        ''''''''''''''''''''''


                        Try
                            Me.Cursor = Cursors.WaitCursor

                            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            Dim rptFile As String = Application.StartupPath & "\OutstandingLedger-" & dtBill.Rows(i)(8) & ".pdf"

                            If IO.File.Exists(rptFile) Then
                                IO.File.Delete(rptFile)
                            End If

                            Dim CrExportOptions As CrystalDecisions.Shared.ExportOptions = objReport.ExportOptions
                            Dim CrDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions()
                            Dim CrFormatTypeOptions As New CrystalDecisions.Shared.PdfRtfWordFormatOptions()
                            CrDiskFileDestinationOptions.DiskFileName = rptFile

                            With CrExportOptions
                                .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                                .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                                .DestinationOptions = CrDiskFileDestinationOptions
                                .FormatOptions = CrFormatTypeOptions
                            End With
                            objReport.Export()


                            ReportParameters.rptCaption = Me.Text
                            MailAttachments1 = rptFile

                            'ReportParameters.rptFilter = " {vw_LedgerAccount.Led_Key} In ['02121']"
                        Catch
                        End Try

                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    
                        Dim path As String = MailAttachments '"C:\Users\VRS18\Downloads\MonicaNx.jpg" '"C:\Users\VRS18\Documents\BILL.pdf"
                        Dim no As String = dtBill.Rows(i)(5)
                        Dim path1 As String = MailAttachments1 '"C:\Users\VRS18\Downloads\MonicaNx.jpg" '"C:\Users\VRS18\Documents\BILL.pdf"



                        Dim note As String = "Dear - " & dtBill.Rows(i)(2) & "" & vbCrLf _
                            & vbCrLf _
                           & "This is a gentle reminder to clear your payment dues with Khatunaresh Enterprises Pvt. Ltd. (Bodysize)." & vbCrLf _
                           & "Your total outstanding with Khatunaresh Enterprises Pvt. Ltd. until now is Rs  " & dtBill.Rows(i)(8) & "." & vbCrLf _
                           & "We request you to clear your dues as soon as possible to avoid deduction of 5% cash discount. (Cash Discount is not applicable on payments made after 45 days)." & vbCrLf _
                             & "Any pending or new order will not be dispatched till the due payment  is not cleared." & vbCrLf _
                                & vbCrLf _
                           & "Details of your Outstanding and Ledger has been shared below -" & vbCrLf _
                           & vbCrLf _
                           & "Regards," & vbCrLf _
                           & "Bodysize" & vbCrLf

                        WhatsAppText(note, no)
                        WhatsAppFile(path, no, "Outstanding Amount")
                        WhatsAppFile(path1, no, "Outstanding Ledger")
                    End If

                    If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftWareForGcube)) = 1 Then
                        Dim path As String = MailAttachments
                        Dim no As String = dtBill.Rows(i)(5)
                        Dim note As String = "Dear - " & dtBill.Rows(i)(2) & "" & vbCrLf _
                          & vbCrLf _
                         & "This is a gentle reminder to clear your payment dues with G CUBE NX." & vbCrLf _
                         & "Your total outstanding with G CUBE NX until now is Rs  " & dtBill.Rows(i)(8) & "." & vbCrLf _
                              & vbCrLf _
                         & "Details of your Outstanding Ledger has been shared below -" & vbCrLf _
                         & vbCrLf _
                         & "Regards," & vbCrLf _
                         & "G CUBE NX" & vbCrLf

                        WhatsAppText(note, no)
                        WhatsAppFile(path, no, "Outstanding Ledger")
                    End If
                    ''''''''''''''''''''''''''''''
                Else

                End If


                ' End If
            Next i
            If WhatsMsg = True Then
                MsgBox("WhatsApp Msg Send Successfully !!", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Someting Went Wrong !", MsgBoxStyle.Exclamation)
            End If

            'For i = 0 To dtBill.Rows.Count - 1
            '    If dtBill.Rows(i)(0) & "" = "1" And dtBill.Rows(i)(5) & "" <> "" And dtBill.Rows(i)(8) <> 0 Then


            '        '    MsgBox("WhatsApp No. Not Specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            '        '    Exit Sub
            '        'Else
            '        ''''''''''''''''''''''''''''''''
            '        '   ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccount.rpt"
            '        ' ReportParameters.rptFilter = "{VIEW_BYRACCOUNT.CoBr_Id} = '" & SelBranchId & "' And  {VIEW_BYRACCOUNT.Party_key} In ['" & dtBill.Rows(i)(1) & "']"


            '        MailAttachments = ""
            '        ReportParameters.rptCaption = Me.Text
            '        ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccount.rpt"
            '        ReportParameters.rptFilter = "{VIEW_BYRACCOUNT.CoBr_Id} = '" & SelBranchId & "' And {VIEW_BYRACCOUNT.Party_key} In ['" & dtBill.Rows(i)(1) & "']"

            '        Dim Formulas As Hashtable = Nothing

            '        Formulas = New Hashtable
            '        Dim CrystalFormulas As Hashtable
            '        Formulas.Add("stDate#S", Format$(AccFromDt, "dd/MM/yyyy"))
            '        Formulas.Add("ToDate#S", Format$(Now.Date, "dd/MM/yyyy"))
            '        'Dim subrpt() As SubReportDetails
            '        Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            '        If Not IO.File.Exists(ReportParameters.rptFile) Then
            '            MsgBox("Report file does not exists !", MsgBoxStyle.Exclamation)
            '            Exit Sub
            '        End If
            '        objReport.Load(ReportParameters.rptFile)

            '        If objReport.RecordSelectionFormula <> "" Then
            '            objReport.RecordSelectionFormula = objReport.RecordSelectionFormula
            '        Else

            '            objReport.RecordSelectionFormula = ReportParameters.rptFilter
            '        End If

            '        Dim obj As Object
            '        Dim FormulaKey As String = ""

            '        If Not IsNothing(Formulas) Then
            '            For Each obj In Formulas
            '                If FormulaIsNumeric(obj.Key, FormulaKey) Then
            '                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = obj.Value
            '                Else
            '                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = "'" & obj.Value & "'"
            '                End If
            '            Next obj
            '        End If



            '        Formulas = Nothing
            '        CrystalFormulas = Nothing

            '        objReport.SetDatabaseLogon(SQLUserId, Password, ServerName, Database)

            '        If SQLUserId.Trim.Length = 0 Then
            '            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, True)
            '        Else
            '            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, SQLUserId, Password)
            '        End If
            '        ''''''''''''''''''''''

            '        Try
            '            Me.Cursor = Cursors.WaitCursor

            '            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            '            Dim rptFile As String = Application.StartupPath & "\OutstandingLedger-" & dtBill.Rows(i)(8) & ".pdf"

            '            If IO.File.Exists(rptFile) Then
            '                IO.File.Delete(rptFile)
            '            End If

            '            Dim CrExportOptions As CrystalDecisions.Shared.ExportOptions = objReport.ExportOptions
            '            Dim CrDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions()
            '            Dim CrFormatTypeOptions As New CrystalDecisions.Shared.PdfRtfWordFormatOptions()
            '            CrDiskFileDestinationOptions.DiskFileName = rptFile

            '            With CrExportOptions
            '                .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
            '                .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
            '                .DestinationOptions = CrDiskFileDestinationOptions
            '                .FormatOptions = CrFormatTypeOptions
            '            End With
            '            objReport.Export()

            '            MailAttachments = rptFile
            '            ReportParameters.rptCaption = Me.Text


            '            'ReportParameters.rptFilter = " {vw_LedgerAccount.Led_Key} In ['02121']"
            '        Catch
            '        End Try
            '        Dim path As String = MailAttachments '"C:\Users\VRS18\Downloads\MonicaNx.jpg" '"C:\Users\VRS18\Documents\BILL.pdf"
            '        Dim no As String = dtBill.Rows(i)(5)

            '        Dim note As String = "Dear - " & dtBill.Rows(i)(2) & "" & vbCrLf _
            '            & vbCrLf _
            '           & "This is a gentle reminder to clear your payment dues with Khatunaresh Enterprises Pvt. Ltd. (Bodysize)." & vbCrLf _
            '           & "Your total outstanding with Khatunaresh Enterprises Pvt. Ltd. until now is Rs  " & dtBill.Rows(i)(8) & "." & vbCrLf _
            '           & "We request you to clear your dues as soon as possible to avoid deduction of 5% cash discount. (Cash Discount is not applicable on payments made after 45 days)." & vbCrLf _
            '             & "Any pending or new order will not be dispatched till the due payment  is not cleared." & vbCrLf _
            '                & vbCrLf _
            '           & "Details of your Outstanding and Ledger has been shared below -" & vbCrLf _
            '           & vbCrLf _
            '           & "Regards," & vbCrLf _
            '           & "Bodysize" & vbCrLf

            '        '  WhatsAppText(note, no)
            '        WhatsAppFile(path, no, "Outstanding Ledger")


            '        ''''''''''''''''''''''''''''''
            '    Else

            '    End If


            '    ' End If
            'Next i
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '' Function to send File from local drive


    Public Function WhatsAppFile(ByVal FileNameWithPath As String, ByVal PhoneNoStr As String, ByVal fileCaption As String) As Boolean

        Dim filepath As String = FileNameWithPath ' absolute path of file on local drive
        Dim key As String = GetSettingAsPerId(ApplnSettingsIdx.WhatsAppAPI) ' your api key
        Dim number As String = "91" & PhoneNoStr ' target mobile number, including country code
        Dim caption As String = fileCaption ' caption is optional parameter

        Try

            System.Net.ServicePointManager.Expect100Continue = False
            'ServicePointManager.SecurityProtocol = CType(768, SecurityProtocolType) Or CType(3072, SecurityProtocolType)
            'ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls

            Dim AsBytes As Byte() = File.ReadAllBytes(filepath)
            Dim filedata As String = Convert.ToBase64String(AsBytes)
            Dim filename = New FileInfo(filepath).Name
            Dim wb = New WebClient()
            Dim data = New NameValueCollection()
            data("data") = filedata
            data("filename") = filename
            data("key") = key
            data("number") = number
            data("caption") = caption

            Dim response = wb.UploadValues("http://node4.wabapi.com/v4/postfile.php", "POST", data)
            Dim responseInString As String = Encoding.UTF8.GetString(response)
            WhatsAppFile = True
            WhatsMsg = True

        Catch ex As Exception
            WhatsAppFile = False
            WhatsMsg = False
            MsgBox("WhatsApp Msg Sending Request Fail,Please Check Internet Connection..!", MsgBoxStyle.Exclamation)
        End Try

        Return WhatsAppFile

    End Function


    ''''Function to send text 

    Public Function WhatsAppText(ByVal Message As String, ByVal PhoneNoStr As String) As Boolean

        Dim msg As String = Message  ' absolute path of file on local drive
        Dim key As String = GetSettingAsPerId(ApplnSettingsIdx.WhatsAppAPI) ' your api key
        Dim number As String = "91" & PhoneNoStr ' target mobile number, including country code

        Try
            System.Net.ServicePointManager.Expect100Continue = False
            'ServicePointManager.SecurityProtocol = CType(768, SecurityProtocolType) Or CType(3072, SecurityProtocolType)
            ' ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls

            Dim wb = New WebClient()
            Dim data = New NameValueCollection()
            data("message") = msg
            data("key") = key
            data("number") = number

            Dim response = wb.UploadValues("http://node4.wabapi.com/v4/text.php", "POST", data)
            Dim responseInString As String = Encoding.UTF8.GetString(response)
            WhatsAppText = True
            WhatsMsg = True

        Catch ex As Exception
            WhatsAppText = False
            WhatsMsg = False
        End Try

        Return WhatsAppText

    End Function

    Private Sub mnuVendors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVendors.Click
        Dim i As Integer
        'Dim dblTotChgSale As Double = 0
        Try
            If dtgBill.CurrentRowIndex = -1 Then
                MsgBox("Bill details have not been provided !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                Exit Sub
            End If
            If MsgBox("Do You Want to Send Outstanding Bills Via Both ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then
                Exit Sub
            End If
            If MsgBox("Are You Sure to Send Outstanding Bills Via Email And WhatsApp  ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then
                Exit Sub
            End If

            dtBill = CType(dtgBill.DataSource, DataTable)
            For i = 0 To dtBill.Rows.Count - 1
                If dtBill.Rows(i)(0) & "" = "1" And dtBill.Rows(i)(5) & "" <> "" And dtBill.Rows(i)(6) & "" <> "" And dtBill.Rows(i)(8) <> 0 Then

                    'If MsgBox("Do You Want to Send Outstanding Bills Via Both ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then
                    '    Exit Sub
                    'End If
                    ''''''''''''''''''''''''''''''''
                    Me.Cursor = Cursors.WaitCursor


                    Dim SenderAcc As String = GetSettingAsPerId(ApplnSettingsIdx.GenEmailUser)
                    Dim SenderPwd As String = GetSettingAsPerId(ApplnSettingsIdx.GenEmailPassword)
                    'Dim SenderName As String = GetSettingAsPerId(ApplnSettingsIdx.GenEmailSenderName)

                    'EmailSender(SenderAcc, SenderPwd, SenderName, txtRecipient.Text, txtMessage.Text, txtSubject.Text)
                    ''Satyam 16072022



                    MailAttachments = ""
                    ReportParameters.rptCaption = Me.Text
                    ReportParameters.rptFile = ReportPath & "\Accounts\LedgerOsBill.rpt"
                    ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "' And  {vw_LedgerAccount.Led_Key} In ['" & dtBill.Rows(i)(1) & "']"

                    Dim Formulas As Hashtable = Nothing

                    Formulas = New Hashtable
                    Dim CrystalFormulas As Hashtable
                    Formulas.Add("DispDtlRef#N", 0)
                    Formulas.Add("BillType#N", 0)
                    Formulas.Add("MultiLedger#N", 0)
                    Formulas.Add("stDate#S", Format$(AccFromDt, "dd/MM/yyyy"))
                    Formulas.Add("ToDate#S", Format$(Now.Date, "dd/MM/yyyy"))
                    'Dim subrpt() As SubReportDetails
                    Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

                    If Not IO.File.Exists(ReportParameters.rptFile) Then
                        MsgBox("Report file does not exists !", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                    objReport.Load(ReportParameters.rptFile)

                    If objReport.RecordSelectionFormula <> "" Then
                        objReport.RecordSelectionFormula = objReport.RecordSelectionFormula
                    Else

                        objReport.RecordSelectionFormula = ReportParameters.rptFilter
                    End If


                    Dim obj As Object
                    Dim FormulaKey As String = ""

                    If Not IsNothing(Formulas) Then
                        For Each obj In Formulas
                            If FormulaIsNumeric(obj.Key, FormulaKey) Then
                                objReport.DataDefinition.FormulaFields(FormulaKey).Text = obj.Value
                            Else
                                objReport.DataDefinition.FormulaFields(FormulaKey).Text = "'" & obj.Value & "'"
                            End If
                        Next obj
                    End If



                    Formulas = Nothing
                    CrystalFormulas = Nothing


                    objReport.SetDatabaseLogon(SQLUserId, Password, ServerName, Database)

                    If SQLUserId.Trim.Length = 0 Then
                        objReport.DataSourceConnections(0).SetConnection(ServerName, Database, True)
                    Else
                        objReport.DataSourceConnections(0).SetConnection(ServerName, Database, SQLUserId, Password)
                    End If
                    ''''''''''''''''''''''


                    Try
                        Me.Cursor = Cursors.WaitCursor

                        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        Dim rptFile As String = Application.StartupPath & "\OutstandingBill-" & dtBill.Rows(i)(8) & ".pdf"

                        If IO.File.Exists(rptFile) Then
                            IO.File.Delete(rptFile)
                        End If

                        Dim CrExportOptions As CrystalDecisions.Shared.ExportOptions = objReport.ExportOptions
                        Dim CrDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions()
                        Dim CrFormatTypeOptions As New CrystalDecisions.Shared.PdfRtfWordFormatOptions()
                        CrDiskFileDestinationOptions.DiskFileName = rptFile

                        With CrExportOptions
                            .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                            .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                            .DestinationOptions = CrDiskFileDestinationOptions
                            .FormatOptions = CrFormatTypeOptions
                        End With
                        objReport.Export()


                        ReportParameters.rptCaption = Me.Text
                        MailAttachments = rptFile

                        'ReportParameters.rptFilter = " {vw_LedgerAccount.Led_Key} In ['02121']"
                    Catch
                    End Try
                    '------------------------------------------------------------------------------------------------------
                    Dim MailAttachments1 As String
                    MailAttachments1 = ""
                    ReportParameters.rptCaption = Me.Text
                    ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccount.rpt"
                    ReportParameters.rptFilter = "{VIEW_BYRACCOUNT.CoBr_Id} = '" & SelBranchId & "' And {VIEW_BYRACCOUNT.Party_key} In ['" & dtBill.Rows(i)(1) & "']"




                    Formulas = New Hashtable

                    Formulas.Add("stDate#S", Format$(AccFromDt, "dd/MM/yyyy"))
                    Formulas.Add("ToDate#S", Format$(Now.Date, "dd/MM/yyyy"))
                    'Dim subrpt() As SubReportDetails


                    If Not IO.File.Exists(ReportParameters.rptFile) Then
                        MsgBox("Report file does not exists !", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                    objReport.Load(ReportParameters.rptFile)

                    If objReport.RecordSelectionFormula <> "" Then
                        objReport.RecordSelectionFormula = objReport.RecordSelectionFormula
                    Else

                        objReport.RecordSelectionFormula = ReportParameters.rptFilter
                    End If


                    FormulaKey = ""

                    If Not IsNothing(Formulas) Then
                        For Each obj In Formulas
                            If FormulaIsNumeric(obj.Key, FormulaKey) Then
                                objReport.DataDefinition.FormulaFields(FormulaKey).Text = obj.Value
                            Else
                                objReport.DataDefinition.FormulaFields(FormulaKey).Text = "'" & obj.Value & "'"
                            End If
                        Next obj
                    End If



                    Formulas = Nothing
                    CrystalFormulas = Nothing

                    objReport.SetDatabaseLogon(SQLUserId, Password, ServerName, Database)

                    If SQLUserId.Trim.Length = 0 Then
                        objReport.DataSourceConnections(0).SetConnection(ServerName, Database, True)
                    Else
                        objReport.DataSourceConnections(0).SetConnection(ServerName, Database, SQLUserId, Password)
                    End If
                    ''''''''''''''''''''''


                    Try
                        Me.Cursor = Cursors.WaitCursor

                        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                        Dim rptFile As String = Application.StartupPath & "\OutstandingLedger-" & dtBill.Rows(i)(8) & ".pdf"

                        If IO.File.Exists(rptFile) Then
                            IO.File.Delete(rptFile)
                        End If

                        Dim CrExportOptions As CrystalDecisions.Shared.ExportOptions = objReport.ExportOptions
                        Dim CrDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions()
                        Dim CrFormatTypeOptions As New CrystalDecisions.Shared.PdfRtfWordFormatOptions()
                        CrDiskFileDestinationOptions.DiskFileName = rptFile

                        With CrExportOptions
                            .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                            .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                            .DestinationOptions = CrDiskFileDestinationOptions
                            .FormatOptions = CrFormatTypeOptions
                        End With
                        objReport.Export()


                        ReportParameters.rptCaption = Me.Text
                        MailAttachments1 = rptFile

                        'ReportParameters.rptFilter = " {vw_LedgerAccount.Led_Key} In ['02121']"
                    Catch
                    End Try

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                    Dim note As String = "Dear - " & dtBill.Rows(i)(2) & "" & vbCrLf _
                        & vbCrLf _
                       & "This is a gentle reminder to clear your payment dues with Khatunaresh Enterprises Pvt. Ltd. (Bodysize)." & vbCrLf _
                       & "Your total outstanding with Khatunaresh Enterprises Pvt. Ltd. until now is Rs  " & dtBill.Rows(i)(8) & "." & vbCrLf _
                       & "We request you to clear your dues as soon as possible to avoid deduction of 5% cash discount. (Cash Discount is not applicable on payments made after 45 days)." & vbCrLf _
                         & "Any pending or new order will not be dispatched till the due payment  is not cleared." & vbCrLf _
                            & vbCrLf _
                       & "Details of your Outstanding and Ledger has been shared below -" & vbCrLf _
                       & vbCrLf _
                       & "Regards," & vbCrLf _
                       & "Bodysize" & vbCrLf
                    SendMail1(SenderAcc, SenderPwd, dtBill.Rows(i)(6), "", "", "Outstanding Amount ", note, Label1, MailAttachments, MailAttachments1)

                    Dim path As String = MailAttachments '"C:\Users\VRS18\Downloads\MonicaNx.jpg" '"C:\Users\VRS18\Documents\BILL.pdf"
                    Dim no As String = dtBill.Rows(i)(5)

                    Dim path1 As String = MailAttachments1  '"C:\Users\VRS18\Downloads\MonicaNx.jpg" '"C:\Users\VRS18\Documents\BILL.pdf"
                    

                  
                    WhatsAppText(note, no)
                    WhatsAppFile(path, no, "Ouststanding Amount")
                    WhatsAppFile(path1, no, "Ouststanding Ledger")



                    ''''''''''''''''''''''''''''''
                    'End If

                Else

                End If
            Next i

            If WhatsMsg = True And MailMsg = True Then
                MsgBox("WhatsApp And Mail Both Send Successfully !", MsgBoxStyle.OkOnly)
            ElseIf WhatsMsg = True And MailMsg = False Then
                MsgBox("WhatsApp Msg Send Successfully !", MsgBoxStyle.OkOnly)
            ElseIf WhatsMsg = False And MailMsg = True Then
                MsgBox("Mail Send Successfully !!", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Something Went Wrong !!", MsgBoxStyle.Exclamation)
            End If
            'For i = 0 To dtBill.Rows.Count - 1
            '    If dtBill.Rows(i)(0) & "" = "1" And dtBill.Rows(i)(5) & "" <> "" And dtBill.Rows(i)(6) & "" <> "" And dtBill.Rows(i)(8) <> 0 Then


            '        ''''''''''''''''''''''''''''''''
            '        Me.Cursor = Cursors.WaitCursor


            '        Dim SenderAcc As String = GetSettingAsPerId(ApplnSettingsIdx.GenEmailUser)
            '        Dim SenderPwd As String = GetSettingAsPerId(ApplnSettingsIdx.GenEmailPassword)
            '        'Dim SenderName As String = GetSettingAsPerId(ApplnSettingsIdx.GenEmailSenderName)

            '        'EmailSender(SenderAcc, SenderPwd, SenderName, txtRecipient.Text, txtMessage.Text, txtSubject.Text)
            '        ''Satyam 16072022



            '        MailAttachments = ""
            '        ReportParameters.rptCaption = Me.Text
            '        ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccount.rpt"
            '        ReportParameters.rptFilter = "{VIEW_BYRACCOUNT.CoBr_Id} = '" & SelBranchId & "' And {VIEW_BYRACCOUNT.Party_key} In ['" & dtBill.Rows(i)(1) & "']"


            '        Dim Formulas As Hashtable = Nothing

            '        Formulas = New Hashtable
            '        Dim CrystalFormulas As Hashtable
            '        Formulas.Add("stDate#S", Format$(AccFromDt, "dd/MM/yyyy"))
            '        Formulas.Add("ToDate#S", Format$(Now.Date, "dd/MM/yyyy"))
            '        'Dim subrpt() As SubReportDetails
            '        Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            '        If Not IO.File.Exists(ReportParameters.rptFile) Then
            '            MsgBox("Report file does not exists !", MsgBoxStyle.Exclamation)
            '            Exit Sub
            '        End If
            '        objReport.Load(ReportParameters.rptFile)

            '        If objReport.RecordSelectionFormula <> "" Then
            '            objReport.RecordSelectionFormula = objReport.RecordSelectionFormula
            '        Else

            '            objReport.RecordSelectionFormula = ReportParameters.rptFilter
            '        End If

            '        Dim obj As Object
            '        Dim FormulaKey As String = ""

            '        If Not IsNothing(Formulas) Then
            '            For Each obj In Formulas
            '                If FormulaIsNumeric(obj.Key, FormulaKey) Then
            '                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = obj.Value
            '                Else
            '                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = "'" & obj.Value & "'"
            '                End If
            '            Next obj
            '        End If



            '        Formulas = Nothing
            '        CrystalFormulas = Nothing

            '        objReport.SetDatabaseLogon(SQLUserId, Password, ServerName, Database)

            '        If SQLUserId.Trim.Length = 0 Then
            '            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, True)
            '        Else
            '            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, SQLUserId, Password)
            '        End If
            '        ''''''''''''''''''''''


            '        Try
            '            Me.Cursor = Cursors.WaitCursor

            '            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            '            Dim rptFile As String = Application.StartupPath & "\OutstandingLedger-" & dtBill.Rows(i)(8) & ".pdf"

            '            If IO.File.Exists(rptFile) Then
            '                IO.File.Delete(rptFile)
            '            End If

            '            Dim CrExportOptions As CrystalDecisions.Shared.ExportOptions = objReport.ExportOptions
            '            Dim CrDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions()
            '            Dim CrFormatTypeOptions As New CrystalDecisions.Shared.PdfRtfWordFormatOptions()
            '            CrDiskFileDestinationOptions.DiskFileName = rptFile

            '            With CrExportOptions
            '                .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
            '                .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
            '                .DestinationOptions = CrDiskFileDestinationOptions
            '                .FormatOptions = CrFormatTypeOptions
            '            End With
            '            objReport.Export()


            '            ReportParameters.rptCaption = Me.Text
            '            MailAttachments = rptFile

            '            'ReportParameters.rptFilter = " {vw_LedgerAccount.Led_Key} In ['02121']"
            '        Catch
            '        End Try



            '        Dim path As String = MailAttachments '"C:\Users\VRS18\Downloads\MonicaNx.jpg" '"C:\Users\VRS18\Documents\BILL.pdf"
            '        Dim no As String = dtBill.Rows(i)(5)


            '        WhatsAppFile(path, no, "Ouststanding Ledger")

            '        ''''''''''''''''''''''''''''''
            '        ' End If
            '    Else


            '    End If
            'Next i
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub





    ''SATYAM 15072022
    Private Function GetSelectedAttributes(ByVal Combo As Object, ByVal FieldName As String)
        Dim SelectedItems As String = ""
        Dim AllItems As String = ""
        Dim SelValues As String = ""

        SelectedItems = Combo.Properties.GetCheckedItems
        AllItems = SelectedList(Combo, SelectedItems)

        If AllItems <> "" Then
            SelValues = " " & FieldName & " In (" & AllItems & ")"
        Else
            SelValues = ""
        End If

        Return SelValues
    End Function

    Private Function SelectedList(ByVal Combo As Object, ByVal SelectedItems As String, Optional ByVal IsNumber As Boolean = False) As String
        Dim AllItems() As String = Split(SelectedItems, ",")

        If SelectedItems = "" Then Return ""

        Dim NewItemList As String = ""
        Dim obj As Object

        For Each obj In AllItems
            If IsNumber Then
                NewItemList &= Trim(obj) & ","
            Else
                NewItemList &= Trim(obj) & "','"
            End If
        Next obj

        If NewItemList.Trim.Length > 0 Then
            If IsNumber Then
                NewItemList = Mid$(NewItemList, 1, Len(NewItemList) - 1)
                NewItemList = NewItemList
            Else
                NewItemList = Mid$(NewItemList, 1, Len(NewItemList) - 2)
                NewItemList = "'" & NewItemList
            End If
        End If

        Return NewItemList
    End Function

End Class