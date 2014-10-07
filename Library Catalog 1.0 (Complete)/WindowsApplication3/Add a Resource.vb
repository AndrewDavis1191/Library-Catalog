Public Class ResourceADD

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

    Private Sub ResourceADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.CheckedOut' table. You can move, or remove it, as needed.
        Me.CheckedOutTableAdapter.Fill(Me.LibraryDataSet.CheckedOut)
        'TODO: This line of code loads data into the 'LibraryDataSet.CheckedOut' table. You can move, or remove it, as needed.
        Me.CheckedOutTableAdapter.Fill(Me.LibraryDataSet.CheckedOut)
        'TODO: This line of code loads data into the 'LibraryDataSet.CheckOutHistory' table. You can move, or remove it, as needed.
        'Me.CheckOutHistoryTableAdapter.Fill(Me.LibraryDataSet.CheckOutHistory)
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
                    CheckedOutBooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If CheckedOutBooks = 1 Then
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
                    dgvCell.Value = RowData.ISBN
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
                    CheckedOutBooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If CheckedOutBooks = 1 Then
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
                    dgvCell.Value = RowData.ISBN
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
                    CheckedOutBooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If CheckedOutBooks = 1 Then
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
                    dgvCell.Value = RowData.ISBN
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
                    CheckedOutBooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If CheckedOutBooks = 1 Then
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
                    dgvCell.Value = RowData.ISBN
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
                    CheckedOutBooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If CheckedOutBooks = 1 Then
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
                    dgvCell.Value = RowData.ISBN
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
                    CheckedOutBooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If CheckedOutBooks = 1 Then
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
                    dgvCell.Value = RowData.ISBN
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
                    CheckedOutBooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

                    'If Me.txtTitle.Text = "" Xor Me.txtAuthor.Text = "" Xor Me.txtISBN.Text = "" Xor Me.txtSeries.Text = "" Then
                    'Me.CheckedOutTableAdapter.Fill(LibraryDataSet.CheckedOut)


                    If CheckedOutBooks = 1 Then
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
                    dgvCell.Value = RowData.ISBN
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

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim currentdate As Date = Date.Today.Date
        Dim memberid As String = Welcome.MemberID

        LblArrow.Hide()
        Lblformatting.Hide()


        If DgvBookcatalog.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a book you wish to insert")
        Else

            'trying to check out an already checked out book catch
            resourceid = DgvBookcatalog.SelectedCells(0).Value
            Title = DgvBookcatalog.SelectedCells(1).Value
            AuthorLast = DgvBookcatalog.SelectedCells(3).Value
            Series = DgvBookcatalog.SelectedCells(5).Value
            ISBN = DgvBookcatalog.SelectedCells(2).Value
            PubDate = DgvBookcatalog.SelectedCells(4).Value
            CheckoutPeriod = DgvBookcatalog.SelectedCells(6).Value


            checkedoutbooks = CheckedOutTableAdapter.FillByResourceID(LibraryDataSet.CheckedOut, resourceid)

            If checkedoutbooks = 0 And resourceid = "" Then
                MessageBox.Show("No book currently selected.")

            Else
                txtResourceID.Text = resourceid
                txttitledata.Text = Title
                txtLastdata.Text = AuthorLast
                txtpubDate.Text = PubDate
                txtSeriesData.Text = Series
                txtISBNdata.text = ISBN
                txtCheckoutDate.Text = CheckoutPeriod

            End If
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim NumberOfRows As Integer
        Dim ISBNrows As Object

        'Dim CheckOutPeriod As Decimal


        NumberOfRows = LibraryResourcesTableAdapter.FillByResourceID(LibraryDataSet.LibraryResources, txtResourceID.Text)


        If ISBNrows = 1 Then

            MessageBox.Show("This ISBN is currently in use; Please enter a different combination")


        ElseIf NumberOfRows = 1 Then


            MessageBox.Show("This ResourceID is currently in use; Please enter a different combination")







        ElseIf NumberOfRows = 0 And ISBNrows = 0 And txtResourceID.Text = "" And txttitledata.Text = "" And txtLastdata.Text = "" And txtSeriesData.Text = "" And
                txtpubDate.Text = "" And TxtISBNdata.Text = "" And txtCheckoutDate.Text = "" Then
            MessageBox.Show("Please enter all fields.")

        Else
            Me.LibraryResourcesTableAdapter.Insert(txtResourceID.Text, txttitledata.Text, txtLastdata.Text, Nothing, Nothing,
                                                   txtpubDate.Text, txtSeriesData.Text, TxtISBNdata.Text, Nothing, txtCheckoutDate.Text,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing)
            MessageBox.Show("New Resource Added!")
            txtResourceID.Text = ""
            txttitledata.Text = ""
            txtLastdata.Text = ""
            txtpubDate.Text = ""
            txtSeriesData.Text = ""
            TxtISBNdata.Text = ""
            txtCheckoutDate.Text = ""
        End If




    End Sub

    Private Sub BtnBookCatalogReturn_Click(sender As Object, e As EventArgs) Handles BtnBookCatalogReturn.Click
        Bookcatalog.Show()
        Me.Hide()
        Bookcatalog.Dgvbookcatalog.Rows.Clear()
        Bookcatalog.txtAuthor.Clear()
        Bookcatalog.txtISBN.Clear()
        Bookcatalog.txtSeries.Clear()
        Bookcatalog.TxtTitle.Clear()
        Bookcatalog.TxtTitle.Focus()


    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtLastdata.Clear()
        txtCheckoutDate.Clear()
        txtpubDate.Clear()
        TxtISBNdata.Clear()
        txtResourceID.Clear()
        txtSeriesData.Clear()
        txttitledata.Clear()
        txtResourceID.Focus()


    End Sub

    Private Sub DgvBookcatalog_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBookcatalog.CellContentClick

    End Sub
End Class