<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBlock
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWorkaround = New System.Windows.Forms.Label()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.txtMyID = New System.Windows.Forms.TextBox()
        Me.lblMyID = New System.Windows.Forms.Label()
        Me.lblCreativeTab = New System.Windows.Forms.Label()
        Me.cboxCreative = New System.Windows.Forms.ComboBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddItem = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.cmdColorHelp = New System.Windows.Forms.Button()
        Me.lblHardness = New System.Windows.Forms.Label()
        Me.numHardness = New System.Windows.Forms.NumericUpDown()
        Me.lblLuminance = New System.Windows.Forms.CheckBox()
        Me.numLuminance = New System.Windows.Forms.NumericUpDown()
        Me.cboxTextureUp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboxTextureDown = New System.Windows.Forms.ComboBox()
        Me.cboxTextureSides = New System.Windows.Forms.ComboBox()
        Me.boxTextures = New System.Windows.Forms.GroupBox()
        CType(Me.numHardness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLuminance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxTextures.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = """"
        '
        'lblWorkaround
        '
        Me.lblWorkaround.AutoSize = True
        Me.lblWorkaround.Location = New System.Drawing.Point(126, 80)
        Me.lblWorkaround.Name = "lblWorkaround"
        Me.lblWorkaround.Size = New System.Drawing.Size(13, 17)
        Me.lblWorkaround.TabIndex = 22
        Me.lblWorkaround.Text = """"
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(398, 308)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(225, 32)
        Me.cmdCreate.TabIndex = 21
        Me.cmdCreate.Text = "Create Block!"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'txtMyID
        '
        Me.txtMyID.Location = New System.Drawing.Point(288, 318)
        Me.txtMyID.Name = "txtMyID"
        Me.txtMyID.ReadOnly = True
        Me.txtMyID.Size = New System.Drawing.Size(66, 22)
        Me.txtMyID.TabIndex = 20
        '
        'lblMyID
        '
        Me.lblMyID.AutoSize = True
        Me.lblMyID.Location = New System.Drawing.Point(219, 321)
        Me.lblMyID.Name = "lblMyID"
        Me.lblMyID.Size = New System.Drawing.Size(63, 17)
        Me.lblMyID.TabIndex = 19
        Me.lblMyID.Text = "Block ID:"
        '
        'lblCreativeTab
        '
        Me.lblCreativeTab.AutoSize = True
        Me.lblCreativeTab.Location = New System.Drawing.Point(467, 138)
        Me.lblCreativeTab.Name = "lblCreativeTab"
        Me.lblCreativeTab.Size = New System.Drawing.Size(93, 17)
        Me.lblCreativeTab.TabIndex = 18
        Me.lblCreativeTab.Text = "Creative Tab:"
        '
        'cboxCreative
        '
        Me.cboxCreative.FormattingEnabled = True
        Me.cboxCreative.Items.AddRange(New Object() {"DECORATION", "FOOD", "INTERNAL", "MATERIAL", "TOOL"})
        Me.cboxCreative.Location = New System.Drawing.Point(569, 138)
        Me.cboxCreative.Name = "cboxCreative"
        Me.cboxCreative.Size = New System.Drawing.Size(274, 24)
        Me.cboxCreative.TabIndex = 17
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(143, 80)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(280, 22)
        Me.txtItemName.TabIndex = 14
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(41, 83)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(87, 17)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Block Name:"
        '
        'lblAddItem
        '
        Me.lblAddItem.AutoSize = True
        Me.lblAddItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddItem.Location = New System.Drawing.Point(394, 29)
        Me.lblAddItem.Name = "lblAddItem"
        Me.lblAddItem.Size = New System.Drawing.Size(83, 24)
        Me.lblAddItem.TabIndex = 12
        Me.lblAddItem.Text = "Add Block"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(460, 243)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(118, 21)
        Me.lblColor.TabIndex = 26
        Me.lblColor.Text = "Custom Color:"
        Me.lblColor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(584, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "["
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(775, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "]"
        '
        'txtColor
        '
        Me.txtColor.Enabled = False
        Me.txtColor.Location = New System.Drawing.Point(602, 241)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(167, 22)
        Me.txtColor.TabIndex = 29
        '
        'cmdColorHelp
        '
        Me.cmdColorHelp.Location = New System.Drawing.Point(818, 241)
        Me.cmdColorHelp.Name = "cmdColorHelp"
        Me.cmdColorHelp.Size = New System.Drawing.Size(24, 23)
        Me.cmdColorHelp.TabIndex = 30
        Me.cmdColorHelp.Text = "?"
        Me.cmdColorHelp.UseVisualStyleBackColor = True
        '
        'lblHardness
        '
        Me.lblHardness.AutoSize = True
        Me.lblHardness.Location = New System.Drawing.Point(467, 83)
        Me.lblHardness.Name = "lblHardness"
        Me.lblHardness.Size = New System.Drawing.Size(73, 17)
        Me.lblHardness.TabIndex = 31
        Me.lblHardness.Text = "Hardness:"
        '
        'numHardness
        '
        Me.numHardness.Location = New System.Drawing.Point(552, 82)
        Me.numHardness.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numHardness.Name = "numHardness"
        Me.numHardness.Size = New System.Drawing.Size(290, 22)
        Me.numHardness.TabIndex = 32
        '
        'lblLuminance
        '
        Me.lblLuminance.AutoSize = True
        Me.lblLuminance.Location = New System.Drawing.Point(460, 196)
        Me.lblLuminance.Name = "lblLuminance"
        Me.lblLuminance.Size = New System.Drawing.Size(103, 21)
        Me.lblLuminance.TabIndex = 33
        Me.lblLuminance.Text = "Light Level:"
        Me.lblLuminance.UseVisualStyleBackColor = True
        '
        'numLuminance
        '
        Me.numLuminance.Enabled = False
        Me.numLuminance.Location = New System.Drawing.Point(569, 196)
        Me.numLuminance.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numLuminance.Name = "numLuminance"
        Me.numLuminance.Size = New System.Drawing.Size(273, 22)
        Me.numLuminance.TabIndex = 34
        '
        'cboxTextureUp
        '
        Me.cboxTextureUp.FormattingEnabled = True
        Me.cboxTextureUp.Items.AddRange(New Object() {"""grass"",0", """grass"",1", """grass"",2", """grass"",3", """grass"",4", """grass"",5", """grass"",6", """grass"",7", """grass"",8", """grass"",9", """grass"",10", """grass"",11", """grass"",12", """grass"",13", """grass"",14", """grass"",15", """grass"",16", """grass"",17", """grass"",18", """stone"",0", """stone"",1", """stone"",2", """stone"",3", """stone"",4", """stone"",5", """stone"",6", """cobblestone"",0", """cobblestone_mossy"",0", """stonebrick"",0", """stonebrick"",1", """stonebrick"",2", """stonebrick"",3", """bedrock"",0", """obsidian"",0", """clay"",0", """sand"",0", """sand"",1", """sandstone"",0", """sandstone"",1", """sandstone"",2", """sandstone"",3", """sandstone"",4", """gravel"",0", """dirt"",0", """dirt"",1", """dirt"",2", """planks"",0", """planks"",1", """planks"",2", """planks"",3", """planks"",4", """planks"",5", """stone_slab"",0", """stone_slab"",1", """brick"",0", """tnt"",0", """tnt"",1", """tnt"",2", """bookshelf"",0", """web"",0", """flower1"",0", """flower2"",0", """flower2"",1", """flower2"",2", """flower2"",3", """flower2"",4", """flower2"",5", """flower2"",6", """flower2"",7", """flower2"",8", """double_plant_bottom"",0", """double_plant_bottom"",1", """double_plant_bottom"",2", """double_plant_bottom"",3", """double_plant_bottom"",4", """double_plant_bottom"",5", """double_plant_top"",0", """double_plant_top"",1", """double_plant_top"",2", """double_plant_top"",3", """double_plant_top"",4", """double_plant_top"",5", """double_plant_carried"",0", """double_plant_carried"",1", """sunflower_additional"",0", """sunflower_additional"",1", """sapling"",0", """sapling"",1", """sapling"",2", """sapling"",3", """sapling"",4", """sapling"",5", """log"",0", """log"",1", """log"",2", """log"",3", """log"",4", """log"",5", """log"",6", """log"",7", """log2"",0", """log2"",1", """log2"",2", """log2"",3", """iron_block"",0", """gold_block"",0", """diamond_block"",0", """coal_block"",0", """lapis_block"",0", """emerald_block"",0", """redstone_block"",0", """quartz_block"",0", """quartz_block"",1", """quartz_block"",2", """quartz_block"",3", """quartz_block"",4", """quartz_block"",5", """quartz_block"",6", """mushroom_red"",0", """mushroom_brown"",0", """gold_ore"",0", """iron_ore"",0", """coal_ore"",0", """lapis_ore"",0", """diamond_ore"",0", """redstone_ore"",0", """emerald_ore"",0", """quartz_ore"",0", """tallgrass"",0", """tallgrass"",1", """tallgrass"",2", """tallgrass"",3", """tallgrass"",4", """crafting_table"",0", """crafting_table"",1", """crafting_table"",2", """furnace"",0", """furnace"",1", """furnace"",2", """furnace"",3", """stonecutter"",0", """stonecutter"",1", """stonecutter"",2", """stonecutter"",3", """sponge"",0", """glass"",0", """leaves"",0", """leaves"",1", """leaves"",2", """leaves"",3", """leaves"",4", """leaves"",5", """leaves"",6", """leaves"",7", """leaves_opaque"",0", """leaves_opaque"",1", """leaves_opaque"",2", """leaves_opaque"",3", """leaves2"",0", """leaves2"",1", """leaves2"",2", """leaves2"",3", """leaves_opaque2"",0", """leaves_opaque2"",1", """mob_spawner"",0", """snow"",0", """ice"",0", """ice_packed"",0", """cactus"",0", """cactus"",1", """cactus"",2", """reeds"",0", """jukebox_side"",0", """jukebox_top"",0", """waterlily"",0", """waterlily"",1", """mycelium"",0", """mycelium"",1", """torch_on"",0", """redstone_torch_on"",0", """redstone_torch_off"",0", """door"",0", """door"",1", """door"",2", """door"",3", """door"",4", """door"",5", """door"",6", """door"",7", """door"",8", """door"",9", """door"",10", """door"",11", """door"",12", """door"",13", """ladder"",0", """trapdoor"",0", """iron_trapdoor"",0", """iron_bars"",0", """farmland"",0", """farmland"",1", """wheat"",0", """wheat"",1", """wheat"",2", """wheat"",3", """wheat"",4", """wheat"",5", """wheat"",6", """wheat"",7", """grass_path"",0", """grass_path"",1", """lever"",0", """pumpkin"",0", """pumpkin"",1", """pumpkin"",2", """pumpkin"",3", """netherrack"",0", """nether_brick"",0", """nether_wart"",0", """nether_wart"",1", """nether_wart"",2", """soul_sand"",0", """glowstone"",0", """piston_top_sticky"",0", """piston_top_normal"",0", """piston_side"",0", """piston_inner"",0", """piston_bottom"",0", """melon"",0", """melon"",1", """melon_stem"",0", """melon_stem"",1", """pumpkin_stem"",0", """pumpkin_stem"",1", """rail_normal"",0", """rail_normal_turned"",0", """rail_golden"",0", """rail_golden_powered"",0", """rail_detector"",0", """rail_detector_powered"",0", """rail_activator"",0", """rail_activator_powered"",0", """bed"",0", """bed"",1", """bed"",2", """bed"",3", """bed"",4", """bed"",5", """cauldron_top"",0", """cauldron_inner"",0", """cauldron_side"",0", """cauldron_bottom"",0", """brewing_stand_base"",0", """brewing_stand"",0", """cake_bottom"",0", """cake_inner"",0", """cake_top"",0", """cake_side"",0", """mushroom_block"",0", """mushroom_block"",1", """mushroom_block"",2", """mushroom_block"",3", """vine"",0", """vine"",1", """repeater_off"",0", """repeater_on"",0", """glass_pane_top"",0", """end_stone"",0", """endframee"",0", """endframee"",1", """endframee"",2", """redstone_dust_cross"",0", """redstone_dust_cross_overlay"",0", """redstone_dust_line"",0", """redstone_dust_line_overlay"",0", """redstone_lamp_off"",0", """redstone_lamp_on"",0", """enchanting_table_bottom"",0", """enchanting_table_side"",0", """enchanting_table_top"",0", """dragon_egg"",0", """hayblock"",0", """hayblock"",1", """cocoa"",0", """cocoa"",1", """cocoa"",2", """trip_wire"",0", """trip_wire_source"",0", """command_block"",0", """itemframe_background"",0", """flower_pot"",0", """carrots"",0", """carrots"",1", """carrots"",2", """carrots"",3", """potatoes"",0", """potatoes"",1", """potatoes"",2", """potatoes"",3", """beetroot"",0", """beetroot"",1", """beetroot"",2", """beetroot"",3", """anvil_base"",0", """anvil_top_damaged_x"",0", """anvil_top_damaged_x"",1", """anvil_top_damaged_x"",2", """reactor_core"",0", """reactor_core"",1", """reactor_core"",2", """glowing_obsidian"",0", """destroy"",0", """destroy"",1", """destroy"",2", """destroy"",3", """destroy"",4", """destroy"",5", """destroy"",6", """destroy"",7", """destroy"",8", """destroy"",9", """chest_inventory"",0", """chest_inventory"",1", """chest_inventory"",2", """missing_tile"",0", """wool"",0", """wool"",1", """wool"",2", """wool"",3", """wool"",4", """wool"",5", """wool"",6", """wool"",7", """wool"",8", """wool"",9", """wool"",10", """wool"",11", """wool"",12", """wool"",13", """wool"",14", """wool"",15", """hardened_clay"",0", """stained_clay"",0", """stained_clay"",1", """stained_clay"",2", """stained_clay"",3", """stained_clay"",4", """stained_clay"",5", """stained_clay"",6", """stained_clay"",7", """stained_clay"",8", """stained_clay"",9", """stained_clay"",10", """stained_clay"",11", """stained_clay"",12", """stained_clay"",13", """stained_clay"",14", """stained_clay"",15", """fire"",0", """fire"",1", """still_water"",0", """still_lava"",0", """portal"",0", """daylight_detector_side"",0", """daylight_detector_top"",0", """daylight_detector_inverted_top"",0", """noteblock"",0", """flowing_water"",0", """flowing_lava"",0"})
        Me.cboxTextureUp.Location = New System.Drawing.Point(77, 21)
        Me.cboxTextureUp.Name = "cboxTextureUp"
        Me.cboxTextureUp.Size = New System.Drawing.Size(302, 24)
        Me.cboxTextureUp.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Up:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Down:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Sides:"
        '
        'cboxTextureDown
        '
        Me.cboxTextureDown.FormattingEnabled = True
        Me.cboxTextureDown.Items.AddRange(New Object() {"""grass"",0", """grass"",1", """grass"",2", """grass"",3", """grass"",4", """grass"",5", """grass"",6", """grass"",7", """grass"",8", """grass"",9", """grass"",10", """grass"",11", """grass"",12", """grass"",13", """grass"",14", """grass"",15", """grass"",16", """grass"",17", """grass"",18", """stone"",0", """stone"",1", """stone"",2", """stone"",3", """stone"",4", """stone"",5", """stone"",6", """cobblestone"",0", """cobblestone_mossy"",0", """stonebrick"",0", """stonebrick"",1", """stonebrick"",2", """stonebrick"",3", """bedrock"",0", """obsidian"",0", """clay"",0", """sand"",0", """sand"",1", """sandstone"",0", """sandstone"",1", """sandstone"",2", """sandstone"",3", """sandstone"",4", """gravel"",0", """dirt"",0", """dirt"",1", """dirt"",2", """planks"",0", """planks"",1", """planks"",2", """planks"",3", """planks"",4", """planks"",5", """stone_slab"",0", """stone_slab"",1", """brick"",0", """tnt"",0", """tnt"",1", """tnt"",2", """bookshelf"",0", """web"",0", """flower1"",0", """flower2"",0", """flower2"",1", """flower2"",2", """flower2"",3", """flower2"",4", """flower2"",5", """flower2"",6", """flower2"",7", """flower2"",8", """double_plant_bottom"",0", """double_plant_bottom"",1", """double_plant_bottom"",2", """double_plant_bottom"",3", """double_plant_bottom"",4", """double_plant_bottom"",5", """double_plant_top"",0", """double_plant_top"",1", """double_plant_top"",2", """double_plant_top"",3", """double_plant_top"",4", """double_plant_top"",5", """double_plant_carried"",0", """double_plant_carried"",1", """sunflower_additional"",0", """sunflower_additional"",1", """sapling"",0", """sapling"",1", """sapling"",2", """sapling"",3", """sapling"",4", """sapling"",5", """log"",0", """log"",1", """log"",2", """log"",3", """log"",4", """log"",5", """log"",6", """log"",7", """log2"",0", """log2"",1", """log2"",2", """log2"",3", """iron_block"",0", """gold_block"",0", """diamond_block"",0", """coal_block"",0", """lapis_block"",0", """emerald_block"",0", """redstone_block"",0", """quartz_block"",0", """quartz_block"",1", """quartz_block"",2", """quartz_block"",3", """quartz_block"",4", """quartz_block"",5", """quartz_block"",6", """mushroom_red"",0", """mushroom_brown"",0", """gold_ore"",0", """iron_ore"",0", """coal_ore"",0", """lapis_ore"",0", """diamond_ore"",0", """redstone_ore"",0", """emerald_ore"",0", """quartz_ore"",0", """tallgrass"",0", """tallgrass"",1", """tallgrass"",2", """tallgrass"",3", """tallgrass"",4", """crafting_table"",0", """crafting_table"",1", """crafting_table"",2", """furnace"",0", """furnace"",1", """furnace"",2", """furnace"",3", """stonecutter"",0", """stonecutter"",1", """stonecutter"",2", """stonecutter"",3", """sponge"",0", """glass"",0", """leaves"",0", """leaves"",1", """leaves"",2", """leaves"",3", """leaves"",4", """leaves"",5", """leaves"",6", """leaves"",7", """leaves_opaque"",0", """leaves_opaque"",1", """leaves_opaque"",2", """leaves_opaque"",3", """leaves2"",0", """leaves2"",1", """leaves2"",2", """leaves2"",3", """leaves_opaque2"",0", """leaves_opaque2"",1", """mob_spawner"",0", """snow"",0", """ice"",0", """ice_packed"",0", """cactus"",0", """cactus"",1", """cactus"",2", """reeds"",0", """jukebox_side"",0", """jukebox_top"",0", """waterlily"",0", """waterlily"",1", """mycelium"",0", """mycelium"",1", """torch_on"",0", """redstone_torch_on"",0", """redstone_torch_off"",0", """door"",0", """door"",1", """door"",2", """door"",3", """door"",4", """door"",5", """door"",6", """door"",7", """door"",8", """door"",9", """door"",10", """door"",11", """door"",12", """door"",13", """ladder"",0", """trapdoor"",0", """iron_trapdoor"",0", """iron_bars"",0", """farmland"",0", """farmland"",1", """wheat"",0", """wheat"",1", """wheat"",2", """wheat"",3", """wheat"",4", """wheat"",5", """wheat"",6", """wheat"",7", """grass_path"",0", """grass_path"",1", """lever"",0", """pumpkin"",0", """pumpkin"",1", """pumpkin"",2", """pumpkin"",3", """netherrack"",0", """nether_brick"",0", """nether_wart"",0", """nether_wart"",1", """nether_wart"",2", """soul_sand"",0", """glowstone"",0", """piston_top_sticky"",0", """piston_top_normal"",0", """piston_side"",0", """piston_inner"",0", """piston_bottom"",0", """melon"",0", """melon"",1", """melon_stem"",0", """melon_stem"",1", """pumpkin_stem"",0", """pumpkin_stem"",1", """rail_normal"",0", """rail_normal_turned"",0", """rail_golden"",0", """rail_golden_powered"",0", """rail_detector"",0", """rail_detector_powered"",0", """rail_activator"",0", """rail_activator_powered"",0", """bed"",0", """bed"",1", """bed"",2", """bed"",3", """bed"",4", """bed"",5", """cauldron_top"",0", """cauldron_inner"",0", """cauldron_side"",0", """cauldron_bottom"",0", """brewing_stand_base"",0", """brewing_stand"",0", """cake_bottom"",0", """cake_inner"",0", """cake_top"",0", """cake_side"",0", """mushroom_block"",0", """mushroom_block"",1", """mushroom_block"",2", """mushroom_block"",3", """vine"",0", """vine"",1", """repeater_off"",0", """repeater_on"",0", """glass_pane_top"",0", """end_stone"",0", """endframee"",0", """endframee"",1", """endframee"",2", """redstone_dust_cross"",0", """redstone_dust_cross_overlay"",0", """redstone_dust_line"",0", """redstone_dust_line_overlay"",0", """redstone_lamp_off"",0", """redstone_lamp_on"",0", """enchanting_table_bottom"",0", """enchanting_table_side"",0", """enchanting_table_top"",0", """dragon_egg"",0", """hayblock"",0", """hayblock"",1", """cocoa"",0", """cocoa"",1", """cocoa"",2", """trip_wire"",0", """trip_wire_source"",0", """command_block"",0", """itemframe_background"",0", """flower_pot"",0", """carrots"",0", """carrots"",1", """carrots"",2", """carrots"",3", """potatoes"",0", """potatoes"",1", """potatoes"",2", """potatoes"",3", """beetroot"",0", """beetroot"",1", """beetroot"",2", """beetroot"",3", """anvil_base"",0", """anvil_top_damaged_x"",0", """anvil_top_damaged_x"",1", """anvil_top_damaged_x"",2", """reactor_core"",0", """reactor_core"",1", """reactor_core"",2", """glowing_obsidian"",0", """destroy"",0", """destroy"",1", """destroy"",2", """destroy"",3", """destroy"",4", """destroy"",5", """destroy"",6", """destroy"",7", """destroy"",8", """destroy"",9", """chest_inventory"",0", """chest_inventory"",1", """chest_inventory"",2", """missing_tile"",0", """wool"",0", """wool"",1", """wool"",2", """wool"",3", """wool"",4", """wool"",5", """wool"",6", """wool"",7", """wool"",8", """wool"",9", """wool"",10", """wool"",11", """wool"",12", """wool"",13", """wool"",14", """wool"",15", """hardened_clay"",0", """stained_clay"",0", """stained_clay"",1", """stained_clay"",2", """stained_clay"",3", """stained_clay"",4", """stained_clay"",5", """stained_clay"",6", """stained_clay"",7", """stained_clay"",8", """stained_clay"",9", """stained_clay"",10", """stained_clay"",11", """stained_clay"",12", """stained_clay"",13", """stained_clay"",14", """stained_clay"",15", """fire"",0", """fire"",1", """still_water"",0", """still_lava"",0", """portal"",0", """daylight_detector_side"",0", """daylight_detector_top"",0", """daylight_detector_inverted_top"",0", """noteblock"",0", """flowing_water"",0", """flowing_lava"",0"})
        Me.cboxTextureDown.Location = New System.Drawing.Point(77, 66)
        Me.cboxTextureDown.Name = "cboxTextureDown"
        Me.cboxTextureDown.Size = New System.Drawing.Size(302, 24)
        Me.cboxTextureDown.TabIndex = 22
        '
        'cboxTextureSides
        '
        Me.cboxTextureSides.FormattingEnabled = True
        Me.cboxTextureSides.Items.AddRange(New Object() {"""grass"",0", """grass"",1", """grass"",2", """grass"",3", """grass"",4", """grass"",5", """grass"",6", """grass"",7", """grass"",8", """grass"",9", """grass"",10", """grass"",11", """grass"",12", """grass"",13", """grass"",14", """grass"",15", """grass"",16", """grass"",17", """grass"",18", """stone"",0", """stone"",1", """stone"",2", """stone"",3", """stone"",4", """stone"",5", """stone"",6", """cobblestone"",0", """cobblestone_mossy"",0", """stonebrick"",0", """stonebrick"",1", """stonebrick"",2", """stonebrick"",3", """bedrock"",0", """obsidian"",0", """clay"",0", """sand"",0", """sand"",1", """sandstone"",0", """sandstone"",1", """sandstone"",2", """sandstone"",3", """sandstone"",4", """gravel"",0", """dirt"",0", """dirt"",1", """dirt"",2", """planks"",0", """planks"",1", """planks"",2", """planks"",3", """planks"",4", """planks"",5", """stone_slab"",0", """stone_slab"",1", """brick"",0", """tnt"",0", """tnt"",1", """tnt"",2", """bookshelf"",0", """web"",0", """flower1"",0", """flower2"",0", """flower2"",1", """flower2"",2", """flower2"",3", """flower2"",4", """flower2"",5", """flower2"",6", """flower2"",7", """flower2"",8", """double_plant_bottom"",0", """double_plant_bottom"",1", """double_plant_bottom"",2", """double_plant_bottom"",3", """double_plant_bottom"",4", """double_plant_bottom"",5", """double_plant_top"",0", """double_plant_top"",1", """double_plant_top"",2", """double_plant_top"",3", """double_plant_top"",4", """double_plant_top"",5", """double_plant_carried"",0", """double_plant_carried"",1", """sunflower_additional"",0", """sunflower_additional"",1", """sapling"",0", """sapling"",1", """sapling"",2", """sapling"",3", """sapling"",4", """sapling"",5", """log"",0", """log"",1", """log"",2", """log"",3", """log"",4", """log"",5", """log"",6", """log"",7", """log2"",0", """log2"",1", """log2"",2", """log2"",3", """iron_block"",0", """gold_block"",0", """diamond_block"",0", """coal_block"",0", """lapis_block"",0", """emerald_block"",0", """redstone_block"",0", """quartz_block"",0", """quartz_block"",1", """quartz_block"",2", """quartz_block"",3", """quartz_block"",4", """quartz_block"",5", """quartz_block"",6", """mushroom_red"",0", """mushroom_brown"",0", """gold_ore"",0", """iron_ore"",0", """coal_ore"",0", """lapis_ore"",0", """diamond_ore"",0", """redstone_ore"",0", """emerald_ore"",0", """quartz_ore"",0", """tallgrass"",0", """tallgrass"",1", """tallgrass"",2", """tallgrass"",3", """tallgrass"",4", """crafting_table"",0", """crafting_table"",1", """crafting_table"",2", """furnace"",0", """furnace"",1", """furnace"",2", """furnace"",3", """stonecutter"",0", """stonecutter"",1", """stonecutter"",2", """stonecutter"",3", """sponge"",0", """glass"",0", """leaves"",0", """leaves"",1", """leaves"",2", """leaves"",3", """leaves"",4", """leaves"",5", """leaves"",6", """leaves"",7", """leaves_opaque"",0", """leaves_opaque"",1", """leaves_opaque"",2", """leaves_opaque"",3", """leaves2"",0", """leaves2"",1", """leaves2"",2", """leaves2"",3", """leaves_opaque2"",0", """leaves_opaque2"",1", """mob_spawner"",0", """snow"",0", """ice"",0", """ice_packed"",0", """cactus"",0", """cactus"",1", """cactus"",2", """reeds"",0", """jukebox_side"",0", """jukebox_top"",0", """waterlily"",0", """waterlily"",1", """mycelium"",0", """mycelium"",1", """torch_on"",0", """redstone_torch_on"",0", """redstone_torch_off"",0", """door"",0", """door"",1", """door"",2", """door"",3", """door"",4", """door"",5", """door"",6", """door"",7", """door"",8", """door"",9", """door"",10", """door"",11", """door"",12", """door"",13", """ladder"",0", """trapdoor"",0", """iron_trapdoor"",0", """iron_bars"",0", """farmland"",0", """farmland"",1", """wheat"",0", """wheat"",1", """wheat"",2", """wheat"",3", """wheat"",4", """wheat"",5", """wheat"",6", """wheat"",7", """grass_path"",0", """grass_path"",1", """lever"",0", """pumpkin"",0", """pumpkin"",1", """pumpkin"",2", """pumpkin"",3", """netherrack"",0", """nether_brick"",0", """nether_wart"",0", """nether_wart"",1", """nether_wart"",2", """soul_sand"",0", """glowstone"",0", """piston_top_sticky"",0", """piston_top_normal"",0", """piston_side"",0", """piston_inner"",0", """piston_bottom"",0", """melon"",0", """melon"",1", """melon_stem"",0", """melon_stem"",1", """pumpkin_stem"",0", """pumpkin_stem"",1", """rail_normal"",0", """rail_normal_turned"",0", """rail_golden"",0", """rail_golden_powered"",0", """rail_detector"",0", """rail_detector_powered"",0", """rail_activator"",0", """rail_activator_powered"",0", """bed"",0", """bed"",1", """bed"",2", """bed"",3", """bed"",4", """bed"",5", """cauldron_top"",0", """cauldron_inner"",0", """cauldron_side"",0", """cauldron_bottom"",0", """brewing_stand_base"",0", """brewing_stand"",0", """cake_bottom"",0", """cake_inner"",0", """cake_top"",0", """cake_side"",0", """mushroom_block"",0", """mushroom_block"",1", """mushroom_block"",2", """mushroom_block"",3", """vine"",0", """vine"",1", """repeater_off"",0", """repeater_on"",0", """glass_pane_top"",0", """end_stone"",0", """endframee"",0", """endframee"",1", """endframee"",2", """redstone_dust_cross"",0", """redstone_dust_cross_overlay"",0", """redstone_dust_line"",0", """redstone_dust_line_overlay"",0", """redstone_lamp_off"",0", """redstone_lamp_on"",0", """enchanting_table_bottom"",0", """enchanting_table_side"",0", """enchanting_table_top"",0", """dragon_egg"",0", """hayblock"",0", """hayblock"",1", """cocoa"",0", """cocoa"",1", """cocoa"",2", """trip_wire"",0", """trip_wire_source"",0", """command_block"",0", """itemframe_background"",0", """flower_pot"",0", """carrots"",0", """carrots"",1", """carrots"",2", """carrots"",3", """potatoes"",0", """potatoes"",1", """potatoes"",2", """potatoes"",3", """beetroot"",0", """beetroot"",1", """beetroot"",2", """beetroot"",3", """anvil_base"",0", """anvil_top_damaged_x"",0", """anvil_top_damaged_x"",1", """anvil_top_damaged_x"",2", """reactor_core"",0", """reactor_core"",1", """reactor_core"",2", """glowing_obsidian"",0", """destroy"",0", """destroy"",1", """destroy"",2", """destroy"",3", """destroy"",4", """destroy"",5", """destroy"",6", """destroy"",7", """destroy"",8", """destroy"",9", """chest_inventory"",0", """chest_inventory"",1", """chest_inventory"",2", """missing_tile"",0", """wool"",0", """wool"",1", """wool"",2", """wool"",3", """wool"",4", """wool"",5", """wool"",6", """wool"",7", """wool"",8", """wool"",9", """wool"",10", """wool"",11", """wool"",12", """wool"",13", """wool"",14", """wool"",15", """hardened_clay"",0", """stained_clay"",0", """stained_clay"",1", """stained_clay"",2", """stained_clay"",3", """stained_clay"",4", """stained_clay"",5", """stained_clay"",6", """stained_clay"",7", """stained_clay"",8", """stained_clay"",9", """stained_clay"",10", """stained_clay"",11", """stained_clay"",12", """stained_clay"",13", """stained_clay"",14", """stained_clay"",15", """fire"",0", """fire"",1", """still_water"",0", """still_lava"",0", """portal"",0", """daylight_detector_side"",0", """daylight_detector_top"",0", """daylight_detector_inverted_top"",0", """noteblock"",0", """flowing_water"",0", """flowing_lava"",0"})
        Me.cboxTextureSides.Location = New System.Drawing.Point(77, 115)
        Me.cboxTextureSides.Name = "cboxTextureSides"
        Me.cboxTextureSides.Size = New System.Drawing.Size(302, 24)
        Me.cboxTextureSides.TabIndex = 23
        '
        'boxTextures
        '
        Me.boxTextures.Controls.Add(Me.cboxTextureSides)
        Me.boxTextures.Controls.Add(Me.cboxTextureDown)
        Me.boxTextures.Controls.Add(Me.Label6)
        Me.boxTextures.Controls.Add(Me.Label5)
        Me.boxTextures.Controls.Add(Me.Label4)
        Me.boxTextures.Controls.Add(Me.cboxTextureUp)
        Me.boxTextures.Location = New System.Drawing.Point(44, 116)
        Me.boxTextures.Name = "boxTextures"
        Me.boxTextures.Size = New System.Drawing.Size(395, 147)
        Me.boxTextures.TabIndex = 35
        Me.boxTextures.TabStop = False
        Me.boxTextures.Text = "Textures"
        '
        'AddBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 361)
        Me.Controls.Add(Me.boxTextures)
        Me.Controls.Add(Me.numLuminance)
        Me.Controls.Add(Me.lblLuminance)
        Me.Controls.Add(Me.numHardness)
        Me.Controls.Add(Me.lblHardness)
        Me.Controls.Add(Me.cmdColorHelp)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWorkaround)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.txtMyID)
        Me.Controls.Add(Me.lblMyID)
        Me.Controls.Add(Me.lblCreativeTab)
        Me.Controls.Add(Me.cboxCreative)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblAddItem)
        Me.Name = "AddBlock"
        Me.Text = "Add Block"
        CType(Me.numHardness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLuminance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxTextures.ResumeLayout(False)
        Me.boxTextures.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblWorkaround As Label
    Friend WithEvents cmdCreate As Button
    Friend WithEvents txtMyID As TextBox
    Friend WithEvents lblMyID As Label
    Friend WithEvents lblCreativeTab As Label
    Friend WithEvents cboxCreative As ComboBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddItem As Label
    Friend WithEvents lblColor As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents cmdColorHelp As Button
    Friend WithEvents lblHardness As Label
    Friend WithEvents numHardness As NumericUpDown
    Friend WithEvents lblLuminance As CheckBox
    Friend WithEvents numLuminance As NumericUpDown
    Friend WithEvents cboxTextureUp As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboxTextureDown As ComboBox
    Friend WithEvents cboxTextureSides As ComboBox
    Friend WithEvents boxTextures As GroupBox
End Class
