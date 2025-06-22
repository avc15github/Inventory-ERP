Imports System.Data.SqlClient

Public Class frmAccDashboard

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        DisplayChart1() ''Top Debtors 
        DisplayChart2() ''Top Creditors
    End Sub

    Private Sub DisplayChart1()
        Query = "Select Led_Name, IsNull(Sum(Net_Amt), 0) AmtSum " _
            & " From Bill Inner Join Ledger On Bill.Party_Key = Ledger.Led_Key " _
            & " Where Doc_Id > 0 " _
            & " And Doc_Dt >= '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And Doc_Dt <= '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'" _
            & " Group By Led_Name " _
            & " Order By IsNull(Sum(Net_Amt), 0) Desc "
        Dim Table As DataTable = Common.GetDataTable(Query)
        Dim View As DataView = Table.DefaultView

        Dash1.Series.Clear()
        Dash1.Titles.Clear()
        Dash1.ChartAreas.Clear()

        Dash1.Series.Add("Series")
        Dash1.Titles.Add("Titles")
        Dash1.ChartAreas.Add("ChartArea")

        Dim ChartSr As DataVisualization.Charting.Series = Dash1.Series(0)
        Dim ChartTitle As DataVisualization.Charting.Title = Dash1.Titles(0)
        Dim ChartArea As DataVisualization.Charting.ChartArea = Dash1.ChartAreas(0)

        ChartSr.Points.DataBindXY(View, "Led_Name", View, "AmtSum")
        ChartSr.ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChartSr.Font = New Font("Tahoma", 7, FontStyle.Regular)
        ChartSr("BarLabelStyle") = "Center"
        'ChartSr.Color = Color.WhiteSmoke
        ChartTitle.Text = "Top Debtors"
        ChartTitle.Font = New Font("Tahoma", 9, FontStyle.Bold)
        ChartTitle.ForeColor = Color.WhiteSmoke

        ChartArea.AxisX.IsLabelAutoFit = False

        ' Set axis labels font
        ChartArea.AxisX.LabelStyle.Font = New Font("Tahoma", 8, FontStyle.Regular)
        ChartArea.AxisY.LabelStyle.Font = New Font("Tahoma", 8, FontStyle.Regular)
        ChartArea.AxisX.LabelStyle.ForeColor = Color.WhiteSmoke
        ChartArea.AxisY.LabelStyle.ForeColor = Color.WhiteSmoke

        ' Set axis labels angle
        ChartArea.AxisX.LabelStyle.Angle = -30

        ' Disable offset labels style
        ChartArea.AxisX.LabelStyle.IsStaggered = False

        ' Enable X axis labels
        ChartArea.AxisX.LabelStyle.Enabled = True

        ' Enable AntiAliasing for either Text and Graphics or just Graphics
        'Chart1.AntiAliasing = AntiAliasing.All  ' AntiAliasingStyles.Graphics 

        ChartSr.IsValueShownAsLabel = True
        ChartSr.Label = "#VALY"
        ChartSr.LabelForeColor = Color.WhiteSmoke
        ChartArea.AxisY.IsMarksNextToAxis = True
        ChartArea.IsSameFontSizeForAllAxes = True

        ChartSr("PixelPointWidth") = "40"
        Dash1.ChartAreas(0).Position.Auto = False
        Dash1.ChartAreas(0).Position.Width = 90
        Dash1.ChartAreas(0).Position.Height = 100


        ChartArea.BackColor = Color.Transparent

        ' Set Gradient Type
        'ChartArea.BackGradientStyle = DataVisualization.Charting.GradientStyle.LeftRight

        ' Set Border Color
        ChartArea.BorderColor = Color.Black
        'ChartArea.BackSecondaryColor = Color.Gray

        ' Set Border Style
        ChartArea.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet

        ' Set Border Width
        ChartArea.BorderWidth = 1

        ' Set Shadow Offset
        ChartArea.ShadowOffset = 5

        ' Set font attributes for the single data point
        ' Set labels Position
        ChartSr("LabelStyle") = "Top"

        ' Set labels font
        ChartSr.Font = New Font("Tahoma", 7, FontStyle.Regular)
        ChartSr.BorderWidth = 1
        'ChartSr.BackSecondaryColor = Color.White

        'Dash1.ChartAreas(0).Area3DStyle.Enable3D = True
        Dash1.Series(0)("DrawingStyle") = "Cylinder"


        ChartArea.AxisX.MinorGrid.Enabled = True
        ChartArea.AxisX.MajorGrid.Enabled = True
        ChartArea.AxisX.MinorGrid.Interval = 1

        ChartArea.AxisY.MinorGrid.Enabled = True
        ChartArea.AxisY.MajorGrid.Enabled = True
        ChartArea.AxisY.MinorGrid.Interval = 1

        ChartArea.AxisY.MinorGrid.LineColor = Color.LightSlateGray
        ChartArea.AxisY.MajorGrid.LineColor = Color.LightSlateGray

        ChartArea.AxisX.MinorGrid.LineColor = Color.LightSlateGray
        ChartArea.AxisX.MajorGrid.LineColor = Color.LightSlateGray

        Table = Nothing
        View = Nothing

        'Dash1.Series("Series1").Legend = "Legend1"
        'Dash1.Series("Series1").XValueMember = "ItemSubGrp_Name"
        'Dash1.Series("Series1").YValueMembers = "QtySum"
        'Dash1.DataSource = Table
    End Sub

    Private Sub DisplayChart2()
        ''Top Creditors
        Query = "Select Led_Name, IsNull(Sum(Net_Amt), 0) AmtSum " _
            & " From Purchase Inner Join Ledger On Purchase.Supl_Key = Ledger.Led_Key " _
            & " Where Doc_Id > 0 " _
            & " And Doc_Dt >= '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And Doc_Dt <= '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'" _
            & " Group By Led_Name " _
            & " Order By IsNull(Sum(Net_Amt), 0) Desc "
        Dim Table As DataTable = Common.GetDataTable(Query)
        Dim View As DataView = Table.DefaultView

        Dash2.Series.Clear()
        Dash2.Titles.Clear()
        Dash2.ChartAreas.Clear()

        Dash2.Series.Add("Series")
        Dash2.Titles.Add("Titles")
        Dash2.ChartAreas.Add("ChartArea")

        Dim ChartSr As DataVisualization.Charting.Series = Dash2.Series(0)
        Dim ChartTitle As DataVisualization.Charting.Title = Dash2.Titles(0)
        Dim ChartArea As DataVisualization.Charting.ChartArea = Dash2.ChartAreas(0)

        ChartSr.Points.DataBindXY(View, "Led_Name", View, "AmtSum")
        ChartSr.ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChartSr.Font = New Font("Tahoma", 7, FontStyle.Regular)
        ChartSr("LabelStyle") = "Top"
        'ChartSr.Color = Color.WhiteSmoke
        ChartTitle.Text = "Top Creditors"
        ChartTitle.Font = New Font("Tahoma", 9, FontStyle.Bold)
        ChartTitle.ForeColor = Color.WhiteSmoke

        ChartArea.AxisX.IsLabelAutoFit = False

        ChartArea.AxisX.LabelStyle.Font = New Font("Tahoma", 8, FontStyle.Regular)
        ChartArea.AxisY.LabelStyle.Font = New Font("Tahoma", 8, FontStyle.Regular)
        ChartArea.AxisX.LabelStyle.ForeColor = Color.WhiteSmoke
        ChartArea.AxisY.LabelStyle.ForeColor = Color.WhiteSmoke

        ChartArea.AxisX.LabelStyle.Angle = -30
        ChartArea.AxisX.LabelStyle.IsStaggered = False
        ChartArea.AxisX.LabelStyle.Enabled = True

        ChartSr.IsValueShownAsLabel = True
        ChartSr.Label = "#VALY"
        ChartSr.LabelForeColor = Color.WhiteSmoke
        ChartArea.AxisY.IsMarksNextToAxis = True
        ChartArea.IsSameFontSizeForAllAxes = True

        ChartSr("PixelPointWidth") = "40"
        Dash2.ChartAreas(0).Position.Auto = False
        Dash2.ChartAreas(0).Position.Width = 90
        Dash2.ChartAreas(0).Position.Height = 100

        ChartArea.BackColor = Color.Transparent

        'ChartArea.BackGradientStyle = DataVisualization.Charting.GradientStyle.LeftRight

        ChartArea.BorderColor = Color.Black
        'ChartArea.BackSecondaryColor = Color.Gray

        ChartArea.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea.BorderWidth = 1
        ChartArea.ShadowOffset = 5


        ChartSr.Font = New Font("Tahoma", 7, FontStyle.Regular)
        ChartSr.BorderWidth = 1
        'ChartSr.BackSecondaryColor = Color.White

        Dash2.Series(0)("DrawingStyle") = "Cylinder"


        ChartArea.AxisX.MinorGrid.Enabled = True
        ChartArea.AxisX.MajorGrid.Enabled = True
        ChartArea.AxisX.MinorGrid.Interval = 1

        ChartArea.AxisY.MinorGrid.Enabled = True
        ChartArea.AxisY.MajorGrid.Enabled = True
        ChartArea.AxisY.MinorGrid.Interval = 1

        ChartArea.AxisY.MinorGrid.LineColor = Color.LightSlateGray
        ChartArea.AxisY.MajorGrid.LineColor = Color.LightSlateGray

        ChartArea.AxisX.MinorGrid.LineColor = Color.LightSlateGray
        ChartArea.AxisX.MajorGrid.LineColor = Color.LightSlateGray


        Table = Nothing
        View = Nothing
    End Sub
End Class