<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResourceADD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResourceADD))
        Me.DgvBookcatalog = New System.Windows.Forms.DataGridView()
        Me.dgvresourceIDdatacolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtitledatacolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAuthorLastDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPubDateDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNdatacolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSeriesDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCheckoutPeriodDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibraryResourcesTableAdapter = New LibraryDatabase.LibraryDataSetTableAdapters.LibraryResourcesTableAdapter()
        Me.Lbltitle2 = New System.Windows.Forms.Label()
        Me.Lbltitle1 = New System.Windows.Forms.Label()
        Me.Lblwords = New System.Windows.Forms.Label()
        Me.CheckedOutTableAdapter = New LibraryDatabase.LibraryDataSetTableAdapters.CheckedOutTableAdapter()
        Me.LblISBN = New System.Windows.Forms.Label()
        Me.LblSeries = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.txtSeries = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnBookCatalogReturn = New System.Windows.Forms.Button()
        Me.txtResourceID = New System.Windows.Forms.TextBox()
        Me.txttitledata = New System.Windows.Forms.TextBox()
        Me.txtLastdata = New System.Windows.Forms.TextBox()
        Me.txtpubDate = New System.Windows.Forms.TextBox()
        Me.txtSeriesData = New System.Windows.Forms.TextBox()
        Me.txtCheckoutDate = New System.Windows.Forms.TextBox()
        Me.LblresourceIDdata = New System.Windows.Forms.Label()
        Me.Lbltitledata = New System.Windows.Forms.Label()
        Me.Lbllastdata = New System.Windows.Forms.Label()
        Me.Lblpubdate = New System.Windows.Forms.Label()
        Me.LblSeriesdata = New System.Windows.Forms.Label()
        Me.Lblchkdatedata = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LibraryDataSet = New LibraryDatabase.LibraryDataSet()
        Me.LibraryResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblISBNdata = New System.Windows.Forms.Label()
        Me.TxtISBNdata = New System.Windows.Forms.TextBox()
        Me.Lblformatting = New System.Windows.Forms.Label()
        Me.LblArrow = New System.Windows.Forms.Label()
        CType(Me.DgvBookcatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvBookcatalog
        '
        Me.DgvBookcatalog.AllowUserToAddRows = False
        Me.DgvBookcatalog.AllowUserToResizeColumns = False
        Me.DgvBookcatalog.AllowUserToResizeRows = False
        Me.DgvBookcatalog.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBookcatalog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvBookcatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBookcatalog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvresourceIDdatacolumn, Me.dgvtitledatacolumn, Me.dgvAuthorLastDataColumn, Me.dgvPubDateDataColumn, Me.ISBNdatacolumn, Me.dgvSeriesDataColumn, Me.dgvCheckoutPeriodDataColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvBookcatalog.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvBookcatalog.Location = New System.Drawing.Point(36, 87)
        Me.DgvBookcatalog.Name = "DgvBookcatalog"
        Me.DgvBookcatalog.RowHeadersVisible = False
        Me.DgvBookcatalog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvBookcatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBookcatalog.Size = New System.Drawing.Size(173, 214)
        Me.DgvBookcatalog.TabIndex = 0
        '
        'dgvresourceIDdatacolumn
        '
        Me.dgvresourceIDdatacolumn.HeaderText = "Resource ID"
        Me.dgvresourceIDdatacolumn.Name = "dgvresourceIDdatacolumn"
        Me.dgvresourceIDdatacolumn.Visible = False
        '
        'dgvtitledatacolumn
        '
        Me.dgvtitledatacolumn.HeaderText = "Title"
        Me.dgvtitledatacolumn.Name = "dgvtitledatacolumn"
        Me.dgvtitledatacolumn.Width = 170
        '
        'dgvAuthorLastDataColumn
        '
        Me.dgvAuthorLastDataColumn.HeaderText = "Author Last"
        Me.dgvAuthorLastDataColumn.Name = "dgvAuthorLastDataColumn"
        Me.dgvAuthorLastDataColumn.Visible = False
        '
        'dgvPubDateDataColumn
        '
        Me.dgvPubDateDataColumn.HeaderText = "Publication Date"
        Me.dgvPubDateDataColumn.Name = "dgvPubDateDataColumn"
        Me.dgvPubDateDataColumn.Visible = False
        '
        'ISBNdatacolumn
        '
        Me.ISBNdatacolumn.HeaderText = "ISBN"
        Me.ISBNdatacolumn.Name = "ISBNdatacolumn"
        Me.ISBNdatacolumn.Visible = False
        '
        'dgvSeriesDataColumn
        '
        Me.dgvSeriesDataColumn.HeaderText = "Series"
        Me.dgvSeriesDataColumn.Name = "dgvSeriesDataColumn"
        Me.dgvSeriesDataColumn.Visible = False
        '
        'dgvCheckoutPeriodDataColumn
        '
        Me.dgvCheckoutPeriodDataColumn.HeaderText = "CheckoutPeriod"
        Me.dgvCheckoutPeriodDataColumn.Name = "dgvCheckoutPeriodDataColumn"
        Me.dgvCheckoutPeriodDataColumn.Visible = False
        '
        'LibraryResourcesTableAdapter
        '
        Me.LibraryResourcesTableAdapter.ClearBeforeFill = True
        '
        'Lbltitle2
        '
        Me.Lbltitle2.AutoSize = True
        Me.Lbltitle2.BackColor = System.Drawing.Color.Transparent
        Me.Lbltitle2.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle2.Location = New System.Drawing.Point(142, 10)
        Me.Lbltitle2.Name = "Lbltitle2"
        Me.Lbltitle2.Size = New System.Drawing.Size(216, 42)
        Me.Lbltitle2.TabIndex = 56
        Me.Lbltitle2.Text = "Configuration"
        '
        'Lbltitle1
        '
        Me.Lbltitle1.AutoSize = True
        Me.Lbltitle1.BackColor = System.Drawing.Color.Transparent
        Me.Lbltitle1.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle1.Location = New System.Drawing.Point(8, 10)
        Me.Lbltitle1.Name = "Lbltitle1"
        Me.Lbltitle1.Size = New System.Drawing.Size(146, 42)
        Me.Lbltitle1.TabIndex = 55
        Me.Lbltitle1.Text = "Resource"
        '
        'Lblwords
        '
        Me.Lblwords.AutoSize = True
        Me.Lblwords.BackColor = System.Drawing.Color.Transparent
        Me.Lblwords.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblwords.Location = New System.Drawing.Point(24, 51)
        Me.Lblwords.Name = "Lblwords"
        Me.Lblwords.Size = New System.Drawing.Size(216, 13)
        Me.Lblwords.TabIndex = 66
        Me.Lblwords.Text = "Make Changes to the Books in the Database!"
        '
        'CheckedOutTableAdapter
        '
        Me.CheckedOutTableAdapter.ClearBeforeFill = True
        '
        'LblISBN
        '
        Me.LblISBN.AutoSize = True
        Me.LblISBN.BackColor = System.Drawing.Color.Transparent
        Me.LblISBN.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblISBN.Location = New System.Drawing.Point(514, 42)
        Me.LblISBN.Name = "LblISBN"
        Me.LblISBN.Size = New System.Drawing.Size(31, 13)
        Me.LblISBN.TabIndex = 84
        Me.LblISBN.Text = "ISBN:"
        '
        'LblSeries
        '
        Me.LblSeries.AutoSize = True
        Me.LblSeries.BackColor = System.Drawing.Color.Transparent
        Me.LblSeries.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeries.Location = New System.Drawing.Point(506, 13)
        Me.LblSeries.Name = "LblSeries"
        Me.LblSeries.Size = New System.Drawing.Size(39, 13)
        Me.LblSeries.TabIndex = 83
        Me.LblSeries.Text = "Series:"
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.BackColor = System.Drawing.Color.Transparent
        Me.LblAuthor.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAuthor.Location = New System.Drawing.Point(352, 41)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(42, 13)
        Me.LblAuthor.TabIndex = 82
        Me.LblAuthor.Text = "Author:"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(363, 18)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(31, 13)
        Me.LblTitle.TabIndex = 81
        Me.LblTitle.Text = "Title:"
        '
        'txtSeries
        '
        Me.txtSeries.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeries.Location = New System.Drawing.Point(551, 10)
        Me.txtSeries.Name = "txtSeries"
        Me.txtSeries.Size = New System.Drawing.Size(100, 21)
        Me.txtSeries.TabIndex = 1
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(400, 37)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(100, 21)
        Me.txtAuthor.TabIndex = 2
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(551, 37)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(100, 21)
        Me.txtISBN.TabIndex = 3
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(400, 10)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(100, 21)
        Me.TxtTitle.TabIndex = 0
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
        'BtnBookCatalogReturn
        '
        Me.BtnBookCatalogReturn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnBookCatalogReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBookCatalogReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBookCatalogReturn.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBookCatalogReturn.ForeColor = System.Drawing.Color.DimGray
        Me.BtnBookCatalogReturn.Location = New System.Drawing.Point(3, 343)
        Me.BtnBookCatalogReturn.Name = "BtnBookCatalogReturn"
        Me.BtnBookCatalogReturn.Size = New System.Drawing.Size(107, 23)
        Me.BtnBookCatalogReturn.TabIndex = 15
        Me.BtnBookCatalogReturn.Text = "Return To Catalog!"
        Me.BtnBookCatalogReturn.UseVisualStyleBackColor = False
        '
        'txtResourceID
        '
        Me.txtResourceID.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResourceID.Location = New System.Drawing.Point(322, 120)
        Me.txtResourceID.Name = "txtResourceID"
        Me.txtResourceID.Size = New System.Drawing.Size(100, 21)
        Me.txtResourceID.TabIndex = 5
        '
        'txttitledata
        '
        Me.txttitledata.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitledata.Location = New System.Drawing.Point(322, 148)
        Me.txttitledata.Name = "txttitledata"
        Me.txttitledata.Size = New System.Drawing.Size(100, 21)
        Me.txttitledata.TabIndex = 6
        '
        'txtLastdata
        '
        Me.txtLastdata.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastdata.Location = New System.Drawing.Point(322, 176)
        Me.txtLastdata.Name = "txtLastdata"
        Me.txtLastdata.Size = New System.Drawing.Size(100, 21)
        Me.txtLastdata.TabIndex = 7
        '
        'txtpubDate
        '
        Me.txtpubDate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpubDate.Location = New System.Drawing.Point(485, 120)
        Me.txtpubDate.Name = "txtpubDate"
        Me.txtpubDate.Size = New System.Drawing.Size(100, 21)
        Me.txtpubDate.TabIndex = 9
        '
        'txtSeriesData
        '
        Me.txtSeriesData.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeriesData.Location = New System.Drawing.Point(485, 148)
        Me.txtSeriesData.Name = "txtSeriesData"
        Me.txtSeriesData.Size = New System.Drawing.Size(100, 21)
        Me.txtSeriesData.TabIndex = 10
        '
        'txtCheckoutDate
        '
        Me.txtCheckoutDate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckoutDate.Location = New System.Drawing.Point(485, 176)
        Me.txtCheckoutDate.Name = "txtCheckoutDate"
        Me.txtCheckoutDate.Size = New System.Drawing.Size(100, 21)
        Me.txtCheckoutDate.TabIndex = 11
        '
        'LblresourceIDdata
        '
        Me.LblresourceIDdata.AutoSize = True
        Me.LblresourceIDdata.BackColor = System.Drawing.Color.Transparent
        Me.LblresourceIDdata.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblresourceIDdata.Location = New System.Drawing.Point(250, 125)
        Me.LblresourceIDdata.Name = "LblresourceIDdata"
        Me.LblresourceIDdata.Size = New System.Drawing.Size(66, 13)
        Me.LblresourceIDdata.TabIndex = 94
        Me.LblresourceIDdata.Text = "Resource ID:"
        '
        'Lbltitledata
        '
        Me.Lbltitledata.AutoSize = True
        Me.Lbltitledata.BackColor = System.Drawing.Color.Transparent
        Me.Lbltitledata.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitledata.Location = New System.Drawing.Point(286, 152)
        Me.Lbltitledata.Name = "Lbltitledata"
        Me.Lbltitledata.Size = New System.Drawing.Size(31, 13)
        Me.Lbltitledata.TabIndex = 95
        Me.Lbltitledata.Text = "Title:"
        '
        'Lbllastdata
        '
        Me.Lbllastdata.AutoSize = True
        Me.Lbllastdata.BackColor = System.Drawing.Color.Transparent
        Me.Lbllastdata.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbllastdata.Location = New System.Drawing.Point(255, 180)
        Me.Lbllastdata.Name = "Lbllastdata"
        Me.Lbllastdata.Size = New System.Drawing.Size(64, 13)
        Me.Lbllastdata.TabIndex = 96
        Me.Lbllastdata.Text = "Author Last:"
        '
        'Lblpubdate
        '
        Me.Lblpubdate.AutoSize = True
        Me.Lblpubdate.BackColor = System.Drawing.Color.Transparent
        Me.Lblpubdate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpubdate.Location = New System.Drawing.Point(432, 124)
        Me.Lblpubdate.Name = "Lblpubdate"
        Me.Lblpubdate.Size = New System.Drawing.Size(53, 13)
        Me.Lblpubdate.TabIndex = 98
        Me.Lblpubdate.Text = "Pub Date:"
        '
        'LblSeriesdata
        '
        Me.LblSeriesdata.AutoSize = True
        Me.LblSeriesdata.BackColor = System.Drawing.Color.Transparent
        Me.LblSeriesdata.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeriesdata.Location = New System.Drawing.Point(444, 152)
        Me.LblSeriesdata.Name = "LblSeriesdata"
        Me.LblSeriesdata.Size = New System.Drawing.Size(39, 13)
        Me.LblSeriesdata.TabIndex = 99
        Me.LblSeriesdata.Text = "Series:"
        '
        'Lblchkdatedata
        '
        Me.Lblchkdatedata.AutoSize = True
        Me.Lblchkdatedata.BackColor = System.Drawing.Color.Transparent
        Me.Lblchkdatedata.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblchkdatedata.Location = New System.Drawing.Point(422, 180)
        Me.Lblchkdatedata.Name = "Lblchkdatedata"
        Me.Lblchkdatedata.Size = New System.Drawing.Size(61, 13)
        Me.Lblchkdatedata.TabIndex = 100
        Me.Lblchkdatedata.Text = "Chckt Date:"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnInsert.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.DimGray
        Me.btnInsert.Location = New System.Drawing.Point(670, 120)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(97, 23)
        Me.btnInsert.TabIndex = 12
        Me.btnInsert.Text = "Insert Book Data!"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnClear.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.DimGray
        Me.BtnClear.Location = New System.Drawing.Point(670, 155)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(97, 23)
        Me.BtnClear.TabIndex = 13
        Me.BtnClear.Text = "Clear Book Data!"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdd.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.DimGray
        Me.BtnAdd.Location = New System.Drawing.Point(670, 190)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(97, 23)
        Me.BtnAdd.TabIndex = 14
        Me.BtnAdd.Text = "Add a Resource!"
        Me.BtnAdd.UseVisualStyleBackColor = False
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
        'CheckOutBindingSource
        '
        Me.CheckOutBindingSource.DataMember = "CheckedOut"
        Me.CheckOutBindingSource.DataSource = Me.LibraryDataSet
        '
        'LblISBNdata
        '
        Me.LblISBNdata.AutoSize = True
        Me.LblISBNdata.BackColor = System.Drawing.Color.Transparent
        Me.LblISBNdata.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblISBNdata.Location = New System.Drawing.Point(285, 206)
        Me.LblISBNdata.Name = "LblISBNdata"
        Me.LblISBNdata.Size = New System.Drawing.Size(31, 13)
        Me.LblISBNdata.TabIndex = 104
        Me.LblISBNdata.Text = "ISBN:"
        '
        'TxtISBNdata
        '
        Me.TxtISBNdata.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtISBNdata.Location = New System.Drawing.Point(322, 203)
        Me.TxtISBNdata.Name = "TxtISBNdata"
        Me.TxtISBNdata.Size = New System.Drawing.Size(100, 21)
        Me.TxtISBNdata.TabIndex = 8
        '
        'Lblformatting
        '
        Me.Lblformatting.AutoSize = True
        Me.Lblformatting.BackColor = System.Drawing.Color.Transparent
        Me.Lblformatting.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblformatting.ForeColor = System.Drawing.Color.Blue
        Me.Lblformatting.Location = New System.Drawing.Point(648, 87)
        Me.Lblformatting.Name = "Lblformatting"
        Me.Lblformatting.Size = New System.Drawing.Size(139, 13)
        Me.Lblformatting.TabIndex = 106
        Me.Lblformatting.Text = "This should help Formatting!"
        '
        'LblArrow
        '
        Me.LblArrow.AutoSize = True
        Me.LblArrow.BackColor = System.Drawing.Color.Transparent
        Me.LblArrow.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArrow.ForeColor = System.Drawing.Color.Blue
        Me.LblArrow.Location = New System.Drawing.Point(705, 100)
        Me.LblArrow.Name = "LblArrow"
        Me.LblArrow.Size = New System.Drawing.Size(17, 13)
        Me.LblArrow.TabIndex = 107
        Me.LblArrow.Text = "↓"
        '
        'ResourceADD
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LibraryDatabase.My.Resources.Resources.Books_Background_image
        Me.CancelButton = Me.BtnBookCatalogReturn
        Me.ClientSize = New System.Drawing.Size(815, 368)
        Me.Controls.Add(Me.LblArrow)
        Me.Controls.Add(Me.Lblformatting)
        Me.Controls.Add(Me.TxtISBNdata)
        Me.Controls.Add(Me.LblISBNdata)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Lblchkdatedata)
        Me.Controls.Add(Me.LblSeriesdata)
        Me.Controls.Add(Me.Lblpubdate)
        Me.Controls.Add(Me.Lbllastdata)
        Me.Controls.Add(Me.Lbltitledata)
        Me.Controls.Add(Me.LblresourceIDdata)
        Me.Controls.Add(Me.txtCheckoutDate)
        Me.Controls.Add(Me.txtSeriesData)
        Me.Controls.Add(Me.txtpubDate)
        Me.Controls.Add(Me.txtLastdata)
        Me.Controls.Add(Me.txttitledata)
        Me.Controls.Add(Me.txtResourceID)
        Me.Controls.Add(Me.BtnBookCatalogReturn)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.LblISBN)
        Me.Controls.Add(Me.LblSeries)
        Me.Controls.Add(Me.LblAuthor)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.txtSeries)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Lblwords)
        Me.Controls.Add(Me.Lbltitle2)
        Me.Controls.Add(Me.Lbltitle1)
        Me.Controls.Add(Me.DgvBookcatalog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ResourceADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add a Resource!"
        CType(Me.DgvBookcatalog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvBookcatalog As System.Windows.Forms.DataGridView
    Friend WithEvents LibraryDataSet As LibraryDatabase.LibraryDataSet
    Friend WithEvents LibraryResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryResourcesTableAdapter As LibraryDatabase.LibraryDataSetTableAdapters.LibraryResourcesTableAdapter
    Friend WithEvents Lbltitle2 As System.Windows.Forms.Label
    Friend WithEvents Lbltitle1 As System.Windows.Forms.Label
    Friend WithEvents Lblwords As System.Windows.Forms.Label
    Friend WithEvents CheckOutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckedOutTableAdapter As LibraryDatabase.LibraryDataSetTableAdapters.CheckedOutTableAdapter
    Friend WithEvents LblISBN As System.Windows.Forms.Label
    Friend WithEvents LblSeries As System.Windows.Forms.Label
    Friend WithEvents LblAuthor As System.Windows.Forms.Label
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents txtSeries As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnBookCatalogReturn As System.Windows.Forms.Button
    Friend WithEvents txtResourceID As System.Windows.Forms.TextBox
    Friend WithEvents txttitledata As System.Windows.Forms.TextBox
    Friend WithEvents txtLastdata As System.Windows.Forms.TextBox
    Friend WithEvents txtpubDate As System.Windows.Forms.TextBox
    Friend WithEvents txtSeriesData As System.Windows.Forms.TextBox
    Friend WithEvents txtCheckoutDate As System.Windows.Forms.TextBox
    Friend WithEvents LblresourceIDdata As System.Windows.Forms.Label
    Friend WithEvents Lbltitledata As System.Windows.Forms.Label
    Friend WithEvents Lbllastdata As System.Windows.Forms.Label
    Friend WithEvents Lblpubdate As System.Windows.Forms.Label
    Friend WithEvents LblSeriesdata As System.Windows.Forms.Label
    Friend WithEvents Lblchkdatedata As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblISBNdata As System.Windows.Forms.Label
    Friend WithEvents TxtISBNdata As System.Windows.Forms.TextBox
    Friend WithEvents dgvresourceIDdatacolumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtitledatacolumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvAuthorLastDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPubDateDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISBNdatacolumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvSeriesDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCheckoutPeriodDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lblformatting As System.Windows.Forms.Label
    Friend WithEvents LblArrow As System.Windows.Forms.Label
End Class
