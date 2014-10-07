<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.picbox2 = New System.Windows.Forms.PictureBox()
        Me.Picbox4 = New System.Windows.Forms.PictureBox()
        Me.Picbox1 = New System.Windows.Forms.PictureBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Picbox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnJoin = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RbtnEmployee = New System.Windows.Forms.RadioButton()
        Me.RbtnMember = New System.Windows.Forms.RadioButton()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TxtpassLogin = New System.Windows.Forms.TextBox()
        Me.TxtEmailLogin = New System.Windows.Forms.TextBox()
        Me.LibraryMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet = New LibraryDatabase.LibraryDataSet()
        Me.TxtFirst = New System.Windows.Forms.TextBox()
        Me.TxtLast = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtPassconfirm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LibraryMembersTableAdapter = New LibraryDatabase.LibraryDataSetTableAdapters.LibraryMembersTableAdapter()
        Me.TableAdapterManager = New LibraryDatabase.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.CheckedOutTableAdapter = New LibraryDatabase.LibraryDataSetTableAdapters.CheckedOutTableAdapter()
        Me.CheckOutHistoryTableAdapter = New LibraryDatabase.LibraryDataSetTableAdapters.CheckOutHistoryTableAdapter()
        Me.Library_EmployeesTableAdapter = New LibraryDatabase.LibraryDataSetTableAdapters.Library_EmployeesTableAdapter()
        Me.LibraryResourcesTableAdapter = New LibraryDatabase.LibraryDataSetTableAdapters.LibraryResourcesTableAdapter()
        Me.LibraryEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblblank = New System.Windows.Forms.Label()
        Me.lblWeak = New System.Windows.Forms.Label()
        Me.lblMedium = New System.Windows.Forms.Label()
        Me.lblStrong = New System.Windows.Forms.Label()
        Me.lblVeryStrong = New System.Windows.Forms.Label()
        CType(Me.picbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picbox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picbox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picbox2
        '
        Me.picbox2.BackColor = System.Drawing.Color.Transparent
        Me.picbox2.BackgroundImage = Global.LibraryDatabase.My.Resources.Resources.Ender_s_Game_Cover
        Me.picbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbox2.Location = New System.Drawing.Point(175, 124)
        Me.picbox2.Name = "picbox2"
        Me.picbox2.Size = New System.Drawing.Size(108, 142)
        Me.picbox2.TabIndex = 57
        Me.picbox2.TabStop = False
        '
        'Picbox4
        '
        Me.Picbox4.BackColor = System.Drawing.Color.Transparent
        Me.Picbox4.BackgroundImage = Global.LibraryDatabase.My.Resources.Resources.Harry_Potter_and_the_Order_of_the_Phoenix_Cover
        Me.Picbox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picbox4.Location = New System.Drawing.Point(175, 124)
        Me.Picbox4.Name = "Picbox4"
        Me.Picbox4.Size = New System.Drawing.Size(108, 142)
        Me.Picbox4.TabIndex = 55
        Me.Picbox4.TabStop = False
        '
        'Picbox1
        '
        Me.Picbox1.BackColor = System.Drawing.Color.Transparent
        Me.Picbox1.BackgroundImage = Global.LibraryDatabase.My.Resources.Resources.Harry_Potter_and_the_Chamber_of_Secrets_Cover
        Me.Picbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picbox1.Location = New System.Drawing.Point(175, 124)
        Me.Picbox1.Name = "Picbox1"
        Me.Picbox1.Size = New System.Drawing.Size(108, 142)
        Me.Picbox1.TabIndex = 54
        Me.Picbox1.TabStop = False
        '
        'Timer4
        '
        Me.Timer4.Interval = 3000
        '
        'Timer3
        '
        Me.Timer3.Interval = 3000
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Picbox3
        '
        Me.Picbox3.BackColor = System.Drawing.Color.Transparent
        Me.Picbox3.BackgroundImage = Global.LibraryDatabase.My.Resources.Resources.Hunger_Games_Cover
        Me.Picbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picbox3.Location = New System.Drawing.Point(175, 124)
        Me.Picbox3.Name = "Picbox3"
        Me.Picbox3.Size = New System.Drawing.Size(108, 142)
        Me.Picbox3.TabIndex = 56
        Me.Picbox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.LibraryDatabase.My.Resources.Resources.removed_watermark__first_attempt_cropped
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(51, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(342, 220)
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 42)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Librio"
        '
        'BtnJoin
        '
        Me.BtnJoin.BackColor = System.Drawing.Color.BurlyWood
        Me.BtnJoin.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJoin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnJoin.Location = New System.Drawing.Point(669, 202)
        Me.BtnJoin.Name = "BtnJoin"
        Me.BtnJoin.Size = New System.Drawing.Size(105, 36)
        Me.BtnJoin.TabIndex = 8
        Me.BtnJoin.Text = "Join the Library"
        Me.BtnJoin.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(429, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(429, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(429, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(429, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "First Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(431, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(255, 52)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Not a member? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Join here in one simple step"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 42)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Vista"
        '
        'RbtnEmployee
        '
        Me.RbtnEmployee.AutoSize = True
        Me.RbtnEmployee.BackColor = System.Drawing.Color.Transparent
        Me.RbtnEmployee.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnEmployee.Location = New System.Drawing.Point(513, 51)
        Me.RbtnEmployee.Name = "RbtnEmployee"
        Me.RbtnEmployee.Size = New System.Drawing.Size(71, 17)
        Me.RbtnEmployee.TabIndex = 40
        Me.RbtnEmployee.Text = "Employee"
        Me.RbtnEmployee.UseVisualStyleBackColor = False
        '
        'RbtnMember
        '
        Me.RbtnMember.AutoSize = True
        Me.RbtnMember.BackColor = System.Drawing.Color.Transparent
        Me.RbtnMember.Checked = True
        Me.RbtnMember.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnMember.Location = New System.Drawing.Point(436, 51)
        Me.RbtnMember.Name = "RbtnMember"
        Me.RbtnMember.Size = New System.Drawing.Size(65, 17)
        Me.RbtnMember.TabIndex = 39
        Me.RbtnMember.TabStop = True
        Me.RbtnMember.Text = "Member"
        Me.RbtnMember.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLogin.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.DimGray
        Me.BtnLogin.Location = New System.Drawing.Point(668, 25)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "Sign In"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'TxtpassLogin
        '
        Me.TxtpassLogin.AcceptsTab = True
        Me.TxtpassLogin.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtpassLogin.Location = New System.Drawing.Point(543, 25)
        Me.TxtpassLogin.Name = "TxtpassLogin"
        Me.TxtpassLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtpassLogin.Size = New System.Drawing.Size(100, 21)
        Me.TxtpassLogin.TabIndex = 1
        '
        'TxtEmailLogin
        '
        Me.TxtEmailLogin.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmailLogin.Location = New System.Drawing.Point(436, 25)
        Me.TxtEmailLogin.Name = "TxtEmailLogin"
        Me.TxtEmailLogin.Size = New System.Drawing.Size(100, 21)
        Me.TxtEmailLogin.TabIndex = 0
        Me.TxtEmailLogin.Text = "Email"
        '
        'LibraryMembersBindingSource
        '
        Me.LibraryMembersBindingSource.DataMember = "LibraryMembers"
        Me.LibraryMembersBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtFirst
        '
        Me.TxtFirst.Location = New System.Drawing.Point(432, 152)
        Me.TxtFirst.Name = "TxtFirst"
        Me.TxtFirst.Size = New System.Drawing.Size(211, 20)
        Me.TxtFirst.TabIndex = 3
        '
        'TxtLast
        '
        Me.TxtLast.Location = New System.Drawing.Point(432, 191)
        Me.TxtLast.Name = "TxtLast"
        Me.TxtLast.Size = New System.Drawing.Size(211, 20)
        Me.TxtLast.TabIndex = 4
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(432, 230)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(211, 20)
        Me.TxtEmail.TabIndex = 5
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(432, 269)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(100, 20)
        Me.TxtPass.TabIndex = 6
        '
        'TxtPassconfirm
        '
        Me.TxtPassconfirm.Location = New System.Drawing.Point(543, 269)
        Me.TxtPassconfirm.Name = "TxtPassconfirm"
        Me.TxtPassconfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassconfirm.Size = New System.Drawing.Size(100, 20)
        Me.TxtPassconfirm.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "A library Resource"
        '
        'LibraryMembersTableAdapter
        '
        Me.LibraryMembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckedOutTableAdapter = Me.CheckedOutTableAdapter
        Me.TableAdapterManager.CheckOutHistoryTableAdapter = Me.CheckOutHistoryTableAdapter
        Me.TableAdapterManager.Library_EmployeesTableAdapter = Me.Library_EmployeesTableAdapter
        Me.TableAdapterManager.LibraryMembersTableAdapter = Me.LibraryMembersTableAdapter
        Me.TableAdapterManager.LibraryResourcesTableAdapter = Me.LibraryResourcesTableAdapter
        Me.TableAdapterManager.UpdateOrder = LibraryDatabase.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CheckedOutTableAdapter
        '
        Me.CheckedOutTableAdapter.ClearBeforeFill = True
        '
        'CheckOutHistoryTableAdapter
        '
        Me.CheckOutHistoryTableAdapter.ClearBeforeFill = True
        '
        'Library_EmployeesTableAdapter
        '
        Me.Library_EmployeesTableAdapter.ClearBeforeFill = True
        '
        'LibraryResourcesTableAdapter
        '
        Me.LibraryResourcesTableAdapter.ClearBeforeFill = True
        '
        'LibraryEmployeesBindingSource
        '
        Me.LibraryEmployeesBindingSource.DataMember = "Library Employees"
        Me.LibraryEmployeesBindingSource.DataSource = Me.LibraryDataSet
        '
        'lblblank
        '
        Me.lblblank.AutoSize = True
        Me.lblblank.BackColor = System.Drawing.Color.Transparent
        Me.lblblank.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblblank.Location = New System.Drawing.Point(482, 253)
        Me.lblblank.Name = "lblblank"
        Me.lblblank.Size = New System.Drawing.Size(33, 13)
        Me.lblblank.TabIndex = 66
        Me.lblblank.Text = "Blank"
        '
        'lblWeak
        '
        Me.lblWeak.AutoSize = True
        Me.lblWeak.BackColor = System.Drawing.Color.Transparent
        Me.lblWeak.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeak.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblWeak.Location = New System.Drawing.Point(482, 253)
        Me.lblWeak.Name = "lblWeak"
        Me.lblWeak.Size = New System.Drawing.Size(34, 13)
        Me.lblWeak.TabIndex = 67
        Me.lblWeak.Text = "Weak"
        Me.lblWeak.Visible = False
        '
        'lblMedium
        '
        Me.lblMedium.AutoSize = True
        Me.lblMedium.BackColor = System.Drawing.Color.Transparent
        Me.lblMedium.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedium.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblMedium.Location = New System.Drawing.Point(482, 253)
        Me.lblMedium.Name = "lblMedium"
        Me.lblMedium.Size = New System.Drawing.Size(46, 13)
        Me.lblMedium.TabIndex = 68
        Me.lblMedium.Text = "Medium"
        Me.lblMedium.Visible = False
        '
        'lblStrong
        '
        Me.lblStrong.AutoSize = True
        Me.lblStrong.BackColor = System.Drawing.Color.Transparent
        Me.lblStrong.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrong.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.lblStrong.Location = New System.Drawing.Point(482, 253)
        Me.lblStrong.Name = "lblStrong"
        Me.lblStrong.Size = New System.Drawing.Size(37, 13)
        Me.lblStrong.TabIndex = 69
        Me.lblStrong.Text = "Strong"
        Me.lblStrong.Visible = False
        '
        'lblVeryStrong
        '
        Me.lblVeryStrong.AutoSize = True
        Me.lblVeryStrong.BackColor = System.Drawing.Color.Transparent
        Me.lblVeryStrong.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeryStrong.ForeColor = System.Drawing.Color.Crimson
        Me.lblVeryStrong.Location = New System.Drawing.Point(482, 253)
        Me.lblVeryStrong.Name = "lblVeryStrong"
        Me.lblVeryStrong.Size = New System.Drawing.Size(59, 13)
        Me.lblVeryStrong.TabIndex = 70
        Me.lblVeryStrong.Text = "Very Strong"
        Me.lblVeryStrong.Visible = False
        '
        'Welcome
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LibraryDatabase.My.Resources.Resources.Books_Background_image
        Me.ClientSize = New System.Drawing.Size(797, 368)
        Me.Controls.Add(Me.lblVeryStrong)
        Me.Controls.Add(Me.lblStrong)
        Me.Controls.Add(Me.lblMedium)
        Me.Controls.Add(Me.lblWeak)
        Me.Controls.Add(Me.lblblank)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPassconfirm)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtLast)
        Me.Controls.Add(Me.TxtFirst)
        Me.Controls.Add(Me.picbox2)
        Me.Controls.Add(Me.Picbox4)
        Me.Controls.Add(Me.Picbox1)
        Me.Controls.Add(Me.Picbox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnJoin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RbtnEmployee)
        Me.Controls.Add(Me.RbtnMember)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtpassLogin)
        Me.Controls.Add(Me.TxtEmailLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome!"
        CType(Me.picbox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picbox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picbox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picbox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Picbox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Picbox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Picbox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RbtnEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnMember As System.Windows.Forms.RadioButton
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents TxtpassLogin As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmailLogin As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirst As System.Windows.Forms.TextBox
    Friend WithEvents TxtLast As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassconfirm As System.Windows.Forms.TextBox
    Friend WithEvents BtnJoin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents LibraryMembersBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents LibraryMembersTableAdapter As LibraryDatabase.LibraryDataSetTableAdapters.LibraryMembersTableAdapter
    Public WithEvents TableAdapterManager As LibraryDatabase.LibraryDataSetTableAdapters.TableAdapterManager
    Public WithEvents CheckedOutTableAdapter As LibraryDatabase.LibraryDataSetTableAdapters.CheckedOutTableAdapter
    Public WithEvents CheckOutHistoryTableAdapter As LibraryDatabase.LibraryDataSetTableAdapters.CheckOutHistoryTableAdapter
    Public WithEvents LibraryResourcesTableAdapter As LibraryDatabase.LibraryDataSetTableAdapters.LibraryResourcesTableAdapter
    Public WithEvents LibraryDataSet As LibraryDatabase.LibraryDataSet
    Friend WithEvents LibraryEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Library_EmployeesTableAdapter As LibraryDatabase.LibraryDataSetTableAdapters.Library_EmployeesTableAdapter
    Friend WithEvents lblblank As System.Windows.Forms.Label
    Friend WithEvents lblWeak As System.Windows.Forms.Label
    Friend WithEvents lblMedium As System.Windows.Forms.Label
    Friend WithEvents lblStrong As System.Windows.Forms.Label
    Friend WithEvents lblVeryStrong As System.Windows.Forms.Label

End Class
