Public Class frmRecord
    Dim I As Integer

    Public Sub UpdateRecord()
        strQuery = "Select * From `studentsinfo` Where `ID` <> '##-####'"
        dgvRecord.Rows.Clear()
        ReaderQuery(strQuery)

        With Reader_
            While .Read
                I = dgvRecord.Rows.Add()
                dgvRecord.Item(0, I).Value = I + 1
                For A = 1 To 13
                    dgvRecord.Item(A, I).Value = .GetValue(A - 1).ToString
                Next
            End While
        End With
    End Sub

    Private Sub frmRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbbCourses.Text = "All"
        cbbYear.Text = "All"
        cbbBlock.Text = "All"
        UpdateRecord()
    End Sub

    Public Function Sort(ByVal Course_ As String, ByVal Year_ As String, ByVal Block_ As String) As String
        If Course_ = "All" And Year_ = "All" And Block_ = "All" Then
            Return "Select * From `studentsinfo` Where `ID` <> '##-####'"
        ElseIf Course_ = "All" And Year_ <> "All" And Block_ <> "All" Then
            Return "Select * From `studentsinfo` where `Year` like '" & Year_ & "' and `Block` like '" & Block_ & "'"

        ElseIf Course_ <> "All" And Year_ = "All" And Block_ <> "All" Then
            Return "Select * From `studentsinfo` where `Course` like '" & Course_ & "' and `Block` like '" & Block_ & "'"

        ElseIf Course_ <> "All" And Year_ <> "All" And Block_ = "All" Then
            Return "Select * From `studentsinfo` where `Course` like '" & Course_ & "' and `Year` like '" & Year_ & "'"

        ElseIf Course_ = "All" And Year_ = "All" And Block_ <> "All" Then
            Return "Select * From `studentsinfo` where `Block` like '" & Block_ & "' and `ID` <> '##-####'"

        ElseIf Course_ <> "All" And Year_ = "All" And Block_ = "All" Then
            Return "Select * From `studentsinfo` where `Course` like '" & Course_ & "'"

        ElseIf Course_ = "All" And Year_ <> "All" And Block_ = "All" Then
            Return "Select * From `studentsinfo` where `Year` like '" & Year_ & "'"
        End If
        Return "Select * From `studentsinfo` where `Course` like '" & Course_ & "' and `Year` like '" & Year_ & "' and `Block` like '" & Block_ & "'"
    End Function

    Private Sub frmRecord_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "College Of Education - Selection") = MsgBoxResult.Yes = True Then
            e.Cancel = False
            Me.Hide()
            frmLogIn.ClrScrn()
            frmLogIn.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub StudentToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        Form_ = New frmAddStudent
        isEdit_ = "0"
        Form_.Show()
    End Sub

    Private Sub txtIDNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDNo.TextChanged
        If txtIDNo.TextLength = 7 Then
            bttnEdit.Enabled = True
            If txtIDNo.Text = "##-####" Then
                dgvRecord.Rows.Clear()
            Else
                dgvRecord.Rows.Clear()
                strQuery = "Select * From `studentsinfo` Where `ID` = '" & txtIDNo.Text & "'"
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        I = dgvRecord.Rows.Add()
                        dgvRecord.Item(0, I).Value = I + 1
                        For A = 1 To 13
                            dgvRecord.Item(A, I).Value = .GetValue(A - 1).ToString
                        Next
                    End While
                End With
            End If
        Else
            bttnEdit.Enabled = False
            UpdateRecord()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Do you want to sign out?", MsgBoxStyle.YesNo, "College Of Education - Student Record") = MsgBoxResult.Yes = True Then
            Me.Hide()
            frmLogIn.ClrScrn()
            frmLogIn.Show()
        End If
    End Sub

    Private Sub bttnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEdit.Click
        Dim Index As Integer
        Dim Index2 As Integer
        Dim FindYear As String = vbNullString

        While Not Index = dgvRecord.Rows.Count
            If Not txtIDNo.Text = dgvRecord.Item(1, Index).Value Then
                MsgBox("ID no. not found!", , "College Of Education - Student Record")
                Index2 = Index2 + 1
            End If
            Index = Index + 1
        End While

        If txtIDNo.Text = vbNullString Or Index2 = dgvRecord.Rows.Count Then
            MsgBox("Student no. is not found or enter a valid student no.", , "College Of Education - Student Record")
        Else
            SearchedID = dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value
            Form_ = New frmOption
            Form_.ShowDialog()
            If Form_.DialogResult = Windows.Forms.DialogResult.Yes Then
                SearchedID = txtIDNo.Text
                isEdit_ = "1"
                Form_ = New frmAddStudent
                Form_.Text = "Edit Student"
                Form_.Show()
            ElseIf Form_.DialogResult = Windows.Forms.DialogResult.No Then
                strQuery = "Delete From `studentsinfo` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `payment1stsem` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `payment2ndsem` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `particulars1stsem` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `particulars2ndsem` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `if1stsemester` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `if2ndsemester` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `fees1stsem` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `fees2ndsem` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `datepaid1stsem` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `datepaid2ndsem` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `cost1stsem` Where `ID` = '" & txtIDNo.Text & "';" & _
                    "Delete From `cost2ndsem` Where `ID` = '" & txtIDNo.Text & "'"

                If MsgBox("Do you want to delete it?", MsgBoxStyle.YesNo, "College Of Education - Student Record") = MsgBoxResult.Yes Then
                    SendQuery2(strQuery, "orgfee1")
                    SendQuery2(strQuery, "orgfee2")
                    SendQuery2(strQuery, "orgfee3")
                    SendQuery(strQuery)
                    MsgBox("Success!, Data deleted.", , "College Of Education - Student Record")
                    UpdateRecord()
                End If

            ElseIf Form_.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ClearTrigs()
                SearchedID = txtIDNo.Text
                strQuery = "Select * from `studentsinfo` Where `ID` = '" & txtIDNo.Text & "'"
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        FindYear = .GetValue(8).ToString
                    End While
                End With
                Year_ = FindYear
                isPassSF_ = "C"
                isPassOF_ = "C"
                isPassCC_ = "B"
                ChangeOrg = "B"
                ChangeYear = "B"
                frmSelection.Show()

            ElseIf Form_.DialogResult = Windows.Forms.DialogResult.OK Then
                ClearTrigs()
                SearchedID = txtIDNo.Text
                strQuery = "Select * from `studentsinfo` Where `ID` = '" & txtIDNo.Text & "'"
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        FindYear = .GetValue(8).ToString
                    End While
                End With
                frmSelection.ClrScrn()
                isPassSF_ = "B"
                isPassOF_ = "B"
                isPassCC_ = "B"
                ChangeYear = "B"
                ChangeOrg = "B"
                frmSelection.Show()
            End If
        End If
    End Sub

    Private Sub dgvRecord_CellDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecord.CellDoubleClick
        Form_ = New frmOption
        Form_.ShowDialog()
        If Form_.DialogResult = Windows.Forms.DialogResult.Yes Then
            SearchedID = dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value
            Form_ = New frmAddStudent
            Form_.Text = "Edit Student"
            isEdit_ = "1"
            Form_.Show()
        ElseIf Form_.DialogResult = Windows.Forms.DialogResult.No Then
            strQuery = "Delete From `cost1stsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `cost2ndsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `fees1stsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `fees2ndsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `datepaid1stsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `datepaid2ndsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `payment1stsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `payment2ndsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `if1stsemester` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `if2ndsemester` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `particulars1stsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `particulars2ndsem` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "';" & _
                       "Delete From `studentsinfo` Where `ID` Like '" & dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value & "'"

            If MsgBox("Do you want to delete it?", MsgBoxStyle.YesNo, "College Of Education - Student Record") = MsgBoxResult.Yes Then
                SendQuery2(strQuery, "orgfee1")
                SendQuery2(strQuery, "orgfee2")
                SendQuery2(strQuery, "orgfee3")
                SendQuery(strQuery)
                MsgBox("Success!, Data deleted.", , "College Of Education - Student Record")
                UpdateRecord()
            End If

        ElseIf Form_.DialogResult = Windows.Forms.DialogResult.Cancel Then
            ClearTrigs()
            SearchedID = dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value
            Year_ = dgvRecord.Item(9, dgvRecord.CurrentCell.RowIndex).Value.ToString
            isPassSF_ = "C"
            isPassOF_ = "C"
            isPassCC_ = "B"
            ChangeOrg = "B"
            ChangeYear = "B"
            frmSelection.Show()
        ElseIf Form_.DialogResult = Windows.Forms.DialogResult.OK Then
            ClearTrigs()
            SearchedID = dgvRecord.Item(1, dgvRecord.CurrentCell.RowIndex).Value
            Year_ = dgvRecord.Item(9, dgvRecord.CurrentCell.RowIndex).Value.ToString
            frmSelection.ClrScrn()
            isPassSF_ = "B"
            isPassOF_ = "B"
            isPassCC_ = "B"
            ChangeOrg = "B"
            ChangeYear = "B"
            frmSelection.Show()
        End If
    End Sub

    Private Sub cbbCourses_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbCourses.SelectedIndexChanged
        strQuery = Sort(cbbCourses.Text, cbbYear.Text, cbbBlock.Text)
        Dim Rows_ As Integer = 0
        dgvRecord.Rows.Clear()
        Try
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    Rows_ = dgvRecord.Rows.Add()
                    dgvRecord.Item(0, Rows_).Value = Rows_ + 1
                    dgvRecord.Item(1, Rows_).Value = .GetValue(0)
                    dgvRecord.Item(2, Rows_).Value = .GetValue(1)
                    dgvRecord.Item(3, Rows_).Value = .GetValue(2)
                    dgvRecord.Item(4, Rows_).Value = .GetValue(3)
                    dgvRecord.Item(5, Rows_).Value = .GetValue(4)
                    dgvRecord.Item(6, Rows_).Value = .GetValue(5)
                    dgvRecord.Item(7, Rows_).Value = .GetValue(6)
                    dgvRecord.Item(8, Rows_).Value = .GetValue(7)
                    dgvRecord.Item(9, Rows_).Value = .GetValue(8)
                    dgvRecord.Item(10, Rows_).Value = .GetValue(9)
                    dgvRecord.Item(11, Rows_).Value = .GetValue(10)
                    dgvRecord.Item(12, Rows_).Value = .GetValue(11)
                    dgvRecord.Item(13, Rows_).Value = .GetValue(12)
                End While
            End With
        Catch ex As Exception
            MsgBox(ex.Message, , "College Of Education - Student Record")
        End Try
    End Sub

    Private Sub cbbYear_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbYear.SelectedIndexChanged
        strQuery = Sort(cbbCourses.Text, cbbYear.Text, cbbBlock.Text)
        Dim Rows_ As Integer = 0
        dgvRecord.Rows.Clear()
        Try
            Dim Numb As Integer
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    Rows_ = dgvRecord.Rows.Add()
                    dgvRecord.Item(0, Rows_).Value = Rows_ + 1
                    For Numb = 0 To 12
                        dgvRecord.Item(Numb + 1, Rows_).Value = .GetValue(Numb)
                    Next
                End While
            End With
        Catch ex As Exception
            MsgBox(ex.Message, , "College Of Education - Student Record")
        End Try
    End Sub

    Private Sub cbbBlock_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbBlock.SelectedIndexChanged
        strQuery = Sort(cbbCourses.Text, cbbYear.Text, cbbBlock.Text)
        Dim Rows_ As Integer = 0
        dgvRecord.Rows.Clear()
        Try
            Dim Numb As Integer
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                        Rows_ = dgvRecord.Rows.Add()
                        dgvRecord.Item(0, Rows_).Value = Rows_ + 1
                        For Numb = 0 To 12
                            dgvRecord.Item(Numb + 1, Rows_).Value = .GetValue(Numb)
                        Next
                End While
            End With
        Catch ex As Exception
            MsgBox(ex.Message, , "College Of Education - Student Record")
        End Try
    End Sub

    Private Sub txtIDNo_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDNo.KeyPress
        If Asc(e.KeyChar) < 58 And Asc(e.KeyChar) > 47 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub TransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionToolStripMenuItem.Click
        ClearTrigs()
        isPassSF_ = "A"
        isPassOF_ = "A"
        isPassCC_ = "A"
        ChangeOrg = "A"
        ChangeYear = "A"
        frmSelection.ClrScrn()
        frmSelection.Show()
    End Sub

    Private Sub ManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagementToolStripMenuItem.Click
        frmAdminPanel.Show()
    End Sub
End Class