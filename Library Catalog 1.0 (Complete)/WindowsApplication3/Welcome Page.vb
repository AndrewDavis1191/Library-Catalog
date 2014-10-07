Public Class Welcome
    Public MemberName As String
    Public MemberID As String
    Public Memberfullname As Object




    Private Sub picbox2_Click(sender As Object, e As EventArgs) Handles picbox2.Click

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim NumberOfRows As Integer = 0
        Dim RowData As Object
        Dim ERowData As Object
        Dim Password As String = String.Empty
        Dim FirstName As String = String.Empty
        Dim LastName As String = String.Empty
        Dim MemberID As Object = String.Empty
        Dim EmployeeID As Object = String.Empty
        Dim EmployeeEmail As Object = String.Empty




        If TxtEmailLogin.Text = String.Empty OrElse TxtpassLogin.Text = String.Empty Then
            MessageBox.Show("Please make sure to fill BOTH boxes")
            Exit Sub
        Else
            Dim Email As String
            Dim arobase As Integer
            Dim dot As Integer

            Email = TxtEmailLogin.Text
            arobase = Email.IndexOf("@")
            If arobase <> -1 Then
                dot = Email.IndexOf(".", arobase)
                If dot = -1 Then
                    MessageBox.Show("invalid email address")
                    TxtEmailLogin.SelectAll()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Not a valid email address")
                TxtEmailLogin.SelectAll()
                Exit Sub
            End If
        End If

        If TxtpassLogin.Text = "" Then
            MessageBox.Show("Please enter password")
            Exit Sub
        End If
        If RbtnMember.Checked = False And RbtnEmployee.Checked = False Then
            MessageBox.Show("Please select a role")
            Exit Sub
        End If
      


        If RbtnEmployee.Checked = True Then
            NumberOfRows = Library_EmployeesTableAdapter.FillByeEmail(LibraryDataSet.Library_Employees, TxtEmailLogin.Text)

            If NumberOfRows = 0 Then
                MessageBox.Show("Email not Found", "", MessageBoxButtons.OK)
                TxtEmailLogin.Clear()
                TxtpassLogin.Clear()


            Else

                If NumberOfRows >= 1 Then

                    ERowData = Library_EmployeesTableAdapter.GetDataByeEmail(TxtEmailLogin.Text)(0) 'the (0) means look in the first place in the collection…
                    EmployeeEmail = ERowData.Email
                    Password = ERowData.Password
                    EmployeeID = ERowData.ID

                    If Password = TxtpassLogin.Text Then
                        MessageBox.Show("Login Successful!")
                        'add hidden items here
                        Bookcatalog.BtnAccount.Hide()
                        Bookcatalog.btnCheckOut.Hide()
                        Bookcatalog.LblmemberWords.Hide()
                        Bookcatalog.BtnemployeeLogoff.Show()
                        Bookcatalog.BtnEmployeeResource.Show()
                        Bookcatalog.LblEmployeeWords.Show()


                        Bookcatalog.Show()
                        Me.Hide()

                        TxtpassLogin.Clear()
                        TxtEmailLogin.Clear()



                    End If

                End If

                End If

            End If


            If RbtnMember.Checked = True Then
                NumberOfRows = LibraryMembersTableAdapter.FillByMEmail(LibraryDataSet.LibraryMembers, TxtEmailLogin.Text)
                ' if not empty



                If NumberOfRows = 0 Then
                    MessageBox.Show("Email not found", "", MessageBoxButtons.OK)
                    TxtEmailLogin.Text = ""
                    TxtpassLogin.Text = ""
                    TxtEmailLogin.Focus()

                Else

                    NumberOfRows = 1
                    LibraryMembersTableAdapter.FillByMEmail(LibraryDataSet.LibraryMembers, TxtEmailLogin.Text)

                    If NumberOfRows = 1 Then

                        RowData = LibraryMembersTableAdapter.GetDataByMEmail(TxtEmailLogin.Text)(0)
                        Password = RowData.Password
                        MemberID = RowData.MemberID

                        If Password = TxtpassLogin.Text Then
                            MessageBox.Show("Login successful")
                            Memberfullname = LibraryMembersTableAdapter.GetDataByMEmail(TxtEmailLogin.Text)(0)
                            MemberName = Memberfullname.FirstName & "" & Memberfullname.LastName
                        MemberAccount.Show()
                        Me.Hide()
                        Bookcatalog.LblEmployeeWords.Hide()
                        Bookcatalog.BtnEmployeeResource.Hide()
                        Bookcatalog.BtnemployeeLogoff.Hide()
                        Bookcatalog.BtnAccount.Show()
                        Bookcatalog.btnCheckOut.Show()
                        Bookcatalog.LblmemberWords.Show()



                        MemberAccount.txtmemberid.Text = MemberID

                        ElseIf NumberOfRows = 0 Then
                            MessageBox.Show("Login unsuccessful")
                            TxtpassLogin.Clear()
                        End If
                    End If
                End If
            End If

    End Sub


    Private Sub LibraryMembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LibraryMembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Library_Employees' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'LibraryDataSet.LibraryMembers' table. You can move, or remove it, as needed.
        Me.LibraryMembersTableAdapter.Fill(Me.LibraryDataSet.LibraryMembers)



    End Sub

    Private Sub BtnJoin_Click(sender As Object, e As EventArgs) Handles BtnJoin.Click
        Dim NumberofRows As Integer
        'These lines ensure that the boxes are filled as required
        If TxtEmail.Text = String.Empty OrElse TxtFirst.Text = String.Empty OrElse _
            TxtLast.Text = String.Empty OrElse TxtPass.Text = String.Empty OrElse TxtPassconfirm.Text = String.Empty Then
            MessageBox.Show("Please make sure to fill ALL the boxes")
            Exit Sub
        Else
            'These lines ensure the proper requirements are met
            Dim Email As String
            Dim arobase As Integer
            Dim dot As Integer

            Email = TxtEmail.Text
            arobase = Email.IndexOf("@")
            If arobase <> -1 Then
                dot = Email.IndexOf(".", arobase)
                If dot = -1 Then
                    MessageBox.Show("invalid email address")
                    TxtEmail.SelectAll()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Not a valid email address")
                TxtEmail.SelectAll()
                Exit Sub
            End If
        End If

        If TxtPass.Text <> TxtPassconfirm.Text Then
            MessageBox.Show("Your passwords don't seem to match!!")
            Exit Sub
        End If

        'Now to add the additional users to the database
        If NumberofRows = 1 Then
            NumberofRows = LibraryMembersTableAdapter.FillByMEmail(LibraryDataSet.LibraryMembers, TxtEmail.Text)
            MessageBox.Show("We're sorry, but the e-mail you chose appears to be in use")
        Else
            LibraryMembersTableAdapter.MInsert("Temp", TxtFirst.Text, TxtLast.Text, Nothing, Nothing, Nothing, Nothing, TxtEmail.Text, TxtPass.Text)
            MessageBox.Show("Your account has been successfully created!")
        End If


        TxtEmailLogin.Focus()
        TxtEmailLogin.Clear()
        TxtEmail.Clear()
        TxtFirst.Clear()
        TxtLast.Clear()
        TxtPass.Clear()
        TxtPassconfirm.Clear()


    End Sub

    Private Sub TxtPassconfirm_TextChanged(sender As Object, e As EventArgs) Handles TxtPassconfirm.TextChanged
        If TxtPassconfirm.AcceptsReturn Then
            BtnJoin.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        picbox2.Show()
        Picbox3.Hide()
        Picbox4.Hide()
        Picbox1.Hide()
        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        picbox2.Hide()
        Picbox3.Show()
        Picbox4.Hide()
        Picbox1.Hide()
        Timer3.Start()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        Picbox3.Hide()
        Picbox4.Show()
        picbox2.Hide()
        Picbox1.Hide()
        Timer4.Start()

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Stop()
        Picbox4.Hide()
        Picbox1.Show()
        picbox2.Hide()
        Picbox3.Hide()
        Timer1.Start()

    End Sub

    Private Sub RbtnEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnEmployee.CheckedChanged

    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged
        Dim password As String

        password = TxtPass.Text




        Dim score As Int32 = 1




        If password.Length < 1 Then


            lblblank.Show()
            lblMedium.Hide()
            lblWeak.Hide()
            lblVeryStrong.Hide()
            lblStrong.Hide()

        End If

        If password.Length < 8 And password.Length > 5 Then
            lblMedium.Show()
            lblblank.Hide()
            lblVeryStrong.Hide()
            lblStrong.Hide()
            lblWeak.Hide()

        End If



        If password.Length < 5 And password.Length >= 1 Then

            lblWeak.Show()
            lblblank.Hide()
            lblVeryStrong.Hide()
            lblStrong.Hide()
            lblMedium.Hide()


        End If



        If password.Length >= 8 And password.Length < 10 Then

            lblStrong.Show()
            lblblank.Hide()
            lblMedium.Hide()
            lblWeak.Hide()
            lblVeryStrong.Hide()


        End If

        If password.Length >= 10 Then

            lblVeryStrong.Show()
            lblblank.Hide()
            lblMedium.Hide()
            lblWeak.Hide()
            lblStrong.Hide()

        End If




    End Sub

End Class


    Enum PasswordScore

        Blank = 0

        VeryWeak = 1

        Weak = 2

        Medium = 3

        Strong = 4

        VeryStrong = 5

    End Enum

