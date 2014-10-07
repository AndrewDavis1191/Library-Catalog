Public Class MemberAccount
    Dim RowData As Object
    Dim NumberofRows As Integer
    Dim CheckoutPeriod As Long
    Dim BookInfo As Object
    Dim ResourceID As String
    Dim ResourceStatus As String
    Dim DueDate As Date
    Dim CheckoutDate As Date
    Dim MemberID As String = Welcome.MemberID


    Private Sub MemberAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.LibraryDataSet.LibraryResources)
        'TODO: This line of code loads data into the 'LibraryDataSet.CheckOutHistory' table. You can move, or remove it, as needed.
        Me.CheckOutHistoryTableAdapter.Fill(Me.LibraryDataSet.CheckOutHistory)
        'TODO: This line of code loads data into the 'LibraryDataSet.CheckedOut' table. You can move, or remove it, as needed.
        Me.CheckedOutTableAdapter.Fill(Me.LibraryDataSet.CheckedOut)
        'TODO: This line of code loads data into the 'LibraryDataSet.CheckedOut' table. You can move, or remove it, as needed.
        Me.CheckedOutTableAdapter.Fill(Me.LibraryDataSet.CheckedOut)
        'TODO: This line of code loads data into the 'LibraryDataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.LibraryDataSet.LibraryResources)
        'TODO: This line of code loads data into the 'LibraryDataSet.CheckOutHistory' table. You can move, or remove it, as needed.
        Me.CheckOutHistoryTableAdapter.Fill(Me.LibraryDataSet.CheckOutHistory)


        txtmemberid.Hide()
        lblmembername.Text = Welcome.MemberName



    End Sub

    Private Sub lblmembername_Click(sender As Object, e As EventArgs) Handles lblmembername.Click

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Bookcatalog.Show()
        Me.Hide()

    End Sub

    Private Sub Btnviewcheckedout_Click(sender As Object, e As EventArgs) Handles Btnviewcheckedout.Click


        dgvCheckedOutBooks.Rows.Clear()


        NumberofRows = CheckedOutTableAdapter.FillByMemberID(LibraryDataSet.CheckedOut, txtmemberid.Text)

        If NumberOfRows > 0 Then

            Dim x As Integer = 0
            For x = 0 To NumberOfRows - 1 Step 1

                BookInfo = CheckedOutTableAdapter.GetDataByMemberID(txtmemberid.Text)(x)
                ResourceID = BookInfo.resourceID

                RowData = Welcome.LibraryResourcesTableAdapter.GetDataByResourceID(ResourceID)(0)

                CheckoutDate = BookInfo.checkoutdate

                CheckoutPeriod = RowData.checkoutperiod
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, CheckoutDate)
                ResourceStatus = "DUE " & DueDate.Date

                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.title
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.authorlast
                dgvRow.Cells.Add(dgvCell)

                'dgvCell = New DataGridViewTextBoxCell()
                'dgvCell.Value = RowData.publicationdate
                'dgvRow.Cells.Add(dgvCell)

                'dgvCell = New DataGridViewTextBoxCell()
                'dgvCell.Value = RowData.Series
                'dgvRow.Cells.Add(dgvCell)

                'dgvCell = New DataGridViewTextBoxCell()
                'dgvCell.Value = RowData.CallNumber
                'dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = CheckoutDate.Date
                dgvRow.Cells.Add(dgvCell)


                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = ResourceStatus
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.resourceID
                dgvRow.Cells.Add(dgvCell)

                dgvCheckedOutBooks.Rows.Add(dgvRow)

            Next
        Else
            MessageBox.Show("You do not have any books checked out.")

        End If
    End Sub


    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckedHistory.CellContentClick

    End Sub

    Private Sub btncheckedhistory_Click(sender As Object, e As EventArgs) Handles btncheckedhistory.Click

        dgvCheckedHistory.Rows.Clear()

        NumberofRows = CheckOutHistoryTableAdapter.FillByMemberID(LibraryDataSet.CheckOutHistory, txtmemberid.Text)

        If NumberofRows > 0 Then

            Dim x As Integer = 0
            For x = 0 To NumberofRows - 1 Step 1

                BookInfo = CheckOutHistoryTableAdapter.GetDataByMemberID(txtmemberid.Text)(x)
                ResourceID = BookInfo.ResourceID

                RowData = Welcome.LibraryResourcesTableAdapter.GetDataByResourceID(ResourceID)(0)

                CheckoutDate = BookInfo.CheckoutDate

                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'dgvCell = New DataGridViewTextBoxCell()
                'dgvCell.Value = ResourceID
                'dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.title
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = CheckoutDate.Date
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = BookInfo.ReturnDate
                dgvRow.Cells.Add(dgvCell)

                dgvCheckedHistory.Rows.Add(dgvRow)

            Next
        Else

            MessageBox.Show("You do not have a history of books checked out.")

        End If
    End Sub

    Private Sub LibraryResourcesBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtmemberid_TextChanged(sender As Object, e As EventArgs) Handles txtmemberid.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRenew.Click


        Dim currentdate As Date = Date.Today.Date
        NumberofRows = CheckedOutTableAdapter.FillByMemberID(LibraryDataSet.CheckedOut, txtmemberid.Text)

        If NumberofRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        Else

            If dgvCheckedOutBooks.SelectedCells.Count = 0 Then
                MessageBox.Show("Please select the book you wish to renew from the items on the left")
            Else

                'renew book
                ResourceID = dgvCheckedOutBooks.SelectedCells(5).Value
                CheckedOutTableAdapter.RenewQuery(ResourceID, currentdate, txtmemberid.Text, ResourceID, txtmemberid.Text)

                CheckoutPeriod = dgvCheckedOutBooks.SelectedCells(4).Value
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, currentdate)
                ResourceStatus = "DUE " & DueDate.Date
                dgvCheckedOutBooks.SelectedCells(2).Value = currentdate
                dgvCheckedOutBooks.SelectedCells(3).Value = ResourceStatus

                MessageBox.Show("Book Renewal Successful!")

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim CurrentDate As Date = Date.Today
        Dim LocalCheckoutDate As Date

        If dgvCheckedOutBooks.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select the book you wish to return from the items on the left")
        Else

            'return book

            ResourceID = dgvCheckedOutBooks.SelectedCells(5).Value
            LocalCheckoutDate = dgvCheckedOutBooks.SelectedCells(2).Value

            CheckOutHistoryTableAdapter.InsertBookQuery(ResourceID, txtmemberid.Text, LocalCheckoutDate, CurrentDate)
            'test of insert above
            If ResourceID = "" Then
                MessageBox.Show("No book selected.")

            Else
                CheckedOutTableAdapter.BookDeleteQuery(ResourceID, txtmemberid.Text)

                MessageBox.Show("Return successful!")
                dgvCheckedOutBooks.SelectedCells(3).Value = "RETURNED"
                dgvCheckedOutBooks.Rows.Clear()

                NumberofRows = CheckOutHistoryTableAdapter.FillByMemberID(LibraryDataSet.CheckOutHistory, txtmemberid.Text)
                dgvCheckedHistory.Rows.Clear()

                If NumberofRows > 0 Then

                    Dim x As Integer = 0
                    For x = 0 To NumberofRows - 1 Step 1

                        BookInfo = CheckOutHistoryTableAdapter.GetDataByMemberID(txtmemberid.Text)(x)
                        ResourceID = BookInfo.ResourceID

                        RowData = LibraryResourcesTableAdapter.GetDataByResourceID(ResourceID)(0)

                        CheckoutDate = BookInfo.CheckoutDate

                        Dim dgvRow As New DataGridViewRow
                        Dim dgvCell As DataGridViewCell

                        'dgvCell = New DataGridViewTextBoxCell()
                        'dgvCell.Value = ResourceID
                        'dgvRow.Cells.Add(dgvCell)

                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = RowData.title
                        dgvRow.Cells.Add(dgvCell)

                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = CheckoutDate.Date
                        dgvRow.Cells.Add(dgvCell)

                        dgvCell = New DataGridViewTextBoxCell()
                        dgvCell.Value = BookInfo.ReturnDate
                        dgvRow.Cells.Add(dgvCell)

                        dgvCheckedHistory.Rows.Add(dgvRow)

                    Next
                ElseIf NumberofRows = 0 Then
                    MessageBox.Show("Return successful!")
                End If
            End If
        End If

        NumberofRows = CheckedOutTableAdapter.FillByMemberID(LibraryDataSet.CheckedOut, txtmemberid.Text)

        If NumberofRows > 0 Then

            Dim x As Integer = 0
            For x = 0 To NumberofRows - 1 Step 1

                BookInfo = CheckedOutTableAdapter.GetDataByMemberID(txtmemberid.Text)(x)
                ResourceID = BookInfo.resourceID

                RowData = LibraryResourcesTableAdapter.GetDataByResourceID(ResourceID)(0)

                CheckoutDate = BookInfo.checkoutdate

                CheckoutPeriod = RowData.checkoutperiod
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, CheckoutDate)
                ResourceStatus = "DUE " & DueDate.Date

                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.title
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.authorlast
                dgvRow.Cells.Add(dgvCell)

                'dgvCell = New DataGridViewTextBoxCell()
                'dgvCell.Value = RowData.publicationdate
                'dgvRow.Cells.Add(dgvCell)

                'dgvCell = New DataGridViewTextBoxCell()
                'dgvCell.Value = RowData.Series
                'dgvRow.Cells.Add(dgvCell)

                'dgvCell = New DataGridViewTextBoxCell()
                'dgvCell.Value = RowData.CallNumber
                'dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = CheckoutDate.Date
                dgvRow.Cells.Add(dgvCell)


                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = ResourceStatus
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.resourceID
                dgvRow.Cells.Add(dgvCell)

                dgvCheckedOutBooks.Rows.Add(dgvRow)

            Next
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btnlogout.Click
        Welcome.Show()
        Me.Close()
        Welcome.TxtEmailLogin.Clear()
        Welcome.TxtpassLogin.Clear()
        Welcome.TxtEmailLogin.Focus()

    End Sub
End Class