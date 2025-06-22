<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualMatching
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
        Me.pnlRecvPayable = New System.Windows.Forms.Panel
        Me.rdReceivables = New System.Windows.Forms.RadioButton
        Me.rdPayables = New System.Windows.Forms.RadioButton
        Me.pnlPartySel = New System.Windows.Forms.Panel
        Me.rdOneParty = New System.Windows.Forms.RadioButton
        Me.rdAllParties = New System.Windows.Forms.RadioButton
        Me.pnlParty = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbParty = New System.Windows.Forms.ComboBox
        Me.lblBroker = New System.Windows.Forms.Label
        Me.cmbBroker = New System.Windows.Forms.ComboBox
        Me.pnlTrans = New System.Windows.Forms.Panel
        Me.rdAllTrans = New System.Windows.Forms.RadioButton
        Me.rdOnlyOSTrans = New System.Windows.Forms.RadioButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnView = New DevExpress.XtraEditors.SimpleButton
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.pnlRecvPayable.SuspendLayout()
        Me.pnlPartySel.SuspendLayout()
        Me.pnlParty.SuspendLayout()
        Me.pnlTrans.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRecvPayable
        '
        Me.pnlRecvPayable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRecvPayable.Controls.Add(Me.rdReceivables)
        Me.pnlRecvPayable.Controls.Add(Me.rdPayables)
        Me.pnlRecvPayable.Location = New System.Drawing.Point(413, 104)
        Me.pnlRecvPayable.Name = "pnlRecvPayable"
        Me.pnlRecvPayable.Size = New System.Drawing.Size(269, 36)
        Me.pnlRecvPayable.TabIndex = 0
        '
        'rdReceivables
        '
        Me.rdReceivables.Checked = True
        Me.rdReceivables.Location = New System.Drawing.Point(19, 8)
        Me.rdReceivables.Name = "rdReceivables"
        Me.rdReceivables.Size = New System.Drawing.Size(93, 17)
        Me.rdReceivables.TabIndex = 0
        Me.rdReceivables.TabStop = True
        Me.rdReceivables.Text = "Receivables"
        '
        'rdPayables
        '
        Me.rdPayables.Location = New System.Drawing.Point(146, 8)
        Me.rdPayables.Name = "rdPayables"
        Me.rdPayables.Size = New System.Drawing.Size(112, 18)
        Me.rdPayables.TabIndex = 1
        Me.rdPayables.Text = "Payables"
        '
        'pnlPartySel
        '
        Me.pnlPartySel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPartySel.Controls.Add(Me.rdOneParty)
        Me.pnlPartySel.Controls.Add(Me.rdAllParties)
        Me.pnlPartySel.Location = New System.Drawing.Point(413, 165)
        Me.pnlPartySel.Name = "pnlPartySel"
        Me.pnlPartySel.Size = New System.Drawing.Size(269, 36)
        Me.pnlPartySel.TabIndex = 1
        '
        'rdOneParty
        '
        Me.rdOneParty.Checked = True
        Me.rdOneParty.Location = New System.Drawing.Point(19, 8)
        Me.rdOneParty.Name = "rdOneParty"
        Me.rdOneParty.Size = New System.Drawing.Size(93, 17)
        Me.rdOneParty.TabIndex = 0
        Me.rdOneParty.TabStop = True
        Me.rdOneParty.Text = "One Party"
        '
        'rdAllParties
        '
        Me.rdAllParties.Location = New System.Drawing.Point(146, 8)
        Me.rdAllParties.Name = "rdAllParties"
        Me.rdAllParties.Size = New System.Drawing.Size(112, 18)
        Me.rdAllParties.TabIndex = 1
        Me.rdAllParties.Text = "All Parties"
        '
        'pnlParty
        '
        Me.pnlParty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlParty.Controls.Add(Me.Label8)
        Me.pnlParty.Controls.Add(Me.cmbParty)
        Me.pnlParty.Location = New System.Drawing.Point(293, 260)
        Me.pnlParty.Name = "pnlParty"
        Me.pnlParty.Size = New System.Drawing.Size(493, 38)
        Me.pnlParty.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Tag = ""
        Me.Label8.Text = "Party"
        '
        'cmbParty
        '
        Me.cmbParty.Location = New System.Drawing.Point(99, 8)
        Me.cmbParty.Name = "cmbParty"
        Me.cmbParty.Size = New System.Drawing.Size(364, 21)
        Me.cmbParty.TabIndex = 1
        Me.cmbParty.Tag = "To Broker"
        '
        'lblBroker
        '
        Me.lblBroker.AutoSize = True
        Me.lblBroker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBroker.Location = New System.Drawing.Point(330, 226)
        Me.lblBroker.Name = "lblBroker"
        Me.lblBroker.Size = New System.Drawing.Size(51, 13)
        Me.lblBroker.TabIndex = 2
        Me.lblBroker.Tag = ""
        Me.lblBroker.Text = "Broker"
        '
        'cmbBroker
        '
        Me.cmbBroker.Location = New System.Drawing.Point(413, 223)
        Me.cmbBroker.Name = "cmbBroker"
        Me.cmbBroker.Size = New System.Drawing.Size(269, 21)
        Me.cmbBroker.TabIndex = 3
        Me.cmbBroker.Tag = "Broker"
        '
        'pnlTrans
        '
        Me.pnlTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTrans.Controls.Add(Me.rdAllTrans)
        Me.pnlTrans.Controls.Add(Me.rdOnlyOSTrans)
        Me.pnlTrans.Location = New System.Drawing.Point(413, 336)
        Me.pnlTrans.Name = "pnlTrans"
        Me.pnlTrans.Size = New System.Drawing.Size(269, 36)
        Me.pnlTrans.TabIndex = 5
        '
        'rdAllTrans
        '
        Me.rdAllTrans.Checked = True
        Me.rdAllTrans.Location = New System.Drawing.Point(19, 8)
        Me.rdAllTrans.Name = "rdAllTrans"
        Me.rdAllTrans.Size = New System.Drawing.Size(102, 17)
        Me.rdAllTrans.TabIndex = 0
        Me.rdAllTrans.TabStop = True
        Me.rdAllTrans.Text = "All Transactions"
        '
        'rdOnlyOSTrans
        '
        Me.rdOnlyOSTrans.Location = New System.Drawing.Point(146, 8)
        Me.rdOnlyOSTrans.Name = "rdOnlyOSTrans"
        Me.rdOnlyOSTrans.Size = New System.Drawing.Size(112, 18)
        Me.rdOnlyOSTrans.TabIndex = 1
        Me.rdOnlyOSTrans.Text = "Only Outstanding"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(559, 446)
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
        Me.btnView.Location = New System.Drawing.Point(440, 446)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 26)
        Me.btnView.TabIndex = 6
        Me.btnView.Text = "View"
        '
        'lblFormCaption
        '
        Me.lblFormCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFormCaption.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormCaption.ForeColor = System.Drawing.Color.Navy
        Me.lblFormCaption.Location = New System.Drawing.Point(12, 9)
        Me.lblFormCaption.Name = "lblFormCaption"
        Me.lblFormCaption.Size = New System.Drawing.Size(1062, 25)
        Me.lblFormCaption.TabIndex = 8
        Me.lblFormCaption.Text = "Manual Matching"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmManualMatching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 612)
        Me.Controls.Add(Me.lblFormCaption)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.pnlTrans)
        Me.Controls.Add(Me.lblBroker)
        Me.Controls.Add(Me.pnlParty)
        Me.Controls.Add(Me.cmbBroker)
        Me.Controls.Add(Me.pnlPartySel)
        Me.Controls.Add(Me.pnlRecvPayable)
        Me.MaximizeBox = False
        Me.Name = "frmManualMatching"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual Matching"
        Me.pnlRecvPayable.ResumeLayout(False)
        Me.pnlPartySel.ResumeLayout(False)
        Me.pnlParty.ResumeLayout(False)
        Me.pnlParty.PerformLayout()
        Me.pnlTrans.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlRecvPayable As System.Windows.Forms.Panel
    Friend WithEvents rdReceivables As System.Windows.Forms.RadioButton
    Friend WithEvents rdPayables As System.Windows.Forms.RadioButton
    Friend WithEvents pnlPartySel As System.Windows.Forms.Panel
    Friend WithEvents rdOneParty As System.Windows.Forms.RadioButton
    Friend WithEvents rdAllParties As System.Windows.Forms.RadioButton
    Friend WithEvents pnlParty As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbParty As System.Windows.Forms.ComboBox
    Friend WithEvents lblBroker As System.Windows.Forms.Label
    Friend WithEvents cmbBroker As System.Windows.Forms.ComboBox
    Friend WithEvents pnlTrans As System.Windows.Forms.Panel
    Friend WithEvents rdAllTrans As System.Windows.Forms.RadioButton
    Friend WithEvents rdOnlyOSTrans As System.Windows.Forms.RadioButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Public WithEvents lblFormCaption As System.Windows.Forms.Label

    Public Sub New(ByVal blnFlag1 As Boolean)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'strFilter = strFilter1
        blnFlag = blnFlag1
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
