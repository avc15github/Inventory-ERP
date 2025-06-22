<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTDSEntry
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
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTDSEntry))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.btnEntry = New DevExpress.XtraEditors.SimpleButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnprint = New DevExpress.XtraEditors.SimpleButton
        Me.grpdate_party = New System.Windows.Forms.GroupBox
        Me.rdPartyWise = New System.Windows.Forms.RadioButton
        Me.rdDateWise = New System.Windows.Forms.RadioButton
        Me.grpentry = New System.Windows.Forms.GroupBox
        Me.rdUnPaid = New System.Windows.Forms.RadioButton
        Me.rdAllEntry = New System.Windows.Forms.RadioButton
        Me.grpdate_range = New System.Windows.Forms.GroupBox
        Me.lblFrom = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.grpacc_sel = New System.Windows.Forms.GroupBox
        Me.lvwAccountDtls = New System.Windows.Forms.ListView
        Me.mnuSelection = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuSelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUnSelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuInvertSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.grpEntryMain = New DevExpress.XtraEditors.GroupControl
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.grpsr = New System.Windows.Forms.GroupBox
        Me.btnsrclose = New DevExpress.XtraEditors.SimpleButton
        Me.txtsrto = New NumericTextBox.NumericTextBox
        Me.txtsrfrom = New NumericTextBox.NumericTextBox
        Me.btnallupd = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtgdetails = New System.Windows.Forms.DataGrid
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.grpenrtybankDetails = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTotAmt = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblTotTDS = New System.Windows.Forms.Label
        Me.txtchq_no = New System.Windows.Forms.TextBox
        Me.btnUpdateAll = New DevExpress.XtraEditors.SimpleButton
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.Label92 = New System.Windows.Forms.Label
        Me.txtChallanNo = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.cmbBank = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblBarLocation = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.dtpChallandt = New DateTimePick.DateTimePick
        Me.dtpTo = New DateTimePick.DateTimePick
        Me.dtpFrom = New DateTimePick.DateTimePick
        Me.grpMain.SuspendLayout()
        Me.grpdate_party.SuspendLayout()
        Me.grpentry.SuspendLayout()
        Me.grpdate_range.SuspendLayout()
        Me.grpacc_sel.SuspendLayout()
        Me.mnuSelection.SuspendLayout()
        CType(Me.grpEntryMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntryMain.SuspendLayout()
        Me.grpsr.SuspendLayout()
        CType(Me.dtgdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpenrtybankDetails.SuspendLayout()
        CType(Me.cmbBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpMain.Controls.Add(Me.btnEntry)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Controls.Add(Me.btnprint)
        Me.grpMain.Controls.Add(Me.grpdate_party)
        Me.grpMain.Controls.Add(Me.grpentry)
        Me.grpMain.Controls.Add(Me.grpdate_range)
        Me.grpMain.Controls.Add(Me.grpacc_sel)
        Me.grpMain.Location = New System.Drawing.Point(5, -1)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(984, 557)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'btnEntry
        '
        Me.btnEntry.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEntry.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntry.Appearance.Options.UseFont = True
        Me.btnEntry.Location = New System.Drawing.Point(649, 261)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(70, 26)
        Me.btnEntry.TabIndex = 8
        Me.btnEntry.Text = "&Entry"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(796, 261)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 26)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "C&lose"
        '
        'btnprint
        '
        Me.btnprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnprint.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Appearance.Options.UseFont = True
        Me.btnprint.Location = New System.Drawing.Point(722, 261)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(70, 26)
        Me.btnprint.TabIndex = 9
        Me.btnprint.Text = "&Print"
        '
        'grpdate_party
        '
        Me.grpdate_party.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpdate_party.Controls.Add(Me.rdPartyWise)
        Me.grpdate_party.Controls.Add(Me.rdDateWise)
        Me.grpdate_party.Location = New System.Drawing.Point(649, 178)
        Me.grpdate_party.Name = "grpdate_party"
        Me.grpdate_party.Size = New System.Drawing.Size(292, 61)
        Me.grpdate_party.TabIndex = 543
        Me.grpdate_party.TabStop = False
        Me.grpdate_party.Text = "Index To Be"
        '
        'rdPartyWise
        '
        Me.rdPartyWise.AutoSize = True
        Me.rdPartyWise.Location = New System.Drawing.Point(102, 22)
        Me.rdPartyWise.Name = "rdPartyWise"
        Me.rdPartyWise.Size = New System.Drawing.Size(82, 19)
        Me.rdPartyWise.TabIndex = 6
        Me.rdPartyWise.Text = "PartyWise"
        Me.rdPartyWise.UseVisualStyleBackColor = True
        '
        'rdDateWise
        '
        Me.rdDateWise.AutoSize = True
        Me.rdDateWise.Checked = True
        Me.rdDateWise.Location = New System.Drawing.Point(8, 22)
        Me.rdDateWise.Name = "rdDateWise"
        Me.rdDateWise.Size = New System.Drawing.Size(78, 19)
        Me.rdDateWise.TabIndex = 5
        Me.rdDateWise.TabStop = True
        Me.rdDateWise.Text = "DateWise"
        Me.rdDateWise.UseVisualStyleBackColor = True
        '
        'grpentry
        '
        Me.grpentry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpentry.Controls.Add(Me.rdUnPaid)
        Me.grpentry.Controls.Add(Me.rdAllEntry)
        Me.grpentry.Location = New System.Drawing.Point(649, 122)
        Me.grpentry.Name = "grpentry"
        Me.grpentry.Size = New System.Drawing.Size(292, 48)
        Me.grpentry.TabIndex = 542
        Me.grpentry.TabStop = False
        '
        'rdUnPaid
        '
        Me.rdUnPaid.AutoSize = True
        Me.rdUnPaid.Location = New System.Drawing.Point(92, 22)
        Me.rdUnPaid.Name = "rdUnPaid"
        Me.rdUnPaid.Size = New System.Drawing.Size(106, 19)
        Me.rdUnPaid.TabIndex = 4
        Me.rdUnPaid.Text = "UnPaid Entries"
        Me.rdUnPaid.UseVisualStyleBackColor = True
        '
        'rdAllEntry
        '
        Me.rdAllEntry.AutoSize = True
        Me.rdAllEntry.Checked = True
        Me.rdAllEntry.Location = New System.Drawing.Point(6, 22)
        Me.rdAllEntry.Name = "rdAllEntry"
        Me.rdAllEntry.Size = New System.Drawing.Size(81, 19)
        Me.rdAllEntry.TabIndex = 3
        Me.rdAllEntry.TabStop = True
        Me.rdAllEntry.Text = "All Entries"
        Me.rdAllEntry.UseVisualStyleBackColor = True
        '
        'grpdate_range
        '
        Me.grpdate_range.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpdate_range.Controls.Add(Me.dtpTo)
        Me.grpdate_range.Controls.Add(Me.lblFrom)
        Me.grpdate_range.Controls.Add(Me.lblTo)
        Me.grpdate_range.Controls.Add(Me.dtpFrom)
        Me.grpdate_range.Location = New System.Drawing.Point(649, 36)
        Me.grpdate_range.Name = "grpdate_range"
        Me.grpdate_range.Size = New System.Drawing.Size(292, 80)
        Me.grpdate_range.TabIndex = 541
        Me.grpdate_range.TabStop = False
        Me.grpdate_range.Text = "Date Range"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(11, 26)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(61, 15)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "Start Date"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(11, 46)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(55, 15)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "End Date"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpacc_sel
        '
        Me.grpacc_sel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpacc_sel.Controls.Add(Me.lvwAccountDtls)
        Me.grpacc_sel.Location = New System.Drawing.Point(12, 22)
        Me.grpacc_sel.Name = "grpacc_sel"
        Me.grpacc_sel.Size = New System.Drawing.Size(614, 454)
        Me.grpacc_sel.TabIndex = 13
        Me.grpacc_sel.TabStop = False
        Me.grpacc_sel.Text = "Select Account"
        '
        'lvwAccountDtls
        '
        Me.lvwAccountDtls.CheckBoxes = True
        Me.lvwAccountDtls.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwAccountDtls.FullRowSelect = True
        Me.lvwAccountDtls.GridLines = True
        Me.lvwAccountDtls.Location = New System.Drawing.Point(12, 22)
        Me.lvwAccountDtls.Name = "lvwAccountDtls"
        Me.lvwAccountDtls.Size = New System.Drawing.Size(589, 397)
        Me.lvwAccountDtls.TabIndex = 7
        Me.lvwAccountDtls.UseCompatibleStateImageBehavior = False
        Me.lvwAccountDtls.View = System.Windows.Forms.View.Details
        '
        'mnuSelection
        '
        Me.mnuSelection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSelectAll, Me.mnuUnSelectAll, Me.mnuInvertSelect})
        Me.mnuSelection.Name = "mnuSelection"
        Me.mnuSelection.Size = New System.Drawing.Size(139, 70)
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Name = "mnuSelectAll"
        Me.mnuSelectAll.Size = New System.Drawing.Size(138, 22)
        Me.mnuSelectAll.Text = "Select All"
        '
        'mnuUnSelectAll
        '
        Me.mnuUnSelectAll.Name = "mnuUnSelectAll"
        Me.mnuUnSelectAll.Size = New System.Drawing.Size(138, 22)
        Me.mnuUnSelectAll.Text = "Unselect All"
        '
        'mnuInvertSelect
        '
        Me.mnuInvertSelect.Name = "mnuInvertSelect"
        Me.mnuInvertSelect.Size = New System.Drawing.Size(138, 22)
        Me.mnuInvertSelect.Text = "Invert Select"
        '
        'grpEntryMain
        '
        Me.grpEntryMain.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpEntryMain.Appearance.Options.UseBackColor = True
        Me.grpEntryMain.Controls.Add(Me.btnSave)
        Me.grpEntryMain.Controls.Add(Me.grpsr)
        Me.grpEntryMain.Controls.Add(Me.dtgdetails)
        Me.grpEntryMain.Controls.Add(Me.btnCancel)
        Me.grpEntryMain.Controls.Add(Me.grpenrtybankDetails)
        Me.grpEntryMain.Location = New System.Drawing.Point(3, 5)
        Me.grpEntryMain.LookAndFeel.SkinName = "Money Twins"
        Me.grpEntryMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpEntryMain.Name = "grpEntryMain"
        Me.grpEntryMain.Size = New System.Drawing.Size(978, 548)
        Me.grpEntryMain.TabIndex = 583
        Me.grpEntryMain.Text = "Entry"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(620, 458)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 27)
        Me.btnSave.TabIndex = 535
        Me.btnSave.Text = "&Save"
        '
        'grpsr
        '
        Me.grpsr.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpsr.Controls.Add(Me.btnsrclose)
        Me.grpsr.Controls.Add(Me.txtsrto)
        Me.grpsr.Controls.Add(Me.txtsrfrom)
        Me.grpsr.Controls.Add(Me.btnallupd)
        Me.grpsr.Controls.Add(Me.Label1)
        Me.grpsr.Controls.Add(Me.Label2)
        Me.grpsr.Controls.Add(Me.Label4)
        Me.grpsr.Location = New System.Drawing.Point(167, 358)
        Me.grpsr.Name = "grpsr"
        Me.grpsr.Size = New System.Drawing.Size(201, 86)
        Me.grpsr.TabIndex = 534
        Me.grpsr.TabStop = False
        Me.grpsr.Text = "Sr No"
        Me.grpsr.Visible = False
        '
        'btnsrclose
        '
        Me.btnsrclose.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsrclose.Appearance.Options.UseFont = True
        Me.btnsrclose.Image = CType(resources.GetObject("btnsrclose.Image"), System.Drawing.Image)
        Me.btnsrclose.Location = New System.Drawing.Point(106, 48)
        Me.btnsrclose.Name = "btnsrclose"
        Me.btnsrclose.Size = New System.Drawing.Size(84, 23)
        Me.btnsrclose.TabIndex = 4
        Me.btnsrclose.Text = "C&lose"
        '
        'txtsrto
        '
        Me.txtsrto.AllowAlphabets = False
        Me.txtsrto.AllowMoveToNextControl = False
        Me.txtsrto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsrto.EditValue = 0
        Me.txtsrto.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrto.Location = New System.Drawing.Point(132, 16)
        Me.txtsrto.Name = "txtsrto"
        Me.txtsrto.Size = New System.Drawing.Size(50, 22)
        Me.txtsrto.TabIndex = 2
        Me.txtsrto.Tag = "Discount (%)"
        Me.txtsrto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsrfrom
        '
        Me.txtsrfrom.AllowAlphabets = False
        Me.txtsrfrom.AllowMoveToNextControl = False
        Me.txtsrfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsrfrom.EditValue = 0
        Me.txtsrfrom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrfrom.Location = New System.Drawing.Point(50, 16)
        Me.txtsrfrom.Name = "txtsrfrom"
        Me.txtsrfrom.Size = New System.Drawing.Size(50, 22)
        Me.txtsrfrom.TabIndex = 1
        Me.txtsrfrom.Tag = "Discount (%)"
        Me.txtsrfrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnallupd
        '
        Me.btnallupd.Image = CType(resources.GetObject("btnallupd.Image"), System.Drawing.Image)
        Me.btnallupd.Location = New System.Drawing.Point(16, 48)
        Me.btnallupd.Name = "btnallupd"
        Me.btnallupd.Size = New System.Drawing.Size(84, 23)
        Me.btnallupd.TabIndex = 3
        Me.btnallupd.Text = "&Update"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 14)
        Me.Label2.TabIndex = 527
        Me.Label2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "From"
        '
        'dtgdetails
        '
        Me.dtgdetails.CaptionFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgdetails.CaptionForeColor = System.Drawing.Color.White
        Me.dtgdetails.CaptionText = "Entry Details"
        Me.dtgdetails.DataMember = ""
        Me.dtgdetails.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgdetails.HeaderFont = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgdetails.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgdetails.Location = New System.Drawing.Point(3, 23)
        Me.dtgdetails.Name = "dtgdetails"
        Me.dtgdetails.Size = New System.Drawing.Size(967, 418)
        Me.dtgdetails.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(695, 458)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 27)
        Me.btnCancel.TabIndex = 536
        Me.btnCancel.Text = "Cance&l"
        '
        'grpenrtybankDetails
        '
        Me.grpenrtybankDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpenrtybankDetails.Controls.Add(Me.Label3)
        Me.grpenrtybankDetails.Controls.Add(Me.lblTotAmt)
        Me.grpenrtybankDetails.Controls.Add(Me.Label17)
        Me.grpenrtybankDetails.Controls.Add(Me.lblTotTDS)
        Me.grpenrtybankDetails.Controls.Add(Me.txtchq_no)
        Me.grpenrtybankDetails.Controls.Add(Me.btnUpdateAll)
        Me.grpenrtybankDetails.Controls.Add(Me.btnUpdate)
        Me.grpenrtybankDetails.Controls.Add(Me.dtpChallandt)
        Me.grpenrtybankDetails.Controls.Add(Me.Label92)
        Me.grpenrtybankDetails.Controls.Add(Me.txtChallanNo)
        Me.grpenrtybankDetails.Controls.Add(Me.Label74)
        Me.grpenrtybankDetails.Controls.Add(Me.cmbBank)
        Me.grpenrtybankDetails.Controls.Add(Me.lblBarLocation)
        Me.grpenrtybankDetails.Controls.Add(Me.Label85)
        Me.grpenrtybankDetails.Controls.Add(Me.Label89)
        Me.grpenrtybankDetails.Location = New System.Drawing.Point(8, 438)
        Me.grpenrtybankDetails.Name = "grpenrtybankDetails"
        Me.grpenrtybankDetails.Size = New System.Drawing.Size(605, 100)
        Me.grpenrtybankDetails.TabIndex = 533
        Me.grpenrtybankDetails.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(418, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 531
        Me.Label3.Text = "Tot Amt :"
        '
        'lblTotAmt
        '
        Me.lblTotAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotAmt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotAmt.Location = New System.Drawing.Point(481, 44)
        Me.lblTotAmt.Name = "lblTotAmt"
        Me.lblTotAmt.Size = New System.Drawing.Size(111, 21)
        Me.lblTotAmt.TabIndex = 530
        Me.lblTotAmt.Text = "0"
        Me.lblTotAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(420, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 18)
        Me.Label17.TabIndex = 529
        Me.Label17.Text = "Tot TDS :"
        '
        'lblTotTDS
        '
        Me.lblTotTDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotTDS.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTDS.Location = New System.Drawing.Point(480, 18)
        Me.lblTotTDS.Name = "lblTotTDS"
        Me.lblTotTDS.Size = New System.Drawing.Size(113, 21)
        Me.lblTotTDS.TabIndex = 528
        Me.lblTotTDS.Text = "0"
        Me.lblTotTDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtchq_no
        '
        Me.txtchq_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtchq_no.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchq_no.Location = New System.Drawing.Point(275, 16)
        Me.txtchq_no.MaxLength = 30
        Me.txtchq_no.Name = "txtchq_no"
        Me.txtchq_no.Size = New System.Drawing.Size(138, 22)
        Me.txtchq_no.TabIndex = 3
        Me.txtchq_no.Tag = "Product"
        '
        'btnUpdateAll
        '
        Me.btnUpdateAll.Image = CType(resources.GetObject("btnUpdateAll.Image"), System.Drawing.Image)
        Me.btnUpdateAll.Location = New System.Drawing.Point(194, 72)
        Me.btnUpdateAll.Name = "btnUpdateAll"
        Me.btnUpdateAll.Size = New System.Drawing.Size(84, 23)
        Me.btnUpdateAll.TabIndex = 6
        Me.btnUpdateAll.Text = "Update &All"
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(108, 72)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "&Update"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.Color.Transparent
        Me.Label92.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(204, 19)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(69, 17)
        Me.Label92.TabIndex = 13
        Me.Label92.Text = "Cheque No"
        '
        'txtChallanNo
        '
        Me.txtChallanNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChallanNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChallanNo.Location = New System.Drawing.Point(81, 16)
        Me.txtChallanNo.MaxLength = 30
        Me.txtChallanNo.Name = "txtChallanNo"
        Me.txtChallanNo.Size = New System.Drawing.Size(99, 22)
        Me.txtChallanNo.TabIndex = 1
        Me.txtChallanNo.Tag = "Product"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(448, 21)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(0, 14)
        Me.Label74.TabIndex = 527
        Me.Label74.Visible = False
        '
        'cmbBank
        '
        Appearance1.FontData.Name = "Verdana"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.cmbBank.Appearance = Appearance1
        Me.cmbBank.AutoComplete = True
        Me.cmbBank.AutoSize = False
        Me.cmbBank.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbBank.FlatMode = True
        Me.cmbBank.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBank.Location = New System.Drawing.Point(275, 42)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(138, 21)
        Me.cmbBank.TabIndex = 4
        Me.cmbBank.Tag = "Bank"
        '
        'lblBarLocation
        '
        Me.lblBarLocation.AutoSize = True
        Me.lblBarLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblBarLocation.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarLocation.Location = New System.Drawing.Point(204, 44)
        Me.lblBarLocation.Name = "lblBarLocation"
        Me.lblBarLocation.Size = New System.Drawing.Size(36, 17)
        Me.lblBarLocation.TabIndex = 0
        Me.lblBarLocation.Text = "Bank"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(5, 19)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(68, 17)
        Me.Label85.TabIndex = 6
        Me.Label85.Text = "Challan No"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.BackColor = System.Drawing.Color.Transparent
        Me.Label89.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label89.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label89.Location = New System.Drawing.Point(5, 44)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(70, 17)
        Me.Label89.TabIndex = 7
        Me.Label89.Text = "Challan Dt."
        '
        'dtpChallandt
        '
        Me.dtpChallandt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChallandt.Location = New System.Drawing.Point(81, 41)
        Me.dtpChallandt.Name = "dtpChallandt"
        Me.dtpChallandt.Size = New System.Drawing.Size(99, 22)
        Me.dtpChallandt.TabIndex = 2
        Me.dtpChallandt.Tag = "Bill Date"
        Me.dtpChallandt.Value = New Date(2020, 12, 15, 0, 0, 0, 0)
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(80, 46)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(104, 23)
        Me.dtpTo.TabIndex = 2
        Me.dtpTo.Value = New Date(2020, 12, 15, 0, 0, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(80, 22)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(104, 23)
        Me.dtpFrom.TabIndex = 1
        Me.dtpFrom.Value = New Date(2020, 12, 15, 0, 0, 0, 0)
        '
        'frmTDSEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 561)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.grpEntryMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmTDSEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TDS Challan Entry"
        Me.grpMain.ResumeLayout(False)
        Me.grpdate_party.ResumeLayout(False)
        Me.grpdate_party.PerformLayout()
        Me.grpentry.ResumeLayout(False)
        Me.grpentry.PerformLayout()
        Me.grpdate_range.ResumeLayout(False)
        Me.grpdate_range.PerformLayout()
        Me.grpacc_sel.ResumeLayout(False)
        Me.mnuSelection.ResumeLayout(False)
        CType(Me.grpEntryMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntryMain.ResumeLayout(False)
        Me.grpsr.ResumeLayout(False)
        Me.grpsr.PerformLayout()
        CType(Me.dtgdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpenrtybankDetails.ResumeLayout(False)
        Me.grpenrtybankDetails.PerformLayout()
        CType(Me.cmbBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents mnuSelection As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUnSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInvertSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvwAccountDtls As System.Windows.Forms.ListView
    Friend WithEvents grpacc_sel As System.Windows.Forms.GroupBox
    Friend WithEvents btnEntry As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpdate_party As System.Windows.Forms.GroupBox
    Friend WithEvents rdPartyWise As System.Windows.Forms.RadioButton
    Friend WithEvents rdDateWise As System.Windows.Forms.RadioButton
    Friend WithEvents grpentry As System.Windows.Forms.GroupBox
    Friend WithEvents rdUnPaid As System.Windows.Forms.RadioButton
    Friend WithEvents rdAllEntry As System.Windows.Forms.RadioButton
    Friend WithEvents grpdate_range As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
    Friend WithEvents grpEntryMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpsr As System.Windows.Forms.GroupBox
    Friend WithEvents btnsrclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtsrto As NumericTextBox.NumericTextBox
    Friend WithEvents txtsrfrom As NumericTextBox.NumericTextBox
    Friend WithEvents btnallupd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtgdetails As System.Windows.Forms.DataGrid
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpenrtybankDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtchq_no As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpChallandt As DateTimePick.DateTimePick
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents txtChallanNo As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents cmbBank As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblBarLocation As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotAmt As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblTotTDS As System.Windows.Forms.Label
End Class
