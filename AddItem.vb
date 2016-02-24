Public Class AddItem

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        Form1.CurrItemID = Form1.CurrItemID + 1
        Form1.treeMods.Nodes.Insert(0, txtMyID.Text)
        Form1.treeMods.TopNode.Nodes.Add(lblWorkaround.Text & txtItemName.Text & lblWorkaround.Text)
        Form1.treeMods.TopNode.Nodes.Add(cboxItemTexture.Text)
        Form1.treeMods.TopNode.Nodes.Add("ItemCategory." & cboxCreative.Text)
        Controls.Clear()
        InitializeComponent()
        Hide()
        txtMyID.Text = Form1.CurrItemID
    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMyID.Text = Form1.CurrItemID
    End Sub
End Class