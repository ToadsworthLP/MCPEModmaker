Public Class Settings
    Private Sub cmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click
        Form1.CurrBlockID = numBlockID.Text
        Form1.CurrItemID = numItemID.Text
        Hide()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numBlockID.Value = Form1.CurrBlockID
        numItemID.Value = Form1.CurrItemID
    End Sub
End Class