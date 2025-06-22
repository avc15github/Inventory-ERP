Imports System.Data.SqlClient

Public Class frmStockDrillDown
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Filters As String, ByVal DateFilters As String, ByVal StkType As String, ByVal itmText As String, ByVal strDatefltrNew As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'strFilter = strFilter1
        AppliedFilters = Filters
        DateFilter = DateFilters
        Stk_Type = StkType
        itemTextFltr = itmText

        DateFilterNew = strDatefltrNew
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
    Friend WithEvents dtgPartyAc As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCreditAmt As System.Windows.Forms.Label
    Friend WithEvents lblBillAmt As System.Windows.Forms.Label
    Friend WithEvents lblOnAcAmt As System.Windows.Forms.Label
    Friend WithEvents lblBalAmt As System.Windows.Forms.Label
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSrchtext As System.Windows.Forms.TextBox
    Friend WithEvents lblFilters As System.Windows.Forms.Label
    Friend WithEvents rdSrchStart As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLedgerType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSearchFor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblDateFilter As System.Windows.Forms.Label
    Friend WithEvents lblTotOpQty As System.Windows.Forms.Label
    Friend WithEvents lblTotalQtyIn As System.Windows.Forms.Label
    Friend WithEvents lblTotalQtyOut As System.Windows.Forms.Label
    Friend WithEvents lblTotalClQty As System.Windows.Forms.Label
    Friend WithEvents rdSrchAnyWhere As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockDrillDown))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.lblTotalClQty = New System.Windows.Forms.Label
        Me.lblTotalQtyOut = New System.Windows.Forms.Label
        Me.lblTotalQtyIn = New System.Windows.Forms.Label
        Me.lblTotOpQty = New System.Windows.Forms.Label
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.lblDateFilter = New System.Windows.Forms.Label
        Me.lblFilters = New System.Windows.Forms.Label
        Me.dtgPartyAc = New System.Windows.Forms.DataGrid
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.rdSrchAnyWhere = New System.Windows.Forms.RadioButton
        Me.lblCreditAmt = New System.Windows.Forms.Label
        Me.rdSrchStart = New System.Windows.Forms.RadioButton
        Me.lblOnAcAmt = New System.Windows.Forms.Label
        Me.lblBalAmt = New System.Windows.Forms.Label
        Me.txtSrchtext = New System.Windows.Forms.TextBox
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.cmbSearchFor = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbLedgerType = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblBillAmt = New System.Windows.Forms.Label
        Me.chkShowAll = New System.Windows.Forms.CheckBox
        Me.grpMain.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dtgPartyAc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSearchFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLedgerType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.chkShowAll)
        Me.grpMain.Controls.Add(Me.lblTotalClQty)
        Me.grpMain.Controls.Add(Me.lblTotalQtyOut)
        Me.grpMain.Controls.Add(Me.lblTotalQtyIn)
        Me.grpMain.Controls.Add(Me.lblTotOpQty)
        Me.grpMain.Controls.Add(Me.pnlSearch)
        Me.grpMain.Controls.Add(Me.dtgPartyAc)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Controls.Add(Me.rdSrchAnyWhere)
        Me.grpMain.Controls.Add(Me.lblCreditAmt)
        Me.grpMain.Controls.Add(Me.rdSrchStart)
        Me.grpMain.Controls.Add(Me.lblOnAcAmt)
        Me.grpMain.Controls.Add(Me.lblBalAmt)
        Me.grpMain.Controls.Add(Me.txtSrchtext)
        Me.grpMain.Controls.Add(Me.btnSearch)
        Me.grpMain.Controls.Add(Me.cmbSearchFor)
        Me.grpMain.Controls.Add(Me.cmbLedgerType)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.lblBillAmt)
        Me.grpMain.Location = New System.Drawing.Point(1, -6)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(1077, 593)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'lblTotalClQty
        '
        Me.lblTotalClQty.AutoSize = True
        Me.lblTotalClQty.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalClQty.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalClQty.Location = New System.Drawing.Point(936, 540)
        Me.lblTotalClQty.Name = "lblTotalClQty"
        Me.lblTotalClQty.Size = New System.Drawing.Size(28, 14)
        Me.lblTotalClQty.TabIndex = 125
        Me.lblTotalClQty.Text = "0.00"
        '
        'lblTotalQtyOut
        '
        Me.lblTotalQtyOut.AutoSize = True
        Me.lblTotalQtyOut.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalQtyOut.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQtyOut.Location = New System.Drawing.Point(815, 540)
        Me.lblTotalQtyOut.Name = "lblTotalQtyOut"
        Me.lblTotalQtyOut.Size = New System.Drawing.Size(28, 14)
        Me.lblTotalQtyOut.TabIndex = 124
        Me.lblTotalQtyOut.Text = "0.00"
        '
        'lblTotalQtyIn
        '
        Me.lblTotalQtyIn.AutoSize = True
        Me.lblTotalQtyIn.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalQtyIn.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQtyIn.Location = New System.Drawing.Point(692, 540)
        Me.lblTotalQtyIn.Name = "lblTotalQtyIn"
        Me.lblTotalQtyIn.Size = New System.Drawing.Size(28, 14)
        Me.lblTotalQtyIn.TabIndex = 123
        Me.lblTotalQtyIn.Text = "0.00"
        '
        'lblTotOpQty
        '
        Me.lblTotOpQty.AutoSize = True
        Me.lblTotOpQty.BackColor = System.Drawing.Color.Transparent
        Me.lblTotOpQty.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotOpQty.Location = New System.Drawing.Point(574, 540)
        Me.lblTotOpQty.Name = "lblTotOpQty"
        Me.lblTotOpQty.Size = New System.Drawing.Size(28, 14)
        Me.lblTotOpQty.TabIndex = 122
        Me.lblTotOpQty.Text = "0.00"
        '
        'pnlSearch
        '
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.lblDateFilter)
        Me.pnlSearch.Controls.Add(Me.lblFilters)
        Me.pnlSearch.Location = New System.Drawing.Point(7, 36)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1061, 51)
        Me.pnlSearch.TabIndex = 121
        '
        'lblDateFilter
        '
        Me.lblDateFilter.AutoSize = True
        Me.lblDateFilter.BackColor = System.Drawing.Color.Transparent
        Me.lblDateFilter.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateFilter.Location = New System.Drawing.Point(12, 8)
        Me.lblDateFilter.Name = "lblDateFilter"
        Me.lblDateFilter.Size = New System.Drawing.Size(60, 14)
        Me.lblDateFilter.TabIndex = 12
        Me.lblDateFilter.Text = "Date Filter"
        '
        'lblFilters
        '
        Me.lblFilters.AutoSize = True
        Me.lblFilters.BackColor = System.Drawing.Color.Transparent
        Me.lblFilters.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilters.Location = New System.Drawing.Point(12, 30)
        Me.lblFilters.Name = "lblFilters"
        Me.lblFilters.Size = New System.Drawing.Size(51, 14)
        Me.lblFilters.TabIndex = 5
        Me.lblFilters.Text = "All Items"
        '
        'dtgPartyAc
        '
        Me.dtgPartyAc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgPartyAc.CaptionVisible = False
        Me.dtgPartyAc.DataMember = ""
        Me.dtgPartyAc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyAc.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyAc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgPartyAc.Location = New System.Drawing.Point(7, 89)
        Me.dtgPartyAc.Name = "dtgPartyAc"
        Me.dtgPartyAc.Size = New System.Drawing.Size(1063, 444)
        Me.dtgPartyAc.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnExit.Location = New System.Drawing.Point(1009, 563)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 24)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        '
        'lblFormCaption
        '
        Me.lblFormCaption.BackColor = System.Drawing.Color.Teal
        Me.lblFormCaption.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormCaption.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFormCaption.Location = New System.Drawing.Point(330, 9)
        Me.lblFormCaption.Name = "lblFormCaption"
        Me.lblFormCaption.Size = New System.Drawing.Size(307, 25)
        Me.lblFormCaption.TabIndex = 0
        Me.lblFormCaption.Text = "Consolidated Summary"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdSrchAnyWhere
        '
        Me.rdSrchAnyWhere.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdSrchAnyWhere.AutoSize = True
        Me.rdSrchAnyWhere.BackColor = System.Drawing.Color.Transparent
        Me.rdSrchAnyWhere.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSrchAnyWhere.Location = New System.Drawing.Point(799, 63)
        Me.rdSrchAnyWhere.Name = "rdSrchAnyWhere"
        Me.rdSrchAnyWhere.Size = New System.Drawing.Size(112, 18)
        Me.rdSrchAnyWhere.TabIndex = 9
        Me.rdSrchAnyWhere.Text = "Search between"
        Me.rdSrchAnyWhere.UseVisualStyleBackColor = False
        Me.rdSrchAnyWhere.Visible = False
        '
        'lblCreditAmt
        '
        Me.lblCreditAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCreditAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCreditAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblCreditAmt.Location = New System.Drawing.Point(434, 469)
        Me.lblCreditAmt.Name = "lblCreditAmt"
        Me.lblCreditAmt.Size = New System.Drawing.Size(88, 20)
        Me.lblCreditAmt.TabIndex = 119
        Me.lblCreditAmt.Text = "0"
        Me.lblCreditAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCreditAmt.Visible = False
        '
        'rdSrchStart
        '
        Me.rdSrchStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdSrchStart.AutoSize = True
        Me.rdSrchStart.BackColor = System.Drawing.Color.Transparent
        Me.rdSrchStart.Checked = True
        Me.rdSrchStart.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSrchStart.Location = New System.Drawing.Point(715, 56)
        Me.rdSrchStart.Name = "rdSrchStart"
        Me.rdSrchStart.Size = New System.Drawing.Size(117, 18)
        Me.rdSrchStart.TabIndex = 8
        Me.rdSrchStart.TabStop = True
        Me.rdSrchStart.Text = "Search from start"
        Me.rdSrchStart.UseVisualStyleBackColor = False
        Me.rdSrchStart.Visible = False
        '
        'lblOnAcAmt
        '
        Me.lblOnAcAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOnAcAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOnAcAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnAcAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblOnAcAmt.Location = New System.Drawing.Point(529, 469)
        Me.lblOnAcAmt.Name = "lblOnAcAmt"
        Me.lblOnAcAmt.Size = New System.Drawing.Size(88, 20)
        Me.lblOnAcAmt.TabIndex = 119
        Me.lblOnAcAmt.Text = "0"
        Me.lblOnAcAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOnAcAmt.Visible = False
        '
        'lblBalAmt
        '
        Me.lblBalAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBalAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBalAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblBalAmt.Location = New System.Drawing.Point(625, 469)
        Me.lblBalAmt.Name = "lblBalAmt"
        Me.lblBalAmt.Size = New System.Drawing.Size(112, 20)
        Me.lblBalAmt.TabIndex = 119
        Me.lblBalAmt.Text = "0"
        Me.lblBalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBalAmt.Visible = False
        '
        'txtSrchtext
        '
        Me.txtSrchtext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSrchtext.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrchtext.Location = New System.Drawing.Point(611, 65)
        Me.txtSrchtext.Name = "txtSrchtext"
        Me.txtSrchtext.Size = New System.Drawing.Size(59, 21)
        Me.txtSrchtext.TabIndex = 6
        Me.txtSrchtext.Tag = "Search Text"
        Me.txtSrchtext.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSearch.Location = New System.Drawing.Point(675, 35)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(34, 33)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Visible = False
        '
        'cmbSearchFor
        '
        Appearance1.FontData.Name = "Verdana"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.cmbSearchFor.Appearance = Appearance1
        Me.cmbSearchFor.AutoComplete = True
        Me.cmbSearchFor.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbSearchFor.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSearchFor.FlatMode = True
        Me.cmbSearchFor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchFor.Location = New System.Drawing.Point(226, -14)
        Me.cmbSearchFor.Name = "cmbSearchFor"
        Me.cmbSearchFor.Size = New System.Drawing.Size(69, 20)
        Me.cmbSearchFor.TabIndex = 13
        Me.cmbSearchFor.Tag = "Ledger Type"
        Me.cmbSearchFor.Visible = False
        '
        'cmbLedgerType
        '
        Appearance2.FontData.Name = "Verdana"
        Appearance2.FontData.SizeInPoints = 8.0!
        Me.cmbLedgerType.Appearance = Appearance2
        Me.cmbLedgerType.AutoComplete = True
        Me.cmbLedgerType.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbLedgerType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbLedgerType.FlatMode = True
        Me.cmbLedgerType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLedgerType.Location = New System.Drawing.Point(211, 61)
        Me.cmbLedgerType.Name = "cmbLedgerType"
        Me.cmbLedgerType.Size = New System.Drawing.Size(135, 20)
        Me.cmbLedgerType.TabIndex = 11
        Me.cmbLedgerType.Tag = "Ledger Type"
        Me.cmbLedgerType.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ledger Type"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(290, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 14)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Total "
        Me.Label1.Visible = False
        '
        'lblBillAmt
        '
        Me.lblBillAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBillAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBillAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblBillAmt.Location = New System.Drawing.Point(338, 469)
        Me.lblBillAmt.Name = "lblBillAmt"
        Me.lblBillAmt.Size = New System.Drawing.Size(88, 20)
        Me.lblBillAmt.TabIndex = 119
        Me.lblBillAmt.Text = "0"
        Me.lblBillAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBillAmt.Visible = False
        '
        'chkShowAll
        '
        Me.chkShowAll.AutoSize = True
        Me.chkShowAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowAll.Location = New System.Drawing.Point(10, 539)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.Size = New System.Drawing.Size(123, 17)
        Me.chkShowAll.TabIndex = 129
        Me.chkShowAll.Text = "Do Not Refresh"
        Me.chkShowAll.UseVisualStyleBackColor = True
        '
        'frmStockDrillDown
        '
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1079, 589)
        Me.Controls.Add(Me.grpMain)
        Me.MaximizeBox = False
        Me.Name = "frmStockDrillDown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Party Account"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.dtgPartyAc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSearchFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLedgerType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim cmdCommand As SqlCommand
    Dim sdaAdapter As SqlDataAdapter
    Dim strFilter As String
    Dim blnFlag As Boolean
    Dim DtSeries As DataTable
    Dim dtTemp As DataTable
    Dim WithEvents dtGrdRef As DataTable
    Dim SMSFields As String = ""
    Dim SMSGrpFields As String = ""
    Dim AppliedFilters As String = ""

    Dim DateFilter As String = ""
    Dim Stk_Type As String = ""
    Dim itemTextFltr As String = ""

    Dim DateFilterNew As String = ""

    Enum GridColumns
        Category
        Product
        Design
        Shade
        ITEMSUBGRPKey
        ItemKey
        StyleKey
        ShadeKey
        DocDt
        OpQty
        InQty
        OutQty
        Clqty
        PartyKey
        StockKey
    End Enum

    Private Sub frmCustAc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cmbSearchFor.Items
            .Add("Party")
            .Add("Broker")
        End With
        cmbSearchFor.SelectedIndex = 0

        With cmbLedgerType.Items
            .Add("All")
            .Add("GL")
            .Add("Customers")
            .Add("Suppliers")
        End With
        cmbLedgerType.SelectedIndex = 0
        lblDateFilter.Text = DateFilter
        lblFilters.Text = "Item : " & itemTextFltr

        If Stk_Type = "A" Then
            lblFormCaption.Text = "Accessories Stock Summary"
            Me.Text = "Accessories Stock Summary"
        ElseIf Stk_Type = "F" Then
            lblFormCaption.Text = "Finish Stock Summary"
            Me.Text = "Finish Stock Summary"
        Else
            lblFormCaption.Text = "Fabric Stock Summary"
            Me.Text = "Fabric Stock Summary"
        End If



        If blnFlag = True Then

            Call btnSearch_Click(btnSearch, Nothing)

            
            'BalAmt = Val(lblBillAmt.Text) - (Val(lblCreditAmt.Text) + Val(lblOnAcAmt.Text))
            'lblBalAmt.Text = IIf(BalAmt > 0, Format$(BalAmt, "0.00") & " " & "Dr", Format$(Math.Abs(BalAmt), "0.00") & " " & "Cr")
        End If
        txtSrchtext.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DisplaySeriesHeader(ByVal dtTable As DataTable)
        Dim tblStyle As New DataGridTableStyle
        '
        With tblStyle
            .MappingName = dtTable.TableName
            .HeaderFont = New System.Drawing.Font("Verdana", 8, FontStyle.Bold, GraphicsUnit.Point)
            .RowHeaderWidth = 12
            .ReadOnly = False
            .ForeColor = Color.DarkBlue
            .SelectionBackColor = Color.Lavender
            .SelectionForeColor = Color.DarkBlue
            .GridLineColor = Color.SteelBlue
            .HeaderForeColor = Color.Maroon
        End With

        Dim colCategory As New DataGridTextBoxColumn
        With colCategory
            .MappingName = dtTable.Columns(0).ColumnName
            .HeaderText = "Category"
            .Width = 120
            .ReadOnly = True
        End With

        Dim colProduct As New DataGridTextBoxColumn
        With colProduct
            .MappingName = dtTable.Columns(1).ColumnName
            .HeaderText = "Product"
            .Alignment = HorizontalAlignment.Left
            .Width = 220
            .ReadOnly = True
        End With

        Dim colDesign As New DataGridTextBoxColumn
        With colDesign
            .MappingName = dtTable.Columns(2).ColumnName
            .HeaderText = IIf(Stk_Type = "A", "", "Design")
            .Alignment = HorizontalAlignment.Left
            .Width = IIf(Stk_Type = "A", 0, 130)
            .ReadOnly = True
        End With

        Dim colShade As New DataGridTextBoxColumn
        With colShade
            .MappingName = dtTable.Columns(3).ColumnName
            .HeaderText = "Shade"
            .Alignment = HorizontalAlignment.Left
            .Width = 100
            .ReadOnly = True
        End With

        Dim colITEMSUBGRPKey As New DataGridTextBoxColumn
        With colITEMSUBGRPKey
            .MappingName = dtTable.Columns(4).ColumnName
            .HeaderText = ""
            .Alignment = HorizontalAlignment.Right
            .Width = 0
            .ReadOnly = True
        End With

        Dim colItemKey As New DataGridTextBoxColumn
        With colItemKey
            .MappingName = dtTable.Columns(5).ColumnName
            .HeaderText = ""
            .Width = 0
            .ReadOnly = True
        End With

        Dim colStyleKey As New DataGridTextBoxColumn
        With colStyleKey
            .MappingName = dtTable.Columns(6).ColumnName
            .HeaderText = ""
            .Width = 0
            .ReadOnly = True
        End With

        Dim colShadeKey As New DataGridTextBoxColumn
        With colShadeKey
            .MappingName = dtTable.Columns(7).ColumnName
            .HeaderText = ""
            .Alignment = HorizontalAlignment.Left
            .Width = 0
            .ReadOnly = True
        End With

        Dim colDocDt As New DataGridTextBoxColumn
        With colDocDt
            .MappingName = dtTable.Columns(8).ColumnName
            .HeaderText = ""
            .Width = 0
            .ReadOnly = True
        End With

        Dim colOpQty As New DataGridTextBoxColumn
        With colOpQty
            .MappingName = dtTable.Columns(9).ColumnName
            .HeaderText = "Op.Qty."
            .Width = 80
            .ReadOnly = True
        End With

        Dim colInQty As New DataGridTextBoxColumn
        With colInQty
            .MappingName = dtTable.Columns(10).ColumnName
            .HeaderText = "Qty.In."
            .Alignment = HorizontalAlignment.Left
            .Width = 80
            .ReadOnly = True
        End With

        Dim colOutQty As New DataGridTextBoxColumn
        With colOutQty
            .MappingName = dtTable.Columns(11).ColumnName
            .HeaderText = "Qty.Out."
            .Width = 80
            .ReadOnly = True
        End With

        Dim colClQty As New DataGridTextBoxColumn
        With colClQty
            .MappingName = dtTable.Columns(12).ColumnName
            .HeaderText = "Cl Qty"
            .Alignment = HorizontalAlignment.Left
            .Width = 80
            .ReadOnly = True
        End With

        Dim colPartyKey As New DataGridTextBoxColumn
        With colPartyKey
            .MappingName = dtTable.Columns(13).ColumnName
            .HeaderText = ""
            .Alignment = HorizontalAlignment.Left
            .Width = 0
            .ReadOnly = True
        End With

        Dim colStockKey As New DataGridTextBoxColumn
        With colStockKey
            .MappingName = dtTable.Columns(14).ColumnName
            .HeaderText = ""
            .Alignment = HorizontalAlignment.Left
            .Width = 0
            .ReadOnly = True
        End With

        '


        tblStyle.GridColumnStyles.Clear()
        tblStyle.GridColumnStyles.AddRange(New DataGridColumnStyle() {colCategory, colProduct, colDesign, colShade, colITEMSUBGRPKey, colItemKey, colStyleKey, colShadeKey, colDocDt, colOpQty, colInQty, colOutQty, colClQty, colPartyKey, colStockKey})



        Dim TotalWidthForOpQty As Integer = colCategory.Width + colProduct.Width + colDesign.Width + colShade.Width + 30
        Dim TotalWidthForQtyIn As Integer = colCategory.Width + colProduct.Width + colDesign.Width + colShade.Width + colOpQty.Width + 30
        Dim TotalWidthForQtyOut As Integer = colCategory.Width + colProduct.Width + colDesign.Width + colShade.Width + colOpQty.Width + colInQty.Width + 30
        Dim TotalWidthForClqty As Integer = colCategory.Width + colProduct.Width + colDesign.Width + colShade.Width + colOpQty.Width + colInQty.Width + colOutQty.Width + 30

        lblTotOpQty.Location = New Point(TotalWidthForOpQty, 540)
        lblTotalQtyIn.Location = New Point(TotalWidthForQtyIn, 540)
        lblTotalQtyOut.Location = New Point(TotalWidthForQtyOut, 540)
        lblTotalClQty.Location = New Point(TotalWidthForClqty, 540)


        colCategory = Nothing : colProduct = Nothing : colDesign = Nothing : colShade = Nothing
        colITEMSUBGRPKey = Nothing : colItemKey = Nothing : colStyleKey = Nothing : colShadeKey = Nothing : colDocDt = Nothing
        colOpQty = Nothing : colInQty = Nothing : colOutQty = Nothing : colClQty = Nothing : colPartyKey = Nothing : colStockKey = Nothing

        dtgPartyAc.TableStyles.Clear()
        dtgPartyAc.TableStyles.Add(tblStyle)
        dtgPartyAc.ReadOnly = True

    End Sub

    Private Sub dtgPartyAc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtgPartyAc.KeyPress

    End Sub

    Private Sub dtgPartyAc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgPartyAc.KeyUp
        'Try
        '    dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)
        'Catch ex As IndexOutOfRangeException
        '    Exit Sub
        'End Try
    End Sub

    Private Sub dtgPartyAc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgPartyAc.MouseUp
        Try
            dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)
        Catch ex As IndexOutOfRangeException
            Exit Sub
        End Try
    End Sub

    Private Sub dtgPartyAc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgPartyAc.DoubleClick
        Dim strPartyKey, strPartyNm As String
        Dim dtMonthlyDate As Date
        If dtgPartyAc.CurrentRowIndex = -1 Then Exit Sub
        blnFlag = False
        Dim intMonthId As Integer

        Me.Cursor = Cursors.WaitCursor
        strPartyKey = dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, 0)
        strPartyNm = dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, 1)
        dtMonthlyDate = AccToDt
        Dim frmCustAcDetailed As New frmStockDrillDownDtl(dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, 0), strPartyNm, intMonthId, True, DateFilterNew, Stk_Type, "", DateFilter, dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, 9), dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, 12))
        frmCustAcDetailed.MdiParent = Me.MdiParent
        frmCustAcDetailed.Tag = "CustAcMonthly"
        frmCustAcDetailed.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtgPartyAc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgPartyAc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgPartyAc_DoubleClick(Nothing, Nothing)
            'ElseIf e.KeyCode = Keys.Down Then
            '    Try
            '        dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)
            '    Catch ex As IndexOutOfRangeException
            '        Exit Sub
            '    End Try
        End If
    End Sub

    Private Sub frmCustAc_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If blnFlag = False Then

            If chkShowAll.Checked = False Then
                Call btnSearch_Click(btnSearch, Nothing)
            End If
            'Dim BalAmt As Double = 0
            'lblBillAmt.Text = 0 : lblCreditAmt.Text = 0 : lblOnAcAmt.Text = 0 : lblBalAmt.Text = 0
            'Query = " SELECT ISNULL(SUM(AMOUNT),0) DEBITS " _
            '    & " FROM VIEW_BYRACCOUNT_DEBITS1 LEFT JOIN PARTYDTL ON VIEW_BYRACCOUNT_DEBITS1.PARTYDTL_ID = PARTYDTL.PARTYDTL_ID " _
            '    & " LEFT JOIN PARTY ON PARTY.PARTY_KEY = PARTYDTL.PARTY_KEY " _
            '    & " LEFT JOIN CITY ON CITY.CITY_KEY = PARTYDTL.CITY_KEY " _
            '    & " LEFT JOIN STATE ON CITY.STATE_KEY = STATE.STATE_KEY " _
            '    & " WHERE VIEW_BYRACCOUNT_DEBITS1.COBR_ID = '" & SelBranchId & "' AND VIEW_BYRACCOUNT_DEBITS1.FCYR_KEY = '" & SelYearId & "'" & strFilter
            'dtTemp = Common.GetDataTable(Query)
            'If dtTemp.Rows.Count > 0 Then
            '    lblBillAmt.Text = dtTemp.Rows(0).Item("DEBITS")
            'End If

            'Query = "SELECT ISNULL(SUM(AMOUNT),0) CREDITS" _
            '    & " FROM VIEW_BYRACCOUNT_CREDITS1 LEFT JOIN PARTYDTL ON VIEW_BYRACCOUNT_CREDITS1.PARTYDTL_ID = PARTYDTL.PARTYDTL_ID " _
            '    & " LEFT JOIN PARTY ON PARTY.PARTY_KEY = PARTYDTL.PARTY_KEY " _
            '    & " LEFT JOIN CITY ON CITY.CITY_KEY = PARTYDTL.CITY_KEY " _
            '    & " LEFT JOIN STATE ON CITY.STATE_KEY = STATE.STATE_KEY " _
            '    & " WHERE VIEW_BYRACCOUNT_CREDITS1.COBR_ID = '" & SelBranchId & "' AND VIEW_BYRACCOUNT_CREDITS1.FCYR_KEY = '" & SelYearId & "'" & strFilter
            'dtTemp = Common.GetDataTable(Query)
            'If dtTemp.Rows.Count > 0 Then
            '    lblCreditAmt.Text = dtTemp.Rows(0).Item("CREDITS")
            'End If

            'Query = "SELECT ISNULL(SUM(AMOUNT),0) ONAC" _
            '    & " FROM VIEW_BYRACCOUNT_ONACCR1 LEFT JOIN PARTYDTL ON VIEW_BYRACCOUNT_ONACCR1.PARTYDTL_ID = PARTYDTL.PARTYDTL_ID " _
            '    & " LEFT JOIN PARTY ON PARTY.PARTY_KEY = PARTYDTL.PARTY_KEY " _
            '    & " LEFT JOIN CITY ON CITY.CITY_KEY = PARTYDTL.CITY_KEY " _
            '    & " LEFT JOIN STATE ON CITY.STATE_KEY = STATE.STATE_KEY " _
            '    & " WHERE VIEW_BYRACCOUNT_ONACCR1.COBR_ID = '" & SelBranchId & "' AND VIEW_BYRACCOUNT_ONACCR1.FCYR_KEY = '" & SelYearId & "'" & strFilter
            'dtTemp = Common.GetDataTable(Query)
            'If dtTemp.Rows.Count > 0 Then
            '    lblOnAcAmt.Text = dtTemp.Rows(0).Item("ONAC")
            'End If

            'BalAmt = Val(lblBillAmt.Text) - (Val(lblCreditAmt.Text) + Val(lblOnAcAmt.Text))
            'lblBalAmt.Text = IIf(BalAmt > 0, Format$(BalAmt, "0.00") & " " & "Dr", Format$(Math.Abs(BalAmt), "0.00") & " " & "Cr")
        End If
        txtSrchtext.Focus()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'If keyData = Keys.Down Or keyData = Keys.Up Then
        '    If Me.ActiveControl.Parent Is CType(dtgPartyAc, DataGrid) Or Me.ActiveControl Is CType(dtgPartyAc, DataGrid) Then
        '        Call dtgPartyAc_MouseClick(dtgPartyAc, Nothing)
        '    End If
        'End If
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim DtTable As New DataTable
        Dim Filter As String = ""
        Dim LedType As String = ""

        If txtSrchtext.Text.Trim.Length > 0 Then
            If cmbSearchFor.SelectedIndex = 0 Then
                If rdSrchStart.Checked Then
                    Filter = " And PartyName Like '" & txtSrchtext.Text & "%'"
                Else
                    Filter = " And PartyName Like '%" & txtSrchtext.Text & "%'"
                End If
            Else
                If rdSrchStart.Checked Then
                    Filter = " And BrokerName Like '" & txtSrchtext.Text & "%'"
                Else
                    Filter = " And BrokerName Like '%" & txtSrchtext.Text & "%'"
                End If
            End If
        End If

        If cmbLedgerType.SelectedIndex = 1 Then
            LedType = " Where Party.Led_Cat='L'"
        ElseIf cmbLedgerType.SelectedIndex = 2 Then
            LedType = " Where AccLGrp.AccLGrp_Type='4'"
        ElseIf cmbLedgerType.SelectedIndex = 3 Then
            LedType = " Where AccLGrp.AccLGrp_Type='3'"
        Else
            LedType = " Where AccLGrp.AccLGrp_Type in ('3','4') Or Party.Led_Cat='L' "
        End If

        'Query = "Select Party_key, PartyName, City, MobileNo, Abs(Sum(Amt)) Amt, case when Sum(Amt) < 0 then 'Cr' else 'Dr' end Flag, AccLGrp_Key, AccLGrp_Name, Broker_Key, BrokerName " _
        '    & " From ( " _
        '    & " Select A.CoBr_Id, A.Fcyr_Id, A.Led_Key Party_key, Party.Led_Name PartyName, Station.Stn_Name City, Party.Mobile1 MobileNo, " _
        '    & " case when AmtFlag = 'D' then Sum(Amount) else -Sum(Amount) end Amt, Party.AccLGrp_Key, AccLGrp.AccLGrp_Name, Party.Broker_Key, Broker.Led_Name BrokerName  " _
        '    & " from View_LedgerOnScreen as A " _
        '    & " Left Join Ledger Party	on A.Led_Key = Party.Led_Key " _
        '    & " Left Join Ledger Broker	on Party.Broker_Key = Broker.Led_Key " _
        '    & " Left Join Station on Party.OStn_Key = Station.Stn_Key " _
        '    & " Left Join AccLGrp on Party.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
        '    & LedType _
        '    & " Group By A.CoBr_Id, A.Fcyr_Id, A.Led_Key, Party.Led_Name, Station.Stn_Name, Party.Mobile1, AmtFlag, Party.AccLGrp_Key, AccLGrp.AccLGrp_Name, Party.Broker_Key, Broker.Led_Name  " _
        '    & " ) B " _
        '    & " WHERE COBR_ID = '" & SelBranchId & "' " & Filter & " AND PARTYNAME <> ''" _
        '    & " Group By Party_key, PartyName, City, MobileNo, AccLGrp_Key, AccLGrp_Name, Broker_Key, BrokerName " _
        '    & " ORDER BY PARTYNAME, CITY"

        If Stk_Type = "G" Then
            Query = " select  Category,Product,Style,Shade, ITEMSUBGRPKey , ItemKey , StyleKey , ShadeKey , DocDt ,OpQty,InQty,OutQty,Clqty,PartyKey,StockKey,BrandKey, ItemSizeKey ,TypeKey,StyleSize   " _
                 & " From ( " _
                 & " SELECT ITEMSUBGRP.ITEMSUBGRP_NAME Category, ITEM.ITEM_NAME Product,Style.Style_Code Style,SHADE.SHADE_NAME Shade , A.ITEMSUBGRP_Key ITEMSUBGRPKey , A.Item_Key ItemKey , A.Style_Key StyleKey , A.Shade_Key ShadeKey , A.Doc_Dt DocDt ," _
                 & "  0 OpQty ,(Case when TRJ_FLG = 'R' THEN sum(qty) else 0 end ) InQty , (case when TRJ_FLG ='I' THEN sum(qty) else 0 end ) OutQty, ((Case when TRJ_FLG='R' THEN sum(qty) else 0 end )- (case when TRJ_FLG ='I' THEN sum(qty) else 0 end )) Clqty , A.Party_Key PartyKey , A.Stock_Key  StockKey , A.Brand_Key BrandKey , A.ItemSize_Key ItemSizeKey , A.Type_Key TypeKey , ItemSize.Size_Name StyleSize , A.COBR_ID COBRID ,A.FCYR_ID FCYRID   " _
                 & " FROM View_FabricStockLedgerDrill as A " _
                 & " Left Join Item	on A.Item_Key = Item.Item_Key " _
                 & " Left Join ITEMSUBGRP on A.ITEMSUBGRP_Key = ITEMSUBGRP.ITEMSUBGRP_Key " _
                 & " Left Join Style on A.Style_Key = Style.Style_Key " _
                 & " Left Join Shade on A.Shade_Key = Shade.Shade_Key " _
                 & " Left Join Type on A.Type_Key = Type.Type_Key " _
                 & " Left Join Brand on A.Brand_Key = Brand.Brand_Key " _
                 & " Left Join ItemSize on A.ItemSize_Key = ItemSize.ItemSize_Key " _
                 & " GROUP BY ITEMSUBGRP.ITEMSUBGRP_NAME,ITEM.ITEM_NAME,Style.Style_Code,SHADE.SHADE_NAME, A.ITEMSUBGRP_Key,A.Item_Key,A.Style_Key,A.Shade_Key,A.Doc_Dt, A.Party_Key, A.Stock_Key,A.Brand_Key,A.ItemSize_Key , A.Type_Key,ItemSize.Size_Name, A.TRJ_FLG , A.COBR_ID,A.FCYR_ID  " _
                 & " ) B " _
                 & " WHERE B.COBRID = '" & SelBranchId & "' " & AppliedFilters & " AND B.FcyrId <='" & SelYearId & "' " _
                 & " GROUP BY Category,Product,Style,Shade, ITEMSUBGRPKey , ItemKey , StyleKey , ShadeKey , DocDt , OpQty,InQty,OutQty,Clqty,PartyKey,StockKey,BrandKey,ItemSizeKey ,TypeKey , StyleSize " _
                 & " ORDER BY Product,Style,Shade "
        ElseIf Stk_Type = "A" Then
            Query = " select  Category,Product,Style,Shade, ITEMSUBGRPKey , ItemKey , StyleKey , ShadeKey , DocDt ,OpQty,InQty,OutQty,Clqty,PartyKey,StockKey,BrandKey, ItemSizeKey ,TypeKey,StyleSize   " _
                 & " From ( " _
                 & " SELECT ITEMSUBGRP.ITEMSUBGRP_NAME Category, ITEM.ITEM_NAME Product,Style.Style_Code Style,SHADE.SHADE_NAME Shade , A.ITEMSUBGRP_Key ITEMSUBGRPKey , A.Item_Key ItemKey , A.Style_Key StyleKey , A.Shade_Key ShadeKey , A.Doc_Dt DocDt ," _
                 & "  0 OpQty ,(Case when TRJ_FLG = 'R' THEN sum(qty) else 0 end ) InQty , (case when TRJ_FLG ='I' THEN sum(qty) else 0 end ) OutQty, ((Case when TRJ_FLG='R' THEN sum(qty) else 0 end )- (case when TRJ_FLG ='I' THEN sum(qty) else 0 end )) Clqty , A.Party_Key PartyKey , A.Stock_Key  StockKey , A.Brand_Key BrandKey , A.ItemSize_Key ItemSizeKey , A.Type_Key TypeKey , ItemSize.Size_Name StyleSize , A.COBR_ID COBRID ,A.FCYR_ID FCYRID   " _
                 & " FROM View_AccStockLedgerDrill as A " _
                 & " Left Join Item	on A.Item_Key = Item.Item_Key " _
                 & " Left Join ITEMSUBGRP on A.ITEMSUBGRP_Key = ITEMSUBGRP.ITEMSUBGRP_Key " _
                 & " Left Join Style on A.Style_Key = Style.Style_Key " _
                 & " Left Join Shade on A.Shade_Key = Shade.Shade_Key " _
                 & " Left Join Type on A.Type_Key = Type.Type_Key " _
                 & " Left Join Brand on A.Brand_Key = Brand.Brand_Key " _
                 & " Left Join ItemSize on A.ItemSize_Key = ItemSize.ItemSize_Key " _
                 & " GROUP BY ITEMSUBGRP.ITEMSUBGRP_NAME,ITEM.ITEM_NAME,Style.Style_Code,SHADE.SHADE_NAME, A.ITEMSUBGRP_Key,A.Item_Key,A.Style_Key,A.Shade_Key,A.Doc_Dt, A.Party_Key, A.Stock_Key,A.Brand_Key,A.ItemSize_Key , A.Type_Key,ItemSize.Size_Name, A.TRJ_FLG , A.COBR_ID,A.FCYR_ID  " _
                 & " ) B " _
                 & " WHERE B.COBRID = '" & SelBranchId & "' " & AppliedFilters & " AND B.FcyrId <='" & SelYearId & "' " _
                 & " GROUP BY Category,Product,Style,Shade, ITEMSUBGRPKey , ItemKey , StyleKey , ShadeKey , DocDt , OpQty,InQty,OutQty,Clqty,PartyKey,StockKey,BrandKey,ItemSizeKey ,TypeKey , StyleSize " _
                 & " ORDER BY Product,Style,Shade "
        Else
            Query = " select  Category,Product,Style,Shade, ITEMSUBGRPKey , ItemKey , StyleKey , ShadeKey , DocDt ,OpQty,InQty,OutQty,Clqty,PartyKey,StockKey,BrandKey, StyleSizeId ,TypeKey,StyleSize   " _
                  & " From ( " _
                  & " SELECT ITEMSUBGRP.ITEMSUBGRP_NAME Category, ITEM.ITEM_NAME Product,Style.Style_Code Style,SHADE.SHADE_NAME Shade , A.ITEMSUBGRP_Key ITEMSUBGRPKey , A.Item_Key ItemKey , A.Style_Key StyleKey , A.Shade_Key ShadeKey , A.Doc_Dt DocDt ," _
                  & "  0 OpQty ,(Case when TRJ_FLG = 'R' THEN sum(qty) else 0 end ) InQty , (case when TRJ_FLG ='I' THEN sum(qty) else 0 end ) OutQty, ((Case when TRJ_FLG='R' THEN sum(qty) else 0 end )- (case when TRJ_FLG ='I' THEN sum(qty) else 0 end )) Clqty , A.Party_Key PartyKey , A.Stock_Key  StockKey , A.Brand_Key BrandKey , A.StyleSize_Id StyleSizeId , A.Type_Key TypeKey , StyleSize.Size_Name StyleSize , A.COBR_ID COBRID ,A.FCYR_ID FCYRID   " _
                  & " FROM View_FinishLedgerDrill as A " _
                  & " Left Join Item	on A.Item_Key = Item.Item_Key " _
                  & " Left Join ITEMSUBGRP on A.ITEMSUBGRP_Key = ITEMSUBGRP.ITEMSUBGRP_Key " _
                  & " Left Join Style on A.Style_Key = Style.Style_Key " _
                  & " Left Join Shade on A.Shade_Key = Shade.Shade_Key " _
                  & " Left Join Type on A.Type_Key = Type.Type_Key " _
                  & " Left Join Brand on A.Brand_Key = Brand.Brand_Key " _
                  & " Left Join StyleSize on A.StyleSize_Id = StyleSize.StyleSize_Id " _
                  & " GROUP BY ITEMSUBGRP.ITEMSUBGRP_NAME,ITEM.ITEM_NAME,Style.Style_Code,SHADE.SHADE_NAME, A.ITEMSUBGRP_Key,A.Item_Key,A.Style_Key,A.Shade_Key,A.Doc_Dt, A.Party_Key, A.Stock_Key,A.Brand_Key,A.StyleSize_Id , A.Type_Key,StyleSize.Size_Name, A.TRJ_FLG , A.COBR_ID,A.FCYR_ID  " _
                  & " ) B " _
                  & " WHERE B.COBRID = '" & SelBranchId & "' " & AppliedFilters & " AND B.FcyrId <='" & SelYearId & "' " _
                  & " GROUP BY Category,Product,Style,Shade, ITEMSUBGRPKey , ItemKey , StyleKey , ShadeKey , DocDt , OpQty,InQty,OutQty,Clqty,PartyKey,StockKey,BrandKey,StyleSizeId ,TypeKey , StyleSize " _
                  & " ORDER BY Product,Style,Shade "
        End If
       




        DtTable = Common.GetDataTable(Query)
        DtTable.DefaultView.AllowNew = False
        DtTable.DefaultView.AllowDelete = False
        dtgPartyAc.DataSource = DtTable
        Call DisplaySeriesHeader(DtTable)
        dtgPartyAc.ReadOnly = False
        dtGrdRef = CType(dtgPartyAc.DataSource, DataTable)
        dtgPartyAc.CurrentRowIndex = 0
        dtgPartyAc.Focus()
        If DtTable.Rows.Count > 0 Then
            dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)
            lblTotOpQty.Text = DtTable.Compute("Sum(OpQty)", "")
           
            ' dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)
            lblTotalQtyIn.Text = DtTable.Compute("Sum(InQty)", "")
            lblTotalQtyOut.Text = DtTable.Compute("Sum(OutQty)", "")
            lblTotalClQty.Text = DtTable.Compute("Sum(ClQty)", "")
        Else

        End If
        

    End Sub

    Private Sub txtSrchtext_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSrchtext.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnSearch_Click(btnSearch, Nothing)
        End If
    End Sub

    Private Sub dtgPartyAc_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgPartyAc.MouseClick
        'Try
        '    dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber - 1)
        'Catch ex As IndexOutOfRangeException
        '    Exit Sub
        'End Try
    End Sub

End Class