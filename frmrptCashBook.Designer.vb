<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptCashBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal rptType As enmRptType)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        bytRptType = rptType
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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lblFormCaption As System.Windows.Forms.Label
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbPurchType As System.Windows.Forms.ComboBox
    Friend WithEvents lblPurchType As System.Windows.Forms.Label
    Friend WithEvents chkViewSize As System.Windows.Forms.CheckBox
    Friend WithEvents cmbStateFrom As System.Windows.Forms.ComboBox
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdWithinState As System.Windows.Forms.RadioButton
    Friend WithEvents rdOutOfState As System.Windows.Forms.RadioButton
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents pnlState As System.Windows.Forms.Panel
    Friend WithEvents pnlCNType As System.Windows.Forms.Panel
    Friend WithEvents rdCNTypeAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdCNTypeGoodsRtn As System.Windows.Forms.RadioButton
    Friend WithEvents rdCNTypeOthers As System.Windows.Forms.RadioButton
    Friend WithEvents pnlPartyType As System.Windows.Forms.Panel
    Friend WithEvents rdPartyAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdPartyCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rdPartySupl As System.Windows.Forms.RadioButton
    Friend WithEvents cmbPurchGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblPurchGroup As System.Windows.Forms.Label
    Friend WithEvents cmbTax As System.Windows.Forms.ComboBox
    Friend WithEvents chkTax As System.Windows.Forms.CheckBox
    Friend WithEvents lblBroker As System.Windows.Forms.Label
    Friend WithEvents cmbBrokerFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbBrokerTo As System.Windows.Forms.ComboBox
    Friend WithEvents pnlBroker As System.Windows.Forms.Panel
    Friend WithEvents chkPurType As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmbBank As System.Windows.Forms.ComboBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents chkSizeWise As System.Windows.Forms.CheckBox
    Friend WithEvents btnPurType As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCityFrom = New System.Windows.Forms.ComboBox
        Me.cmbCityTo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbStateFrom1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbStateTo = New System.Windows.Forms.ComboBox
        Me.pnlParty = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbPartyFrom = New System.Windows.Forms.ComboBox
        Me.cmbPartyTo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkSum = New System.Windows.Forms.CheckBox
        Me.chkSizeWise = New System.Windows.Forms.CheckBox
        Me.cmbBank = New System.Windows.Forms.ComboBox
        Me.lblBank = New System.Windows.Forms.Label
        Me.chkPurType = New System.Windows.Forms.CheckedListBox
        Me.chkTax = New System.Windows.Forms.CheckBox
        Me.cmbTax = New System.Windows.Forms.ComboBox
        Me.cmbPurchGroup = New System.Windows.Forms.ComboBox
        Me.lblPurchGroup = New System.Windows.Forms.Label
        Me.pnlPartyType = New System.Windows.Forms.Panel
        Me.rdPartyAll = New System.Windows.Forms.RadioButton
        Me.rdPartyCustomer = New System.Windows.Forms.RadioButton
        Me.rdPartySupl = New System.Windows.Forms.RadioButton
        Me.pnlState = New System.Windows.Forms.Panel
        Me.rdAll = New System.Windows.Forms.RadioButton
        Me.rdWithinState = New System.Windows.Forms.RadioButton
        Me.rdOutOfState = New System.Windows.Forms.RadioButton
        Me.chkViewSize = New System.Windows.Forms.CheckBox
        Me.cmbPurchType = New System.Windows.Forms.ComboBox
        Me.lblPurchType = New System.Windows.Forms.Label
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.dtpTo = New DateTimePick.DateTimePick
        Me.dtpFrom = New DateTimePick.DateTimePick
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.cmbStateFrom = New System.Windows.Forms.ComboBox
        Me.lblState = New System.Windows.Forms.Label
        Me.pnlCNType = New System.Windows.Forms.Panel
        Me.rdCNTypeAll = New System.Windows.Forms.RadioButton
        Me.rdCNTypeGoodsRtn = New System.Windows.Forms.RadioButton
        Me.rdCNTypeOthers = New System.Windows.Forms.RadioButton
        Me.pnlBroker = New System.Windows.Forms.Panel
        Me.lblBroker = New System.Windows.Forms.Label
        Me.cmbBrokerFrom = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbBrokerTo = New System.Windows.Forms.ComboBox
        Me.btnPurType = New System.Windows.Forms.Button
        Me.grpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlParty.SuspendLayout()
        Me.pnlPartyType.SuspendLayout()
        Me.pnlState.SuspendLayout()
        Me.pnlDate.SuspendLayout()
        Me.pnlCNType.SuspendLayout()
        Me.pnlBroker.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpMain.BackColor = System.Drawing.Color.Transparent
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Controls.Add(Me.Panel2)
        Me.grpMain.Controls.Add(Me.pnlParty)
        Me.grpMain.Controls.Add(Me.chkSum)
        Me.grpMain.Controls.Add(Me.chkSizeWise)
        Me.grpMain.Controls.Add(Me.cmbBank)
        Me.grpMain.Controls.Add(Me.lblBank)
        Me.grpMain.Controls.Add(Me.chkPurType)
        Me.grpMain.Controls.Add(Me.chkTax)
        Me.grpMain.Controls.Add(Me.cmbTax)
        Me.grpMain.Controls.Add(Me.cmbPurchGroup)
        Me.grpMain.Controls.Add(Me.lblPurchGroup)
        Me.grpMain.Controls.Add(Me.pnlPartyType)
        Me.grpMain.Controls.Add(Me.pnlState)
        Me.grpMain.Controls.Add(Me.chkViewSize)
        Me.grpMain.Controls.Add(Me.cmbPurchType)
        Me.grpMain.Controls.Add(Me.lblPurchType)
        Me.grpMain.Controls.Add(Me.pnlDate)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.btnShow)
        Me.grpMain.Controls.Add(Me.cmbStateFrom)
        Me.grpMain.Controls.Add(Me.lblState)
        Me.grpMain.Controls.Add(Me.pnlCNType)
        Me.grpMain.Controls.Add(Me.pnlBroker)
        Me.grpMain.Controls.Add(Me.btnPurType)
        Me.grpMain.Location = New System.Drawing.Point(16, 12)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(612, 496)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbCityFrom)
        Me.Panel1.Controls.Add(Me.cmbCityTo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(7, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 32)
        Me.Panel1.TabIndex = 113
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "City From"
        '
        'cmbCityFrom
        '
        Me.cmbCityFrom.DropDownWidth = 300
        Me.cmbCityFrom.Location = New System.Drawing.Point(98, 5)
        Me.cmbCityFrom.Name = "cmbCityFrom"
        Me.cmbCityFrom.Size = New System.Drawing.Size(225, 21)
        Me.cmbCityFrom.TabIndex = 13
        Me.cmbCityFrom.Tag = "Party From"
        '
        'cmbCityTo
        '
        Me.cmbCityTo.DropDownWidth = 300
        Me.cmbCityTo.Location = New System.Drawing.Point(360, 5)
        Me.cmbCityTo.Name = "cmbCityTo"
        Me.cmbCityTo.Size = New System.Drawing.Size(215, 21)
        Me.cmbCityTo.TabIndex = 15
        Me.cmbCityTo.Tag = "Party To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(328, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "To"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cmbStateFrom1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cmbStateTo)
        Me.Panel2.Location = New System.Drawing.Point(7, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 35)
        Me.Panel2.TabIndex = 112
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 106
        Me.Label7.Tag = ""
        Me.Label7.Text = "State From"
        '
        'cmbStateFrom1
        '
        Me.cmbStateFrom1.Location = New System.Drawing.Point(98, 8)
        Me.cmbStateFrom1.Name = "cmbStateFrom1"
        Me.cmbStateFrom1.Size = New System.Drawing.Size(225, 21)
        Me.cmbStateFrom1.TabIndex = 107
        Me.cmbStateFrom1.Tag = "From Broker"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(328, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 108
        Me.Label9.Tag = ""
        Me.Label9.Text = "To"
        '
        'cmbStateTo
        '
        Me.cmbStateTo.Location = New System.Drawing.Point(360, 8)
        Me.cmbStateTo.Name = "cmbStateTo"
        Me.cmbStateTo.Size = New System.Drawing.Size(215, 21)
        Me.cmbStateTo.TabIndex = 109
        Me.cmbStateTo.Tag = "To Broker"
        '
        'pnlParty
        '
        Me.pnlParty.Controls.Add(Me.Label3)
        Me.pnlParty.Controls.Add(Me.cmbPartyFrom)
        Me.pnlParty.Controls.Add(Me.cmbPartyTo)
        Me.pnlParty.Controls.Add(Me.Label4)
        Me.pnlParty.Location = New System.Drawing.Point(7, 200)
        Me.pnlParty.Name = "pnlParty"
        Me.pnlParty.Size = New System.Drawing.Size(584, 32)
        Me.pnlParty.TabIndex = 111
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Party From"
        '
        'cmbPartyFrom
        '
        Me.cmbPartyFrom.DropDownWidth = 300
        Me.cmbPartyFrom.Location = New System.Drawing.Point(98, 5)
        Me.cmbPartyFrom.Name = "cmbPartyFrom"
        Me.cmbPartyFrom.Size = New System.Drawing.Size(225, 21)
        Me.cmbPartyFrom.TabIndex = 13
        Me.cmbPartyFrom.Tag = "Party From"
        '
        'cmbPartyTo
        '
        Me.cmbPartyTo.DropDownWidth = 300
        Me.cmbPartyTo.Location = New System.Drawing.Point(360, 5)
        Me.cmbPartyTo.Name = "cmbPartyTo"
        Me.cmbPartyTo.Size = New System.Drawing.Size(215, 21)
        Me.cmbPartyTo.TabIndex = 15
        Me.cmbPartyTo.Tag = "Party To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "To"
        '
        'chkSum
        '
        Me.chkSum.AutoSize = True
        Me.chkSum.Location = New System.Drawing.Point(497, 238)
        Me.chkSum.Name = "chkSum"
        Me.chkSum.Size = New System.Drawing.Size(73, 17)
        Me.chkSum.TabIndex = 110
        Me.chkSum.Text = "Detailed"
        Me.chkSum.UseVisualStyleBackColor = True
        Me.chkSum.Visible = False
        '
        'chkSizeWise
        '
        Me.chkSizeWise.AutoSize = True
        Me.chkSizeWise.Location = New System.Drawing.Point(281, 431)
        Me.chkSizeWise.Name = "chkSizeWise"
        Me.chkSizeWise.Size = New System.Drawing.Size(81, 17)
        Me.chkSizeWise.TabIndex = 109
        Me.chkSizeWise.Text = "Size Wise"
        Me.chkSizeWise.UseVisualStyleBackColor = True
        Me.chkSizeWise.Visible = False
        '
        'cmbBank
        '
        Me.cmbBank.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBank.ItemHeight = 13
        Me.cmbBank.Location = New System.Drawing.Point(175, 241)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(234, 21)
        Me.cmbBank.TabIndex = 108
        Me.cmbBank.Tag = "From State"
        Me.cmbBank.Visible = False
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(70, 244)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(102, 13)
        Me.lblBank.TabIndex = 107
        Me.lblBank.Text = "Sub Cash Book"
        Me.lblBank.Visible = False
        '
        'chkPurType
        '
        Me.chkPurType.Location = New System.Drawing.Point(159, 244)
        Me.chkPurType.Name = "chkPurType"
        Me.chkPurType.Size = New System.Drawing.Size(232, 52)
        Me.chkPurType.TabIndex = 106
        Me.chkPurType.Visible = False
        '
        'chkTax
        '
        Me.chkTax.Location = New System.Drawing.Point(73, 327)
        Me.chkTax.Name = "chkTax"
        Me.chkTax.Size = New System.Drawing.Size(80, 16)
        Me.chkTax.TabIndex = 105
        Me.chkTax.Text = "Tax Wise"
        Me.chkTax.Visible = False
        '
        'cmbTax
        '
        Me.cmbTax.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTax.ItemHeight = 13
        Me.cmbTax.Location = New System.Drawing.Point(160, 325)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Size = New System.Drawing.Size(234, 21)
        Me.cmbTax.TabIndex = 104
        Me.cmbTax.Tag = "Tax Name"
        Me.cmbTax.Visible = False
        '
        'cmbPurchGroup
        '
        Me.cmbPurchGroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurchGroup.ItemHeight = 13
        Me.cmbPurchGroup.Location = New System.Drawing.Point(160, 246)
        Me.cmbPurchGroup.Name = "cmbPurchGroup"
        Me.cmbPurchGroup.Size = New System.Drawing.Size(234, 21)
        Me.cmbPurchGroup.TabIndex = 1
        Me.cmbPurchGroup.Tag = "Purchase Group"
        Me.cmbPurchGroup.Visible = False
        '
        'lblPurchGroup
        '
        Me.lblPurchGroup.AutoSize = True
        Me.lblPurchGroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchGroup.Location = New System.Drawing.Point(73, 248)
        Me.lblPurchGroup.Name = "lblPurchGroup"
        Me.lblPurchGroup.Size = New System.Drawing.Size(87, 13)
        Me.lblPurchGroup.TabIndex = 17
        Me.lblPurchGroup.Text = "Purch Group"
        Me.lblPurchGroup.Visible = False
        '
        'pnlPartyType
        '
        Me.pnlPartyType.Controls.Add(Me.rdPartyAll)
        Me.pnlPartyType.Controls.Add(Me.rdPartyCustomer)
        Me.pnlPartyType.Controls.Add(Me.rdPartySupl)
        Me.pnlPartyType.Location = New System.Drawing.Point(105, 351)
        Me.pnlPartyType.Name = "pnlPartyType"
        Me.pnlPartyType.Size = New System.Drawing.Size(312, 24)
        Me.pnlPartyType.TabIndex = 5
        Me.pnlPartyType.Visible = False
        '
        'rdPartyAll
        '
        Me.rdPartyAll.Checked = True
        Me.rdPartyAll.Location = New System.Drawing.Point(9, 4)
        Me.rdPartyAll.Name = "rdPartyAll"
        Me.rdPartyAll.Size = New System.Drawing.Size(56, 16)
        Me.rdPartyAll.TabIndex = 0
        Me.rdPartyAll.TabStop = True
        Me.rdPartyAll.Text = "All"
        '
        'rdPartyCustomer
        '
        Me.rdPartyCustomer.Location = New System.Drawing.Point(81, 4)
        Me.rdPartyCustomer.Name = "rdPartyCustomer"
        Me.rdPartyCustomer.Size = New System.Drawing.Size(112, 16)
        Me.rdPartyCustomer.TabIndex = 1
        Me.rdPartyCustomer.Text = "Customer"
        '
        'rdPartySupl
        '
        Me.rdPartySupl.Location = New System.Drawing.Point(209, 4)
        Me.rdPartySupl.Name = "rdPartySupl"
        Me.rdPartySupl.Size = New System.Drawing.Size(96, 16)
        Me.rdPartySupl.TabIndex = 2
        Me.rdPartySupl.Text = "Supplier"
        '
        'pnlState
        '
        Me.pnlState.Controls.Add(Me.rdAll)
        Me.pnlState.Controls.Add(Me.rdWithinState)
        Me.pnlState.Controls.Add(Me.rdOutOfState)
        Me.pnlState.Location = New System.Drawing.Point(105, 375)
        Me.pnlState.Name = "pnlState"
        Me.pnlState.Size = New System.Drawing.Size(312, 24)
        Me.pnlState.TabIndex = 6
        Me.pnlState.Visible = False
        '
        'rdAll
        '
        Me.rdAll.Checked = True
        Me.rdAll.Location = New System.Drawing.Point(8, 4)
        Me.rdAll.Name = "rdAll"
        Me.rdAll.Size = New System.Drawing.Size(56, 16)
        Me.rdAll.TabIndex = 0
        Me.rdAll.TabStop = True
        Me.rdAll.Text = "All"
        '
        'rdWithinState
        '
        Me.rdWithinState.Location = New System.Drawing.Point(81, 4)
        Me.rdWithinState.Name = "rdWithinState"
        Me.rdWithinState.Size = New System.Drawing.Size(112, 16)
        Me.rdWithinState.TabIndex = 1
        Me.rdWithinState.Text = "Within State"
        '
        'rdOutOfState
        '
        Me.rdOutOfState.Location = New System.Drawing.Point(208, 4)
        Me.rdOutOfState.Name = "rdOutOfState"
        Me.rdOutOfState.Size = New System.Drawing.Size(96, 16)
        Me.rdOutOfState.TabIndex = 2
        Me.rdOutOfState.Text = "Out Of State"
        '
        'chkViewSize
        '
        Me.chkViewSize.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewSize.Location = New System.Drawing.Point(160, 431)
        Me.chkViewSize.Name = "chkViewSize"
        Me.chkViewSize.Size = New System.Drawing.Size(88, 16)
        Me.chkViewSize.TabIndex = 8
        Me.chkViewSize.Text = "View Size"
        Me.chkViewSize.Visible = False
        '
        'cmbPurchType
        '
        Me.cmbPurchType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurchType.ItemHeight = 13
        Me.cmbPurchType.Location = New System.Drawing.Point(327, 272)
        Me.cmbPurchType.Name = "cmbPurchType"
        Me.cmbPurchType.Size = New System.Drawing.Size(70, 21)
        Me.cmbPurchType.TabIndex = 2
        Me.cmbPurchType.Tag = "Purchase Type"
        Me.cmbPurchType.Visible = False
        '
        'lblPurchType
        '
        Me.lblPurchType.AutoSize = True
        Me.lblPurchType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchType.Location = New System.Drawing.Point(73, 274)
        Me.lblPurchType.Name = "lblPurchType"
        Me.lblPurchType.Size = New System.Drawing.Size(80, 13)
        Me.lblPurchType.TabIndex = 102
        Me.lblPurchType.Text = "Purch Type"
        Me.lblPurchType.Visible = False
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.dtpFrom)
        Me.pnlDate.Controls.Add(Me.Label1)
        Me.pnlDate.Controls.Add(Me.Label2)
        Me.pnlDate.Location = New System.Drawing.Point(125, 60)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(312, 28)
        Me.pnlDate.TabIndex = 0
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(210, 4)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(90, 21)
        Me.dtpTo.TabIndex = 3
        Me.dtpTo.Value = New Date(2017, 4, 28, 0, 0, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(59, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(90, 21)
        Me.dtpFrom.TabIndex = 2
        Me.dtpFrom.Value = New Date(2017, 4, 28, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'lblFormCaption
        '
        Me.lblFormCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFormCaption.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormCaption.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFormCaption.Location = New System.Drawing.Point(3, 17)
        Me.lblFormCaption.Name = "lblFormCaption"
        Me.lblFormCaption.Size = New System.Drawing.Size(606, 24)
        Me.lblFormCaption.TabIndex = 12
        Me.lblFormCaption.Text = "Cash Book Details"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(337, 456)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 28)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.Black
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(193, 456)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(88, 28)
        Me.btnShow.TabIndex = 9
        Me.btnShow.Text = "&View"
        '
        'cmbStateFrom
        '
        Me.cmbStateFrom.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStateFrom.ItemHeight = 13
        Me.cmbStateFrom.Location = New System.Drawing.Point(160, 298)
        Me.cmbStateFrom.Name = "cmbStateFrom"
        Me.cmbStateFrom.Size = New System.Drawing.Size(234, 21)
        Me.cmbStateFrom.TabIndex = 4
        Me.cmbStateFrom.Tag = "From State"
        Me.cmbStateFrom.Visible = False
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(73, 300)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(79, 13)
        Me.lblState.TabIndex = 3
        Me.lblState.Text = "Local State"
        Me.lblState.Visible = False
        '
        'pnlCNType
        '
        Me.pnlCNType.Controls.Add(Me.rdCNTypeAll)
        Me.pnlCNType.Controls.Add(Me.rdCNTypeGoodsRtn)
        Me.pnlCNType.Controls.Add(Me.rdCNTypeOthers)
        Me.pnlCNType.Location = New System.Drawing.Point(105, 399)
        Me.pnlCNType.Name = "pnlCNType"
        Me.pnlCNType.Size = New System.Drawing.Size(312, 24)
        Me.pnlCNType.TabIndex = 7
        Me.pnlCNType.Visible = False
        '
        'rdCNTypeAll
        '
        Me.rdCNTypeAll.Checked = True
        Me.rdCNTypeAll.Location = New System.Drawing.Point(9, 4)
        Me.rdCNTypeAll.Name = "rdCNTypeAll"
        Me.rdCNTypeAll.Size = New System.Drawing.Size(56, 16)
        Me.rdCNTypeAll.TabIndex = 0
        Me.rdCNTypeAll.TabStop = True
        Me.rdCNTypeAll.Text = "All"
        '
        'rdCNTypeGoodsRtn
        '
        Me.rdCNTypeGoodsRtn.Location = New System.Drawing.Point(81, 4)
        Me.rdCNTypeGoodsRtn.Name = "rdCNTypeGoodsRtn"
        Me.rdCNTypeGoodsRtn.Size = New System.Drawing.Size(112, 16)
        Me.rdCNTypeGoodsRtn.TabIndex = 1
        Me.rdCNTypeGoodsRtn.Text = "Goods Return"
        '
        'rdCNTypeOthers
        '
        Me.rdCNTypeOthers.Location = New System.Drawing.Point(209, 4)
        Me.rdCNTypeOthers.Name = "rdCNTypeOthers"
        Me.rdCNTypeOthers.Size = New System.Drawing.Size(96, 16)
        Me.rdCNTypeOthers.TabIndex = 2
        Me.rdCNTypeOthers.Text = "Others"
        '
        'pnlBroker
        '
        Me.pnlBroker.Controls.Add(Me.lblBroker)
        Me.pnlBroker.Controls.Add(Me.cmbBrokerFrom)
        Me.pnlBroker.Controls.Add(Me.Label8)
        Me.pnlBroker.Controls.Add(Me.cmbBrokerTo)
        Me.pnlBroker.Location = New System.Drawing.Point(7, 163)
        Me.pnlBroker.Name = "pnlBroker"
        Me.pnlBroker.Size = New System.Drawing.Size(584, 35)
        Me.pnlBroker.TabIndex = 0
        Me.pnlBroker.Visible = False
        '
        'lblBroker
        '
        Me.lblBroker.AutoSize = True
        Me.lblBroker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBroker.Location = New System.Drawing.Point(6, 10)
        Me.lblBroker.Name = "lblBroker"
        Me.lblBroker.Size = New System.Drawing.Size(89, 13)
        Me.lblBroker.TabIndex = 106
        Me.lblBroker.Tag = ""
        Me.lblBroker.Text = "Broker From"
        '
        'cmbBrokerFrom
        '
        Me.cmbBrokerFrom.Location = New System.Drawing.Point(98, 8)
        Me.cmbBrokerFrom.Name = "cmbBrokerFrom"
        Me.cmbBrokerFrom.Size = New System.Drawing.Size(225, 21)
        Me.cmbBrokerFrom.TabIndex = 107
        Me.cmbBrokerFrom.Tag = "From Broker"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(328, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 108
        Me.Label8.Tag = ""
        Me.Label8.Text = "To"
        '
        'cmbBrokerTo
        '
        Me.cmbBrokerTo.Location = New System.Drawing.Point(360, 8)
        Me.cmbBrokerTo.Name = "cmbBrokerTo"
        Me.cmbBrokerTo.Size = New System.Drawing.Size(215, 21)
        Me.cmbBrokerTo.TabIndex = 109
        Me.cmbBrokerTo.Tag = "To Broker"
        '
        'btnPurType
        '
        Me.btnPurType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurType.ForeColor = System.Drawing.Color.Black
        Me.btnPurType.Location = New System.Drawing.Point(447, 398)
        Me.btnPurType.Name = "btnPurType"
        Me.btnPurType.Size = New System.Drawing.Size(136, 24)
        Me.btnPurType.TabIndex = 9
        Me.btnPurType.Text = "Purch Type"
        Me.btnPurType.Visible = False
        '
        'frmrptCashBook
        '
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(640, 520)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmrptCashBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Book Details"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlParty.ResumeLayout(False)
        Me.pnlParty.PerformLayout()
        Me.pnlPartyType.ResumeLayout(False)
        Me.pnlState.ResumeLayout(False)
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.pnlCNType.ResumeLayout(False)
        Me.pnlBroker.ResumeLayout(False)
        Me.pnlBroker.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents chkSum As System.Windows.Forms.CheckBox
    Friend WithEvents pnlParty As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbPartyFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCityFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCityTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbStateFrom1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbStateTo As System.Windows.Forms.ComboBox

#End Region
End Class
