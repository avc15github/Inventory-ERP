Imports System.Data.SqlClient

Public Class frmAccReportFilters
    Dim Formulas As Hashtable
    Dim ReportCaption As String = ""
    Dim rptType As ReportType
    'Public subrpt() As SubReportDetails
    ' Public subrptFormula() As SubRptFormulaDetails

    Enum ReportType
        DayBook
        CashBook
        BankBook
        GeneralLedger
        Journal
        DebitNote
        CreditNote
        GroupSummary
        GroupVoucher
        Receivables
        Payables
        LedgerOs
        'LedgerOs_sundaryDB_CR
        GroupOs
        TrialBalance
        GroupTrialBalance
        ProfitNLossAc
        ProfitNLossAcScreen
        BalanceSheet
        BalanceSheetScreen
        PurchaseReg
        SalesReg
        DailyCollection
        CustLedger
        OSReminder
        CustBillWise
        TaxSummary
        DiscountSummary
        CFormReminder
        Pending_CForm
        TaxForm_DateWise
        RG1Register
        TaxForm_Recd
        CustConfirmation
        BrokerCommRcptBill
        PartyCommBill
        PartySalesAnalysisQty
        StyleCosting
        TaxSummaryGST
        ReceivablesB
        PTR
        PendingOrderReport
        CustomerOutstanding ''ankita 12122018
        BrokerOutstanding  ''ankita 12122018
    End Enum


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAccReportFilters_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmAccReportFilters_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Me.Cursor = Cursors.WaitCursor

            dtpFrom.Value = AccFromDt
            dtpTo.Value = AccToDt

            Query = "Select STATE_KEY, STATE_NAME " _
                & " From State " _
                & " Where Status = '1' And State_Name <> '' " _
                & BranchFixFilter _
                & " Order By State_Name"
            Common.FillCheckBoxCombo(Query, cmbState, "STATE_NAME", "STATE_KEY")

            Query = "Select ACCGRP_ID, ACCGRP_NAME " _
                & " From AccGrp " _
                & " Where Status = '1' And AccGrp_Name <> '' " _
                & " Order By AccGrp_Name"
            Common.FillCheckBoxCombo(Query, cmbGroup, "ACCGRP_NAME", "ACCGRP_ID")

            If rptType = ReportType.LedgerOs Or rptType = ReportType.GroupOs Or rptType = ReportType.CustomerOutstanding Then
                DisplaySubGroup(" And AccLGrp.AccLGrp_Type In (3,4)")
            Else
                DisplaySubGroup()
            End If

            dtpFrom.Value = AccFromDt
            dtpTo.Value = AccToDt

            rdLedger.Checked = True
            pnlDate.Enabled = True

            Select Case rptType
                Case ReportType.DayBook
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlLedger.Enabled = False

                    Me.Text = "Day Book"

                Case ReportType.CashBook
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    cmbGroup.Enabled = False
                    cmbSubGrp.Enabled = False
                    chkShowBill.Enabled = False

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                        & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                        & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                        & " And AccLGrp.AccLGrp_Type = 1" _
                        & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")

                    Me.Text = "Cash Book"

                Case ReportType.BankBook
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    cmbGroup.Enabled = False
                    cmbSubGrp.Enabled = False
                    chkShowBill.Enabled = False

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                        & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                        & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                        & " And AccLGrp.AccLGrp_Type = 2" _
                        & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")

                    Me.Text = "Bank Book"

                Case ReportType.GeneralLedger
                    ''CHANGE BY RAHUL ON 13/04/2019
                    If Val(GetSettingAsPerId(ApplnSettingsIdx.DisplayOutlet)) = 1 Then
                        lblBroker.Visible = True : cmbBroker.Visible = True
                        lblBroker.Text = "Outlet"

                        Query = "Select LED_KEY, LED_NAME " _
                              & " From Ledger Where Led_Cat In ('F') And Status = '1'" _
                              & BranchFixFilter _
                              & " Order By Led_Name"
                        Common.FillCheckBoxCombo(Query, cmbBroker, "LED_NAME", "LED_KEY")
                    End If
                    ''END
                    Me.Text = "General Ledger"

                Case ReportType.Journal
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlLedger.Enabled = False

                    Me.Text = "Journal Register"

                Case ReportType.DebitNote
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlLedger.Enabled = False

                    Me.Text = "Debit Note Register"

                Case ReportType.CreditNote
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlLedger.Enabled = False

                    Me.Text = "Credit Note Register"

                Case ReportType.GroupSummary
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbLedger.Enabled = False

                    Me.Text = "Group Summary"

                Case ReportType.GroupVoucher
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbLedger.Enabled = False

                    Me.Text = "Group Voucher"

                Case ReportType.Receivables
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    chkShowBill.Enabled = False
                    chkShowNarration.Enabled = False
                    cmbGroup.Enabled = False
                    cmbSubGrp.Enabled = False
                    cmbLedger.Enabled = True
                    chkOverdue.Visible = True
                    chkShowCostCtr.Visible = True
                    chkShowCostCtr.Text = "Age Wise"

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And AccLGrp.AccLgrp_Type =4 " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")

                    Me.Text = "Receivables"

                Case ReportType.ReceivablesB
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    chkShowBill.Enabled = False
                    chkShowNarration.Enabled = False
                    cmbGroup.Enabled = False
                    cmbSubGrp.Enabled = False
                    cmbLedger.Enabled = True
                    chkOverdue.Visible = True
                    chkShowCostCtr.Visible = True
                    chkShowCostCtr.Text = "Age Wise"

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And AccLGrp.AccLgrp_Type =4 " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")

                    Me.Text = "Receivables B"

                Case ReportType.Payables
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    chkShowBill.Enabled = False
                    chkShowNarration.Enabled = False
                    cmbGroup.Enabled = False
                    cmbSubGrp.Enabled = False
                    cmbLedger.Enabled = True
                    chkOverdue.Visible = True
                    chkShowCostCtr.Visible = True
                    chkShowCostCtr.Text = "Age Wise"

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And AccLGrp.AccLgrp_Type =3 " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")

                    Me.Text = "Payables"

                Case ReportType.LedgerOs
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False

                    cmbGroup.Enabled = False
                    rdAll.Checked = True
                    chkShowBill.Enabled = False
                    chkShowNarration.Enabled = False
                    chkOverdue.Visible = True

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                       & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                       & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                       & " And AccLGrp.AccLgrp_Type in(3,4) " _
                       & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")

                    Me.Text = "O/s Ledgers"

                    ''ankita 12122018
                Case ReportType.CustomerOutstanding
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False

                    cmbGroup.Enabled = False
                    rdAll.Checked = True
                    chkShowBill.Enabled = False
                    chkShowNarration.Enabled = False
                    chkOverdue.Visible = True

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                       & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                       & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                       & " And AccLGrp.AccLgrp_Type in(3,4) " _
                       & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")

                    Me.Text = "Customer Outstanding"
                    ''end ankita 12122018
                Case ReportType.GroupOs
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlSummaryDetail.Enabled = False
                    cmbGroup.Enabled = False
                    rdAll.Checked = True
                    chkShowBill.Enabled = False
                    chkShowNarration.Enabled = False

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                       & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                       & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                       & " And AccLGrp.AccLgrp_Type In(3,4)  " _
                       & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")

                    Me.Text = "O/s Groups"

                Case ReportType.TrialBalance
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    'chkShowBill.Enabled = False
                    chkShowNarration.Enabled = False

                    ''CHANGE BY RAHUL ON 17/04/2019
                    ''pnlLedger.Enabled = False
                    ''END

                    chkOverdue.Visible = True
                    chkOverdue.Text = "Show Due Only"
                    chkShowBill.Text = "Show Ledger Wise"
                    Me.Text = "Trial Balance"

                    ''CHANGE BY RAHUL ON 17/04/2019
                    If Val(GetSettingAsPerId(ApplnSettingsIdx.DisplayOutlet)) = 1 Then
                        lblGroup.Enabled = False : cmbGroup.Enabled = False
                        lblSubGroup.Enabled = False : cmbSubGrp.Enabled = False
                        lblParty.Enabled = False : cmbLedger.Enabled = False
                        lblBroker.Visible = True : cmbBroker.Visible = True
                        lblBroker.Text = "Outlet"

                        Query = "Select LED_KEY, LED_NAME " _
                              & " From Ledger Where Led_Cat In ('F') And Status = '1'" _
                              & BranchFixFilter _
                              & " Order By Led_Name"
                        Common.FillCheckBoxCombo(Query, cmbBroker, "LED_NAME", "LED_KEY")
                    Else
                        pnlLedger.Enabled = False
                    End If
                    ''END

                Case ReportType.GroupTrialBalance
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    cmbLedger.Enabled = False
                    chkShowNarration.Enabled = False
                    chkShowBill.Text = "Show Ledger Wise"
                    chkOverdue.Visible = True
                    chkOverdue.Text = "Show Due Only"

                    Me.Text = "Group Trial Balance"

                Case ReportType.ProfitNLossAc
                    pnlPartyOptions.Enabled = False
                    pnlSummaryDetail.Enabled = False
                    pnlLocation.Enabled = False
                    chkShowNarration.Enabled = False
                    pnlLedger.Enabled = False
                    chkShowBill.Text = "Show Ledger Wise"

                    If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForRamtex)) = 1 Then
                        chkOverdue.Visible = True
                        chkOverdue.Text = "Show Vertical Wise"
                        chkOverdue.Checked = True
                    End If

                    If AccToDt > Now Then
                        dtpTo.Value = Now
                    End If
                    Me.Text = "Profit & Loss A/c"

                Case ReportType.ProfitNLossAcScreen
                    pnlPartyOptions.Enabled = False
                    pnlSummaryDetail.Enabled = False
                    pnlLocation.Enabled = False
                    chkShowNarration.Enabled = False
                    pnlLedger.Enabled = False
                    chkShowBill.Enabled = False
                    If AccToDt > Now Then
                        dtpTo.Value = Now
                    End If
                    Me.Text = "Profit & Loss A/c (Screen)"

                Case ReportType.PTR
                    pnlPartyOptions.Enabled = False
                    pnlSummaryDetail.Enabled = False
                    pnlLocation.Enabled = False
                    chkShowNarration.Enabled = False
                    pnlLedger.Enabled = False
                    chkShowBill.Enabled = False
                    'If AccToDt > Now Then
                    dtpTo.Value = Now
                    'End If
                    lblFrom.Visible = False
                    dtpFrom.Enabled = False
                    dtpTo.Enabled = False
                    lblTo.Visible = False
                    Me.Text = "Pending Task Report"

                Case ReportType.PendingOrderReport
                    pnlPartyOptions.Enabled = False
                    pnlSummaryDetail.Enabled = False
                    pnlLocation.Enabled = False
                    chkShowNarration.Enabled = False
                    pnlLedger.Enabled = False
                    chkShowBill.Enabled = False
                    'If AccToDt > Now Then
                    'dtpTo.Value = Now
                    'End If
                    'lblFrom.Visible = False
                    'dtpFrom.Enabled = False
                    'dtpTo.Enabled = False
                    'lblTo.Visible = False
                    Me.Text = "Pending Order Report"
                Case ReportType.BalanceSheet
                    pnlPartyOptions.Enabled = False
                    pnlSummaryDetail.Enabled = False
                    pnlLocation.Enabled = False
                    chkShowNarration.Enabled = False
                    pnlLedger.Enabled = False
                    chkShowBill.Text = "Show Ledger Wise"
                    lblFrom.Visible = False : dtpFrom.Visible = False

                    If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForRamtex)) = 1 Then
                        chkOverdue.Visible = True
                        chkOverdue.Text = "Show Vertical Wise"
                        chkOverdue.Checked = True
                    End If

                    lblTo.Text = "As On "
                    If AccToDt > Now Then
                        dtpTo.Value = Now
                    End If
                    'dtpTo.Value = Now

                    Me.Text = "Balance Sheet"

                Case ReportType.BalanceSheetScreen
                    pnlPartyOptions.Enabled = False
                    pnlSummaryDetail.Enabled = False
                    pnlLocation.Enabled = False
                    chkShowNarration.Enabled = False
                    pnlLedger.Enabled = False
                    chkShowBill.Enabled = False
                    lblFrom.Visible = False : dtpFrom.Visible = False
                    lblTo.Text = "As On "
                    'dtpTo.Value = Now
                    If AccToDt > Now Then
                        dtpTo.Value = Now
                    End If
                    Me.Text = "Balance Sheet Screen"

                Case ReportType.PurchaseReg
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlOtherOptions.Enabled = False
                    pnlLedger.Enabled = False
                    cmbLedger.Enabled = False

                    Me.Text = "Purchase Register"

                Case ReportType.SalesReg
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlOtherOptions.Enabled = False
                    pnlLedger.Enabled = False
                    cmbLedger.Enabled = False

                    Me.Text = "Sales Register"

                Case ReportType.DailyCollection
                    pnlPartyOptions.Enabled = False
                    pnlLocation.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False
                    cmbSubGrp.Enabled = False
                    cmbLedger.Enabled = True
                    lblBroker.Visible = True : cmbBroker.Visible = True
                    lblSalesPerson.Visible = True : cmbSalesPerson.Visible = True

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And AccLGrp.AccLgrp_Type =4 " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And Led_Cat in('B') " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbBroker, "LED_NAME", "LED_KEY")

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And Led_Cat in('S') " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbSalesPerson, "LED_NAME", "LED_KEY")

                    Me.Text = "Daily Collection"

                Case ReportType.CustLedger
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Enabled = False : cmbSalesPerson.Enabled = False
                    lblBroker.Enabled = False : lblSalesPerson.Enabled = False
                    cmbLedger.Enabled = True
                    rdCustomer.Checked = True

                    Me.Text = "Customer Ledger"

                Case ReportType.CustBillWise
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Enabled = False : cmbSalesPerson.Enabled = False
                    lblBroker.Enabled = False : lblSalesPerson.Enabled = False
                    cmbLedger.Enabled = True
                    rdCustomer.Checked = True

                    Me.Text = "Customer A/c - BillWise"

                Case ReportType.CFormReminder
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Visible = True : cmbSalesPerson.Enabled = False
                    lblBroker.Visible = True : lblSalesPerson.Enabled = False
                    lblTaxForm.Visible = True : cmbFormType.Visible = True
                    cmbLedger.Enabled = True : rdCustomer.Checked = True
                    lblFrom.Visible = False : dtpFrom.Visible = False
                    lblTo.Text = "Bill Upto"

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And Led_Cat in('B') " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbBroker, "LED_NAME", "LED_KEY")

                    With cmbFormType.Items
                        .Add("<<ALL>>")
                        .Add("C-Form")
                        .Add("F-Form")
                        .Add("H-Form")
                        .Add("I-Form")
                    End With
                    cmbFormType.DropDownStyle = ComboBoxStyle.DropDownList
                    cmbFormType.SelectedIndex = 1

                    Me.Text = "Tax Form Reminder"

                Case ReportType.Pending_CForm
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Visible = True : cmbSalesPerson.Enabled = False
                    lblBroker.Visible = True : lblSalesPerson.Enabled = False
                    lblTaxForm.Visible = True : cmbFormType.Visible = True
                    cmbLedger.Enabled = True : rdCustomer.Checked = True
                    lblFrom.Visible = True : dtpFrom.Visible = True
                    'lblTo.Text = "Bill Upto"
                    'lblFrom.Text = "Bill From"

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And Led_Cat in('B') " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbBroker, "LED_NAME", "LED_KEY")

                    With cmbFormType.Items
                        .Add("<<ALL>>")
                        .Add("C-Form")
                        .Add("F-Form")
                        .Add("H-Form")
                        .Add("I-Form")
                    End With
                    cmbFormType.DropDownStyle = ComboBoxStyle.DropDownList
                    cmbFormType.SelectedIndex = 1

                    Me.Text = "Pending Tax Form Details"

                Case ReportType.TaxForm_DateWise
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Visible = False : cmbSalesPerson.Visible = False
                    lblBroker.Visible = False : lblSalesPerson.Visible = False
                    lblTaxForm.Visible = True : cmbFormType.Visible = True
                    cmbLedger.Enabled = True : rdCustomer.Checked = True
                    lblFrom.Visible = False : dtpFrom.Visible = False
                    lblTo.Text = "Bill Upto"

                    With cmbFormType.Items
                        .Add("<<ALL>>")
                        .Add("C-Form")
                        .Add("F-Form")
                        .Add("H-Form")
                        .Add("I-Form")
                    End With
                    cmbFormType.DropDownStyle = ComboBoxStyle.DropDownList
                    cmbFormType.SelectedIndex = 1

                    Me.Text = "Tax Form Status (Date Wise)"

                Case ReportType.TaxForm_Recd
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Visible = False : cmbSalesPerson.Visible = False
                    lblBroker.Visible = False : lblSalesPerson.Visible = False
                    lblTaxForm.Visible = True : cmbFormType.Visible = True
                    cmbLedger.Enabled = True : rdCustomer.Checked = True
                    lblFrom.Visible = False : dtpFrom.Visible = False
                    lblTo.Text = "Bill Upto"

                    With cmbFormType.Items
                        .Add("<<ALL>>")
                        .Add("C-Form")
                        .Add("F-Form")
                        .Add("H-Form")
                        .Add("I-Form")
                    End With
                    cmbFormType.DropDownStyle = ComboBoxStyle.DropDownList
                    cmbFormType.SelectedIndex = 1

                    Me.Text = "Tax Form Received"

                Case ReportType.OSReminder
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Enabled = False : cmbSalesPerson.Enabled = False
                    lblBroker.Enabled = False : lblSalesPerson.Enabled = False
                    cmbLedger.Enabled = True
                    rdCustomer.Checked = True
                    lblFrom.Visible = False : dtpFrom.Visible = False
                    lblTo.Text = "Bill Upto"

                    Me.Text = "Outstanding Reminder (Party Wise)"

                Case ReportType.TaxSummary
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False : pnlLedger.Enabled = False
                    pnlLocation.Enabled = False

                    Me.Text = "Tax Summary"

                    ''Rohit 16082017
                Case ReportType.TaxSummaryGST
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False : pnlLedger.Enabled = False
                    pnlLocation.Enabled = False

                    Me.Text = "GST Summary"

                    '''End Rohit
                Case ReportType.DiscountSummary
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False : pnlLedger.Enabled = False
                    pnlLocation.Enabled = False

                    Me.Text = "Discount Summary"

                Case ReportType.RG1Register
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False : pnlLedger.Enabled = False
                    pnlLocation.Enabled = False

                    Me.Text = "RG1 Register"

                Case ReportType.CustConfirmation
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = True
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Enabled = False : cmbSalesPerson.Enabled = False
                    lblBroker.Enabled = False : lblSalesPerson.Enabled = False
                    cmbLedger.Enabled = True
                    rdCustomer.Checked = True

                    Me.Text = "Customer A/c Confirmation"

                Case ReportType.PartyCommBill
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Enabled = False : cmbSalesPerson.Enabled = False
                    lblBroker.Visible = False : lblSalesPerson.Enabled = False
                    cmbLedger.Enabled = True : rdCustomer.Checked = True
                    pnlLocation.Enabled = False
                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And Led_Cat in('B') " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbBroker, "LED_NAME", "LED_KEY")

                Case ReportType.BrokerCommRcptBill
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Visible = True : cmbSalesPerson.Enabled = False
                    lblBroker.Visible = True : lblSalesPerson.Enabled = False
                    cmbLedger.Enabled = True : rdCustomer.Checked = True

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And Led_Cat in('B') " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbBroker, "LED_NAME", "LED_KEY")
                    ''ankita 12122018

                Case ReportType.BrokerOutstanding
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Visible = True : cmbSalesPerson.Enabled = False
                    lblBroker.Visible = True : lblSalesPerson.Enabled = False
                    cmbLedger.Enabled = True : rdCustomer.Checked = True

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And Led_Cat in('B') " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbBroker, "LED_NAME", "LED_KEY")
                    ''end ankita 12122018

                Case ReportType.PartySalesAnalysisQty
                    pnlPartyOptions.Enabled = False : pnlSummaryDetail.Enabled = False
                    pnlOtherOptions.Enabled = False
                    cmbGroup.Enabled = False : cmbSubGrp.Enabled = False
                    lblGroup.Enabled = False : lblSubGroup.Enabled = False
                    cmbBroker.Visible = True : cmbSalesPerson.Enabled = False
                    lblBroker.Visible = True : lblSalesPerson.Enabled = False
                    cmbLedger.Enabled = True : rdCustomer.Checked = True

                    Query = "Select Distinct LED_KEY, LED_NAME " _
                      & " From Ledger " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                      & " And Led_Cat in('B') " _
                      & " Order By Led_Name"
                    Common.FillCheckBoxCombo(Query, cmbBroker, "LED_NAME", "LED_KEY")

                    Me.Text = "PartyWise Sales Summary With CN And Qty Report"

            End Select

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        SetReportParameters()
    End Sub

    Private Function GetFromToDateSeriesFilter(ByVal DateField As String, ByVal SeriesField As String, Optional ByVal AddParam As Boolean = True) As String
        Dim Series As String = ""
        Dim FromToDate As String = ""

        'If rdA.Checked Then
        '    Series = " And " & SeriesField & " = 'A'"
        'ElseIf rdB.Checked Then
        '    Series = " And " & SeriesField & " = 'B'"
        'End If

        If AddParam Then
            Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
        End If

        FromToDate = " And " & DateField & " >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And " & DateField & " <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & Series

        Return FromToDate
    End Function

    Private Sub cmbState_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles cmbState.Closed
        If cmbState.IsModified Then
            cmbCity.Properties.DataSource = Nothing
            cmbCity.SetEditValue("")
            ClearDropDown(cmbCity)

            cmbLedger.Properties.DataSource = Nothing
            cmbLedger.SetEditValue("")
            ClearDropDown(cmbLedger)

            DisplayLedger()
            If cmbState.Properties.Items.GetCheckedValues.Count = 0 Then Exit Sub

            DisplayCity()
            DisplayLedger()
        End If
    End Sub

    Private Sub ClearDropDown(ByVal Combo As Object)
        Dim i As Short

        If Combo.Properties.Items.Count > 0 Then
            For i = Combo.Properties.Items.Count - 1 To 0 Step -1
                Combo.Properties.Items.Remove(Combo.Properties.Items(i))
            Next i
        End If
    End Sub

    Private Sub DisplayCity()
        Dim SelectedItems As String = cmbState.Properties.GetCheckedItems
        Dim AllState As String = SelectedList(cmbState, SelectedItems)

        If AllState <> "" Then
            AllState = " And State.State_Key In (" & AllState & ")"
        Else
            AllState = ""
        End If

        Query = "Select Station.Stn_Key, Stn_Name From Station " _
            & " Inner Join State On State.State_Key = Station.State_Key " _
            & " Where Station.Stn_Key <> '' And Station.CoBr_Id = '" & SelBranchFixId & "' And Station.Status = '1' " _
            & AllState _
            & " Order By Stn_Name"
        Common.FillCheckBoxCombo(Query, cmbCity, "Stn_Name", "Stn_Key")
    End Sub

    Private Sub DisplayLedger()
        Try
            Dim SelectedItems As String = cmbState.Properties.GetCheckedItems
            Dim AllState As String = SelectedList(cmbState, SelectedItems)

            If AllState <> "" Then
                AllState = " And State.State_Key In (" & AllState & ")"
            Else
                AllState = ""
            End If

            SelectedItems = cmbCity.Properties.GetCheckedItems
            Dim AllCity As String = SelectedList(cmbCity, SelectedItems)

            If AllCity <> "" Then
                AllCity = " And Station.Stn_Key In (" & AllCity & ")"
            Else
                AllCity = ""
            End If

            SelectedItems = cmbGroup.Properties.GetCheckedItems
            Dim AllGroup As String = SelectedList(cmbGroup, SelectedItems, True)

            If AllGroup <> "" Then
                AllGroup = " And AccLGrp.AccGrp_Id In (" & AllGroup & ")"
            Else
                AllGroup = ""
            End If

            SelectedItems = cmbSubGrp.Properties.GetCheckedItems
            Dim AllSubGroup As String = SelectedList(cmbSubGrp, SelectedItems)

            If AllSubGroup <> "" Then
                AllSubGroup = " And Ledger.AccLGrp_Key In (" & AllSubGroup & ")"
            Else
                AllSubGroup = ""
            End If

            Dim LedgerFltr As String = ""

            If rdCustomer.Checked Then
                If rptType = ReportType.CustLedger Or rptType = ReportType.CustBillWise Or rptType = ReportType.CFormReminder Or rptType = ReportType.Pending_CForm Or rptType = ReportType.TaxForm_DateWise Or rptType = ReportType.TaxForm_Recd Or rptType = ReportType.CustConfirmation Or rptType = ReportType.PartyCommBill Or rptType = ReportType.BrokerCommRcptBill Or rptType = ReportType.PartySalesAnalysisQty Or rptType = ReportType.BrokerOutstanding Then
                    LedgerFltr = " And Led_Cat in ('R','W','D') "
                ElseIf rptType = ReportType.OSReminder Then
                    LedgerFltr = " And Led_Cat in ('R','W','D','B') "
                Else
                    LedgerFltr = " And Led_Cat = 'R'"
                End If

            ElseIf rdVendor.Checked Then
                LedgerFltr = " And Led_Cat = 'V'"

            ElseIf rdLedger.Checked Then
                LedgerFltr = " And Led_Cat = 'L'"
            End If

            Dim GrpFltr As String = ""

            If rptType = ReportType.LedgerOs Or rptType = ReportType.GroupOs Or rptType = ReportType.CustomerOutstanding Then
                GrpFltr = " And AccLGrp.AccLGrp_Type In (3,4)"
            End If

            Query = "Select Distinct LED_KEY, LED_NAME " _
                & " From Ledger Left Join Station On Ledger.OStn_Key = Station.Stn_Key " _
                & " Left Join State On State.State_Key = Station.State_Key " _
                & " Left Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchFixId & "' And Led_Name <> '' " _
                & AllState & AllCity & AllGroup & AllSubGroup & LedgerFltr & GrpFltr _
                & " Order By Led_Name"
            Common.FillCheckBoxCombo(Query, cmbLedger, "LED_NAME", "LED_KEY")



        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

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

    Private Sub cmbGroup_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles cmbGroup.Closed
        If cmbGroup.IsModified Then
            cmbSubGrp.Properties.DataSource = Nothing
            cmbSubGrp.SetEditValue("")
            ClearDropDown(cmbSubGrp)

            cmbLedger.Properties.DataSource = Nothing
            cmbLedger.SetEditValue("")
            ClearDropDown(cmbLedger)

            DisplayLedger()
            If cmbGroup.Properties.Items.GetCheckedValues.Count = 0 Then Exit Sub

            DisplaySubGroup()
            DisplayLedger()
        End If
    End Sub

    Private Sub DisplaySubGroup(Optional ByVal Fltr As String = "")
        Dim SelectedItems As String = cmbGroup.Properties.GetCheckedItems
        Dim AllItems As String = SelectedList(cmbGroup, SelectedItems, True)

        If AllItems <> "" Then
            SelectedItems = " And AccLGrp.AccGrp_Id In (" & AllItems & ")"
        Else
            SelectedItems = ""
        End If

        Query = "Select ACCLGRP_KEY, ACCLGRP_NAME " _
            & " From AccLGrp Left Join AccGrp On AccLGrp.AccGrp_Id = AccGrp.AccGrp_Id " _
            & " Where AccLGrp.Status = '1' And AccLGrp.CoBr_Id = '" & SelBranchFixId & "' And AccLGrp_Name <> '' " _
            & SelectedItems & Fltr _
            & " Order By AccLGrp_Name"
        Common.FillCheckBoxCombo(Query, cmbSubGrp, "ACCLGRP_NAME", "ACCLGRP_KEY")
    End Sub

    Private Sub cmbCity_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles cmbCity.Closed
        If cmbCity.IsModified Then
            cmbLedger.Properties.DataSource = Nothing
            cmbLedger.SetEditValue("")
            ClearDropDown(cmbLedger)

            DisplayLedger()
        End If
    End Sub

    Private Sub cmbSubGrp_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles cmbSubGrp.Closed
        If cmbSubGrp.IsModified Then
            cmbLedger.Properties.DataSource = Nothing
            cmbLedger.SetEditValue("")
            ClearDropDown(cmbLedger)

            DisplayLedger()
        End If
    End Sub

    Private Sub rdCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdCustomer.CheckedChanged, rdVendor.CheckedChanged, rdLedger.CheckedChanged, rdAll.CheckedChanged
        DisplayLedger()
    End Sub

    Private Sub chkShowBill_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowBill.CheckedChanged
        If rptType = ReportType.GroupTrialBalance Or rptType = ReportType.TrialBalance Then
            If chkShowBill.Checked Then rdSummary.Checked = True
            pnlSummaryDetail.Enabled = Not chkShowBill.Checked
        End If
    End Sub

    Private Sub cmbState_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbGroup.KeyDown, cmbLedger.KeyDown, rdCustomer.KeyDown, rdVendor.KeyDown, rdLedger.KeyDown, rdAll.KeyDown, chkShowBill.KeyDown, chkShowNarration.KeyDown, chkShowCostCtr.KeyDown, chkInclOpBal.KeyDown, rdSummary.KeyDown, rdDetailed.KeyDown, cmbCity.KeyDown, cmbState.KeyDown, cmbSubGrp.KeyDown, cmbSalesPerson.KeyDown, cmbBroker.KeyDown, dtpTo.KeyDownEvent, dtpFrom.KeyDownEvent
        MoveToNextControl(e)
    End Sub

    Private Function GetFromToDateSeriesFilter(ByVal DateField As String, Optional ByVal AddParam As Boolean = True) As String
        Dim FromToDate As String = ""

        If AddParam Then
            Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
        End If

        FromToDate = " And " & DateField & " >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And " & DateField & " <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

        Return FromToDate
    End Function

    Private Function GetPartyFilter(ByVal Table As String, Optional ByVal ActualTable As Boolean = False) As String
        Dim SelState As String = ""
        Dim SelCity As String = ""
        Dim SelGroup As String = ""
        Dim SelSubGroup As String = ""
        Dim SelParties As String = ""
        Dim PartyFltr As String = ""

        SelState = GetSelectedAttributes(cmbState, "State.State_Key", False)
        If SelState.Trim.Length > 0 Then
            PartyFltr &= " And " & SelState
        End If

        SelCity = GetSelectedAttributes(cmbCity, "City.Stn_Key", False)
        If SelCity.Trim.Length > 0 Then
            PartyFltr &= " And " & SelCity
        End If

        SelGroup = GetSelectedAttributes(cmbGroup, "AccGrp.AccGrp_Id", True)
        If SelGroup.Trim.Length > 0 Then
            PartyFltr &= " And " & SelGroup
        End If

        SelSubGroup = GetSelectedAttributes(cmbSubGrp, "AccLGrp.AccLGrp_Key", False)
        If SelSubGroup.Trim.Length > 0 Then
            PartyFltr &= " And " & SelSubGroup
        End If
        If rptType = ReportType.PartyCommBill Then
            SelParties = GetSelectedAttributes(cmbLedger, Table & ".cust_Key", False)
        ElseIf rptType = ReportType.OSReminder Or rptType = ReportType.CFormReminder Or rptType = ReportType.Pending_CForm Or rptType = ReportType.TaxForm_DateWise Or rptType = ReportType.TaxForm_Recd Or rptType = ReportType.PartyCommBill Or rptType = ReportType.BrokerCommRcptBill Or rptType = ReportType.PartySalesAnalysisQty Or rptType = ReportType.BrokerOutstanding Then
            SelParties = GetSelectedAttributes(cmbLedger, Table & ".Party_Id", False)
        ElseIf rptType = ReportType.CustLedger Or rptType = ReportType.CustBillWise Then
            SelParties = GetSelectedAttributes(cmbLedger, Table & ".Party_Key", False)
        Else
            SelParties = GetSelectedAttributes(cmbLedger, Table & ".Led_Key", False)
        End If

        If SelParties.Trim.Length > 0 Then
            PartyFltr &= " And " & SelParties
        End If

        Return PartyFltr
    End Function

    Private Function GetSelectedAttributes(ByVal Combo As Object, ByVal FieldName As String, ByVal IsNumber As Boolean)
        Dim SelectedItems As String = ""
        Dim AllItems As String = ""
        Dim SelValues As String = ""

        SelectedItems = Combo.Properties.GetCheckedItems
        AllItems = SelectedList(Combo, SelectedItems, IsNumber)

        If AllItems <> "" Then
            SelValues = " {" & FieldName & "} In [" & AllItems & "]"
        Else
            SelValues = ""
        End If

        Return SelValues
    End Function

    Private Sub SetReportParameters()
        Dim FromToDt As String = ""
        Dim PartyFltr As String = ""
        Dim LedType As String = ""
        Dim SelBroker As String = ""
        Dim BrokerFltr As String = ""
        Dim SelLedger As String = ""
        Dim LedgerFltr As String = ""
        Dim SelStation As String = ""
        Dim StationFltr As String = ""

        Formulas = New Hashtable
        ReDim subrpt(0)

        If rdCustomer.Checked Then
            LedType = " And {Ledger.Led_Cat} = 'W'"
        ElseIf rdVendor.Checked Then
            LedType = " And {Ledger.Led_Cat} = 'V'"
        ElseIf rdLedger.Checked Then
            LedType = " And {Ledger.Led_Cat} = 'L'"
        ElseIf rdAll.Checked Then

        End If

        If cmbFormType.SelectedIndex = 0 Then
            FormType = ""
        ElseIf cmbFormType.SelectedIndex = 1 Then
            FormType = "C"
        ElseIf cmbFormType.SelectedIndex = 2 Then
            FormType = "F"
        ElseIf cmbFormType.SelectedIndex = 3 Then
            FormType = "H"
        ElseIf cmbFormType.SelectedIndex = 4 Then
            FormType = "I"
        End If

        Select Case rptType
            Case ReportType.DayBook
                FromToDt = GetFromToDateSeriesFilter("{vw_DayBook.Doc_Dt}")

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("TotalFooter#N", 0)
                Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))
                Formulas.Add("ReportCaption#S", Me.Text)

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\DayBook.rpt"
                ReportParameters.rptFilter = "{vw_DayBook.CoBr_Id} = '" & SelBranchId & "'" & FromToDt

            Case ReportType.CashBook
                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")
                PartyFltr = GetPartyFilter("vw_GenLedger")

                If PartyFltr.Trim.Length = 0 Then
                    PartyFltr = " And {AccLGrp.AccLGrp_Type} = 1"
                End If

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))

                If cmbLedger.Properties.Items.GetCheckedValues.Count > 1 Or cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    Formulas.Add("MultiLedger#N", 1)
                Else
                    Formulas.Add("MultiLedger#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\GenLedger.rpt"
                ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' AND {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr

            Case ReportType.BankBook
                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")
                PartyFltr = GetPartyFilter("vw_GenLedger")

                If PartyFltr.Trim.Length = 0 Then
                    PartyFltr = " And {AccLGrp.AccLGrp_Type} = 2"
                End If

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))
                If cmbLedger.Properties.Items.GetCheckedValues.Count > 1 Or cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    Formulas.Add("MultiLedger#N", 1)
                Else
                    Formulas.Add("MultiLedger#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\GenLedger.rpt"
                ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' AND {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr

            Case ReportType.GeneralLedger
                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")
                PartyFltr = GetPartyFilter("vw_GenLedger")

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))

                If cmbLedger.Properties.Items.GetCheckedValues.Count > 1 Or cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    Formulas.Add("MultiLedger#N", 1)
                Else
                    Formulas.Add("MultiLedger#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text

                ''CHANGE BY RAHUL ON 13/04/2019
                If Val(GetSettingAsPerId(ApplnSettingsIdx.DisplayOutlet)) = 1 Then
                    SelBroker = GetSelectedAttributes(cmbBroker, "vw_GenLedger.Outlet_Key", False)
                    If SelBroker.Trim.Length > 0 Then
                        BrokerFltr &= " And " & SelBroker
                    End If

                    If SelBroker.Trim.Length > 0 Then
                        ReportParameters.rptFile = ReportPath & "\Accounts\GenLedgerOutlet.rpt"
                        ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' AND {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr & LedType & BrokerFltr
                    Else
                        ReportParameters.rptFile = ReportPath & "\Accounts\GenLedger.rpt"
                        ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' AND {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr & LedType
                    End If
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\GenLedger.rpt"
                    ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' AND {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr & LedType

                End If
                ''END

            Case ReportType.CustLedger
                FromToDt = GetFromToDateSeriesFilter("{VIEW_BYRACCOUNT.Doc_Dt}")
                PartyFltr = GetPartyFilter("VIEW_BYRACCOUNT")

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccount.rpt"
                ReportParameters.rptFilter = "{VIEW_BYRACCOUNT.CoBr_Id} = '" & SelBranchId & "' AND {VIEW_BYRACCOUNT.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr

            Case ReportType.CustBillWise
                FromToDt = GetFromToDateSeriesFilter("{VIEW_BYRACCOUNT_DEBITS.Doc_Dt}")
                PartyFltr = GetPartyFilter("VIEW_BYRACCOUNT_DEBITS")

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccountBill.rpt"
                'ReportParameters.rptFilter = "{VIEW_BYRACCOUNT_DEBITS.CoBr_Id} = '" & SelBranchId & "' AND {VIEW_BYRACCOUNT_DEBITS.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr
                ReportParameters.rptFilter = "{VIEW_BYRACCOUNT_DEBITS.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & "" & PartyFltr
            Case ReportType.OSReminder
                FromToDt = GetFromToDateSeriesFilter("{View_OSBills.Doc_Dt}")
                PartyFltr = GetPartyFilter("View_OSBills")

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\OsReminder.rpt"
                ReportParameters.rptFilter = "{View_OSBills.CoBr_Id} = '" & SelBranchId & "' AND {View_OSBills.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr

            Case ReportType.CFormReminder
                PartyFltr = GetPartyFilter("PendCform")

                SelBroker = GetSelectedAttributes(cmbBroker, "Broker.Led_Key", False)
                If SelBroker.Trim.Length > 0 Then
                    BrokerFltr &= " And " & SelBroker
                End If

                SelLedger = GetSelectedAttributes(cmbBroker, "Ledger.Led_Key", False)
                If SelLedger.Trim.Length > 0 Then
                    LedgerFltr &= " And " & SelLedger
                End If

                If cmbFormType.SelectedIndex > 0 Then
                    BrokerFltr &= " AND {PENDCFORM.FORM_Type}= " & Chr(34) & FormType & Chr(34)
                End If
                Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Reports\CformReminder.rpt"
                ReportParameters.rptFilter = "{PendCform.CoBr_Id} = '" & SelBranchId & "' AND {PendCform.Bill_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr & BrokerFltr

            Case ReportType.Pending_CForm
                PartyFltr = GetPartyFilter("PendCform")

                SelBroker = GetSelectedAttributes(cmbBroker, "Broker.Led_Key", False)
                If SelBroker.Trim.Length > 0 Then
                    BrokerFltr &= " And " & SelBroker
                End If
                If cmbFormType.SelectedIndex > 0 Then
                    BrokerFltr &= " AND {PENDCFORM.FORM_Type}= " & Chr(34) & FormType & Chr(34)
                End If
                Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Reports\PendCForm.rpt"
                ReportParameters.rptFilter = "{PendCform.CoBr_Id} = '" & SelBranchId & "' And {PendCform.Bill_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {PendCform.Bill_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr & BrokerFltr
                '  ReportParameters.rptFilter = "{PendCform.CoBr_Id} = '" & SelBranchId & "' AND {PendCform.Bill_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr & BrokerFltr

            Case ReportType.TaxForm_DateWise
                FromToDt = GetFromToDateSeriesFilter("{PendCform.Bill_Dt}")
                PartyFltr = GetPartyFilter("PendCform")

                If cmbFormType.SelectedIndex > 0 Then
                    BrokerFltr &= " AND {PENDCFORM.FORM_Type}= " & Chr(34) & FormType & Chr(34)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Reports\CFormDatewise.rpt"
                ReportParameters.rptFilter = "{PendCform.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr & BrokerFltr

            Case ReportType.TaxForm_Recd
                FromToDt = GetFromToDateSeriesFilter("{View_CForm_Status.Doc_Dt}")
                PartyFltr = GetPartyFilter("View_CForm_Status")

                If cmbFormType.SelectedIndex > 0 Then
                    BrokerFltr &= " AND {View_CForm_Status.cform_flg}= " & Chr(34) & FormType & Chr(34)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\CFormRecd.rpt"
                ReportParameters.rptFilter = "{View_CForm_Status.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr & BrokerFltr

            Case ReportType.TaxSummary
                FromToDt = GetFromToDateSeriesFilter("{View_TaxSum_Terms.Doc_Dt}")

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\TaxSum.rpt"
                '''"ROhit 16082017
                'ReportParameters.rptFilter = "{View_TaxSum_Terms.CoBr_Id} = '" & SelBranchId & "'" & FromToDt
                ReportParameters.rptFilter = "{View_TaxSum_Terms.TaxClass}<>'GST' and {View_TaxSum_Terms.CoBr_Id} = '" & SelBranchId & "'" & FromToDt
            Case ReportType.TaxSummaryGST
                FromToDt = GetFromToDateSeriesFilter("{View_TaxSum_Terms.Doc_Dt}")

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\TaxSumGST.rpt"
                ReportParameters.rptFilter = "{View_TaxSum_Terms.TaxClass}='GST' and {View_TaxSum_Terms.CoBr_Id} = '" & SelBranchId & "'" & FromToDt
                '''"End ROhit 16082017
            Case ReportType.DiscountSummary
                FromToDt = GetFromToDateSeriesFilter("{View_TaxSum_Terms.Doc_Dt}")

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\TaxSumOthChgs.rpt"
                ReportParameters.rptFilter = "{View_TaxSum_Terms.CoBr_Id} = '" & SelBranchId & "' AND {View_TaxSum_Terms.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

            Case ReportType.Journal
                FromToDt = GetFromToDateSeriesFilter("{vw_DayBook.Doc_Dt}")
                PartyFltr = " And {vw_DayBook.Vchr_Type} = 'Journal'"

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("TotalFooter#N", 0)
                Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))
                Formulas.Add("ReportCaption#S", Me.Text)

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\DayBook.rpt"
                ReportParameters.rptFilter = "{vw_DayBook.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr

            Case ReportType.DebitNote
                FromToDt = GetFromToDateSeriesFilter("{vw_DayBook.Doc_Dt}")
                PartyFltr = " And {vw_DayBook.Vchr_Type} = 'Debit Note'"

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("TotalFooter#N", 0)
                Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))
                Formulas.Add("ReportCaption#S", Me.Text)

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\DayBook.rpt"
                ReportParameters.rptFilter = "{vw_DayBook.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr

            Case ReportType.CreditNote
                FromToDt = GetFromToDateSeriesFilter("{vw_DayBook.Doc_Dt}")
                PartyFltr = " And {vw_DayBook.Vchr_Type} = 'Credit Note'"

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("TotalFooter#N", 0)
                Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))
                Formulas.Add("ReportCaption#S", Me.Text)

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\DayBook.rpt"
                ReportParameters.rptFilter = "{vw_DayBook.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr

            Case ReportType.GroupSummary
                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")
                PartyFltr = GetPartyFilter("vw_GenLedger")

                If cmbSubGrp.Properties.Items.GetCheckedValues.Count > 1 Or cmbSubGrp.Properties.Items.GetCheckedValues.Count = 0 Then
                    Formulas.Add("MultiGroup#N", 1)
                Else
                    Formulas.Add("MultiGroup#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\GroupSummary.rpt"
                ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' AND {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr

            Case ReportType.GroupVoucher
                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")
                PartyFltr = GetPartyFilter("vw_GenLedger")

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))

                If cmbSubGrp.Properties.Items.GetCheckedValues.Count > 1 Or cmbSubGrp.Properties.Items.GetCheckedValues.Count = 0 Then
                    Formulas.Add("MultiGroup#N", 1)
                Else
                    Formulas.Add("MultiGroup#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\GroupVoucher.rpt"
                ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' AND {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & PartyFltr

            Case ReportType.Receivables
                Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
                Formulas.Add("ToDate#S", Format$(dtpTo.Value, "MM/dd/yyyy"))
                Formulas.Add("TDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                FromToDt = " And {vw_LedgerAccount.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

                If cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    PartyFltr = " And {AccLGrp.AccLGrp_Type} =4 "
                Else
                    PartyFltr = GetPartyFilter("vw_LedgerAccount")
                End If

                If chkShowCostCtr.Checked Then
                    Formulas.Add("ReportCaption#S", "Debitor Aging From ")
                    ReportParameters.rptCaption = Me.Text
                    ReportParameters.rptFile = ReportPath & "\Accounts\OsAging.rpt"
                    ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "' And {@BalAmt} <> 0 " & FromToDt & PartyFltr

                Else
                    If rdSummary.Checked Then
                        Formulas.Add("DispDtlRef#N", 0)
                    Else
                        Formulas.Add("DispDtlRef#N", 1)
                    End If
                    Formulas.Add("BillType#N", IIf(chkOverdue.Checked, 1, 0))

                    Dim ODFilter As String = ""
                    If chkOverdue.Checked Then
                        ODFilter = " And {@ODDays} > 0"
                    End If

                    If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForRamtex)) = 1 Then
                        ReDim subrpt(1)

                        subrpt(0).Report = "GeneralLedger"
                        subrpt(0).FormulaName = "ToDate"
                        subrpt(0).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                        subrpt(0).Filter = "{vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
                    End If

                    Formulas.Add("ReportCaption#S", "Bills Outstanding(Receivable)")
                    ReportParameters.rptCaption = Me.Text
                    ReportParameters.rptFile = ReportPath & "\Accounts\BillStatus.rpt"
                    ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "' And {@BalAmt} <> 0 " & FromToDt & ODFilter & PartyFltr
                End If

            Case ReportType.ReceivablesB
                Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
                Formulas.Add("ToDate#S", Format$(dtpTo.Value, "MM/dd/yyyy"))
                Formulas.Add("TDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                FromToDt = " And {vw_LedgerAccountB.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

                If cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    PartyFltr = " And {AccLGrp.AccLGrp_Type} =4 "
                Else
                    PartyFltr = GetPartyFilter("vw_LedgerAccountB")
                End If

                If chkShowCostCtr.Checked Then
                    Formulas.Add("ReportCaption#S", "Debitor Aging From ")
                    ReportParameters.rptCaption = Me.Text
                    ReportParameters.rptFile = ReportPath & "\Accounts\OsAgingB.rpt"
                    ReportParameters.rptFilter = "{vw_LedgerAccountB.CoBr_Id} = '" & SelBranchId & "' And {@BalAmt} > 0 " & FromToDt & PartyFltr

                Else
                    If rdSummary.Checked Then
                        Formulas.Add("DispDtlRef#N", 0)
                    Else
                        Formulas.Add("DispDtlRef#N", 1)
                    End If
                    Formulas.Add("BillType#N", IIf(chkOverdue.Checked, 1, 0))

                    Dim ODFilter As String = ""
                    If chkOverdue.Checked Then
                        ODFilter = " And {@ODDays} > 0"
                    End If

                    Formulas.Add("ReportCaption#S", "Bills Outstanding(Receivable)")
                    ReportParameters.rptCaption = Me.Text
                    ReportParameters.rptFile = ReportPath & "\Accounts\BillStatusB.rpt"
                    ReportParameters.rptFilter = "{vw_LedgerAccountB.CoBr_Id} = '" & SelBranchId & "' And {@BalAmt} <> 0 " & FromToDt & ODFilter & PartyFltr
                End If

            Case ReportType.Payables
                Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
                Formulas.Add("ToDate#S", Format$(dtpTo.Value, "MM/dd/yyyy"))
                Formulas.Add("TDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                FromToDt = " And {vw_LedgerAccount.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

                If cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    PartyFltr = " And {AccLGrp.AccLGrp_Type} =3"
                Else
                    PartyFltr = GetPartyFilter("vw_LedgerAccount")
                End If
                '''''''''''''''''''''''''''''''''
                ReDim subrpt(1)

                subrpt(0).Report = "OnAccountDtl.rpt"
                'subrpt(0).FormulaName = "ToDate"
                'subrpt(0).FormulaValue = "{vw_LedgerAccount.Doc_Dt}"

                subrpt(0).Filter = " {vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "'"

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                If chkShowCostCtr.Checked Then
                    Formulas.Add("ReportCaption#S", "Creditor Aging From ")
                    ReportParameters.rptCaption = Me.Text
                    ReportParameters.rptFile = ReportPath & "\Accounts\OsAging.rpt"
                    'ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "' " & FromToDt & PartyFltr
                    ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "' And {@BalAmt} < 0 " & FromToDt & PartyFltr
                Else
                    If rdSummary.Checked Then
                        Formulas.Add("DispDtlRef#N", 0)
                    Else
                        Formulas.Add("DispDtlRef#N", 1)
                    End If
                    Formulas.Add("BillType#N", IIf(chkOverdue.Checked, 1, 0))

                    Formulas.Add("ReportCaption#S", "Bills Outstanding(Payable)")
                    Dim ODFilter As String = ""
                    If chkOverdue.Checked Then
                        ODFilter = " And {@ODDays} > 0"
                    End If

                    Formulas.Add("GroupWise#N", 0)
                    ReportParameters.rptCaption = Me.Text
                    ReportParameters.rptFile = ReportPath & "\Accounts\BillStatus.rpt"
                    ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "' And {@BalAmt} <> 0 " & FromToDt & ODFilter & PartyFltr
                End If


            Case ReportType.LedgerOs
                Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
                Formulas.Add("ToDate#S", Format$(dtpTo.Value, "MM/dd/yyyy"))
                'Formulas.Add("TDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                FromToDt = " And {vw_LedgerAccount.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
                PartyFltr = GetPartyFilter("vw_LedgerAccount")

                If PartyFltr.Trim.Length = 0 Then
                    PartyFltr = " And {AccLGrp.AccLGrp_Type} In [3, 4]"
                End If

                If rdSummary.Checked Then
                    Formulas.Add("DispDtlRef#N", 0)
                Else
                    Formulas.Add("DispDtlRef#N", 1)
                End If
                Formulas.Add("BillType#N", IIf(chkOverdue.Checked, 1, 0))

                Dim ODFilter As String = ""
                If chkOverdue.Checked Then
                    ODFilter = " And {@ODDays} > 0"
                End If

                If cmbLedger.Properties.Items.GetCheckedValues.Count > 1 Or cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    Formulas.Add("MultiLedger#N", 1)
                Else
                    Formulas.Add("MultiLedger#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\LedgerOsBill.rpt"
                ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "' And {@BalAmt} <> 0 " & FromToDt & ODFilter & PartyFltr


            Case ReportType.GroupOs
                Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
                Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                FromToDt = " And {vw_LedgerAccount.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
                PartyFltr = GetPartyFilter("vw_LedgerAccount")

                If PartyFltr.Trim.Length = 0 Then
                    PartyFltr = " And {AccLGrp.AccLGrp_Type} In [3, 4]"
                End If

                'If rdSummary.Checked Then
                '    Formulas.Add("DispDtlRef#N", 0)
                'Else
                '    Formulas.Add("DispDtlRef#N", 1)
                'End If

                If cmbSubGrp.Properties.Items.GetCheckedValues.Count > 1 Or cmbSubGrp.Properties.Items.GetCheckedValues.Count = 0 Then
                    Formulas.Add("MultiLedger#N", 1)
                Else
                    Formulas.Add("MultiLedger#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\GroupOs.rpt"
                ReportParameters.rptFilter = "{vw_LedgerAccount.CoBr_Id} = '" & SelBranchId & "' And {@BalAmt} <> 0 " & FromToDt & PartyFltr

            Case ReportType.TrialBalance
                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")



                If chkShowBill.Checked Then
                    Formulas.Add("DispLedger#N", 1)
                    Formulas.Add("DispDtl#N", 1)
                Else
                    If rdSummary.Checked Then
                        Formulas.Add("DispDtl#N", 0)
                    Else
                        Formulas.Add("DispDtl#N", 1)
                    End If
                    Formulas.Add("DispLedger#N", 0)
                End If
                If chkOverdue.Checked Then
                    Formulas.Add("DueOnly#N", 1)
                Else
                    Formulas.Add("DueOnly#N", 0)
                End If

                ReDim subrpt(1)

                subrpt(0).Report = "OpStock"
                subrpt(0).FormulaName = "StDate"
                subrpt(0).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")

                subrpt(0).Filter = "{Clstk.CoBr_Id} = '" & SelBranchId & "'"

                FromToDt = " And {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

                ReportParameters.rptCaption = Me.Text

                ''CHANGE BY RAHUL ON 17/04/2019
                If Val(GetSettingAsPerId(ApplnSettingsIdx.DisplayOutlet)) = 1 Then
                    SelBroker = GetSelectedAttributes(cmbBroker, "vw_GenLedger.Outlet_Key", False)
                    If SelBroker.Trim.Length > 0 Then
                        BrokerFltr &= " And " & SelBroker
                    End If

                    If SelBroker.Trim.Length > 0 Then
                        ReportParameters.rptFile = ReportPath & "\Accounts\TrialBalanceOutlet.rpt"
                        ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & BrokerFltr
                    Else
                        ReportParameters.rptFile = ReportPath & "\Accounts\TrialBalance.rpt"
                        ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & FromToDt
                    End If
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\TrialBalance.rpt"
                    ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & FromToDt

                End If
                ''END

                ''ReportParameters.rptFile = ReportPath & "\Accounts\TrialBalance.rpt"
                ''ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & FromToDt

            Case ReportType.GroupTrialBalance
                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")
                PartyFltr = GetPartyFilter("vw_GenLedger")

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If

                If chkShowBill.Checked Then
                    Formulas.Add("DispLedger#N", 1)
                Else
                    Formulas.Add("DispLedger#N", 0)
                End If

                If chkOverdue.Checked Then
                    Formulas.Add("DueOnly#N", 1)
                Else
                    Formulas.Add("DueOnly#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\TrialBalance.rpt"
                ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr

            Case ReportType.ProfitNLossAc
                'FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")

                'ReDim subrpt(2)

                'subrpt(0).Report = "OpeningStock"
                'subrpt(0).FormulaName = "StDate"
                'subrpt(0).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")

                'subrpt(1).Report = "ClosingStock"
                'subrpt(1).FormulaName = "ToDate"
                'subrpt(1).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")

                ''subrpt(2).Report = "Sources"
                ''subrpt(2).FormulaName = "DisplayDtl"
                ''subrpt(2).FormulaValue = 1

                ''subrpt(2).Report = "Sources"
                ''subrpt(2).Filter = "{vw_GenLedger.Doc_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

                ''subrpt(2).Report = "Sources"
                ''subrpt(2).FormulaName = "StDate"
                ''subrpt(2).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")

                ''subrpt(3).Report = "Sources"
                ''subrpt(3).FormulaName = "ToDate"
                ''subrpt(3).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")

                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")

                '                ReDim subrpt(9)
                ReDim subrpt(7)

                subrpt(0).Report = "Sources"
                subrpt(0).FormulaName = "StDate"
                subrpt(0).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(0).FormulaName = "ToDate"
                subrpt(0).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                subrpt(0).Filter = "{ACCGRP.AccGrp_Name} = 'Sales Account' And  {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt

                subrpt(1).Report = "OpeningStock"
                subrpt(1).FormulaName = "StDate"
                subrpt(1).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(1).Filter = "{CLSTK.CoBr_Id} = '" & SelBranchId & "'"

                subrpt(2).Report = "ClosingStock"
                subrpt(2).FormulaName = "ToDate"
                subrpt(2).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                subrpt(2).Filter = "{CLSTK.CoBr_Id} = '" & SelBranchId & "'"

                subrpt(3).Report = "PurchaseAmt"
                subrpt(3).FormulaName = "StDate"
                subrpt(3).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(3).FormulaName = "ToDate"
                subrpt(3).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")

                If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForRamtex)) = 0 Then
                    subrpt(3).Filter = "{AccGrp.AccGrp_Name} = 'Purchase Account' " & FromToDt
                Else
                    subrpt(3).Filter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' And {AccGrp.AccGrp_Name} in ['Purchase Account',  'Direct Expenses'] " & FromToDt
                End If



                subrpt(4).Report = "DirectExpenses"
                subrpt(4).Filter = "{AccGrp.AccGrp_Name} = 'Direct Expenses' And {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt

                subrpt(5).Report = "IndirectIncome"
                subrpt(5).Filter = "{AccGrp.AccGrp_Name} = 'Indirect Income' and {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt

                subrpt(6).Report = "IndirectExpenses"
                subrpt(6).Filter = "{AccGrp.AccGrp_Name} = 'Indirect Expenses' and {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt
                ReportParameters.rptCaption = Me.Text

                'subrpt(7).Report = "RawMaterialStock"
                'subrpt(7).FormulaName = "ToDate"
                'subrpt(7).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")


                'subrpt(8).Report = "SemiFinishStock"
                'subrpt(8).FormulaName = "ToDate"
                'subrpt(8).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")


                If chkShowBill.Checked Then
                    If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForRamtex)) = 1 Then
                        If chkOverdue.Checked = True Then
                            ReportParameters.rptFile = ReportPath & "\Accounts\PLAccountDtl.rpt"
                        Else
                            ReportParameters.rptFile = ReportPath & "\Accounts\PLAccountDtlH.rpt"
                        End If
                    Else
                        ReportParameters.rptFile = ReportPath & "\Accounts\PLAccountDtl.rpt"
                    End If

                Else
                    If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForRamtex)) = 1 Then
                        If chkOverdue.Checked = True Then
                            ReportParameters.rptFile = ReportPath & "\Accounts\PLAccount.rpt"
                        Else
                            ReportParameters.rptFile = ReportPath & "\Accounts\PLAccountH.rpt"
                        End If
                    Else
                        ReportParameters.rptFile = ReportPath & "\Accounts\PLAccount.rpt"
                    End If


                End If
                ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & FromToDt

            Case ReportType.ProfitNLossAcScreen

                Dim frmDispForm As Form = New frmProfitLossAc(Format$(dtpFrom.Value, "dd/MM/yyyy"), Format$(dtpTo.Value, "dd/MM/yyyy"), True)
                DisplayForm(frmDispForm, "NDPROFITANDLOSSSCREEN", True)
            Case ReportType.PTR

                Dim frmDispForm As Form = New frmPTR(Format$(dtpFrom.Value, "dd/MM/yyyy"), Format$(dtpTo.Value, "dd/MM/yyyy"), True)
                DisplayForm(frmDispForm, "NDPTR", True)

            Case ReportType.BalanceSheetScreen
                If dtpTo.Value > AccToDt Then
                    MsgBox("Date Should be between Financial Year..", MsgBoxStyle.OkOnly, AcceptButton)
                    dtpTo.Focus()
                    Exit Sub
                End If
                Dim frmDispForm As Form = New frmBalanceSheet(Format$(dtpFrom.Value, "dd/MM/yyyy"), Format$(dtpTo.Value, "dd/MM/yyyy"), True)
                DisplayForm(frmDispForm, "NDBALANCESHEETSCREEN", True)

            Case ReportType.BalanceSheet
                If dtpTo.Value > AccToDt Then
                    MsgBox("Date Should be between Financial Year..", MsgBoxStyle.OkOnly, AcceptButton)
                    dtpTo.Focus()
                    Exit Sub
                End If

                FromToDt = " And {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
                'ReDim subrpt(11)
                ReDim subrpt(9)

                subrpt(0).Report = "Sources"
                subrpt(0).FormulaName = "StDate"
                subrpt(0).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(0).FormulaName = "ToDate"
                subrpt(0).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                subrpt(0).Filter = "{ACCMGRP.AccMGrp_Name} = 'Liabilities' And {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & FromToDt


                subrpt(1).Report = "Application"
                subrpt(1).FormulaName = "StDate"
                subrpt(1).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(1).FormulaName = "ToDate"
                subrpt(1).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                subrpt(1).Filter = "{AccMGrp.AccMGrp_Name} = 'Assets' And {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt
                ''cobr filter

                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}")

                subrpt(2).Report = "Sales"
                subrpt(2).FormulaName = "StDate"
                subrpt(2).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(2).FormulaName = "ToDate"
                subrpt(2).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                subrpt(2).Filter = "{ACCGRP.AccGrp_Name} = 'Sales Account' And {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt
                ''cobr filter

                subrpt(3).Report = "OpStock"
                subrpt(3).FormulaName = "StDate"
                subrpt(3).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(3).Filter = "{CLSTK.CoBr_Id} = '" & SelBranchId & "'"

                subrpt(4).Report = "ClStock"
                subrpt(4).FormulaName = "ToDate"
                subrpt(4).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                subrpt(4).Filter = "{CLSTK.CoBr_Id} = '" & SelBranchId & "'"

                subrpt(5).Report = "Purchase"
                'subrpt(5).FormulaName = "StDate"
                'subrpt(5).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                'subrpt(5).FormulaName = "ToDate"
                'subrpt(5).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                subrpt(5).Filter = "{AccGrp.AccGrp_Name} = 'Purchase Account' And {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt
                ''cobr filter
                subrpt(6).Report = "DirectExps"
                subrpt(6).Filter = "{AccGrp.AccGrp_Name} = 'Direct Expenses' And {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt
                ''cobr filter
                subrpt(7).Report = "IndirectIncome"
                subrpt(7).Filter = "{AccGrp.AccGrp_Name} = 'Indirect Income' And {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt
                ''cobr filter
                subrpt(8).Report = "IndirectExps"
                subrpt(8).Filter = "{AccGrp.AccGrp_Name} = 'Indirect Expenses' And {vw_GenLedger.CoBr_Id} = '" & SelBranchId & "' " & FromToDt
                ''cobr filter

                'subrpt(10).Report = "SemiFinishStock"
                'subrpt(10).FormulaName = "ToDate"
                'subrpt(10).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")

                FromToDt = " And {vw_GenLedger.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"


                ReportParameters.rptCaption = Me.Text
                '    If chkShowBill.Checked Then
                '        ReportParameters.rptFile = ReportPath & "\Accounts\BalanceSheetDtl.rpt"
                '    Else
                '        ReportParameters.rptFile = ReportPath & "\Accounts\BalanceSheet.rpt"
                'End If


                If chkShowBill.Checked Then
                    If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForRamtex)) = 1 Then
                        If chkOverdue.Checked = True Then
                            ReportParameters.rptFile = ReportPath & "\Accounts\BalanceSheetDtl.rpt"
                        Else
                            ReportParameters.rptFile = ReportPath & "\Accounts\BalanceSheetDtlH.rpt"
                        End If
                    Else
                        ReportParameters.rptFile = ReportPath & "\Accounts\BalanceSheetDtl.rpt"
                    End If

                Else
                    If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForRamtex)) = 1 Then
                        If chkOverdue.Checked = True Then
                            ReportParameters.rptFile = ReportPath & "\Accounts\BalanceSheet.rpt"
                        Else
                            ReportParameters.rptFile = ReportPath & "\Accounts\BalanceSheetH.rpt"
                        End If
                    Else
                        ReportParameters.rptFile = ReportPath & "\Accounts\BalanceSheet.rpt"
                    End If


                End If

                ReportParameters.rptFilter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & FromToDt
                Formulas.Add("BSDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

            Case ReportType.PurchaseReg
                FromToDt = GetFromToDateSeriesFilter("{vw_DayBook.Doc_Dt}")

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("TotalFooter#N", 1)
                Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))
                Formulas.Add("ReportCaption#S", Me.Text)

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\DayBook.rpt"
                ReportParameters.rptFilter = "{vw_DayBook.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & " And {vw_DayBook.Vchr_Type} = 'Purchase'"

            Case ReportType.SalesReg
                FromToDt = GetFromToDateSeriesFilter("{vw_DayBook.Doc_Dt}")

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                Formulas.Add("TotalFooter#N", 1)
                Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))
                Formulas.Add("ReportCaption#S", Me.Text)

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\DayBook.rpt"
                ReportParameters.rptFilter = "{vw_DayBook.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & " And {vw_DayBook.Vchr_Type} = 'Sales'"

            Case ReportType.DailyCollection
                Formulas.Add("FromDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
                'Formulas.Add("ToDate#S", Format$(dtpTo.Value, "MM/dd/yyyy"))
                Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                'FromToDt = " And {vw_LedgerAccount.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

                If cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    PartyFltr = " And {Ledger.Led_Cat} = 'B' "
                Else
                    PartyFltr = GetPartyFilter("Ledger")
                End If

                If rdSummary.Checked Then
                    Formulas.Add("DispDtlRef#N", 0)
                Else
                    Formulas.Add("DispDtlRef#N", 1)
                End If
                'Formulas.Add("BillType#N", IIf(chkOverdue.Checked, 1, 0))

                Formulas.Add("ReportCaption#S", "Daily Collection")
                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\DailyCollection.rpt"
                ReportParameters.rptFilter = "{Vchr.CoBr_Id} = '" & SelBranchId & "' And {vchrDtlRef.Doc_Amt} > 0 " & FromToDt & PartyFltr

            Case ReportType.RG1Register
                FromToDt = GetFromToDateSeriesFilter("{View_RG1.Doc_Dt}")

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\RG1.rpt"
                ReportParameters.rptFilter = "{View_RG1.CoBr_Id} = '" & SelBranchId & "' AND {View_RG1.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

            Case ReportType.CustConfirmation
                Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
                Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                FromToDt = GetFromToDateSeriesFilter("{vw_GenLedger.Doc_Dt}", False)
                ReDim subrpt(4)

                PartyFltr = GetPartyFilter("Ledger")
                subrpt(0).Report = "DrOpening"
                subrpt(0).FormulaName = "StDate"
                subrpt(0).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(0).Filter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & PartyFltr

                PartyFltr = GetPartyFilter("Ledger")
                subrpt(1).Report = "CrOpening"
                subrpt(1).FormulaName = "StDate"
                subrpt(1).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(1).Filter = "{vw_GenLedger.CoBr_Id} = '" & SelBranchId & "'" & PartyFltr

                PartyFltr = GetPartyFilter("Ledger")
                FromToDt = GetFromToDateSeriesFilter("{View_ByrAccLed_Debits.Doc_Dt}", False)
                subrpt(2).Report = "DrDetails"
                subrpt(2).FormulaName = "StDate"
                subrpt(2).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(2).FormulaName = "ToDate"
                subrpt(2).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                subrpt(2).Filter = "{View_ByrAccLed_Debits.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr

                PartyFltr = GetPartyFilter("Ledger")
                FromToDt = GetFromToDateSeriesFilter("{View_ByrAccLed_Credit.Doc_Dt}", False)
                subrpt(3).Report = "CrDetails"
                subrpt(3).FormulaName = "StDate"
                subrpt(3).FormulaValue = Format$(dtpFrom.Value, "dd/MM/yyyy")
                subrpt(3).FormulaName = "ToDate"
                subrpt(3).FormulaValue = Format$(dtpTo.Value, "dd/MM/yyyy")
                subrpt(3).Filter = "{View_ByrAccLed_Credit.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr

                PartyFltr = GetPartyFilter("PARTY")
                ReportParameters.rptCaption = Me.Text
                If rdSummary.Checked Then
                    ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccountConfSum.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\ByrAccountConf.rpt"
                End If
                ReportParameters.rptFilter = "{PARTY.CoBr_Id} = '" & SelBranchId & "'" & PartyFltr
            Case ReportType.PendingOrderReport
                FromToDt = GetFromToDateSeriesFilter("{SalesOrder.Doc_Dt}")
                'PartyFltr = GetPartyFilter("vw_GenLedger")

                If rdSummary.Checked Then
                    Formulas.Add("DispDtl#N", 0)
                Else
                    Formulas.Add("DispDtl#N", 1)
                End If
                'Formulas.Add("DispDtlRef#N", IIf(chkShowBill.Checked, 1, 0))
                'Formulas.Add("DispRemark#N", IIf(chkShowNarration.Checked, 1, 0))

                If cmbLedger.Properties.Items.GetCheckedValues.Count > 1 Or cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    Formulas.Add("MultiLedger#N", 1)
                Else
                    Formulas.Add("MultiLedger#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Report\PendingOrderReport.rpt"
                ReportParameters.rptFilter = "{SalesOrder.CoBr_Id} = '" & SelBranchId & "'" & FromToDt

            Case ReportType.BrokerCommRcptBill
                Dim FromRctDt As String = ""

                If GetSettingAsPerId(ApplnSettingsIdx.BrokerCommRepDateFilterOn) = "R" Then
                    FromToDt = GetFromToDateSeriesFilter("{View_CommOnBillWise.Rcpt_Dt}")
                Else
                    FromToDt = GetFromToDateSeriesFilter("{View_CommOnBillWise.Bill_Dt}")
                    'FromRctDt = " And {View_CommOnBillWise.Rcpt_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And {View_CommOnBillWise.Rcpt_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
                End If


                PartyFltr = GetPartyFilter("View_CommOnBillWise")

                SelBroker = GetSelectedAttributes(cmbBroker, "Broker.Led_Key", False)
                If SelBroker.Trim.Length > 0 Then
                    BrokerFltr &= " And " & SelBroker
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\BrokerCommOnBillWise.rpt"
                ReportParameters.rptFilter = "{View_CommOnBillWise.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & FromRctDt & PartyFltr & BrokerFltr

            Case ReportType.PartyCommBill
                FromToDt = GetFromToDateSeriesFilter("{SaleBill.Doc_Dt}")
                PartyFltr = GetPartyFilter("SaleBill")

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\PartyCommOnBillWise.rpt"
                ReportParameters.rptFilter = "{SaleBill.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr

            Case ReportType.PartySalesAnalysisQty
                FromToDt = GetFromToDateSeriesFilter("{View_SalesAnlysis.Bill_Dt}")
                PartyFltr = GetPartyFilter("View_SalesAnlysis")

                SelBroker = GetSelectedAttributes(cmbBroker, "Broker.Led_Key", False)
                If SelBroker.Trim.Length > 0 Then
                    BrokerFltr &= " And " & SelBroker
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\SalesAnalysisQty.rpt"
                ReportParameters.rptFilter = "{View_SalesAnlysis.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr & BrokerFltr

                ''ankita 12122018

            Case ReportType.CustomerOutstanding
                'Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
                'Formulas.Add("ToDate#S", Format$(dtpTo.Value, "MM/dd/yyyy"))
                'Formulas.Add("TDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

                FromToDt = GetFromToDateSeriesFilter("{SalesOutstanding.Doc_Dt}")
                PartyFltr = GetPartyFilter("SalesOutstanding")

                If PartyFltr.Trim.Length = 0 Then
                    PartyFltr = " And {AccLGrp.AccLGrp_Type} In [3, 4]"
                End If

                If rdSummary.Checked Then
                    Formulas.Add("DispDtlRef#N", 0)
                Else
                    Formulas.Add("DispDtlRef#N", 1)
                End If
                Formulas.Add("BillType#N", IIf(chkOverdue.Checked, 1, 0))

                Dim ODFilter As String = ""
                If chkOverdue.Checked Then
                    ODFilter = " And {@ODDays} > 0"
                End If

                If cmbLedger.Properties.Items.GetCheckedValues.Count > 1 Or cmbLedger.Properties.Items.GetCheckedValues.Count = 0 Then
                    Formulas.Add("MultiLedger#N", 1)
                Else
                    Formulas.Add("MultiLedger#N", 0)
                End If

                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\SalesOutstanding.rpt"
                ReportParameters.rptFilter = "{SalesOutstanding.Bal_Amt} > 0 and {SalesOutstanding.CoBr_Id} = '" & SelBranchId & "' " & FromToDt & ODFilter & PartyFltr


            Case ReportType.BrokerOutstanding

                FromToDt = GetFromToDateSeriesFilter("{SalesOutstanding.Doc_Dt}")
                PartyFltr = GetPartyFilter("SalesOutstanding")
                SelBroker = GetSelectedAttributes(cmbBroker, "Broker.Led_Key", False)
                'SelBroker = GetSelectedAttributes(cmbBroker, "Broker.CoBr_Id", False)
                If SelBroker.Trim.Length > 0 Then
                    BrokerFltr &= " And " & SelBroker
                End If

                '__________ADDED BY PRITI_________27/02/2020__
                SelLedger = GetSelectedAttributes(cmbLedger, "Ledger.Led_Key", False)
                If SelLedger.Trim.Length > 0 Then
                    LedgerFltr &= " And " & SelLedger
                End If

                SelStation = GetSelectedAttributes(cmbCity, "Station.Stn_Key", False)
                If SelStation.Trim.Length > 0 Then
                    StationFltr &= " And " & SelStation
                End If



                ReportParameters.rptCaption = Me.Text
                ReportParameters.rptFile = ReportPath & "\Accounts\SalesOutstanding.rpt"
                ReportParameters.rptFilter = "{SalesOutstanding.CoBr_Id} = '" & SelBranchId & "'" & FromToDt & PartyFltr & BrokerFltr & LedgerFltr & SelStation

                ''end 12122018

        End Select

        If rptType <> ReportType.ProfitNLossAcScreen And rptType <> ReportType.BalanceSheetScreen And rptType <> ReportType.PTR Then
            Dim frmRpt As New frmViewReports(Formulas)
            frmRpt.Show()

            Formulas = Nothing
          
        End If

    End Sub

    Private Sub DisplayForm(ByVal frmForm As Object, ByVal frmText As String, Optional ByVal DisplayModal As Boolean = False)
        If DisplayModal Then
            frmForm.Tag = frmText
            frmForm.Show()
        Else
            If Not Common.FormIsLoaded(Me, frmText) Then
                frmForm.MdiParent = Me
                frmForm.Tag = frmText
                frmForm.Show()
            End If
        End If
    End Sub

    Private Sub cmbFormType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbFormType.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnView.Focus()
        End If
    End Sub
End Class