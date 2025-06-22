<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportFilters
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

    Sub New(ByVal rptTrans As TransactionType, ByVal rptType As ReportType, ByVal DisplayDetailSummary As DetailSummary, ByVal Heading As String, Optional ByVal WithOption As Boolean = True, Optional ByVal OptType As OptionType = OptionType.DefaultWise)
        ' Add any initialization after the InitializeComponent() call.
        Me.TransType = rptTrans
        Me.DispDetailSummary = DisplayDetailSummary
        Me.rptType = rptType
        Me.ReportCaption = Heading
        Me.DisplayOption = WithOption
        Me.CurrOptionType = OptType
        StkType = Heading
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.btnGstR1New = New DevExpress.XtraEditors.SimpleButton
        Me.BtnStockExportToExcel = New DevExpress.XtraEditors.SimpleButton
        Me.chkDesignAsperStock = New System.Windows.Forms.CheckBox
        Me.pnlOtherOptions = New System.Windows.Forms.Panel
        Me.rdOthOption1 = New System.Windows.Forms.RadioButton
        Me.rdOthOption3 = New System.Windows.Forms.RadioButton
        Me.rdOthOption2 = New System.Windows.Forms.RadioButton
        Me.chkSize = New System.Windows.Forms.CheckBox
        Me.lblSalesType = New System.Windows.Forms.Label
        Me.cmbSalesType = New CustomCheckbox.CustomEdit
        Me.pnlDate2 = New System.Windows.Forms.Panel
        Me.dtpTo2 = New DateTimePick.DateTimePick
        Me.lblFrom2 = New System.Windows.Forms.Label
        Me.lblTo2 = New System.Windows.Forms.Label
        Me.dtpFrom2 = New DateTimePick.DateTimePick
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbJOrderNo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.chkStatewise = New System.Windows.Forms.CheckBox
        Me.chkStorewise = New System.Windows.Forms.CheckBox
        Me.cmbStore = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbStateGSTR = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnlJobCard = New System.Windows.Forms.Panel
        Me.txtJobCardTo = New System.Windows.Forms.TextBox
        Me.txtJobCardFrom = New System.Windows.Forms.TextBox
        Me.lblJFrom = New System.Windows.Forms.Label
        Me.lblJTo = New System.Windows.Forms.Label
        Me.cmbPurType = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblPurchaseType = New System.Windows.Forms.Label
        Me.btnGSTR3BExcel = New DevExpress.XtraEditors.SimpleButton
        Me.btnGSTR1Excel = New DevExpress.XtraEditors.SimpleButton
        Me.cmbSONo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblSaleOrder = New System.Windows.Forms.Label
        Me.lblJobOrder = New System.Windows.Forms.Label
        Me.cmbOrderNo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.pnlHoney = New System.Windows.Forms.Panel
        Me.cmbProcessHoney = New CustomCheckbox.CustomEdit
        Me.lblProcess = New System.Windows.Forms.Label
        Me.cmbPartyHoney = New CustomCheckbox.CustomEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbrate = New CustomCheckbox.CustomEdit
        Me.pnlDate1 = New System.Windows.Forms.Panel
        Me.dtpTo1 = New DateTimePick.DateTimePick
        Me.lbldate1 = New System.Windows.Forms.Label
        Me.lblTo1 = New System.Windows.Forms.Label
        Me.dtpFrom1 = New DateTimePick.DateTimePick
        Me.cmbLocation = New CustomCheckbox.CustomEdit
        Me.cmbTax = New CustomCheckbox.CustomEdit
        Me.cmbOperator = New CustomCheckbox.CustomEdit
        Me.chkChart = New System.Windows.Forms.CheckBox
        Me.chkData = New System.Windows.Forms.CheckBox
        Me.lblTax = New System.Windows.Forms.Label
        Me.lblOperator = New System.Windows.Forms.Label
        Me.lblLocation = New System.Windows.Forms.Label
        Me.txtText = New System.Windows.Forms.TextBox
        Me.lblText = New System.Windows.Forms.Label
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.dtpTo = New DateTimePick.DateTimePick
        Me.lblFrom = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.dtpFrom = New DateTimePick.DateTimePick
        Me.pnlStock = New System.Windows.Forms.Panel
        Me.pnlAgingParam = New System.Windows.Forms.Panel
        Me.rdAgeQty = New System.Windows.Forms.RadioButton
        Me.rdAgeValue = New System.Windows.Forms.RadioButton
        Me.pnlRateType = New System.Windows.Forms.GroupBox
        Me.rdPurRate = New System.Windows.Forms.RadioButton
        Me.rdMRP = New System.Windows.Forms.RadioButton
        Me.rdSP = New System.Windows.Forms.RadioButton
        Me.chkDispValue = New System.Windows.Forms.CheckBox
        Me.txtStkTo = New NumericTextBox.NumericTextBox
        Me.txtStkFrom = New NumericTextBox.NumericTextBox
        Me.lblAgingOn = New System.Windows.Forms.Label
        Me.lblQty = New System.Windows.Forms.Label
        Me.chkDispRate = New System.Windows.Forms.CheckBox
        Me.cmbDisplay = New DevExpress.XtraEditors.ComboBoxEdit
        Me.pnlSummaryDetail = New System.Windows.Forms.Panel
        Me.rdDetailed = New System.Windows.Forms.RadioButton
        Me.rdSummary = New System.Windows.Forms.RadioButton
        Me.pnlSeries = New System.Windows.Forms.Panel
        Me.rdA = New System.Windows.Forms.RadioButton
        Me.rdAll = New System.Windows.Forms.RadioButton
        Me.rdB = New System.Windows.Forms.RadioButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnOption = New DevExpress.XtraEditors.SimpleButton
        Me.btnView = New DevExpress.XtraEditors.SimpleButton
        Me.pnlProduct = New System.Windows.Forms.Panel
        Me.cmbOccassion = New CustomCheckbox.CustomEdit
        Me.cmbSeason = New CustomCheckbox.CustomEdit
        Me.cmbQuality = New CustomCheckbox.CustomEdit
        Me.cmbBrand = New CustomCheckbox.CustomEdit
        Me.cmbSize = New CustomCheckbox.CustomEdit
        Me.cmbShade = New CustomCheckbox.CustomEdit
        Me.cmbType = New CustomCheckbox.CustomEdit
        Me.cmbStyle = New CustomCheckbox.CustomEdit
        Me.cmbProduct = New CustomCheckbox.CustomEdit
        Me.cmbProductSubGrp = New CustomCheckbox.CustomEdit
        Me.cmbProductGrp = New CustomCheckbox.CustomEdit
        Me.lblSize = New System.Windows.Forms.Label
        Me.lblOccassion = New System.Windows.Forms.Label
        Me.lblShade = New System.Windows.Forms.Label
        Me.lblSeason = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.lblQuality = New System.Windows.Forms.Label
        Me.lblSubGroup = New System.Windows.Forms.Label
        Me.lblDesign = New System.Windows.Forms.Label
        Me.lblBrand = New System.Windows.Forms.Label
        Me.lblGroup = New System.Windows.Forms.Label
        Me.lblProduct = New System.Windows.Forms.Label
        Me.pnlParty = New System.Windows.Forms.Panel
        Me.cmbRegion = New CustomCheckbox.CustomEdit
        Me.lblRegion = New System.Windows.Forms.Label
        Me.lblCountry = New System.Windows.Forms.Label
        Me.cmbCountry = New CustomCheckbox.CustomEdit
        Me.cmbParty = New CustomCheckbox.CustomEdit
        Me.cmbStation = New CustomCheckbox.CustomEdit
        Me.cmbCity = New CustomCheckbox.CustomEdit
        Me.cmbDistrict = New CustomCheckbox.CustomEdit
        Me.cmbState = New CustomCheckbox.CustomEdit
        Me.lblParty = New System.Windows.Forms.Label
        Me.lblStation = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.lblDistrict = New System.Windows.Forms.Label
        Me.pnlSection = New System.Windows.Forms.Panel
        Me.lblSection = New System.Windows.Forms.Label
        Me.cmbSelection = New System.Windows.Forms.ComboBox
        Me.pnlOptions = New System.Windows.Forms.Panel
        Me.pnlSelectOption = New System.Windows.Forms.Panel
        Me.lstDetails = New System.Windows.Forms.ListBox
        Me.lstOption1 = New System.Windows.Forms.ListBox
        Me.btnGrp1 = New DevExpress.XtraEditors.SimpleButton
        Me.lstOption3 = New System.Windows.Forms.ListBox
        Me.btnGrp2 = New DevExpress.XtraEditors.SimpleButton
        Me.lstOption2 = New System.Windows.Forms.ListBox
        Me.btnGrp3 = New DevExpress.XtraEditors.SimpleButton
        Me.btnDetail = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelDetail = New DevExpress.XtraEditors.SimpleButton
        Me.btnDown = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelGrp1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnUp = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelGrp2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelGrp3 = New DevExpress.XtraEditors.SimpleButton
        Me.lstMain = New System.Windows.Forms.ListBox
        Me.btnCloseOption = New DevExpress.XtraEditors.SimpleButton
        Me.Label21 = New System.Windows.Forms.Label
        Me.Plnitemdetils = New System.Windows.Forms.GroupBox
        Me.rddamnaged = New System.Windows.Forms.RadioButton
        Me.rdfinished = New System.Windows.Forms.RadioButton
        Me.cmbPartyFrom = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbBranchFrom = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txtPartyAddrFrom = New System.Windows.Forms.TextBox
        Me.cmbPartyTo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbBranchTo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txtPartyAddrTo = New System.Windows.Forms.TextBox
        Me.UltraComboEditor1 = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbMRNType = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblDeptment = New System.Windows.Forms.Label
        Me.cmbFromDept = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.grpmrn = New DevExpress.XtraEditors.GroupControl
        Me.cmbCreationNo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbOCNO = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbMIN = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblMIN = New System.Windows.Forms.Label
        Me.cmbMRN = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.LBLPP = New System.Windows.Forms.Label
        Me.grpMain.SuspendLayout()
        Me.pnlOtherOptions.SuspendLayout()
        CType(Me.cmbSalesType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDate2.SuspendLayout()
        CType(Me.cmbJOrderNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStateGSTR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlJobCard.SuspendLayout()
        CType(Me.cmbPurType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSONo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrderNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHoney.SuspendLayout()
        CType(Me.cmbProcessHoney.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPartyHoney.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDate1.SuspendLayout()
        CType(Me.cmbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOperator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDate.SuspendLayout()
        Me.pnlStock.SuspendLayout()
        Me.pnlAgingParam.SuspendLayout()
        Me.pnlRateType.SuspendLayout()
        CType(Me.cmbDisplay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSummaryDetail.SuspendLayout()
        Me.pnlSeries.SuspendLayout()
        Me.pnlProduct.SuspendLayout()
        CType(Me.cmbOccassion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSeason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbQuality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbShade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductSubGrp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductGrp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParty.SuspendLayout()
        CType(Me.cmbRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbParty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDistrict.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSection.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        Me.pnlSelectOption.SuspendLayout()
        Me.Plnitemdetils.SuspendLayout()
        CType(Me.cmbPartyFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBranchFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPartyTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBranchTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMRNType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFromDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpmrn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpmrn.SuspendLayout()
        CType(Me.cmbCreationNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOCNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMRN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.LBLPP)
        Me.grpMain.Controls.Add(Me.btnGstR1New)
        Me.grpMain.Controls.Add(Me.BtnStockExportToExcel)
        Me.grpMain.Controls.Add(Me.chkDesignAsperStock)
        Me.grpMain.Controls.Add(Me.pnlOtherOptions)
        Me.grpMain.Controls.Add(Me.chkSize)
        Me.grpMain.Controls.Add(Me.lblSalesType)
        Me.grpMain.Controls.Add(Me.cmbSalesType)
        Me.grpMain.Controls.Add(Me.pnlDate2)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.cmbJOrderNo)
        Me.grpMain.Controls.Add(Me.chkStatewise)
        Me.grpMain.Controls.Add(Me.chkStorewise)
        Me.grpMain.Controls.Add(Me.cmbStore)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.cmbStateGSTR)
        Me.grpMain.Controls.Add(Me.Label4)
        Me.grpMain.Controls.Add(Me.pnlJobCard)
        Me.grpMain.Controls.Add(Me.cmbPurType)
        Me.grpMain.Controls.Add(Me.lblPurchaseType)
        Me.grpMain.Controls.Add(Me.btnGSTR3BExcel)
        Me.grpMain.Controls.Add(Me.btnGSTR1Excel)
        Me.grpMain.Controls.Add(Me.cmbSONo)
        Me.grpMain.Controls.Add(Me.lblSaleOrder)
        Me.grpMain.Controls.Add(Me.lblJobOrder)
        Me.grpMain.Controls.Add(Me.cmbOrderNo)
        Me.grpMain.Controls.Add(Me.pnlHoney)
        Me.grpMain.Controls.Add(Me.cmbrate)
        Me.grpMain.Controls.Add(Me.pnlDate1)
        Me.grpMain.Controls.Add(Me.cmbLocation)
        Me.grpMain.Controls.Add(Me.cmbTax)
        Me.grpMain.Controls.Add(Me.cmbOperator)
        Me.grpMain.Controls.Add(Me.chkChart)
        Me.grpMain.Controls.Add(Me.chkData)
        Me.grpMain.Controls.Add(Me.lblTax)
        Me.grpMain.Controls.Add(Me.lblOperator)
        Me.grpMain.Controls.Add(Me.lblLocation)
        Me.grpMain.Controls.Add(Me.txtText)
        Me.grpMain.Controls.Add(Me.lblText)
        Me.grpMain.Controls.Add(Me.pnlDate)
        Me.grpMain.Controls.Add(Me.pnlStock)
        Me.grpMain.Controls.Add(Me.pnlSummaryDetail)
        Me.grpMain.Controls.Add(Me.pnlSeries)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Controls.Add(Me.btnOption)
        Me.grpMain.Controls.Add(Me.btnView)
        Me.grpMain.Controls.Add(Me.pnlProduct)
        Me.grpMain.Controls.Add(Me.pnlParty)
        Me.grpMain.Controls.Add(Me.pnlSection)
        Me.grpMain.Location = New System.Drawing.Point(5, -1)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(772, 563)
        Me.grpMain.TabIndex = 1
        Me.grpMain.TabStop = False
        '
        'btnGstR1New
        '
        Me.btnGstR1New.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGstR1New.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGstR1New.Appearance.Options.UseFont = True
        Me.btnGstR1New.Location = New System.Drawing.Point(502, 531)
        Me.btnGstR1New.Name = "btnGstR1New"
        Me.btnGstR1New.Size = New System.Drawing.Size(69, 26)
        Me.btnGstR1New.TabIndex = 53
        Me.btnGstR1New.Text = "GSTR1 New"
        Me.btnGstR1New.Visible = False
        '
        'BtnStockExportToExcel
        '
        Me.BtnStockExportToExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnStockExportToExcel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStockExportToExcel.Appearance.Options.UseFont = True
        Me.BtnStockExportToExcel.Location = New System.Drawing.Point(524, 416)
        Me.BtnStockExportToExcel.Name = "BtnStockExportToExcel"
        Me.BtnStockExportToExcel.Size = New System.Drawing.Size(134, 26)
        Me.BtnStockExportToExcel.TabIndex = 52
        Me.BtnStockExportToExcel.Text = "Stock Export To Excel"
        Me.BtnStockExportToExcel.Visible = False
        '
        'chkDesignAsperStock
        '
        Me.chkDesignAsperStock.AutoSize = True
        Me.chkDesignAsperStock.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDesignAsperStock.Location = New System.Drawing.Point(529, 255)
        Me.chkDesignAsperStock.Name = "chkDesignAsperStock"
        Me.chkDesignAsperStock.Size = New System.Drawing.Size(132, 19)
        Me.chkDesignAsperStock.TabIndex = 51
        Me.chkDesignAsperStock.Text = "Design As per Stock"
        Me.chkDesignAsperStock.UseVisualStyleBackColor = True
        Me.chkDesignAsperStock.Visible = False
        '
        'pnlOtherOptions
        '
        Me.pnlOtherOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOtherOptions.Controls.Add(Me.rdOthOption1)
        Me.pnlOtherOptions.Controls.Add(Me.rdOthOption3)
        Me.pnlOtherOptions.Controls.Add(Me.rdOthOption2)
        Me.pnlOtherOptions.Location = New System.Drawing.Point(291, 381)
        Me.pnlOtherOptions.Name = "pnlOtherOptions"
        Me.pnlOtherOptions.Size = New System.Drawing.Size(367, 26)
        Me.pnlOtherOptions.TabIndex = 12
        Me.pnlOtherOptions.Visible = False
        '
        'rdOthOption1
        '
        Me.rdOthOption1.AutoSize = True
        Me.rdOthOption1.Checked = True
        Me.rdOthOption1.Location = New System.Drawing.Point(5, 2)
        Me.rdOthOption1.Name = "rdOthOption1"
        Me.rdOthOption1.Size = New System.Drawing.Size(71, 19)
        Me.rdOthOption1.TabIndex = 0
        Me.rdOthOption1.TabStop = True
        Me.rdOthOption1.Tag = ""
        Me.rdOthOption1.Text = "With PO"
        Me.rdOthOption1.UseVisualStyleBackColor = True
        '
        'rdOthOption3
        '
        Me.rdOthOption3.AutoSize = True
        Me.rdOthOption3.Location = New System.Drawing.Point(281, 2)
        Me.rdOthOption3.Name = "rdOthOption3"
        Me.rdOthOption3.Size = New System.Drawing.Size(40, 19)
        Me.rdOthOption3.TabIndex = 2
        Me.rdOthOption3.Text = "All"
        Me.rdOthOption3.UseVisualStyleBackColor = True
        '
        'rdOthOption2
        '
        Me.rdOthOption2.AutoSize = True
        Me.rdOthOption2.Location = New System.Drawing.Point(150, 2)
        Me.rdOthOption2.Name = "rdOthOption2"
        Me.rdOthOption2.Size = New System.Drawing.Size(89, 19)
        Me.rdOthOption2.TabIndex = 1
        Me.rdOthOption2.Tag = ""
        Me.rdOthOption2.Text = "Without PO"
        Me.rdOthOption2.UseVisualStyleBackColor = True
        '
        'chkSize
        '
        Me.chkSize.AutoSize = True
        Me.chkSize.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSize.Location = New System.Drawing.Point(19, 370)
        Me.chkSize.Name = "chkSize"
        Me.chkSize.Size = New System.Drawing.Size(76, 19)
        Me.chkSize.TabIndex = 10
        Me.chkSize.Text = "View Size"
        Me.chkSize.UseVisualStyleBackColor = True
        '
        'lblSalesType
        '
        Me.lblSalesType.AutoSize = True
        Me.lblSalesType.Location = New System.Drawing.Point(394, 167)
        Me.lblSalesType.Name = "lblSalesType"
        Me.lblSalesType.Size = New System.Drawing.Size(60, 15)
        Me.lblSalesType.TabIndex = 50
        Me.lblSalesType.Text = "SalesType"
        Me.lblSalesType.Visible = False
        '
        'cmbSalesType
        '
        Me.cmbSalesType.EditValue = ""
        Me.cmbSalesType.Location = New System.Drawing.Point(456, 165)
        Me.cmbSalesType.Name = "cmbSalesType"
        Me.cmbSalesType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSalesType.Properties.IncrementalSearch = True
        Me.cmbSalesType.Size = New System.Drawing.Size(209, 20)
        Me.cmbSalesType.TabIndex = 49
        Me.cmbSalesType.Tag = "Party"
        Me.cmbSalesType.Visible = False
        '
        'pnlDate2
        '
        Me.pnlDate2.Controls.Add(Me.dtpTo2)
        Me.pnlDate2.Controls.Add(Me.lblFrom2)
        Me.pnlDate2.Controls.Add(Me.lblTo2)
        Me.pnlDate2.Controls.Add(Me.dtpFrom2)
        Me.pnlDate2.Enabled = False
        Me.pnlDate2.Location = New System.Drawing.Point(254, 424)
        Me.pnlDate2.Name = "pnlDate2"
        Me.pnlDate2.Size = New System.Drawing.Size(265, 31)
        Me.pnlDate2.TabIndex = 48
        Me.pnlDate2.Visible = False
        '
        'dtpTo2
        '
        Me.dtpTo2.Location = New System.Drawing.Point(166, 4)
        Me.dtpTo2.Name = "dtpTo2"
        Me.dtpTo2.Size = New System.Drawing.Size(89, 20)
        Me.dtpTo2.TabIndex = 2
        Me.dtpTo2.Value = New Date(2024, 5, 21, 0, 0, 0, 0)
        '
        'lblFrom2
        '
        Me.lblFrom2.AutoSize = True
        Me.lblFrom2.Location = New System.Drawing.Point(5, 7)
        Me.lblFrom2.Name = "lblFrom2"
        Me.lblFrom2.Size = New System.Drawing.Size(35, 15)
        Me.lblFrom2.TabIndex = 0
        Me.lblFrom2.Text = "From"
        '
        'lblTo2
        '
        Me.lblTo2.AutoSize = True
        Me.lblTo2.Location = New System.Drawing.Point(138, 7)
        Me.lblTo2.Name = "lblTo2"
        Me.lblTo2.Size = New System.Drawing.Size(19, 15)
        Me.lblTo2.TabIndex = 2
        Me.lblTo2.Text = "To"
        Me.lblTo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFrom2
        '
        Me.dtpFrom2.Location = New System.Drawing.Point(42, 5)
        Me.dtpFrom2.Name = "dtpFrom2"
        Me.dtpFrom2.Size = New System.Drawing.Size(89, 19)
        Me.dtpFrom2.TabIndex = 1
        Me.dtpFrom2.Value = New Date(2024, 5, 21, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Job Order No"
        Me.Label5.Visible = False
        '
        'cmbJOrderNo
        '
        Appearance1.FontData.Name = "Verdana"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.cmbJOrderNo.Appearance = Appearance1
        Me.cmbJOrderNo.AutoComplete = True
        Me.cmbJOrderNo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbJOrderNo.FlatMode = True
        Me.cmbJOrderNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJOrderNo.Location = New System.Drawing.Point(398, 385)
        Me.cmbJOrderNo.Name = "cmbJOrderNo"
        Me.cmbJOrderNo.Size = New System.Drawing.Size(199, 20)
        Me.cmbJOrderNo.TabIndex = 46
        Me.cmbJOrderNo.Tag = "Supplier"
        Me.cmbJOrderNo.Visible = False
        '
        'chkStatewise
        '
        Me.chkStatewise.AutoSize = True
        Me.chkStatewise.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStatewise.Location = New System.Drawing.Point(562, 449)
        Me.chkStatewise.Name = "chkStatewise"
        Me.chkStatewise.Size = New System.Drawing.Size(81, 19)
        Me.chkStatewise.TabIndex = 45
        Me.chkStatewise.Text = "StateWise"
        Me.chkStatewise.UseVisualStyleBackColor = True
        Me.chkStatewise.Visible = False
        '
        'chkStorewise
        '
        Me.chkStorewise.AutoSize = True
        Me.chkStorewise.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStorewise.Location = New System.Drawing.Point(672, 447)
        Me.chkStorewise.Name = "chkStorewise"
        Me.chkStorewise.Size = New System.Drawing.Size(82, 19)
        Me.chkStorewise.TabIndex = 44
        Me.chkStorewise.Text = "StoreWise"
        Me.chkStorewise.UseVisualStyleBackColor = True
        Me.chkStorewise.Visible = False
        '
        'cmbStore
        '
        Me.cmbStore.EnterMoveNextControl = True
        Me.cmbStore.Location = New System.Drawing.Point(600, 496)
        Me.cmbStore.Name = "cmbStore"
        Me.cmbStore.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStore.Properties.Appearance.Options.UseFont = True
        Me.cmbStore.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStore.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbStore.Size = New System.Drawing.Size(165, 21)
        Me.cmbStore.TabIndex = 41
        Me.cmbStore.Tag = "Product Group"
        Me.cmbStore.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(559, 502)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Store"
        Me.Label3.Visible = False
        '
        'cmbStateGSTR
        '
        Me.cmbStateGSTR.EnterMoveNextControl = True
        Me.cmbStateGSTR.Location = New System.Drawing.Point(599, 470)
        Me.cmbStateGSTR.Name = "cmbStateGSTR"
        Me.cmbStateGSTR.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStateGSTR.Properties.Appearance.Options.UseFont = True
        Me.cmbStateGSTR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStateGSTR.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbStateGSTR.Size = New System.Drawing.Size(167, 21)
        Me.cmbStateGSTR.TabIndex = 43
        Me.cmbStateGSTR.Tag = "Product Group"
        Me.cmbStateGSTR.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(559, 474)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "State"
        Me.Label4.Visible = False
        '
        'pnlJobCard
        '
        Me.pnlJobCard.Controls.Add(Me.txtJobCardTo)
        Me.pnlJobCard.Controls.Add(Me.txtJobCardFrom)
        Me.pnlJobCard.Controls.Add(Me.lblJFrom)
        Me.pnlJobCard.Controls.Add(Me.lblJTo)
        Me.pnlJobCard.Location = New System.Drawing.Point(90, 449)
        Me.pnlJobCard.Name = "pnlJobCard"
        Me.pnlJobCard.Size = New System.Drawing.Size(339, 26)
        Me.pnlJobCard.TabIndex = 39
        Me.pnlJobCard.Visible = False
        '
        'txtJobCardTo
        '
        Me.txtJobCardTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobCardTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJobCardTo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobCardTo.Location = New System.Drawing.Point(215, 2)
        Me.txtJobCardTo.MaxLength = 0
        Me.txtJobCardTo.Name = "txtJobCardTo"
        Me.txtJobCardTo.Size = New System.Drawing.Size(75, 22)
        Me.txtJobCardTo.TabIndex = 17
        Me.txtJobCardTo.Tag = ""
        '
        'txtJobCardFrom
        '
        Me.txtJobCardFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobCardFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJobCardFrom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobCardFrom.Location = New System.Drawing.Point(112, 2)
        Me.txtJobCardFrom.MaxLength = 0
        Me.txtJobCardFrom.Name = "txtJobCardFrom"
        Me.txtJobCardFrom.Size = New System.Drawing.Size(75, 22)
        Me.txtJobCardFrom.TabIndex = 16
        Me.txtJobCardFrom.Tag = ""
        '
        'lblJFrom
        '
        Me.lblJFrom.Location = New System.Drawing.Point(4, 4)
        Me.lblJFrom.Name = "lblJFrom"
        Me.lblJFrom.Size = New System.Drawing.Size(103, 18)
        Me.lblJFrom.TabIndex = 10
        Me.lblJFrom.Text = "JobCard No. From"
        '
        'lblJTo
        '
        Me.lblJTo.Location = New System.Drawing.Point(193, 5)
        Me.lblJTo.Name = "lblJTo"
        Me.lblJTo.Size = New System.Drawing.Size(20, 18)
        Me.lblJTo.TabIndex = 9
        Me.lblJTo.Text = "To"
        '
        'cmbPurType
        '
        Appearance2.FontData.Name = "Verdana"
        Appearance2.FontData.SizeInPoints = 8.0!
        Me.cmbPurType.Appearance = Appearance2
        Me.cmbPurType.AutoComplete = True
        Me.cmbPurType.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbPurType.FlatMode = True
        Me.cmbPurType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurType.Location = New System.Drawing.Point(105, 398)
        Me.cmbPurType.Name = "cmbPurType"
        Me.cmbPurType.Size = New System.Drawing.Size(199, 20)
        Me.cmbPurType.TabIndex = 38
        Me.cmbPurType.Tag = "Supplier"
        Me.cmbPurType.Visible = False
        '
        'lblPurchaseType
        '
        Me.lblPurchaseType.AutoSize = True
        Me.lblPurchaseType.Location = New System.Drawing.Point(12, 401)
        Me.lblPurchaseType.Name = "lblPurchaseType"
        Me.lblPurchaseType.Size = New System.Drawing.Size(85, 15)
        Me.lblPurchaseType.TabIndex = 37
        Me.lblPurchaseType.Text = "Purchase Type"
        Me.lblPurchaseType.Visible = False
        '
        'btnGSTR3BExcel
        '
        Me.btnGSTR3BExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGSTR3BExcel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGSTR3BExcel.Appearance.Options.UseFont = True
        Me.btnGSTR3BExcel.Location = New System.Drawing.Point(672, 530)
        Me.btnGSTR3BExcel.Name = "btnGSTR3BExcel"
        Me.btnGSTR3BExcel.Size = New System.Drawing.Size(87, 26)
        Me.btnGSTR3BExcel.TabIndex = 36
        Me.btnGSTR3BExcel.Text = "GSTR-3B Excel"
        Me.btnGSTR3BExcel.Visible = False
        '
        'btnGSTR1Excel
        '
        Me.btnGSTR1Excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGSTR1Excel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGSTR1Excel.Appearance.Options.UseFont = True
        Me.btnGSTR1Excel.Location = New System.Drawing.Point(578, 530)
        Me.btnGSTR1Excel.Name = "btnGSTR1Excel"
        Me.btnGSTR1Excel.Size = New System.Drawing.Size(87, 26)
        Me.btnGSTR1Excel.TabIndex = 35
        Me.btnGSTR1Excel.Text = "GSTR1 Excel"
        Me.btnGSTR1Excel.Visible = False
        '
        'cmbSONo
        '
        Appearance3.FontData.Name = "Verdana"
        Appearance3.FontData.SizeInPoints = 8.0!
        Me.cmbSONo.Appearance = Appearance3
        Me.cmbSONo.AutoComplete = True
        Me.cmbSONo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbSONo.FlatMode = True
        Me.cmbSONo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSONo.Location = New System.Drawing.Point(188, 399)
        Me.cmbSONo.Name = "cmbSONo"
        Me.cmbSONo.Size = New System.Drawing.Size(199, 20)
        Me.cmbSONo.TabIndex = 34
        Me.cmbSONo.Tag = "Supplier"
        Me.cmbSONo.Visible = False
        '
        'lblSaleOrder
        '
        Me.lblSaleOrder.AutoSize = True
        Me.lblSaleOrder.Location = New System.Drawing.Point(95, 402)
        Me.lblSaleOrder.Name = "lblSaleOrder"
        Me.lblSaleOrder.Size = New System.Drawing.Size(83, 15)
        Me.lblSaleOrder.TabIndex = 33
        Me.lblSaleOrder.Text = "Sale Order No"
        Me.lblSaleOrder.Visible = False
        '
        'lblJobOrder
        '
        Me.lblJobOrder.AutoSize = True
        Me.lblJobOrder.Location = New System.Drawing.Point(384, 62)
        Me.lblJobOrder.Name = "lblJobOrder"
        Me.lblJobOrder.Size = New System.Drawing.Size(78, 15)
        Me.lblJobOrder.TabIndex = 32
        Me.lblJobOrder.Text = "Job Order No"
        Me.lblJobOrder.Visible = False
        '
        'cmbOrderNo
        '
        Appearance4.FontData.Name = "Verdana"
        Appearance4.FontData.SizeInPoints = 8.0!
        Me.cmbOrderNo.Appearance = Appearance4
        Me.cmbOrderNo.AutoComplete = True
        Me.cmbOrderNo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbOrderNo.FlatMode = True
        Me.cmbOrderNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderNo.Location = New System.Drawing.Point(469, 59)
        Me.cmbOrderNo.Name = "cmbOrderNo"
        Me.cmbOrderNo.Size = New System.Drawing.Size(199, 20)
        Me.cmbOrderNo.TabIndex = 31
        Me.cmbOrderNo.Tag = "Supplier"
        Me.cmbOrderNo.Visible = False
        '
        'pnlHoney
        '
        Me.pnlHoney.Controls.Add(Me.cmbProcessHoney)
        Me.pnlHoney.Controls.Add(Me.lblProcess)
        Me.pnlHoney.Controls.Add(Me.cmbPartyHoney)
        Me.pnlHoney.Controls.Add(Me.Label1)
        Me.pnlHoney.Enabled = False
        Me.pnlHoney.Location = New System.Drawing.Point(393, 78)
        Me.pnlHoney.Name = "pnlHoney"
        Me.pnlHoney.Size = New System.Drawing.Size(271, 63)
        Me.pnlHoney.TabIndex = 30
        Me.pnlHoney.Visible = False
        '
        'cmbProcessHoney
        '
        Me.cmbProcessHoney.EditValue = ""
        Me.cmbProcessHoney.Location = New System.Drawing.Point(56, 6)
        Me.cmbProcessHoney.Name = "cmbProcessHoney"
        Me.cmbProcessHoney.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProcessHoney.Properties.IncrementalSearch = True
        Me.cmbProcessHoney.Size = New System.Drawing.Size(209, 20)
        Me.cmbProcessHoney.TabIndex = 11
        Me.cmbProcessHoney.Tag = "Party"
        '
        'lblProcess
        '
        Me.lblProcess.AutoSize = True
        Me.lblProcess.Location = New System.Drawing.Point(4, 8)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(50, 15)
        Me.lblProcess.TabIndex = 10
        Me.lblProcess.Text = "Process"
        '
        'cmbPartyHoney
        '
        Me.cmbPartyHoney.EditValue = ""
        Me.cmbPartyHoney.Location = New System.Drawing.Point(56, 33)
        Me.cmbPartyHoney.Name = "cmbPartyHoney"
        Me.cmbPartyHoney.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPartyHoney.Properties.IncrementalSearch = True
        Me.cmbPartyHoney.Size = New System.Drawing.Size(209, 20)
        Me.cmbPartyHoney.TabIndex = 9
        Me.cmbPartyHoney.Tag = "Party"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Party"
        '
        'cmbrate
        '
        Me.cmbrate.EditValue = ""
        Me.cmbrate.Location = New System.Drawing.Point(451, 415)
        Me.cmbrate.Name = "cmbrate"
        Me.cmbrate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbrate.Properties.IncrementalSearch = True
        Me.cmbrate.Size = New System.Drawing.Size(69, 20)
        Me.cmbrate.TabIndex = 2
        Me.cmbrate.Tag = "Product Group"
        Me.cmbrate.Visible = False
        '
        'pnlDate1
        '
        Me.pnlDate1.Controls.Add(Me.dtpTo1)
        Me.pnlDate1.Controls.Add(Me.lbldate1)
        Me.pnlDate1.Controls.Add(Me.lblTo1)
        Me.pnlDate1.Controls.Add(Me.dtpFrom1)
        Me.pnlDate1.Enabled = False
        Me.pnlDate1.Location = New System.Drawing.Point(490, 17)
        Me.pnlDate1.Name = "pnlDate1"
        Me.pnlDate1.Size = New System.Drawing.Size(280, 36)
        Me.pnlDate1.TabIndex = 3
        Me.pnlDate1.Visible = False
        '
        'dtpTo1
        '
        Me.dtpTo1.Location = New System.Drawing.Point(192, 8)
        Me.dtpTo1.Name = "dtpTo1"
        Me.dtpTo1.Size = New System.Drawing.Size(83, 23)
        Me.dtpTo1.TabIndex = 2
        Me.dtpTo1.Value = New Date(2024, 5, 21, 0, 0, 0, 0)
        '
        'lbldate1
        '
        Me.lbldate1.Location = New System.Drawing.Point(5, 3)
        Me.lbldate1.Name = "lbldate1"
        Me.lbldate1.Size = New System.Drawing.Size(73, 38)
        Me.lbldate1.TabIndex = 0
        Me.lbldate1.Text = " From"
        Me.lbldate1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTo1
        '
        Me.lblTo1.AutoSize = True
        Me.lblTo1.Location = New System.Drawing.Point(171, 12)
        Me.lblTo1.Name = "lblTo1"
        Me.lblTo1.Size = New System.Drawing.Size(19, 15)
        Me.lblTo1.TabIndex = 2
        Me.lblTo1.Text = "To"
        Me.lblTo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFrom1
        '
        Me.dtpFrom1.Location = New System.Drawing.Point(87, 8)
        Me.dtpFrom1.Name = "dtpFrom1"
        Me.dtpFrom1.Size = New System.Drawing.Size(89, 23)
        Me.dtpFrom1.TabIndex = 1
        Me.dtpFrom1.Value = New Date(2024, 5, 21, 0, 0, 0, 0)
        '
        'cmbLocation
        '
        Me.cmbLocation.EditValue = ""
        Me.cmbLocation.Enabled = False
        Me.cmbLocation.Location = New System.Drawing.Point(338, 349)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLocation.Properties.IncrementalSearch = True
        Me.cmbLocation.Size = New System.Drawing.Size(176, 20)
        Me.cmbLocation.TabIndex = 9
        Me.cmbLocation.Tag = "Location"
        '
        'cmbTax
        '
        Me.cmbTax.EditValue = ""
        Me.cmbTax.Location = New System.Drawing.Point(338, 197)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTax.Properties.IncrementalSearch = True
        Me.cmbTax.Size = New System.Drawing.Size(174, 20)
        Me.cmbTax.TabIndex = 6
        Me.cmbTax.Tag = "Tax"
        '
        'cmbOperator
        '
        Me.cmbOperator.EditValue = ""
        Me.cmbOperator.Location = New System.Drawing.Point(79, 197)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOperator.Properties.IncrementalSearch = True
        Me.cmbOperator.Size = New System.Drawing.Size(172, 20)
        Me.cmbOperator.TabIndex = 4
        Me.cmbOperator.Tag = "Broker"
        '
        'chkChart
        '
        Me.chkChart.AutoSize = True
        Me.chkChart.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChart.Location = New System.Drawing.Point(255, 496)
        Me.chkChart.Name = "chkChart"
        Me.chkChart.Size = New System.Drawing.Size(101, 19)
        Me.chkChart.TabIndex = 17
        Me.chkChart.Text = "Display Chart"
        Me.chkChart.UseVisualStyleBackColor = True
        Me.chkChart.Visible = False
        '
        'chkData
        '
        Me.chkData.AutoSize = True
        Me.chkData.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkData.Location = New System.Drawing.Point(149, 496)
        Me.chkData.Name = "chkData"
        Me.chkData.Size = New System.Drawing.Size(97, 19)
        Me.chkData.TabIndex = 16
        Me.chkData.Text = "Display Data"
        Me.chkData.UseVisualStyleBackColor = True
        Me.chkData.Visible = False
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(254, 200)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 15)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "Tax"
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(10, 200)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(43, 15)
        Me.lblOperator.TabIndex = 3
        Me.lblOperator.Text = "Broker"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(254, 352)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(53, 15)
        Me.lblLocation.TabIndex = 8
        Me.lblLocation.Text = "Location"
        '
        'txtText
        '
        Me.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtText.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtText.Location = New System.Drawing.Point(64, 461)
        Me.txtText.MaxLength = 0
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(117, 22)
        Me.txtText.TabIndex = 15
        Me.txtText.Tag = ""
        Me.txtText.Visible = False
        '
        'lblText
        '
        Me.lblText.Location = New System.Drawing.Point(10, 463)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(52, 15)
        Me.lblText.TabIndex = 14
        Me.lblText.Text = "Barcode"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblText.Visible = False
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.lblFrom)
        Me.pnlDate.Controls.Add(Me.lblTo)
        Me.pnlDate.Controls.Add(Me.dtpFrom)
        Me.pnlDate.Enabled = False
        Me.pnlDate.Location = New System.Drawing.Point(10, 17)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(309, 28)
        Me.pnlDate.TabIndex = 0
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(222, 4)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(84, 23)
        Me.dtpTo.TabIndex = 3
        Me.dtpTo.Value = New Date(2024, 5, 21, 0, 0, 0, 0)
        '
        'lblFrom
        '
        Me.lblFrom.Location = New System.Drawing.Point(9, 8)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(89, 15)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(194, 8)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(19, 15)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(107, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(89, 23)
        Me.dtpFrom.TabIndex = 1
        Me.dtpFrom.Value = New Date(2024, 5, 21, 0, 0, 0, 0)
        '
        'pnlStock
        '
        Me.pnlStock.Controls.Add(Me.pnlAgingParam)
        Me.pnlStock.Controls.Add(Me.pnlRateType)
        Me.pnlStock.Controls.Add(Me.chkDispValue)
        Me.pnlStock.Controls.Add(Me.txtStkTo)
        Me.pnlStock.Controls.Add(Me.txtStkFrom)
        Me.pnlStock.Controls.Add(Me.lblAgingOn)
        Me.pnlStock.Controls.Add(Me.lblQty)
        Me.pnlStock.Controls.Add(Me.chkDispRate)
        Me.pnlStock.Controls.Add(Me.cmbDisplay)
        Me.pnlStock.Location = New System.Drawing.Point(7, 409)
        Me.pnlStock.Name = "pnlStock"
        Me.pnlStock.Size = New System.Drawing.Size(445, 79)
        Me.pnlStock.TabIndex = 13
        Me.pnlStock.Visible = False
        '
        'pnlAgingParam
        '
        Me.pnlAgingParam.Controls.Add(Me.rdAgeQty)
        Me.pnlAgingParam.Controls.Add(Me.rdAgeValue)
        Me.pnlAgingParam.Location = New System.Drawing.Point(218, 50)
        Me.pnlAgingParam.Name = "pnlAgingParam"
        Me.pnlAgingParam.Size = New System.Drawing.Size(225, 26)
        Me.pnlAgingParam.TabIndex = 8
        Me.pnlAgingParam.Visible = False
        '
        'rdAgeQty
        '
        Me.rdAgeQty.AutoSize = True
        Me.rdAgeQty.Checked = True
        Me.rdAgeQty.Location = New System.Drawing.Point(19, 2)
        Me.rdAgeQty.Name = "rdAgeQty"
        Me.rdAgeQty.Size = New System.Drawing.Size(44, 19)
        Me.rdAgeQty.TabIndex = 0
        Me.rdAgeQty.TabStop = True
        Me.rdAgeQty.Text = "Qty"
        Me.rdAgeQty.UseVisualStyleBackColor = True
        '
        'rdAgeValue
        '
        Me.rdAgeValue.AutoSize = True
        Me.rdAgeValue.Location = New System.Drawing.Point(98, 2)
        Me.rdAgeValue.Name = "rdAgeValue"
        Me.rdAgeValue.Size = New System.Drawing.Size(55, 19)
        Me.rdAgeValue.TabIndex = 1
        Me.rdAgeValue.Text = "Value"
        Me.rdAgeValue.UseVisualStyleBackColor = True
        '
        'pnlRateType
        '
        Me.pnlRateType.Controls.Add(Me.rdPurRate)
        Me.pnlRateType.Controls.Add(Me.rdMRP)
        Me.pnlRateType.Controls.Add(Me.rdSP)
        Me.pnlRateType.Location = New System.Drawing.Point(218, 2)
        Me.pnlRateType.Name = "pnlRateType"
        Me.pnlRateType.Size = New System.Drawing.Size(225, 46)
        Me.pnlRateType.TabIndex = 6
        Me.pnlRateType.TabStop = False
        Me.pnlRateType.Text = "Value On"
        Me.pnlRateType.Visible = False
        '
        'rdPurRate
        '
        Me.rdPurRate.AutoSize = True
        Me.rdPurRate.Checked = True
        Me.rdPurRate.Location = New System.Drawing.Point(19, 18)
        Me.rdPurRate.Name = "rdPurRate"
        Me.rdPurRate.Size = New System.Drawing.Size(58, 19)
        Me.rdPurRate.TabIndex = 0
        Me.rdPurRate.TabStop = True
        Me.rdPurRate.Text = "Pur Rt"
        Me.rdPurRate.UseVisualStyleBackColor = True
        '
        'rdMRP
        '
        Me.rdMRP.AutoSize = True
        Me.rdMRP.Location = New System.Drawing.Point(98, 18)
        Me.rdMRP.Name = "rdMRP"
        Me.rdMRP.Size = New System.Drawing.Size(50, 19)
        Me.rdMRP.TabIndex = 1
        Me.rdMRP.Text = "MRP"
        Me.rdMRP.UseVisualStyleBackColor = True
        '
        'rdSP
        '
        Me.rdSP.AutoSize = True
        Me.rdSP.Location = New System.Drawing.Point(173, 18)
        Me.rdSP.Name = "rdSP"
        Me.rdSP.Size = New System.Drawing.Size(38, 19)
        Me.rdSP.TabIndex = 2
        Me.rdSP.Text = "SP"
        Me.rdSP.UseVisualStyleBackColor = True
        '
        'chkDispValue
        '
        Me.chkDispValue.AutoSize = True
        Me.chkDispValue.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDispValue.Location = New System.Drawing.Point(162, 30)
        Me.chkDispValue.Name = "chkDispValue"
        Me.chkDispValue.Size = New System.Drawing.Size(101, 19)
        Me.chkDispValue.TabIndex = 5
        Me.chkDispValue.Text = "Display Value"
        Me.chkDispValue.UseVisualStyleBackColor = True
        Me.chkDispValue.Visible = False
        '
        'txtStkTo
        '
        Me.txtStkTo.AllowAlphabets = False
        Me.txtStkTo.AllowMoveToNextControl = False
        Me.txtStkTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStkTo.EditValue = 0
        Me.txtStkTo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkTo.Location = New System.Drawing.Point(167, 4)
        Me.txtStkTo.Name = "txtStkTo"
        Me.txtStkTo.Size = New System.Drawing.Size(43, 22)
        Me.txtStkTo.TabIndex = 3
        Me.txtStkTo.Tag = "Qty To"
        Me.txtStkTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStkTo.Visible = False
        '
        'txtStkFrom
        '
        Me.txtStkFrom.AllowAlphabets = False
        Me.txtStkFrom.AllowMoveToNextControl = False
        Me.txtStkFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStkFrom.EditValue = 0
        Me.txtStkFrom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkFrom.Location = New System.Drawing.Point(120, 4)
        Me.txtStkFrom.Name = "txtStkFrom"
        Me.txtStkFrom.Size = New System.Drawing.Size(43, 22)
        Me.txtStkFrom.TabIndex = 2
        Me.txtStkFrom.Tag = "Qty From"
        Me.txtStkFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStkFrom.Visible = False
        '
        'lblAgingOn
        '
        Me.lblAgingOn.AutoSize = True
        Me.lblAgingOn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgingOn.Location = New System.Drawing.Point(157, 54)
        Me.lblAgingOn.Name = "lblAgingOn"
        Me.lblAgingOn.Size = New System.Drawing.Size(64, 18)
        Me.lblAgingOn.TabIndex = 7
        Me.lblAgingOn.Text = "Aging On"
        Me.lblAgingOn.Visible = False
        '
        'lblQty
        '
        Me.lblQty.Location = New System.Drawing.Point(3, 8)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(33, 18)
        Me.lblQty.TabIndex = 0
        Me.lblQty.Text = "Qty"
        Me.lblQty.Visible = False
        '
        'chkDispRate
        '
        Me.chkDispRate.AutoSize = True
        Me.chkDispRate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDispRate.Location = New System.Drawing.Point(11, 29)
        Me.chkDispRate.Name = "chkDispRate"
        Me.chkDispRate.Size = New System.Drawing.Size(95, 19)
        Me.chkDispRate.TabIndex = 4
        Me.chkDispRate.Text = "Display Rate"
        Me.chkDispRate.UseVisualStyleBackColor = True
        Me.chkDispRate.Visible = False
        '
        'cmbDisplay
        '
        Me.cmbDisplay.EditValue = "-- ALL --"
        Me.cmbDisplay.Location = New System.Drawing.Point(38, 5)
        Me.cmbDisplay.Name = "cmbDisplay"
        Me.cmbDisplay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDisplay.Properties.Items.AddRange(New Object() {"-- ALL --", "=", ">", "<", "Range"})
        Me.cmbDisplay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbDisplay.Size = New System.Drawing.Size(78, 20)
        Me.cmbDisplay.TabIndex = 1
        Me.cmbDisplay.Tag = "Quantity Type"
        Me.cmbDisplay.Visible = False
        '
        'pnlSummaryDetail
        '
        Me.pnlSummaryDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSummaryDetail.Controls.Add(Me.rdDetailed)
        Me.pnlSummaryDetail.Controls.Add(Me.rdSummary)
        Me.pnlSummaryDetail.Enabled = False
        Me.pnlSummaryDetail.Location = New System.Drawing.Point(324, 17)
        Me.pnlSummaryDetail.Name = "pnlSummaryDetail"
        Me.pnlSummaryDetail.Size = New System.Drawing.Size(176, 26)
        Me.pnlSummaryDetail.TabIndex = 1
        '
        'rdDetailed
        '
        Me.rdDetailed.AutoSize = True
        Me.rdDetailed.Checked = True
        Me.rdDetailed.Location = New System.Drawing.Point(97, 3)
        Me.rdDetailed.Name = "rdDetailed"
        Me.rdDetailed.Size = New System.Drawing.Size(71, 19)
        Me.rdDetailed.TabIndex = 1
        Me.rdDetailed.TabStop = True
        Me.rdDetailed.Text = "Detailed"
        Me.rdDetailed.UseVisualStyleBackColor = True
        '
        'rdSummary
        '
        Me.rdSummary.AutoSize = True
        Me.rdSummary.Location = New System.Drawing.Point(5, 3)
        Me.rdSummary.Name = "rdSummary"
        Me.rdSummary.Size = New System.Drawing.Size(76, 19)
        Me.rdSummary.TabIndex = 0
        Me.rdSummary.Text = "Summary"
        Me.rdSummary.UseVisualStyleBackColor = True
        '
        'pnlSeries
        '
        Me.pnlSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSeries.Controls.Add(Me.rdA)
        Me.pnlSeries.Controls.Add(Me.rdAll)
        Me.pnlSeries.Controls.Add(Me.rdB)
        Me.pnlSeries.Location = New System.Drawing.Point(140, 381)
        Me.pnlSeries.Name = "pnlSeries"
        Me.pnlSeries.Size = New System.Drawing.Size(147, 26)
        Me.pnlSeries.TabIndex = 11
        Me.pnlSeries.Visible = False
        '
        'rdA
        '
        Me.rdA.AutoSize = True
        Me.rdA.Checked = True
        Me.rdA.Location = New System.Drawing.Point(6, 2)
        Me.rdA.Name = "rdA"
        Me.rdA.Size = New System.Drawing.Size(32, 19)
        Me.rdA.TabIndex = 0
        Me.rdA.TabStop = True
        Me.rdA.Text = "A"
        Me.rdA.UseVisualStyleBackColor = True
        '
        'rdAll
        '
        Me.rdAll.AutoSize = True
        Me.rdAll.Location = New System.Drawing.Point(96, 2)
        Me.rdAll.Name = "rdAll"
        Me.rdAll.Size = New System.Drawing.Size(40, 19)
        Me.rdAll.TabIndex = 2
        Me.rdAll.Text = "All"
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'rdB
        '
        Me.rdB.AutoSize = True
        Me.rdB.Location = New System.Drawing.Point(50, 2)
        Me.rdB.Name = "rdB"
        Me.rdB.Size = New System.Drawing.Size(32, 19)
        Me.rdB.TabIndex = 1
        Me.rdB.Text = "B"
        Me.rdB.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(324, 531)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 26)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        '
        'btnOption
        '
        Me.btnOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOption.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption.Appearance.Options.UseFont = True
        Me.btnOption.Location = New System.Drawing.Point(232, 531)
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Size = New System.Drawing.Size(75, 26)
        Me.btnOption.TabIndex = 19
        Me.btnOption.Text = "Option"
        Me.btnOption.Visible = False
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnView.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Appearance.Options.UseFont = True
        Me.btnView.Location = New System.Drawing.Point(133, 531)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 26)
        Me.btnView.TabIndex = 18
        Me.btnView.Text = "View"
        '
        'pnlProduct
        '
        Me.pnlProduct.Controls.Add(Me.cmbOccassion)
        Me.pnlProduct.Controls.Add(Me.cmbSeason)
        Me.pnlProduct.Controls.Add(Me.cmbQuality)
        Me.pnlProduct.Controls.Add(Me.cmbBrand)
        Me.pnlProduct.Controls.Add(Me.cmbSize)
        Me.pnlProduct.Controls.Add(Me.cmbShade)
        Me.pnlProduct.Controls.Add(Me.cmbType)
        Me.pnlProduct.Controls.Add(Me.cmbStyle)
        Me.pnlProduct.Controls.Add(Me.cmbProduct)
        Me.pnlProduct.Controls.Add(Me.cmbProductSubGrp)
        Me.pnlProduct.Controls.Add(Me.cmbProductGrp)
        Me.pnlProduct.Controls.Add(Me.lblSize)
        Me.pnlProduct.Controls.Add(Me.lblOccassion)
        Me.pnlProduct.Controls.Add(Me.lblShade)
        Me.pnlProduct.Controls.Add(Me.lblSeason)
        Me.pnlProduct.Controls.Add(Me.lblType)
        Me.pnlProduct.Controls.Add(Me.lblQuality)
        Me.pnlProduct.Controls.Add(Me.lblSubGroup)
        Me.pnlProduct.Controls.Add(Me.lblDesign)
        Me.pnlProduct.Controls.Add(Me.lblBrand)
        Me.pnlProduct.Controls.Add(Me.lblGroup)
        Me.pnlProduct.Controls.Add(Me.lblProduct)
        Me.pnlProduct.Enabled = False
        Me.pnlProduct.Location = New System.Drawing.Point(9, 220)
        Me.pnlProduct.Name = "pnlProduct"
        Me.pnlProduct.Size = New System.Drawing.Size(511, 155)
        Me.pnlProduct.TabIndex = 7
        '
        'cmbOccassion
        '
        Me.cmbOccassion.EditValue = ""
        Me.cmbOccassion.Location = New System.Drawing.Point(70, 128)
        Me.cmbOccassion.Name = "cmbOccassion"
        Me.cmbOccassion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOccassion.Properties.IncrementalSearch = True
        Me.cmbOccassion.Size = New System.Drawing.Size(174, 20)
        Me.cmbOccassion.TabIndex = 21
        Me.cmbOccassion.Tag = "Occassion"
        '
        'cmbSeason
        '
        Me.cmbSeason.EditValue = ""
        Me.cmbSeason.Location = New System.Drawing.Point(329, 104)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSeason.Properties.IncrementalSearch = True
        Me.cmbSeason.Size = New System.Drawing.Size(176, 20)
        Me.cmbSeason.TabIndex = 19
        Me.cmbSeason.Tag = "Season"
        '
        'cmbQuality
        '
        Me.cmbQuality.EditValue = ""
        Me.cmbQuality.Location = New System.Drawing.Point(70, 104)
        Me.cmbQuality.Name = "cmbQuality"
        Me.cmbQuality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbQuality.Properties.IncrementalSearch = True
        Me.cmbQuality.Size = New System.Drawing.Size(174, 20)
        Me.cmbQuality.TabIndex = 17
        Me.cmbQuality.Tag = "Quality"
        '
        'cmbBrand
        '
        Me.cmbBrand.EditValue = ""
        Me.cmbBrand.Location = New System.Drawing.Point(329, 80)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBrand.Properties.IncrementalSearch = True
        Me.cmbBrand.Size = New System.Drawing.Size(176, 20)
        Me.cmbBrand.TabIndex = 15
        Me.cmbBrand.Tag = "Brand"
        '
        'cmbSize
        '
        Me.cmbSize.EditValue = ""
        Me.cmbSize.Location = New System.Drawing.Point(70, 80)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSize.Properties.IncrementalSearch = True
        Me.cmbSize.Size = New System.Drawing.Size(174, 20)
        Me.cmbSize.TabIndex = 13
        Me.cmbSize.Tag = "Size"
        '
        'cmbShade
        '
        Me.cmbShade.EditValue = ""
        Me.cmbShade.Location = New System.Drawing.Point(329, 56)
        Me.cmbShade.Name = "cmbShade"
        Me.cmbShade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbShade.Properties.IncrementalSearch = True
        Me.cmbShade.Size = New System.Drawing.Size(176, 20)
        Me.cmbShade.TabIndex = 11
        Me.cmbShade.Tag = "Shade"
        '
        'cmbType
        '
        Me.cmbType.EditValue = ""
        Me.cmbType.Location = New System.Drawing.Point(70, 56)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbType.Properties.IncrementalSearch = True
        Me.cmbType.Size = New System.Drawing.Size(174, 20)
        Me.cmbType.TabIndex = 9
        Me.cmbType.Tag = "Type"
        '
        'cmbStyle
        '
        Me.cmbStyle.EditValue = ""
        Me.cmbStyle.Location = New System.Drawing.Point(329, 32)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStyle.Properties.IncrementalSearch = True
        Me.cmbStyle.Size = New System.Drawing.Size(176, 20)
        Me.cmbStyle.TabIndex = 7
        Me.cmbStyle.Tag = "Design"
        '
        'cmbProduct
        '
        Me.cmbProduct.EditValue = ""
        Me.cmbProduct.Location = New System.Drawing.Point(70, 32)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProduct.Properties.IncrementalSearch = True
        Me.cmbProduct.Size = New System.Drawing.Size(174, 20)
        Me.cmbProduct.TabIndex = 5
        Me.cmbProduct.Tag = "Product"
        '
        'cmbProductSubGrp
        '
        Me.cmbProductSubGrp.EditValue = ""
        Me.cmbProductSubGrp.Location = New System.Drawing.Point(329, 7)
        Me.cmbProductSubGrp.Name = "cmbProductSubGrp"
        Me.cmbProductSubGrp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProductSubGrp.Properties.IncrementalSearch = True
        Me.cmbProductSubGrp.Size = New System.Drawing.Size(176, 20)
        Me.cmbProductSubGrp.TabIndex = 3
        Me.cmbProductSubGrp.Tag = "Product Sub-Group"
        '
        'cmbProductGrp
        '
        Me.cmbProductGrp.EditValue = ""
        Me.cmbProductGrp.Location = New System.Drawing.Point(70, 7)
        Me.cmbProductGrp.Name = "cmbProductGrp"
        Me.cmbProductGrp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProductGrp.Properties.IncrementalSearch = True
        Me.cmbProductGrp.Size = New System.Drawing.Size(174, 20)
        Me.cmbProductGrp.TabIndex = 1
        Me.cmbProductGrp.Tag = "Product Group"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(2, 83)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(28, 15)
        Me.lblSize.TabIndex = 12
        Me.lblSize.Text = "Size"
        '
        'lblOccassion
        '
        Me.lblOccassion.AutoSize = True
        Me.lblOccassion.Location = New System.Drawing.Point(3, 131)
        Me.lblOccassion.Name = "lblOccassion"
        Me.lblOccassion.Size = New System.Drawing.Size(65, 15)
        Me.lblOccassion.TabIndex = 20
        Me.lblOccassion.Text = "Occassion"
        '
        'lblShade
        '
        Me.lblShade.AutoSize = True
        Me.lblShade.Location = New System.Drawing.Point(246, 59)
        Me.lblShade.Name = "lblShade"
        Me.lblShade.Size = New System.Drawing.Size(40, 15)
        Me.lblShade.TabIndex = 10
        Me.lblShade.Text = "Shade"
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.Location = New System.Drawing.Point(246, 107)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(46, 15)
        Me.lblSeason.TabIndex = 18
        Me.lblSeason.Text = "Season"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(3, 59)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 15)
        Me.lblType.TabIndex = 8
        Me.lblType.Text = "Type"
        '
        'lblQuality
        '
        Me.lblQuality.AutoSize = True
        Me.lblQuality.Location = New System.Drawing.Point(3, 107)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(48, 15)
        Me.lblQuality.TabIndex = 16
        Me.lblQuality.Text = "Quality"
        '
        'lblSubGroup
        '
        Me.lblSubGroup.AutoSize = True
        Me.lblSubGroup.Location = New System.Drawing.Point(246, 10)
        Me.lblSubGroup.Name = "lblSubGroup"
        Me.lblSubGroup.Size = New System.Drawing.Size(65, 15)
        Me.lblSubGroup.TabIndex = 2
        Me.lblSubGroup.Text = "Sub-Group"
        '
        'lblDesign
        '
        Me.lblDesign.AutoSize = True
        Me.lblDesign.Location = New System.Drawing.Point(246, 35)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(44, 15)
        Me.lblDesign.TabIndex = 6
        Me.lblDesign.Text = "Design"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(246, 83)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(40, 15)
        Me.lblBrand.TabIndex = 14
        Me.lblBrand.Text = "Brand"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(3, 10)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(41, 15)
        Me.lblGroup.TabIndex = 0
        Me.lblGroup.Text = "Group"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(3, 35)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(50, 15)
        Me.lblProduct.TabIndex = 4
        Me.lblProduct.Text = "Product"
        '
        'pnlParty
        '
        Me.pnlParty.Controls.Add(Me.cmbRegion)
        Me.pnlParty.Controls.Add(Me.lblRegion)
        Me.pnlParty.Controls.Add(Me.lblCountry)
        Me.pnlParty.Controls.Add(Me.cmbCountry)
        Me.pnlParty.Controls.Add(Me.cmbParty)
        Me.pnlParty.Controls.Add(Me.cmbStation)
        Me.pnlParty.Controls.Add(Me.cmbCity)
        Me.pnlParty.Controls.Add(Me.cmbDistrict)
        Me.pnlParty.Controls.Add(Me.cmbState)
        Me.pnlParty.Controls.Add(Me.lblParty)
        Me.pnlParty.Controls.Add(Me.lblStation)
        Me.pnlParty.Controls.Add(Me.lblCity)
        Me.pnlParty.Controls.Add(Me.lblState)
        Me.pnlParty.Controls.Add(Me.lblDistrict)
        Me.pnlParty.Enabled = False
        Me.pnlParty.Location = New System.Drawing.Point(111, 54)
        Me.pnlParty.Name = "pnlParty"
        Me.pnlParty.Size = New System.Drawing.Size(271, 135)
        Me.pnlParty.TabIndex = 3
        '
        'cmbRegion
        '
        Me.cmbRegion.EditValue = ""
        Me.cmbRegion.Location = New System.Drawing.Point(56, 4)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRegion.Properties.IncrementalSearch = True
        Me.cmbRegion.Size = New System.Drawing.Size(209, 20)
        Me.cmbRegion.TabIndex = 0
        Me.cmbRegion.Tag = "Country"
        Me.cmbRegion.Visible = False
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(4, 7)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(44, 15)
        Me.lblRegion.TabIndex = 14
        Me.lblRegion.Text = "Region"
        Me.lblRegion.Visible = False
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(4, 34)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(50, 15)
        Me.lblCountry.TabIndex = 11
        Me.lblCountry.Text = "Country"
        Me.lblCountry.Visible = False
        '
        'cmbCountry
        '
        Me.cmbCountry.EditValue = ""
        Me.cmbCountry.Location = New System.Drawing.Point(56, 31)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCountry.Properties.IncrementalSearch = True
        Me.cmbCountry.Size = New System.Drawing.Size(209, 20)
        Me.cmbCountry.TabIndex = 1
        Me.cmbCountry.Tag = "Country"
        Me.cmbCountry.Visible = False
        '
        'cmbParty
        '
        Me.cmbParty.EditValue = ""
        Me.cmbParty.Location = New System.Drawing.Point(56, 109)
        Me.cmbParty.Name = "cmbParty"
        Me.cmbParty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbParty.Properties.IncrementalSearch = True
        Me.cmbParty.Size = New System.Drawing.Size(209, 20)
        Me.cmbParty.TabIndex = 9
        Me.cmbParty.Tag = "Party"
        '
        'cmbStation
        '
        Me.cmbStation.EditValue = ""
        Me.cmbStation.Location = New System.Drawing.Point(56, 83)
        Me.cmbStation.Name = "cmbStation"
        Me.cmbStation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStation.Properties.IncrementalSearch = True
        Me.cmbStation.Size = New System.Drawing.Size(209, 20)
        Me.cmbStation.TabIndex = 7
        Me.cmbStation.Tag = "Station"
        '
        'cmbCity
        '
        Me.cmbCity.EditValue = ""
        Me.cmbCity.Location = New System.Drawing.Point(-9, 40)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCity.Properties.IncrementalSearch = True
        Me.cmbCity.Size = New System.Drawing.Size(10, 20)
        Me.cmbCity.TabIndex = 5
        Me.cmbCity.Tag = "City"
        Me.cmbCity.Visible = False
        '
        'cmbDistrict
        '
        Me.cmbDistrict.EditValue = ""
        Me.cmbDistrict.Location = New System.Drawing.Point(-9, 46)
        Me.cmbDistrict.Name = "cmbDistrict"
        Me.cmbDistrict.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDistrict.Properties.IncrementalSearch = True
        Me.cmbDistrict.Size = New System.Drawing.Size(11, 20)
        Me.cmbDistrict.TabIndex = 3
        Me.cmbDistrict.Tag = "District"
        Me.cmbDistrict.Visible = False
        '
        'cmbState
        '
        Me.cmbState.EditValue = ""
        Me.cmbState.Location = New System.Drawing.Point(56, 57)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbState.Properties.IncrementalSearch = True
        Me.cmbState.Size = New System.Drawing.Size(209, 20)
        Me.cmbState.TabIndex = 2
        Me.cmbState.Tag = "State"
        '
        'lblParty
        '
        Me.lblParty.AutoSize = True
        Me.lblParty.Location = New System.Drawing.Point(4, 112)
        Me.lblParty.Name = "lblParty"
        Me.lblParty.Size = New System.Drawing.Size(36, 15)
        Me.lblParty.TabIndex = 8
        Me.lblParty.Text = "Party"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(4, 86)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(45, 15)
        Me.lblStation.TabIndex = 6
        Me.lblStation.Text = "Station"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(-30, 45)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(28, 15)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City"
        Me.lblCity.Visible = False
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(4, 60)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(34, 15)
        Me.lblState.TabIndex = 0
        Me.lblState.Text = "State"
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Location = New System.Drawing.Point(3, 33)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(48, 15)
        Me.lblDistrict.TabIndex = 2
        Me.lblDistrict.Text = "District"
        Me.lblDistrict.Visible = False
        '
        'pnlSection
        '
        Me.pnlSection.Controls.Add(Me.lblSection)
        Me.pnlSection.Controls.Add(Me.cmbSelection)
        Me.pnlSection.Location = New System.Drawing.Point(32, 411)
        Me.pnlSection.Name = "pnlSection"
        Me.pnlSection.Size = New System.Drawing.Size(485, 33)
        Me.pnlSection.TabIndex = 29
        Me.pnlSection.Visible = False
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Location = New System.Drawing.Point(9, 9)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(81, 15)
        Me.lblSection.TabIndex = 26
        Me.lblSection.Text = "Select Section"
        '
        'cmbSelection
        '
        Me.cmbSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelection.Location = New System.Drawing.Point(95, 5)
        Me.cmbSelection.Name = "cmbSelection"
        Me.cmbSelection.Size = New System.Drawing.Size(385, 23)
        Me.cmbSelection.TabIndex = 27
        '
        'pnlOptions
        '
        Me.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOptions.Controls.Add(Me.pnlSelectOption)
        Me.pnlOptions.Controls.Add(Me.lstMain)
        Me.pnlOptions.Controls.Add(Me.btnCloseOption)
        Me.pnlOptions.Controls.Add(Me.Label21)
        Me.pnlOptions.Location = New System.Drawing.Point(518, 74)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(270, 438)
        Me.pnlOptions.TabIndex = 1
        Me.pnlOptions.Visible = False
        '
        'pnlSelectOption
        '
        Me.pnlSelectOption.Controls.Add(Me.lstDetails)
        Me.pnlSelectOption.Controls.Add(Me.lstOption1)
        Me.pnlSelectOption.Controls.Add(Me.btnGrp1)
        Me.pnlSelectOption.Controls.Add(Me.lstOption3)
        Me.pnlSelectOption.Controls.Add(Me.btnGrp2)
        Me.pnlSelectOption.Controls.Add(Me.lstOption2)
        Me.pnlSelectOption.Controls.Add(Me.btnGrp3)
        Me.pnlSelectOption.Controls.Add(Me.btnDetail)
        Me.pnlSelectOption.Controls.Add(Me.btnDelDetail)
        Me.pnlSelectOption.Controls.Add(Me.btnDown)
        Me.pnlSelectOption.Controls.Add(Me.btnDelGrp1)
        Me.pnlSelectOption.Controls.Add(Me.btnUp)
        Me.pnlSelectOption.Controls.Add(Me.btnDelGrp2)
        Me.pnlSelectOption.Controls.Add(Me.btnDelGrp3)
        Me.pnlSelectOption.Location = New System.Drawing.Point(93, 13)
        Me.pnlSelectOption.Name = "pnlSelectOption"
        Me.pnlSelectOption.Size = New System.Drawing.Size(165, 380)
        Me.pnlSelectOption.TabIndex = 1
        '
        'lstDetails
        '
        Me.lstDetails.AllowDrop = True
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.ItemHeight = 15
        Me.lstDetails.Location = New System.Drawing.Point(67, 291)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(93, 64)
        Me.lstDetails.TabIndex = 10
        '
        'lstOption1
        '
        Me.lstOption1.AllowDrop = True
        Me.lstOption1.FormattingEnabled = True
        Me.lstOption1.ItemHeight = 15
        Me.lstOption1.Location = New System.Drawing.Point(68, 2)
        Me.lstOption1.Name = "lstOption1"
        Me.lstOption1.Size = New System.Drawing.Size(93, 64)
        Me.lstOption1.TabIndex = 1
        '
        'btnGrp1
        '
        Me.btnGrp1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrp1.Appearance.Options.UseFont = True
        Me.btnGrp1.Location = New System.Drawing.Point(5, 2)
        Me.btnGrp1.Name = "btnGrp1"
        Me.btnGrp1.Size = New System.Drawing.Size(53, 22)
        Me.btnGrp1.TabIndex = 0
        Me.btnGrp1.Text = "Grp 1 >"
        '
        'lstOption3
        '
        Me.lstOption3.AllowDrop = True
        Me.lstOption3.FormattingEnabled = True
        Me.lstOption3.ItemHeight = 15
        Me.lstOption3.Location = New System.Drawing.Point(65, 195)
        Me.lstOption3.Name = "lstOption3"
        Me.lstOption3.Size = New System.Drawing.Size(93, 64)
        Me.lstOption3.TabIndex = 7
        '
        'btnGrp2
        '
        Me.btnGrp2.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrp2.Appearance.Options.UseFont = True
        Me.btnGrp2.Location = New System.Drawing.Point(5, 99)
        Me.btnGrp2.Name = "btnGrp2"
        Me.btnGrp2.Size = New System.Drawing.Size(53, 22)
        Me.btnGrp2.TabIndex = 3
        Me.btnGrp2.Text = "Grp 2 >"
        '
        'lstOption2
        '
        Me.lstOption2.AllowDrop = True
        Me.lstOption2.FormattingEnabled = True
        Me.lstOption2.ItemHeight = 15
        Me.lstOption2.Location = New System.Drawing.Point(67, 99)
        Me.lstOption2.Name = "lstOption2"
        Me.lstOption2.Size = New System.Drawing.Size(93, 64)
        Me.lstOption2.TabIndex = 4
        '
        'btnGrp3
        '
        Me.btnGrp3.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrp3.Appearance.Options.UseFont = True
        Me.btnGrp3.Location = New System.Drawing.Point(5, 195)
        Me.btnGrp3.Name = "btnGrp3"
        Me.btnGrp3.Size = New System.Drawing.Size(53, 22)
        Me.btnGrp3.TabIndex = 6
        Me.btnGrp3.Text = "Grp 3 >"
        '
        'btnDetail
        '
        Me.btnDetail.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetail.Appearance.Options.UseFont = True
        Me.btnDetail.Location = New System.Drawing.Point(5, 291)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(53, 22)
        Me.btnDetail.TabIndex = 9
        Me.btnDetail.Text = "Detail >"
        '
        'btnDelDetail
        '
        Me.btnDelDetail.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelDetail.Appearance.Options.UseFont = True
        Me.btnDelDetail.Location = New System.Drawing.Point(67, 355)
        Me.btnDelDetail.Name = "btnDelDetail"
        Me.btnDelDetail.Size = New System.Drawing.Size(93, 22)
        Me.btnDelDetail.TabIndex = 11
        Me.btnDelDetail.Text = "Delete"
        '
        'btnDown
        '
        Me.btnDown.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Appearance.Options.UseFont = True
        Me.btnDown.Enabled = False
        Me.btnDown.Location = New System.Drawing.Point(5, 338)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(53, 18)
        Me.btnDown.TabIndex = 13
        Me.btnDown.Text = "v"
        '
        'btnDelGrp1
        '
        Me.btnDelGrp1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelGrp1.Appearance.Options.UseFont = True
        Me.btnDelGrp1.Location = New System.Drawing.Point(68, 66)
        Me.btnDelGrp1.Name = "btnDelGrp1"
        Me.btnDelGrp1.Size = New System.Drawing.Size(93, 22)
        Me.btnDelGrp1.TabIndex = 2
        Me.btnDelGrp1.Text = "Delete"
        '
        'btnUp
        '
        Me.btnUp.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Appearance.Options.UseFont = True
        Me.btnUp.Enabled = False
        Me.btnUp.Location = New System.Drawing.Point(5, 319)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(53, 18)
        Me.btnUp.TabIndex = 12
        Me.btnUp.Text = "^"
        '
        'btnDelGrp2
        '
        Me.btnDelGrp2.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelGrp2.Appearance.Options.UseFont = True
        Me.btnDelGrp2.Location = New System.Drawing.Point(67, 163)
        Me.btnDelGrp2.Name = "btnDelGrp2"
        Me.btnDelGrp2.Size = New System.Drawing.Size(93, 22)
        Me.btnDelGrp2.TabIndex = 5
        Me.btnDelGrp2.Text = "Delete"
        '
        'btnDelGrp3
        '
        Me.btnDelGrp3.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelGrp3.Appearance.Options.UseFont = True
        Me.btnDelGrp3.Location = New System.Drawing.Point(65, 259)
        Me.btnDelGrp3.Name = "btnDelGrp3"
        Me.btnDelGrp3.Size = New System.Drawing.Size(93, 22)
        Me.btnDelGrp3.TabIndex = 8
        Me.btnDelGrp3.Text = "Delete"
        '
        'lstMain
        '
        Me.lstMain.FormattingEnabled = True
        Me.lstMain.ItemHeight = 15
        Me.lstMain.Items.AddRange(New Object() {"Section", "Group", "SubGroup", "Product", "Design", "Type", "Shade", "Size", "Brand", "Quality", "Season", "Occassion", "Location", "Supplier", "Broker"})
        Me.lstMain.Location = New System.Drawing.Point(2, 29)
        Me.lstMain.Name = "lstMain"
        Me.lstMain.Size = New System.Drawing.Size(88, 364)
        Me.lstMain.TabIndex = 0
        '
        'btnCloseOption
        '
        Me.btnCloseOption.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseOption.Appearance.Options.UseFont = True
        Me.btnCloseOption.Location = New System.Drawing.Point(111, 401)
        Me.btnCloseOption.Name = "btnCloseOption"
        Me.btnCloseOption.Size = New System.Drawing.Size(75, 26)
        Me.btnCloseOption.TabIndex = 2
        Me.btnCloseOption.Text = "Close"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 18)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Options"
        '
        'Plnitemdetils
        '
        Me.Plnitemdetils.Controls.Add(Me.rddamnaged)
        Me.Plnitemdetils.Controls.Add(Me.rdfinished)
        Me.Plnitemdetils.Enabled = False
        Me.Plnitemdetils.Location = New System.Drawing.Point(522, 15)
        Me.Plnitemdetils.Name = "Plnitemdetils"
        Me.Plnitemdetils.Size = New System.Drawing.Size(199, 37)
        Me.Plnitemdetils.TabIndex = 2
        Me.Plnitemdetils.TabStop = False
        '
        'rddamnaged
        '
        Me.rddamnaged.AutoSize = True
        Me.rddamnaged.Location = New System.Drawing.Point(104, 14)
        Me.rddamnaged.Name = "rddamnaged"
        Me.rddamnaged.Size = New System.Drawing.Size(76, 19)
        Me.rddamnaged.TabIndex = 1
        Me.rddamnaged.TabStop = True
        Me.rddamnaged.Text = "Damaged"
        Me.rddamnaged.UseVisualStyleBackColor = True
        '
        'rdfinished
        '
        Me.rdfinished.AutoSize = True
        Me.rdfinished.Checked = True
        Me.rdfinished.Location = New System.Drawing.Point(12, 15)
        Me.rdfinished.Name = "rdfinished"
        Me.rdfinished.Size = New System.Drawing.Size(72, 19)
        Me.rdfinished.TabIndex = 0
        Me.rdfinished.TabStop = True
        Me.rdfinished.Text = "Finished"
        Me.rdfinished.UseVisualStyleBackColor = True
        '
        'cmbPartyFrom
        '
        Appearance5.FontData.Name = "Verdana"
        Appearance5.FontData.SizeInPoints = 8.0!
        Me.cmbPartyFrom.Appearance = Appearance5
        Me.cmbPartyFrom.AutoComplete = True
        Me.cmbPartyFrom.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbPartyFrom.FlatMode = True
        Me.cmbPartyFrom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyFrom.Location = New System.Drawing.Point(906, 0)
        Me.cmbPartyFrom.Name = "cmbPartyFrom"
        Me.cmbPartyFrom.Size = New System.Drawing.Size(10, 20)
        Me.cmbPartyFrom.TabIndex = 14
        Me.cmbPartyFrom.Tag = "Jobber From"
        Me.cmbPartyFrom.Visible = False
        '
        'cmbBranchFrom
        '
        Appearance6.FontData.Name = "Verdana"
        Appearance6.FontData.SizeInPoints = 8.0!
        Me.cmbBranchFrom.Appearance = Appearance6
        Me.cmbBranchFrom.AutoComplete = True
        Me.cmbBranchFrom.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbBranchFrom.FlatMode = True
        Me.cmbBranchFrom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBranchFrom.Location = New System.Drawing.Point(854, -9)
        Me.cmbBranchFrom.Name = "cmbBranchFrom"
        Me.cmbBranchFrom.Size = New System.Drawing.Size(10, 20)
        Me.cmbBranchFrom.TabIndex = 16
        Me.cmbBranchFrom.TabStop = False
        Me.cmbBranchFrom.Tag = "Broker"
        Me.cmbBranchFrom.Visible = False
        '
        'txtPartyAddrFrom
        '
        Me.txtPartyAddrFrom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartyAddrFrom.Location = New System.Drawing.Point(792, -9)
        Me.txtPartyAddrFrom.MaxLength = 500
        Me.txtPartyAddrFrom.Multiline = True
        Me.txtPartyAddrFrom.Name = "txtPartyAddrFrom"
        Me.txtPartyAddrFrom.ReadOnly = True
        Me.txtPartyAddrFrom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPartyAddrFrom.Size = New System.Drawing.Size(10, 52)
        Me.txtPartyAddrFrom.TabIndex = 18
        Me.txtPartyAddrFrom.TabStop = False
        Me.txtPartyAddrFrom.Tag = "Remark"
        Me.txtPartyAddrFrom.Visible = False
        '
        'cmbPartyTo
        '
        Appearance7.FontData.Name = "Verdana"
        Appearance7.FontData.SizeInPoints = 8.0!
        Me.cmbPartyTo.Appearance = Appearance7
        Me.cmbPartyTo.AutoComplete = True
        Me.cmbPartyTo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbPartyTo.FlatMode = True
        Me.cmbPartyTo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyTo.Location = New System.Drawing.Point(898, 0)
        Me.cmbPartyTo.Name = "cmbPartyTo"
        Me.cmbPartyTo.Size = New System.Drawing.Size(10, 20)
        Me.cmbPartyTo.TabIndex = 22
        Me.cmbPartyTo.TabStop = False
        Me.cmbPartyTo.Tag = "Jobber To"
        Me.cmbPartyTo.Visible = False
        '
        'cmbBranchTo
        '
        Appearance8.FontData.Name = "Verdana"
        Appearance8.FontData.SizeInPoints = 8.0!
        Me.cmbBranchTo.Appearance = Appearance8
        Me.cmbBranchTo.AutoComplete = True
        Me.cmbBranchTo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbBranchTo.FlatMode = True
        Me.cmbBranchTo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBranchTo.Location = New System.Drawing.Point(880, -9)
        Me.cmbBranchTo.Name = "cmbBranchTo"
        Me.cmbBranchTo.Size = New System.Drawing.Size(10, 20)
        Me.cmbBranchTo.TabIndex = 24
        Me.cmbBranchTo.TabStop = False
        Me.cmbBranchTo.Tag = "Broker"
        '
        'txtPartyAddrTo
        '
        Me.txtPartyAddrTo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartyAddrTo.Location = New System.Drawing.Point(865, -21)
        Me.txtPartyAddrTo.MaxLength = 500
        Me.txtPartyAddrTo.Multiline = True
        Me.txtPartyAddrTo.Name = "txtPartyAddrTo"
        Me.txtPartyAddrTo.ReadOnly = True
        Me.txtPartyAddrTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPartyAddrTo.Size = New System.Drawing.Size(21, 52)
        Me.txtPartyAddrTo.TabIndex = 26
        Me.txtPartyAddrTo.TabStop = False
        Me.txtPartyAddrTo.Tag = "Remark"
        Me.txtPartyAddrTo.Visible = False
        '
        'UltraComboEditor1
        '
        Appearance9.FontData.Name = "Verdana"
        Appearance9.FontData.SizeInPoints = 8.0!
        Me.UltraComboEditor1.Appearance = Appearance9
        Me.UltraComboEditor1.AutoComplete = True
        Me.UltraComboEditor1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.UltraComboEditor1.FlatMode = True
        Me.UltraComboEditor1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.UltraComboEditor1.Location = New System.Drawing.Point(914, 0)
        Me.UltraComboEditor1.Name = "UltraComboEditor1"
        Me.UltraComboEditor1.Size = New System.Drawing.Size(21, 20)
        Me.UltraComboEditor1.TabIndex = 17
        Me.UltraComboEditor1.TabStop = False
        Me.UltraComboEditor1.Tag = "Location"
        Me.UltraComboEditor1.Visible = False
        '
        'cmbMRNType
        '
        Appearance10.FontData.Name = "Verdana"
        Appearance10.FontData.SizeInPoints = 8.0!
        Me.cmbMRNType.Appearance = Appearance10
        Me.cmbMRNType.AutoComplete = True
        Me.cmbMRNType.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbMRNType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbMRNType.FlatMode = True
        Me.cmbMRNType.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMRNType.Location = New System.Drawing.Point(789, 6)
        Me.cmbMRNType.Name = "cmbMRNType"
        Me.cmbMRNType.Size = New System.Drawing.Size(115, 20)
        Me.cmbMRNType.TabIndex = 11
        Me.cmbMRNType.Tag = "MRN"
        '
        'lblDeptment
        '
        Me.lblDeptment.AutoSize = True
        Me.lblDeptment.BackColor = System.Drawing.Color.Transparent
        Me.lblDeptment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptment.Location = New System.Drawing.Point(116, 218)
        Me.lblDeptment.Name = "lblDeptment"
        Me.lblDeptment.Size = New System.Drawing.Size(73, 18)
        Me.lblDeptment.TabIndex = 8
        Me.lblDeptment.Text = "From Dept"
        '
        'cmbFromDept
        '
        Appearance11.FontData.Name = "Verdana"
        Appearance11.FontData.SizeInPoints = 8.0!
        Me.cmbFromDept.Appearance = Appearance11
        Me.cmbFromDept.AutoComplete = True
        Me.cmbFromDept.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbFromDept.FlatMode = True
        Me.cmbFromDept.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFromDept.Location = New System.Drawing.Point(197, 218)
        Me.cmbFromDept.Name = "cmbFromDept"
        Me.cmbFromDept.Size = New System.Drawing.Size(213, 20)
        Me.cmbFromDept.TabIndex = 9
        Me.cmbFromDept.Tag = "Broker"
        '
        'grpmrn
        '
        Me.grpmrn.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.grpmrn.Appearance.Options.UseBackColor = True
        Me.grpmrn.Controls.Add(Me.cmbCreationNo)
        Me.grpmrn.Controls.Add(Me.Label9)
        Me.grpmrn.Controls.Add(Me.cmbOCNO)
        Me.grpmrn.Controls.Add(Me.Label8)
        Me.grpmrn.Controls.Add(Me.cmbMIN)
        Me.grpmrn.Controls.Add(Me.lblMIN)
        Me.grpmrn.Controls.Add(Me.cmbMRN)
        Me.grpmrn.Controls.Add(Me.Label2)
        Me.grpmrn.Controls.Add(Me.cmbFromDept)
        Me.grpmrn.Controls.Add(Me.lblDeptment)
        Me.grpmrn.Controls.Add(Me.cmbMRNType)
        Me.grpmrn.Controls.Add(Me.UltraComboEditor1)
        Me.grpmrn.Controls.Add(Me.txtPartyAddrTo)
        Me.grpmrn.Controls.Add(Me.cmbBranchTo)
        Me.grpmrn.Controls.Add(Me.cmbPartyTo)
        Me.grpmrn.Controls.Add(Me.txtPartyAddrFrom)
        Me.grpmrn.Controls.Add(Me.cmbBranchFrom)
        Me.grpmrn.Controls.Add(Me.cmbPartyFrom)
        Me.grpmrn.Location = New System.Drawing.Point(6, 46)
        Me.grpmrn.LookAndFeel.SkinName = "Money Twins"
        Me.grpmrn.Name = "grpmrn"
        Me.grpmrn.ShowCaption = False
        Me.grpmrn.Size = New System.Drawing.Size(772, 470)
        Me.grpmrn.TabIndex = 3
        Me.grpmrn.Text = "GroupControl3"
        '
        'cmbCreationNo
        '
        Appearance12.FontData.Name = "Verdana"
        Appearance12.FontData.SizeInPoints = 8.0!
        Me.cmbCreationNo.Appearance = Appearance12
        Me.cmbCreationNo.AutoComplete = True
        Me.cmbCreationNo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbCreationNo.FlatMode = True
        Me.cmbCreationNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCreationNo.Location = New System.Drawing.Point(197, 169)
        Me.cmbCreationNo.Name = "cmbCreationNo"
        Me.cmbCreationNo.Size = New System.Drawing.Size(213, 20)
        Me.cmbCreationNo.TabIndex = 7
        Me.cmbCreationNo.Tag = "Broker"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(116, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Creation No"
        '
        'cmbOCNO
        '
        Appearance13.FontData.Name = "Verdana"
        Appearance13.FontData.SizeInPoints = 8.0!
        Me.cmbOCNO.Appearance = Appearance13
        Me.cmbOCNO.AutoComplete = True
        Me.cmbOCNO.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbOCNO.FlatMode = True
        Me.cmbOCNO.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOCNO.Location = New System.Drawing.Point(197, 120)
        Me.cmbOCNO.Name = "cmbOCNO"
        Me.cmbOCNO.Size = New System.Drawing.Size(213, 20)
        Me.cmbOCNO.TabIndex = 5
        Me.cmbOCNO.Tag = "Broker"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "OC No"
        '
        'cmbMIN
        '
        Appearance14.FontData.Name = "Verdana"
        Appearance14.FontData.SizeInPoints = 8.0!
        Me.cmbMIN.Appearance = Appearance14
        Me.cmbMIN.AutoComplete = True
        Me.cmbMIN.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbMIN.FlatMode = True
        Me.cmbMIN.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMIN.Location = New System.Drawing.Point(197, 19)
        Me.cmbMIN.Name = "cmbMIN"
        Me.cmbMIN.Size = New System.Drawing.Size(213, 20)
        Me.cmbMIN.TabIndex = 1
        Me.cmbMIN.Tag = "Broker"
        '
        'lblMIN
        '
        Me.lblMIN.AutoSize = True
        Me.lblMIN.BackColor = System.Drawing.Color.Transparent
        Me.lblMIN.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMIN.Location = New System.Drawing.Point(116, 20)
        Me.lblMIN.Name = "lblMIN"
        Me.lblMIN.Size = New System.Drawing.Size(55, 18)
        Me.lblMIN.TabIndex = 0
        Me.lblMIN.Text = "MIN No"
        '
        'cmbMRN
        '
        Appearance15.FontData.Name = "Verdana"
        Appearance15.FontData.SizeInPoints = 8.0!
        Me.cmbMRN.Appearance = Appearance15
        Me.cmbMRN.AutoComplete = True
        Me.cmbMRN.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbMRN.FlatMode = True
        Me.cmbMRN.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMRN.Location = New System.Drawing.Point(197, 70)
        Me.cmbMRN.Name = "cmbMRN"
        Me.cmbMRN.Size = New System.Drawing.Size(213, 20)
        Me.cmbMRN.TabIndex = 3
        Me.cmbMRN.Tag = "Broker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MRN No"
        '
        'LBLPP
        '
        Me.LBLPP.Location = New System.Drawing.Point(370, 418)
        Me.LBLPP.Name = "LBLPP"
        Me.LBLPP.Size = New System.Drawing.Size(33, 18)
        Me.LBLPP.TabIndex = 54
        Me.LBLPP.Text = "PP"
        Me.LBLPP.Visible = False
        '
        'frmReportFilters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 567)
        Me.Controls.Add(Me.Plnitemdetils)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.grpmrn)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmReportFilters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.pnlOtherOptions.ResumeLayout(False)
        Me.pnlOtherOptions.PerformLayout()
        CType(Me.cmbSalesType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDate2.ResumeLayout(False)
        Me.pnlDate2.PerformLayout()
        CType(Me.cmbJOrderNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStateGSTR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlJobCard.ResumeLayout(False)
        Me.pnlJobCard.PerformLayout()
        CType(Me.cmbPurType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSONo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrderNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHoney.ResumeLayout(False)
        Me.pnlHoney.PerformLayout()
        CType(Me.cmbProcessHoney.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPartyHoney.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDate1.ResumeLayout(False)
        Me.pnlDate1.PerformLayout()
        CType(Me.cmbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOperator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.pnlStock.ResumeLayout(False)
        Me.pnlStock.PerformLayout()
        Me.pnlAgingParam.ResumeLayout(False)
        Me.pnlAgingParam.PerformLayout()
        Me.pnlRateType.ResumeLayout(False)
        Me.pnlRateType.PerformLayout()
        CType(Me.cmbDisplay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSummaryDetail.ResumeLayout(False)
        Me.pnlSummaryDetail.PerformLayout()
        Me.pnlSeries.ResumeLayout(False)
        Me.pnlSeries.PerformLayout()
        Me.pnlProduct.ResumeLayout(False)
        Me.pnlProduct.PerformLayout()
        CType(Me.cmbOccassion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSeason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbQuality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbShade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductSubGrp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductGrp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParty.ResumeLayout(False)
        Me.pnlParty.PerformLayout()
        CType(Me.cmbRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbParty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDistrict.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSection.ResumeLayout(False)
        Me.pnlSection.PerformLayout()
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlOptions.PerformLayout()
        Me.pnlSelectOption.ResumeLayout(False)
        Me.Plnitemdetils.ResumeLayout(False)
        Me.Plnitemdetils.PerformLayout()
        CType(Me.cmbPartyFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBranchFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPartyTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBranchTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMRNType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFromDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpmrn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpmrn.ResumeLayout(False)
        Me.grpmrn.PerformLayout()
        CType(Me.cmbCreationNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOCNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMRN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents pnlParty As System.Windows.Forms.Panel
    Friend WithEvents lblStation As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblDistrict As System.Windows.Forms.Label
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblParty As System.Windows.Forms.Label
    Friend WithEvents pnlProduct As System.Windows.Forms.Panel
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblShade As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblDesign As System.Windows.Forms.Label
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents lblOccassion As System.Windows.Forms.Label
    Friend WithEvents lblSeason As System.Windows.Forms.Label
    Friend WithEvents lblQuality As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
    Friend WithEvents rdSummary As System.Windows.Forms.RadioButton
    Friend WithEvents rdDetailed As System.Windows.Forms.RadioButton
    Friend WithEvents lblSubGroup As System.Windows.Forms.Label
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents pnlSeries As System.Windows.Forms.Panel
    Friend WithEvents rdA As System.Windows.Forms.RadioButton
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdB As System.Windows.Forms.RadioButton
    Friend WithEvents pnlSummaryDetail As System.Windows.Forms.Panel
    Friend WithEvents chkSize As System.Windows.Forms.CheckBox
    Friend WithEvents btnOption As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents lstOption3 As System.Windows.Forms.ListBox
    Friend WithEvents lstOption2 As System.Windows.Forms.ListBox
    Friend WithEvents lstMain As System.Windows.Forms.ListBox
    Friend WithEvents btnCloseOption As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstOption1 As System.Windows.Forms.ListBox
    Friend WithEvents lstDetails As System.Windows.Forms.ListBox
    Friend WithEvents btnDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGrp3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGrp2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGrp1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelGrp3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelGrp2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelGrp1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents pnlSelectOption As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbDisplay As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents txtStkFrom As NumericTextBox.NumericTextBox
    Friend WithEvents pnlStock As System.Windows.Forms.Panel
    Friend WithEvents chkDispRate As System.Windows.Forms.CheckBox
    Friend WithEvents chkDispValue As System.Windows.Forms.CheckBox
    Friend WithEvents txtStkTo As NumericTextBox.NumericTextBox
    Friend WithEvents rdPurRate As System.Windows.Forms.RadioButton
    Friend WithEvents rdSP As System.Windows.Forms.RadioButton
    Friend WithEvents rdMRP As System.Windows.Forms.RadioButton
    Friend WithEvents pnlRateType As System.Windows.Forms.GroupBox
    Friend WithEvents pnlAgingParam As System.Windows.Forms.Panel
    Friend WithEvents rdAgeQty As System.Windows.Forms.RadioButton
    Friend WithEvents rdAgeValue As System.Windows.Forms.RadioButton
    Friend WithEvents lblAgingOn As System.Windows.Forms.Label
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents pnlOtherOptions As System.Windows.Forms.Panel
    Friend WithEvents rdOthOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdOthOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdOthOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblOperator As System.Windows.Forms.Label
    Friend WithEvents chkChart As System.Windows.Forms.CheckBox
    Friend WithEvents chkData As System.Windows.Forms.CheckBox
    Friend WithEvents cmbDistrict As CustomCheckbox.CustomEdit
    Friend WithEvents cmbState As CustomCheckbox.CustomEdit
    Friend WithEvents cmbCity As CustomCheckbox.CustomEdit
    Friend WithEvents cmbParty As CustomCheckbox.CustomEdit
    Friend WithEvents cmbStation As CustomCheckbox.CustomEdit
    Friend WithEvents cmbTax As CustomCheckbox.CustomEdit
    Friend WithEvents cmbOperator As CustomCheckbox.CustomEdit
    Friend WithEvents cmbProductGrp As CustomCheckbox.CustomEdit
    Friend WithEvents cmbProductSubGrp As CustomCheckbox.CustomEdit
    Friend WithEvents cmbType As CustomCheckbox.CustomEdit
    Friend WithEvents cmbStyle As CustomCheckbox.CustomEdit
    Friend WithEvents cmbProduct As CustomCheckbox.CustomEdit
    Friend WithEvents cmbSize As CustomCheckbox.CustomEdit
    Friend WithEvents cmbShade As CustomCheckbox.CustomEdit
    Friend WithEvents cmbSeason As CustomCheckbox.CustomEdit
    Friend WithEvents cmbQuality As CustomCheckbox.CustomEdit
    Friend WithEvents cmbBrand As CustomCheckbox.CustomEdit
    Friend WithEvents cmbLocation As CustomCheckbox.CustomEdit
    Friend WithEvents cmbOccassion As CustomCheckbox.CustomEdit
    Friend WithEvents pnlDate1 As System.Windows.Forms.Panel
    Friend WithEvents dtpTo1 As DateTimePick.DateTimePick
    Friend WithEvents lbldate1 As System.Windows.Forms.Label
    Friend WithEvents lblTo1 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom1 As DateTimePick.DateTimePick
    Friend WithEvents cmbrate As CustomCheckbox.CustomEdit
    Friend WithEvents pnlHoney As System.Windows.Forms.Panel
    Friend WithEvents cmbProcessHoney As CustomCheckbox.CustomEdit
    Friend WithEvents lblProcess As System.Windows.Forms.Label
    Friend WithEvents cmbPartyHoney As CustomCheckbox.CustomEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Plnitemdetils As System.Windows.Forms.GroupBox
    Friend WithEvents rddamnaged As System.Windows.Forms.RadioButton
    Friend WithEvents rdfinished As System.Windows.Forms.RadioButton
    Friend WithEvents cmbOrderNo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblJobOrder As System.Windows.Forms.Label
    Friend WithEvents lblSaleOrder As System.Windows.Forms.Label
    Friend WithEvents cmbSONo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbCountry As CustomCheckbox.CustomEdit
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents btnGSTR3BExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGSTR1Excel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbPurType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblPurchaseType As System.Windows.Forms.Label
    Friend WithEvents lblJTo As System.Windows.Forms.Label
    Friend WithEvents pnlJobCard As System.Windows.Forms.Panel
    Friend WithEvents txtJobCardTo As System.Windows.Forms.TextBox
    Friend WithEvents txtJobCardFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblJFrom As System.Windows.Forms.Label
    Friend WithEvents cmbStateGSTR As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStore As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkStatewise As System.Windows.Forms.CheckBox
    Friend WithEvents chkStorewise As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbJOrderNo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents cmbRegion As CustomCheckbox.CustomEdit
    Friend WithEvents pnlDate2 As System.Windows.Forms.Panel
    Friend WithEvents dtpTo2 As DateTimePick.DateTimePick
    Friend WithEvents lblFrom2 As System.Windows.Forms.Label
    Friend WithEvents lblTo2 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom2 As DateTimePick.DateTimePick
    Friend WithEvents lblSalesType As System.Windows.Forms.Label
    Friend WithEvents cmbSalesType As CustomCheckbox.CustomEdit
    Friend WithEvents pnlSection As System.Windows.Forms.Panel
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents cmbSelection As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyFrom As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbBranchFrom As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtPartyAddrFrom As System.Windows.Forms.TextBox
    Friend WithEvents cmbPartyTo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbBranchTo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtPartyAddrTo As System.Windows.Forms.TextBox
    Friend WithEvents UltraComboEditor1 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbMRNType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblDeptment As System.Windows.Forms.Label
    Friend WithEvents cmbFromDept As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents grpmrn As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbMRN As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCreationNo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbOCNO As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbMIN As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblMIN As System.Windows.Forms.Label
    Friend WithEvents chkDesignAsperStock As System.Windows.Forms.CheckBox
    Friend WithEvents BtnStockExportToExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGstR1New As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LBLPP As System.Windows.Forms.Label
End Class
