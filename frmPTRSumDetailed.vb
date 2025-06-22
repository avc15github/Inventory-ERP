Imports System.Data.SqlClient

Public Class frmPTRSumDetailed
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal strParty1 As String, ByVal strPartyNm1 As String, ByVal StrMonthId1 As String, ByVal intUserId1 As Integer, ByVal blnFlag1 As Boolean, ByVal strFromDt1 As String, ByVal strToDt1 As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        strParty = strParty1
        strPartyNm = strPartyNm1
        StrMonthId = StrMonthId1
        intUserId = intUserId1
        blnFlag = blnFlag1
        strFromDt = strFromDt1
        strToDt = strToDt1
        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    'Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    '    If disposing Then
    '        If Not (components Is Nothing) Then
    '            components.Dispose()
    '        End If
    '    End If
    '    MyBase.Dispose(disposing)
    'End Sub

    'Required by the Windows Form Designer
    Private components1 As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents lblFormCaption As System.Windows.Forms.Label
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dtgPartyDtls As System.Windows.Forms.DataGrid
    Friend WithEvents lblCreditAmt As System.Windows.Forms.Label
    Friend WithEvents lblDebitAmt As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblOpFlag As System.Windows.Forms.Label
    Friend WithEvents lblOpAmt As System.Windows.Forms.Label
    Friend WithEvents lblClFlag As System.Windows.Forms.Label
    Friend WithEvents chkShowBal As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFilters As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDateRange As System.Windows.Forms.Button
    Friend WithEvents btnBillWise As System.Windows.Forms.Button
    Friend WithEvents btnDetailed As System.Windows.Forms.Button
    Friend WithEvents btnMonthly As System.Windows.Forms.Button
    Friend WithEvents grpDateRange As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtpToDate As DateTimePick.DateTimePick
    Friend WithEvents dtpFromDt As DateTimePick.DateTimePick
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnDateCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConfDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents grpFilters As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelFilter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConfFilter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbVoucherType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSelVoucher As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtLedgerName As System.Windows.Forms.TextBox
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents txtChqNo As System.Windows.Forms.TextBox
    Friend WithEvents txtToAmt As NumericTextBox.NumericTextBox
    Friend WithEvents txtFromAmt As NumericTextBox.NumericTextBox
    Friend WithEvents cmbAmount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grpOSDtls As System.Windows.Forms.GroupBox
    Friend WithEvents dtgOSDtls As System.Windows.Forms.DataGrid
    Friend WithEvents chkShowAll As System.Windows.Forms.CheckBox
    Friend WithEvents lblOSFlag As System.Windows.Forms.Label
    Friend WithEvents lblOSTotAmt As System.Windows.Forms.Label
    Friend WithEvents lblOSAdjAmt As System.Windows.Forms.Label
    Friend WithEvents lblOSBalAmt As System.Windows.Forms.Label
    Friend WithEvents grpPymtDtl As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dtgPymtDtl As System.Windows.Forms.DataGrid
    Friend WithEvents lblBalAmt As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnFilters = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnDateRange = New System.Windows.Forms.Button
        Me.btnBillWise = New System.Windows.Forms.Button
        Me.btnDetailed = New System.Windows.Forms.Button
        Me.btnMonthly = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkShowBal = New System.Windows.Forms.CheckBox
        Me.lblOpFlag = New System.Windows.Forms.Label
        Me.lblOpAmt = New System.Windows.Forms.Label
        Me.lblClFlag = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDebitAmt = New System.Windows.Forms.Label
        Me.dtgPartyDtls = New System.Windows.Forms.DataGrid
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.lblCreditAmt = New System.Windows.Forms.Label
        Me.lblBalAmt = New System.Windows.Forms.Label
        Me.grpDateRange = New DevExpress.XtraEditors.GroupControl
        Me.dtpToDate = New DateTimePick.DateTimePick
        Me.dtpFromDt = New DateTimePick.DateTimePick
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.btnDateCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnConfDate = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit
        Me.Label33 = New System.Windows.Forms.Label
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.grpFilters = New DevExpress.XtraEditors.GroupControl
        Me.txtToAmt = New NumericTextBox.NumericTextBox
        Me.txtFromAmt = New NumericTextBox.NumericTextBox
        Me.cmbAmount = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.txtChqNo = New System.Windows.Forms.TextBox
        Me.txtLedgerName = New System.Windows.Forms.TextBox
        Me.cmbVoucherType = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbSelVoucher = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancelFilter = New DevExpress.XtraEditors.SimpleButton
        Me.btnConfFilter = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.grpOSDtls = New System.Windows.Forms.GroupBox
        Me.lblOSFlag = New System.Windows.Forms.Label
        Me.lblOSTotAmt = New System.Windows.Forms.Label
        Me.lblOSAdjAmt = New System.Windows.Forms.Label
        Me.lblOSBalAmt = New System.Windows.Forms.Label
        Me.chkShowAll = New System.Windows.Forms.CheckBox
        Me.dtgOSDtls = New System.Windows.Forms.DataGrid
        Me.grpPymtDtl = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.dtgPymtDtl = New System.Windows.Forms.DataGrid
        Me.grpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgPartyDtls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDateRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDateRange.SuspendLayout()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilters.SuspendLayout()
        CType(Me.cmbAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVoucherType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSelVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOSDtls.SuspendLayout()
        CType(Me.dtgOSDtls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPymtDtl.SuspendLayout()
        CType(Me.dtgPymtDtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Controls.Add(Me.Label4)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.chkShowBal)
        Me.grpMain.Controls.Add(Me.lblOpFlag)
        Me.grpMain.Controls.Add(Me.lblOpAmt)
        Me.grpMain.Controls.Add(Me.lblClFlag)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.lblDebitAmt)
        Me.grpMain.Controls.Add(Me.dtgPartyDtls)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Controls.Add(Me.lblCreditAmt)
        Me.grpMain.Controls.Add(Me.lblBalAmt)
        Me.grpMain.Location = New System.Drawing.Point(0, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(1080, 607)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnFilters)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnDateRange)
        Me.Panel1.Controls.Add(Me.btnBillWise)
        Me.Panel1.Controls.Add(Me.btnDetailed)
        Me.Panel1.Controls.Add(Me.btnMonthly)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Location = New System.Drawing.Point(11, 562)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 39)
        Me.Panel1.TabIndex = 130
        '
        'btnFilters
        '
        Me.btnFilters.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilters.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFilters.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFilters.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilters.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnFilters.Location = New System.Drawing.Point(821, 5)
        Me.btnFilters.Name = "btnFilters"
        Me.btnFilters.Size = New System.Drawing.Size(92, 28)
        Me.btnFilters.TabIndex = 5
        Me.btnFilters.Text = "&Filters"
        Me.btnFilters.UseVisualStyleBackColor = False
        Me.btnFilters.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnRefresh.Location = New System.Drawing.Point(667, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 28)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Visible = False
        '
        'btnDateRange
        '
        Me.btnDateRange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDateRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDateRange.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDateRange.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDateRange.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnDateRange.Location = New System.Drawing.Point(9, 5)
        Me.btnDateRange.Name = "btnDateRange"
        Me.btnDateRange.Size = New System.Drawing.Size(95, 28)
        Me.btnDateRange.TabIndex = 0
        Me.btnDateRange.Text = "&Date Range"
        Me.btnDateRange.UseVisualStyleBackColor = False
        Me.btnDateRange.Visible = False
        '
        'btnBillWise
        '
        Me.btnBillWise.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBillWise.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBillWise.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBillWise.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillWise.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnBillWise.Location = New System.Drawing.Point(508, 5)
        Me.btnBillWise.Name = "btnBillWise"
        Me.btnBillWise.Size = New System.Drawing.Size(95, 28)
        Me.btnBillWise.TabIndex = 3
        Me.btnBillWise.Text = "&Bill Wise"
        Me.btnBillWise.UseVisualStyleBackColor = False
        Me.btnBillWise.Visible = False
        '
        'btnDetailed
        '
        Me.btnDetailed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetailed.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDetailed.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDetailed.Enabled = False
        Me.btnDetailed.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetailed.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnDetailed.Location = New System.Drawing.Point(343, 5)
        Me.btnDetailed.Name = "btnDetailed"
        Me.btnDetailed.Size = New System.Drawing.Size(91, 29)
        Me.btnDetailed.TabIndex = 2
        Me.btnDetailed.Text = "D&etailed"
        Me.btnDetailed.UseVisualStyleBackColor = False
        Me.btnDetailed.Visible = False
        '
        'btnMonthly
        '
        Me.btnMonthly.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMonthly.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMonthly.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthly.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnMonthly.Location = New System.Drawing.Point(182, 5)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(95, 28)
        Me.btnMonthly.TabIndex = 1
        Me.btnMonthly.Text = "&Monthly"
        Me.btnMonthly.UseVisualStyleBackColor = False
        Me.btnMonthly.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnExit.Location = New System.Drawing.Point(974, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 29)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(611, 538)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "C/B"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(231, 539)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "O/B"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'chkShowBal
        '
        Me.chkShowBal.AutoSize = True
        Me.chkShowBal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowBal.Location = New System.Drawing.Point(12, 539)
        Me.chkShowBal.Name = "chkShowBal"
        Me.chkShowBal.Size = New System.Drawing.Size(171, 17)
        Me.chkShowBal.TabIndex = 127
        Me.chkShowBal.Text = "Show R&unning Balance"
        Me.chkShowBal.UseVisualStyleBackColor = True
        Me.chkShowBal.Visible = False
        '
        'lblOpFlag
        '
        Me.lblOpFlag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOpFlag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpFlag.ForeColor = System.Drawing.Color.Blue
        Me.lblOpFlag.Location = New System.Drawing.Point(362, 536)
        Me.lblOpFlag.Name = "lblOpFlag"
        Me.lblOpFlag.Size = New System.Drawing.Size(22, 20)
        Me.lblOpFlag.TabIndex = 126
        Me.lblOpFlag.Text = "Dr"
        Me.lblOpFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpFlag.Visible = False
        '
        'lblOpAmt
        '
        Me.lblOpAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOpAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOpAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblOpAmt.Location = New System.Drawing.Point(263, 536)
        Me.lblOpAmt.Name = "lblOpAmt"
        Me.lblOpAmt.Size = New System.Drawing.Size(99, 20)
        Me.lblOpAmt.TabIndex = 125
        Me.lblOpAmt.Text = "0"
        Me.lblOpAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpAmt.Visible = False
        '
        'lblClFlag
        '
        Me.lblClFlag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblClFlag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClFlag.ForeColor = System.Drawing.Color.Blue
        Me.lblClFlag.Location = New System.Drawing.Point(743, 536)
        Me.lblClFlag.Name = "lblClFlag"
        Me.lblClFlag.Size = New System.Drawing.Size(22, 20)
        Me.lblClFlag.TabIndex = 124
        Me.lblClFlag.Text = "Dr"
        Me.lblClFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblClFlag.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1065, 25)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Detailed"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDebitAmt
        '
        Me.lblDebitAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDebitAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDebitAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebitAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblDebitAmt.Location = New System.Drawing.Point(401, 536)
        Me.lblDebitAmt.Name = "lblDebitAmt"
        Me.lblDebitAmt.Size = New System.Drawing.Size(93, 20)
        Me.lblDebitAmt.TabIndex = 119
        Me.lblDebitAmt.Text = "0"
        Me.lblDebitAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDebitAmt.Visible = False
        '
        'dtgPartyDtls
        '
        Me.dtgPartyDtls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgPartyDtls.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyDtls.CaptionText = "Detailed"
        Me.dtgPartyDtls.DataMember = ""
        Me.dtgPartyDtls.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyDtls.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgPartyDtls.Location = New System.Drawing.Point(7, 65)
        Me.dtgPartyDtls.Name = "dtgPartyDtls"
        Me.dtgPartyDtls.Size = New System.Drawing.Size(1068, 468)
        Me.dtgPartyDtls.TabIndex = 1
        '
        'lblFormCaption
        '
        Me.lblFormCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFormCaption.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormCaption.ForeColor = System.Drawing.Color.Navy
        Me.lblFormCaption.Location = New System.Drawing.Point(8, 9)
        Me.lblFormCaption.Name = "lblFormCaption"
        Me.lblFormCaption.Size = New System.Drawing.Size(1065, 25)
        Me.lblFormCaption.TabIndex = 0
        Me.lblFormCaption.Text = "Pending Documents"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCreditAmt
        '
        Me.lblCreditAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCreditAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCreditAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblCreditAmt.Location = New System.Drawing.Point(511, 536)
        Me.lblCreditAmt.Name = "lblCreditAmt"
        Me.lblCreditAmt.Size = New System.Drawing.Size(93, 20)
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
        Me.lblBalAmt.Location = New System.Drawing.Point(643, 536)
        Me.lblBalAmt.Name = "lblBalAmt"
        Me.lblBalAmt.Size = New System.Drawing.Size(99, 20)
        Me.lblBalAmt.TabIndex = 119
        Me.lblBalAmt.Text = "0"
        Me.lblBalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBalAmt.Visible = False
        '
        'grpDateRange
        '
        Me.grpDateRange.AccessibleName = ""
        Me.grpDateRange.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.grpDateRange.Appearance.Options.UseBackColor = True
        Me.grpDateRange.AppearanceCaption.BackColor = System.Drawing.Color.White
        Me.grpDateRange.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpDateRange.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.grpDateRange.AppearanceCaption.Options.UseBackColor = True
        Me.grpDateRange.AppearanceCaption.Options.UseFont = True
        Me.grpDateRange.AppearanceCaption.Options.UseForeColor = True
        Me.grpDateRange.Controls.Add(Me.dtpToDate)
        Me.grpDateRange.Controls.Add(Me.dtpFromDt)
        Me.grpDateRange.Controls.Add(Me.Label28)
        Me.grpDateRange.Controls.Add(Me.Label31)
        Me.grpDateRange.Controls.Add(Me.btnDateCancel)
        Me.grpDateRange.Controls.Add(Me.btnConfDate)
        Me.grpDateRange.Controls.Add(Me.TextEdit10)
        Me.grpDateRange.Controls.Add(Me.Label33)
        Me.grpDateRange.Controls.Add(Me.TextEdit11)
        Me.grpDateRange.Controls.Add(Me.TextEdit12)
        Me.grpDateRange.Controls.Add(Me.TextBox6)
        Me.grpDateRange.Location = New System.Drawing.Point(381, 243)
        Me.grpDateRange.LookAndFeel.SkinName = "Caramel"
        Me.grpDateRange.Name = "grpDateRange"
        Me.grpDateRange.Size = New System.Drawing.Size(322, 127)
        Me.grpDateRange.TabIndex = 0
        Me.grpDateRange.TabStop = True
        Me.grpDateRange.Text = "Date Range"
        Me.grpDateRange.Visible = False
        '
        'dtpToDate
        '
        Me.dtpToDate.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Location = New System.Drawing.Point(227, 38)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(82, 22)
        Me.dtpToDate.TabIndex = 3
        Me.dtpToDate.Tag = "To Date"
        Me.dtpToDate.Value = New Date(2018, 7, 2, 0, 0, 0, 0)
        '
        'dtpFromDt
        '
        Me.dtpFromDt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDt.Location = New System.Drawing.Point(74, 38)
        Me.dtpFromDt.Name = "dtpFromDt"
        Me.dtpFromDt.Size = New System.Drawing.Size(82, 22)
        Me.dtpFromDt.TabIndex = 1
        Me.dtpFromDt.Tag = "From Date"
        Me.dtpFromDt.Value = New Date(2018, 7, 2, 0, 0, 0, 0)
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(22, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(41, 17)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "From "
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(190, 41)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(22, 17)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "To"
        '
        'btnDateCancel
        '
        Me.btnDateCancel.Appearance.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDateCancel.Appearance.Options.UseFont = True
        Me.btnDateCancel.Location = New System.Drawing.Point(183, 86)
        Me.btnDateCancel.LookAndFeel.SkinName = "Money Twins"
        Me.btnDateCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDateCancel.Name = "btnDateCancel"
        Me.btnDateCancel.Size = New System.Drawing.Size(55, 25)
        Me.btnDateCancel.TabIndex = 5
        Me.btnDateCancel.Text = "Cancel"
        '
        'btnConfDate
        '
        Me.btnConfDate.Appearance.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfDate.Appearance.Options.UseFont = True
        Me.btnConfDate.Location = New System.Drawing.Point(94, 86)
        Me.btnConfDate.LookAndFeel.SkinName = "Money Twins"
        Me.btnConfDate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnConfDate.Name = "btnConfDate"
        Me.btnConfDate.Size = New System.Drawing.Size(55, 25)
        Me.btnConfDate.TabIndex = 4
        Me.btnConfDate.Text = "Confirm"
        '
        'TextEdit10
        '
        Me.TextEdit10.EditValue = "0"
        Me.TextEdit10.EnterMoveNextControl = True
        Me.TextEdit10.Location = New System.Drawing.Point(495, 186)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit10.Properties.Appearance.Options.UseFont = True
        Me.TextEdit10.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit10.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit10.Properties.Mask.EditMask = "n2"
        Me.TextEdit10.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit10.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit10.Size = New System.Drawing.Size(24, 21)
        Me.TextEdit10.TabIndex = 30
        Me.TextEdit10.Tag = "Mark Up"
        Me.TextEdit10.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(525, 209)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 14)
        Me.Label33.TabIndex = 61
        Me.Label33.Text = "Type"
        Me.Label33.Visible = False
        '
        'TextEdit11
        '
        Me.TextEdit11.EditValue = "0"
        Me.TextEdit11.EnterMoveNextControl = True
        Me.TextEdit11.Location = New System.Drawing.Point(586, 184)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit11.Properties.Appearance.Options.UseFont = True
        Me.TextEdit11.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit11.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit11.Properties.Mask.EditMask = "n2"
        Me.TextEdit11.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit11.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit11.Size = New System.Drawing.Size(23, 21)
        Me.TextEdit11.TabIndex = 44
        Me.TextEdit11.Tag = "Sale Rate"
        '
        'TextEdit12
        '
        Me.TextEdit12.EditValue = "0"
        Me.TextEdit12.EnterMoveNextControl = True
        Me.TextEdit12.Location = New System.Drawing.Point(562, 186)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit12.Properties.Appearance.Options.UseFont = True
        Me.TextEdit12.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit12.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit12.Properties.Mask.EditMask = "n2"
        Me.TextEdit12.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit12.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit12.Size = New System.Drawing.Size(18, 21)
        Me.TextEdit12.TabIndex = 40
        Me.TextEdit12.Tag = "WSP"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(655, 185)
        Me.TextBox6.MaxLength = 15
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(24, 22)
        Me.TextBox6.TabIndex = 11
        Me.TextBox6.Tag = "Image"
        Me.TextBox6.Visible = False
        '
        'grpFilters
        '
        Me.grpFilters.AccessibleName = ""
        Me.grpFilters.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.grpFilters.Appearance.Options.UseBackColor = True
        Me.grpFilters.AppearanceCaption.BackColor = System.Drawing.Color.White
        Me.grpFilters.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpFilters.AppearanceCaption.ForeColor = System.Drawing.Color.Blue
        Me.grpFilters.AppearanceCaption.Options.UseBackColor = True
        Me.grpFilters.AppearanceCaption.Options.UseFont = True
        Me.grpFilters.AppearanceCaption.Options.UseForeColor = True
        Me.grpFilters.Controls.Add(Me.txtToAmt)
        Me.grpFilters.Controls.Add(Me.txtFromAmt)
        Me.grpFilters.Controls.Add(Me.cmbAmount)
        Me.grpFilters.Controls.Add(Me.txtNarration)
        Me.grpFilters.Controls.Add(Me.txtChqNo)
        Me.grpFilters.Controls.Add(Me.txtLedgerName)
        Me.grpFilters.Controls.Add(Me.cmbVoucherType)
        Me.grpFilters.Controls.Add(Me.cmbSelVoucher)
        Me.grpFilters.Controls.Add(Me.Label10)
        Me.grpFilters.Controls.Add(Me.Label9)
        Me.grpFilters.Controls.Add(Me.Label8)
        Me.grpFilters.Controls.Add(Me.Label7)
        Me.grpFilters.Controls.Add(Me.Label5)
        Me.grpFilters.Controls.Add(Me.Label1)
        Me.grpFilters.Controls.Add(Me.btnCancelFilter)
        Me.grpFilters.Controls.Add(Me.btnConfFilter)
        Me.grpFilters.Controls.Add(Me.TextEdit1)
        Me.grpFilters.Controls.Add(Me.Label6)
        Me.grpFilters.Controls.Add(Me.TextEdit2)
        Me.grpFilters.Controls.Add(Me.TextEdit3)
        Me.grpFilters.Controls.Add(Me.TextBox1)
        Me.grpFilters.Location = New System.Drawing.Point(397, 189)
        Me.grpFilters.LookAndFeel.SkinName = "Caramel"
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(360, 237)
        Me.grpFilters.TabIndex = 0
        Me.grpFilters.TabStop = True
        Me.grpFilters.Text = "Ledger Filters"
        Me.grpFilters.Visible = False
        '
        'txtToAmt
        '
        Me.txtToAmt.AllowAlphabets = False
        Me.txtToAmt.AllowMoveToNextControl = False
        Me.txtToAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtToAmt.EditValue = 0
        Me.txtToAmt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToAmt.Location = New System.Drawing.Point(279, 114)
        Me.txtToAmt.Name = "txtToAmt"
        Me.txtToAmt.Size = New System.Drawing.Size(75, 22)
        Me.txtToAmt.TabIndex = 9
        Me.txtToAmt.Tag = "Amt To"
        Me.txtToAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFromAmt
        '
        Me.txtFromAmt.AllowAlphabets = False
        Me.txtFromAmt.AllowMoveToNextControl = False
        Me.txtFromAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFromAmt.EditValue = 0
        Me.txtFromAmt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromAmt.Location = New System.Drawing.Point(196, 114)
        Me.txtFromAmt.Name = "txtFromAmt"
        Me.txtFromAmt.Size = New System.Drawing.Size(75, 22)
        Me.txtFromAmt.TabIndex = 8
        Me.txtFromAmt.Tag = "Amt From"
        Me.txtFromAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbAmount
        '
        Me.cmbAmount.EditValue = "-- ALL --"
        Me.cmbAmount.Location = New System.Drawing.Point(120, 114)
        Me.cmbAmount.Name = "cmbAmount"
        Me.cmbAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAmount.Properties.Items.AddRange(New Object() {"-- ALL --", "=", ">", "<", "Range"})
        Me.cmbAmount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbAmount.Size = New System.Drawing.Size(70, 20)
        Me.cmbAmount.TabIndex = 7
        Me.cmbAmount.Tag = "Amount"
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(120, 168)
        Me.txtNarration.MaxLength = 20
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(235, 22)
        Me.txtNarration.TabIndex = 13
        Me.txtNarration.Tag = "Narration"
        '
        'txtChqNo
        '
        Me.txtChqNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChqNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqNo.Location = New System.Drawing.Point(120, 140)
        Me.txtChqNo.MaxLength = 20
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(114, 22)
        Me.txtChqNo.TabIndex = 11
        Me.txtChqNo.Tag = "Chq No."
        '
        'txtLedgerName
        '
        Me.txtLedgerName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLedgerName.Location = New System.Drawing.Point(120, 88)
        Me.txtLedgerName.Name = "txtLedgerName"
        Me.txtLedgerName.Size = New System.Drawing.Size(235, 22)
        Me.txtLedgerName.TabIndex = 5
        '
        'cmbVoucherType
        '
        Appearance1.FontData.Name = "Verdana"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.cmbVoucherType.Appearance = Appearance1
        Me.cmbVoucherType.AutoComplete = True
        Me.cmbVoucherType.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbVoucherType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbVoucherType.FlatMode = True
        Me.cmbVoucherType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVoucherType.Location = New System.Drawing.Point(120, 63)
        Me.cmbVoucherType.Name = "cmbVoucherType"
        Me.cmbVoucherType.Size = New System.Drawing.Size(147, 20)
        Me.cmbVoucherType.TabIndex = 3
        Me.cmbVoucherType.Tag = "Voucher Type"
        '
        'cmbSelVoucher
        '
        Appearance2.FontData.Name = "Verdana"
        Appearance2.FontData.SizeInPoints = 8.0!
        Me.cmbSelVoucher.Appearance = Appearance2
        Me.cmbSelVoucher.AutoComplete = True
        Me.cmbSelVoucher.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbSelVoucher.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSelVoucher.FlatMode = True
        Me.cmbSelVoucher.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelVoucher.Location = New System.Drawing.Point(120, 37)
        Me.cmbSelVoucher.Name = "cmbSelVoucher"
        Me.cmbSelVoucher.Size = New System.Drawing.Size(147, 20)
        Me.cmbSelVoucher.TabIndex = 1
        Me.cmbSelVoucher.Tag = "Select Vouchers"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 14)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Narration"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Cheque No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 14)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Ledger Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Voucher Types"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Vouchers"
        '
        'btnCancelFilter
        '
        Me.btnCancelFilter.Appearance.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelFilter.Appearance.Options.UseFont = True
        Me.btnCancelFilter.Location = New System.Drawing.Point(216, 204)
        Me.btnCancelFilter.LookAndFeel.SkinName = "Money Twins"
        Me.btnCancelFilter.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancelFilter.Name = "btnCancelFilter"
        Me.btnCancelFilter.Size = New System.Drawing.Size(55, 25)
        Me.btnCancelFilter.TabIndex = 15
        Me.btnCancelFilter.Text = "Cancel"
        '
        'btnConfFilter
        '
        Me.btnConfFilter.Appearance.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfFilter.Appearance.Options.UseFont = True
        Me.btnConfFilter.Location = New System.Drawing.Point(122, 204)
        Me.btnConfFilter.LookAndFeel.SkinName = "Money Twins"
        Me.btnConfFilter.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnConfFilter.Name = "btnConfFilter"
        Me.btnConfFilter.Size = New System.Drawing.Size(55, 25)
        Me.btnConfFilter.TabIndex = 14
        Me.btnConfFilter.Text = "Confirm"
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "0"
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(495, 186)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.Mask.EditMask = "n2"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit1.Size = New System.Drawing.Size(24, 21)
        Me.TextEdit1.TabIndex = 30
        Me.TextEdit1.Tag = "Mark Up"
        Me.TextEdit1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(525, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 14)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Type"
        Me.Label6.Visible = False
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = "0"
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(586, 184)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit2.Properties.Mask.EditMask = "n2"
        Me.TextEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit2.Size = New System.Drawing.Size(23, 21)
        Me.TextEdit2.TabIndex = 44
        Me.TextEdit2.Tag = "Sale Rate"
        '
        'TextEdit3
        '
        Me.TextEdit3.EditValue = "0"
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(562, 186)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit3.Properties.Mask.EditMask = "n2"
        Me.TextEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit3.Size = New System.Drawing.Size(18, 21)
        Me.TextEdit3.TabIndex = 40
        Me.TextEdit3.Tag = "WSP"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(655, 185)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(24, 22)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Tag = "Image"
        Me.TextBox1.Visible = False
        '
        'grpOSDtls
        '
        Me.grpOSDtls.Controls.Add(Me.lblOSFlag)
        Me.grpOSDtls.Controls.Add(Me.lblOSTotAmt)
        Me.grpOSDtls.Controls.Add(Me.lblOSAdjAmt)
        Me.grpOSDtls.Controls.Add(Me.lblOSBalAmt)
        Me.grpOSDtls.Controls.Add(Me.chkShowAll)
        Me.grpOSDtls.Controls.Add(Me.dtgOSDtls)
        Me.grpOSDtls.Location = New System.Drawing.Point(7, 62)
        Me.grpOSDtls.Name = "grpOSDtls"
        Me.grpOSDtls.Size = New System.Drawing.Size(1064, 501)
        Me.grpOSDtls.TabIndex = 133
        Me.grpOSDtls.TabStop = False
        Me.grpOSDtls.Visible = False
        '
        'lblOSFlag
        '
        Me.lblOSFlag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOSFlag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSFlag.ForeColor = System.Drawing.Color.Blue
        Me.lblOSFlag.Location = New System.Drawing.Point(717, 471)
        Me.lblOSFlag.Name = "lblOSFlag"
        Me.lblOSFlag.Size = New System.Drawing.Size(22, 20)
        Me.lblOSFlag.TabIndex = 133
        Me.lblOSFlag.Text = "Dr"
        Me.lblOSFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOSFlag.Visible = False
        '
        'lblOSTotAmt
        '
        Me.lblOSTotAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOSTotAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOSTotAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSTotAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblOSTotAmt.Location = New System.Drawing.Point(415, 471)
        Me.lblOSTotAmt.Name = "lblOSTotAmt"
        Me.lblOSTotAmt.Size = New System.Drawing.Size(93, 20)
        Me.lblOSTotAmt.TabIndex = 132
        Me.lblOSTotAmt.Text = "0"
        Me.lblOSTotAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOSTotAmt.Visible = False
        '
        'lblOSAdjAmt
        '
        Me.lblOSAdjAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOSAdjAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOSAdjAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSAdjAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblOSAdjAmt.Location = New System.Drawing.Point(516, 471)
        Me.lblOSAdjAmt.Name = "lblOSAdjAmt"
        Me.lblOSAdjAmt.Size = New System.Drawing.Size(93, 20)
        Me.lblOSAdjAmt.TabIndex = 130
        Me.lblOSAdjAmt.Text = "0"
        Me.lblOSAdjAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOSAdjAmt.Visible = False
        '
        'lblOSBalAmt
        '
        Me.lblOSBalAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOSBalAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOSBalAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSBalAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblOSBalAmt.Location = New System.Drawing.Point(617, 471)
        Me.lblOSBalAmt.Name = "lblOSBalAmt"
        Me.lblOSBalAmt.Size = New System.Drawing.Size(99, 20)
        Me.lblOSBalAmt.TabIndex = 131
        Me.lblOSBalAmt.Text = "0"
        Me.lblOSBalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOSBalAmt.Visible = False
        '
        'chkShowAll
        '
        Me.chkShowAll.AutoSize = True
        Me.chkShowAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowAll.Location = New System.Drawing.Point(10, 470)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.Size = New System.Drawing.Size(112, 17)
        Me.chkShowAll.TabIndex = 128
        Me.chkShowAll.Text = "Show All Bills"
        Me.chkShowAll.UseVisualStyleBackColor = True
        Me.chkShowAll.Visible = False
        '
        'dtgOSDtls
        '
        Me.dtgOSDtls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgOSDtls.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgOSDtls.CaptionText = "Outstanding"
        Me.dtgOSDtls.DataMember = ""
        Me.dtgOSDtls.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgOSDtls.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgOSDtls.Location = New System.Drawing.Point(1, 7)
        Me.dtgOSDtls.Name = "dtgOSDtls"
        Me.dtgOSDtls.Size = New System.Drawing.Size(1065, 451)
        Me.dtgOSDtls.TabIndex = 2
        '
        'grpPymtDtl
        '
        Me.grpPymtDtl.Controls.Add(Me.btnClose)
        Me.grpPymtDtl.Controls.Add(Me.dtgPymtDtl)
        Me.grpPymtDtl.Location = New System.Drawing.Point(12, 95)
        Me.grpPymtDtl.Name = "grpPymtDtl"
        Me.grpPymtDtl.Size = New System.Drawing.Size(1057, 461)
        Me.grpPymtDtl.TabIndex = 136
        Me.grpPymtDtl.TabStop = False
        Me.grpPymtDtl.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnClose.Location = New System.Drawing.Point(975, 428)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 29)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        '
        'dtgPymtDtl
        '
        Me.dtgPymtDtl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgPymtDtl.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPymtDtl.CaptionText = "Payment Bill Detail"
        Me.dtgPymtDtl.DataMember = ""
        Me.dtgPymtDtl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPymtDtl.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPymtDtl.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgPymtDtl.Location = New System.Drawing.Point(4, 5)
        Me.dtgPymtDtl.Name = "dtgPymtDtl"
        Me.dtgPymtDtl.Size = New System.Drawing.Size(1050, 423)
        Me.dtgPymtDtl.TabIndex = 2
        '
        'frmPTRSumDetailed
        '
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1079, 612)
        Me.Controls.Add(Me.grpPymtDtl)
        Me.Controls.Add(Me.grpOSDtls)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.grpDateRange)
        Me.Controls.Add(Me.grpMain)
        Me.MaximizeBox = False
        Me.Name = "frmPTRSumDetailed"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Party Account Detailed"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgPartyDtls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDateRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDateRange.ResumeLayout(False)
        Me.grpDateRange.PerformLayout()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFilters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
        CType(Me.cmbAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVoucherType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSelVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOSDtls.ResumeLayout(False)
        Me.grpOSDtls.PerformLayout()
        CType(Me.dtgOSDtls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPymtDtl.ResumeLayout(False)
        CType(Me.dtgPymtDtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim cmdCommand As SqlCommand
    Dim sdaAdapter As SqlDataAdapter
    Dim strFilter As String
    Dim strParty As String
    Dim strPartyNm As String
    Dim StrMonthId As String
    Dim intUserId As Integer
    Dim blnFlag As Boolean
    Dim blnRecievable As Boolean
    Dim strFromDt As String
    Dim strToDt As String
    Dim dtMonthlyDate As Date
    Dim DtSeries As DataTable
    Dim dtTemp As DataTable
    Dim WithEvents DtOSDtls As DataTable
    Dim WithEvents Details As DataTable
    Dim WithEvents DtPymtDtls As DataTable
    Dim SMSFields As String = ""
    Dim SMSGrpFields As String = ""
    Dim OpBal As Double = 0
    Dim TotDebit As Double = 0
    Dim TotCredit As Double = 0
    Dim TotClosing As Double = 0
    Dim TotAmt As Double = 0
    Dim AdjAmt As Double = 0
    Dim BalAmt As Double = 0
    Dim OSFlag As Double = 0

    Enum GridColumns
        Type
        Doc_No
        Doc_Id
        Doc_dt
        Party_key   '0
        Led_Name
        TotQty
        NetAmt
        UserName
        Brand
        Country
        ApprovalStage
    End Enum

    Enum GridOSCols
        Doc_dt
        Type
        Doc_No
        RefNo
        TotalAmt
        AdjAmt
        BalAmt
        Os_Days
        Due_dt
        Narration
        Flag
        OpDocRef_id
        Doc_Id
        Party_Key
    End Enum

    Enum GridPymtCols
        Doc_dt
        Type
        Doc_No
        AdjAmt
        Flag
        ChqNo
        Narration
        DocRef_id
        Doc_Id
    End Enum

    Private Sub frmPTRSumDetailed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.F5 Then
        '    DisplayFill()
        'End If
        'If Control.ModifierKeys = Keys.Alt And e.KeyCode = Keys.F Then
        '    grpFilters.Visible = True
        'End If
    End Sub

    Private Sub frmCustAcBillWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If blnFlag = True Then
            With cmbSelVoucher.Items
                .Add("ALL Vouchers")
                .Add("Debit Entries")
                .Add("Credit Entries")
            End With
            cmbSelVoucher.DropDownStyle = ComboBoxStyle.DropDownList
            cmbSelVoucher.SelectedIndex = 0

            Query = " Select Distinct Vchr_type as ID, Vchr_type From View_LedgerOnScreen Order By Vchr_type "
            Dim dtVchrType As DataTable = Common.GetDataTableWithAll(Query)

            With cmbVoucherType
                .DataSource = dtVchrType
                .DisplayMember = "Vchr_type"
                .ValueMember = "ID"
            End With
            cmbVoucherType.SelectedIndex = 0
            If blnFlag = True Then
                DisplayFill()
            Else
                DisplayFillPTR()
            End If

        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DisplayGridHeaders()
        Dim Grid As New GridColumnCreateAndFormat("CustAcDetailed")

        With Grid
            .AddColumn("Type", GridColumnCreateAndFormat.enmTypeIdx.StringType, 150, "Type")
            .AddColumn("Doc_No", GridColumnCreateAndFormat.enmTypeIdx.StringType, 250, "Doc No")
            .AddColumn("Doc_Id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "Doc_Id")
            .AddColumn("Doc_dt", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Date")
            .AddColumn("Party_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Party_Key")
            .AddColumn("Led_Name", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Led_Name")
            .AddColumn("TotQty", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "TotQty.")
            .AddColumn("NetAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "NetAmt.")
            .AddColumn("UserName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "UserName")
            .AddColumn("Brand", GridColumnCreateAndFormat.enmTypeIdx.StringType, 120, "Brand")
            .AddColumn("Country", GridColumnCreateAndFormat.enmTypeIdx.StringType, 120, "Country")
            .AddColumn("ApprovalStage", GridColumnCreateAndFormat.enmTypeIdx.StringType, 120, "ApprovalStage")

            .AddColumnToTable()
            Details = .GetTable
            Details.DefaultView.AllowNew = False
            Details.DefaultView.AllowEdit = True
            Details.DefaultView.AllowDelete = False

            dtgPartyDtls.DataSource = Details
            .DisplayGridHeaders(Details, dtgPartyDtls, False)
        End With
    End Sub

    Private Sub dtgPartyAc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgPartyDtls.MouseUp
        Try
            dtgPartyDtls.Select(dtgPartyDtls.CurrentCell.RowNumber)
        Catch ex As IndexOutOfRangeException
            Exit Sub
        End Try
    End Sub

    Private Sub dtgPartyAc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgPartyDtls.DoubleClick
        Dim strType As String
        If dtgPartyDtls.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        strType = dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Type)

        If dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Doc_Id) > 0 Then
            If strType = "Vchr" Then
                Dim frmVchr As frmVoucher
                NewRecordId = "" : frmVchr.blnVchr = True
                NewRecordId = dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Doc_Id)

                Select Case dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Type)
                    Case "Payment"
                        frmVchr = New frmVoucher("PY")
                        frmVchr.Tag = "Payment"
                    Case "Receipt"
                        frmVchr = New frmVoucher("RC")
                        frmVchr.Tag = "Receipt"
                    Case "Debit Note"
                        frmVchr = New frmVoucher("DN")
                        frmVchr.Tag = "Debit Note"
                    Case "Credit Note"
                        frmVchr = New frmVoucher("CN")
                        frmVchr.Tag = "Credit Note"
                    Case "Journal"
                        frmVchr = New frmVoucher("JV")
                        frmVchr.Tag = "Journal"
                    Case "Contra"
                        frmVchr = New frmVoucher("CT")
                        frmVchr.Tag = "Contra"
                    Case "Purchase"
                        frmVchr = New frmVoucher("PV")
                        frmVchr.Tag = "Purchase"
                    Case "Sales"
                        frmVchr = New frmVoucher("SV")
                        frmVchr.Tag = "Sales"
                End Select
                frmVchr.MdiParent = Me.MdiParent
                frmVchr.Show()
                frmVchr.blnVchr = False

            Else

                Select Case dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Type)
                    Case "Sales"
                        Dim frmBill As frmSaleBill
                        NewRecordId = "" : frmBill.blnBill = True
                        NewRecordId = dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Doc_Id)

                        frmBill = New frmSaleBill("A")
                        frmBill.Tag = "Sales Invoice"
                        frmBill.MdiParent = Me.MdiParent
                        frmBill.Show()
                        frmBill.blnBill = False

                    Case "CreditNote"
                        Dim frmCN As frmCN
                        NewRecordId = "" : frmCN.blnCN = True
                        NewRecordId = dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Doc_Id)

                        frmCN = New frmCN
                        frmCN.Tag = "Credit Note"
                        frmCN.MdiParent = Me.MdiParent
                        frmCN.Show()
                        frmCN.blnCN = False

                    Case "Purchase"
                        Dim frmPurch As frmPurchaseBill
                        NewRecordId = "" : frmPurch.blnPurBill = True
                        NewRecordId = dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Doc_Id)

                        frmPurch = New frmPurchaseBill
                        frmPurch.Tag = "Purchase"
                        frmPurch.MdiParent = Me.MdiParent
                        frmPurch.Show()
                        frmPurch.blnPurBill = False

                    Case "SalesReturn"
                        Dim frmSaleRtn As frmSaleRtn
                        NewRecordId = "" : frmSaleRtn.blnSR = True
                        NewRecordId = dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Doc_Id)

                        frmSaleRtn = New frmSaleRtn
                        frmSaleRtn.Tag = "Credit Note"
                        frmSaleRtn.MdiParent = Me.MdiParent
                        frmSaleRtn.Show()
                        frmSaleRtn.blnSR = False

                    Case "PurchaseReturn"
                        Dim frmPurchRtn As frmPurchaseReturn
                        NewRecordId = "" : frmPurchRtn.blnPurRtnBill = True
                        NewRecordId = dtgPartyDtls.Item(dtgPartyDtls.CurrentRowIndex, GridColumns.Doc_Id)

                        frmPurchRtn = New frmPurchaseReturn(frmPurchaseReturn.BarcodeWise.No)
                        frmPurchRtn.Tag = "Purchase"
                        frmPurchRtn.MdiParent = Me.MdiParent
                        frmPurchRtn.Show()
                        frmPurchRtn.blnPurRtnBill = False

                End Select

            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgPartyAc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgPartyDtls.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgPartyAc_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub frmCustAcBillWise_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If blnFlag = False Then
            With cmbSelVoucher.Items
                .Add("ALL Vouchers")
                .Add("Debit Entries")
                .Add("Credit Entries")
            End With
            cmbSelVoucher.DropDownStyle = ComboBoxStyle.DropDownList
            cmbSelVoucher.SelectedIndex = 0

            Query = " Select Distinct Vchr_type as ID, Vchr_type From View_LedgerOnScreen Order By Vchr_type "
            Dim dtVchrType As DataTable = Common.GetDataTableWithAll(Query)

            With cmbVoucherType
                .DataSource = dtVchrType
                .DisplayMember = "Vchr_type"
                .ValueMember = "ID"
            End With
            cmbVoucherType.SelectedIndex = 0

            If blnFlag = True Then
                DisplayFill()
            Else
                DisplayFillPTR()
            End If
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'If keyData = Keys.Enter Then
        '    If Me.ActiveControl.Parent Is CType(dtgPartyAc, DataGrid) Or Me.ActiveControl Is CType(dtgPartyAc, DataGrid) Then
        '        Call dtgPartyAc_DoubleClick(Nothing, Nothing)
        '    End If
        'End If
    End Function

    Private Sub DisplayFill()
        Dim DtTable As New DataTable
        Dim dtFrom, dtTo As DateTime
        Dim strSrchString As String
        dtFrom = AccFromDt
        dtTo = AccToDt
        Details = Nothing : dtgPartyDtls.DataSource = Nothing
        DisplayGridHeaders()
        TotDebit = 0 : TotCredit = 0
        OpBal = 0 : TotClosing = 0


        If strFromDt <> "" Then
            dtFrom = CDate(strFromDt)
            dtTo = CDate(strToDt)
        End If

        dtgPartyDtls.CaptionText = strPartyNm & "  From : " & Format$(dtFrom, "dd/MM/yyyy") & "  To : " & Format$(dtTo, "dd/MM/yyyy")
        If strPartyNm = "2" Then
            Query = "Select Distinct * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type ='" & strParty & "') and Trans_Type in (Select ISnull(Trans_Type,'')Trans_Type from TransForApproval Where Trans_Type<> '') and doc_id not in(Select doc_id from TransApproval where TransApproval.DOc_Id= VW_PTR.Doc_id and TransApproval.Trans_Type=VW_PTR.Trans_Type and ApproveFlag='R' ) and doc_id not in(Select doc_id from TransApproval where TransApproval.DOc_Id= VW_PTR.Doc_id and TransApproval.Trans_Type=VW_PTR.Trans_Type  )" & strSrchString & " and Trans_Type='" & StrMonthId & "'"
        ElseIf strPartyNm = "3" Then
            If StrMonthId = "OS" Then
                Query = " Select Distinct Doc_id,* from ( select  distinct VW_PTR.* from VW_PTR inner join TransApproval on TransApproval.Doc_Id= VW_PTR.Doc_Id  " _
                        & " where CoBr_Id =" & SelBranchId & " and VW_PTR.Trans_Type='OS' and Level_Id=3 and ApproveFlag='A'and TransApproval.Trans_type='SO' and VW_PTR.Doc_Dt='1900-01-01' and TransApproval.Approved_By=" & intUserId & ") A  "
            Else
                Query = " Select Distinct * from  (Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type ='" & strParty & "') " _
                   & " Union all   Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and ledger.approval=0 and level_type='2'))  " _
                   & "  union all Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and level_type='2')) and doc_id in( Select doc_id from TransApproval where TransApproval.Trans_Type=VW_PTR.Trans_Type)) a  where a.doc_id not in (select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type and level_id=3 and ApproveFlag='A' Union all  select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type  and ApprovRejected='R' and ApproveFlag='R')" & strSrchString & "  and Trans_Type in (Select ISnull(Trans_Type,'')Trans_Type from TransForApproval Where Trans_Type<> '')  and Trans_Type= '" & StrMonthId & "'"
            End If
           
        ElseIf strPartyNm = "1" Then
            Dim ReportFilter As String = ""
            'ReportFilter = "Vw_SOApprovalStatusReport.CoBr_Id = '" & SelBranchId & "' And (Vw_SOApprovalStatusReport.SoCreated_By = " & intUserId & " Or Vw_SOApprovalStatusReport.PPCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.JobCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FinCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FabCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.AccCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FinPurCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FabPurCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.AccPurCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.JobIsuCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.PACKINGSLIPCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.PACKINGCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.salebillCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.BomCreated_By = " & intUserId & " ) And Vw_SOApprovalStatusReport.Status <> '0'"
            ''Rohit 04092018
            'If StrMonthId = "SO" Then
            '    Query = " Select 'SalesOrder' Type,SoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,UserName,SOApprovalStage ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where SoCreated_By = " & intUserId & " and Vw_PTRSum.SOApprovalStage<>'3'  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by SoDoc_no,Buyer,UserName,SOApprovalStage,Country,Brand_name"
            'ElseIf StrMonthId = "BM" Then
            '    Query = "Select Distinct cast(BomPrdStyle_Id as varchar(20))+'-'+Style_Code Doc_No,'BOM' Type,'' Led_Name ,0 TotQty ,0 NetAmt ,BOMUSER UserName,BOMApprovalStage ApprovalStage,'' Brand,''Country FROM Vw_PTRSum Where BOMCreated_By = " & intUserId & " and BomApprovalStage<>'3' And BomApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by BOMUSER,BomApprovalStage,BomPrdStyle_Id,Style_Code   "
            'ElseIf StrMonthId = "PP" Then
            '    'Query = "Select 'ProdnPln' Type,PPDOC_No Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,PPuser UserName,PPApprovalStage ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and PPApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by PPDoc_no,Buyer,PPUSER,PPApprovalStage,Country,Brand_name"
            '    Query = "Select 'ProdnPln' Type,PPDOC_No Doc_No,'' Led_Name ,0 TotQty ,0 NetAmt ,PPuser UserName,PPApprovalStage ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and PPApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by PPDoc_no,PPUSER,PPApprovalStage,Country,Brand_name"
            'ElseIf StrMonthId = "JW" Then
            '    Query = "Select 'JobWorkOrder' Type,Job_Docno Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,JobUser UserName,JobApprovalStage ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where JobCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by Job_Docno,Buyer,JobUser,JobApprovalStage,Country,Brand_name "
            'ElseIf StrMonthId = "FP" Then
            '    Query = "Select 'FinPurchaseOrder' Type,FinPoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FinPoUser UserName,FinApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where FinCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FinPoDoc_no,Buyer,FinPoUser,FinApproval,Country,Brand_name "
            'ElseIf StrMonthId = "GP" Then
            '    Query = " Select 'FabPurchaseOrder' Type,FabPoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabPoUser UserName,FabApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where FabCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FabPoDoc_no,Buyer,FabPoUser,FabApproval,Country,Brand_name "
            'ElseIf StrMonthId = "AP" Then
            '    Query = "Select 'AccPurchaseOrder' Type,AccPoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,AccPoUser UserName,TrimApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where AccCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by AccPoDoc_no,Buyer,AccPoUser,TrimApproval,Country,Brand_name "
            'ElseIf StrMonthId = "FI" Then
            '    Query = "Select 'FinishPurchase' Type,FinPurDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FinPurUser UserName,FinPurApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where FinPurCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FinPurDoc_no,Buyer,FinPurUser,FinPurApproval,Country,Brand_name "
            'ElseIf StrMonthId = "GI" Then
            '    Query = "Select 'FabPurchase' Type,FabPurDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabPurUser UserName,FabPurApproval ApprovalStage,Brand_name Brand,Country fROM Vw_PTRSum Where FabPurCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FabPurDoc_no,Buyer,FabPurUser,FabPurApproval,Country,Brand_name "
            'ElseIf StrMonthId = "AI" Then
            '    Query = "Select 'AccPurchase' Type,AccPurDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,AccPurUser UserName,TrimPurApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where AccPurCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by AccPurDoc_no,Buyer,AccPurUser,TrimPurApproval,Country,Brand_name "
            'ElseIf StrMonthId = "JB" Then
            '    Query = "Select 'JobCard' Type,FabIsuDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabIsuUser UserName,FabIsuApproval ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where JobIsuCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FabIsuDoc_no,Buyer,FabIsuUser,FabIsuApproval,Country,Brand_name "
            'ElseIf StrMonthId = "PL" Then
            '    Query = "Select 'PackingSlip' Type,Slip_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,SlipUser UserName,SlipApproval ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PACKINGSLIPCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by Slip_no,Buyer,SlipUser,SlipApproval,Country,Brand_name "
            'ElseIf StrMonthId = "PS" Then
            '    Query = "Select 'PackingList' Type,Challan_No Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,ChallanUser UserName,ChallanApproval ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PACKINGCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by Challan_No,Buyer,ChallanUser,ChallanApproval,Country,Brand_name "
            'ElseIf StrMonthId = "SI" Then
            '    Query = "Select 'SalesInvoice' Type,SaleBill Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,SaleBillUser UserName,SaleBillApproval ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where salebillCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by SaleBill,Buyer,SaleBillUser,SaleBillApproval,Country,Brand_name "
            'End If

            If StrMonthId = "SO" Then
                Query = " Select 'SalesOrder' Type,SoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,UserName,SOApprovalStage ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where SoCreated_By = " & intUserId & " and sodoc_id not in (select doc_id from TransApproval where  Trans_Type='SO' and Level_Id=3 and ApproveFlag='A') and Vw_PTRSum.SOApprovalStage<>'3'  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by SoDoc_no,Buyer,UserName,SOApprovalStage,Country,Brand_name"
            ElseIf StrMonthId = "BM" Then
                Query = "Select Distinct cast(BomPrdStyle_Id as varchar(20))+'-'+Style_Code Doc_No,'BOM' Type,'' Led_Name ,0 TotQty ,0 NetAmt ,BOMUSER UserName,BOMApprovalStage ApprovalStage,'' Brand,''Country FROM Vw_PTRSum Where BOMCreated_By = " & intUserId & " and BomPrdStyle_Id not in (select doc_id from TransApproval where  Trans_Type='BM' and Level_Id=3 and ApproveFlag='A')  and BomApprovalStage<>'3' And BomApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by BOMUSER,BomApprovalStage,BomPrdStyle_Id,Style_Code   "
            ElseIf StrMonthId = "PP" Then
                'Query = "Select 'ProdnPln' Type,PPDOC_No Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,PPuser UserName,PPApprovalStage ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and PPApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by PPDoc_no,Buyer,PPUSER,PPApprovalStage,Country,Brand_name"
                Query = "Select 'ProdnPln' Type,PPDOC_No Doc_No,'' Led_Name ,0 TotQty ,0 NetAmt ,PPuser UserName,PPApprovalStage ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PPCreated_By = " & intUserId & " and PPdoc_id not in (select doc_id from TransApproval where  Trans_Type='PP' and Level_Id=3 and ApproveFlag='A')  and PPApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by PPDoc_no,PPUSER,PPApprovalStage,Country,Brand_name"
            ElseIf StrMonthId = "JW" Then
                Query = "Select 'JobWorkOrder' Type,Job_Docno Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,JobUser UserName,JobApprovalStage ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where JobCreated_By = " & intUserId & "  and Jobdoc_id not in (select doc_id from TransApproval where  Trans_Type='JW' and Level_Id=3 and ApproveFlag='A') and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by Job_Docno,Buyer,JobUser,JobApprovalStage,Country,Brand_name "
            ElseIf StrMonthId = "FP" Then
                Query = "Select 'FinPurchaseOrder' Type,FinPoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FinPoUser UserName,FinApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where FinCreated_By = " & intUserId & "  and FinPODoc_Id not in (select doc_id from TransApproval where  Trans_Type='FP' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FinPoDoc_no,Buyer,FinPoUser,FinApproval,Country,Brand_name "
            ElseIf StrMonthId = "GP" Then
                Query = " Select 'FabPurchaseOrder' Type,FabPoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabPoUser UserName,FabApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where FabCreated_By = " & intUserId & " and FabPODoc_Id not in (select doc_id from TransApproval where  Trans_Type='GP' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FabPoDoc_no,Buyer,FabPoUser,FabApproval,Country,Brand_name "
            ElseIf StrMonthId = "AP" Then
                Query = "Select 'AccPurchaseOrder' Type,AccPoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,AccPoUser UserName,TrimApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where AccCreated_By = " & intUserId & " and AccPODoc_Id not in (select doc_id from TransApproval where  Trans_Type='AP' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by AccPoDoc_no,Buyer,AccPoUser,TrimApproval,Country,Brand_name "
            ElseIf StrMonthId = "FI" Then
                Query = "Select 'FinishPurchase' Type,FinPurDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FinPurUser UserName,FinPurApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where FinPurCreated_By = " & intUserId & "  and PurDoc_Id not in (select doc_id from TransApproval where  Trans_Type='FI' and Level_Id=3 and ApproveFlag='A')   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FinPurDoc_no,Buyer,FinPurUser,FinPurApproval,Country,Brand_name "
            ElseIf StrMonthId = "GI" Then
                Query = "Select 'FabPurchase' Type,FabPurDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabPurUser UserName,FabPurApproval ApprovalStage,Brand_name Brand,Country fROM Vw_PTRSum Where FabPurCreated_By = " & intUserId & " and FabPurDoc_Id not in (select doc_id from TransApproval where  Trans_Type='GI' and Level_Id=3 and ApproveFlag='A')   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FabPurDoc_no,Buyer,FabPurUser,FabPurApproval,Country,Brand_name "
            ElseIf StrMonthId = "AI" Then
                Query = "Select 'AccPurchase' Type,AccPurDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,AccPurUser UserName,TrimPurApproval ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where AccPurCreated_By = " & intUserId & " and AccPurDoc_Id not in (select doc_id from TransApproval where  Trans_Type='AI' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by AccPurDoc_no,Buyer,AccPurUser,TrimPurApproval,Country,Brand_name "
            ElseIf StrMonthId = "JB" Then
                Query = "Select 'JobCard' Type,FabIsuDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabIsuUser UserName,FabIsuApproval ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where JobIsuCreated_By = " & intUserId & "  and FabIsuDoc_Id not in (select doc_id from TransApproval where  Trans_Type='JB' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by FabIsuDoc_no,Buyer,FabIsuUser,FabIsuApproval,Country,Brand_name "
            ElseIf StrMonthId = "PL" Then
                Query = "Select 'PackingSlip' Type,Slip_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,SlipUser UserName,SlipApproval ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PACKINGSLIPCreated_By = " & intUserId & " and packingSlipDoc_id not in (select doc_id from TransApproval where  Trans_Type='PL' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by Slip_no,Buyer,SlipUser,SlipApproval,Country,Brand_name "
            ElseIf StrMonthId = "PS" Then
                Query = "Select 'PackingList' Type,Challan_No Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,ChallanUser UserName,ChallanApproval ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PACKINGCreated_By = " & intUserId & " and PackingDoc_id not in (select doc_id from TransApproval where  Trans_Type='PS' and Level_Id=3 and ApproveFlag='A')   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by Challan_No,Buyer,ChallanUser,ChallanApproval,Country,Brand_name "
            ElseIf StrMonthId = "SI" Then
                Query = "Select 'SalesInvoice' Type,SaleBill Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,SaleBillUser UserName,SaleBillApproval ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where salebillCreated_By = " & intUserId & " and SaleBillDoc_id not in (select doc_id from TransApproval where  Trans_Type='SI' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by SaleBill,Buyer,SaleBillUser,SaleBillApproval,Country,Brand_name "
            End If
        End If

        DtTable = Common.GetDataTable(Query)
        dtgPartyDtls.ReadOnly = False

        Dim PurRow, NewRow As DataRow

        For Each PurRow In DtTable.Rows
            NewRow = Details.NewRow
            NewRow(GridColumns.Type) = PurRow("Type") & ""
            NewRow(GridColumns.Doc_No) = PurRow("Doc_No") & ""
            'NewRow(GridColumns.Doc_dt) = PurRow("Doc_dt") & ""
            'NewRow(GridColumns.Party_key) = PurRow("Party_key") & ""
            NewRow(GridColumns.Party_key) = ""
            NewRow(GridColumns.Led_Name) = PurRow("Led_Name") & ""
            NewRow(GridColumns.TotQty) = PurRow("TotQty")
            NewRow(GridColumns.NetAmt) = PurRow("NetAmt")
            NewRow(GridColumns.UserName) = PurRow("UserName") & ""
            'If strPartyNm = "1" Then
            NewRow(GridColumns.Brand) = PurRow("Brand") & ""
            NewRow(GridColumns.Country) = PurRow("Country") & ""
            NewRow(GridColumns.ApprovalStage) = PurRow("ApprovalStage") & ""

            'End If


            Details.Rows.Add(NewRow)
            Details.AcceptChanges()
            dtgPartyDtls.CurrentRowIndex = Details.Rows.Count - 1
        Next
        dtgPartyDtls.CurrentRowIndex = 0
        dtgPartyDtls.Focus()
        'dtgPartyDtls.Select(dtgPartyDtls.CurrentCell.RowNumber)

    End Sub
    Private Sub DisplayFillPTR()
        Dim DtTable As New DataTable
        Dim dtFrom, dtTo As DateTime
        Dim strSrchString As String
        dtFrom = AccFromDt
        dtTo = AccToDt
        Details = Nothing : dtgPartyDtls.DataSource = Nothing
        DisplayGridHeaders()
        TotDebit = 0 : TotCredit = 0
        OpBal = 0 : TotClosing = 0


        If strFromDt <> "" Then
            dtFrom = CDate(strFromDt)
            dtTo = CDate(strToDt)
        End If

        dtgPartyDtls.CaptionText = strPartyNm & "  From : " & Format$(dtFrom, "dd/MM/yyyy") & "  To : " & Format$(dtTo, "dd/MM/yyyy")
        If strPartyNm = "3" Then
            Query = " Select Distinct * from  (Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type ='" & strParty & "') " _
                    & " Union all   Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and ledger.approval=0 and level_type='2'))  " _
                    & "  union all Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and level_type='2')) and doc_id in( Select doc_id from TransApproval where TransApproval.Trans_Type=VW_PTR.Trans_Type)) a  where a.doc_id not in (select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type and level_id=3 and ApproveFlag='A' Union all  select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type  and ApprovRejected='R' and ApproveFlag='R')" & strSrchString & "  and Trans_Type in (Select ISnull(Trans_Type,'')Trans_Type from TransForApproval Where Trans_Type<> '')  and Trans_Type= '" & StrMonthId & "'"
            'ElseIf strPartyNm = "1" Then
        Else
            Dim ReportFilter As String = ""
            'ReportFilter = "Vw_PTRSum.CoBr_Id = '" & SelBranchId & "' And (Vw_PTRSum.SoCreated_By = " & intUserId & " Or Vw_PTRSum.PPCreated_By = " & intUserId & "  Or Vw_PTRSum.JobCreated_By = " & intUserId & "  Or Vw_PTRSum.FinCreated_By = " & intUserId & "  Or Vw_PTRSum.FabCreated_By = " & intUserId & "  Or Vw_PTRSum.AccCreated_By = " & intUserId & "  Or Vw_PTRSum.FinPurCreated_By = " & intUserId & "  Or Vw_PTRSum.FabPurCreated_By = " & intUserId & "  Or Vw_PTRSum.AccPurCreated_By = " & intUserId & "  Or Vw_PTRSum.JobIsuCreated_By = " & intUserId & "  Or Vw_PTRSum.PACKINGSLIPCreated_By = " & intUserId & "  Or Vw_PTRSum.PACKINGCreated_By = " & intUserId & "  Or Vw_PTRSum.salebillCreated_By = " & intUserId & "  Or Vw_PTRSum.BomCreated_By = " & intUserId & " ) And Vw_PTRSum.Status <> '0'"

            '''Rohit 04092018

            'If StrMonthId = "SO" Then
            '    'Query = " Select 'SalesOrder' Type,SoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,UserName,SOApprovalStage ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where SoCreated_By = " & intUserId & " and Vw_PTRSum.SOApprovalStage<>'3'  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by SoDoc_no,Buyer,UserName,SOApprovalStage,Country,Brand_name"
            '    Query = " Select 'SalesOrder' Type,'' Doc_No,'' Led_Name ,0 TotQty ,0 NetAmt ,''UserName,'' ApprovalStage,'' Brand,''Country  "
            'ElseIf StrMonthId = "BM" Then
            '    'Query = "Select 'BOM' Type,SoDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,'' Led_Name ,0 TotQty ,0 NetAmt ,BOMUSER UserName,'' ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where  SOCreated_By = " & intUserId & "  and BomPrdStyle_Id=0  and BomApprovalStage<>'NA' and Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
            '    Query = "Select 'BOM' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name Brand,Country.Cont_Name Country,Ledger.Led_Name from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Ledger on Ledger.Led_key=SalesOrder.Cust_key Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key Inner Join Shade on Shade.Shade_Key=SalesOrderDtl.Shade_key Inner Join Type on Type.Type_Key=SalesOrderDtl.Type_Key Inner Join Brand on Brand.Brand_Key=Style.Brand_Key Inner Join Item on Item.Item_key=SalesOrderdtl.Item_Key Inner Join Users on Users.User_Id=SalesOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where  (SalesOrderDtl.Style_key not in (Select BomPrdStyle.Style_key from BomPrdStyle) And SalesOrderDtl.Type_Key not in(Select BomPrdStyle.Type_Key from BomPrdStyle) And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle)  And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle))  and MFGTrd='M'  And SalesOrder.Created_By = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "PP" Then
            '    Query = "Select 'ProdnPln' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name Brand,Country.Cont_Name Country,Ledger.Led_Name from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Ledger on Ledger.Led_key=SalesOrder.Cust_key Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key Inner Join Shade on Shade.Shade_Key=SalesOrderDtl.Shade_key Inner Join Type on Type.Type_Key=SalesOrderDtl.Type_Key Inner Join Brand on Brand.Brand_Key=Style.Brand_Key Inner Join Item on Item.Item_key=SalesOrderdtl.Item_Key Inner Join Users on Users.User_Id=SalesOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where   docdtl_id not in (Select So_DocDtlId from ProdnPlnDtl)  and MFGTrd='M'  And SalesOrder.Created_By = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "JW" Then
            '    Query = "Select 'JobWorkOrder' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from ProdnPlnDtl Inner Join ProdnPln on ProdnPln.Doc_id=ProdnPlnDtl.Doc_id Inner Join Ledger on Ledger.Led_key=ProdnPln.Party_Key  Inner Join Style on Style.Style_key=ProdnPlndtl.Style_Key  Inner Join Shade on Shade.Shade_Key=ProdnPlnDtl.Shade_key Inner Join Type on Type.Type_Key=ProdnPlnDtl.Type_Key    Inner Join Brand on Brand.Brand_Key=Style.Brand_Key    Inner Join Item on Item.Item_key=ProdnPlndtl.Item_Key Inner Join Users on Users.User_Id=ProdnPln.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key  inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where  docdtl_id not in (Select PP_DocDtlId from joborderdtl) And ProdnPln.Created_by= " & intUserId & "  and ProdnPln.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "FP" Then
            '    'Query = "Select 'FinPurchaseOrder' Type,SoDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FinPoUser UserName,'' ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where SOCreated_By = " & intUserId & "  and FinPoDoc_id=0 and PPApprovalStage='NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
            '    Query = " select 'FinPurchaseOrder' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,''ApprovalStage,Brand_name Brand,Country.Cont_Name Country,Ledger.Led_Name from SalesOrderDtl 	Inner Join SalesOrder on SalesOrder.Doc_Id=SalesOrderDtl.Doc_id Inner Join Ledger on Ledger.Led_key=SalesOrder.Cust_Key    Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key   Inner Join Shade on Shade.Shade_Key=SalesOrderDtl.Shade_key   Inner Join Type on Type.Type_Key=SalesOrderDtl.Type_Key     Inner Join Brand on Brand.Brand_Key=Style.Brand_Key    Inner Join Item on Item.Item_key=SalesOrderdtl.Item_Key Inner Join Users on Users.User_Id=SalesOrder.Created_by   Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key  inner join  station on ledger.Ostn_key = station.stn_key   inner join state on station.state_key = state.state_key   inner join country on state.cont_key = country.cont_key   	where MFGTRD='T' 	and DocDtl_id not in (Select SODocDtl_id from PurOrderDtl )  And SalesOrder.Created_by= " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "GP" Then
            '    'Query = " Select 'FabPurchaseOrder' Type,PPDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabPoUser UserName,'' ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and FabPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
            '    Query = "Select 'FabPurchaseOrder' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from prodnplnfab  Inner Join ProdnPlnDtl on ProdnPlnDtl.DocDtl_Id=ProdnPlnFab.DocDtl_id Inner Join ProdnPln on ProdnPln.Doc_id=ProdnPlnDtl.Doc_id Inner Join Ledger on Ledger.Led_key=ProdnPln.Party_Key Inner Join Style on Style.Style_key=ProdnPlnFab.Style_Key  Inner Join Shade on Shade.Shade_Key=ProdnPlnFab.Shade_key Inner Join Type on Type.Type_Key=ProdnPlnFab.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner Join Item on Item.Item_key=ProdnPlndtl.Item_Key Inner Join Users on Users.User_Id=ProdnPln.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where  ProdnPlnFab.style_key <>'' and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl) And ProdnPln.Created_by= " & intUserId & "  and ProdnPln.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "AP" Then
            '    'Query = "Select 'AccPurchaseOrder' Type,PPDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,AccPoUser UserName,'' ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and AccPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
            '    Query = "Select 'AccPurchaseOrder' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from prodnplnfab  Inner Join ProdnPlnDtl on ProdnPlnDtl.DocDtl_Id=ProdnPlnFab.DocDtl_id Inner Join ProdnPln on ProdnPln.Doc_id=ProdnPlnDtl.Doc_id Inner Join Ledger on Ledger.Led_key=ProdnPln.Party_Key Inner Join Style on Style.Style_key=ProdnPlnFab.Style_Key  Inner Join Shade on Shade.Shade_Key=ProdnPlnFab.Shade_key Inner Join Type on Type.Type_Key=ProdnPlnFab.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner Join Item on Item.Item_key=ProdnPlndtl.Item_Key Inner Join Users on Users.User_Id=ProdnPln.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where  ProdnPlnFab.style_key ='' and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl) And ProdnPln.Created_by= " & intUserId & "  and ProdnPln.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "FI" Then
            '    'Query = "Select 'FinishPurchase' Type,FinPoDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FinPurUser UserName,'' ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where FinCreated_By = " & intUserId & "  and FinPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
            '    Query = "Select 'FinishPurchase' As Type,Doc_no+'--'+Style.Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PurOrderDtl  Inner Join PurOrder   on PurOrderDtl.Doc_id=PurOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=PurOrder.Supl_Key Inner Join Style on Style.Style_key=PurOrderDtl.Style_Key  Inner Join Shade on Shade.Shade_Key=PurOrderDtl.Shade_key Inner Join Type on Type.Type_Key=PurOrderDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner Join Item on Item.Item_key=PurOrderDtl.Item_Key Inner Join Users on Users.User_Id=PurOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on  ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where Po_Type='F' and DocDtl_Id not in (Select PodtlId from PurchaseDtl) And PurOrder.Created_By = " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "GI" Then
            '    'Query = "Select 'FabPurchase' Type,FabPoDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabPurUser UserName,'' ApprovalStage,Brand_name Brand,Country fROM Vw_PTRSum Where FabCreated_By = " & intUserId & "  and FabPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
            '    Query = "Select 'FabPurchase' As Type,Doc_no+'--'+Style.Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PurOrderDtl  Inner Join PurOrder   on PurOrderDtl.Doc_id=PurOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=PurOrder.Supl_Key Inner Join Style on Style.Style_key=PurOrderDtl.Style_Key  Inner Join Shade on Shade.Shade_Key=PurOrderDtl.Shade_key Inner Join Type on Type.Type_Key=PurOrderDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner Join Item on Item.Item_key=PurOrderDtl.Item_Key Inner Join Users on Users.User_Id=PurOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on  ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where Po_Type='G' and DocDtl_Id not in (Select PodtlId from PurchaseDtl) And PurOrder.Created_By = " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "AI" Then
            '    Query = "Select 'AccPurchase' As Type,Doc_no+'--'+Style.Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PurOrderDtl  Inner Join PurOrder   on PurOrderDtl.Doc_id=PurOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=PurOrder.Supl_Key Inner Join Style on Style.Style_key=PurOrderDtl.Style_Key  Inner Join Shade on Shade.Shade_Key=PurOrderDtl.Shade_key Inner Join Type on Type.Type_Key=PurOrderDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner Join Item on Item.Item_key=PurOrderDtl.Item_Key Inner Join Users on Users.User_Id=PurOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on  ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where Po_Type='A' and DocDtl_Id not in (Select PodtlId from PurchaseDtl) And PurOrder.Created_By = " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "JB" Then
            '    'Query = "Select 'JobCard' Type,Job_Docno+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,UserName,'' ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where JobCreated_By = " & intUserId & "  and FabIsuDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
            '    Query = "Select 'JobCard' Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from jobOrderDtl Inner Join jobOrder   on jobOrderDtl.Doc_id=jobOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=jobOrder.Party_key   Inner Join Style on Style.Style_key=jobOrderDtl.Style_Key    Inner Join Shade on Shade.Shade_Key=jobOrderDtl.Shade_key Inner Join Type on Type.Type_Key=jobOrderDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner  Join Item on Item.Item_key=jobOrderDtl.Item_Key Inner Join Users on Users.User_Id=jobOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join   station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where DocDtl_Id not in (Select JobWorkDocDtl_Id from ProcIsuDtl ) And jobOrder.Created_By = " & intUserId & "  and jobOrder.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "PL" Then
            '    Query = "Select 'PackingSlip' Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from SalesOrderDtl Inner Join SalesOrder   on SalesOrderDtl.Doc_id=SalesOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=SalesOrder.Cust_key   Inner Join Style on Style.Style_key=SalesOrderDtl.Style_Key    Inner Join Shade on Shade.Shade_Key=SalesOrderDtl.Shade_key Inner Join Type on Type.Type_Key=SalesOrderDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner  Join Item on Item.Item_key=SalesOrderDtl.Item_Key Inner Join Users on Users.User_Id=SalesOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join   station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where DocDtl_Id not in (Select Sodocdtl_id from PackingSlipDtl) And SalesOrder.Created_By = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "PS" Then
            '    'Query = "Select 'Packing' Type,Slip_No+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,ChallanUser UserName,'' ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PACKINGSlipCreated_By = " & intUserId & "  and Challan_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
            '    Query = "Select 'PackingList' Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PackingSlipDtl Inner Join PackingSlip   on PackingSlipDtl.Doc_id=PackingSlip.Doc_Id Inner Join Ledger on Ledger.Led_key=PackingSlip.Cust_key   Inner Join Style on Style.Style_key=PackingSlipDtl.Style_Key    Inner Join Shade on Shade.Shade_Key=PackingSlipDtl.Shade_key Inner Join Type on Type.Type_Key=PackingSlipDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner  Join Item on Item.Item_key=PackingSlipDtl.Item_Key Inner Join Users on Users.User_Id=PackingSlip.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join   station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where DocDtl_Id not in (Select Sodocdtl_id from PackingDtl) And PackingSlip.Created_By = " & intUserId & "  and PackingSlip.CoBr_Id =" & SelBranchId & ""
            'ElseIf StrMonthId = "SI" Then
            '    'Query = "Select 'SalesInvoice' Type,Challan_No+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,SaleBillUser UserName,'' ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PackingCreated_By = " & intUserId & "  and SaleBill='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
            '    Query = "Select 'SalesInvoice' Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PackingDtl Inner Join Packing   on PackingDtl.Doc_id=Packing.Doc_Id Inner Join Ledger on Ledger.Led_key=Packing.Cust_key   Inner Join Style on Style.Style_key=PackingDtl.Style_Key    Inner Join Shade on Shade.Shade_Key=PackingDtl.Shade_key Inner Join Type on Type.Type_Key=PackingDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner  Join Item on Item.Item_key=PackingDtl.Item_Key Inner Join Users on Users.User_Id=Packing.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join   station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where DocDtl_Id not in (Select PackDocDtl_id from SaleBillDtl) And Packing.Created_By = " & intUserId & "  and Packing.CoBr_Id =" & SelBranchId & ""
            'End If
            If StrMonthId = "SO" Then
                'Query = " Select 'SalesOrder' Type,SoDoc_no Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,UserName,SOApprovalStage ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where SoCreated_By = " & intUserId & " and Vw_PTRSum.SOApprovalStage<>'3'  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by SoDoc_no,Buyer,UserName,SOApprovalStage,Country,Brand_name"
                Query = " Select 'SalesOrder' Type,'' Doc_No,'' Led_Name ,0 TotQty ,0 NetAmt ,''UserName,'' ApprovalStage,'' Brand,''Country  "
            ElseIf StrMonthId = "BM" Then
                'Query = "Select 'BOM' Type,SoDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,'' Led_Name ,0 TotQty ,0 NetAmt ,BOMUSER UserName,'' ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where  SOCreated_By = " & intUserId & "  and BomPrdStyle_Id=0  and BomApprovalStage<>'NA' and Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                Query = "Select 'BOM' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name Brand,Country.Cont_Name Country,Ledger.Led_Name from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Ledger on Ledger.Led_key=SalesOrder.Cust_key Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key Inner Join Shade on Shade.Shade_Key=SalesOrderDtl.Shade_key Inner Join Type on Type.Type_Key=SalesOrderDtl.Type_Key Inner Join Brand on Brand.Brand_Key=Style.Brand_Key Inner Join Item on Item.Item_key=SalesOrderdtl.Item_Key Inner Join Users on Users.User_Id=SalesOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where  (SalesOrderDtl.Style_key not in (Select BomPrdStyle.Style_key from BomPrdStyle) And SalesOrderDtl.Type_Key not in(Select BomPrdStyle.Type_Key from BomPrdStyle) And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle)  And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle))  and MFGTrd='M'  And SalesOrder.Created_By = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & " and SalesOrder.Status=1 "
            ElseIf StrMonthId = "PP" Then
                Query = "Select 'ProdnPln' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name Brand,Country.Cont_Name Country,Ledger.Led_Name from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Ledger on Ledger.Led_key=SalesOrder.Cust_key Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key Inner Join Shade on Shade.Shade_Key=SalesOrderDtl.Shade_key Inner Join Type on Type.Type_Key=SalesOrderDtl.Type_Key Inner Join Brand on Brand.Brand_Key=Style.Brand_Key Inner Join Item on Item.Item_key=SalesOrderdtl.Item_Key Inner Join Users on Users.User_Id=SalesOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where   docdtl_id not in (Select So_DocDtlId from ProdnPlnDtl)  and MFGTrd='M'  And SalesOrder.Created_By = " & intUserId & " and SalesOrder.Status=1 and SalesOrder.CoBr_Id =" & SelBranchId & ""
            ElseIf StrMonthId = "JW" Then
                Query = "Select 'JobWorkOrder' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from ProdnPlnDtl Inner Join ProdnPln on ProdnPln.Doc_id=ProdnPlnDtl.Doc_id Inner Join Ledger on Ledger.Led_key=ProdnPln.Party_Key  Inner Join Style on Style.Style_key=ProdnPlndtl.Style_Key  Inner Join Shade on Shade.Shade_Key=ProdnPlnDtl.Shade_key Inner Join Type on Type.Type_Key=ProdnPlnDtl.Type_Key    Inner Join Brand on Brand.Brand_Key=Style.Brand_Key    Inner Join Item on Item.Item_key=ProdnPlndtl.Item_Key Inner Join Users on Users.User_Id=ProdnPln.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key  inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where  docdtl_id not in (Select PP_DocDtlId from joborderdtl) And ProdnPln.Created_by= " & intUserId & "  and ProdnPln.CoBr_Id =" & SelBranchId & " and Prodnpln.Status=1 and style.mfgtrd='M' "
            ElseIf StrMonthId = "FP" Then ''''' check pobalqty greter then 0 15 march 2019
                'Query = "Select 'FinPurchaseOrder' Type,SoDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FinPoUser UserName,'' ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where SOCreated_By = " & intUserId & "  and FinPoDoc_id=0 and PPApprovalStage='NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                Query = " select 'FinPurchaseOrder' As Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,''ApprovalStage,Brand_name Brand,Country.Cont_Name Country,Ledger.Led_Name from SalesOrderDtl 	Inner Join SalesOrder on SalesOrder.Doc_Id=SalesOrderDtl.Doc_id Inner Join Ledger on Ledger.Led_key=SalesOrder.Cust_Key    Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key   Inner Join Shade on Shade.Shade_Key=SalesOrderDtl.Shade_key   Inner Join Type on Type.Type_Key=SalesOrderDtl.Type_Key     Inner Join Brand on Brand.Brand_Key=Style.Brand_Key    Inner Join Item on Item.Item_key=SalesOrderdtl.Item_Key Inner Join Users on Users.User_Id=SalesOrder.Created_by   Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key  inner join  station on ledger.Ostn_key = station.stn_key   inner join state on station.state_key = state.state_key   inner join country on state.cont_key = country.cont_key   	where MFGTRD='T' 	and DocDtl_id not in (Select SODocDtl_id from PurOrderDtl )  And SalesOrder.Created_by= " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & " and SalesOrder.Status=1 and SalesOrderdtl.POBalQty>0 "
            ElseIf StrMonthId = "GP" Then
                'Query = " Select 'FabPurchaseOrder' Type,PPDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabPoUser UserName,'' ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and FabPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                ' Query = "Select 'FabPurchaseOrder' As Type,Doc_no+'--'+Style.Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from prodnplnfab  Inner Join ProdnPlnDtl on ProdnPlnDtl.DocDtl_Id=ProdnPlnFab.DocDtl_id Inner Join ProdnPln on ProdnPln.Doc_id=ProdnPlnDtl.Doc_id Inner Join Ledger on Ledger.Led_key=ProdnPln.Party_Key Inner Join Style on Style.Style_key=ProdnPlnFab.Style_Key  Inner Join Shade on Shade.Shade_Key=ProdnPlnFab.Shade_key Inner Join Type on Type.Type_Key=ProdnPlnFab.Type_Key   Inner Join Style StyleFin on StyleFin.Style_key=ProdnPlnDtl.Style_Key Inner Join Brand on Brand.Brand_Key=StyleFin.Brand_Key  Inner Join Item on Item.Item_key=ProdnPlnFab.Item_Key Inner Join Users on Users.User_Id=ProdnPln.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where  ProdnPlnFab.style_key <>'' and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl) And ProdnPln.Created_by= " & intUserId & " and ProdnPln.Status=1 and style.mfgtrd='M' and ProdnPln.CoBr_Id =" & SelBranchId & " order by Doc_no Asc " ''comment by ankita 15042019
                ''ankita 15042019
                Query = "Select 'FabPurchaseOrder' As Type,Doc_no+'--'+Style.Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from prodnplnfab  Inner Join ProdnPlnDtl on ProdnPlnDtl.DocDtl_Id=ProdnPlnFab.DocDtl_id Inner Join ProdnPln on ProdnPln.Doc_id=ProdnPlnDtl.Doc_id Inner Join Ledger on Ledger.Led_key=ProdnPln.Party_Key Inner Join Style on Style.Style_key=ProdnPlnFab.Style_Key  Inner Join Shade on Shade.Shade_Key=ProdnPlnFab.Shade_key Inner Join Type on Type.Type_Key=ProdnPlnFab.Type_Key   Inner Join Style StyleFin on StyleFin.Style_key=ProdnPlnDtl.Style_Key Inner Join Brand on Brand.Brand_Key=StyleFin.Brand_Key  Inner Join Item on Item.Item_key=ProdnPlnFab.Item_Key Inner Join Users on Users.User_Id=ProdnPln.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where  ProdnPlnFab.style_key <>'' and ProdnPlnFab.Bal_Qty>0 and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl) And ProdnPln.Created_by= " & intUserId & " and ProdnPln.Status=1 and style.mfgtrd='M' and ProdnPln.CoBr_Id =" & SelBranchId & " order by Doc_no Asc "
                ''end ankita
            ElseIf StrMonthId = "AP" Then
                'Query = "Select 'AccPurchaseOrder' Type,PPDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,AccPoUser UserName,'' ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and AccPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                Query = "Select 'AccPurchaseOrder' As Type,Doc_no+'--'+Style.Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from prodnplnfab  Inner Join ProdnPlnDtl on ProdnPlnDtl.DocDtl_Id=ProdnPlnFab.DocDtl_id Inner Join ProdnPln on ProdnPln.Doc_id=ProdnPlnDtl.Doc_id Inner Join Ledger on Ledger.Led_key=ProdnPln.Party_Key Inner Join Style on Style.Style_key=ProdnPlnFab.Style_Key  Inner Join Shade on Shade.Shade_Key=ProdnPlnFab.Shade_key Inner Join Type on Type.Type_Key=ProdnPlnFab.Type_Key   Inner Join Style StyleFin on StyleFin.Style_key=ProdnPlnDtl.Style_Key Inner Join Brand on Brand.Brand_Key=StyleFin.Brand_Key  Inner Join Item on Item.Item_key=ProdnPlnFab.Item_Key Inner Join Users on Users.User_Id=ProdnPln.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where  ProdnPlnFab.style_key ='' and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl) And ProdnPln.Created_by= " & intUserId & "  and ProdnPln.Status=1 and style.mfgtrd='M' and ProdnPln.CoBr_Id =" & SelBranchId & " order by Doc_no Asc "
            ElseIf StrMonthId = "FI" Then
                'Query = "Select 'FinishPurchase' Type,FinPoDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FinPurUser UserName,'' ApprovalStage,Brand_name Brand,Country  FROM Vw_PTRSum Where FinCreated_By = " & intUserId & "  and FinPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                Query = "Select 'FinishPurchase' As Type,Doc_no+'--'+Style.Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PurOrderDtl  Inner Join PurOrder   on PurOrderDtl.Doc_id=PurOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=PurOrder.Supl_Key Inner Join Style on Style.Style_key=PurOrderDtl.Style_Key  Inner Join Shade on Shade.Shade_Key=PurOrderDtl.Shade_key Inner Join Type on Type.Type_Key=PurOrderDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner Join Item on Item.Item_key=PurOrderDtl.Item_Key Inner Join Users on Users.User_Id=PurOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on  ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where Po_Type='F' and DocDtl_Id not in (Select PodtlId from PurchaseDtl) And PurOrder.Created_By = " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & " and PurOrder.Status=1  "
            ElseIf StrMonthId = "GI" Then
                'Query = "Select 'FabPurchase' Type,FabPoDoc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,FabPurUser UserName,'' ApprovalStage,Brand_name Brand,Country fROM Vw_PTRSum Where FabCreated_By = " & intUserId & "  and FabPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                Query = "Select 'FabPurchase' As Type,Doc_no+'--'+Style.Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PurOrderDtl  Inner Join PurOrder   on PurOrderDtl.Doc_id=PurOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=PurOrder.Supl_Key Inner Join Style on Style.Style_key=PurOrderDtl.Style_Key  Inner Join Shade on Shade.Shade_Key=PurOrderDtl.Shade_key Inner Join Type on Type.Type_Key=PurOrderDtl.Type_Key   Inner Join Style StyleFin on StyleFin.Style_key=PurOrderDtl.Style_Key Inner Join Brand on Brand.Brand_Key=StyleFin.Brand_Key  Inner Join Item on Item.Item_key=PurOrderDtl.Item_Key Inner Join Users on Users.User_Id=PurOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on  ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where Po_Type='G' and DocDtl_Id not in (Select PodtlId from PurchaseDtl) And PurOrder.Created_By = " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "  and PurOrder.Status=1  "
            ElseIf StrMonthId = "AI" Then
                Query = "Select 'AccPurchase' As Type,Doc_no+'--'+Style.Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt , Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PurOrderDtl  Inner Join PurOrder   on PurOrderDtl.Doc_id=PurOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=PurOrder.Supl_Key Inner Join Style on Style.Style_key=PurOrderDtl.Style_Key  Inner Join Shade on Shade.Shade_Key=PurOrderDtl.Shade_key Inner Join Type on Type.Type_Key=PurOrderDtl.Type_Key   Inner Join Style StyleFin on StyleFin.Style_key=PurOrderDtl.Style_Key Inner Join Brand on Brand.Brand_Key=StyleFin.Brand_Key  Inner Join Item on Item.Item_key=PurOrderDtl.Item_Key Inner Join Users on Users.User_Id=PurOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join  station on  ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key where Po_Type='A' and DocDtl_Id not in (Select PodtlId from PurchaseDtl) And PurOrder.Created_By = " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "  and PurOrder.Status=1 "
            ElseIf StrMonthId = "JB" Then
                'Query = "Select 'JobCard' Type,Job_Docno+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,UserName,'' ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where JobCreated_By = " & intUserId & "  and FabIsuDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                Query = "Select 'JobCard' Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from jobOrderDtl Inner Join jobOrder   on jobOrderDtl.Doc_id=jobOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=jobOrder.Party_key   Inner Join Style on Style.Style_key=jobOrderDtl.Style_Key    Inner Join Shade on Shade.Shade_Key=jobOrderDtl.Shade_key Inner Join Type on Type.Type_Key=jobOrderDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner  Join Item on Item.Item_key=jobOrderDtl.Item_Key Inner Join Users on Users.User_Id=jobOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join   station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where DocDtl_Id not in (Select JobWorkDocDtl_Id from ProcIsuDtl ) And jobOrder.Created_By = " & intUserId & "  and jobOrder.CoBr_Id =" & SelBranchId & "  and jobOrder.Status=1  "
            ElseIf StrMonthId = "PL" Then
                Query = "Select 'PackingSlip' Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from SalesOrderDtl Inner Join SalesOrder   on SalesOrderDtl.Doc_id=SalesOrder.Doc_Id Inner Join Ledger on Ledger.Led_key=SalesOrder.Cust_key   Inner Join Style on Style.Style_key=SalesOrderDtl.Style_Key    Inner Join Shade on Shade.Shade_Key=SalesOrderDtl.Shade_key Inner Join Type on Type.Type_Key=SalesOrderDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner  Join Item on Item.Item_key=SalesOrderDtl.Item_Key Inner Join Users on Users.User_Id=SalesOrder.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join   station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where DocDtl_Id not in (Select Sodocdtl_id from PackingSlipDtl) And SalesOrder.Created_By = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & "  and SalesOrder.Status=1 "
            ElseIf StrMonthId = "PS" Then
                'Query = "Select 'Packing' Type,Slip_No+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,ChallanUser UserName,'' ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PACKINGSlipCreated_By = " & intUserId & "  and Challan_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                Query = "Select 'PackingList' Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PackingSlipDtl Inner Join PackingSlip   on PackingSlipDtl.Doc_id=PackingSlip.Doc_Id Inner Join Ledger on Ledger.Led_key=PackingSlip.Cust_key   Inner Join Style on Style.Style_key=PackingSlipDtl.Style_Key    Inner Join Shade on Shade.Shade_Key=PackingSlipDtl.Shade_key Inner Join Type on Type.Type_Key=PackingSlipDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner  Join Item on Item.Item_key=PackingSlipDtl.Item_Key Inner Join Users on Users.User_Id=PackingSlip.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join   station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where DocDtl_Id not in (Select Sodocdtl_id from PackingDtl) And PackingSlip.Created_By = " & intUserId & "  and PackingSlip.CoBr_Id =" & SelBranchId & " and PackingSlip.Status=1  "
            ElseIf StrMonthId = "SI" Then
                'Query = "Select 'SalesInvoice' Type,Challan_No+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,Buyer Led_Name ,0 TotQty ,0 NetAmt ,SaleBillUser UserName,'' ApprovalStage,Brand_name Brand,Country FROM Vw_PTRSum Where PackingCreated_By = " & intUserId & "  and SaleBill='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                Query = "Select 'SalesInvoice' Type,Doc_no+'--'+Style_COde+'--'+Shade_Name+'--'+Type_Name+'--'+Item_Name Doc_No,0 TotQty ,0 NetAmt ,Userled.Led_Name UserName,'' ApprovalStage,Brand_name	Brand,Country.Cont_Name Country,Ledger.Led_Name from PackingDtl Inner Join Packing   on PackingDtl.Doc_id=Packing.Doc_Id Inner Join Ledger on Ledger.Led_key=Packing.Cust_key   Inner Join Style on Style.Style_key=PackingDtl.Style_Key    Inner Join Shade on Shade.Shade_Key=PackingDtl.Shade_key Inner Join Type on Type.Type_Key=PackingDtl.Type_Key   Inner Join Brand on Brand.Brand_Key=Style.Brand_Key  Inner  Join Item on Item.Item_key=PackingDtl.Item_Key Inner Join Users on Users.User_Id=Packing.Created_by Inner Join Ledger Userled on UserLed.Led_Key=Users.Led_Key inner join   station on ledger.Ostn_key = station.stn_key inner join state on station.state_key = state.state_key inner join country on state.cont_key = country.cont_key  where PackingDtl.PSDTL_ID In(Select Docdtl_id from packingslipdtl where sodoc_id in (Select Doc_Id From SalesOrder Where SalesOrder.Created_by = " & intUserId & " )) And docdtl_id not in (Select PackDocDtl_id from SaleBillDtl inner join SaleBill on SaleBill.Doc_Id=SaleBillDtl.Doc_id )  And Packing.CoBr_Id =" & SelBranchId & " and Packing.Status=1  "
            End If
        End If

        DtTable = Common.GetDataTable(Query)
        dtgPartyDtls.ReadOnly = False

        Dim PurRow, NewRow As DataRow

        For Each PurRow In DtTable.Rows
            NewRow = Details.NewRow
            NewRow(GridColumns.Type) = PurRow("Type") & ""
            NewRow(GridColumns.Doc_No) = PurRow("Doc_No") & ""
            'NewRow(GridColumns.Doc_dt) = PurRow("Doc_dt") & ""
            'NewRow(GridColumns.Party_key) = PurRow("Party_key") & ""
            NewRow(GridColumns.Party_key) = ""
            NewRow(GridColumns.Led_Name) = PurRow("Led_Name") & ""
            NewRow(GridColumns.TotQty) = PurRow("TotQty")
            NewRow(GridColumns.NetAmt) = PurRow("NetAmt")
            NewRow(GridColumns.UserName) = PurRow("UserName") & ""
            If strPartyNm = "1" Or strPartyNm = "2" Then
                NewRow(GridColumns.Brand) = PurRow("Brand") & ""
                NewRow(GridColumns.Country) = PurRow("Country") & ""
                NewRow(GridColumns.ApprovalStage) = PurRow("ApprovalStage") & ""

            End If


            Details.Rows.Add(NewRow)
            Details.AcceptChanges()
            dtgPartyDtls.CurrentRowIndex = Details.Rows.Count - 1
        Next
        dtgPartyDtls.CurrentRowIndex = 0
        dtgPartyDtls.Focus()
        'dtgPartyDtls.Select(dtgPartyDtls.CurrentCell.RowNumber)

    End Sub
    Private Sub chkShowBal_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowBal.CheckedChanged
        If blnFlag = True Then
            DisplayFill()
        Else
            DisplayFillPTR()
        End If
    End Sub

    Private Sub btnDateRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateRange.Click
        grpDateRange.Visible = True
        dtpFromDt.Focus()
    End Sub

    Private Sub btnDateCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateCancel.Click
        grpDateRange.Visible = False
    End Sub

    Private Sub dtpFromDt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFromDt.KeyDownEvent, dtpToDate.KeyDownEvent, cmbVoucherType.KeyDown, cmbSelVoucher.KeyDown, cmbAmount.KeyDown, txtChqNo.KeyDown, txtFromAmt.KeyDown, txtLedgerName.KeyDown, txtNarration.KeyDown, txtToAmt.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub btnConfDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfDate.Click
        If dtgPartyDtls.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        strFromDt = dtpFromDt.Value
        strToDt = dtpToDate.Value
        dtMonthlyDate = dtpToDate.Value
        If blnFlag = True Then
            DisplayFill()
        Else
            DisplayFillPTR()
        End If
        grpDateRange.Visible = False
    End Sub

    Private Sub btnMonthly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonthly.Click
        If dtgPartyDtls.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor

        Dim frmCustAcMonthly As New frmCustAcMonthly(strParty, strPartyNm, dtMonthlyDate, True)
        frmCustAcMonthly.MdiParent = Me.MdiParent
        frmCustAcMonthly.Tag = "CustAcMonthly"
        frmCustAcMonthly.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If blnFlag = True Then
            DisplayFill()
        Else
            DisplayFillPTR()
        End If
    End Sub

    Private Sub btnFilters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilters.Click
        ClearFilters()
        grpFilters.Visible = True
    End Sub

    Private Sub btnCancelFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelFilter.Click
        grpFilters.Visible = False
    End Sub

    Private Sub cmbAmount_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAmount.EditValueChanged
        txtToAmt.Visible = False
        txtFromAmt.Visible = True
        If cmbAmount.SelectedIndex = 0 Then
            txtFromAmt.Visible = False
        End If
        If cmbAmount.SelectedIndex = 4 Then
            txtToAmt.Visible = True
        End If
        txtFromAmt.EditValue = 0 : txtToAmt.EditValue = 0
    End Sub

    Private Sub ClearFilters()
        txtLedgerName.Text = ""
        txtChqNo.Text = ""
        txtNarration.Text = ""
        cmbAmount.SelectedIndex = 0
        cmbSelVoucher.SelectedIndex = 0
        cmbVoucherType.SelectedIndex = 0
        txtFromAmt.EditValue = 0 : txtToAmt.EditValue = 0
    End Sub

    Private Function GetQtyFilter(ByVal Field As String) As String
        Dim QtyFilter As String = ""

        If cmbAmount.SelectedIndex = 0 Then ''All

        ElseIf cmbAmount.SelectedIndex = 1 Then ''Equal To
            QtyFilter = Field & " = " & txtFromAmt.EditValue
        ElseIf cmbAmount.SelectedIndex = 2 Then ''Greater Than
            QtyFilter = Field & " > " & txtFromAmt.EditValue
        ElseIf cmbAmount.SelectedIndex = 3 Then ''Less Than
            QtyFilter = Field & " < " & txtFromAmt.EditValue
        ElseIf cmbAmount.SelectedIndex = 4 Then ''Range
            QtyFilter = "(" & Field & " >= " & txtFromAmt.EditValue & " And " & Field & " <= " & txtToAmt.EditValue & ")"
        End If

        Return QtyFilter
    End Function

    Private Sub btnConfFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfFilter.Click
        Dim DtTable As New DataTable
        Dim dtFrom, dtTo As DateTime
        Dim AmtFilter As String = ""
        Dim strHav As String = " Having "
        Dim strHaving As String = ""
        Dim strVchrType As String = ""
        Dim strWh As String = " Where "
        Dim strWhere As String = ""
        dtFrom = AccFromDt
        dtTo = AccToDt
        Details = Nothing : dtgPartyDtls.DataSource = Nothing
        DisplayGridHeaders()
        TotDebit = 0 : TotCredit = 0
        OpBal = 0 : TotClosing = 0

        If strFromDt <> "" Then
            dtFrom = CDate(strFromDt)
            dtTo = CDate(strToDt)
        End If

        If txtLedgerName.Text <> "" Then
            If strWhere = "" Then
                strWhere = " Led_Name like '%" & txtLedgerName.Text & "%'"
            Else
                strWhere = strWhere & " And Led_Name like '%" & txtLedgerName.Text & "%'"
            End If
        End If

        If txtChqNo.Text <> "" Then
            If strWhere = "" Then
                strWhere = " ChqNo like '%" & txtChqNo.Text & "%'"
            Else
                strWhere = strWhere & " And ChqNo like '%" & txtChqNo.Text & "%'"
            End If
        End If

        If txtNarration.Text <> "" Then
            If strWhere = "" Then
                strWhere = " Remark like '%" & txtNarration.Text & "%'"
            Else
                strWhere = strWhere & " And Remark like '%" & txtNarration.Text & "%'"
            End If
        End If

        If cmbVoucherType.SelectedIndex > 0 Then
            If strWhere = "" Then
                strWhere = " Vchr_Type='" & cmbVoucherType.Value & "'"
            Else
                strWhere = strWhere & " AND Vchr_Type='" & cmbVoucherType.Value & "'"
            End If
        End If

        If cmbSelVoucher.SelectedIndex = 0 Then
            strHaving = ""
        ElseIf cmbSelVoucher.SelectedIndex = 1 Then
            If strHaving = "" Then
                strHaving = " Sum(Debit) > 0 "
            Else
                strHaving = strHaving & " And Sum(Debit) > 0 "
            End If
        ElseIf cmbSelVoucher.SelectedIndex = 2 Then
            If strHaving = "" Then
                strHaving = " Sum(Credit) > 0 "
            Else
                strHaving = strHaving & " And Sum(Credit) > 0 "
            End If
        End If

        If cmbAmount.SelectedIndex > 0 Then
            AmtFilter = GetQtyFilter("Sum(Debit)") & " Or " & GetQtyFilter("Sum(Credit)")
            If strHaving = "" Then
                strHaving = AmtFilter
            Else
                strHaving = strHaving & " And " & AmtFilter
            End If
        End If

        dtgPartyDtls.CaptionText = strPartyNm & "  From : " & Format$(dtFrom, "dd/MM/yyyy") & "  To : " & Format$(dtTo, "dd/MM/yyyy")

        Query = "Select count(*) From View_LedgerOnScreen " _
            & " Where COBR_ID = '" & SelBranchId & "' and Fcyr_Id='" & SelYearId & "' and Led_Key ='" & strParty & "' And (DOC_DT < '" & Format$(dtFrom, "MM/dd/yyyy") & "' OR Trj_Type='Opening' )"
        Dim DtTbl1 As DataTable = Common.GetDataTable(Query)

        If DtTbl1.Rows(0).Item(0) = 0 Then
            Query = "Select '' Party_Key, DATEADD(Day,-1,'" & Format$(dtFrom, "MM/dd/yyyy") & "') Doc_dt, 'Op' Doc_No, 'Opening' Type, 'Opening' Vchr_Type, 0 Debit, 0 Credit, '' ChqNo, '' Remark, 0 Doc_Id, '' Cross_Ac, '' Led_Name  " _
                & " Union All "
        Else
            Query = ""
        End If

        Query = Query & " Select Party_Key, Doc_dt, Doc_No, Type, Vchr_Type, case when Sum(Amt) >= 0 then Sum(Amt) else 0 end Debit, " _
            & " case when Sum(Amt) < 0 then Sum(Amt) else 0 end Credit, ChqNo, Remark, Doc_Id, '' Cross_Ac, '' Led_Name " _
            & " From (Select A.Led_Key Party_Key, DATEADD(Day,-1,Fcyr.From_Dt) Doc_dt, 'Op' Doc_No, Trj_Type Type, Vchr_Type, " _
            & " case when AmtFlag = 'D' then Sum(Amount) else -Sum(Amount) end Amt, '' ChqNo, '' Remark, 0 as Doc_Id  " _
            & " from View_LedgerOnScreen as A    " _
            & " Left Join Ledger Party	on A.Led_Key = Party.Led_Key   " _
            & " Left Join Fcyr 			on A.Fcyr_Id = Fcyr.Fcyr_Id    " _
            & " Where A.COBR_ID = '" & SelBranchId & "' and A.Fcyr_Id='" & SelYearId & "' and A.Led_Key ='" & strParty & "' And Trj_Type = 'Opening' " _
            & " Group by A.Led_Key, Trj_Type, Vchr_Type, AmtFlag, Fcyr.From_Dt ) A " _
            & " Group by Party_Key, Doc_dt, Doc_No, Type, Vchr_Type, ChqNo, Remark, Doc_Id   " _
            & " Union All " _
            & " Select Party_Key, Doc_dt, Doc_No, Type, Vchr_Type, Sum(Debit)Debit, Sum(Credit)Credit, ChqNo, Remark, Doc_Id, Cross_Ac, Led_Name  " _
            & " From (Select A.Led_Key Party_Key, A.Doc_dt, A.Doc_No, Trj_Type Type, Vchr_Type, case when AmtFlag = 'D' then Amount else 0 end Debit, " _
            & " case when AmtFlag = 'C' then Amount else 0 end Credit, A.ChqNo, A.Remark, A.Doc_Id, A.Cross_Ac, CrosParty.Led_Name " _
            & " from View_LedgerOnScreen as A  " _
            & " Left Join Ledger CrosParty on A.Cross_Ac = CrosParty.Led_Key " _
            & " Where A.COBR_ID = '" & SelBranchId & "' and A.Fcyr_Id='" & SelYearId & "' and A.Led_Key ='" & strParty & "' And Trj_Type <> 'Opening' " _
            & IIf(strFromDt <> "", " And A.DOC_DT Between '" & Format$(dtFrom, "MM/dd/yyyy") & "' And '" & Format$(dtTo, "MM/dd/yyyy") & "'", "") _
            & " ) B " _
            & IIf(strWhere = "", "", strWh & strWhere) _
            & " Group by Party_Key, Doc_dt, Doc_No, Type, Vchr_Type, ChqNo, Remark, Doc_Id, Cross_Ac, Led_Name  " _
            & IIf(strHaving = "", "", strHav & strHaving) _
            & " Order by Doc_dt "

        DtTable = Common.GetDataTable(Query)
        dtgPartyDtls.ReadOnly = False

        Dim PurRow, NewRow As DataRow

        For Each PurRow In DtTable.Rows
            NewRow = Details.NewRow
            NewRow(GridColumns.Type) = PurRow("Type") & ""
            NewRow(GridColumns.Doc_No) = PurRow("Doc_No") & ""
            NewRow(GridColumns.Doc_dt) = PurRow("Doc_dt") & ""
            NewRow(GridColumns.Party_key) = PurRow("Party_key") & ""
            NewRow(GridColumns.Led_Name) = PurRow("Led_Name") & ""
            NewRow(GridColumns.TotQty) = PurRow("TotQty")
            NewRow(GridColumns.NetAmt) = PurRow("NetAmt")
            NewRow(GridColumns.UserName) = PurRow("UserName") & ""
            Details.Rows.Add(NewRow)

            Details.AcceptChanges()
            dtgPartyDtls.CurrentRowIndex = Details.Rows.Count - 1
        Next


        dtgPartyDtls.CurrentRowIndex = 0
        dtgPartyDtls.Focus()
        dtgPartyDtls.Select(dtgPartyDtls.CurrentCell.RowNumber)
        grpFilters.Visible = False
    End Sub

    Private Sub DisplayOSGrid()
        Dim Grid As New GridColumnCreateAndFormat("OSGrid")

        With Grid
            .AddColumn("Doc_dt", GridColumnCreateAndFormat.enmTypeIdx.StringType, 100, "Date")
            .AddColumn("Type", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, "Type")
            .AddColumn("Doc_No", GridColumnCreateAndFormat.enmTypeIdx.StringType, 100, "Doc No")
            .AddColumn("RefNo", GridColumnCreateAndFormat.enmTypeIdx.StringType, 90, "Ref No")
            .AddColumn("TotalAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 110, "Total Amt.")
            .AddColumn("AdjAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 110, "Adj Amount.")
            .AddColumn("BalAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 110, "Pending Amt.")
            .AddColumn("Os_Days", GridColumnCreateAndFormat.enmTypeIdx.StringType, 70, "Days")
            .AddColumn("Due_dt", GridColumnCreateAndFormat.enmTypeIdx.StringType, 100, "Due Date")
            .AddColumn("Narration", GridColumnCreateAndFormat.enmTypeIdx.StringType, 300, "Narration")
            .AddColumn("Flag", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("OpDocRef_id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "OpDocRef_id")
            .AddColumn("Doc_Id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "Doc_Id")
            .AddColumn("Party_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Party_Key")

            .AddColumnToTable()
            DtOSDtls = .GetTable
            DtOSDtls.DefaultView.AllowNew = False
            DtOSDtls.DefaultView.AllowEdit = True
            DtOSDtls.DefaultView.AllowDelete = False

            dtgOSDtls.DataSource = DtOSDtls
            .DisplayGridHeaders(DtOSDtls, dtgOSDtls, False)
        End With
    End Sub

    Private Sub DisplayOSFill()
        Dim strLedType As String = ""

        Dim DtTable As New DataTable
        DtOSDtls = Nothing : dtgOSDtls.DataSource = Nothing
        DisplayOSGrid()
        dtgOSDtls.CaptionText = strPartyNm
        TotAmt = 0 : AdjAmt = 0 : BalAmt = 0 : OSFlag = 0

        Query = " Select B.AccLGrp_Type from Ledger as A " _
                & " Left Join AccLGrp as B	on A.AccLGrp_key = B.AccLGrp_key " _
                & " Where A.Led_key='" & strParty & "'"
        Dim DtDoc = Common.GetDataTable(Query)

        If DtDoc.Rows.Count > 0 Then
            strLedType = DtDoc.Rows(0)(0)
            If strLedType = "4" Then
                blnRecievable = True
            ElseIf strLedType = "3" Then
                blnRecievable = False
            End If
        End If

        If blnRecievable Then
            Query = " Select Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                & " Due_dt, Narration, Amt_flg, Party_Key " _
                & " From View_ManualAdjust as A " _
                & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "' And Party_key = '" & strParty & "'" & IIf(chkShowAll.Checked, "", " And Bal_Amt <> 0") _
                & " And Amt_flg = 'D'" _
                & " Union All " _
                & " Select Cobr_id, FcYr_Id, Doc_Dt, DocRef_id as OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, TotAmt as Tot_amt, AdjAmt, " _
                & " BalAmt as Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days,  '' Due_dt, Narration, AmtFlag as Amt_flg, Party_Key  " _
                & " From View_ManualMatching " _
                & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "' And Party_key = '" & strParty & "'" & IIf(chkShowAll.Checked, "", " And BalAmt <> 0") _
                & " And AmtFlag = 'D' And Trj_type = 'Vchr' " _
                & " Union All " _
                & " Select Cobr_id, FcYr_Id, Doc_Dt, DocRef_id as OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, 0-TotAmt as Tot_amt, 0-AdjAmt, 0-BalAmt as Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                & " '' Due_dt, Narration, AmtFlag as Amt_flg, Party_Key " _
                & " From View_ManualMatching " _
                & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "' And Party_key = '" & strParty & "'" & IIf(chkShowAll.Checked, "", " And BalAmt <> 0") _
                & " And AmtFlag = 'C'" _
                & " Order by Doc_Dt "
        Else
            Query = " Select Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                & " Due_dt, Narration, Amt_flg, Party_Key " _
                & " From View_ManualAdjust as A " _
                & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "' And Party_key = '" & strParty & "'" & IIf(chkShowAll.Checked, "", " And Bal_Amt <> 0") _
                & " And Amt_flg = 'C'" _
                & " Union All  " _
                & " Select Cobr_id, FcYr_Id, Doc_Dt, DocRef_id as OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, TotAmt as Tot_amt, AdjAmt, " _
                & " BalAmt as Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days,  '' Due_dt, Narration, AmtFlag as Amt_flg, Party_Key  " _
                & " From View_ManualMatching " _
                & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "' And Party_key = '" & strParty & "'" & IIf(chkShowAll.Checked, "", " And BalAmt <> 0") _
                & " And AmtFlag = 'C' And Trj_type = 'Vchr' " _
                & " Union All " _
                & " Select Cobr_id, FcYr_Id, Doc_Dt, DocRef_id as OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, 0-TotAmt as Tot_amt, 0-AdjAmt, 0-BalAmt as Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                & " '' Due_dt, Narration, AmtFlag as Amt_flg, Party_Key " _
                & " From View_ManualMatching " _
                & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "' And Party_key = '" & strParty & "' " & IIf(chkShowAll.Checked, "", " And BalAmt <> 0") _
                & " And AmtFlag = 'D'" _
                & " Order by Doc_Dt "
        End If

        DtTable = Common.GetDataTable(Query)
        Dim PurRow, NewRow As DataRow

        For Each PurRow In DtTable.Rows
            NewRow = DtOSDtls.NewRow

            NewRow(GridOSCols.Doc_dt) = PurRow("Doc_Dt") & ""
            NewRow(GridOSCols.Type) = PurRow("Trj_type") & ""
            NewRow(GridOSCols.Doc_No) = PurRow("Doc_No") & ""
            NewRow(GridOSCols.RefNo) = PurRow("RefNo") & ""
            NewRow(GridOSCols.TotalAmt) = PurRow("Tot_amt")
            NewRow(GridOSCols.AdjAmt) = PurRow("AdjAmt")
            NewRow(GridOSCols.BalAmt) = PurRow("Bal_amt")
            NewRow(GridOSCols.Os_Days) = PurRow("Os_Days") & ""
            NewRow(GridOSCols.Due_dt) = PurRow("Due_dt") & ""
            NewRow(GridOSCols.Narration) = PurRow("Narration") & ""
            NewRow(GridOSCols.Flag) = IIf(PurRow("Amt_flg") = "D", "Dr", "Cr")
            NewRow(GridOSCols.OpDocRef_id) = PurRow("OpDocRef_id")
            NewRow(GridOSCols.Doc_Id) = PurRow("Doc_Id")
            NewRow(GridOSCols.Party_Key) = PurRow("Party_key") & ""

            If PurRow("Tot_amt") <> 0 Then
                TotAmt = TotAmt + PurRow("Tot_amt")
            End If
            If PurRow("AdjAmt") <> 0 Then
                AdjAmt = AdjAmt + PurRow("AdjAmt")
            End If
            If PurRow("Bal_amt") <> 0 Then
                BalAmt = BalAmt + PurRow("Bal_amt")
            End If
            If PurRow("Amt_flg") = "D" Then
                OSFlag = OSFlag + PurRow("Bal_amt")
            Else
                OSFlag = OSFlag - PurRow("Bal_amt")
            End If

            DtOSDtls.Rows.Add(NewRow)

            DtOSDtls.AcceptChanges()
            dtgOSDtls.CurrentRowIndex = DtOSDtls.Rows.Count - 1
        Next PurRow

        DtOSDtls.AcceptChanges()

        lblOSTotAmt.Text = Format$(TotAmt, "0.00")
        lblOSAdjAmt.Text = Format$(AdjAmt, "0.00")
        lblOSBalAmt.Text = Format$(Math.Abs(BalAmt), "0.00")
        lblOSFlag.Text = IIf(OSFlag >= 0, "Dr", "Cr")

        If dtgOSDtls.CurrentRowIndex <> -1 Then
            dtgOSDtls.CurrentRowIndex = 0
            dtgOSDtls.Focus()
            dtgOSDtls.Select(dtgOSDtls.CurrentCell.RowNumber)
        End If

    End Sub

    Private Sub btnBillWise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillWise.Click
        grpOSDtls.Visible = True
        btnDetailed.Enabled = True
        btnBillWise.Enabled = False : btnDateRange.Enabled = False
        btnRefresh.Enabled = False : btnFilters.Enabled = False
        Label2.Text = "Outstanding"
        DisplayOSFill()
    End Sub

    Private Sub btnDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailed.Click
        grpOSDtls.Visible = False
        btnDetailed.Enabled = False
        btnBillWise.Enabled = True : btnDateRange.Enabled = True
        btnRefresh.Enabled = True : btnFilters.Enabled = True
        Label2.Text = "Detailed"

        Query = " Select Distinct Vchr_type as ID, Vchr_type From View_LedgerOnScreen Order By Vchr_type "
        Dim dtVchrType As DataTable = Common.GetDataTableWithAll(Query)

        With cmbVoucherType
            .DataSource = dtVchrType
            .DisplayMember = "Vchr_type"
            .ValueMember = "ID"
        End With
        cmbVoucherType.SelectedIndex = 0

        If blnFlag = True Then
            DisplayFill()
        Else
            DisplayFillPTR()
        End If
    End Sub

    Private Sub DisplayPymtDtlGrid()
        Dim Grid As New GridColumnCreateAndFormat("PymtDtlGrid")

        With Grid
            .AddColumn("Doc_dt", GridColumnCreateAndFormat.enmTypeIdx.StringType, 100, "Date")
            .AddColumn("Type", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, "Type")
            .AddColumn("Doc_No", GridColumnCreateAndFormat.enmTypeIdx.StringType, 100, "Doc No")
            .AddColumn("AdjAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 110, "Adj Amount.")
            .AddColumn("Flag", GridColumnCreateAndFormat.enmTypeIdx.StringType, 30, "")
            .AddColumn("ChqNo", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, "ChqNo")
            .AddColumn("Narration", GridColumnCreateAndFormat.enmTypeIdx.StringType, 300, "Narration")
            .AddColumn("DocRef_id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "DocRef_id")
            .AddColumn("Doc_Id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "Doc_Id")

            .AddColumnToTable()
            DtPymtDtls = .GetTable
            DtPymtDtls.DefaultView.AllowNew = False
            DtPymtDtls.DefaultView.AllowEdit = True
            DtPymtDtls.DefaultView.AllowDelete = False

            dtgPymtDtl.DataSource = DtPymtDtls
            .DisplayGridHeaders(DtPymtDtls, dtgPymtDtl, False)
        End With
    End Sub

    Private Sub dtgOSDtls_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgOSDtls.DoubleClick
        If dtgOSDtls.CurrentRowIndex = -1 Then Exit Sub
        grpPymtDtl.Visible = True
        grpPymtDtl.BringToFront()
        DisplayPymtDtlFill()
    End Sub

    Private Sub dtgOSDtls_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgOSDtls.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgOSDtls_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        grpPymtDtl.Visible = False
    End Sub

    Private Sub DisplayPymtDtlFill()
        Dim DocRefId As Integer
        Dim DtTable As New DataTable
        DtPymtDtls = Nothing : dtgPymtDtl.DataSource = Nothing
        DisplayPymtDtlGrid()

        DocRefId = dtgOSDtls.Item(dtgOSDtls.CurrentRowIndex, GridOSCols.OpDocRef_id)
        If DocRefId = 0 Then
            Exit Sub
        End If

        If blnRecievable Then
            Query = " Select B.Doc_Dt, Case VchrType When 'PY' Then 'Payment' When 'RC' Then 'Receipt' When 'DN' Then 'Debit Note' When 'CN' Then 'Credit Note' " _
                & " When 'JV' Then 'Journal' When 'CT' Then 'Contra' When 'PV' Then 'Purchase' When 'SV' Then 'Sales' End As Vchr_Type, " _
                & " B.Doc_No, A.Doc_Amt, A.AmtFlag, A.Remark, B.Doc_Id, A.DocRef_Id, " _
                & " (Select top 1 ChqNo from VchrDtl where VchrDtl.Doc_Id=B.Doc_Id and LedRef_Key='" & strParty & "') ChqNo " _
                & " from VchrDtlRef as A " _
                & " Left Join Vchr as B		on A.Doc_Id = B.Doc_Id  " _
                & " Where (A.VchrDtlAdj_Id=" & DocRefId & " or A.SaleBill_Id=" & DocRefId & ")"
        Else
            Query = " Select B.Doc_Dt, Case VchrType When 'PY' Then 'Payment' When 'RC' Then 'Receipt' When 'DN' Then 'Debit Note' When 'CN' Then 'Credit Note' " _
                & " When 'JV' Then 'Journal' When 'CT' Then 'Contra' When 'PV' Then 'Purchase' When 'SV' Then 'Sales' End As Vchr_Type, " _
                & " B.Doc_No, A.Doc_Amt, A.AmtFlag, A.Remark, B.Doc_Id, A.DocRef_Id, " _
                & " (Select top 1 ChqNo from VchrDtl where VchrDtl.Doc_Id=B.Doc_Id and LedRef_Key='" & strParty & "') ChqNo " _
                & " from VchrDtlRef as A " _
                & " Left Join Vchr as B		on A.Doc_Id = B.Doc_Id  " _
                & " Where (A.VchrDtlAdj_Id=" & DocRefId & " or A.PurchaseBill_id=" & DocRefId & ")"
        End If

        DtTable = Common.GetDataTable(Query)
        Dim PurRow, NewRow As DataRow

        For Each PurRow In DtTable.Rows
            NewRow = DtPymtDtls.NewRow

            NewRow(GridPymtCols.Doc_dt) = PurRow("Doc_Dt") & ""
            NewRow(GridPymtCols.Type) = PurRow("Vchr_Type") & ""
            NewRow(GridPymtCols.Doc_No) = PurRow("Doc_No") & ""
            NewRow(GridPymtCols.AdjAmt) = PurRow("Doc_Amt")
            NewRow(GridPymtCols.Flag) = IIf(PurRow("AmtFlag") = "D", "Dr", "Cr")
            NewRow(GridPymtCols.ChqNo) = PurRow("ChqNo") & ""
            NewRow(GridPymtCols.Narration) = PurRow("Remark") & ""
            NewRow(GridPymtCols.DocRef_id) = PurRow("DocRef_id")
            NewRow(GridPymtCols.Doc_Id) = PurRow("Doc_Id")

            DtPymtDtls.Rows.Add(NewRow)

            DtPymtDtls.AcceptChanges()
            dtgPymtDtl.CurrentRowIndex = DtPymtDtls.Rows.Count - 1
        Next PurRow

        DtPymtDtls.AcceptChanges()

        If dtgPymtDtl.CurrentRowIndex <> -1 Then
            dtgPymtDtl.CurrentRowIndex = 0
            dtgPymtDtl.Focus()
            dtgPymtDtl.Select(dtgPymtDtl.CurrentCell.RowNumber)
        End If

    End Sub

    Private Sub chkShowAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowAll.CheckedChanged
        DisplayOSFill()
    End Sub

End Class