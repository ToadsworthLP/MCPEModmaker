<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItem
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAddItem = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.cboxItemTexture = New System.Windows.Forms.ComboBox()
        Me.lblTexture = New System.Windows.Forms.Label()
        Me.lblCreativeTab = New System.Windows.Forms.Label()
        Me.cboxCreative = New System.Windows.Forms.ComboBox()
        Me.lblMyID = New System.Windows.Forms.Label()
        Me.txtMyID = New System.Windows.Forms.TextBox()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.lblWorkaround = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAddItem
        '
        Me.lblAddItem.AutoSize = True
        Me.lblAddItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddItem.Location = New System.Drawing.Point(180, 25)
        Me.lblAddItem.Name = "lblAddItem"
        Me.lblAddItem.Size = New System.Drawing.Size(78, 24)
        Me.lblAddItem.TabIndex = 0
        Me.lblAddItem.Text = "Add Item"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(33, 75)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(79, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Item Name:"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(135, 72)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(260, 22)
        Me.txtItemName.TabIndex = 2
        '
        'cboxItemTexture
        '
        Me.cboxItemTexture.FormattingEnabled = True
        Me.cboxItemTexture.Items.AddRange(New Object() {"""apple"",0", """apple_golden"",0", """arrow"",0", """axe"",0", """axe"",1", """axe"",2", """axe"",3", """axe"",4", """bed"",0", """beef_cooked"",0" & Global.Microsoft.VisualBasic.ChrW(9), """beef_raw"",0", """blaze_powder"",0", """blaze_rod"",0", """boat"",0", """boat"",1", """boat"",2", """boat"",3", """boat"",4", """boat"",5", """bone"",0", """book_enchanted"",0", """book_normal"",0", """book_writable"",0", """book_written"",0", """boots"",0", """boots"",1", """boots"",2", """boots"",3", """boots"",4", """bowl"",0", """bow_pulling"",0", """bow_pulling"",1", """bow_pulling"",2", """bow_standby"",0", """bread"",0", """brewing_stand"",0", """brick"",0", """bucket"",0", """bucket"",1", """bucket"",2", """bucket"",3", """cake"",0", """carrot"",0", """carrot_golden"",0", """carrot_on_a_stick"",0", """beetroot"",0", """cauldron"",0", """charcoal"",0", """chestplate"",0", """chestplate"",1", """chestplate"",2", """chestplate"",3", """chestplate"",4", """chicken_cooked"",0", """chicken_raw"",0", """clay_ball"",0", """coal"",0", """comparator"",0", """cookie"",0", """diamond"",0", """diamond_horse_armor"",0", """door_iron"",0", """door_wood"",0", """door_spruce"",0", """door_birch"",0", """door_jungle"",0", """door_acacia"",0", """door_darkoak"",0", """dye_powder"",0", """dye_powder"",1", """dye_powder"",2", """dye_powder"",3", """dye_powder"",4", """dye_powder"",5", """dye_powder"",6", """dye_powder"",7", """dye_powder"",8", """dye_powder"",9", """dye_powder"",10", """dye_powder"",11", """dye_powder"",12", """dye_powder"",13", """dye_powder"",14", """dye_powder"",15", """egg"",0", """emerald"",0", """empty_armor_slot_boots"",0", """empty_armor_slot_chestplate"",0", """empty_armor_slot_helmet"",0", """empty_armor_slot_leggings"",0", """ender_eye"",0", """ender_pearl"",0", """experience_bottle"",0", """feather"",0", """fireball"",0", """fireworks"",0", """fireworks_charge"",0", """fireworks_charge_overlay"",0", """fishing_rod"",0", """fishing_rod"",1", """fish_raw_cod"",0", """fish_raw_salmon"",0", """fish_raw_clown_fish"",0", """fish_raw_puffer_fish"",0", """fish_cooked_cod"",0", """fish_cooked_salmon"",0", """flint"",0", """flint_and_steel"",0", """flower_pot"",0", """ghast_tear"",0", """glowstone_dust"",0", """gold_horse_armor"",0", """gold_ingot"",0", """gold_nugget"",0", """gunpowder"",0", """helmet"",0", """helmet"",1", """helmet"",2", """helmet"",3", """helmet"",4", """hoe"",0", """hoe"",1", """hoe"",2", """hoe"",3", """hoe"",4", """hopper"",0", """iron_horse_armor"",0", """iron_ingot"",0", """item_frame"",0", """lead"",0", """leather"",0", """leggings"",0", """leggings"",1", """leggings"",2", """leggings"",3", """leggings"",4", """magma_cream"",0", """map_empty"",0", """map_filled"",0", """melon"",0", """melon_speckled"",0", """minecart_chest"",0", """minecart_furnace"",0", """minecart_hopper"",0", """minecart_normal"",0", """minecart_tnt"",0", """mushroom_stew"",0", """beetroot_soup"",0", """name_tag"",0", """netherbrick"",0", """nether_star"",0", """nether_wart"",0", """painting"",0", """paper"",0", """pickaxe"",0", """pickaxe"",1", """pickaxe"",2", """pickaxe"",3", """pickaxe"",4", """porkchop_cooked"",0", """porkchop_raw"",0", """potato"",0", """potato_baked"",0", """potato_poisonous"",0", """potion_bottle_drinkable"",0", """potion_bottle_drinkable"",1", """potion_bottle_drinkable"",2", """potion_bottle_drinkable"",3", """potion_bottle_drinkable"",4", """potion_bottle_drinkable"",5", """potion_bottle_drinkable"",6", """potion_bottle_drinkable"",7", """potion_bottle_drinkable"",8", """potion_bottle_drinkable"",9", """potion_bottle_drinkable"",10", """potion_bottle_drinkable"",11", """potion_bottle_drinkable"",12", """potion_bottle_drinkable"",13", """potion_bottle_drinkable"",14", """potion_bottle_drinkable"",15", """potion_bottle_drinkable"",16", """potion_bottle_drinkable"",17", """potion_bottle_drinkable"",18", """potion_bottle_drinkable"",19", """potion_bottle_drinkable"",20", """potion_bottle_drinkable"",21", """potion_bottle_drinkable"",22", """potion_bottle_drinkable"",23", """potion_bottle_empty"",0", """potion_bottle_splash"",0", """potion_bottle_splash"",1", """potion_bottle_splash"",2", """potion_bottle_splash"",3", """potion_bottle_splash"",4", """potion_bottle_splash"",5", """potion_bottle_splash"",6", """potion_bottle_splash"",7", """potion_bottle_splash"",8", """potion_bottle_splash"",9", """potion_bottle_splash"",10", """potion_bottle_splash"",11", """potion_bottle_splash"",12", """potion_bottle_splash"",13", """potion_bottle_splash"",14", """potion_bottle_splash"",15", """potion_bottle_splash"",16", """potion_bottle_splash"",17", """potion_bottle_splash"",18", """potion_bottle_splash"",19", """potion_bottle_splash"",20", """potion_bottle_splash"",21", """potion_bottle_splash"",22", """potion_bottle_splash"",23", """potion_overlay"",0", """pumpkin_pie"",0", """quartz"",0", """quiver"",0", """record_11"",0", """record_13"",0", """record_blocks"",0", """record_cat"",0", """record_chirp"",0", """record_far"",0", """record_mall"",0", """record_mellohi"",0", """record_stal"",0", """record_strad"",0", """record_wait"",0", """record_ward"",0", """redstone_dust"",0", """reeds"",0", """repeater"",0", """rotten_flesh"",0", """ruby"",0", """saddle"",0", """seeds_melon"",0", """seeds_pumpkin"",0", """seeds_wheat"",0", """seeds_beetroot"",0", """shears"",0", """shovel"",0", """shovel"",1", """shovel"",2", """shovel"",3", """shovel"",4", """sign"",0", """skull_creeper"",0", """skull_skeleton"",0", """skull_steve"",0", """skull_wither"",0", """skull_zombie"",0", """slimeball"",0", """snowball"",0", """spawn_egg"",0", """spawn_egg"",1", """spawn_egg"",2", """spawn_egg"",3", """spawn_egg"",4", """spawn_egg"",5", """spawn_egg"",6", """spawn_egg"",7", """spawn_egg"",8", """spawn_egg"",9", """spawn_egg"",10", """spawn_egg"",11", """spawn_egg"",12", """spawn_egg"",13", """spawn_egg"",14", """spawn_egg"",15", """spawn_egg"",16", """spawn_egg"",17", """spawn_egg"",18", """spawn_egg"",19", """spawn_egg"",20", """spawn_egg"",21", """spawn_egg"",22", """spawn_egg"",23", """spawn_egg"",24", """spawn_egg"",25", """spawn_egg"",26", """spider_eye"",0", """spider_eye_fermented"",0", """stick"",0", """string"",0", """sugar"",0", """sword"",0", """sword"",1", """sword"",2", """sword"",3", """sword"",4", """wheat"",0", """clock_item"",0", """compass_item"",0", """rabbit_cooked"",0", """rabbit_foot"",0", """rabbit_hide"",0", """rabbit"",0", """rabbit_stew"",0", """lever"",0"})
        Me.cboxItemTexture.Location = New System.Drawing.Point(119, 119)
        Me.cboxItemTexture.Name = "cboxItemTexture"
        Me.cboxItemTexture.Size = New System.Drawing.Size(290, 24)
        Me.cboxItemTexture.TabIndex = 3
        '
        'lblTexture
        '
        Me.lblTexture.AutoSize = True
        Me.lblTexture.Location = New System.Drawing.Point(36, 119)
        Me.lblTexture.Name = "lblTexture"
        Me.lblTexture.Size = New System.Drawing.Size(60, 17)
        Me.lblTexture.TabIndex = 4
        Me.lblTexture.Text = "Texture:"
        '
        'lblCreativeTab
        '
        Me.lblCreativeTab.AutoSize = True
        Me.lblCreativeTab.Location = New System.Drawing.Point(36, 169)
        Me.lblCreativeTab.Name = "lblCreativeTab"
        Me.lblCreativeTab.Size = New System.Drawing.Size(93, 17)
        Me.lblCreativeTab.TabIndex = 6
        Me.lblCreativeTab.Text = "Creative Tab:"
        '
        'cboxCreative
        '
        Me.cboxCreative.FormattingEnabled = True
        Me.cboxCreative.Items.AddRange(New Object() {"DECORATION", "FOOD", "INTERNAL", "MATERIAL", "TOOL"})
        Me.cboxCreative.Location = New System.Drawing.Point(135, 169)
        Me.cboxCreative.Name = "cboxCreative"
        Me.cboxCreative.Size = New System.Drawing.Size(274, 24)
        Me.cboxCreative.TabIndex = 5
        '
        'lblMyID
        '
        Me.lblMyID.AutoSize = True
        Me.lblMyID.Location = New System.Drawing.Point(33, 241)
        Me.lblMyID.Name = "lblMyID"
        Me.lblMyID.Size = New System.Drawing.Size(55, 17)
        Me.lblMyID.TabIndex = 7
        Me.lblMyID.Text = "Item ID:"
        '
        'txtMyID
        '
        Me.txtMyID.Location = New System.Drawing.Point(94, 238)
        Me.txtMyID.Name = "txtMyID"
        Me.txtMyID.ReadOnly = True
        Me.txtMyID.Size = New System.Drawing.Size(66, 22)
        Me.txtMyID.TabIndex = 8
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(184, 231)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(225, 28)
        Me.cmdCreate.TabIndex = 9
        Me.cmdCreate.Text = "Create Item!"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'lblWorkaround
        '
        Me.lblWorkaround.AutoSize = True
        Me.lblWorkaround.Location = New System.Drawing.Point(118, 72)
        Me.lblWorkaround.Name = "lblWorkaround"
        Me.lblWorkaround.Size = New System.Drawing.Size(13, 17)
        Me.lblWorkaround.TabIndex = 10
        Me.lblWorkaround.Text = """"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(401, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = """"
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 297)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWorkaround)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.txtMyID)
        Me.Controls.Add(Me.lblMyID)
        Me.Controls.Add(Me.lblCreativeTab)
        Me.Controls.Add(Me.cboxCreative)
        Me.Controls.Add(Me.lblTexture)
        Me.Controls.Add(Me.cboxItemTexture)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblAddItem)
        Me.Name = "AddItem"
        Me.Text = "Add Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddItem As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents cboxItemTexture As ComboBox
    Friend WithEvents lblTexture As Label
    Friend WithEvents lblCreativeTab As Label
    Friend WithEvents cboxCreative As ComboBox
    Friend WithEvents lblMyID As Label
    Friend WithEvents txtMyID As TextBox
    Friend WithEvents cmdCreate As Button
    Friend WithEvents lblWorkaround As Label
    Friend WithEvents Label1 As Label
End Class
