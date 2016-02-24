<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdNewItem = New System.Windows.Forms.Button()
        Me.treeMods = New System.Windows.Forms.TreeView()
        Me.cmdNewBlock = New System.Windows.Forms.Button()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.cmdAddCrafting = New System.Windows.Forms.Button()
        Me.cmdAddSmelting = New System.Windows.Forms.Button()
        Me.lblAboutItemIDs = New System.Windows.Forms.Label()
        Me.cmdItemIDList = New System.Windows.Forms.Button()
        Me.cmdSettings = New System.Windows.Forms.Button()
        Me.cmdCustom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(326, 30)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(175, 30)
        Me.cmdExport.TabIndex = 0
        Me.cmdExport.Text = "Export Mod"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdNewItem
        '
        Me.cmdNewItem.Location = New System.Drawing.Point(326, 100)
        Me.cmdNewItem.Name = "cmdNewItem"
        Me.cmdNewItem.Size = New System.Drawing.Size(175, 30)
        Me.cmdNewItem.TabIndex = 1
        Me.cmdNewItem.Text = "Add Item"
        Me.cmdNewItem.UseVisualStyleBackColor = True
        '
        'treeMods
        '
        Me.treeMods.Location = New System.Drawing.Point(38, 30)
        Me.treeMods.Name = "treeMods"
        Me.treeMods.Size = New System.Drawing.Size(245, 315)
        Me.treeMods.TabIndex = 2
        '
        'cmdNewBlock
        '
        Me.cmdNewBlock.Location = New System.Drawing.Point(326, 136)
        Me.cmdNewBlock.Name = "cmdNewBlock"
        Me.cmdNewBlock.Size = New System.Drawing.Size(175, 30)
        Me.cmdNewBlock.TabIndex = 3
        Me.cmdNewBlock.Text = "Add Block"
        Me.cmdNewBlock.UseVisualStyleBackColor = True
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.Location = New System.Drawing.Point(407, 387)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(118, 13)
        Me.lblCredits.TabIndex = 4
        Me.lblCredits.Text = "Made by ToadsworthLP"
        '
        'cmdAddCrafting
        '
        Me.cmdAddCrafting.Location = New System.Drawing.Point(326, 172)
        Me.cmdAddCrafting.Name = "cmdAddCrafting"
        Me.cmdAddCrafting.Size = New System.Drawing.Size(175, 30)
        Me.cmdAddCrafting.TabIndex = 5
        Me.cmdAddCrafting.Text = "Add Crafting Recipe"
        Me.cmdAddCrafting.UseVisualStyleBackColor = True
        '
        'cmdAddSmelting
        '
        Me.cmdAddSmelting.Location = New System.Drawing.Point(326, 208)
        Me.cmdAddSmelting.Name = "cmdAddSmelting"
        Me.cmdAddSmelting.Size = New System.Drawing.Size(175, 30)
        Me.cmdAddSmelting.TabIndex = 6
        Me.cmdAddSmelting.Text = "Add Smelting Recipe"
        Me.cmdAddSmelting.UseVisualStyleBackColor = True
        '
        'lblAboutItemIDs
        '
        Me.lblAboutItemIDs.AutoSize = True
        Me.lblAboutItemIDs.Location = New System.Drawing.Point(35, 366)
        Me.lblAboutItemIDs.Name = "lblAboutItemIDs"
        Me.lblAboutItemIDs.Size = New System.Drawing.Size(171, 34)
        Me.lblAboutItemIDs.TabIndex = 8
        Me.lblAboutItemIDs.Text = "ItemIDs (Use the numbers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in the ""DEC""-Column):"
        '
        'cmdItemIDList
        '
        Me.cmdItemIDList.Location = New System.Drawing.Point(246, 366)
        Me.cmdItemIDList.Name = "cmdItemIDList"
        Me.cmdItemIDList.Size = New System.Drawing.Size(35, 33)
        Me.cmdItemIDList.TabIndex = 9
        Me.cmdItemIDList.Text = "?"
        Me.cmdItemIDList.UseVisualStyleBackColor = True
        '
        'cmdSettings
        '
        Me.cmdSettings.Location = New System.Drawing.Point(326, 315)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Size = New System.Drawing.Size(175, 30)
        Me.cmdSettings.TabIndex = 10
        Me.cmdSettings.Text = "Settings"
        Me.cmdSettings.UseVisualStyleBackColor = True
        '
        'cmdCustom
        '
        Me.cmdCustom.Location = New System.Drawing.Point(326, 244)
        Me.cmdCustom.Name = "cmdCustom"
        Me.cmdCustom.Size = New System.Drawing.Size(175, 30)
        Me.cmdCustom.TabIndex = 11
        Me.cmdCustom.Text = "Add Custom Code"
        Me.cmdCustom.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 413)
        Me.Controls.Add(Me.cmdCustom)
        Me.Controls.Add(Me.cmdSettings)
        Me.Controls.Add(Me.cmdItemIDList)
        Me.Controls.Add(Me.lblAboutItemIDs)
        Me.Controls.Add(Me.cmdAddSmelting)
        Me.Controls.Add(Me.cmdAddCrafting)
        Me.Controls.Add(Me.lblCredits)
        Me.Controls.Add(Me.cmdNewBlock)
        Me.Controls.Add(Me.treeMods)
        Me.Controls.Add(Me.cmdNewItem)
        Me.Controls.Add(Me.cmdExport)
        Me.Name = "Form1"
        Me.Text = "Minecraft: PE Mod Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdExport As Button
    Friend WithEvents cmdNewItem As Button
    Friend WithEvents treeMods As TreeView
    Friend WithEvents cmdNewBlock As Button
    Friend WithEvents lblCredits As Label
    Friend WithEvents cmdAddCrafting As Button
    Friend WithEvents cmdAddSmelting As Button
    Friend WithEvents lblAboutItemIDs As Label
    Friend WithEvents cmdItemIDList As Button
    Friend WithEvents cmdSettings As Button
    Friend WithEvents cmdCustom As Button
End Class
