Public Class AddCustom
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Form1.CustomString = txtInput.Text
        MessageBox.Show("Added your code to the mod project!")
        Hide()
    End Sub

    Private Sub AddCustom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Text = Form1.CustomString
    End Sub
End Class