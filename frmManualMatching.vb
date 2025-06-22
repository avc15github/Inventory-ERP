Imports System.Data.SqlClient

Public Class frmManualMatching
    Inherits System.Windows.Forms.Form

    Dim LedType As String = ""
    Dim blnFlag As Boolean

    Private Sub frmManualMatching_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Query = "SELECT LED_KEY, LED_NAME FROM LEDGER" _
               & " WHERE STATUS = '1' and LED_CAT ='B' AND LED_NAME <> '' ORDER BY LED_NAME"
        Dim dtBroker As DataTable = Common.GetDataTableWithAll(Query)

        With cmbBroker
            .DataSource = dtBroker
            .DisplayMember = "LED_NAME"
            .ValueMember = "LED_KEY"
        End With

        If rdReceivables.Checked Then
            LedType = " And AccLGrp.AccLGrp_Type='4'"
        ElseIf rdPayables.Checked Then
            LedType = " And AccLGrp.AccLGrp_Type='3'"
        End If

        Query = "SELECT LED_KEY, LED_NAME FROM LEDGER" _
                & " Left Join AccLGrp on Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                & " WHERE LEDGER.STATUS = '1' AND LED_NAME <> '' " & LedType & " ORDER BY LED_NAME"
        Dim dtParty As DataTable = Common.GetDataTableWithAll(Query)

        With cmbParty
            .DataSource = dtParty
            .DisplayMember = "LED_NAME"
            .ValueMember = "LED_KEY"
        End With

    End Sub

    Private Sub rdOneParty_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdOneParty.CheckedChanged, rdAllParties.CheckedChanged
        If rdOneParty.Checked Then
            pnlParty.Visible = True
        Else
            pnlParty.Visible = False
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim strPartyKey As String = ""
        Dim blnOnlyOS, blnReceivable As Boolean

        If rdOneParty.Checked Then
            If cmbParty.SelectedIndex = 0 Then
                MsgBox("Please Select Party !", MsgBoxStyle.Exclamation)
                cmbParty.Focus()
                Exit Sub
            End If
        End If

        If rdReceivables.Checked Then
            blnReceivable = True
        Else
            blnReceivable = False
        End If

        If rdOneParty.Checked Then
            strPartyKey = cmbParty.SelectedValue
        End If

        If rdOnlyOSTrans.Checked Then
            blnOnlyOS = True
        Else
            blnOnlyOS = False
        End If

        blnFlag = False
        Me.Cursor = Cursors.WaitCursor
        Dim frmMMRcptPymt As New frmMMRcptPymt(strPartyKey, blnOnlyOS, blnReceivable, True)
        frmMMRcptPymt.MdiParent = Me.MdiParent
        frmMMRcptPymt.Tag = "Document Adjustment"
        frmMMRcptPymt.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub rdReceivables_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdReceivables.CheckedChanged, rdPayables.CheckedChanged
        If rdReceivables.Checked Then
            LedType = " And AccLGrp.AccLGrp_Type='4'"
        ElseIf rdPayables.Checked Then
            LedType = " And AccLGrp.AccLGrp_Type='3'"
        End If

        Query = "SELECT LED_KEY, LED_NAME FROM LEDGER" _
                & " Left Join AccLGrp on Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key " _
                & " WHERE LEDGER.STATUS = '1' AND LED_NAME <> '' " & LedType & " ORDER BY LED_NAME"
        Dim dtParty As DataTable = Common.GetDataTableWithAll(Query)

        With cmbParty
            .DataSource = dtParty
            .DisplayMember = "LED_NAME"
            .ValueMember = "LED_KEY"
        End With
    End Sub

    Private Sub cmbBroker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBroker.KeyDown, cmbParty.KeyDown
        Call MoveToNextControl(e)
    End Sub

    Private Sub rdAllParties_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdAllParties.KeyDown, rdAllTrans.KeyDown, rdOneParty.KeyDown, rdOnlyOSTrans.KeyDown, rdPayables.KeyDown, rdReceivables.KeyDown
        Call MoveToNextControl(e)
    End Sub

End Class