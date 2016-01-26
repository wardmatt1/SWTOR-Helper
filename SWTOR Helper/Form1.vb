﻿Imports System.IO

Public Class Main_Window
    Private Sub Main_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadxml("CrewSkills")

        loadxml("Items")
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
        Dim legnod As TreeNode = findrootnode(UI_Main.treeview.SelectedNode)
        If legnod.Text = "Crafting Items" Then
            MsgBox("You must select a Legacy")
        Else
            Dim l As Legacy = GetDictItem(legnod.Text, LoadedLegacy)
        End If
    End Sub






    Private Sub ItemDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemDatabaseToolStripMenuItem.Click
        UI_ItemDatabase.Show()
    End Sub
End Class