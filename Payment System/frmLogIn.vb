Public Class frmLogIn
    Dim userInfo As String = System.IO.File.ReadAllText("C:\xampp\anonymous\SecureInfo\infouser.dll")
    Dim passInfo As String = System.IO.File.ReadAllText("C:\xampp\anonymous\SecureInfo\infopass.dll")

    Public Sub ClrScrn()
        txtUserName.Clear()
        txtPassword.Clear()
        txtUserName.Focus()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUserName.Text = userInfo And txtPassword.Text = passInfo Then
            MsgBox("Log In successfully.", , "College Of Education - Log In")
            Me.Hide()
            frmRecord.Show()
            ClrScrn()
        ElseIf txtUserName.Text = vbNullString Or txtPassword.Text = vbNullString Then
            MsgBox("Error!, Please enter username and password.", , "College Of Education - Log In")
            txtUserName.Focus()
        Else
            MsgBox("Log In failed.", , "College Of Education - Log In")
            txtUserName.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Shell("C:\xampp\xampp_stop.exe", AppWinStyle.Hide)
        Me.Close()
    End Sub

    Private Sub lnklblAbout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnklblAbout.LinkClicked
        frmAbout.Show()
    End Sub

    Private Sub pnlShortcut_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlShortcut.Click
        Me.Hide()
        frmRecord.Show()
        ClrScrn()
    End Sub

    Private Sub tmerAndSht_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmerAndSht.Tick
        'stmerAndSht.Stop()
    End Sub

    Private Sub frmLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Shell("C:\xampp\xampp_start.exe", AppWinStyle.Hide)
        Try
            Connection()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("You must reconfigure your connection first!", MsgBoxStyle.OkOnly)
            Form_ = New frmConfigure
            Form_.ShowDialog()
        End Try
    End Sub

    Private Sub tmerAndSht2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmerAndSht2.Tick
        lblTimeAndSht.Text = Now
    End Sub
End Class