Public Class AddCrafting
    Private Sub cmdIDHelp_Click(sender As Object, e As EventArgs)
        Dim url As String = “http://minecraft.gamepedia.com/Pocket_Edition_data_values“
        Process.Start(url)
    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        Dim IngredientString As String = ""
        Dim MyNumber As Integer = 1
        Form1.treeMods.Nodes.Insert(0, "Crafting")
        Form1.treeMods.TopNode.Nodes.Add(numOutput.Text)
        Form1.treeMods.TopNode.Nodes.Add(numOutputNumber.Text)
        For Each Litem As String In lstIngredients.Items
            IngredientString = IngredientString & Litem & ",1,0"
            If MyNumber < lstIngredients.Items.Count Then
                IngredientString = IngredientString & ","
            End If
            MyNumber = MyNumber + 1
        Next
        Form1.treeMods.TopNode.Nodes.Add("[" & IngredientString & "]")
        Controls.Clear()
        InitializeComponent()
        Hide()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        lstIngredients.Items.Add(numInputID.Text)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If lstIngredients.SelectedIndex <> -1 Then
            lstIngredients.Items.RemoveAt(lstIngredients.SelectedIndex)
        End If
    End Sub
End Class