Public Class frmAddStudent

    Dim Fee(39) As String
    Dim Fee1(39) As String
    Dim Cost(39) As String
    Dim Cost1(39) As String
    Dim Particulars(39) As String
    Dim Particulars1(39) As String

    Dim OrgFee2(39) As String
    Dim OrgFee12(39) As String
    Dim OrgCost2(39) As String
    Dim OrgCost12(39) As String
    Dim OrgParticulars2(39) As String
    Dim OrgParticulars12(39) As String

    Dim OrgFee(39) As String
    Dim OrgFee1(39) As String
    Dim OrgCost(39) As String
    Dim OrgCost1(39) As String
    Dim OrgParticulars(39) As String
    Dim OrgParticulars1(39) As String
    Dim If_ As Integer = 0

    Private Sub ClrScrn()
        txtStudNo().Clear()
        txtLname().Clear()
        txtFname().Clear()
        txtMname().Clear()
        txtExtname().Clear()
        txtContact().Clear()
        cbbGender().Text = vbNullString
        cbbCourse().Text = vbNullString
        cbbYear().Text = vbNullString
        cbbBlock().Text = vbNullString
        cbbOrganization1.Text = vbNullString
        cbbOrganization2.Text = vbNullString
        cbbOrganization3.Text = vbNullString
        txtStudNo.Focus()
    End Sub

    Private Sub frmAddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        If isEdit_ = "0" Then
            btnEdit.Visible = False
            btnSave.Visible = True

        ElseIf isEdit_ = "1" Then
            btnEdit.Visible = True
            btnSave.Visible = False
            txtStudNo.ReadOnly = True
            cbbOrganization1.Enabled = True
            cbbOrganization2.Enabled = True
            cbbOrganization3.Enabled = True

            strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
            Try
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        txtStudNo.Text = .GetValue(0).ToString
                        txtLname.Text = .GetValue(1).ToString
                        txtFname.Text = .GetValue(2).ToString
                        txtMname.Text = .GetValue(3).ToString
                        txtExtname.Text = .GetValue(4).ToString
                        txtContact.Text = .GetValue(5).ToString
                        cbbGender.Text = .GetValue(6).ToString
                        cbbCourse.Text = .GetValue(7).ToString
                        cbbYear.Text = .GetValue(8).ToString
                        cbbBlock.Text = .GetValue(9).ToString
                        cbbOrganization1.Text = .GetValue(10).ToString
                        cbbOrganization2.Text = .GetValue(11).ToString
                        cbbOrganization3.Text = .GetValue(12).ToString
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try
        End If
    End Sub

    Private Sub frmAddStudent_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "College Of Education - Student Information") = MsgBoxResult.Yes = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Public Function SaveOrg(ByVal OrgName As String, ByVal dbName As String)
        Array.Clear(OrgFee2, 0, 39)
        Array.Clear(OrgFee12, 0, 39)
        Array.Clear(OrgCost2, 0, 39)
        Array.Clear(OrgCost12, 0, 39)
        Array.Clear(OrgParticulars2, 0, 39)
        Array.Clear(OrgParticulars12, 0, 39)
        Dim Trig As Integer = 0

        Dim ID As String = vbNullString

        If OrgName = "GENES CLUB" Then
            ID = "##-##GC"
            Trig = 1
        ElseIf OrgName = "SIGMA" Then
            ID = "##-##SI"
            Trig = 1
        ElseIf OrgName = "FYE 1" Then
            ID = "##-##F1"
            Trig = 1
        ElseIf OrgName = "FYE 2" Then
            ID = "##-##F2"
            Trig = 1
        ElseIf OrgName = "FYE 3" Then
            ID = "##-##F3"
            Trig = 1
        ElseIf OrgName = "FAITH" Then
            ID = "##-##FA"
            Trig = 1
        ElseIf OrgName = "ENGLISH CLUB" Then
            ID = "##-##EC"
            Trig = 1
        ElseIf OrgName = "SOCIAL SCIENCE CLUB" Then
            ID = "##-##SS"
            Trig = 1
        ElseIf OrgName = "MAPE CLUB" Then
            ID = "##-##MC"
            Trig = 1
        ElseIf OrgName = "KAMFIL" Then
            ID = "##-##KA"
            Trig = 1
        ElseIf String.IsNullOrEmpty(OrgName) = True Then
            Trig = 0
        End If


        If Trig = 1 Then
            strQuery = "Select * from `fees1stsem` Where `ID` Like '" & ID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery2(strQuery, dbName)
                With Reader_2
                    While .Read
                        For Numb = 0 To 40
                            OrgFee2(Numb) = .GetValue(Numb + 1)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `fees2ndsem` Where `ID` Like '" & ID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery2(strQuery, dbName)
                With Reader_2
                    While .Read
                        For Numb = 0 To 40
                            OrgFee12(Numb) = .GetValue(Numb + 1)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `cost1stsem` Where `ID` Like '" & ID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery2(strQuery, dbName)
                With Reader_2
                    While .Read
                        For Numb = 0 To 40
                            OrgCost2(Numb) = .GetValue(Numb + 1)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `cost2ndsem` Where `ID` Like '" & ID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery2(strQuery, dbName)
                With Reader_2
                    While .Read
                        For Numb = 0 To 40
                            OrgCost12(Numb) = .GetValue(Numb + 1)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `particulars1stsem` Where `ID` Like '" & ID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery2(strQuery, dbName)
                With Reader_2
                    While .Read
                        For Numb = 0 To 40
                            OrgCost12(Numb) = .GetValue(Numb + 1)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `particulars2ndsem` Where `ID` Like '" & ID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery2(strQuery, dbName)
                With Reader_2
                    While .Read
                        For Numb = 0 To 40
                            OrgCost12(Numb) = .GetValue(Numb + 1)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try


            strQuery =
            "Insert Into `studentsinfo`(`ID`, `Last Name`, `First Name`, `Middle Name`, `Extension Name`, `Contact No.`, `Gender`, `Course`, `Year`, `Block`,`Organization 1`,`Organization 2`,`Organization 3`) " & _
            "VALUES ('" & txtStudNo.Text & "', '" & txtLname.Text & "', '" & txtFname.Text & "', '" & txtMname.Text & "', '" & txtExtname.Text & "', '" & txtContact.Text & "', '" & cbbGender.Text & "', '" & cbbCourse.Text & "', '" & cbbYear.Text & "', '" & cbbBlock.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `fees1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '" & OrgFee2(0) & "', '" & OrgFee2(1) & "', '" & OrgFee2(2) & "', '" & OrgFee2(3) & "', '" & OrgFee2(4) & "', '" & OrgFee2(5) & "', '" & OrgFee2(6) & "', '" & OrgFee2(7) & "', '" & OrgFee2(8) & "', '" & OrgFee2(9) & "', '" & OrgFee2(10) & "', '" & OrgFee2(11) & "', '" & OrgFee2(12) & "', '" & OrgFee2(13) & "', '" & OrgFee2(14) & "', '" & OrgFee2(15) & "', '" & OrgFee2(16) & "', '" & OrgFee2(17) & "', '" & OrgFee2(18) & "', '" & OrgFee2(19) & "', '" & OrgFee2(20) & "', '" & OrgFee2(21) & "', '" & OrgFee2(22) & "', '" & OrgFee2(23) & "', '" & OrgFee2(24) & "', '" & OrgFee2(25) & "', '" & OrgFee2(26) & "', '" & OrgFee2(27) & "', '" & OrgFee2(28) & "', '" & OrgFee2(29) & "', '" & OrgFee2(30) & "', '" & OrgFee2(31) & "', '" & OrgFee2(32) & "', '" & OrgFee2(33) & "', '" & OrgFee2(34) & "', '" & OrgFee2(35) & "', '" & OrgFee2(36) & "', '" & OrgFee2(37) & "', '" & OrgFee2(38) & "', '" & OrgFee2(39) & "', '" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `fees2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '" & OrgFee12(0) & "', '" & OrgFee12(1) & "', '" & OrgFee12(2) & "', '" & OrgFee12(3) & "', '" & OrgFee12(4) & "', '" & OrgFee12(5) & "', '" & OrgFee12(6) & "', '" & OrgFee12(7) & "', '" & OrgFee12(8) & "', '" & OrgFee12(9) & "', '" & OrgFee12(10) & "', '" & OrgFee12(11) & "', '" & OrgFee12(12) & "', '" & OrgFee12(13) & "', '" & OrgFee12(14) & "', '" & OrgFee12(15) & "', '" & OrgFee12(16) & "', '" & OrgFee12(17) & "', '" & OrgFee12(18) & "', '" & OrgFee12(19) & "','" & OrgFee12(20) & "', '" & OrgFee12(21) & "', '" & OrgFee12(22) & "', '" & OrgFee12(23) & "', '" & OrgFee12(24) & "', '" & OrgFee12(25) & "', '" & OrgFee12(26) & "', '" & OrgFee12(27) & "', '" & OrgFee12(28) & "', '" & OrgFee12(29) & "', '" & OrgFee12(30) & "', '" & OrgFee12(31) & "', '" & OrgFee12(32) & "', '" & OrgFee12(33) & "', '" & OrgFee12(34) & "', '" & OrgFee12(35) & "', '" & OrgFee12(36) & "', '" & OrgFee12(37) & "', '" & OrgFee12(38) & "', '" & OrgFee12(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `cost1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '" & OrgCost2(0) & "', '" & OrgCost2(1) & "', '" & OrgCost2(2) & "', '" & OrgCost2(3) & "', '" & OrgCost2(4) & "', '" & OrgCost2(5) & "', '" & OrgCost2(6) & "', '" & OrgCost2(7) & "', '" & OrgCost2(8) & "', '" & OrgCost2(9) & "', '" & OrgCost2(10) & "', '" & OrgCost2(11) & "', '" & OrgCost2(12) & "', '" & OrgCost2(13) & "', '" & OrgCost2(14) & "', '" & OrgCost2(15) & "', '" & OrgCost2(16) & "', '" & OrgCost2(17) & "', '" & OrgCost2(18) & "', '" & OrgCost2(19) & "', '" & OrgCost2(20) & "', '" & OrgCost2(21) & "', '" & OrgCost2(22) & "', '" & OrgCost2(23) & "', '" & OrgCost2(24) & "', '" & OrgCost2(25) & "', '" & OrgCost2(26) & "', '" & OrgCost2(27) & "', '" & OrgCost2(28) & "', '" & OrgCost2(29) & "', '" & OrgCost2(30) & "', '" & OrgCost2(31) & "', '" & OrgCost2(32) & "', '" & OrgCost2(33) & "', '" & OrgCost2(34) & "', '" & OrgCost2(35) & "', '" & OrgCost2(36) & "', '" & OrgCost2(37) & "', '" & OrgCost2(38) & "','" & OrgCost2(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `cost2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '" & OrgCost12(0) & "', '" & OrgCost12(1) & "', '" & OrgCost12(2) & "', '" & OrgCost12(3) & "', '" & OrgCost12(4) & "', '" & OrgCost12(5) & "', '" & OrgCost12(6) & "', '" & OrgCost12(7) & "', '" & OrgCost12(8) & "', '" & OrgCost12(9) & "', '" & OrgCost12(10) & "', '" & OrgCost12(11) & "', '" & OrgCost12(12) & "', '" & OrgCost12(13) & "', '" & OrgCost12(14) & "', '" & OrgCost12(15) & "', '" & OrgCost12(16) & "', '" & OrgCost12(17) & "', '" & OrgCost12(18) & "', '" & OrgCost12(19) & "', '" & OrgCost12(20) & "', '" & OrgCost12(21) & "', '" & OrgCost12(22) & "', '" & OrgCost12(23) & "', '" & OrgCost12(24) & "', '" & OrgCost12(25) & "', '" & OrgCost12(26) & "', '" & OrgCost12(27) & "', '" & OrgCost12(28) & "', '" & OrgCost12(29) & "', '" & OrgCost12(30) & "', '" & OrgCost12(31) & "', '" & OrgCost12(32) & "', '" & OrgCost12(33) & "', '" & OrgCost12(34) & "', '" & OrgCost12(35) & "', '" & OrgCost12(36) & "', '" & OrgCost12(37) & "', '" & OrgCost12(38) & "','" & OrgCost12(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `datepaid1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `datepaid2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `payment1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0','0','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `payment2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0','0','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `if1stsemester`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0','0','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `if2ndsemester`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0','0','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `particulars1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '" & OrgParticulars2(0) & "', '" & OrgParticulars2(1) & "', '" & OrgParticulars2(2) & "', '" & OrgParticulars2(3) & "', '" & OrgParticulars2(4) & "', '" & OrgParticulars2(5) & "', '" & OrgParticulars2(6) & "', '" & OrgParticulars2(7) & "', '" & OrgParticulars2(8) & "', '" & OrgParticulars2(9) & "', '" & OrgParticulars2(10) & "', '" & OrgParticulars2(11) & "', '" & OrgParticulars2(12) & "', '" & OrgParticulars2(13) & "', '" & OrgParticulars2(14) & "', '" & OrgParticulars2(15) & "', '" & OrgParticulars2(16) & "', '" & OrgParticulars2(17) & "', '" & OrgParticulars2(18) & "', '" & OrgParticulars2(19) & "', '" & OrgParticulars2(20) & "', '" & OrgParticulars2(21) & "', '" & OrgParticulars2(22) & "', '" & OrgParticulars2(23) & "', '" & OrgParticulars2(24) & "', '" & OrgParticulars2(25) & "', '" & OrgParticulars2(26) & "', '" & OrgParticulars2(27) & "', '" & OrgParticulars2(28) & "', '" & OrgParticulars2(29) & "', '" & OrgParticulars2(30) & "', '" & OrgParticulars2(31) & "', '" & OrgParticulars2(32) & "', '" & OrgParticulars2(33) & "', '" & OrgParticulars2(34) & "', '" & OrgParticulars2(35) & "', '" & OrgParticulars2(36) & "', '" & OrgParticulars2(37) & "', '" & OrgParticulars2(38) & "','" & OrgParticulars2(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
            "Insert Into `particulars2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
            " VALUES ('" & txtStudNo.Text & "', '" & OrgParticulars12(0) & "', '" & OrgParticulars12(1) & "', '" & OrgParticulars12(2) & "', '" & OrgParticulars12(3) & "', '" & OrgParticulars12(4) & "', '" & OrgParticulars12(5) & "', '" & OrgParticulars12(6) & "', '" & OrgParticulars12(7) & "', '" & OrgParticulars12(8) & "', '" & OrgParticulars12(9) & "', '" & OrgParticulars12(10) & "', '" & OrgParticulars12(11) & "', '" & OrgParticulars12(12) & "', '" & OrgParticulars12(13) & "', '" & OrgParticulars12(14) & "', '" & OrgParticulars12(15) & "', '" & OrgParticulars12(16) & "', '" & OrgParticulars12(17) & "', '" & OrgParticulars12(18) & "', '" & OrgParticulars12(19) & "', '" & OrgParticulars12(20) & "', '" & OrgParticulars12(21) & "', '" & OrgParticulars12(22) & "', '" & OrgParticulars12(23) & "', '" & OrgParticulars12(24) & "', '" & OrgParticulars12(25) & "', '" & OrgParticulars12(26) & "', '" & OrgParticulars12(27) & "', '" & OrgParticulars12(28) & "', '" & OrgParticulars12(29) & "', '" & OrgParticulars12(30) & "', '" & OrgParticulars12(31) & "', '" & OrgParticulars12(32) & "', '" & OrgParticulars12(33) & "', '" & OrgParticulars12(34) & "', '" & OrgParticulars12(35) & "', '" & OrgParticulars12(36) & "', '" & OrgParticulars12(37) & "', '" & OrgParticulars12(38) & "','" & OrgParticulars12(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "')"

            SendQuery2(strQuery, dbName)
        End If
        Return 0
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtStudNo.Text = vbNullString Or txtLname.Text = vbNullString Or txtFname.Text = vbNullString Or cbbGender.Text = vbNullString Or cbbCourse.Text = vbNullString Or cbbYear.Text = vbNullString Then
            MsgBox("Please enter the following information.", , "College Of Education - Student Information")
        Else
            Dim YearID As String = vbNullString

            If cbbYear.Text = "1st" Then
                YearID = "##-###1"
            ElseIf cbbYear.Text = "2nd" Then
                YearID = "##-###2"
            ElseIf cbbYear.Text = "3rd" Then
                YearID = "##-###3"
            ElseIf cbbYear.Text = "4th" Then
                YearID = "##-###4"
            ElseIf cbbYear.Text = "5th" Then
                YearID = "##-###5"
            End If

            strQuery = "Select * from `fees1stsem` Where `ID` Like '" & YearID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        For Numb = 1 To 40
                            Fee(Numb - 1) = .GetValue(Numb)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `fees2ndsem` Where `ID` Like '" & YearID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        For Numb = 1 To 40
                            Fee1(Numb - 1) = .GetValue(Numb)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `cost1stsem` Where `ID` Like '" & YearID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        For Numb = 1 To 40
                            Cost(Numb - 1) = .GetValue(Numb)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `cost2ndsem` Where `ID` Like '" & YearID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        For Numb = 1 To 40
                            Cost1(Numb - 1) = .GetValue(Numb)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `particulars1stsem` Where `ID` Like '" & YearID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        For Numb = 1 To 40
                            Particulars(Numb - 1) = .GetValue(Numb)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery = "Select * from `particulars2ndsem` Where `ID` Like '" & YearID.ToString & "'"
            Try
                Dim Numb As Integer
                ReaderQuery(strQuery)
                With Reader_
                    While .Read
                        For Numb = 1 To 40
                            Particulars1(Numb - 1) = .GetValue(Numb)
                        Next
                    End While
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "College Of Education - Student Information")
            End Try

            strQuery =
     "Insert Into `studentsinfo`(`ID`, `Last Name`, `First Name`, `Middle Name`, `Extension Name`, `Contact No.`, `Gender`, `Course`, `Year`, `Block`,`Organization 1`,`Organization 2`,`Organization 3`) " & _
     "VALUES ('" & txtStudNo.Text & "', '" & txtLname.Text & "', '" & txtFname.Text & "', '" & txtMname.Text & "', '" & txtExtname.Text & "', '" & txtContact.Text & "', '" & cbbGender.Text & "', '" & cbbCourse.Text & "', '" & cbbYear.Text & "', '" & cbbBlock.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `fees1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '" & Fee(0) & "', '" & Fee(1) & "', '" & Fee(2) & "', '" & Fee(3) & "', '" & Fee(4) & "', '" & Fee(5) & "', '" & Fee(6) & "', '" & Fee(7) & "', '" & Fee(8) & "', '" & Fee(9) & "', '" & Fee(10) & "', '" & Fee(11) & "', '" & Fee(12) & "', '" & Fee(13) & "', '" & Fee(14) & "', '" & Fee(15) & "', '" & Fee(16) & "', '" & Fee(17) & "', '" & Fee(18) & "', '" & Fee(19) & "', '" & Fee(20) & "', '" & Fee(21) & "', '" & Fee(22) & "', '" & Fee(23) & "', '" & Fee(24) & "', '" & Fee(25) & "', '" & Fee(26) & "', '" & Fee(27) & "', '" & Fee(28) & "', '" & Fee(29) & "', '" & Fee(30) & "', '" & Fee(31) & "', '" & Fee(32) & "', '" & Fee(33) & "', '" & Fee(34) & "', '" & Fee(35) & "', '" & Fee(36) & "', '" & Fee(37) & "', '" & Fee(38) & "', '" & Fee(39) & "', '" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `fees2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '" & Fee1(0) & "', '" & Fee1(1) & "', '" & Fee1(2) & "', '" & Fee1(3) & "', '" & Fee1(4) & "', '" & Fee1(5) & "', '" & Fee1(6) & "', '" & Fee1(7) & "', '" & Fee1(8) & "', '" & Fee1(9) & "', '" & Fee1(10) & "', '" & Fee1(11) & "', '" & Fee1(12) & "', '" & Fee1(13) & "', '" & Fee1(14) & "', '" & Fee1(15) & "', '" & Fee1(16) & "', '" & Fee1(17) & "', '" & Fee1(18) & "', '" & Fee1(19) & "','" & Fee1(20) & "', '" & Fee1(21) & "', '" & Fee1(22) & "', '" & Fee1(23) & "', '" & Fee1(24) & "', '" & Fee1(25) & "', '" & Fee1(26) & "', '" & Fee1(27) & "', '" & Fee1(28) & "', '" & Fee1(29) & "', '" & Fee1(30) & "', '" & Fee1(31) & "', '" & Fee1(32) & "', '" & Fee1(33) & "', '" & Fee1(34) & "', '" & Fee1(35) & "', '" & Fee1(36) & "', '" & Fee1(37) & "', '" & Fee1(38) & "', '" & Fee1(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `cost1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '" & Cost(0) & "', '" & Cost(1) & "', '" & Cost(2) & "', '" & Cost(3) & "', '" & Cost(4) & "', '" & Cost(5) & "', '" & Cost(6) & "', '" & Cost(7) & "', '" & Cost(8) & "', '" & Cost(9) & "', '" & Cost(10) & "', '" & Cost(11) & "', '" & Cost(12) & "', '" & Cost(13) & "', '" & Cost(14) & "', '" & Cost(15) & "', '" & Cost(16) & "', '" & Cost(17) & "', '" & Cost(18) & "', '" & Cost(19) & "', '" & Cost(20) & "', '" & Cost(21) & "', '" & Cost(22) & "', '" & Cost(23) & "', '" & Cost(24) & "', '" & Cost(25) & "', '" & Cost(26) & "', '" & Cost(27) & "', '" & Cost(28) & "', '" & Cost(29) & "', '" & Cost(30) & "', '" & Cost(31) & "', '" & Cost(32) & "', '" & Cost(33) & "', '" & Cost(34) & "', '" & Cost(35) & "', '" & Cost(36) & "', '" & Cost(37) & "', '" & Cost(38) & "','" & Cost(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `cost2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '" & Cost1(0) & "', '" & Cost1(1) & "', '" & Cost1(2) & "', '" & Cost1(3) & "', '" & Cost1(4) & "', '" & Cost1(5) & "', '" & Cost1(6) & "', '" & Cost1(7) & "', '" & Cost1(8) & "', '" & Cost1(9) & "', '" & Cost1(10) & "', '" & Cost1(11) & "', '" & Cost1(12) & "', '" & Cost1(13) & "', '" & Cost1(14) & "', '" & Cost1(15) & "', '" & Cost1(16) & "', '" & Cost1(17) & "', '" & Cost1(18) & "', '" & Cost1(19) & "', '" & Cost1(20) & "', '" & Cost1(21) & "', '" & Cost1(22) & "', '" & Cost1(23) & "', '" & Cost1(24) & "', '" & Cost1(25) & "', '" & Cost1(26) & "', '" & Cost1(27) & "', '" & Cost1(28) & "', '" & Cost1(29) & "', '" & Cost1(30) & "', '" & Cost1(31) & "', '" & Cost1(32) & "', '" & Cost1(33) & "', '" & Cost1(34) & "', '" & Cost1(35) & "', '" & Cost1(36) & "', '" & Cost1(37) & "', '" & Cost1(38) & "','" & Cost1(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `datepaid1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `datepaid2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `payment1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0','0','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `payment2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0','0','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `if1stsemester`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0','0','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `if2ndsemester`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0','0','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `particulars1stsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '" & Particulars(0) & "', '" & Particulars(1) & "', '" & Particulars(2) & "', '" & Particulars(3) & "', '" & Particulars(4) & "', '" & Particulars(5) & "', '" & Particulars(6) & "', '" & Particulars(7) & "', '" & Particulars(8) & "', '" & Particulars(9) & "', '" & Particulars(10) & "', '" & Particulars(11) & "', '" & Particulars(12) & "', '" & Particulars(13) & "', '" & Particulars(14) & "', '" & Particulars(15) & "', '" & Particulars(16) & "', '" & Particulars(17) & "', '" & Particulars(18) & "', '" & Particulars(19) & "', '" & Particulars(20) & "', '" & Particulars(21) & "', '" & Particulars(22) & "', '" & Particulars(23) & "', '" & Particulars(24) & "', '" & Particulars(25) & "', '" & Particulars(26) & "', '" & Particulars(27) & "', '" & Particulars(28) & "', '" & Particulars(29) & "', '" & Particulars(30) & "', '" & Particulars(31) & "', '" & Particulars(32) & "', '" & Particulars(33) & "', '" & Particulars(34) & "', '" & Particulars(35) & "', '" & Particulars(36) & "', '" & Particulars(37) & "', '" & Particulars(38) & "','" & Particulars(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "');" & _
     "Insert Into `particulars2ndsem`(`ID`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `13`, `14`, `15`, `16`, `17`, `18`, `19`, `20`,`21`,`22`,`23`,`24`,`25`,`26`,`27`,`28`,`29`,`30`,`31`,`32`,`33`,`34`,`35`,`36`,`37`,`38`,`39`,`40`,`Year`, `Organization 1`, `Organization 2`, `Organization 3`)" & _
     " VALUES ('" & txtStudNo.Text & "', '" & Particulars1(0) & "', '" & Particulars1(1) & "', '" & Particulars1(2) & "', '" & Particulars1(3) & "', '" & Particulars1(4) & "', '" & Particulars1(5) & "', '" & Particulars1(6) & "', '" & Particulars1(7) & "', '" & Particulars1(8) & "', '" & Particulars1(9) & "', '" & Particulars1(10) & "', '" & Particulars1(11) & "', '" & Particulars1(12) & "', '" & Particulars1(13) & "', '" & Particulars1(14) & "', '" & Particulars1(15) & "', '" & Particulars1(16) & "', '" & Particulars1(17) & "', '" & Particulars1(18) & "', '" & Particulars1(19) & "', '" & Particulars1(20) & "', '" & Particulars1(21) & "', '" & Particulars1(22) & "', '" & Particulars1(23) & "', '" & Particulars1(24) & "', '" & Particulars1(25) & "', '" & Particulars1(26) & "', '" & Particulars1(27) & "', '" & Particulars1(28) & "', '" & Particulars1(29) & "', '" & Particulars1(30) & "', '" & Particulars1(31) & "', '" & Particulars1(32) & "', '" & Particulars1(33) & "', '" & Particulars1(34) & "', '" & Particulars1(35) & "', '" & Particulars1(36) & "', '" & Particulars1(37) & "', '" & Particulars1(38) & "','" & Particulars1(39) & "','" & cbbYear.Text & "', '" & cbbOrganization1.Text & "', '" & cbbOrganization2.Text & "', '" & cbbOrganization3.Text & "')"
        End If

        '                  ....
        '                 '    '
        '                 '    '                     
        '                 '    '
        '                 '    '
        '                 '    '
        '            .... '    ' .... 
        '           '    ''    ''    '...
        '      .... '    ''    ''    '   '
        '    .'    ''    '      '    '   '
        '    '.     '....'      '....'   '
        '      '.                  '....' 
        '        '.                   .'
        '          '.               .'
        '            '.............'

        If String.IsNullOrEmpty(cbbOrganization1.Text) = False Then
            If cbbOrganization1.Text = cbbOrganization2.Text Or cbbOrganization1.Text = cbbOrganization3.Text Then
                If String.IsNullOrEmpty(cbbOrganization2.Text) = True And String.IsNullOrEmpty(cbbOrganization3.Text) = True Then
                    If_ = 0
                Else
                    MsgBox("Error! Duplication of organization occured.", , "College Of Education - Add Student")
                    If_ = 1
                End If
            ElseIf cbbOrganization2.Text = cbbOrganization1.Text Or cbbOrganization2.Text = cbbOrganization3.Text Then
                If String.IsNullOrEmpty(cbbOrganization2.Text) = True And String.IsNullOrEmpty(cbbOrganization3.Text) = True Then
                    If_ = 0
                Else
                    MsgBox("Error! Duplication of organization occured.", , "College Of Education - Add Student")
                    If_ = 1
                End If
            Else
                If_ = 0
            End If
        End If
        If txtStudNo.TextLength = 7 And If_ = 0 Then
            If MsgBox("Do you want to save this data?", MsgBoxStyle.YesNo, "College Of Education - Student Information") = MsgBoxResult.Yes Then
                Try
                    SendQuery(strQuery)
                    SaveOrg(cbbOrganization1.Text, "orgfee1")
                    SaveOrg(cbbOrganization2.Text, "orgfee2")
                    SaveOrg(cbbOrganization3.Text, "orgfee3")
                    MsgBox("Success! Data saved.", , "College Of Education - Student Information")
                    frmRecord.UpdateRecord()
                    ClrScrn()
                    txtStudNo.Focus()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Error: (FAS-122)") 'Para ma-trace agad kung nasaang line yung error
                End Try
            End If
        End If
    End Sub

    Private Sub btnBack_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        frmRecord.Show()
    End Sub

    Private Sub bttnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEdit.Click
        If_ = vbNull
        If txtStudNo.Text = vbNullString Then
            MsgBox("Error!", , "College Of Education - Student Information")

        ElseIf String.IsNullOrEmpty(cbbOrganization1.Text) = False Then
            If cbbOrganization1.Text = cbbOrganization2.Text Or cbbOrganization1.Text = cbbOrganization3.Text Then
                If String.IsNullOrEmpty(cbbOrganization2.Text) = True And String.IsNullOrEmpty(cbbOrganization3.Text) = True Then
                    If_ = 0
                Else
                    MsgBox("Error! Duplication of organization occured.", , "College Of Education - Add Student")
                    If_ = 1
                End If
            ElseIf cbbOrganization2.Text = cbbOrganization1.Text Or cbbOrganization2.Text = cbbOrganization3.Text Then
                If String.IsNullOrEmpty(cbbOrganization2.Text) = True And String.IsNullOrEmpty(cbbOrganization3.Text) = True Then
                    If_ = 0
                Else
                    MsgBox("Error! Duplication of organization occured.", , "College Of Education - Add Student")
                    If_ = 1
                End If
            Else
                If_ = 0
            End If
        End If

        strQuery = "Update `studentsinfo` Set `Last Name` = '" & txtLname.Text & "', `First Name` = '" & txtFname.Text & "', `Middle Name` = '" & txtMname.Text & "', `Extension Name` = '" & txtExtname.Text & "', `Contact No.` = '" & txtContact.Text & "', `Gender` = '" & cbbGender.Text & "', `Course` = '" & cbbCourse.Text & "', `Year` = '" & cbbYear.Text & "', `Block` = '" & cbbBlock.Text & "', `Organization 1` = '" & cbbOrganization1.Text & "', `Organization 2` = '" & cbbOrganization2.Text & "', `Organization 3` = '" & cbbOrganization3.Text & "' Where `ID` = '" & txtStudNo.Text & "'"
        If MsgBox("Do you want to save this data?", MsgBoxStyle.YesNo, "College Of Education - Student Information") = MsgBoxResult.Yes And If_ = 0 Then
            Try
                SendQuery(strQuery)
                SendQuery2(strQuery, "orgfee1")
                SendQuery2(strQuery, "orgfee1")
                SendQuery2(strQuery, "orgfee1")
                MsgBox("Success! Data saved.", , "College Of Education - Student Information")
                Me.Hide()
                frmRecord.UpdateRecord()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error: (FAS-146)") 'Para ma-trace agad kung nasaang line yung error
            End Try
        End If
    End Sub

    Private Sub txtStudNo_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStudNo.KeyPress
        If Asc(e.KeyChar) < 58 And Asc(e.KeyChar) > 47 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Asc(e.KeyChar) < 58 And Asc(e.KeyChar) > 47 Or Asc(e.KeyChar) = 8 Then
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub
End Class