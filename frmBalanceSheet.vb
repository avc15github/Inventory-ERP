Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmBalanceSheet
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
    Friend WithEvents dtgLiabs As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCreditAmt As System.Windows.Forms.Label
    Friend WithEvents lblDebitAmt As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFlag As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents dtgAssets As System.Windows.Forms.DataGrid
    Friend WithEvents lblBalAmt As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.dtgAssets = New System.Windows.Forms.DataGrid
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.lblFlag = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDebitAmt = New System.Windows.Forms.Label
        Me.dtgLiabs = New System.Windows.Forms.DataGrid
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.lblCreditAmt = New System.Windows.Forms.Label
        Me.lblBalAmt = New System.Windows.Forms.Label
        Me.grpMain.SuspendLayout()
        CType(Me.dtgAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgLiabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.dtgAssets)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.btnRefresh)
        Me.grpMain.Controls.Add(Me.btnExport)
        Me.grpMain.Controls.Add(Me.lblFlag)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.lblDebitAmt)
        Me.grpMain.Controls.Add(Me.dtgLiabs)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Controls.Add(Me.lblCreditAmt)
        Me.grpMain.Controls.Add(Me.lblBalAmt)
        Me.grpMain.Location = New System.Drawing.Point(0, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(1077, 607)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'dtgAssets
        '
        Me.dtgAssets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgAssets.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgAssets.DataMember = ""
        Me.dtgAssets.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgAssets.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgAssets.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgAssets.Location = New System.Drawing.Point(540, 64)
        Me.dtgAssets.Name = "dtgAssets"
        Me.dtgAssets.Size = New System.Drawing.Size(535, 502)
        Me.dtgAssets.TabIndex = 124
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
        Me.Label2.Text = "Balance Sheet"
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
        'dtgLiabs
        '
        Me.dtgLiabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgLiabs.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgLiabs.CaptionText = "B/S"
        Me.dtgLiabs.DataMember = ""
        Me.dtgLiabs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgLiabs.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgLiabs.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgLiabs.Location = New System.Drawing.Point(7, 64)
        Me.dtgLiabs.Name = "dtgLiabs"
        Me.dtgLiabs.Size = New System.Drawing.Size(535, 502)
        Me.dtgLiabs.TabIndex = 1
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
        Me.lblFormCaption.Text = "Balance Sheet"
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
        'frmBalanceSheet
        '
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1079, 612)
        Me.Controls.Add(Me.grpMain)
        Me.MaximizeBox = False
        Me.Name = "frmBalanceSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Sheet"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.dtgAssets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgLiabs, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim WithEvents DtLiabs As DataTable
    Dim WithEvents DtAssets As DataTable
    Dim SMSFields As String = ""
    Dim SMSGrpFields As String = ""
    Dim TotPurch As Double = 0
    Dim TotSales As Double = 0
    Dim TotPurchDtl As Double = 0
    Dim TotSalesDtl As Double = 0
    Dim TotLiabs As Double = 0
    Dim TotAssets As Double = 0
    Dim TotGrandLiabs As Double = 0
    Dim TotGrandAssets As Double = 0
    Dim IsGP As Boolean = False
    
    Enum GridLiabCol
        Disp_Level
        Liability_Name
        Perc
        DtlAmt
        Amount
        AccGrp_Id
        AccLGrp_Key
        Led_Key
    End Enum

    Enum GridAssetCol
        Disp_Level
        Asset_Name
        Perc
        DtlAmt
        Amount
        AccGrp_Id
        AccLGrp_Key
        Led_Key
    End Enum

    Private Sub frmBalanceSheet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.F5 Then
        '    DisplayFill()
        'End If
    End Sub

    Private Sub frmCustAcBillWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If blnFlag = True Then
            DisplayFillLiabs()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DisplayFillLiabs()
        Dim DtTable As New DataTable
        DtLiabs = Nothing : dtgLiabs.DataSource = Nothing
        DtAssets = Nothing : dtgAssets.DataSource = Nothing
        Dim strVar1 As String = ""
        Dim strVarDtl As String = ""
        TotGrandAssets = 0 : TotGrandLiabs = 0
        DisplayGridLiab()
        dtgLiabs.CaptionText = "Balance Sheet as on : " & Format$(dtpToDt, "dd/MM/yyyy")

        'Query = " Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '   & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '   & " case when A.AmtFlag='C' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '   & " FROM vw_GenLedger A " _
        '   & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '   & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '   & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '   & " WHERE A.COBR_ID = '" & SelBranchId & "' And A.Fcyr_Id='" & SelYearId & "' And ACCGRP.Disp_Level in ('A1','A2','A3','A4') " _
        '   & " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '   & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '   & " ) as A " _
        '   & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '   & " Having Sum(A.Amount) <> 0 " _
        '   & " Union All " _
        '   & " Select Top 1 'A5' as Disp_Level, 'Profit & Loss A/c' as AccGrp_Name, ACCLGRP.AccLGrp_Name, Ledger.Led_Name, " _
        '   & " Ledger.ClBal as Amount, 15 as AccGrp_Id, Ledger.AccLGrp_Key, Ledger.Led_Key, 16 Fcyr_Id, Ledger.Cobr_Id  " _
        '   & " From Ledger  " _
        '   & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
        '   & " where LEDGER.AccLgrp_Key='0127' and Led_Name like 'Profit%' And Ledger.Cobr_Id = '" & SelBranchId & "'" _
        '   & " ORDER BY Disp_Level, AccLGrp_Name, Led_Name "

        '''ROhit09062017

        ' Query = " Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '& " case when A.AmtFlag='C' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " FROM vw_GenLedger A " _
        '& " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '& " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '& " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '& " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('A1','A2','A3','A4') " _
        '& " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '& " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " ) as A " _
        '& " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " Having Sum(A.Amount) <> 0 " _
        '& " Union All " _
        '& " Select Top 1 'A5' as Disp_Level, 'Profit & Loss A/c' as AccGrp_Name, ACCLGRP.AccLGrp_Name, Ledger.Led_Name, " _
        '& " Ledger.ClBal as Amount, 15 as AccGrp_Id, Ledger.AccLGrp_Key, Ledger.Led_Key, 16 Fcyr_Id, Ledger.Cobr_Id  " _
        '& " From Ledger  " _
        '& " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
        '& " where LEDGER.AccLgrp_Key='0127' and Led_Name like 'Profit%' And Ledger.Cobr_Id = '" & SelBranchId & "'" _
        '& " ORDER BY Disp_Level, AccLGrp_Name, Led_Name "

        ''Rohit 12062017
        Query = " Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
       & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
       & " case when A.AmtFlag='C' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
       & " FROM vw_GenLedger A " _
       & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
       & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
       & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
       & " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('A1','A2','A3','A4') " _
       & " And A.Doc_Dt  <= '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
       & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
       & " ) as A " _
       & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
       & " Having Sum(A.Amount) <> 0 " _
       & " Union All " _
       & " Select Top 1 'A5' as Disp_Level, 'Profit & Loss A/c' as AccGrp_Name, ACCLGRP.AccLGrp_Name, Ledger.Led_Name, " _
       & " Ledger.ClBal as Amount, 15 as AccGrp_Id, Ledger.AccLGrp_Key, Ledger.Led_Key,  Ledger.Cobr_Id  " _
       & " From Ledger  " _
       & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
       & " where LEDGER.AccLgrp_Key='0127' and Led_Name like 'Profit%' And Ledger.Cobr_Id = '" & SelBranchId & "'" _
       & " ORDER BY Disp_Level, AccLGrp_Name, Led_Name "


        '  Query = " Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) +isnull((Select Sum(isnull(Amt,0)) " _
        '          & " From (Select AB.Led_Key Party_Key, DATEADD(Day,-1,'" & Format$(AccFromDt, "MM/dd/yyyy") & "') Doc_dt, 'Op' Doc_No, 'Opening' Type, 'Opening' Vchr_Type, " _
        '          & " case when AmtFlag = 'C' then Sum(Amount) else -Sum(Amount) end Amt, '' ChqNo, '' Remark, 0 as Doc_Id  " _
        '          & " from View_LedgerOnScreen as AB    " _
        '          & " Left Join Ledger Party	on AB.Led_Key = Party.Led_Key   " _
        '          & " Where AB.COBR_ID = '" & SelBranchId & "'  and AB.Led_Key=A.Led_Key and AB.Fcyr_Id='" & SelYearId - 1 & "'  And AB.DOC_DT < '" & Format$(AccFromDt, "MM/dd/yyyy") & "'" _
        '          & " Group by AB.Led_Key, AmtFlag ) B " _
        '          & " Group by Party_Key, Doc_dt, Doc_No, Type, Vchr_Type, ChqNo, Remark, Doc_Id   " _
        '  & " ),0) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '& " case when A.AmtFlag='C' then Sum(A.Amount) else -Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " FROM vw_GenLedger A " _
        '& " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '& " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '& " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '& " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('A1','A2','A3','A4') " _
        '& " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '& " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " ) as A " _
        '& " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " Having Sum(A.Amount) <> 0 " _
        ' & " Union All " _
        ' & " Select B.Disp_Level,B.AccGrp_Name, B.AccLGrp_Name, B.Led_Name,Sum(B.Amount)Amount, B.AccGrp_Id, B.AccLGrp_Key, B.Led_Key, B.Fcyr_Id, B.Cobr_Id    " _
        ' & " From ( Select ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, Party.Led_Name,  case when  AB.AmtFlag='C' then Sum( AB.Amount) else -Sum( AB.Amount) end Amount,   " _
        ' & " ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, Party.Led_Key,  AB.Fcyr_Id,  AB.Cobr_Id from View_LedgerOnScreen as AB Left Join Ledger Party	on AB.Led_Key = Party.Led_Key  " _
        ' & " INNER JOIN AccLGrp ACCLGRP ON Party.AccLGrp_Key=ACCLGRP.AccLGrp_Key   INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id    " _
        ' & " Where AB.COBR_ID = '" & SelBranchId & "' And ACCGRP.Disp_Level in ('A1','A2','A3','A4') and AB.Led_Key not in( " _
        ' & "Select A.Led_Key " _
        ' & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        ' & " case when A.AmtFlag='C' then Sum(A.Amount) else -Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        ' & " FROM vw_GenLedger A " _
        ' & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        ' & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        ' & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        ' & " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('A1','A2','A3','A4')  " _
        ' & " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        ' & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        ' & " ) as A " _
        ' & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        ' & " Having Sum(A.Amount) <> 0 )" _
        '& " and AB.Fcyr_Id='" & SelYearId - 1 & "'  And AB.DOC_DT < '" & Format$(AccFromDt, "MM/dd/yyyy") & "'" _
        ' & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, Party.Led_Name, AB.AmtFlag,  ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, Party.Led_Key, AB.Fcyr_Id, AB.Cobr_Id " _
        ' & "  ) B   Group by B.Disp_Level, B.AccGrp_Name, B.AccLGrp_Name, B.Led_Name, B.AccGrp_Id, B.AccLGrp_Key, B.Led_Key, B.Fcyr_Id,B.Cobr_Id   Having Sum(B.Amount) <> 0   " _
        ' & " Union All " _
        '& " Select Top 1 'A5' as Disp_Level, 'Profit & Loss A/c' as AccGrp_Name, ACCLGRP.AccLGrp_Name, Ledger.Led_Name, " _
        '& " Ledger.ClBal as Amount, 15 as AccGrp_Id, Ledger.AccLGrp_Key, Ledger.Led_Key, 16 Fcyr_Id, Ledger.Cobr_Id  " _
        '& " From Ledger  " _
        '& " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
        '& " where LEDGER.AccLgrp_Key='0127' and Led_Name like 'Profit%' And Ledger.Cobr_Id = '" & SelBranchId & "'" _
        '& " ORDER BY Disp_Level, AccLGrp_Name, Led_Name "


        DtTable = Common.GetDataTable(Query)
        Dim PurRow, NewRow As DataRow
        Dim i, j As Integer
        Dim RowNo As Integer
        Dim RowDtlNo As Integer

        For Each PurRow In DtTable.Rows
            NewRow = DtLiabs.NewRow

            If PurRow("AccGrp_Name") <> strVar1 Then
                TotPurch = 0 : TotPurchDtl = 0

                '*****AccGrp_Name
                NewRow(GridLiabCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridLiabCol.Liability_Name) = PurRow("AccGrp_Name") & ""
                NewRow(GridLiabCol.Perc) = 0
                NewRow(GridLiabCol.DtlAmt) = 0
                NewRow(GridLiabCol.Amount) = 0

                NewRow(GridLiabCol.AccGrp_Id) = 0
                NewRow(GridLiabCol.AccLGrp_Key) = ""
                NewRow(GridLiabCol.Led_Key) = ""
                If i <> 0 Then
                    RowNo = i ''i + 1
                Else
                    RowNo = 0
                End If

                'If PurRow("Disp_Level") <> "A1" And PurRow("Disp_Level") <> "A2" And PurRow("Disp_Level") <> "A3" Then
                '    RowNo = RowNo + 1
                'End If

                RowDtlNo = i + 1

                strVar1 = PurRow("AccGrp_Name")

                DtLiabs.Rows.Add(NewRow)
                i = i + 1
                DtLiabs.AcceptChanges()

                '*****AccLGrp_Name
                NewRow = DtLiabs.NewRow
                NewRow(GridLiabCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridLiabCol.Liability_Name) = "   " & PurRow("AccLGrp_Name") & ""
                NewRow(GridLiabCol.Perc) = 0
                NewRow(GridLiabCol.DtlAmt) = 0
                NewRow(GridLiabCol.Amount) = 0

                NewRow(GridLiabCol.AccGrp_Id) = 0
                NewRow(GridLiabCol.AccLGrp_Key) = ""
                NewRow(GridLiabCol.Led_Key) = ""

                'If j > 1 Then
                '    RowDtlNo = j + 1 '2
                'Else
                '    RowDtlNo = j + 1
                'End If

               
                strVarDtl = PurRow("AccLGrp_Name")

                'If PurRow("Disp_Level") <> "A1" And PurRow("Disp_Level") <> "A2" And PurRow("Disp_Level") <> "A3" Then
                '    RowDtlNo = RowDtlNo + 1
                'End If

                DtLiabs.Rows.Add(NewRow)
                j = j + 1
                i = i + 1
                DtLiabs.AcceptChanges()

                '*****Led_Name
                NewRow = DtLiabs.NewRow
                NewRow(GridLiabCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridLiabCol.Liability_Name) = "      " & PurRow("Led_Name") & ""
                NewRow(GridLiabCol.Perc) = 0
                NewRow(GridLiabCol.DtlAmt) = PurRow("Amount")
                NewRow(GridLiabCol.Amount) = 0

                If PurRow("AccGrp_Name") = "Capital Account" Then
                    TotPurch = TotPurch + PurRow("Amount")
                    TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Loans (Liabilities)" Then
                    TotPurch = TotPurch + PurRow("Amount")
                    TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Current Liabilities" Then
                    TotPurch = TotPurch + PurRow("Amount")
                    TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Suspense Account" Then
                    TotPurch = TotPurch + PurRow("Amount")
                    TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Profit & Loss A/c" Then
                    TotPurch = TotPurch + PurRow("Amount")
                    TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                End If

                NewRow(GridLiabCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridLiabCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridLiabCol.Led_Key) = PurRow("Led_Key")
                TotPurchDtl = TotPurchDtl + PurRow("Amount")
                i = i + 1
            Else

                If PurRow("AccLGrp_Name") <> strVarDtl Then
                    TotPurchDtl = 0
                    '*****AccLGrp_Name
                    NewRow(GridLiabCol.Disp_Level) = PurRow("Disp_Level") & ""
                    NewRow(GridLiabCol.Liability_Name) = "   " & PurRow("AccLGrp_Name") & ""
                    NewRow(GridLiabCol.Perc) = 0
                    NewRow(GridLiabCol.DtlAmt) = 0
                    NewRow(GridLiabCol.Amount) = 0

                    NewRow(GridLiabCol.AccGrp_Id) = 0
                    NewRow(GridLiabCol.AccLGrp_Key) = ""
                    NewRow(GridLiabCol.Led_Key) = ""
                    'If j > 1 Then
                    '    RowDtlNo = j + 1 '2
                    'Else
                    '    RowDtlNo = j + 1
                    'End If

                    RowDtlNo = i '+ 1 - 1

                    strVarDtl = PurRow("AccLGrp_Name")
                    If PurRow("Disp_Level") <> "A1" And PurRow("Disp_Level") <> "A2" And PurRow("Disp_Level") <> "A3" Then
                        RowDtlNo = RowDtlNo + 1
                    End If

                    DtLiabs.Rows.Add(NewRow)
                    i = i + 1
                    j = j + 1
                    DtLiabs.AcceptChanges()

                    '*****Led_Name
                    NewRow = DtLiabs.NewRow
                    NewRow(GridLiabCol.Disp_Level) = PurRow("Disp_Level") & ""
                    NewRow(GridLiabCol.Liability_Name) = "      " & PurRow("Led_Name") & ""
                    NewRow(GridLiabCol.Perc) = 0
                    NewRow(GridLiabCol.DtlAmt) = PurRow("Amount")
                    NewRow(GridLiabCol.Amount) = 0

                    If PurRow("AccGrp_Name") = "Capital Account" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Loans (Liabilities)" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Current Liabilities" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Suspense Account" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Profit & Loss Account" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    End If

                    i = i + 1
                    j = j + 1

                    NewRow(GridLiabCol.AccGrp_Id) = PurRow("AccGrp_Id")
                    NewRow(GridLiabCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                    NewRow(GridLiabCol.Led_Key) = PurRow("Led_Key")
                    TotPurchDtl = TotPurchDtl + PurRow("Amount")

                Else

                    NewRow(GridLiabCol.Disp_Level) = PurRow("Disp_Level") & ""
                    NewRow(GridLiabCol.Liability_Name) = "      " & PurRow("Led_Name") & ""
                    NewRow(GridLiabCol.Perc) = 0
                    NewRow(GridLiabCol.DtlAmt) = PurRow("Amount")
                    NewRow(GridLiabCol.Amount) = 0
                    If PurRow("AccGrp_Name") = "Capital Account" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Loans (Liabilities)" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Current Liabilities" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Suspense Account" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Profit & Loss Account" Then
                        TotPurch = TotPurch + PurRow("Amount")
                        TotGrandLiabs = TotGrandLiabs + PurRow("Amount")
                    End If

                    NewRow(GridLiabCol.AccGrp_Id) = PurRow("AccGrp_Id")
                    NewRow(GridLiabCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                    NewRow(GridLiabCol.Led_Key) = PurRow("Led_Key")
                    TotPurchDtl = TotPurchDtl + PurRow("Amount")

                    i = i + 1
                    j = j + 1

                End If

            End If

            DtLiabs.Rows.Add(NewRow)
            'i = i + 1
            'j = j + 1
            DtLiabs.AcceptChanges()
            DtLiabs.Rows(RowDtlNo).Item(GridLiabCol.Amount) = TotPurchDtl
            DtLiabs.Rows(RowNo).Item(GridLiabCol.Amount) = TotPurch
            dtgLiabs.CurrentRowIndex = DtLiabs.Rows.Count - 1
        Next PurRow


        DtLiabs.AcceptChanges()

        IsGP = True
        DisplayFillAssets()
        IsGP = False
        TotLiabs = DtLiabs.Compute("Sum(Amount)", "")

        Dim BlankRows As Integer = (DtLiabs.Rows.Count) - (DtAssets.Rows.Count)
        i = 1
        For var = i To BlankRows
            NewRow = DtAssets.NewRow

            NewRow(GridAssetCol.Disp_Level) = ""
            NewRow(GridAssetCol.Asset_Name) = ""
            NewRow(GridAssetCol.Perc) = 0
            NewRow(GridAssetCol.DtlAmt) = 0
            NewRow(GridAssetCol.Amount) = 0

            NewRow(GridAssetCol.AccGrp_Id) = 0
            NewRow(GridAssetCol.AccLGrp_Key) = ""
            NewRow(GridAssetCol.Led_Key) = ""
            RowNo = i

            DtAssets.Rows.Add(NewRow)
            i = i + 1
            DtAssets.AcceptChanges()

        Next var

        '**************
        BlankRows = (DtAssets.Rows.Count) - (DtLiabs.Rows.Count)
        i = 1
        For var = i To BlankRows
            NewRow = DtLiabs.NewRow

            NewRow(GridLiabCol.Disp_Level) = ""
            NewRow(GridLiabCol.Liability_Name) = ""
            NewRow(GridLiabCol.Perc) = 0
            NewRow(GridLiabCol.DtlAmt) = 0
            NewRow(GridLiabCol.Amount) = 0

            NewRow(GridLiabCol.AccGrp_Id) = 0
            NewRow(GridLiabCol.AccLGrp_Key) = ""
            NewRow(GridLiabCol.Led_Key) = ""
            RowNo = i

            DtLiabs.Rows.Add(NewRow)
            i = i + 1
            DtLiabs.AcceptChanges()

        Next var

        '*************Difference in Op Bal  Liab
        If DtLiabs.Rows.Count > 0 Then
            NewRow = DtLiabs.NewRow

            NewRow(GridLiabCol.Disp_Level) = ""
            If (TotGrandAssets - TotGrandLiabs) > 0 Then
                NewRow(GridLiabCol.Liability_Name) = "Difference in Op Bal"
                NewRow(GridLiabCol.Perc) = 0
                NewRow(GridLiabCol.DtlAmt) = 0
                NewRow(GridLiabCol.Amount) = (TotGrandAssets - TotGrandLiabs)
            Else
                NewRow(GridLiabCol.Liability_Name) = ""
                NewRow(GridLiabCol.Perc) = 0
                NewRow(GridLiabCol.DtlAmt) = 0
                NewRow(GridLiabCol.Amount) = 0
            End If

            NewRow(GridLiabCol.AccGrp_Id) = 0
            NewRow(GridLiabCol.AccLGrp_Key) = ""
            NewRow(GridLiabCol.Led_Key) = ""

            DtLiabs.Rows.Add(NewRow)
            DtLiabs.AcceptChanges()

            NewRow = DtLiabs.NewRow
            NewRow(GridLiabCol.Disp_Level) = ""
            NewRow(GridLiabCol.Liability_Name) = "TOTAL"
            NewRow(GridLiabCol.Perc) = 0
            NewRow(GridLiabCol.DtlAmt) = 0
            NewRow(GridLiabCol.Amount) = IIf((TotGrandAssets - TotGrandLiabs) > 0, TotGrandAssets, TotGrandLiabs)

            NewRow(GridLiabCol.AccGrp_Id) = 0
            NewRow(GridLiabCol.AccLGrp_Key) = ""
            NewRow(GridLiabCol.Led_Key) = ""

            DtLiabs.Rows.Add(NewRow)
            DtLiabs.AcceptChanges()
        End If

        '*************Assets C/F
        If DtAssets.Rows.Count > 0 Then
            NewRow = DtAssets.NewRow

            NewRow(GridAssetCol.Disp_Level) = ""
            If ((TotGrandLiabs - TotGrandAssets)) > 0 Then
                NewRow(GridAssetCol.Asset_Name) = "Difference in Op Bal"
                NewRow(GridAssetCol.Perc) = 0
                NewRow(GridAssetCol.DtlAmt) = 0
                NewRow(GridAssetCol.Amount) = (TotGrandLiabs - TotGrandAssets)
            Else
                NewRow(GridAssetCol.Asset_Name) = ""
                NewRow(GridAssetCol.Perc) = 0
                NewRow(GridAssetCol.DtlAmt) = 0
                NewRow(GridAssetCol.Amount) = 0
            End If

            NewRow(GridAssetCol.AccGrp_Id) = 0
            NewRow(GridAssetCol.AccLGrp_Key) = ""
            NewRow(GridAssetCol.Led_Key) = ""

            DtAssets.Rows.Add(NewRow)
            DtAssets.AcceptChanges()

            NewRow = DtAssets.NewRow
            NewRow(GridAssetCol.Disp_Level) = ""
            NewRow(GridAssetCol.Asset_Name) = "TOTAL"
            NewRow(GridAssetCol.Perc) = 0
            NewRow(GridAssetCol.DtlAmt) = 0
            NewRow(GridAssetCol.Amount) = IIf((TotGrandLiabs - TotGrandAssets) > 0, TotGrandLiabs, TotGrandAssets)

            NewRow(GridAssetCol.AccGrp_Id) = 0
            NewRow(GridAssetCol.AccLGrp_Key) = ""
            NewRow(GridAssetCol.Led_Key) = ""

            DtAssets.Rows.Add(NewRow)
            DtAssets.AcceptChanges()
        End If

        dtgLiabs.CurrentRowIndex = 0
        dtgLiabs.Focus()
        dtgLiabs.Select(dtgLiabs.CurrentCell.RowNumber)

        dtgAssets.CurrentRowIndex = 0
        dtgAssets.Focus()
        dtgAssets.Select(dtgAssets.CurrentCell.RowNumber)
    End Sub

    Private Sub DisplayFillAssets()
        Dim DtTable As New DataTable
        Dim strVar1 As String = ""
        Dim strVarDtl As String = ""
        DisplayGridAssets()

        'Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '    & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '    & " case when A.AmtFlag='D' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '    & " FROM vw_GenLedger A " _
        '    & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '    & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '    & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '    & " WHERE A.COBR_ID = '" & SelBranchId & "' And A.Fcyr_Id='" & SelYearId & "' And ACCGRP.Disp_Level in ('B1','B2','B3','B4')  " _
        '    & " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '    & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '    & " ) as A " _
        '    & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '    & " Having Sum(A.Amount) <> 0 " _
        '    & " Union All " _
        '    & " Select 'B5' as Disp_Level, 'Closing Stock' as AccGrp_Name, ACCLGRP.AccLGrp_Name, 'Closing Stock' as Led_Name, Sum(Amount) as Amount, 4 as AccGrp_Id, Ledger.AccLGrp_Key, '' as Led_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id " _
        '    & " From ClStkDtl Left Join ClStk On ClStkDtl.ClStk_ID = ClStk.ClStk_ID   " _
        '    & " Left Join Ledger On ClStkDtl.Led_Key = Ledger.Led_Key   " _
        '    & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
        '    & " Where Ledger.AccLGrp_Key = '0128' And ClStk_Dt = '" & Format$(AccToDt, "MM/dd/yyyy") & "' And ClStk.COBR_ID = '" & SelBranchId & "' And ClStk.Fcyr_Id='" & SelYearId & "'" _
        '    & " Group by ACCLGRP.AccLGrp_Name, Ledger.AccLGrp_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id  " _
        '    & " ORDER BY Disp_Level, AccLGrp_Name, Led_Name  "
        'ROhit 09062017
        'Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '& " case when A.AmtFlag='D' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " FROM vw_GenLedger A " _
        '& " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '& " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '& " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '& " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('B1','B2','B3','B4')  " _
        '& " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '& " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " ) as A " _
        '& " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '& " Having Sum(A.Amount) <> 0 " _
        '& " Union All " _
        '& " Select 'B5' as Disp_Level, 'Closing Stock' as AccGrp_Name, ACCLGRP.AccLGrp_Name, 'Closing Stock' as Led_Name, Sum(Amount) as Amount, 4 as AccGrp_Id, Ledger.AccLGrp_Key, '' as Led_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id " _
        '& " From ClStkDtl Left Join ClStk On ClStkDtl.ClStk_ID = ClStk.ClStk_ID   " _
        '& " Left Join Ledger On ClStkDtl.Led_Key = Ledger.Led_Key   " _
        '& " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
        '& " Where Ledger.AccLGrp_Key = '0128' And ClStk_Dt = '" & Format$(AccToDt, "MM/dd/yyyy") & "' And ClStk.COBR_ID = '" & SelBranchId & "'" _
        '& " Group by ACCLGRP.AccLGrp_Name, Ledger.AccLGrp_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id  " _
        '& " ORDER BY Disp_Level, AccLGrp_Name, Led_Name  "


        '''Rohit 12062017
        Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
        & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        & " case when A.AmtFlag='D' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
        & " FROM vw_GenLedger A " _
        & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        & " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('B1','B2','B3','B4')  " _
        & " And A.Doc_Dt <= '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key,  A.Cobr_Id " _
        & " ) as A " _
        & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key,  A.Cobr_Id " _
        & " Having Sum(A.Amount) <> 0 " _
        & " Union All " _
        & " Select 'B5' as Disp_Level, 'Closing Stock' as AccGrp_Name, ACCLGRP.AccLGrp_Name, 'Closing Stock' as Led_Name, Sum(Amount) as Amount, 4 as AccGrp_Id, Ledger.AccLGrp_Key, '' as Led_Key, ClStk.Cobr_Id " _
        & " From ClStkDtl Left Join ClStk On ClStkDtl.ClStk_ID = ClStk.ClStk_ID   " _
        & " Left Join Ledger On ClStkDtl.Led_Key = Ledger.Led_Key   " _
        & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
        & " Where Ledger.AccLGrp_Key = '0128' And ClStk_Dt = '" & Format$(dtpToDt, "MM/dd/yyyy") & "' And ClStk.COBR_ID = '" & SelBranchId & "'" _
        & " Group by ACCLGRP.AccLGrp_Name, Ledger.AccLGrp_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id  " _
        & " ORDER BY Disp_Level, AccLGrp_Name, Led_Name  "

        ''  Query = "Select A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, Sum(A.Amount)+isnull((Select Sum(isnull(Amt,0)) " _
        ''          & " From (Select AB.Led_Key Party_Key, DATEADD(Day,-1,'" & Format$(AccFromDt, "MM/dd/yyyy") & "') Doc_dt, 'Op' Doc_No, 'Opening' Type, 'Opening' Vchr_Type, " _
        ''          & " case when AmtFlag = 'D' then Sum(Amount) else -Sum(Amount) end Amt, '' ChqNo, '' Remark, 0 as Doc_Id  " _
        ''          & " from View_LedgerOnScreen as AB    " _
        ''          & " Left Join Ledger Party	on AB.Led_Key = Party.Led_Key   " _
        ''          & " Where AB.COBR_ID = '" & SelBranchId & "'  and AB.Led_Key=A.Led_Key and AB.Fcyr_Id='" & SelYearId - 1 & "'  And AB.DOC_DT < '" & Format$(AccFromDt, "MM/dd/yyyy") & "'" _
        ''          & " Group by AB.Led_Key, AmtFlag ) B " _
        ''          & " Group by Party_Key, Doc_dt, Doc_No, Type, Vchr_Type, ChqNo, Remark, Doc_Id   " _
        ''  & " ),0) Amount, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '' & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '' & " case when A.AmtFlag='D' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '' & " FROM vw_GenLedger A " _
        '' & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '' & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '' & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '' & " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('B1','B2','B3','B4')  " _
        '' & " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '' & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '' & " ) as A " _
        '' & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '' & " Having Sum(A.Amount) <> 0 " _
        '' & " Union All " _
        '' & " Select B.Disp_Level,B.AccGrp_Name, B.AccLGrp_Name, B.Led_Name,Sum(B.Amount)Amount, B.AccGrp_Id, B.AccLGrp_Key, B.Led_Key, B.Fcyr_Id, B.Cobr_Id    " _
        '' & " From ( Select ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, Party.Led_Name,  case when  AB.AmtFlag='D' then Sum( AB.Amount) else 0-Sum( AB.Amount) end Amount,   " _
        '' & " ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, Party.Led_Key,  AB.Fcyr_Id,  AB.Cobr_Id from View_LedgerOnScreen as AB Left Join Ledger Party	on AB.Led_Key = Party.Led_Key  " _
        '' & " INNER JOIN AccLGrp ACCLGRP ON Party.AccLGrp_Key=ACCLGRP.AccLGrp_Key   INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id    " _
        '' & " Where AB.COBR_ID = '" & SelBranchId & "' And ACCGRP.Disp_Level in ('B1','B2','B3','B4') and AB.Led_Key not in( " _
        '' & "Select A.Led_Key " _
        '' & " From (SELECT ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, " _
        '' & " case when A.AmtFlag='D' then Sum(A.Amount) else 0-Sum(A.Amount) end Amount, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '' & " FROM vw_GenLedger A " _
        '' & " INNER JOIN Ledger LEDGER ON A.Led_Key=LEDGER.Led_Key " _
        '' & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key " _
        '' & " INNER JOIN AccGrp ACCGRP ON ACCLGRP.AccGrp_Id=ACCGRP.AccGrp_Id " _
        '' & " WHERE A.COBR_ID = '" & SelBranchId & "'  And ACCGRP.Disp_Level in ('B1','B2','B3','B4')  " _
        '' & " And A.Doc_Dt between '" & Format$(dtpFromDt, "MM/dd/yyyy") & "' and '" & Format$(dtpToDt, "MM/dd/yyyy") & "' " _
        '' & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, LEDGER.Led_Name, A.AmtFlag, ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, LEDGER.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '' & " ) as A " _
        '' & " Group by A.Disp_Level, A.AccGrp_Name, A.AccLGrp_Name, A.Led_Name, A.AccGrp_Id, A.AccLGrp_Key, A.Led_Key, A.Fcyr_Id, A.Cobr_Id " _
        '' & " Having Sum(A.Amount) <> 0 )" _
        ''& " and AB.Fcyr_Id='" & SelYearId - 1 & "'  And AB.DOC_DT < '" & Format$(AccFromDt, "MM/dd/yyyy") & "'" _
        '' & " Group by ACCGRP.Disp_Level, ACCGRP.AccGrp_Name, ACCLGRP.AccLGrp_Name, Party.Led_Name, AB.AmtFlag,  ACCGRP.AccGrp_Id, ACCLGRP.AccLGrp_Key, Party.Led_Key, AB.Fcyr_Id, AB.Cobr_Id " _
        '' & "  ) B   Group by B.Disp_Level, B.AccGrp_Name, B.AccLGrp_Name, B.Led_Name, B.AccGrp_Id, B.AccLGrp_Key, B.Led_Key, B.Fcyr_Id,B.Cobr_Id   Having Sum(B.Amount) <> 0   " _
        '' & " Union All " _
        '' & " Select 'B5' as Disp_Level, 'Closing Stock' as AccGrp_Name, ACCLGRP.AccLGrp_Name, 'Closing Stock' as Led_Name, Sum(Amount) as Amount, 4 as AccGrp_Id, Ledger.AccLGrp_Key, '' as Led_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id " _
        '' & " From ClStkDtl Left Join ClStk On ClStkDtl.ClStk_ID = ClStk.ClStk_ID   " _
        '' & " Left Join Ledger On ClStkDtl.Led_Key = Ledger.Led_Key   " _
        '' & " INNER JOIN AccLGrp ACCLGRP ON LEDGER.AccLGrp_Key=ACCLGRP.AccLGrp_Key  " _
        '' & " Where Ledger.AccLGrp_Key = '0128' And ClStk_Dt = '" & Format$(AccToDt, "MM/dd/yyyy") & "' And ClStk.COBR_ID = '" & SelBranchId & "'" _
        '' & " Group by ACCLGRP.AccLGrp_Name, Ledger.AccLGrp_Key, ClStk.Fcyr_Id, ClStk.Cobr_Id  " _
        '' & " ORDER BY Disp_Level, AccLGrp_Name, Led_Name  "


        DtTable = Common.GetDataTable(Query)
        Dim PurRow, NewRow As DataRow
        Dim var As Integer
        Dim i, j As Integer
        Dim RowNo As Integer
        Dim RowDtlNo As Integer

        For Each PurRow In DtTable.Rows
            NewRow = DtAssets.NewRow

            If PurRow("AccGrp_Name") <> strVar1 Then
                TotSales = 0 : TotSalesDtl = 0
                NewRow(GridAssetCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridAssetCol.Asset_Name) = PurRow("AccGrp_Name") & ""
                NewRow(GridAssetCol.Perc) = 0
                NewRow(GridAssetCol.DtlAmt) = 0
                NewRow(GridAssetCol.Amount) = 0

                NewRow(GridAssetCol.AccGrp_Id) = 0
                NewRow(GridAssetCol.AccLGrp_Key) = ""
                NewRow(GridAssetCol.Led_Key) = ""
                If i <> 0 Then
                    RowNo = i + 1
                Else
                    RowNo = i
                End If

                If PurRow("Disp_Level") <> "B1" And PurRow("Disp_Level") <> "B2" And PurRow("Disp_Level") <> "B3" Then
                    RowNo = RowNo + 1
                End If
                strVar1 = PurRow("AccGrp_Name")

                DtAssets.Rows.Add(NewRow)
                i = i + 1
                DtAssets.AcceptChanges()

                '*****AccLGrp_Name
                NewRow = DtAssets.NewRow
                NewRow(GridAssetCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridAssetCol.Asset_Name) = "   " & PurRow("AccLGrp_Name") & ""
                NewRow(GridAssetCol.Perc) = 0
                NewRow(GridAssetCol.DtlAmt) = 0
                NewRow(GridAssetCol.Amount) = 0

                NewRow(GridAssetCol.AccGrp_Id) = 0
                NewRow(GridAssetCol.AccLGrp_Key) = ""
                NewRow(GridAssetCol.Led_Key) = ""

                If j > 1 Then
                    RowDtlNo = j + 2
                Else
                    RowDtlNo = j + 1
                End If
                strVarDtl = PurRow("AccLGrp_Name")

                DtAssets.Rows.Add(NewRow)
                j = j + 1
                DtAssets.AcceptChanges()

                '*****Led_Name
                NewRow = DtAssets.NewRow
                NewRow(GridAssetCol.Disp_Level) = PurRow("Disp_Level") & ""
                NewRow(GridAssetCol.Asset_Name) = "      " & PurRow("Led_Name") & ""
                NewRow(GridAssetCol.Perc) = 0
                NewRow(GridAssetCol.DtlAmt) = PurRow("Amount")
                NewRow(GridAssetCol.Amount) = 0

                If PurRow("AccGrp_Name") = "Fixed Assets" Then
                    TotSales = TotSales + PurRow("Amount")
                    TotGrandAssets = TotGrandAssets + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Investment" Then
                    TotSales = TotSales + PurRow("Amount")
                    TotGrandAssets = TotGrandAssets + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Current Assets" Then
                    TotSales = TotSales + PurRow("Amount")
                    TotGrandAssets = TotGrandAssets + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Misc. Expenses" Then
                    TotSales = TotSales + PurRow("Amount")
                    TotGrandAssets = TotGrandAssets + PurRow("Amount")
                ElseIf PurRow("AccGrp_Name") = "Closing Stock" Then
                    TotSales = TotSales + PurRow("Amount")
                    TotGrandAssets = TotGrandAssets + PurRow("Amount")
                End If

                NewRow(GridAssetCol.AccGrp_Id) = PurRow("AccGrp_Id")
                NewRow(GridAssetCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                NewRow(GridAssetCol.Led_Key) = PurRow("Led_Key")
                TotSalesDtl = TotSalesDtl + PurRow("Amount")

            Else

                If PurRow("AccLGrp_Name") <> strVarDtl Then
                    TotSalesDtl = 0
                    '*****AccLGrp_Name
                    NewRow(GridAssetCol.Disp_Level) = PurRow("Disp_Level") & ""
                    NewRow(GridAssetCol.Asset_Name) = "   " & PurRow("AccLGrp_Name") & ""
                    NewRow(GridAssetCol.Perc) = 0
                    NewRow(GridAssetCol.DtlAmt) = 0
                    NewRow(GridAssetCol.Amount) = 0

                    NewRow(GridAssetCol.AccGrp_Id) = 0
                    NewRow(GridAssetCol.AccLGrp_Key) = ""
                    NewRow(GridAssetCol.Led_Key) = ""
                    If j > 1 Then
                        RowDtlNo = j + 2
                    Else
                        RowDtlNo = j + 1
                    End If

                    strVarDtl = PurRow("AccLGrp_Name")

                    DtAssets.Rows.Add(NewRow)
                    i = i + 1
                    j = j + 1
                    DtLiabs.AcceptChanges()

                    '*****Led_Name
                    NewRow = DtAssets.NewRow
                    NewRow(GridAssetCol.Disp_Level) = PurRow("Disp_Level") & ""
                    NewRow(GridAssetCol.Asset_Name) = "      " & PurRow("Led_Name") & ""
                    NewRow(GridAssetCol.Perc) = 0
                    NewRow(GridAssetCol.DtlAmt) = PurRow("Amount")
                    NewRow(GridAssetCol.Amount) = 0

                    If PurRow("AccGrp_Name") = "Fixed Assets" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Investment" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Current Assets" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Misc. Expenses" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Closing Stock" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    End If

                    NewRow(GridAssetCol.AccGrp_Id) = PurRow("AccGrp_Id")
                    NewRow(GridAssetCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                    NewRow(GridAssetCol.Led_Key) = PurRow("Led_Key")
                    TotSalesDtl = TotSalesDtl + PurRow("Amount")

                Else

                    NewRow(GridAssetCol.Disp_Level) = PurRow("Disp_Level") & ""
                    NewRow(GridAssetCol.Asset_Name) = "      " & PurRow("Led_Name") & ""
                    NewRow(GridAssetCol.Perc) = 0
                    NewRow(GridAssetCol.DtlAmt) = PurRow("Amount")
                    NewRow(GridAssetCol.Amount) = 0
                    If PurRow("AccGrp_Name") = "Fixed Assets" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Investment" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Current Assets" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Misc. Expenses" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    ElseIf PurRow("AccGrp_Name") = "Closing Stock" Then
                        TotSales = TotSales + PurRow("Amount")
                        TotGrandAssets = TotGrandAssets + PurRow("Amount")
                    End If

                    NewRow(GridAssetCol.AccGrp_Id) = PurRow("AccGrp_Id")
                    NewRow(GridAssetCol.AccLGrp_Key) = PurRow("AccLGrp_Key")
                    NewRow(GridAssetCol.Led_Key) = PurRow("Led_Key")
                    TotSalesDtl = TotSalesDtl + PurRow("Amount")

                End If
            End If

            DtAssets.Rows.Add(NewRow)
            i = i + 1
            j = j + 1
            DtAssets.AcceptChanges()
            DtAssets.Rows(RowDtlNo).Item(GridAssetCol.Amount) = TotSalesDtl
            DtAssets.Rows(RowNo).Item(GridAssetCol.Amount) = TotSales
            dtgAssets.CurrentRowIndex = DtAssets.Rows.Count - 1
        Next PurRow

        DtAssets.AcceptChanges()

        dtgAssets.CurrentRowIndex = 0
        dtgAssets.Focus()
        dtgAssets.Select(dtgAssets.CurrentCell.RowNumber)
    End Sub

    Private Sub dtgExps_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLiabs.MouseUp
        Try
            dtgLiabs.Select(dtgLiabs.CurrentCell.RowNumber)
        Catch ex As IndexOutOfRangeException
            Exit Sub
        End Try
    End Sub

    Private Sub dtgExps_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgLiabs.DoubleClick
        Dim strPartyKey, strPartyNm As String
        Dim dtMonthlyDate As Date
        If dtgLiabs.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        strPartyKey = dtgLiabs.Item(dtgLiabs.CurrentRowIndex, 7)
        strPartyNm = dtgLiabs.Item(dtgLiabs.CurrentRowIndex, 1)
        dtMonthlyDate = dtpToDt
        BalanceSheet = True
        If strPartyKey <> "" Then
            Dim frmCustAcMonthly As New frmCustAcMonthly(strPartyKey, strPartyNm, dtMonthlyDate, True)
            frmCustAcMonthly.MdiParent = Me.MdiParent
            frmCustAcMonthly.Tag = "CustAcMonthly"
            frmCustAcMonthly.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgExps_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgLiabs.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgExps_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtgIncome_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgAssets.MouseUp
        Try
            dtgAssets.Select(dtgAssets.CurrentCell.RowNumber)
        Catch ex As IndexOutOfRangeException
            Exit Sub
        End Try
    End Sub

    Private Sub dtgIncome_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgAssets.DoubleClick
        Dim strPartyKey, strPartyNm As String
        Dim dtMonthlyDate As Date
        If dtgAssets.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        strPartyKey = dtgAssets.Item(dtgAssets.CurrentRowIndex, 7)
        strPartyNm = dtgAssets.Item(dtgAssets.CurrentRowIndex, 1)
        dtMonthlyDate = dtpToDt
        BalanceSheet = True
        If strPartyKey <> "" Then
            Dim frmCustAcMonthly As New frmCustAcMonthly(strPartyKey, strPartyNm, dtMonthlyDate, True)
            frmCustAcMonthly.MdiParent = Me.MdiParent
            frmCustAcMonthly.Tag = "CustAcMonthly"
            frmCustAcMonthly.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgIncome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgAssets.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgIncome_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub frmCustAcBillWise_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If blnFlag = False Then
            DisplayFillLiabs()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'If keyData = Keys.Enter Then
        '    If Me.ActiveControl.Parent Is CType(dtgPartyAc, DataGrid) Or Me.ActiveControl Is CType(dtgPartyAc, DataGrid) Then
        '        Call dtgPartyAc_DoubleClick(Nothing, Nothing)
        '    End If
        'End If
    End Function

    Private Sub DisplayGridLiab()
        Dim Grid As New GridColumnCreateAndFormat("LIABILITIES")

        With Grid
            .AddColumn("Disp_Level", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("Liability_Name", GridColumnCreateAndFormat.enmTypeIdx.StringType, 268, "LIABILITIES")
            .AddColumn("Perc", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "%")
            .AddColumn("DtlAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 110, "")
            .AddColumn("Amount", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 120, "AMOUNT.")
            .AddColumn("AccGrp_Id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "")
            .AddColumn("AccLGrp_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("Led_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")

            .AddColumnToTable()
            DtLiabs = .GetTable
            DtLiabs.DefaultView.AllowNew = False
            DtLiabs.DefaultView.AllowEdit = True
            DtLiabs.DefaultView.AllowDelete = False

            dtgLiabs.DataSource = DtLiabs
            .DisplayGridHeaders(DtLiabs, dtgLiabs, False)
        End With
    End Sub

    Private Sub DisplayGridAssets()
        Dim Grid As New GridColumnCreateAndFormat("Incomes")

        With Grid
            .AddColumn("Disp_Level", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("Asset_Name", GridColumnCreateAndFormat.enmTypeIdx.StringType, 268, "ASSETS")
            .AddColumn("Perc", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "%")
            .AddColumn("DtlAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 110, "")
            .AddColumn("Amount", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 120, "AMOUNT.")
            .AddColumn("AccGrp_Id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "")
            .AddColumn("AccLGrp_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("Led_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")

            .AddColumnToTable()
            DtAssets = .GetTable
            DtAssets.DefaultView.AllowNew = False
            DtAssets.DefaultView.AllowEdit = True
            DtAssets.DefaultView.AllowDelete = False

            dtgAssets.DataSource = DtAssets
            .DisplayGridHeaders(DtAssets, dtgAssets, False)
        End With
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        DisplayFillLiabs()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If DtLiabs.Columns.Count = 0 Then Exit Sub

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
        xlSheet.Cells(5, 1) = "BALANCE SHEET"
        xlSheet.Range("A5:H5").Font.Bold = True
        xlSheet.Range("A5:H5").Font.Size = 14
        'xlSheet.Cells(7, 1) = strPartyNm
        'xlSheet.Range("A7:H7").Font.Bold = True
        'xlSheet.Range("A7:H7").Font.Underline = True
        'xlSheet.Range("A7:H7").Font.Size = 12

        With xlSheet
            .Range("A8:A8").Value = "LIABILITIES"
            .Range("B8:B8").Value = ""
            .Range("C8:C8").Value = "AMOUNT"
            .Range("B8:C8").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            .Range("B8:C8").NumberFormat = "###,##0.00"
            .Range("D8:D8").Value = "ASSETS"
            .Range("E8:E8").Value = ""
            .Range("F8:F8").Value = "AMOUNT"
            .Range("D8:F8").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            .Range("D8:F8").NumberFormat = "###,##0.00"
        End With

        Dim RecRow As DataRow

        For Each RecRow In DtLiabs.Rows
            With xlSheet
                .Range("A" & n & ":A" & n).Value = RecRow("Liability_Name") & ""
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
        For Each RecRow In DtAssets.Rows
            With xlSheet
                .Range("D" & n & ":D" & n).Value = RecRow("Asset_Name") & ""
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