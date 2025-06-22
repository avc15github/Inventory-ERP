Imports System.Data.SqlClient

Public Class frmrptRateList
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Rate As RateList)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        RtLst = Rate
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCategoryFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCategoryTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbProductFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProductTo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClientCat As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lblFormCaption As System.Windows.Forms.Label
    Friend WithEvents lblClientCat As System.Windows.Forms.Label
    Friend WithEvents mnuSelection As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUnSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInvertSelect As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSrchStyle As System.Windows.Forms.TextBox
    Friend WithEvents lvwStyle As System.Windows.Forms.ListView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents mnuChkSelected As System.Windows.Forms.MenuItem
    Friend WithEvents cmbStyleFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStyleTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdMRP As System.Windows.Forms.RadioButton
    Friend WithEvents rdWSP As System.Windows.Forms.RadioButton
    Friend WithEvents rdCP As System.Windows.Forms.RadioButton
    Friend WithEvents rdMRPWSP As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.rdAll = New System.Windows.Forms.RadioButton
        Me.cmbStyleFrom = New System.Windows.Forms.ComboBox
        Me.cmbStyleTo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lvwStyle = New System.Windows.Forms.ListView
        Me.txtSrchStyle = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFormCaption = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.cmbCategoryFrom = New System.Windows.Forms.ComboBox
        Me.cmbCategoryTo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbProductFrom = New System.Windows.Forms.ComboBox
        Me.cmbProductTo = New System.Windows.Forms.ComboBox
        Me.cmbClientCat = New System.Windows.Forms.ComboBox
        Me.lblClientCat = New System.Windows.Forms.Label
        Me.rdMRP = New System.Windows.Forms.RadioButton
        Me.rdWSP = New System.Windows.Forms.RadioButton
        Me.rdCP = New System.Windows.Forms.RadioButton
        Me.rdMRPWSP = New System.Windows.Forms.RadioButton
        Me.mnuSelection = New System.Windows.Forms.ContextMenu
        Me.mnuChkSelected = New System.Windows.Forms.MenuItem
        Me.mnuSelectAll = New System.Windows.Forms.MenuItem
        Me.mnuUnSelectAll = New System.Windows.Forms.MenuItem
        Me.mnuInvertSelect = New System.Windows.Forms.MenuItem
        Me.grpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.rdAll)
        Me.grpMain.Controls.Add(Me.cmbStyleFrom)
        Me.grpMain.Controls.Add(Me.cmbStyleTo)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.btnSearch)
        Me.grpMain.Controls.Add(Me.lvwStyle)
        Me.grpMain.Controls.Add(Me.txtSrchStyle)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.lblFormCaption)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.btnShow)
        Me.grpMain.Controls.Add(Me.cmbCategoryFrom)
        Me.grpMain.Controls.Add(Me.cmbCategoryTo)
        Me.grpMain.Controls.Add(Me.Label7)
        Me.grpMain.Controls.Add(Me.Label8)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.Label9)
        Me.grpMain.Controls.Add(Me.cmbProductFrom)
        Me.grpMain.Controls.Add(Me.cmbProductTo)
        Me.grpMain.Controls.Add(Me.cmbClientCat)
        Me.grpMain.Controls.Add(Me.lblClientCat)
        Me.grpMain.Controls.Add(Me.rdMRP)
        Me.grpMain.Controls.Add(Me.rdWSP)
        Me.grpMain.Controls.Add(Me.rdCP)
        Me.grpMain.Controls.Add(Me.rdMRPWSP)
        Me.grpMain.Location = New System.Drawing.Point(9, 8)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(632, 512)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'rdAll
        '
        Me.rdAll.Checked = True
        Me.rdAll.Location = New System.Drawing.Point(16, 437)
        Me.rdAll.Name = "rdAll"
        Me.rdAll.Size = New System.Drawing.Size(48, 16)
        Me.rdAll.TabIndex = 188
        Me.rdAll.TabStop = True
        Me.rdAll.Text = "All"
        '
        'cmbStyleFrom
        '
        Me.cmbStyleFrom.DropDownWidth = 275
        Me.cmbStyleFrom.Location = New System.Drawing.Point(121, 144)
        Me.cmbStyleFrom.Name = "cmbStyleFrom"
        Me.cmbStyleFrom.Size = New System.Drawing.Size(211, 21)
        Me.cmbStyleFrom.TabIndex = 11
        Me.cmbStyleFrom.Tag = "From Style"
        '
        'cmbStyleTo
        '
        Me.cmbStyleTo.DropDownWidth = 275
        Me.cmbStyleTo.Location = New System.Drawing.Point(389, 144)
        Me.cmbStyleTo.Name = "cmbStyleTo"
        Me.cmbStyleTo.Size = New System.Drawing.Size(211, 21)
        Me.cmbStyleTo.TabIndex = 13
        Me.cmbStyleTo.Tag = "To Style"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Tag = ""
        Me.Label2.Text = "Style From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Tag = ""
        Me.Label3.Text = "To"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnSearch.Location = New System.Drawing.Point(576, 160)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 21)
        Me.btnSearch.TabIndex = 187
        Me.btnSearch.Text = "..."
        Me.btnSearch.Visible = False
        '
        'lvwStyle
        '
        Me.lvwStyle.CheckBoxes = True
        Me.lvwStyle.Location = New System.Drawing.Point(16, 184)
        Me.lvwStyle.Name = "lvwStyle"
        Me.lvwStyle.Size = New System.Drawing.Size(600, 240)
        Me.lvwStyle.TabIndex = 14
        Me.lvwStyle.TabStop = False
        Me.lvwStyle.UseCompatibleStateImageBehavior = False
        Me.lvwStyle.View = System.Windows.Forms.View.List
        '
        'txtSrchStyle
        '
        Me.txtSrchStyle.Location = New System.Drawing.Point(120, 192)
        Me.txtSrchStyle.Name = "txtSrchStyle"
        Me.txtSrchStyle.Size = New System.Drawing.Size(440, 21)
        Me.txtSrchStyle.TabIndex = 181
        Me.txtSrchStyle.TabStop = False
        Me.txtSrchStyle.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "Search"
        Me.Label1.Visible = False
        '
        'lblFormCaption
        '
        Me.lblFormCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFormCaption.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormCaption.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFormCaption.Location = New System.Drawing.Point(3, 17)
        Me.lblFormCaption.Name = "lblFormCaption"
        Me.lblFormCaption.Size = New System.Drawing.Size(626, 24)
        Me.lblFormCaption.TabIndex = 25
        Me.lblFormCaption.Text = "Rate List"
        Me.lblFormCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnExit.Location = New System.Drawing.Point(328, 471)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 28)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnShow.Location = New System.Drawing.Point(208, 471)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(88, 28)
        Me.btnShow.TabIndex = 15
        Me.btnShow.Text = "&View"
        '
        'cmbCategoryFrom
        '
        Me.cmbCategoryFrom.DropDownWidth = 275
        Me.cmbCategoryFrom.Location = New System.Drawing.Point(121, 86)
        Me.cmbCategoryFrom.Name = "cmbCategoryFrom"
        Me.cmbCategoryFrom.Size = New System.Drawing.Size(211, 21)
        Me.cmbCategoryFrom.TabIndex = 3
        Me.cmbCategoryFrom.Tag = "From Category"
        '
        'cmbCategoryTo
        '
        Me.cmbCategoryTo.DropDownWidth = 275
        Me.cmbCategoryTo.Location = New System.Drawing.Point(389, 86)
        Me.cmbCategoryTo.Name = "cmbCategoryTo"
        Me.cmbCategoryTo.Size = New System.Drawing.Size(211, 21)
        Me.cmbCategoryTo.TabIndex = 5
        Me.cmbCategoryTo.Tag = "To Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Tag = ""
        Me.Label7.Text = "Product From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(363, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Tag = ""
        Me.Label8.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(363, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Tag = ""
        Me.Label5.Text = "To"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Tag = ""
        Me.Label9.Text = "SubGroup From"
        '
        'cmbProductFrom
        '
        Me.cmbProductFrom.DropDownWidth = 275
        Me.cmbProductFrom.Location = New System.Drawing.Point(121, 115)
        Me.cmbProductFrom.Name = "cmbProductFrom"
        Me.cmbProductFrom.Size = New System.Drawing.Size(211, 21)
        Me.cmbProductFrom.TabIndex = 7
        Me.cmbProductFrom.Tag = "From Product"
        '
        'cmbProductTo
        '
        Me.cmbProductTo.DropDownWidth = 275
        Me.cmbProductTo.Location = New System.Drawing.Point(389, 115)
        Me.cmbProductTo.Name = "cmbProductTo"
        Me.cmbProductTo.Size = New System.Drawing.Size(211, 21)
        Me.cmbProductTo.TabIndex = 9
        Me.cmbProductTo.Tag = "To Product"
        '
        'cmbClientCat
        '
        Me.cmbClientCat.Location = New System.Drawing.Point(240, 56)
        Me.cmbClientCat.Name = "cmbClientCat"
        Me.cmbClientCat.Size = New System.Drawing.Size(224, 21)
        Me.cmbClientCat.TabIndex = 1
        Me.cmbClientCat.Tag = "Client Category"
        Me.cmbClientCat.Visible = False
        '
        'lblClientCat
        '
        Me.lblClientCat.AutoSize = True
        Me.lblClientCat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientCat.Location = New System.Drawing.Point(128, 58)
        Me.lblClientCat.Name = "lblClientCat"
        Me.lblClientCat.Size = New System.Drawing.Size(99, 13)
        Me.lblClientCat.TabIndex = 0
        Me.lblClientCat.Tag = ""
        Me.lblClientCat.Text = "Rate Category"
        Me.lblClientCat.Visible = False
        '
        'rdMRP
        '
        Me.rdMRP.Location = New System.Drawing.Point(80, 437)
        Me.rdMRP.Name = "rdMRP"
        Me.rdMRP.Size = New System.Drawing.Size(48, 16)
        Me.rdMRP.TabIndex = 188
        Me.rdMRP.Text = "MRP"
        '
        'rdWSP
        '
        Me.rdWSP.Location = New System.Drawing.Point(144, 437)
        Me.rdWSP.Name = "rdWSP"
        Me.rdWSP.Size = New System.Drawing.Size(48, 16)
        Me.rdWSP.TabIndex = 188
        Me.rdWSP.Text = "WSP"
        '
        'rdCP
        '
        Me.rdCP.Location = New System.Drawing.Point(208, 437)
        Me.rdCP.Name = "rdCP"
        Me.rdCP.Size = New System.Drawing.Size(48, 16)
        Me.rdCP.TabIndex = 188
        Me.rdCP.Text = "CP"
        '
        'rdMRPWSP
        '
        Me.rdMRPWSP.Location = New System.Drawing.Point(272, 437)
        Me.rdMRPWSP.Name = "rdMRPWSP"
        Me.rdMRPWSP.Size = New System.Drawing.Size(96, 16)
        Me.rdMRPWSP.TabIndex = 188
        Me.rdMRPWSP.Text = "MRP + WSP"
        '
        'mnuSelection
        '
        Me.mnuSelection.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuChkSelected, Me.mnuSelectAll, Me.mnuUnSelectAll, Me.mnuInvertSelect})
        '
        'mnuChkSelected
        '
        Me.mnuChkSelected.Index = 0
        Me.mnuChkSelected.Text = "Check Selected"
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Index = 1
        Me.mnuSelectAll.Text = "Select All"
        '
        'mnuUnSelectAll
        '
        Me.mnuUnSelectAll.Index = 2
        Me.mnuUnSelectAll.Text = "UnSelect All"
        '
        'mnuInvertSelect
        '
        Me.mnuInvertSelect.Index = 3
        Me.mnuInvertSelect.Text = "Invert Select"
        '
        'frmrptRateList
        '
        Me.ClientSize = New System.Drawing.Size(650, 527)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmrptRateList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rate List"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Enum RateList
        StandardList
        CategoryWise
        AllCategory
    End Enum

    Dim RtLst As RateList
    Dim Loading As Boolean

    Private Sub frmRateList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Loading = True
        If RtLst = RateList.StandardList Then
            lblFormCaption.Text = "Standard Rate List"
        ElseIf RtLst = RateList.CategoryWise Then
            lblFormCaption.Text = "Rate List (Category Wise)"
        ElseIf RtLst = RateList.AllCategory Then
            lblFormCaption.Text = "Rate List (All Category)"
        End If
        Me.Text = lblFormCaption.Text

        Try
            Me.Cursor = Cursors.WaitCursor

            If RtLst = RateList.AllCategory Or RtLst = RateList.CategoryWise Then
                Query = "Select RateCat_Id, RateCat_Name " _
                     & " From RateCat " _
                     & " Where RateCat_Id <> 0 " _
                     & " Order By RateCat_Name "
                Dim ClientCategory As DataTable = Common.GetDataTableWithAll(Query)

                With cmbClientCat
                    .DataSource = ClientCategory
                    .DisplayMember = "RateCat_Name"
                    .ValueMember = "RateCat_Id"
                End With
                lblClientCat.Visible = True : cmbClientCat.Visible = True
            End If

            Query = "Select ITEMSUBGRP_KEY, ITEMSUBGRP_NAME " _
                & " From ItemSubGrp Left Join ItemGrp On ItemSubGrp.ItemGrp_Key = ItemGrp.ItemGrp_Key " _
                & " Where ItemSubGrp.Status = '1' And ItemSubGrp_Name <> '' And ItemSubGrp_Type = 'F' " _
                & " Order By ItemSubGrp_Name "
            Dim dtCatFrom As DataTable = Common.GetDataTableWithAll(Query)

            With cmbCategoryFrom
                .DataSource = dtCatFrom
                .DisplayMember = "ITEMSUBGRP_NAME"
                .ValueMember = "ITEMSUBGRP_KEY"
            End With

            Query = "Select ITEMSUBGRP_KEY, ITEMSUBGRP_NAME " _
                & " From ItemSubGrp Left Join ItemGrp On ItemSubGrp.ItemGrp_Key = ItemGrp.ItemGrp_Key " _
                & " Where ItemSubGrp.Status = '1' And ItemSubGrp_Name <> '' And ItemSubGrp_Type = 'F' " _
                & " Order By ItemSubGrp_Name "
            Dim dtCatTo As DataTable = Common.GetDataTableWithAll(Query)

            With cmbCategoryTo
                .DataSource = dtCatTo
                .DisplayMember = "ITEMSUBGRP_NAME"
                .ValueMember = "ITEMSUBGRP_KEY"
            End With

            If cmbCategoryFrom.Items.Count > 0 Then
                cmbCategoryFrom.SelectedIndex = 0
                Call cmbCategoryFrom_SelectionChangeCommitted(cmbCategoryFrom, Nothing)
            End If

            lvwStyle.ContextMenu = mnuSelection
            lvwStyle.Focus()
            Loading = False

        Catch sqlEx As SqlException
            Call Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbCategoryFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCategoryFrom.SelectionChangeCommitted
        If cmbCategoryFrom.SelectedIndex = -1 Then Exit Sub

        cmbCategoryTo.SelectedIndex = cmbCategoryFrom.SelectedIndex
        Call DisplayProduct()
    End Sub

    Private Sub DisplayProduct()
        Dim strFilter As String = ""

        If cmbCategoryFrom.SelectedIndex > 0 Then
            If cmbCategoryTo.SelectedIndex > 0 Then
                strFilter = " AND (ItemSubGrp.ITEMSUBGRP_NAME >= '" & ReplaceApostrophe(cmbCategoryFrom.Text) & "' AND ItemSubGrp.ITEMSUBGRP_NAME <= '" & ReplaceApostrophe(cmbCategoryTo.Text) & "')"
            Else
                strFilter = " AND (ItemSubGrp.ITEMSUBGRP_NAME >= '" & ReplaceApostrophe(cmbCategoryFrom.Text) & "')"
            End If
        End If

        Query = "Select ITEM_KEY, ITEM_NAME " _
            & " From Item Left Join ItemSubGrp On Item.ItemSubGrp_Key = ItemSubGrp.ItemSubGrp_Key " _
            & " Where Item.Status = '1' And Item_Name <> '' And Item_Type = 'F' " & strFilter _
            & " Order By Item_Name"
        Dim dtPrdFrom As DataTable = Common.GetDataTableWithAll(Query)

        With cmbProductFrom
            .DataSource = dtPrdFrom
            .DisplayMember = "ITEM_NAME"
            .ValueMember = "ITEM_KEY"
        End With

        Query = "Select ITEM_KEY, ITEM_NAME " _
            & " From Item Left Join ItemSubGrp On Item.ItemSubGrp_Key = ItemSubGrp.ItemSubGrp_Key " _
            & " Where Item.Status = '1' And Item_Name <> '' And Item_Type = 'F' " & strFilter _
            & " Order By Item_Name"
        Dim dtPrdTo As DataTable = Common.GetDataTableWithAll(Query)

        With cmbProductTo
            .DataSource = dtPrdTo
            .DisplayMember = "ITEM_NAME"
            .ValueMember = "ITEM_KEY"
        End With

        If cmbProductFrom.Items.Count > 0 Then
            cmbProductFrom.SelectedIndex = 0
            Call cmbProductFrom_SelectionChangeCommitted(cmbProductFrom, Nothing)
        End If
    End Sub

    Private Sub cmbCategoryTo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCategoryTo.SelectionChangeCommitted
        If cmbCategoryTo.SelectedIndex = -1 Then Exit Sub
        Call DisplayProduct()
    End Sub

    Private Sub cmbClientCat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbClientCat.KeyDown, cmbCategoryFrom.KeyDown, cmbCategoryTo.KeyDown, cmbProductFrom.KeyDown, cmbProductTo.KeyDown, cmbStyleFrom.KeyDown, cmbStyleTo.KeyDown
        Call MoveToNextControl(e)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If RtLst = RateList.AllCategory Or RtLst = RateList.CategoryWise Then
            If cmbClientCat.SelectedIndex = -1 Or cmbCategoryTo.SelectedIndex = -1 Then
                MsgBox("Invalid Rate Category selected !", MsgBoxStyle.Exclamation)
                cmbClientCat.Focus()
                Exit Sub
            End If
        End If

        If cmbCategoryFrom.SelectedIndex = -1 Or cmbCategoryTo.SelectedIndex = -1 Then
            MsgBox("Invalid SubGroup selected !", MsgBoxStyle.Exclamation)
            cmbCategoryFrom.Focus()
            Exit Sub
        ElseIf cmbProductFrom.SelectedIndex = -1 Or cmbProductTo.SelectedIndex = -1 Then
            MsgBox("Invalid Product selected !", MsgBoxStyle.Exclamation)
            cmbProductFrom.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim strFilter As String = ""
        Dim StyleFilter As String = ""
        Dim formula As New Hashtable

        Try
            If RtLst = RateList.AllCategory Or RtLst = RateList.CategoryWise Then
                If cmbClientCat.SelectedIndex > 0 Then
                    strFilter = "{RateCat.RateCat_Name} = " & Chr(34) & cmbClientCat.Text & Chr(34)
                End If
            End If

            If cmbCategoryFrom.SelectedIndex > 0 Then
                If cmbCategoryTo.SelectedIndex > 0 Then
                    strFilter &= " AND {FGCAT.ITEMSUBGRP_NAME} >= " & Chr(34) & cmbCategoryFrom.Text & Chr(34) & " AND {FGCAT.ITEMSUBGRP_NAME} <= " & Chr(34) & cmbCategoryTo.Text & Chr(34)
                Else
                    strFilter &= " AND {FGCAT.ITEMSUBGRP_NAME} >= " & Chr(34) & cmbCategoryFrom.Text & Chr(34)
                End If
            End If

            If cmbProductFrom.SelectedIndex > 0 Then
                If cmbProductTo.SelectedIndex > 0 Then
                    strFilter &= " AND {FGPRD.ITEM_NAME} >= " & Chr(34) & cmbProductFrom.Text & Chr(34) & " AND {FGPRD.ITEM_NAME} <= " & Chr(34) & cmbProductTo.Text & Chr(34)
                Else
                    strFilter &= " AND {FGPRD.ITEM_NAME} >= " & Chr(34) & cmbProductFrom.Text & Chr(34)
                End If
            End If


            If DisplayWithAllFilter() Then
                StyleFilter = ""

            ElseIf lvwStyle.CheckedItems.Count > 0 Then
                StyleFilter = GetSelectedStyle()

                If StyleFilter.Trim.Length > 0 Then
                    StyleFilter = " And (" & StyleFilter & ")"
                End If

            ElseIf cmbStyleFrom.SelectedIndex > 0 And cmbStyleTo.SelectedIndex > 0 And lvwStyle.CheckedItems.Count = 0 Then
                If cmbStyleFrom.SelectedIndex > 0 Then
                    If cmbStyleTo.SelectedIndex > 0 Then
                        strFilter &= " AND {FGSTYLE.STYLE_CODE} >= " & Chr(34) & cmbStyleFrom.Text & Chr(34) & " AND {FGSTYLE.STYLE_CODE} <= " & Chr(34) & cmbStyleTo.Text & Chr(34)
                    Else
                        strFilter &= " AND {FGSTYLE.STYLE_CODE} >= " & Chr(34) & cmbStyleFrom.Text & Chr(34)
                    End If
                End If
            End If


            'Dim strCompanyNm, strCompanyAddr, strCompanyTel, strCompanyEmail, strCompanyLogo As String

            If RtLst = RateList.StandardList Then
                ReportParameters.rptFile = ReportPath & "\Masters\PriceList.rpt"
            ElseIf RtLst = RateList.CategoryWise Then
                ReportParameters.rptFile = ReportPath & "\Masters\PriceListCat.rpt"
            ElseIf RtLst = RateList.AllCategory Then
                ReportParameters.rptFile = ReportPath & "\Masters\PriceListCatAll.rpt"
            End If

            If Mid$(strFilter, 1, 4).ToUpper = " AND" Then
                strFilter = Mid$(strFilter, 5)
            End If

            If lvwStyle.CheckedItems.Count = 0 Or lvwStyle.Items.Count = lvwStyle.CheckedItems.Count Then
                StyleFilter = ""
            Else
                StyleFilter = GetSelectedStyle()
                StyleFilter = IIf(strFilter.Trim.Length > 0, " And ", "") & " (" & StyleFilter & ")"
            End If

            ReportParameters.rptFilter = strFilter & IIf(StyleFilter <> "", StyleFilter, "")
            '.set_Formulas(0, "Company_Name = '" & strCompanyNm & "'")
            '.set_Formulas(1, "Company_Addr = '" & strCompanyAddr & "'")
            '.set_Formulas(2, "Company_Tel = '" & strCompanyTel & "'")
            '.set_Formulas(3, "Company_Email = '" & strCompanyEmail & "'")

            Dim PriceType As Byte

            If rdAll.Checked Then
                PriceType = 0
            ElseIf rdMRP.Checked Then
                PriceType = 1
            ElseIf rdWSP.Checked Then
                PriceType = 2
            ElseIf rdCP.Checked Then
                PriceType = 3
            ElseIf rdMRPWSP.Checked Then
                PriceType = 4
            End If

            formula.Add("Price_Type#N", PriceType)
            ReportParameters.rptCaption = Me.Text
            ReportParameters.ApplyCompanyFilter = True


            Dim frmrpt As New frmViewReports(formula)
            frmrpt.Show()

        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbProductFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductFrom.SelectionChangeCommitted
        If cmbProductFrom.SelectedIndex = -1 Then Exit Sub
        cmbProductTo.SelectedIndex = cmbProductFrom.SelectedIndex
        Call DisplayStyle()
    End Sub

    Private Sub mnuSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectAll.Click
        Dim lvwItem As ListViewItem
        For Each lvwItem In lvwStyle.Items
            lvwItem.Checked = True
        Next lvwItem
    End Sub

    Private Sub mnuUnSelectAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuUnSelectAll.Click
        Dim lvwItem As ListViewItem
        For Each lvwItem In lvwStyle.Items
            lvwItem.Checked = False
        Next lvwItem
    End Sub

    Private Sub mnuInvertSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInvertSelect.Click
        Dim lvwItem As ListViewItem
        For Each lvwItem In lvwStyle.Items
            lvwItem.Checked = Not lvwItem.Checked
        Next lvwItem
    End Sub

    Private Sub DisplayStyle()
        If cmbProductFrom.SelectedIndex = -1 Or cmbProductTo.SelectedIndex = -1 Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Filter As String = ""

            If cmbCategoryFrom.SelectedIndex > 0 Then
                If cmbCategoryTo.SelectedIndex > 0 Then
                    Filter = " And ItemSubGrp.ITEMSUBGRP_NAME >= '" & ReplaceApostrophe(cmbCategoryFrom.Text) & "' And ItemSubGrp.ITEMSUBGRP_NAME <= '" & ReplaceApostrophe(cmbCategoryTo.Text) & "'"
                Else
                    Filter = " And ItemSubGrp.ITEMSUBGRP_NAME >= '" & ReplaceApostrophe(cmbCategoryFrom.Text) & "'"
                End If
            End If

            If cmbProductFrom.SelectedIndex > 0 Then
                If cmbProductTo.SelectedIndex > 0 Then
                    Filter &= " And ITEM.ITEM_NAME >= '" & ReplaceApostrophe(cmbProductFrom.Text) & "' And ITEM.ITEM_NAME <= '" & ReplaceApostrophe(cmbProductTo.Text) & "'"
                Else
                    Filter &= " And ITEM.ITEM_NAME >= '" & ReplaceApostrophe(cmbProductFrom.Text) & "'"
                End If
            End If

            Query = "Select DISTINCT Style.STYLE_Key, Style.STYLE_CODE " _
                & " From Style Left Join Item On Style.Item_Key = Item.Item_Key " _
                & " Inner Join ItemSubGrp On Item.ItemSubGrp_Key = ItemSubGrp.ItemSubGrp_Key " _
                & " Where Style.Status = '1' And Style.Style_Code <> '' " & Filter _
                & " Order By Style.Style_Code"

            Dim dtStyleFrom As DataTable = Common.GetDataTableWithAll(Query)

            With cmbStyleFrom
                .DataSource = dtStyleFrom
                .DisplayMember = "STYLE_CODE"
                .ValueMember = "STYLE_Key"
            End With

            Dim dtStyleTo As DataTable = Common.GetDataTableWithAll(Query)

            With cmbStyleTo
                .DataSource = dtStyleTo
                .DisplayMember = "STYLE_CODE"
                .ValueMember = "STYLE_Key"
            End With

            cmbStyleFrom.SelectedIndex = 0 : cmbStyleTo.SelectedIndex = 0
            Call cmbStyleFrom_SelectionChangeCommitted(cmbStyleFrom, Nothing)

        Catch sqlEx As SqlException
            Call Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbProductTo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductTo.SelectionChangeCommitted
        If cmbProductTo.SelectedIndex = -1 Then Exit Sub
        Call DisplayStyle()
    End Sub

    Private Sub cmbProductFrom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductFrom.Validated
        If cmbProductFrom.SelectedIndex = -1 Then cmbProductFrom.SelectedIndex = 0
    End Sub

    Private Sub cmbProductTo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductTo.Validated
        If cmbProductTo.SelectedIndex = -1 Then cmbProductTo.SelectedIndex = 0
    End Sub

    Private Function GetSelectedStyle() As String
        Dim lvwItem As ListViewItem
        Dim strSelected As String = ""

        For Each lvwItem In lvwStyle.CheckedItems
            strSelected &= "{FGSTYLE.STYLE_CODE} = " & Chr(34) & lvwItem.Text & Chr(34) & " Or "
        Next lvwItem

        If strSelected.Trim.Length > 0 Then
            strSelected = Mid$(strSelected, 1, Len(strSelected) - 3)
        End If
        Return strSelected
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If lvwStyle.Items.Count = 0 Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim lvwItem As ListViewItem
            Dim intSrchIdx As Integer
            Dim blnFound As Boolean

            For Each lvwItem In lvwStyle.Items
                lvwItem.Selected = False
            Next lvwItem

            For Each lvwItem In lvwStyle.Items
                If lvwItem.Text.ToUpper Like "*" & txtSrchStyle.Text.ToUpper & "*" Then
                    lvwItem.Selected = True
                    lvwStyle.Focus()
                    blnFound = True
                    Exit Sub
                End If
            Next lvwItem

            If Not blnFound Then
                MsgBox("Search text not found !", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuChkSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChkSelected.Click
        Dim lvwItem As ListViewItem
        If lvwStyle.SelectedItems.Count > 1 Then
            For Each lvwItem In lvwStyle.SelectedItems
                lvwItem.Checked = True
            Next lvwItem
        End If
    End Sub

    Private Sub cmbStyleFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStyleFrom.SelectionChangeCommitted
        If cmbStyleFrom.SelectedIndex = -1 Then Exit Sub
        Call cmbStyleFrom_SelectedIndexChanged(cmbStyleFrom, Nothing)
        Call DisplayStyleInListBox()
    End Sub

    Private Sub DisplayStyleInListBox()
        If cmbProductFrom.SelectedIndex = -1 Or cmbProductTo.SelectedIndex = -1 Then Exit Sub
        If cmbStyleFrom.SelectedIndex = -1 Or cmbStyleTo.SelectedIndex = -1 Then Exit Sub

        Dim Filter As String = ""

        If cmbCategoryFrom.SelectedIndex > 0 Then
            If cmbCategoryTo.SelectedIndex > 0 Then
                Filter = " And ItemSubGrp.ITEMSUBGRP_NAME >= '" & ReplaceApostrophe(cmbCategoryFrom.Text) & "' And ItemSubGrp.ITEMSUBGRP_NAME <= '" & ReplaceApostrophe(cmbCategoryTo.Text) & "'"
            Else
                Filter = " And ItemSubGrp.ITEMSUBGRP_NAME >= '" & ReplaceApostrophe(cmbCategoryFrom.Text) & "'"
            End If
        End If

        If cmbProductFrom.SelectedIndex > 0 Then
            If cmbProductTo.SelectedIndex > 0 Then
                Filter &= " And ITEM.ITEM_NAME >= '" & ReplaceApostrophe(cmbProductFrom.Text) & "' And ITEM.ITEM_NAME <= '" & ReplaceApostrophe(cmbProductTo.Text) & "'"
            Else
                Filter &= " And ITEM.ITEM_NAME >= '" & ReplaceApostrophe(cmbProductFrom.Text) & "'"
            End If
        End If

        If cmbStyleFrom.SelectedIndex > 0 Then
            If cmbStyleTo.SelectedIndex > 0 Then
                Filter &= " And Style.STYLE_CODE >= '" & ReplaceApostrophe(cmbStyleFrom.Text) & "' And Style.STYLE_CODE <= '" & ReplaceApostrophe(cmbStyleTo.Text) & "'"
            Else
                Filter &= " And Style.STYLE_CODE >= '" & ReplaceApostrophe(cmbStyleFrom.Text) & "'"
            End If
        End If


        Try
            Me.Cursor = Cursors.WaitCursor

            Query = "Select DISTINCT Style.STYLE_Key, Style.STYLE_CODE " _
                & " From Style Left Join Item On Style.Item_Key = Item.Item_Key " _
                & " Inner Join ItemSubGrp On Item.ItemSubGrp_Key = ItemSubGrp.ItemSubGrp_Key " _
                & " Where Style.Status = '1' And Style.Style_Code <> '' " & Filter _
                & " Order By Style.Style_Code"
            Dim StyleData As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow

            lvwStyle.Items.Clear() : lvwStyle.Columns.Clear()
            lvwStyle.Columns.Add("Style", 200, HorizontalAlignment.Left)

            For Each RecRow In StyleData.Rows
                lvwStyle.Items.Add(RecRow("STYLE_CODE") & "")
            Next RecRow

        Catch sqlEx As SqlException
            Call Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbStyleFrom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStyleFrom.SelectedIndexChanged
        If cmbStyleFrom.SelectedIndex = -1 Then Exit Sub
        If cmbStyleTo.Items.Count <= 0 Then Exit Sub

        cmbStyleTo.SelectedIndex = cmbStyleFrom.SelectedIndex
    End Sub

    Private Sub cmbStyleTo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStyleTo.SelectionChangeCommitted
        If cmbStyleTo.SelectedIndex = -1 Then Exit Sub
        Call DisplayStyleInListBox()
    End Sub

    Private Function DisplayWithAllFilter() As Boolean
        Dim AllSelected As Boolean = (cmbCategoryFrom.SelectedIndex = 0 And cmbProductFrom.SelectedIndex = 0 And cmbStyleFrom.SelectedIndex = 0)

        Return AllSelected And (lvwStyle.CheckedItems.Count = 0 Or lvwStyle.CheckedItems.Count = lvwStyle.Items.Count)
    End Function

    Private Sub cmbStyleFrom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStyleFrom.Validated
        If cmbStyleFrom.SelectedIndex = -1 Then cmbStyleFrom.SelectedIndex = 0
    End Sub

    Private Sub cmbStyleTo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStyleTo.Validated
        If cmbStyleTo.SelectedIndex = -1 Then cmbStyleTo.SelectedIndex = 0
    End Sub

End Class