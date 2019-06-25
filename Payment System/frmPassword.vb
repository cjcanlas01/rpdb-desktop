Public Class frmPassword

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim Pass As String = System.IO.File.ReadAllText("C:\xampp\anonymous\SecureInfo\infopass.dll")

        If txtPassword.Text = Pass Then
            MsgBox("Password confirmed.", , "College Of Education - Password Confirmation")
            If isPass_ = "1" Then
                Me.Hide()
                frmCollection.AddFee()
            ElseIf isPass_ = "0" Then
                Me.Hide()
                frmCollection.RemoveFee()
            End If
        End If
    End Sub

End Class