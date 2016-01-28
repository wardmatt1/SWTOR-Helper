Public Class UI_Crafting_Mats
    Inherits UI
    Private _node As String

    Sub New(win As Form)
        UI_Window = win

        _node = AddTreeNode(UI_Main.treeview, "Crafting Items")
        UI_Panel = NewPanel(_node)

        Me.CraftingMat_Title = New System.Windows.Forms.Label()
        Me.CraftingMats_FilterBox = New System.Windows.Forms.GroupBox()
        Me.CraftingMats_FilterBox_FBT = New System.Windows.Forms.GroupBox()
        Me.CraftingMats_FilterBox_FBT_Label1 = New System.Windows.Forms.Label()
        Me.CraftingMats_FilterBox_FBT_CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CraftingMats_FilterBox_FBT_CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CraftingMats_FilterBox_FBT_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CraftingMats_FilterBox_ByTier_CheckBox = New System.Windows.Forms.CheckBox()
        Me.CraftingMats_FilterBox_Filter = New System.Windows.Forms.Button()
        Me.CraftingMats_FilterBox_Reset = New System.Windows.Forms.Button()
        Me.CraftingMats_FilterBox_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CraftingMats_FilterBox_ByCrewSkill_CheckBox = New System.Windows.Forms.CheckBox()
        Me.CraftingMats_FilterBox_ByPlanet_CheckBox = New System.Windows.Forms.CheckBox()
        Me.CraftingMat_Panel1 = New System.Windows.Forms.Panel()
        Me.CraftingMat_SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.CraftingMat_ListView = New System.Windows.Forms.ListView()
        Me.CraftingMat_Info_Planets = New System.Windows.Forms.GroupBox()
        Me.CraftingMat_Info_Planetlist = New System.Windows.Forms.Label()
        Me.CraftingMat_Info_Tier1 = New System.Windows.Forms.Label()
        Me.CraftingMat_Info_Tier2 = New System.Windows.Forms.Label()
        Me.CraftingMat_Info_SkillLvl2 = New System.Windows.Forms.Label()
        Me.CraftingMat_Info_SkillLvl1 = New System.Windows.Forms.Label()
        Me.CraftingMat_Info_CrewSkill1 = New System.Windows.Forms.Label()
        Me.CraftingMat_Info_CrewSkill2 = New System.Windows.Forms.Label()
        Me.CraftingMst_Name = New System.Windows.Forms.Label()
        Me.CraftingMat_Icon = New System.Windows.Forms.PictureBox()
        Me.CraftingMats_FilterBox_TextBox1 = New System.Windows.Forms.TextBox()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        UI_Panel.SuspendLayout()
        Me.CraftingMats_FilterBox.SuspendLayout()
        Me.CraftingMats_FilterBox_FBT.SuspendLayout()
        Me.CraftingMat_Panel1.SuspendLayout()
        CType(Me.CraftingMat_SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CraftingMat_SplitContainer.Panel1.SuspendLayout()
        Me.CraftingMat_SplitContainer.Panel2.SuspendLayout()
        Me.CraftingMat_SplitContainer.SuspendLayout()
        Me.CraftingMat_Info_Planets.SuspendLayout()
        CType(Me.CraftingMat_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        win.SuspendLayout()
        '
        ' UI_Panel
        '
        UI_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UI_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        UI_Panel.Controls.Add(Me.CraftingMat_Title)
        UI_Panel.Controls.Add(Me.CraftingMats_FilterBox)
        UI_Panel.Controls.Add(Me.CraftingMat_Panel1)
        UI_Panel.Location = New System.Drawing.Point(194, 27)
        UI_Panel.MinimumSize = New System.Drawing.Size(585, 522)
        UI_Panel.Name = "Panel1"
        UI_Panel.Size = New System.Drawing.Size(585, 522)
        UI_Panel.TabIndex = 0
        '
        'CraftingMat_Title
        '
        Me.CraftingMat_Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CraftingMat_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CraftingMat_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingMat_Title.Location = New System.Drawing.Point(3, 3)
        Me.CraftingMat_Title.Name = "CraftingMat_Title"
        Me.CraftingMat_Title.Size = New System.Drawing.Size(574, 40)
        Me.CraftingMat_Title.TabIndex = 2
        Me.CraftingMat_Title.Text = "Quick Crafting Material Reference"
        Me.CraftingMat_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CraftingMats_FilterBox
        '
        Me.CraftingMats_FilterBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CraftingMats_FilterBox.Controls.Add(Me.CraftingMats_FilterBox_TextBox1)
        Me.CraftingMats_FilterBox.Controls.Add(Me.CraftingMats_FilterBox_FBT)
        Me.CraftingMats_FilterBox.Controls.Add(Me.CraftingMats_FilterBox_ByTier_CheckBox)
        Me.CraftingMats_FilterBox.Controls.Add(Me.CraftingMats_FilterBox_Filter)
        Me.CraftingMats_FilterBox.Controls.Add(Me.CraftingMats_FilterBox_Reset)
        Me.CraftingMats_FilterBox.Controls.Add(Me.CraftingMats_FilterBox_ComboBox1)
        Me.CraftingMats_FilterBox.Controls.Add(Me.CraftingMats_FilterBox_ByCrewSkill_CheckBox)
        Me.CraftingMats_FilterBox.Controls.Add(Me.CraftingMats_FilterBox_ByPlanet_CheckBox)
        Me.CraftingMats_FilterBox.Location = New System.Drawing.Point(8, 376)
        Me.CraftingMats_FilterBox.Name = "CraftingMats_FilterBox"
        Me.CraftingMats_FilterBox.Size = New System.Drawing.Size(356, 141)
        Me.CraftingMats_FilterBox.TabIndex = 1
        Me.CraftingMats_FilterBox.TabStop = False
        Me.CraftingMats_FilterBox.Text = "Filter"
        '
        'CraftingMats_FilterBox_FBT
        '
        Me.CraftingMats_FilterBox_FBT.Controls.Add(Me.CraftingMats_FilterBox_FBT_Label1)
        Me.CraftingMats_FilterBox_FBT.Controls.Add(Me.CraftingMats_FilterBox_FBT_CheckBox2)
        Me.CraftingMats_FilterBox_FBT.Controls.Add(Me.CraftingMats_FilterBox_FBT_CheckBox1)
        Me.CraftingMats_FilterBox_FBT.Controls.Add(Me.CraftingMats_FilterBox_FBT_ComboBox1)
        Me.CraftingMats_FilterBox_FBT.Location = New System.Drawing.Point(222, 19)
        Me.CraftingMats_FilterBox_FBT.Name = "CraftingMats_FilterBox_FBT"
        Me.CraftingMats_FilterBox_FBT.Size = New System.Drawing.Size(108, 100)
        Me.CraftingMats_FilterBox_FBT.TabIndex = 9
        Me.CraftingMats_FilterBox_FBT.TabStop = False
        Me.CraftingMats_FilterBox_FBT.Text = "Filter By Tier"
        '
        'CraftingMats_FilterBox_FBT_Label1
        '
        Me.CraftingMats_FilterBox_FBT_Label1.AutoSize = True
        Me.CraftingMats_FilterBox_FBT_Label1.Location = New System.Drawing.Point(6, 30)
        Me.CraftingMats_FilterBox_FBT_Label1.Name = "CraftingMats_FilterBox_FBT_Label1"
        Me.CraftingMats_FilterBox_FBT_Label1.Size = New System.Drawing.Size(25, 13)
        Me.CraftingMats_FilterBox_FBT_Label1.TabIndex = 10
        Me.CraftingMats_FilterBox_FBT_Label1.Text = "Tier"
        '
        'CraftingMats_FilterBox_FBT_CheckBox2
        '
        Me.CraftingMats_FilterBox_FBT_CheckBox2.AutoSize = True
        Me.CraftingMats_FilterBox_FBT_CheckBox2.Location = New System.Drawing.Point(37, 73)
        Me.CraftingMats_FilterBox_FBT_CheckBox2.Name = "CraftingMats_FilterBox_FBT_CheckBox2"
        Me.CraftingMats_FilterBox_FBT_CheckBox2.Size = New System.Drawing.Size(58, 17)
        Me.CraftingMats_FilterBox_FBT_CheckBox2.TabIndex = 9
        Me.CraftingMats_FilterBox_FBT_CheckBox2.Text = "Or less"
        Me.CraftingMats_FilterBox_FBT_CheckBox2.UseVisualStyleBackColor = True
        '
        'CraftingMats_FilterBox_FBT_CheckBox1
        '
        Me.CraftingMats_FilterBox_FBT_CheckBox1.AutoSize = True
        Me.CraftingMats_FilterBox_FBT_CheckBox1.Location = New System.Drawing.Point(37, 50)
        Me.CraftingMats_FilterBox_FBT_CheckBox1.Name = "CraftingMats_FilterBox_FBT_CheckBox1"
        Me.CraftingMats_FilterBox_FBT_CheckBox1.Size = New System.Drawing.Size(64, 17)
        Me.CraftingMats_FilterBox_FBT_CheckBox1.TabIndex = 8
        Me.CraftingMats_FilterBox_FBT_CheckBox1.Text = "Or More"
        Me.CraftingMats_FilterBox_FBT_CheckBox1.UseVisualStyleBackColor = True
        '
        'CraftingMats_FilterBox_FBT_ComboBox1
        '
        Me.CraftingMats_FilterBox_FBT_ComboBox1.FormattingEnabled = True
        Me.CraftingMats_FilterBox_FBT_ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.CraftingMats_FilterBox_FBT_ComboBox1.Location = New System.Drawing.Point(37, 25)
        Me.CraftingMats_FilterBox_FBT_ComboBox1.Name = "CraftingMats_FilterBox_FBT_ComboBox1"
        Me.CraftingMats_FilterBox_FBT_ComboBox1.Size = New System.Drawing.Size(39, 21)
        Me.CraftingMats_FilterBox_FBT_ComboBox1.TabIndex = 3
        '
        'CraftingMats_FilterBox_ByTier_CheckBox
        '
        Me.CraftingMats_FilterBox_ByTier_CheckBox.AutoSize = True
        Me.CraftingMats_FilterBox_ByTier_CheckBox.Location = New System.Drawing.Point(6, 69)
        Me.CraftingMats_FilterBox_ByTier_CheckBox.Name = "CraftingMats_FilterBox_ByTier_CheckBox"
        Me.CraftingMats_FilterBox_ByTier_CheckBox.Size = New System.Drawing.Size(59, 17)
        Me.CraftingMats_FilterBox_ByTier_CheckBox.TabIndex = 0
        Me.CraftingMats_FilterBox_ByTier_CheckBox.Text = "By Tier"
        Me.CraftingMats_FilterBox_ByTier_CheckBox.UseVisualStyleBackColor = True
        '
        'CraftingMats_FilterBox_Filter
        '
        Me.CraftingMats_FilterBox_Filter.Location = New System.Drawing.Point(6, 112)
        Me.CraftingMats_FilterBox_Filter.Name = "CraftingMats_FilterBox_Filter"
        Me.CraftingMats_FilterBox_Filter.Size = New System.Drawing.Size(75, 23)
        Me.CraftingMats_FilterBox_Filter.TabIndex = 7
        Me.CraftingMats_FilterBox_Filter.Text = "Filter"
        Me.CraftingMats_FilterBox_Filter.UseVisualStyleBackColor = True
        '
        'CraftingMats_FilterBox_Reset
        '
        Me.CraftingMats_FilterBox_Reset.Location = New System.Drawing.Point(95, 112)
        Me.CraftingMats_FilterBox_Reset.Name = "CraftingMats_FilterBox_Reset"
        Me.CraftingMats_FilterBox_Reset.Size = New System.Drawing.Size(75, 23)
        Me.CraftingMats_FilterBox_Reset.TabIndex = 6
        Me.CraftingMats_FilterBox_Reset.Text = "Reset"
        Me.CraftingMats_FilterBox_Reset.UseVisualStyleBackColor = True
        '
        'CraftingMats_FilterBox_ComboBox1
        '
        Me.CraftingMats_FilterBox_ComboBox1.FormattingEnabled = True
        Me.CraftingMats_FilterBox_ComboBox1.Items.AddRange(New Object() {"All", "Crafting Skills", "  Armormech", "  Armstech", "  Artifice", "  Biochem ", "  Cybertech", "  Synthweaving", "Gathering Skills", "  Archaeology", "  Bioanalysis", "  Scavenging", "  Slicing", "Mission Skills", "  Diplomacy", "  Investigation", "  Treasure Hunting", "  Underworld Trading"})
        Me.CraftingMats_FilterBox_ComboBox1.Location = New System.Drawing.Point(95, 46)
        Me.CraftingMats_FilterBox_ComboBox1.Name = "CraftingMats_FilterBox_ComboBox1"
        Me.CraftingMats_FilterBox_ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.CraftingMats_FilterBox_ComboBox1.TabIndex = 5
        '
        'CraftingMats_FilterBox_ByCrewSkill_CheckBox
        '
        Me.CraftingMats_FilterBox_ByCrewSkill_CheckBox.AutoSize = True
        Me.CraftingMats_FilterBox_ByCrewSkill_CheckBox.Location = New System.Drawing.Point(6, 46)
        Me.CraftingMats_FilterBox_ByCrewSkill_CheckBox.Name = "CraftingMats_FilterBox_ByCrewSkill_CheckBox"
        Me.CraftingMats_FilterBox_ByCrewSkill_CheckBox.Size = New System.Drawing.Size(87, 17)
        Me.CraftingMats_FilterBox_ByCrewSkill_CheckBox.TabIndex = 2
        Me.CraftingMats_FilterBox_ByCrewSkill_CheckBox.Text = "By Crew Skill"
        Me.CraftingMats_FilterBox_ByCrewSkill_CheckBox.UseVisualStyleBackColor = True
        '
        'CraftingMats_FilterBox_ByPlanet_CheckBox
        '
        Me.CraftingMats_FilterBox_ByPlanet_CheckBox.AutoSize = True
        Me.CraftingMats_FilterBox_ByPlanet_CheckBox.Location = New System.Drawing.Point(6, 19)
        Me.CraftingMats_FilterBox_ByPlanet_CheckBox.Name = "CraftingMats_FilterBox_ByPlanet_CheckBox"
        Me.CraftingMats_FilterBox_ByPlanet_CheckBox.Size = New System.Drawing.Size(71, 17)
        Me.CraftingMats_FilterBox_ByPlanet_CheckBox.TabIndex = 1
        Me.CraftingMats_FilterBox_ByPlanet_CheckBox.Text = "By Planet"
        Me.CraftingMats_FilterBox_ByPlanet_CheckBox.UseVisualStyleBackColor = True
        '
        'CraftingMat_Panel1
        '
        Me.CraftingMat_Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CraftingMat_Panel1.Controls.Add(Me.CraftingMat_SplitContainer)
        Me.CraftingMat_Panel1.Location = New System.Drawing.Point(3, 46)
        Me.CraftingMat_Panel1.Name = "CraftingMat_Panel1"
        Me.CraftingMat_Panel1.Size = New System.Drawing.Size(574, 317)
        Me.CraftingMat_Panel1.TabIndex = 0
        '
        'CraftingMat_SplitContainer
        '
        Me.CraftingMat_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CraftingMat_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CraftingMat_SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.CraftingMat_SplitContainer.Name = "CraftingMat_SplitContainer"
        '
        'CraftingMat_SplitContainer.Panel1
        '
        Me.CraftingMat_SplitContainer.Panel1.Controls.Add(Me.CraftingMat_ListView)
        Me.CraftingMat_SplitContainer.Panel1MinSize = 200
        '
        'CraftingMat_SplitContainer.Panel2
        '
        Me.CraftingMat_SplitContainer.Panel2.Controls.Add(Me.CraftingMat_Info_Planets)
        Me.CraftingMat_SplitContainer.Panel2.Controls.Add(Me.CraftingMat_Info_Tier1)
        Me.CraftingMat_SplitContainer.Panel2.Controls.Add(Me.CraftingMat_Info_Tier2)
        Me.CraftingMat_SplitContainer.Panel2.Controls.Add(Me.CraftingMat_Info_SkillLvl2)
        Me.CraftingMat_SplitContainer.Panel2.Controls.Add(Me.CraftingMat_Info_SkillLvl1)
        Me.CraftingMat_SplitContainer.Panel2.Controls.Add(Me.CraftingMat_Info_CrewSkill1)
        Me.CraftingMat_SplitContainer.Panel2.Controls.Add(Me.CraftingMat_Info_CrewSkill2)
        Me.CraftingMat_SplitContainer.Panel2.Controls.Add(Me.CraftingMst_Name)
        Me.CraftingMat_SplitContainer.Panel2.Controls.Add(Me.CraftingMat_Icon)
        Me.CraftingMat_SplitContainer.Panel2MinSize = 200
        Me.CraftingMat_SplitContainer.Size = New System.Drawing.Size(574, 317)
        Me.CraftingMat_SplitContainer.SplitterDistance = 233
        Me.CraftingMat_SplitContainer.TabIndex = 0
        '
        'CraftingMat_ListView
        '
        Me.CraftingMat_ListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CraftingMat_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CraftingMat_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.CraftingMat_ListView.FullRowSelect = True
        Me.CraftingMat_ListView.GridLines = True
        Me.CraftingMat_ListView.Location = New System.Drawing.Point(3, 3)
        Me.CraftingMat_ListView.MultiSelect = False
        Me.CraftingMat_ListView.Name = "CraftingMat_ListView"
        Me.CraftingMat_ListView.Size = New System.Drawing.Size(223, 307)
        Me.CraftingMat_ListView.TabIndex = 0
        Me.CraftingMat_ListView.UseCompatibleStateImageBehavior = False
        Me.CraftingMat_ListView.View = System.Windows.Forms.View.Details
        'CraftingMat_Info_Planets
        '
        Me.CraftingMat_Info_Planets.Controls.Add(Me.CraftingMat_Info_Planetlist)
        Me.CraftingMat_Info_Planets.Location = New System.Drawing.Point(3, 128)
        Me.CraftingMat_Info_Planets.Name = "CraftingMat_Info_Planets"
        Me.CraftingMat_Info_Planets.Size = New System.Drawing.Size(191, 100)
        Me.CraftingMat_Info_Planets.TabIndex = 8
        Me.CraftingMat_Info_Planets.TabStop = False
        Me.CraftingMat_Info_Planets.Text = "Planets"
        '
        'CraftingMat_Info_Planetlist
        '
        Me.CraftingMat_Info_Planetlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CraftingMat_Info_Planetlist.Location = New System.Drawing.Point(9, 16)
        Me.CraftingMat_Info_Planetlist.Name = "CraftingMat_Info_Planetlist"
        Me.CraftingMat_Info_Planetlist.Size = New System.Drawing.Size(176, 81)
        Me.CraftingMat_Info_Planetlist.TabIndex = 0
        '
        'CraftingMat_Info_Tier1
        '
        Me.CraftingMat_Info_Tier1.AutoSize = True
        Me.CraftingMat_Info_Tier1.Location = New System.Drawing.Point(131, 92)
        Me.CraftingMat_Info_Tier1.Name = "CraftingMat_Info_Tier1"
        Me.CraftingMat_Info_Tier1.Size = New System.Drawing.Size(25, 13)
        Me.CraftingMat_Info_Tier1.TabIndex = 7
        Me.CraftingMat_Info_Tier1.Text = "Tier"
        '
        'CraftingMat_Info_Tier2
        '
        Me.CraftingMat_Info_Tier2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CraftingMat_Info_Tier2.Location = New System.Drawing.Point(134, 105)
        Me.CraftingMat_Info_Tier2.MaximumSize = New System.Drawing.Size(300, 0)
        Me.CraftingMat_Info_Tier2.MinimumSize = New System.Drawing.Size(60, 20)
        Me.CraftingMat_Info_Tier2.Name = "CraftingMat_Info_Tier2"
        Me.CraftingMat_Info_Tier2.Size = New System.Drawing.Size(60, 20)
        Me.CraftingMat_Info_Tier2.TabIndex = 6
        Me.CraftingMat_Info_Tier2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CraftingMat_Info_SkillLvl2
        '
        Me.CraftingMat_Info_SkillLvl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CraftingMat_Info_SkillLvl2.Location = New System.Drawing.Point(63, 105)
        Me.CraftingMat_Info_SkillLvl2.MaximumSize = New System.Drawing.Size(300, 0)
        Me.CraftingMat_Info_SkillLvl2.MinimumSize = New System.Drawing.Size(60, 20)
        Me.CraftingMat_Info_SkillLvl2.Name = "CraftingMat_Info_SkillLvl2"
        Me.CraftingMat_Info_SkillLvl2.Size = New System.Drawing.Size(60, 20)
        Me.CraftingMat_Info_SkillLvl2.TabIndex = 5
        Me.CraftingMat_Info_SkillLvl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CraftingMat_Info_SkillLvl1
        '
        Me.CraftingMat_Info_SkillLvl1.AutoSize = True
        Me.CraftingMat_Info_SkillLvl1.Location = New System.Drawing.Point(63, 92)
        Me.CraftingMat_Info_SkillLvl1.Name = "CraftingMat_Info_SkillLvl1"
        Me.CraftingMat_Info_SkillLvl1.Size = New System.Drawing.Size(55, 13)
        Me.CraftingMat_Info_SkillLvl1.TabIndex = 4
        Me.CraftingMat_Info_SkillLvl1.Text = "Skill Level"
        '
        'CraftingMat_Info_CrewSkill1
        '
        Me.CraftingMat_Info_CrewSkill1.AutoSize = True
        Me.CraftingMat_Info_CrewSkill1.Location = New System.Drawing.Point(63, 59)
        Me.CraftingMat_Info_CrewSkill1.Name = "CraftingMat_Info_CrewSkill1"
        Me.CraftingMat_Info_CrewSkill1.Size = New System.Drawing.Size(48, 13)
        Me.CraftingMat_Info_CrewSkill1.TabIndex = 3
        Me.CraftingMat_Info_CrewSkill1.Text = "Crewskill"
        '
        'CraftingMat_Info_CrewSkill2
        '
        Me.CraftingMat_Info_CrewSkill2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CraftingMat_Info_CrewSkill2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CraftingMat_Info_CrewSkill2.Location = New System.Drawing.Point(66, 72)
        Me.CraftingMat_Info_CrewSkill2.MaximumSize = New System.Drawing.Size(300, 0)
        Me.CraftingMat_Info_CrewSkill2.MinimumSize = New System.Drawing.Size(128, 20)
        Me.CraftingMat_Info_CrewSkill2.Name = "CraftingMat_Info_CrewSkill2"
        Me.CraftingMat_Info_CrewSkill2.Size = New System.Drawing.Size(261, 20)
        Me.CraftingMat_Info_CrewSkill2.TabIndex = 2
        Me.CraftingMat_Info_CrewSkill2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CraftingMst_Name
        '
        Me.CraftingMst_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CraftingMst_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CraftingMst_Name.Location = New System.Drawing.Point(63, 20)
        Me.CraftingMst_Name.MaximumSize = New System.Drawing.Size(300, 0)
        Me.CraftingMst_Name.MinimumSize = New System.Drawing.Size(128, 20)
        Me.CraftingMst_Name.Name = "CraftingMst_Name"
        Me.CraftingMst_Name.Size = New System.Drawing.Size(261, 20)
        Me.CraftingMst_Name.TabIndex = 1
        Me.CraftingMst_Name.Text = ""
        Me.CraftingMst_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CraftingMat_Icon
        '
        Me.CraftingMat_Icon.BackColor = System.Drawing.Color.Transparent
        Me.CraftingMat_Icon.Location = New System.Drawing.Point(3, 3)
        Me.CraftingMat_Icon.Name = "CraftingMat_Icon"
        Me.CraftingMat_Icon.Size = New System.Drawing.Size(54, 54)
        Me.CraftingMat_Icon.TabIndex = 0
        Me.CraftingMat_Icon.TabStop = False
        '
        'CraftingMats_FilterBox_TextBox1
        '
        Me.CraftingMats_FilterBox_TextBox1.Location = New System.Drawing.Point(95, 20)
        Me.CraftingMats_FilterBox_TextBox1.Name = "CraftingMats_FilterBox_TextBox1"
        Me.CraftingMats_FilterBox_TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.CraftingMats_FilterBox_TextBox1.TabIndex = 10
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tier"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Crew Skill"
        '
        'Form1
        '

        win.Controls.Add(UI_Panel)

        UI_Panel.ResumeLayout(False)
        Me.CraftingMats_FilterBox.ResumeLayout(False)
        Me.CraftingMats_FilterBox.PerformLayout()
        Me.CraftingMats_FilterBox_FBT.ResumeLayout(False)
        Me.CraftingMats_FilterBox_FBT.PerformLayout()
        Me.CraftingMat_Panel1.ResumeLayout(False)
        Me.CraftingMat_SplitContainer.Panel1.ResumeLayout(False)
        Me.CraftingMat_SplitContainer.Panel2.ResumeLayout(False)
        Me.CraftingMat_SplitContainer.Panel2.PerformLayout()
        CType(Me.CraftingMat_SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CraftingMat_SplitContainer.ResumeLayout(False)
        Me.CraftingMat_Info_Planets.ResumeLayout(False)
        CType(Me.CraftingMat_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        win.ResumeLayout(False)

        CraftingMats_FilterBox_FBT_ComboBox1.SelectedIndex = 0
        CraftingMats_FilterBox_ComboBox1.SelectedIndex = 0
        UpdateList()
    End Sub
    Private Sub UpdateList()
        CraftingMat_ListView.BeginUpdate()
        CraftingMat_ListView.Items.Clear()
        For Each item As My_item In Items
            If item.Type = "Crafting" Then
                Dim lvwItem As ListViewItem = New ListViewItem(item.Tier.ToString)
                lvwItem.SubItems.Add(item.Name)
                lvwItem.SubItems.Add(item.Crewskill)
                CraftingMat_ListView.Items.Add(lvwItem)
            End If
        Next

        For Each col As ColumnHeader In CraftingMat_ListView.Columns
            Dim index = CraftingMat_ListView.Columns.IndexOf(col)
            CraftingMat_ListView.AutoResizeColumn(index, ColumnHeaderAutoResizeStyle.HeaderSize)
        Next
        CraftingMat_ListView.EndUpdate()
    End Sub


    Private Sub CraftingMats_FilterBox_Filter_Click(sender As Object, e As EventArgs) Handles CraftingMats_FilterBox_Filter.Click

        Dim list As ListView = CraftingMat_ListView
        list.BeginUpdate()
        list.Items.Clear()
        UpdateList()
        Dim bypla As Boolean = CraftingMats_FilterBox_ByPlanet_CheckBox.Checked
        Dim byplatext As String = CraftingMats_FilterBox_TextBox1.Text

        Dim bycs As Boolean = CraftingMats_FilterBox_ByCrewSkill_CheckBox.Checked
        Dim bycstext As String = Trim(CraftingMats_FilterBox_ComboBox1.GetItemText(CraftingMats_FilterBox_ComboBox1.SelectedItem))
        If bycstext = "All" Then
            bycstext = Nothing
        End If

        Dim byter As Boolean = CraftingMats_FilterBox_ByTier_CheckBox.Checked
        Dim bytertext As String = CraftingMats_FilterBox_FBT_ComboBox1.GetItemText(CraftingMats_FilterBox_FBT_ComboBox1.SelectedItem)
        Dim byterormore As Boolean = CraftingMats_FilterBox_FBT_CheckBox1.Checked
        Dim byterorless As Boolean = CraftingMats_FilterBox_FBT_CheckBox2.Checked
        Dim bytermoreorless As String = ""
        If byterormore = False And byterorless = False Then
            bytermoreorless = "Equal"
        Else
            If byterormore = True Then
                bytermoreorless = "Greater"
            Else
                bytermoreorless = "Less"
            End If
        End If





        For Each listitem As ListViewItem In CraftingMat_ListView.Items
            Dim sellvl As String = listitem.Text
            Dim selcre As String = listitem.SubItems(2).Text
            If bytertext <> Nothing And byter = True Then
                Dim index As Integer = listitem.Index
                list.Items(index).Selected = True
                Select Case bytermoreorless
                    Case "Equal"
                        If CInt(sellvl) <> CInt(bytertext) Then
                            listitem.Remove()
                        End If
                    Case "Greater"
                        If CInt(sellvl) < CInt(bytertext) Then
                            listitem.Remove()
                        End If
                    Case "Less"
                        If CInt(sellvl) > CInt(bytertext) Then
                            listitem.Remove()
                        End If
                End Select
            End If

            If bycs = True And bycstext <> Nothing Then
                If Not selcre = bycstext Then
                    listitem.Remove()
                End If
            End If

            If byplatext <> Nothing And bypla = True Then
                For Each item In Items
                    If item.Name = listitem.SubItems(1).Text Then

                        If InStr(item.Planet, byplatext) = Nothing Then
                            listitem.Remove()
                        End If
                    End If
                Next
            End If
        Next

        list.EndUpdate()

    End Sub
    Private Sub CraftingMats_FilterBox_Reset_Click(sender As Object, e As EventArgs) Handles CraftingMats_FilterBox_Reset.Click
        UpdateList()
        CraftingMats_FilterBox_FBT_CheckBox1.Checked = False
        CraftingMats_FilterBox_FBT_CheckBox2.Checked = False
        CraftingMats_FilterBox_ByCrewSkill_CheckBox.Checked = False
        CraftingMats_FilterBox_ByPlanet_CheckBox.Checked = False
        CraftingMats_FilterBox_ByTier_CheckBox.Checked = False
        CraftingMats_FilterBox_FBT_ComboBox1.SelectedIndex = 0
        CraftingMats_FilterBox_ComboBox1.SelectedIndex = 0
        CraftingMats_FilterBox_TextBox1.Text = Nothing
    End Sub
    Private Sub CraftingMats_FilterBox_FBT_CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CraftingMats_FilterBox_FBT_CheckBox2.CheckedChanged
        If CraftingMats_FilterBox_FBT_CheckBox2.Checked = True Then
            CraftingMats_FilterBox_FBT_CheckBox1.Checked = False
        End If
    End Sub
    Private Sub CraftingMats_FilterBox_FBT_CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CraftingMats_FilterBox_FBT_CheckBox1.CheckedChanged
        If CraftingMats_FilterBox_FBT_CheckBox1.Checked = True Then
            CraftingMats_FilterBox_FBT_CheckBox2.Checked = False
        End If
    End Sub
    Private Sub Crafting_Mats_ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CraftingMat_ListView.SelectedIndexChanged
        If CraftingMat_ListView.SelectedItems.Count > 0 Then
            Dim name = CraftingMat_ListView.SelectedItems.Item(0).SubItems(1).Text
            For Each item As My_item In Items
                If name = item.Name Then
                    CraftingMat_Icon.Image = item.Icon
                    CraftingMst_Name.Text = item.Name
                    CraftingMat_Info_CrewSkill2.Text = item.Crewskill
                    CraftingMat_Info_SkillLvl2.Text = item.SkillLvl
                    CraftingMat_Info_Tier2.Text = item.Tier
                    If item.Planet <> Nothing Then
                        CraftingMat_Info_Planetlist.Text = item.Planet.Replace(", ", vbCrLf)
                    End If
                    Exit For
                End If
            Next

        End If
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CraftingMat_Panel1 As Panel
    Friend WithEvents CraftingMat_SplitContainer As SplitContainer
    Friend WithEvents CraftingMat_ListView As ListView
    Friend WithEvents CraftingMst_Name As Label
    Friend WithEvents CraftingMat_Icon As PictureBox
    Friend WithEvents CraftingMats_FilterBox As GroupBox
    Friend WithEvents CraftingMats_FilterBox_FBT As GroupBox
    Friend WithEvents CraftingMats_FilterBox_FBT_Label1 As Label
    Friend WithEvents CraftingMats_FilterBox_FBT_CheckBox2 As CheckBox
    Friend WithEvents CraftingMats_FilterBox_FBT_CheckBox1 As CheckBox
    Friend WithEvents CraftingMats_FilterBox_FBT_ComboBox1 As ComboBox
    Friend WithEvents CraftingMats_FilterBox_ByTier_CheckBox As CheckBox
    Friend WithEvents CraftingMats_FilterBox_Filter As Button
    Friend WithEvents CraftingMats_FilterBox_Reset As Button
    Friend WithEvents CraftingMats_FilterBox_ComboBox1 As ComboBox
    Friend WithEvents CraftingMats_FilterBox_ByCrewSkill_CheckBox As CheckBox
    Friend WithEvents CraftingMats_FilterBox_ByPlanet_CheckBox As CheckBox
    Friend WithEvents CraftingMat_Title As Label
    Friend WithEvents CraftingMat_Info_CrewSkill1 As Label
    Friend WithEvents CraftingMat_Info_CrewSkill2 As Label
    Friend WithEvents CraftingMat_Info_SkillLvl2 As Label
    Friend WithEvents CraftingMat_Info_SkillLvl1 As Label
    Friend WithEvents CraftingMat_Info_Planets As GroupBox
    Friend WithEvents CraftingMat_Info_Tier1 As Label
    Friend WithEvents CraftingMat_Info_Tier2 As Label
    Friend WithEvents CraftingMat_Info_Planetlist As Label
    Friend WithEvents CraftingMats_FilterBox_TextBox1 As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader

End Class
