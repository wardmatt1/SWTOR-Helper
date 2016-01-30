Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Public Class UI_ChrInventory
    Inherits UI
    Implements INotifyPropertyChanged
    Private _palletitem As My_item
    Private _slotsused As Integer
    Private _maxslots As Integer
    Private _chr As Character

    Sub New(ui As UI, c As Character)
        _chr = c
        UI_ChrInventorys.Add(Me)
        _slotsused = 0
        _maxslots = 40
        UI_Name = AddTreeNode(UI_Main.treeview, "Inventory", ui.UI_TreeViewNode.Name)


        UI_TreeViewNode = GetDictItem(UI_Name, TreeViewNodes)
        UI_Panel = NewPanel(UI_Name)
        _titlelabel = New Label
        _InvListView = New ListView
        _ItemControlGroupBox = New GroupBox
        _ItemControlLabel = New Label
        _ItemControlPictureBox = New PictureBox
        _ItemControlNumericUPDown = New NumericUpDown
        _ItemControlRemButton = New Button
        _ItemControlAddButton = New Button
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        _AddSlotsButton = New Button
        _RemSlotsButton = New Button
        _SlotsReaminingLable = New Label
        _SlotsMaxLable = New Label
        UI_Panel.SuspendLayout()

        '_titlelabel 
        _titlelabel.Text = c.SWTOR_Name + " Inventory"

        _titlelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        _titlelabel.Location = New System.Drawing.Point(6, 6)
        _titlelabel.TextAlign = ContentAlignment.MiddleCenter
        _titlelabel.Font = New Font(_titlelabel.Font.FontFamily, 20)
        _titlelabel.Size = New System.Drawing.Size(539, 40)
        _titlelabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top _
           Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),
            System.Windows.Forms.AnchorStyles)

        '_InvListView 
        _InvListView.Location = New Point(6, 48)
        _InvListView.Size = New Size(539, 366)
        _InvListView.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        _InvListView.SmallImageList = Icons
        _InvListView.GridLines = True
        _InvListView.View = View.Details
        _InvListView.FullRowSelect = True
        _InvListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})

        '_SlotsReaminingLable 
        _SlotsReaminingLable.Text = "Remaining Slots: " & (_maxslots - _slotsused)
        _SlotsReaminingLable.Location = New Point(6, 467)
        _SlotsReaminingLable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _SlotsReaminingLable.BorderStyle = BorderStyle.Fixed3D
        _SlotsReaminingLable.AutoSize = True

        '
        _SlotsMaxLable.Text = "Max Slots: " & _maxslots
        _SlotsMaxLable.Location = New Point(6, 490)
        _SlotsMaxLable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _SlotsMaxLable.BorderStyle = BorderStyle.Fixed3D
        _SlotsMaxLable.AutoSize = True

        '__AddTabButton
        _AddSlotsButton.Location = New System.Drawing.Point(6, 431)
        _AddSlotsButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _AddSlotsButton.Text = "Add Slots"

        '_RemTabButton
        _RemSlotsButton.Location = New System.Drawing.Point(82, 431)
        _RemSlotsButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _RemSlotsButton.Text = "Remove"

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

        UI_Panel.Controls.Add(_SlotsReaminingLable)
        UI_Panel.Controls.Add(_SlotsMaxLable)
        UI_Panel.Controls.Add(_ItemControlGroupBox)
        UI_Panel.Controls.Add(_AddSlotsButton)
        UI_Panel.Controls.Add(_RemSlotsButton)
        UI_Panel.Controls.Add(_titlelabel)
        UI_Panel.Controls.Add(_InvListView)
        MainW.Controls.Add(UI_Panel)
        UI_Panel.ResumeLayout(False)
        UI_Panel.PerformLayout()



    End Sub


    Friend WithEvents _SlotsMaxLable As Label
    Friend WithEvents _SlotsReaminingLable As Label
    Friend WithEvents _AddSlotsButton As Button
    Friend WithEvents _RemSlotsButton As Button
    Friend WithEvents _titlelabel As Label
    Friend WithEvents _InvListView As ListView
    Friend WithEvents _ItemControlLabel As Label
    Friend WithEvents _ItemControlPictureBox As PictureBox
    Friend WithEvents _ItemControlNumericUPDown As NumericUpDown
    Friend WithEvents _ItemControlRemButton As Button
    Friend WithEvents _ItemControlAddButton As Button
    Friend WithEvents _ItemControlGroupBox As GroupBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged


    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
    Private Sub PalletItemChanged() Handles Me.PropertyChanged
        Dim item As My_item = _palletitem
        _ItemControlPictureBox.Image = item.Icon
        _ItemControlLabel.Text = item.Name
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
    Private Sub AddSlotsButton_Clicked(sender As Object, e As EventArgs) Handles _AddSlotsButton.Click

        Select Case _maxslots
            Case 40
                _maxslots = 50
            Case 50
                _maxslots = 60
            Case 60
                _maxslots = 70
            Case 70
                _maxslots = 80
        End Select
        _SlotsMaxLable.Text = "Max Slots: " & _maxslots
        _SlotsReaminingLable.Text = "Remaining Slots: " & (_maxslots - _slotsused)

    End Sub
    Private Sub RemSlotsButton_Clicked(sender As Object, e As EventArgs) Handles _RemSlotsButton.Click

        Select Case _maxslots
            Case 50
                If _slotsused <= 40 Then
                    _maxslots = 40
                End If
            Case 60
                If _slotsused <= 50 Then
                    _maxslots = 50
                End If
            Case 70
                If _slotsused <= 60 Then
                    _maxslots = 60
                End If
            Case 80
                If _slotsused <= 70 Then
                    _maxslots = 70
                End If
        End Select

        _SlotsMaxLable.Text = "Max Slots: " & _maxslots
        _SlotsReaminingLable.Text = "Remaining Slots: " & (_maxslots - _slotsused)

    End Sub
    Private Sub ItemControlAddButton_Clicked() Handles _ItemControlAddButton.Click
        If Not _palletitem Is Nothing Then
            If Not _slotsused = _maxslots Then
                Dim count As Byte = _ItemControlNumericUPDown.Value
                Dim inventory As Inventory = _chr.Inventory
                inventory.addItem(_palletitem, count)
                _slotsused += 1
                additemtolistview(_palletitem, _InvListView, count)
                _SlotsReaminingLable.Text = "Remaining Slots: " & (_maxslots - _slotsused)
                For Each col As ColumnHeader In _InvListView.Columns
                    Dim index = _InvListView.Columns.IndexOf(col)
                    _InvListView.AutoResizeColumn(index, ColumnHeaderAutoResizeStyle.HeaderSize)
                Next
            Else
                MsgBox("Out of room.")
            End If
        Else
            Item_Pallet = New UI_ItemPallet
            Item_Pallet.window.Show()
        End If
    End Sub
    Private Sub ItemControlRemButton_Clicked() Handles _ItemControlRemButton.Click
        If _InvListView.SelectedItems.Count > 0 Then
            Dim selitem As Integer = _InvListView.SelectedIndices(0)
            Dim inventory As Inventory = _chr.Inventory
            inventory.remItem(selitem)
            _slotsused = _slotsused - 1
            Dim litem As ListViewItem = _InvListView.SelectedItems.Item(0)
            litem.Remove()
            litem = Nothing
            _SlotsReaminingLable.Text = "Remaining Slots: " & (_maxslots - _slotsused)

        End If
    End Sub
    Private Sub additemtolistview(item As My_item, list As ListView, count As Byte)
        Dim litem As ListViewItem = New ListViewItem
        litem.ImageIndex = Icons.Images.Keys.IndexOf(item.Name)
        litem.SubItems.Add(item.Name)
        litem.SubItems.Add(count)
        list.Items.Add(litem)
    End Sub
End Class
