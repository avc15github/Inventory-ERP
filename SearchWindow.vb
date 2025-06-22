Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class SearchWindow

    Dim arrDisplay As ArrayList
    Dim DisplayColumns As String
    Dim WhereCondn As String = ""
    Dim OrderBy As String = ""
    Dim SearchCol As String = ""
    Dim Query As String = ""
    Dim SrchTable As String = ""
    Dim ConnectionString As String = ""
    Dim FindRec As String = ""
    Dim UnqId As String = ""
    Dim HeaderText As String = ""
    Dim DispClose As Boolean
    Dim arrColFullName() As String
    Dim FirstTime, Loading As Boolean
    Dim IdAsInteger As Boolean
    Dim EventRaised As Boolean
    Dim objForm As Object
    Dim SearchRecords As Boolean = True
    Dim SearchCaption As String = ""
    Public Shared blnSearchClicked As Boolean = False

    Enum enmColumnPos
        ColName
        ColCaption
        ColWidth
        ColFullName
        SearchableColumn
        colFormatType
    End Enum


    Event CurrentRecordId(ByRef CurrId As String)
    Event CurrentRecordValue(ByRef CurrId As Integer)
    Event SearchAndClose(ByRef CurrId As String)


    Public WriteOnly Property DisplayArrayList() As ArrayList
        Set(ByVal Value As ArrayList)
            arrDisplay = Value

            Dim arrSplit() As String
            Dim i As Short
            DisplayColumns = ""

            ReDim arrColFullName(0)
            For i = 0 To arrDisplay.Count - 1
                arrSplit = Split(arrDisplay.Item(i).ToString, " - ")
                DisplayColumns &= arrSplit(0) & ","

                ReDim Preserve arrColFullName(UBound(arrColFullName) + 1)
                If arrSplit(3) <> "" Then
                    arrColFullName(UBound(arrColFullName) - 1) = arrSplit(3)
                Else
                    arrColFullName(UBound(arrColFullName) - 1) = arrSplit(0)
                End If
            Next i
            DisplayColumns = DisplayColumns.Substring(0, DisplayColumns.Length - 1)
        End Set
    End Property

    Public WriteOnly Property Where() As String
        Set(ByVal value As String)
            WhereCondn = value
        End Set
    End Property

    Public WriteOnly Property Order() As String
        Set(ByVal value As String)
            OrderBy = value
        End Set
    End Property

    Public WriteOnly Property Table() As String
        Set(ByVal value As String)
            SrchTable = value
        End Set
    End Property

    Public WriteOnly Property Connect() As String
        Set(ByVal value As String)
            ConnectionString = value
        End Set
    End Property

    Public WriteOnly Property CurrentRecord() As String
        Set(ByVal value As String)
            FindRec = value
        End Set
    End Property

    Public WriteOnly Property UniqueId() As String
        Set(ByVal value As String)
            UnqId = value
        End Set
    End Property

    Public WriteOnly Property Caption() As String
        Set(ByVal value As String)
            HeaderText = value
        End Set
    End Property

    Public WriteOnly Property ViewCloseButton() As Boolean
        Set(ByVal value As Boolean)
            DispClose = value
        End Set
    End Property

    Public WriteOnly Property IntegerId() As Boolean
        Set(ByVal value As Boolean)
            IdAsInteger = value
        End Set
    End Property

    Public WriteOnly Property FormLoading() As Boolean
        Set(ByVal value As Boolean)
            Loading = value
        End Set
    End Property

    Public WriteOnly Property MyForm() As Object
        Set(ByVal value As Object)
            objForm = value
        End Set
    End Property

    Public Property DisplaySearchRecords() As Boolean
        Get
            Return SearchRecords
        End Get
        Set(ByVal value As Boolean)
            SearchRecords = value
        End Set
    End Property

    Public WriteOnly Property HeaderCaption() As String
        Set(ByVal value As String)
            SearchCaption = value
        End Set
    End Property

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Visible = False
        objForm.CloseSearch()
    End Sub

    'Public Property SearchClicked() As Boolean
    '    Get
    '        Return blnSearchClicked
    '    End Get
    '    Set(ByVal Value As Boolean)
    '        blnSearchClicked = Value
    '    End Set
    'End Property

    Private Sub DisplayGridHeaders(ByVal dtTable As DataTable)
        Dim colDisplayColumns As DataGridViewTextBoxColumn
        Dim i As Short
        Dim arrSplit() As String

        dgvSearch.Columns.Clear()
        With dgvSearch
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .RowHeadersWidth = 21
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .VirtualMode = True
            .AllowUserToResizeColumns = True
            .AutoGenerateColumns = False
            .DataSource = dtTable
            .ReadOnly = True

            'columnHeaderStyle.Font = New Font("Calibri", 9, FontStyle.Bold, GraphicsUnit.Point)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 9, FontStyle.Bold, GraphicsUnit.Point)
            '.ColumnHeadersDefaultCellStyle.ForeColor = Color.Brown
            .DefaultCellStyle.Font = New Font("Calibri", 9, FontStyle.Regular, GraphicsUnit.Point)
            .DefaultCellStyle.ForeColor = Color.Navy
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        End With

        For i = 0 To arrDisplay.Count - 1
            arrSplit = Split(arrDisplay.Item(i).ToString, " - ")

            colDisplayColumns = New DataGridViewTextBoxColumn
            With colDisplayColumns
                .DataPropertyName = CType(dgvSearch.DataSource, DataTable).Columns(i).ColumnName
                .Name = CType(dgvSearch.DataSource, DataTable).Columns(i).ColumnName
                If i = arrDisplay.Count - 1 Then
                    If arrSplit(enmColumnPos.ColWidth) = 0 Then
                        .HeaderText = ""
                        .Width = 0
                        .Visible = False
                    Else
                        .HeaderText = arrSplit(enmColumnPos.ColCaption)
                        .Width = arrSplit(enmColumnPos.ColWidth)
                    End If
                Else
                    .HeaderText = arrSplit(enmColumnPos.ColCaption)
                    .Width = arrSplit(enmColumnPos.ColWidth)
                End If

                Dim colType As System.Type = CType(dgvSearch.DataSource, DataTable).Columns(i).DataType
                If colType.FullName = "System.String" Then
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                ElseIf colType.FullName = "System.Int16" Or colType.FullName = "System.Int32" Or colType.FullName = "System.Int64" Then
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf colType.FullName = "System.Decimal" Then
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    If arrSplit(enmColumnPos.colFormatType) = "0" Then
                        .DefaultCellStyle.Format = "0.000"
                    Else
                        .DefaultCellStyle.Format = "N2"
                    End If

                ElseIf colType.FullName = "System.DateTime" Then
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .DefaultCellStyle.Format = "dd/MM/yyyy"
                    End If
            End With

            dgvSearch.Columns.Add(colDisplayColumns)
            'colDisplayColumns = Nothing
        Next i
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim Filter As String = ""

        If SearchCol.Trim.Length > 0 Then
            If pnlDateSel.Visible Then
                If dtpFrom.Value > dtpTo.Value Then
                    MsgBox("From date cannot be greater than To date !", MsgBoxStyle.Exclamation)
                    dtpFrom.Focus()
                    Exit Sub
                End If
            End If
            If pnlDateSel.Visible = True Then
                Filter &= SearchCol & " >= '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' AND " & SearchCol & " <= '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
            Else
                If rdSrchStart.Checked Then
                    Filter = SearchCol & " Like '" & txtSrchtext.Text & "%'"
                Else
                    Filter = SearchCol & " Like '%" & txtSrchtext.Text & "%'"
                End If
            End If
            Query = "SELECT  " & DisplayColumns & " FROM " & SrchTable _
                & " Where " & Filter & " And " & WhereCondn _
                & OrderBy
        Else
            Query = "SELECT  " & DisplayColumns & " FROM " & SrchTable _
                & " Where " & WhereCondn & OrderBy
        End If

            Console.WriteLine(Query)

            Dim dbAdapt As New SqlDataAdapter(Query, ConnectionString)
            Dim SearchData As New DataTable
            dbAdapt.Fill(SearchData)

            Call DisplayGridHeaders(SearchData)

            If FirstTime Or Loading Then
                'If dgvSearch.Columns.Count = 1 Then
                '    SearchCol = GetFieldName(0, dgvSearch.Columns(0).Name)
                '    lblSearchColumn.Text = dgvSearch.Columns(0).HeaderText
                '    FirstTime = False
                'Else
                SearchCol = GetFieldName(0, dgvSearch.Columns(0).Name)
                lblSearchColumn.Text = dgvSearch.Columns(0).HeaderText
                FirstTime = False
                Loading = False
                'End If
            End If
            lblRecordsFound.Text = SearchData.Rows.Count & " record(s) found"

            If FindRec <> "" Then
                Dim bs As New BindingSource
            bs.DataSource = dgvSearch.DataSource
            If UnqId.Contains(".") Then
                UnqId = Mid(UnqId, InStr(UnqId, ".", CompareMethod.Text) + 1, Len(UnqId))
            End If

            Dim recPos As Integer = bs.Find(UnqId, FindRec)

            If recPos >= 0 Then
                dgvSearch.CurrentCell = dgvSearch.Item(0, recPos)
            End If
        End If

        'Dim i As Short
        'Dim Data As DataTable = CType(dgvSearch.DataSource, DataTable)

        'For i = 0 To dgvSearch.RowCount - 1
        '    If i = 2 Then
        '        dgvSearch.Rows(i).DefaultCellStyle.BackColor = Color.Red

        '    ElseIf i = 5 Then
        '        dgvSearch.Rows(i).DefaultCellStyle.BackColor = Color.RoyalBlue

        '    ElseIf i = 8 Then
        '        dgvSearch.Rows(i).DefaultCellStyle.BackColor = Color.SaddleBrown
        '    End If
        'Next i

        EventRaised = True
        dgvSearch_CellClick(dgvSearch, Nothing)

        If SearchCaption.Trim.Length = 0 Then
            grpMain.Text = HeaderText
        Else
            grpMain.Text = SearchCaption
        End If
    End Sub

    Private Sub dgvSearch_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        'MsgBox("cellclick")

        If EventRaised Then
            If dgvSearch.RowCount > 0 Then
                If IdAsInteger Then
                    RaiseEvent CurrentRecordValue(Val(dgvSearch.Item(dgvSearch.Columns.Count - 1, dgvSearch.CurrentRow.Index).Value))
                Else
                    RaiseEvent CurrentRecordId(dgvSearch.Item(dgvSearch.Columns.Count - 1, dgvSearch.CurrentRow.Index).Value)
                End If
            End If
        End If
    End Sub

    Private Sub dgvSearch_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvSearch.ColumnHeaderMouseClick
        'Dim arrSplit() As String
        'arrSplit = Split(arrDisplay.Item(e.ColumnIndex).ToString, " - ")

        'If CBool(arrSplit(enmColumnPos.SearchableColumn)) Then
        '    SearchCol = GetFieldName(e.ColumnIndex, dgvSearch.Columns(e.ColumnIndex).Name)
        '    lblSearchColumn.Text = dgvSearch.Columns(e.ColumnIndex).HeaderText
        'End If

        Dim arrSplit() As String
        arrSplit = Split(arrDisplay.Item(e.ColumnIndex).ToString, " - ")

        If CBool(arrSplit(enmColumnPos.SearchableColumn)) Then
            SearchCol = GetFieldName(e.ColumnIndex, dgvSearch.Columns(e.ColumnIndex).Name)
            lblSearchColumn.Text = dgvSearch.Columns(e.ColumnIndex).HeaderText
            If dgvSearch.Columns(dgvSearch.Columns(e.ColumnIndex).Name).ValueType Is System.Type.GetType("System.DateTime") Then
                pnlDateSel.Visible = True
                txtSrchtext.Text = ""
                txtSrchtext.Visible = False
            Else
                pnlDateSel.Visible = False
                txtSrchtext.Visible = True
            End If

        End If
    End Sub

    Public Sub LoadSearch()
        pnlDateSel.Visible = False
        txtSrchtext.Visible = True

        txtSrchtext.Clear()
        If SearchRecords Then
            btnSearch_Click(btnSearch, Nothing)
        End If
        btnClose.Visible = DispClose
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        If dgvSearch.Columns.Count = 0 Then Exit Sub

        Dim i As Integer
        Dim j As Byte

        Dim r As Integer = 4
        Dim c As Byte = 1
        Dim cols As Byte
        Dim txtFormat As New ArrayList
        Dim colFormat As New ArrayList

        Dim xlApp As New Excel.Application
        Dim xlBook As Excel.Workbook = xlApp.Workbooks.Add
        Dim xlSheet As Excel.Worksheet = xlBook.ActiveSheet

        xlSheet.Cells(1, 1) = HeaderText

        For j = 0 To dgvSearch.Columns.Count - 1
            If dgvSearch.Columns(j).Width > 5 Then
                xlSheet.Cells(3, c) = dgvSearch.Columns(j).HeaderText
                c += 1 : cols += 1
            End If

            If dgvSearch.Columns(j).ValueType.FullName.ToUpper = "SYSTEM.DECIMAL" Then
                colFormat.Add(Chr(65 + j))
            ElseIf dgvSearch.Columns(j).ValueType.FullName.ToUpper = "SYSTEM.STRING" Then
                txtFormat.Add(Chr(65 + j))
            End If
        Next j

        c = 1
        For i = 0 To dgvSearch.Rows.Count - 1
            For j = 0 To dgvSearch.Columns.Count - 1
                If dgvSearch.Columns(j).Width > 5 Then
                    xlSheet.Cells(r, c) = dgvSearch.Item(j, i).Value
                    c += 1
                End If
            Next j

            r += 1 : c = 1
        Next i


        xlSheet.Range("A1:" & Chr(64 + cols) & "1").MergeCells = True
        With xlSheet.Range("A1:" & Chr(64 + cols) & "1")
            .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            .Font.Bold = True
            .Font.Size = 14
        End With
        xlSheet.Range("A3:" & Chr(64 + cols) & "3").Columns.Font.Bold = True

        For Each obj As Object In colFormat
            xlSheet.Range(obj & ":" & obj).NumberFormat = "0.00"
        Next obj

        For Each obj As Object In txtFormat
            xlSheet.Range(obj & ":" & obj).NumberFormat = "@"
        Next obj

        xlSheet.Columns.AutoFit()

        xlApp.Visible = True
        xlSheet = Nothing : xlBook = Nothing : xlApp = Nothing
    End Sub

    Private Sub txtSrchtext_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSrchtext.KeyDown
        If e.KeyCode = Keys.Return Then
            btnSearch_Click(btnSearch, Nothing)
        End If
    End Sub

    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        If dgvSearch.RowCount > 0 Then
            blnSearchClicked = True
            RaiseEvent SearchAndClose(dgvSearch.Item(dgvSearch.Columns.Count - 1, dgvSearch.CurrentRow.Index).Value)
        End If
    End Sub

    Private Function GetFieldName(ByVal Idx As Byte, ByVal ColFullName As String) As String
        If arrColFullName(Idx) <> "" Then
            Return arrColFullName(Idx)
        Else
            Return ColFullName
        End If
    End Function

    Private Sub SearchWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Loading Then FirstTime = True
    End Sub

    Private Sub dgvSearch_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.Sorted

    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Open the print dialog
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDoc
        printDialog.UseEXDialog = True
        'Get the document
        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDoc.DocumentName = grpMain.Text
            PrintDoc.Print()
        End If
        'Note: In case you want to show the Print Preview Dialog instead of 
        'Print Dialog then comment the above code and uncomment the following code

        'Open the print preview dialog
        'PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
        'objPPdialog.Document = printDocument1;
        'objPPdialog.ShowDialog()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDoc.BeginPrint
        Try
            Dim strFormat As New StringFormat()
            strFormat.Alignment = StringAlignment.Near
            strFormat.LineAlignment = StringAlignment.Center
            strFormat.Trimming = StringTrimming.EllipsisCharacter

            Dim arrColumnLefts As New ArrayList
            Dim arrColumnWidths As New ArrayList
            Dim iCellHeight As Integer
            Dim iCount As Integer
            Dim bFirstPage As Boolean
            Dim bNewPage As Boolean
            Dim iTotalWidth As Double

            arrColumnLefts.Clear()
            arrColumnWidths.Clear()
            iCellHeight = 0
            iCount = 0
            bFirstPage = True
            bNewPage = True

            ' Calculating Total Widths
            iTotalWidth = 0
            For Each dgvGridCol As DataGridViewColumn In dgvSearch.Columns
                iTotalWidth += dgvGridCol.Width
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        Try
            'Set the left margin
            Dim iLeftMargin As Integer = e.MarginBounds.Left
            'Set the top margin
            Dim iTopMargin As Integer = e.MarginBounds.Top
            'Whether more pages have to print or not
            Dim bMorePagesToPrint As Boolean = False
            Dim iTmpWidth As Integer = 0
            Dim bFirstPage As Boolean
            Dim iHeaderHeight As Integer
            Dim arrColumnLefts As New ArrayList
            Dim arrColumnWidths As New ArrayList
            Dim iRow As Integer
            Dim iTotalWidth As Integer
            Dim iCellHeight As Integer
            Dim bNewPage As Boolean
            Dim strFormat As StringFormat = Nothing

            'For the first page to print set the cell width and header height
            If bFirstPage Then
                For Each GridCol As DataGridViewColumn In dgvSearch.Columns
                    iTmpWidth = CInt(Math.Floor(CDbl(CDbl(GridCol.Width) / CDbl(iTotalWidth) * CDbl(iTotalWidth) * (CDbl(e.MarginBounds.Width) / CDbl(iTotalWidth)))))

                    iHeaderHeight = CInt(e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11

                    ' Save width and height of headers
                    arrColumnLefts.Add(iLeftMargin)
                    arrColumnWidths.Add(iTmpWidth)
                    iLeftMargin += iTmpWidth
                Next
            End If
            'Loop till all the grid rows not get printed
            While iRow <= dgvSearch.Rows.Count - 1
                Dim GridRow As DataGridViewRow = dgvSearch.Rows(iRow)
                'Set the cell height
                iCellHeight = GridRow.Height + 5
                Dim iCount As Integer = 0
                'Check whether the current page settings allows more rows to print
                If iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                    bNewPage = True
                    bFirstPage = False
                    bMorePagesToPrint = True
                    Exit While
                Else
                    If bNewPage Then
                        'Draw Header
                        e.Graphics.DrawString("Customer Summary", New Font(dgvSearch.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary", New Font(dgvSearch.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        Dim strDate As [String] = DateTime.Now.ToLongDateString() & " " & DateTime.Now.ToShortTimeString()
                        'Draw Date
                        e.Graphics.DrawString(strDate, New Font(dgvSearch.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(strDate, New Font(dgvSearch.Font, FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary", New Font(New Font(dgvSearch.Font, FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        'Draw Columns                 
                        iTopMargin = e.MarginBounds.Top
                        For Each GridCol As DataGridViewColumn In dgvSearch.Columns
                            e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight))

                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight))

                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font, New SolidBrush(GridCol.InheritedStyle.ForeColor), New RectangleF(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight), strFormat)
                            iCount += 1
                        Next
                        bNewPage = False
                        iTopMargin += iHeaderHeight
                    End If
                    iCount = 0
                    'Draw Columns Contents                
                    For Each Cel As DataGridViewCell In GridRow.Cells
                        If Cel.Value IsNot Nothing Then
                            e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font, New SolidBrush(Cel.InheritedStyle.ForeColor), New RectangleF(CInt(arrColumnLefts(iCount)), CSng(iTopMargin), CInt(arrColumnWidths(iCount)), CSng(iCellHeight)), strFormat)
                        End If
                        'Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iCellHeight))
                        iCount += 1
                    Next
                End If
                iRow += 1
                iTopMargin += iCellHeight
            End While

            'If more lines exist, print another page.
            If bMorePagesToPrint Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If


        Catch exc As Exception
            MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class



Class DisplayColumns
    Dim strColumnName As String
    Dim strColumnCaption As String
    Dim dblColumnWidth As Double
    Dim SearchableCol As Boolean


    Public Sub New(ByVal strName As String, ByVal strCaption As String, ByVal dblWidth As Double, ByVal Search As Boolean)
        MyBase.new()
        ColumnName = strName
        ColumnCaption = strCaption
        ColumnWidth = dblWidth
        SearchableCol = CInt(Search)
    End Sub

    Public WriteOnly Property ColumnName() As String
        Set(ByVal Value As String)
            strColumnName = Value
        End Set
    End Property

    Public WriteOnly Property ColumnCaption() As String
        Set(ByVal Value As String)
            strColumnCaption = Value
        End Set
    End Property

    Public WriteOnly Property ColumnWidth() As Double
        Set(ByVal Value As Double)
            dblColumnWidth = Value
        End Set
    End Property

    Public WriteOnly Property SearchableColumn() As Boolean
        Set(ByVal Value As Boolean)
            SearchableCol = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return strColumnName & " - " & strColumnCaption & " - " & dblColumnWidth & " - " & SearchableCol
    End Function
End Class