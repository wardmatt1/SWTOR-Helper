Public Class Legacy
    Inherits SWTOR_Record

    Private _server As String
    Private _AccountType As Integer
    Private _ChrDict As Dictionary(Of String, Character) = New Dictionary(Of String, Character)
    Private _UI_Characters As UI_Characters
    Private _UI_CharactersNode As TreeNode

    Sub New(name As String)
        SWTOR_Type = False
        SWTOR_Name = UppercaseFirstLetter(name)
        LoadedLegacy.Add(SWTOR_Name, Me)
        SWTOR_MainPanel = New UI_Legacy(Me)
        SWTOR_Bank = New Bank(Me, SWTOR_MainPanel)
        _UI_Characters = New UI_Characters(SWTOR_MainPanel)
        _UI_CharactersNode = _UI_Characters.UI_TreeViewNode
    End Sub
    Public Sub Leg_AddChr(name As String, c As Character)
        _ChrDict.Add(name, c)
    End Sub
    Public Property UI_CharactersNode As TreeNode
        Get
            Return _UI_CharactersNode
        End Get
        Set(value As TreeNode)
            _UI_CharactersNode = value
        End Set
    End Property
End Class

