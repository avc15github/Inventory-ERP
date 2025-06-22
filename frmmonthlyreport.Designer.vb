<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmonthlyreport
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
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.pnlPartyOptions = New System.Windows.Forms.Panel
        Me.rdVendor = New System.Windows.Forms.RadioButton
        Me.rdCustomer = New System.Windows.Forms.RadioButton
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
        Me.cmbExecutedBy = New CustomCheckbox.CustomEdit
        Me.cmbSalesOrder = New CustomCheckbox.CustomEdit
        Me.lblSubGroup = New System.Windows.Forms.Label
        Me.lblGroup = New System.Windows.Forms.Label
        Me.pnlLocation = New System.Windows.Forms.Panel
        Me.cmbCountry = New CustomCheckbox.CustomEdit
        Me.cmbBrand = New CustomCheckbox.CustomEdit
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.grpMain.SuspendLayout()
        Me.pnlPartyOptions.SuspendLayout()
        Me.pnlDate.SuspendLayout()
        Me.pnlSummaryDetail.SuspendLayout()
        Me.pnlLedger.SuspendLayout()
        CType(Me.cmbExecutedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLocation.SuspendLayout()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.pnlPartyOptions)
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
        Me.pnlPartyOptions.Controls.Add(Me.rdCustomer)
        Me.pnlPartyOptions.Location = New System.Drawing.Point(16, 53)
        Me.pnlPartyOptions.Name = "pnlPartyOptions"
        Me.pnlPartyOptions.Size = New System.Drawing.Size(298, 26)
        Me.pnlPartyOptions.TabIndex = 1
        '
        'rdVendor
        '
        Me.rdVendor.AutoSize = True
        Me.rdVendor.Location = New System.Drawing.Point(180, 3)
        Me.rdVendor.Name = "rdVendor"
        Me.rdVendor.Size = New System.Drawing.Size(63, 19)
        Me.rdVendor.TabIndex = 1
        Me.rdVendor.Text = "Vendor"
        Me.rdVendor.UseVisualStyleBackColor = True
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
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.lblFrom)
        Me.pnlDate.Controls.Add(Me.lblTo)
        Me.pnlDate.Controls.Add(Me.dtpFrom)
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
        Me.dtpTo.Value = New Date(2018, 9, 7, 0, 0, 0, 0)
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
        Me.dtpFrom.Value = New Date(2018, 9, 7, 0, 0, 0, 0)
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
        Me.btnClose.Location = New System.Drawing.Point(273, 255)
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
        Me.btnView.Location = New System.Drawing.Point(154, 255)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 26)
        Me.btnView.TabIndex = 6
        Me.btnView.Text = "View"
        '
        'pnlLedger
        '
        Me.pnlLedger.Controls.Add(Me.cmbExecutedBy)
        Me.pnlLedger.Controls.Add(Me.cmbSalesOrder)
        Me.pnlLedger.Controls.Add(Me.lblSubGroup)
        Me.pnlLedger.Controls.Add(Me.lblGroup)
        Me.pnlLedger.Location = New System.Drawing.Point(17, 154)
        Me.pnlLedger.Name = "pnlLedger"
        Me.pnlLedger.Size = New System.Drawing.Size(298, 71)
        Me.pnlLedger.TabIndex = 4
        '
        'cmbExecutedBy
        '
        Me.cmbExecutedBy.EditValue = ""
        Me.cmbExecutedBy.Location = New System.Drawing.Point(79, 30)
        Me.cmbExecutedBy.Name = "cmbExecutedBy"
        Me.cmbExecutedBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbExecutedBy.Properties.IncrementalSearch = True
        Me.cmbExecutedBy.Size = New System.Drawing.Size(209, 20)
        Me.cmbExecutedBy.TabIndex = 7
        Me.cmbExecutedBy.Tag = "Product"
        '
        'cmbSalesOrder
        '
        Me.cmbSalesOrder.EditValue = ""
        Me.cmbSalesOrder.Location = New System.Drawing.Point(79, 5)
        Me.cmbSalesOrder.Name = "cmbSalesOrder"
        Me.cmbSalesOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSalesOrder.Properties.IncrementalSearch = True
        Me.cmbSalesOrder.Size = New System.Drawing.Size(209, 20)
        Me.cmbSalesOrder.TabIndex = 6
        Me.cmbSalesOrder.Tag = "Product"
        '
        'lblSubGroup
        '
        Me.lblSubGroup.AutoSize = True
        Me.lblSubGroup.Location = New System.Drawing.Point(7, 33)
        Me.lblSubGroup.Name = "lblSubGroup"
        Me.lblSubGroup.Size = New System.Drawing.Size(48, 15)
        Me.lblSubGroup.TabIndex = 2
        Me.lblSubGroup.Text = "Vertical"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(7, 8)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(69, 15)
        Me.lblGroup.TabIndex = 0
        Me.lblGroup.Text = "Sales order"
        '
        'pnlLocation
        '
        Me.pnlLocation.Controls.Add(Me.cmbCountry)
        Me.pnlLocation.Controls.Add(Me.cmbBrand)
        Me.pnlLocation.Controls.Add(Me.lblCity)
        Me.pnlLocation.Controls.Add(Me.lblState)
        Me.pnlLocation.Location = New System.Drawing.Point(16, 85)
        Me.pnlLocation.Name = "pnlLocation"
        Me.pnlLocation.Size = New System.Drawing.Size(298, 57)
        Me.pnlLocation.TabIndex = 3
        '
        'cmbCountry
        '
        Me.cmbCountry.EditValue = ""
        Me.cmbCountry.Location = New System.Drawing.Point(79, 6)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCountry.Properties.IncrementalSearch = True
        Me.cmbCountry.Size = New System.Drawing.Size(209, 20)
        Me.cmbCountry.TabIndex = 4
        Me.cmbCountry.Tag = "State"
        '
        'cmbBrand
        '
        Me.cmbBrand.EditValue = ""
        Me.cmbBrand.Location = New System.Drawing.Point(79, 31)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBrand.Properties.IncrementalSearch = True
        Me.cmbBrand.Size = New System.Drawing.Size(209, 20)
        Me.cmbBrand.TabIndex = 5
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(7, 32)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(40, 15)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "Brand"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(7, 8)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(50, 15)
        Me.lblState.TabIndex = 0
        Me.lblState.Text = "Country"
        '
        'frmmonthlyreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 347)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmmonthlyreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Report"
        Me.grpMain.ResumeLayout(False)
        Me.pnlPartyOptions.ResumeLayout(False)
        Me.pnlPartyOptions.PerformLayout()
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.pnlSummaryDetail.ResumeLayout(False)
        Me.pnlSummaryDetail.PerformLayout()
        Me.pnlLedger.ResumeLayout(False)
        Me.pnlLedger.PerformLayout()
        CType(Me.cmbExecutedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLocation.ResumeLayout(False)
        Me.pnlLocation.PerformLayout()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents pnlLocation As System.Windows.Forms.Panel
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
    Friend WithEvents rdSummary As System.Windows.Forms.RadioButton
    Friend WithEvents rdDetailed As System.Windows.Forms.RadioButton
    Friend WithEvents pnlSummaryDetail As System.Windows.Forms.Panel
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents pnlPartyOptions As System.Windows.Forms.Panel
    Friend WithEvents rdVendor As System.Windows.Forms.RadioButton
    Friend WithEvents rdCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents cmbBrand As CustomCheckbox.CustomEdit
    Friend WithEvents cmbCountry As CustomCheckbox.CustomEdit
    Friend WithEvents pnlLedger As System.Windows.Forms.Panel
    Friend WithEvents cmbExecutedBy As CustomCheckbox.CustomEdit
    Friend WithEvents cmbSalesOrder As CustomCheckbox.CustomEdit
    Friend WithEvents lblSubGroup As System.Windows.Forms.Label
    Friend WithEvents lblGroup As System.Windows.Forms.Label
End Class
