Public Class frmCollection
    Dim strQuery, strQuery2 As String
    Dim semA = "1st"
    Dim semB = "2nd"
    Dim ID As String = "##-####"

    Dim Sem As String = vbNullString
    Dim Cost_Itm As String = vbNullString
    Dim Datepaid_ As String = vbNullString
    Dim Payments_ As String = vbNullString
    Dim Particulars_ As String = vbNullString
    Dim If_ As String = vbNullString

    Public Sub RemoveFee()
        Dim Desc = "Fee Description #" + txtNo.Text
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

        If MsgBox("Are you sure you want to delete this fee?", MsgBoxStyle.YesNo, "College Of Education - Fee Collection") = MsgBoxResult.Yes Then

            If rbttn1stSem.Checked = True Then
                Sem = "fees1stsem"
                Cost_Itm = "cost1stsem"
                Datepaid_ = "datepaid1stsem"
                Payments_ = "payment1stsem"
                Particulars_ = "particulars1stsem"
                If_ = "if1stsemester"
            ElseIf rbttn2ndSem.Checked = True Then
                Sem = "fees2ndsem"
                Cost_Itm = "cost2ndsem"
                Datepaid_ = "datepaid2ndsem"
                Payments_ = "payment2ndsem"
                Particulars_ = "particulars2ndsem"
                If_ = "if2ndsemester"
            End If

            If Trigger = "A" Then
                strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '' Where `ID` = '" & ID.ToString & "';" & _
                    "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '0' Where `ID` = '" & ID.ToString & "';" & _
                    "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '' Where `ID` = '" & ID.ToString & "';" & _
                    "Update `" & Sem & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-###1' And `ID` not like '##-###2' And `ID` not like '##-###3' And `ID` not like '##-###4' And `ID` not like '##-###5' And `Year` = '" & Year_.ToString & "';" & _
                   "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '0' Where `ID` not like '##-###1' And `ID` not like '##-###2' And `ID` not like '##-###3' And `ID` not like '##-###4' And `ID` not like '##-###5' And `Year` = '" & Year_.ToString & "';" & _
                   "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-###1' And `ID` not like '##-###2' And `ID` not like '##-###3' And `ID` not like '##-###4' And `ID` not like '##-###5' And `Year` = '" & Year_.ToString & "';" & _
                   "Update `" & Datepaid_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-###1' And `ID` not like '##-###2' And `ID` not like '##-###3' And `ID` not like '##-###4' And `ID` not like '##-###5' And `Year` = '" & Year_.ToString & "';" & _
                   "Update `" & Payments_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-###1' And `ID` not like '##-###2' And `ID` not like '##-###3' And `ID` not like '##-###4' And `ID` not like '##-###5' And `Year` = '" & Year_.ToString & "';" & _
                    "Update `" & If_ & "` Set `" & txtNo.Text & "` = '0' Where `ID` not like '##-###1' And `ID` not like '##-###2' And `ID` not like '##-###3' And `ID` not like '##-###4' And `ID` not like '##-###5' And `Year` = '" & Year_.ToString & "'"
                SendQuery(strQuery)
            ElseIf Trigger = "B" Then
                strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '' Where `ID` = '" & ID.ToString & "';" & _
                    "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '0' Where `ID` = '" & ID.ToString & "';" & _
                    "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '' Where `ID` = '" & ID.ToString & "'"
                SendQuery2(strQuery, "orgfee1")
                SendQuery2(strQuery, "orgfee2")
                SendQuery2(strQuery, "orgfee3")

                strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 1` = '" & Organization_.ToString & "';" & _
                   "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '0' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 1` = '" & Organization_.ToString & "';" & _
                   "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 1` = '" & Organization_.ToString & "';" & _
                   "Update `" & Datepaid_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 1` = '" & Organization_.ToString & "';" & _
                   "Update `" & Payments_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 1` = '" & Organization_.ToString & "';" & _
                    "Update `" & If_ & "` Set `" & txtNo.Text & "` = '0' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 1` = '" & Organization_.ToString & "'"
                SendQuery2(strQuery, "orgfee1")
                strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 2` = '" & Organization_.ToString & "';" & _
                   "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '0' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 2` = '" & Organization_.ToString & "';" & _
                   "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 2` = '" & Organization_.ToString & "';" & _
                   "Update `" & Datepaid_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 2` = '" & Organization_.ToString & "';" & _
                   "Update `" & Payments_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 2` = '" & Organization_.ToString & "';" & _
                    "Update `" & If_ & "` Set `" & txtNo.Text & "` = '0' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 2` = '" & Organization_.ToString & "'"
                SendQuery2(strQuery, "orgfee2")
                strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 3` = '" & Organization_.ToString & "';" & _
                   "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '0' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 3` = '" & Organization_.ToString & "';" & _
                   "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 3` = '" & Organization_.ToString & "';" & _
                   "Update `" & Datepaid_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 3` = '" & Organization_.ToString & "';" & _
                   "Update `" & Payments_ & "` Set `" & txtNo.Text & "` = '' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 3` = '" & Organization_.ToString & "';" & _
                    "Update `" & If_ & "` Set `" & txtNo.Text & "` = '0' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 3` = '" & Organization_.ToString & "'"
                SendQuery2(strQuery, "orgfee3")
            End If
        End If
        UpdateFirstSem()
        UpdateSecondSem()
        UpdateLabelTotal()
        ClrScrn()
    End Sub

    Public Sub AddFee()
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
            Sem = "fees1stsem"
            Cost_Itm = "cost1stsem"
            Particulars_ = "particulars1stsem"

        ElseIf rbttn2ndSem.Checked = True Then
            Sem = "fees2ndsem"
            Cost_Itm = "cost2ndsem"
            Particulars_ = "particulars2ndsem"

        End If

                If MsgBox("Do you want to save it?", MsgBoxStyle.YesNo, "College Of Education - Fee Collection") = MsgBoxResult.Yes Then
                    Try
                        If Trigger = "A" Then
                            strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '" & txtCollection.Text & "' Where `ID` = '" & ID.ToString & "';" & _
                                       "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '" & txtAmount.Text & "' Where `ID` = '" & ID.ToString & "';" & _
                                       "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '" & txtParticulars.Text & "' Where `ID` = '" & ID.ToString & "'"
                            SendQuery(strQuery)
                            strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '" & txtCollection.Text & "' Where `ID` not like '##-###1' And `ID` not like '##-###2' And `ID` not like '##-###3' And `ID` not like '##-###4' And `ID` not like '##-###5' And `Year` = '" & Year_.ToString & "';" & _
                                       "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '" & txtAmount.Text & "' Where `ID` not like '##-###1' And `ID` not like '##-###2' And `ID` not like '##-###3' And `ID` not like '##-###4' And `ID` not like '##-###5' And `Year` = '" & Year_.ToString & "';" & _
                                       "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '" & txtParticulars.Text & "' Where `ID` not like '##-###1' And `ID` not like '##-###2' And `ID` not like '##-###3' And `ID` not like '##-###4' And `ID` not like '##-###5' And `Year` = '" & Year_.ToString & "'"
                            SendQuery(strQuery)
                        ElseIf Trigger = "B" Then
                            strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '" & txtCollection.Text & "' Where `ID` = '" & ID.ToString & "';" & _
                                   "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '" & txtAmount.Text & "' Where `ID` = '" & ID.ToString & "';" & _
                                   "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '" & txtParticulars.Text & "' Where `ID` = '" & ID.ToString & "'"
                            SendQuery2(strQuery, "orgfee1")
                            SendQuery2(strQuery, "orgfee2")
                            SendQuery2(strQuery, "orgfee3")
                            strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '" & txtCollection.Text & "' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 1` like '" & Organization_.ToString & "';" & _
                                   "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '" & txtAmount.Text & "' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 1` like '" & Organization_.ToString & "';" & _
                                   "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '" & txtParticulars.Text & "' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 1` like '" & Organization_.ToString & "'"
                            SendQuery2(strQuery, "orgfee1")
                            strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '" & txtCollection.Text & "' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 2` like '" & Organization_.ToString & "';" & _
                                   "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '" & txtAmount.Text & "' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 2` like '" & Organization_.ToString & "';" & _
                                   "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '" & txtParticulars.Text & "' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 2` like '" & Organization_.ToString & "'"
                            SendQuery2(strQuery, "orgfee2")
                            strQuery = "Update `" & Sem & "` Set `" & txtNo.Text & "` = '" & txtCollection.Text & "' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 3` like '" & Organization_.ToString & "';" & _
                                   "Update `" & Cost_Itm & "` Set `" & txtNo.Text & "` = '" & txtAmount.Text & "' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 3` like '" & Organization_.ToString & "';" & _
                                   "Update `" & Particulars_ & "` Set `" & txtNo.Text & "` = '" & txtParticulars.Text & "' Where `ID` not like '##-##GC' And  `ID` not like '##-##SI' And  `ID` not like '##-##F1' And  `ID` not like '##-##F2' And  `ID` not like '##-##F3' And  `ID` not like '##-##FA'  And  `ID` not like '##-##EC' And  `ID` not like '##-##SS' And  `ID` not like '##-##MC' And  `ID` not like '##-##KA' And  `Organization 3` like '" & Organization_.ToString & "'"
                            SendQuery2(strQuery, "orgfee3")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, , "College Of Education - Fee Collection")
                    End Try
                    MsgBox("Success! Data saved.", , "College Of Education - Fee Collection")

                    ClrScrn()
                    UpdateFirstSem()
                    UpdateSecondSem()
                    UpdateLabelTotal()
        End If
    End Sub

    Public Sub ClrScrn()
        txtNo.Clear()
        txtAmount.Clear()
        txtCollection.Clear()
        txtParticulars.Clear()
    End Sub

    Private Sub UpdateLabelTotal()
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

        Dim IndexB As Integer = 1
        Dim IndexD As Integer = 0
        Dim Total As Integer
        Dim Cost_ = vbNullString

        If rbttn1stSem.Checked = True Then
            Cost_ = "cost1stsem"
        End If

        If rbttn2ndSem.Checked = True Then
            Cost_ = "cost2ndsem"
        End If

        If Trigger = "A" Then
            strQuery = "Select * From `" & Cost_ & "` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not IndexD = 20
                        Total = Total + Val(.GetValue(IndexB))
                        IndexB = IndexB + 1
                        IndexD = IndexD + 1
                    End While
                End While
            End With

        ElseIf Trigger = "B" Then
            strQuery = "Select * From `" & Cost_ & "` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery2(strQuery, "orgfee1")
            With Reader_2
                While .Read
                    While Not IndexD = 20
                        Total = Total + Val(.GetValue(IndexB))
                        IndexB = IndexB + 1
                        IndexD = IndexD + 1
                    End While
                End While
            End With
        End If


        If rbttn1stSem.Checked = True Then
            lblTotal1.Text = Total
        End If

        If rbttn2ndSem.Checked = True Then
            lblTotal2.Text = Total
        End If
    End Sub

    Private Sub UpdateFirstSem()
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

        If Trigger = "A" Then
            'Load datagridview from two SQL statements
            strQuery = "Select * From `fees1stsem` Where `ID` = '" & ID.ToString & "'"
            dgv1stCollection.Rows.Clear()
            ReaderQuery(strQuery)
            Dim A As Integer
            Dim B As Integer = 1
            Dim C As Integer = 1
            Dim D As Integer

            With Reader_
                While .Read
                    While Not A = 39
                        A = dgv1stCollection.Rows.Add
                        dgv1stCollection.Item(0, A).Value = A + 1
                        dgv1stCollection.Item(1, A).Value = .GetValue(C).ToString
                        C = C + 1
                    End While
                End While
            End With

            strQuery = "Select * From `particulars1stsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not D = 40
                        dgv1stCollection.Item(2, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `cost1stsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not D = 40
                        dgv1stCollection.Item(3, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
            End With
            B = 1
            D = 0

        ElseIf Trigger = "B" Then

            'Load datagridview from two SQL statements
            strQuery = "Select * From `fees1stsem` Where `ID` = '" & ID.ToString & "'"
            dgv1stCollection.Rows.Clear()
            ReaderQuery2(strQuery, "orgfee1")

            Dim A As Integer
            Dim B As Integer = 1
            Dim C As Integer = 1
            Dim D As Integer

            With Reader_2
                While .Read
                    While Not A = 39
                        A = dgv1stCollection.Rows.Add
                        dgv1stCollection.Item(0, A).Value = A + 1
                        dgv1stCollection.Item(1, A).Value = .GetValue(C).ToString
                        C = C + 1
                    End While
                End While
            End With

            strQuery = "Select * From `particulars1stsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery2(strQuery, "orgfee1")
            With Reader_2
                While .Read
                    While Not D = 40
                        dgv1stCollection.Item(2, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `cost1stsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery2(strQuery, "orgfee1")
            With Reader_2
                While .Read
                    While Not D = 40
                        dgv1stCollection.Item(3, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
            End With
            B = 1
            D = 0
        End If

    End Sub

    Private Sub UpdateSecondSem()
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

        If Trigger = "A" Then
            strQuery = "Select * From `fees2ndsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery(strQuery)
            dgv2ndCollection.Rows.Clear()

            Dim A As Integer
            Dim B As Integer = 1
            Dim C As Integer = 1
            Dim D As Integer

            With Reader_
                While .Read
                    While Not A = 39
                        A = dgv2ndCollection.Rows.Add
                        dgv2ndCollection.Item(0, A).Value = A + 1
                        dgv2ndCollection.Item(1, A).Value = .GetValue(C).ToString
                        C = C + 1
                    End While
                End While
            End With

            strQuery = "Select * From `particulars2ndsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not D = 40
                        dgv2ndCollection.Item(2, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `cost2ndsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    While Not D = 40
                        dgv2ndCollection.Item(3, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

        ElseIf Trigger = "B" Then
            strQuery = "Select * From `fees2ndsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery2(strQuery, "orgfee1")
            dgv2ndCollection.Rows.Clear()

            Dim A As Integer
            Dim B As Integer = 1
            Dim C As Integer = 1
            Dim D As Integer

            With Reader_2
                While .Read
                    While Not A = 39
                        A = dgv2ndCollection.Rows.Add
                        dgv2ndCollection.Item(0, A).Value = A + 1
                        dgv2ndCollection.Item(1, A).Value = .GetValue(C).ToString
                        C = C + 1
                    End While
                End While
            End With

            strQuery = "Select * From `particulars2ndsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery2(strQuery, "orgfee1")
            With Reader_2
                While .Read
                    While Not D = 40
                        dgv2ndCollection.Item(2, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With

            strQuery = "Select * From `cost2ndsem` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery2(strQuery, "orgfee1")
            With Reader_2
                While .Read
                    While Not D = 40
                        dgv2ndCollection.Item(3, D).Value = .GetValue(B).ToString
                        B = B + 1
                        D = D + 1
                    End While
                End While
                B = 1
                D = 0
            End With
        End If
    End Sub

    Private Sub frmCollection_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "College Of Education - Fee Collection") = MsgBoxResult.Yes = True Then
            e.Cancel = False
            ClearTrigs()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

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
            Cost_Itm = "cost1stsem"
        ElseIf rbttn2ndSem.Checked = True Then
            Cost_Itm = "cost2ndsem"
        End If

        Dim Confirm As Integer = 0
        If Trigger = "A" Then

            strQuery = "Select * From `" & Cost_Itm & "` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery(strQuery)
            With Reader_
                While .Read
                    Confirm = .GetValue(Val(txtNo.Text))
                End While
            End With
        ElseIf Trigger = "B" Then
            strQuery = "Select * From `" & Cost_Itm & "` Where `ID` = '" & ID.ToString & "'"
            ReaderQuery2(strQuery, "orgfee1")
            With Reader_2
                While .Read
                    Confirm = .GetValue(Val(txtNo.Text))
                End While
            End With
        End If
        If txtNo.Text = vbNullString Or txtCollection.Text = vbNullString Or txtParticulars.Text = vbNullString Or txtAmount.Text = vbNullString Then
            MsgBox("Please complete all the information.", , "College Of Education - Fee Collection")
            MsgBox(Confirm)
            MsgBox(txtNo.Text)
        ElseIf Not Confirm = Val(txtAmount.Text) Then
            If Confirm = 0 Then
                isPass_ = "1"
                frmPassword.txtPassword.Clear()
                frmPassword.Show()
            Else
                MsgBox("Error!  Changing of fee occur. Please remove fee and add a new instead.", , "College Of Education - Collection Fee")
            End If
        End If
    End Sub

    Private Sub btnRemove_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If txtNo.Text = vbNullString Or txtCollection.Text = vbNullString Or txtParticulars.Text = vbNullString Or txtAmount.Text = vbNullString Then
            MsgBox("Please complete all the information.", , "College Of Education - Fee Collection")
        Else
            isPass_ = "0"
            frmPassword.txtPassword.Clear()
            frmPassword.Show()
        End If
    End Sub

    Private Sub rbttn1stSem_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbttn1stSem.CheckedChanged
        If rbttn1stSem.Checked = True Then
            tabCollection.SelectTab(0)
            UpdateLabelTotal()
            ClrScrn()
        End If
    End Sub

    Private Sub rbttn2ndSem_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbttn2ndSem.CheckedChanged
        If rbttn2ndSem.Checked = True Then
            tabCollection.SelectTab(1)
            UpdateLabelTotal()
            ClrScrn()
        End If
    End Sub

    Private Sub txtNo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNo.TextChanged
        If txtNo.Text = vbNullString Or Val(txtNo.Text) = 0 Or Val(txtNo.Text) > 20 Then
            txtCollection.ReadOnly = True
            txtCollection.Clear()
            btnAdd.Enabled = False
            btnRemove.Enabled = False
        Else
            btnAdd.Enabled = True
            btnRemove.Enabled = True
            txtCollection.ReadOnly = False
        End If
    End Sub

    Private Sub txtNo_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNo.KeyPress
        If Asc(e.KeyChar) < 58 And Asc(e.KeyChar) > 47 Or Asc(e.KeyChar) = 8 Then
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtAmount_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If Asc(e.KeyChar) < 58 And Asc(e.KeyChar) > 47 Or Asc(e.KeyChar) = 8 Then
        Else
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub tabCollection_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabCollection.Click
        If tabCollection.SelectedTab.Text = "1st Semester" Then
            rbttn1stSem.Checked = True
            UpdateLabelTotal()
            ClrScrn()
        ElseIf tabCollection.SelectedTab.Text = "2nd Semester" Then
            rbttn2ndSem.Checked = True
            UpdateLabelTotal()
            ClrScrn()
        End If
    End Sub

    Private Sub frmCollection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Trigger = "A" Then
            lblOrgName.Text = "Year: " + Year_
        ElseIf Trigger = "B" Then
            lblOrgName.Text = "Org.: " + Organization_
        End If

        rbttn1stSem.Checked = True
        ClrScrn()
        UpdateFirstSem()
        UpdateSecondSem()
        UpdateLabelTotal()
    End Sub

    Private Sub txtCollection_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCollection.TextChanged
        If txtCollection.Text = vbNullString Then
            txtParticulars.ReadOnly = True
        Else
            txtParticulars.ReadOnly = False
        End If
    End Sub

    Private Sub dgv1stCollection_CellClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1stCollection.CellClick
        txtNo.Text = dgv1stCollection.Item(0, dgv1stCollection.CurrentCell.RowIndex).Value
        txtCollection.Text = dgv1stCollection.Item(1, dgv1stCollection.CurrentCell.RowIndex).Value
        txtParticulars.Text = dgv1stCollection.Item(2, dgv1stCollection.CurrentCell.RowIndex).Value
        txtAmount.Text = dgv1stCollection.Item(3, dgv1stCollection.CurrentCell.RowIndex).Value
    End Sub

    Private Sub txtParticulars_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParticulars.TextChanged
        If txtCollection.Text = vbNullString Then
            txtAmount.ReadOnly = True
        Else
            txtAmount.ReadOnly = False
        End If
    End Sub

    Private Sub dgv2ndCollection_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2ndCollection.CellClick
        txtNo.Text = dgv2ndCollection.Item(0, dgv2ndCollection.CurrentCell.RowIndex).Value
        txtCollection.Text = dgv2ndCollection.Item(1, dgv2ndCollection.CurrentCell.RowIndex).Value
        txtParticulars.Text = dgv2ndCollection.Item(2, dgv2ndCollection.CurrentCell.RowIndex).Value
        txtAmount.Text = dgv2ndCollection.Item(3, dgv2ndCollection.CurrentCell.RowIndex).Value
    End Sub

    Private Sub bttnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNew.Click
        ClearTrigs()
        Me.Close()
        isPassSF_ = "A"
        isPassOF_ = "A"
        isPassCC_ = "A"
        ChangeOrg = "A"
        ChangeYear = "A"
        frmSelection.ClrScrn()
        frmSelection.Show()
    End Sub
End Class