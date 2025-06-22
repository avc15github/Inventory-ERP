Imports Microsoft.Office.Interop
Imports System.Net
Imports System.IO
Imports System.Collections.Specialized
Imports System.Text

Public Class frmViewReports

    Dim CrystalFormulas As Hashtable

    Dim WHATSAPPNO1 As String = ""
    Dim WHATSAPPNO1New As String = ""
    Dim DOCNO1 As String = ""
    Dim msgbool As Boolean = False
    'Dim subrpt() As SubReportDetails
    Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument


    Private Sub frmViewReports_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmViewReports_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IO.File.Exists(ReportParameters.rptFile) Then
            MsgBox("Report file does not exists !", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        If Val(GetSettingAsPerId(ApplnSettingsIdx.HetherGrey)) = "1" Then
            If ApprovePrint = "True" Then
                PictureEdit1.Visible = False
                Dim ts As ToolStrip = crptReport.Controls(4)
                ts.Items.Add("Send As Email")
                AddHandler ts.ItemClicked, AddressOf EmailReport
                ''Satyam(8092022)
                If Val(GetSettingAsPerId(ApplnSettingsIdx.WhatsAppApplicable)) = 1 And Val(GetSettingAsPerId(ApplnSettingsIdx.WhatsAppUseInBill)) = 1 Then
                    If WhatsAppUseInTxn = True Then
                        WHATSAPPNO1 = WHATSAPPNO
                        WHATSAPPNO1New = WHATSAPPNONew
                        DOCNO1 = DOCNO
                        Dim ts1 As ToolStrip = crptReport.Controls(4)
                        ts.Items.Add("Send As WhatsApp")
                        AddHandler ts1.ItemClicked, AddressOf WhatsApp
                    End If

                End If
            Else
                PictureEdit1.Visible = True
            End If
        Else

            If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForRamtex)) = 1 Then
                If ChkApproval = "True" And ApprovePrint = "True" Then
                    PictureEdit1.Visible = True
                Else
                    PictureEdit1.Visible = False
                End If
            Else
                PictureEdit1.Visible = False
            End If


            Dim ts As ToolStrip = crptReport.Controls(4)
            ts.Items.Add("Send As Email")
            AddHandler ts.ItemClicked, AddressOf EmailReport

            ''Satyam 08092022
            If Val(GetSettingAsPerId(ApplnSettingsIdx.WhatsAppApplicable)) = 1 And Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForBodysize)) = 1 Then
                If WhatsAppUseInTxn = True Then
                    WHATSAPPNO1 = WHATSAPPNO
                    WHATSAPPNO1New = WHATSAPPNONew
                    DOCNO1 = DOCNO
                    Dim ts1 As ToolStrip = crptReport.Controls(4)
                    ts.Items.Add("Send As WhatsApp")
                    AddHandler ts1.ItemClicked, AddressOf WhatsApp
                End If

            ElseIf Val(GetSettingAsPerId(ApplnSettingsIdx.WhatsAppApplicable)) = 1 And Val(GetSettingAsPerId(ApplnSettingsIdx.SoftWareForGcube)) = 1 Then
                If WhatsAppUseInTxn = True Then

                    WHATSAPPNO1New = WHATSAPPNONew
                    DOCNO1 = DOCNO
                    Dim ts1 As ToolStrip = crptReport.Controls(4)
                    ts.Items.Add("Send As WhatsApp")
                    AddHandler ts1.ItemClicked, AddressOf WhatsApp
                End If
            End If
        End If

        If Val(GetSettingAsPerId(ApplnSettingsIdx.WhatsAppUseInAllReports)) = 1 Then
            Dim ts1 As ToolStrip = crptReport.Controls(4)
            ts1.Items.Add("Send As WhatsApp")
            AddHandler ts1.ItemClicked, AddressOf WhatsApp
        End If

        Dim Pdfview As ToolStrip = crptReport.Controls(4)
        Pdfview.Items.Add("Open In PDF")

        AddHandler Pdfview.ItemClicked, AddressOf ViewPDFReport

        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim Address As String = ""
        Dim TelNo As String = ""
        Dim Email As String = ""


        ''ts.ImageList = ImageList1
        'ts.Items(ts.Items.Count - 1).DisplayStyle = ToolStripItemDisplayStyle.Image
        'ts.Items(ts.Items.Count - 1).ImageAlign = ContentAlignment.MiddleCenter
        'ts.Items(ts.Items.Count - 1).ImageKey = 0



        objReport.Load(ReportParameters.rptFile)

        If objReport.RecordSelectionFormula <> "" Then
            If ReportParameters.rptFilter <> "" Then
                objReport.RecordSelectionFormula = objReport.RecordSelectionFormula & " And " & ReportParameters.rptFilter
            Else
                objReport.RecordSelectionFormula = objReport.RecordSelectionFormula
            End If
        Else
            objReport.RecordSelectionFormula = ReportParameters.rptFilter
        End If


        If ReportParameters.rptFile.EndsWith("AllInOneSales.rpt") Then
            'objReport.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.LargeCapacity
            objReport.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperCsheet
        End If

        If ReportParameters.ApplyCompanyFilter Then
            GetCompanyDetails(Address, TelNo, Email)

            With objReport.DataDefinition.FormulaFields
                .Item("Company_Name").Text = "'" & SelCompany & "'"
                '.Item("Company_Addr").Text = "'" & Address & "'"
                .Item("Company_Tel").Text = "'" & TelNo & "'"
                .Item("Company_Email").Text = "'" & Email & "'"
            End With

            ReportParameters.ApplyCompanyFilter = False
        End If
        Me.Text = ReportParameters.rptCaption

        Dim obj As Object
        Dim FormulaKey As String = ""

        If Not IsNothing(CrystalFormulas) Then
            For Each obj In CrystalFormulas
                If FormulaIsNumeric(obj.Key, FormulaKey) Then
                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = obj.Value
                Else
                    objReport.DataDefinition.FormulaFields(FormulaKey).Text = "'" & obj.Value & "'"
                End If
            Next obj
        End If


        ''''''Set specific paper size in a printer  27/05/2012
        If FormType = "Bill" Then
            FormType = ""
            Dim repOptions As CrystalDecisions.CrystalReports.Engine.PrintOptions = objReport.PrintOptions

            With repOptions
                'objReport.PrintOptions.PrinterName
                .PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
                '.PaperSize = GetPapersizeID("HP LaserJet 1018", "Bill")
                .PaperSize = GetPapersizeID(GetSettingAsPerId(ApplnSettingsIdx.SalesPrinterName), GetSettingAsPerId(ApplnSettingsIdx.SalesPageSize))
                '.PrinterName = "EPSON LX-300+II"
            End With

        ElseIf FormType = "General" Then
            FormType = ""
            Dim repOptions As CrystalDecisions.CrystalReports.Engine.PrintOptions = objReport.PrintOptions

            With repOptions
                .PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
                .PaperSize = GetPapersizeID(GetSettingAsPerId(ApplnSettingsIdx.SalesPrinterName), "General")
            End With
        End If


        'Dim crParameterFieldDefinitions As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
        'Dim crParameterFieldDefinition As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
        'Dim crParameterValues As New CrystalDecisions.Shared.ParameterValues
        'Dim crParameterDiscreteValue As New CrystalDecisions.Shared.ParameterDiscreteValue

        'crParameterDiscreteValue.Value = 1
        'crParameterFieldDefinitions = objReport.DataDefinition.ParameterFields
        'crParameterFieldDefinition = crParameterFieldDefinitions.Item("BottomN")
        'crParameterValues = crParameterFieldDefinition.CurrentValues

        'crParameterValues.Clear()
        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)



        ReportParameters.rptFile = ""
        ReportParameters.rptFilter = ""
        ReportParameters.rptCaption = ""
        ReportParameters.ApplyCompanyFilter = False
        CrystalFormulas = Nothing

        'sunil 
        'If SQLUserId.Trim.Length > 0 Then
        '    ConInfo.ConnectionInfo.UserID = SQLUserId
        '    ConInfo.ConnectionInfo.Password = Password
        'End If

        'ConInfo.ConnectionInfo.ServerName = ServerName
        'ConInfo.ConnectionInfo.DatabaseName = Database

        objReport.SetDatabaseLogon(SQLUserId, Password, ServerName, Database)

        ''If Not IsNothing(subrpt) Then
        ''    If UBound(subrpt) > 0 Then
        ''        Dim i As Byte

        ''        For i = 0 To UBound(subrpt) - 1
        ''            If subrpt(i).Report.Trim.Length > 0 Then
        ''                objReport.Subreports(subrpt(i).Report).RecordSelectionFormula = subrpt(i).Filter
        ''            End If
        ''        Next i
        ''    End If
        ''End If

        If Not IsNothing(subrpt) Then
            If UBound(subrpt) > 0 Then
                Dim i As Byte

                For i = 0 To UBound(subrpt) - 1
                    If subrpt(i).Report.Trim.Length > 0 Then
                        If objReport.Subreports(subrpt(i).Report).RecordSelectionFormula <> "" Then
                            objReport.Subreports(subrpt(i).Report).RecordSelectionFormula = objReport.Subreports(subrpt(i).Report).RecordSelectionFormula & " And " & subrpt(i).Filter
                        Else
                            objReport.Subreports(subrpt(i).Report).RecordSelectionFormula = subrpt(i).Filter
                        End If

                        If subrpt(i).FormulaValue <> "" Then
                            objReport.Subreports(subrpt(i).Report).DataDefinition.FormulaFields(subrpt(i).FormulaName).Text = "'" & subrpt(i).FormulaValue & "'"
                        End If
                    End If
                Next i
            End If
        End If

        'sunil
        If SQLUserId.Trim.Length = 0 Then
            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, True)
        Else
            objReport.DataSourceConnections(0).SetConnection(ServerName, Database, SQLUserId, Password)
        End If

        ReDim subrpt(0)

        'For intCounter = 0 To objReport.Database.Tables.Count - 1
        '    objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
        'Next

        If ReportParameters.SetCustomPapaerSize Then

        End If

        If ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToPrinter Then
            objReport.PrintToPrinter(ReportParameters.NoOfCopiesToPrint, True, 0, 0)

            Me.Close()

        ElseIf ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToWindow Then
            crptReport.ShowPrintButton = ReportParameters.ShowPrintButton

            crptReport.ReportSource = Nothing
            crptReport.ReportSource = objReport
            crptReport.Show()
        End If

        ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToWindow
        ''ReportParameters.PrintToPrinter = False
    End Sub

    Public Function GetPapersizeID(ByVal PrinterName As String, ByVal PaperSizeName As String) As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        Dim PaperSizeID As Integer = 0
        Dim ppname As String = ""
        Dim s As String = ""

        ' doctoprint.PrinterSettings.PrinterName = "doPDF v7"
        For i As Integer = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            ppname = PaperSizeName

            If doctoprint.PrinterSettings.PaperSizes(i).PaperName = ppname Then
                Dim rawKind As Integer = CInt(doctoprint.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(i)))
                Return rawKind

                Exit For
            End If
        Next
        Return PaperSizeID
    End Function

    Private Sub GetCompanyDetails(ByRef Address As String, ByRef TelNo As String, ByRef Email As String)
        Query = "Select RegdAdd, TelNo, Email " _
            & " From CoBr " _
            & " Where CoBr_Id = '" & SelBranchId & "'"
        Dim CoDetails As DataTable = Common.GetDataTable(Query)

        If CoDetails.Rows.Count > 0 Then
            Address = CoDetails.Rows(0)("RegdAdd") & ""
            TelNo = CoDetails.Rows(0)("TelNo") & ""
            Email = CoDetails.Rows(0)("Email") & ""
        End If
    End Sub

    Private Function FormulaIsNumeric(ByVal Value As String, ByRef FormulaKey As String) As Boolean
        Dim Data() As String = Value.Split("#")
        FormulaKey = Data(0)

        If Data(1) = "N" Then Return True
        Return False
    End Function

    Private Sub frmViewReports_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub SetReportPageSize(ByVal mPaperSize As String, ByVal PaperOrientation As Integer, ByVal objrpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Try
            Dim ObjPrinterSetting As New System.Drawing.Printing.PrinterSettings
            Dim PkSize As New System.Drawing.Printing.PaperSize

            ObjPrinterSetting.PrinterName = "Epson FX1170"

            For i As Integer = 0 To ObjPrinterSetting.PaperSizes.Count - 1
                If ObjPrinterSetting.PaperSizes.Item(i).PaperName = mPaperSize.Trim Then
                    PkSize = ObjPrinterSetting.PaperSizes.Item(i)
                    Exit For
                End If
            Next

            If PkSize IsNot Nothing Then
                Dim myAppPrintOptions As CrystalDecisions.CrystalReports.Engine.PrintOptions = objrpt.PrintOptions
                myAppPrintOptions.PrinterName = "Epson FX1170"
                myAppPrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLegal 'CType(PkSize.RawKind, CrystalDecisions.Shared.PaperSize)
                objrpt.PrintOptions.PaperOrientation = IIf(PaperOrientation = 1, CrystalDecisions.Shared.PaperOrientation.Portrait, CrystalDecisions.Shared.PaperOrientation.Landscape)
            End If

            PkSize = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EmailReport(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        If e.ClickedItem.Text.ToUpper <> "SEND AS EMAIL" Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim rptFile As String = Application.StartupPath & "\Report.pdf"

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

            Dim frmMail As New frmSendMail
            frmMail.ShowDialog()

        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    ''Satyam 08092022
    Private Sub WhatsApp(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        If e.ClickedItem.Text.ToUpper <> "SEND AS WHATSAPP" Then Exit Sub

        Try

            Me.Cursor = Cursors.WaitCursor

            If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftWareForGcube)) = 1 Then
                If WHATSAPPNO1New = "" Or WHATSAPPNO1New = "0" Or WHATSAPPNO1New.Length < 10 Then
                    MsgBox("WhatsApp Number Of this Party Invalid or Not Specified ..", MsgBoxStyle.Exclamation)
                    Exit Sub

                End If
            Else
                If WHATSAPPNO1 = "" Or WHATSAPPNO1 = "0" Or WHATSAPPNO1.Length < 10 Then
                    MsgBox("WhatsApp Number is an Invalid or Not Specified ..", MsgBoxStyle.Exclamation)
                    Exit Sub


                End If
                If WHATSAPPNO1New = "" Or WHATSAPPNO1New = "0" Or WHATSAPPNO1New.Length < 10 Then
                    MsgBox("WhatsApp Number Of this Party Invalid or Not Specified ..", MsgBoxStyle.Exclamation)
                    Exit Sub

                End If
            End If
           

            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim rptFile As String = ""
            If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftWareForGcube)) = 1 Then
                rptFile = Application.StartupPath & "\GCUBE NX -'" & DOCNO1 & "'.pdf"
            Else
                rptFile = Application.StartupPath & "\'" & DOCNO1 & "'.pdf"
            End If
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

            'Dim frmMail As New frmSendMail
            'frmMail.ShowDialog()
            SendWhatsapp()


        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub PictureEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureEdit1.Click
        MessageBox.Show("Document Is Not Approved Can Not Export and Print", "Approval Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    ''Satyam 01082022
    Private Sub SendWhatsapp()


        If MsgBox("Are You Want to Send Report Via WhatsApp ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then
            Exit Sub

        End If
        Dim path As String = MailAttachments '"C:\Users\VRS18\Downloads\MonicaNx.jpg" '"C:\Users\VRS18\Documents\BILL.pdf"
        Dim no As String = WHATSAPPNO1  ''9869723951
        Dim num As String = WHATSAPPNO1New
        'Dim nUM As String = "8104253742"

        Dim note As String = "Report"
        'Dim note As String = "Dear - " & dtBill.Rows(i)(2) & "" & vbCrLf _
        '                & vbCrLf _
        '               & "This is a gentle reminder to clear your payment dues with Khatunaresh Enterprises Pvt. Ltd. (Bodysize)." & vbCrLf _
        '               '& "Your total outstanding with Khatunaresh Enterprises Pvt. Ltd. until now is Rs  " & dtBill.Rows(i)(8) & "." & vbCrLf _
        '               & "We request you to clear your dues as soon as possible to avoid deduction of 5% cash discount. (Cash Discount is not applicable on payments made after 45 days)." & vbCrLf _
        '                 & "Any pending or new order will not be dispatched till the due payment  is not cleared." & vbCrLf _
        '                    & vbCrLf _
        '               & "Details of your Outstanding and Ledger has been shared below -" & vbCrLf _
        '               & vbCrLf _
        '               & "Regards," & vbCrLf _
        '               & "Bodysize" & vbCrLf
        'Dim SMSMessage As String = "Dear " & txtName.Text & "" & vbCrLf _
        '      & "You Visited On, Date- " & dtpCSTIssueDt.Value & "," & vbCrLf _
        '      & vbCrLf _
        '      & "Please have a look on the Report attached below," & vbCrLf _
        '      & vbCrLf _
        '      & "Thanking You for Shooping With Us !!! " & vbCrLf _
        '      & "A1 COLLECTION, MUMBAI"

        'Dim SMSMessage As String = "Dear " & txtName.Text & "" & vbCrLf _
        '     & "You Visited On, Date- " & dtpCSTIssueDt.Value & "," & vbCrLf _
        '     & vbCrLf _
        '     & "Please have a look on the Report attached below," & vbCrLf _
        '     & vbCrLf _
        '     & "Thanking You for Shooping With Us !!! " & vbCrLf _
        '     & "A1 COLLECTION, MUMBAI"


        If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftWareForGcube)) = 1 Then
            WhatsAppFile(path, num, note)
        Else

            WhatsAppFile(path, no, note)
            msgbool = True
            WhatsAppFile(path, num, note)

        End If
        ' WhatsAppText(SMSMessage, no)
      
    End Sub

    '' Function to send File from local drive


    Public Function WhatsAppFile(ByVal FileNameWithPath As String, ByVal PhoneNoStr As String, ByVal fileCaption As String) As Boolean

        Dim filepath As String = FileNameWithPath ' absolute path of file on local drive
        Dim key As String = GetSettingAsPerId(ApplnSettingsIdx.WhatsAppAPI) ' "cbKICqvGIudvugXZyk" ' your api key
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

            If msgbool = True Then
                MsgBox("WhatsApp Msg Send Successfully..!", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            WhatsAppFile = False
            MsgBox("WhatsApp Msg Sending Request Fail,Please Check Internet Connection..!", MsgBoxStyle.Exclamation)
        End Try

        Return WhatsAppFile

    End Function

    Private Sub ViewPDFReport(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        If e.ClickedItem.Text.ToUpper <> "OPEN IN PDF" Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim rptFile As String = ""
            rptFile = Application.StartupPath & "\Report.pdf"

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

A:          Dim newpath As String = Application.StartupPath & "\Report.pdf"
            Process.Start(newpath)
            'Dim frmPdf As New frmViewPDF(IIf(rptFile.ToString = "", newpath, rptFile))
            'frmPdf.ShowDialog()

        Catch ex As Exception
            ' GoTo A
            MsgBox("Unable To Open As PDF At Present,Please Try Again Later..!", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class