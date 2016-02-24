Public Class Form1

    Public CurrItemID As Integer = 1000
    Public CurrBlockID As Integer = 200
    Public CustomString As String = ""

    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click

        Dim ModString As String = ""
        Dim RecipeString As String = ""

        For Each Node As TreeNode In treeMods.Nodes

            Dim ItemID As String = Node.Text
            Dim ItemName As String = Node.FirstNode.Text
            Dim ItemTexture As String = Node.FirstNode.NextNode.Text
            Dim ItemTab As String = Node.FirstNode.NextNode.NextNode.Text

            If Val(ItemID) > 0 Then
                If ItemID > 255 Then

                    ModString = ModString & "ModPE.setItem(" & ItemID & ", " & ItemTexture & ", " & ItemName & ");" & vbCrLf &
                                                            "Item.setCategory(" & ItemID & ", " & ItemTab & ");" & vbCrLf &
                                                            "Player.addItemCreativeInv(" & ItemID & ");" & vbCrLf

                ElseIf ItemID < 255 Then
                    Dim BlockColor As String = Node.FirstNode.NextNode.NextNode.NextNode.Text
                    Dim Hardness As String = Node.FirstNode.NextNode.NextNode.NextNode.NextNode.Text
                    Dim Luminance As String = Node.LastNode.Text

                    ModString = ModString & "Block.defineBlock(" & ItemID & ", " & ItemName & ", " & "[" & ItemTexture & "]);" & vbCrLf &
                                        "Item.setCategory(" & ItemID & ", " & ItemTab & ");" & vbCrLf &
                                        "Player.addItemCreativeInv(" & ItemID & ");" & vbCrLf
                    If Node.FirstNode.NextNode.NextNode.NextNode.Text <> "[0x]" Then
                        ModString = ModString & "Block.setColor(" & ItemID & ", " & BlockColor & ");" & vbCrLf
                    End If
                    If Node.FirstNode.NextNode.NextNode.NextNode.NextNode.Text <> 0 Then
                        ModString = ModString & "Block.setDestroyTime(" & ItemID & ", " & Hardness & ");" & vbCrLf
                    End If
                    If Node.LastNode.Text <> 0 Then
                        ModString = ModString & "Block.setLightLevel(" & ItemID & ", " & Luminance & ");" & vbCrLf &
                                                "Block.setLightOpacity(" & ItemID & ", " & 0.01 & ");" & vbCrLf
                    End If
                End If
            Else
                If ItemID = "Crafting" Then
                    RecipeString = RecipeString & "Item.addCraftRecipe(" & ItemName & "," & ItemTexture & ",0," & ItemTab & ");" & vbCrLf
                End If
                If ItemID = "Smelting" Then
                    RecipeString = RecipeString & "Item.addFurnaceRecipe(" & ItemTab & "," & ItemName & "," & ItemTexture & ");" & vbCrLf
                End If
            End If
        Next
        ModString = ModString & RecipeString & CustomString
        Dim sav As New SaveFileDialog
        sav.Filter = "MCPE Mod Script|*.js"
        If sav.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllText(sav.FileName, ModString)
        End If
    End Sub

    Private Sub cmdNewItem_Click(sender As Object, e As EventArgs) Handles cmdNewItem.Click
        AddItem.Show()
    End Sub

    Private Sub cmdNewBlock_Click(sender As Object, e As EventArgs) Handles cmdNewBlock.Click
        AddBlock.Show()
    End Sub

    Private Sub cmdAddCrafting_Click(sender As Object, e As EventArgs) Handles cmdAddCrafting.Click
        AddCrafting.Show()
    End Sub

    Private Sub cmdAddSmelting_Click(sender As Object, e As EventArgs) Handles cmdAddSmelting.Click
        AddSmelting.Show()
    End Sub

    Private Sub cmdItemIDList_Click(sender As Object, e As EventArgs) Handles cmdItemIDList.Click
        Dim url As String = “http://minecraft.gamepedia.com/Pocket_Edition_data_values“
        Process.Start(url)
    End Sub

    Private Sub cmdSettings_Click(sender As Object, e As EventArgs) Handles cmdSettings.Click
        Settings.Show()
    End Sub

    Private Sub cmdCustom_Click(sender As Object, e As EventArgs) Handles cmdCustom.Click
        AddCustom.Show()
    End Sub
End Class