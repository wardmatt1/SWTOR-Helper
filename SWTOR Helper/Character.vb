Public Class Character
    Inherits SWTOR_Record
    Private _UI_Character As UI_Character
    Private _UI_Inventory As Chr_Inventory
    Private _Inventory As Inventory
    Private _ChrClass, _ChrAdvClass, _ChrDiscipline As String

    Sub New(Name As String, l As Legacy)
        SWTOR_Type = True
        SWTOR_Name = UppercaseFirstLetter(Name)
        l.Leg_AddChr(SWTOR_Name, Me)
        _Inventory = New Inventory(Me, False)
        _UI_Character = New UI_Character(Me, l.UI_CharactersNode)
        _UI_Inventory = New Chr_Inventory(Me, _UI_Character)
        SWTOR_Bank = New Bank(Me, _UI_Character)
        Inventorys.Add(_Inventory)
        Inventorys.Add(SWTOR_Bank.banktab(0))
        Inventorys.Add(SWTOR_Bank.banktab(1))
        Inventorys.Add(SWTOR_Bank.banktab(2))
        Inventorys.Add(SWTOR_Bank.banktab(3))
        Inventorys.Add(SWTOR_Bank.banktab(4))
    End Sub
    Public ReadOnly Property Inventory
        Get
            Return _Inventory
        End Get
    End Property
    Public Property ChrClass As String
        Get
            Return _ChrClass
        End Get
        Set(value As String)
            _ChrClass = value
        End Set
    End Property
    Public Property ChrAdvClass As String
        Get
            Return _ChrAdvClass
        End Get
        Set(value As String)
            _ChrAdvClass = value
        End Set
    End Property
    Public Property ChrDiscipline As String
        Get
            Return _ChrDiscipline
        End Get
        Set(value As String)
            _ChrDiscipline = value
        End Set
    End Property
End Class
