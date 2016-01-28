Public Class UI_ItemPallet

    Sub New()
        Icons.ImageSize = New Size(54, 54)

        _win = New Form
        _tabber = New TabControl
        _ArcheologyTab = New TabPage
        _ArcheologyListView = New ListView
        _BioanalysisTab = New TabPage
        _BioanalysisListView = New ListView
        _ScavengingTab = New TabPage
        _ScavengingListView = New ListView
        _SlicingTab = New TabPage
        _SlicingListView = New ListView

        _tabber.SuspendLayout()
        _ArcheologyTab.SuspendLayout()
        _win.SuspendLayout()

        '_ArcheologyListView
        _ArcheologyListView.Location = New System.Drawing.Point(0, 0)
        _ArcheologyListView.Size = New System.Drawing.Size(560, 317)
        _ArcheologyListView.Dock = DockStyle.Fill
        _ArcheologyListView.LargeImageList = Icons
        _ArcheologyListView.MultiSelect = False

        '_BioanalysisListView
        _BioanalysisListView.Location = New System.Drawing.Point(0, 0)
        _BioanalysisListView.Size = New System.Drawing.Size(560, 317)
        _BioanalysisListView.Dock = DockStyle.Fill
        _BioanalysisListView.LargeImageList = Icons
        _BioanalysisListView.MultiSelect = False

        '_BioanalysisListView
        _ScavengingListView.Location = New System.Drawing.Point(0, 0)
        _ScavengingListView.Size = New System.Drawing.Size(560, 317)
        _ScavengingListView.Dock = DockStyle.Fill
        _ScavengingListView.LargeImageList = Icons
        _ScavengingListView.MultiSelect = False

        '_BioanalysisListView
        _SlicingListView.Location = New System.Drawing.Point(0, 0)
        _SlicingListView.Size = New System.Drawing.Size(560, 317)
        _SlicingListView.Dock = DockStyle.Fill
        _SlicingListView.LargeImageList = Icons
        _SlicingListView.MultiSelect = False
        For Each item In Items

            Select Case item.Crewskill
                Case "Archeology"
                    Dim litem As ListViewItem = New ListViewItem
                    litem.Text = item.Name
                    litem.ImageIndex = Icons.Images.Keys.IndexOf(item.Name)
                    _ArcheologyListView.Items.Add(litem)
                Case "Bioanalysis"
                    Dim litem As ListViewItem = New ListViewItem
                    litem.Text = item.Name
                    litem.ImageIndex = Icons.Images.Keys.IndexOf(item.Name)
                    _BioanalysisListView.Items.Add(litem)
                Case "Scavenging"
                    Dim litem As ListViewItem = New ListViewItem
                    litem.Text = item.Name
                    litem.ImageIndex = Icons.Images.Keys.IndexOf(item.Name)
                    _ScavengingListView.Items.Add(litem)
                Case "Slicing"
                    Dim litem As ListViewItem = New ListViewItem
                    litem.Text = item.Name
                    litem.ImageIndex = Icons.Images.Keys.IndexOf(item.Name)
                    _SlicingListView.Items.Add(litem)
            End Select
        Next

        '_ArcheologyListViewItems



        '_ArcheologyTab
        _ArcheologyTab.Text = "Archeology"
        _ArcheologyTab.Controls.Add(_ArcheologyListView)
        '_BioanalysisTab
        _BioanalysisTab.Text = "Bioanalysis"
        _BioanalysisTab.Controls.Add(_BioanalysisListView)
        '_ScavengingTab
        _ScavengingTab.Text = "Scavenging"
        _ScavengingTab.Controls.Add(_ScavengingListView)
        '_SlicingTab
        _SlicingTab.Text = "Slicing"
        _SlicingTab.Controls.Add(_SlicingListView)



        '_tabber
        _tabber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        _tabber.Controls.Add(_ArcheologyTab)
        _tabber.Controls.Add(_BioanalysisTab)
        _tabber.Controls.Add(_ScavengingTab)
        _tabber.Controls.Add(_SlicingTab)

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

    Private Sub ArcheologyListView_SelectedIndexChanged(sender As ListView, e As EventArgs) Handles _ArcheologyListView.SelectedIndexChanged, _BioanalysisListView.SelectedIndexChanged, _ScavengingListView.SelectedIndexChanged, _SlicingListView.SelectedIndexChanged
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
    Friend WithEvents _BioanalysisTab As TabPage
    Friend WithEvents _BioanalysisListView As ListView
    Friend WithEvents _ScavengingTab As TabPage
    Friend WithEvents _ScavengingListView As ListView
    Friend WithEvents _SlicingTab As TabPage
    Friend WithEvents _SlicingListView As ListView
End Class
