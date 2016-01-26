Public Class UI_Mainwindow
    Inherits UI
    Friend WithEvents _treeview As TreeView


    Sub New(win As Form)
        UI_Window = win
        _treeview = New TreeView
        _treeview.Parent = UI_Window
        _treeview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        _treeview.Location = New System.Drawing.Point(6, 27)
        _treeview.Name = "MainWindow_TreeView"
        _treeview.Size = New System.Drawing.Size(182, 522)
        _treeview.TabIndex = 2


    End Sub
    Private Sub TreeView_AfterSelect(sender As Object, e As EventArgs) Handles _treeview.AfterSelect
        UpdateFromTreeview()

    End Sub

    Property treeview As TreeView
        Get
            Return _treeview
        End Get
        Set(value As TreeView)
        End Set
    End Property

    Public Sub UpdateFromTreeview()
        Dim n As KeyValuePair(Of String, Panel)
        For Each n In MainPanels
            If _treeview.SelectedNode.Name = n.Key Then
                n.Value.Visible = True
                UI_Window.Text = "Star Wars the Old Republic Helper - " + _treeview.SelectedNode.Text

            Else
                n.Value.Visible = False
            End If
        Next
    End Sub
End Class
