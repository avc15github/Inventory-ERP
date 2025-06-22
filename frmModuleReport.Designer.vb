<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuleReport
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
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.lblReportType = New System.Windows.Forms.Label
        Me.cmbPackingD = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbParty = New System.Windows.Forms.ComboBox
        Me.cmbSample = New System.Windows.Forms.ComboBox
        Me.pnlCostSheetType = New System.Windows.Forms.Panel
        Me.rdCostSheet = New System.Windows.Forms.RadioButton
        Me.rdPartySupl = New System.Windows.Forms.RadioButton
        Me.btnView = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.grpMain.SuspendLayout()
        Me.pnlCostSheetType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpMain.Controls.Add(Me.lblReportType)
        Me.grpMain.Controls.Add(Me.cmbPackingD)
        Me.grpMain.Controls.Add(Me.Label4)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.cmbParty)
        Me.grpMain.Controls.Add(Me.cmbSample)
        Me.grpMain.Controls.Add(Me.pnlCostSheetType)
        Me.grpMain.Controls.Add(Me.btnView)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.btnPrint)
        Me.grpMain.Location = New System.Drawing.Point(2, 1)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(374, 189)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'lblReportType
        '
        Me.lblReportType.AutoSize = True
        Me.lblReportType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportType.Location = New System.Drawing.Point(8, 119)
        Me.lblReportType.Name = "lblReportType"
        Me.lblReportType.Size = New System.Drawing.Size(86, 13)
        Me.lblReportType.TabIndex = 20
        Me.lblReportType.Text = "Report Type"
        Me.lblReportType.Visible = False
        '
        'cmbPackingD
        '
        Me.cmbPackingD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPackingD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPackingD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPackingD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPackingD.FormattingEnabled = True
        Me.cmbPackingD.Location = New System.Drawing.Point(104, 115)
        Me.cmbPackingD.Name = "cmbPackingD"
        Me.cmbPackingD.Size = New System.Drawing.Size(238, 21)
        Me.cmbPackingD.TabIndex = 19
        Me.cmbPackingD.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Party"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Style No"
        '
        'cmbParty
        '
        Me.cmbParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbParty.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParty.FormattingEnabled = True
        Me.cmbParty.Location = New System.Drawing.Point(104, 57)
        Me.cmbParty.Name = "cmbParty"
        Me.cmbParty.Size = New System.Drawing.Size(238, 21)
        Me.cmbParty.TabIndex = 4
        '
        'cmbSample
        '
        Me.cmbSample.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSample.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSample.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSample.FormattingEnabled = True
        Me.cmbSample.Location = New System.Drawing.Point(104, 86)
        Me.cmbSample.Name = "cmbSample"
        Me.cmbSample.Size = New System.Drawing.Size(238, 21)
        Me.cmbSample.TabIndex = 5
        '
        'pnlCostSheetType
        '
        Me.pnlCostSheetType.Controls.Add(Me.rdCostSheet)
        Me.pnlCostSheetType.Controls.Add(Me.rdPartySupl)
        Me.pnlCostSheetType.Location = New System.Drawing.Point(25, 19)
        Me.pnlCostSheetType.Name = "pnlCostSheetType"
        Me.pnlCostSheetType.Size = New System.Drawing.Size(316, 28)
        Me.pnlCostSheetType.TabIndex = 14
        Me.pnlCostSheetType.Visible = False
        '
        'rdCostSheet
        '
        Me.rdCostSheet.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCostSheet.Location = New System.Drawing.Point(11, 4)
        Me.rdCostSheet.Name = "rdCostSheet"
        Me.rdCostSheet.Size = New System.Drawing.Size(112, 16)
        Me.rdCostSheet.TabIndex = 6
        Me.rdCostSheet.Text = "Cost Sheet"
        '
        'rdPartySupl
        '
        Me.rdPartySupl.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.rdPartySupl.Location = New System.Drawing.Point(171, 1)
        Me.rdPartySupl.Name = "rdPartySupl"
        Me.rdPartySupl.Size = New System.Drawing.Size(136, 26)
        Me.rdPartySupl.TabIndex = 7
        Me.rdPartySupl.Text = "Buyer Cost Sheet"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(103, 149)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(88, 28)
        Me.btnView.TabIndex = 8
        Me.btnView.Text = "&View"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(213, 149)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 28)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "&Close"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(0, 135)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 28)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.Visible = False
        '
        'frmModuleReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 191)
        Me.Controls.Add(Me.grpMain)
        Me.Location = New System.Drawing.Point(80, 80)
        Me.MaximizeBox = False
        Me.Name = "frmModuleReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Module Reports"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.pnlCostSheetType.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbParty As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSample As System.Windows.Forms.ComboBox

    Public Sub New(ByVal rptType As ReportType)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        bytRptType = rptType
    End Sub
    Friend WithEvents pnlCostSheetType As System.Windows.Forms.Panel
    Friend WithEvents rdCostSheet As System.Windows.Forms.RadioButton
    Friend WithEvents rdPartySupl As System.Windows.Forms.RadioButton
    Friend WithEvents cmbPackingD As System.Windows.Forms.ComboBox
    Friend WithEvents lblReportType As System.Windows.Forms.Label
End Class
