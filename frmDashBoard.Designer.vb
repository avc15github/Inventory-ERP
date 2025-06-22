<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashBoard
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
        Me.btnView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTo = New DateTimePick.DateTimePick
        Me.dtpFrom = New DateTimePick.DateTimePick
        Me.Dash1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.Dash3 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Dash2 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.Dash4 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dash1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Dash3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dash2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dash4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(570, 10)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 29)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(6, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(999, 43)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'dtpTo
        '
        'Me.dtpTo.CustomFormat = "dd/MM/yyyy"
        ' Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(452, 13)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(96, 22)
        Me.dtpTo.TabIndex = 3
        Me.dtpTo.Value = New Date(2011, 11, 30, 0, 0, 0, 0)
        '
        'dtpFrom
        '
        'Me.dtpFrom.CustomFormat = "dd/MM/yyyy"
        'Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(284, 13)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(96, 22)
        Me.dtpFrom.TabIndex = 1
        Me.dtpFrom.Value = New Date(2011, 11, 1, 0, 0, 0, 0)
        '
        'Dash1
        '
        Me.Dash1.BackColor = System.Drawing.Color.Transparent
        Me.Dash1.Location = New System.Drawing.Point(5, 18)
        Me.Dash1.Name = "Dash1"
        Me.Dash1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Dash1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.LightSeaGreen}
        Me.Dash1.Size = New System.Drawing.Size(326, 287)
        Me.Dash1.TabIndex = 7
        Me.Dash1.Text = "Chart1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.Dash4)
        Me.GroupControl1.Controls.Add(Me.Dash3)
        Me.GroupControl1.Controls.Add(Me.Dash2)
        Me.GroupControl1.Controls.Add(Me.Dash1)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 42)
        Me.GroupControl1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(1010, 644)
        Me.GroupControl1.TabIndex = 9
        Me.GroupControl1.Text = "GroupControl1"
        '
        'Dash3
        '
        Me.Dash3.BackColor = System.Drawing.Color.Transparent
        Me.Dash3.Location = New System.Drawing.Point(668, 18)
        Me.Dash3.Name = "Dash3"
        Me.Dash3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Dash3.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))}
        Me.Dash3.Size = New System.Drawing.Size(326, 287)
        Me.Dash3.TabIndex = 11
        Me.Dash3.Text = "Chart1"
        '
        'Dash2
        '
        Me.Dash2.BackColor = System.Drawing.Color.Transparent
        Me.Dash2.BorderlineColor = System.Drawing.Color.Transparent
        Me.Dash2.Location = New System.Drawing.Point(6, 341)
        Me.Dash2.Name = "Dash2"
        Me.Dash2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Dash2.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))}
        Me.Dash2.Size = New System.Drawing.Size(326, 287)
        Me.Dash2.TabIndex = 8
        Me.Dash2.Text = "Chart1"
        '
        'Dash4
        '
        Me.Dash4.BackColor = System.Drawing.Color.Transparent
        Me.Dash4.Location = New System.Drawing.Point(668, 341)
        Me.Dash4.Name = "Dash4"
        Me.Dash4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Dash4.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.LimeGreen}
        Me.Dash4.Size = New System.Drawing.Size(326, 287)
        Me.Dash4.TabIndex = 12
        Me.Dash4.Text = "Chart1"
        '
        'frmDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 686)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dash1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.Dash3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dash2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dash4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
    Friend WithEvents Dash1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Dash2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Dash3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Dash4 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
