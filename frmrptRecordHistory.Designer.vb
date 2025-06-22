<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptRecordHistory
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
        Me.rdDelete = New System.Windows.Forms.RadioButton
        Me.rdEdit = New System.Windows.Forms.RadioButton
        Me.rdAdd = New System.Windows.Forms.RadioButton
        Me.rdAll = New System.Windows.Forms.RadioButton
        Me.lblParty = New System.Windows.Forms.Label
        Me.cmbUsers = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.dtpTo = New DateTimePick.DateTimePick
        Me.lblFrom = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.dtpFrom = New DateTimePick.DateTimePick
        Me.chkSize = New System.Windows.Forms.CheckBox
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnView = New DevExpress.XtraEditors.SimpleButton
        Me.grpMain.SuspendLayout()
        CType(Me.cmbUsers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.rdDelete)
        Me.grpMain.Controls.Add(Me.rdEdit)
        Me.grpMain.Controls.Add(Me.rdAdd)
        Me.grpMain.Controls.Add(Me.rdAll)
        Me.grpMain.Controls.Add(Me.lblParty)
        Me.grpMain.Controls.Add(Me.cmbUsers)
        Me.grpMain.Controls.Add(Me.pnlDate)
        Me.grpMain.Controls.Add(Me.chkSize)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Controls.Add(Me.btnView)
        Me.grpMain.Location = New System.Drawing.Point(9, 3)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(319, 187)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'rdDelete
        '
        Me.rdDelete.AutoSize = True
        Me.rdDelete.Location = New System.Drawing.Point(242, 109)
        Me.rdDelete.Name = "rdDelete"
        Me.rdDelete.Size = New System.Drawing.Size(69, 18)
        Me.rdDelete.TabIndex = 6
        Me.rdDelete.Text = "Deleted"
        Me.rdDelete.UseVisualStyleBackColor = True
        '
        'rdEdit
        '
        Me.rdEdit.AutoSize = True
        Me.rdEdit.Location = New System.Drawing.Point(161, 109)
        Me.rdEdit.Name = "rdEdit"
        Me.rdEdit.Size = New System.Drawing.Size(60, 18)
        Me.rdEdit.TabIndex = 5
        Me.rdEdit.Text = "Edited"
        Me.rdEdit.UseVisualStyleBackColor = True
        '
        'rdAdd
        '
        Me.rdAdd.AutoSize = True
        Me.rdAdd.Location = New System.Drawing.Point(80, 109)
        Me.rdAdd.Name = "rdAdd"
        Me.rdAdd.Size = New System.Drawing.Size(60, 18)
        Me.rdAdd.TabIndex = 4
        Me.rdAdd.Text = "Added"
        Me.rdAdd.UseVisualStyleBackColor = True
        '
        'rdAll
        '
        Me.rdAll.AutoSize = True
        Me.rdAll.Checked = True
        Me.rdAll.Location = New System.Drawing.Point(19, 109)
        Me.rdAll.Name = "rdAll"
        Me.rdAll.Size = New System.Drawing.Size(40, 18)
        Me.rdAll.TabIndex = 3
        Me.rdAll.TabStop = True
        Me.rdAll.Text = "All"
        Me.rdAll.UseVisualStyleBackColor = True
        '
        'lblParty
        '
        Me.lblParty.AutoSize = True
        Me.lblParty.Location = New System.Drawing.Point(34, 66)
        Me.lblParty.Name = "lblParty"
        Me.lblParty.Size = New System.Drawing.Size(38, 14)
        Me.lblParty.TabIndex = 1
        Me.lblParty.Text = "Users"
        '
        'cmbUsers
        '
        Me.cmbUsers.EnterMoveNextControl = True
        Me.cmbUsers.Location = New System.Drawing.Point(72, 64)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsers.Properties.Appearance.Options.UseFont = True
        Me.cmbUsers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbUsers.Properties.PopupFormMinSize = New System.Drawing.Size(0, 150)
        Me.cmbUsers.Properties.PopupFormSize = New System.Drawing.Size(0, 150)
        Me.cmbUsers.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize
        Me.cmbUsers.Size = New System.Drawing.Size(209, 21)
        Me.cmbUsers.TabIndex = 2
        Me.cmbUsers.Tag = "Party"
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.lblFrom)
        Me.pnlDate.Controls.Add(Me.lblTo)
        Me.pnlDate.Controls.Add(Me.dtpFrom)
        Me.pnlDate.Location = New System.Drawing.Point(27, 15)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(265, 31)
        Me.pnlDate.TabIndex = 0
        '
        'dtpTo
        '
        'Me.dtpTo.CustomFormat = "dd/MM/yyyy"
        'Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(166, 4)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(89, 22)
        Me.dtpTo.TabIndex = 3
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(5, 8)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(34, 14)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(145, 8)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(19, 14)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFrom
        '
        'Me.dtpFrom.CustomFormat = "dd/MM/yyyy"
        'Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(42, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(89, 22)
        Me.dtpFrom.TabIndex = 1
        '
        'chkSize
        '
        Me.chkSize.AutoSize = True
        Me.chkSize.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSize.Location = New System.Drawing.Point(27, 386)
        Me.chkSize.Name = "chkSize"
        Me.chkSize.Size = New System.Drawing.Size(76, 19)
        Me.chkSize.TabIndex = 13
        Me.chkSize.Text = "View Size"
        Me.chkSize.UseVisualStyleBackColor = True
        Me.chkSize.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(177, 147)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 26)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        '
        'btnView
        '
        Me.btnView.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Appearance.Options.UseFont = True
        Me.btnView.Location = New System.Drawing.Point(53, 147)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 26)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "View"
        '
        'frmrptRecordHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 197)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmrptRecordHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record History"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.cmbUsers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
    Friend WithEvents chkSize As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblParty As System.Windows.Forms.Label
    Friend WithEvents cmbUsers As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents rdDelete As System.Windows.Forms.RadioButton
    Friend WithEvents rdEdit As System.Windows.Forms.RadioButton
    Friend WithEvents rdAdd As System.Windows.Forms.RadioButton
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
End Class
