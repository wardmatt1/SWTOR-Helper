Imports System.Xml
Imports System.IO




Public Module My_functions
    Public Enablelogging = False
    Public UI_Main As UI_Mainwindow
    Public Items As List(Of My_item) = New List(Of My_item)
    Public UI_Banks As List(Of UI_Bank) = New List(Of UI_Bank)
    Public UI_ChrInventorys As List(Of UI_ChrInventory) = New List(Of UI_ChrInventory)
    Public MainW As Form = Main_Window
    Public Item_Pallet As UI_ItemPallet
    Public Icons As ImageList = New ImageList
    Friend WithEvents Events As New My_Events

    'Dictionaries
    Public LoadedLegacy As New Dictionary(Of String, Legacy)
    Public MainPanels As New Dictionary(Of String, Panel)
    Public TreeViewNodes As New Dictionary(Of String, TreeNode)
    Public CrewSkills As New Dictionary(Of String, My_CrewSkill)



    Public Function NewPanel(Name As String) As Panel
        Dim panel As New Panel
        panel.Parent = Main_Window

        panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
    Or System.Windows.Forms.AnchorStyles.Left) _
    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        panel.Location = New System.Drawing.Point(218, 27)
        panel.Name = Name
        panel.Size = New System.Drawing.Size(554, 522)
        panel.TabIndex = 3
        MainPanels.Add(Name, panel)
        Return panel
    End Function
    Public Function AddTreeNode(treeview As TreeView, name As String, Optional parentname As String = Nothing) As String
        Dim node As TreeNode = Nothing
        Dim parent As TreeNode = Nothing

        If parentname Is Nothing Then
            node = treeview.Nodes.Add(name)
            TreeViewNodes.Add(name, node)
            node.Name = name
            node.Text = name
        Else
            Dim n As KeyValuePair(Of String, TreeNode)

            For Each n In TreeViewNodes
                If n.Key = parentname Then
                    parent = n.Value
                    node = parent.Nodes.Add(name)
                    node.Name = parent.Name + "_" + name
                    node.Text = name
                    TreeViewNodes.Add(node.Name, node)
                    Exit For
                End If
            Next

        End If
        Return node.Name
    End Function
    Public Function getItembyName(Name As String) As My_item
        For Each item In Items
            If item.Name = Name Then
                Return item
            End If
        Next
        Return Nothing
    End Function


    Public Function GetDictItem(s As String, d As Dictionary(Of String, TreeNode)) As TreeNode
        Dim n As KeyValuePair(Of String, TreeNode)

        For Each n In TreeViewNodes
            If n.Key = s Then
                Return n.Value
            End If
        Next
        Return Nothing
    End Function

    Public Function GetDictItem(s As String, d As Dictionary(Of String, Legacy)) As Legacy

        Dim n As KeyValuePair(Of String, Legacy)

        For Each n In LoadedLegacy
            If n.Key = s Then
                Return n.Value
            End If
        Next
        Return Nothing
    End Function
    Public Function GetDictItem(s As String, d As Dictionary(Of String, Panel)) As Panel

        Dim n As KeyValuePair(Of String, Panel)

        For Each n In MainPanels
            If n.Key = s Then
                Return n.Value
            End If
        Next
        Return Nothing
    End Function

    Public Function UppercaseFirstLetter(ByVal val As String) As String
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        Dim array() As Char = val.ToCharArray

        array(0) = Char.ToUpper(array(0))

        Return New String(array)
    End Function



    Public Function findrootnode(t As TreeNode) As TreeNode
        While Not t.Parent Is Nothing
            t = t.Parent
        End While
        Return t
    End Function




End Module
