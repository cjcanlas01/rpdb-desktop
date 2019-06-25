Public Class frmOption
    Dim Dialog_ As DialogResult = Windows.Forms.DialogResult.Abort
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dialog_ = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dialog_ = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub btnCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollection.Click
        Dialog_ = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmOption_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = Dialog_
        ClearTrigs()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dialog_ = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class