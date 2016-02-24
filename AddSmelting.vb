Public Class AddSmelting
    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        Form1.treeMods.Nodes.Insert(0, "Smelting")
        Form1.treeMods.TopNode.Nodes.Add(numOutput.Text)
        Form1.treeMods.TopNode.Nodes.Add("0")
        Form1.treeMods.TopNode.Nodes.Add(numInput.Text)
        Controls.Clear()
        InitializeComponent()
        Hide()
    End Sub

    Private Sub cmdIDHelp_Click(sender As Object, e As EventArgs)
        Dim url As String = “http://minecraft.gamepedia.com/Pocket_Edition_data_values“
        Process.Start(url)
    End Sub
End Class