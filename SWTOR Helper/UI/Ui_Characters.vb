﻿Public Class UI_Characters
    Inherits UI

    Sub New(ui As UI)
        UI_Name = AddTreeNode(UI_Main.treeview, "Characters", ui.UI_TreeViewNode.Name)
        UI_TreeViewNode = GetDictItem(UI_Name, TreeViewNodes)
        UI_Panel = NewPanel(UI_Name)
        _titlelabel = New Label
        UI_Panel.SuspendLayout()



        '_titlelabel 
        _titlelabel.Text = "Characters"
        _titlelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        _titlelabel.Location = New System.Drawing.Point(6, 6)
        _titlelabel.TextAlign = ContentAlignment.MiddleCenter
        _titlelabel.Font = New Font(_titlelabel.Font.FontFamily, 20)
        _titlelabel.Size = New System.Drawing.Size(539, 40)
        _titlelabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top _
           Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),
            System.Windows.Forms.AnchorStyles)

        UI_Panel.Controls.Add(_titlelabel)
        MainW.Controls.Add(UI_Panel)
        UI_Panel.ResumeLayout(False)
        UI_Panel.PerformLayout()
    End Sub


    Friend WithEvents _titlelabel As Label


End Class
