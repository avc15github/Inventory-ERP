Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmPTRSum
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal strParty1 As String, ByVal strPartyNm1 As String, ByVal intUserId1 As Integer, ByVal dtmonthlyDate1 As Date, ByVal blnFlag1 As Boolean)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        strParty = strParty1
        strPartyNm = strPartyNm1
        intUserId = intUserId1
        blnFlag = blnFlag1
        dtMonthlyDate = dtmonthlyDate1
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
    Friend WithEvents dtgPartyAc As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCreditAmt As System.Windows.Forms.Label
    Friend WithEvents lblDebitAmt As System.Windows.Forms.Label
    Friend WithEvents btnDetailed As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFlag As System.Windows.Forms.Label
    Friend WithEvents btnMonthly As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDateRange As System.Windows.Forms.Button
    Friend WithEvents btnBillWise As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents grpDateRange As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnDateCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConfDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents dtpToDate As DateTimePick.DateTimePick
    Friend WithEvents dtpFromDt As DateTimePick.DateTimePick
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents lblBalAmt As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnDateRange = New System.Windows.Forms.Button
        Me.btnBillWise = New System.Windows.Forms.Button
        Me.btnDetailed = New System.Windows.Forms.Button
        Me.btnMonthly = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblFlag = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDebitAmt = New System.Windows.Forms.Label
        Me.dtgPartyAc = New System.Windows.Forms.DataGrid
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.lblCreditAmt = New System.Windows.Forms.Label
        Me.lblBalAmt = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
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
        Me.dtgParty = New System.Windows.Forms.DataGrid
        Me.grpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgPartyAc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDateRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDateRange.SuspendLayout()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgParty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.dtgParty)
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Controls.Add(Me.lblFlag)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.lblDebitAmt)
        Me.grpMain.Controls.Add(Me.dtgPartyAc)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Controls.Add(Me.lblCreditAmt)
        Me.grpMain.Controls.Add(Me.lblBalAmt)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Location = New System.Drawing.Point(0, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(1077, 607)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnDateRange)
        Me.Panel1.Controls.Add(Me.btnBillWise)
        Me.Panel1.Controls.Add(Me.btnDetailed)
        Me.Panel1.Controls.Add(Me.btnMonthly)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Location = New System.Drawing.Point(6, 562)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 39)
        Me.Panel1.TabIndex = 2
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExport.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnExport.Location = New System.Drawing.Point(840, 5)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(81, 28)
        Me.btnExport.TabIndex = 7
        Me.btnExport.Text = "Expor&t"
        Me.btnExport.UseVisualStyleBackColor = False
        Me.btnExport.Visible = False
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
        Me.btnMonthly.Enabled = False
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
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnExit.Location = New System.Drawing.Point(978, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 28)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFlag
        '
        Me.lblFlag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFlag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlag.ForeColor = System.Drawing.Color.Blue
        Me.lblFlag.Location = New System.Drawing.Point(571, 533)
        Me.lblFlag.Name = "lblFlag"
        Me.lblFlag.Size = New System.Drawing.Size(22, 20)
        Me.lblFlag.TabIndex = 123
        Me.lblFlag.Text = "Dr"
        Me.lblFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFlag.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(159, 536)
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
        Me.lblDebitAmt.Location = New System.Drawing.Point(218, 533)
        Me.lblDebitAmt.Name = "lblDebitAmt"
        Me.lblDebitAmt.Size = New System.Drawing.Size(88, 20)
        Me.lblDebitAmt.TabIndex = 119
        Me.lblDebitAmt.Text = "0"
        Me.lblDebitAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDebitAmt.Visible = False
        '
        'dtgPartyAc
        '
        Me.dtgPartyAc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgPartyAc.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyAc.CaptionText = "PTR-Count"
        Me.dtgPartyAc.DataMember = ""
        Me.dtgPartyAc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyAc.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyAc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgPartyAc.Location = New System.Drawing.Point(7, 36)
        Me.dtgPartyAc.Name = "dtgPartyAc"
        Me.dtgPartyAc.Size = New System.Drawing.Size(536, 490)
        Me.dtgPartyAc.TabIndex = 1
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
        Me.lblFormCaption.Text = "Pending Task Status"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCreditAmt
        '
        Me.lblCreditAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCreditAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCreditAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblCreditAmt.Location = New System.Drawing.Point(336, 533)
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
        Me.lblBalAmt.Location = New System.Drawing.Point(457, 533)
        Me.lblBalAmt.Name = "lblBalAmt"
        Me.lblBalAmt.Size = New System.Drawing.Size(112, 20)
        Me.lblBalAmt.TabIndex = 119
        Me.lblBalAmt.Text = "0"
        Me.lblBalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBalAmt.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1060, 25)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.grpDateRange.Location = New System.Drawing.Point(377, 263)
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
        Me.dtpToDate.Value = New Date(2018, 7, 3, 0, 0, 0, 0)
        '
        'dtpFromDt
        '
        Me.dtpFromDt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDt.Location = New System.Drawing.Point(74, 38)
        Me.dtpFromDt.Name = "dtpFromDt"
        Me.dtpFromDt.Size = New System.Drawing.Size(82, 22)
        Me.dtpFromDt.TabIndex = 1
        Me.dtpFromDt.Tag = "From Date"
        Me.dtpFromDt.Value = New Date(2018, 7, 3, 0, 0, 0, 0)
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
        Me.btnDateCancel.Location = New System.Drawing.Point(190, 86)
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
        Me.btnConfDate.Location = New System.Drawing.Point(103, 86)
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
        'dtgParty
        '
        Me.dtgParty.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgParty.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgParty.CaptionText = "PTR-Count"
        Me.dtgParty.DataMember = ""
        Me.dtgParty.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgParty.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgParty.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgParty.Location = New System.Drawing.Point(544, 36)
        Me.dtgParty.Name = "dtgParty"
        Me.dtgParty.Size = New System.Drawing.Size(520, 490)
        Me.dtgParty.TabIndex = 124
        '
        'frmPTRSum
        '
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1079, 612)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.grpDateRange)
        Me.MaximizeBox = False
        Me.Name = "frmPTRSum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PTR- As Per User"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgPartyAc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDateRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDateRange.ResumeLayout(False)
        Me.grpDateRange.PerformLayout()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgParty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim cmdCommand As SqlCommand
    Dim sdaAdapter As SqlDataAdapter
    Dim strFilter As String
    Dim strParty As String
    Dim strPartyNm As String
    Dim intUserId As Integer
    Dim blnFlag As Boolean
    Dim dtMonthlyDate As Date
    Dim DtSeries As DataTable
    Dim dtTemp As DataTable
    Dim WithEvents Details As DataTable
    Dim WithEvents Details1 As DataTable
    Dim SMSFields As String = ""
    Dim SMSGrpFields As String = ""
    Dim TotDebit As Double = 0
    Dim TotCredit As Double = 0
    Dim TotClosing As Double = 0

    Enum GridColumns
        Party_key
        DocType
        MName
        Debit
        Credit
        Closing
        Flag
        MonthId
        SeqNo
    End Enum

    Private Sub frmPTRSum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.F5 Then
        '    DisplayFill()
        'End If
    End Sub

    Private Sub frmCustAcBillWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If blnFlag = True Then
            DisplayFill()
            DisplayFillPTR()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DisplayFill()
        Dim DtTable As New DataTable
        Details = Nothing : dtgPartyAc.DataSource = Nothing
        DisplayGridHeaders()
        Dim strSrchString As String = ""
        
        If strPartyNm = "2" Then
            Query = "Select Distinct count(Doc_id)Doc,Trans_type,Type from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type ='" & strParty & "') and Trans_Type in (Select ISnull(Trans_Type,'')Trans_Type from TransForApproval Where Trans_Type<> '') and doc_id not in(Select doc_id from TransApproval where TransApproval.DOc_Id= VW_PTR.Doc_id and TransApproval.Trans_Type=VW_PTR.Trans_Type and ApproveFlag='R' ) and doc_id not in(Select doc_id from TransApproval where TransApproval.DOc_Id= VW_PTR.Doc_id and TransApproval.Trans_Type=VW_PTR.Trans_Type  )" & strSrchString & " Group by Trans_type,Type "
        ElseIf strPartyNm = "3" Then
            'Query = " Select Distinct count(Doc_id)Doc,Trans_type from  (Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type ='" & strParty & "') " _
            '         & " Union all   Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and ledger.approval=0 and level_type='2'))  " _
            '         & "  union all Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and level_type='2')) and doc_id in( Select doc_id from TransApproval where TransApproval.Trans_Type=VW_PTR.Trans_Type)) a  where a.doc_id not in (select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type and level_id=3 and ApproveFlag='A' Union all  select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type  and ApprovRejected='R' and ApproveFlag='R')" & strSrchString & "  and Trans_Type in (Select ISnull(Trans_Type,'')Trans_Type from TransForApproval Where Trans_Type<> '')  Group by Trans_type   "
            Query = " Select Distinct count(Doc_id)Doc,Trans_type,Type from  ( SELECT dISTINCT * FROM  (Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type ='" & strParty & "') " _
                    & " Union all   Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and ledger.approval=0 and level_type='2'))  " _
                    & "  union all Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and level_type='2')) and doc_id in( Select doc_id from TransApproval where TransApproval.Trans_Type=VW_PTR.Trans_Type)) AA) a  where a.doc_id not in (select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type and level_id=3 and ApproveFlag='A' Union all  select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type  and ApprovRejected='R' and ApproveFlag='R')" & strSrchString & "  and Trans_Type in (Select ISnull(Trans_Type,'')Trans_Type from TransForApproval Where Trans_Type<> '')  Group by Trans_type,Type   " _
                    & " Union all  Select Distinct count(Doc_id)Doc,Trans_type,Type from ( select  distinct VW_PTR.* from VW_PTR inner join TransApproval on TransApproval.Doc_Id= VW_PTR.Doc_Id " _
                    & "  where CoBr_Id =" & SelBranchId & " and VW_PTR.Trans_Type='OS' and Level_Id=3 and ApproveFlag='A'and TransApproval.Trans_type='SO' and VW_PTR.Doc_Dt='1900-01-01' and TransApproval.Approved_By= " & intUserId & ") A Group By A.Trans_type,A.Type"

        ElseIf strPartyNm = "1" Then
            Dim ReportFilter As String = ""
            'ReportFilter = "Vw_SOApprovalStatusReport.CoBr_Id = '" & SelBranchId & "' And (Vw_SOApprovalStatusReport.SoCreated_By = " & intUserId & " Or Vw_SOApprovalStatusReport.PPCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.JobCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FinCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FabCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.AccCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FinPurCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FabPurCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.AccPurCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.JobIsuCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.PACKINGSLIPCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.PACKINGCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.salebillCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.BomCreated_By = " & intUserId & " ) And Vw_SOApprovalStatusReport.Status <> '0'"
            ''Rohit 04092018
            'Query = " Select Count(Doc)Doc,'SO' Trans_type,'SalesOrder' as Type from (Select  Count(*)Doc,'SO' Trans_type  FROM Vw_PTRSum Where SoCreated_By = " & intUserId & "    and Vw_PTRSum.SOApprovalStage<>'3'  and Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by SoDoc_No)A" _
            '       & " Union All Select Count(Doc)Doc,'BM' Trans_type,'BOM' as Type from  (Select count(*)Doc,BomPrdStyle_Id,'BM' Trans_type  FROM Vw_PTRSum Where  BOMCreated_By = " & intUserId & "   and BomApprovalStage<>'3' And BomApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by BomPrdStyle_Id)A" _
            '       & " Union All Select  Count(Doc)Doc,'PP' Trans_type,'ProdPlanning' as Type from (Select  Count(*)Doc,PPDoc_no,'PP' Trans_type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "  and PPApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by PPDoc_no)A" _
            '       & " Union All Select  Count(Doc)Doc,'JW' Trans_type,'JobWorkorder' as Type from (Select  Count(*)Doc,'JW' Trans_type  FROM Vw_PTRSum Where JobCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by Job_Docno)A" _
            '       & " Union All Select  Count(Doc)Doc,'FP' Trans_type,'Finish PO' As Type from (Select  Count(*)Doc,'FP' Trans_type  FROM Vw_PTRSum Where FinCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FinPODoc_no)A" _
            '       & " Union All Select  Count(Doc)Doc,'GP' Trans_type,'Fabric PO' As Type from (Select  Count(*)Doc,'GP' Trans_type  FROM Vw_PTRSum Where FabCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FabPODoc_no)A" _
            '       & " Union All Select  Count(Doc)Doc,'AP' Trans_type,'Acc PO' As Type from (Select  Count(*)Doc,'AP' Trans_type  FROM Vw_PTRSum Where AccCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by AccPODoc_no)A" _
            '       & " Union All Select  Count(Doc)Doc,'FI' Trans_type ,'Finish Purchase' As Type from (Select  Count(*)Doc,'FI' Trans_type  FROM Vw_PTRSum Where FinPurCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FinPurDoc_No)A" _
            '       & " Union All Select  Count(Doc)Doc,'GI' Trans_type,'Fabric Purchase' As Type from (Select  Count(*)Doc,'GI' Trans_type  FROM Vw_PTRSum Where FabPurCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FabPurDoc_No)A" _
            '       & " Union All Select  Count(Doc)Doc,'AI' Trans_type ,'Acc Purchase' As Type from (Select  Count(*)Doc,'AI' Trans_type  FROM Vw_PTRSum Where AccPurCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by AccPurDoc_No)A" _
            '       & " Union All Select  Count(Doc)Doc,'JB' Trans_type,'Job Card' As Type from (Select  Count(*)Doc,'JB' Trans_type  FROM Vw_PTRSum Where JobIsuCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FabIsuDoc_no)A" _
            '       & " Union All Select  Count(Doc)Doc,'PL' Trans_type ,'Packing Slip' As Type from (Select  Count(*)Doc,'PL' Trans_type  FROM Vw_PTRSum Where PACKINGSLIPCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by Slip_No)A" _
            '       & " Union All Select  Count(Doc)Doc,'PS' Trans_type,'Packing List' As Type from (Select  Count(*)Doc,'PS' Trans_type  FROM Vw_PTRSum Where PACKINGCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by Challan_No)A" _
            '       & " Union All Select  Count(Doc)Doc,'SI' Trans_type,'Sales Invoice' As Type from (Select  Count(*)Doc,'SI' Trans_type  FROM Vw_PTRSum Where salebillCreated_By = " & intUserId & "   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by SaleBill)A"

            Query = "  Select * from (Select Count(Doc)Doc,'SO' Trans_type,'SalesOrder' as Type from (Select  Count(*)Doc,'SO' Trans_type  FROM Vw_PTRSum Where SoCreated_By = " & intUserId & " and sodoc_id <>0   and sodoc_id not in (select doc_id from TransApproval where  Trans_Type='SO' and Level_Id=3 and ApproveFlag='A') and Vw_PTRSum.SOApprovalStage<>'3'  and Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by SoDoc_No)A" _
                  & " Union All Select Count(Doc)Doc,'BM' Trans_type,'BOM' as Type from  (Select count(*)Doc,BomPrdStyle_Id,'BM' Trans_type  FROM Vw_PTRSum Where  BOMCreated_By = " & intUserId & " and BomPrdStyle_Id <>0 and BomPrdStyle_Id not in (select doc_id from TransApproval where  Trans_Type='BM' and Level_Id=3 and ApproveFlag='A')  and BomApprovalStage<>'3' And BomApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by BomPrdStyle_Id)A" _
                  & " Union All Select  Count(Doc)Doc,'PP' Trans_type,'ProdPlanning' as Type from (Select  Count(*)Doc,PPDoc_no,'PP' Trans_type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & " and PPdoc_id <>0 and PPdoc_id not in (select doc_id from TransApproval where  Trans_Type='PP' and Level_Id=3 and ApproveFlag='A') and PPApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by PPDoc_no)A" _
                  & " Union All Select  Count(Doc)Doc,'JW' Trans_type,'JobWorkorder' as Type from (Select  Count(*)Doc,'JW' Trans_type  FROM Vw_PTRSum Where JobCreated_By = " & intUserId & " and Jobdoc_id <>0 and Jobdoc_id not in (select doc_id from TransApproval where  Trans_Type='JW' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by Job_Docno)A ) B Inner Join TransForApproval On B.Trans_type=TransForApproval.Trans_Type "
            '& " Union All Select  Count(Doc)Doc,'FP' Trans_type,'Finish PO' As Type from (Select  Count(*)Doc,'FP' Trans_type  FROM Vw_PTRSum Where FinCreated_By = " & intUserId & "  and FinPODoc_Id <>0 and FinPODoc_Id not in (select doc_id from TransApproval where  Trans_Type='FP' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FinPODoc_no)A" _
            '& " Union All Select  Count(Doc)Doc,'GP' Trans_type,'Fabric PO' As Type from (Select  Count(*)Doc,'GP' Trans_type  FROM Vw_PTRSum Where FabCreated_By = " & intUserId & " and FabPODoc_Id <>0 and FabPODoc_Id not in (select doc_id from TransApproval where  Trans_Type='GP' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FabPODoc_no)A" _
            '& " Union All Select  Count(Doc)Doc,'AP' Trans_type,'Acc PO' As Type from (Select  Count(*)Doc,'AP' Trans_type  FROM Vw_PTRSum Where AccCreated_By = " & intUserId & "  and AccPODoc_Id <>0 and AccPODoc_Id not in (select doc_id from TransApproval where  Trans_Type='AP' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by AccPODoc_no)A" _
            '& " Union All Select  Count(Doc)Doc,'FI' Trans_type ,'Finish Purchase' As Type from (Select  Count(*)Doc,'FI' Trans_type  FROM Vw_PTRSum Where FinPurCreated_By = " & intUserId & " and PurDoc_Id <>0 and PurDoc_Id not in (select doc_id from TransApproval where  Trans_Type='FI' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FinPurDoc_No)A" _
            '& " Union All Select  Count(Doc)Doc,'GI' Trans_type,'Fabric Purchase' As Type from (Select  Count(*)Doc,'GI' Trans_type  FROM Vw_PTRSum Where FabPurCreated_By = " & intUserId & " and FabPurDoc_Id <>0 and FabPurDoc_Id not in (select doc_id from TransApproval where  Trans_Type='GI' and Level_Id=3 and ApproveFlag='A')   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FabPurDoc_No)A" _
            '& " Union All Select  Count(Doc)Doc,'AI' Trans_type ,'Acc Purchase' As Type from (Select  Count(*)Doc,'AI' Trans_type  FROM Vw_PTRSum Where AccPurCreated_By = " & intUserId & " and AccPurDoc_Id <>0  and AccPurDoc_Id not in (select doc_id from TransApproval where  Trans_Type='AI' and Level_Id=3 and ApproveFlag='A')   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by AccPurDoc_No)A" _
            '& " Union All Select  Count(Doc)Doc,'JB' Trans_type,'Job Card' As Type from (Select  Count(*)Doc,'JB' Trans_type  FROM Vw_PTRSum Where JobIsuCreated_By = " & intUserId & "  and FabIsuDoc_Id <>0 and FabIsuDoc_Id not in (select doc_id from TransApproval where  Trans_Type='JB' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FabIsuDoc_no)A" _
            '& " Union All Select  Count(Doc)Doc,'PS' Trans_type,'Packing List' As Type from (Select  Count(*)Doc,'PS' Trans_type  FROM Vw_PTRSum Where PACKINGCreated_By = " & intUserId & "  and PackingDoc_id <>0 and PackingDoc_id not in (select doc_id from TransApproval where  Trans_Type='PS' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by Challan_No)A" _
            '& " Union All Select  Count(Doc)Doc,'SI' Trans_type,'Sales Invoice' As Type from (Select  Count(*)Doc,'SI' Trans_type  FROM Vw_PTRSum Where salebillCreated_By = " & intUserId & " and SaleBillDoc_id <> 0 and SaleBillDoc_id not in (select doc_id from TransApproval where  Trans_Type='SI' and Level_Id=3 and ApproveFlag='A')  and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by SaleBill)A  ) B Inner Join TransForApproval On B.Trans_type=TransForApproval.Trans_Type "

            '& " Union All Select  Count(Doc)Doc,'PL' Trans_type ,'Packing Slip' As Type from (Select  Count(*)Doc,'PL' Trans_type  FROM Vw_PTRSum Where PACKINGSLIPCreated_By = " & intUserId & " and packingSlipDoc_id not in (select doc_id from TransApproval where  Trans_Type='PL' and Level_Id=3 and ApproveFlag='A')   and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by Slip_No)A" _
        End If

        DtTable = Common.GetDataTable(Query)
        Dim PurRow, NewRow As DataRow
        Dim i As Integer

        For Each PurRow In DtTable.Rows

            i = MonthExist(PurRow("Trans_Type"))
            NewRow = Details.NewRow
            NewRow(GridColumns.Party_key) = strParty
            NewRow(GridColumns.DocType) = PurRow("Type") & ""
            NewRow(GridColumns.MName) = PurRow("Trans_Type") & ""
            NewRow(GridColumns.Debit) = PurRow("Doc")

            Details.Rows.Add(NewRow)


            Details.AcceptChanges()
            dtgPartyAc.CurrentRowIndex = Details.Rows.Count - 1
        Next PurRow

        Details.AcceptChanges()

        dtgPartyAc.CurrentRowIndex = 0
        dtgPartyAc.Focus()
        'dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)
    End Sub
    Private Sub DisplayFillPTR()
        If strPartyNm <> "3" Then

            Dim DtTable As New DataTable
            Details = Nothing : dtgParty.DataSource = Nothing
            DisplayGridHeadersPTR()
            Dim strSrchString As String = ""

            If strPartyNm = "2" Then
                'Query = "Select Distinct count(Doc_id)Doc,Trans_type from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type ='" & strParty & "') and Trans_Type in (Select ISnull(Trans_Type,'')Trans_Type from TransForApproval Where Trans_Type<> '') and doc_id not in(Select doc_id from TransApproval where TransApproval.DOc_Id= VW_PTR.Doc_id and TransApproval.Trans_Type=VW_PTR.Trans_Type and ApproveFlag='R' ) and doc_id not in(Select doc_id from TransApproval where TransApproval.DOc_Id= VW_PTR.Doc_id and TransApproval.Trans_Type=VW_PTR.Trans_Type  )" & strSrchString & " Group by Trans_type "
                'Query = " Select 0 Doc,'SO' Trans_type,'SalesOrder' as Type " _
                '       & " Union All Select count(*)Doc,'BM' Trans_type,'BOM' as Type FROM Vw_PTRSum Where  SOCreated_By = " & intUserId & "  and BomPrdStyle_Id=0  and BomApprovalStage<>'NA' and Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'PP' Trans_type,'ProdPlanning' as Type  FROM Vw_PTRSum Where SOCreated_By = " & intUserId & "   and PPDoc_Id=0 and PPApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'GP' Trans_type,'Fabric PO' As Type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and FabPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'AP' Trans_type,'Acc PO' As Type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and AccPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'FP' Trans_type,'Finish PO' As Type  FROM Vw_PTRSum Where SOCreated_By = " & intUserId & "  and FinPoDoc_id=0 and PPApprovalStage='NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'JW' Trans_type,'JobWorkorder' as Type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "  and JobDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'GI' Trans_type,'Fabric Purchase' As Type  FROM Vw_PTRSum Where FabCreated_By = " & intUserId & "  and FabPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'AI' Trans_type,'Acc Purchase' As Type  FROM Vw_PTRSum Where AccCreated_By = " & intUserId & "  and AccPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'FI' Trans_type,'Finish Purchase' As Type  FROM Vw_PTRSum Where FinCreated_By = " & intUserId & "  and FinPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'JB' Trans_type,'Job Card' As Type  FROM Vw_PTRSum Where JobCreated_By = " & intUserId & "  and FabIsuDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'PL' Trans_type ,'Packing List' As Type  FROM Vw_PTRSum Where SoCreated_By = " & intUserId & "  and Slip_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'PS' Trans_type,'Packing Slip' As Type  FROM Vw_PTRSum Where PACKINGSlipCreated_By = " & intUserId & "  and Challan_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'SI' Trans_type,'Sales Invoice' As Type  FROM Vw_PTRSum Where PackingCreated_By = " & intUserId & "  and SaleBill='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                'Query = " Select 0 Doc,'SO' Trans_type,'SalesOrder' as Type " _
                '      & " Union All Select count(*) Doc,'BM' Trans_type,'BOM' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where  (SalesOrderDtl.Style_key not in (Select BomPrdStyle.Style_key from BomPrdStyle) And SalesOrderDtl.Type_Key not in(Select BomPrdStyle.Type_Key from BomPrdStyle) And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle)  And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle))  And SalesOrder.Created_by = " & intUserId & "   and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                '      & " Union All Select count(*) Doc,'PP' Trans_type,'ProdPlanning' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where   docdtl_id not in (Select So_DocDtlId from ProdnPlnDtl)  And SalesOrder.Created_by = " & intUserId & "   and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                '      & " Union All select count(*)Doc,'GP' Trans_type,'Fabric PO' As Type  from prodnplnfab where style_key <>'' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & " and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                '      & " Union All select count(*)Doc,'AP' Trans_type,'Acc PO' As Type  from prodnplnfab where style_key ='' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & " and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                '      & " Union All select count(*)Doc,'FP' Trans_type,'Finish PO' As Type  from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_Id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_Key=SalesOrderDtl.Style_Key where  MfgTrd='T' and SalesOrderDtl.doc_id in (Select Doc_id from SalesOrder where Created_by= " & intUserId & "and CoBr_Id =" & SelBranchId & ") and DocDtl_id not in (Select SODocDtl_id from PurOrderDtl )  " _
                '      & " Union All Select  Count(*)Doc,'JW' Trans_type,'JobWorkorder' as Type  FROM ProdnPlnDtl Inner Join ProdnPln on ProdnPln.DOc_id =ProdnPlnDtl.Doc_id Where ProdnPlnDtl.DocDtl_id not in (Select PP_DocDtlid from JobOrderDtl) 	And ProdnPln.Created_by= " & intUserId & " and ProdnPln.CoBr_Id =" & SelBranchId & "" _
                '      & " Union All Select count(*) Doc,'GI' Trans_type,'Fabric Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='F' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "" _
                '      & " Union All Select count(*) Doc,'AI' Trans_type,'Acc Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='F' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "" _
                '      & " Union All Select count(*) Doc,'FI' Trans_type,'Finish Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='F' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "" _
                '      & " Union All Select  Count(*)Doc,'JB' Trans_type,'Job Card' As Type   FROM Vw_PTRSum Where JobCreated_By = " & intUserId & "  and FabIsuDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '      & " Union All Select count(*) Doc,'PL' Trans_type,'Packing List' As Type from SalesOrderDtl  Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingSlipDtl inner join PackingSlip on PackingSlip.Doc_Id=PackingSlipDtl.Doc_id ) And SalesOrder.Created_by = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                '      & " Union All Select count(*) Doc,'PS' Trans_type,'Packing Slip' As Type from PackingSlipDtl  Inner Join PackingSlip on PackingSlip.Doc_id=PackingSlipDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingDtl inner join Packing on Packing.Doc_Id=PackingDtl.Doc_id ) And PackingSlip.Created_By = " & intUserId & " and PackingSlip.CoBr_Id  =" & SelBranchId & "" _
                '      & " Union All Select count(*) Doc,'SI' Trans_type,'Sales Invoice' As Type from PackingDtl  Inner Join Packing on Packing.Doc_id=PackingDtl.Doc_id where docdtl_id not in (Select PackDocDtl_id from SaleBillDtl inner join SaleBill on SaleBill.Doc_Id=SaleBillDtl.Doc_id ) And Packing.Created_By = " & intUserId & "  and Packing.CoBr_Id  =" & SelBranchId & ""

                '''Rohit 04092018

                'Query = " Select 0 Doc,'SO' Trans_type,'SalesOrder' as Type " _
                '       & " Union All Select count(*) Doc,'BM' Trans_type,'BOM' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where  (SalesOrderDtl.Style_key not in (Select BomPrdStyle.Style_key from BomPrdStyle) And SalesOrderDtl.Type_Key not in(Select BomPrdStyle.Type_Key from BomPrdStyle) And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle)  And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle)) and MFGTrd='M'  And SalesOrder.Created_by = " & intUserId & "   and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select count(*) Doc,'PP' Trans_type,'ProdPlanning' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where   docdtl_id not in (Select So_DocDtlId from ProdnPlnDtl) and MFGTrd='M'  And SalesOrder.Created_by = " & intUserId & "   and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All select count(*)Doc,'GP' Trans_type,'Fabric PO' As Type  from prodnplnfab where style_key <>'' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & " and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                '       & " Union All select count(*)Doc,'AP' Trans_type,'Acc PO' As Type  from prodnplnfab where style_key ='' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & " and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                '       & " Union All   select count(*)Doc,'FP' Trans_type,'Finish PO' As Type  from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_Id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_Key=SalesOrderDtl.Style_Key where  MfgTrd='T' and SalesOrderDtl.doc_id in (Select Doc_id from SalesOrder where Created_by= " & intUserId & "and CoBr_Id =" & SelBranchId & ") and DocDtl_id not in (Select SODocDtl_id from PurOrderDtl )  " _
                '       & " Union All Select  Count(*)Doc,'JW' Trans_type,'JobWorkorder' as Type  FROM ProdnPlnDtl Inner Join ProdnPln on ProdnPln.DOc_id =ProdnPlnDtl.Doc_id Where ProdnPlnDtl.DocDtl_id not in (Select PP_DocDtlid from JobOrderDtl) 	And ProdnPln.Created_by= " & intUserId & " and ProdnPln.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'GI' Trans_type,'Fabric Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='G' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'AI' Trans_type,'Acc Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='A' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'FI' Trans_type,'Finish Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='F' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'JB' Trans_type,'Job Card' As Type from jobOrderDtl  Inner Join jobOrder on jobOrder.Doc_id=jobOrderDtl.Doc_id where docdtl_id not in (Select JobWorkDocDtl_Id from ProcIsuDtl )  And jobOrder.Created_by= " & intUserId & "  and jobOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select count(*) Doc,'PL' Trans_type,'Packing Slip' As Type from SalesOrderDtl  Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingSlipDtl inner join PackingSlip on PackingSlip.Doc_Id=PackingSlipDtl.Doc_id ) And SalesOrder.Created_by = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'PS' Trans_type,'Packing List' As Type from PackingSlipDtl  Inner Join PackingSlip on PackingSlip.Doc_id=PackingSlipDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingDtl inner join Packing on Packing.Doc_Id=PackingDtl.Doc_id ) And PackingSlip.Created_By = " & intUserId & " and PackingSlip.CoBr_Id  =" & SelBranchId & "" _
                '       & " Union All Select count(*) Doc,'SI' Trans_type,'Sales Invoice' As Type from PackingDtl  Inner Join Packing on Packing.Doc_id=PackingDtl.Doc_id where docdtl_id not in (Select PackDocDtl_id from SaleBillDtl inner join SaleBill on SaleBill.Doc_Id=SaleBillDtl.Doc_id ) And Packing.Created_By = " & intUserId & "  and Packing.CoBr_Id  =" & SelBranchId & ""


                Query = " Select 0 Doc,'SO' Trans_type,'SalesOrder' as Type " _
                       & " Union All Select count(*) Doc,'BM' Trans_type,'BOM' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where  (SalesOrderDtl.Style_key not in (Select BomPrdStyle.Style_key from BomPrdStyle) And SalesOrderDtl.Type_Key not in(Select BomPrdStyle.Type_Key from BomPrdStyle) And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle)  And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle)) and MFGTrd='M'  And SalesOrder.Created_by = " & intUserId & "   and SalesOrder.CoBr_Id =" & SelBranchId & "  and SalesOrder.Status=1 " _
                       & " Union All Select count(*) Doc,'PP' Trans_type,'ProdPlanning' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where   docdtl_id not in (Select So_DocDtlId from ProdnPlnDtl) and MFGTrd='M'  And SalesOrder.Created_by = " & intUserId & "  and SalesOrder.Status=1 and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                       & " Union All select count(*)Doc,'GP' Trans_type,'Fabric PO' As Type  from prodnplnfab where style_key <>'' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & " and Prodnpln.Status=1 and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                       & " Union All select count(*)Doc,'AP' Trans_type,'Acc PO' As Type  from prodnplnfab where style_key ='' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & " and Prodnpln.Status=1 and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                       & " Union All   select count(*)Doc,'FP' Trans_type,'Finish PO' As Type  from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_Id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_Key=SalesOrderDtl.Style_Key where  MfgTrd='T' and SalesOrderDtl.doc_id in (Select Doc_id from SalesOrder where Created_by= " & intUserId & "and CoBr_Id =" & SelBranchId & ") and DocDtl_id not in (Select SODocDtl_id from PurOrderDtl )  and SalesOrder.Status=1 " _
                       & " Union All Select  Count(*)Doc,'JW' Trans_type,'JobWorkorder' as Type  FROM ProdnPlnDtl Inner Join ProdnPln on ProdnPln.DOc_id =ProdnPlnDtl.Doc_id Where ProdnPlnDtl.DocDtl_id not in (Select PP_DocDtlid from JobOrderDtl) 	And ProdnPln.Created_by= " & intUserId & " and ProdnPln.CoBr_Id =" & SelBranchId & "  and ProdnPln.Status=1  " _
                       & " Union All  Select count(*) Doc,'GI' Trans_type,'Fabric Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='G' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & " and PurOrder.Status=1 " _
                       & " Union All  Select count(*) Doc,'AI' Trans_type,'Acc Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='A' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & " and PurOrder.Status=1 " _
                       & " Union All  Select count(*) Doc,'FI' Trans_type,'Finish Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='F' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & " and PurOrder.Status=1 " _
                       & " Union All  Select count(*) Doc,'JB' Trans_type,'Job Card' As Type from jobOrderDtl  Inner Join jobOrder on jobOrder.Doc_id=jobOrderDtl.Doc_id where docdtl_id not in (Select JobWorkDocDtl_Id from ProcIsuDtl )  And jobOrder.Created_by= " & intUserId & "  and jobOrder.CoBr_Id =" & SelBranchId & " and jobOrder.Status=1 " _
                       & " Union All Select count(*) Doc,'PL' Trans_type,'Packing Slip' As Type from SalesOrderDtl  Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingSlipDtl inner join PackingSlip on PackingSlip.Doc_Id=PackingSlipDtl.Doc_id ) And SalesOrder.Created_by = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & " and SalesOrder.Status=1 " _
                       & " Union All  Select count(*) Doc,'PS' Trans_type,'Packing List' As Type from PackingSlipDtl  Inner Join PackingSlip on PackingSlip.Doc_id=PackingSlipDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingDtl inner join Packing on Packing.Doc_Id=PackingDtl.Doc_id ) And PackingSlip.Created_By = " & intUserId & " and PackingSlip.CoBr_Id  =" & SelBranchId & " and PackingSlip.Status=1 " _
                       & " Union All Select count(*) Doc, 'SI' Trans_type,'Sales Invoice' As Type from PackingDtl  Inner Join Packing on Packing.Doc_id=PackingDtl.Doc_id where PackingDtl.PSDTL_ID In(Select Docdtl_id from packingslipdtl where sodoc_id in (Select Doc_Id From SalesOrder Where SalesOrder.Created_by = " & intUserId & " )) And docdtl_id not in (Select PackDocDtl_id from SaleBillDtl inner join SaleBill on SaleBill.Doc_Id=SaleBillDtl.Doc_id )  and Packing.CoBr_Id  = '" & SelBranchId & "'  and Packing.Status=1 "
            ElseIf strPartyNm = "3" Then
                Query = " Select Distinct count(Doc_id)Doc,Trans_type,Type from ( SELECT dISTINCT * FROM (Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type ='" & strParty & "') " _
                         & " Union all   Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and ledger.approval=0 and level_type='2'))  " _
                         & "  union all Select * from VW_PTR Where CoBr_Id =" & SelBranchId & " and Created_By in (Select User_Id from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type in (Select Ledger.led_key from Users Inner Join ledger on Users.Led_Key=Ledger.Led_Key Where  LevelEmp_Type='" & strParty & "' and level_type='2')) and doc_id in( Select doc_id from TransApproval where TransApproval.Trans_Type=VW_PTR.Trans_Type)) AA) a  where a.doc_id not in (select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type and level_id=3 and ApproveFlag='A' Union all  select Doc_Id from TransApproval where TransApproval.Doc_Id=a.Doc_Id and a.Trans_Type=TransApproval.Trans_type  and ApprovRejected='R' and ApproveFlag='R')" & strSrchString & "  and Trans_Type in (Select ISnull(Trans_Type,'')Trans_Type from TransForApproval Where Trans_Type<> '')  Group by Trans_type,Type   "
            ElseIf strPartyNm = "1" Then
                Dim ReportFilter As String = ""
                'ReportFilter = "Vw_SOApprovalStatusReport.CoBr_Id = '" & SelBranchId & "' And (Vw_SOApprovalStatusReport.SoCreated_By = " & intUserId & " Or Vw_SOApprovalStatusReport.PPCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.JobCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FinCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FabCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.AccCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FinPurCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.FabPurCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.AccPurCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.JobIsuCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.PACKINGSLIPCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.PACKINGCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.salebillCreated_By = " & intUserId & "  Or Vw_SOApprovalStatusReport.BomCreated_By = " & intUserId & " ) And Vw_SOApprovalStatusReport.Status <> '0'"
                'from (Select  Count(*)Doc,'SO' Trans_type  FROM Vw_PTRSum Where SoCreated_By = " & intUserId & "    and Vw_PTRSum.SOApprovalStage<>'3' and Vw_PTRSum.CoBr_Id =" & SelBranchId & " group by SoDoc_No)A
                'Query = " Select 0 Doc,'SO' Trans_type " _
                '       & " Union All Select Count(Doc)Doc,'BM' Trans_type from  (Select count(*)Doc,BomPrdStyle_Id,'BM' Trans_type  FROM Vw_PTRSum Where  SOCreated_By = " & intUserId & "  and BomPrdStyle_Id=0  and BomApprovalStage<>'NA' and Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by BomPrdStyle_Id)A" _
                '       & " Union All Select  Count(Doc)Doc,'PP' Trans_type from (Select  Count(*)Doc,PPDoc_no,'PP' Trans_type  FROM Vw_PTRSum Where SOCreated_By = " & intUserId & "   and PPDoc_Id=0 and PPApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by PPDoc_no)A" _
                '       & " Union All Select  Count(Doc)Doc,'JW' Trans_type from (Select  Count(*)Doc,'JW' Trans_type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "  and JobDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by Job_Docno)A" _
                '       & " Union All Select  Count(Doc)Doc,'FP' Trans_type from (Select  Count(*)Doc,'FP' Trans_type  FROM Vw_PTRSum Where SOCreated_By = " & intUserId & "  and FinPoDoc_id=0 and PPApprovalStage='NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FinPODoc_no)A" _
                '       & " Union All Select  Count(Doc)Doc,'GP' Trans_type from (Select  Count(*)Doc,'GP' Trans_type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and FabPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FabPODoc_no)A" _
                '       & " Union All Select  Count(Doc)Doc,'AP' Trans_type from (Select  Count(*)Doc,'AP' Trans_type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and AccPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by AccPODoc_no)A" _
                '       & " Union All Select  Count(Doc)Doc,'FI' Trans_type from (Select  Count(*)Doc,'FI' Trans_type  FROM Vw_PTRSum Where FinCreated_By = " & intUserId & "  and FinPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FinPurDoc_No)A" _
                '       & " Union All Select  Count(Doc)Doc,'GI' Trans_type from (Select  Count(*)Doc,'GI' Trans_type  FROM Vw_PTRSum Where FabCreated_By = " & intUserId & "  and FabPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FabPurDoc_No)A" _
                '       & " Union All Select  Count(Doc)Doc,'AI' Trans_type from (Select  Count(*)Doc,'AI' Trans_type  FROM Vw_PTRSum Where AccCreated_By = " & intUserId & "  and AccPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by AccPurDoc_No)A" _
                '       & " Union All Select  Count(Doc)Doc,'JB' Trans_type from (Select  Count(*)Doc,'JB' Trans_type  FROM Vw_PTRSum Where JobCreated_By = " & intUserId & "  and FabIsuDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by FabIsuDoc_no)A" _
                '       & " Union All Select  Count(Doc)Doc,'PL' Trans_type from (Select  Count(*)Doc,'PL' Trans_type  FROM Vw_PTRSum Where SoCreated_By = " & intUserId & "  and Slip_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by Slip_No)A" _
                '       & " Union All Select  Count(Doc)Doc,'PS' Trans_type from (Select  Count(*)Doc,'PS' Trans_type  FROM Vw_PTRSum Where PACKINGSlipCreated_By = " & intUserId & "  and Challan_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by Challan_No)A" _
                '       & " Union All Select  Count(Doc)Doc,'SI' Trans_type from (Select  Count(*)Doc,'SI' Trans_type  FROM Vw_PTRSum Where PackingCreated_By = " & intUserId & "  and SaleBill='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "group by SaleBill)A"
                'Query = " Select 0 Doc,'SO' Trans_type,'SalesOrder' as Type " _
                '       & " Union All Select count(*)Doc,'BM' Trans_type,'BOM' as Type   FROM Vw_PTRSum Where  SOCreated_By = " & intUserId & "  and BomPrdStyle_Id=0  and BomApprovalStage<>'NA' and Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'PP' Trans_type,'ProdPlanning' as Type  FROM Vw_PTRSum Where SOCreated_By = " & intUserId & "   and PPDoc_Id=0 and PPApprovalStage<>'NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'GP' Trans_type,'Fabric PO' As Type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and FabPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'AP' Trans_type,'Acc PO' As Type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "   and AccPoDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'FP' Trans_type,'Finish PO' As Type   FROM Vw_PTRSum Where SOCreated_By = " & intUserId & "  and FinPoDoc_id=0 and PPApprovalStage='NA' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'JW' Trans_type,'JobWorkorder' as Type  FROM Vw_PTRSum Where PPCreated_By = " & intUserId & "  and JobDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'GI' Trans_type ,'Fabric Purchase' As Type FROM Vw_PTRSum Where FabCreated_By = " & intUserId & "  and FabPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'AI' Trans_type ,'Acc Purchase' As Type FROM Vw_PTRSum Where AccCreated_By = " & intUserId & "  and AccPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'FI' Trans_type,'Finish Purchase' As Type  FROM Vw_PTRSum Where FinCreated_By = " & intUserId & "  and FinPurDoc_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'JB' Trans_type,'Job Card' As Type   FROM Vw_PTRSum Where JobCreated_By = " & intUserId & "  and FabIsuDoc_id=0 and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'PL' Trans_type ,'Packing List' As Type  FROM Vw_PTRSum Where SoCreated_By = " & intUserId & "  and Slip_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'PS' Trans_type,'Packing Slip' As Type  FROM Vw_PTRSum Where PACKINGSlipCreated_By = " & intUserId & "  and Challan_No='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select  Count(*)Doc,'SI' Trans_type,'Sales Invoice' As Type  FROM Vw_PTRSum Where PackingCreated_By = " & intUserId & "  and SaleBill='' and  Vw_PTRSum.CoBr_Id =" & SelBranchId & ""
                ''Rohit 04092019
                'Query = " Select 0 Doc,'SO' Trans_type,'SalesOrder' as Type " _
                '       & " Union All Select count(*) Doc,'BM' Trans_type,'BOM' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where  (SalesOrderDtl.Style_key not in (Select BomPrdStyle.Style_key from BomPrdStyle) And SalesOrderDtl.Type_Key not in(Select BomPrdStyle.Type_Key from BomPrdStyle) And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle) and MFGTrd='M' And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle))  And SalesOrder.Created_by = " & intUserId & "   and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select count(*) Doc,'PP' Trans_type,'ProdPlanning' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where   docdtl_id not in (Select So_DocDtlId from ProdnPlnDtl) and MFGTrd='M' And SalesOrder.Created_by = " & intUserId & "   and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All select count(*)Doc,'GP' Trans_type,'Fabric PO' As Type  from prodnplnfab where style_key <>'' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & " and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                '       & " Union All select count(*)Doc,'AP' Trans_type,'Acc PO' As Type  from prodnplnfab where style_key ='' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & " and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                '       & " Union All   select count(*)Doc,'FP' Trans_type,'Finish PO' As Type  from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_Id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_Key=SalesOrderDtl.Style_Key where  MfgTrd='T' and SalesOrderDtl.doc_id in (Select Doc_id from SalesOrder where Created_by= " & intUserId & "and CoBr_Id =" & SelBranchId & ") and DocDtl_id not in (Select SODocDtl_id from PurOrderDtl )  " _
                '       & " Union All Select  Count(*)Doc,'JW' Trans_type,'JobWorkorder' as Type  FROM ProdnPlnDtl Inner Join ProdnPln on ProdnPln.DOc_id =ProdnPlnDtl.Doc_id Where ProdnPlnDtl.DocDtl_id not in (Select PP_DocDtlid from JobOrderDtl) 	And ProdnPln.Created_by= " & intUserId & " and ProdnPln.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'GI' Trans_type,'Fabric Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='G' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'AI' Trans_type,'Acc Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='A' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'FI' Trans_type,'Finish Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='F' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'JB' Trans_type,'Job Card' As Type from jobOrderDtl  Inner Join jobOrder on jobOrder.Doc_id=jobOrderDtl.Doc_id where docdtl_id not in (Select JobWorkDocDtl_Id from ProcIsuDtl )  And jobOrder.Created_by= " & intUserId & "  and jobOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All Select count(*) Doc,'PL' Trans_type,'Packing Slip' As Type from SalesOrderDtl  Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingSlipDtl inner join PackingSlip on PackingSlip.Doc_Id=PackingSlipDtl.Doc_id ) And SalesOrder.Created_by = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                '       & " Union All  Select count(*) Doc,'PS' Trans_type,'Packing List' As Type from PackingSlipDtl  Inner Join PackingSlip on PackingSlip.Doc_id=PackingSlipDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingDtl inner join Packing on Packing.Doc_Id=PackingDtl.Doc_id ) And PackingSlip.Created_By = " & intUserId & " and PackingSlip.CoBr_Id  =" & SelBranchId & "" _
                '       & " Union All Select count(*) Doc,'SI' Trans_type,'Sales Invoice' As Type from PackingDtl  Inner Join Packing on Packing.Doc_id=PackingDtl.Doc_id where docdtl_id not in (Select PackDocDtl_id from SaleBillDtl inner join SaleBill on SaleBill.Doc_Id=SaleBillDtl.Doc_id ) And Packing.Created_By = " & intUserId & "  and Packing.CoBr_Id  =" & SelBranchId & ""
                Query = " Select 0 Doc,'SO' Trans_type,'SalesOrder' as Type " _
                     & " Union All Select count(*) Doc,'BM' Trans_type,'BOM' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where  (SalesOrderDtl.Style_key not in (Select BomPrdStyle.Style_key from BomPrdStyle) And SalesOrderDtl.Type_Key not in(Select BomPrdStyle.Type_Key from BomPrdStyle) And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle) and MFGTrd='M' And SalesOrderDtl.Shade_Key not in(Select BomPrdStyle.Shade_Key from BomPrdStyle))  And SalesOrder.Created_by = " & intUserId & "   and SalesOrder.CoBr_Id =" & SelBranchId & " and SalesOrder.Status=1 " _
                     & " Union All Select count(*) Doc,'PP' Trans_type,'ProdPlanning' As Type from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_key=SalesOrderdtl.Style_Key where   docdtl_id not in (Select So_DocDtlId from ProdnPlnDtl) and MFGTrd='M' And SalesOrder.Created_by = " & intUserId & "   and SalesOrder.Status=1 and SalesOrder.CoBr_Id =" & SelBranchId & "" _
                     & " Union All select count(*)Doc,'GP' Trans_type,'Fabric PO' As Type  from prodnplnfab where style_key <>'' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & "   and Prodnpln.Status=1 and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                     & " Union All select count(*)Doc,'AP' Trans_type,'Acc PO' As Type  from prodnplnfab where style_key ='' and doc_id in (Select Doc_id from Prodnpln where Created_by=" & intUserId & "   and Prodnpln.Status=1 and CoBr_Id =" & SelBranchId & ") and ProdnPlnFab_ID not in (Select ProdnPlnFab_ID from PurOrderDtl ) " _
                     & " Union All   select count(*)Doc,'FP' Trans_type,'Finish PO' As Type  from SalesOrderDtl Inner Join SalesOrder on SalesOrder.Doc_Id=SalesOrderDtl.Doc_id Inner Join Style on Style.Style_Key=SalesOrderDtl.Style_Key where  MfgTrd='T' and SalesOrderDtl.doc_id in (Select Doc_id from SalesOrder where Created_by= " & intUserId & "and CoBr_Id =" & SelBranchId & ") and DocDtl_id not in (Select SODocDtl_id from PurOrderDtl )  and SalesOrder.Status=1 " _
                     & " Union All Select  Count(*)Doc,'JW' Trans_type,'JobWorkorder' as Type  FROM ProdnPlnDtl  Inner Join ProdnPln on ProdnPln.DOc_id =ProdnPlnDtl.Doc_id Inner Join Style on Style.style_key=prodnplndtl.style_key Where ProdnPlnDtl.DocDtl_id not in (Select PP_DocDtlid from JobOrderDtl) 	and style.MfgTrd='M' And ProdnPln.Created_by= " & intUserId & " and ProdnPln.CoBr_Id =" & SelBranchId & " and Prodnpln.Status=1 " _
                     & " Union All  Select count(*) Doc,'GI' Trans_type,'Fabric Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='G' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & " and PurOrder.Status=1 " _
                     & " Union All  Select count(*) Doc,'AI' Trans_type,'Acc Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='A' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & " and PurOrder.Status=1 " _
                     & " Union All  Select count(*) Doc,'FI' Trans_type,'Finish Purchase' As Type from PurOrderDtl   Inner Join PurOrder on PurOrder.Doc_id=PurOrderDtl.Doc_id where Po_Type='F' and docdtl_id not in (Select PodtlId from PurchaseDtl inner join Purchase on Purchase.Doc_Id=PurchaseDtl.DOc_id where Pur_type='F')  And PurOrder.Created_by= " & intUserId & "  and PurOrder.CoBr_Id =" & SelBranchId & " and PurOrder.Status=1 " _
                     & " Union All  Select count(*) Doc,'JB' Trans_type,'Job Card' As Type from jobOrderDtl  Inner Join jobOrder on jobOrder.Doc_id=jobOrderDtl.Doc_id where docdtl_id not in (Select JobWorkDocDtl_Id from ProcIsuDtl )  And jobOrder.Created_by= " & intUserId & "  and jobOrder.CoBr_Id =" & SelBranchId & "  and jobOrder.Status=1 " _
                     & " Union All Select count(*) Doc,'PL' Trans_type,'Packing Slip' As Type from SalesOrderDtl  Inner Join SalesOrder on SalesOrder.Doc_id=SalesOrderDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingSlipDtl inner join PackingSlip on PackingSlip.Doc_Id=PackingSlipDtl.Doc_id ) And SalesOrder.Created_by = " & intUserId & "  and SalesOrder.CoBr_Id =" & SelBranchId & " and SalesOrder.Status=1 " _
                     & " Union All  Select count(*) Doc,'PS' Trans_type,'Packing List' As Type from PackingSlipDtl  Inner Join PackingSlip on PackingSlip.Doc_id=PackingSlipDtl.Doc_id where docdtl_id not in (Select Sodocdtl_id from PackingDtl inner join Packing on Packing.Doc_Id=PackingDtl.Doc_id ) And PackingSlip.Created_By = " & intUserId & " and PackingSlip.CoBr_Id  =" & SelBranchId & " and PackingSlip.Status=1 " _
                     & " Union All Select count(*) Doc, 'SI' Trans_type,'Sales Invoice' As Type from PackingDtl  Inner Join Packing on Packing.Doc_id=PackingDtl.Doc_id where PackingDtl.PSDTL_ID In(Select Docdtl_id from packingslipdtl where sodoc_id in (Select Doc_Id From SalesOrder Where SalesOrder.Created_by = " & intUserId & " )) And docdtl_id not in (Select PackDocDtl_id from SaleBillDtl inner join SaleBill on SaleBill.Doc_Id=SaleBillDtl.Doc_id )  and Packing.CoBr_Id  = '" & SelBranchId & "'  and Packing.Status=1 "
            End If

            '     & " Union All Select count(*) Doc,'SI' Trans_type,'Sales Invoice' As Type from PackingDtl  Inner Join Packing on Packing.Doc_id=PackingDtl.Doc_id where docdtl_id not in (Select PackDocDtl_id from SaleBillDtl inner join SaleBill on SaleBill.Doc_Id=SaleBillDtl.Doc_id ) And PackingDtl.PSDTL_ID In(Select Docdtl_id from packingslipdtl where sodoc_id in (Select Doc_Id From SalesOrder Where SalesOrder.Created_by = " & intUserId & " )) and Packing.CoBr_Id  = " & SelBranchId & "  and Packing.Status=1 "

            DtTable = Common.GetDataTable(Query)
            Dim PurRow, NewRow As DataRow
            Dim i As Integer

            For Each PurRow In DtTable.Rows

                i = MonthExist1(PurRow("Trans_Type"))
                NewRow = Details1.NewRow
                NewRow(GridColumns.Party_key) = strParty
                NewRow(GridColumns.DocType) = PurRow("Type") & ""
                NewRow(GridColumns.MName) = PurRow("Trans_Type") & ""

                NewRow(GridColumns.Debit) = PurRow("Doc")
                Details1.Rows.Add(NewRow)


                Details1.AcceptChanges()
                dtgParty.CurrentRowIndex = Details1.Rows.Count - 1
            Next PurRow

            Details1.AcceptChanges()

            dtgParty.CurrentRowIndex = 0
            dtgParty.Focus()
            'dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)

        End If
    End Sub
    Private Sub dtgPartyAc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgPartyAc.MouseUp
        Try
            dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)
        Catch ex As IndexOutOfRangeException
            Exit Sub
        End Try
    End Sub
    

    Private Sub dtgPartyAc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgPartyAc.DoubleClick
        Dim StrMonthId As String

        If dtgPartyAc.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        StrMonthId = dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, 2)
        Dim frmPTRSumDetailed As New frmPTRSumDetailed(dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, 0), strPartyNm, StrMonthId, intUserId, True, "", "")
        frmPTRSumDetailed.MdiParent = Me.MdiParent
        frmPTRSumDetailed.Tag = ""
        frmPTRSumDetailed.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgPartyAc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgPartyAc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgPartyAc_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub frmCustAcBillWise_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If blnFlag = False Then
            TotDebit = 0
            TotCredit = 0
            TotClosing = 0
            'sunil 01/02/2019
            'DisplayFill()
            'DisplayFillPTR()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'If keyData = Keys.Enter Then
        '    If Me.ActiveControl.Parent Is CType(dtgPartyAc, DataGrid) Or Me.ActiveControl Is CType(dtgPartyAc, DataGrid) Then
        '        Call dtgPartyAc_DoubleClick(Nothing, Nothing)
        '    End If
        'End If
    End Function

    Private Sub DisplayGridHeaders()
        Dim Grid As New GridColumnCreateAndFormat("CustAcMonthly")

        With Grid
            .AddColumn("Party_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Party_Key")
            .AddColumn("DocType", GridColumnCreateAndFormat.enmTypeIdx.StringType, 200, "Doc_Type")
            .AddColumn("MName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "DocType")
            .AddColumn("Debit", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 230, "Count of pending approvals.")
            .AddColumn("Credit", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "Credit.")
            .AddColumn("Closing", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "Closing.")
            .AddColumn("Flag", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("MonthId", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("SeqNo", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")

            .AddColumnToTable()
            Details = .GetTable
            Details.DefaultView.AllowNew = False
            Details.DefaultView.AllowEdit = True
            Details.DefaultView.AllowDelete = False

            dtgPartyAc.DataSource = Details
            .DisplayGridHeaders(Details, dtgPartyAc, False)
        End With
    End Sub
    Private Sub DisplayGridHeadersPTR()
        Dim Grid As New GridColumnCreateAndFormat("CustAcMonthly1")

        With Grid
            .AddColumn("Party_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Party_Key")
            .AddColumn("DocType", GridColumnCreateAndFormat.enmTypeIdx.StringType, 200, "Doc_Type")
            .AddColumn("MName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "DocType")
            .AddColumn("Debit", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 230, "Count of Document Creation.")
            .AddColumn("Credit", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "Credit.")
            .AddColumn("Closing", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "Closing.")
            .AddColumn("Flag", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("MonthId", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("SeqNo", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")

            .AddColumnToTable()
            Details1 = .GetTable
            Details1.DefaultView.AllowNew = False
            Details1.DefaultView.AllowEdit = True
            Details1.DefaultView.AllowDelete = False

            dtgParty.DataSource = Details1
            .DisplayGridHeaders(Details1, dtgParty, False)
        End With
    End Sub
    Private Function MonthExist(ByVal MonthName As String) As Integer
        Dim i As Integer
        Dim RecRow() As DataRow

        RecRow = Details.Select("MName = '" & MonthName & "'", "")
        If RecRow.Length > 0 Then
            i = Details.Rows.IndexOf(RecRow(0))
        Else
            Return -1
        End If

        Return i
    End Function
    Private Function MonthExist1(ByVal MonthName As String) As Integer
        Dim i As Integer
        Dim RecRow() As DataRow

        RecRow = Details1.Select("MName = '" & MonthName & "'", "")
        If RecRow.Length > 0 Then
            i = Details1.Rows.IndexOf(RecRow(0))
        Else
            Return -1
        End If

        Return i
    End Function
    Private Sub btnDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailed.Click
        If dtgPartyAc.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        Dim frmCustAcDetailed As New frmCustAcDetailed(dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, 0), strPartyNm, 0, True, "", "")
        frmCustAcDetailed.MdiParent = Me.MdiParent
        frmCustAcDetailed.Tag = "CustAcDetailed"
        frmCustAcDetailed.Show()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

    Private Sub btnDateCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateCancel.Click
        grpDateRange.Visible = False
    End Sub

    Private Sub btnConfDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfDate.Click
        If dtgPartyAc.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Dim strFromDt As String = dtpFromDt.Value
        Dim strToDt As String = dtpToDate.Value

        Me.Cursor = Cursors.WaitCursor
        Dim frmCustAcDetailed As New frmCustAcDetailed(dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, 0), strPartyNm, 0, True, strFromDt, strToDt)
        frmCustAcDetailed.MdiParent = Me.MdiParent
        frmCustAcDetailed.Tag = "CustAcDetailed"
        frmCustAcDetailed.Show()
        Me.Cursor = Cursors.Default
        grpDateRange.Visible = False
    End Sub

    Private Sub btnDateRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateRange.Click
        grpDateRange.Visible = True
        dtpFromDt.Focus()
    End Sub

    Private Sub dtpFromDt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFromDt.KeyDownEvent, dtpToDate.KeyDownEvent
        MoveToNextControl(e)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        TotDebit = 0
        TotCredit = 0
        TotClosing = 0
        DisplayFill()
        DisplayFillPTR()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If Details.Columns.Count = 0 Then Exit Sub

        'Dim i As Integer
        'Dim j As Byte
        Dim r As Integer = 5
        Dim c As Byte = 1
        'Dim cols As Byte
        Dim txtFormat As New ArrayList
        Dim colFormat As New ArrayList

        Dim xlApp As New Excel.Application
        Dim xlBook As Excel.Workbook = xlApp.Workbooks.Add
        Dim xlSheet As Excel.Worksheet = xlBook.ActiveSheet
        Dim n As Integer = 10

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

        xlSheet.Cells(4, 1) = "FIN. YEAR : " & Format$(AccFromDt, "dd/MM/yyyy") & " - " & Format$(AccToDt, "dd/MM/yyyy")
        xlSheet.Range("A4:H4").Font.Bold = True
        xlSheet.Range("A4:H4").Font.Size = 12
        xlSheet.Cells(5, 1) = "MONTHLY SUMMARY OF ACCOUNTS"
        xlSheet.Range("A5:H5").Font.Bold = True
        xlSheet.Range("A5:H5").Font.Size = 14
        xlSheet.Cells(7, 1) = strPartyNm
        xlSheet.Range("A7:H7").Font.Bold = True
        xlSheet.Range("A7:H7").Font.Underline = True
        xlSheet.Range("A7:H7").Font.Size = 12

        With xlSheet
            .Range("A9:A9").Value = "Month"
            .Range("B9:B9").Value = "Debit"
            .Range("C9:C9").Value = "Credit"
            .Range("D9:D9").Value = "Closing"
            .Range("B9:D9").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            .Range("E9:E9").Value = ""
        End With

        Dim RecRow As DataRow

        For Each RecRow In Details.Rows
            With xlSheet
                .Range("A" & n & ":A" & n).Value = RecRow("MNAME") & ""
                .Range("B" & n & ":B" & n).Value = Format$(RecRow("Debit"), "0.00")
                .Range("C" & n & ":C" & n).Value = Format$(RecRow("Credit"), "0.00")
                .Range("D" & n & ":D" & n).Value = Format$(RecRow("Closing"), "0.00")
                .Range("E" & n & ":E" & n).Value = RecRow("Flag") & ""
            End With
            n += 1
        Next RecRow

        n += 1
        xlSheet.Range("A" & n & ":A" & n).Value = "Total"
        xlSheet.Range("B" & n & ":B" & n).Value = lblDebitAmt.Text
        xlSheet.Range("C" & n & ":C" & n).Value = lblCreditAmt.Text
        xlSheet.Range("D" & n & ":D" & n).Value = lblBalAmt.Text
        xlSheet.Range("E" & n & ":E" & n).Value = lblFlag.Text
        xlSheet.Range("A" & n & ":E" & n).Font.Bold = True

        'For j = 0 To Details.Columns.Count - 1
        '    'If Details.Columns(j).Width > 5 Then
        '    xlSheet.Cells(1, c) = Details.Columns(j).ColumnName
        '    c += 1 : cols += 1
        '    'End If
        '    If Details.Columns(j).DataType.FullName.ToUpper = "SYSTEM.DECIMAL" Then
        '        colFormat.Add(Chr(65 + j))
        '    ElseIf Details.Columns(j).DataType.FullName.ToUpper = "SYSTEM.STRING" Then
        '        txtFormat.Add(Chr(65 + j))
        '    End If
        'Next j

        'c = 1
        'For i = 0 To Details.Rows.Count - 1
        '    For j = 0 To Details.Columns.Count - 1
        '        xlSheet.Cells(r, c) = Details.Rows(i).Item(j)      'dtgPartyAc.Item(j, i).Value
        '        c += 1
        '    Next j
        '    r += 1 : c = 1
        'Next i

        xlSheet.Range("A9:E9").Font.Bold = True
        xlSheet.Range("A:A").ColumnWidth = 20
        xlSheet.Range("B:D").ColumnWidth = 15

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

    Private Sub dtgParty_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgParty.MouseUp
        Try
            dtgParty.Select(dtgParty.CurrentCell.RowNumber)
        Catch ex As IndexOutOfRangeException
            Exit Sub
        End Try
    End Sub
    Private Sub dtgParty_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgParty.DoubleClick
        Dim StrMonthId As String

        If dtgParty.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        StrMonthId = dtgParty.Item(dtgParty.CurrentRowIndex, 2)
        Dim frmPTRSumDetailed As New frmPTRSumDetailed(dtgParty.Item(dtgParty.CurrentRowIndex, 0), strPartyNm, StrMonthId, intUserId, False, "", "")
        frmPTRSumDetailed.MdiParent = Me.MdiParent
        frmPTRSumDetailed.Tag = ""
        frmPTRSumDetailed.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgParty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgParty.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgParty_DoubleClick(Nothing, Nothing)
        End If
    End Sub
End Class