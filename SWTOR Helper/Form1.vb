Imports System.IO

Public Class Main_Window
    Private Sub Main_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log("-------------------")
        Log("Starting up deh helper!")
        Log(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
        LoadData()
        Item_Pallet = New UI_ItemPallet

        UI_Main = New UI_Mainwindow(Me)
        Dim UI_Craft = New UI_Crafting_Mats(Me)
        Dim l As Legacy = New Legacy("test")
        Dim c As Character = New Character("asrock", l)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub LegacyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LegacyToolStripMenuItem.Click
        Dim newlegacy = New NewlegacyDIalogbox
        newlegacy.ShowDialog()
    End Sub

    Private Sub CharacterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterToolStripMenuItem.Click

        If UI_Main.treeview.SelectedNode Is Nothing Then
            UI_Main.treeview.SelectedNode = UI_Main.treeview.Nodes.Item(0)
        End If

        Dim legnod As TreeNode = findrootnode(UI_Main.treeview.SelectedNode)
        If legnod.Text = "Crafting Items" Then
            MsgBox("You must select a Legacy")
        Else

            Dim l As Legacy = GetDictItem(legnod.Text, LoadedLegacy)
            Dim name As String = InputBox("New Character")
            Dim chr As Character = New Character(name, l)
        End If
    End Sub






    Private Sub ItemDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemDatabaseToolStripMenuItem.Click
        UI_ItemDatabase.Show()
    End Sub

    Private Sub ItemPalletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemPalletToolStripMenuItem.Click
        Item_Pallet = New UI_ItemPallet

        Item_Pallet.window.Show()
    End Sub

    Private Sub LogFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogFileToolStripMenuItem.Click
        Dim FILE_NAME As String = Directory.GetCurrentDirectory() + "\Log\Log.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub
    Private Sub window_close(sender As Object, e As EventArgs) Handles Me.Closed
        Log("Helper Deactivated!")
        Log(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
        Log("-------------------")

    End Sub
End Class