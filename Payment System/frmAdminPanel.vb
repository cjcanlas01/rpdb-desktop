Public Class frmAdminPanel

    Public Function BackUP(ByVal Argument As String, ByVal SQLFileName As String) As Integer
        Dim BACKUPDIR_PATH = "C:\xampp\anonymous\" & Format(Date.Today, "MMM_dd_yyyy") & "\"
        System.IO.Directory.CreateDirectory(BACKUPDIR_PATH)
        Using myProcess As New Process()
            Dim newfiledb As String = BACKUPDIR_PATH & Format(Now(), "MMM_dd_yyyy").ToString & "_" & SQLFileName & "_local.sql"
            Try
                myProcess.StartInfo.FileName = "mysqldump.exe"
                myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
                myProcess.StartInfo.Arguments = Argument & newfiledb
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                myProcess.Start()
                myProcess.WaitForExit()
                'MsgBox("Backup Created ... " & vbNewLine & newfiledb)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical + vbOKOnly, ex.Message)
            Finally
                myProcess.Close()
            End Try
        End Using
        Return 1
    End Function

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        btnReset.Enabled = False
        SendQuery("DROP DATABASE `studentfeescoe`; DROP DATABASE `orgfee1`; DROP DATABASE `orgfee2`; DROP DATABASE `orgfee3`")
        Using myProcess As New Process()
            Try
                myProcess.StartInfo.FileName = "Patch.bat"
                myProcess.StartInfo.WorkingDirectory = "C:\xampp\anonymous\Patch\"
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                myProcess.Start()
                myProcess.WaitForExit()
                MsgBox("Reset of databases is successful")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical + vbOKOnly, ex.Message)
            Finally
                myProcess.Close()
            End Try
        End Using
        btnReset.Enabled = True
    End Sub

    Private Sub btnBackUp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackUp.Click
        Dim Count = 0
        btnBackUp.Enabled = False
        Count += BackUP("--host=localhost --user=root --password=1000101 studentfeescoe -r ", "studentfeescoe")
        Count += BackUP("--host=localhost --user=root --password=1000101 orgfee1 -r ", "orgfee1")
        Count += BackUP("--host=localhost --user=root --password=1000101 orgfee2 -r ", "orgfee2")
        Count += BackUP("--host=localhost --user=root --password=1000101 orgfee3 -r ", "orgfee3")

        If Count = 4 Then
            Using myProcess As New Process()
                Try
                    myProcess.StartInfo.FileName = "cmd.exe"
                    myProcess.StartInfo.WorkingDirectory = "C:\Windows\System32\"
                    myProcess.StartInfo.Arguments = "/c cd C:\xampp\anonymous && 7za a C:\xampp\anonymous\SQL_COED_archive_" & Format(Now(), "MMM_dd_yyyy@h_mm_ss_tt") & ".zip " & "C:\xampp\anonymous\" & Format(Date.Today, "MMM_dd_yyyy") & "\* -r && del C:\xampp\anonymous\" & Format(Date.Today, "MMM_dd_yyyy") & "\*.sql && rmdir " & "C:\xampp\anonymous\" & Format(Date.Today, "MMM_dd_yyyy")
                    myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    myProcess.Start()
                    myProcess.WaitForExit()
                    MsgBox("Databases successfully backed up and compressed.")
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical + vbOKOnly, ex.Message)
                Finally
                    myProcess.Close()
                End Try
            End Using
            btnBackUp.Enabled = True
        End If
    End Sub

    Private Sub frmAdminPanel_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "College Of Education - Student Information") = MsgBoxResult.Yes = True Then
            e.Cancel = False
            frmRecord.UpdateRecord()
        Else
            e.Cancel = True
        End If
    End Sub

End Class