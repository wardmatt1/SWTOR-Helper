Public Class Character
    Inherits SWTOR_Record
    Private _UI_Character As UI_Character
    Private _UI_Inventory As Chr_Inventory
    Private _Inventory As Inventory
    Private _chrLvl As Integer
    Private _Bank_Inventory As Inventory


    Sub New(Name As String, l As Legacy)
        SWTOR_Type = True
        SWTOR_Name = UppercaseFirstLetter(Name)
        l.Leg_AddChr(SWTOR_Name, Me)
        _Inventory = New Inventory(Me, False)
        _Bank_Inventory = New Inventory(Me)

        _UI_Character = New UI_Character(Me, l.UI_CharactersNode)
        _UI_Inventory = New Chr_Inventory(Me, _UI_Character)
        SWTOR_Bank = New Bank(Me, _UI_Character)
    End Sub
End Class
