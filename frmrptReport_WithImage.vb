Public Class frmrptReport_WithImage
    Dim crdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim rptpath As String

    Public Property ReportDocument() As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Get
            Return crdoc
        End Get
        Set(ByVal value As CrystalDecisions.CrystalReports.Engine.ReportDocument)
            crdoc = value
        End Set
    End Property

    Public WriteOnly Property ReportPath() As String
        Set(ByVal value As String)
            rptpath = value
        End Set
    End Property

    Private Sub frmrptReport_WithImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'crdoc.Load("D:\Project\VRSERP\Solution\Forms\Utilities\StockWithImage_Crosstab.rpt")
        'crdoc.SetDataSource(dt)
        rptViewer.ReportSource = crdoc
    End Sub
End Class