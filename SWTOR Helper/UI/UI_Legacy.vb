Public Class UI_Legacy
    Inherits UI
    Private _UI_Characters As UI_Characters
    Sub New(l As Legacy)

        UI_Name = AddTreeNode(UI_Main.treeview, l.SWTOR_Name)
        UI_Panel = NewPanel(UI_Name)
        _titlelabel = New Label
        UI_TreeViewNode = GetDictItem(l.SWTOR_Name, TreeViewNodes)

        '_titlelabel
        _titlelabel.Text = "The " + l.SWTOR_Name + " Legacy"
        _titlelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        _titlelabel.Location = New System.Drawing.Point(6, 6)
        _titlelabel.TextAlign = ContentAlignment.MiddleCenter
        _titlelabel.Font = New Font(_titlelabel.Font.FontFamily, 20)
        _titlelabel.Size = New System.Drawing.Size(539, 40)
        __titlelabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top _
           Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),
            System.Windows.Forms.AnchorStyles)

        'UI_Panel
        UI_Panel.Controls.Add(__titlelabel)



        MainW.Controls.Add(UI_Panel)

    End Sub
    Friend WithEvents _titlelabel As Label



End Class
