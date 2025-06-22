<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccReportFilters
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Sub New(ByVal rptType As ReportType)
        ' Add any initialization after the InitializeComponent() call.
        Me.rptType = rptType
        'Me.ReportCaption = Heading

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.pnlPartyOptions = New System.Windows.Forms.Panel
        Me.rdVendor = New System.Windows.Forms.RadioButton
        Me.rdAll = New System.Windows.Forms.RadioButton
        Me.rdLedger = New System.Windows.Forms.RadioButton
        Me.rdCustomer = New System.Windows.Forms.RadioButton
        Me.pnlOtherOptions = New System.Windows.Forms.Panel
        Me.chkOverdue = New DevExpress.XtraEditors.CheckEdit
        Me.chkInclOpBal = New DevExpress.XtraEditors.CheckEdit
        Me.chkShowNarration = New DevExpress.XtraEditors.CheckEdit
        Me.chkShowCostCtr = New DevExpress.XtraEditors.CheckEdit
        Me.chkShowBill = New DevExpress.XtraEditors.CheckEdit
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.dtpTo = New DateTimePick.DateTimePick
        Me.lblFrom = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.dtpFrom = New DateTimePick.DateTimePick
        Me.pnlSummaryDetail = New System.Windows.Forms.Panel
        Me.rdDetailed = New System.Windows.Forms.RadioButton
        Me.rdSummary = New System.Windows.Forms.RadioButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnView = New DevExpress.XtraEditors.SimpleButton
        Me.pnlLedger = New System.Windows.Forms.Panel
        Me.cmbFormType = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblTaxForm = New System.Windows.Forms.Label
        Me.cmbSalesPerson = New CustomCheckbox.CustomEdit
        Me.cmbBroker = New CustomCheckbox.CustomEdit
        Me.cmbLedger = New CustomCheckbox.CustomEdit
        Me.cmbSubGrp = New CustomCheckbox.CustomEdit
        Me.cmbGroup = New CustomCheckbox.CustomEdit
        Me.lblSalesPerson = New System.Windows.Forms.Label
        Me.lblBroker = New System.Windows.Forms.Label
        Me.lblParty = New System.Windows.Forms.Label
        Me.lblSubGroup = New System.Windows.Forms.Label
        Me.lblGroup = New System.Windows.Forms.Label
        Me.pnlLocation = New System.Windows.Forms.Panel
        Me.cmbState = New CustomCheckbox.CustomEdit
        Me.cmbCity = New CustomCheckbox.CustomEdit
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.grpMain.SuspendLayout()
        Me.pnlPartyOptions.SuspendLayout()
        Me.pnlOtherOptions.SuspendLayout()
        CType(Me.chkOverdue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInclOpBal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowNarration.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowCostCtr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDate.SuspendLayout()
        Me.pnlSummaryDetail.SuspendLayout()
        Me.pnlLedger.SuspendLayout()
        CType(Me.cmbFormType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBroker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLedger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSubGrp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLocation.SuspendLayout()
        CType(Me.cmbState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.pnlPartyOptions)
        Me.grpMain.Controls.Add(Me.pnlOtherOptions)
        Me.grpMain.Controls.Add(Me.pnlDate)
        Me.grpMain.Controls.Add(Me.pnlSummaryDetail)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Controls.Add(Me.btnView)
        Me.grpMain.Controls.Add(Me.pnlLedger)
        Me.grpMain.Controls.Add(Me.pnlLocation)
        Me.grpMain.Location = New System.Drawing.Point(5, -1)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(514, 343)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'pnlPartyOptions
        '
        Me.pnlPartyOptions.Controls.Add(Me.rdVendor)
        Me.pnlPartyOptions.Controls.Add(Me.rdAll)
        Me.pnlPartyOptions.Controls.Add(Me.rdLedger)
        Me.pnlPartyOptions.Controls.Add(Me.rdCustomer)
        Me.pnlPartyOptions.Location = New System.Drawing.Point(16, 53)
        Me.pnlPartyOptions.Name = "pnlPartyOptions"
        Me.pnlPartyOptions.Size = New System.Drawing.Size(298, 26)
        Me.pnlPartyOptions.TabIndex = 1
        '
        'rdVendor
        '
        Me.rdVendor.AutoSize = True
        Me.rdVendor.Location = New System.Drawing.Point(95, 3)
        Me.rdVendor.Name = "rdVendor"
        Me.rdVendor.Size = New System.Drawing.Size(63, 19)
        Me.rdVendor.TabIndex = 1
        Me.rdVendor.Text = "Vendor"
        Me.rdVendor.UseVisualStyleBackColor = True
        '
        'rdAll
        '
        Me.rdAll.AutoSize = True
        Me.rdAll.Location = New System.Drawing.Point(244, 3)
        Me.rdAll.Name = "rdAll"
        Me.rdAll.Size = New System.Drawing.Size(40, 19)
        Me.rdAll.TabIndex = 3
        Me.rdAll.Text = "All"
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'rdLedger
        '
        Me.rdLedger.AutoSize = True
        Me.rdLedger.Location = New System.Drawing.Point(171, 3)
        Me.rdLedger.Name = "rdLedger"
        Me.rdLedger.Size = New System.Drawing.Size(60, 19)
        Me.rdLedger.TabIndex = 2
        Me.rdLedger.Text = "Ledger"
        Me.rdLedger.UseVisualStyleBackColor = True
        '
        'rdCustomer
        '
        Me.rdCustomer.AutoSize = True
        Me.rdCustomer.Checked = True
        Me.rdCustomer.Location = New System.Drawing.Point(5, 3)
        Me.rdCustomer.Name = "rdCustomer"
        Me.rdCustomer.Size = New System.Drawing.Size(77, 19)
        Me.rdCustomer.TabIndex = 0
        Me.rdCustomer.TabStop = True
        Me.rdCustomer.Text = "Customer"
        Me.rdCustomer.UseVisualStyleBackColor = True
        '
        'pnlOtherOptions
        '
        Me.pnlOtherOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOtherOptions.Controls.Add(Me.chkOverdue)
        Me.pnlOtherOptions.Controls.Add(Me.chkInclOpBal)
        Me.pnlOtherOptions.Controls.Add(Me.chkShowNarration)
        Me.pnlOtherOptions.Controls.Add(Me.chkShowCostCtr)
        Me.pnlOtherOptions.Controls.Add(Me.chkShowBill)
        Me.pnlOtherOptions.Location = New System.Drawing.Point(320, 85)
        Me.pnlOtherOptions.Name = "pnlOtherOptions"
        Me.pnlOtherOptions.Size = New System.Drawing.Size(178, 216)
        Me.pnlOtherOptions.TabIndex = 5
        '
        'chkOverdue
        '
        Me.chkOverdue.Location = New System.Drawing.Point(16, 69)
        Me.chkOverdue.Name = "chkOverdue"
        Me.chkOverdue.Properties.Caption = "Show Overdue Only"
        Me.chkOverdue.Size = New System.Drawing.Size(126, 19)
        Me.chkOverdue.TabIndex = 4
        Me.chkOverdue.Visible = False
        '
        'chkInclOpBal
        '
        Me.chkInclOpBal.Location = New System.Drawing.Point(16, 124)
        Me.chkInclOpBal.Name = "chkInclOpBal"
        Me.chkInclOpBal.Properties.Caption = "Include Opening Balances"
        Me.chkInclOpBal.Size = New System.Drawing.Size(148, 19)
        Me.chkInclOpBal.TabIndex = 3
        Me.chkInclOpBal.Visible = False
        '
        'chkShowNarration
        '
        Me.chkShowNarration.Location = New System.Drawing.Point(16, 43)
        Me.chkShowNarration.Name = "chkShowNarration"
        Me.chkShowNarration.Properties.Caption = "Show Narration"
        Me.chkShowNarration.Size = New System.Drawing.Size(104, 19)
        Me.chkShowNarration.TabIndex = 1
        '
        'chkShowCostCtr
        '
        Me.chkShowCostCtr.Location = New System.Drawing.Point(16, 96)
        Me.chkShowCostCtr.Name = "chkShowCostCtr"
        Me.chkShowCostCtr.Properties.Caption = "Show Cost Center"
        Me.chkShowCostCtr.Size = New System.Drawing.Size(114, 19)
        Me.chkShowCostCtr.TabIndex = 2
        Me.chkShowCostCtr.Visible = False
        '
        'chkShowBill
        '
        Me.chkShowBill.Location = New System.Drawing.Point(16, 17)
        Me.chkShowBill.Name = "chkShowBill"
        Me.chkShowBill.Properties.Caption = "Show Bill Wise"
        Me.chkShowBill.Size = New System.Drawing.Size(143, 19)
        Me.chkShowBill.TabIndex = 0
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.lblFrom)
        Me.pnlDate.Controls.Add(Me.lblTo)
        Me.pnlDate.Controls.Add(Me.dtpFrom)
        Me.pnlDate.Enabled = False
        Me.pnlDate.Location = New System.Drawing.Point(101, 16)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(325, 31)
        Me.pnlDate.TabIndex = 0
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(212, 4)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(100, 23)
        Me.dtpTo.TabIndex = 3
        Me.dtpTo.Value = New Date(2016, 7, 21, 0, 0, 0, 0)
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(5, 8)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(35, 15)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(158, 8)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(19, 15)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(42, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(97, 23)
        Me.dtpFrom.TabIndex = 1
        Me.dtpFrom.Value = New Date(2016, 7, 21, 0, 0, 0, 0)
        '
        'pnlSummaryDetail
        '
        Me.pnlSummaryDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSummaryDetail.Controls.Add(Me.rdDetailed)
        Me.pnlSummaryDetail.Controls.Add(Me.rdSummary)
        Me.pnlSummaryDetail.Location = New System.Drawing.Point(320, 53)
        Me.pnlSummaryDetail.Name = "pnlSummaryDetail"
        Me.pnlSummaryDetail.Size = New System.Drawing.Size(178, 26)
        Me.pnlSummaryDetail.TabIndex = 2
        '
        'rdDetailed
        '
        Me.rdDetailed.AutoSize = True
        Me.rdDetailed.Location = New System.Drawing.Point(97, 3)
        Me.rdDetailed.Name = "rdDetailed"
        Me.rdDetailed.Size = New System.Drawing.Size(71, 19)
        Me.rdDetailed.TabIndex = 1
        Me.rdDetailed.Text = "Detailed"
        Me.rdDetailed.UseVisualStyleBackColor = True
        '
        'rdSummary
        '
        Me.rdSummary.AutoSize = True
        Me.rdSummary.Checked = True
        Me.rdSummary.Location = New System.Drawing.Point(5, 3)
        Me.rdSummary.Name = "rdSummary"
        Me.rdSummary.Size = New System.Drawing.Size(76, 19)
        Me.rdSummary.TabIndex = 0
        Me.rdSummary.TabStop = True
        Me.rdSummary.Text = "Summary"
        Me.rdSummary.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(273, 307)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 26)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnView.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Appearance.Options.UseFont = True
        Me.btnView.Location = New System.Drawing.Point(154, 307)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 26)
        Me.btnView.TabIndex = 6
        Me.btnView.Text = "View"
        '
        'pnlLedger
        '
        Me.pnlLedger.Controls.Add(Me.cmbFormType)
        Me.pnlLedger.Controls.Add(Me.lblTaxForm)
        Me.pnlLedger.Controls.Add(Me.cmbSalesPerson)
        Me.pnlLedger.Controls.Add(Me.cmbBroker)
        Me.pnlLedger.Controls.Add(Me.cmbLedger)
        Me.pnlLedger.Controls.Add(Me.cmbSubGrp)
        Me.pnlLedger.Controls.Add(Me.cmbGroup)
        Me.pnlLedger.Controls.Add(Me.lblSalesPerson)
        Me.pnlLedger.Controls.Add(Me.lblBroker)
        Me.pnlLedger.Controls.Add(Me.lblParty)
        Me.pnlLedger.Controls.Add(Me.lblSubGroup)
        Me.pnlLedger.Controls.Add(Me.lblGroup)
        Me.pnlLedger.Location = New System.Drawing.Point(16, 141)
        Me.pnlLedger.Name = "pnlLedger"
        Me.pnlLedger.Size = New System.Drawing.Size(298, 160)
        Me.pnlLedger.TabIndex = 4
        '
        'cmbFormType
        '
        Appearance1.FontData.Name = "Verdana"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.cmbFormType.Appearance = Appearance1
        Me.cmbFormType.AutoComplete = True
        Me.cmbFormType.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbFormType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbFormType.FlatMode = True
        Me.cmbFormType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormType.Location = New System.Drawing.Point(78, 133)
        Me.cmbFormType.Name = "cmbFormType"
        Me.cmbFormType.Size = New System.Drawing.Size(123, 20)
        Me.cmbFormType.TabIndex = 56
        Me.cmbFormType.Tag = "Form Type"
        Me.cmbFormType.Visible = False
        '
        'lblTaxForm
        '
        Me.lblTaxForm.AutoSize = True
        Me.lblTaxForm.Location = New System.Drawing.Point(5, 136)
        Me.lblTaxForm.Name = "lblTaxForm"
        Me.lblTaxForm.Size = New System.Drawing.Size(56, 15)
        Me.lblTaxForm.TabIndex = 10
        Me.lblTaxForm.Text = "Tax Form"
        Me.lblTaxForm.Visible = False
        '
        'cmbSalesPerson
        '
        Me.cmbSalesPerson.Location = New System.Drawing.Point(79, 106)
        Me.cmbSalesPerson.Name = "cmbSalesPerson"
        Me.cmbSalesPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSalesPerson.Properties.IncrementalSearch = True
        Me.cmbSalesPerson.Size = New System.Drawing.Size(209, 20)
        Me.cmbSalesPerson.TabIndex = 9
        Me.cmbSalesPerson.Tag = "Sales Person"
        Me.cmbSalesPerson.Visible = False
        '
        'cmbBroker
        '
        Me.cmbBroker.Location = New System.Drawing.Point(79, 80)
        Me.cmbBroker.Name = "cmbBroker"
        Me.cmbBroker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBroker.Properties.IncrementalSearch = True
        Me.cmbBroker.Size = New System.Drawing.Size(209, 20)
        Me.cmbBroker.TabIndex = 7
        Me.cmbBroker.Tag = "Broker"
        Me.cmbBroker.Visible = False
        '
        'cmbLedger
        '
        Me.cmbLedger.Location = New System.Drawing.Point(79, 55)
        Me.cmbLedger.Name = "cmbLedger"
        Me.cmbLedger.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLedger.Properties.IncrementalSearch = True
        Me.cmbLedger.Size = New System.Drawing.Size(209, 20)
        Me.cmbLedger.TabIndex = 5
        Me.cmbLedger.Tag = "Party"
        '
        'cmbSubGrp
        '
        Me.cmbSubGrp.Location = New System.Drawing.Point(79, 30)
        Me.cmbSubGrp.Name = "cmbSubGrp"
        Me.cmbSubGrp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSubGrp.Properties.IncrementalSearch = True
        Me.cmbSubGrp.Size = New System.Drawing.Size(209, 20)
        Me.cmbSubGrp.TabIndex = 3
        Me.cmbSubGrp.Tag = "Product"
        '
        'cmbGroup
        '
        Me.cmbGroup.Location = New System.Drawing.Point(79, 5)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGroup.Properties.IncrementalSearch = True
        Me.cmbGroup.Size = New System.Drawing.Size(209, 20)
        Me.cmbGroup.TabIndex = 1
        Me.cmbGroup.Tag = "Product"
        '
        'lblSalesPerson
        '
        Me.lblSalesPerson.AutoSize = True
        Me.lblSalesPerson.Location = New System.Drawing.Point(5, 109)
        Me.lblSalesPerson.Name = "lblSalesPerson"
        Me.lblSalesPerson.Size = New System.Drawing.Size(74, 15)
        Me.lblSalesPerson.TabIndex = 8
        Me.lblSalesPerson.Text = "SalesPerson"
        Me.lblSalesPerson.Visible = False
        '
        'lblBroker
        '
        Me.lblBroker.AutoSize = True
        Me.lblBroker.Location = New System.Drawing.Point(7, 83)
        Me.lblBroker.Name = "lblBroker"
        Me.lblBroker.Size = New System.Drawing.Size(43, 15)
        Me.lblBroker.TabIndex = 6
        Me.lblBroker.Text = "Broker"
        Me.lblBroker.Visible = False
        '
        'lblParty
        '
        Me.lblParty.AutoSize = True
        Me.lblParty.Location = New System.Drawing.Point(7, 58)
        Me.lblParty.Name = "lblParty"
        Me.lblParty.Size = New System.Drawing.Size(42, 15)
        Me.lblParty.TabIndex = 4
        Me.lblParty.Text = "Ledger"
        '
        'lblSubGroup
        '
        Me.lblSubGroup.AutoSize = True
        Me.lblSubGroup.Location = New System.Drawing.Point(7, 33)
        Me.lblSubGroup.Name = "lblSubGroup"
        Me.lblSubGroup.Size = New System.Drawing.Size(65, 15)
        Me.lblSubGroup.TabIndex = 2
        Me.lblSubGroup.Text = "Sub-Group"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(7, 8)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(41, 15)
        Me.lblGroup.TabIndex = 0
        Me.lblGroup.Text = "Group"
        '
        'pnlLocation
        '
        Me.pnlLocation.Controls.Add(Me.cmbState)
        Me.pnlLocation.Controls.Add(Me.cmbCity)
        Me.pnlLocation.Controls.Add(Me.lblCity)
        Me.pnlLocation.Controls.Add(Me.lblState)
        Me.pnlLocation.Location = New System.Drawing.Point(16, 85)
        Me.pnlLocation.Name = "pnlLocation"
        Me.pnlLocation.Size = New System.Drawing.Size(298, 57)
        Me.pnlLocation.TabIndex = 3
        '
        'cmbState
        '
        Me.cmbState.Location = New System.Drawing.Point(79, 6)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbState.Properties.IncrementalSearch = True
        Me.cmbState.Size = New System.Drawing.Size(209, 20)
        Me.cmbState.TabIndex = 1
        Me.cmbState.Tag = "State"
        '
        'cmbCity
        '
        Me.cmbCity.Location = New System.Drawing.Point(79, 31)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCity.Properties.IncrementalSearch = True
        Me.cmbCity.Size = New System.Drawing.Size(209, 20)
        Me.cmbCity.TabIndex = 3
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(7, 32)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(28, 15)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(7, 8)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(34, 15)
        Me.lblState.TabIndex = 0
        Me.lblState.Text = "State"
        '
        'frmAccReportFilters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 347)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAccReportFilters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts Reports"
        Me.grpMain.ResumeLayout(False)
        Me.pnlPartyOptions.ResumeLayout(False)
        Me.pnlPartyOptions.PerformLayout()
        Me.pnlOtherOptions.ResumeLayout(False)
        CType(Me.chkOverdue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInclOpBal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowNarration.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowCostCtr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.pnlSummaryDetail.ResumeLayout(False)
        Me.pnlSummaryDetail.PerformLayout()
        Me.pnlLedger.ResumeLayout(False)
        Me.pnlLedger.PerformLayout()
        CType(Me.cmbFormType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBroker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLedger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSubGrp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLocation.ResumeLayout(False)
        Me.pnlLocation.PerformLayout()
        CType(Me.cmbState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents pnlLocation As System.Windows.Forms.Panel
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblParty As System.Windows.Forms.Label
    Friend WithEvents pnlLedger As System.Windows.Forms.Panel
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
    Friend WithEvents rdSummary As System.Windows.Forms.RadioButton
    Friend WithEvents rdDetailed As System.Windows.Forms.RadioButton
    Friend WithEvents lblSubGroup As System.Windows.Forms.Label
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents pnlSummaryDetail As System.Windows.Forms.Panel
    Friend WithEvents pnlOtherOptions As System.Windows.Forms.Panel
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents pnlPartyOptions As System.Windows.Forms.Panel
    Friend WithEvents rdVendor As System.Windows.Forms.RadioButton
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdLedger As System.Windows.Forms.RadioButton
    Friend WithEvents rdCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents chkInclOpBal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkShowNarration As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkShowCostCtr As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkShowBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkOverdue As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblSalesPerson As System.Windows.Forms.Label
    Friend WithEvents lblBroker As System.Windows.Forms.Label
    Friend WithEvents cmbCity As CustomCheckbox.CustomEdit
    Friend WithEvents cmbState As CustomCheckbox.CustomEdit
    Friend WithEvents cmbSubGrp As CustomCheckbox.CustomEdit
    Friend WithEvents cmbGroup As CustomCheckbox.CustomEdit
    Friend WithEvents cmbBroker As CustomCheckbox.CustomEdit
    Friend WithEvents cmbLedger As CustomCheckbox.CustomEdit
    Friend WithEvents cmbSalesPerson As CustomCheckbox.CustomEdit
    Friend WithEvents lblTaxForm As System.Windows.Forms.Label
    Friend WithEvents cmbFormType As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
