Imports System.Data.SqlClient

Public Class frmTDSEntry
    Dim Formulas As Hashtable
    Dim ReportCaption As String = ""
    Dim Details As DataTable
    Dim voucher_id As Integer
    Dim sr_no As Integer
    Enum gridcols
        tds_key
        tds_pay_name
        sr_no
        type
        doc_no
        doc_dt
        Bill_No
        party_name
        party_key
        amount
        tds_perc
        tds_amt
        challan_no
        challan_dt
        chq_no
        bank_name
        bank_key
        doc_id
        vochr_id
    End Enum
    Enum lvwJobchlnDetails
        TDS_Name
        TDS_key
    End Enum
    Private Sub frmAccReportFilters_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub frmAccReportFilters_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Me.Cursor = Cursors.WaitCursor

            dtpFrom.Value = AccFromDt
            dtpTo.Value = AccToDt
            dtpFrom.Value = AccFromDt
            dtpTo.Value = AccToDt

            Query = "Select LED_KEY,LED_NAME From ledger where ACCLGRP_KEY IN (SELECT ACCLGRP_KEY FROM ACCLGRP WHERE AccLGrp_Type IN(2))  And Status = '1' " _
            & BranchFixFilter _
            & " Order By Led_Name"
            Common.FillCombo2(Query, cmbBank, "LED_NAME", "LED_KEY")

            Select_Acc_Fill()

            lvwAccountDtls.ContextMenuStrip = mnuSelection

            dtpFrom.Focus()
        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Sub Select_Acc_Fill()
        Try


            Query = " Select LED_KEY, LED_NAME " _
                    & " From Ledger " _
                    & " Where Status = '1' And Led_Name <> '' And Led_Cat = 'L' and acclgrp_key='" & SelBranchFixId & 8 & "' and Led_Name like 'Tds%' " _
                    & BranchFixFilter _
                    & " Order By Led_Name"
            Dim SalesOrderDtls As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow
            Dim Cnt As Integer
            ClearListHeaders()
            For Each RecRow In SalesOrderDtls.Rows
                lvwAccountDtls.Items.Add(RecRow("LED_NAME"))
                'lvwAccountDtls.Items.Add(RecRow("LED_KEY"))

                Cnt = lvwAccountDtls.Items.Count - 1
                With lvwAccountDtls.Items(Cnt).SubItems
                    .Add(RecRow("LED_KEY") & "")

                End With
            Next RecRow
            SalesOrderDtls = Nothing

            If lvwAccountDtls.Items.Count > 0 Then
                lvwAccountDtls.Items(0).Selected = True
                lvwAccountDtls.Focus()
            End If


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub ClearListHeaders()
        lvwAccountDtls.Items.Clear()
        lvwAccountDtls.Columns.Clear()

        With lvwAccountDtls.Columns

            .Add("Account Name", 500, HorizontalAlignment.Left)
            .Add("TDs Key ", 0, HorizontalAlignment.Left)
        End With
    End Sub
    Private Function GetFromToDateSeriesFilter(ByVal DateField As String, ByVal SeriesField As String, Optional ByVal AddParam As Boolean = True) As String
        Dim Series As String = ""
        Dim FromToDate As String = ""
        If AddParam Then
            Formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            Formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
        End If

        FromToDate = " And " & DateField & " >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And " & DateField & " <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" & Series

        Return FromToDate
    End Function
    Private Sub mnuSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectAll.Click
        Dim lvwItem As ListViewItem

        For Each lvwItem In lvwAccountDtls.Items
            lvwItem.Checked = True
        Next lvwItem
    End Sub

    Private Sub mnuUnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUnSelectAll.Click
        Dim lvwItem As ListViewItem

        For Each lvwItem In lvwAccountDtls.Items
            lvwItem.Checked = False
        Next lvwItem
    End Sub

    Private Sub mnuInvertSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInvertSelect.Click
        Dim lvwItem As ListViewItem

        For Each lvwItem In lvwAccountDtls.Items
            lvwItem.Checked = Not lvwItem.Checked
        Next lvwItem
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub DisplayGridHeaders()
        Dim Grid As New GridColumnCreateAndFormat("PurDetails")

        With Grid
            .AddColumn("tds_key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "TDS Key.")
            .AddColumn("tds_pay_name", GridColumnCreateAndFormat.enmTypeIdx.StringType, 150, "TDS Name")
            .AddColumn("sr_no", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 40, "SR No..")
            .AddColumn("Type", GridColumnCreateAndFormat.enmTypeIdx.StringType, 40, "Type")
            .AddColumn("doc_no", GridColumnCreateAndFormat.enmTypeIdx.StringType, 60, "Doc No")
            .AddColumn("doc_dt", GridColumnCreateAndFormat.enmTypeIdx.StringType, 70, "Doc Date")
            .AddColumn("Bill_No", GridColumnCreateAndFormat.enmTypeIdx.StringType, 60, "Bill No")
            .AddColumn("party_name", GridColumnCreateAndFormat.enmTypeIdx.StringType, 160, "Party Name")
            .AddColumn("party_key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Party_key")
            .AddColumn("amount", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 100, "Amount..")
            .AddColumn("tds_perc", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 40, "TDS %..")
            .AddColumn("tds_amt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 60, "TDS Amt..")
            .AddColumn("challan_no", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, "Challan No")
            .AddColumn("challan_dt", GridColumnCreateAndFormat.enmTypeIdx.DateTimeType, 80, "Challan Date")
            .AddColumn("chq_no", GridColumnCreateAndFormat.enmTypeIdx.StringType, 50, "Cheque No")
            .AddColumn("bank_name", GridColumnCreateAndFormat.enmTypeIdx.StringType, 150, "Bank Name")
            .AddColumn("bank_key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Bank Key")
            .AddColumn("doc_id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "Doc_id")
            .AddColumn("vochr_id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "vochr_id")

            .AddColumnToTable()
            Details = .GetTable
            Details.DefaultView.AllowNew = False
            Details.DefaultView.AllowEdit = False
            Details.DefaultView.AllowDelete = False

            dtgDetails.DataSource = Details
            .DisplayGridHeaders(Details, dtgDetails)
        End With
    End Sub
    Private Sub btnEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntry.Click
        grpEntryMain.BringToFront()
        txtChallanNo.Focus()

        Details = Nothing : dtgdetails.DataSource = Nothing
        DisplayGridHeaders()

        Dim i As Short
        Dim doc_id As String = ""

        For i = 0 To lvwAccountDtls.Items.Count - 1
            If lvwAccountDtls.Items(i).Checked Then
                If lvwAccountDtls.Items(i).SubItems(lvwJobchlnDetails.TDS_key).Text > 0 Then
                    If Not RecordExist(lvwAccountDtls.Items(i).SubItems(lvwJobchlnDetails.TDS_key).Text) Then
                        If doc_id <> "" Then
                            doc_id = doc_id & "','" & lvwAccountDtls.Items(i).SubItems(lvwJobchlnDetails.TDS_key).Text
                        Else
                            doc_id = lvwAccountDtls.Items(i).SubItems(lvwJobchlnDetails.TDS_key).Text
                        End If
                    End If

                End If
            End If
        Next

        grid_fill(doc_id)
        ReCalcSerial(False)
        txtChallanNo.Text = ""
        dtpChallandt.Text = ""
        cmbBank.Text = ""
        txtchq_no.Text = ""
        grpsr.Visible = False
    End Sub
    Private Function RecordExist(ByVal recptid As String) As Boolean
        Dim i As Integer
        For i = 0 To Details.Rows.Count - 1
            If Details.Rows(i).Item(gridcols.tds_key) = recptid Then
                Return True
            End If
        Next i
        Return False
    End Function
   

    Sub grid_fill(ByVal TDS_Key As String)
        Dim strwhr As String = ""
        Dim strorderby As String = ""
        Dim select_str As String = ""
        Dim FromToDate As String = ""

        If TDS_Key = "" Then
            select_str = " where tds_Name like 'Tds%'"
        Else
            select_str = " where tds_key in ('" & TDS_Key & "')"
        End If
        If rdUnPaid.Checked = True Then
            strwhr = " and challan_no=''"
        Else
            strwhr = ""
        End If

        If rdDateWise.Checked = True Then
            strorderby = " Order by Doc_Dt"
        Else
            strorderby = " Order by Led_Name"
        End If

        'FromToDate = " And (Doc_Dt >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And Doc_Dt <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & "))"
        FromToDate = " And (Doc_Dt >= '" & Format$(dtpFrom.Value, "yyyy/MM/dd") & "' And Doc_Dt <= '" & Format$(dtpTo.Value, "yyyy/MM/dd") & "')"


        'Query = "SELECT     tds_key, tds_name,  sr_no, type, doc_no, Doc_Dt, party_id,Led_Name, Net_Amt, TDSRt, TDSAmt, AmtAfterTDS, Challan_no, " _
        '        & "  challandt, Chq_no, bank_name, Bank_key, PurchaseBill_id, voucher_id, Doc_Id " _
        '        & " FROM (SELECT     dbo.VchrDtl.LedRef_Key AS tds_key, Ledger_1.Led_Name AS tds_name, 0 AS sr_no, 'JRNL' AS type, dbo.Vchr.PDoc_No AS doc_no, dbo.Vchr.Doc_Dt,  " _
        '        & " dbo.VchrDtl.Led_Key AS party_id, dbo.Ledger.Led_Name, ((dbo.VchrDtl.Amount * 100) / dbo.Ledger.TDSRate) AS Net_Amt, dbo.Ledger.TDSRate AS TDSRt,  " _
        '        & " dbo.VchrDtl.Amount AS TDSAmt, (((dbo.VchrDtl.Amount * 100) / dbo.Ledger.TDSRate) - VchrDtl.Amount) AS AmtAfterTDS, dbo.Vchr.Challan_no,  " _
        '        & " dbo.Vchr.challandt, dbo.Vchr.Chq_no, Ledger_2.Led_Name AS bank_name, dbo.Vchr.Bank_key, dbo.VchrDtlRef.PurchaseBill_id,  " _
        '        & " dbo.Vchr.doc_id AS voucher_id, VchrDtlRef.PurchaseBill_id AS Doc_Id " _
        '        & " FROM  VchrDtl Left Join Vchr ON dbo.VchrDtl.Doc_Id = dbo.Vchr.Doc_Id INNER JOIN dbo.Ledger AS Ledger_1 ON dbo.VchrDtl.TDS_Party = Ledger_1.Led_Key INNER JOIN " _
        '        & " dbo.Ledger AS Ledger_2 ON dbo.Vchr.Bank_key = Ledger_2.Led_Key INNER JOIN dbo.Ledger ON dbo.VchrDtl.Led_Key = dbo.Ledger.Led_Key  " _
        '        & " WHERE(dbo.Ledger.TDSRate <> 0) and Ledger_1.Led_Name like 'Tds%' " _
        '        & " UNION ALL  " _
        '        & " SELECT     dbo.VchrDtl.Led_Key AS tds_key, Ledger_1.Led_Name AS tds_name, 0 AS sr_no, 'JRNL' AS type, dbo.PurchaseBill.Doc_no, dbo.PurchaseBill.Doc_Dt,  " _
        '        & " dbo.PurchaseBill.Party_Id, dbo.Ledger.Led_Name, dbo.PurchaseBill.Net_Amt, dbo.PurchaseBill.TDSRt, dbo.PurchaseBill.TDSAmt, dbo.PurchaseBill.AmtAfterTDS, dbo.Vchr.Challan_no, dbo.Vchr.challandt, dbo.Vchr.Chq_no, Ledger_2.Led_Name AS bank_name, dbo.Vchr.Bank_key,  " _
        '        & "  dbo.VchrDtlRef.PurchaseBill_id, dbo.PurchaseBill.voucher_id, dbo.PurchaseBill.Doc_Id " _
        '        & " FROM         dbo.VchrDtlRef INNER JOIN dbo.VchrDtl ON dbo.VchrDtlRef.DocDtl_Id = dbo.VchrDtl.DocDtl_Id INNER JOIN " _
        '        & " dbo.Vchr ON dbo.VchrDtlRef.Doc_Id = dbo.Vchr.Doc_Id INNER JOIN dbo.PurchaseBill ON dbo.VchrDtlRef.PurchaseBill_id = dbo.PurchaseBill.Doc_Id INNER JOIN " _
        '        & " dbo.Ledger ON dbo.PurchaseBill.Party_Id = dbo.Ledger.Led_Key INNER JOIN dbo.Ledger AS Ledger_1 ON dbo.VchrDtl.LedRef_Key = Ledger_1.Led_Key INNER JOIN " _
        '        & " dbo.Ledger AS Ledger_2 ON dbo.Vchr.Bank_key = Ledger_2.Led_Key " _
        '        & " WHERE    (dbo.PurchaseBill.tdsrt <> 0)) AS abc " _
        '        & select_str & strwhr & FromToDate & strorderby


        Query = "SELECT     tds_key, tds_name,  sr_no, type, doc_no, Doc_Dt,BillNo, party_id,Led_Name, Net_Amt, TDSRt, TDSAmt,  Challan_no, " _
                 & "  challandt, Chq_no, bank_name, Bank_key, voucher_id " _
                 & " FROM (SELECT     VchrDtl.Led_Key AS tds_key, Ledger.Led_Name AS tds_name, 0 AS sr_no, 'JRNL' AS type, " _
                 & " Vchr.PDoc_No AS doc_no, Vchr.Doc_Dt,'' BillNo,   VchrDtl.LedRef_Key AS party_id, Ledger_1.Led_Name, VchrDtl.TDS_On_Amt AS Net_Amt, " _
                 & " Ledger_1.TDSRate AS TDSRt,   VchrDtl.Amount AS TDSAmt, Vchr.Challan_no,   Vchr.challandt, Vchr.Chq_no, " _
                 & " Ledger_2.Led_Name AS bank_name, Vchr.Bank_key,   Vchr.doc_id AS voucher_id " _
                 & " FROM VchrDtl  " _
                 & " Left Join Vchr ON VchrDtl.Doc_Id = Vchr.Doc_Id  " _
                 & " Left JOIN Ledger AS Ledger_1 ON VchrDtl.TDS_Party = Ledger_1.Led_Key  " _
                 & " Left JOIN  Ledger AS Ledger_2 ON Vchr.Bank_key = Ledger_2.Led_Key  " _
                 & " Left JOIN Ledger ON VchrDtl.Led_Key = Ledger.Led_Key   " _
                 & " WHERE (Ledger_1.TDSRate <> 0) and Ledger.Led_Name like 'Tds%' and vchr.cobr_id = '" & SelBranchId & "' " _
                 & " UNION ALL  " _
                 & " SELECT     VchrDtl.LedRef_Key AS tds_key, Ledger_1.Led_Name AS tds_name, 0 AS sr_no, 'JRNL' AS type, PurchaseBill.Doc_no, " _
                 & " PurchaseBill.Doc_Dt,PurchaseBill.Chln_No,   PurchaseBill.Party_Id, Ledger.Led_Name, PurchaseBill.Net_Amt, PurchaseBill.TDSRt,  " _
                 & " PurchaseBill.TDSAmt,  Vchr.Challan_no, Vchr.challandt, Vchr.Chq_no, Ledger_2.Led_Name AS bank_name,  " _
                 & " Vchr.Bank_key, Vchr.Doc_Id voucher_id " _
                 & " FROM VchrDtlRef " _
                 & " INNER JOIN VchrDtl ON VchrDtlRef.DocDtl_Id = VchrDtl.DocDtl_Id  " _
                 & " INNER JOIN  Vchr ON VchrDtlRef.Doc_Id = Vchr.Doc_Id  " _
                 & " INNER JOIN PurchaseBill ON VchrDtlRef.PurchaseBill_id = PurchaseBill.Doc_Id  " _
                 & " INNER JOIN  Ledger ON PurchaseBill.Party_Id = Ledger.Led_Key  " _
                 & " INNER JOIN Ledger AS Ledger_1 ON VchrDtl.LedRef_Key = Ledger_1.Led_Key  " _
                 & " INNER JOIN  Ledger AS Ledger_2 ON Vchr.Bank_key = Ledger_2.Led_Key   " _
                 & " WHERE  Vchr.cobr_id = '" & SelBranchId & "' and  (PurchaseBill.tdsrt <> 0)) AS abc " _
                 & select_str & strwhr & FromToDate & strorderby

        Dim PurtdsDtl As DataTable = Common.GetDataTable(Query)
        Dim PurRow, NewRow As DataRow
        Dim strCurrRow As String = ""
        Dim TDSAmt As Double = 0 ''ankita 25052019
        Dim NetAmt As Double = 0 ''ankita 25052019
        For Each PurRow In PurtdsDtl.Rows
            NewRow = Details.NewRow
            ' NewRow = Details.NewRow
            NewRow(gridcols.tds_key) = PurRow("tds_key") & ""
            NewRow(gridcols.tds_pay_name) = PurRow("tds_name") & ""
            NewRow(gridcols.sr_no) = Val(PurRow("sr_no"))
            NewRow(gridcols.type) = PurRow("type") & ""
            NewRow(gridcols.doc_no) = PurRow("Doc_no") & ""
            NewRow(gridcols.doc_dt) = PurRow("Doc_Dt") & ""
            NewRow(gridcols.Bill_No) = PurRow("BillNo") & ""
            NewRow(gridcols.party_name) = PurRow("Led_Name") & ""
            NewRow(gridcols.party_key) = PurRow("Party_Id") & ""
            NewRow(gridcols.amount) = Format$(Val(PurRow("Net_Amt")), "0.00")
            NewRow(gridcols.tds_perc) = Val(PurRow("TDSRt"))
            NewRow(gridcols.tds_amt) = Val(PurRow("TDSAmt"))
            NewRow(gridcols.challan_no) = PurRow("Challan_no") & ""
            ' If IsDBNull(("challandt")) Then
            'If PurRow("challandt") = "01/01/1900 12:00:00 AM" Then
            '    NewRow(gridcols.challan_dt) = ""
            'Else
            NewRow(gridcols.challan_dt) = PurRow("challandt")
            ' End If
            NewRow(gridcols.chq_no) = PurRow("Chq_no")
            NewRow(gridcols.bank_name) = PurRow("bank_name")
            NewRow(gridcols.bank_key) = PurRow("Bank_key") & ""
            NewRow(gridcols.doc_id) = 0
            NewRow(gridcols.vochr_id) = Val(PurRow("voucher_id"))
            TDSAmt = TDSAmt + Val(PurRow("TDSAmt")) ''ankita 25052019
            NetAmt = NetAmt + Format$(Val(PurRow("Net_Amt")), "0.00") ''ankita 
            Details.Rows.Add(NewRow)
        Next PurRow
        lblTotTDS.Text = TDSAmt ''ankita 25052019
        lblTotAmt.Text = NetAmt ''ankita 25052019
        Details.AcceptChanges()
        dtgdetails.CurrentRowIndex = Details.Rows.Count - 1
        ReCalcSerial(False)
        dtgDetails_Click(Nothing, Nothing)
    End Sub
    Private Sub dtgDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If dtgdetails.CurrentRowIndex = -1 Then Exit Sub
        With dtgdetails
            txtChallanNo.Text = .Item(.CurrentRowIndex, gridcols.challan_no)
            dtpChallandt.Value = .Item(.CurrentRowIndex, gridcols.challan_dt)
            txtchq_no.Text = .Item(.CurrentRowIndex, gridcols.chq_no)
            cmbBank.Text = .Item(.CurrentRowIndex, gridcols.bank_name)
            cmbBank.Value = .Item(.CurrentRowIndex, gridcols.bank_key)
            voucher_id = .Item(.CurrentRowIndex, gridcols.vochr_id)
            sr_no = .Item(.CurrentRowIndex, gridcols.sr_no)
        End With

    End Sub
    Private Sub btnallupd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallupd.Click
        If Val(txtsrfrom.EditValue) = 0 Then
            MsgBox("Sr No cannot be Blank !", MsgBoxStyle.Exclamation)
            txtsrfrom.Focus()
            Exit Sub
        End If

        If Val(txtsrto.EditValue) = 0 Then
            MsgBox("Sr No cannot be Blank !", MsgBoxStyle.Exclamation)
            txtsrto.Focus()
            Exit Sub
        End If

        If Val(txtsrto.EditValue) > Details.Rows.Count Then
            MsgBox("Sr No To cannot be greater then Entry Details Count !", MsgBoxStyle.Exclamation)
            txtsrto.Focus()
            Exit Sub
        End If


        If Val(txtsrfrom.EditValue) > Val(txtsrto.EditValue) Then
            MsgBox("Sr No From cannot be greater then Sr No To !", MsgBoxStyle.Exclamation)
            txtsrfrom.Focus()
            Exit Sub
        End If


        If txtChallanNo.Text = "" Then
            MsgBox("Challan No cannot be Blank !", MsgBoxStyle.Exclamation)
            txtChallanNo.Focus()
            Exit Sub
        End If

        If txtchq_no.Text = "" Then
            MsgBox("Cheque No cannot be Blank !", MsgBoxStyle.Exclamation)
            txtchq_no.Focus()
            Exit Sub
        End If


        If cmbBank.Text.Trim.Length = 0 Then
            MsgBox(cmbBank.Tag & c_BlankMsg, MsgBoxStyle.Exclamation)
            cmbBank.Focus()
            Exit Sub
        End If

        Dim Trans As SqlTransaction = Nothing
        Dim i As Integer
        Dim sr_from As Integer
        Dim sr_to As Integer
        sr_from = Val(txtsrfrom.EditValue) - 1
        sr_to = Val(txtsrto.EditValue)

        For i = sr_from To sr_to - 1
            With dtgdetails
                .Item(i, gridcols.challan_no) = txtChallanNo.Text
                .Item(i, gridcols.challan_dt) = dtpChallandt.Value
                .Item(i, gridcols.chq_no) = txtchq_no.Text
                .Item(i, gridcols.bank_name) = cmbBank.Text
                .Item(i, gridcols.bank_key) = cmbBank.Value
                '.Item(i, gridcols.vochr_id) = voucher_id
            End With
        Next i
        Details.AcceptChanges()
        ReCalcSerial(False)
        btnsrclose_Click(btnsrclose, Nothing)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click


        If txtChallanNo.Text = "" Then
            MsgBox("Challan No cannot be Blank !", MsgBoxStyle.Exclamation)
            txtChallanNo.Focus()
            Exit Sub
        End If


        If txtchq_no.Text = "" Then
            MsgBox("Cheque No cannot be Blank !", MsgBoxStyle.Exclamation)
            txtchq_no.Focus()
            Exit Sub
        End If

        If cmbBank.Text.Trim.Length = 0 Then
            MsgBox(cmbBank.Tag & c_BlankMsg, MsgBoxStyle.Exclamation)
            cmbBank.Focus()
            Exit Sub
        End If
        With dtgdetails
            .Item(.CurrentRowIndex, gridcols.challan_no) = txtChallanNo.Text
            .Item(.CurrentRowIndex, gridcols.challan_dt) = dtpChallandt.Value
            .Item(.CurrentRowIndex, gridcols.chq_no) = txtchq_no.Text
            .Item(.CurrentRowIndex, gridcols.bank_name) = cmbBank.Text
            .Item(.CurrentRowIndex, gridcols.bank_key) = cmbBank.Value
            '.Item(.CurrentRowIndex, gridcols.vochr_id) = voucher_id
        End With
        Details.AcceptChanges()
        ReCalcSerial(False)
    End Sub

    Private Sub btnUpdateAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateAll.Click
        grpsr.Visible = True
        txtsrfrom.Focus()
    End Sub
    Private Sub btnsrclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsrclose.Click
        grpsr.Visible = False
        txtsrfrom.Text = ""
        txtsrto.Text = ""
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        grpEntryMain.SendToBack()
        'Select_Acc_Fill()
        lvwAccountDtls.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Trans As SqlTransaction = Nothing
        Trans = CreateSQLTransaction()
        For i = 0 To Details.Rows.Count - 1
            If Details.Rows(i)(gridcols.challan_no) <> "" Then
                voucher_id = Details.Rows(i)(gridcols.vochr_id)
                If Val(voucher_id) > 0 Then
                    Query = "update Vchr set Challan_no='" & Details.Rows(i)(gridcols.challan_no) & "',challandt='" & Format$(Details.Rows(i)(gridcols.challan_dt), "MM/dd/yyyy HH:mm:ss tt") & "', Chq_no='" & Details.Rows(i)(gridcols.chq_no) & "', " _
                            & " Bank_key='" & Details.Rows(i)(gridcols.bank_key) & "' where doc_id=" & Val(Details.Rows(i)(gridcols.vochr_id)) 'Val(voucher_id)

                    Common.ExecuteQuery(Query, Trans)
                End If
            End If
           
        Next i

        If Details.Rows.Count > 0 Then
            MsgBox("Update Successfully !", MsgBoxStyle.Exclamation)
        End If
        ReCalcSerial(False)
        btnCancel_Click(btnCancel, Nothing)
        Trans.Commit()

    End Sub

    Private Sub txtChallanNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChallanNo.KeyDown, txtchq_no.KeyDown, dtpChallandt.KeyDown, txtsrfrom.KeyDown, dtpTo.KeyDownEvent, dtpFrom.KeyDownEvent
        MoveToNextControl(e)
    End Sub

    Private Sub cmbBank_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBank.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdate.Focus()
        End If
    End Sub

    Private Sub txtsrto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsrto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnallupd.Focus()
        End If
    End Sub

    Private Sub lvwAccountDtls_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwAccountDtls.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEntry.Focus()
        End If
    End Sub

    Private Sub rdAllEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdAllEntry.KeyDown, rdUnPaid.KeyDown, rdPartyWise.KeyDown
        MoveToNextControl(e)
    End Sub
    Private Sub rdDateWise_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdDateWise.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEntry.Focus()
        End If
    End Sub
    Private Sub ReCalcSerial(ByVal ForBarcode As Boolean)
        If IsNothing(Details) Then Exit Sub

        Dim RecRow As DataRow
        Dim LastSrNo As Integer

        For Each RecRow In Details.Rows
            If LastSrNo = 0 Then
                LastSrNo = 1
            Else
                LastSrNo += 1
            End If

            RecRow(gridcols.sr_no) = LastSrNo
        Next RecRow

        Details.AcceptChanges()
    End Sub


    Private Sub dtgdetails_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgdetails.MouseUp
        If dtgdetails.CurrentRowIndex = -1 Then Exit Sub

        dtgdetails.Select(dtgdetails.CurrentRowIndex)
        dtgDetails_Click(dtgdetails, Nothing)
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim formula As New Hashtable
        Dim strFilter As String = ""
        Dim strwhr As String = ""
        Dim select_str As String = ""

        Details = Nothing : dtgdetails.DataSource = Nothing
        DisplayGridHeaders()

        Dim i As Short
        Dim TDS_Key As String = ""

        For i = 0 To lvwAccountDtls.Items.Count - 1
            If lvwAccountDtls.Items(i).Checked Then
                If lvwAccountDtls.Items(i).SubItems(lvwJobchlnDetails.TDS_key).Text > 0 Then
                    If Not RecordExist(lvwAccountDtls.Items(i).SubItems(lvwJobchlnDetails.TDS_key).Text) Then
                        If TDS_Key <> "" Then
                            TDS_Key = TDS_Key & "','" & lvwAccountDtls.Items(i).SubItems(lvwJobchlnDetails.TDS_key).Text
                        Else
                            TDS_Key = lvwAccountDtls.Items(i).SubItems(lvwJobchlnDetails.TDS_key).Text
                        End If
                    End If

                End If
            End If
        Next

        If TDS_Key <> "" Then
            select_str = " And {View_Tds.Tds_Key} in ['" & TDS_Key & "']"
        End If
        If rdUnPaid.Checked = True Then
            strwhr = " And {View_Tds.Challan_no} =''"
        Else
            strwhr = ""
        End If

        formula.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
        formula.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

        strFilter &= " And {View_Tds.Doc_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And {View_Tds.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
        ReportParameters.rptFile = ReportPath & "\Accounts\TDSDetails.rpt"
        ReportParameters.rptFilter = "{View_Tds.CoBr_Id} = '" & SelBranchId & "' " & strFilter & select_str & strwhr

        Dim frmrpt As New frmViewReports(formula)
        frmrpt.Show()

    End Sub
End Class