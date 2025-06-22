Imports System.Data.SqlClient

Public Class frmmonthlyreport
    Dim Formulas As Hashtable
    Dim ReportCaption As String = ""
    Dim rptType As ReportType
    Dim DispDetailSummary As DetailSummary

    Enum ReportType
        MonthlycustomerWiseReport
        monthlyFactorywiseReport
        ' ReverseMechanism1
    End Enum
    Enum DetailSummary
        Yes
        No
    End Enum
    Enum OptionType
        Bill
    End Enum
    Enum TransactionType
        SalesOrder
    End Enum
   
    Private Function GetPartyFilter()
        Dim salecountry As String = ""
        Dim PartyFltr As String = ""

        salecountry = GetSelectedAttributes(cmbCountry, "country.Cont_Key")
        If salecountry.Trim.Length > 0 Then
            PartyFltr &= " And " & salecountry
        End If
    End Function
   
    Private Function GetSelectedAttributes(ByVal Combo As Object, ByVal FieldName As String)
        Dim SelectedItems As String = ""
        Dim AllItems As String = ""
        Dim SelValues As String = ""

        SelectedItems = Combo.Properties.GetCheckedItems
        AllItems = SelectedList(Combo, SelectedItems)

        If AllItems <> "" Then
            SelValues = " {" & FieldName & "} In [" & AllItems & "]"
        Else
            SelValues = ""
        End If

        Return SelValues
    End Function

    Private Function GetFromToDateSeriesFilter(ByVal DateField As String, Optional ByVal AddParam As Boolean = True, Optional ByVal SeriesFltr As Boolean = True) As String
        Dim Series As String = ""
        Dim FromToDate As String = ""
        Formulas = New Hashtable

        If AddParam Then
            Formulas.Add("FromDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
        End If

        FromToDate = " And " & DateField & " >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And " & DateField & " <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & Series

        Return FromToDate
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

    Private Sub frmmonthlyreport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillcombo()
        pnlSummaryDetail.Visible = False
        rdSummary.Visible = False
        rdDetailed.Visible = False
        rdVendor.Visible = False
        pnlDate.Visible = True
        rdCustomer.Visible = False
        pnlPartyOptions.Visible = False
        dtpFrom.Enabled = True
        dtpTo.Enabled = True

        'If rptType = ReportType.ReverseMechanism1 Then

        '    cmbBrand.Enabled = False
        '    cmbCountry.Enabled = False
        '    cmbExecutedBy.Enabled = False
        '    cmbSalesOrder.Enabled = False
        'End If
        Try
            Dim strDate As Date = "1" & "/" & Month(Now()) & "/" & Year(Now())
            Dim dtDate As Date = Format$(strDate, "MM/dd/yyyy")
            dtpFrom.Value = Format$(dtDate, "MM/dd/yyyy")
        Catch ex As Exception

        End Try
        GetSalesOrder()

    End Sub
    Private Sub GetSalesOrder()
        Query = "Select Doc_id, Doc_No " _
                & " From SalesOrder " _
                & " Where Status = '1'  And Doc_No <> '' and DlvDate >= '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' and DlvDate<='" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'" _
                & BranchFixFilter _
                & " Order By Doc_No"
        Common.FillCheckBoxCombo(Query, cmbSalesOrder, "Doc_No", "Doc_id")
    End Sub
    Private Sub fillcombo() 



        Query = "Select Cont_Key, Cont_Name " _
           & " From country " _
           & " Where Status = '1' And Cont_Name <> '' " _
           & BranchFixFilter _
           & " Order By Cont_Name"
        Common.FillCheckBoxCombo(Query, cmbCountry, "Cont_Name", "Cont_Key")


        Query = "Select BRAND_KEY, BRAND_NAME " _
            & " From Brand " _
            & " Where Status = '1' And Brand_Name <> '' " _
            & BranchFixFilter _
            & " Order By Brand_Name"
        Common.FillCheckBoxCombo(Query, cmbBrand, "BRAND_NAME", "BRAND_KEY")

        'Query = "Select Doc_id, Doc_No " _
        '            & " From SalesOrder " _
        '            & " Where Status = '1'  And Doc_No <> '' " _
        '            & BranchFixFilter _
        '            & " Order By Doc_No"
        'Common.FillCheckBoxCombo(Query, cmbSalesOrder, "Doc_No", "Doc_id")
        ''fcyr_id= current date
        'GetSalesOrder()
        Query = "Select Qlty_Key, Qlty_Name " _
                    & " From Quality " _
                    & " Where Status = '1' And Qlty_Name <> '' " _
                    & BranchFixFilter _
                    & " Order By Qlty_Name"
        Common.FillCheckBoxCombo(Query, cmbExecutedBy, "Qlty_Name", "Qlty_Key")


    End Sub

    Private Function GetSelectedAttributesForStock(ByVal Combo As Object, ByVal FieldName As String)
        Dim SelectedItems As String = ""
        Dim AllItems As String = ""
        Dim SelValues As String = ""

        SelectedItems = Combo.Properties.GetCheckedItems
        AllItems = SelectedList(Combo, SelectedItems)

        If AllItems <> "" Then
            SelValues = FieldName & " In [" & AllItems & "]"
        Else
            SelValues = ""
        End If

        Return SelValues
    End Function
    Private Function GetSelectedAttributesNumeric(ByVal Combo As Object, ByVal FieldName As String)
        Dim SelectedItems As String = ""
        Dim AllItems As String = ""
        Dim SelValues As String = ""

        SelectedItems = Combo.Properties.GetCheckedItems
        AllItems = SelectedList(Combo, SelectedItems, True)

        If AllItems <> "" Then
            SelValues = " {" & FieldName & "} In [" & AllItems & "]"
        Else
            SelValues = ""
        End If

        Return SelValues
    End Function
    Private Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim frmView As Form
        Dim PartyFltr As String = ""
        Dim FromToDt As String = ""
        Dim LocFilter As String = ""
        Dim Saleorder As String = ""
        Dim Qualitys As String = ""
        Dim brand As String = ""
        Dim FromToDt1 As String = ""
        Dim revcmval As Integer

        ' FromToDt = GetFromToDateSeriesFilter("{vw_CustomerwiseDlvRpt.Doc_Dt}")

        LocFilter = GetSelectedAttributesForStock(cmbCountry, "{country.Cont_Key}")
        If LocFilter.Trim.Length > 0 Then
            LocFilter = " And " & LocFilter
        End If

        ApprovePrint = True



        brand = GetSelectedAttributesForStock(cmbBrand, "{Brand.Brand_Key}")
        If brand.Trim.Length > 0 Then
            brand = " And " & brand
        End If

        Saleorder = GetSelectedAttributesNumeric(cmbSalesOrder, "salesorder.Doc_id")
        If Saleorder.Trim.Length > 0 Then
            Saleorder = " And " & Saleorder
        End If

        Qualitys = GetSelectedAttributesForStock(cmbExecutedBy, "{Quality.Qlty_Key}")
        If Qualitys.Trim.Length > 0 Then
            Qualitys = " And " & Qualitys
        End If

        If rptType = ReportType.MonthlycustomerWiseReport Then
            '   If rdSummary.Checked = True Then
            PartyFltr = GetPartyFilter()
            FromToDt = GetFromToDateSeriesFilter("{SalesOrder.DlvDate}")

            ReportParameters.rptFile = ReportPath & "\Reports\CustomerwiseDlv.rpt"
            ReportParameters.rptFilter = "{COBR.Cobr_id} = '" & SelBranchId & "' " & FromToDt & LocFilter & brand & Qualitys & Saleorder

            ' End If
        End If
        If rptType = ReportType.monthlyFactorywiseReport Then
            ' If rdSummary.Checked = True Then
            PartyFltr = GetPartyFilter()
            FromToDt = GetFromToDateSeriesFilter("{joborder.Doc_Dt}")

            ReportParameters.rptFile = ReportPath & "\Reports\JobberwiseDlv.rpt"
            ReportParameters.rptFilter = "{COBR.Cobr_id} = '" & SelBranchId & "'" & FromToDt & LocFilter & Qualitys & brand & Saleorder

            ' End If
        End If
        'If rptType = ReportType.ReverseMechanism1 Then


        '    FromToDt = GetFromToDateSeriesFilter("{Purchasebill.Doc_Dt}")


        '    ReportParameters.rptFile = ReportPath & "\Reports\RCM.rpt"

        '    '  ReportParameters.rptFile = ReportPath & "\Reports\RCM.rpt" SelBranchId
        '    'ReportParameters.rptFilter = "{party.revcm} = '1' and  {COBR.Cobr_id} ='" & SelBranchId & "' and {Purchasebill.Net_Amt} > 750" & FromToDt

        '    '  ReportParameters.rptCaption = "Reverse Mechanism"
        'Formulas.Add("ReportCaption#S", ReportParameters.rptCaption)

        'End If

        ReportParameters.rptCaption = Me.Text
        frmView = New frmViewReports(Formulas)
        frmView.Show()

        Formulas = Nothing
    End Sub
   
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dtpFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFrom.KeyDownEvent, dtpTo.KeyDownEvent, cmbCountry.KeyDown, cmbBrand.KeyDown, cmbSalesOrder.KeyDown, cmbExecutedBy.KeyDown, btnView.KeyDown
        'If dtpTo.Focused = True And e.KeyCode = Keys.Enter Then
        '    GetSalesOrder()
        '    MoveToNextControl(e)
        'Else

        'End If
        If e.KeyCode = Keys.Enter Then
            GetSalesOrder()
        End If
        MoveToNextControl(e)
    End Sub




    'Private Sub dtpTo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTo.LostFocus
    '    GetSalesOrder()
    'End Sub
End Class