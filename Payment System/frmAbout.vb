Public Class frmAbout

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        frmLogIn.ClrScrn()
        frmLogIn.Show()
    End Sub
End Class