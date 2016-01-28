Public Class UI_ItemPallet
    Private _ArcheologyItems As List(Of My_item) = New List(Of My_item)
    Sub New()
        Icons.ImageSize = New Size(54, 54)
        For Each item In Items

            Select Case item.Crewskill
                Case "Archeology"
                    _ArcheologyItems.Add(item)
            End Select
        Next

        _win = New Form
        _tabber = New TabControl
        _ArcheologyTab = New TabPage
        _ArcheologyListView = New ListView

        _tabber.SuspendLayout()
        _ArcheologyTab.SuspendLayout()
        _win.SuspendLayout()

        '_ArcheologyListView
        _ArcheologyListView.Location = New System.Drawing.Point(0, 0)
        _ArcheologyListView.Size = New System.Drawing.Size(560, 317)
        _ArcheologyListView.Dock = DockStyle.Fill
        _ArcheologyListView.LargeImageList = Icons
        _ArcheologyListView.MultiSelect = False
        '_ArcheologyListViewItems
        For Each item In _ArcheologyItems
            Dim litem As ListViewItem = New ListViewItem
            litem.Text = item.Name
            litem.ImageIndex = Icons.Images.Keys.IndexOf(item.Name)
            _ArcheologyListView.Items.Add(litem)

        Next

        '_ArcheologyTab
        _ArcheologyTab.Text = "Archeology"
        _ArcheologyTab.Controls.Add(_ArcheologyListView)
        '_tabber
        _tabber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        _tabber.Controls.Add(_ArcheologyTab)
        _tabber.Location = New System.Drawing.Point(6, 6)
        _tabber.Name = "Pallet"
        _tabber.SelectedIndex = 0
        _tabber.Size = New System.Drawing.Size(574, 353)
        _tabber.TabIndex = 0



        '_win
        _win.Controls.Add(_tabber)

        _win.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        _win.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        _win.ClientSize = New System.Drawing.Size(584, 361)
        _win.MinimumSize = New System.Drawing.Size(600, 400)
        _win.Name = "Item Pallet"
        _win.Text = "Item Pallet"



        _ArcheologyTab.ResumeLayout(False)
        _tabber.ResumeLayout(False)
        _win.ResumeLayout(False)
        _win.PerformLayout()
    End Sub
    Public ReadOnly Property window As Form
        Get
            Return _win
        End Get

    End Property


    Private Sub window_close(sender As Object, e As EventArgs) Handles _win.Closed
        Me.Finalize()

    End Sub

    Private Sub ArcheologyListView_SelectedIndexChanged(sender As ListView, e As EventArgs) Handles _ArcheologyListView.SelectedIndexChanged
        If sender.SelectedItems.Count > 0 Then
            For Each bankui As UI_Bank In UI_Banks
                bankui.PalletItem = getItembyName(sender.SelectedItems.Item(0).Text)
            Next
            For Each chrinv As UI_ChrInventory In UI_ChrInventorys
                chrinv.PalletItem = getItembyName(sender.SelectedItems.Item(0).Text)
            Next

        End If
    End Sub



    'Form elements
    Friend WithEvents _win As Form
    Friend WithEvents _tabber As TabControl
    Friend WithEvents _ArcheologyTab As TabPage
    Friend WithEvents _ArcheologyListView As ListView

End Class
