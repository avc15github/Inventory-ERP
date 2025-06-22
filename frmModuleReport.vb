Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows
Imports System.Text
Imports System.IO
Imports System.Xml
Public Class frmModuleReport

    Dim Formulas As Hashtable
    Dim ReportCaption As String = ""
    Dim rptType As ReportType

    Enum ReportType
        CostSheet
        PurchaseSalesOrder
        PerformaSalesOrder
        FabOrder
        FinOrder
        AccOrder
        BuyerStandardLabel
        JobWorkPO
        JobWorkOrder
        FabGRN
        FinGRN
        AccGRN
        BuyerStandardLabelGRN
        JobWorkPORecv
        JobWorkOrderRecv
        FabRtn
        FinRtn
        AccRtn
        BuyerStandardLabelRtn
    End Enum


    Dim bytRptType As ReportType
    Dim blnLoading As Boolean
    Dim Checked As Boolean

    Private Sub frmModuleReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        blnLoading = False
        If bytRptType = ReportType.CostSheet Then
            rdCostSheet.Checked = True
            pnlCostSheetType.Visible = True
            cmbPackingD.Visible = False
            Me.Text = "Cost Sheet Report"
            If rdCostSheet.Checked Then
                cmbParty.Enabled = False
                Query = " Select Distinct Style.Style_Code,Style_id From Style " _
                    & " Left Join BomprdStyle on Style.Style_key=BomprdStyle.Style_Key where Bom_Type='S' "
                Common.FillCombo2(Query, cmbSample, "Style_Code", "Style_id")
            Else
                cmbParty.Enabled = True
                Query = " Select Distinct Style.Style_Code,Style_id From Style " _
                   & " Left Join BomprdStyle on Style.Style_key=BomprdStyle.Style_Key where Bom_Type='O' "
                Common.FillCombo2(Query, cmbSample, "Style_Code", "Style_id")

                Query = " select '' Led_Name , '' Led_Key Union All select led_Name,led_key from ledger left join BomprdStyle on BomprdStyle.Cust_Key=Ledger.Led_key where led_cat='W' and ledger.Status='1' and BomprdStyle.Cust_Key <> '' " _
                    & " Order By Led_Name"
                Common.FillCombo2(Query, cmbParty, "Led_Name", "Led_key")
                If cmbParty.Items.Count > 0 Then
                    cmbParty.SelectedIndex = 0
                End If
            End If




            'Query = " Select Distinct Style.Style_Code,Style_id From Style " _
            '        & " Left Join BomprdStyle on Style.Style_key=BomprdStyle.Style_Key where Vender_"
            'Common.FillCombo2(Query, cmbSample, "Style_Code", "Style_id")

        End If
        If bytRptType = ReportType.PerformaSalesOrder Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False

            Label4.Visible = True
            Label3.Visible = False

            Label4.Text = "SO No."
            Query = " select Doc_no,Doc_id from salesorder  where status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

           
        ElseIf bytRptType = ReportType.FabOrder Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "PO No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from PurOrder  where PO_Type = 'G' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.FinOrder Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "PO No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from PurOrder  where PO_Type = 'F' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.AccOrder Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "PO No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from PurOrder  where PO_Type = 'S' And  PO_Finish = 'S' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.BuyerStandardLabel Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "PO No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from PurOrder  where PO_Type = 'S' And PO_Finish = 'L' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.JobWorkPO Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "JobPO No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from JobWorkPO  where  status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.JobWorkOrder Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "JobOrder No"
            Label3.Visible = False
            Label4.Location = New Point(15, 61)
            Query = " select Doc_no,Doc_id from JobOrder  where  status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.FabGRN Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "GRN No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from purchase  where Pur_Type = 'G' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.FinGRN Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "GRN No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from purchase  where Pur_Type = 'F' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.AccGRN Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "GRN No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from purchase  where Pur_Type1 = 'S' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.BuyerStandardLabelGRN Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "GRN No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from purchase  where Pur_Type1 = 'L' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.JobWorkPORecv Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "Receipt No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from ProcIsuRct  where status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.JobWorkOrderRecv Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "Receipt No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from ProcRct  where status='1' "
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.FabRtn Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "GRT No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from purchaseRtn  where Rtn_Type = 'G' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.FinRtn Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "GRT No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from purchaseRtn  where Rtn_Type = 'F' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.AccRtn Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "GRT No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from purchaseRtn  where Rtn_Type = 'S' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.BuyerStandardLabelRtn Then
            cmbParty.Visible = True
            cmbSample.Visible = False
            pnlCostSheetType.Visible = False
            Label4.Visible = True
            Label4.Text = "GRT No"
            Label3.Visible = False
            Query = " select Doc_no,Doc_id from purchaseRtn  where Rtn_Type = 'L' And status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")

        ElseIf bytRptType = ReportType.PurchaseSalesOrder Then
            cmbParty.Visible = True
            cmbSample.Visible = True
            pnlCostSheetType.Visible = False
            'cmbPackingD.Visible = True
            'cmbPackingD.Visible = True
            Label4.Visible = True
            Label3.Visible = True
            Label3.Text = "Packing Info"
            'Label3.Location = New Point(15, 92)
            cmbSample.DropDownStyle = ComboBoxStyle.DropDownList
            With cmbSample.Items
                .Add("Packing Information")
                .Add("Labeling Information")
                .Add("Carton Information")
            End With

            With cmbPackingD.Items
                .Add("D3 - Buyer Specific - Bulk Pack ")
                .Add("D4 - Buyer Specific - Pre Pack ")
                .Add("D5 - Buyer Specific - Store Wise Bulk Pack ")
                .Add("D6 - Buyer Specific - Store Wise Pre Pack ")
            End With


            Label4.Text = "SO No."
            Query = " select Doc_no,Doc_id from salesorder  where status='1'"
            Common.FillCombo2(Query, cmbParty, "Doc_no", "Doc_id")
        End If

    End Sub

    Private Sub dtpFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbParty.KeyDown, cmbSample.KeyDown
        Call MoveToNextControl(e)
    End Sub
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        Select Case bytRptType
            Case ReportType.PerformaSalesOrder
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from SalesOrder  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                Common.CheckForTransApproval("SO") ''ankita 03122018


                If Val(GetSettingAsPerId(ApplnSettingsIdx.DisplayImageinSalesOrder)) = 1 Then


                    Dim ms As MemoryStream
                    Dim cmd As SqlCommand
                    Dim pctlogo As New PictureBox
                    Dim DtTempTble As DataTable


                    If GetSettingAsPerId(ApplnSettingsIdx.Software_For) = "1" Then
                        Query = "Delete From TempStyleImage " _
                          & " Where Doc_Type='SO'"
                        Common.ExecuteQuery(Query)
                    Else

                        Query = "Delete From TempStyleImage " _
                       & " Where SODocDtl_ID In(Select DocDtl_Id From SalesOrderDtl Where Doc_Id = " & CurrIntId1 & ")"
                        Common.ExecuteQuery(Query)

                    End If

                    If GetSettingAsPerId(ApplnSettingsIdx.Software_For) = "1" Then
                        Query = " SELECT DISTINCT 0 DocDtl_Id, Style_Key, isnull((Select Top 1 Style_ImageF From StyleShade WHERE Style_ImageF<>'' And StyleShade.Style_Key = SalesOrderDtl.Style_Key And StyleShade.Shade_Key = SalesOrderDtl.Shade_Key),'') Style_Image " _
                               & " FROM SalesOrderDtl WHERE STATUS<> '0' And Doc_Id = " & CurrIntId1 _
                               & " ORDER BY DocDtl_Id "
                    Else
                        Query = " SELECT Style_Image, DocDtl_Id, SalesOrderDtl.Style_Key FROM SalesOrderDtl " _
                               & " Left Join Style On SalesOrderDtl.Style_Key = Style.Style_Key " _
                               & " WHERE Style_Image<>'' And Doc_Id = " & CurrIntId1 _
                               & " ORDER BY DocDtl_Id "
                    End If

                    DtTempTble = New DataTable
                    DtTempTble = Common.GetDataTable(Query)

                    For Each drImageRow In DtTempTble.Rows

                        If drImageRow("Style_Image") <> "" Then
                            pctlogo.Image = System.Drawing.Image.FromFile(GetSettingAsPerId(ApplnSettingsIdx.GenImagePath) & "\Product\" & drImageRow("Style_Image"))
                            ms = New MemoryStream
                            pctlogo.Image.Save(ms, pctlogo.Image.RawFormat)

                            Dim arrImage() As Byte = ms.GetBuffer
                            ms.Dispose()

                            cmd = New SqlCommand
                            With cmd
                                .Connection = Common.NewSQLConnection
                                .Connection.Open()
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "InsertBomImage"
                                .Parameters.Add(New SqlParameter("@BomPrdStyle_Id", SqlDbType.BigInt)).Value = 0
                                .Parameters.Add(New SqlParameter("@Style_Key", SqlDbType.Text)).Value = drImageRow("Style_Key")
                                .Parameters.Add(New SqlParameter("@SODocDtl_Id", SqlDbType.BigInt)).Value = drImageRow("DocDtl_Id")
                                .Parameters.Add(New SqlParameter("@User_Id", SqlDbType.BigInt)).Value = UserId
                                .Parameters.Add(New SqlParameter("@Image1", SqlDbType.Image)).Value = arrImage
                                .Parameters.Add(New SqlParameter("@Image2", SqlDbType.Image)).Value = DBNull.Value
                                .Parameters.Add(New SqlParameter("@Image3", SqlDbType.Image)).Value = DBNull.Value
                                .Parameters.Add(New SqlParameter("@Image4", SqlDbType.Image)).Value = DBNull.Value

                                If GetSettingAsPerId(ApplnSettingsIdx.Software_For) = "1" Then
                                    .Parameters.Add(New SqlParameter("@RefDoc_Id", SqlDbType.BigInt)).Value = CurrIntId1
                                    .Parameters.Add(New SqlParameter("@Doc_Type", SqlDbType.Text)).Value = "SO"
                                End If

                            End With

                            cmd.ExecuteNonQuery()
                            cmd.Connection.Dispose()
                            cmd = Nothing
                        End If
                    Next drImageRow

                End If




                Dim Formulas As New Hashtable

                If GetSettingAsPerId(ApplnSettingsIdx.Software_For) = "0" Then
                    Formulas.Add("ItemCaption#S", GetSystemCaption(SystemCaptionIdx.DefProduct))
                    Formulas.Add("DesignCaption#S", GetSystemCaption(SystemCaptionIdx.DefArticle))
                    Formulas.Add("ShadeCaption#S", GetSystemCaption(SystemCaptionIdx.DefShade))
                    Formulas.Add("SizeCaption#S", GetSystemCaption(SystemCaptionIdx.DefSize))
                End If


                ReportParameters.rptFile = ReportPath & "\Forms\SalesOrder.rpt"
                ReportParameters.rptFilter = "{SalesOrder.Doc_Id} = " & CurrIntId1
                ReportParameters.PrintToPrinter = False
                ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToWindow
                ReportParameters.rptCaption = Me.Text
            Case ReportType.PurchaseSalesOrder

                Query = "Select SOStatus_Id From SalesOrder Where Doc_ID =" & cmbParty.SelectedValue & " "
                Dim SOStatus As Integer = Common.ExecuteScalar(Query)

                'If SOStatus <> 2 Then
                '    MsgBox("OC Status Should be Confirmed", MsgBoxStyle.Exclamation)
                '    Exit Sub
                'Else
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from SalesOrder  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                Common.CheckForTransApproval("SO") ''ankita 03122018

                If Val(GetSettingAsPerId(ApplnSettingsIdx.DisplayImageinSalesOrder)) = 1 Then

                    'Dim pctTmpBranchLogo As PictureBox
                    Dim ms As MemoryStream
                    Dim cmd As SqlCommand
                    Dim pctlogo As New PictureBox
                    Dim DtTempTble As DataTable

                    If Val(CurrIntId1) = 0 Then
                        Exit Sub
                    End If

                    If GetSettingAsPerId(ApplnSettingsIdx.Software_For) = "1" Then
                        Query = "Delete From TempStyleImage " _
                          & " Where Doc_Type='SO'"
                        Common.ExecuteQuery(Query)


                        '''Satyam 07062024

                        Dim DtTempTble2 As DataTable
                        Dim DtTempTble1 As DataTable
                        Dim SODtl As DataTable
                        Dim DtHeader As DataTable
                        Dim totalLabels As Integer = 0

                        Dim i As Integer = 0
                        Dim Extrafld As Integer = 0


                        Query = "Delete From Temp_LabelingHrdrpt " _
                                  & " Where SODoc_Id = " & CurrIntId1
                        Common.ExecuteQuery(Query)

                        Query = "Delete From Temp_Labelingrpt1 " _
                                  & " Where SODoc_Id = " & CurrIntId1
                        Common.ExecuteQuery(Query)

                        Query = "Delete From Temp_Labelingrpt2 " _
                                  & " Where SODoc_Id = " & CurrIntId1
                        Common.ExecuteQuery(Query)

                        Query = "Delete From Temp_Labelingrpt3 " _
                                  & " Where SODoc_Id = " & CurrIntId1
                        Common.ExecuteQuery(Query)



                        Query = " SELECT DISTINCT ITEM_KEY, ITEM_NAME FROM SODtlLabelingDtl WHERE Doc_Id = " & CurrIntId1 _
                                      & " ORDER BY ITEM_KEY "

                        DtTempTble2 = New DataTable
                        DtTempTble2 = Common.GetDataTable(Query)

                        If DtTempTble2.Rows.Count > 0 Then
                            Query = "Insert Into Temp_LabelingHrdrpt Values(" & CurrIntId1 & ",'','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')"
                            Common.ExecuteQuery(Query)

                        Else
                            Query = " SELECT DISTINCT ITEM_KEY, ITEM_NAME FROM SODtlLabelingDtl WHERE Doc_Id = " & CurrIntId1 _
                                      & " ORDER BY ITEM_KEY "

                            DtTempTble2 = New DataTable
                            DtTempTble2 = Common.GetDataTable(Query)

                        End If



                        i = 1
                        Extrafld = 1

                        Query = " SELECT Top 1 * FROM SODtlLabeling WHERE Field1_Caption <>'' And Doc_Id = " & CurrIntId1
                        DtTempTble1 = New DataTable
                        DtTempTble1 = Common.GetDataTable(Query)

                        If DtTempTble1.Rows.Count > 0 Then

                            If DtTempTble1.Rows(0).Item("Field1_Caption") <> "" Then
                                Query = "Update Temp_LabelingHrdrpt Set Column" & i & " = '" & ReplaceApostrophe(DtTempTble1.Rows(0).Item("Field1_Caption")) & "'" _
                                  & " Where SODoc_Id = " & CurrIntId1
                                Common.ExecuteQuery(Query)
                                i = i + 1
                                Extrafld = Extrafld + 1
                            End If

                            If DtTempTble1.Rows(0).Item("Field2_Caption") <> "" Then
                                Query = "Update Temp_LabelingHrdrpt Set Column" & i & " = '" & ReplaceApostrophe(DtTempTble1.Rows(0).Item("Field2_Caption")) & "'" _
                                  & " Where SODoc_Id = " & CurrIntId1
                                Common.ExecuteQuery(Query)
                                i = i + 1
                                Extrafld = Extrafld + 1
                            End If

                            If DtTempTble1.Rows(0).Item("Field3_Caption") <> "" Then
                                Query = "Update Temp_LabelingHrdrpt Set Column" & i & " = '" & ReplaceApostrophe(DtTempTble1.Rows(0).Item("Field3_Caption")) & "'" _
                                  & " Where SODoc_Id = " & CurrIntId1
                                Common.ExecuteQuery(Query)
                                i = i + 1
                                Extrafld = Extrafld + 1
                            End If

                            If DtTempTble1.Rows(0).Item("Field4_Caption") <> "" Then
                                Query = "Update Temp_LabelingHrdrpt Set Column" & i & " = '" & ReplaceApostrophe(DtTempTble1.Rows(0).Item("Field4_Caption")) & "'" _
                                  & " Where SODoc_Id = " & CurrIntId1
                                Common.ExecuteQuery(Query)
                                i = i + 1
                                Extrafld = Extrafld + 1
                            End If

                            If DtTempTble1.Rows(0).Item("Field5_Caption") <> "" Then
                                Query = "Update Temp_LabelingHrdrpt Set Column" & i & " = '" & ReplaceApostrophe(DtTempTble1.Rows(0).Item("Field5_Caption")) & "'" _
                                  & " Where SODoc_Id = " & CurrIntId1
                                Common.ExecuteQuery(Query)
                                i = i + 1
                                Extrafld = Extrafld + 1
                            End If

                        End If

                        For Each drHeaderRow In DtTempTble2.Rows

                            Query = "Update Temp_LabelingHrdrpt Set Column" & i & " = '" & drHeaderRow("ITEM_NAME") & "', Column" & i & "_Key" & " = '" & drHeaderRow("ITEM_KEY") & "' " _
                                 & " Where SODoc_Id = " & CurrIntId1
                            Common.ExecuteQuery(Query)

                            i = i + 1

                        Next



                        DtTempTble2 = Nothing
                        DtTempTble1 = Nothing


                        Dim j As Integer = 1
                        Dim k As Integer = 1


                        Query = "SELECT SALESORDERDTL.DOC_ID, SALESORDERDTL.DOCDTL_ID, STYLE_CODE, PARTY_STYLE, SHADE_NAME, QTY, BUYERdescription, Barcode, RetailPrice, SODtlLabeling_Id, " _
                              & " Field1_Value, Field2_Value, Field3_Value, Field4_Value, Field5_Value " _
                              & " FROM SALESORDERDTL LEFT JOIN STYLE ON STYLE.STYLE_KEY = SALESORDERDTL.STYLE_KEY " _
                              & " LEFT JOIN SHADE ON SHADE.SHADE_KEY = SALESORDERDTL.SHADE_KEY " _
                              & " LEFT JOIN SODtlLabeling ON SODtlLabeling.DocDtl_Id = SALESORDERDTL.DocDtl_Id " _
                              & " WHERE SALESORDERDTL.DOC_ID = " & CurrIntId1
                        SODtl = New DataTable
                        SODtl = Common.GetDataTable(Query)
                        Dim TableInsert As Boolean = False
                        Dim FirstInsert As Boolean = False

                        If SODtl.Rows.Count > 0 Then
                            For Each drSoDtl In SODtl.Rows

                                TableInsert = False
                                FirstInsert = False

                                Query = " SELECT ITEM_NAME, QTY FROM SODtlLabelingDtl WHERE SODtlLabeling_Id =  '" & drSoDtl("SODtlLabeling_Id") & "' " _
                                      & " ORDER BY ITEM_KEY "
                                '& drSoDtl("SODtlLabeling_Id") _ changed by suraj 
                                DtTempTble2 = New DataTable
                                DtTempTble2 = Common.GetDataTable(Query)

                                If DtTempTble2.Rows.Count > 0 Then
                                    For Each drHeaderRow In DtTempTble2.Rows

                                        totalLabels = i
                                        '(SODoc_ID,SODocDtl_ID,StyleNo,BuyerStyleNumber,ColorName,OrderQuantity,BuyerDescription,BarCode,RetailPrice)
                                        For k = 1 To totalLabels - 1
                                            If k = 1 Or k = 9 Or k = 17 Then
                                                'TableInsert = False
                                                j = 1
                                            End If
                                            Query = "Select * from Temp_LabelingHrdrpt Where Column" & k & " = '" & drHeaderRow("ITEM_NAME") & "' And SODoc_Id = " & CurrIntId1
                                            DtHeader = Common.GetDataTable(Query)
                                            If DtHeader.Rows.Count > 0 Then
                                                If k <= 8 Then
                                                    If TableInsert = False Then
                                                        Query = "Insert Into Temp_Labelingrpt1 Values(" & drSoDtl("DOC_ID") & "," & drSoDtl("DOCDTL_ID") & ",'" & drSoDtl("STYLE_CODE") & "','" & drSoDtl("PARTY_STYLE") & "','" & drSoDtl("SHADE_NAME") & "','" & drSoDtl("QTY") & "','" & drSoDtl("BUYERdescription") & "','" & drSoDtl("Barcode") & "','" & drSoDtl("RetailPrice") & "','" & drSoDtl("Field1_Value") & "','" & drSoDtl("Field2_Value") & "','" & drSoDtl("Field3_Value") & "','" & drSoDtl("Field4_Value") & "','" & drSoDtl("Field5_Value") & "','','','')"
                                                        Common.ExecuteQuery(Query)
                                                        Query = "Update Temp_Labelingrpt1 Set Column" & j & " = '" & drHeaderRow("QTY") & "'" _
                                                             & " Where SODocDtl_Id = " & drSoDtl("DOCDTL_ID")
                                                        Common.ExecuteQuery(Query)
                                                        TableInsert = True
                                                    Else
                                                        Query = "Update Temp_Labelingrpt1 Set Column" & j & " = '" & drHeaderRow("QTY") & "'" _
                                                             & " Where SODocDtl_Id = " & drSoDtl("DOCDTL_ID")
                                                        Common.ExecuteQuery(Query)
                                                    End If

                                                ElseIf (k > 8 And k <= 16) Then
                                                    If k = 9 Then
                                                        TableInsert = False
                                                    End If
                                                    If TableInsert = False Or FirstInsert = False Then
                                                        Query = "Insert Into Temp_Labelingrpt2 Values(" & drSoDtl("DOC_ID") & "," & drSoDtl("DOCDTL_ID") & ",'" & drSoDtl("STYLE_CODE") & "','" & drSoDtl("PARTY_STYLE") & "','" & drSoDtl("SHADE_NAME") & "','" & drSoDtl("QTY") & "','" & drSoDtl("BUYERdescription") & "','" & drSoDtl("Barcode") & "','" & drSoDtl("RetailPrice") & "','','','','','','','','','')"
                                                        Common.ExecuteQuery(Query)
                                                        Query = "Update Temp_Labelingrpt2 Set Column" & j & " = '" & drHeaderRow("QTY") & "'" _
                                                             & " Where SODocDtl_Id = " & drSoDtl("DOCDTL_ID")
                                                        Common.ExecuteQuery(Query)
                                                        TableInsert = True
                                                        FirstInsert = True
                                                    Else
                                                        Query = "Update Temp_Labelingrpt2 Set Column" & j & " = '" & drHeaderRow("QTY") & "'" _
                                                             & " Where SODocDtl_Id = " & drSoDtl("DOCDTL_ID")
                                                        Common.ExecuteQuery(Query)
                                                    End If

                                                End If
                                            End If
                                            j = j + 1
                                        Next k

                                    Next

                                End If



                            Next
                        End If

                        ''end 


                    Else

                        Query = "Delete From TempStyleImage " _
                       & " Where SODocDtl_ID In(Select DocDtl_Id From SalesOrderDtl Where Doc_Id = " & CurrIntId1 & ")"
                        Common.ExecuteQuery(Query)

                    End If

                    If GetSettingAsPerId(ApplnSettingsIdx.Software_For) = "1" Then
                        Query = " SELECT DISTINCT 0 DocDtl_Id, Style_Key, isnull((Select Top 1 Style_ImageF From StyleShade WHERE Style_ImageF<>'' And StyleShade.Style_Key = SalesOrderDtl.Style_Key And StyleShade.Shade_Key = SalesOrderDtl.Shade_Key),'') Style_Image " _
                            & " FROM SalesOrderDtl WHERE STATUS<> '0' And Doc_Id = " & CurrIntId1 _
                            & " ORDER BY DocDtl_Id "
                    Else
                        Query = " SELECT Style_Image, DocDtl_Id, SalesOrderDtl.Style_Key FROM SalesOrderDtl " _
                               & " Left Join Style On SalesOrderDtl.Style_Key = Style.Style_Key " _
                               & " WHERE Style_Image<>'' And Doc_Id = " & CurrIntId1 _
                               & " ORDER BY DocDtl_Id "
                    End If

                    DtTempTble = New DataTable
                    DtTempTble = Common.GetDataTable(Query)

                    For Each drImageRow In DtTempTble.Rows

                        'drTempNewRow(SizeGridCols.Size) = drImageRow("Style_Image")
                        'drTempNewRow(SizeGridCols.Qty) = drImageRow("Qty")
                        If drImageRow("Style_Image") <> "" Then
                            pctlogo.Image = System.Drawing.Image.FromFile(GetSettingAsPerId(ApplnSettingsIdx.GenImagePath) & "\Product\" & drImageRow("Style_Image"))
                            ms = New MemoryStream
                            pctlogo.Image.Save(ms, pctlogo.Image.RawFormat)

                            Dim arrImage() As Byte = ms.GetBuffer
                            ms.Dispose()

                            cmd = New SqlCommand
                            With cmd
                                .Connection = Common.NewSQLConnection
                                .Connection.Open()
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "InsertBomImage"
                                .Parameters.Add(New SqlParameter("@BomPrdStyle_Id", SqlDbType.BigInt)).Value = 0
                                .Parameters.Add(New SqlParameter("@Style_Key", SqlDbType.Text)).Value = drImageRow("Style_Key")
                                .Parameters.Add(New SqlParameter("@SODocDtl_Id", SqlDbType.BigInt)).Value = drImageRow("DocDtl_Id")
                                .Parameters.Add(New SqlParameter("@User_Id", SqlDbType.BigInt)).Value = UserId
                                .Parameters.Add(New SqlParameter("@Image1", SqlDbType.Image)).Value = arrImage
                                .Parameters.Add(New SqlParameter("@Image2", SqlDbType.Image)).Value = DBNull.Value
                                .Parameters.Add(New SqlParameter("@Image3", SqlDbType.Image)).Value = DBNull.Value
                                .Parameters.Add(New SqlParameter("@Image4", SqlDbType.Image)).Value = DBNull.Value

                                If GetSettingAsPerId(ApplnSettingsIdx.Software_For) = "1" Then
                                    .Parameters.Add(New SqlParameter("@RefDoc_Id", SqlDbType.BigInt)).Value = CurrIntId1
                                    .Parameters.Add(New SqlParameter("@Doc_Type", SqlDbType.Text)).Value = "SO"
                                End If

                            End With

                            cmd.ExecuteNonQuery()
                            cmd.Connection.Dispose()
                            cmd = Nothing
                        End If
                    Next drImageRow

                    ' End If

                    If GetSettingAsPerId(ApplnSettingsIdx.Software_For) = "1" Then
                        ReportParameters.rptFile = ReportPath & "\Forms\PurchaseSO.rpt"
                        If cmbSample.SelectedIndex = 0 Then
                            If cmbPackingD.SelectedIndex = -1 Then Exit Sub
                            If cmbPackingD.SelectedIndex = 0 Then
                                ReportParameters.rptFile = ReportPath & "\Forms\D3.rpt"
                            ElseIf cmbPackingD.SelectedIndex = 1 Then
                                ReportParameters.rptFile = ReportPath & "\Forms\D4.rpt"
                            ElseIf cmbPackingD.SelectedIndex = 2 Then
                                ReportParameters.rptFile = ReportPath & "\Forms\D5.rpt"
                            ElseIf cmbPackingD.SelectedIndex = 3 Then
                                ReportParameters.rptFile = ReportPath & "\Forms\D6.rpt"
                            End If

                        ElseIf cmbSample.SelectedIndex = 1 Then
                            ReportParameters.rptFile = ReportPath & "\Forms\SalesOrderLabeling.rpt"
                            ReportParameters.rptFilter = "{SalesOrder.Doc_Id} = " & CurrIntId1
                            ReportParameters.PrintToPrinter = False
                            ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToWindow
                            ReportParameters.rptCaption = Me.Text
                            Dim frmView1 As New frmViewReports
                            frmView1.Show()
                            ReportParameters.rptFile = ReportPath & "\Forms\SalesOrderLabelingImage.rpt"
                        ElseIf cmbSample.SelectedIndex = 2 Then
                            ReportParameters.rptFile = ReportPath & "\Forms\SalesOrderCarton.rpt"
                        End If
                    Else
                        ReportParameters.rptFile = ReportPath & "\Forms\ProformaInvoice.rpt"
                    End If


                    ReportParameters.rptFilter = "{SalesOrder.Doc_Id} = " & CurrIntId1

                    ReportParameters.PrintToPrinter = False
                    ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToWindow
                    ReportParameters.rptCaption = Me.Text


                    '            strReportFile = ReportPath & "\Reports\PerformaSalesorder.rpt"
                    '            strFormula = "{PurOrder} = '" & SelBranchId & "' and Salesorder.Doc_id=" & ""
                    '            strTitle = "Perfoma Sales Order Report"
                End If
            Case ReportType.CostSheet

                Dim CurrIntId As Integer
                'Query = "Select BomprdStyle_id from Bomprdstyle  where BomprdStyle_id=" & cmbSample.SelectedValue & " "
                If rdCostSheet.Checked = True Then
                    Query = "Select BomprdStyle_id from Bomprdstyle Left Join Style On BomPrdStyle.Style_Key = style.Style_Key  where Style.Style_Code ='" & cmbSample.Text & "' AND BOM_TYPE='S' "
                Else
                    Query = "Select BomprdStyle_id from Bomprdstyle Left Join Style On BomPrdStyle.Style_Key = style.Style_Key  where Style.Style_Code ='" & cmbSample.Text & "' AND BOM_TYPE='O' "
                End If

                Dim DtApproval As DataTable = Common.GetDataTable(Query)

                If DtApproval.Rows.Count > 0 Then
                    CurrIntId = DtApproval.Rows(0)("BomprdStyle_id")
                End If
                If Val(CurrIntId) = 0 Then Exit Sub

                Dim BomType As String
                Query = "Select Bom_Type from Bomprdstyle where Bomprdstyle_id=" & CurrIntId & " "
                Dim Bom As DataTable = Common.GetDataTable(Query)
                If Bom.Rows.Count > 0 Then
                    BomType = Bom.Rows(0)("Bom_Type")
                End If

                '        If BomType = "O" Then
                '            ReportParameters.rptFile = ReportPath & "\Forms\BOMBuyer.rpt"
                '        Else
                '            ReportParameters.rptFile = ReportPath & "\Forms\BOM.rpt"
                '        End If
                '    End If



                '    Dim frmView As New frmViewReports(Formulas)
                '    frmView.Show()

                '    Formulas = Nothing

                '    Me.Cursor = Cursors.Default
                'End Sub

                'Private Sub GetReportDetails(ByRef strReportFile As String, ByRef strFormula As String, ByRef strTitle As String)


                '    Select Case bytRptType
                '        Case ReportType.CostSheet
                '            strReportFile = ReportPath & "\Reports\DayBookSales.rpt"
                '            'strFormula = "{} = '" & SelBranchId & "' AND {BILL.DOC_DT} >= DATE(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") AND {BILL.Doc_DT} <= DATE(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ") "
                '            strTitle = "Cost Sheet Report"

                '        Case ReportType.PerformaSalesOrder
                '            strReportFile = ReportPath & "\Reports\PerformaSalesorder.rpt"
                '            strFormula = "{PurOrder} = '" & SelBranchId & "' and Salesorder.Doc_id=" & ""
                '            strTitle = "Perfoma Sales Order Report"

                '        Case ReportType.PerformaSalesOrder
                '            strReportFile = ReportPath & "\Reports\PurchaseSalesorder.rpt"
                '            strFormula = "{SalesOrder.Cobr_id} = '" & SelBranchId & "' "
                '            strTitle = "Purchase Sales Order Report"
                '    End Select
                'End Sub


                If Val(GetSettingAsPerId(ApplnSettingsIdx.BomType)) = 1 Then
                    Dim ms As MemoryStream
                    Dim cmd As SqlCommand
                    Dim pctlogo As New PictureBox
                    Dim DtTempTble As DataTable
                    Dim i As Short = 0
                    Dim arrImage() As Byte
                    Dim arrImage1() As Byte
                    Dim arrImage2() As Byte
                    Dim arrImage3() As Byte

                    Query = "Delete From TempStyleImage " _
                      & " Where BomPrdStyle_Id =  " & CurrIntId
                    Common.ExecuteQuery(Query)


                    Query = " Select Top 1 Style_ImageF, BomPrdStyle.Style_Key, BomPrdStyle.BomPrdStyle_Id From StyleShade " _
                         & " Left Join BomPrdStyle On BomPrdStyle.Style_Key = StyleShade.Style_Key " _
                         & " WHERE Style_ImageF<>'' And BomPrdStyle.BomPrdStyle_Id = " & CurrIntId _
                         & " ORDER BY StyleShade_Id "

                    DtTempTble = New DataTable
                    DtTempTble = Common.GetDataTable(Query)

                    'For Each drImageRow In DtTempTble.Rows
                    If DtTempTble.Rows.Count > 0 Then

                        pctlogo.Image = System.Drawing.Image.FromFile(GetSettingAsPerId(ApplnSettingsIdx.GenImagePath) & "\Product\" & DtTempTble.Rows(0)("Style_ImageF"))
                        ms = New MemoryStream
                        pctlogo.Image.Save(ms, pctlogo.Image.RawFormat)

                        arrImage = ms.GetBuffer
                        ms.Close()
                        pctlogo.Image = Nothing

                        cmd = New SqlCommand
                        With cmd
                            'If i = 0 Then
                            .Connection = Common.NewSQLConnection
                            .Connection.Open()
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "InsertBomImage"
                            .Parameters.Add(New SqlParameter("@BomPrdStyle_Id", SqlDbType.BigInt)).Value = CurrIntId
                            .Parameters.Add(New SqlParameter("@Style_Key", SqlDbType.Text)).Value = DtTempTble.Rows(0)("Style_Key")
                            .Parameters.Add(New SqlParameter("@SODocDtl_Id", SqlDbType.BigInt)).Value = 0
                            .Parameters.Add(New SqlParameter("@User_Id", SqlDbType.BigInt)).Value = UserId
                            .Parameters.Add(New SqlParameter("@Image1", SqlDbType.Image)).Value = arrImage
                            .Parameters.Add(New SqlParameter("@Image2", SqlDbType.Image)).Value = DBNull.Value
                            .Parameters.Add(New SqlParameter("@Image3", SqlDbType.Image)).Value = DBNull.Value
                            .Parameters.Add(New SqlParameter("@Image4", SqlDbType.Image)).Value = DBNull.Value

                            .Parameters.Add(New SqlParameter("@RefDoc_Id", SqlDbType.BigInt)).Value = CurrIntId
                            .Parameters.Add(New SqlParameter("@Doc_Type", SqlDbType.Text)).Value = "BM"
                            i = i + 1
                        End With

                        cmd.ExecuteNonQuery()
                        cmd.Connection.Close()
                        cmd = Nothing

                    End If
                End If


                If BomType = "O" Then
                    ReportParameters.rptFile = ReportPath & "\Forms\BOMBuyer.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Forms\BOM.rpt"
                End If

                ReportParameters.rptFilter = "{vw_BOMDetails.BomPrdStyle_Id} = " & CurrIntId

            Case ReportType.FabOrder
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from PurOrder  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\FabricOrder.rpt"
                ReportParameters.rptFilter = "{PurOrder.Doc_ID} = " & CurrIntId1

            Case ReportType.FinOrder
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from PurOrder  where Doc_id=" & cmbParty.SelectedValue & "   "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\PurchaseOrder(ITEM).rpt"
                ReportParameters.rptFilter = "{PurOrder.Doc_ID} = " & CurrIntId1

            Case ReportType.AccOrder
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from PurOrder  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\AccOrder.rpt"
                ReportParameters.rptFilter = "{PurOrder.Doc_ID} = " & CurrIntId1


            Case ReportType.BuyerStandardLabel
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from PurOrder  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\LabelOrder.rpt"
                ReportParameters.rptFilter = "{PurOrder.Doc_ID} = " & CurrIntId1

            Case ReportType.JobWorkPO
                Dim CurrIntId1 As Integer
                Dim Job_Type As String = ""
                Query = "Select Doc_id from JobWorkPO  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub

                Query = "Select Job_Type from JobWorkPO  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval1 As DataTable = Common.GetDataTable(Query)
                If DtApproval1.Rows.Count > 0 Then
                    Job_Type = DtApproval1.Rows(0).Item("Job_Type")
                End If
                If Job_Type = "G" Then
                    ReportParameters.rptFile = ReportPath & "\Forms\JobWorkPOFabric.rpt"
                ElseIf Job_Type = "F" Then
                    ReportParameters.rptFile = ReportPath & "\Forms\JobWorkPOFinish.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Forms\JobWorkPOAcc.rpt"
                End If

                ReportParameters.rptFilter = "{JobWorkPO.Doc_ID} = " & CurrIntId1

            Case ReportType.JobWorkOrder
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from JobOrder  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\JOBWORKORDER.rpt"
                ReportParameters.rptFilter = "{JobOrder.Doc_ID} = " & CurrIntId1

            Case ReportType.FabGRN
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from Purchase  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\FabricPurchase.rpt"
                ReportParameters.rptFilter = "{Purchase.Doc_ID} = " & CurrIntId1

            Case ReportType.FinGRN
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from Purchase  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\Purchase.rpt"
                ReportParameters.rptFilter = "{Purchase.Doc_ID} = " & CurrIntId1

            Case ReportType.AccGRN
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from Purchase  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\AccPurchase.rpt"
                ReportParameters.rptFilter = "{Purchase.Doc_ID} = " & CurrIntId1

            Case ReportType.BuyerStandardLabelGRN
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from Purchase  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\PurchaseLabel.rpt"
                ReportParameters.rptFilter = "{Purchase.Doc_ID} = " & CurrIntId1

            Case ReportType.JobWorkPORecv
                Dim CurrIntId1 As Integer
                Dim Rct_Type As String = ""
                Query = "Select Doc_id from ProcIsuRct  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub

                Query = "Select Rct_Type from ProcIsuRct  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval2 As DataTable = Common.GetDataTable(Query)
                If DtApproval2.Rows.Count > 0 Then
                    Rct_Type = DtApproval2.Rows(0).Item("Rct_Type")
                End If
                If Rct_Type = "GR" Then
                    ReportParameters.rptFile = ReportPath & "\Forms\FabRec.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Forms\AccRec.rpt"
                End If


                ReportParameters.rptFilter = "{ProcIsuRct.Doc_ID} = " & CurrIntId1

            Case ReportType.JobWorkOrderRecv
                Dim CurrIntId1 As Integer
                Query = "Select Doc_id from ProcRct where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval As DataTable = Common.GetDataTable(Query)
                If DtApproval.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub
                ReportParameters.rptFile = ReportPath & "\Forms\JobCard.rpt"
                ReportParameters.rptFilter = "{ProcIsu.Doc_ID} = " & CurrIntId1

            Case ReportType.FabRtn
                Dim CurrIntId1 As Integer
                Dim Rtn_For As String = ""
                Query = "Select Doc_id from purchaseRtn  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval2 As DataTable = Common.GetDataTable(Query)
                If DtApproval2.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval2.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub

                Query = "Select Rtn_For from purchaseRtn  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval3 As DataTable = Common.GetDataTable(Query)
                If DtApproval3.Rows.Count > 0 Then
                    Rtn_For = DtApproval3.Rows(0).Item("Rtn_For")
                End If
                If Rtn_For = "E" Then
                    ReportParameters.rptFile = ReportPath & "\Forms\FabricPurchaseRtn.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Forms\FabricPurchaseRtnRedo.rpt"
                End If

                ReportParameters.rptFilter = "{purchaseRtn.Doc_ID} = " & CurrIntId1

            Case ReportType.FinRtn
                Dim CurrIntId1 As Integer
                Dim Rtn_For As String = ""
                Query = "Select Doc_id from purchaseRtn  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval2 As DataTable = Common.GetDataTable(Query)
                If DtApproval2.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval2.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub

                Query = "Select Rtn_For from purchaseRtn  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval3 As DataTable = Common.GetDataTable(Query)
                If DtApproval3.Rows.Count > 0 Then
                    Rtn_For = DtApproval3.Rows(0).Item("Rtn_For")
                End If
                If Rtn_For = "E" Then
                    ReportParameters.rptFile = ReportPath & "\Forms\PurchaseRtn.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Forms\PurchaseRtnRedo.rpt"
                End If

                ReportParameters.rptFilter = "{purchaseRtn.Doc_ID} = " & CurrIntId1

            Case ReportType.AccRtn
                Dim CurrIntId1 As Integer
                Dim Rtn_For As String = ""
                Query = "Select Doc_id from purchaseRtn  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval2 As DataTable = Common.GetDataTable(Query)
                If DtApproval2.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval2.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub

                Query = "Select Rtn_For from purchaseRtn  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval3 As DataTable = Common.GetDataTable(Query)
                If DtApproval3.Rows.Count > 0 Then
                    Rtn_For = DtApproval3.Rows(0).Item("Rtn_For")
                End If
                If Rtn_For = "E" Then
                    ReportParameters.rptFile = ReportPath & "\Forms\AccPurchaseRtn.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Forms\AccPurchaseRtnRedo.rpt"
                End If

                ReportParameters.rptFilter = "{purchaseRtn.Doc_ID} = " & CurrIntId1

            Case ReportType.BuyerStandardLabelRtn
                Dim CurrIntId1 As Integer
                Dim Rtn_For As String = ""
                Query = "Select Doc_id from purchaseRtn  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval2 As DataTable = Common.GetDataTable(Query)
                If DtApproval2.Rows.Count > 0 Then
                    CurrIntId1 = DtApproval2.Rows(0)("Doc_id")
                End If
                If CurrIntId1 = 0 Then Exit Sub

                Query = "Select Rtn_For from purchaseRtn  where Doc_id=" & cmbParty.SelectedValue & " "
                Dim DtApproval3 As DataTable = Common.GetDataTable(Query)
                If DtApproval3.Rows.Count > 0 Then
                    Rtn_For = DtApproval3.Rows(0).Item("Rtn_For")
                End If
                If Rtn_For = "E" Then
                    ReportParameters.rptFile = ReportPath & "\Forms\LabelPurchaseRtn.rpt"
                Else
                    ReportParameters.rptFile = ReportPath & "\Forms\LabelPurchaseRtnRedo.rpt"
                End If

                ReportParameters.rptFilter = "{purchaseRtn.Doc_ID} = " & CurrIntId1

        End Select

        ReportParameters.PrintToPrinter = False
        ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToWindow
        ReportParameters.rptCaption = Me.Text

        Dim frmView As New frmViewReports
        frmView.Show()
    End Sub
    Private Sub rdPartySupl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPartySupl.CheckedChanged, rdCostSheet.CheckedChanged
        If rdCostSheet.Checked = True Then
            cmbParty.Enabled = False
            cmbParty.Text = ""
            Query = " Select Distinct Style.Style_Code,Style_id From Style " _
                & " Left Join BomprdStyle on Style.Style_key=BomprdStyle.Style_Key where Bom_Type='S' "
            Common.FillCombo2(Query, cmbSample, "Style_Code", "Style_id")
        Else
            cmbParty.Enabled = True
            Query = " Select Distinct Style.Style_Code,Style_id From Style " _
               & " Left Join BomprdStyle on Style.Style_key=BomprdStyle.Style_Key where Bom_Type='O' "
            Common.FillCombo2(Query, cmbSample, "Style_Code", "Style_id")

            Query = " select '' Led_Name , '' Led_Key Union All select led_Name,led_key from ledger left join BomprdStyle on BomprdStyle.Cust_Key=Ledger.Led_key where led_cat='W' and ledger.Status='1'" _
                & " Order By Led_Name"
            Common.FillCombo2(Query, cmbParty, "Led_Name", "Led_Key")
            If cmbParty.Items.Count > 0 Then
                cmbParty.SelectedIndex = 0
            End If
        End If
    End Sub

    ' Private Sub rdCostSheet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdCostSheet.CheckedChanged
    'cmbParty.Enabled = False
    'cmbParty.Text = ""
    'Query = " Select Distinct Style.Style_Code,Style_id From Style " _
    '    & " Left Join BomprdStyle on Style.Style_key=BomprdStyle.Style_Key where Bom_Type='S' "
    'Common.FillCombo2(Query, cmbSample, "Style_Code", "Style_id")
    ' End Sub

    Private Sub cmbParty_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbParty.SelectedValueChanged

        If rdPartySupl.Checked = True Then
            Query = " Select '' Style_Code , 0 Style_Id Union All Select Distinct Style.Style_Code,Style_id From Style " _
                              & " Left Join BomprdStyle on Style.Style_key=BomprdStyle.Style_Key where Bom_Type='O' and BomprdStyle.Cust_key='" & cmbParty.SelectedValue & "' "
            Common.FillCombo2(Query, cmbSample, "Style_Code", "Style_id")
            If cmbSample.Items.Count > 0 Then
                cmbSample.SelectedIndex = 0
            End If
        End If

    End Sub

    Private Sub cmbSample_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSample.KeyPress
        cmbSample.DroppedDown = False
    End Sub

    Private Sub cmbParty_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbParty.Validated
        If cmbParty.SelectedIndex = -1 Then cmbParty.SelectedIndex = 0
    End Sub

    Private Sub cmbSample_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSample.Validated
        If cmbSample.SelectedIndex = -1 Then cmbSample.SelectedIndex = 0
    End Sub

    Private Sub cmbParty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbParty.KeyPress
        cmbParty.DroppedDown = False
    End Sub

    Private Sub cmbSample_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSample.SelectedValueChanged
        If bytRptType = ReportType.PurchaseSalesOrder Then
            If cmbSample.SelectedIndex = 0 Then
                cmbPackingD.Visible = True
                lblReportType.Visible = True
                cmbPackingD.SelectedIndex = 0
            Else
                cmbPackingD.Visible = False
                lblReportType.Visible = False
            End If
        Else
            cmbPackingD.Visible = False
            lblReportType.Visible = False
        End If
    End Sub

    
End Class
