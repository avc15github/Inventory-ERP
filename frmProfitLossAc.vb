Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmProfitLossAc
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal dtpFromDt1 As Date, ByVal dtpToDt1 As Date, ByVal blnFlag1 As Boolean)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        dtpFromDt = dtpFromDt1
        dtpToDt = dtpToDt1
        blnFlag = blnFlag1
        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents lblFormCaption As System.Windows.Forms.Label
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dtgExps As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCreditAmt As System.Windows.Forms.Label
    Friend WithEvents lblDebitAmt As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFlag As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents dtgIncome As System.Windows.Forms.DataGrid
    Friend WithEvents lblBalAmt As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.dtgIncome = New System.Windows.Forms.DataGrid
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.lblFlag = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDebitAmt = New System.Windows.Forms.Label
        Me.dtgExps = New System.Windows.Forms.DataGrid
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.lblCreditAmt = New System.Windows.Forms.Label
        Me.lblBalAmt = New System.Windows.Forms.Label
        Me.grpMain.SuspendLayout()
        CType(Me.dtgIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgExps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.dtgIncome)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.btnRefresh)
        Me.grpMain.Controls.Add(Me.btnExport)
        Me.grpMain.Controls.Add(Me.lblFlag)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.lblDebitAmt)
        Me.grpMain.Controls.Add(Me.dtgExps)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Controls.Add(Me.lblCreditAmt)
        Me.grpMain.Controls.Add(Me.lblBalAmt)
        Me.grpMain.Location = New System.Drawing.Point(0, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(1077, 607)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'dtgIncome
        '
        Me.dtgIncome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgIncome.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgIncome.DataMember = ""
        Me.dtgIncome.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgIncome.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgIncome.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgIncome.Location = New System.Drawing.Point(540, 64)
        Me.dtgIncome.Name = "dtgIncome"
        Me.dtgIncome.Size = New System.Drawing.Size(535, 502)
        Me.dtgIncome.TabIndex = 124
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnExit.Location = New System.Drawing.Point(994, 572)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 28)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnRefresh.Location = New System.Drawing.Point(877, 572)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 28)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExport.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnExport.Location = New System.Drawing.Point(9, 572)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(81, 28)
        Me.btnExport.TabIndex = 7
        Me.btnExport.Text = "Expor&t"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'lblFlag
        '
        Me.lblFlag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFlag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlag.ForeColor = System.Drawing.Color.Blue
        Me.lblFlag.Location = New System.Drawing.Point(571, 576)
        Me.lblFlag.Name = "lblFlag"
        Me.lblFlag.Size = New System.Drawing.Size(22, 20)
        Me.lblFlag.TabIndex = 123
        Me.lblFlag.Text = "Dr"
        Me.lblFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFlag.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1064, 25)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Profit && Loss A/c"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(159, 579)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 14)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Total "
        Me.Label1.Visible = False
        '
        'lblDebitAmt
        '
        Me.lblDebitAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDebitAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDebitAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebitAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblDebitAmt.Location = New System.Drawing.Point(218, 576)
        Me.lblDebitAmt.Name = "lblDebitAmt"
        Me.lblDebitAmt.Size = New System.Drawing.Size(88, 20)
        Me.lblDebitAmt.TabIndex = 119
        Me.lblDebitAmt.Text = "0"
        Me.lblDebitAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDebitAmt.Visible = False
        '
        'dtgExps
        '
        Me.dtgExps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgExps.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgExps.CaptionText = "P & L A/c"
        Me.dtgExps.DataMember = ""
        Me.dtgExps.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgExps.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgExps.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgExps.Location = New System.Drawing.Point(7, 64)
        Me.dtgExps.Name = "dtgExps"
        Me.dtgExps.Size = New System.Drawing.Size(535, 502)
        Me.dtgExps.TabIndex = 1
        '
        'lblFormCaption
        '
        Me.lblFormCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFormCaption.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormCaption.ForeColor = System.Drawing.Color.Navy
        Me.lblFormCaption.Location = New System.Drawing.Point(8, 8)
        Me.lblFormCaption.Name = "lblFormCaption"
        Me.lblFormCaption.Size = New System.Drawing.Size(1062, 25)
        Me.lblFormCaption.TabIndex = 0
        Me.lblFormCaption.Text = "Profit && Loss Account"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCreditAmt
        '
        Me.lblCreditAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCreditAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCreditAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblCreditAmt.Location = New System.Drawing.Point(336, 576)
        Me.lblCreditAmt.Name = "lblCreditAmt"
        Me.lblCreditAmt.Size = New System.Drawing.Size(88, 20)
        Me.lblCreditAmt.TabIndex = 119
        Me.lblCreditAmt.Text = "0"
        Me.lblCreditAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCreditAmt.Visible = False
        '
        'lblBalAmt
        '
        Me.lblBalAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBalAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBalAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblBalAmt.Location = New System.Drawing.Point(457, 576)
        Me.lblBalAmt.Name = "lblBalAmt"
        Me.lblBalAmt.Size = New System.Drawing.Size(112, 20)
        Me.lblBalAmt.TabIndex = 119
        Me.lblBalAmt.Text = "0"
        Me.lblBalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBalAmt.Visible = False
        '
        'frmProfitLossAc
        '
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1079, 612)
        Me.Controls.Add(Me.grpMain)
        Me.MaximizeBox = False
        Me.Name = "frmProfitLossAc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proft & Loss A/c"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.dtgIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgExps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim cmdCommand As SqlCommand
    Dim sdaAdapter As SqlDataAdapter
    Dim strFilter As String
    Dim dtpFromDt As Date
    Dim dtpToDt As Date
    Dim blnFlag As Boolean
    Dim DtSeries As DataTable
    Dim dtTemp As DataTable
    Dim WithEvents DtExps As DataTable
    Dim WithEvents DtIncm As DataTable
    Dim SMSFields As String = ""
    Dim SMSGrpFields As String = ""
    Dim TotPurch As Double = 0
    Dim TotSales As Double = 0
    Dim TotExps As Double = 0
    Dim TotIncms As Double = 0
    Dim IsGP As Boolean = False
    Dim GrossProfit As Double = 0
    Dim GrossLoss As Double = 0
    Dim NetProfit As Double = 0
    Dim NetLoss As Double = 0

    Enum GridExpsCol
        Disp_Level
        ExpsLed_Name
        Perc
        DtlAmt
        Amount
        AccGrp_Id
        AccLGrp_Key
        Led_Key
    End Enum

    Enum GridIncomeCol
        Disp_Level
        IncomLed_Name
        Perc
        DtlAmt
        Amount
        AccGrp_Id
        AccLGrp_Key
        Led_Key
    End Enum

    Private Sub frmProfitLossAc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.F5 Then
        '    DisplayFill()
        'End If
    End Sub

    Private Sub frmCustAcBillWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If blnFlag = True Then
            DisplayFillExps()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DisplayFillExps()
        Dim DtTable As New DataTable
        Dim Trans As SqlTransaction = Nothing
        DtExps = Nothing : dtgExps.DataSource = Nothing
        DtIncm = Nothing : dtgIncome.DataSource = Nothing
        Dim strVar1 As String = ""
        Dim TotOpStk As Double = 0
        DisplayGridExps()
        dtgExps.CaptionText = "Profit & Loss A/c for the Month of : " & Format$(dtpToDt, "dd/MM/yyyy")

        ''''Rohit 13062017

        Query = "Select 'E0' as Disp_Level, 'Opening Stock' as AccGrp_Name, ACCLGRP.AccLGrp_Name, 'Opening Stock' as Led_Name, Sum(Amount) as Amount, 16 as AccGrp_Id, Ledger.AccLGrp_Key, '' as Led_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id " _
            & " From ClStkDtl Left Join ClStk On ClStkDtl.ClStk_ID = ClStk.ClStk_ID   " _
            & " Left Join Ledger On ClStkDtl.Led_Key = Ledger.Led_Key   " _
            & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
            & " Where Ledger.AccLGrp_Key = '0128' And ClStk_Dt = '" & Format$(AccFromDt, "MM/dd/yyyy") & "' And ClStk.COBR_ID = '" & SelBranchId & "' And ClStk.Fcyr_Id='" & SelYearId & "'" _
            & " Group by ACCLGRP.AccLGrp_Name, Ledger.AccLGrp_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id  " _
            & " Union All " _
            & " Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
            & " case when A.AmtFlag='D' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " FROM vw_GenLedger A " _
            & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
            & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
            & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
            & " WHERE A.COBR_ID = '" & SelBranchId & "' And A.Fcyr_Id='" & SelYearId & "' And ACCGRP.Disp_Level in ('E1','E2') " _
            & " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
            & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " ) as A " _
            & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " ORDER BY Disp_Level, AccLGrp_Name, Led_Name "



        'Query = "Select 'E0' as Disp_Level, 'Opening Stock' as AccGrp_Name, ACCLGRP.AccLGrp_Name, 'Opening Stock' as Led_Name, Sum(Amount) as Amount, 16 as AccGrp_Id, Ledger.AccLGrp_Key, '' as Led_Key,  ClStk.Cobr_Id " _
        '    & " From ClStkDtl Left Join ClStk On ClStkDtl.ClStk_ID = ClStk.ClStk_ID   " _
        '    & " Left Join Ledger On ClStkDtl.Led_Key = Ledger.Led_Key   " _
        '    & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
        '    & " Where Ledger.AccLGrp_Key = '0128' And ClStk_Dt = '" & Format$(AccFromDt, "MM/dd/yyyy") & "' And ClStk.COBR_ID = '" & SelBranchId & "' And ClStk.Fcyr_Id='" & SelYearId & "'" _
        '    & " Group by ACCLGRP.AccLGrp_Name, Ledger.AccLGrp_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id  " _
        '    & " Union All " _
        '    & " Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
        '    & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '    & " case when A.AmtFlag='D' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
        '    & " FROM vw_GenLedger A " _
        '    & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '    & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '    & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '    & " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('E1','E2') " _
        '    & " And A.Doc_Dt  <= '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '    & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
        '    & " ) as A " _
        '    & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
        '    & " ORDER BY Disp_Level, AccLGrp_Name, Led_Name "



        DtTable = Common.GetDataTable(Query)
        Dim PurRow, NewRow As DataRow
        Dim i As Integer
        Dim RowNo As Integer

        For Each PurRow In DtTable.Rows
            NewRow = DtExps.NewRow

            If PurRow("AccGrp_Name") <> strVar1 Then
                TotPurch = 0
                NewRow(GridExpsCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridExpsCol.ExpsLed_Name) = PurRow("AccGrp_Name") & ""
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = 0
                NewRow(GridExpsCol.Amount) = 0

                NewRow(GridExpsCol.AccGrp_Id) = 0
                NewRow(GridExpsCol.AccLGrp_Key) = ""
                NewRow(GridExpsCol.Led_Key) = ""
                RowNo = i

                strVar1 = PurRow("AccGrp_Name")

                DtExps.Rows.Add(NewRow)
                i = i + 1
                DtExps.AcceptChanges()

                NewRow = DtExps.NewRow
                NewRow(GridExpsCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridExpsCol.ExpsLed_Name) = "   " & PurRow("Led_Name") & ""
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = PurRow("Amount")
                NewRow(GridExpsCol.Amount) = 0

                If PurRow("AccGrp_Name") = "Opening Stock" Then
                    TotPurch = TotPurch + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Purchase Account" Then
                    TotPurch = TotPurch + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Direct Expenses" Then
                    TotPurch = TotPurch + PurRow("Amount")
                End If

                NewRow(GridExpsCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridExpsCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridExpsCol.Led_Key) = PurRow("Led_Key")

            Else

                NewRow(GridExpsCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridExpsCol.ExpsLed_Name) = "   " & PurRow("Led_Name") & ""
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = PurRow("Amount")
                NewRow(GridExpsCol.Amount) = 0
                If PurRow("AccGrp_Name") = "Opening Stock" Then
                    TotPurch = TotPurch + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Purchase Account" Then
                    TotPurch = TotPurch + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Direct Expenses" Then
                    TotPurch = TotPurch + PurRow("Amount")
                End If

                NewRow(GridExpsCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridExpsCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridExpsCol.Led_Key) = PurRow("Led_Key")

            End If

                DtExps.Rows.Add(NewRow)
                i = i + 1
                DtExps.AcceptChanges()
                DtExps.Rows(RowNo).Item(GridExpsCol.Amount) = TotPurch
                dtgExps.CurrentRowIndex = DtExps.Rows.Count - 1
        Next PurRow

        DtExps.AcceptChanges()

        IsGP = True
        DisplayFillIncomes()
        IsGP = False
        If DtExps.Rows.Count > 0 Then
            TotExps = DtExps.Compute("Sum(Amount)", "")
        End If


        '*************GP C/F
        If DtExps.Rows.Count > 0 Then
            NewRow = DtExps.NewRow

            NewRow(GridExpsCol.Disp_Level) = ""
            If (TotIncms - TotExps) > 0 Then
                NewRow(GridExpsCol.ExpsLed_Name) = "Gross Proft C/F"
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = 0
                NewRow(GridExpsCol.Amount) = (TotIncms - TotExps)
                GrossProfit = (TotIncms - TotExps)
            Else
                NewRow(GridExpsCol.ExpsLed_Name) = ""
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = 0
                NewRow(GridExpsCol.Amount) = 0
            End If

            NewRow(GridExpsCol.AccGrp_Id) = 0
            NewRow(GridExpsCol.AccLGrp_Key) = ""
            NewRow(GridExpsCol.Led_Key) = ""

            DtExps.Rows.Add(NewRow)
            DtExps.AcceptChanges()

            NewRow = DtExps.NewRow
            NewRow(GridExpsCol.Disp_Level) = ""
            NewRow(GridExpsCol.ExpsLed_Name) = "TOTAL"
            NewRow(GridExpsCol.Perc) = 0
            NewRow(GridExpsCol.DtlAmt) = 0
            NewRow(GridExpsCol.Amount) = IIf((TotIncms - TotExps) > 0, TotIncms, TotExps)

            NewRow(GridExpsCol.AccGrp_Id) = 0
            NewRow(GridExpsCol.AccLGrp_Key) = ""
            NewRow(GridExpsCol.Led_Key) = ""

            DtExps.Rows.Add(NewRow)
            DtExps.AcceptChanges()
        End If

        '**************'*-*-*GrossLoss

        If DtExps.Rows.Count > 0 Then
            NewRow = DtExps.NewRow

            NewRow(GridExpsCol.Disp_Level) = ""
            NewRow(GridExpsCol.ExpsLed_Name) = ""
            NewRow(GridExpsCol.Perc) = 0
            NewRow(GridExpsCol.DtlAmt) = 0
            NewRow(GridExpsCol.Amount) = 0

            NewRow(GridExpsCol.AccGrp_Id) = 0
            NewRow(GridExpsCol.AccLGrp_Key) = ""
            NewRow(GridExpsCol.Led_Key) = ""

            DtExps.Rows.Add(NewRow)
            DtExps.AcceptChanges()

            '**** G/L
            NewRow = DtExps.NewRow

            NewRow(GridExpsCol.Disp_Level) = ""
            If GrossLoss > 0 Then
                NewRow(GridExpsCol.ExpsLed_Name) = "Gross Loss B/F"
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = 0
                NewRow(GridExpsCol.Amount) = GrossLoss
            Else
                NewRow(GridExpsCol.ExpsLed_Name) = ""
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = 0
                NewRow(GridExpsCol.Amount) = 0
            End If

            NewRow(GridExpsCol.AccGrp_Id) = 0
            NewRow(GridExpsCol.AccLGrp_Key) = ""
            NewRow(GridExpsCol.Led_Key) = ""

            DtExps.Rows.Add(NewRow)
            DtExps.AcceptChanges()
        End If

        '*-*-*GrossProfit
        If DtIncm.Rows.Count > 0 Then
            NewRow = DtIncm.NewRow

            NewRow(GridIncomeCol.Disp_Level) = ""
            NewRow(GridIncomeCol.IncomLed_Name) = ""
            NewRow(GridIncomeCol.Perc) = 0
            NewRow(GridIncomeCol.DtlAmt) = 0
            NewRow(GridIncomeCol.Amount) = 0

            NewRow(GridIncomeCol.AccGrp_Id) = 0
            NewRow(GridIncomeCol.AccLGrp_Key) = ""
            NewRow(GridIncomeCol.Led_Key) = ""

            DtIncm.Rows.Add(NewRow)
            DtIncm.AcceptChanges()

            '**** G/P
            NewRow = DtIncm.NewRow

            NewRow(GridIncomeCol.Disp_Level) = ""
            If GrossProfit > 0 Then
                NewRow(GridIncomeCol.IncomLed_Name) = "Gross Proft B/F"
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = 0
                NewRow(GridIncomeCol.Amount) = GrossProfit
            Else
                NewRow(GridIncomeCol.IncomLed_Name) = ""
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = 0
                NewRow(GridIncomeCol.Amount) = 0
            End If

            NewRow(GridIncomeCol.AccGrp_Id) = 0
            NewRow(GridIncomeCol.AccLGrp_Key) = ""
            NewRow(GridIncomeCol.Led_Key) = ""

            DtIncm.Rows.Add(NewRow)
            DtIncm.AcceptChanges()
        End If

        '**********Indirect Exps
        '''Rohit 13032016
        Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
            & " case when A.AmtFlag='D' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " FROM vw_GenLedger A " _
            & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
            & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
            & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
            & " WHERE A.COBR_ID = '" & SelBranchId & "' And A.Fcyr_Id='" & SelYearId & "' And ACCGRP.Disp_Level in ('E3') " _
            & " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
            & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " ) as A " _
            & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " ORDER BY A.Disp_Level, A.AccLGrp_Name, A.Led_Name "

        'Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
        '    & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '    & " case when A.AmtFlag='D' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
        '    & " FROM vw_GenLedger A " _
        '    & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '    & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '    & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '    & " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('E3') " _
        '    & " And A.Doc_Dt <= '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '    & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
        '    & " ) as A " _
        '    & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
        '    & " ORDER BY A.Disp_Level, A.AccLGrp_Name, A.Led_Name "

        DtTable = Common.GetDataTable(Query)

        i = DtExps.Rows.Count
        For Each PurRow In DtTable.Rows
            NewRow = DtExps.NewRow

            If PurRow("AccGrp_Name") <> strVar1 Then
                TotPurch = 0
                NewRow(GridExpsCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridExpsCol.ExpsLed_Name) = PurRow("AccGrp_Name") & ""
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = 0
                NewRow(GridExpsCol.Amount) = 0

                NewRow(GridExpsCol.AccGrp_Id) = 0
                NewRow(GridExpsCol.AccLGrp_Key) = ""
                NewRow(GridExpsCol.Led_Key) = ""
                RowNo = i

                strVar1 = PurRow("AccGrp_Name")

                DtExps.Rows.Add(NewRow)
                i = i + 1
                DtExps.AcceptChanges()

                NewRow = DtExps.NewRow
                NewRow(GridExpsCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridExpsCol.ExpsLed_Name) = "   " & PurRow("Led_Name") & ""
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = PurRow("Amount")
                NewRow(GridExpsCol.Amount) = 0
                If PurRow("AccGrp_Name") = "Indirect Expenses" Then
                    TotPurch = TotPurch + PurRow("Amount")
                End If

                NewRow(GridExpsCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridExpsCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridExpsCol.Led_Key) = PurRow("Led_Key")

            Else

                NewRow(GridExpsCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridExpsCol.ExpsLed_Name) = "   " & PurRow("Led_Name") & ""
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = PurRow("Amount")
                NewRow(GridExpsCol.Amount) = 0
                If PurRow("AccGrp_Name") = "Indirect Expenses" Then
                    TotPurch = TotPurch + PurRow("Amount")
                End If

                NewRow(GridExpsCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridExpsCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridExpsCol.Led_Key) = PurRow("Led_Key")

            End If

            DtExps.Rows.Add(NewRow)
            i = i + 1
            DtExps.AcceptChanges()
            DtExps.Rows(RowNo).Item(GridExpsCol.Amount) = TotPurch
            dtgExps.CurrentRowIndex = DtExps.Rows.Count - 1
        Next PurRow

        DtExps.AcceptChanges()

        '****Indirect Income
        '''Rohit 13062017
        Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
            & " case when A.AmtFlag='C' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " FROM vw_GenLedger A " _
            & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
            & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
            & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
            & " WHERE A.COBR_ID = '" & SelBranchId & "' And A.Fcyr_Id='" & SelYearId & "' And ACCGRP.Disp_Level in ('I3')  " _
            & " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
            & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " ) as A " _
            & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " ORDER BY A.Disp_Level, A.AccLGrp_Name, A.Led_Name "


        'Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
        '    & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '    & " case when A.AmtFlag='C' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
        '    & " FROM vw_GenLedger A " _
        '    & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '    & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '    & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '    & " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('I3')  " _
        '    & " And A.Doc_Dt <= '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '    & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Cobr_Id " _
        '    & " ) as A " _
        '    & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Cobr_Id " _
        '    & " ORDER BY A.Disp_Level, A.AccLGrp_Name, A.Led_Name "


        DtTable = Common.GetDataTable(Query)
        i = DtIncm.Rows.Count

        For Each PurRow In DtTable.Rows
            NewRow = DtIncm.NewRow

            If PurRow("AccGrp_Name") <> strVar1 Then
                TotSales = 0
                NewRow(GridIncomeCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridIncomeCol.IncomLed_Name) = PurRow("AccGrp_Name") & ""
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = 0
                NewRow(GridIncomeCol.Amount) = 0

                NewRow(GridIncomeCol.AccGrp_Id) = 0
                NewRow(GridIncomeCol.AccLGrp_Key) = ""
                NewRow(GridIncomeCol.Led_Key) = ""
                RowNo = i

                strVar1 = PurRow("AccGrp_Name")

                DtIncm.Rows.Add(NewRow)
                i = i + 1
                DtExps.AcceptChanges()

                NewRow = DtIncm.NewRow
                NewRow(GridIncomeCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridIncomeCol.IncomLed_Name) = "   " & PurRow("Led_Name") & ""
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = PurRow("Amount")
                NewRow(GridIncomeCol.Amount) = 0
                If PurRow("AccGrp_Name") = "Indirect Income" Then
                    TotSales = TotSales + PurRow("Amount")
                End If

                NewRow(GridIncomeCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridIncomeCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridIncomeCol.Led_Key) = PurRow("Led_Key")

            Else

                NewRow(GridIncomeCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridIncomeCol.IncomLed_Name) = "   " & PurRow("Led_Name") & ""
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = PurRow("Amount")
                NewRow(GridIncomeCol.Amount) = 0
                If PurRow("AccGrp_Name") = "Indirect Income" Then
                    TotSales = TotSales + PurRow("Amount")
                End If

                NewRow(GridIncomeCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridIncomeCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridIncomeCol.Led_Key) = PurRow("Led_Key")

            End If

            DtIncm.Rows.Add(NewRow)
            i = i + 1
            DtIncm.AcceptChanges()
            DtIncm.Rows(RowNo).Item(GridIncomeCol.Amount) = TotSales
            dtgIncome.CurrentRowIndex = DtIncm.Rows.Count - 1
        Next PurRow

        DtIncm.AcceptChanges()

        '*************NP C/F
        If DtExps.Rows.Count > 0 Then
            NewRow = DtExps.NewRow

            NewRow(GridExpsCol.Disp_Level) = ""
            If ((GrossProfit + TotSales) - (GrossLoss + TotPurch)) > 0 Then
                NewRow(GridExpsCol.ExpsLed_Name) = "Net Proft"
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = 0
                'NewRow(GridExpsCol.Amount) = ((GrossProfit + TotSales) - (GrossLoss + TotPurch))
                'NetProfit = ((GrossProfit + TotSales) - (GrossLoss + TotPurch))
                NewRow(GridExpsCol.Amount) = ((GrossProfit) - (TotPurch))
                NetProfit = ((GrossProfit) - ( TotPurch))
            Else
                NewRow(GridExpsCol.ExpsLed_Name) = ""
                NewRow(GridExpsCol.Perc) = 0
                NewRow(GridExpsCol.DtlAmt) = 0
                NewRow(GridExpsCol.Amount) = 0
            End If

            NewRow(GridExpsCol.AccGrp_Id) = 0
            NewRow(GridExpsCol.AccLGrp_Key) = ""
            NewRow(GridExpsCol.Led_Key) = ""

            DtExps.Rows.Add(NewRow)
            DtExps.AcceptChanges()

            NewRow = DtExps.NewRow
            NewRow(GridExpsCol.Disp_Level) = ""
            NewRow(GridExpsCol.ExpsLed_Name) = "TOTAL"
            NewRow(GridExpsCol.Perc) = 0
            NewRow(GridExpsCol.DtlAmt) = 0
            NewRow(GridExpsCol.Amount) = IIf(((GrossProfit + TotSales) - (GrossLoss + TotPurch)) > 0, (GrossProfit + TotSales), (GrossLoss + TotPurch))
            ' NewRow(GridExpsCol.Amount) = IIf(((GrossProfit) - (TotPurch)) > 0, (GrossProfit), (TotPurch))

            NewRow(GridExpsCol.AccGrp_Id) = 0
            NewRow(GridExpsCol.AccLGrp_Key) = ""
            NewRow(GridExpsCol.Led_Key) = ""

            DtExps.Rows.Add(NewRow)
            DtExps.AcceptChanges()
        End If

        Dim BlankRows As Integer = (DtExps.Rows.Count) - (DtIncm.Rows.Count)
        i = 3
        For var = i To BlankRows
            NewRow = DtIncm.NewRow

            NewRow(GridIncomeCol.Disp_Level) = ""
            NewRow(GridIncomeCol.IncomLed_Name) = ""
            NewRow(GridIncomeCol.Perc) = 0
            NewRow(GridIncomeCol.DtlAmt) = 0
            NewRow(GridIncomeCol.Amount) = 0

            NewRow(GridIncomeCol.AccGrp_Id) = 0
            NewRow(GridIncomeCol.AccLGrp_Key) = ""
            NewRow(GridIncomeCol.Led_Key) = ""
            RowNo = i

            DtIncm.Rows.Add(NewRow)
            i = i + 1
            DtIncm.AcceptChanges()

        Next var

        '*************NL C/F
        If DtIncm.Rows.Count > 0 Then
            NewRow = DtIncm.NewRow

            NewRow(GridIncomeCol.Disp_Level) = ""
            If ((GrossLoss + TotPurch) - (GrossProfit + TotSales)) > 0 Then
                NewRow(GridIncomeCol.IncomLed_Name) = "Net Loss"
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = 0
                'NewRow(GridIncomeCol.Amount) = ((GrossLoss + TotPurch) - (GrossProfit + TotSales))
                'NetLoss = ((GrossLoss + TotPurch) - (GrossProfit + TotSales))
                NewRow(GridIncomeCol.Amount) = ((GrossLoss + TotPurch) - (GrossProfit + TotSales))
                NetLoss = ((GrossLoss + TotPurch) - (GrossProfit + TotSales))
            Else
                NewRow(GridIncomeCol.IncomLed_Name) = ""
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = 0
                NewRow(GridIncomeCol.Amount) = 0
            End If

            NewRow(GridIncomeCol.AccGrp_Id) = 0
            NewRow(GridIncomeCol.AccLGrp_Key) = ""
            NewRow(GridIncomeCol.Led_Key) = ""

            DtIncm.Rows.Add(NewRow)
            DtIncm.AcceptChanges()

            NewRow = DtIncm.NewRow
            NewRow(GridIncomeCol.Disp_Level) = ""
            NewRow(GridIncomeCol.IncomLed_Name) = "TOTAL"
            NewRow(GridIncomeCol.Perc) = 0
            NewRow(GridIncomeCol.DtlAmt) = 0
            NewRow(GridIncomeCol.Amount) = IIf(((GrossLoss + TotPurch) - (GrossProfit + TotSales)) > 0, (GrossLoss + TotPurch), (GrossProfit + TotSales))

            NewRow(GridIncomeCol.AccGrp_Id) = 0
            NewRow(GridIncomeCol.AccLGrp_Key) = ""
            NewRow(GridIncomeCol.Led_Key) = ""

            DtIncm.Rows.Add(NewRow)
            DtIncm.AcceptChanges()
        End If

        If NetProfit > 0 Then
            Query = "Update Ledger Set ClBal= " & NetProfit _
                    & " Where Led_Key in (Select Led_Key from Ledger where AccLgrp_Key='0127')"
            Common.ExecuteQuery(Query, Trans)
        ElseIf NetLoss > 0 Then
            Query = "Update Ledger Set ClBal= 0 - " & NetLoss _
                    & " Where Led_Key in (Select Led_Key from Ledger where AccLgrp_Key='0127')"
            Common.ExecuteQuery(Query, Trans)
        End If

        If DtExps.Rows.Count > 0 Then
            dtgExps.CurrentRowIndex = 0
            dtgExps.Focus()
            dtgExps.Select(dtgExps.CurrentCell.RowNumber)
        End If
        If DtIncm.Rows.Count > 0 Then
            dtgIncome.CurrentRowIndex = 0
            dtgIncome.Focus()
            dtgIncome.Select(dtgIncome.CurrentCell.RowNumber)
        End If

    End Sub

    Private Sub DisplayFillIncomes()
        Dim DtTable As New DataTable
        'DtIncm = Nothing : dtgIncome.DataSource = Nothing
        Dim strVar1 As String = ""
        Dim TotOpStk As Double = 0
        DisplayGridIncome()


        ''''Rohit 13062017
        Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
            & " case when A.AmtFlag='C' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " FROM vw_GenLedger A " _
            & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
            & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
            & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
            & " WHERE A.COBR_ID = '" & SelBranchId & "' And A.Fcyr_Id='" & SelYearId & "' And ACCGRP.Disp_Level in ('I1','I2')  " _
            & " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
            & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " ) as A " _
            & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
            & " Union All " _
            & " Select 'I4' as Disp_Level, 'Closing Stock' as AccGrp_Name, ACCLGRP.AccLGrp_Name, 'Closing Stock' as Led_Name, Sum(Amount) as Amount, 4 as AccGrp_Id, Ledger.AccLGrp_Key, '' as Led_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id " _
            & " From ClStkDtl Left Join ClStk On ClStkDtl.ClStk_ID = ClStk.ClStk_ID   " _
            & " Left Join Ledger On ClStkDtl.Led_Key = Ledger.Led_Key   " _
            & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
            & " Where Ledger.AccLGrp_Key = '0128' And ClStk_Dt = '" & Format$(AccToDt, "MM/dd/yyyy") & "' And ClStk.COBR_ID = '" & SelBranchId & "' And ClStk.Fcyr_Id='" & SelYearId & "'" _
            & " Group by ACCLGRP.AccLGrp_Name, Ledger.AccLGrp_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id  " _
            & " ORDER BY Disp_Level, AccLGrp_Name, Led_Name  "

        'Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
        '    & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '    & " case when A.AmtFlag='C' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
        '    & " FROM vw_GenLedger A " _
        '    & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '    & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '    & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '    & " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('I1','I2')  " _
        '    & " And A.Doc_Dt <= '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '    & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
        '    & " ) as A " _
        '    & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
        '    & " Union All " _
        '    & " Select 'I4' as Disp_Level, 'Closing Stock' as AccGrp_Name, ACCLGRP.AccLGrp_Name, 'Closing Stock' as Led_Name, Sum(Amount) as Amount, 4 as AccGrp_Id, Ledger.AccLGrp_Key, '' as Led_Key,  ClStk.Cobr_Id " _
        '    & " From ClStkDtl Left Join ClStk On ClStkDtl.ClStk_ID = ClStk.ClStk_ID   " _
        '    & " Left Join Ledger On ClStkDtl.Led_Key = Ledger.Led_Key   " _
        '    & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
        '    & " Where Ledger.AccLGrp_Key = '0128' And ClStk_Dt = '" & Format$(AccToDt, "MM/dd/yyyy") & "' And ClStk.COBR_ID = '" & SelBranchId & "' And ClStk.Fcyr_Id='" & SelYearId & "'" _
        '    & " Group by ACCLGRP.AccLGrp_Name, Ledger.AccLGrp_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id  " _
        '    & " ORDER BY Disp_Level, AccLGrp_Name, Led_Name  "

        DtTable = Common.GetDataTable(Query)
        Dim PurRow, NewRow As DataRow
        Dim var As Integer
        Dim i As Integer
        Dim RowNo As Integer

        For Each PurRow In DtTable.Rows
            NewRow = DtIncm.NewRow

            If PurRow("AccGrp_Name") <> strVar1 Then
                TotSales = 0
                NewRow(GridIncomeCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridIncomeCol.IncomLed_Name) = PurRow("AccGrp_Name") & ""
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = 0
                NewRow(GridIncomeCol.Amount) = 0

                NewRow(GridIncomeCol.AccGrp_Id) = 0
                NewRow(GridIncomeCol.AccLGrp_Key) = ""
                NewRow(GridIncomeCol.Led_Key) = ""
                RowNo = i

                strVar1 = PurRow("AccGrp_Name")

                DtIncm.Rows.Add(NewRow)
                i = i + 1
                DtExps.AcceptChanges()

                NewRow = DtIncm.NewRow
                NewRow(GridIncomeCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridIncomeCol.IncomLed_Name) = "   " & PurRow("Led_Name") & ""
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = PurRow("Amount")
                NewRow(GridIncomeCol.Amount) = 0
                If PurRow("AccGrp_Name") = "Sales Account" Then
                    TotSales = TotSales + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Direct Income" Then
                    TotSales = TotSales + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Closing Stock" Then
                    TotSales = TotSales + PurRow("Amount")
                End If

                NewRow(GridIncomeCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridIncomeCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridIncomeCol.Led_Key) = PurRow("Led_Key")

            Else

                NewRow(GridIncomeCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridIncomeCol.IncomLed_Name) = "   " & PurRow("Led_Name") & ""
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = PurRow("Amount")
                NewRow(GridIncomeCol.Amount) = 0
                If PurRow("AccGrp_Name") = "Sales Account" Then
                    TotSales = TotSales + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Direct Income" Then
                    TotSales = TotSales + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Closing Stock" Then
                    TotSales = TotSales + PurRow("Amount")
                End If

                NewRow(GridIncomeCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridIncomeCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridIncomeCol.Led_Key) = PurRow("Led_Key")

                End If

            DtIncm.Rows.Add(NewRow)
            i = i + 1
            DtIncm.AcceptChanges()
            DtIncm.Rows(RowNo).Item(GridIncomeCol.Amount) = TotSales
            dtgIncome.CurrentRowIndex = DtIncm.Rows.Count - 1
        Next PurRow

        DtIncm.AcceptChanges()

        Dim BlankRows As Integer = (DtExps.Rows.Count) - (DtIncm.Rows.Count)
        If IsGP = True Then
            i = 1
            For var = i To BlankRows
                NewRow = DtIncm.NewRow

                NewRow(GridIncomeCol.Disp_Level) = ""
                NewRow(GridIncomeCol.IncomLed_Name) = ""
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = 0
                NewRow(GridIncomeCol.Amount) = 0

                NewRow(GridIncomeCol.AccGrp_Id) = 0
                NewRow(GridIncomeCol.AccLGrp_Key) = ""
                NewRow(GridIncomeCol.Led_Key) = ""
                RowNo = i

                DtIncm.Rows.Add(NewRow)
                i = i + 1
                DtIncm.AcceptChanges()

            Next var

            TotIncms = DtIncm.Compute("Sum(Amount)", "")

            If DtIncm.Rows.Count > 0 Then
                NewRow = DtIncm.NewRow

                NewRow(GridIncomeCol.Disp_Level) = ""
                If (TotExps - TotIncms) > 0 Then
                    NewRow(GridIncomeCol.IncomLed_Name) = "Gross Loss C/F"
                    NewRow(GridIncomeCol.Perc) = 0
                    NewRow(GridIncomeCol.DtlAmt) = 0
                    NewRow(GridIncomeCol.Amount) = (TotExps - TotIncms)
                    GrossLoss = (TotExps - TotIncms)
                Else
                    NewRow(GridIncomeCol.IncomLed_Name) = ""
                    NewRow(GridIncomeCol.Perc) = 0
                    NewRow(GridIncomeCol.DtlAmt) = 0
                    NewRow(GridIncomeCol.Amount) = 0
                    End If

                NewRow(GridIncomeCol.AccGrp_Id) = 0
                NewRow(GridIncomeCol.AccLGrp_Key) = ""
                NewRow(GridIncomeCol.Led_Key) = ""

                DtIncm.Rows.Add(NewRow)
                DtIncm.AcceptChanges()

                NewRow = DtIncm.NewRow
                NewRow(GridIncomeCol.Disp_Level) = ""
                NewRow(GridIncomeCol.IncomLed_Name) = "TOTAL"
                NewRow(GridIncomeCol.Perc) = 0
                NewRow(GridIncomeCol.DtlAmt) = 0
                NewRow(GridIncomeCol.Amount) = IIf((TotExps - TotIncms) > 0, TotExps, TotIncms)

                NewRow(GridIncomeCol.AccGrp_Id) = 0
                NewRow(GridIncomeCol.AccLGrp_Key) = ""
                NewRow(GridIncomeCol.Led_Key) = ""

                DtIncm.Rows.Add(NewRow)
                DtIncm.AcceptChanges()
                End If
            IsGP = False
            End If

            '**************

        dtgIncome.CurrentRowIndex = 0
        dtgIncome.Focus()
        dtgIncome.Select(dtgIncome.CurrentCell.RowNumber)
    End Sub

    Private Sub dtgExps_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgExps.MouseUp
        Try
            dtgExps.Select(dtgExps.CurrentCell.RowNumber)
        Catch ex As IndexOutOfRangeException
            Exit Sub
        End Try
    End Sub

    Private Sub dtgExps_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgExps.DoubleClick
        Dim strPartyKey, strPartyNm As String
        Dim dtMonthlyDate As Date
        If dtgExps.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        strPartyKey = dtgExps.Item(dtgExps.CurrentRowIndex, 7)
        strPartyNm = dtgExps.Item(dtgExps.CurrentRowIndex, 1)
        dtMonthlyDate = dtpToDt
        BalanceSheet = False
        DtpBalSheetToDate = dtpFromDt
        If strPartyKey <> "" Then
            Dim frmCustAcMonthly As New frmCustAcMonthly(strPartyKey, strPartyNm, dtMonthlyDate, True)
            frmCustAcMonthly.MdiParent = Me.MdiParent
            frmCustAcMonthly.Tag = "CustAcMonthly"
            frmCustAcMonthly.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub dtgExps_MouseDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgExps.MouseDoubleClick
        Dim strPartyKey, strPartyNm As String
        Dim dtMonthlyDate As Date
        If dtgExps.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        strPartyKey = dtgExps.Item(dtgExps.CurrentRowIndex, 7)
        strPartyNm = dtgExps.Item(dtgExps.CurrentRowIndex, 1)
        dtMonthlyDate = dtpToDt
        BalanceSheet = False
        DtpBalSheetToDate = dtpFromDt
        If strPartyKey <> "" Then
            Dim frmCustAcMonthly As New frmCustAcMonthly(strPartyKey, strPartyNm, dtMonthlyDate, True)
            frmCustAcMonthly.MdiParent = Me.MdiParent
            frmCustAcMonthly.Tag = "CustAcMonthly"
            frmCustAcMonthly.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgExps_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgExps.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgExps_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtgIncome_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgIncome.MouseUp
        Try
            dtgIncome.Select(dtgIncome.CurrentCell.RowNumber)
        Catch ex As IndexOutOfRangeException
            Exit Sub
        End Try
    End Sub

    Private Sub dtgIncome_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgIncome.DoubleClick
        Dim strPartyKey, strPartyNm As String
        Dim dtMonthlyDate As Date
        If dtgIncome.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        strPartyKey = dtgIncome.Item(dtgIncome.CurrentRowIndex, 7)
        strPartyNm = dtgIncome.Item(dtgIncome.CurrentRowIndex, 1)
        dtMonthlyDate = dtpToDt
        BalanceSheet = False
        DtpBalSheetToDate = dtpFromDt
        If strPartyKey <> "" Then
            Dim frmCustAcMonthly As New frmCustAcMonthly(strPartyKey, strPartyNm, dtMonthlyDate, True)
            frmCustAcMonthly.MdiParent = Me.MdiParent
            frmCustAcMonthly.Tag = "CustAcMonthly"
            frmCustAcMonthly.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub dtgIncome_MouseDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgIncome.MouseDoubleClick
        Dim strPartyKey, strPartyNm As String
        Dim dtMonthlyDate As Date
        If dtgIncome.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        strPartyKey = dtgIncome.Item(dtgIncome.CurrentRowIndex, 7)
        strPartyNm = dtgIncome.Item(dtgIncome.CurrentRowIndex, 1)
        dtMonthlyDate = dtpToDt
        BalanceSheet = False
        DtpBalSheetToDate = dtpFromDt
        If strPartyKey <> "" Then
            Dim frmCustAcMonthly As New frmCustAcMonthly(strPartyKey, strPartyNm, dtMonthlyDate, True)
            frmCustAcMonthly.MdiParent = Me.MdiParent
            frmCustAcMonthly.Tag = "CustAcMonthly"
            frmCustAcMonthly.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgIncome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgIncome.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgIncome_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub frmCustAcBillWise_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If blnFlag = False Then
            DisplayFillExps()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'If keyData = Keys.Enter Then
        '    If Me.ActiveControl.Parent Is CType(dtgPartyAc, DataGrid) Or Me.ActiveControl Is CType(dtgPartyAc, DataGrid) Then
        '        Call dtgPartyAc_DoubleClick(Nothing, Nothing)
        '    End If
        'End If
    End Function

    Private Sub DisplayGridExps()
        Dim Grid As New GridColumnCreateAndFormat("Expenses")

        With Grid
            .AddColumn("Disp_Level", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("ExpsLed_Name", GridColumnCreateAndFormat.enmTypeIdx.StringType, 268, "Expenses")
            .AddColumn("Perc", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "%")
            .AddColumn("DtlAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 110, "")
            .AddColumn("Amount", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 120, "Amount.")
            .AddColumn("AccGrp_Id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "")
            .AddColumn("AccLGrp_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("Led_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")

            .AddColumnToTable()
            DtExps = .GetTable
            DtExps.DefaultView.AllowNew = False
            DtExps.DefaultView.AllowEdit = True
            DtExps.DefaultView.AllowDelete = False

            dtgExps.DataSource = DtExps
            .DisplayGridHeaders(DtExps, dtgExps, False)
        End With
    End Sub

    Private Sub DisplayGridIncome()
        Dim Grid As New GridColumnCreateAndFormat("Incomes")

        With Grid
            .AddColumn("Disp_Level", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("IncomLed_Name", GridColumnCreateAndFormat.enmTypeIdx.StringType, 268, "Income")
            .AddColumn("Perc", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "%")
            .AddColumn("DtlAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 110, "")
            .AddColumn("Amount", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 120, "Amount.")
            .AddColumn("AccGrp_Id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "")
            .AddColumn("AccLGrp_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("Led_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")

            .AddColumnToTable()
            DtIncm = .GetTable
            DtIncm.DefaultView.AllowNew = False
            DtIncm.DefaultView.AllowEdit = True
            DtIncm.DefaultView.AllowDelete = False

            dtgIncome.DataSource = DtIncm
            .DisplayGridHeaders(DtIncm, dtgIncome, False)
        End With
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        DisplayFillExps()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If DtExps.Columns.Count = 0 Then Exit Sub

        Dim r As Integer = 5
        Dim c As Byte = 1
        Dim txtFormat As New ArrayList
        Dim colFormat As New ArrayList

        Dim xlApp As New Excel.Application
        Dim xlBook As Excel.Workbook = xlApp.Workbooks.Add
        Dim xlSheet As Excel.Worksheet = xlBook.ActiveSheet
        Dim n As Integer = 9

        Query = " Select Cobr_Name, RegdAdd, Stn_Name, TelNo, FaxNo, Email " _
            & " From Cobr " _
            & " Left Join Station on Cobr.Stn_Key=Station.Stn_Key " _
            & " Where Cobr.Cobr_Id ='" & SelBranchId & "'"
        Dim DtTable As DataTable = Common.GetDataTable(Query)

        If DtTable.Rows.Count > 0 Then
            xlSheet.Cells(1, 1) = DtTable.Rows(0).Item("Cobr_Name") & "-(" & DtTable.Rows(0).Item("Stn_Name") & ")"
            xlSheet.Range("A1:H1").Font.Bold = True
            xlSheet.Range("A1:H1").Font.Size = 16
            xlSheet.Cells(2, 1) = "Add : " & DtTable.Rows(0).Item("RegdAdd")
            xlSheet.Range("A2:F2").MergeCells = True
            xlSheet.Range("A2:F2").RowHeight = 35
            xlSheet.Cells(3, 1) = "Phone : " & DtTable.Rows(0).Item("TelNo") & IIf(DtTable.Rows(0).Item("FaxNo") <> "", " Fax : " & DtTable.Rows(0).Item("FaxNo"), "") & " Email : " & DtTable.Rows(0).Item("Email")
        End If

        xlSheet.Cells(4, 1) = "FIN. YEAR : " & Format$(dtpFromDt, "dd/MM/yyyy") & " - " & Format$(dtpToDt, "dd/MM/yyyy")
        xlSheet.Range("A4:H4").Font.Bold = True
        xlSheet.Range("A4:H4").Font.Size = 12
        xlSheet.Cells(5, 1) = "PROFIT AND LOSS ACCOUNT"
        xlSheet.Range("A5:H5").Font.Bold = True
        xlSheet.Range("A5:H5").Font.Size = 14
        'xlSheet.Cells(7, 1) = strPartyNm
        'xlSheet.Range("A7:H7").Font.Bold = True
        'xlSheet.Range("A7:H7").Font.Underline = True
        'xlSheet.Range("A7:H7").Font.Size = 12

        With xlSheet
            .Range("A8:A8").Value = "EXPENSES"
            .Range("B8:B8").Value = ""
            .Range("C8:C8").Value = "AMOUNT"
            .Range("B8:C8").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            .Range("D8:D8").Value = "INCOME"
            .Range("E8:E8").Value = ""
            .Range("F8:F8").Value = "AMOUNT"
            .Range("D8:F8").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        End With

        Dim RecRow As DataRow

        For Each RecRow In DtExps.Rows
            With xlSheet
                .Range("A" & n & ":A" & n).Value = RecRow("ExpsLed_Name") & ""
                .Range("B" & n & ":B" & n).Value = IIf(Format$(RecRow("DtlAmt"), "0.00") <> 0, Format$(RecRow("DtlAmt"), "0.00"), "")
                .Range("C" & n & ":C" & n).Value = IIf(Format$(RecRow("Amount"), "0.00") <> 0, Format$(RecRow("Amount"), "0.00"), "")
                If RecRow("AccGrp_Id") = 0 Then
                    .Range("A" & n & ":C" & n).Font.Bold = True
                End If
            End With
            n += 1
        Next RecRow

        'n += 1
        'xlSheet.Range("A" & n & ":A" & n).Value = "Total"
        'xlSheet.Range("B" & n & ":B" & n).Value = lblDebitAmt.Text
        'xlSheet.Range("C" & n & ":C" & n).Value = lblCreditAmt.Text
        'xlSheet.Range("D" & n & ":D" & n).Value = lblBalAmt.Text
        'xlSheet.Range("E" & n & ":E" & n).Value = lblFlag.Text
        'xlSheet.Range("A" & n & ":E" & n).Font.Bold = True

        n = 9
        For Each RecRow In DtIncm.Rows
            With xlSheet
                .Range("D" & n & ":D" & n).Value = RecRow("IncomLed_Name") & ""
                .Range("E" & n & ":E" & n).Value = IIf(Format$(RecRow("DtlAmt"), "0.00") <> 0, Format$(RecRow("DtlAmt"), "0.00"), "")
                .Range("F" & n & ":F" & n).Value = IIf(Format$(RecRow("Amount"), "0.00") <> 0, Format$(RecRow("Amount"), "0.00"), "")
                If RecRow("AccGrp_Id") = 0 Then
                    .Range("D" & n & ":F" & n).Font.Bold = True
                End If
            End With
            n += 1
        Next RecRow

        xlSheet.Range("A8:F8").Font.Bold = True
        xlSheet.Range("A:A").ColumnWidth = 35
        xlSheet.Range("B:C").ColumnWidth = 14
        xlSheet.Range("D:D").ColumnWidth = 35
        xlSheet.Range("E:F").ColumnWidth = 18

        For Each obj As Object In colFormat
            xlSheet.Range(obj & ":" & obj).NumberFormat = "0.00"
        Next obj

        For Each obj As Object In txtFormat
            xlSheet.Range(obj & ":" & obj).NumberFormat = "@"
        Next obj

        'xlSheet.Columns.AutoFit()
        'Dim strExportFile As String = Application.StartupPath & "\" & "MonthlyLedger.xls"
        'xlSheet.SaveAs(strExportFile)
        xlApp.Visible = True
        xlSheet = Nothing : xlBook = Nothing : xlApp = Nothing
    End Sub

    
End Class