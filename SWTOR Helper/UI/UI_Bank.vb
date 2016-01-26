Public Class UI_Bank
    Inherits UI
    Private _tabcount As Byte

    Sub New(ui As UI, _type As Boolean)
        _tabcount = 1

        If _type = True Then
            UI_Name = AddTreeNode(UI_Main.treeview, "Cargo Hold", ui.UI_TreeViewNode.Name)
        Else
            UI_Name = AddTreeNode(UI_Main.treeview, "Legacy Cargo Hold", ui.UI_TreeViewNode.Name)

        End If

        UI_TreeViewNode = GetDictItem(UI_Name, TreeViewNodes)
        UI_Panel = NewPanel(UI_Name)
        _titlelabel = New Label
        _tabber = New TabControl
        _tab1 = New TabPage
        _tab2 = New TabPage
        _tab3 = New TabPage
        _tab4 = New TabPage
        _tab5 = New TabPage
        _AddTabButton = New Button
        _RemTabButton = New Button
        UI_Panel.SuspendLayout()

        '_tab1
        _tab1.Text = "Bay 1"

        '_tab2
        _tab2.Text = "Bay 2"

        '_tab3
        _tab3.Text = "Bay 3"

        '_tab4
        _tab4.Text = "Bay 4"

        '_tab5
        _tab5.Text = "Bay 5"

        '_tabber

        _tabber.Location = New System.Drawing.Point(6, 49)
        _tabber.Size = New System.Drawing.Size(539, 400)
        _tabber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
           Or System.Windows.Forms.AnchorStyles.Left) _
           Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        _tabber.Alignment = TabAlignment.Bottom
        _tabber.TabPages.Add(_tab1)

        '__AddTabButton
        _AddTabButton.Location = New System.Drawing.Point(6, 456)
        _AddTabButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _AddTabButton.Text = "Add Tab"

        '_RemTabButton
        _RemTabButton.Location = New System.Drawing.Point(82, 456)
        _RemTabButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _RemTabButton.Text = "Remove "


        '_titlelabel 
        If _type = True Then
            _titlelabel.Text = "Cargo Hold"
        Else
            _titlelabel.Text = "Legacy Cargo Hold"

        End If
        _titlelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        _titlelabel.Location = New System.Drawing.Point(6, 6)
        _titlelabel.TextAlign = ContentAlignment.MiddleCenter
        _titlelabel.Font = New Font(_titlelabel.Font.FontFamily, 20)
        _titlelabel.Size = New System.Drawing.Size(539, 40)
        _titlelabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top _
           Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),
            System.Windows.Forms.AnchorStyles)

        UI_Panel.Controls.Add(_AddTabButton)
        UI_Panel.Controls.Add(_RemTabButton)
        UI_Panel.Controls.Add(_tabber)
        UI_Panel.Controls.Add(_titlelabel)
        MainW.Controls.Add(UI_Panel)
        UI_Panel.ResumeLayout(False)
        UI_Panel.PerformLayout()
    End Sub





    Friend WithEvents _titlelabel As Label
    Friend WithEvents _tabber As TabControl
    Friend WithEvents _tab1 As TabPage
    Friend WithEvents _tab2 As TabPage
    Friend WithEvents _tab3 As TabPage
    Friend WithEvents _tab4 As TabPage
    Friend WithEvents _tab5 As TabPage
    Friend WithEvents _AddTabButton As Button
    Friend WithEvents _RemTabButton As Button


    Public Property UI_Bank_TabCount As Byte
        Get
            Return _tabcount
        End Get
        Set(value As Byte)
            _tabcount = value
        End Set
    End Property


    Private Sub AddTabButton_Clicked(sender As Object, e As EventArgs) Handles _AddTabButton.Click
        Select Case UI_Bank_TabCount
            Case 1
                UI_Bank_TabCount = 2
                _tabber.TabPages.Add(_tab2)
            Case 2
                UI_Bank_TabCount = 3
                _tabber.TabPages.Add(_tab3)
            Case 3
                UI_Bank_TabCount = 4
                _tabber.TabPages.Add(_tab4)
            Case 4
                UI_Bank_TabCount = 5
                _tabber.TabPages.Add(_tab5)
            Case Else
                MsgBox("Can't add more tabs")
        End Select
    End Sub
    Private Sub RemTabButton_Clicked(sender As Object, e As EventArgs) Handles _RemTabButton.Click
        Select Case UI_Bank_TabCount
            Case 5
                UI_Bank_TabCount = 4
                _tabber.TabPages.Remove(_tab5)
            Case 4
                UI_Bank_TabCount = 3
                _tabber.TabPages.Remove(_tab4)
            Case 3
                UI_Bank_TabCount = 2
                _tabber.TabPages.Remove(_tab3)
            Case 2
                UI_Bank_TabCount = 1
                _tabber.TabPages.Remove(_tab2)
            Case Else
                MsgBox("Can't Remove more tabs")
        End Select
    End Sub
End Class
