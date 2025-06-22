Imports System.Data.SqlClient

Public Class frmrptCashBook

    Enum enmRptType
        Sales_Book
        Sales_WithTINNo
        Sales_PartyWithTINNo
        Sales_BrokerWise
        CNRegister
        CNRegisterGST   '--Abhi 22/12/2017---
        CNRegister_BrokerWise
        Purchase_Book
        BrokerCommission
        Sales_BookGST
        Purchase_BookGST
        BrokerCommissionReport ''ankita 20052019
        BrokerCollection
    End Enum

    Dim bytRptType As enmRptType
    Dim blnLoading As Boolean
    Dim Checked As Boolean

    Private Sub frmrptCashBook_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFrom.Value = AccFromDt
        dtpTo.Value = AccToDt
        blnLoading = False

        If bytRptType = enmRptType.Sales_Book Then
            Me.Text = "Sales Register"
            DisplayState() : cmbStateFrom.Visible = True : lblState.Visible = True
            'cmbTax.Visible = True
            pnlState.Visible = True : chkTax.Visible = True : pnlBroker.Visible = False : pnlParty.Visible = False

            Query = "Select TXTMTDS_ID, TXTMTDS_NAME From TaxTermsTDS " _
                & " Where Status = '1' " & BranchLedFixFilter _
                & " Order By TXTMTDS_NAME"
            Dim dtTax As DataTable = Common.GetDataTableWithAll(Query)

            With cmbTax
                .DataSource = dtTax
                .DisplayMember = "TXTMTDS_NAME"
                .ValueMember = "TXTMTDS_ID"
            End With

        ElseIf bytRptType = enmRptType.Sales_BookGST Then
            Me.Text = "Sales Register(GST)"
            DisplayState() : cmbStateFrom.Visible = False : lblState.Visible = False
            cmbTax.Visible = False
            pnlState.Visible = False : chkTax.Visible = False : pnlBroker.Visible = False : pnlParty.Visible = False

            Query = "Select TXTMTDS_ID, TXTMTDS_NAME From TaxTermsTDS " _
                & " Where Status = '1' And TaxClass='GST'" & BranchLedFixFilter _
                & " Order By TXTMTDS_NAME"
            Dim dtTax As DataTable = Common.GetDataTableWithAll(Query)

            With cmbTax
                .DataSource = dtTax
                .DisplayMember = "TXTMTDS_NAME"
                .ValueMember = "TXTMTDS_ID"
            End With

        ElseIf bytRptType = enmRptType.Sales_WithTINNo Then
            Me.Text = "Sales Register (With TIN No)"
            DisplayState() : cmbStateFrom.Visible = True : lblState.Visible = True
            'cmbTax.Visible = True
            pnlState.Visible = True : chkTax.Visible = True
            pnlBroker.Visible = False : pnlParty.Visible = False

            Query = "Select TXTMTDS_ID, TXTMTDS_NAME From TaxTermsTDS " _
                & " Where Status = '1' " & BranchLedFixFilter _
                & " Order By TXTMTDS_NAME"
            Dim dtTax As DataTable = Common.GetDataTableWithAll(Query)

            With cmbTax
                .DataSource = dtTax
                .DisplayMember = "TXTMTDS_NAME"
                .ValueMember = "TXTMTDS_ID"
            End With

        ElseIf bytRptType = enmRptType.Sales_PartyWithTINNo Then
            Me.Text = "Sales Register (Party With TIN No)"
            DisplayState() : cmbStateFrom.Visible = True : lblState.Visible = True
            pnlBroker.Visible = True : pnlState.Visible = True : chkTax.Visible = True : pnlParty.Visible = False
            lblBroker.Text = "Party From"

            blnLoading = True
            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' and Led_Cat in ('R','W','D') AND LED_NAME <> '' " & BranchLedFixFilter _
                & " ORDER BY LED_NAME"
            Dim dtBrokerFrom As DataTable = Common.GetDataTableWithAll(Query)

            With cmbBrokerFrom
                .DataSource = dtBrokerFrom
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With

            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' AND Led_Cat in ('R','W','D') AND LED_NAME <> '' " & BranchLedFixFilter _
                & " ORDER BY LED_NAME"
            Dim dtBrokerTo As DataTable = Common.GetDataTableWithAll(Query)

            With cmbBrokerTo
                .DataSource = dtBrokerTo
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With
            blnLoading = False
            Call cmbBrokerFrom_SelectedValueChanged(Nothing, Nothing)

            Query = "Select TXTMTDS_ID, TXTMTDS_NAME From TaxTermsTDS " _
                & " Where Status = '1' " & BranchLedFixFilter _
                & " Order By TXTMTDS_NAME"
            Dim dtTax As DataTable = Common.GetDataTableWithAll(Query)

            With cmbTax
                .DataSource = dtTax
                .DisplayMember = "TXTMTDS_NAME"
                .ValueMember = "TXTMTDS_ID"
            End With

        ElseIf bytRptType = enmRptType.Sales_BrokerWise Then
            Me.Text = "Sales Register (Broker Wise)"
            DisplayState() : cmbStateFrom.Visible = True : lblState.Visible = True
            cmbTax.Visible = False : chkTax.Visible = False
            pnlState.Visible = True : pnlBroker.Visible = True
            pnlParty.Visible = False
            'Query = "Select TXTMTDS_ID, TXTMTDS_NAME From TaxTermsTDS " _
            '    & " Where Status = '1' " _
            '    & " Order By TXTMTDS_NAME"
            'Dim dtTax As DataTable = Common.GetDataTableWithAll(Query)

            'With cmbTax
            '    .DataSource = dtTax
            '    .DisplayMember = "TXTMTDS_NAME"
            '    .ValueMember = "TXTMTDS_ID"
            'End With
            blnLoading = True
            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' and LED_CAT ='B' AND LED_NAME <> '' " & BranchLedFixFilter _
                & " ORDER BY LED_NAME"
            Dim dtBrokerFrom As DataTable = Common.GetDataTableWithAll(Query)

            With cmbBrokerFrom
                .DataSource = dtBrokerFrom
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With

            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' AND LED_CAT IN ('B') AND LED_NAME <> '' " & BranchLedFixFilter _
                & " ORDER BY LED_NAME"
            Dim dtBrokerTo As DataTable = Common.GetDataTableWithAll(Query)

            With cmbBrokerTo
                .DataSource = dtBrokerTo
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With
            blnLoading = False
            Call cmbBrokerFrom_SelectedValueChanged(Nothing, Nothing)

        ElseIf bytRptType = enmRptType.CNRegister Then
            Me.Text = "Credit Note Register"
            Call DisplayState() : cmbStateFrom.Visible = True : lblState.Visible = True
            pnlState.Visible = True ': pnlPartyType.Visible = True ': pnlCNType.Visible = True
            chkTax.Visible = True

            Query = "Select TXTMTDS_ID, TXTMTDS_NAME From TaxTermsTDS " _
                & " Where Status = '1' " & BranchLedFixFilter _
                & " Order By TXTMTDS_NAME"
            Dim dtTax As DataTable = Common.GetDataTableWithAll(Query)

            With cmbTax
                .DataSource = dtTax
                .DisplayMember = "TXTMTDS_NAME"
                .ValueMember = "TXTMTDS_ID"
            End With

            '--Abhi 22/12/2017---
        ElseIf bytRptType = enmRptType.CNRegisterGST Then
            Me.Text = "Credit Note Register GST"
            Call DisplayState() : cmbStateFrom.Visible = False : lblState.Visible = False
            pnlState.Visible = False : pnlParty.Visible = False ': pnlCNType.Visible = True
            chkTax.Visible = False

            Query = "Select TXTMTDS_ID, TXTMTDS_NAME From TaxTermsTDS " _
                & " Where Status = '1' " & BranchLedFixFilter _
                & " Order By TXTMTDS_NAME"
            Dim dtTax As DataTable = Common.GetDataTableWithAll(Query)

            With cmbTax
                .DataSource = dtTax
                .DisplayMember = "TXTMTDS_NAME"
                .ValueMember = "TXTMTDS_ID"
            End With
            '--Abhi 22/12/2017---

        ElseIf bytRptType = enmRptType.CNRegister_BrokerWise Then
            Me.Text = "Credit Note Register (Broker Wise)"
            Call DisplayState() : cmbStateFrom.Visible = True : lblState.Visible = True
            pnlState.Visible = True ': pnlPartyType.Visible = True ': pnlCNType.Visible = True : chkTax.Visible = True : 
            pnlBroker.Visible = True

            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' and LED_CAT ='B' AND LED_NAME <> '' " & BranchLedFixFilter _
                & " ORDER BY LED_NAME"
            Dim dtBrokerFrom As DataTable = Common.GetDataTableWithAll(Query)
            blnLoading = True
            With cmbBrokerFrom
                .DataSource = dtBrokerFrom
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With

            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' AND LED_CAT IN ('B') AND LED_NAME <> '' " & BranchLedFixFilter _
                & " ORDER BY LED_NAME"
            Dim dtBrokerTo As DataTable = Common.GetDataTableWithAll(Query)

            With cmbBrokerTo
                .DataSource = dtBrokerTo
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With

            blnLoading = False
            Call cmbBrokerFrom_SelectedValueChanged(Nothing, Nothing)

        ElseIf bytRptType = enmRptType.Purchase_Book Then
            Me.Text = "Purchase Register"
            DisplayState() : cmbStateFrom.Visible = True : lblState.Visible = True
            'cmbTax.Visible = True
            pnlState.Visible = True : chkTax.Visible = True

            Query = " Select LED_KEY, LED_NAME " _
            & " From Ledger Where Led_Cat = 'L' And Status = '1' " _
            & BranchLedFixFilter _
            & " Order By Led_Name"
            Dim dtTable As DataTable = Common.GetDataTableWithAll(Query)

            With cmbPurchGroup
                .DataSource = dtTable
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With
            lblPurchGroup.Visible = True : cmbPurchGroup.Visible = True

            Query = "Select TXTMTDS_ID, TXTMTDS_NAME From TaxTermsTDS " _
                & " Where Status = '1' " & BranchLedFixFilter _
                & " Order By TXTMTDS_NAME"
            Dim dtTax As DataTable = Common.GetDataTableWithAll(Query)

            With cmbTax
                .DataSource = dtTax
                .DisplayMember = "TXTMTDS_NAME"
                .ValueMember = "TXTMTDS_ID"
            End With
        ElseIf bytRptType = enmRptType.Purchase_BookGST Then
            Me.Text = "Purchase Register GST "
            DisplayState() : cmbStateFrom.Visible = False : lblState.Visible = False
            cmbTax.Visible = False
            pnlState.Visible = False : chkTax.Visible = False

            Query = " Select LED_KEY, LED_NAME " _
            & " From Ledger Where Led_Cat = 'L' And Status = '1' " _
            & BranchLedFixFilter _
            & " Order By Led_Name"
            Dim dtTable As DataTable = Common.GetDataTableWithAll(Query)

            With cmbPurchGroup
                .DataSource = dtTable
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With
            lblPurchGroup.Visible = False : cmbPurchGroup.Visible = False

            Query = "Select TXTMTDS_ID, TXTMTDS_NAME From TaxTermsTDS " _
                & " Where Status = '1' " & BranchLedFixFilter _
                & " Order By TXTMTDS_NAME"
            Dim dtTax As DataTable = Common.GetDataTableWithAll(Query)

            With cmbTax
                .DataSource = dtTax
                .DisplayMember = "TXTMTDS_NAME"
                .ValueMember = "TXTMTDS_ID"
            End With

        ElseIf bytRptType = enmRptType.BrokerCollection Or bytRptType = enmRptType.BrokerCommission Or bytRptType = enmRptType.BrokerCommissionReport Then ''ankita 20052019
            If bytRptType = enmRptType.BrokerCommissionReport Or bytRptType = enmRptType.BrokerCollection Then
                chkSum.Visible = False
            Else
                chkSum.Visible = True
            End If
            If bytRptType = enmRptType.BrokerCollection Then
                Me.Text = "Broker Collection Report"
            Else
                Me.Text = "Broker Commission Report"
            End If

            cmbTax.Visible = False : chkTax.Visible = False
            pnlBroker.Visible = True



            blnLoading = True
            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' and LED_CAT ='B' AND LED_NAME <> '' " & BranchLedFixFilter _
                & " ORDER BY LED_NAME"
            Dim dtBrokerFrom As DataTable = Common.GetDataTableWithAll(Query)

            With cmbBrokerFrom
                .DataSource = dtBrokerFrom
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With

            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' AND LED_CAT IN ('B') AND LED_NAME <> '' " & BranchLedFixFilter _
                & " ORDER BY LED_NAME"
            Dim dtBrokerTo As DataTable = Common.GetDataTableWithAll(Query)

            With cmbBrokerTo
                .DataSource = dtBrokerTo
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With
            blnLoading = False
            Call cmbBrokerFrom_SelectedValueChanged(Nothing, Nothing)

            Query = "Select Distinct LED_KEY, LED_NAME " _
                & " From Ledger Left Join Station On Ledger.OStn_Key = Station.Stn_Key " _
                & " Left Join State On State.State_Key = Station.State_Key " _
                & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " _
                & " Order By Led_Name"

            Dim dtPartyFrom As DataTable = Common.GetDataTableWithAll(Query)
            With cmbPartyFrom
                .DataSource = dtPartyFrom
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With

            Dim dtPartyTo As DataTable = Common.GetDataTableWithAll(Query)
            With cmbPartyTo
                .DataSource = dtPartyTo
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With

            If cmbPartyFrom.Items.Count > 0 Then cmbPartyFrom.SelectedIndex = 0



            '''''Added by Pooja on 27-04-2017
            Query = "Select distinct STATE_KEY, STATE_NAME From State " _
            & " Where State_Key <> '' And Status = '1' Order By State_Name"
            Dim dtStateFrom As DataTable = Common.GetDataTableWithAll(Query)

            With cmbStateFrom1
                .DataSource = dtStateFrom
                .DisplayMember = "STATE_NAME"
                .ValueMember = "STATE_KEY"
            End With

            Dim dtStateTo As DataTable = Common.GetDataTableWithAll(Query)
            With cmbStateTo
                .DataSource = dtStateTo
                .DisplayMember = "STATE_NAME"
                .ValueMember = "STATE_KEY"
            End With


            Query = "Select distinct Station.Stn_Key, Stn_Name From Station " _
                & " Inner Join State On State.State_Key = Station.State_Key " _
                & " Where Station.Stn_Key <> '' And Station.Status = '1'" _
                & " Order By Stn_Name"

            Dim dtCityFrom As DataTable = Common.GetDataTableWithAll(Query)
            With cmbCityFrom
                .DataSource = dtCityFrom
                .DisplayMember = "Stn_Name"
                .ValueMember = "Stn_Key"
            End With

            Dim dtCityTo As DataTable = Common.GetDataTableWithAll(Query)
            With cmbCityTo
                .DataSource = dtCityTo
                .DisplayMember = "Stn_Name"
                .ValueMember = "Stn_Key"
            End With

            If cmbStateFrom1.Items.Count > 0 Then
                cmbStateFrom1.SelectedIndex = 0
                Call cmbStateFrom1_SelectionChangeCommitted(cmbStateFrom1, Nothing)
            End If

        End If

        lblFormCaption.Text = Me.Text
    End Sub

    Private Sub dtpFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkViewSize.KeyDown, cmbStateFrom.KeyDown, dtpTo.KeyDownEvent, dtpFrom.KeyDownEvent
        Call MoveToNextControl(e)
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim strFile, strFormula, strTitle As String
        Dim strAll As String = ""
        Dim strState As String = ""
        Dim strCNType As String = ""
        Dim strPartyType As String = ""
        Dim BrokerFltr As String = ""
        Dim Formulas As New Hashtable

        ReDim subrpt(0)

        If bytRptType = enmRptType.BrokerCollection Or bytRptType = enmRptType.Sales_BrokerWise Or bytRptType = enmRptType.CNRegister_BrokerWise Or bytRptType = enmRptType.BrokerCommission Or bytRptType = enmRptType.BrokerCommissionReport Then ''ankita 20052019
            If cmbBrokerFrom.SelectedIndex = -1 Or cmbBrokerTo.SelectedIndex = -1 Then
                MsgBox("Invalid Broker selected !", MsgBoxStyle.Exclamation)
                cmbBrokerFrom.Focus()
                Exit Sub
            End If
        ElseIf bytRptType = enmRptType.Sales_PartyWithTINNo Then
            If cmbBrokerFrom.SelectedIndex = -1 Or cmbBrokerTo.SelectedIndex = -1 Then
                MsgBox("Invalid Party selected !", MsgBoxStyle.Exclamation)
                cmbBrokerFrom.Focus()
                Exit Sub
            End If
        End If

        strFile = "" : strFormula = "" : strTitle = ""
        GetReportDetails(strFile, strFormula, strTitle)
        'ReportParameters.ApplyCompanyFilter = True

        If bytRptType = enmRptType.Sales_Book Or bytRptType = enmRptType.Sales_BookGST Or bytRptType = enmRptType.Sales_WithTINNo Or bytRptType = enmRptType.Sales_PartyWithTINNo Or bytRptType = enmRptType.Sales_BrokerWise Or bytRptType = enmRptType.CNRegister Or bytRptType = enmRptType.CNRegisterGST Or bytRptType = enmRptType.CNRegister_BrokerWise Or bytRptType = enmRptType.Purchase_Book Or bytRptType = enmRptType.Purchase_BookGST Then
            If rdWithinState.Checked Then
                strFormula &= " AND {STATE.STATE_NAME} = " & Chr(34) & cmbStateFrom.Text & Chr(34)
            ElseIf rdOutOfState.Checked Then
                strFormula &= " AND {STATE.STATE_NAME} <> " & Chr(34) & cmbStateFrom.Text & Chr(34)
            End If
        End If

        If bytRptType = enmRptType.BrokerCollection Or bytRptType = enmRptType.Sales_BrokerWise Or bytRptType = enmRptType.CNRegister_BrokerWise Or bytRptType = enmRptType.BrokerCommission Or bytRptType = enmRptType.BrokerCommissionReport Then
            If cmbBrokerFrom.SelectedIndex > 0 Then
                If cmbBrokerTo.SelectedIndex > 0 Then
                    strFormula &= " AND {BROKER.LED_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbBrokerFrom.Text) & Chr(34) & " AND {BROKER.LED_NAME} <= " & Chr(34) & ReplaceApostrophe(cmbBrokerTo.Text) & Chr(34)
                Else
                    strFormula &= " AND {BROKER.LED_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbBrokerFrom.Text) & Chr(34)
                End If
            End If
        End If

        If bytRptType = enmRptType.BrokerCollection Or bytRptType = enmRptType.BrokerCommission Or bytRptType = enmRptType.BrokerCommissionReport Then ''ankita 20052019
            If cmbPartyFrom.SelectedIndex > 0 Then
                If cmbPartyTo.SelectedIndex > 0 Then
                    strFormula &= " And {Party.LED_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbPartyFrom.Text) & Chr(34) & " And {Party.LED_NAME} <= " & Chr(34) & ReplaceApostrophe(cmbPartyTo.Text) & Chr(34)
                Else
                    strFormula &= " And {Party.LED_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbPartyFrom.Text) & Chr(34)
                End If
            End If


            '''''Added by Pooja on 28-04-2017
            If cmbStateFrom1.SelectedIndex > 0 Then
                If cmbStateTo.SelectedIndex > 0 Then
                    strFormula &= " And {State.State_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbStateFrom1.Text) & Chr(34) & " And {State.State_NAME} <= " & Chr(34) & ReplaceApostrophe(cmbStateTo.Text) & Chr(34)
                Else
                    strFormula &= " And {State.State_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbStateFrom1.Text) & Chr(34)
                End If
            End If


            If cmbCityFrom.SelectedIndex > 0 Then
                If cmbCityTo.SelectedIndex > 0 Then
                    strFormula &= " And {Station.Stn_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbCityFrom.Text) & Chr(34) & " And {Station.Stn_NAME} <= " & Chr(34) & ReplaceApostrophe(cmbCityTo.Text) & Chr(34)
                Else
                    strFormula &= " And {State.Stn_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbCityFrom.Text) & Chr(34)
                End If
            End If

        End If


        If bytRptType = enmRptType.Sales_PartyWithTINNo Then
            If cmbBrokerFrom.SelectedIndex > 0 Then
                If cmbBrokerTo.SelectedIndex > 0 Then
                    strFormula &= " AND {PARTY.LED_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbBrokerFrom.Text) & Chr(34) & " AND {PARTY.LED_NAME} <= " & Chr(34) & ReplaceApostrophe(cmbBrokerTo.Text) & Chr(34)
                Else
                    strFormula &= " AND {PARTY.LED_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbBrokerFrom.Text) & Chr(34)
                End If
            End If
        End If

        Formulas.Add("StDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
        Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

        ReportParameters.rptCaption = strTitle
        ReportParameters.rptFile = strFile
        ReportParameters.rptFilter = strFormula

        If bytRptType = enmRptType.Sales_Book Then
            ReDim subrpt(1)
            subrpt(0).Report = "TaxSumAmt"

            If cmbStateFrom.Text.Trim.Length > 0 Then
                ReDim subrptFormula(1)

                subrptFormula(0).FormulaKey = "LOCALSTATE"
                subrptFormula(0).FormulaValue = Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34)
            End If

            'subrpt(0).Filter = "LOCALSTATE = " & Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34)
            If chkTax.Checked Then
                If cmbTax.SelectedIndex > 0 Then
                    strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                End If
            End If

            subrpt(0).Filter = "{BILL.COBR_ID} = '" & SelBranchId & "' AND {Tax.TxTmTDS_Flag} = 'X' AND {BILL.Doc_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") And {BILL.Doc_Type} = 'A' " & strAll
            'subrpt(0).Filter = "{BILL.Doc_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll

            'subrpt(1).Report = "QtySum"
            'subrpt(1).Filter = "{BILL.Doc_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"

        ElseIf bytRptType = enmRptType.Sales_BookGST Then
            ReDim subrpt(1)
            subrpt(0).Report = "Tax"


            If cmbStateFrom.Text.Trim.Length > 0 Then
                ReDim subrptFormula(1)

                subrptFormula(0).FormulaKey = "LOCALSTATE"
                subrptFormula(0).FormulaValue = Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34)
            End If

            'subrpt(0).Filter = "LOCALSTATE = " & Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34)
            If chkTax.Checked Then
                If cmbTax.SelectedIndex > 0 Then
                    strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                End If
            End If

            subrpt(0).Filter = "{VW_TaxSumAmt.COBR_ID} = '" & SelBranchId & "' AND {VW_TaxSumAmt.Doc_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {VW_TaxSumAmt.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") And {VW_TaxSumAmt.Doc_Type} = 'A' "
            'subrpt(0).Filter = " {VW_TaxSumAmt.Doc_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {VW_TaxSumAmt.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")  "


        ElseIf bytRptType = enmRptType.Sales_WithTINNo Or bytRptType = enmRptType.Sales_BrokerWise Or bytRptType = enmRptType.Sales_PartyWithTINNo Then
            ReDim subrpt(1)

            subrpt(0).Report = "TaxSumAmt"
            If cmbStateFrom.Text.Trim.Length > 0 Then
                ReDim subrptFormula(1)

                subrptFormula(0).FormulaKey = "LOCALSTATE"
                subrptFormula(0).FormulaValue = Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34)
            End If

            If chkTax.Checked Then
                If cmbTax.SelectedIndex > 0 Then
                    strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                End If
            End If

            subrpt(0).Filter = "{BILL.COBR_ID} = '" & SelBranchId & "' AND {Tax.TxTmTDS_Flag} = 'X' AND {BILL.Doc_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") And {BILL.Doc_Type} = 'A' " & strAll


        ElseIf bytRptType = enmRptType.CNRegister Or bytRptType = enmRptType.CNRegister_BrokerWise Then '--Abhi 22/12/2017---
            ReDim subrpt(1)

            subrpt(0).Report = "TaxDetails"
            If cmbStateFrom.Text.Trim.Length > 0 Then
                ReDim subrptFormula(1)

                subrptFormula(0).FormulaKey = "LOCALSTATE"
                subrptFormula(0).FormulaValue = Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34)
            End If

            If chkTax.Checked Then
                If cmbTax.SelectedIndex > 0 Then
                    strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                End If
            End If

            subrpt(0).Filter = strFormula & strAll

        ElseIf bytRptType = enmRptType.Purchase_Book Then
            ReDim subrpt(1)
            subrpt(0).Report = "TaxDtlsSum"

            If cmbStateFrom.Text.Trim.Length > 0 Then
                ReDim subrptFormula(1)

                subrptFormula(0).FormulaKey = "LOCALSTATE"
                subrptFormula(0).FormulaValue = Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34)
            End If

            If chkTax.Checked Then
                If cmbTax.SelectedIndex > 0 Then
                    strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                End If
            End If

            subrpt(0).Filter = "{PurchaseBILL.COBR_ID} = '" & SelBranchId & "' AND {Tax.TxTmTDS_Flag} = 'X' AND {PurchaseBILL.Doc_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {PurchaseBILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
        ElseIf bytRptType = enmRptType.Purchase_BookGST Then
            ReDim subrpt(1)
            subrpt(0).Report = "PTax1"

            If cmbStateFrom.Text.Trim.Length > 0 Then
                ReDim subrptFormula(1)

                subrptFormula(0).FormulaKey = "LOCALSTATE"
                subrptFormula(0).FormulaValue = Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34)
            End If

            If chkTax.Checked Then
                If cmbTax.SelectedIndex > 0 Then
                    strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                End If
            End If

            subrpt(0).Filter = "{VW_PurTaxSumAmt.COBR_ID} = '" & SelBranchId & "'  AND {VW_PurTaxSumAmt.Doc_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {VW_PurTaxSumAmt.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") "

        ElseIf bytRptType = enmRptType.BrokerCommission Then ''ankita 20052019
            Formulas.Add("ReportType#N", IIf(chkSum.Checked, 1, 0))

        End If

        Dim frmView As New frmViewReports(Formulas)
        frmView.Show()

        Formulas = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GetReportDetails(ByRef strReportFile As String, ByRef strFormula As String, ByRef strTitle As String)
        Dim strAll As String = ""
        Dim strParty As String = ""

        Select Case bytRptType
            Case enmRptType.Sales_Book
                If chkTax.Checked Then
                    strReportFile = ReportPath & "\Accounts\DayBookSalesTaxWise.rpt"
                    If cmbTax.SelectedIndex > 0 Then
                        strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                    End If
                Else
                    strReportFile = ReportPath & "\Accounts\DayBookSales.rpt"
                End If

                strFormula = "{BILL.COBR_ID} = '" & SelBranchId & "' AND {Tax.TxTmTDS_Flag} = 'X' AND {BILL.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Sales Register"
            Case enmRptType.Sales_BookGST
                If chkTax.Checked Then
                    strReportFile = ReportPath & "\Accounts\DayBookSalesTaxWiseGST.rpt"
                    If cmbTax.SelectedIndex > 0 Then
                        strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                    End If
                Else
                    strReportFile = ReportPath & "\Accounts\DayBookSalesGST.rpt"
                End If

                strFormula = "{BILL.COBR_ID} = '" & SelBranchId & "' AND {Tax.TxTmTDS_Flag} = 'X' AND {BILL.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Sales Register GST "
            Case enmRptType.Sales_WithTINNo
                If chkTax.Checked Then
                    strReportFile = ReportPath & "\Accounts\DayBookSalesTaxWiseTin.rpt"
                    If cmbTax.SelectedIndex > 0 Then
                        strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                    End If
                Else
                    strReportFile = ReportPath & "\Accounts\DayBookSalesTin.rpt"
                End If
                strFormula = "{BILL.COBR_ID} = '" & SelBranchId & "' AND {Tax.TxTmTDS_Flag} = 'X' AND {BILL.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Sales Register (With TIN No)"

            Case enmRptType.Sales_PartyWithTINNo
                If chkTax.Checked Then
                    strReportFile = ReportPath & "\Accounts\DayBookSalesPartyTaxWiseTin.rpt"
                    If cmbTax.SelectedIndex > 0 Then
                        strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                    End If
                Else
                    strReportFile = ReportPath & "\Accounts\DayBookSalesPartyTin.rpt"
                End If
                strFormula = "{BILL.COBR_ID} = '" & SelBranchId & "' AND {Tax.TxTmTDS_Flag} = 'X' AND {BILL.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Sales Register (Party With TIN No)"

            Case enmRptType.Sales_BrokerWise
                strReportFile = ReportPath & "\Accounts\DayBookSalesAgent.rpt"
                strFormula = "{BILL.COBR_ID} = '" & SelBranchId & "' AND {Tax.TxTmTDS_Flag} = 'X' AND {BILL.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.DOC_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Sales Register (Broker Wise)"

            Case enmRptType.CNRegister
                strReportFile = ReportPath & "\Accounts\CNRegister.rpt"
                If chkTax.Checked Then
                    If cmbTax.SelectedIndex > 0 Then
                        strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                    End If
                End If

                strFormula = "{View_CN.COBR_ID} = '" & SelBranchId & "' AND {View_CN.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {View_CN.DOC_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Credit Note Register"

                '--Abhi 22/12/2017---
            Case enmRptType.CNRegisterGST
                strReportFile = ReportPath & "\Accounts\CNRegisterGST.rpt"
                If chkTax.Checked Then
                    If cmbTax.SelectedIndex > 0 Then
                        strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                    End If
                End If

                strFormula = "{View_CN.COBR_ID} = '" & SelBranchId & "' AND {View_CN.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {View_CN.DOC_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Credit Note Register"
                '--Abhi 22/12/2017---

            Case enmRptType.CNRegister_BrokerWise
                strReportFile = ReportPath & "\Accounts\CNRegisterBroker.rpt"
                If chkTax.Checked Then
                    If cmbTax.SelectedIndex > 0 Then
                        strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                    End If
                End If

                strFormula = "{View_CN.COBR_ID} = '" & SelBranchId & "' AND {View_CN.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {View_CN.DOC_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Credit Note Register (Broker Wise)"

            Case enmRptType.Purchase_Book
                If cmbPurchGroup.SelectedIndex <> 0 Then
                    strAll = " AND {Ledger.Led_NAME} = " & Chr(34) & cmbPurchGroup.Text & Chr(34)
                End If

                If chkTax.Checked Then
                    If cmbTax.SelectedIndex > 0 Then
                        strAll &= " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                    End If
                End If

                strReportFile = ReportPath & "\Accounts\DayBookPur.rpt"
                strFormula = "{PurchaseBILL.COBR_ID} = '" & SelBranchId & "' AND {PurchaseBILL.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {PurchaseBILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Purchase Register"

            Case enmRptType.Purchase_BookGST
                If cmbPurchGroup.SelectedIndex <> 0 Then
                    strAll = " AND {Ledger.Led_NAME} = " & Chr(34) & cmbPurchGroup.Text & Chr(34)
                End If

                If chkTax.Checked Then
                    If cmbTax.SelectedIndex > 0 Then
                        strAll &= " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                    End If
                End If

                strReportFile = ReportPath & "\Accounts\DayBookPurGST.rpt"
                strFormula = "{PurchaseBILL.COBR_ID} = '" & SelBranchId & "' AND {PurchaseBILL.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {PurchaseBILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                strTitle = "Purchase Register GST"

            Case enmRptType.BrokerCommission
                strReportFile = ReportPath & "\Accounts\BrokerComm.rpt"
                strFormula = "{View_CommDtl.COBR_ID} = '" & SelBranchId & "' AND {View_CommDtl.Bill_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {View_CommDtl.Bill_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") "
                strTitle = "Broker Commission Report"

                'Added by satish 07062019------------
            Case enmRptType.BrokerCollection
                strReportFile = ReportPath & "\Accounts\BrokerWiseCollection.rpt"
                strFormula = "{View_BrokerWiseCollection.COBR_ID} = '" & SelBranchId & "' AND {View_BrokerWiseCollection.Doc_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {View_BrokerWiseCollection.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") "
                strTitle = "Broker Collection Report"
                '-----------------------------------------

                ''ankita 20052019
            Case enmRptType.BrokerCommissionReport
                strReportFile = ReportPath & "\Accounts\CNRegisterBroker.rpt"
                strFormula = "{SalesRtn.COBR_ID} = '" & SelBranchId & "' AND {SalesRtn.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {SalesRtn.DOC_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") "
                strTitle = "Credit Note Register (Broker Wise)"
                'If chkTax.Checked Then
                '    If cmbTax.SelectedIndex > 0 Then
                '        strAll = " And {TAX.TxTmTDS_NAME} = " & Chr(34) & ReplaceApostrophe(cmbTax.Text) & Chr(34)
                '    End If
                'End If

                'strFormula = "{SalesRtn.COBR_ID} = '" & SelBranchId & "' AND {SalesRtn.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {SalesRtn.DOC_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") " & strAll
                'strTitle = "Credit Note Register (Broker Wise)"

             
                ''end ankita 20052019


        End Select
    End Sub

    Private Sub DisplayState()
        Query = "SELECT 0 STATE_ID, '' STATE_NAME UNION ALL " _
            & "SELECT STATE_ID, STATE_NAME FROM STATE " _
            & " WHERE STATUS = '1' And COBR_ID = '" & SelBranchId & "' ORDER BY STATE_NAME"
        Common.FillCombo2(Query, cmbStateFrom, "STATE_NAME", "STATE_ID")

        blnLoading = False
        cmbStateFrom.SelectedIndex = 0
    End Sub

    Private Sub chkTax_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTax.CheckedChanged
        cmbTax.Visible = chkTax.Checked
    End Sub

    Private Sub cmbBrokerFrom_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBrokerFrom.SelectedValueChanged
        If blnLoading Or cmbBrokerFrom.SelectedIndex = -1 Then Exit Sub
        cmbBrokerTo.SelectedIndex = cmbBrokerFrom.SelectedIndex
    End Sub

    Private Sub cmbPartyFrom_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartyFrom.SelectionChangeCommitted
        If cmbPartyFrom.SelectedIndex = -1 Then Exit Sub
        cmbPartyTo.SelectedIndex = cmbPartyFrom.SelectedIndex
    End Sub


    ''Added by Pooja
    Private Sub cmbStateFrom1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStateFrom1.SelectionChangeCommitted
        If cmbStateFrom1.SelectedIndex = -1 Or cmbStateTo.SelectedIndex = -1 Then Exit Sub
        cmbStateTo.SelectedIndex = cmbStateFrom1.SelectedIndex
        Call DisplayCity()
    End Sub

    Private Sub DisplayCity()
        Dim strFilter As String = ""

        Try
            If cmbStateFrom1.SelectedIndex > 0 Then
                If cmbStateTo.SelectedIndex > 0 Then
                    strFilter = " And (State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom1.Text) & "' And State.State_Name <= '" & ReplaceApostrophe(cmbStateTo.Text) & "')"
                Else
                    strFilter = " And State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom1.Text) & "'"
                End If
            End If

            Me.Cursor = Cursors.WaitCursor

            Query = "Select Distinct Station.Stn_Key, Stn_Name From Station " _
                & " Inner Join State On State.State_Key = Station.State_Key " _
                & " Where Station.Stn_Key <> '' And Station.Status = '1' " & strFilter _
                & " Order By Stn_Name"

            Dim dtCityFrom As DataTable = Common.GetDataTableWithAll(Query)
            With cmbCityFrom
                .DataSource = dtCityFrom
                .DisplayMember = "Stn_Name"
                .ValueMember = "Stn_Key"
            End With

            Dim dtCityTo As DataTable = Common.GetDataTableWithAll(Query)
            With cmbCityTo
                .DataSource = dtCityTo
                .DisplayMember = "Stn_Name"
                .ValueMember = "Stn_Key"
            End With

            If cmbCityFrom.Items.Count > 0 Then
                cmbCityFrom.SelectedIndex = 0
                Call cmbCityFrom_SelectionChangeCommitted(cmbCityFrom, Nothing)
            End If

        Catch SqlEx As Exception
            Call Common.LogAndDisplayException(SqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbCityFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCityFrom.SelectionChangeCommitted
        If cmbCityFrom.SelectedIndex = -1 Then Exit Sub
        cmbCityTo.SelectedIndex = cmbCityFrom.SelectedIndex
        Call DisplayParty()
    End Sub


    Private Sub DisplayParty()
        Dim strFilter As String = ""

        Try
            If cmbStateFrom1.SelectedIndex > 0 Then
                If cmbStateTo.SelectedIndex > 0 Then
                    strFilter = " And (State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom1.Text) & "' And State.State_Name <= '" & ReplaceApostrophe(cmbStateTo.Text) & "')"
                Else
                    strFilter = " And State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom1.Text) & "'"
                End If
            End If

            If cmbCityFrom.SelectedIndex > 0 Then
                If cmbCityTo.SelectedIndex > 0 Then
                    strFilter &= " And (Station.Stn_Name >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "' And Station.Stn_Name <= '" & ReplaceApostrophe(cmbCityTo.Text) & "')"
                Else
                    strFilter &= " And Station.Stn_Name >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "'"
                End If
            End If

            Me.Cursor = Cursors.WaitCursor

            Query = "Select Distinct LED_KEY, LED_NAME " _
                & " From Ledger Left Join Station On Ledger.OStn_Key = Station.Stn_Key " _
                & " Left Join State On State.State_Key = Station.State_Key " _
                & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchFixId & "' And Led_Name <> '' " & strFilter _
                & " Order By Led_Name"

            Dim dtPartyFrom As DataTable = Common.GetDataTableWithAll(Query)
            With cmbPartyFrom
                .DataSource = dtPartyFrom
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With

            Dim dtPartyTo As DataTable = Common.GetDataTableWithAll(Query)
            With cmbPartyTo
                .DataSource = dtPartyTo
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With

            If cmbPartyFrom.Items.Count > 0 Then cmbPartyFrom.SelectedIndex = 0

        Catch SqlEx As Exception
            Call Common.LogAndDisplayException(SqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class