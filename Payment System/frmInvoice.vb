Public Class frmInvoice
    Dim A As Integer = 1
    Dim B As Integer = 1
    Public Change As Integer = 0
    Public TotalAmount1 As Integer = 0
    Dim Label_ As Integer = 0
    Dim Fee(39) As String
    Dim Fees(39) As String
    Dim IfChecker As String = vbNullString
    Dim OrgDesc As String = vbNullString

    Public Sub ClrScrn()
        txtIdNo.Clear()
        txtName.Clear()
        txtReceived.Clear()
        txtChange.Clear()
        listCollection.Items.Clear()
        rbttn1stSem.Checked = False
        rbttn2ndSem.Checked = False
        lblTotalAmount.Text = ""
        dgvInvoice.Rows.Clear()
    End Sub

    Private Sub frmInvoice_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "College Of Education - Transaction") = MsgBoxResult.Yes = True Then
            ClrScrn()
            ClearTrigs()
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub txtIdNo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdNo.TextChanged
        If txtIdNo.TextLength = 7 Then
            Try
                strQuery = "Select * From `studentsinfo` Where `ID` = '" & txtIdNo.Text & "'"
                ReaderQuery(strQuery)

                With Reader_
                    Dim Name As String
                    While .Read
                        Name = .GetValue(1) + "," + " " + .GetValue(2) + " " + .GetValue(3) + " " + .GetValue(4)
                        txtName.Text = Name.ToString
                    End While
                End With
            Catch ex As Exception
            End Try
        ElseIf Not txtIdNo.TextLength = 7 Then
            txtName.Clear()
        End If
    End Sub

    Private Sub rbttn1stSem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbttn1stSem.CheckedChanged
        'To load listcollection items
        Dim ID As String = vbNullString

        If Trigger = "A" Then
            If Year_ = "1st" Then
                ID = "##-###1"
            ElseIf Year_ = "2nd" Then
                ID = "##-###2"
            ElseIf Year_ = "3rd" Then
                ID = "##-###3"
            ElseIf Year_ = "4th" Then
                ID = "##-###4"
            ElseIf Year_ = "5th" Then
                ID = "##-###5"
            End If

        ElseIf Trigger = "B" Then
            If Organization_ = "GENES ORGANIZATION" Then
                ID = "##-##GC"
            ElseIf Organization_ = "SIGMA" Then
                ID = "##-##SI"
            ElseIf Organization_ = "FYE" Then
                ID = "##-##F1"
            ElseIf Organization_ = "TEATRO BUGHAW" Then
                ID = "##-##TB"
            ElseIf Organization_ = "FAITH EDUCATORS" Then
                ID = "##-##FA"
            ElseIf Organization_ = "MORSEL" Then
                ID = "##-##MO"
            ElseIf Organization_ = "NOMADSS" Then
                ID = "##-##NO"
            ElseIf Organization_ = "AFEMS" Then
                ID = "##-##AF"
            ElseIf Organization_ = "KAMFIL" Then
                ID = "##-##KA"
            ElseIf Organization_ = "BYI" Then
                ID = "##-##BY"
            ElseIf Organization_ = "CCGI" Then
                ID = "##-##CC"
            End If
        End If
        lblTotalAmount.Text = ""
        lblSemester.Text = "1st"
        dgvInvoice.Rows.Clear()
        listCollection.Items.Clear()

        If rbttn1stSem.Checked = True Then

            If Trigger = "A" Then
                strQuery = "Select * From `fees1stsem` Where `ID` = '" & ID.ToString & "'"
                ReaderQuery(strQuery)
                With Reader_
                    While .Read()
                        While Not A = 41
                            listCollection.Items.Add(.GetValue(A))
                            A = A + 1
                        End While
                    End While
                End With
                A = 1
                txtReceived.Clear()
                txtChange.Clear()
                TotalAmount1 = 0

            ElseIf Trigger = "B" Then

                If IfChecker = "1" Then
                    OrgDesc = "orgfee1"
                ElseIf IfChecker = "2" Then
                    OrgDesc = "orgfee2"
                ElseIf IfChecker = "3" Then
                    OrgDesc = "orgfee3"
                End If

                strQuery = "Select * From `fees1stsem` Where `ID` = '" & ID.ToString & "'"
                ReaderQuery2(strQuery, OrgDesc)
                With Reader_2
                    While .Read()
                        While Not A = 41
                            listCollection.Items.Add(.GetValue(A))
                            A = A + 1
                        End While
                    End While
                End With
                A = 1
                txtReceived.Clear()
                txtChange.Clear()
                TotalAmount1 = 0

            End If
        End If


    End Sub

    Private Sub rbttn2ndSem_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbttn2ndSem.CheckedChanged

        Dim ID As String = vbNullString

        If Trigger = "A" Then
            If Year_ = "1st" Then
                ID = "##-###1"
            ElseIf Year_ = "2nd" Then
                ID = "##-###2"
            ElseIf Year_ = "3rd" Then
                ID = "##-###3"
            ElseIf Year_ = "4th" Then
                ID = "##-###4"
            ElseIf Year_ = "5th" Then
                ID = "##-###5"
            End If

        ElseIf Trigger = "B" Then
            If Organization_ = "GENES ORGANIZATION" Then
                ID = "##-##GC"
            ElseIf Organization_ = "SIGMA" Then
                ID = "##-##SI"
            ElseIf Organization_ = "FYE" Then
                ID = "##-##F1"
            ElseIf Organization_ = "TEATRO BUGHAW" Then
                ID = "##-##TB"
            ElseIf Organization_ = "FAITH EDUCATORS" Then
                ID = "##-##FA"
            ElseIf Organization_ = "MORSEL" Then
                ID = "##-##MO"
            ElseIf Organization_ = "NOMADSS" Then
                ID = "##-##NO"
            ElseIf Organization_ = "AFEMS" Then
                ID = "##-##AF"
            ElseIf Organization_ = "KAMFIL" Then
                ID = "##-##KA"
            ElseIf Organization_ = "BYI" Then
                ID = "##-##BY"
            ElseIf Organization_ = "CCGI" Then
                ID = "##-##CC"
                End If
        End If
        lblTotalAmount.Text = ""
        lblSemester.Text = "2nd"
        dgvInvoice.Rows.Clear()
        listCollection.Items.Clear()


        If rbttn2ndSem.Checked = True Then
            If Trigger = "A" Then
                strQuery = "Select * From `fees2ndsem` Where `ID` = '" & ID.ToString & "'"
                ReaderQuery(strQuery)
                With Reader_
                    While .Read()
                        While Not B = 41
                            listCollection.Items.Add(.GetValue(B))
                            B = B + 1
                        End While
                    End While
                End With
                B = 1
                txtReceived.Clear()
                txtChange.Clear()
                TotalAmount1 = 0

            ElseIf Trigger = "B" Then

                If IfChecker = "1" Then
                    OrgDesc = "orgfee1"
                ElseIf IfChecker = "2" Then
                    OrgDesc = "orgfee2"
                ElseIf IfChecker = "3" Then
                    OrgDesc = "orgfee3"
                End If

                strQuery = "Select * From `fees2ndsem` Where `ID` = '" & ID.ToString & "'"
                ReaderQuery2(strQuery, OrgDesc)
                With Reader_2
                    While .Read()
                        While Not B = 41
                            listCollection.Items.Add(.GetValue(B))
                            B = B + 1
                        End While
                    End While
                End With
            End If
            B = 1
            txtReceived.Clear()
            txtChange.Clear()
            TotalAmount1 = 0
        End If
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim No As Integer = listCollection.SelectedIndex + 1
        Dim Fees_ As String = vbNullString
        Dim Cost_ As String = vbNullString
        Dim Particulars_ As String = vbNullString
        Dim Payment_ As String = vbNullString

        Dim ID As String = vbNullString

        If Trigger = "A" Then
            If Year_ = "1st" Then
                ID = "##-###1"
            ElseIf Year_ = "2nd" Then
                ID = "##-###2"
            ElseIf Year_ = "3rd" Then
                ID = "##-###3"
            ElseIf Year_ = "4th" Then
                ID = "##-###4"
            ElseIf Year_ = "5th" Then
                ID = "##-###5"
            End If

        ElseIf Trigger = "B" Then
            If Organization_ = "GENES ORGANIZATION" Then
                ID = "##-##GC"
            ElseIf Organization_ = "SIGMA" Then
                ID = "##-##SI"
            ElseIf Organization_ = "FYE" Then
                ID = "##-##F1"
            ElseIf Organization_ = "TEATRO BUGHAW" Then
                ID = "##-##TB"
            ElseIf Organization_ = "FAITH EDUCATORS" Then
                ID = "##-##FA"
            ElseIf Organization_ = "MORSEL" Then
                ID = "##-##MO"
            ElseIf Organization_ = "NOMADSS" Then
                ID = "##-##NO"
            ElseIf Organization_ = "AFEMS" Then
                ID = "##-##AF"
            ElseIf Organization_ = "KAMFIL" Then
                ID = "##-##KA"
            ElseIf Organization_ = "BYI" Then
                ID = "##-##BY"
            ElseIf Organization_ = "CCGI" Then
                ID = "##-##CC"
            End If
        End If

        If rbttn1stSem.Checked = True Then
            Fees_ = "fees1stsem"
            Cost_ = "cost1stsem"
            Particulars_ = "particulars1stsem"
            Payment_ = "payment1stsem"

        ElseIf rbttn2ndSem.Checked = True Then
            Fees_ = "fees2ndsem"
            Cost_ = "cost2ndsem"
            Particulars_ = "particulars2ndsem"
            Payment_ = "payment2ndsem"
        End If

        If listCollection.SelectedIndex < 0 Then
            MsgBox("No transaction is selected", , "College Of Education - Transaction")
        Else
            If Trigger = "A" Then
                strQuery = "Select * From `" & Fees_ & "` Where `ID` = '" & ID & "'"
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        A = dgvInvoice.Rows.Add
                        dgvInvoice.Item(0, A).Value = No
                        dgvInvoice.Item(1, A).Value = .GetValue(No)
                    End While
                End With

            ElseIf Trigger = "B" Then

                If IfChecker = "1" Then
                    OrgDesc = "orgfee1"
                ElseIf IfChecker = "2" Then
                    OrgDesc = "orgfee2"
                ElseIf IfChecker = "3" Then
                    OrgDesc = "orgfee3"
                End If

                strQuery = "Select * From `" & Fees_ & "` Where `ID` = '" & ID & "'"
                ReaderQuery2(strQuery, OrgDesc)
                With Reader_2
                    While .Read
                        A = dgvInvoice.Rows.Add
                        dgvInvoice.Item(0, A).Value = No
                        dgvInvoice.Item(1, A).Value = .GetValue(No)
                    End While
                End With
            End If



            If Trigger = "A" Then

                strQuery = "Select * From `" & Particulars_ & "` Where `ID` = '" & ID & "'"
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        dgvInvoice.Item(2, A).Value = .GetValue(No)
                    End While
                End With
            ElseIf Trigger = "B" Then

                If IfChecker = "1" Then
                    OrgDesc = "orgfee1"
                ElseIf IfChecker = "2" Then
                    OrgDesc = "orgfee2"
                ElseIf IfChecker = "3" Then
                    OrgDesc = "orgfee3"
                End If

                strQuery = "Select * From `" & Particulars_ & "` Where `ID` = '" & ID & "'"
                ReaderQuery2(strQuery, OrgDesc)
                With Reader_2
                    While .Read
                        dgvInvoice.Item(2, A).Value = .GetValue(No)
                    End While
                End With
            End If

            Try

                If Trigger = "A" Then
                    strQuery = "Select * from `" & Cost_ & "` Where `ID` Like '" & txtIdNo.Text & "'"
                    ReaderQuery(strQuery)
                    With Reader_
                        While .Read
                            Fee(0) = .GetValue(1).ToString
                            Fee(1) = .GetValue(2).ToString
                            Fee(2) = .GetValue(3).ToString
                            Fee(3) = .GetValue(4).ToString
                            Fee(4) = .GetValue(5).ToString
                            Fee(5) = .GetValue(6).ToString
                            Fee(6) = .GetValue(7).ToString
                            Fee(7) = .GetValue(8).ToString
                            Fee(8) = .GetValue(9).ToString
                            Fee(9) = .GetValue(10).ToString
                            Fee(10) = .GetValue(11).ToString
                            Fee(11) = .GetValue(12).ToString
                            Fee(12) = .GetValue(13).ToString
                            Fee(13) = .GetValue(14).ToString
                            Fee(14) = .GetValue(15).ToString
                            Fee(15) = .GetValue(16).ToString
                            Fee(16) = .GetValue(17).ToString
                            Fee(17) = .GetValue(18).ToString
                            Fee(18) = .GetValue(19).ToString
                            Fee(19) = .GetValue(20).ToString
                            Fee(20) = .GetValue(21).ToString
                            Fee(21) = .GetValue(22).ToString
                            Fee(22) = .GetValue(23).ToString
                            Fee(23) = .GetValue(24).ToString
                            Fee(24) = .GetValue(25).ToString
                            Fee(25) = .GetValue(26).ToString
                            Fee(26) = .GetValue(27).ToString
                            Fee(27) = .GetValue(28).ToString
                            Fee(28) = .GetValue(29).ToString
                            Fee(29) = .GetValue(30).ToString
                            Fee(30) = .GetValue(31).ToString
                            Fee(31) = .GetValue(32).ToString
                            Fee(32) = .GetValue(33).ToString
                            Fee(33) = .GetValue(34).ToString
                            Fee(34) = .GetValue(35).ToString
                            Fee(35) = .GetValue(36).ToString
                            Fee(36) = .GetValue(37).ToString
                            Fee(37) = .GetValue(38).ToString
                            Fee(38) = .GetValue(39).ToString
                            Fee(39) = .GetValue(40).ToString
                        End While
                    End With

                ElseIf Trigger = "B" Then

                    If IfChecker = "1" Then
                        OrgDesc = "orgfee1"
                    ElseIf IfChecker = "2" Then
                        OrgDesc = "orgfee2"
                    ElseIf IfChecker = "3" Then
                        OrgDesc = "orgfee3"
                    End If

                    strQuery = "Select * from `" & Cost_ & "` Where `ID` Like '" & txtIdNo.Text & "'"
                    ReaderQuery2(strQuery, OrgDesc)
                    With Reader_2
                        While .Read
                            Fee(0) = .GetValue(1).ToString
                            Fee(1) = .GetValue(2).ToString
                            Fee(2) = .GetValue(3).ToString
                            Fee(3) = .GetValue(4).ToString
                            Fee(4) = .GetValue(5).ToString
                            Fee(5) = .GetValue(6).ToString
                            Fee(6) = .GetValue(7).ToString
                            Fee(7) = .GetValue(8).ToString
                            Fee(8) = .GetValue(9).ToString
                            Fee(9) = .GetValue(10).ToString
                            Fee(10) = .GetValue(11).ToString
                            Fee(11) = .GetValue(12).ToString
                            Fee(12) = .GetValue(13).ToString
                            Fee(13) = .GetValue(14).ToString
                            Fee(14) = .GetValue(15).ToString
                            Fee(15) = .GetValue(16).ToString
                            Fee(16) = .GetValue(17).ToString
                            Fee(17) = .GetValue(18).ToString
                            Fee(18) = .GetValue(19).ToString
                            Fee(19) = .GetValue(20).ToString
                            Fee(20) = .GetValue(21).ToString
                            Fee(21) = .GetValue(22).ToString
                            Fee(22) = .GetValue(23).ToString
                            Fee(23) = .GetValue(24).ToString
                            Fee(24) = .GetValue(25).ToString
                            Fee(25) = .GetValue(26).ToString
                            Fee(26) = .GetValue(27).ToString
                            Fee(27) = .GetValue(28).ToString
                            Fee(28) = .GetValue(29).ToString
                            Fee(29) = .GetValue(30).ToString
                            Fee(30) = .GetValue(31).ToString
                            Fee(31) = .GetValue(32).ToString
                            Fee(32) = .GetValue(33).ToString
                            Fee(33) = .GetValue(34).ToString
                            Fee(34) = .GetValue(35).ToString
                            Fee(35) = .GetValue(36).ToString
                            Fee(36) = .GetValue(37).ToString
                            Fee(37) = .GetValue(38).ToString
                            Fee(38) = .GetValue(39).ToString
                            Fee(39) = .GetValue(40).ToString
                        End While
                    End With
                End If
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            Try
                If Trigger = "A" Then

                    strQuery = "Select * from `" & Payment_ & "` Where `ID` Like '" & txtIdNo.Text & "'"
                    ReaderQuery(strQuery)
                    With Reader_
                        While .Read
                            Fees(0) = .GetValue(1).ToString
                            Fees(1) = .GetValue(2).ToString
                            Fees(2) = .GetValue(3).ToString
                            Fees(3) = .GetValue(4).ToString
                            Fees(4) = .GetValue(5).ToString
                            Fees(5) = .GetValue(6).ToString
                            Fees(6) = .GetValue(7).ToString
                            Fees(7) = .GetValue(8).ToString
                            Fees(8) = .GetValue(9).ToString
                            Fees(9) = .GetValue(10).ToString
                            Fees(10) = .GetValue(11).ToString
                            Fees(11) = .GetValue(12).ToString
                            Fees(12) = .GetValue(13).ToString
                            Fees(13) = .GetValue(14).ToString
                            Fees(14) = .GetValue(15).ToString
                            Fees(15) = .GetValue(16).ToString
                            Fees(16) = .GetValue(17).ToString
                            Fees(17) = .GetValue(18).ToString
                            Fees(18) = .GetValue(19).ToString
                            Fees(19) = .GetValue(20).ToString
                            Fees(20) = .GetValue(21).ToString
                            Fees(21) = .GetValue(22).ToString
                            Fees(22) = .GetValue(23).ToString
                            Fees(23) = .GetValue(24).ToString
                            Fees(24) = .GetValue(25).ToString
                            Fees(25) = .GetValue(26).ToString
                            Fees(26) = .GetValue(27).ToString
                            Fees(27) = .GetValue(28).ToString
                            Fees(28) = .GetValue(29).ToString
                            Fees(29) = .GetValue(30).ToString
                            Fees(30) = .GetValue(31).ToString
                            Fees(31) = .GetValue(32).ToString
                            Fees(32) = .GetValue(33).ToString
                            Fees(33) = .GetValue(34).ToString
                            Fees(34) = .GetValue(35).ToString
                            Fees(35) = .GetValue(36).ToString
                            Fees(36) = .GetValue(37).ToString
                            Fees(37) = .GetValue(38).ToString
                            Fees(38) = .GetValue(39).ToString
                            Fees(39) = .GetValue(40).ToString
                        End While
                    End With

                ElseIf Trigger = "B" Then

                    If IfChecker = "1" Then
                        OrgDesc = "orgfee1"
                    ElseIf IfChecker = "2" Then
                        OrgDesc = "orgfee2"
                    ElseIf IfChecker = "3" Then
                        OrgDesc = "orgfee3"
                    End If

                    strQuery = "Select * from `" & Payment_ & "` Where `ID` Like '" & txtIdNo.Text & "'"
                    ReaderQuery2(strQuery, OrgDesc)
                    With Reader_2
                        While .Read
                            Fees(0) = .GetValue(1).ToString
                            Fees(1) = .GetValue(2).ToString
                            Fees(2) = .GetValue(3).ToString
                            Fees(3) = .GetValue(4).ToString
                            Fees(4) = .GetValue(5).ToString
                            Fees(5) = .GetValue(6).ToString
                            Fees(6) = .GetValue(7).ToString
                            Fees(7) = .GetValue(8).ToString
                            Fees(8) = .GetValue(9).ToString
                            Fees(9) = .GetValue(10).ToString
                            Fees(10) = .GetValue(11).ToString
                            Fees(11) = .GetValue(12).ToString
                            Fees(12) = .GetValue(13).ToString
                            Fees(13) = .GetValue(14).ToString
                            Fees(14) = .GetValue(15).ToString
                            Fees(15) = .GetValue(16).ToString
                            Fees(16) = .GetValue(17).ToString
                            Fees(17) = .GetValue(18).ToString
                            Fees(18) = .GetValue(19).ToString
                            Fees(19) = .GetValue(20).ToString
                            Fees(20) = .GetValue(21).ToString
                            Fees(21) = .GetValue(22).ToString
                            Fees(22) = .GetValue(23).ToString
                            Fees(23) = .GetValue(24).ToString
                            Fees(24) = .GetValue(25).ToString
                            Fees(25) = .GetValue(26).ToString
                            Fees(26) = .GetValue(27).ToString
                            Fees(27) = .GetValue(28).ToString
                            Fees(28) = .GetValue(29).ToString
                            Fees(29) = .GetValue(30).ToString
                            Fees(30) = .GetValue(31).ToString
                            Fees(31) = .GetValue(32).ToString
                            Fees(32) = .GetValue(33).ToString
                            Fees(33) = .GetValue(34).ToString
                            Fees(34) = .GetValue(35).ToString
                            Fees(35) = .GetValue(36).ToString
                            Fees(36) = .GetValue(37).ToString
                            Fees(37) = .GetValue(38).ToString
                            Fees(38) = .GetValue(39).ToString
                            Fees(39) = .GetValue(40).ToString
                        End While
                    End With
                End If

            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try


            Dim CheckOrg(2) As String
            strQuery = "Select * From `studentsinfo` Where `ID` = '" & txtIdNo.Text & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    CheckOrg(0) = .GetValue(10).ToString
                    CheckOrg(1) = .GetValue(11).ToString
                    CheckOrg(2) = .GetValue(12).ToString
                End While
            End With

            If CheckOrg(0) = Organization_ Then
                IfChecker = "1"
            ElseIf CheckOrg(1) = Organization_ Then
                IfChecker = "2"
            ElseIf CheckOrg(2) = Organization_ Then
                IfChecker = "3"
            End If

            Try
                If Not Fee(listCollection.SelectedIndex) = Fees(listCollection.SelectedIndex) Then

                    If Trigger = "A" Then

                        strQuery = "Select * From `" & Cost_ & "` Where `ID` = '" & txtIdNo.Text & "'"
                        ReaderQuery(strQuery)
                        With Reader_
                            While .Read
                                dgvInvoice.Item(3, A).Value = .GetValue(No)
                                TotalAmount1 = TotalAmount1 + .GetValue(No)
                            End While
                            lblTotalAmount.Text = TotalAmount1.ToString
                        End With

                    ElseIf Trigger = "B" Then

                        If IfChecker = "1" Then
                            OrgDesc = "orgfee1"
                        ElseIf IfChecker = "2" Then
                            OrgDesc = "orgfee2"
                        ElseIf IfChecker = "3" Then
                            OrgDesc = "orgfee3"
                        End If

                        strQuery = "Select * From `" & Cost_ & "` Where `ID` = '" & txtIdNo.Text & "'"
                        ReaderQuery2(strQuery, OrgDesc)
                        With Reader_2
                            While .Read
                                dgvInvoice.Item(3, A).Value = .GetValue(No)
                                TotalAmount1 = TotalAmount1 + .GetValue(No)
                            End While
                            lblTotalAmount.Text = TotalAmount1.ToString
                        End With
                    Else
                        dgvInvoice.Item(3, A).Value = vbNullString
                    End If
                End If

                If dgvInvoice.Item(3, A).Value = vbNullString Then
                    MsgBox("Payment is already paid.")
                    dgvInvoice.Rows.Clear()
                    TotalAmount1 = 0
                    lblTotalAmount.Text = vbNullString
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnRemove_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        'Dim UpdateAmount As Integer
        If MsgBox("Do you want to delete it?", MsgBoxStyle.YesNo, "College Of Education - Transaction") = MsgBoxResult.Yes Then
            Try
                lblTotalAmount.Text = Val(lblTotalAmount.Text) - dgvInvoice.Item(3, dgvInvoice.CurrentCell.RowIndex).Value
                Dim No As Integer = dgvInvoice.CurrentCell.RowIndex
                Dim A As DataGridViewRow = dgvInvoice.Rows(No)
                dgvInvoice.Rows.Remove(A)
                TotalAmount1 = 0
                txtReceived.Clear()
                txtChange.Clear()
            Catch ex As Exception

            End Try
            
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        ClrScrn()
        frmRecord.Show()
    End Sub

    Private Sub txtReceived_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceived.TextChanged
        If txtReceived.TextLength = 0 Then
            txtChange.Clear()
        ElseIf txtReceived.Text = "0" Or Val(txtReceived.Text) < TotalAmount1 Then
            txtChange.Text = "0"
        Else
            Change = Val(txtReceived.Text) - TotalAmount1
            txtChange.Text = Change.ToString
        End If
    End Sub

    Private Sub btnProcess_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim Index As Integer
        Dim DatePaid_ As String = vbNullString
        Dim Payment_ As String = vbNullString
        Dim If_ As String = vbNullString

        If rbttn1stSem.Checked = True Then
            Payment_ = "payment1stsem"
            DatePaid_ = "datepaid1stsem"
            If_ = "if1stsemester"

        ElseIf rbttn2ndSem.Checked = True Then
            Payment_ = "payment2ndsem"
            DatePaid_ = "datepaid2ndsem"
            If_ = "if2ndsemester"
        End If

        Try
            If Trigger = "A" Then
                If dgvInvoice.Rows.Count > 1 Then
                    If Val(lblTotalAmount.Text) > Val(txtReceived.Text) Then
                        MsgBox("Error!, Amount received is less than the total amount. Please pay in full.", , "College Of Education - Transaction")
                    Else
                        If MsgBox("Do you want to processed payment?", MsgBoxStyle.YesNo, "College Of Education - Transaction") = MsgBoxResult.Yes Then
                            While Not Index = dgvInvoice.Rows.Count
                                strQuery = "Update `" & Payment_ & "` Set `" & dgvInvoice.Item(0, Index).Value & "` = '" & dgvInvoice.Item(3, Index).Value & "' Where `ID` = '" & txtIdNo.Text & "';" & _
                                        "Update `" & DatePaid_ & "` Set `" & dgvInvoice.Item(0, Index).Value & "` = '" & dtpDate.Text & "' Where `ID` = '" & txtIdNo.Text & "';" & _
                                       "Update `" & If_ & "` Set `" & dgvInvoice.Item(0, Index).Value & "` = '1' Where `ID` = '" & txtIdNo.Text & "'"
                                    SendQuery(strQuery)
                                    Index = Index + 1
                            End While
                            MsgBox("Payment proccessed.", , "College Of Education - Transaction")
                            ClrScrn()
                            txtIdNo.Text = SearchedID
                        End If
                    End If

                ElseIf dgvInvoice.Rows.Count = 1 Then
                    If Val(lblTotalAmount.Text) > Val(txtReceived.Text) Then
                        MsgBox("Error!, Amount received is less the total amount. Please pay in full.", , "College Of Education - Transaction")
                    Else
                        If MsgBox("Do you want to processed payment?", MsgBoxStyle.YesNo, "College Of Education - Transaction") = MsgBoxResult.Yes Then
                            Dim Col_ As Integer
                            Col_ = dgvInvoice.Item(0, Index).Value
                            strQuery = "Update `" & Payment_ & "` Set `" & Col_ & "` = '" & dgvInvoice.Item(3, Index).Value & "' Where `ID` = '" & txtIdNo.Text & "';" & _
                                    "Update `" & DatePaid_ & "` Set `" & Col_ & "` = '" & dtpDate.Text & "' Where `ID` = '" & txtIdNo.Text & "';" & _
                                   "Update `" & If_ & "` Set `" & Col_ & "` = '1' Where `ID` = '" & txtIdNo.Text & "'"
                                SendQuery(strQuery)
                                MsgBox("Payment proccessed.", , "College Of Education - Transaction")
                                ClrScrn()
                                txtIdNo.Text = SearchedID
                            End If
                    End If
                End If
                'BREAK LINE

            ElseIf Trigger = "B" Then

                If IfChecker = "1" Then
                    OrgDesc = "orgfee1"
                ElseIf IfChecker = "2" Then
                    OrgDesc = "orgfee2"
                ElseIf IfChecker = "3" Then
                    OrgDesc = "orgfee3"
                End If

                If dgvInvoice.Rows.Count > 1 Then
                    If Val(lblTotalAmount.Text) > Val(txtReceived.Text) Then
                        MsgBox("Error!, Amount received is less than the total amount. Please pay in full.", , "College Of Education - Transaction")
                    Else
                        If MsgBox("Do you want to processed payment?", MsgBoxStyle.YesNo, "College Of Education - Transaction") = MsgBoxResult.Yes Then
                            While Not Index = dgvInvoice.Rows.Count
                                strQuery = "Update `" & Payment_ & "` Set `" & dgvInvoice.Item(0, Index).Value & "` = '" & dgvInvoice.Item(3, Index).Value & "' Where `ID` = '" & txtIdNo.Text & "' And `Organization 1` = '" & Organization_ & "' Or `Organization 2` = '" & Organization_ & "' Or `Organization 3` = '" & Organization_ & "';" & _
                                        "Update `" & DatePaid_ & "` Set `" & dgvInvoice.Item(0, Index).Value & "` = '" & dtpDate.Text & "' Where `ID` = '" & txtIdNo.Text & "'  And `Organization 1` = '" & Organization_ & "' Or `Organization 2` = '" & Organization_ & "' Or `Organization 3` = '" & Organization_ & "';" & _
                                       "Update `" & If_ & "` Set `" & dgvInvoice.Item(0, Index).Value & "` = '1' Where `ID` = '" & txtIdNo.Text & "'  And `Organization 1` = '" & Organization_ & "' Or `Organization 2` = '" & Organization_ & "' Or `Organization 3` = '" & Organization_ & "'"
                                SendQuery2(strQuery, OrgDesc)
                                Index = Index + 1
                            End While
                            MsgBox("Payment proccessed.", , "College Of Education - Transaction")
                            ClrScrn()
                            txtIdNo.Text = SearchedID
                        End If
                    End If

                ElseIf dgvInvoice.Rows.Count = 1 Then

                    If IfChecker = "1" Then
                        OrgDesc = "orgfee1"
                    ElseIf IfChecker = "2" Then
                        OrgDesc = "orgfee2"
                    ElseIf IfChecker = "3" Then
                        OrgDesc = "orgfee3"
                    End If

                    If Val(lblTotalAmount.Text) > Val(txtReceived.Text) Then
                        MsgBox("Error!, Amount received is less the total amount. Please pay in full.", , "College Of Education - Transaction")
                    Else
                        If MsgBox("Do you want to processed payment?", MsgBoxStyle.YesNo, "College Of Education - Transaction") = MsgBoxResult.Yes Then
                            Dim Col_ As Integer
                            Col_ = dgvInvoice.Item(0, Index).Value
                            strQuery = "Update `" & Payment_ & "` Set `" & Col_ & "` = '" & dgvInvoice.Item(3, Index).Value & "' Where `ID` = '" & txtIdNo.Text & "'  And `Organization 1` = '" & Organization_ & "' Or `Organization 2` = '" & Organization_ & "' Or `Organization 3` = '" & Organization_ & "';" & _
                                    "Update `" & DatePaid_ & "` Set `" & Col_ & "` = '" & dtpDate.Text & "' Where `ID` = '" & txtIdNo.Text & "'  And `Organization 1` = '" & Organization_ & "' Or `Organization 2` = '" & Organization_ & "' Or `Organization 3` = '" & Organization_ & "';" & _
                                   "Update `" & If_ & "` Set `" & Col_ & "` = '1' Where `ID` = '" & txtIdNo.Text & "'  And `Organization 1` = '" & Organization_ & "' Or `Organization 2` = '" & Organization_ & "' Or `Organization 3` = '" & Organization_ & "'"
                            SendQuery2(strQuery, OrgDesc)
                            MsgBox("Payment proccessed.", , "College Of Education - Transaction")
                            ClrScrn()
                            txtIdNo.Text = SearchedID
                        End If
                    End If
                End If
            Else
                MsgBox("Please select a semester and fee.", , "College Of Education - Transaction")
            End If

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub txtIdNo_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdNo.KeyPress
        If Asc(e.KeyChar) < 58 And Asc(e.KeyChar) > 47 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtReceived_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReceived.KeyPress
        If Asc(e.KeyChar) < 58 And Asc(e.KeyChar) > 46 Or Asc(e.KeyChar) = 8 Then
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtChange_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChange.KeyPress
        If Asc(e.KeyChar) < 58 And Asc(e.KeyChar) > 47 Or Asc(e.KeyChar) = 8 Then
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub frmInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CheckOrg(2) As String

        If Trigger = "A" Then
            lblOrgName.Text = "Year: " + Year_
        ElseIf Trigger = "B" Then
            lblOrgName.Text = "Org.: " + Organization_
        End If

        If isInvoice_ = 1 Then
            txtIdNo.Text = SearchedID
        ElseIf isInvoice_ = 0 Then
            ClrScrn()
        End If

        If Trigger = "B" And ChangeOrg = "B" Then
            strQuery = "Select * From `studentsinfo` Where `ID` = '" & txtIdNo.Text & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    CheckOrg(0) = .GetValue(10).ToString
                    CheckOrg(1) = .GetValue(11).ToString
                    CheckOrg(2) = .GetValue(12).ToString
                End While
            End With

            If CheckOrg(0) = Organization_ Then
                MsgBox("Organization confirmed.", , "College Of Education - Transaction")
                IfChecker = "1"
            ElseIf CheckOrg(1) = Organization_ Then
                MsgBox("Organization confirmed.", , "College Of Education - Transaction")
                IfChecker = "2"
            ElseIf CheckOrg(2) = Organization_ Then
                MsgBox("Organization confirmed.", , "College Of Education - Transaction")
                IfChecker = "3"
            Else
                MsgBox("No organization found! Please enter correct data.", , "College Of Education - Transaction")
            End If
        End If
    End Sub
End Class