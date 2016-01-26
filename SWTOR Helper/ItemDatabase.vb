Public Class UI_ItemDatabase
    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub ItemDatabase_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        updateItems()
    End Sub

    Private Sub UI_ItemDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = Color.Transparent

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        If ListView1.SelectedItems.Count > 0 Then
            Dim name = ListView1.SelectedItems.Item(0).SubItems(0).Text
            Dim itemtype = ListView1.SelectedItems.Item(0).SubItems(1).Text
            Dim img = ListView1.SelectedItems.Item(0).SubItems(7).Text
            For Each item As My_item In Items
                If name = item.Name Then
                    PictureBox1.Image = item.Icon
                    Exit For
                End If
            Next

        End If

    End Sub
    Private Sub updateItems()
        ListView1.Items.Clear()
        For Each item As My_item In Items
            If item.Type = "Crafting" Then
                Dim lvwItem As ListViewItem = New ListViewItem(item.Name.ToString)
                lvwItem.SubItems.Add(item.Lvl)
                lvwItem.SubItems.Add(item.Type)
                lvwItem.SubItems.Add(item.Subtype)
                lvwItem.SubItems.Add(item.Tier)
                lvwItem.SubItems.Add(item.Quality)
                lvwItem.SubItems.Add(item.Price)
                lvwItem.SubItems.Add(item.Crewskill)
                lvwItem.SubItems.Add(item.SkillLvl)
                lvwItem.SubItems.Add(item.Planet)
                lvwItem.SubItems.Add(item.IconName)
                ListView1.Items.Add(lvwItem)
            End If
        Next
        For Each col As ColumnHeader In ListView1.Columns
            Dim index = ListView1.Columns.IndexOf(col)
            ListView1.AutoResizeColumn(index, ColumnHeaderAutoResizeStyle.HeaderSize)
        Next
    End Sub

End Class