Imports System.Data.SqlClient

Public Class frmrptPartyWithTax
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal rpt As ReportType)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        rptType = rpt
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
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
    Friend WithEvents lblFromDt As System.Windows.Forms.Label
    Friend WithEvents lblToDt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbCustFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCustTo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCityFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCityTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblStateFrom As System.Windows.Forms.Label
    Friend WithEvents cmbStateFrom As System.Windows.Forms.ComboBox
    Friend WithEvents lblStateTo As System.Windows.Forms.Label
    Friend WithEvents cmbStateTo As System.Windows.Forms.ComboBox
    Friend WithEvents lblFormCaption As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTax As System.Windows.Forms.ComboBox
    Friend WithEvents txtFromAmt As System.Windows.Forms.TextBox
    Friend WithEvents chkDtls As System.Windows.Forms.CheckBox
    Friend WithEvents pnlOtherOptions As System.Windows.Forms.Panel
    Friend WithEvents rdsales As System.Windows.Forms.RadioButton
    Friend WithEvents rdall As System.Windows.Forms.RadioButton
    Friend WithEvents rdSalesRtn As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.pnlOtherOptions = New System.Windows.Forms.Panel
        Me.rdsales = New System.Windows.Forms.RadioButton
        Me.rdall = New System.Windows.Forms.RadioButton
        Me.rdSalesRtn = New System.Windows.Forms.RadioButton
        Me.chkDtls = New System.Windows.Forms.CheckBox
        Me.txtFromAmt = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbCustFrom = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbCustTo = New System.Windows.Forms.ComboBox
        Me.cmbCityFrom = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCityTo = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblStateFrom = New System.Windows.Forms.Label
        Me.cmbStateFrom = New System.Windows.Forms.ComboBox
        Me.lblStateTo = New System.Windows.Forms.Label
        Me.cmbStateTo = New System.Windows.Forms.ComboBox
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.dtpTo = New DateTimePick.DateTimePick
        Me.dtpFrom = New DateTimePick.DateTimePick
        Me.lblFromDt = New System.Windows.Forms.Label
        Me.lblToDt = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTax = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpMain.SuspendLayout()
        Me.pnlOtherOptions.SuspendLayout()
        Me.pnlDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpMain.Controls.Add(Me.pnlOtherOptions)
        Me.grpMain.Controls.Add(Me.chkDtls)
        Me.grpMain.Controls.Add(Me.txtFromAmt)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.btnShow)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Controls.Add(Me.Label7)
        Me.grpMain.Controls.Add(Me.cmbCustFrom)
        Me.grpMain.Controls.Add(Me.Label8)
        Me.grpMain.Controls.Add(Me.cmbCustTo)
        Me.grpMain.Controls.Add(Me.cmbCityFrom)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.cmbCityTo)
        Me.grpMain.Controls.Add(Me.Label9)
        Me.grpMain.Controls.Add(Me.lblStateFrom)
        Me.grpMain.Controls.Add(Me.cmbStateFrom)
        Me.grpMain.Controls.Add(Me.lblStateTo)
        Me.grpMain.Controls.Add(Me.cmbStateTo)
        Me.grpMain.Controls.Add(Me.pnlDate)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.cmbTax)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Location = New System.Drawing.Point(32, 16)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(589, 336)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'pnlOtherOptions
        '
        Me.pnlOtherOptions.Controls.Add(Me.rdsales)
        Me.pnlOtherOptions.Controls.Add(Me.rdall)
        Me.pnlOtherOptions.Controls.Add(Me.rdSalesRtn)
        Me.pnlOtherOptions.Location = New System.Drawing.Point(314, 220)
        Me.pnlOtherOptions.Name = "pnlOtherOptions"
        Me.pnlOtherOptions.Size = New System.Drawing.Size(253, 26)
        Me.pnlOtherOptions.TabIndex = 29
        '
        'rdsales
        '
        Me.rdsales.AutoSize = True
        Me.rdsales.Location = New System.Drawing.Point(79, 5)
        Me.rdsales.Name = "rdsales"
        Me.rdsales.Size = New System.Drawing.Size(56, 17)
        Me.rdsales.TabIndex = 0
        Me.rdsales.Text = "Sales"
        Me.rdsales.UseVisualStyleBackColor = True
        '
        'rdall
        '
        Me.rdall.AutoSize = True
        Me.rdall.Checked = True
        Me.rdall.Location = New System.Drawing.Point(16, 5)
        Me.rdall.Name = "rdall"
        Me.rdall.Size = New System.Drawing.Size(39, 17)
        Me.rdall.TabIndex = 2
        Me.rdall.TabStop = True
        Me.rdall.Text = "All"
        Me.rdall.UseVisualStyleBackColor = True
        '
        'rdSalesRtn
        '
        Me.rdSalesRtn.AutoSize = True
        Me.rdSalesRtn.Location = New System.Drawing.Point(162, 4)
        Me.rdSalesRtn.Name = "rdSalesRtn"
        Me.rdSalesRtn.Size = New System.Drawing.Size(79, 17)
        Me.rdSalesRtn.TabIndex = 1
        Me.rdSalesRtn.Text = "Sales Rtn"
        Me.rdSalesRtn.UseVisualStyleBackColor = True
        '
        'chkDtls
        '
        Me.chkDtls.AutoSize = True
        Me.chkDtls.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDtls.Location = New System.Drawing.Point(363, 191)
        Me.chkDtls.Name = "chkDtls"
        Me.chkDtls.Size = New System.Drawing.Size(72, 19)
        Me.chkDtls.TabIndex = 28
        Me.chkDtls.Text = "Detailed"
        Me.chkDtls.UseVisualStyleBackColor = True
        '
        'txtFromAmt
        '
        Me.txtFromAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFromAmt.Location = New System.Drawing.Point(115, 226)
        Me.txtFromAmt.Name = "txtFromAmt"
        Me.txtFromAmt.Size = New System.Drawing.Size(100, 21)
        Me.txtFromAmt.TabIndex = 16
        Me.txtFromAmt.Tag = "From Amount"
        Me.txtFromAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnExit.Location = New System.Drawing.Point(304, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 28)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "E&xit"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnShow.Location = New System.Drawing.Point(192, 283)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(88, 28)
        Me.btnShow.TabIndex = 19
        Me.btnShow.Text = "&View"
        '
        'lblFormCaption
        '
        Me.lblFormCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFormCaption.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormCaption.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFormCaption.Location = New System.Drawing.Point(3, 17)
        Me.lblFormCaption.Name = "lblFormCaption"
        Me.lblFormCaption.Size = New System.Drawing.Size(583, 24)
        Me.lblFormCaption.TabIndex = 27
        Me.lblFormCaption.Text = "Bill Wise Party Details"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Tag = ""
        Me.Label7.Text = "Party From"
        '
        'cmbCustFrom
        '
        Me.cmbCustFrom.DropDownWidth = 275
        Me.cmbCustFrom.Location = New System.Drawing.Point(115, 164)
        Me.cmbCustFrom.Name = "cmbCustFrom"
        Me.cmbCustFrom.Size = New System.Drawing.Size(211, 21)
        Me.cmbCustFrom.TabIndex = 10
        Me.cmbCustFrom.Tag = "From Manufacturer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(338, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Tag = ""
        Me.Label8.Text = "To"
        '
        'cmbCustTo
        '
        Me.cmbCustTo.DropDownWidth = 275
        Me.cmbCustTo.Location = New System.Drawing.Point(363, 164)
        Me.cmbCustTo.Name = "cmbCustTo"
        Me.cmbCustTo.Size = New System.Drawing.Size(211, 21)
        Me.cmbCustTo.TabIndex = 12
        Me.cmbCustTo.Tag = "To Manufacturer"
        '
        'cmbCityFrom
        '
        Me.cmbCityFrom.DropDownWidth = 275
        Me.cmbCityFrom.Location = New System.Drawing.Point(115, 138)
        Me.cmbCityFrom.Name = "cmbCityFrom"
        Me.cmbCityFrom.Size = New System.Drawing.Size(211, 21)
        Me.cmbCityFrom.TabIndex = 6
        Me.cmbCityFrom.Tag = "From City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(338, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Tag = ""
        Me.Label5.Text = "To"
        '
        'cmbCityTo
        '
        Me.cmbCityTo.DropDownWidth = 275
        Me.cmbCityTo.Location = New System.Drawing.Point(363, 138)
        Me.cmbCityTo.Name = "cmbCityTo"
        Me.cmbCityTo.Size = New System.Drawing.Size(211, 21)
        Me.cmbCityTo.TabIndex = 8
        Me.cmbCityTo.Tag = "To City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Tag = ""
        Me.Label9.Text = "City From"
        '
        'lblStateFrom
        '
        Me.lblStateFrom.AutoSize = True
        Me.lblStateFrom.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateFrom.Location = New System.Drawing.Point(14, 114)
        Me.lblStateFrom.Name = "lblStateFrom"
        Me.lblStateFrom.Size = New System.Drawing.Size(79, 13)
        Me.lblStateFrom.TabIndex = 1
        Me.lblStateFrom.Tag = ""
        Me.lblStateFrom.Text = "State From"
        '
        'cmbStateFrom
        '
        Me.cmbStateFrom.DropDownWidth = 275
        Me.cmbStateFrom.Location = New System.Drawing.Point(115, 112)
        Me.cmbStateFrom.Name = "cmbStateFrom"
        Me.cmbStateFrom.Size = New System.Drawing.Size(211, 21)
        Me.cmbStateFrom.TabIndex = 2
        Me.cmbStateFrom.Tag = "From State"
        '
        'lblStateTo
        '
        Me.lblStateTo.AutoSize = True
        Me.lblStateTo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTo.Location = New System.Drawing.Point(338, 114)
        Me.lblStateTo.Name = "lblStateTo"
        Me.lblStateTo.Size = New System.Drawing.Size(23, 13)
        Me.lblStateTo.TabIndex = 3
        Me.lblStateTo.Tag = ""
        Me.lblStateTo.Text = "To"
        '
        'cmbStateTo
        '
        Me.cmbStateTo.DropDownWidth = 275
        Me.cmbStateTo.Location = New System.Drawing.Point(363, 112)
        Me.cmbStateTo.Name = "cmbStateTo"
        Me.cmbStateTo.Size = New System.Drawing.Size(211, 21)
        Me.cmbStateTo.TabIndex = 4
        Me.cmbStateTo.Tag = "To State"
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.dtpFrom)
        Me.pnlDate.Controls.Add(Me.lblFromDt)
        Me.pnlDate.Controls.Add(Me.lblToDt)
        Me.pnlDate.Location = New System.Drawing.Point(120, 56)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(346, 24)
        Me.pnlDate.TabIndex = 0
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(220, 1)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(87, 21)
        Me.dtpTo.TabIndex = 3
        Me.dtpTo.Value = New Date(2016, 7, 21, 0, 0, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(56, 1)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(88, 21)
        Me.dtpFrom.TabIndex = 1
        Me.dtpFrom.Tag = "From Date"
        Me.dtpFrom.Value = New Date(2016, 7, 21, 0, 0, 0, 0)
        '
        'lblFromDt
        '
        Me.lblFromDt.AutoSize = True
        Me.lblFromDt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDt.Location = New System.Drawing.Point(11, 3)
        Me.lblFromDt.Name = "lblFromDt"
        Me.lblFromDt.Size = New System.Drawing.Size(41, 13)
        Me.lblFromDt.TabIndex = 0
        Me.lblFromDt.Text = "From"
        '
        'lblToDt
        '
        Me.lblToDt.AutoSize = True
        Me.lblToDt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToDt.Location = New System.Drawing.Point(191, 3)
        Me.lblToDt.Name = "lblToDt"
        Me.lblToDt.Size = New System.Drawing.Size(23, 13)
        Me.lblToDt.TabIndex = 2
        Me.lblToDt.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Tag = ""
        Me.Label1.Text = "Tax"
        '
        'cmbTax
        '
        Me.cmbTax.DropDownWidth = 275
        Me.cmbTax.Location = New System.Drawing.Point(115, 190)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Size = New System.Drawing.Size(211, 21)
        Me.cmbTax.TabIndex = 14
        Me.cmbTax.Tag = "Tax"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Tag = ""
        Me.Label3.Text = "Amount"
        '
        'frmrptPartyWithTax
        '
        Me.ClientSize = New System.Drawing.Size(656, 373)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmrptPartyWithTax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Party With Tax"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.pnlOtherOptions.ResumeLayout(False)
        Me.pnlOtherOptions.PerformLayout()
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Enum ReportType
        SalesSummary_PartyWise
        SalesSummary_PartyTax
        SalesSummary_WithAddress

        PurchSummary_PartyWise
        PurchSummary_PartyTax
        PurchSummary_WithAddress
    End Enum

    Dim rptType As ReportType

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmrptPartyWithTax_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            If rptType = ReportType.SalesSummary_PartyWise Then
                lblFormCaption.Text = "Sales Summary - Party Wise"
                rdsales.Text = "Sales" : rdSalesRtn.Text = "Sales Rtn"
            ElseIf rptType = ReportType.SalesSummary_PartyTax Then
                lblFormCaption.Text = "Sales Summary - Party / Tax"
                rdsales.Text = "Sales" : rdSalesRtn.Text = "Sales Rtn"
            ElseIf rptType = ReportType.SalesSummary_WithAddress Then
                lblFormCaption.Text = "Sales Summary - With Address"
                rdsales.Text = "Sales" : rdSalesRtn.Text = "Sales Rtn"
            ElseIf rptType = ReportType.PurchSummary_PartyWise Then
                lblFormCaption.Text = "Purchase Summary - Party Wise"
                rdsales.Text = "Purchase" : rdSalesRtn.Text = "Purch Rtn"
            ElseIf rptType = ReportType.PurchSummary_PartyTax Then
                lblFormCaption.Text = "Purchase Summary - Party / Tax"
                rdsales.Text = "Purchase" : rdSalesRtn.Text = "Purch Rtn"
            ElseIf rptType = ReportType.PurchSummary_WithAddress Then
                lblFormCaption.Text = "Purchase Summary - With Address"
                rdsales.Text = "Purchase" : rdSalesRtn.Text = "Purch Rtn"
            End If
            Me.Text = lblFormCaption.Text

            dtpFrom.Value = AccFromDt : dtpTo.Value = AccToDt
            txtFromAmt.Text = 0

            Query = "Select TXTMTDS_KEY, ABBR " _
                    & " From TaxTermsTDS " _
                    & " Where Status = '1' And TxTmTDS_Name <> '' " _
                    & BranchLedFixFilter _
                    & " Order By Abbr"
            Dim Tax As DataTable = Common.GetDataTableWithAll(Query)

            With cmbTax
                .DataSource = Tax
                .DisplayMember = "ABBR"
                .ValueMember = "TXTMTDS_KEY"
            End With

            If cmbTax.Items.Count > 0 Then cmbTax.SelectedIndex = 0

            Query = "SELECT STATE_KEY, STATE_NAME FROM STATE " _
                    & " WHERE STATUS = '1' AND STATE_NAME <> '' ORDER BY STATE_NAME"
            Dim dtStateFrom As DataTable = Common.GetDataTableWithAll(Query)

            With cmbStateFrom
                .DataSource = dtStateFrom
                .DisplayMember = "STATE_NAME"
                .ValueMember = "STATE_KEY"
            End With

            Query = "SELECT STATE_KEY, STATE_NAME FROM STATE " _
                & " WHERE STATUS = '1' AND STATE_NAME <> '' ORDER BY STATE_NAME"
            Dim dtStateTo As DataTable = Common.GetDataTableWithAll(Query)

            With cmbStateTo
                .DataSource = dtStateTo
                .DisplayMember = "STATE_NAME"
                .ValueMember = "STATE_KEY"
            End With

            cmbStateFrom.SelectedIndex = 0
            Call cmbStateFrom_SelectionChangeCommitted(cmbStateFrom, Nothing)


        Catch sqlEx As SqlException
            Call Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbStateFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStateFrom.SelectionChangeCommitted
        If cmbStateFrom.SelectedIndex = -1 Then Exit Sub
        cmbStateTo.SelectedIndex = cmbStateFrom.SelectedIndex

        Call DisplayCity()
    End Sub

    Private Sub cmbStateTo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStateTo.SelectionChangeCommitted
        If cmbStateTo.SelectedIndex = -1 Then Exit Sub
        Call DisplayCity()
    End Sub

    Private Sub DisplayCity()
        Dim strFilter As String = ""

        If cmbStateFrom.SelectedIndex > 0 Then
            If cmbStateTo.SelectedIndex > 0 Then
                strFilter = " And State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "' And State.State_Name <= '" & ReplaceApostrophe(cmbStateTo.Text) & "'"
            Else
                strFilter = " And State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "'"
            End If
        End If

        Query = "Select Station.Stn_Key, Stn_Name From Station " _
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

        cmbCityFrom.SelectedIndex = 0
        Call cmbCityFrom_SelectionChangeCommitted(cmbCityFrom, Nothing)
    End Sub

    Private Sub DisplayCustomers()
        Dim dtCustFrom As DataTable
        Dim dtCustTo As DataTable
        Dim strFilter As String = ""

        If cmbStateFrom.SelectedIndex > 0 Then
            If cmbStateTo.SelectedIndex > 0 Then
                strFilter = " AND (STATE.STATE_NAME >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "' AND STATE.STATE_NAME <= '" & ReplaceApostrophe(cmbStateTo.Text) & "')"
            Else
                strFilter = " AND (STATE.STATE_NAME >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "')"
            End If
        End If

        If cmbCityFrom.SelectedIndex > 0 Then
            If cmbCityTo.SelectedIndex > 0 Then
                strFilter &= " And (Station.Stn_Name >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "' And Station.Stn_Name <= '" & ReplaceApostrophe(cmbCityTo.Text) & "')"
            Else
                strFilter &= " And Station.Stn_Name >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "'"
            End If
        End If

        Query = "Select Distinct LED_KEY, LED_NAME " _
                & " From Ledger Left Join Station On Ledger.OStn_Key = Station.Stn_Key " _
                & " Left Join State On State.State_Key = Station.State_Key " _
                & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchLedFixId & "' And Led_Name <> '' " & strFilter _
                & " Order By Led_Name"
        dtCustFrom = Common.GetDataTableWithAll(Query)
        With cmbCustFrom
            .DataSource = dtCustFrom
            .DisplayMember = "LED_NAME"
            .ValueMember = "LED_KEY"
        End With

        dtCustTo = Common.GetDataTableWithAll(Query)
        With cmbCustTo
            .DataSource = dtCustTo
            .DisplayMember = "LED_NAME"
            .ValueMember = "LED_KEY"
        End With
    End Sub

    Private Sub cmbCityTo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCityTo.SelectionChangeCommitted
        If cmbCityTo.SelectedIndex = -1 Then Exit Sub
        Call DisplayCustomers()
    End Sub

    Private Sub cmbCityFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCityFrom.SelectionChangeCommitted
        If cmbCityFrom.SelectedIndex = -1 Then Exit Sub
        cmbCityTo.SelectedIndex = cmbCityFrom.SelectedIndex
        Call DisplayCustomers()
    End Sub

    Private Sub dtpFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbStateFrom.KeyDown, cmbStateTo.KeyDown, cmbCityFrom.KeyDown, cmbCityTo.KeyDown, cmbCustFrom.KeyDown, cmbCustTo.KeyDown, cmbTax.KeyDown, txtFromAmt.KeyDown, dtpFrom.KeyDownEvent
        MoveToNextControl(e)
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If cmbStateFrom.SelectedIndex = -1 Or cmbStateTo.SelectedIndex = -1 Then
            MsgBox("Invalid state selected !", MsgBoxStyle.Exclamation)
            cmbStateFrom.Focus()
            Exit Sub

        ElseIf cmbCityFrom.SelectedIndex = -1 Or cmbCityTo.SelectedIndex = -1 Then
            MsgBox("Invalid city selected !", MsgBoxStyle.Exclamation)
            cmbCityFrom.Focus()
            Exit Sub

        ElseIf cmbCustFrom.SelectedIndex = -1 Or cmbCustTo.SelectedIndex = -1 Then
            MsgBox("Invalid customer selected !", MsgBoxStyle.Exclamation)
            cmbCustFrom.Focus()
            Exit Sub

        ElseIf cmbTax.SelectedIndex = -1 Then
            MsgBox("Invalid Tax selected !", MsgBoxStyle.Exclamation)
            cmbTax.Focus()
            Exit Sub
        End If

        Dim strFilter As String = ""

        If cmbStateFrom.SelectedIndex > 0 Then
            If cmbStateTo.SelectedIndex > 0 Then
                strFilter = " AND {STATE.STATE_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34) & " AND {STATE.STATE_NAME} <= " & Chr(34) & ReplaceApostrophe(cmbStateTo.Text) & Chr(34)
            Else
                strFilter = " AND {STATE.STATE_NAME} >= " & Chr(34) & ReplaceApostrophe(cmbStateFrom.Text) & Chr(34)
            End If
        End If

        If cmbCityFrom.SelectedIndex > 0 Then
            If cmbCityTo.SelectedIndex > 0 Then
                strFilter &= " AND {CITY.Stn_Name} >= " & Chr(34) & ReplaceApostrophe(cmbCityFrom.Text) & Chr(34) & " AND {CITY.Stn_Name} <= " & Chr(34) & ReplaceApostrophe(cmbCityTo.Text) & Chr(34)
            Else
                strFilter &= " AND {CITY.Stn_Name} >= " & Chr(34) & ReplaceApostrophe(cmbCityFrom.Text) & Chr(34)
            End If
        End If

        If cmbCustFrom.SelectedIndex > 0 Then
            If cmbCustTo.SelectedIndex > 0 Then
                strFilter &= " AND {PARTY.LED_NAME} >= " & Chr(34) & cmbCustFrom.Text & Chr(34) & " AND {PARTY.LED_NAME} <= " & Chr(34) & cmbCustTo.Text & Chr(34)
            Else
                strFilter &= " AND {PARTY.LED_NAME} >= " & Chr(34) & cmbCustFrom.Text & Chr(34)
            End If
        End If

        If cmbTax.SelectedIndex > 0 Then
            If rptType = ReportType.PurchSummary_PartyTax Or rptType = ReportType.PurchSummary_PartyWise Or rptType = ReportType.PurchSummary_WithAddress Then
                strFilter &= " AND {View_Purchase.Tax_Key} = '" & cmbTax.SelectedValue & "'"
            Else
                strFilter &= " AND {View_Sales.Tax_Key} = '" & cmbTax.SelectedValue & "'"
            End If
        End If


        Dim formula As New Hashtable

        If rptType = ReportType.SalesSummary_PartyWise Then
            If chkDtls.Checked = False Then
                If rdSalesRtn.Checked Then
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_SalesSumPartySRTN.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_SalesSumParty.rpt"
                End If
            Else
                If rdSalesRtn.Checked Then
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_SalesSumPartyDtlSRTN.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_SalesSumPartyDtl.rpt"
                End If
            End If

            If rdsales.Checked Then
                strFilter &= " And {View_Sales.Trj_Type} ='Sales'"
            ElseIf rdSalesRtn.Checked Then
                strFilter &= " And {View_Sales.Trj_Type} <>'Sales'"
            End If

            strFilter &= " And {View_Sales.Bill_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And {View_Sales.Bill_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
            ReportParameters.rptFilter = "{View_Sales.CoBr_Id} = '" & SelBranchId & "' And {View_Sales.FcYr_Id} = '" & SelYearId & "'" & strFilter

            formula.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            formula.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
            formula.Add("Val#N", Val(txtFromAmt.Text))

        ElseIf rptType = ReportType.SalesSummary_PartyTax Then
            If chkDtls.Checked = False Then
                If rdSalesRtn.Checked Then
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_SalesSumPartyTaxSRTN.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_SalesSumPartyTax.rpt"
                End If
            Else
                If rdSalesRtn.Checked Then
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_SalesSumPartyTaxDtlSRTN.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_SalesSumPartyTaxDtl.rpt"
                End If
            End If

            If rdsales.Checked Then
                strFilter &= " And {View_Sales.Trj_Type} ='Sales'"
            End If

            strFilter &= " And {View_Sales.Bill_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And {View_Sales.Bill_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
            ReportParameters.rptFilter = "{View_Sales.CoBr_Id} = '" & SelBranchId & "' And {View_Sales.FcYr_Id} = '" & SelYearId & "'" & strFilter
            
            formula.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            formula.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
            formula.Add("Val#N", Val(txtFromAmt.Text))

        ElseIf rptType = ReportType.SalesSummary_WithAddress Then
            'ReportParameters.rptFile = ReportPath & "\Accounts\Tax_SalesSumPartyAdd.rpt"
            'strFilter &= " And {View_Sales.Bill_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And {View_Sales.Bill_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
            'ReportParameters.rptFilter = "{View_Sales.CoBr_Id} = '" & SelBranchId & "' And {View_Sales.FcYr_ID} = '" & SelYearId & "'" & strFilter

            'formula.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            'formula.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
            'formula.Add("Val#N", Val(txtFromAmt.Text))

        ElseIf rptType = ReportType.PurchSummary_PartyWise Then
            If chkDtls.Checked = False Then
                If rdSalesRtn.Checked Then
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_PurSumPartyRTN.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_PurSumParty.rpt"
                End If
            Else
                If rdSalesRtn.Checked Then
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_PurSumPartyDtlRTN.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_PurSumPartyDtl.rpt"
                End If
            End If

            If rdsales.Checked Then
                strFilter &= " And {View_Purchase.Trj_Type} ='Purchase'"
            ElseIf rdSalesRtn.Checked Then
                strFilter &= " And {View_Purchase.Trj_Type} <>'Purchase'"
            End If

            strFilter &= " And {View_Purchase.Bill_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And {View_Purchase.Bill_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
            ReportParameters.rptFilter = "{View_Purchase.CoBr_Id} = '" & SelBranchId & "' And {View_Purchase.FcYr_ID} = '" & SelYearId & "'" & strFilter
            
            formula.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            formula.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
            formula.Add("Val#N", Val(txtFromAmt.Text))

        ElseIf rptType = ReportType.PurchSummary_PartyTax Then
            If chkDtls.Checked = False Then
                If rdSalesRtn.Checked Then
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_PurSumPartyTaxRTN.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_PurSumPartyTax.rpt"
                End If
            Else
                If rdSalesRtn.Checked Then
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_PurSumPartyTaxDtlRTN.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Accounts\Tax_PurSumPartyTaxDtl.rpt"
                End If
            End If

            If rdsales.Checked Then
                strFilter &= " And {View_Purchase.Trj_Type} ='Purchase'"
            ElseIf rdSalesRtn.Checked Then
                strFilter &= " And {View_Purchase.Trj_Type} <>'Purchase'"
            End If

            strFilter &= " And {View_Purchase.Bill_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And {View_Purchase.Bill_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
            ReportParameters.rptFilter = "{View_Purchase.CoBr_Id} = '" & SelBranchId & "' And {View_Purchase.FcYr_ID} = '" & SelYearId & "'" & strFilter

            formula.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            formula.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
            formula.Add("Val#N", Val(txtFromAmt.Text))

        ElseIf rptType = ReportType.PurchSummary_WithAddress Then
            'ReportParameters.rptFile = ReportPath & "\Accounts\Tax_PurSumPartyAdd.rpt"
            'strFilter &= " And {View_Purchase.Bill_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And {View_Purchase.Bill_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
            'ReportParameters.rptFilter = "{View_Purchase.CoBr_Id} = '" & SelBranchId & "' And {View_Purchase.FcYr_ID} = '" & SelYearId & "'" & strFilter

            'formula.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            'formula.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))
            'formula.Add("Val#N", Val(txtFromAmt.Text))
        End If

        ReportParameters.rptCaption = Me.Text

        Dim frmrpt As New frmViewReports(formula)
        frmrpt.Show()
    End Sub

    Private Sub cmbCustFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCustFrom.SelectionChangeCommitted
        If cmbCustFrom.SelectedIndex = -1 Then Exit Sub
        cmbCustTo.SelectedIndex = cmbCustFrom.SelectedIndex
    End Sub

    
End Class