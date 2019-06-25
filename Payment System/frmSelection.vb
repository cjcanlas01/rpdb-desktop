Public Class frmSelection

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If rbttnStudentFees.Checked = True And Not cbbYear.Text = vbNullString Then
            If isPassSF_ = "A" Then
                'Displays recording of fees - YEAR
                Year_ = cbbYear.Text
                Me.Close()
                Trigger = "A"
                frmCollection.ClrScrn()
                frmCollection.Show()
                ClrScrn()
            ElseIf isPassSF_ = "B" Then
                'Displays form of transaction - YEAR
                Year_ = cbbYear.Text
                Me.Close()
                isInvoice_ = 1
                Trigger = "A"
                frmInvoice.ClrScrn()
                frmInvoice.Show()
                ClrScrn()
            ElseIf isPassSF_ = "C" Then
                'Displays form of displaying fees - YEAR
                Year_ = cbbYear.Text
                Me.Close()
                Trigger = "A"
                frmPayorListofPayment.Show()
                ClrScrn()
            End If
           
        ElseIf rbttnOrganizationFees.Checked = True And Not cbbOrganization.Text = vbNullString Then
            If isPassOF_ = "A" Then
                'Displays recording of fees - ORG
                Organization_ = cbbOrganization.Text
                Me.Close()
                Trigger = "B"
                frmCollection.ClrScrn()
                frmCollection.Show()
                ClrScrn()
            ElseIf isPassOF_ = "B" Then
                'Displays form of transaction - ORG
                Organization_ = cbbOrganization.Text
                Me.Close()
                isInvoice_ = 1
                Trigger = "B"
                frmInvoice.ClrScrn()
                frmInvoice.Show()
                ClrScrn()
            ElseIf isPassOF_ = "C" Then
                'Displays form of displaying fees - ORG
                Organization_ = cbbOrganization.Text
                Me.Close()
                Trigger = "B"
                frmPayorListofPayment.Show()
                ClrScrn()
            End If
        Else
            MsgBox("Please enter the following information.", , "College Of Education - Selection")
        End If
    End Sub

    Public Sub ClrScrn()
        rbttnOrganizationFees.Checked = False
        rbttnStudentFees.Checked = False
        cbbYear.Text = vbNullString
        cbbOrganization.Text = vbNullString
        Label1.Hide()
        Label2.Hide()
        cbbYear.Hide()
        cbbOrganization.Hide()
    End Sub

    Private Sub rbttnStudentFees_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbttnStudentFees.CheckedChanged
        If rbttnStudentFees.Checked = True Then
            Label1.Show()
            Label2.Hide()
            cbbYear.Show()
            cbbOrganization.Hide()
        End If
    End Sub

    Private Sub rbttnOrganizationFees_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbttnOrganizationFees.CheckedChanged
        If rbttnOrganizationFees.Checked = True Then
            Label1.Hide()
            Label2.Show()
            cbbYear.Hide()
            cbbOrganization.Show()
        End If
    End Sub

    Private Sub frmSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim CheckOrg(2) As String
        Dim Year As String = vbNullString

        ClrScrn()
        rbttnStudentFees.Checked = True

        If ChangeYear = "A " Then
            cbbYear.Items.Clear()
            cbbYear.Items.Add("1st")
            cbbYear.Items.Add("2nd")
            cbbYear.Items.Add("3rd")
            cbbYear.Items.Add("4th")
            cbbYear.Items.Add("5th")

        ElseIf ChangeYear = "B" Then
            strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    Year = .GetValue(8)
                End While
            End With

            cbbYear.Items.Clear()
            cbbYear.Items.Add(Year)
        End If

        If ChangeOrg = "A" Then
            cbbOrganization.Items.Clear()
            cbbOrganization.Items.Add("GENES ORGANIZATION")
            cbbOrganization.Items.Add("SIGMA")
            cbbOrganization.Items.Add("FYE")
            cbbOrganization.Items.Add("TEATRO BUGHAW")
            cbbOrganization.Items.Add("FAITH EDUCATORS")
            cbbOrganization.Items.Add("MORSEL")
            cbbOrganization.Items.Add("NOMADSS")
            cbbOrganization.Items.Add("AFEMS")
            cbbOrganization.Items.Add("KAMFIL")
            cbbOrganization.Items.Add("BYI")
            cbbOrganization.Items.Add("CCGI")

        ElseIf ChangeOrg = "B" Then
            strQuery = "Select * From `studentsinfo` Where `ID` = '" & SearchedID & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    CheckOrg(0) = .GetValue(10)
                    CheckOrg(1) = .GetValue(11)
                    CheckOrg(2) = .GetValue(12)
                End While
            End With

            cbbOrganization.Items.Clear()
            cbbOrganization.Items.Add(CheckOrg(0))
            cbbOrganization.Items.Add(CheckOrg(1))
            cbbOrganization.Items.Add(CheckOrg(2))
        End If
    End Sub

    Private Sub frmSelection_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ClrScrn()
    End Sub
End Class