Public Class Bookcatalog
    Dim AuthorLast As String
    Dim PubDate As String
    Dim Series As String
    Dim ISBN As String
    Dim RowData As Object
    Dim CallNumber As String
    Dim Title As String
    Dim CheckoutPeriod As Long
    Dim NumberOfRows As Integer
    Dim CheckedOutRecord As Integer
    Dim checkedoutbooks As Integer
    Dim checkedoutbookinfo As Object
    Dim resourceid As String
    Dim Resourcestatus As String
    Dim DueDate As Date
    Dim checkoutdate As Date
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvbookcatalog.CellContentClick

    End Sub

    Private Sub LibraryResourcesBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bookcatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.CheckedOut' table. You can move, or remove it, as needed.
        Me.CheckedOutTableAdapter.Fill(Me.LibraryDataSet.CheckedOut)
        'TODO: This line of code loads data into the 'LibraryDataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.LibraryDataSet.LibraryResources)
        'TODO: This line of code loads data into the 'LibraryDataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.LibraryDataSet.LibraryResources)
        'TODO: This line of code loads data into the 'LibraryDataSet.CheckedOut' table. You can move, or remove it, as needed.
        Me.CheckedOutTableAdapter.Fill(Me.LibraryDataSet.CheckedOut)
        'TODO: This line of code loads data into the 'LibraryDataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.LibraryDataSet.LibraryResources)

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        Title = "%" & TxtTitle.Text & "%"
        'splitname = Split(txtAuthor.Text, ",")
        AuthorLast = "%" & txtAuthor.Text & "%"
        Series = "%" & txtSeries.Text & "%"
        'ISBN = "%" & txtISBN.Text & "%"

        If TxtTitle.Text = "" And txtAuthor.Text = "" And txtSeries.Text = "" And txtISBN.Text = "" Then
            MessageBox.Show("Please enter search criteria.")
        End If

        If TxtTitle.Text <> "" And txtAuthor.Text = "" And txtSeries.Text = "" And txtISBN.Text = "" Then
            NumberOfRows = LibraryResourcesTableAdapter.FillByTitle(LibraryDataSet.LibraryResources, Title)
            Dgvbookcatalog.Rows.Clear()

            If NumberOfRows > 0 Then
                Dim x As Integer = 0
                For x = 0 To NumberOfRows - 1 Step 1

                    RowData = LibraryResourcesTableAdapter.GetDataByTitle(Title)(x)
                    resourceid = RowData.resourceID
                    CheckoutPeriod = RowData.checkoutperiod
                    checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If checkedoutbooks = 1 Then
                        checkedoutbookinfo = CheckedOutTableAdapter.GetDataByResourceID(resourceid)(0)
                        checkoutdate = checkedoutbookinfo.checkoutdate
                        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
                        Resourcestatus = "Not Available"
                    Else
                        Resourcestatus = "Available"

                    End If
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.resourceID
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.title
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Resourcestatus
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorlast
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.publication
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.Series
                    dgvRow.Cells.Add(dgvCell)

                    'dgvCell = New DataGridViewTextBoxCell()
                    'dgvCell.Value = RowData.CallNumber
                    'dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.CheckOutPeriod
                    dgvRow.Cells.Add(dgvCell)

                    Dgvbookcatalog.Rows.Add(dgvRow)

                Next
            ElseIf NumberOfRows = 0 Then
                MessageBox.Show("No results found.")

            End If
        End If

        If txtAuthor.Text <> "" And TxtTitle.Text = "" And txtSeries.Text = "" Then
            NumberOfRows = LibraryResourcesTableAdapter.FillByAuthorLast(LibraryDataSet.LibraryResources, AuthorLast)
            dgvBookCatalog.Rows.Clear()

            If NumberOfRows > 0 Then
                Dim x As Integer = 0
                For x = 0 To NumberOfRows - 1 Step 1

                    RowData = LibraryResourcesTableAdapter.GetDataByAuthorLast(AuthorLast)(x)
                    resourceid = RowData.resourceID
                    CheckoutPeriod = RowData.checkoutperiod
                    checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If checkedoutbooks = 1 Then
                        checkedoutbookinfo = CheckedOutTableAdapter.GetDataByResourceID(resourceid)(0)
                        checkoutdate = checkedoutbookinfo.checkoutdate
                        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
                        Resourcestatus = "Not Available"
                    Else
                        Resourcestatus = "Available"

                    End If
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.resourceID
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.title
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Resourcestatus
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorlast
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.publication
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.Series
                    dgvRow.Cells.Add(dgvCell)

                    'dgvCell = New DataGridViewTextBoxCell()
                    'dgvCell.Value = RowData.CallNumber
                    'dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.CheckOutPeriod
                    dgvRow.Cells.Add(dgvCell)

                    dgvBookCatalog.Rows.Add(dgvRow)

                Next
            ElseIf NumberOfRows = 0 Then
                MessageBox.Show("No results found.")

            End If
        End If

        If txtSeries.Text <> "" And TxtTitle.Text = "" And txtAuthor.Text = "" Then
            NumberOfRows = LibraryResourcesTableAdapter.FillBySeries(LibraryDataSet.LibraryResources, Series)
            dgvBookCatalog.Rows.Clear()

            If NumberOfRows > 0 Then
                Dim x As Integer = 0
                For x = 0 To NumberOfRows - 1 Step 1

                    RowData = LibraryResourcesTableAdapter.GetDataBySeries(Series)(x)
                    resourceid = RowData.resourceID
                    CheckoutPeriod = RowData.checkoutperiod
                    checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If checkedoutbooks = 1 Then
                        checkedoutbookinfo = CheckedOutTableAdapter.GetDataByResourceID(resourceid)(0)
                        checkoutdate = checkedoutbookinfo.checkoutdate
                        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
                        Resourcestatus = "Not Available"
                    Else
                        Resourcestatus = "Available"

                    End If
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.resourceID
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.title
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Resourcestatus
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorlast
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.publication
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.Series
                    dgvRow.Cells.Add(dgvCell)

                    'dgvCell = New DataGridViewTextBoxCell()
                    'dgvCell.Value = RowData.CallNumber
                    'dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.CheckOutPeriod
                    dgvRow.Cells.Add(dgvCell)

                    dgvBookCatalog.Rows.Add(dgvRow)

                Next
            ElseIf NumberOfRows = 0 Then
                MessageBox.Show("No results found.")

            End If
        End If

        If TxtTitle.Text <> "" And txtAuthor.Text <> "" And txtSeries.Text = "" Then
            NumberOfRows = LibraryResourcesTableAdapter.FillByTitleLast(LibraryDataSet.LibraryResources, Title, AuthorLast)
            dgvBookCatalog.Rows.Clear()

            If NumberOfRows > 0 Then
                Dim x As Integer = 0
                For x = 0 To NumberOfRows - 1 Step 1

                    RowData = LibraryResourcesTableAdapter.GetDataByTitleLast(Title, AuthorLast)(x)
                    resourceid = RowData.resourceID
                    CheckoutPeriod = RowData.checkoutperiod
                    checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If checkedoutbooks = 1 Then
                        checkedoutbookinfo = CheckedOutTableAdapter.GetDataByResourceID(resourceid)(0)
                        checkoutdate = checkedoutbookinfo.checkoutdate
                        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
                        Resourcestatus = "Not Available"
                    Else
                        Resourcestatus = "Available"

                    End If
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.resourceID
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.title
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Resourcestatus
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorlast
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.publication
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.Series
                    dgvRow.Cells.Add(dgvCell)

                    'dgvCell = New DataGridViewTextBoxCell()
                    'dgvCell.Value = RowData.CallNumber
                    'dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.CheckOutPeriod
                    dgvRow.Cells.Add(dgvCell)

                    dgvBookCatalog.Rows.Add(dgvRow)

                Next
            ElseIf NumberOfRows = 0 Then
                MessageBox.Show("No results found.")

            End If
        End If

        If TxtTitle.Text <> "" And txtSeries.Text <> "" And txtAuthor.Text = "" Then
            NumberOfRows = LibraryResourcesTableAdapter.FillByTitleSeries(LibraryDataSet.LibraryResources, Title, Series)
            dgvBookCatalog.Rows.Clear()

            If NumberOfRows > 0 Then
                Dim x As Integer = 0
                For x = 0 To NumberOfRows - 1 Step 1

                    RowData = LibraryResourcesTableAdapter.GetDataByTitlesSeries(Title, Series)(x)
                    resourceid = RowData.resourceID
                    CheckoutPeriod = RowData.checkoutperiod
                    checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If checkedoutbooks = 1 Then
                        checkedoutbookinfo = CheckedOutTableAdapter.GetDataByResourceID(resourceid)(0)
                        checkoutdate = checkedoutbookinfo.checkoutdate
                        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
                        Resourcestatus = "Not Available"
                    Else
                        Resourcestatus = "Available"

                    End If
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.resourceID
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.title
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Resourcestatus
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorlast
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.publication
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.Series
                    dgvRow.Cells.Add(dgvCell)

                    'dgvCell = New DataGridViewTextBoxCell()
                    'dgvCell.Value = RowData.CallNumber
                    'dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.CheckOutPeriod
                    dgvRow.Cells.Add(dgvCell)

                    dgvBookCatalog.Rows.Add(dgvRow)

                Next
            ElseIf NumberOfRows = 0 Then
                MessageBox.Show("No results found.")

            End If
        End If

        If txtAuthor.Text <> "" And txtSeries.Text <> "" And TxtTitle.Text = "" Then
            NumberOfRows = LibraryResourcesTableAdapter.FillByLastSeries(LibraryDataSet.LibraryResources, AuthorLast, Series)
            dgvBookCatalog.Rows.Clear()

            If NumberOfRows > 0 Then
                Dim x As Integer = 0
                For x = 0 To NumberOfRows - 1 Step 1

                    RowData = LibraryResourcesTableAdapter.GetDataByLastSeries(AuthorLast, Series)(x)
                    resourceid = RowData.resourceID
                    CheckoutPeriod = RowData.checkoutperiod
                    checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If checkedoutbooks = 1 Then
                        checkedoutbookinfo = CheckedOutTableAdapter.GetDataByResourceID(resourceid)(0)
                        checkoutdate = checkedoutbookinfo.checkoutdate
                        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
                        Resourcestatus = "Not Available"
                    Else
                        Resourcestatus = "Available"

                    End If
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.resourceID
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.title
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Resourcestatus
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorlast
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.publication
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.Series
                    dgvRow.Cells.Add(dgvCell)

                    'dgvCell = New DataGridViewTextBoxCell()
                    'dgvCell.Value = RowData.CallNumber
                    'dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.CheckOutPeriod
                    dgvRow.Cells.Add(dgvCell)

                    dgvBookCatalog.Rows.Add(dgvRow)

                Next
            ElseIf NumberOfRows = 0 Then
                MessageBox.Show("No results found.")

            End If
        End If

        If TxtTitle.Text <> "" And txtAuthor.Text <> "" And txtSeries.Text <> "" Then
            NumberOfRows = LibraryResourcesTableAdapter.FillByTitleAuthorLastSeriesISBN(LibraryDataSet.LibraryResources, Title, AuthorLast, Series, ISBN)
            dgvBookCatalog.Rows.Clear()

            If NumberOfRows > 0 Then
                Dim x As Integer = 0
                For x = 0 To NumberOfRows - 1 Step 1

                    RowData = LibraryResourcesTableAdapter.GetDataByTitleAuthorLastSeriesISBN(Title, AuthorLast, Series, ISBN)(x)
                    resourceid = RowData.resourceID
                    CheckoutPeriod = RowData.checkoutperiod
                    checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If checkedoutbooks = 1 Then
                        checkedoutbookinfo = CheckedOutTableAdapter.GetDataByResourceID(resourceid)(0)
                        checkoutdate = checkedoutbookinfo.checkoutdate
                        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
                        Resourcestatus = "Not Available"
                    Else
                        Resourcestatus = "Available"

                    End If
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.resourceID
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.title
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Resourcestatus
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorlast
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.publication
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.Series
                    dgvRow.Cells.Add(dgvCell)

                    'dgvCell = New DataGridViewTextBoxCell()
                    'dgvCell.Value = RowData.CallNumber
                    'dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.CheckOutPeriod
                    dgvRow.Cells.Add(dgvCell)

                    Dgvbookcatalog.Rows.Add(dgvRow)

                Next
            ElseIf NumberOfRows = 0 Then
                MessageBox.Show("No results found.")

            End If
        End If
        TxtTitle.Text = ""
        txtAuthor.Text = ""
        txtSeries.Text = ""
        txtISBN.Text = ""
    End Sub

    Private Sub btnShowall_Click(sender As Object, e As EventArgs) Handles btnShowall.Click
        txtAuthor.Clear()
        TxtTitle.Clear()
        txtISBN.Clear()
        txtSeries.Clear()


        Title = "%" & TxtTitle.Text & "%"
        'splitname = Split(txtAuthor.Text, ",")
        AuthorLast = "%" & txtAuthor.Text & "%"
        Series = "%" & txtSeries.Text & "%"
        'ISBN = "%" & txtISBN.Text & "%"


        If TxtTitle.Text = "" And txtAuthor.Text = "" And txtSeries.Text = "" Then
            NumberOfRows = LibraryResourcesTableAdapter.FillByTitleAuthorLastSeriesISBN(LibraryDataSet.LibraryResources, Title, AuthorLast, Series, ISBN)
            Dgvbookcatalog.Rows.Clear()

            If NumberOfRows > 0 Then
                Dim x As Integer = 0
                For x = 0 To NumberOfRows - 1 Step 1

                    RowData = LibraryResourcesTableAdapter.GetDataByTitleAuthorLastSeriesISBN(Title, AuthorLast, Series, ISBN)(x)
                    resourceid = RowData.resourceID
                    CheckoutPeriod = RowData.checkoutperiod
                    checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If checkedoutbooks = 1 Then
                        checkedoutbookinfo = CheckedOutTableAdapter.GetDataByResourceID(resourceid)(0)
                        checkoutdate = checkedoutbookinfo.checkoutdate
                        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
                        Resourcestatus = "Not Available"
                    Else
                        Resourcestatus = "Available"

                    End If
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.resourceID
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.title
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = Resourcestatus
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.authorlast
                    dgvRow.Cells.Add(dgvCell)



                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.publication
                    dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.Series
                    dgvRow.Cells.Add(dgvCell)

                    'dgvCell = New DataGridViewTextBoxCell()
                    'dgvCell.Value = RowData.CallNumber
                    'dgvRow.Cells.Add(dgvCell)

                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = RowData.CheckOutPeriod
                    dgvRow.Cells.Add(dgvCell)

                    Dgvbookcatalog.Rows.Add(dgvRow)

                Next
            ElseIf NumberOfRows = 0 Then
                MessageBox.Show("No results found.")

            End If
        End If
    End Sub

    Private Sub btnclearall_Click(sender As Object, e As EventArgs) Handles btnclearall.Click
        TxtTitle.Text = ""
        txtAuthor.Text = ""
        txtISBN.Text = ""
        Dgvbookcatalog.Rows.Clear()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim selectedBook As Object
        Dim currentdate As Date = Date.Today.Date
        Dim memberid As String = MemberAccount.txtmemberid.Text

        If dgvBookCatalog.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a book you wish to checkout")
        Else

            'trying to check out an already checked out book catch
            resourceid = dgvBookCatalog.SelectedCells(0).Value
            Title = dgvBookCatalog.SelectedCells(1).Value
            checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

            If checkedoutbooks = 1 Then
                MessageBox.Show("This book is currently checked out. Please select another book.")

            ElseIf checkedoutbooks = 0 And resourceid = "" Then
                MessageBox.Show("No book currently selected.")

            Else
                selectedBook = LibraryResourcesTableAdapter.GetDataByResourceID(resourceid)(0)
                CheckedOutTableAdapter.InsertCheckedOutBook(resourceid, currentdate, memberid)
                MessageBox.Show("Checkout successful!")


                CheckoutPeriod = Dgvbookcatalog.SelectedCells(6).Value
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, currentdate)
                Resourcestatus = "Not Available"
                dgvBookCatalog.SelectedCells(2).Value = Resourcestatus



            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click
        MemberAccount.Show()
        Me.Hide()
        MemberAccount.dgvCheckedOutBooks.Rows.Clear()
        MemberAccount.dgvCheckedHistory.Rows.Clear()


    End Sub

    Private Sub LibraryResourcesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LibraryResourcesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LibraryResourcesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub BtnEmployeeResource_Click(sender As Object, e As EventArgs) Handles BtnEmployeeResource.Click
        ResourceADD.Show()
        Me.Hide()
        ResourceADD.DgvBookcatalog.Rows.Clear()
        ResourceADD.txtSeriesData.Clear()
        ResourceADD.txtLastdata.Clear()
        ResourceADD.txtSeries.Clear()
        ResourceADD.TxtISBNdata.Clear()
        ResourceADD.txtISBN.Clear()
        ResourceADD.TxtTitle.Clear()
        ResourceADD.txtpubDate.Clear()
        ResourceADD.txttitledata.Clear()
        ResourceADD.txtAuthor.Clear()
        ResourceADD.txtCheckoutDate.Clear()


    End Sub

    Private Sub BtnemployeeLogoff_Click(sender As Object, e As EventArgs) Handles BtnemployeeLogoff.Click
        Welcome.Show()
        Me.Hide()
        Welcome.TxtEmailLogin.Clear()
        Welcome.TxtpassLogin.Clear()
        Welcome.TxtPass.Clear()
        Welcome.TxtEmail.Clear()
        Welcome.TxtFirst.Clear()
        Welcome.TxtLast.Clear()
        Welcome.TxtPassconfirm.Clear()
        Welcome.TxtEmailLogin.Focus()

    End Sub
End Class