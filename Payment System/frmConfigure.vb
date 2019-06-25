Imports System.IO
Public Class frmConfigure

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        MsgBox("Good Bye.")
        End
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        MsgBox("Good Bye.")
        End
    End Sub

    Dim fs As FileStream

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            'To edit Server.text
            fs = New FileStream(My.Application.Info.DirectoryPath & "\Connection\Server.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            fs.SetLength(txtServer.TextLength - 1)
            fs.Position = 0
            For i As Integer = 0 To txtServer.TextLength - 1
                fs.WriteByte(CByte(Asc(txtServer.Text.Chars(i))))
            Next i
            fs.Close()
            'to edit Userid.txt
            fs = New FileStream(My.Application.Info.DirectoryPath & "\Connection\Userid.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            fs.SetLength(txtUserid.TextLength - 1)
            fs.Position = 0
            For i As Integer = 0 To txtUserid.TextLength - 1
                fs.WriteByte(CByte(Asc(txtUserid.Text.Chars(i))))
            Next i
            fs.Close()
            'to edit Password.txt
            fs = New FileStream(My.Application.Info.DirectoryPath & "\Connection\Password.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            fs.SetLength(txtPassword.TextLength - 1)
            fs.Position = 0
            For i As Integer = 0 To txtPassword.TextLength - 1
                fs.WriteByte(CByte(Asc(txtPassword.Text.Chars(i))))
            Next i
            fs.Close()
            'to Edit Database.txt
            fs = New FileStream(My.Application.Info.DirectoryPath & "\Connection\Database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            fs.SetLength(txtDatabase.TextLength - 1)
            fs.Position = 0
            For i As Integer = 0 To txtDatabase.TextLength - 1
                fs.WriteByte(CByte(Asc(txtDatabase.Text.Chars(i))))
            Next i
            fs.Close()
            MsgBox("Configuration successfully!" + vbNewLine + "Reopen the application.")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()
    End Sub
    Dim len As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'to edit Server.text
            fs = New FileStream(My.Application.Info.DirectoryPath & "\Connection\Server.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            len = fs.Length - 1
            fs.Position = 0
            For i As Integer = 0 To len
                txtServer.Text = txtServer.Text + ChrW(fs.ReadByte())
            Next i
            fs.Close()
            len = 0
            'to edit Userid.txt
            fs = New FileStream(My.Application.Info.DirectoryPath & "\Connection\Userid.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            len = fs.Length - 1
            fs.Position = 0
            For i As Integer = 0 To len
                txtUserid.Text = txtUserid.Text + ChrW(fs.ReadByte())
            Next i
            fs.Close()
            len = 0
            'to edit Password.txt
            fs = New FileStream(My.Application.Info.DirectoryPath & "\Connection\Password.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            len = fs.Length - 1
            fs.Position = 0
            For i As Integer = 0 To len
                txtPassword.Text = txtPassword.Text + ChrW(fs.ReadByte())
            Next i
            fs.Close()
            len = 0
            'to Edit Database.txt
            fs = New FileStream(My.Application.Info.DirectoryPath & "\Connection\Database.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            len = fs.Length - 1
            fs.Position = 0
            For i As Integer = 0 To len
                txtDatabase.Text = txtDatabase.Text + ChrW(fs.ReadByte())
            Next i
            fs.Close()
            len = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class