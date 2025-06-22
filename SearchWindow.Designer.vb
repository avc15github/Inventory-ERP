<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchWindow
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchWindow))
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.pnlDateSel = New System.Windows.Forms.Panel
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.dgvSearch = New System.Windows.Forms.DataGridView
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.lblRecordsFound = New System.Windows.Forms.Label
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtSrchtext = New System.Windows.Forms.TextBox
        Me.lblSearchColumn = New System.Windows.Forms.Label
        Me.rdSrchStart = New System.Windows.Forms.RadioButton
        Me.rdSrchAnyWhere = New System.Windows.Forms.RadioButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.pnlDateSel.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpMain.Appearance.Options.UseBackColor = True
        Me.grpMain.AppearanceCaption.BackColor = System.Drawing.Color.Brown
        Me.grpMain.AppearanceCaption.BackColor2 = System.Drawing.Color.NavajoWhite
        Me.grpMain.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMain.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.grpMain.AppearanceCaption.Options.UseBackColor = True
        Me.grpMain.AppearanceCaption.Options.UseFont = True
        Me.grpMain.AppearanceCaption.Options.UseForeColor = True
        Me.grpMain.AppearanceCaption.Options.UseTextOptions = True
        Me.grpMain.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpMain.Controls.Add(Me.pnlDateSel)
        Me.grpMain.Controls.Add(Me.dgvSearch)
        Me.grpMain.Controls.Add(Me.btnPrint)
        Me.grpMain.Controls.Add(Me.btnExcel)
        Me.grpMain.Controls.Add(Me.lblRecordsFound)
        Me.grpMain.Controls.Add(Me.btnSearch)
        Me.grpMain.Controls.Add(Me.txtSrchtext)
        Me.grpMain.Controls.Add(Me.lblSearchColumn)
        Me.grpMain.Controls.Add(Me.rdSrchStart)
        Me.grpMain.Controls.Add(Me.rdSrchAnyWhere)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Location = New System.Drawing.Point(0, 0)
        Me.grpMain.LookAndFeel.SkinName = "Blue"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(382, 379)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "Search"
        '
        'pnlDateSel
        '
        Me.pnlDateSel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDateSel.Controls.Add(Me.dtpFrom)
        Me.pnlDateSel.Controls.Add(Me.Label3)
        Me.pnlDateSel.Controls.Add(Me.Label2)
        Me.pnlDateSel.Controls.Add(Me.dtpTo)
        Me.pnlDateSel.Location = New System.Drawing.Point(67, 33)
        Me.pnlDateSel.Name = "pnlDateSel"
        Me.pnlDateSel.Size = New System.Drawing.Size(82, 32)
        Me.pnlDateSel.TabIndex = 11
        Me.pnlDateSel.Visible = False
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(47, 5)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(95, 23)
        Me.dtpFrom.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "From"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(151, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(175, 5)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(95, 23)
        Me.dtpTo.TabIndex = 3
        '
        'dgvSearch
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(10, 77)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(362, 260)
        Me.dgvSearch.TabIndex = 8
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Appearance.Options.UseBackColor = True
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.Location = New System.Drawing.Point(153, 351)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Visible = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseBackColor = True
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Location = New System.Drawing.Point(286, 347)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(86, 23)
        Me.btnExcel.TabIndex = 6
        Me.btnExcel.Text = "Excel Export"
        '
        'lblRecordsFound
        '
        Me.lblRecordsFound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRecordsFound.AutoSize = True
        Me.lblRecordsFound.BackColor = System.Drawing.Color.Transparent
        Me.lblRecordsFound.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordsFound.ForeColor = System.Drawing.Color.Maroon
        Me.lblRecordsFound.Location = New System.Drawing.Point(12, 347)
        Me.lblRecordsFound.Name = "lblRecordsFound"
        Me.lblRecordsFound.Size = New System.Drawing.Size(101, 15)
        Me.lblRecordsFound.TabIndex = 7
        Me.lblRecordsFound.Text = "0 record(s) found"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSearch.Location = New System.Drawing.Point(210, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(34, 33)
        Me.btnSearch.TabIndex = 2
        '
        'txtSrchtext
        '
        Me.txtSrchtext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSrchtext.Location = New System.Drawing.Point(106, 39)
        Me.txtSrchtext.Name = "txtSrchtext"
        Me.txtSrchtext.Size = New System.Drawing.Size(98, 23)
        Me.txtSrchtext.TabIndex = 1
        Me.txtSrchtext.Tag = "Search Text"
        '
        'lblSearchColumn
        '
        Me.lblSearchColumn.AutoSize = True
        Me.lblSearchColumn.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchColumn.Location = New System.Drawing.Point(11, 42)
        Me.lblSearchColumn.Name = "lblSearchColumn"
        Me.lblSearchColumn.Size = New System.Drawing.Size(49, 15)
        Me.lblSearchColumn.TabIndex = 0
        Me.lblSearchColumn.Text = "Column"
        '
        'rdSrchStart
        '
        Me.rdSrchStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdSrchStart.AutoSize = True
        Me.rdSrchStart.BackColor = System.Drawing.Color.Transparent
        Me.rdSrchStart.Location = New System.Drawing.Point(255, 32)
        Me.rdSrchStart.Name = "rdSrchStart"
        Me.rdSrchStart.Size = New System.Drawing.Size(120, 19)
        Me.rdSrchStart.TabIndex = 3
        Me.rdSrchStart.Text = "Search from start"
        Me.rdSrchStart.UseVisualStyleBackColor = False
        '
        'rdSrchAnyWhere
        '
        Me.rdSrchAnyWhere.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdSrchAnyWhere.AutoSize = True
        Me.rdSrchAnyWhere.BackColor = System.Drawing.Color.Transparent
        Me.rdSrchAnyWhere.Checked = True
        Me.rdSrchAnyWhere.Location = New System.Drawing.Point(255, 51)
        Me.rdSrchAnyWhere.Name = "rdSrchAnyWhere"
        Me.rdSrchAnyWhere.Size = New System.Drawing.Size(110, 19)
        Me.rdSrchAnyWhere.TabIndex = 4
        Me.rdSrchAnyWhere.TabStop = True
        Me.rdSrchAnyWhere.Text = "Search between"
        Me.rdSrchAnyWhere.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseBackColor = True
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(198, 347)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.Visible = False
        '
        'PrintDoc
        '
        '
        'SearchWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SearchWindow"
        Me.Size = New System.Drawing.Size(382, 379)
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.pnlDateSel.ResumeLayout(False)
        Me.pnlDateSel.PerformLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rdSrchStart As System.Windows.Forms.RadioButton
    Friend WithEvents rdSrchAnyWhere As System.Windows.Forms.RadioButton
    Friend WithEvents txtSrchtext As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchColumn As System.Windows.Forms.Label
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRecordsFound As System.Windows.Forms.Label
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents pnlDateSel As System.Windows.Forms.Panel
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker

End Class
