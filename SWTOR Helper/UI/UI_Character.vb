Public Class UI_Character
    Inherits UI
    Friend WithEvents Events As My_Events = My_functions.Events
    Private _char As Character


    Sub New(c As Character, cn As TreeNode)
        _char = c
        UI_Name = AddTreeNode(UI_Main.treeview, c.SWTOR_Name, cn.Name)
        UI_TreeViewNode = GetDictItem(UI_Name, TreeViewNodes)
        UI_Panel = NewPanel(UI_Name)
        _titlelabel = New Label


        Me.Companions_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Companions_Crit15 = New System.Windows.Forms.Label()
        Me.Companions_Crt10 = New System.Windows.Forms.Label()
        Me.Companions_Label4 = New System.Windows.Forms.Label()
        Me.Companions_Label3 = New System.Windows.Forms.Label()
        Me.Companions_Add = New System.Windows.Forms.Button()
        Me.Companions_TNL = New System.Windows.Forms.Label()
        Me.Companions_Label1 = New System.Windows.Forms.Label()
        Me.Companions_GP = New System.Windows.Forms.GroupBox()
        Me.Companions_GP_Label = New System.Windows.Forms.Label()
        Me.Companions_Rem = New System.Windows.Forms.Button()
        Me.Companions_Influ_Set = New System.Windows.Forms.Button()
        Me.Companions_Infl = New System.Windows.Forms.NumericUpDown()
        Me.Companions_Label2 = New System.Windows.Forms.Label()
        Me.Companions_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Companions_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Companions_ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChrInfo_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ChrInfo_Discipline = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.ChrInfo_Label6 = New System.Windows.Forms.Label()
        Me.ChrInfo_ComboBox_Class = New System.Windows.Forms.ComboBox()
        Me.ChrInfo_AdvClass = New System.Windows.Forms.ComboBox()
        Me.ChrInfo_Label2 = New System.Windows.Forms.Label()
        Me.ChrInfo_Label1 = New System.Windows.Forms.Label()
        Me.ChrInfo_CrewLvl3 = New System.Windows.Forms.NumericUpDown()
        Me.ChrInfo_CrewLvl2 = New System.Windows.Forms.NumericUpDown()
        Me.ChrInfo_CrewLvl1 = New System.Windows.Forms.NumericUpDown()
        Me.ChrInfo_Label8 = New System.Windows.Forms.Label()
        Me.ChrInfo_Label9 = New System.Windows.Forms.Label()
        Me.ChrInfo_Label7 = New System.Windows.Forms.Label()
        Me.ChrInfo_Label4 = New System.Windows.Forms.Label()
        Me.ChrInfo_Label5 = New System.Windows.Forms.Label()
        Me.ChrInfo_Label3 = New System.Windows.Forms.Label()
        Me.ChrInfo_Crew3 = New System.Windows.Forms.ComboBox()
        Me.ChrInfo_Crew2 = New System.Windows.Forms.ComboBox()
        Me.ChrInfo_Crew1 = New System.Windows.Forms.ComboBox()
        Me.Currency_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Currency_Set = New System.Windows.Forms.Button()
        Me.Currency_Rem = New System.Windows.Forms.Button()
        Me.Currency_Add = New System.Windows.Forms.Button()
        Me.Currency_TextBox = New System.Windows.Forms.TextBox()
        Me.Currency_ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Inv_OV = New System.Windows.Forms.GroupBox()
        Me.Inv_OV_ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._titlelabel = New System.Windows.Forms.Label()
        Me.UI_Panel.SuspendLayout()
        Me.Companions_GroupBox.SuspendLayout()
        Me.Companions_GP.SuspendLayout()
        CType(Me.Companions_Infl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Companions_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChrInfo_GroupBox.SuspendLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChrInfo_CrewLvl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChrInfo_CrewLvl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChrInfo_CrewLvl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Currency_GroupBox.SuspendLayout()
        Me.Inv_OV.SuspendLayout()
        '
        'UI_Panel
        '
        Me.UI_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UI_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UI_Panel.Controls.Add(Me.Companions_GroupBox)
        Me.UI_Panel.Controls.Add(Me.ChrInfo_GroupBox)
        Me.UI_Panel.Controls.Add(Me.Currency_GroupBox)
        Me.UI_Panel.Controls.Add(Me.Inv_OV)
        Me.UI_Panel.Controls.Add(Me._titlelabel)
        Me.UI_Panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.UI_Panel.Location = New System.Drawing.Point(218, 27)
        Me.UI_Panel.Name = "UI_Panel"
        Me.UI_Panel.Size = New System.Drawing.Size(554, 522)
        Me.UI_Panel.TabIndex = 0
        '
        'Companions_GroupBox
        '
        Me.Companions_GroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Crit15)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Crt10)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Label4)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Label3)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Add)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_TNL)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Label1)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_GP)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Rem)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Influ_Set)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Infl)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_Label2)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_CheckBox)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_PictureBox)
        Me.Companions_GroupBox.Controls.Add(Me.Companions_ListView)
        Me.Companions_GroupBox.Location = New System.Drawing.Point(207, 248)
        Me.Companions_GroupBox.Name = "Companions_GroupBox"
        Me.Companions_GroupBox.Size = New System.Drawing.Size(338, 267)
        Me.Companions_GroupBox.TabIndex = 4
        Me.Companions_GroupBox.TabStop = False
        Me.Companions_GroupBox.Text = "Companions"
        '
        'Companions_Crit15
        '
        Me.Companions_Crit15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Companions_Crit15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Companions_Crit15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Companions_Crit15.Location = New System.Drawing.Point(58, 232)
        Me.Companions_Crit15.Name = "Companions_Crit15"
        Me.Companions_Crit15.Size = New System.Drawing.Size(37, 21)
        Me.Companions_Crit15.TabIndex = 19
        Me.Companions_Crit15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Companions_Crt10
        '
        Me.Companions_Crt10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Companions_Crt10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Companions_Crt10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Companions_Crt10.Location = New System.Drawing.Point(9, 232)
        Me.Companions_Crt10.Name = "Companions_Crt10"
        Me.Companions_Crt10.Size = New System.Drawing.Size(37, 21)
        Me.Companions_Crt10.TabIndex = 18
        Me.Companions_Crt10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Companions_Label4
        '
        Me.Companions_Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Companions_Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Companions_Label4.Location = New System.Drawing.Point(58, 211)
        Me.Companions_Label4.Name = "Companions_Label4"
        Me.Companions_Label4.Size = New System.Drawing.Size(37, 14)
        Me.Companions_Label4.TabIndex = 17
        Me.Companions_Label4.Text = "Crit %"
        '
        'Companions_Label3
        '
        Me.Companions_Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Companions_Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Companions_Label3.Location = New System.Drawing.Point(9, 211)
        Me.Companions_Label3.Name = "Companions_Label3"
        Me.Companions_Label3.Size = New System.Drawing.Size(37, 14)
        Me.Companions_Label3.TabIndex = 16
        Me.Companions_Label3.Text = "Crit %"
        '
        'Companions_Add
        '
        Me.Companions_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Companions_Add.Location = New System.Drawing.Point(6, 164)
        Me.Companions_Add.Name = "Companions_Add"
        Me.Companions_Add.Size = New System.Drawing.Size(40, 40)
        Me.Companions_Add.TabIndex = 4
        Me.Companions_Add.Text = "+"
        Me.Companions_Add.UseVisualStyleBackColor = True
        '
        'Companions_TNL
        '
        Me.Companions_TNL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Companions_TNL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Companions_TNL.Location = New System.Drawing.Point(257, 46)
        Me.Companions_TNL.Name = "Companions_TNL"
        Me.Companions_TNL.Size = New System.Drawing.Size(71, 20)
        Me.Companions_TNL.TabIndex = 14
        Me.Companions_TNL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Companions_Label1
        '
        Me.Companions_Label1.AutoSize = True
        Me.Companions_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Companions_Label1.Location = New System.Drawing.Point(254, 29)
        Me.Companions_Label1.Name = "Companions_Label1"
        Me.Companions_Label1.Size = New System.Drawing.Size(74, 13)
        Me.Companions_Label1.TabIndex = 13
        Me.Companions_Label1.Text = "Till Next Level"
        '
        'Companions_GP
        '
        Me.Companions_GP.Controls.Add(Me.Companions_GP_Label)
        Me.Companions_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Companions_GP.Location = New System.Drawing.Point(101, 157)
        Me.Companions_GP.Name = "Companions_GP"
        Me.Companions_GP.Size = New System.Drawing.Size(230, 100)
        Me.Companions_GP.TabIndex = 12
        Me.Companions_GP.TabStop = False
        Me.Companions_GP.Text = "Gift Preference"
        '
        'Companions_GP_Label
        '
        Me.Companions_GP_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Companions_GP_Label.Location = New System.Drawing.Point(6, 17)
        Me.Companions_GP_Label.Name = "Companions_GP_Label"
        Me.Companions_GP_Label.Size = New System.Drawing.Size(218, 90)
        Me.Companions_GP_Label.TabIndex = 0
        '
        'Companions_Rem
        '
        Me.Companions_Rem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Companions_Rem.Location = New System.Drawing.Point(55, 164)
        Me.Companions_Rem.Name = "Companions_Rem"
        Me.Companions_Rem.Size = New System.Drawing.Size(40, 40)
        Me.Companions_Rem.TabIndex = 5
        Me.Companions_Rem.Text = "-"
        Me.Companions_Rem.UseVisualStyleBackColor = True
        '
        'Companions_Influ_Set
        '
        Me.Companions_Influ_Set.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Companions_Influ_Set.Location = New System.Drawing.Point(285, 112)
        Me.Companions_Influ_Set.Name = "Companions_Influ_Set"
        Me.Companions_Influ_Set.Size = New System.Drawing.Size(40, 40)
        Me.Companions_Influ_Set.TabIndex = 2
        Me.Companions_Influ_Set.Text = "Set"
        Me.Companions_Influ_Set.UseVisualStyleBackColor = True
        '
        'Companions_Infl
        '
        Me.Companions_Infl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Companions_Infl.Location = New System.Drawing.Point(193, 129)
        Me.Companions_Infl.Maximum = New Decimal(New Integer() {250000, 0, 0, 0})
        Me.Companions_Infl.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Companions_Infl.Name = "Companions_Infl"
        Me.Companions_Infl.Size = New System.Drawing.Size(89, 23)
        Me.Companions_Infl.TabIndex = 1
        Me.Companions_Infl.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Companions_Label2
        '
        Me.Companions_Label2.AutoSize = True
        Me.Companions_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Companions_Label2.Location = New System.Drawing.Point(196, 112)
        Me.Companions_Label2.Name = "Companions_Label2"
        Me.Companions_Label2.Size = New System.Drawing.Size(51, 13)
        Me.Companions_Label2.TabIndex = 6
        Me.Companions_Label2.Text = "Influence"
        '
        'Companions_CheckBox
        '
        Me.Companions_CheckBox.AutoSize = True
        Me.Companions_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Companions_CheckBox.Location = New System.Drawing.Point(196, 88)
        Me.Companions_CheckBox.Name = "Companions_CheckBox"
        Me.Companions_CheckBox.Size = New System.Drawing.Size(70, 21)
        Me.Companions_CheckBox.TabIndex = 3
        Me.Companions_CheckBox.Text = "KoTFE"
        Me.Companions_CheckBox.UseVisualStyleBackColor = True
        '
        'Companions_PictureBox
        '
        Me.Companions_PictureBox.Location = New System.Drawing.Point(193, 29)
        Me.Companions_PictureBox.Name = "Companions_PictureBox"
        Me.Companions_PictureBox.Size = New System.Drawing.Size(54, 54)
        Me.Companions_PictureBox.TabIndex = 2
        Me.Companions_PictureBox.TabStop = False
        '
        'Companions_ListView
        '
        Me.Companions_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7})
        Me.Companions_ListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Companions_ListView.Location = New System.Drawing.Point(9, 29)
        Me.Companions_ListView.Name = "Companions_ListView"
        Me.Companions_ListView.Size = New System.Drawing.Size(178, 123)
        Me.Companions_ListView.TabIndex = 0
        Me.Companions_ListView.UseCompatibleStateImageBehavior = False
        Me.Companions_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Level"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Crit"
        '
        'ChrInfo_GroupBox
        '
        Me.ChrInfo_GroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Discipline)
        Me.ChrInfo_GroupBox.Controls.Add(Me.NumericUpDown4)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Label6)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_ComboBox_Class)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_AdvClass)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Label2)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Label1)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_CrewLvl3)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_CrewLvl2)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_CrewLvl1)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Label8)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Label9)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Label7)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Label4)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Label5)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Label3)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Crew3)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Crew2)
        Me.ChrInfo_GroupBox.Controls.Add(Me.ChrInfo_Crew1)
        Me.ChrInfo_GroupBox.Location = New System.Drawing.Point(207, 52)
        Me.ChrInfo_GroupBox.Name = "ChrInfo_GroupBox"
        Me.ChrInfo_GroupBox.Size = New System.Drawing.Size(338, 190)
        Me.ChrInfo_GroupBox.TabIndex = 2
        Me.ChrInfo_GroupBox.TabStop = False
        Me.ChrInfo_GroupBox.Text = "Character Info"
        '
        'ChrInfo_Discipline
        '
        Me.ChrInfo_Discipline.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Discipline.FormattingEnabled = True
        Me.ChrInfo_Discipline.Location = New System.Drawing.Point(222, 60)
        Me.ChrInfo_Discipline.Name = "ChrInfo_Discipline"
        Me.ChrInfo_Discipline.Size = New System.Drawing.Size(109, 24)
        Me.ChrInfo_Discipline.TabIndex = 4
        Me.ChrInfo_Discipline.Enabled = False

        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown4.Location = New System.Drawing.Point(267, 31)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.NumericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(64, 23)
        Me.NumericUpDown4.TabIndex = 2
        Me.NumericUpDown4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChrInfo_Label6
        '
        Me.ChrInfo_Label6.AutoSize = True
        Me.ChrInfo_Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Label6.Location = New System.Drawing.Point(219, 33)
        Me.ChrInfo_Label6.Name = "ChrInfo_Label6"
        Me.ChrInfo_Label6.Size = New System.Drawing.Size(42, 17)
        Me.ChrInfo_Label6.TabIndex = 0
        Me.ChrInfo_Label6.Text = "Level"
        '
        'ChrInfo_ComboBox_Class
        '
        Me.ChrInfo_ComboBox_Class.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_ComboBox_Class.FormattingEnabled = True
        Me.ChrInfo_ComboBox_Class.Location = New System.Drawing.Point(92, 30)
        Me.ChrInfo_ComboBox_Class.Name = "ChrInfo_ComboBox_Class"
        Me.ChrInfo_ComboBox_Class.Size = New System.Drawing.Size(121, 24)
        Me.ChrInfo_ComboBox_Class.TabIndex = 1
        For Each cla In My_Class.Classes
            Me.ChrInfo_ComboBox_Class.Items.Add(cla.Name)
        Next


        '
        'ChrInfo_AdvClass
        '
        Me.ChrInfo_AdvClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_AdvClass.FormattingEnabled = True
        Me.ChrInfo_AdvClass.Location = New System.Drawing.Point(92, 60)
        Me.ChrInfo_AdvClass.Name = "ChrInfo_AdvClass"
        Me.ChrInfo_AdvClass.Size = New System.Drawing.Size(121, 24)
        Me.ChrInfo_AdvClass.TabIndex = 3
        Me.ChrInfo_AdvClass.Enabled = False

        '
        'ChrInfo_Label2
        '
        Me.ChrInfo_Label2.AutoSize = True
        Me.ChrInfo_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Label2.Location = New System.Drawing.Point(6, 63)
        Me.ChrInfo_Label2.Name = "ChrInfo_Label2"
        Me.ChrInfo_Label2.Size = New System.Drawing.Size(74, 17)
        Me.ChrInfo_Label2.TabIndex = 0
        Me.ChrInfo_Label2.Text = "Adv. Class"
        '
        'ChrInfo_Label1
        '
        Me.ChrInfo_Label1.AutoSize = True
        Me.ChrInfo_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Label1.Location = New System.Drawing.Point(6, 33)
        Me.ChrInfo_Label1.Name = "ChrInfo_Label1"
        Me.ChrInfo_Label1.Size = New System.Drawing.Size(42, 17)
        Me.ChrInfo_Label1.TabIndex = 0
        Me.ChrInfo_Label1.Text = "Class"
        '
        'ChrInfo_CrewLvl3
        '
        Me.ChrInfo_CrewLvl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_CrewLvl3.Location = New System.Drawing.Point(267, 152)
        Me.ChrInfo_CrewLvl3.Maximum = New Decimal(New Integer() {550, 0, 0, 0})
        Me.ChrInfo_CrewLvl3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChrInfo_CrewLvl3.Name = "ChrInfo_CrewLvl3"
        Me.ChrInfo_CrewLvl3.Size = New System.Drawing.Size(64, 23)
        Me.ChrInfo_CrewLvl3.TabIndex = 10
        Me.ChrInfo_CrewLvl3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChrInfo_CrewLvl2
        '
        Me.ChrInfo_CrewLvl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_CrewLvl2.Location = New System.Drawing.Point(267, 122)
        Me.ChrInfo_CrewLvl2.Maximum = New Decimal(New Integer() {550, 0, 0, 0})
        Me.ChrInfo_CrewLvl2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChrInfo_CrewLvl2.Name = "ChrInfo_CrewLvl2"
        Me.ChrInfo_CrewLvl2.Size = New System.Drawing.Size(64, 23)
        Me.ChrInfo_CrewLvl2.TabIndex = 8
        Me.ChrInfo_CrewLvl2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChrInfo_CrewLvl1
        '
        Me.ChrInfo_CrewLvl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_CrewLvl1.Location = New System.Drawing.Point(267, 92)
        Me.ChrInfo_CrewLvl1.Maximum = New Decimal(New Integer() {550, 0, 0, 0})
        Me.ChrInfo_CrewLvl1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChrInfo_CrewLvl1.Name = "ChrInfo_CrewLvl1"
        Me.ChrInfo_CrewLvl1.Size = New System.Drawing.Size(64, 23)
        Me.ChrInfo_CrewLvl1.TabIndex = 6
        Me.ChrInfo_CrewLvl1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChrInfo_Label8
        '
        Me.ChrInfo_Label8.AutoSize = True
        Me.ChrInfo_Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Label8.Location = New System.Drawing.Point(219, 124)
        Me.ChrInfo_Label8.Name = "ChrInfo_Label8"
        Me.ChrInfo_Label8.Size = New System.Drawing.Size(42, 17)
        Me.ChrInfo_Label8.TabIndex = 0
        Me.ChrInfo_Label8.Text = "Level"
        '
        'ChrInfo_Label9
        '
        Me.ChrInfo_Label9.AutoSize = True
        Me.ChrInfo_Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Label9.Location = New System.Drawing.Point(219, 154)
        Me.ChrInfo_Label9.Name = "ChrInfo_Label9"
        Me.ChrInfo_Label9.Size = New System.Drawing.Size(42, 17)
        Me.ChrInfo_Label9.TabIndex = 0
        Me.ChrInfo_Label9.Text = "Level"
        '
        'ChrInfo_Label7
        '
        Me.ChrInfo_Label7.AutoSize = True
        Me.ChrInfo_Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Label7.Location = New System.Drawing.Point(219, 94)
        Me.ChrInfo_Label7.Name = "ChrInfo_Label7"
        Me.ChrInfo_Label7.Size = New System.Drawing.Size(42, 17)
        Me.ChrInfo_Label7.TabIndex = 0
        Me.ChrInfo_Label7.Text = "Level"
        '
        'ChrInfo_Label4
        '
        Me.ChrInfo_Label4.AutoSize = True
        Me.ChrInfo_Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Label4.Location = New System.Drawing.Point(6, 124)
        Me.ChrInfo_Label4.Name = "ChrInfo_Label4"
        Me.ChrInfo_Label4.Size = New System.Drawing.Size(80, 17)
        Me.ChrInfo_Label4.TabIndex = 0
        Me.ChrInfo_Label4.Text = "Crew Skill 2"
        '
        'ChrInfo_Label5
        '
        Me.ChrInfo_Label5.AutoSize = True
        Me.ChrInfo_Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Label5.Location = New System.Drawing.Point(6, 154)
        Me.ChrInfo_Label5.Name = "ChrInfo_Label5"
        Me.ChrInfo_Label5.Size = New System.Drawing.Size(80, 17)
        Me.ChrInfo_Label5.TabIndex = 0
        Me.ChrInfo_Label5.Text = "Crew Skill 3"
        '
        'ChrInfo_Label3
        '
        Me.ChrInfo_Label3.AutoSize = True
        Me.ChrInfo_Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Label3.Location = New System.Drawing.Point(6, 94)
        Me.ChrInfo_Label3.Name = "ChrInfo_Label3"
        Me.ChrInfo_Label3.Size = New System.Drawing.Size(80, 17)
        Me.ChrInfo_Label3.TabIndex = 0
        Me.ChrInfo_Label3.Text = "Crew Skill 1"
        '
        'ChrInfo_Crew3
        '
        Me.ChrInfo_Crew3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Crew3.FormattingEnabled = True
        Me.ChrInfo_Crew3.Location = New System.Drawing.Point(92, 151)
        Me.ChrInfo_Crew3.Name = "ChrInfo_Crew3"
        Me.ChrInfo_Crew3.Size = New System.Drawing.Size(121, 24)
        Me.ChrInfo_Crew3.TabIndex = 9
        '
        'ChrInfo_Crew2
        '
        Me.ChrInfo_Crew2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Crew2.FormattingEnabled = True
        Me.ChrInfo_Crew2.Location = New System.Drawing.Point(92, 121)
        Me.ChrInfo_Crew2.Name = "ChrInfo_Crew2"
        Me.ChrInfo_Crew2.Size = New System.Drawing.Size(121, 24)
        Me.ChrInfo_Crew2.TabIndex = 7
        '
        'ChrInfo_Crew1
        '
        Me.ChrInfo_Crew1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ChrInfo_Crew1.FormattingEnabled = True
        Me.ChrInfo_Crew1.Location = New System.Drawing.Point(92, 91)
        Me.ChrInfo_Crew1.Name = "ChrInfo_Crew1"
        Me.ChrInfo_Crew1.Size = New System.Drawing.Size(121, 24)
        Me.ChrInfo_Crew1.TabIndex = 5

        '




        '
        'Currency_GroupBox
        '
        Me.Currency_GroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Currency_GroupBox.Controls.Add(Me.Currency_Set)
        Me.Currency_GroupBox.Controls.Add(Me.Currency_Rem)
        Me.Currency_GroupBox.Controls.Add(Me.Currency_Add)
        Me.Currency_GroupBox.Controls.Add(Me.Currency_TextBox)
        Me.Currency_GroupBox.Controls.Add(Me.Currency_ListView)
        Me.Currency_GroupBox.Location = New System.Drawing.Point(6, 248)
        Me.Currency_GroupBox.Name = "Currency_GroupBox"
        Me.Currency_GroupBox.Size = New System.Drawing.Size(195, 267)
        Me.Currency_GroupBox.TabIndex = 3
        Me.Currency_GroupBox.TabStop = False
        Me.Currency_GroupBox.Text = "Currency"
        '
        'Currency_Set
        '
        Me.Currency_Set.Location = New System.Drawing.Point(132, 200)
        Me.Currency_Set.Name = "Currency_Set"
        Me.Currency_Set.Size = New System.Drawing.Size(57, 57)
        Me.Currency_Set.TabIndex = 4
        Me.Currency_Set.Text = "Set"
        Me.Currency_Set.UseVisualStyleBackColor = True
        '
        'Currency_Rem
        '
        Me.Currency_Rem.Location = New System.Drawing.Point(69, 200)
        Me.Currency_Rem.Name = "Currency_Rem"
        Me.Currency_Rem.Size = New System.Drawing.Size(57, 57)
        Me.Currency_Rem.TabIndex = 3
        Me.Currency_Rem.Text = "-"
        Me.Currency_Rem.UseVisualStyleBackColor = True
        '
        'Currency_Add
        '
        Me.Currency_Add.Location = New System.Drawing.Point(6, 201)
        Me.Currency_Add.Name = "Currency_Add"
        Me.Currency_Add.Size = New System.Drawing.Size(57, 57)
        Me.Currency_Add.TabIndex = 2
        Me.Currency_Add.Text = "+"
        Me.Currency_Add.UseVisualStyleBackColor = True
        '
        'Currency_TextBox
        '
        Me.Currency_TextBox.Location = New System.Drawing.Point(6, 164)
        Me.Currency_TextBox.Name = "Currency_TextBox"
        Me.Currency_TextBox.Size = New System.Drawing.Size(183, 30)
        Me.Currency_TextBox.TabIndex = 1
        '
        'Currency_ListView
        '
        Me.Currency_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.Currency_ListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Currency_ListView.Location = New System.Drawing.Point(6, 29)
        Me.Currency_ListView.Name = "Currency_ListView"
        Me.Currency_ListView.Size = New System.Drawing.Size(183, 123)
        Me.Currency_ListView.TabIndex = 0
        Me.Currency_ListView.UseCompatibleStateImageBehavior = False
        Me.Currency_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name"
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount"
        Me.ColumnHeader6.Width = 87
        '
        'Inv_OV
        '
        Me.Inv_OV.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        Me.Inv_OV.Controls.Add(Me.Inv_OV_ListView)
        Me.Inv_OV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Inv_OV.Location = New System.Drawing.Point(6, 52)
        Me.Inv_OV.Name = "Inv_OV"
        Me.Inv_OV.Size = New System.Drawing.Size(195, 190)
        Me.Inv_OV.TabIndex = 1
        Me.Inv_OV.TabStop = False
        Me.Inv_OV.Text = "Inventory Overview"
        '
        'Inv_OV_ListView
        '
        Me.Inv_OV_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Inv_OV_ListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Inv_OV_ListView.Location = New System.Drawing.Point(6, 29)
        Me.Inv_OV_ListView.Name = "Inv_OV_ListView"
        Me.Inv_OV_ListView.Size = New System.Drawing.Size(183, 153)
        Me.Inv_OV_ListView.TabIndex = 0
        Me.Inv_OV_ListView.UseCompatibleStateImageBehavior = False
        Me.Inv_OV_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Count"
        '
        'titlelabel
        '
        _titlelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        _titlelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _titlelabel.Location = New System.Drawing.Point(6, 6)
        _titlelabel.Name = "titlelabel"
        _titlelabel.Size = New System.Drawing.Size(539, 40)
        _titlelabel.TabIndex = 0
        _titlelabel.Text = c.SWTOR_Name
        _titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        _titlelabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top _
           Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),
            System.Windows.Forms.AnchorStyles)
        '
        'Form1
        '
        Me.UI_Panel.ResumeLayout(False)
        Me.Companions_GroupBox.ResumeLayout(False)
        Me.Companions_GroupBox.PerformLayout()
        Me.Companions_GP.ResumeLayout(False)
        CType(Me.Companions_Infl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Companions_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChrInfo_GroupBox.ResumeLayout(False)
        Me.ChrInfo_GroupBox.PerformLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChrInfo_CrewLvl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChrInfo_CrewLvl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChrInfo_CrewLvl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Currency_GroupBox.ResumeLayout(False)
        Me.Currency_GroupBox.PerformLayout()
        Me.Inv_OV.ResumeLayout(False)

    End Sub
    Private Sub InvChg(sender As Inventory) Handles Events._InventoryChange
        If _char.Inventorys.Contains(sender) Then
            'Update Inv_OV_ListView
        End If

    End Sub

    Private Sub ChrInfo_ComboBox_Class_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChrInfo_ComboBox_Class.SelectedIndexChanged
        Dim selclass As String = ChrInfo_ComboBox_Class.SelectedItem
        ChrInfo_AdvClass.Enabled = True
        If ChrInfo_AdvClass.Items.Count > 0 Then
            While ChrInfo_AdvClass.Items.Count > 0
                ChrInfo_AdvClass.Items.RemoveAt(0)
            End While

        End If
        For Each cla In My_Class.Classes
            If cla.Name = selclass Then
                ChrInfo_AdvClass.Items.Add(cla.GetAdvClass(1))
                ChrInfo_AdvClass.Items.Add(cla.GetAdvClass(2))
                Exit For
            End If
        Next
        _char.ChrClass = ChrInfo_ComboBox_Class.SelectedItem
    End Sub
    Private Sub ChrInfo_AdvClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChrInfo_AdvClass.SelectedIndexChanged
        Dim selclass As String = ChrInfo_ComboBox_Class.SelectedItem
        Dim selAdvClass As String = ChrInfo_AdvClass.SelectedItem
        ChrInfo_Discipline.Enabled = True
        If ChrInfo_Discipline.Items.Count > 0 Then
            While ChrInfo_Discipline.Items.Count > 0
                ChrInfo_Discipline.Items.RemoveAt(0)
            End While
        End If
        For Each cla In My_Class.Classes
            If cla.Name = selclass Then

                ChrInfo_Discipline.Items.Add(cla.GetDiscipline(selAdvClass, 1))
                ChrInfo_Discipline.Items.Add(cla.GetDiscipline(selAdvClass, 2))
                ChrInfo_Discipline.Items.Add(cla.GetDiscipline(selAdvClass, 3))
                Exit For
            End If
        Next
        _char.ChrAdvClass = ChrInfo_AdvClass.SelectedItem

    End Sub
    Private Sub ChrInfo_Discipline_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChrInfo_Discipline.SelectedIndexChanged
        _char.ChrDiscipline = ChrInfo_Discipline.SelectedItem
    End Sub

    Private _titlelabel As Label
    Friend WithEvents Inv_OV As GroupBox
    Friend WithEvents Inv_OV_ListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Companions_GroupBox As GroupBox
    Friend WithEvents ChrInfo_GroupBox As GroupBox
    Friend WithEvents Currency_GroupBox As GroupBox
    Friend WithEvents ChrInfo_Crew1 As ComboBox
    Friend WithEvents Companions_Influ_Set As Button
    Friend WithEvents Companions_Infl As NumericUpDown
    Friend WithEvents Companions_Label2 As Label
    Friend WithEvents Companions_PictureBox As PictureBox
    Friend WithEvents Companions_ListView As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ChrInfo_Discipline As ComboBox
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents ChrInfo_Label6 As Label
    Friend WithEvents ChrInfo_ComboBox_Class As ComboBox
    Friend WithEvents ChrInfo_AdvClass As ComboBox
    Friend WithEvents ChrInfo_Label2 As Label
    Friend WithEvents ChrInfo_Label1 As Label
    Friend WithEvents ChrInfo_CrewLvl3 As NumericUpDown
    Friend WithEvents ChrInfo_CrewLvl2 As NumericUpDown
    Friend WithEvents ChrInfo_CrewLvl1 As NumericUpDown
    Friend WithEvents ChrInfo_Label8 As Label
    Friend WithEvents ChrInfo_Label9 As Label
    Friend WithEvents ChrInfo_Label7 As Label
    Friend WithEvents ChrInfo_Label4 As Label
    Friend WithEvents ChrInfo_Label5 As Label
    Friend WithEvents ChrInfo_Label3 As Label
    Friend WithEvents ChrInfo_Crew3 As ComboBox
    Friend WithEvents ChrInfo_Crew2 As ComboBox
    Friend WithEvents Currency_Set As Button
    Friend WithEvents Currency_Rem As Button
    Friend WithEvents Currency_Add As Button
    Friend WithEvents Currency_TextBox As TextBox
    Friend WithEvents Currency_ListView As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Companions_TNL As Label
    Friend WithEvents Companions_Label1 As Label
    Friend WithEvents Companions_GP As GroupBox
    Friend WithEvents Companions_GP_Label As Label
    Friend WithEvents Companions_Rem As Button
    Friend WithEvents Companions_CheckBox As CheckBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Companions_Add As Button
    Friend WithEvents Companions_Crit15 As Label
    Friend WithEvents Companions_Crt10 As Label
    Friend WithEvents Companions_Label4 As Label
    Friend WithEvents Companions_Label3 As Label

End Class
