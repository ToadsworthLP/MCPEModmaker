Imports System.Net

Public Class AddBlock

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        Form1.CurrBlockID = Form1.CurrBlockID + 1
        Form1.treeMods.Nodes.Insert(0, txtMyID.Text)
        Form1.treeMods.TopNode.Nodes.Add(lblWorkaround.Text & txtItemName.Text & lblWorkaround.Text)
        Form1.treeMods.TopNode.Nodes.Add("[" & cboxTextureDown.Text & "],[" & cboxTextureUp.Text & "],[" & cboxTextureSides.Text & "],[" & cboxTextureSides.Text & "],[" & cboxTextureSides.Text & "],[" & cboxTextureSides.Text & "]")
        Form1.treeMods.TopNode.Nodes.Add("ItemCategory." & cboxCreative.Text)
        Form1.treeMods.TopNode.Nodes.Add("[0x" & txtColor.Text & "]")
        Form1.treeMods.TopNode.Nodes.Add(numHardness.Text)
        Form1.treeMods.TopNode.Nodes.Add(numLuminance.Text)
        Controls.Clear()
        InitializeComponent()
        Hide()
        txtMyID.Text = Form1.CurrBlockID
    End Sub

    Private Sub AddBlock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMyID.Text = Form1.CurrBlockID
    End Sub

    Private Sub lblColor_CheckedChanged(sender As Object, e As EventArgs) Handles lblColor.CheckedChanged
        If txtColor.Enabled = True Then
            txtColor.Enabled = False
        Else
            txtColor.Enabled = True
        End If
    End Sub

    Private Sub cmdColorHelp_Click(sender As Object, e As EventArgs) Handles cmdColorHelp.Click
        Dim url As String = “http://www.rapidtables.com/web/color/color-picker.htm“
        Process.Start(url)
        MessageBox.Show("Use the color code next to the hashtag and type it into the text field!")
    End Sub

    Private Sub lblLuminance_CheckedChanged(sender As Object, e As EventArgs) Handles lblLuminance.CheckedChanged
        If numLuminance.Enabled = True Then
            numLuminance.Enabled = False
        Else
            numLuminance.Enabled = True
        End If
    End Sub
End Class