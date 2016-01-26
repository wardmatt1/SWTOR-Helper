Public Class Chr_Inventory
    Private _owner As SWTOR_Record
    Private _UI_ChrInventory As UI_ChrInventory
    Sub New(l As SWTOR_Record, ui As UI)
        ChrInventory_Owner = l
        _UI_ChrInventory = New UI_ChrInventory(ui, l)
    End Sub
    Public Property UI_ChrInventory As UI_ChrInventory
        Get
            Return _UI_ChrInventory
        End Get
        Set(value As UI_ChrInventory)
            _UI_ChrInventory = value
        End Set
    End Property
    Public Property ChrInventory_Owner As SWTOR_Record
        Get
            Return _owner
        End Get
        Set(value As SWTOR_Record)
            _owner = value
        End Set
    End Property
End Class
