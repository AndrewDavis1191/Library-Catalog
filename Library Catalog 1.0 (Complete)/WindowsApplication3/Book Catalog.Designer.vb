<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bookcatalog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bookcatalog))
        Me.Dgvbookcatalog = New System.Windows.Forms.DataGridView()
        Me.dgvResourceIDDatacolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTitleDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvStatusdataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAuthorLastDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPublicationDateDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSeriesDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCheckOutPeriodDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LblmemberWords = New System.Windows.Forms.Label()
        Me.btnShowall = New System.Windows.Forms.Button()
        Me.btnclearall = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.txtSeries = New System.Windows.Forms.TextBox()
        Me.BtnAccount = New System.Windows.Forms.Button()
        Me.LibraryDataSet = New LibraryDatabase.LibraryDataSet()
        Me.LibraryResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryResourcesTableAdapter = New LibraryDatabase.LibraryDataSetTableAdapters.LibraryResourcesTableAdapter()
        Me.TableAdapterManager = New LibraryDatabase.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.CheckedOutTableAdapter = New LibraryDatabase.LibraryDataSetTableAdapters.CheckedOutTableAdapter()
        Me.LibraryResourcesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibraryResourcesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CheckedOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnemployeeLogoff = New System.Windows.Forms.Button()
        Me.BtnEmployeeResource = New System.Windows.Forms.Button()
        Me.LblEmployeeWords = New System.Windows.Forms.Label()
        CType(Me.Dgvbookcatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryResourcesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibraryResourcesBindingNavigator.SuspendLayout()
        CType(Me.CheckedOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgvbookcatalog
        '
        Me.Dgvbookcatalog.AllowUserToAddRows = False
        Me.Dgvbookcatalog.AllowUserToDeleteRows = False
        Me.Dgvbookcatalog.AllowUserToResizeColumns = False
        Me.Dgvbookcatalog.AllowUserToResizeRows = False
        Me.Dgvbookcatalog.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.Dgvbookcatalog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgvbookcatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvbookcatalog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvResourceIDDatacolumn, Me.dgvTitleDataColumn, Me.dgvStatusdataColumn, Me.dgvAuthorLastDataColumn, Me.dgvPublicationDateDataColumn, Me.dgvSeriesDataColumn, Me.DgvCheckOutPeriodDataColumn})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvbookcatalog.DefaultCellStyle = DataGridViewCellStyle1
        Me.Dgvbookcatalog.Location = New System.Drawing.Point(12, 78)
        Me.Dgvbookcatalog.Name = "Dgvbookcatalog"
        Me.Dgvbookcatalog.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvbookcatalog.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgvbookcatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvbookcatalog.ShowCellErrors = False
        Me.Dgvbookcatalog.ShowCellToolTips = False
        Me.Dgvbookcatalog.ShowEditingIcon = False
        Me.Dgvbookcatalog.ShowRowErrors = False
        Me.Dgvbookcatalog.Size = New System.Drawing.Size(791, 259)
        Me.Dgvbookcatalog.TabIndex = 0
        '
        'dgvResourceIDDatacolumn
        '
        Me.dgvResourceIDDatacolumn.HeaderText = "Resource ID"
        Me.dgvResourceIDDatacolumn.Name = "dgvResourceIDDatacolumn"
        Me.dgvResourceIDDatacolumn.ReadOnly = True
        Me.dgvResourceIDDatacolumn.Visible = False
        '
        'dgvTitleDataColumn
        '
        Me.dgvTitleDataColumn.HeaderText = "Title"
        Me.dgvTitleDataColumn.Name = "dgvTitleDataColumn"
        Me.dgvTitleDataColumn.Width = 180
        '
        'dgvStatusdataColumn
        '
        Me.dgvStatusdataColumn.HeaderText = "Resource Status"
        Me.dgvStatusdataColumn.Name = "dgvStatusdataColumn"
        Me.dgvStatusdataColumn.Width = 120
        '
        'dgvAuthorLastDataColumn
        '
        Me.dgvAuthorLastDataColumn.HeaderText = "Last Name"
        Me.dgvAuthorLastDataColumn.Name = "dgvAuthorLastDataColumn"
        Me.dgvAuthorLastDataColumn.Width = 110
        '
        'dgvPublicationDateDataColumn
        '
        Me.dgvPublicationDateDataColumn.HeaderText = "Publication Date"
        Me.dgvPublicationDateDataColumn.Name = "dgvPublicationDateDataColumn"
        Me.dgvPublicationDateDataColumn.Width = 110
        '
        'dgvSeriesDataColumn
        '
        Me.dgvSeriesDataColumn.HeaderText = "Series"
        Me.dgvSeriesDataColumn.Name = "dgvSeriesDataColumn"
        Me.dgvSeriesDataColumn.Width = 120
        '
        'DgvCheckOutPeriodDataColumn
        '
        Me.DgvCheckOutPeriodDataColumn.HeaderText = "CheckOut Period"
        Me.DgvCheckOutPeriodDataColumn.Name = "DgvCheckOutPeriodDataColumn"
        Me.DgvCheckOutPeriodDataColumn.Width = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Catalog"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 42)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Book"
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(400, 10)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(100, 21)
        Me.TxtTitle.TabIndex = 0
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(551, 37)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(100, 21)
        Me.txtISBN.TabIndex = 3
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(400, 37)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(100, 21)
        Me.txtAuthor.TabIndex = 2
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.BurlyWood
        Me.BtnSearch.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSearch.Location = New System.Drawing.Point(670, 18)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(105, 36)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search!"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'LblmemberWords
        '
        Me.LblmemberWords.AutoSize = True
        Me.LblmemberWords.BackColor = System.Drawing.Color.Transparent
        Me.LblmemberWords.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblmemberWords.Location = New System.Drawing.Point(24, 51)
        Me.LblmemberWords.Name = "LblmemberWords"
        Me.LblmemberWords.Size = New System.Drawing.Size(175, 13)
        Me.LblmemberWords.TabIndex = 65
        Me.LblmemberWords.Text = "Find exactly what you're looking for!"
        '
        'btnShowall
        '
        Me.btnShowall.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnShowall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnShowall.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowall.ForeColor = System.Drawing.Color.DimGray
        Me.btnShowall.Location = New System.Drawing.Point(250, 25)
        Me.btnShowall.Name = "btnShowall"
        Me.btnShowall.Size = New System.Drawing.Size(97, 23)
        Me.btnShowall.TabIndex = 67
        Me.btnShowall.Text = "Show All Books!"
        Me.btnShowall.UseVisualStyleBackColor = False
        Me.btnShowall.Visible = False
        '
        'btnclearall
        '
        Me.btnclearall.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnclearall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnclearall.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclearall.ForeColor = System.Drawing.Color.DimGray
        Me.btnclearall.Location = New System.Drawing.Point(250, 19)
        Me.btnclearall.Name = "btnclearall"
        Me.btnclearall.Size = New System.Drawing.Size(97, 29)
        Me.btnclearall.TabIndex = 7
        Me.btnclearall.Text = "Clear All Books!"
        Me.btnclearall.UseVisualStyleBackColor = False
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCheckOut.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.Location = New System.Drawing.Point(313, 341)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(157, 26)
        Me.btnCheckOut.TabIndex = 69
        Me.btnCheckOut.Text = "Check Out!"
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'txtSeries
        '
        Me.txtSeries.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeries.Location = New System.Drawing.Point(551, 10)
        Me.txtSeries.Name = "txtSeries"
        Me.txtSeries.Size = New System.Drawing.Size(100, 21)
        Me.txtSeries.TabIndex = 1
        '
        'BtnAccount
        '
        Me.BtnAccount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAccount.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccount.ForeColor = System.Drawing.Color.DimGray
        Me.BtnAccount.Location = New System.Drawing.Point(3, 343)
        Me.BtnAccount.Name = "BtnAccount"
        Me.BtnAccount.Size = New System.Drawing.Size(107, 23)
        Me.BtnAccount.TabIndex = 71
        Me.BtnAccount.Text = "Return To Account"
        Me.BtnAccount.UseVisualStyleBackColor = False
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryResourcesBindingSource
        '
        Me.LibraryResourcesBindingSource.DataMember = "LibraryResources"
        Me.LibraryResourcesBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibraryResourcesTableAdapter
        '
        Me.LibraryResourcesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckedOutTableAdapter = Me.CheckedOutTableAdapter
        Me.TableAdapterManager.CheckOutHistoryTableAdapter = Nothing
        Me.TableAdapterManager.Library_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.LibraryMembersTableAdapter = Nothing
        Me.TableAdapterManager.LibraryResourcesTableAdapter = Me.LibraryResourcesTableAdapter
        Me.TableAdapterManager.UpdateOrder = LibraryDatabase.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CheckedOutTableAdapter
        '
        Me.CheckedOutTableAdapter.ClearBeforeFill = True
        '
        'LibraryResourcesBindingNavigator
        '
        Me.LibraryResourcesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LibraryResourcesBindingNavigator.BindingSource = Me.LibraryResourcesBindingSource
        Me.LibraryResourcesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LibraryResourcesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LibraryResourcesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LibraryResourcesBindingNavigatorSaveItem})
        Me.LibraryResourcesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LibraryResourcesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LibraryResourcesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LibraryResourcesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LibraryResourcesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LibraryResourcesBindingNavigator.Name = "LibraryResourcesBindingNavigator"
        Me.LibraryResourcesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LibraryResourcesBindingNavigator.Size = New System.Drawing.Size(815, 25)
        Me.LibraryResourcesBindingNavigator.TabIndex = 72
        Me.LibraryResourcesBindingNavigator.Text = "BindingNavigator1"
        Me.LibraryResourcesBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LibraryResourcesBindingNavigatorSaveItem
        '
        Me.LibraryResourcesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LibraryResourcesBindingNavigatorSaveItem.Image = CType(resources.GetObject("LibraryResourcesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LibraryResourcesBindingNavigatorSaveItem.Name = "LibraryResourcesBindingNavigatorSaveItem"
        Me.LibraryResourcesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LibraryResourcesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CheckedOutBindingSource
        '
        Me.CheckedOutBindingSource.DataMember = "CheckedOut"
        Me.CheckedOutBindingSource.DataSource = Me.LibraryDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Title:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Author:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(506, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Series:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(514, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "ISBN:"
        '
        'BtnemployeeLogoff
        '
        Me.BtnemployeeLogoff.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnemployeeLogoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnemployeeLogoff.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnemployeeLogoff.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnemployeeLogoff.ForeColor = System.Drawing.Color.DimGray
        Me.BtnemployeeLogoff.Location = New System.Drawing.Point(3, 344)
        Me.BtnemployeeLogoff.Name = "BtnemployeeLogoff"
        Me.BtnemployeeLogoff.Size = New System.Drawing.Size(107, 23)
        Me.BtnemployeeLogoff.TabIndex = 5
        Me.BtnemployeeLogoff.Text = "Log Out"
        Me.BtnemployeeLogoff.UseVisualStyleBackColor = False
        '
        'BtnEmployeeResource
        '
        Me.BtnEmployeeResource.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnEmployeeResource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEmployeeResource.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmployeeResource.ForeColor = System.Drawing.Color.White
        Me.BtnEmployeeResource.Location = New System.Drawing.Point(313, 340)
        Me.BtnEmployeeResource.Name = "BtnEmployeeResource"
        Me.BtnEmployeeResource.Size = New System.Drawing.Size(157, 26)
        Me.BtnEmployeeResource.TabIndex = 6
        Me.BtnEmployeeResource.Text = "Add A Resource!"
        Me.BtnEmployeeResource.UseVisualStyleBackColor = False
        '
        'LblEmployeeWords
        '
        Me.LblEmployeeWords.AutoSize = True
        Me.LblEmployeeWords.BackColor = System.Drawing.Color.Transparent
        Me.LblEmployeeWords.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmployeeWords.Location = New System.Drawing.Point(24, 51)
        Me.LblEmployeeWords.Name = "LblEmployeeWords"
        Me.LblEmployeeWords.Size = New System.Drawing.Size(159, 13)
        Me.LblEmployeeWords.TabIndex = 79
        Me.LblEmployeeWords.Text = "Check on all the Books you have!"
        '
        'Bookcatalog
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.LibraryDatabase.My.Resources.Resources.Books_Background_image
        Me.ClientSize = New System.Drawing.Size(815, 368)
        Me.Controls.Add(Me.LblEmployeeWords)
        Me.Controls.Add(Me.BtnEmployeeResource)
        Me.Controls.Add(Me.BtnemployeeLogoff)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LibraryResourcesBindingNavigator)
        Me.Controls.Add(Me.BtnAccount)
        Me.Controls.Add(Me.txtSeries)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnclearall)
        Me.Controls.Add(Me.btnShowall)
        Me.Controls.Add(Me.LblmemberWords)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dgvbookcatalog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bookcatalog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Catalog"
        CType(Me.Dgvbookcatalog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryResourcesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibraryResourcesBindingNavigator.ResumeLayout(False)
        Me.LibraryResourcesBindingNavigator.PerformLayout()
        CType(Me.CheckedOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgvbookcatalog As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents LblmemberWords As System.Windows.Forms.Label
    Friend WithEvents btnShowall As System.Windows.Forms.Button
    Friend WithEvents btnclearall As System.Windows.Forms.Button
    Friend WithEvents btnCheckOut As System.Windows.Forms.Button
    Friend WithEvents txtSeries As System.Windows.Forms.TextBox
    Friend WithEvents BtnAccount As System.Windows.Forms.Button
    Friend WithEvents LibraryDataSet As LibraryDatabase.LibraryDataSet
    Friend WithEvents LibraryResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryResourcesTableAdapter As LibraryDatabase.LibraryDataSetTableAdapters.LibraryResourcesTableAdapter
    Friend WithEvents TableAdapterManager As LibraryDatabase.LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibraryResourcesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LibraryResourcesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CheckedOutTableAdapter As LibraryDatabase.LibraryDataSetTableAdapters.CheckedOutTableAdapter
    Friend WithEvents CheckedOutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvResourceIDDatacolumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTitleDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvStatusdataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvAuthorLastDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPublicationDateDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvSeriesDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgvCheckOutPeriodDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnemployeeLogoff As System.Windows.Forms.Button
    Friend WithEvents BtnEmployeeResource As System.Windows.Forms.Button
    Friend WithEvents LblEmployeeWords As System.Windows.Forms.Label
End Class
