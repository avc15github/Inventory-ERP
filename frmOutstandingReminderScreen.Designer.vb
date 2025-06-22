<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutstandingReminderScreen
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
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSend = New System.Windows.Forms.ToolStripDropDownButton
        Me.mnuCustomer = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuWholesaleCustomer = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuVendors = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbLedger = New CustomCheckbox.CustomEdit
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.dtgBill = New System.Windows.Forms.DataGrid
        Me.mnuSelection = New System.Windows.Forms.ContextMenu
        Me.mnuSelectAll = New System.Windows.Forms.MenuItem
        Me.mnuUnSelectAll = New System.Windows.Forms.MenuItem
        Me.mnuInvertSelect = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.cmbLedger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpMain.Appearance.Options.UseBackColor = True
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.ToolStrip1)
        Me.grpMain.Controls.Add(Me.cmbLedger)
        Me.grpMain.Controls.Add(Me.btnCancel)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.btnShow)
        Me.grpMain.Controls.Add(Me.dtgBill)
        Me.grpMain.Location = New System.Drawing.Point(2, 2)
        Me.grpMain.LookAndFeel.SkinName = "Blue"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(981, 595)
        Me.grpMain.TabIndex = 1
        Me.grpMain.Text = "GroupControl1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSend})
        Me.ToolStrip1.Location = New System.Drawing.Point(616, 7)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(131, 25)
        Me.ToolStrip1.TabIndex = 139
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSend
        '
        Me.btnSend.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomer, Me.mnuWholesaleCustomer, Me.mnuVendors})
        Me.btnSend.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(128, 22)
        Me.btnSend.Text = "Send To Customer.."
        '
        'mnuCustomer
        '
        Me.mnuCustomer.Name = "mnuCustomer"
        Me.mnuCustomer.Size = New System.Drawing.Size(178, 22)
        Me.mnuCustomer.Text = "Send As Email"
        '
        'mnuWholesaleCustomer
        '
        Me.mnuWholesaleCustomer.Name = "mnuWholesaleCustomer"
        Me.mnuWholesaleCustomer.Size = New System.Drawing.Size(178, 22)
        Me.mnuWholesaleCustomer.Text = "Send As WhatsApp"
        '
        'mnuVendors
        '
        Me.mnuVendors.Name = "mnuVendors"
        Me.mnuVendors.Size = New System.Drawing.Size(178, 22)
        Me.mnuVendors.Text = "Send Via Both"
        '
        'cmbLedger
        '
        Me.cmbLedger.Location = New System.Drawing.Point(73, 11)
        Me.cmbLedger.Name = "cmbLedger"
        Me.cmbLedger.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLedger.Properties.IncrementalSearch = True
        Me.cmbLedger.Size = New System.Drawing.Size(312, 20)
        Me.cmbLedger.TabIndex = 1
        Me.cmbLedger.Tag = "Party"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Location = New System.Drawing.Point(442, 562)
        Me.btnCancel.LookAndFeel.SkinName = "Money Twins"
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Close"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Brown
        Me.Label5.Location = New System.Drawing.Point(13, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Party"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.Control
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.Brown
        Me.btnShow.Location = New System.Drawing.Point(425, 6)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(71, 29)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Display"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'dtgBill
        '
        Me.dtgBill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtgBill.CaptionBackColor = System.Drawing.Color.Maroon
        Me.dtgBill.CaptionFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBill.CaptionText = "Series Details"
        Me.dtgBill.CaptionVisible = False
        Me.dtgBill.DataMember = ""
        Me.dtgBill.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBill.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBill.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgBill.Location = New System.Drawing.Point(6, 54)
        Me.dtgBill.Name = "dtgBill"
        Me.dtgBill.Size = New System.Drawing.Size(971, 498)
        Me.dtgBill.TabIndex = 13
        '
        'mnuSelection
        '
        Me.mnuSelection.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSelectAll, Me.mnuUnSelectAll, Me.mnuInvertSelect})
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Index = 0
        Me.mnuSelectAll.Text = "Select All"
        '
        'mnuUnSelectAll
        '
        Me.mnuUnSelectAll.Index = 1
        Me.mnuUnSelectAll.Text = "Unselect All"
        '
        'mnuInvertSelect
        '
        Me.mnuInvertSelect.Index = 2
        Me.mnuInvertSelect.Text = "Invert Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(899, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'frmOutstandingReminderScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 600)
        Me.Controls.Add(Me.grpMain)
        Me.MaximizeBox = False
        Me.Name = "frmOutstandingReminderScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Outstanding Reminder (Party Wise)"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.cmbLedger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtgBill As System.Windows.Forms.DataGrid
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mnuSelection As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUnSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInvertSelect As System.Windows.Forms.MenuItem
    Friend WithEvents cmbLedger As CustomCheckbox.CustomEdit
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSend As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWholesaleCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVendors As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
