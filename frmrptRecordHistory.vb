
Public Class frmrptRecordHistory

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim frmView As Form
        Dim formulas As New Hashtable
        Dim UserFltr As String = ""

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim FlagFltr As String = ""

            If rdAdd.Checked Then
                FlagFltr = " And {RecHistory.AEDFlag} = 'A'"
            ElseIf rdEdit.Checked Then
                FlagFltr = " And {RecHistory.AEDFlag} = 'E'"
            ElseIf rdDelete.Checked Then
                FlagFltr = " And {RecHistory.AEDFlag} = 'D'"
            End If

            UserFltr = GetFilter()

            formulas.Add("stDate#S", Format$(dtpFrom.Value, "dd/MM/yyyy"))
            formulas.Add("ToDate#S", Format$(dtpTo.Value, "dd/MM/yyyy"))

            Dim FromToDt As String = " And {RecHistory.AEDDt} >= Date(" & Format$(dtpFrom.Value, "yyyy,MM,dd") & ") And {RecHistory.AEDDt} <= Date(" & Format$(dtpTo.Value, "yyyy,MM,dd") & ")"
            ReportParameters.rptFile = ReportPath & "\Misc\RecHistory.rpt"
            ReportParameters.rptCaption = Me.Text
            ReportParameters.rptFilter = "{RecHistory.CoBrId} = '" & SelBranchId & "'" & FromToDt & FlagFltr & UserFltr

            frmView = New frmViewReports(formulas)
            frmView.Show()

            Formulas = Nothing


        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmrptRecordHistory_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub frmrptRecordHistory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmrptRecordHistory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpFrom.Value = AccFromDt
        dtpTo.Value = AccToDt

        Query = "Select USERS.USER_ID, LED_NAME " _
           & " From Users Inner Join Ledger On Users.Led_Key = Ledger.Led_Key " _
           & " Where Users.User_Id > 0" _
           & " Order By Led_Name"
        Common.FillCheckBoxCombo(Query, cmbUsers, "LED_NAME", "USER_ID")
    End Sub

    Private Function GetFilter() As String
        Dim SelUsers As String = ""

        SelUsers = GetSelectedAttributes(cmbUsers, "RecHistory.AEDBy")
        If SelUsers.Trim.Length > 0 Then
            SelUsers = " And " & SelUsers
        End If

        Return SelUsers
    End Function

    Private Function GetSelectedAttributes(ByVal Combo As Object, ByVal FieldName As String)
        Dim SelectedItems As String = ""
        Dim AllItems As String = ""
        Dim SelValues As String = ""

        SelectedItems = Combo.Properties.GetCheckedItems
        AllItems = SelectedList(Combo, SelectedItems)

        If AllItems <> "" Then
            SelValues = " {" & FieldName & "} In [" & AllItems & "]"
        Else
            SelValues = ""
        End If

        Return SelValues
    End Function

    Private Function SelectedList(ByVal Combo As Object, ByVal SelectedItems As String, Optional ByVal IsNumber As Boolean = True) As String
        Dim AllItems() As String = Split(SelectedItems, ",")

        If SelectedItems = "" Then Return ""

        Dim NewItemList As String = ""
        Dim obj As Object

        For Each obj In AllItems
            If IsNumber Then
                NewItemList &= Trim(obj) & ","
            Else
                NewItemList &= Trim(obj) & "','"
            End If
        Next obj

        If NewItemList.Trim.Length > 0 Then
            If IsNumber Then
                NewItemList = Mid$(NewItemList, 1, Len(NewItemList) - 1)
                NewItemList = NewItemList
            Else
                NewItemList = Mid$(NewItemList, 1, Len(NewItemList) - 2)
                NewItemList = "'" & NewItemList
            End If
        End If

        Return NewItemList
    End Function

    Private Sub grpMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpMain.Click

    End Sub

    Private Sub rdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdAdd.Click

    End Sub

    Private Sub dtpFrom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFrom.Click

    End Sub

    Private Sub btnView_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.VisibleChanged

    End Sub

    Private Sub frmrptRecordHistory_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick

    End Sub

    Private Sub frmrptRecordHistory_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating

    End Sub

    Private Sub frmrptRecordHistory_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

    End Sub

    Private Sub rdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdDelete.Click

    End Sub

    Private Sub rdAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdAll.Click

    End Sub
End Class