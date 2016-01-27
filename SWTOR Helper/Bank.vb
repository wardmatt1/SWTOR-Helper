Public Class Bank
    Private _owner As SWTOR_Record
    Private _UI_bank As UI_Bank
    Private _Banktab1 As Inventory
    Private _Banktab2 As Inventory
    Private _Banktab3 As Inventory
    Private _Banktab4 As Inventory
    Private _Banktab5 As Inventory
    Sub New(Owner As SWTOR_Record, ui As UI)
        Bank_Owner = Owner
        _Banktab1 = New Inventory(Owner)
        _Banktab2 = New Inventory(Owner)
        _Banktab3 = New Inventory(Owner)
        _Banktab4 = New Inventory(Owner)
        _Banktab5 = New Inventory(Owner)

        UI_Bank = New UI_Bank(ui, Owner.SWTOR_Type, Me)
    End Sub
    Public Function banktab(tab As Byte) As Inventory
        Select Case tab + 1
            Case 1
                Return _Banktab1
            Case 2
                Return _Banktab2
            Case 3
                Return _Banktab3
            Case 4
                Return _Banktab4
            Case 5
                Return _Banktab5
        End Select
        Return Nothing
    End Function
    Public Property UI_Bank As UI_Bank
        Get
            Return _UI_bank
        End Get
        Set(value As UI_Bank)
            _UI_bank = value
        End Set
    End Property
    Public Property Bank_Owner As SWTOR_Record
        Get
            Return _owner
        End Get
        Set(value As SWTOR_Record)
            _owner = value
        End Set
    End Property
End Class
