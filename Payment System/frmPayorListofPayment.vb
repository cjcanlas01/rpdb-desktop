Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Public Class frmPayorListofPayment
    Dim B As Integer = 1
    Dim D As Integer
    Dim TotalAmount1, TotalAmount2, TotalAmount3 As Integer
    Dim Balance As Integer
    Dim IfChecker As String = vbNullString
    Dim OrgDesc As String = vbNullString

    Private Sub StudFee1stSem()
        dgvStudFee.Rows.Clear()

        strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 39
                    D = dgvStudFee.Rows.Add
                    dgvStudFee.Item(0, D).Value = D + 1
                    dgvStudFee.Item(1, D).Value = .GetValue(B).ToString
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `particulars1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 40
                    dgvStudFee.Item(2, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `payment1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 40
                    dgvStudFee.Item(3, D).Value = .GetValue(B).ToString
                    TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `datepaid1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 40
                    dgvStudFee.Item(4, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `if1stsemester` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 40
                    dgvStudFee.Item(5, D).Value = .GetBoolean(B)
                    D = D + 1
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        For Row As Integer = dgvStudFee.Rows.Count - 1 To 0 Step -1
            If dgvStudFee.Item(1, Row).Value.ToString = vbNullString Then
                dgvStudFee.Rows.RemoveAt(Row)
            End If
        Next
    End Sub

    Private Sub OrgFee11stSem()

        dgvOrgFee1.Rows.Clear()
        strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 39
                    D = dgvOrgFee1.Rows.Add
                    dgvOrgFee1.Item(0, D).Value = D + 1
                    dgvOrgFee1.Item(1, D).Value = .GetValue(B).ToString
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `particulars1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee1.Item(2, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `payment1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee1.Item(3, D).Value = .GetValue(B).ToString
                    TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `datepaid1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee1.Item(4, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `if1stsemester` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee1.Item(5, D).Value = .GetBoolean(B)
                    D = D + 1
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With
        For Row As Integer = dgvOrgFee1.Rows.Count - 1 To 0 Step -1
            If dgvOrgFee1.Item(1, Row).Value.ToString = vbNullString Then
                dgvOrgFee1.Rows.RemoveAt(Row)
            End If
        Next
    End Sub

    Private Sub OrgFee21stSem()
        dgvOrgFee2.Rows.Clear()
        strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 39
                    D = dgvOrgFee2.Rows.Add
                    dgvOrgFee2.Item(0, D).Value = D + 1
                    dgvOrgFee2.Item(1, D).Value = .GetValue(B).ToString
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `particulars1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee2.Item(2, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `payment1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee2.Item(3, D).Value = .GetValue(B).ToString
                    TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `datepaid1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee2.Item(4, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `if1stsemester` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee2.Item(5, D).Value = .GetBoolean(B)
                    D = D + 1
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With
        For Row As Integer = dgvOrgFee2.Rows.Count - 1 To 0 Step -1
            If dgvOrgFee2.Item(1, Row).Value.ToString = vbNullString Then
                dgvOrgFee2.Rows.RemoveAt(Row)
            End If
        Next
    End Sub

    Private Sub OrgFee31stSem()
        dgvOrgFee3.Rows.Clear()
        strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 39
                    D = dgvOrgFee3.Rows.Add
                    dgvOrgFee3.Item(0, D).Value = D + 1
                    dgvOrgFee3.Item(1, D).Value = .GetValue(B).ToString
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `particulars1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee3.Item(2, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `payment1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee3.Item(3, D).Value = .GetValue(B).ToString
                    TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `datepaid1stsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee3.Item(4, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `if1stsemester` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee3.Item(5, D).Value = .GetBoolean(B)
                    D = D + 1
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        For Row As Integer = dgvOrgFee3.Rows.Count - 1 To 0 Step -1
            If dgvOrgFee3.Item(1, Row).Value.ToString = vbNullString Then
                dgvOrgFee3.Rows.RemoveAt(Row)
            End If
        Next
    End Sub

    Private Sub FirstSem()
        Dim CheckOrg(2) As String
        strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                CheckOrg(0) = .GetValue(10).ToString
                CheckOrg(1) = .GetValue(11).ToString
                CheckOrg(2) = .GetValue(12).ToString
            End While
        End With

        If CheckOrg(0) = CheckOrg(0) Then
            StudFee1stSem()
            OrgFee11stSem()
        ElseIf CheckOrg(1) = CheckOrg(1) Then
            StudFee1stSem()
            OrgFee21stSem()
        ElseIf CheckOrg(2) = CheckOrg(2) Then
            StudFee1stSem()
            OrgFee31stSem()
        ElseIf CheckOrg(0) = CheckOrg(0) And CheckOrg(1) = CheckOrg(1) And String.IsNullOrEmpty(CheckOrg(2)) Then
            StudFee1stSem()
            OrgFee11stSem()
            OrgFee21stSem()
        ElseIf CheckOrg(0) = CheckOrg(0) And CheckOrg(2) = CheckOrg(2) And String.IsNullOrEmpty(CheckOrg(1)) Then
            StudFee1stSem()
            OrgFee11stSem()
            OrgFee31stSem()
        ElseIf CheckOrg(1) = CheckOrg(1) And CheckOrg(0) = CheckOrg(0) And String.IsNullOrEmpty(CheckOrg(2)) Then
            StudFee1stSem()
            OrgFee21stSem()
            OrgFee11stSem()
        ElseIf CheckOrg(1) = CheckOrg(1) And CheckOrg(2) = CheckOrg(2) And String.IsNullOrEmpty(CheckOrg(0)) Then
            StudFee1stSem()
            OrgFee21stSem()
            OrgFee31stSem()
        ElseIf CheckOrg(2) = CheckOrg(2) And CheckOrg(0) = CheckOrg(0) And String.IsNullOrEmpty(CheckOrg(1)) Then
            StudFee1stSem()
            OrgFee31stSem()
            OrgFee11stSem()
        ElseIf CheckOrg(2) = CheckOrg(2) And CheckOrg(1) = CheckOrg(1) And String.IsNullOrEmpty(CheckOrg(0)) Then
            StudFee1stSem()
            OrgFee31stSem()
            OrgFee21stSem()
        ElseIf CheckOrg(0) = CheckOrg(0) And CheckOrg(1) = CheckOrg(1) And CheckOrg(2) = CheckOrg(2) Then
            StudFee1stSem()
            OrgFee11stSem()
            OrgFee21stSem()
            OrgFee31stSem()
        End If
    End Sub

    Private Sub StudFee12ndSem()
        dgvStudFee1.Rows.Clear()
        strQuery = "Select * From `fees2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 39
                    D = dgvStudFee1.Rows.Add
                    dgvStudFee1.Item(0, D).Value = D + 1
                    dgvStudFee1.Item(1, D).Value = .GetValue(B).ToString
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `particulars2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 40
                    dgvStudFee1.Item(2, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `payment2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 40
                    dgvStudFee1.Item(3, D).Value = .GetValue(B).ToString
                    TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `datepaid2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 40
                    dgvStudFee1.Item(4, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `if2ndsemester` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                While Not D = 40
                    dgvStudFee1.Item(5, D).Value = .GetBoolean(B)
                    D = D + 1
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        For Row As Integer = dgvStudFee1.Rows.Count - 1 To 0 Step -1
            If dgvStudFee1.Item(1, Row).Value.ToString = vbNullString Then
                dgvStudFee1.Rows.RemoveAt(Row)
            End If
        Next
    End Sub

    Private Sub OrgFee1A2ndSem()
        strQuery = "Select * From `fees2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 39
                    D = dgvOrgFee1A.Rows.Add
                    dgvOrgFee1A.Item(0, D).Value = D + 1
                    dgvOrgFee1A.Item(1, D).Value = .GetValue(B).ToString
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `particulars2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee1A.Item(2, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `payment2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee1A.Item(3, D).Value = .GetValue(B).ToString
                    TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `datepaid2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee1A.Item(4, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `if2ndsemester` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee1")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee1A.Item(5, D).Value = .GetBoolean(B)
                    D = D + 1
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With
        For Row As Integer = dgvOrgFee1A.Rows.Count - 1 To 0 Step -1
            If dgvOrgFee1A.Item(1, Row).Value.ToString = vbNullString Then
                dgvOrgFee1A.Rows.RemoveAt(Row)
            End If
        Next
    End Sub

    Private Sub OrgFee2A2ndSem()
        dgvOrgFee2A.Rows.Clear()
        strQuery = "Select * From `fees2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 39
                    D = dgvOrgFee2A.Rows.Add
                    dgvOrgFee2A.Item(0, D).Value = D + 1
                    dgvOrgFee2A.Item(1, D).Value = .GetValue(B).ToString
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `particulars2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee2A.Item(2, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `payment2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee2A.Item(3, D).Value = .GetValue(B).ToString
                    TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `datepaid2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee2A.Item(4, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `if2ndsemester` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee2")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee2A.Item(5, D).Value = .GetBoolean(B)
                    D = D + 1
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With
        For Row As Integer = dgvOrgFee2A.Rows.Count - 1 To 0 Step -1
            If dgvOrgFee2A.Item(1, Row).Value.ToString = vbNullString Then
                dgvOrgFee2A.Rows.RemoveAt(Row)
            End If
        Next
    End Sub

    Private Sub OrgFee3A2ndSem()
        dgvOrgFee3A.Rows.Clear()
        strQuery = "Select * From `fees2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 39
                    D = dgvOrgFee3A.Rows.Add
                    dgvOrgFee3A.Item(0, D).Value = D + 1
                    dgvOrgFee3A.Item(1, D).Value = .GetValue(B).ToString
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `particulars2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee3A.Item(2, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `payment2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee3A.Item(3, D).Value = .GetValue(B).ToString
                    TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `datepaid2ndsem` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee3A.Item(4, D).Value = .GetValue(B).ToString
                    B = B + 1
                    D = D + 1
                End While
            End While
            B = 1
            D = 0
        End With

        strQuery = "Select * From `if2ndsemester` Where `ID` = '" & SearchedID & "'"
        ReaderQuery2(strQuery, "OrgFee3")
        With Reader_2
            While .Read
                While Not D = 40
                    dgvOrgFee3A.Item(5, D).Value = .GetBoolean(B)
                    D = D + 1
                    B = B + 1
                End While
            End While
            B = 1
            D = 0
        End With

        For Row As Integer = dgvOrgFee3A.Rows.Count - 1 To 0 Step -1
            If dgvOrgFee3A.Item(1, Row).Value.ToString = vbNullString Then
                dgvOrgFee3A.Rows.RemoveAt(Row)
            End If
        Next
    End Sub

    Public Sub SecondSem()
        Dim CheckOrg(2) As String
        strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                CheckOrg(0) = .GetValue(10).ToString
                CheckOrg(1) = .GetValue(11).ToString
                CheckOrg(2) = .GetValue(12).ToString
            End While
        End With

        If CheckOrg(0) = CheckOrg(0) Then
            StudFee12ndSem()
            OrgFee1A2ndSem()
        ElseIf CheckOrg(1) = CheckOrg(1) Then
            StudFee12ndSem()
            OrgFee2A2ndSem()
        ElseIf CheckOrg(2) = CheckOrg(2) Then
            StudFee12ndSem()
            OrgFee3A2ndSem()
        ElseIf CheckOrg(0) = CheckOrg(0) And CheckOrg(1) = CheckOrg(1) And String.IsNullOrEmpty(CheckOrg(2)) Then
            StudFee12ndSem()
            OrgFee1A2ndSem()
            OrgFee2A2ndSem()
        ElseIf CheckOrg(0) = CheckOrg(0) And CheckOrg(2) = CheckOrg(2) And String.IsNullOrEmpty(CheckOrg(1)) Then
            StudFee12ndSem()
            OrgFee1A2ndSem()
            OrgFee3A2ndSem()
        ElseIf CheckOrg(1) = CheckOrg(1) And CheckOrg(0) = CheckOrg(0) And String.IsNullOrEmpty(CheckOrg(2)) Then
            StudFee12ndSem()
            OrgFee2A2ndSem()
            OrgFee1A2ndSem()
        ElseIf CheckOrg(1) = CheckOrg(1) And CheckOrg(2) = CheckOrg(2) And String.IsNullOrEmpty(CheckOrg(0)) Then
            StudFee12ndSem()
            OrgFee2A2ndSem()
            OrgFee3A2ndSem()
        ElseIf CheckOrg(2) = CheckOrg(2) And CheckOrg(0) = CheckOrg(0) And String.IsNullOrEmpty(CheckOrg(1)) Then
            StudFee12ndSem()
            OrgFee3A2ndSem()
            OrgFee1A2ndSem()
        ElseIf CheckOrg(2) = CheckOrg(2) And CheckOrg(1) = CheckOrg(1) And String.IsNullOrEmpty(CheckOrg(0)) Then
            StudFee1stSem()
            OrgFee3A2ndSem()
            OrgFee2A2ndSem()
        ElseIf CheckOrg(0) = CheckOrg(0) And CheckOrg(1) = CheckOrg(1) And CheckOrg(2) = CheckOrg(2) Then
            StudFee12ndSem()
            OrgFee1A2ndSem()
            OrgFee2A2ndSem()
            OrgFee3A2ndSem()
        End If
    End Sub


    Private Sub Update1stSem()
        If Trigger = "A" Then
            'Selection for fee of year
            dgv1stSem.Rows.Clear()

            strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not D = 39
                        D = dgv1stSem.Rows.Add
                        dgv1stSem.Item(0, D).Value = D + 1
                        dgv1stSem.Item(1, D).Value = .GetValue(B).ToString
                        B = B + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `particulars1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not D = 40
                        dgv1stSem.Item(2, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `payment1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not D = 40
                        dgv1stSem.Item(3, D).Value = .GetValue(B).ToString
                        TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `datepaid1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not D = 40
                        dgv1stSem.Item(4, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `if1stsemester` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not D = 40
                        dgv1stSem.Item(5, D).Value = .GetBoolean(B)
                        D = D + 1
                        B = B + 1
                    End While
                End While
                B = 1
                D = 0
            End With
            lblTotalAmount1.Text = TotalAmount1.ToString

            Dim Count As Integer = 1
            For Row As Integer = dgv1stSem.Rows.Count - 1 To 0 Step -1
                If dgv1stSem.Item(1, Row).Value.ToString = vbNullString Then
                    dgv1stSem.Rows.RemoveAt(Row)
                End If
            Next
        ElseIf Trigger = "B" Then
            'Selection for fee of organization
            dgv1stSem.Rows.Clear()

            If IfChecker = "1" Then
                OrgDesc = "orgfee1"
            ElseIf IfChecker = "2" Then
                OrgDesc = "orgfee2"
            ElseIf IfChecker = "3" Then
                OrgDesc = "orgfee3"
            End If
            strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_2
                While .Read
                    While Not D = 39
                        D = dgv1stSem.Rows.Add
                        dgv1stSem.Item(0, D).Value = D + 1
                        dgv1stSem.Item(1, D).Value = .GetValue(B).ToString
                        B = B + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `particulars1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_2
                While .Read
                    While Not D = 40
                        dgv1stSem.Item(2, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `payment1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_2
                While .Read
                    While Not D = 40
                        dgv1stSem.Item(3, D).Value = .GetValue(B).ToString
                        TotalAmount1 = TotalAmount1 + .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `datepaid1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_2
                While .Read
                    While Not D = 40
                        dgv1stSem.Item(4, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `if1stsemester` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_2
                While .Read
                    While Not D = 40
                        dgv1stSem.Item(5, D).Value = .GetBoolean(B)
                        D = D + 1
                        B = B + 1
                    End While
                End While
                B = 1
                D = 0
            End With
            lblTotalAmount1.Text = TotalAmount1.ToString

            Dim Count As Integer = 1
            For Row As Integer = dgv1stSem.Rows.Count - 1 To 0 Step -1
                If dgv1stSem.Item(1, Row).Value.ToString = vbNullString Then
                    dgv1stSem.Rows.RemoveAt(Row)
                End If
            Next
        End If

    End Sub

    Private Sub Update2ndSem()
        Dim A As Integer = 1
        Dim C As Integer

        If Trigger = "A" Then
            'Selection for fee of year
            dgv2ndSem.Rows.Clear()

            strQuery = "Select * From `fees2ndsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not C = 39
                        C = dgv2ndSem.Rows.Add
                        dgv2ndSem.Item(0, C).Value = C + 1
                        dgv2ndSem.Item(1, C).Value = .GetValue(A).ToString
                        A = A + 1
                    End While
                End While
                A = 1
                C = 0
            End With

            strQuery = "Select * From `particulars2ndsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not C = 40
                        dgv2ndSem.Item(2, C).Value = .GetValue(A).ToString
                        A = A + 1
                        C = C + 1
                    End While
                End While
                A = 1
                C = 0
            End With

            strQuery = "Select * From `payment2ndsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not C = 40
                        dgv2ndSem.Item(3, C).Value = .GetValue(A).ToString
                        TotalAmount2 = TotalAmount2 + .GetValue(A).ToString
                        A = A + 1
                        C = C + 1
                    End While
                End While
                A = 1
                C = 0
            End With

            strQuery = "Select * From `datepaid2ndsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not C = 40
                        dgv2ndSem.Item(4, C).Value = .GetValue(A).ToString
                        A = A + 1
                        C = C + 1
                    End While
                End While
                A = 1
                C = 0
            End With

            strQuery = "Select * From `if2ndsemester` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not C = 40
                        dgv2ndSem.Item(5, C).Value = .GetBoolean(A)
                        A = A + 1
                        C = C + 1
                    End While
                End While
                A = 1
                C = 0
            End With
            lblTotalAmount2.Text = TotalAmount2.ToString

            Dim Count As Integer = 1
            For Row As Integer = dgv2ndSem.Rows.Count - 1 To 0 Step -1
                If dgv2ndSem.Item(1, Row).Value.ToString = vbNullString Then
                    dgv2ndSem.Rows.RemoveAt(Row)
                End If
            Next
        ElseIf Trigger = "B" Then
            If IfChecker = "1" Then
                OrgDesc = "orgfee1"
            ElseIf IfChecker = "2" Then
                OrgDesc = "orgfee2"
            ElseIf IfChecker = "3" Then
                OrgDesc = "orgfee3"
            End If
            'Selection for fee of organization
            dgv2ndSem.Rows.Clear()

            strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_
                While .Read
                    While Not C = 39
                        C = dgv2ndSem.Rows.Add
                        dgv2ndSem.Item(0, C).Value = C + 1
                        dgv2ndSem.Item(1, C).Value = .GetValue(A).ToString
                        A = A + 1
                    End While
                End While
                A = 1
                C = 0
            End With

            strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_
                While .Read
                    While Not C = 40
                        dgv2ndSem.Item(2, C).Value = .GetValue(A).ToString
                        A = A + 1
                        C = C + 1
                    End While
                End While
                A = 1
                C = 0
            End With

            strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_
                While .Read
                    While Not C = 40
                        dgv2ndSem.Item(3, C).Value = .GetValue(A).ToString
                        TotalAmount2 = TotalAmount2 + .GetValue(A).ToString
                        A = A + 1
                        C = C + 1
                    End While
                End While
                A = 1
                C = 0
            End With

            strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_
                While .Read
                    While Not C = 40
                        dgv2ndSem.Item(4, C).Value = .GetValue(A).ToString
                        A = A + 1
                        C = C + 1
                    End While
                End While
                A = 1
                C = 0
            End With

            strQuery = "Select * From `fees1stsem` Where `ID` = '" & SearchedID & "'"
            ReaderQuery2(strQuery, OrgDesc)
            With Reader_
                While .Read
                    While Not C = 40
                        dgv2ndSem.Item(5, C).Value = .GetBoolean(A)
                        A = A + 1
                        C = C + 1
                    End While
                End While
                A = 1
                C = 0
            End With
            lblTotalAmount2.Text = TotalAmount2.ToString

            Dim Count As Integer = 1
            For Row As Integer = dgv2ndSem.Rows.Count - 1 To 0 Step -1
                If dgv2ndSem.Item(1, Row).Value.ToString = vbNullString Then
                    dgv2ndSem.Rows.RemoveAt(Row)
                End If
            Next
        End If

    End Sub


    Private Sub frmPayorListofPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CheckOrg(2) As String
        lblIDNo.Text = SearchedID

        If Trigger = "A" Then
            lblOrgName.Text = "Year: " + Year_
        ElseIf Trigger = "B" Then
            lblOrgName.Text = "Org.: " + Organization_
        End If

        If Trigger = "B" Then
            strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
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

        strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)

        With Reader_
            Dim Name As String
            While .Read
                Name = .GetValue(1) + "," + " " + .GetValue(2) + " " + .GetValue(3) + " " + .GetValue(4)
                lblName.Text = Name.ToString
            End While
        End With

        Update1stSem()
        FirstSem()
        Update2ndSem()
        SecondSem()

    End Sub

    Private Sub frmPayorListofPayment_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "College Of Education - Payment Collection") = MsgBoxResult.Yes = True Then
            e.Cancel = False
            ClearTrigs()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub tabPayorList_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabPayorList.Click
        If tabPayorList.SelectedTab.Text = "1st Semester" Then
            TotalAmount1 = 0
            lblTotalAmount1.Text = vbNullString
            Update1stSem()
        ElseIf tabPayorList.SelectedTab.Text = "2nd Semester" Then
            TotalAmount2 = 0
            lblTotalAmount2.Text = vbNullString
            Update2ndSem()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Static Dim xlapp As Excel.Application
        Static Dim xlwbook As Excel.Workbook
        Static Dim xlwsheet As Excel.Worksheet
        Dim num1, num2, num3 As Integer
        Dim Name As String = vbNullString
        Dim BlckYr As String = vbNullString
        Dim CheckOrg(2) As String

        Array.Clear(CheckOrg, 0, 2)
        strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
        ReaderQuery(strQuery)
        With Reader_
            While .Read
                CheckOrg(0) = .GetValue(10).ToString
                CheckOrg(1) = .GetValue(11).ToString
                CheckOrg(2) = .GetValue(12).ToString
            End While
        End With

        If tabPayorList.SelectedTab.Text = "1st Semester" Then

            xlapp = New Excel.Application
            xlapp.Visible = True
            xlwbook = xlapp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Resources\CollectionFile.xlsx") '("C:\Users\" & Environment.UserName & "\CollectionFile.xlsx")
            xlwsheet = xlwbook.Sheets("sheet1")

            strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)

            With Reader_
                While .Read
                    Name = .GetValue(1) + "," + " " + .GetValue(2) + " " + .GetValue(3) + " " + .GetValue(4)
                    BlckYr = .GetValue(7) + " " + .GetValue(8) + " " + "Block" + .GetValue(9)
                End While
            End With

            xlwsheet.Cells(10, 2) = SearchedID.ToString
            xlwsheet.Cells(11, 2) = Name.ToString
            xlwsheet.Cells(12, 2) = CheckOrg(0) + ", " + CheckOrg(1) + ", " + CheckOrg(2)
            xlwsheet.Cells(13, 2) = BlckYr.ToString
            xlwsheet.Cells(18, 2) = "STUDENT FEES"
            For num1 = 0 To dgvStudFee.RowCount - 1
                For num2 = 0 To dgvStudFee.ColumnCount - 1
                    For num3 = 1 To dgvStudFee.Columns.Count
                        Try
                            xlwsheet.Cells(19 + num1, 1 + num2) = dgvStudFee(num2, num1).FormattedValue.ToString
                        Catch ex As Exception

                        End Try

                    Next
                Next
            Next
            'BREAK LINE
            Dim NumA As Integer = 0
            Dim CountA As Integer
            For NumA = 0 To dgvStudFee.RowCount - 1
                CountA = CountA + 1
            Next

            Dim Space1 As Integer
            Space1 = CountA + 20
            Dim Space2 As Integer
            Space2 = Space1 + 1

            xlwsheet.Cells(Space1, 2) = CheckOrg(0).ToString
            For num1 = 0 To dgvOrgFee1.RowCount - 1
                For num2 = 0 To dgvOrgFee1.ColumnCount - 1
                    For num3 = 1 To dgvOrgFee1.Columns.Count
                        Try
                            xlwsheet.Cells(Space2 + num1, 1 + num2) = dgvOrgFee1(num2, num1).FormattedValue.ToString
                        Catch ex As Exception

                        End Try

                    Next
                Next
            Next
            'BREAK LINE
            Dim CountB As Integer
            For NumA = 0 To dgvOrgFee1.RowCount - 1
                CountB = CountB + 1
            Next
            Dim Space1A As Integer
            Space1A = CountB + Space2 + 1
            Dim Space2A As Integer
            Space2A = Space1A + 1

            xlwsheet.Cells(Space1A, 2) = CheckOrg(1).ToString
            For num1 = 0 To dgvOrgFee2.RowCount - 1
                For num2 = 0 To dgvOrgFee2.ColumnCount - 1
                    For num3 = 1 To dgvOrgFee2.Columns.Count
                        Try
                            xlwsheet.Cells(Space2A + num1, 1 + num2) = dgvOrgFee2(num2, num1).FormattedValue.ToString
                        Catch ex As Exception

                        End Try

                    Next
                Next
            Next
            'BREAK LINE
            Dim CountC As Integer
            For NumA = 0 To dgvOrgFee2.RowCount - 1
                CountC = CountC + 1
            Next
            Dim Space1B As Integer
            Space1B = CountC + Space2A + 1
            Dim Space2B As Integer
            Space2B = Space1B + 1

            xlwsheet.Cells(Space1B, 2) = CheckOrg(2).ToString
            For num1 = 0 To dgvOrgFee3.RowCount - 1
                For num2 = 0 To dgvOrgFee3.ColumnCount - 1
                    For num3 = 1 To dgvOrgFee3.Columns.Count
                        Try
                            xlwsheet.Cells(Space2B + num1, 1 + num2) = dgvOrgFee3(num2, num1).FormattedValue.ToString
                        Catch ex As Exception

                        End Try

                    Next
                Next
            Next
            'BREAK LINE

            xlapp = Nothing
            xlwbook = Nothing
        End If

        If tabPayorList.SelectedTab.Text = "2nd Semester" Then

            xlapp = New Excel.Application
            xlapp.Visible = True
            xlwbook = xlapp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Resources\CollectionFile.xlsx") '("C:\Users\" & Environment.UserName & "\CollectionFile.xlsx")
            xlwsheet = xlwbook.Sheets("sheet1")

            strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)

            With Reader_
                While .Read
                    Name = .GetValue(1) + "," + " " + .GetValue(2) + " " + .GetValue(3) + " " + .GetValue(4)
                    BlckYr = .GetValue(7) + " " + .GetValue(8) + " " + "Block" + .GetValue(9)
                End While
            End With

            xlwsheet.Cells(10, 2) = SearchedID.ToString
            xlwsheet.Cells(11, 2) = Name.ToString
            xlwsheet.Cells(12, 2) = CheckOrg(0) + ", " + CheckOrg(1) + ", " + CheckOrg(2)
            xlwsheet.Cells(13, 2) = BlckYr.ToString
            xlwsheet.Cells(18, 1) = "STUDENT FEES"
            For num1 = 0 To dgvStudFee1.RowCount - 1
                For num2 = 0 To dgvStudFee1.ColumnCount - 1
                    For num3 = 1 To dgvStudFee1.Columns.Count
                        Try
                            xlwsheet.Cells(19 + num1, 1 + num2) = dgvStudFee1(num2, num1).FormattedValue.ToString
                        Catch ex As Exception

                        End Try

                    Next
                Next
            Next
            'BREAK LINE
            Dim NumA As Integer = 0
            Dim CountA As Integer
            For NumA = 0 To dgvStudFee1.RowCount - 1
                CountA = CountA + 1
            Next

            Dim Space1 As Integer
            Space1 = CountA + 20
            Dim Space2 As Integer
            Space2 = Space1 + 1

            xlwsheet.Cells(Space1, 2) = CheckOrg(0).ToString
            For num1 = 0 To dgvOrgFee1A.RowCount - 1
                For num2 = 0 To dgvOrgFee1A.ColumnCount - 1
                    For num3 = 1 To dgvOrgFee1A.Columns.Count
                        Try
                            xlwsheet.Cells(Space2 + num1, 1 + num2) = dgvOrgFee1A(num2, num1).FormattedValue.ToString
                        Catch ex As Exception

                        End Try

                    Next
                Next
            Next
            'BREAK LINE
            Dim CountB As Integer
            For NumA = 0 To dgvOrgFee1A.RowCount - 1
                CountB = CountB + 1
            Next
            Dim Space1A As Integer
            Space1A = CountB + Space2 + 1
            Dim Space2A As Integer
            Space2A = Space1A + 1

            xlwsheet.Cells(Space1A, 2) = CheckOrg(1).ToString
            For num1 = 0 To dgvOrgFee2A.RowCount - 1
                For num2 = 0 To dgvOrgFee2A.ColumnCount - 1
                    For num3 = 1 To dgvOrgFee2A.Columns.Count
                        Try
                            xlwsheet.Cells(Space2A + num1, 1 + num2) = dgvOrgFee2A(num2, num1).FormattedValue.ToString
                        Catch ex As Exception

                        End Try

                    Next
                Next
            Next
            'BREAK LINE
            Dim CountC As Integer
            For NumA = 0 To dgvOrgFee2A.RowCount - 1
                CountC = CountC + 1
            Next
            Dim Space1B As Integer
            Space1B = CountC + Space2A + 1
            Dim Space2B As Integer
            Space2B = Space1B + 1

            xlwsheet.Cells(Space1B, 2) = CheckOrg(2).ToString
            For num1 = 0 To dgvOrgFee3A.RowCount - 1
                For num2 = 0 To dgvOrgFee3A.ColumnCount - 1
                    For num3 = 1 To dgvOrgFee3A.Columns.Count
                        Try
                            xlwsheet.Cells(Space2B + num1, 1 + num2) = dgvOrgFee3A(num2, num1).FormattedValue.ToString
                        Catch ex As Exception

                        End Try

                    Next
                Next
            Next
            'BREAK LINE

            xlapp = Nothing
            xlwbook = Nothing
        End If
    End Sub
End Class