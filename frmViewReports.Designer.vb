<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReports
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

    Sub New(Optional ByVal crysFormulas As Hashtable = Nothing)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CrystalFormulas = crysFormulas
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer



    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crptReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crptReport
        '
        Me.crptReport.ActiveViewIndex = -1
        Me.crptReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptReport.DisplayGroupTree = False
        Me.crptReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptReport.Location = New System.Drawing.Point(0, 0)
        Me.crptReport.Name = "crptReport"
        Me.crptReport.SelectionFormula = ""
        Me.crptReport.Size = New System.Drawing.Size(838, 534)
        Me.crptReport.TabIndex = 0
        Me.crptReport.ViewTimeSelectionFormula = ""
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.VRSERP.My.Resources.Resources.Image
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 1)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(59, 30)
        Me.PictureEdit1.TabIndex = 1
        '
        'frmViewReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 534)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.crptReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmViewReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crptReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
