
Public Class UI

    Private _window As Form
    Private _Name As String
    Friend WithEvents _Panel As System.Windows.Forms.Panel
    Private _TreeViewNode As System.Windows.Forms.TreeNode



    Public Property UI_TreeViewNode As TreeNode
        Get
            Return _TreeViewNode
        End Get
        Set(value As TreeNode)
            _TreeViewNode = value
        End Set
    End Property

    Public Property UI_Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property UI_Window As Form
        Get
            Return _window
        End Get
        Set(value As Form)
            _window = value
        End Set
    End Property
    Public Property UI_Panel As Panel
        Get
            Return _Panel
        End Get
        Set(value As Panel)
            _Panel = value
        End Set
    End Property
End Class
