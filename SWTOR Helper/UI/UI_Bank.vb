
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Public Class UI_Bank

    Inherits UI
    Implements INotifyPropertyChanged

    Private _tabcount As Byte
    Private _bank As Bank
    Private _palletitem As My_item
    Private _slotsLeft(4) As Integer


    Sub New(ui As UI, _type As Boolean, bank As Bank)
        _slotsLeft(0) = 80
        _slotsLeft(1) = 80
        _slotsLeft(2) = 80
        _slotsLeft(3) = 80
        _slotsLeft(4) = 80
        UI_Banks.Add(Me)
        _tabcount = 1
        _bank = bank
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
        _ItemControlGroupBox = New GroupBox
        _ItemControlLabel = New Label
        _ItemControlPictureBox = New PictureBox
        _ItemControlNumericUPDown = New NumericUpDown
        _ItemControlRemButton = New Button
        _ItemControlAddButton = New Button
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        _SlotsReaminingLable = New Label
        UI_Panel.SuspendLayout()

        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "Icon"

        '
        'ColumnHeader2
        '
        ColumnHeader2.Text = "Name"
        '
        'ColumnHeader3
        '
        ColumnHeader3.Text = "Count"

        '_list1
        _list1 = New ListView
        _list1.Location = New System.Drawing.Point(3, 3)
        _list1.Size = New System.Drawing.Size(524, 366)
        _list1.Dock = DockStyle.Fill
        _list1.SmallImageList = Icons
        _list1.GridLines = True
        _list1.View = View.Details
        _list1.FullRowSelect = True
        _list1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        '_list2
        _list2 = New ListView
        _list2.Location = New System.Drawing.Point(3, 3)
        _list2.Size = New System.Drawing.Size(524, 366)
        _list2.Dock = DockStyle.Fill
        _list2.AllowDrop = True
        _list2.SmallImageList = Icons
        _list2.GridLines = True
        _list2.View = View.Details
        _list2.FullRowSelect = True
        _list2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1.Clone, Me.ColumnHeader2.Clone, Me.ColumnHeader3.Clone})

        '_list3
        _list3 = New ListView
        _list3.Location = New System.Drawing.Point(3, 3)
        _list3.Size = New System.Drawing.Size(524, 366)
        _list3.Dock = DockStyle.Fill
        _list3.AllowDrop = True
        _list3.SmallImageList = Icons
        _list3.GridLines = True
        _list3.View = View.Details
        _list3.FullRowSelect = True
        _list3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1.Clone, Me.ColumnHeader2.Clone, Me.ColumnHeader3.Clone})

        '_list4
        _list4 = New ListView
        _list4.Location = New System.Drawing.Point(3, 3)
        _list4.Size = New System.Drawing.Size(524, 366)
        _list4.Dock = DockStyle.Fill
        _list4.AllowDrop = True
        _list4.SmallImageList = Icons
        _list4.GridLines = True
        _list4.View = View.Details
        _list4.FullRowSelect = True
        _list4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1.Clone, Me.ColumnHeader2.Clone, Me.ColumnHeader3.Clone})

        '_list5
        _list5 = New ListView
        _list5.Location = New System.Drawing.Point(3, 3)
        _list5.Size = New System.Drawing.Size(524, 366)
        _list5.Dock = DockStyle.Fill
        _list5.AllowDrop = True
        _list5.SmallImageList = Icons
        _list5.GridLines = True
        _list5.View = View.Details
        _list5.FullRowSelect = True
        _list5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1.Clone, Me.ColumnHeader2.Clone, Me.ColumnHeader3.Clone})


        '_tab1
        _tab1.Controls.Add(_list1)
        _tab1.Text = "Bay 1"
        '_tab2
        _tab2.Text = "Bay 2"
        _tab2.Controls.Add(_list2)

        '_tab3
        _tab3.Text = "Bay 3"
        _tab3.Controls.Add(_list3)

        '_tab4
        _tab4.Text = "Bay 4"
        _tab4.Controls.Add(_list4)

        '_tab5
        _tab5.Text = "Bay 5"
        _tab5.Controls.Add(_list5)

        '_tabber

        _tabber.Location = New System.Drawing.Point(6, 49)
        _tabber.Size = New System.Drawing.Size(539, 400)
        _tabber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
           Or System.Windows.Forms.AnchorStyles.Left) _
           Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        _tabber.Alignment = TabAlignment.Bottom
        _tabber.TabPages.Add(_tab1)

        '_SlotsReaminingLable 
        _SlotsReaminingLable.Text = "Remaining Slots: " & CStr(_slotsLeft(0))
        _SlotsReaminingLable.Location = New Point(6, 492)
        _SlotsReaminingLable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _SlotsReaminingLable.BorderStyle = BorderStyle.Fixed3D
        _SlotsReaminingLable.AutoSize = True

        '__AddTabButton
        _AddTabButton.Location = New System.Drawing.Point(6, 456)
        _AddTabButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _AddTabButton.Text = "Add Tab"

        '_RemTabButton
        _RemTabButton.Location = New System.Drawing.Point(82, 456)
        _RemTabButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _RemTabButton.Text = "Remove Tab "

        '_ItemControlLabel
        _ItemControlLabel.Location = New System.Drawing.Point(162, 19)
        _ItemControlLabel.Size = New System.Drawing.Size(54, 54)
        _ItemControlLabel.AutoSize = True
        _ItemControlLabel.MaximumSize = New Size(145, 54)



        '_ItemControlPictureBox
        _ItemControlPictureBox.Location = New System.Drawing.Point(106, 19)
        _ItemControlPictureBox.Size = New System.Drawing.Size(56, 56)
        _ItemControlPictureBox.BorderStyle = BorderStyle.FixedSingle
        '_ItemControlNumericUPDown
        _ItemControlNumericUPDown.Location = New System.Drawing.Point(68, 36)
        _ItemControlNumericUPDown.Size = New System.Drawing.Size(35, 23)
        _ItemControlNumericUPDown.Maximum = 99
        _ItemControlNumericUPDown.Minimum = 1
        '_ItemControlRemButton
        _ItemControlRemButton.Location = New System.Drawing.Point(10, 50)
        _ItemControlRemButton.Text = "Remove"
        _ItemControlRemButton.Size = New System.Drawing.Size(55, 23)
        '_ItemControlAddButton
        _ItemControlAddButton.Location = New System.Drawing.Point(10, 20)
        _ItemControlAddButton.Text = "Add"
        _ItemControlAddButton.Size = New System.Drawing.Size(55, 23)

        '_AddItemGroupBox 
        _ItemControlGroupBox.Location = New System.Drawing.Point(229, 431)
        _ItemControlGroupBox.Text = "Item Control"
        _ItemControlGroupBox.Size = New System.Drawing.Size(311, 83)
        _ItemControlGroupBox.Anchor = AnchorStyles.Right Or AnchorStyles.Bottom
        _ItemControlGroupBox.Controls.Add(_ItemControlLabel)
        _ItemControlGroupBox.Controls.Add(_ItemControlPictureBox)
        _ItemControlGroupBox.Controls.Add(_ItemControlNumericUPDown)
        _ItemControlGroupBox.Controls.Add(_ItemControlRemButton)
        _ItemControlGroupBox.Controls.Add(_ItemControlAddButton)


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

        UI_Panel.Controls.Add(_SlotsReaminingLable)
        UI_Panel.Controls.Add(_ItemControlGroupBox)
        UI_Panel.Controls.Add(_AddTabButton)
        UI_Panel.Controls.Add(_RemTabButton)
        UI_Panel.Controls.Add(_tabber)
        UI_Panel.Controls.Add(_titlelabel)
        MainW.Controls.Add(UI_Panel)
        UI_Panel.ResumeLayout(False)
        UI_Panel.PerformLayout()
    End Sub

    Friend WithEvents _ItemControlLabel As Label
    Friend WithEvents _ItemControlPictureBox As PictureBox
    Friend WithEvents _ItemControlNumericUPDown As NumericUpDown
    Friend WithEvents _ItemControlRemButton As Button
    Friend WithEvents _ItemControlAddButton As Button
    Friend WithEvents _ItemControlGroupBox As GroupBox
    Friend WithEvents _titlelabel As Label
    Friend WithEvents _tabber As TabControl
    Friend WithEvents _tab1 As TabPage
    Friend WithEvents _tab2 As TabPage
    Friend WithEvents _tab3 As TabPage
    Friend WithEvents _tab4 As TabPage
    Friend WithEvents _tab5 As TabPage
    Friend WithEvents _AddTabButton As Button
    Friend WithEvents _RemTabButton As Button
    Friend WithEvents _SlotsReaminingLable As Label
    Friend WithEvents _list1 As ListView
    Friend WithEvents _list2 As ListView
    Friend WithEvents _list3 As ListView
    Friend WithEvents _list4 As ListView
    Friend WithEvents _list5 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged



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


    Public Property PalletItem As My_item
        Get
            Return _palletitem
        End Get
        Set(value As My_item)
            If Not (value Is _palletitem) Then
                _palletitem = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property
    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
    Private Sub PalletItemChanged() Handles Me.PropertyChanged
        Dim item As My_item = _palletitem
        _ItemControlPictureBox.Image = item.Icon
        _ItemControlLabel.Text = item.Name
    End Sub
    Private Sub ItemControlAddButton_Clicked() Handles _ItemControlAddButton.Click
        Dim tabindex = _tabber.TabPages.IndexOf(_tabber.SelectedTab)
        Dim list As ListView = _tabber.SelectedTab.Controls.Item(0)
        If Not _palletitem Is Nothing Then
            If Not _slotsLeft(tabindex) = 0 Then
                Dim count As Byte = _ItemControlNumericUPDown.Value
                Dim inventory As Inventory = _bank.banktab(tabindex)
                inventory.addItem(_palletitem, count)
                _slotsLeft(tabindex) = _slotsLeft(tabindex) - 1
                additemtolistview(_palletitem, list, count)
                _SlotsReaminingLable.Text = "Remaining Slots: " & _slotsLeft(tabindex)
                For Each col As ColumnHeader In list.Columns
                    Dim index = list.Columns.IndexOf(col)
                    list.AutoResizeColumn(index, ColumnHeaderAutoResizeStyle.HeaderSize)
                Next
            Else
                MsgBox("Out of room.")
            End If
        Else
            Item_Pallet.window.Show()
        End If
    End Sub
    Private Sub ItemControlRemButton_Clicked() Handles _ItemControlRemButton.Click

    End Sub
    Private Sub tabchange() Handles _tabber.SelectedIndexChanged
        Dim tabindex = _tabber.TabPages.IndexOf(_tabber.SelectedTab)
        _SlotsReaminingLable.Text = "Remaining Slots: " & _slotsLeft(tabindex)

    End Sub
    Private Sub additemtolistview(item As My_item, list As ListView, count As Byte)
        Dim litem As ListViewItem = New ListViewItem
        litem.ImageIndex = Icons.Images.Keys.IndexOf(item.Name)
        litem.SubItems.Add(item.Name)
        litem.SubItems.Add(count)
        list.Items.Add(litem)
    End Sub
End Class
