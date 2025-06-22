Imports System.Data.SqlClient

Public Class frmOSBillDetails
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Flg As WithDate)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        YNFlag = Flg
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
    Public WithEvents lblFormCaption As System.Windows.Forms.Label
    Friend WithEvents dtgSumOsBill As System.Windows.Forms.DataGrid
    Friend WithEvents dtgOsBillDetails As System.Windows.Forms.DataGrid
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbPartyFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCityTo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCityFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStateTo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStateFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyTo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBrokerTo As System.Windows.Forms.ComboBox
    Friend WithEvents txtODDays As NumericTextBox.NumericTextBox
    Friend WithEvents txtOsDays As NumericTextBox.NumericTextBox
    Friend WithEvents cmbBrokerFrom As System.Windows.Forms.ComboBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblTotalBillAmt As System.Windows.Forms.Label
    Friend WithEvents lblTotalOsAmt As System.Windows.Forms.Label
    Friend WithEvents pnlDays As System.Windows.Forms.Panel
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
    Friend WithEvents cmbSalesPerson As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbSaleType As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbBrand As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.cmbSaleType = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbSalesPerson = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.dtpTo = New DateTimePick.DateTimePick
        Me.dtpFrom = New DateTimePick.DateTimePick
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.pnlDays = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtODDays = New NumericTextBox.NumericTextBox
        Me.txtOsDays = New NumericTextBox.NumericTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbPartyFrom = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.dtgOsBillDetails = New System.Windows.Forms.DataGrid
        Me.dtgSumOsBill = New System.Windows.Forms.DataGrid
        Me.cmbPartyTo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbCityTo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCityFrom = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbStateTo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbStateFrom = New System.Windows.Forms.ComboBox
        Me.cmbBrokerTo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbBrokerFrom = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.lblRecords = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.lblTotalBillAmt = New System.Windows.Forms.Label
        Me.lblTotalOsAmt = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmbGroup = New System.Windows.Forms.ComboBox
        Me.cmbBrand = New System.Windows.Forms.ComboBox
        Me.grpMain.SuspendLayout()
        Me.pnlDate.SuspendLayout()
        Me.pnlDays.SuspendLayout()
        CType(Me.dtgOsBillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgSumOsBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpMain.Controls.Add(Me.cmbBrand)
        Me.grpMain.Controls.Add(Me.cmbGroup)
        Me.grpMain.Controls.Add(Me.Label16)
        Me.grpMain.Controls.Add(Me.Label15)
        Me.grpMain.Controls.Add(Me.cmbSaleType)
        Me.grpMain.Controls.Add(Me.Label13)
        Me.grpMain.Controls.Add(Me.cmbSalesPerson)
        Me.grpMain.Controls.Add(Me.Label12)
        Me.grpMain.Controls.Add(Me.pnlDate)
        Me.grpMain.Controls.Add(Me.pnlDays)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.cmbPartyFrom)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Controls.Add(Me.dtgOsBillDetails)
        Me.grpMain.Controls.Add(Me.dtgSumOsBill)
        Me.grpMain.Controls.Add(Me.cmbPartyTo)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.cmbCityTo)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.cmbCityFrom)
        Me.grpMain.Controls.Add(Me.Label4)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.cmbStateTo)
        Me.grpMain.Controls.Add(Me.Label6)
        Me.grpMain.Controls.Add(Me.cmbStateFrom)
        Me.grpMain.Controls.Add(Me.cmbBrokerTo)
        Me.grpMain.Controls.Add(Me.Label7)
        Me.grpMain.Controls.Add(Me.cmbBrokerFrom)
        Me.grpMain.Controls.Add(Me.Label8)
        Me.grpMain.Controls.Add(Me.btnView)
        Me.grpMain.Controls.Add(Me.lblRecords)
        Me.grpMain.Controls.Add(Me.btnPrint)
        Me.grpMain.Controls.Add(Me.lblTotalBillAmt)
        Me.grpMain.Controls.Add(Me.lblTotalOsAmt)
        Me.grpMain.Location = New System.Drawing.Point(37, 3)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(823, 573)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'cmbSaleType
        '
        Me.cmbSaleType.DropDownWidth = 300
        Me.cmbSaleType.Location = New System.Drawing.Point(475, 160)
        Me.cmbSaleType.Name = "cmbSaleType"
        Me.cmbSaleType.Size = New System.Drawing.Size(297, 21)
        Me.cmbSaleType.TabIndex = 38
        Me.cmbSaleType.Tag = "Sale Type"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(407, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Sale Type"
        '
        'cmbSalesPerson
        '
        Me.cmbSalesPerson.DropDownWidth = 300
        Me.cmbSalesPerson.Location = New System.Drawing.Point(109, 160)
        Me.cmbSalesPerson.Name = "cmbSalesPerson"
        Me.cmbSalesPerson.Size = New System.Drawing.Size(297, 21)
        Me.cmbSalesPerson.TabIndex = 36
        Me.cmbSalesPerson.Tag = "SalesPerson"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Sales Person"
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.dtpFrom)
        Me.pnlDate.Controls.Add(Me.Label14)
        Me.pnlDate.Controls.Add(Me.Label11)
        Me.pnlDate.Location = New System.Drawing.Point(19, 217)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(379, 31)
        Me.pnlDate.TabIndex = 34
        Me.pnlDate.Visible = False
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(280, 5)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(96, 21)
        Me.dtpTo.TabIndex = 19
        Me.dtpTo.Value = New Date(2022, 8, 5, 0, 0, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(96, 5)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(86, 21)
        Me.dtpFrom.TabIndex = 17
        Me.dtpFrom.Tag = "From Date"
        Me.dtpFrom.Value = New Date(2022, 8, 5, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(252, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "To"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "From Bill Dt"
        '
        'pnlDays
        '
        Me.pnlDays.Controls.Add(Me.Label9)
        Me.pnlDays.Controls.Add(Me.txtODDays)
        Me.pnlDays.Controls.Add(Me.txtOsDays)
        Me.pnlDays.Controls.Add(Me.Label10)
        Me.pnlDays.Location = New System.Drawing.Point(19, 218)
        Me.pnlDays.Name = "pnlDays"
        Me.pnlDays.Size = New System.Drawing.Size(396, 31)
        Me.pnlDays.TabIndex = 34
        Me.pnlDays.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "O/D Days"
        '
        'txtODDays
        '
        Me.txtODDays.AllowAlphabets = False
        Me.txtODDays.AllowMoveToNextControl = True
        Me.txtODDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtODDays.EditValue = 0
        Me.txtODDays.Location = New System.Drawing.Point(94, 5)
        Me.txtODDays.MaxLength = 5
        Me.txtODDays.Name = "txtODDays"
        Me.txtODDays.Size = New System.Drawing.Size(51, 21)
        Me.txtODDays.TabIndex = 17
        Me.txtODDays.Tag = "OverDue Days"
        Me.txtODDays.Text = "0"
        Me.txtODDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOsDays
        '
        Me.txtOsDays.AllowAlphabets = False
        Me.txtOsDays.AllowMoveToNextControl = True
        Me.txtOsDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOsDays.EditValue = 0
        Me.txtOsDays.Location = New System.Drawing.Point(340, 5)
        Me.txtOsDays.MaxLength = 5
        Me.txtOsDays.Name = "txtOsDays"
        Me.txtOsDays.Size = New System.Drawing.Size(51, 21)
        Me.txtOsDays.TabIndex = 19
        Me.txtOsDays.Tag = "Outstanding Days"
        Me.txtOsDays.Text = "0"
        Me.txtOsDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(270, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "O/s Days"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Party From"
        '
        'cmbPartyFrom
        '
        Me.cmbPartyFrom.DropDownWidth = 300
        Me.cmbPartyFrom.Location = New System.Drawing.Point(109, 109)
        Me.cmbPartyFrom.Name = "cmbPartyFrom"
        Me.cmbPartyFrom.Size = New System.Drawing.Size(297, 21)
        Me.cmbPartyFrom.TabIndex = 9
        Me.cmbPartyFrom.Tag = "Party From"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(328, 530)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 31)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "&Close"
        '
        'lblFormCaption
        '
        Me.lblFormCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFormCaption.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormCaption.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFormCaption.Location = New System.Drawing.Point(3, 17)
        Me.lblFormCaption.Name = "lblFormCaption"
        Me.lblFormCaption.Size = New System.Drawing.Size(817, 21)
        Me.lblFormCaption.TabIndex = 32
        Me.lblFormCaption.Text = "O/s Bill Details"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtgOsBillDetails
        '
        Me.dtgOsBillDetails.CaptionText = "Outstanding Bills (Details)"
        Me.dtgOsBillDetails.DataMember = ""
        Me.dtgOsBillDetails.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgOsBillDetails.Location = New System.Drawing.Point(12, 259)
        Me.dtgOsBillDetails.Name = "dtgOsBillDetails"
        Me.dtgOsBillDetails.Size = New System.Drawing.Size(764, 268)
        Me.dtgOsBillDetails.TabIndex = 21
        '
        'dtgSumOsBill
        '
        Me.dtgSumOsBill.CaptionText = "Outstanding Bills (Summary)"
        Me.dtgSumOsBill.DataMember = ""
        Me.dtgSumOsBill.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgSumOsBill.Location = New System.Drawing.Point(624, 17)
        Me.dtgSumOsBill.Name = "dtgSumOsBill"
        Me.dtgSumOsBill.ReadOnly = True
        Me.dtgSumOsBill.Size = New System.Drawing.Size(40, 28)
        Me.dtgSumOsBill.TabIndex = 2
        Me.dtgSumOsBill.Visible = False
        '
        'cmbPartyTo
        '
        Me.cmbPartyTo.DropDownWidth = 300
        Me.cmbPartyTo.Location = New System.Drawing.Point(476, 109)
        Me.cmbPartyTo.Name = "cmbPartyTo"
        Me.cmbPartyTo.Size = New System.Drawing.Size(297, 21)
        Me.cmbPartyTo.TabIndex = 11
        Me.cmbPartyTo.Tag = "Party To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(450, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "To"
        '
        'cmbCityTo
        '
        Me.cmbCityTo.Location = New System.Drawing.Point(476, 83)
        Me.cmbCityTo.Name = "cmbCityTo"
        Me.cmbCityTo.Size = New System.Drawing.Size(297, 21)
        Me.cmbCityTo.TabIndex = 7
        Me.cmbCityTo.Tag = "City To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(450, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To"
        '
        'cmbCityFrom
        '
        Me.cmbCityFrom.Location = New System.Drawing.Point(109, 83)
        Me.cmbCityFrom.Name = "cmbCityFrom"
        Me.cmbCityFrom.Size = New System.Drawing.Size(297, 21)
        Me.cmbCityFrom.TabIndex = 5
        Me.cmbCityFrom.Tag = "City From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "City From"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "State From"
        '
        'cmbStateTo
        '
        Me.cmbStateTo.Location = New System.Drawing.Point(476, 57)
        Me.cmbStateTo.Name = "cmbStateTo"
        Me.cmbStateTo.Size = New System.Drawing.Size(297, 21)
        Me.cmbStateTo.TabIndex = 3
        Me.cmbStateTo.Tag = "State To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(450, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "To"
        '
        'cmbStateFrom
        '
        Me.cmbStateFrom.Location = New System.Drawing.Point(109, 57)
        Me.cmbStateFrom.Name = "cmbStateFrom"
        Me.cmbStateFrom.Size = New System.Drawing.Size(297, 21)
        Me.cmbStateFrom.TabIndex = 1
        Me.cmbStateFrom.Tag = "State From"
        '
        'cmbBrokerTo
        '
        Me.cmbBrokerTo.DropDownWidth = 300
        Me.cmbBrokerTo.Location = New System.Drawing.Point(476, 135)
        Me.cmbBrokerTo.Name = "cmbBrokerTo"
        Me.cmbBrokerTo.Size = New System.Drawing.Size(297, 21)
        Me.cmbBrokerTo.TabIndex = 15
        Me.cmbBrokerTo.Tag = "Broker To"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(450, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "To"
        '
        'cmbBrokerFrom
        '
        Me.cmbBrokerFrom.DropDownWidth = 300
        Me.cmbBrokerFrom.Location = New System.Drawing.Point(109, 135)
        Me.cmbBrokerFrom.Name = "cmbBrokerFrom"
        Me.cmbBrokerFrom.Size = New System.Drawing.Size(297, 21)
        Me.cmbBrokerFrom.TabIndex = 13
        Me.cmbBrokerFrom.Tag = "Broker From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Broker From"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(475, 219)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(97, 31)
        Me.btnView.TabIndex = 20
        Me.btnView.Text = "&View"
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.ForeColor = System.Drawing.Color.Maroon
        Me.lblRecords.Location = New System.Drawing.Point(12, 530)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(60, 13)
        Me.lblRecords.TabIndex = 16
        Me.lblRecords.Text = "sdasdas"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(676, 218)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(97, 31)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "&Print"
        '
        'lblTotalBillAmt
        '
        Me.lblTotalBillAmt.AutoSize = True
        Me.lblTotalBillAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBillAmt.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalBillAmt.Location = New System.Drawing.Point(537, 538)
        Me.lblTotalBillAmt.Name = "lblTotalBillAmt"
        Me.lblTotalBillAmt.Size = New System.Drawing.Size(15, 13)
        Me.lblTotalBillAmt.TabIndex = 18
        Me.lblTotalBillAmt.Text = "0"
        Me.lblTotalBillAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalOsAmt
        '
        Me.lblTotalOsAmt.AutoSize = True
        Me.lblTotalOsAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOsAmt.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalOsAmt.Location = New System.Drawing.Point(641, 538)
        Me.lblTotalOsAmt.Name = "lblTotalOsAmt"
        Me.lblTotalOsAmt.Size = New System.Drawing.Size(15, 13)
        Me.lblTotalOsAmt.TabIndex = 18
        Me.lblTotalOsAmt.Text = "0"
        Me.lblTotalOsAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Group"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(427, 193)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Brand"
        Me.Label16.Visible = False
        '
        'cmbGroup
        '
        Me.cmbGroup.DropDownWidth = 300
        Me.cmbGroup.Location = New System.Drawing.Point(109, 187)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(297, 21)
        Me.cmbGroup.TabIndex = 41
        Me.cmbGroup.Tag = "Group"
        Me.cmbGroup.Visible = False
        '
        'cmbBrand
        '
        Me.cmbBrand.DropDownWidth = 300
        Me.cmbBrand.Location = New System.Drawing.Point(475, 188)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(297, 21)
        Me.cmbBrand.TabIndex = 42
        Me.cmbBrand.Tag = "Brand"
        Me.cmbBrand.Visible = False
        '
        'frmOSBillDetails
        '
        Me.ClientSize = New System.Drawing.Size(905, 600)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmOSBillDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "O/s Bill Details"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.pnlDays.ResumeLayout(False)
        Me.pnlDays.PerformLayout()
        CType(Me.dtgOsBillDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgSumOsBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Enum enmOSBillDtls
        Trans_Type
        Party
        BillNo
        BillDt
        DueDt
        BillDisc
        BillNet
        BillBal
        ODDays
        OSDays
        Broker
        State
        City
    End Enum

    Enum WithDate
        Yes
        No
    End Enum

    Dim YNFlag As WithDate
    Dim blnLoading As Boolean

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormatDetailHeaders(ByVal dtTable As DataTable)
        Dim tblStyle As DataGridTableStyle = GridColumnCreateAndFormat.CreateTableStyle(dtTable.TableName)
        tblStyle.ReadOnly = True

        Dim colTrjType As New DataGridTextBoxColumn
        With colTrjType
            .MappingName = dtTable.Columns(enmOSBillDtls.Trans_Type).ColumnName
            .HeaderText = "Trans Type"
            .Width = 90
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colParty As New DataGridTextBoxColumn
        With colParty
            .MappingName = dtTable.Columns(enmOSBillDtls.Party).ColumnName
            .HeaderText = "Party"
            .Width = 160
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colBillNo As New DataGridTextBoxColumn
        With colBillNo
            .MappingName = dtTable.Columns(enmOSBillDtls.BillNo).ColumnName
            .HeaderText = "Bill No"
            .Width = 70
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colBillDt As New DataGridTextBoxColumn
        With colBillDt
            .MappingName = dtTable.Columns(enmOSBillDtls.BillDt).ColumnName
            .HeaderText = "Bill Dt"
            .Width = 80
            .Alignment = HorizontalAlignment.Left
            .Format = "dd/MM/yyyy"
        End With

        Dim colDueDt As New DataGridTextBoxColumn
        With colDueDt
            .MappingName = dtTable.Columns(enmOSBillDtls.DueDt).ColumnName
            .HeaderText = "Due Dt"
            .Width = 80
            .Alignment = HorizontalAlignment.Left
            .Format = "dd/MM/yyyy"
        End With

        'Abhi 09-03-2018 BillDisc
        Dim colBillDisc As New DataGridTextBoxColumn
        With colBillDisc
            .MappingName = dtTable.Columns(enmOSBillDtls.BillDisc).ColumnName
            .HeaderText = "Bill Disc"
            .Width = 80
            .Alignment = HorizontalAlignment.Right
            .Format = "0.00"
        End With

        Dim colBillNet As New DataGridTextBoxColumn
        With colBillNet
            .MappingName = dtTable.Columns(enmOSBillDtls.BillNet).ColumnName
            .HeaderText = "Bill Amt"
            .Width = 90
            .Alignment = HorizontalAlignment.Right
            .Format = "0.00"
        End With

        Dim colBillBal As New DataGridTextBoxColumn
        With colBillBal
            .MappingName = dtTable.Columns(enmOSBillDtls.BillBal).ColumnName
            .HeaderText = "Balance Amt"
            .Width = 90
            .Alignment = HorizontalAlignment.Right
            .Format = "0.00"
        End With

        Dim colODDays As New DataGridTextBoxColumn
        With colODDays
            .MappingName = dtTable.Columns(enmOSBillDtls.ODDays).ColumnName
            .HeaderText = "O/D Days"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim colOSDays As New DataGridTextBoxColumn
        With colOSDays
            .MappingName = dtTable.Columns(enmOSBillDtls.OSDays).ColumnName
            .HeaderText = "O/s Days"
            .Width = 75
            .Alignment = HorizontalAlignment.Center
        End With

        Dim colBroker As New DataGridTextBoxColumn
        With colBroker
            .MappingName = dtTable.Columns(enmOSBillDtls.Broker).ColumnName
            .HeaderText = "Broker"
            .Width = 90
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colState As New DataGridTextBoxColumn
        With colState
            .MappingName = dtTable.Columns(enmOSBillDtls.State).ColumnName
            .HeaderText = "State"
            .Width = 100
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colCity As New DataGridTextBoxColumn
        With colCity
            .MappingName = dtTable.Columns(enmOSBillDtls.City).ColumnName
            .HeaderText = "City"
            .Width = 100
            .Alignment = HorizontalAlignment.Left
        End With

        tblStyle.GridColumnStyles.AddRange(New DataGridColumnStyle() {colTrjType, colParty, colBillNo, colBillDt, colDueDt, colBillDisc, colBillNet, colBillBal, colODDays, colOSDays, colBroker, colState, colCity})
        colParty = Nothing : colBroker = Nothing : colState = Nothing : colCity = Nothing : colBillNo = Nothing : colBillDt = Nothing
        colDueDt = Nothing : colODDays = Nothing : colOSDays = Nothing : colBillNet = Nothing : colBillBal = Nothing : colBillDisc = Nothing
        colTrjType = Nothing

        dtgOsBillDetails.TableStyles.Clear()
        dtgOsBillDetails.TableStyles.Add(tblStyle)
    End Sub

    Private Sub frmOSBillDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            Query = "Select STATE_KEY, STATE_NAME From State " _
                & " Where State_Key <> '' And Status = '1' Order By State_Name"
            Dim dtStateFrom As DataTable = Common.GetDataTableWithAll(Query)

            With cmbStateFrom
                .DataSource = dtStateFrom
                .DisplayMember = "STATE_NAME"
                .ValueMember = "STATE_KEY"
            End With

            Dim dtStateTo As DataTable = Common.GetDataTableWithAll(Query)
            With cmbStateTo
                .DataSource = dtStateTo
                .DisplayMember = "STATE_NAME"
                .ValueMember = "STATE_KEY"
            End With

            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' and LED_CAT ='B' AND LED_NAME <> '' ORDER BY LED_NAME"
            Dim dtBrokerFrom As DataTable = Common.GetDataTableWithAll(Query)
            blnLoading = True
            With cmbBrokerFrom
                .DataSource = dtBrokerFrom
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With

            Query = "SELECT LED_ID, LED_NAME FROM LEDGER" _
                & " WHERE STATUS = '1' AND LED_CAT IN ('B') AND LED_NAME <> '' ORDER BY LED_NAME"
            Dim dtBrokerTo As DataTable = Common.GetDataTableWithAll(Query)

            With cmbBrokerTo
                .DataSource = dtBrokerTo
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_ID"
            End With
            blnLoading = False

            If cmbStateFrom.Items.Count > 0 Then
                cmbStateFrom.SelectedIndex = 0
                Call cmbStateFrom_SelectionChangeCommitted(cmbStateFrom, Nothing)
            End If
            lblRecords.Text = ""

            If YNFlag = WithDate.Yes Then
                pnlDate.Visible = True
                dtpFrom.Value = AccFromDt : dtpTo.Value = AccToDt
            Else
                pnlDays.Visible = True
            End If

            Query = " Select LED_KEY, LED_NAME " _
                & " From Ledger Where Led_Cat = 'L' And Status = '1' " _
                & " And AccLGrp_Key In(Select AccLgrp_Key From AccLGrp Where AccGrp_Id = 13)" _
                & BranchFixFilter _
                & " Order By Led_Name"
            Dim dtSaleType As DataTable = Common.GetDataTableWithAll(Query)

            With cmbSaleType
                .DataSource = dtSaleType
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With

            Query = "Select Distinct LED_KEY, LED_NAME From Ledger " _
                      & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchFixId & "' And Led_Name <> '' " _
                      & " And Led_Cat in('S') Order By Led_Name"
            Dim dtSalePerson As DataTable = Common.GetDataTableWithAll(Query)

            With cmbSalesPerson
                .DataSource = dtSalePerson
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With

            '=====================================================
            Query = " Select ITEMGRP_KEY, ITEMGRP_NAME " _
               & " From ITEMGRP Where  ITEMGRP.Status = '1' " _
               & "And ITEMGRP.CoBr_Id = '" & SelBranchFixId & "' And ITEMGRP_NAME <> '' " _
              & " Order By ITEMGRP_NAME"
            Dim dtGroup As DataTable = Common.GetDataTableWithAll(Query)

            With cmbGroup
                .DataSource = dtGroup
                .DisplayMember = "ITEMGRP_NAME"
                .ValueMember = "ITEMGRP_KEY"
            End With



            Query = " Select brand_key, Brand_name " _
              & " From brand Where  brand.Status = '1' " _
              & "And brand.CoBr_Id = '" & SelBranchFixId & "' And brand_name <> '' " _
             & " Order By brand_name"
            Dim dtBrand As DataTable = Common.GetDataTableWithAll(Query)

            With cmbBrand
                .DataSource = dtBrand
                .DisplayMember = "Brand_name"
                .ValueMember = "Brand_key"
            End With

            If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForMalhar)) = "1" Then
                Label15.Visible = True
                cmbGroup.Visible = True
                Label16.Visible = True
                cmbBrand.Visible = True

            End If

            '========================================================
        Catch sqlEx As SqlException
            Call Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbPartyFrom_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartyFrom.SelectionChangeCommitted
        If cmbPartyFrom.SelectedIndex = -1 Then Exit Sub
        cmbPartyTo.SelectedIndex = cmbPartyFrom.SelectedIndex
    End Sub

    Private Sub DisplayBillDetails()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim strState As String = ""
            Dim strCity As String = ""
            Dim strParty As String = ""
            Dim strBroker As String = ""
            Dim strSalesPerson As String = ""
            Dim strSalesType As String = ""
            Dim strGroup As String = "" ''' Satyam 05082022
            Dim strBrand As String = ""  '''
            Dim shtOverDue As Short
            Dim shtOutstanding As Short

            If cmbStateFrom.SelectedIndex > 0 Then
                If cmbStateTo.SelectedIndex > 0 Then
                    strState = " And (State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "' And State.State_Name <= '" & ReplaceApostrophe(cmbStateTo.Text) & "')"
                Else
                    strState = " And State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "'"
                End If
            End If

            If cmbCityFrom.SelectedIndex > 0 Then
                If cmbCityTo.SelectedIndex > 0 Then
                    strCity = " And (Station.Stn_Name >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "' And Station.Stn_Name <= '" & ReplaceApostrophe(cmbCityTo.Text) & "')"
                Else
                    strCity = " And Station.Stn_Name >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "'"
                End If
            End If

            If cmbPartyFrom.SelectedIndex > 0 Then
                If cmbPartyTo.SelectedIndex > 0 Then
                    strParty = " And (Party.LED_NAME >= '" & ReplaceApostrophe(cmbPartyFrom.Text) & "' And Party.LED_NAME <= '" & ReplaceApostrophe(cmbPartyTo.Text) & "')"
                Else
                    strParty = " And Party.LED_NAME >= '" & ReplaceApostrophe(cmbPartyFrom.Text) & "'"
                End If
            End If

            If cmbBrokerFrom.SelectedIndex > 0 Then
                If cmbBrokerTo.SelectedIndex > 0 Then
                    strBroker = " And (Broker.LED_NAME >= '" & ReplaceApostrophe(cmbBrokerFrom.Text) & "' And Broker.LED_NAME <= '" & ReplaceApostrophe(cmbBrokerTo.Text) & "')"
                Else
                    strBroker = " And Broker.LED_NAME >= '" & ReplaceApostrophe(cmbBrokerFrom.Text) & "'"
                End If
            End If

            If cmbSalesPerson.SelectedIndex > 0 Then
                strSalesPerson = " And SalesPerson.LED_NAME = '" & ReplaceApostrophe(cmbSalesPerson.Text) & "'"
            End If

            If cmbSaleType.SelectedIndex > 0 Then
                strSalesType = " And SaleType.LED_NAME = '" & ReplaceApostrophe(cmbSaleType.Text) & "'"
            End If
            '============================================================
            'Satyam 05082022
            If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForMalhar)) = "1" Then
                If cmbGroup.SelectedIndex > 0 Then
                    strGroup = " And itemgroup.itemgrp_name = '" & ReplaceApostrophe(cmbGroup.Text) & "'"
                End If

                If cmbBrand.SelectedIndex > 0 Then
                    strBrand = " And brand1.brand_name = '" & ReplaceApostrophe(cmbBrand.Text) & "'"
                End If
            End If

            '====================================================================
            shtOverDue = Val(txtODDays.Text) : shtOutstanding = Val(txtOsDays.Text)

            Dim DateFltr As String = ""
            Dim DaysFltr As String = ""

            If YNFlag = WithDate.Yes Then
                DateFltr = " And Bill.Doc_Dt >= '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "'" _
                    & " And Bill.Doc_Dt <= '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
            Else
                DaysFltr = " Having DateDiff(Day, Due_Dt, GetDate()) >= " & shtOverDue & " And DateDiff(Day, Doc_Dt, GetDate()) >= " & shtOutstanding
            End If

            'Query = "Select Trj_Type, Party.Led_Name as Party_Name, Doc_No, Doc_Dt, Due_Dt, Cast(Sum(Doc_Amt) As Varchar) + Case When Amt_Flg = 'C' Then ' Cr' Else ' Dr' End Bill_Net, " _
            '    & " Cast(Sum(Bal_Amt) As Varchar) + Case When Amt_Flg = 'C' Then ' Cr' Else ' Dr' End Bill_Bal, DateDiff(Day, Due_Dt, GetDate()) OD_Days, " _
            '    & " DateDiff(Day, Doc_Dt, GetDate()) Os_Days, Broker.Led_Name as Broker_Name, State_Name, Stn_Name  " _
            '    & " From View_OsBills as Bill  " _
            '    & " Inner Join Ledger Party On Party.Led_Key = Bill.Party_Key  " _
            '    & " Inner Join Ledger Broker On Bill.Broker_Key = Broker.Led_Key  " _
            '    & " Inner Join Ledger SalesPerson On Bill.SalesPerson_Key = SalesPerson.Led_Key  " _
            '    & " Inner Join Ledger SaleType On Bill.SaleType = SaleType.Led_Key  " _
            '    & " Inner Join Station On Party.OStn_Key = Station.Stn_Key  " _
            '    & " Inner Join State On Station.State_Key = State.State_Key  " _
            '    & " Where Bill.CoBr_Id = '" & SelBranchId & "' And Bill.FcYr_Id = '" & SelYearId & "'" _
            '    & strState & strCity & strParty & strBroker & DateFltr & strSalesPerson & strSalesType _
            '    & " Group By Trj_Type, Party.Led_Name, Amt_Flg, Broker.Led_Name, State_Name, Stn_Name, Doc_No, Doc_Dt, Due_Dt, Amt_Flg " _
            '    & DaysFltr _
            '    & " Order By Party.Led_Name, Doc_Dt, Broker.Led_Name, State_Name, Stn_Name "
            If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForMalhar)) = "1" Then
                Query = "Select Trj_Type, Party.Led_Name as Party_Name, Doc_No, Doc_Dt, Due_Dt, BillDisc_Perc, Cast(Sum(Doc_Amt) As Varchar) + Case When Amt_Flg = 'C' Then ' Cr' Else ' Dr' End Bill_Net, " _
                   & " Cast(Sum(Bal_Amt) As Varchar) + Case When Amt_Flg = 'C' Then ' Cr' Else ' Dr' End Bill_Bal, DateDiff(Day, Due_Dt, GetDate()) OD_Days, " _
                   & " DateDiff(Day, Doc_Dt, GetDate()) Os_Days, Broker.Led_Name as Broker_Name, State_Name, Stn_Name " _
                   & " From View_OsBills as Bill  " _
                   & " Inner Join Ledger Party On Party.Led_Key = Bill.Party_Key  " _
                   & " Inner Join Ledger Broker On Bill.Broker_Key = Broker.Led_Key  " _
                   & " Inner Join Ledger SalesPerson On Bill.SalesPerson_Key = SalesPerson.Led_Key  " _
                   & " Inner Join Ledger SaleType On Bill.SaleType = SaleType.Led_Key  " _
                    & " left join itemgrp itemgroup on bill.itemgrp_key=itemgroup.itemgrp_key " _
                    & " left join brand brand1 on bill.brand_key=brand1.brand_key" _
                    & " Inner Join Station On Party.OStn_Key = Station.Stn_Key  " _
                   & " Inner Join State On Station.State_Key = State.State_Key  " _
                   & " Where Bill.CoBr_Id = '" & SelBranchId & "'" _
                   & strState & strCity & strParty & strBroker & DateFltr & strSalesPerson & strSalesType & strGroup & strBrand _
                   & " Group By Trj_Type, Party.Led_Name, Amt_Flg, Broker.Led_Name, State_Name, Stn_Name, Doc_No, Doc_Dt, Due_Dt, Amt_Flg, BillDisc_Perc " _
                   & DaysFltr _
                   & " Order By Party.Led_Name, Doc_Dt, Broker.Led_Name, State_Name, Stn_Name "
            Else
                Query = "Select Trj_Type, Party.Led_Name as Party_Name, Doc_No, Doc_Dt, Due_Dt, BillDisc_Perc, Cast(Sum(Doc_Amt) As Varchar) + Case When Amt_Flg = 'C' Then ' Cr' Else ' Dr' End Bill_Net, " _
                 & " Cast(Sum(Bal_Amt) As Varchar) + Case When Amt_Flg = 'C' Then ' Cr' Else ' Dr' End Bill_Bal, DateDiff(Day, Due_Dt, GetDate()) OD_Days, " _
                 & " DateDiff(Day, Doc_Dt, GetDate()) Os_Days, Broker.Led_Name as Broker_Name, State_Name, Stn_Name " _
                 & " From View_OsBills as Bill  " _
                 & " Inner Join Ledger Party On Party.Led_Key = Bill.Party_Key  " _
                 & " Inner Join Ledger Broker On Bill.Broker_Key = Broker.Led_Key  " _
                 & " Inner Join Ledger SalesPerson On Bill.SalesPerson_Key = SalesPerson.Led_Key  " _
                 & " Inner Join Ledger SaleType On Bill.SaleType = SaleType.Led_Key  " _
                 & " Inner Join Station On Party.OStn_Key = Station.Stn_Key  " _
                 & " Inner Join State On Station.State_Key = State.State_Key  " _
                 & " Where Bill.CoBr_Id = '" & SelBranchId & "'" _
                 & strState & strCity & strParty & strBroker & DateFltr & strSalesPerson & strSalesType _
                 & " Group By Trj_Type, Party.Led_Name, Amt_Flg, Broker.Led_Name, State_Name, Stn_Name, Doc_No, Doc_Dt, Due_Dt, Amt_Flg, BillDisc_Perc " _
                 & DaysFltr _
                 & " Order By Party.Led_Name, Doc_Dt, Broker.Led_Name, State_Name, Stn_Name "
            End If
            '" Having DateDiff(Day, Due_Dt, GetDate()) >= " & shtOverDue & " And DateDiff(Day, Doc_Dt, GetDate()) >= " & shtOutstanding _
            Dim dtDetails As DataTable = Common.GetDataTable(Query)
            Dim intDetails As Integer = dtDetails.Rows.Count

            dtgOsBillDetails.DataSource = dtDetails
            dtDetails.DefaultView.AllowNew = False
            dtDetails.DefaultView.AllowDelete = False
            Call FormatDetailHeaders(dtDetails)

            Dim dblCredit, dblDebit, dblBill, dblOs As Double
            Dim strBill, strOs As String

            DateFltr = "" : DaysFltr = ""
            If YNFlag = WithDate.Yes Then
                DateFltr = " And Bill.Doc_Dt >= '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "'" _
                    & " And Bill.Doc_Dt <= '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
            Else
                DaysFltr = " And DateDiff(Day, Due_Dt, GetDate()) >= " & shtOverDue _
                    & " And DateDiff(Day, Doc_Dt, GetDate()) >= " & shtOutstanding
            End If

            'Query = " Select IsNull(Sum(Doc_Amt), 0) From View_OsBills Bill " _
            '    & " Inner Join Ledger Party On Party.Led_Key = Bill.Party_Key " _
            '    & " Inner Join Ledger Broker On Bill.Broker_Key = Broker.Led_Key " _
            '    & " Inner Join Ledger SalesPerson On Bill.SalesPerson_Key = SalesPerson.Led_Key  " _
            '    & " Inner Join Ledger SaleType On Bill.SaleType = SaleType.Led_Key  " _
            '    & " Inner Join Station On Party.OStn_Key = Station.Stn_Key " _
            '    & " Inner Join State On Station.State_Key = State.State_Key " _
            '    & " Where Bill.CoBr_Id = '" & SelBranchId & "' And Bill.FcYr_Id = '" & SelYearId & "'" _
            '    & DaysFltr _
            '    & strState & strCity & strParty & strBroker & DateFltr & strSalesPerson & strSalesType
            'Dim dblNetAmt As Double = CType(Common.ExecuteScalar(Query), Double)


            'Query = "Select IsNull(Sum(Bal_Amt), 0) From View_OsBills Bill " _
            '    & " Inner Join Ledger Party On Party.Led_Key = Bill.Party_Key " _
            '    & " Inner Join Ledger Broker On Bill.Broker_Key = Broker.Led_Key " _
            '    & " Inner Join Ledger SalesPerson On Bill.SalesPerson_Key = SalesPerson.Led_Key  " _
            '    & " Inner Join Ledger SaleType On Bill.SaleType = SaleType.Led_Key  " _
            '    & " Inner Join Station On Party.OStn_Key = Station.Stn_Key " _
            '    & " Inner Join State On Station.State_Key = State.State_Key " _
            '    & " Where Bill.CoBr_Id = '" & SelBranchId & "' And Bill.FcYr_Id = '" & SelYearId & "'" _
            '    & DaysFltr _
            '    & strState & strCity & strParty & strBroker & DateFltr & strSalesPerson & strSalesType
            'Dim dblBalAmt As Double = CType(Common.ExecuteScalar(Query), Double)

            Query = " Select IsNull(Sum(Doc_Amt), 0) From View_OsBills Bill " _
               & " Inner Join Ledger Party On Party.Led_Key = Bill.Party_Key " _
               & " Inner Join Ledger Broker On Bill.Broker_Key = Broker.Led_Key " _
               & " Inner Join Ledger SalesPerson On Bill.SalesPerson_Key = SalesPerson.Led_Key  " _
               & " Inner Join Ledger SaleType On Bill.SaleType = SaleType.Led_Key  " _
               & " Inner Join Station On Party.OStn_Key = Station.Stn_Key " _
               & " Inner Join State On Station.State_Key = State.State_Key " _
               & " Where Bill.CoBr_Id = '" & SelBranchId & "' " _
               & DaysFltr _
               & strState & strCity & strParty & strBroker & DateFltr & strSalesPerson & strSalesType
            Dim dblNetAmt As Double = CType(Common.ExecuteScalar(Query), Double)


            Query = "Select IsNull(Sum(Bal_Amt), 0) From View_OsBills Bill " _
                & " Inner Join Ledger Party On Party.Led_Key = Bill.Party_Key " _
                & " Inner Join Ledger Broker On Bill.Broker_Key = Broker.Led_Key " _
                & " Inner Join Ledger SalesPerson On Bill.SalesPerson_Key = SalesPerson.Led_Key  " _
                & " Inner Join Ledger SaleType On Bill.SaleType = SaleType.Led_Key  " _
                & " Inner Join Station On Party.OStn_Key = Station.Stn_Key " _
                & " Inner Join State On Station.State_Key = State.State_Key " _
                & " Where Bill.CoBr_Id = '" & SelBranchId & "' " _
                & DaysFltr _
                & strState & strCity & strParty & strBroker & DateFltr & strSalesPerson & strSalesType
            Dim dblBalAmt As Double = CType(Common.ExecuteScalar(Query), Double)

            lblTotalBillAmt.Text = Format$(dblNetAmt, "0.00")
            lblTotalOsAmt.Text = Format$(dblBalAmt, "0.00")

            lblRecords.Text = intDetails & " record(s) found"

        Catch sqlEx As SqlException
            Call Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbStateFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStateFrom.SelectionChangeCommitted
        If cmbStateFrom.SelectedIndex = -1 Or cmbStateTo.SelectedIndex = -1 Then Exit Sub
        cmbStateTo.SelectedIndex = cmbStateFrom.SelectedIndex
        Call DisplayCity()
    End Sub

    Private Sub DisplayCity()
        Dim strFilter As String = ""

        Try
            If cmbStateFrom.SelectedIndex > 0 Then
                If cmbStateTo.SelectedIndex > 0 Then
                    strFilter = " And (State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "' And State.State_Name <= '" & ReplaceApostrophe(cmbStateTo.Text) & "')"
                Else
                    strFilter = " And State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "'"
                End If
            End If

            Me.Cursor = Cursors.WaitCursor

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

            If cmbCityFrom.Items.Count > 0 Then
                cmbCityFrom.SelectedIndex = 0
                Call cmbCityFrom_SelectionChangeCommitted(cmbCityFrom, Nothing)
            End If

        Catch SqlEx As Exception
            Call Common.LogAndDisplayException(SqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DisplayParty()
        Dim strFilter As String = ""

        Try
            If cmbStateFrom.SelectedIndex > 0 Then
                If cmbStateTo.SelectedIndex > 0 Then
                    strFilter = " And (State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "' And State.State_Name <= '" & ReplaceApostrophe(cmbStateTo.Text) & "')"
                Else
                    strFilter = " And State.State_Name >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "'"
                End If
            End If

            If cmbCityFrom.SelectedIndex > 0 Then
                If cmbCityTo.SelectedIndex > 0 Then
                    strFilter &= " And (Station.Stn_Name >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "' And Station.Stn_Name <= '" & ReplaceApostrophe(cmbCityTo.Text) & "')"
                Else
                    strFilter &= " And Station.Stn_Name >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "'"
                End If
            End If

            Me.Cursor = Cursors.WaitCursor

            Query = "Select Distinct LED_KEY, LED_NAME " _
                & " From Ledger Left Join Station On Ledger.OStn_Key = Station.Stn_Key " _
                & " Left Join State On State.State_Key = Station.State_Key " _
                & " Where Ledger.Status = '1' And Ledger.CoBr_Id = '" & SelBranchFixId & "' And Led_Name <> '' " & strFilter _
                & " Order By Led_Name"

            Dim dtPartyFrom As DataTable = Common.GetDataTableWithAll(Query)
            With cmbPartyFrom
                .DataSource = dtPartyFrom
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With

            Dim dtPartyTo As DataTable = Common.GetDataTableWithAll(Query)
            With cmbPartyTo
                .DataSource = dtPartyTo
                .DisplayMember = "LED_NAME"
                .ValueMember = "LED_KEY"
            End With

            If cmbPartyFrom.Items.Count > 0 Then cmbPartyFrom.SelectedIndex = 0

        Catch SqlEx As Exception
            Call Common.LogAndDisplayException(SqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbCityFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCityFrom.SelectionChangeCommitted
        If cmbCityFrom.SelectedIndex = -1 Then Exit Sub
        cmbCityTo.SelectedIndex = cmbCityFrom.SelectedIndex
        Call DisplayParty()
    End Sub

    Private Sub cmbBrokerFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBrokerFrom.SelectionChangeCommitted
        If cmbBrokerFrom.SelectedIndex = -1 Then Exit Sub
        cmbBrokerTo.SelectedIndex = cmbBrokerFrom.SelectedIndex
    End Sub

    'Private Sub cmbStateFrom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStateFrom.Validated
    '    cmbStateFrom.SelectedIndex = GetSrchValueIndex(cmbStateFrom, cmbStateFrom.Text)
    '    cmbStateTo.SelectedIndex = cmbStateFrom.SelectedIndex
    'End Sub

    'Private Sub cmbStateTo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStateTo.Validated
    '    cmbStateTo.SelectedIndex = GetSrchValueIndex(cmbStateTo, cmbStateTo.Text)
    'End Sub

    'Private Sub cmbCityFrom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCityFrom.Validated
    '    cmbCityFrom.SelectedIndex = GetSrchValueIndex(cmbCityFrom, cmbCityFrom.Text)
    '    cmbCityTo.SelectedIndex = cmbCityFrom.SelectedIndex
    'End Sub

    'Private Sub cmbCityTo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCityTo.Validated
    '    cmbCityTo.SelectedIndex = GetSrchValueIndex(cmbCityTo, cmbCityTo.Text)
    'End Sub

    'Private Sub cmbPartyFrom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartyFrom.Validated
    '    cmbPartyFrom.SelectedIndex = GetSrchValueIndex(cmbPartyFrom, cmbPartyFrom.Text)
    '    cmbPartyTo.SelectedIndex = cmbPartyFrom.SelectedIndex
    'End Sub

    'Private Sub cmbPartyTo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartyTo.Validated
    '    cmbPartyTo.SelectedIndex = GetSrchValueIndex(cmbPartyTo, cmbPartyTo.Text)
    'End Sub

    'Private Sub cmbBrokerFrom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBrokerFrom.Validated
    '    cmbBrokerFrom.SelectedIndex = GetSrchValueIndex(cmbBrokerFrom, cmbBrokerFrom.Text)
    '    cmbBrokerTo.SelectedIndex = cmbBrokerFrom.SelectedIndex
    'End Sub

    'Private Sub cmbBrokerTo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBrokerTo.Validated
    '    cmbBrokerTo.SelectedIndex = GetSrchValueIndex(cmbBrokerTo, cmbBrokerTo.Text)
    'End Sub

    Private Sub cmbStateFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbStateFrom.KeyDown, cmbStateTo.KeyDown, cmbCityFrom.KeyDown, cmbCityTo.KeyDown, cmbPartyFrom.KeyDown, cmbPartyTo.KeyDown, cmbBrokerFrom.KeyDown, cmbBrokerTo.KeyDown, txtODDays.KeyDown, txtOsDays.KeyDown, dtpFrom.KeyDownEvent
        Call MoveToNextControl(e)
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Call DisplayBillDetails()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call PrintReport()
    End Sub

    Private Sub PrintReport()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim strState As String = ""
            Dim strCity As String = ""
            Dim strParty As String = ""
            Dim strBroker As String = ""
            Dim strSalesPerson As String = ""
            Dim strSalesType As String = ""
            Dim strGroup As String = ""
            Dim strBrand As String = ""
            Dim shtOverDue As Short
            Dim shtOutstanding As Short

            If cmbStateFrom.SelectedIndex > 0 Then
                If cmbStateTo.SelectedIndex > 0 Then
                    strState = " And {State.State_Name} >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "' And {State.State_Name} <= '" & ReplaceApostrophe(cmbStateTo.Text) & "'"
                Else
                    strState = " And {State.State_Name} >= '" & ReplaceApostrophe(cmbStateFrom.Text) & "'"
                End If
            End If

            If cmbCityFrom.SelectedIndex > 0 Then
                If cmbCityTo.SelectedIndex > 0 Then
                    strCity = " And {City.Stn_Name} >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "' And {City.Stn_Name} <= '" & ReplaceApostrophe(cmbCityTo.Text) & "'"
                Else
                    strCity = " And {City.Stn_Name} >= '" & ReplaceApostrophe(cmbCityFrom.Text) & "'"
                End If
            End If

            If cmbPartyFrom.SelectedIndex > 0 Then
                If cmbPartyTo.SelectedIndex > 0 Then
                    strParty = " And {Party.LED_NAME} >= '" & ReplaceApostrophe(cmbPartyFrom.Text) & "' And {Party.LED_NAME} <= '" & ReplaceApostrophe(cmbPartyTo.Text) & "'"
                Else
                    strParty = " And {Party.LED_NAME} >= '" & ReplaceApostrophe(cmbPartyFrom.Text) & "'"
                End If
            End If

            If cmbBrokerFrom.SelectedIndex > 0 Then
                If cmbBrokerFrom.SelectedIndex > 0 Then
                    strBroker = " And {Broker.LED_NAME} >= '" & ReplaceApostrophe(cmbBrokerFrom.Text) & "' And {Broker.LED_NAME} <= '" & ReplaceApostrophe(cmbBrokerTo.Text) & "'"
                Else
                    strBroker = " And {Broker.LED_NAME} >= '" & ReplaceApostrophe(cmbBrokerFrom.Text) & "'"
                End If
            End If

            If cmbSalesPerson.SelectedIndex > 0 Then
                strSalesPerson = " And {SalesPerson.LED_NAME} = '" & ReplaceApostrophe(cmbSalesPerson.Text) & "'"
            End If

            If cmbSaleType.SelectedIndex > 0 Then
                strSalesType = " And {SaleType.LED_NAME} = '" & ReplaceApostrophe(cmbSaleType.Text) & "'"
            End If

            '============================================================
            'Satyam 05082022
            If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForMalhar)) = "1" Then
                If cmbGroup.SelectedIndex > 0 Then
                    strGroup = " And {View_OsBills.itemgrp_key} = '" & ReplaceApostrophe(cmbGroup.SelectedValue) & "'"
                End If

                If cmbBrand.SelectedIndex > 0 Then
                    strBrand = " And {View_OsBills.brand_key} = '" & ReplaceApostrophe(cmbBrand.SelectedValue) & "'"
                End If
            End If

            '====================================================================



            Dim formula As New Hashtable

            ReportParameters.rptFile = ReportPath & "\Accounts\OsBills.rpt"
            If YNFlag = WithDate.Yes Then
                If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForMalhar)) = "1" Then
                    ReportParameters.rptFilter = "{View_OsBills.CoBr_Id} = '" & SelBranchId & "' " _
                    & " And {View_OsBills.Doc_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") " _
                    & " And {View_OsBills.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" _
                    & strState & strCity & strParty & strBroker & strSalesPerson & strSalesType & strGroup & strBrand
                Else
                    ReportParameters.rptFilter = "{View_OsBills.CoBr_Id} = '" & SelBranchId & "' " _
                   & " And {View_OsBills.Doc_Dt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") " _
                   & " And {View_OsBills.Doc_Dt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")" _
                   & strState & strCity & strParty & strBroker & strSalesPerson & strSalesType

                End If


            Else
                If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForMalhar)) = "1" Then
                    ReportParameters.rptFilter = "{View_OsBills.CoBr_Id} = '" & SelBranchId & "' And {View_OsBills.FcYr_Id} = '" & SelYearId & "' And {@OD_Days} >= " & Val(txtODDays.Text) & " And {@OS_Days} >= " & Val(txtOsDays.Text) & strState & strCity & strParty & strBroker & strSalesPerson & strSalesType & strGroup & strBrand
                Else
                    ReportParameters.rptFilter = "{View_OsBills.CoBr_Id} = '" & SelBranchId & "' And {View_OsBills.FcYr_Id} = '" & SelYearId & "' And {@OD_Days} >= " & Val(txtODDays.Text) & " And {@OS_Days} >= " & Val(txtOsDays.Text) & strState & strCity & strParty & strBroker & strSalesPerson & strSalesType
                End If

            End If
                formula.Add("OsDays_Head#S", txtOsDays.Text)
                formula.Add("ODDays_Head#S", txtODDays.Text)
                ReportParameters.rptCaption = lblFormCaption.Text

                Dim frmrpt As New frmViewReports
                frmrpt.Show()

        Catch sqlEx As SqlException
            Call Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GetTotal(ByRef dblBillAmt As Double, ByRef dblOsAmt As Double)
        Dim dtTable As DataTable = CType(dtgOsBillDetails.DataSource, DataTable)

        dblBillAmt = IIf(IsDBNull(dtTable.Compute("SUM(" & dtTable.Columns(enmOSBillDtls.BillNet).ColumnName & ")", "")), 0, dtTable.Compute("SUM(" & dtTable.Columns(enmOSBillDtls.BillNet).ColumnName & ")", ""))
        dblOsAmt = IIf(IsDBNull(dtTable.Compute("SUM(" & dtTable.Columns(enmOSBillDtls.BillBal).ColumnName & ")", "")), 0, dtTable.Compute("SUM(" & dtTable.Columns(enmOSBillDtls.BillBal).ColumnName & ")", ""))
    End Sub
End Class