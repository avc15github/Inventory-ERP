Imports System.Data.SqlClient

Public Class frmManualAdjust
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal StrPartyK1 As String, ByVal strPartyNm1 As String, ByVal StrTrjType1 As String, ByVal intDocID1 As Integer, ByVal blnOnlyOS1 As Boolean, ByVal blnFlag1 As Boolean, ByVal strAdjust1 As String, ByVal intDocRefID1 As Integer, ByVal blnReceivable1 As Boolean)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        StrPartyK = StrPartyK1
        strPartyNm = strPartyNm1
        StrTrjType = StrTrjType1
        intDocID = intDocID1
        blnOnlyOS = blnOnlyOS1
        blnFlag = blnFlag1
        strAdjust = strAdjust1
        intDocRefID = intDocRefID1
        blnReceivable = blnReceivable1
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
    Friend WithEvents lblAdjAmt As System.Windows.Forms.Label
    Friend WithEvents lblAmtToBeAdj As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFlag As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSearchColumn As System.Windows.Forms.Label
    Friend WithEvents txtVchrNo As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents dtpDocDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelAdj As System.Windows.Forms.Button
    Friend WithEvents lblBalAmt As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblNarration = New System.Windows.Forms.Label
        Me.lblFlag = New System.Windows.Forms.Label
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.dtpDocDt = New System.Windows.Forms.DateTimePicker
        Me.Label45 = New System.Windows.Forms.Label
        Me.lblAmtToBeAdj = New System.Windows.Forms.Label
        Me.txtRefNo = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.txtVchrNo = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.lblAdjAmt = New System.Windows.Forms.Label
        Me.lblBalAmt = New System.Windows.Forms.Label
        Me.lblSearchColumn = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.dtgPartyAc = New System.Windows.Forms.DataGrid
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.btnDelAdj = New System.Windows.Forms.Button
        Me.grpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgPartyAc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.btnDelAdj)
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.btnSave)
        Me.grpMain.Controls.Add(Me.dtgPartyAc)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Location = New System.Drawing.Point(0, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(1077, 607)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblNarration)
        Me.Panel1.Controls.Add(Me.lblFlag)
        Me.Panel1.Controls.Add(Me.txtNarration)
        Me.Panel1.Controls.Add(Me.dtpDocDt)
        Me.Panel1.Controls.Add(Me.Label45)
        Me.Panel1.Controls.Add(Me.lblAmtToBeAdj)
        Me.Panel1.Controls.Add(Me.txtRefNo)
        Me.Panel1.Controls.Add(Me.Label52)
        Me.Panel1.Controls.Add(Me.txtVchrNo)
        Me.Panel1.Controls.Add(Me.Label53)
        Me.Panel1.Controls.Add(Me.lblAdjAmt)
        Me.Panel1.Controls.Add(Me.lblBalAmt)
        Me.Panel1.Controls.Add(Me.lblSearchColumn)
        Me.Panel1.Location = New System.Drawing.Point(7, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1063, 94)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(614, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 14)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Balance Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(614, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Adjusted Amount"
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.BackColor = System.Drawing.Color.Transparent
        Me.lblNarration.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNarration.Location = New System.Drawing.Point(12, 43)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(58, 14)
        Me.lblNarration.TabIndex = 6
        Me.lblNarration.Text = "Narration"
        '
        'lblFlag
        '
        Me.lblFlag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFlag.BackColor = System.Drawing.SystemColors.Info
        Me.lblFlag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlag.ForeColor = System.Drawing.Color.Blue
        Me.lblFlag.Location = New System.Drawing.Point(881, 8)
        Me.lblFlag.Name = "lblFlag"
        Me.lblFlag.Size = New System.Drawing.Size(22, 20)
        Me.lblFlag.TabIndex = 10
        Me.lblFlag.Text = "Dr"
        Me.lblFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(89, 40)
        Me.txtNarration.MaxLength = 500
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(504, 47)
        Me.txtNarration.TabIndex = 7
        Me.txtNarration.Tag = "Narration"
        '
        'dtpDocDt
        '
        Me.dtpDocDt.CustomFormat = "dd/MM/yyyy"
        Me.dtpDocDt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDocDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDocDt.Location = New System.Drawing.Point(267, 7)
        Me.dtpDocDt.Name = "dtpDocDt"
        Me.dtpDocDt.Size = New System.Drawing.Size(85, 22)
        Me.dtpDocDt.TabIndex = 3
        Me.dtpDocDt.Tag = "Doc Date"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(221, 11)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(33, 14)
        Me.Label45.TabIndex = 2
        Me.Label45.Text = "Date"
        '
        'lblAmtToBeAdj
        '
        Me.lblAmtToBeAdj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAmtToBeAdj.BackColor = System.Drawing.SystemColors.Info
        Me.lblAmtToBeAdj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmtToBeAdj.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmtToBeAdj.ForeColor = System.Drawing.Color.Blue
        Me.lblAmtToBeAdj.Location = New System.Drawing.Point(763, 8)
        Me.lblAmtToBeAdj.Name = "lblAmtToBeAdj"
        Me.lblAmtToBeAdj.Size = New System.Drawing.Size(112, 20)
        Me.lblAmtToBeAdj.TabIndex = 9
        Me.lblAmtToBeAdj.Text = "0"
        Me.lblAmtToBeAdj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRefNo
        '
        Me.txtRefNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(461, 7)
        Me.txtRefNo.MaxLength = 15
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(129, 22)
        Me.txtRefNo.TabIndex = 5
        Me.txtRefNo.Tag = "Doc Ref No"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(399, 11)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(43, 14)
        Me.Label52.TabIndex = 4
        Me.Label52.Text = "Ref No"
        '
        'txtVchrNo
        '
        Me.txtVchrNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVchrNo.Location = New System.Drawing.Point(89, 7)
        Me.txtVchrNo.MaxLength = 15
        Me.txtVchrNo.Name = "txtVchrNo"
        Me.txtVchrNo.Size = New System.Drawing.Size(102, 22)
        Me.txtVchrNo.TabIndex = 1
        Me.txtVchrNo.Tag = "Voucher No"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(12, 11)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(68, 14)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Voucher No"
        '
        'lblAdjAmt
        '
        Me.lblAdjAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAdjAmt.BackColor = System.Drawing.SystemColors.Info
        Me.lblAdjAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdjAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblAdjAmt.Location = New System.Drawing.Point(763, 34)
        Me.lblAdjAmt.Name = "lblAdjAmt"
        Me.lblAdjAmt.Size = New System.Drawing.Size(112, 20)
        Me.lblAdjAmt.TabIndex = 12
        Me.lblAdjAmt.Tag = "Adjusted Amount"
        Me.lblAdjAmt.Text = "0"
        Me.lblAdjAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBalAmt
        '
        Me.lblBalAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBalAmt.BackColor = System.Drawing.SystemColors.Info
        Me.lblBalAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalAmt.ForeColor = System.Drawing.Color.Blue
        Me.lblBalAmt.Location = New System.Drawing.Point(763, 61)
        Me.lblBalAmt.Name = "lblBalAmt"
        Me.lblBalAmt.Size = New System.Drawing.Size(112, 20)
        Me.lblBalAmt.TabIndex = 14
        Me.lblBalAmt.Tag = "Balance Amt"
        Me.lblBalAmt.Text = "0"
        Me.lblBalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSearchColumn
        '
        Me.lblSearchColumn.AutoSize = True
        Me.lblSearchColumn.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchColumn.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchColumn.Location = New System.Drawing.Point(614, 11)
        Me.lblSearchColumn.Name = "lblSearchColumn"
        Me.lblSearchColumn.Size = New System.Drawing.Size(132, 14)
        Me.lblSearchColumn.TabIndex = 8
        Me.lblSearchColumn.Text = "Amount To Be Adjusted"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(7, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(593, 25)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Adjust Documents"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnSave.Location = New System.Drawing.Point(921, 577)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 24)
        Me.btnSave.TabIndex = 121
        Me.btnSave.Text = "Save"
        '
        'dtgPartyAc
        '
        Me.dtgPartyAc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgPartyAc.CaptionFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyAc.CaptionText = "List of Documents to Adjust"
        Me.dtgPartyAc.DataMember = ""
        Me.dtgPartyAc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyAc.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPartyAc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgPartyAc.Location = New System.Drawing.Point(7, 164)
        Me.dtgPartyAc.Name = "dtgPartyAc"
        Me.dtgPartyAc.Size = New System.Drawing.Size(1066, 407)
        Me.dtgPartyAc.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnExit.Location = New System.Drawing.Point(1010, 577)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 24)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
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
        Me.lblFormCaption.Text = "Manual Matching"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelAdj
        '
        Me.btnDelAdj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelAdj.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelAdj.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelAdj.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnDelAdj.Location = New System.Drawing.Point(7, 577)
        Me.btnDelAdj.Name = "btnDelAdj"
        Me.btnDelAdj.Size = New System.Drawing.Size(88, 26)
        Me.btnDelAdj.TabIndex = 123
        Me.btnDelAdj.Text = "&Delete Adj"
        '
        'frmManualAdjust
        '
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1079, 612)
        Me.Controls.Add(Me.grpMain)
        Me.MaximizeBox = False
        Me.Name = "frmManualAdjust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjust Documents"
        Me.grpMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgPartyAc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim cmdCommand As SqlCommand
    Dim sdaAdapter As SqlDataAdapter
    Dim strFilter As String
    Dim StrPartyK As String
    Dim strPartyNm As String
    Dim StrTrjType As String
    Dim strAdjust As String
    Dim intDocID As Integer
    Dim intDocRefID As Integer
    Dim blnOnlyOS As Boolean
    Dim blnFlag As Boolean
    Dim blnReceivable As Boolean
    Dim DtSeries As DataTable
    Dim dtTemp As DataTable
    Dim WithEvents dtGrdRef As DataTable
    Dim WithEvents Details As DataTable
    Dim SMSFields As String = ""
    Dim SMSGrpFields As String = ""
    Dim TotDebit As Double = 0
    Dim TotCredit As Double = 0
    Dim TotClosing As Double = 0

    Enum GridColumns
        AgstAmt
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
        Broker_Key
        Flag
        OpDocRef_id
        Doc_Id
        Party_Key
        OldAgstAmt
        NewOpDocRef_id
        OnAcOpDocRef_id
    End Enum

    Private Sub frmCustAcBillWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If blnFlag = True Then
            DisplayFill()
        End If
    End Sub

    Private Sub DisplayFill()
        Dim strLedType As String = ""
        Dim strOnlyOS As String = ""
        Dim strParty As String = ""
        Dim blnOpRec, blnOpPay As Boolean
        Dim DtAdjust As New DataTable

        If StrTrjType = "Opening" Then
            Query = " Select Doc_No, RefNo, Doc_Dt, TotAmt, AmtFlag, AdjAmt, BalAmt, Narration From View_ManualMatching " _
                & " Where Party_key='" & StrPartyK & "' And Doc_Id= " & intDocID & " And Trj_Type='" & StrTrjType & "' And DocRef_Id=" & intDocRefID
        Else
            Query = " Select Doc_No, RefNo, Doc_Dt, TotAmt, AmtFlag, AdjAmt, BalAmt, Narration From View_ManualMatching " _
                & " Where Party_key='" & StrPartyK & "' And Doc_Id= " & intDocID & " And Trj_Type='" & StrTrjType & "'"
        End If
        DtAdjust = Common.GetDataTable(Query)

        If DtAdjust.Rows.Count > 0 Then
            txtVchrNo.Text = DtAdjust.Rows(0).Item("Doc_No")
            txtRefNo.Text = DtAdjust.Rows(0).Item("RefNo")
            txtNarration.Text = DtAdjust.Rows(0).Item("Narration")
            dtpDocDt.Value = DtAdjust.Rows(0).Item("Doc_Dt")
            lblAmtToBeAdj.Text = DtAdjust.Rows(0).Item("TotAmt")
            lblFlag.Text = IIf(DtAdjust.Rows(0).Item("AmtFlag") = "D", "Dr", "Cr")
            lblAdjAmt.Text = DtAdjust.Rows(0).Item("AdjAmt")
            lblBalAmt.Text = DtAdjust.Rows(0).Item("BalAmt")
        End If

        txtVchrNo.ReadOnly = True
        txtRefNo.ReadOnly = True
        txtNarration.ReadOnly = True
        dtpDocDt.Enabled = False

        Dim DtTable As New DataTable
        Details = Nothing : dtgPartyAc.DataSource = Nothing
        DisplayGridHeaders()
        dtgPartyAc.CaptionText = strPartyNm

        If blnOnlyOS = True Then
            strOnlyOS = " And Bal_Amt > 0"
        Else
            strOnlyOS = ""
        End If

        If StrPartyK <> "" Then
            strParty = " And Party_key = '" & StrPartyK & "'"
        Else
            strParty = ""
        End If

        If StrTrjType = "Opening" Then
            Query = " Select Doc_Id From Vchr Where VchrType='ME' "
            Dim DtDoc = Common.GetDataTable(Query)

            If DtDoc.Rows.Count > 0 Then
                intDocID = DtDoc.Rows(0)(0)
            Else
                intDocID = intDocID
            End If
        End If

        Query = " Select * from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or SaleBill_Id=" & intDocRefID & ")"
        Dim DtOpening = Common.GetDataTable(Query)

        If DtOpening.Rows.Count > 0 Then
            blnOpRec = True
        Else
            blnOpRec = False
        End If

        Query = " Select * from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or PurchaseBill_id=" & intDocRefID & ")"
        DtOpening = Common.GetDataTable(Query)

        If DtOpening.Rows.Count > 0 Then
            blnOpPay = True
        Else
            blnOpPay = False
        End If

        If blnReceivable Then
            If StrTrjType = "Opening" Then
                If blnOpRec Then
                    Query = " Select isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or SaleBill_Id=A.OpDocRef_id)),0) AgstAmt, " _
                        & " Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                        & " Due_dt, Narration, Broker_Key, Amt_flg, Party_Key, " _
                        & " isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or SaleBill_Id=A.OpDocRef_id)),0) NewOpDocRef_id " _
                        & " ,isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or SaleBill_Id=A.OpDocRef_id) and A.AdjAmt=Doc_Amt ),0) OnAcOpDocRef_id " _
                        & " From View_ManualAdjust as A " _
                        & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "'" & strParty & strOnlyOS _
                        & IIf(strAdjust = "View", " And Isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or SaleBill_Id=A.OpDocRef_id)),0) > 0 ", "") _
                        & " And Amt_flg = 'D'" _
                        & " Order by Doc_Dt "
                Else
                    Query = " Select isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or SaleBill_Id=" & intDocRefID & ")),0) AgstAmt, " _
                        & " Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                        & " Due_dt, Narration, Broker_Key, Amt_flg, Party_Key, " _
                        & " isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or SaleBill_Id=" & intDocRefID & ")),0) NewOpDocRef_id " _
                        & " ,isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or SaleBill_Id=" & intDocRefID & ") and A.AdjAmt=Doc_Amt ),0) OnAcOpDocRef_id " _
                        & " From View_ManualAdjust as A " _
                        & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "'" & strParty & strOnlyOS _
                        & IIf(strAdjust = "View", " And Isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or SaleBill_Id=" & intDocRefID & ")),0) > 0 ", "") _
                        & " And Amt_flg = 'D'" _
                        & " Order by Doc_Dt "
                End If

            ElseIf StrTrjType = "Vchr" Then
                Query = " Select isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or SaleBill_Id=A.OpDocRef_id)),0) AgstAmt, " _
                    & " Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                    & " Due_dt, Narration, Broker_Key, Amt_flg, Party_Key, " _
                    & " isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or SaleBill_Id=A.OpDocRef_id)),0) NewOpDocRef_id, 0 OnAcOpDocRef_id " _
                    & " From View_ManualAdjust as A " _
                    & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "'" & strParty & strOnlyOS _
                    & IIf(strAdjust = "View", " And Isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or SaleBill_Id=A.OpDocRef_id)),0) > 0 ", "") _
                    & " And Amt_flg = 'D'" _
                    & " Order by Doc_Dt "

            ElseIf StrTrjType = "SalesReturn" Then
                Query = " Select isnull((Select Amt from VchrDtlRefAmt where SalesRtn_id =" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or SaleBill_Id=A.OpDocRef_id)),0) AgstAmt, " _
                    & " Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                    & " Due_dt, Narration, Broker_Key, Amt_flg, Party_Key, 0 NewOpDocRef_id, 0 OnAcOpDocRef_id " _
                    & " From View_ManualAdjust as A " _
                    & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "'" & strParty & strOnlyOS _
                    & IIf(strAdjust = "View", " And Isnull((Select Amt from VchrDtlRefAmt where SalesRtn_id =" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or SaleBill_Id=A.OpDocRef_id)),0) > 0 ", "") _
                    & " And Amt_flg = 'D'" _
                    & " Order by Doc_Dt "
            End If

        Else

            If StrTrjType = "Opening" Then
                If blnOpPay Then
                    Query = " Select isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or PurchaseBill_id=A.OpDocRef_id)),0) AgstAmt, " _
                        & " Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                        & " Due_dt, Narration, Broker_Key, Amt_flg, Party_Key, " _
                        & " isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or PurchaseBill_id=A.OpDocRef_id)),0) NewOpDocRef_id " _
                        & " ,isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or PurchaseBill_id=A.OpDocRef_id) and A.AdjAmt=Doc_Amt ),0) OnAcOpDocRef_id " _
                        & " From View_ManualAdjust as A " _
                        & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "'" & strParty & strOnlyOS _
                        & IIf(strAdjust = "View", " And Isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or PurchaseBill_id=A.OpDocRef_id)),0) > 0 ", "") _
                        & " And Amt_flg = 'C'" _
                        & " Order by Doc_Dt "
                Else
                    Query = " Select isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or PurchaseBill_id=" & intDocRefID & ")),0) AgstAmt, " _
                        & " Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                        & " Due_dt, Narration, Broker_Key, Amt_flg, Party_Key, " _
                        & " isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or PurchaseBill_id=" & intDocRefID & ")),0) NewOpDocRef_id " _
                        & " ,isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or PurchaseBill_id=" & intDocRefID & ") and A.AdjAmt=Doc_Amt ),0) OnAcOpDocRef_id " _
                        & " From View_ManualAdjust as A " _
                        & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "'" & strParty & strOnlyOS _
                        & IIf(strAdjust = "View", " And Isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=" & intDocRefID & " or PurchaseBill_id=" & intDocRefID & ")),0) > 0 ", "") _
                        & " And Amt_flg = 'C'" _
                        & " Order by Doc_Dt "
                End If

            ElseIf StrTrjType = "Vchr" Then
                Query = " Select isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or PurchaseBill_id=A.OpDocRef_id)),0) AgstAmt, " _
                    & " Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                    & " Due_dt, Narration, Broker_Key, Amt_flg, Party_Key, " _
                    & " isnull((Select DocRef_id from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or PurchaseBill_id=A.OpDocRef_id)),0) NewOpDocRef_id, 0 OnAcOpDocRef_id " _
                    & " From View_ManualAdjust as A " _
                    & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "'" & strParty & strOnlyOS _
                    & IIf(strAdjust = "View", " And Isnull((Select Doc_Amt from VchrDtlRef where Doc_id=" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or PurchaseBill_id=A.OpDocRef_id)),0) > 0 ", "") _
                    & " And Amt_flg = 'C'" _
                    & " Order by Doc_Dt "

            ElseIf StrTrjType = "PurchaseReturn" Then
                Query = " Select isnull((Select Doc_Amt from VchrDtlRef where PurchaseBill_id =" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or PurchaseBill_id=A.OpDocRef_id)),0) AgstAmt, " _
                    & " Cobr_id, FcYr_Id, Doc_Dt, OpDocRef_id, Doc_Id, Trj_type, Doc_No, RefNo, Tot_amt, AdjAmt, Bal_amt, DateDiff(Day, Doc_Dt, GetDate()) Os_Days, " _
                    & " Due_dt, Narration, Broker_Key, Amt_flg, Party_Key, 0 NewOpDocRef_id, 0 OnAcOpDocRef_id " _
                    & " From View_ManualAdjust as A " _
                    & " Where COBR_ID = '" & SelBranchId & "' And Fcyr_Id='" & SelYearId & "'" & strParty & strOnlyOS _
                    & IIf(strAdjust = "View", " And Isnull((Select Amt from VchrDtlRefAmt where SalesRtn_id =" & intDocID & " And (VchrDtlAdj_Id=A.OpDocRef_id or PurchaseBill_id=A.OpDocRef_id)),0) > 0 ", "") _
                    & " And Amt_flg = 'C'" _
                    & " Order by Doc_Dt "
            End If

        End If

        DtTable = Common.GetDataTable(Query)
        Dim PurRow, NewRow As DataRow

        For Each PurRow In DtTable.Rows
            NewRow = Details.NewRow

            NewRow(GridColumns.AgstAmt) = PurRow("AgstAmt")
            NewRow(GridColumns.Doc_dt) = PurRow("Doc_Dt") & ""
            NewRow(GridColumns.Type) = PurRow("Trj_type") & ""
            NewRow(GridColumns.Doc_No) = PurRow("Doc_No") & ""
            NewRow(GridColumns.RefNo) = PurRow("RefNo") & ""
            NewRow(GridColumns.TotalAmt) = PurRow("Tot_amt")
            NewRow(GridColumns.AdjAmt) = PurRow("AdjAmt")
            NewRow(GridColumns.BalAmt) = PurRow("Bal_amt")
            NewRow(GridColumns.Os_Days) = PurRow("Os_Days") & ""
            NewRow(GridColumns.Due_dt) = PurRow("Due_dt") & ""
            NewRow(GridColumns.Narration) = PurRow("Narration") & ""
            NewRow(GridColumns.Broker_Key) = PurRow("Broker_Key") & ""
            NewRow(GridColumns.Flag) = IIf(PurRow("Amt_flg") = "D", "D", "C")
            NewRow(GridColumns.OpDocRef_id) = PurRow("OpDocRef_id")
            NewRow(GridColumns.Doc_Id) = PurRow("Doc_Id")
            NewRow(GridColumns.Party_Key) = PurRow("Party_key") & ""
            NewRow(GridColumns.OldAgstAmt) = PurRow("AgstAmt")
            NewRow(GridColumns.NewOpDocRef_id) = PurRow("NewOpDocRef_id")
            NewRow(GridColumns.OnAcOpDocRef_id) = PurRow("OnAcOpDocRef_id")

            Details.Rows.Add(NewRow)

            Details.AcceptChanges()
            dtgPartyAc.CurrentRowIndex = Details.Rows.Count - 1
        Next PurRow

        Details.AcceptChanges()

        If strAdjust = "View" Then
            dtgPartyAc.ReadOnly = True
            Label2.Text = "View Adjustments"
        Else
            dtgPartyAc.ReadOnly = False
        End If
        'lblDebitAmt.Text = Format$(TotDebit, "0.00")
        'lblCreditAmt.Text = Format$(TotCredit, "0.00")
        'lblBalAmt.Text = Format$(Math.Abs(TotClosing), "0.00")
        'lblFlag.Text = IIf(TotClosing >= 0, "Dr", "Cr")

        If dtgPartyAc.CurrentRowIndex <> -1 Then
            dtgPartyAc.CurrentRowIndex = 0
            dtgPartyAc.Focus()
            dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dtgPartyAc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgPartyAc.MouseUp
        Try
            dtgPartyAc.Select(dtgPartyAc.CurrentCell.RowNumber)
        Catch ex As IndexOutOfRangeException
            Exit Sub
        End Try
    End Sub

    Private Sub dtgPartyAc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgPartyAc.DoubleClick
        If dtgPartyAc.CurrentRowIndex = -1 Then Exit Sub
    End Sub

    Private Sub dtgPartyAc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgPartyAc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call dtgPartyAc_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub frmCustAcBillWise_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If blnFlag = True Then
            DisplayFill()
        End If
    End Sub

    Private Sub DisplayGridHeaders()
        Dim Grid As New GridColumnCreateAndFormat("ManualAdjust")

        With Grid
            .AddColumn("AgstAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 110, "Amount (F8).", , False)
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
            .AddColumn("Broker_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Broker_Key")
            .AddColumn("Flag", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("OpDocRef_id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "OpDocRef_id")
            .AddColumn("Doc_Id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "Doc_Id")
            .AddColumn("Party_Key", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "Party_Key")
            .AddColumn("OldAgstAmt", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 0, "")
            .AddColumn("NewOpDocRef_id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "NewOpDocRef_id")
            .AddColumn("OnAcOpDocRef_id", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "OnAcOpDocRef_id")

            .AddColumnToTable()
            Details = .GetTable
            Details.DefaultView.AllowNew = False
            Details.DefaultView.AllowEdit = True
            Details.DefaultView.AllowDelete = False

            dtgPartyAc.DataSource = Details
            .DisplayGridHeaders(Details, dtgPartyAc, False)
        End With
    End Sub

    Private Sub dtgPartyAc_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgPartyAc.CurrentCellChanged
        CalcAgstAmt()
    End Sub

    Private Sub CalcAgstAmt()
        Dim dblAdjAmt As Double

        Dim dtAgstAmt As DataTable = CType(dtgPartyAc.DataSource, DataTable)
        If IsNothing(dtAgstAmt) Then Exit Sub
        If dtAgstAmt.Rows.Count > 0 Then
            dblAdjAmt = dtAgstAmt.Compute("Sum(AgstAmt)", "")
        End If
        If dblAdjAmt > Val(lblAmtToBeAdj.Text) Then
            MsgBox("Adjusted Amt Cannot be greater than Voucher Amt!", MsgBoxStyle.Exclamation)
        End If
        lblAdjAmt.Text = Format$(dblAdjAmt, "0.00")
        CalcTotal()
    End Sub

    Private Sub CalcTotal()
        Dim dblBalAmt As Double = 0
        dblBalAmt = Val(lblAmtToBeAdj.Text) - Val(lblAdjAmt.Text)
        lblBalAmt.Text = Format$(dblBalAmt, "0.00")
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim rowNumber, rowCount, colNumber As Integer

        If keyData = Keys.Return Then
            If Me.ActiveControl.Parent Is CType(dtgPartyAc, DataGrid) Or Me.ActiveControl Is CType(dtgPartyAc, DataGrid) Then
                rowNumber = dtgPartyAc.CurrentCell.RowNumber
                rowCount = CType(dtgPartyAc.DataSource, DataTable).Rows.Count
                colNumber = GridColumns.AgstAmt

                If IsDBNull(dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt)) Then
                    dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt) = 0
                End If

                If rowNumber + 1 <= rowCount - 1 Then
                    rowNumber += 1
                Else
                    btnSave.Focus()
                    Exit Function
                End If
                dtgPartyAc.CurrentCell = New DataGridCell(rowNumber, colNumber)
            End If

        ElseIf keyData = Keys.F8 Then
            If Me.ActiveControl.Parent Is CType(dtgPartyAc, DataGrid) Or Me.ActiveControl Is CType(dtgPartyAc, DataGrid) Then
                rowNumber = dtgPartyAc.CurrentCell.RowNumber
                rowCount = CType(dtgPartyAc.DataSource, DataTable).Rows.Count
                colNumber = GridColumns.AgstAmt
                Dim dblPAmt As Double

                Dim dtPendAmt As DataTable = CType(dtgPartyAc.DataSource, DataTable)
                If IsNothing(dtPendAmt) Then Exit Function
                If dtPendAmt.Rows.Count > 0 Then
                    dblPAmt = dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.BalAmt)
                    If dblPAmt < Val(lblBalAmt.Text) Then
                        dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt) = dblPAmt
                    Else
                        dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt) = Val(lblBalAmt.Text)
                    End If
                End If

                rowNumber = dtgPartyAc.CurrentCell.RowNumber
                rowCount = CType(dtgPartyAc.DataSource, DataTable).Rows.Count
                colNumber = GridColumns.AgstAmt

                If IsDBNull(dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt)) Then
                    dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt) = 0
                End If

                If rowNumber + 1 <= rowCount - 1 Then
                    rowNumber += 1
                Else
                    btnSave.Focus()
                    Exit Function
                End If
                dtgPartyAc.CurrentCell = New DataGridCell(rowNumber, colNumber)
            End If

        ElseIf keyData = Keys.Up Or keyData = Keys.Down Then
            If IsDBNull(dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt)) Then
                dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt) = 0
            End If
        End If

    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Trans As SqlTransaction = Nothing
        If Val(lblBalAmt.Text) < 0 Then
            MsgBox("Balance Amt Cannot be less than Zero!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim DtAdj As New DataTable
        Dim DtRef As New DataTable
        Dim DocRefId As Integer
        Dim DocDtlId As Integer
        Trans = CreateSQLTransaction()

        If StrTrjType = "Vchr" Then
            Query = " Select DocDtl_Id From View_ManualMatching " _
                & " Where Party_key='" & StrPartyK & "' And Doc_Id= " & intDocID & " And Trj_Type='" & StrTrjType & "'"
            DtAdj = Common.GetDataTable(Query)

            If DtAdj.Rows.Count > 0 Then
                DocDtlId = DtAdj.Rows(0)(0)
                Query = " Select * From VchrDtlRef Where Doc_Id=" & intDocID & " And DocDtl_Id= " & DocDtlId & " and RefType='4'"
                DtRef = Common.GetDataTable(Query)
                If DtRef.Rows.Count > 0 Then
                    Query = " Delete From VchrDtlRef Where Doc_Id=" & intDocID & " And DocDtl_Id= " & DocDtlId & " and RefType='4'"
                    Call Common.ExecuteQuery(Query, Trans)
                End If
            End If

            Dim i As Short
            Dim RecRow As DataRow

            For i = 0 To Details.Rows.Count - 1
                RecRow = Details.Rows(i)

                If blnReceivable Then
                    If RecRow(GridColumns.AgstAmt) > 0 And RecRow(GridColumns.OldAgstAmt) = 0 Then
                        If RecRow(GridColumns.Type) <> "Op Sale" Then
                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & intDocID & ",'2','" & RecRow(GridColumns.Doc_No) & "','" & Format$(CDate(RecRow(GridColumns.Doc_dt)), "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0,0,'" & IIf(RecRow(GridColumns.Flag) = "D", "C", "D") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0," & Val(RecRow(GridColumns.OpDocRef_id)) & ",0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update SaleBill Set Bal_Amt = Bal_Amt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)
                        Else
                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & intDocID & ",'2','" & RecRow(GridColumns.Doc_No) & "','" & Format$(CDate(RecRow(GridColumns.Doc_dt)), "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.OpDocRef_id)) & ",'" & IIf(RecRow(GridColumns.Flag) = "D", "C", "D") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                  & " Where DocRef_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)
                        End If

                    ElseIf RecRow(GridColumns.AgstAmt) >= 0 And RecRow(GridColumns.OldAgstAmt) > 0 Then
                        If RecRow(GridColumns.Type) <> "Op Sale" Then
                            If RecRow(GridColumns.OpDocRef_id) > 0 Then
                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where DocRef_id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update SaleBill Set Bal_Amt = (Bal_Amt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow(GridColumns.AgstAmt) = 0 Then
                                    Query = "Delete From VchrDtlRef Where DocRef_id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)
                                End If
                            End If
                        Else
                            If RecRow(GridColumns.OpDocRef_id) > 0 Then
                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")-" & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & Val(RecRow(GridColumns.OpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow(GridColumns.AgstAmt) = 0 Then
                                    Query = "Delete From VchrDtlRef Where DocRef_id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)
                                End If
                            End If
                        End If

                    End If

                Else    'payable

                    If RecRow(GridColumns.AgstAmt) > 0 And RecRow(GridColumns.OldAgstAmt) = 0 Then
                        If RecRow(GridColumns.Type) <> "Op Purchase" Then
                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & intDocID & ",'2','" & RecRow(GridColumns.Doc_No) & "','" & Format$(CDate(RecRow(GridColumns.Doc_dt)), "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0,0,'" & IIf(RecRow(GridColumns.Flag) = "D", "C", "D") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0," & Val(RecRow(GridColumns.OpDocRef_id)) & ",0"
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update PurchaseBill Set Bal_Amt = Bal_Amt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)
                        Else
                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & intDocID & ",'2','" & RecRow(GridColumns.Doc_No) & "','" & Format$(CDate(RecRow(GridColumns.Doc_dt)), "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.OpDocRef_id)) & ",'" & IIf(RecRow(GridColumns.Flag) = "D", "C", "D") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                  & " Where DocRef_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)
                        End If

                    ElseIf RecRow(GridColumns.AgstAmt) >= 0 And RecRow(GridColumns.OldAgstAmt) > 0 Then
                        If RecRow(GridColumns.Type) <> "Op Purchase" Then
                            If RecRow(GridColumns.OpDocRef_id) > 0 Then
                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where DocRef_id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update PurchaseBill Set Bal_Amt = (Bal_Amt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow(GridColumns.AgstAmt) = 0 Then
                                    Query = "Delete From VchrDtlRef Where DocRef_id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)
                                End If
                            End If
                        Else
                            If RecRow(GridColumns.OpDocRef_id) > 0 Then
                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")-" & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & Val(RecRow(GridColumns.OpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow(GridColumns.AgstAmt) = 0 Then
                                    Query = "Delete From VchrDtlRef Where DocRef_id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)
                                End If
                            End If
                        End If

                    End If

                End If
                
            Next i

            If Val(lblBalAmt.Text) > 0 Then
                DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & intDocID & ",'4','" & RecRow(GridColumns.Doc_No) & "','" & Format$(CDate(RecRow(GridColumns.Doc_dt)), "MM/dd/yyyy") & "','','',0,0," & Val(lblBalAmt.Text) & ",0," & Val(lblBalAmt.Text) & ",0,0,'" & IIf(RecRow(GridColumns.Flag) = "D", "C", "D") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0,0,0"
                Common.ExecuteQuery(Query, Trans)
            End If

        ElseIf StrTrjType = "SalesReturn" Then

            Dim i As Short
            Dim RecRow As DataRow

            For i = 0 To Details.Rows.Count - 1
                RecRow = Details.Rows(i)

                If RecRow(GridColumns.AgstAmt) > 0 And RecRow(GridColumns.OldAgstAmt) = 0 Then
                    If RecRow(GridColumns.Type) <> "Op Sale" Then
                        DocRefId = Common.NewRecordId("VchrDtlRefamt", "Ref_Id", Trans, False)
                        Query = "Exec Insert_VchrDtlRefamt " & DocRefId & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",'C',0," & Val(RecRow(GridColumns.OpDocRef_id)) & "," & intDocID
                        Common.ExecuteQuery(Query, Trans)

                        Query = "Update SaleBill Set Bal_Amt = Bal_Amt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                        Common.ExecuteQuery(Query, Trans)
                    Else
                        DocRefId = Common.NewRecordId("VchrDtlRefamt", "Ref_Id", Trans, False)
                        Query = "Exec Insert_VchrDtlRefamt " & DocRefId & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",'C'," & Val(RecRow(GridColumns.OpDocRef_id)) & ",0," & intDocID
                        Common.ExecuteQuery(Query, Trans)

                        Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
                              & " Where DocRef_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                        Common.ExecuteQuery(Query, Trans)
                    End If

                    Query = "Update SalesRtn Set Bal_Amt= Bal_Amt - " & Val(RecRow(GridColumns.AgstAmt)) & " where Doc_id= " & intDocID
                    Common.ExecuteQuery(Query, Trans)

                ElseIf RecRow(GridColumns.AgstAmt) >= 0 And RecRow(GridColumns.OldAgstAmt) > 0 Then
                    If RecRow(GridColumns.Type) <> "Op Sale" Then
                        If RecRow(GridColumns.OpDocRef_id) > 0 Then
                            Query = "Update VchrDtlRefamt Set Amt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where SaleBill_Id = " & Val(RecRow(GridColumns.OpDocRef_id)) & " And SalesRtn_id = " & intDocID
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update SaleBill Set Bal_Amt = (Bal_Amt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)

                            If RecRow(GridColumns.AgstAmt) = 0 Then
                                Query = "Delete From VchrDtlRefamt Where SaleBill_Id = " & Val(RecRow(GridColumns.OpDocRef_id)) & " And SalesRtn_id = " & intDocID
                                Common.ExecuteQuery(Query, Trans)
                            End If
                        End If
                    Else
                        If RecRow(GridColumns.OpDocRef_id) > 0 Then
                            Query = "Update VchrDtlRefamt Set Amt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                & " Where VchrDtlAdj_Id = " & Val(RecRow(GridColumns.OpDocRef_id)) & " And SalesRtn_id = " & intDocID
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")-" & Val(RecRow(GridColumns.AgstAmt)) _
                                & " Where DocRef_Id = " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)

                            If RecRow(GridColumns.AgstAmt) = 0 Then
                                Query = "Delete From VchrDtlRefamt Where VchrDtlAdj_Id = " & Val(RecRow(GridColumns.OpDocRef_id)) & " And SalesRtn_id = " & intDocID
                                Common.ExecuteQuery(Query, Trans)
                            End If
                        End If
                    End If

                    Query = "Update SalesRtn Set Bal_Amt= (Bal_Amt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) & " where Doc_id= " & intDocID
                    Common.ExecuteQuery(Query, Trans)

                End If
            Next i

        ElseIf StrTrjType = "Opening" Then
            Dim i As Short
            Dim RecRow As DataRow
            Dim DocKey As String = ""
            Dim Doc_No As String = ""
            Dim DocId As Integer

            Query = " Select Doc_Id From Vchr Where VchrType='ME' "
            DtRef = Common.GetDataTable(Query, Trans)

            If DtRef.Rows.Count > 0 Then
                DocId = DtRef.Rows(0)(0)
            Else
                DocId = Common.NewRecordId("Vchr", "Doc_Id", Trans, False)
                Doc_No = VchrTranNewDocNo("ME", "VCHR", "DOC_NO", 1, 2, "", "00000")
                DocKey = SelYearId & SelBranchId & "ME" & Doc_No

                Query = "Exec Insert_Vchr '" & SelBranchId & "','" & SelYearId & "'," & DocId & ",'ME','" & Doc_No & "','ME" & Doc_No & "','" & DocKey & "','" & Format$(Now, "MM/dd/yyyy") & "','','" & Doc_No & "',0,'D','ME','" & SelLocId & "','" & SelCounterId & "','M','1','0','','1'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm:ss tt") & "'"
                Common.ExecuteQuery(Query, Trans)
            End If

            Query = " Select VchrDtl.DocDtl_Id From VchrDtl " _
                & " Left Join Vchr	on VchrDtl.Doc_Id=Vchr.Doc_id " _
                & " Where VchrType='ME' And Led_key='" & StrPartyK & "'"
            DtAdj = Common.GetDataTable(Query, Trans)

            If DtAdj.Rows.Count > 0 Then
                DocDtlId = DtAdj.Rows(0)(0)
            Else
                DocDtlId = Common.NewRecordId("VchrDtl", "DocDtl_Id", Trans, False)
                Query = "Exec Insert_VchrDtl " & DocDtlId & "," & DocId & ",'" & StrPartyK & "',0,'D','','" & StrPartyK & "','',Null,'','','','1','', Null, " & UserId & ", '" & Format$(Now, "MM/dd/yyyy hh:mm:ss tt") & "','',0"
                Common.ExecuteQuery(Query, Trans)
            End If

            For i = 0 To Details.Rows.Count - 1
                RecRow = Details.Rows(i)

                If blnReceivable Then
                    If RecRow(GridColumns.AgstAmt) > 0 And RecRow(GridColumns.OldAgstAmt) = 0 Then
                        If RecRow(GridColumns.Type) <> "Op Sale" Then
                            
                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & DocId & ",'2','" & Doc_No & "','" & Format$(Now, "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0,0,'" & IIf(RecRow(GridColumns.Flag) = "D", "C", "D") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0," & Val(RecRow(GridColumns.OpDocRef_id)) & ",0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & DocId & ",'2','" & Doc_No & "','" & Format$(Now, "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & intDocRefID & ",'" & IIf(RecRow(GridColumns.Flag) = "D", "D", "C") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update SaleBill Set Bal_Amt = Bal_Amt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                  & " Where DocRef_Id= " & intDocRefID
                            Common.ExecuteQuery(Query, Trans)

                        Else

                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & DocId & ",'2','" & Doc_No & "','" & Format$(Now, "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.OpDocRef_id)) & ",'" & IIf(RecRow(GridColumns.Flag) = "D", "C", "D") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & DocId & ",'2','" & Doc_No & "','" & Format$(Now, "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & intDocRefID & ",'" & IIf(RecRow(GridColumns.Flag) = "D", "D", "C") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                  & " Where DocRef_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                  & " Where DocRef_Id= " & intDocRefID
                            Common.ExecuteQuery(Query, Trans)
                        End If

                    ElseIf RecRow(GridColumns.AgstAmt) >= 0 And RecRow(GridColumns.OldAgstAmt) > 0 Then
                        If RecRow(GridColumns.Type) <> "Op Sale" Then
                            If RecRow(GridColumns.OpDocRef_id) > 0 Then
                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where DocRef_Id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where DocRef_Id = " & Val(RecRow(GridColumns.OnAcOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update SaleBill Set Bal_Amt = (Bal_Amt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where DocRef_Id= " & intDocRefID
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow(GridColumns.AgstAmt) = 0 Then
                                    Query = "Delete From VchrDtlRef Where DocRef_Id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)

                                    Query = "Delete From VchrDtlRef Where DocRef_Id = " & Val(RecRow(GridColumns.OnAcOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)
                                End If
                            End If
                        Else
                            If RecRow(GridColumns.OpDocRef_id) > 0 Then
                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & Val(RecRow(GridColumns.OnAcOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")-" & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & Val(RecRow(GridColumns.OpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")-" & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & intDocRefID
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow(GridColumns.AgstAmt) = 0 Then
                                    Query = "Delete From VchrDtlRef Where DocRef_Id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)

                                    Query = "Delete From VchrDtlRef Where DocRef_Id = " & Val(RecRow(GridColumns.OnAcOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)
                                End If
                            End If
                        End If

                    End If

                Else    'payable

                    If RecRow(GridColumns.AgstAmt) > 0 And RecRow(GridColumns.OldAgstAmt) = 0 Then
                        If RecRow(GridColumns.Type) <> "Op Purchase" Then
                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & DocId & ",'2','" & Doc_No & "','" & Format$(Now, "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0,0,'" & IIf(RecRow(GridColumns.Flag) = "D", "C", "D") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0," & Val(RecRow(GridColumns.OpDocRef_id)) & ",0"
                            Common.ExecuteQuery(Query, Trans)

                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & DocId & ",'2','" & Doc_No & "','" & Format$(Now, "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & intDocRefID & ",'" & IIf(RecRow(GridColumns.Flag) = "D", "D", "C") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update PurchaseBill Set Bal_Amt = Bal_Amt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                  & " Where DocRef_Id= " & intDocRefID
                            Common.ExecuteQuery(Query, Trans)

                        Else

                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & DocId & ",'2','" & Doc_No & "','" & Format$(Now, "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.OpDocRef_id)) & ",'" & IIf(RecRow(GridColumns.Flag) = "D", "C", "D") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            DocRefId = Common.NewRecordId("VchrDtlRef", "DocRef_Id", Trans, False)
                            Query = "Exec Insert_VchrDtlRef " & DocRefId & "," & DocDtlId & "," & DocId & ",'2','" & Doc_No & "','" & Format$(Now, "MM/dd/yyyy") & "','','',0,0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",0," & intDocRefID & ",'" & IIf(RecRow(GridColumns.Flag) = "D", "D", "C") & "'," & Val(RecRow(GridColumns.Os_Days)) & ",'" & Format$(CDate(RecRow(GridColumns.Due_dt)), "MM/dd/yyyy") & "','',0,0,0,0,0,0,0"
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                  & " Where DocRef_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                            Common.ExecuteQuery(Query, Trans)

                            Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
                                  & " Where DocRef_Id= " & intDocRefID
                            Common.ExecuteQuery(Query, Trans)
                        End If

                    ElseIf RecRow(GridColumns.AgstAmt) >= 0 And RecRow(GridColumns.OldAgstAmt) > 0 Then
                        If RecRow(GridColumns.Type) <> "Op Purchase" Then
                            If RecRow(GridColumns.OpDocRef_id) > 0 Then
                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where DocRef_Id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where DocRef_Id = " & Val(RecRow(GridColumns.OnAcOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update PurchaseBill Set Bal_Amt = (Bal_Amt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) _
                                        & " Where DocRef_Id= " & intDocRefID
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow(GridColumns.AgstAmt) = 0 Then
                                    Query = "Delete From VchrDtlRef Where DocRef_Id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)

                                    Query = "Delete From VchrDtlRef Where DocRef_Id = " & Val(RecRow(GridColumns.OnAcOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)
                                End If
                            End If
                        Else
                            If RecRow(GridColumns.OpDocRef_id) > 0 Then
                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_Amt = " & Val(RecRow(GridColumns.AgstAmt)) & ", Doc_BalAmt = " & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & Val(RecRow(GridColumns.OnAcOpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")-" & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & Val(RecRow(GridColumns.OpDocRef_id))
                                Common.ExecuteQuery(Query, Trans)

                                Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")-" & Val(RecRow(GridColumns.AgstAmt)) _
                                    & " Where DocRef_Id = " & intDocRefID
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow(GridColumns.AgstAmt) = 0 Then
                                    Query = "Delete From VchrDtlRef Where DocRef_Id = " & Val(RecRow(GridColumns.NewOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)

                                    Query = "Delete From VchrDtlRef Where DocRef_Id = " & Val(RecRow(GridColumns.OnAcOpDocRef_id))
                                    Common.ExecuteQuery(Query, Trans)
                                End If
                            End If
                        End If

                    End If

                End If

            Next i

            'ElseIf StrTrjType = "PurchaseReturn" Then

            '    Dim i As Short
            '    Dim RecRow As DataRow

            '    For i = 0 To Details.Rows.Count - 1
            '        RecRow = Details.Rows(i)

            '        If RecRow(GridColumns.AgstAmt) > 0 And RecRow(GridColumns.OldAgstAmt) = 0 Then
            '            If RecRow(GridColumns.Type) <> "Op Purchase" Then
            '                DocRefId = Common.NewRecordId("VchrDtlRefamt", "Ref_Id", Trans, False)
            '                Query = "Exec Insert_VchrDtlRefamt " & DocRefId & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",'C',0," & Val(RecRow(GridColumns.OpDocRef_id)) & "," & intDocID
            '                Common.ExecuteQuery(Query, Trans)

            '                Query = "Update SaleBill Set Bal_Amt = Bal_Amt - " & Val(RecRow(GridColumns.AgstAmt)) _
            '                        & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
            '                Common.ExecuteQuery(Query, Trans)
            '            Else
            '                DocRefId = Common.NewRecordId("VchrDtlRefamt", "Ref_Id", Trans, False)
            '                Query = "Exec Insert_VchrDtlRefamt " & DocRefId & ",0," & Val(RecRow(GridColumns.AgstAmt)) & ",'C'," & Val(RecRow(GridColumns.OpDocRef_id)) & ",0," & intDocID
            '                Common.ExecuteQuery(Query, Trans)

            '                Query = "Update VchrDtlRef Set Doc_BalAmt = Doc_BalAmt - " & Val(RecRow(GridColumns.AgstAmt)) _
            '                      & " Where DocRef_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
            '                Common.ExecuteQuery(Query, Trans)
            '            End If

            '            Query = "Update SalesRtn Set Bal_Amt= Bal_Amt - " & Val(RecRow(GridColumns.AgstAmt)) & " where Doc_id= " & intDocID
            '            Common.ExecuteQuery(Query, Trans)

            '        ElseIf RecRow(GridColumns.AgstAmt) >= 0 And RecRow(GridColumns.OldAgstAmt) > 0 Then
            '            If RecRow(GridColumns.Type) <> "Op Sale" Then
            '                If RecRow(GridColumns.OpDocRef_id) > 0 Then
            '                    Query = "Update VchrDtlRefamt Set Amt = " & Val(RecRow(GridColumns.AgstAmt)) _
            '                            & " Where SaleBill_Id = " & Val(RecRow(GridColumns.OpDocRef_id)) & " And SalesRtn_id = " & intDocID
            '                    Common.ExecuteQuery(Query, Trans)

            '                    Query = "Update SaleBill Set Bal_Amt = (Bal_Amt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) _
            '                            & " Where Doc_Id= " & Val(RecRow(GridColumns.OpDocRef_id))
            '                    Common.ExecuteQuery(Query, Trans)

            '                    If RecRow(GridColumns.AgstAmt) = 0 Then
            '                        Query = "Delete From VchrDtlRefamt Where SaleBill_Id = " & Val(RecRow(GridColumns.OpDocRef_id)) & " And SalesRtn_id = " & intDocID
            '                        Common.ExecuteQuery(Query, Trans)
            '                    End If
            '                End If
            '            Else
            '                If RecRow(GridColumns.OpDocRef_id) > 0 Then
            '                    Query = "Update VchrDtlRefamt Set Amt = " & Val(RecRow(GridColumns.AgstAmt)) _
            '                        & " Where VchrDtlAdj_Id = " & Val(RecRow(GridColumns.OpDocRef_id)) & " And SalesRtn_id = " & intDocID
            '                    Common.ExecuteQuery(Query, Trans)

            '                    Query = "Update VchrDtlRef Set Doc_BalAmt = (Doc_BalAmt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")-" & Val(RecRow(GridColumns.AgstAmt)) _
            '                        & " Where DocRef_Id = " & Val(RecRow(GridColumns.OpDocRef_id))
            '                    Common.ExecuteQuery(Query, Trans)

            '                    If RecRow(GridColumns.AgstAmt) = 0 Then
            '                        Query = "Delete From VchrDtlRefamt Where VchrDtlAdj_Id = " & Val(RecRow(GridColumns.OpDocRef_id)) & " And SalesRtn_id = " & intDocID
            '                        Common.ExecuteQuery(Query, Trans)
            '                    End If
            '                End If
            '            End If

            '            Query = "Update SalesRtn Set Bal_Amt= (Bal_Amt + " & Val(RecRow(GridColumns.OldAgstAmt)) & ")- " & Val(RecRow(GridColumns.AgstAmt)) & " where Doc_id= " & intDocID
            '            Common.ExecuteQuery(Query, Trans)

            '        End If
            '    Next i

        End If
        Trans.Commit()
        MsgBox("Saved Succesfully!", MsgBoxStyle.Exclamation)
        DisplayFill()

    End Sub

    Private Sub btnDelAdj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAdj.Click
        If dtgPartyAc.CurrentRowIndex = -1 Then Exit Sub
        If dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt) > 0 Then
            dtgPartyAc.Item(dtgPartyAc.CurrentRowIndex, GridColumns.AgstAmt) = 0
        End If
    End Sub

End Class